Imports CommonClass
Imports System
Public Class FrmManageInOut
    Inherits FrmBase
    Public Status As WorkStates = MainModule.WorkStates._ReadOnly
    Public EmployeeCodVar As String = ""
    Public Action_dateVar As String
    Public TimIn_timeVar As String
    Public TimOut_timeVar As String
    Public Punch_note_codeVar As String
    Public id_punch_inVar As Decimal = 0
    Public id_punch_OutVar As Decimal = 0
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_tab_punch_note As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents LblEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents CmbPunch_note_code As System.Windows.Forms.ComboBox
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents DsFrmManageInOut1 As UCTimeSheet.DSFrmManageInOut
    Friend WithEvents DteAction_date As CalendarCombo.CalendarCombo
    Friend WithEvents TimIn_time As TimeBox.TimeBox
    Friend WithEvents TimOut_time As TimeBox.TimeBox
    Friend WithEvents BtnSaveAndExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnSaveAndNew As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmManageInOut))
        Me.Employee_Cod1 = New UCEmployee.Employee_Cod
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblEmployeeName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbPunch_note_code = New System.Windows.Forms.ComboBox
        Me.DsFrmManageInOut1 = New UCTimeSheet.DSFrmManageInOut
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DApay_tab_punch_note = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Label5 = New System.Windows.Forms.Label
        Me.DteAction_date = New CalendarCombo.CalendarCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.BtnSaveAndExit = New Janus.Windows.EditControls.UIButton
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.TimIn_time = New TimeBox.TimeBox
        Me.TimOut_time = New TimeBox.TimeBox
        Me.BtnSaveAndNew = New Janus.Windows.EditControls.UIButton
        CType(Me.DsFrmManageInOut1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Employee_Cod1
        '
        Me.Employee_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Employee_Cod1.Connection = Me.Cnn
        Me.Employee_Cod1.EmployeeCod = ""
        Me.Employee_Cod1.EmployeeCodLen = 5
        Me.Employee_Cod1.Kind_Employee = "0"
        Me.Employee_Cod1.Location = New System.Drawing.Point(80, 8)
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
        Me.Label2.Location = New System.Drawing.Point(23, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 14)
        Me.Label2.TabIndex = 383
        Me.Label2.Text = "Employee"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblEmployeeName
        '
        Me.LblEmployeeName.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.LblEmployeeName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblEmployeeName.Location = New System.Drawing.Point(183, 9)
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
        Me.Label3.Location = New System.Drawing.Point(2, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 386
        Me.Label3.Text = "Punch Note"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbPunch_note_code
        '
        Me.CmbPunch_note_code.DataSource = Me.DsFrmManageInOut1.pay_tab_punch_note
        Me.CmbPunch_note_code.DisplayMember = "punch_note_desc"
        Me.CmbPunch_note_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPunch_note_code.Location = New System.Drawing.Point(81, 66)
        Me.CmbPunch_note_code.Name = "CmbPunch_note_code"
        Me.CmbPunch_note_code.Size = New System.Drawing.Size(363, 21)
        Me.CmbPunch_note_code.TabIndex = 4
        Me.CmbPunch_note_code.ValueMember = "punch_note_code"
        '
        'DsFrmManageInOut1
        '
        Me.DsFrmManageInOut1.DataSetName = "DSFrmManageInOut"
        Me.DsFrmManageInOut1.Locale = New System.Globalization.CultureInfo("fa-IR")
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
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(43, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 14)
        Me.Label5.TabIndex = 391
        Me.Label5.Text = "Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DteAction_date
        '
        Me.DteAction_date.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteAction_date.BorderColor = System.Drawing.Color.Empty
        Me.DteAction_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteAction_date.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteAction_date.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteAction_date.EditableSal = True
        Me.DteAction_date.Image = CType(resources.GetObject("DteAction_date.Image"), System.Drawing.Image)
        Me.DteAction_date.Location = New System.Drawing.Point(81, 36)
        Me.DteAction_date.MaxValue = CType(2500, Short)
        Me.DteAction_date.MinValue = CType(1800, Short)
        Me.DteAction_date.Name = "DteAction_date"
        Me.DteAction_date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteAction_date.Sal_Mali = Nothing
        Me.DteAction_date.ShowButton = True
        Me.DteAction_date.Size = New System.Drawing.Size(110, 23)
        Me.DteAction_date.TabIndex = 1
        Me.DteAction_date.VisualStyle = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(229, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 14)
        Me.Label4.TabIndex = 397
        Me.Label4.Text = "IN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(342, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 14)
        Me.Label7.TabIndex = 399
        Me.Label7.Text = "OUT"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnSaveAndExit
        '
        Me.BtnSaveAndExit.Location = New System.Drawing.Point(333, 97)
        Me.BtnSaveAndExit.Name = "BtnSaveAndExit"
        Me.BtnSaveAndExit.Size = New System.Drawing.Size(106, 23)
        Me.BtnSaveAndExit.TabIndex = 400
        Me.BtnSaveAndExit.Text = "Save and Exit"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(13, 97)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(106, 23)
        Me.BtnCancel.TabIndex = 401
        Me.BtnCancel.Text = "Cancel"
        '
        'TimIn_time
        '
        Me.TimIn_time.BackColor = System.Drawing.SystemColors.Window
        Me.TimIn_time.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TimIn_time.Location = New System.Drawing.Point(261, 38)
        Me.TimIn_time.Name = "TimIn_time"
        Me.TimIn_time.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimIn_time.Size = New System.Drawing.Size(62, 20)
        Me.TimIn_time.TabIndex = 2
        '
        'TimOut_time
        '
        Me.TimOut_time.BackColor = System.Drawing.SystemColors.Window
        Me.TimOut_time.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TimOut_time.Location = New System.Drawing.Point(379, 38)
        Me.TimOut_time.Name = "TimOut_time"
        Me.TimOut_time.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimOut_time.Size = New System.Drawing.Size(62, 20)
        Me.TimOut_time.TabIndex = 3
        '
        'BtnSaveAndNew
        '
        Me.BtnSaveAndNew.Location = New System.Drawing.Point(173, 97)
        Me.BtnSaveAndNew.Name = "BtnSaveAndNew"
        Me.BtnSaveAndNew.Size = New System.Drawing.Size(106, 23)
        Me.BtnSaveAndNew.TabIndex = 402
        Me.BtnSaveAndNew.Text = "Save and New"
        '
        'FrmManageInOut
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(453, 126)
        Me.Controls.Add(Me.BtnSaveAndNew)
        Me.Controls.Add(Me.CmbPunch_note_code)
        Me.Controls.Add(Me.TimOut_time)
        Me.Controls.Add(Me.TimIn_time)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSaveAndExit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DteAction_date)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblEmployeeName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Employee_Cod1)
        Me.Name = "FrmManageInOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Time Sheet"
        CType(Me.DsFrmManageInOut1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmPunchClock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        DsFrmManageInOut1.Clear()
        DsFrmManageInOut1.pay_tab_punch_note.Addpay_tab_punch_noteRow("", "", 0)
        DApay_tab_punch_note.Fill(DsFrmManageInOut1, "pay_tab_punch_note")
        If EmployeeCodVar.Trim.Length = 0 Then
            Status = MainModule.WorkStates.AddNew
            DteAction_date.Text = Format(DateTime.Now, PubDateFormat.ToString)
            CmbPunch_note_code.SelectedValue = ""
        Else
            Status = MainModule.WorkStates.Edit
            BtnSaveAndNew.Enabled = False
            Employee_Cod1.EmployeeCod = EmployeeCodVar
            DteAction_date.Text = Action_dateVar
            TimIn_time.Text = TimIn_timeVar
            TimOut_time.Text = TimOut_timeVar
            CmbPunch_note_code.Text = Punch_note_codeVar
        End If
    End Sub
    Private Sub Employee_Cod1_NotFindEmployeeCod() Handles Employee_Cod1.NotFindEmployeeCod
        LblEmployeeName.Text = ""
        Call EnableDisableSave()
    End Sub
    Private Sub Employee_Cod1_FindEmployeeCod() Handles Employee_Cod1.FindEmployeeCod
        LblEmployeeName.Text = Employee_Cod1.Desc_Employee
        Call EnableDisableSave()
    End Sub
    Private Sub BtnSaveAndExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveAndExit.Click
        Call Save(True)
    End Sub
    Private Sub BtnSaveAndNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveAndNew.Click
        Call Save(False)
    End Sub
    Private Sub Save(ByVal ThisExitFlag As Boolean)
        If TimIn_time.Text > TimOut_time.Text Then
            MsgBox("OUT time Should be greater then IN time")
            Exit Sub
        End If
        If ClockINConflict() Then
            Exit Sub
        End If
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            If Status = MainModule.WorkStates.AddNew Or id_punch_inVar = 0 Then
                CmdGeneral.CommandText = "INSERT INTO pay_punch_employee_in_out " & _
                                         "(employee_code, action_date, action_time_hour, action_time_Minute, punch_note_code,In_Out_type) Values " & _
                                         "(" & Qt(Employee_Cod1.EmployeeCod) & "," & Qt(DteAction_date.Text) & "," & Qt(TimIn_time.TxtHour.Text) & "," & Qt(TimIn_time.TxtMinute.Text) & "," & Qt(CmbPunch_note_code.Text) & ",0 )"
                CmdGeneral.ExecuteNonQuery()
            Else
                CmdGeneral.CommandText = "Update pay_punch_employee_in_out Set " & _
                                         "employee_code=" & Qt(Employee_Cod1.EmployeeCod) & ", action_date=" & Qt(DteAction_date.Text) & ", action_time_hour=" & Qt(TimIn_time.TxtHour.Text) & ", action_time_Minute=" & Qt(TimIn_time.TxtMinute.Text) & ", punch_note_code=" & Qt(CmbPunch_note_code.Text) & ",In_Out_type=0 " & _
                                         " Where id_punch_in_out=" & id_punch_inVar
                CmdGeneral.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox("This Employee has record For the same date and time")
            Exit Sub
        End Try
        If ClockOUTConflict() Then
            Exit Sub
        End If
        Try
            If Status = MainModule.WorkStates.AddNew Or id_punch_OutVar = 0 Then
                CmdGeneral.CommandText = "INSERT INTO pay_punch_employee_in_out " & _
                                         "(employee_code, action_date, action_time_hour, action_time_Minute, punch_note_code,In_Out_type) Values " & _
                                         "(" & Qt(Employee_Cod1.EmployeeCod) & "," & Qt(DteAction_date.Text) & "," & Qt(TimOut_time.TxtHour.Text) & "," & Qt(TimOut_time.TxtMinute.Text) & "," & Qt(CmbPunch_note_code.Text) & ",1 )"
                CmdGeneral.ExecuteNonQuery()
                TimIn_time.Text = "00:00"
                TimOut_time.Text = "00:00"
                CmbPunch_note_code.Text = ""
                Employee_Cod1.Focus()
            Else
                CmdGeneral.CommandText = "Update pay_punch_employee_in_out Set " & _
                                         "employee_code=" & Qt(Employee_Cod1.EmployeeCod) & ", action_date=" & Qt(DteAction_date.Text) & ", action_time_hour=" & Qt(TimOut_time.TxtHour.Text) & ", action_time_Minute=" & Qt(TimOut_time.TxtMinute.Text) & ", punch_note_code=" & Qt(CmbPunch_note_code.Text) & ",In_Out_type=1 " & _
                                         " Where id_punch_in_out=" & id_punch_OutVar
                CmdGeneral.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox("This Employee has record For the same date and time")
            Exit Sub
        End Try
        If Status <> MainModule.WorkStates.AddNew Then
            If ThisExitFlag Then
                Me.Close()
            Else
                TimIn_time.Text = "00:00"
                TimOut_time.Text = "00:00"
                CmbPunch_note_code.Text = ""
                Employee_Cod1.Focus()
            End If
        End If
    End Sub
    'Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
    '    If TimIn_time.Text > TimOut_time.Text Then
    '        MsgBox("OUT time Should be greater then IN time")
    '        Exit Sub
    '    End If
    '    CmdGeneral.CommandText = "Delete pay_punch_employee_in_out  Where id_punch_in_out=" & id_punch_inVar
    '    CmdGeneral.ExecuteNonQuery()
    '    CmdGeneral.CommandText = "Delete pay_punch_employee_in_out  Where id_punch_in_out=" & id_punch_OutVar
    '    CmdGeneral.ExecuteNonQuery()
    '    If ClockINConflict() Then
    '        Exit Sub
    '    End If
    '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '        CmdGeneral.Connection.Open()
    '    End If
    '    Try
    '        CmdGeneral.CommandText = "INSERT INTO pay_punch_employee_in_out " & _
    '                                 "(employee_code, action_date, action_time_hour, action_time_Minute, punch_note_code,In_Out_type) Values " & _
    '                                 "(" & Qt(Employee_Cod1.EmployeeCod) & "," & Qt(DteAction_date.Text) & "," & Qt(TimIn_time.TxtHour.Text) & "," & Qt(TimIn_time.TxtMinute.Text) & "," & Qt(CmbPunch_note_code.Text) & ",0 )"
    '        CmdGeneral.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MsgBox("This Employee has record For the same date and time")
    '        Exit Sub
    '    End Try
    '    If ClockOUTConflict() Then
    '        Exit Sub
    '    End If
    '    Try
    '        CmdGeneral.CommandText = "INSERT INTO pay_punch_employee_in_out " & _
    '                                 "(employee_code, action_date, action_time_hour, action_time_Minute, punch_note_code,In_Out_type) Values " & _
    '                                 "(" & Qt(Employee_Cod1.EmployeeCod) & "," & Qt(DteAction_date.Text) & "," & Qt(TimOut_time.TxtHour.Text) & "," & Qt(TimOut_time.TxtMinute.Text) & "," & Qt(CmbPunch_note_code.Text) & ",1 )"
    '        CmdGeneral.ExecuteNonQuery()
    '        TimIn_time.Text = "00:00"
    '        TimOut_time.Text = "00:00"
    '        CmbPunch_note_code.Text = ""
    '        Employee_Cod1.Focus()
    '    Catch ex As Exception
    '        MsgBox("This Employee has record For the same date and time")
    '        Exit Sub
    '    End Try
    '    If Status <> MainModule.WorkStates.AddNew Then
    '        Me.Close()
    '    End If
    'End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub DteAction_date_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DteAction_date.TextChanged, TimIn_time.TextChanged, TimOut_time.TextChanged, CmbPunch_note_code.TextChanged
        Call EnableDisableSave()
    End Sub
    Private Sub EnableDisableSave()
        If LblEmployeeName.Text.Trim.Length > 0 And DteAction_date.Text.Trim.Length = 10 Then
            BtnSaveAndExit.Enabled = True
            If Status = MainModule.WorkStates.AddNew Then
                BtnSaveAndNew.Enabled = True
            End If
        Else
            BtnSaveAndExit.Enabled = False
            If Status = MainModule.WorkStates.AddNew Then
                BtnSaveAndNew.Enabled = False
            End If
        End If
    End Sub
    Private Function ClockINConflict() As Boolean
        ClockINConflict = False
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 in_out_type from pay_punch_employee_in_out where Employee_Code=" & Qt(Employee_Cod1.cod_Employee) & " AND action_date=" & Qt(DteAction_date.Text) & _
        " AND id_punch_in_out<>" & id_punch_inVar & " AND id_punch_in_out<>" & id_punch_OutVar & " AND action_time_hour+':'+action_time_Minute<=" & Qt(Mid(TimIn_time.Text, 1, 5)) & " Order by action_time_hour+':'+action_time_Minute Desc "
        If CmdGeneral.ExecuteScalar() & "" = "0" Then
            MsgBox("Conflict in IN Time.", MsgBoxStyle.Exclamation)
            ClockINConflict = True
            Exit Function
        End If
        CmdGeneral.CommandText = "SELECT Top 1 in_out_type from pay_punch_employee_in_out where Employee_Code=" & Qt(Employee_Cod1.cod_Employee) & " AND action_date=" & Qt(DteAction_date.Text) & _
        " AND id_punch_in_out<>" & id_punch_inVar & " AND id_punch_in_out<>" & id_punch_OutVar & " AND action_time_hour+':'+action_time_Minute>=" & Qt(Mid(TimIn_time.Text, 1, 5)) & " Order by action_time_hour+':'+action_time_Minute ASC"
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

        CmdGeneral.CommandText = "SELECT Top 1 in_out_type from pay_punch_employee_in_out where Employee_Code=" & Qt(Employee_Cod1.cod_Employee) & " AND action_date=" & Qt(DteAction_date.Text) & _
        " AND id_punch_in_out<>" & id_punch_OutVar & " AND action_time_hour+':'+action_time_Minute<=" & Qt(Mid(TimOut_time.Text, 1, 5)) & " Order by action_time_hour+':'+action_time_Minute Desc"
        If CmdGeneral.ExecuteScalar() & "" = "1" Then
            MsgBox("Conflict in Out Time.", MsgBoxStyle.Exclamation)
            ClockOUTConflict = True
            Exit Function
        End If
        CmdGeneral.CommandText = "SELECT Top 1 in_out_type from pay_punch_employee_in_out where Employee_Code=" & Qt(Employee_Cod1.cod_Employee) & " AND action_date=" & Qt(DteAction_date.Text) & _
        " AND id_punch_in_out<>" & id_punch_OutVar & " AND action_time_hour+':'+action_time_Minute>=" & Qt(Mid(TimOut_time.Text, 1, 5)) & " Order by action_time_hour+':'+action_time_Minute ASC"
        If CmdGeneral.ExecuteScalar() & "" = "1" Then
            MsgBox("Conflict in Out Time.", MsgBoxStyle.Exclamation)
            ClockOUTConflict = True
            Exit Function
        End If
    End Function
End Class
