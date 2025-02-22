Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmEmployeeInOutBoard
    Inherits FrmBase
    Dim DApay_punch_employee_in_outOriginalVar = ""
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
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsFrmEmployeeInOutBoard1 As UCTimeSheet.DSFrmEmployeeInOutBoard
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DApay_punch_employee_in_out As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkMonthly As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents LblEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents DteAction_date As CalendarCombo.CalendarCombo
    Friend WithEvents Employee_Cod1 As UCEmployee.Employee_Cod
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEmployeeInOutBoard))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEmployeeInOutBoard1 = New UCTimeSheet.DSFrmEmployeeInOutBoard
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DteAction_date = New CalendarCombo.CalendarCombo
        Me.DApay_punch_employee_in_out = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.BtnFind = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.ChkMonthly = New Janus.Windows.EditControls.UICheckBox
        Me.LblEmployeeName = New System.Windows.Forms.TextBox
        Me.Employee_Cod1 = New UCEmployee.Employee_Cod
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEmployeeInOutBoard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.DataMember = "pay_punch_employee_in_out"
        Me.GridEX1.DataSource = Me.DsFrmEmployeeInOutBoard1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><AllowEdit>False</AllowEdit><Caption>pay_punch_emplo" & _
        "yee_in_out</Caption><Columns Collection=""true""><Column0 ID=""id_punch_in_out""><Ca" & _
        "ption>id_punch_in_out</Caption><TypeNameEmptyStringValue>NULL</TypeNameEmptyStri" & _
        "ngValue><EmptyStringValue /><DataMember>id_punch_in_out</DataMember><EditType>No" & _
        "Edit</EditType><Key>id_punch_in_out</Key><Position>0</Position><Visible>False</V" & _
        "isible></Column0><Column1 ID=""IN""><Bound>False</Bound><Caption>IN</Caption><Colu" & _
        "mnType>Image</ColumnType><EditType>NoEdit</EditType><Key>IN</Key><Position>1</Po" & _
        "sition><Width>37</Width></Column1><Column2 ID=""OUT""><Bound>False</Bound><Caption" & _
        ">OUT</Caption><ColumnType>Image</ColumnType><EditType>NoEdit</EditType><Key>OUT<" & _
        "/Key><Position>2</Position><Width>38</Width></Column2><Column3 ID=""employee_code" & _
        """><Caption>Code</Caption><DataMember>employee_code</DataMember><Key>employee_cod" & _
        "e</Key><Position>3</Position><Width>52</Width></Column3><Column4 ID=""EmployeeFul" & _
        "lName""><Caption>Employee Name</Caption><DataMember>EmployeeFullName</DataMember>" & _
        "<EditType>NoEdit</EditType><Key>EmployeeFullName</Key><Position>4</Position><Wid" & _
        "th>138</Width></Column4><Column5 ID=""action_date""><Caption>Date</Caption><DataMe" & _
        "mber>action_date</DataMember><Key>action_date</Key><Position>5</Position><Width>" & _
        "71</Width></Column5><Column6 ID=""action_time""><Caption>Time</Caption><DataMember" & _
        ">action_time</DataMember><DefaultGroupFormatString>d</DefaultGroupFormatString><" & _
        "EditType>CalendarCombo</EditType><InputMask>00:00</InputMask><Key>action_time</K" & _
        "ey><Position>6</Position><Width>57</Width><FormatMode>UseInputMask</FormatMode><" & _
        "/Column6><Column7 ID=""punch_note_code""><Caption>Note</Caption><DataMember>punch_" & _
        "note_code</DataMember><Key>punch_note_code</Key><Position>7</Position><Width>159" & _
        "</Width></Column7><Column8 ID=""In_Out_type""><Caption>In_Out_type</Caption><DataM" & _
        "ember>In_Out_type</DataMember><Key>In_Out_type</Key><Position>8</Position><Visib" & _
        "le>False</Visible></Column8></Columns><GroupCondition ID="""" /><Key>pay_punch_emp" & _
        "loyee_in_out</Key><RowHeaderWidth>19</RowHeaderWidth></RootTable></GridEXLayoutD" & _
        "ata>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.ExternalImageList = Me.ImageList1
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.Location = New System.Drawing.Point(0, 59)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(578, 393)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEmployeeInOutBoard1
        '
        Me.DsFrmEmployeeInOutBoard1.DataSetName = "DSFrmEmployeeInOutBoard"
        Me.DsFrmEmployeeInOutBoard1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(33, 33)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
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
        Me.DteAction_date.Location = New System.Drawing.Point(203, 32)
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
        'DApay_punch_employee_in_out
        '
        Me.DApay_punch_employee_in_out.DeleteCommand = Me.SqlDeleteCommand1
        Me.DApay_punch_employee_in_out.InsertCommand = Me.SqlInsertCommand1
        Me.DApay_punch_employee_in_out.SelectCommand = Me.SqlSelectCommand1
        Me.DApay_punch_employee_in_out.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_punch_employee_in_out", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_punch_in_out", "id_punch_in_out"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("action_date", "action_date"), New System.Data.Common.DataColumnMapping("action_time_Hour", "action_time_Hour"), New System.Data.Common.DataColumnMapping("action_time_Minute", "action_time_Minute"), New System.Data.Common.DataColumnMapping("punch_note_code", "punch_note_code"), New System.Data.Common.DataColumnMapping("In_Out_type", "In_Out_type")})})
        Me.DApay_punch_employee_in_out.UpdateCommand = Me.SqlUpdateCommand1
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
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT pay_punch_employee_in_out.id_punch_in_out, pay_punch_employee_in_out.emplo" & _
        "yee_code, pay_punch_employee_in_out.action_date, pay_punch_employee_in_out.actio" & _
        "n_time_hour + ':' + pay_punch_employee_in_out.action_time_minute AS action_time," & _
        " pay_punch_employee_in_out.punch_note_code, pay_punch_employee_in_out.in_out_typ" & _
        "e, employee.f_name + ' ' + employee.m_name + ' ' + employee.l_name AS EmployeeFu" & _
        "llName FROM pay_punch_employee_in_out INNER JOIN employee ON pay_punch_employee_" & _
        "in_out.employee_code = employee.employee_code"
        Me.SqlSelectCommand1.Connection = Me.Cnn
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
        'BtnFind
        '
        Me.BtnFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.ForeColor = System.Drawing.Color.Black
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(537, 29)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 29)
        Me.BtnFind.TabIndex = 399
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(480, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 400
        Me.Label3.Text = "Referesh"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkMonthly
        '
        Me.ChkMonthly.Location = New System.Drawing.Point(21, 34)
        Me.ChkMonthly.Name = "ChkMonthly"
        Me.ChkMonthly.Size = New System.Drawing.Size(60, 23)
        Me.ChkMonthly.TabIndex = 401
        Me.ChkMonthly.Text = "Monthly"
        Me.ChkMonthly.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        '
        'LblEmployeeName
        '
        Me.LblEmployeeName.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.LblEmployeeName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblEmployeeName.Location = New System.Drawing.Point(112, 6)
        Me.LblEmployeeName.MaxLength = 100
        Me.LblEmployeeName.Name = "LblEmployeeName"
        Me.LblEmployeeName.ReadOnly = True
        Me.LblEmployeeName.Size = New System.Drawing.Size(458, 21)
        Me.LblEmployeeName.TabIndex = 395
        Me.LblEmployeeName.TabStop = False
        Me.LblEmployeeName.Text = ""
        '
        'Employee_Cod1
        '
        Me.Employee_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Employee_Cod1.Connection = Me.Cnn
        Me.Employee_Cod1.EmployeeCod = ""
        Me.Employee_Cod1.EmployeeCodLen = 5
        Me.Employee_Cod1.Location = New System.Drawing.Point(6, 6)
        Me.Employee_Cod1.Name = "Employee_Cod1"
        Me.Employee_Cod1.NotExitIfNotFound = False
        Me.Employee_Cod1.ReleaseIfNotFoundEmployeeCod = False
        Me.Employee_Cod1.Size = New System.Drawing.Size(101, 20)
        Me.Employee_Cod1.TabIndex = 402
        '
        'FrmEmployeeInOutBoard
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(578, 452)
        Me.Controls.Add(Me.Employee_Cod1)
        Me.Controls.Add(Me.ChkMonthly)
        Me.Controls.Add(Me.BtnFind)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblEmployeeName)
        Me.Controls.Add(Me.DteAction_date)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEmployeeInOutBoard"
        Me.Text = "Employee IN/OUT Board"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEmployeeInOutBoard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmEmployeeInOutBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        DApay_punch_employee_in_outOriginalVar = DApay_punch_employee_in_out.SelectCommand.CommandText
        DteAction_date.Text = Format(DateTime.Now, PubDateFormat.ToString)
        Employee_Cod1.Kind_Employee = 0
    End Sub
    Private Sub gridEX1_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEX1.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If e.Row.Cells("IN_Out_type").Value = 0 Then
                e.Row.Cells("IN").ImageIndex = 0
                e.Row.Cells("IN").ToolTipText = "IN"
            End If
            If e.Row.Cells("IN_Out_type").Value = 1 Then
                e.Row.Cells("OUT").ImageIndex = 1
                e.Row.Cells("OUT").ToolTipText = "OUT"
            End If
        End If
    End Sub
    Private Sub Employee_Cod1_NotFindEmployeeCod() Handles Employee_Cod1.NotFindEmployeeCod
        LblEmployeeName.Text = ""
        Call FillDataset()
    End Sub
    Private Sub Employee_Cod1_FindEmployeeCod() Handles Employee_Cod1.FindEmployeeCod
        LblEmployeeName.Text = Employee_Cod1.Desc_Employee
        Call FillDataset()
    End Sub
    Private Sub ChkMonthly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkMonthly.CheckedChanged
        Call FillDataset()
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Call FillDataset()
    End Sub
    Private Sub DteAction_date_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DteAction_date.TextChanged
        Call FillDataset()
    End Sub
    Private Sub DteAction_date_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DteAction_date.Leave
        Call FillDataset()
    End Sub
    Private Sub FillDataset()
        Try

            DsFrmEmployeeInOutBoard1.Clear()
            If Trim(DApay_punch_employee_in_outOriginalVar).Length > 0 Then
                If LblEmployeeName.Text.Trim.Length > 0 Then
                    If ChkMonthly.Checked Then
                        If Mid(DteAction_date.Text, 1, 4).Trim.Length > 0 Then
                            DApay_punch_employee_in_out.SelectCommand.CommandText = DApay_punch_employee_in_outOriginalVar & " Where pay_punch_employee_in_out.employee_code=" & Qt(Employee_Cod1.EmployeeCod) & " AND SUBSTRING(action_date,1,2)=" & Qt(Mid(DteAction_date.Text, 1, 2)) & " AND SUBSTRING(action_date,7,4)=" & Qt(Mid(DteAction_date.Text, 7, 4))
                        Else
                            DApay_punch_employee_in_out.SelectCommand.CommandText = DApay_punch_employee_in_outOriginalVar & " Where pay_punch_employee_in_out.employee_code=" & Qt(Employee_Cod1.EmployeeCod)
                        End If
                    Else
                        If Mid(DteAction_date.Text, 1, 4).Trim.Length > 0 Then
                            DApay_punch_employee_in_out.SelectCommand.CommandText = DApay_punch_employee_in_outOriginalVar & " Where pay_punch_employee_in_out.employee_code=" & Qt(Employee_Cod1.EmployeeCod) & " AND action_date=" & Qt(DteAction_date.Text)
                        Else
                            DApay_punch_employee_in_out.SelectCommand.CommandText = DApay_punch_employee_in_outOriginalVar & " Where pay_punch_employee_in_out.employee_code=" & Qt(Employee_Cod1.EmployeeCod)
                        End If
                    End If
                Else
                    If ChkMonthly.Checked Then
                        If Mid(DteAction_date.Text, 1, 4).Trim.Length > 0 Then
                            DApay_punch_employee_in_out.SelectCommand.CommandText = DApay_punch_employee_in_outOriginalVar & " Where  SUBSTRING(action_date,1,2)=" & Qt(Mid(DteAction_date.Text, 1, 2)) & " AND SUBSTRING(action_date,7,4)=" & Qt(Mid(DteAction_date.Text, 7, 4))
                        Else
                            DApay_punch_employee_in_out.SelectCommand.CommandText = DApay_punch_employee_in_outOriginalVar
                        End If
                    Else
                        If Mid(DteAction_date.Text, 1, 4).Trim.Length > 0 Then
                            DApay_punch_employee_in_out.SelectCommand.CommandText = DApay_punch_employee_in_outOriginalVar & " Where action_date=" & Qt(DteAction_date.Text)
                        Else
                            DApay_punch_employee_in_out.SelectCommand.CommandText = DApay_punch_employee_in_outOriginalVar
                        End If
                    End If
                End If
                DApay_punch_employee_in_out.Fill(DsFrmEmployeeInOutBoard1, "pay_punch_employee_in_out")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
