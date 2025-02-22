Imports TimeBox
Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmEmployeePunchClockCorrection
    Inherits FrmBase
    Dim DApay_punch_employee_in_outOriginalVar
    Dim So As New Janus.Windows.GridEX.SortOrder
    Dim MyClsTime As New ClsTime
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DApay_punch_employee_in_out As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents QuickAddItem As System.Windows.Forms.Button
    Friend WithEvents DsFrmEmployeePunchClockCorrection1 As UCTimeSheet.DSFrmEmployeePunchClockCorrection
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmdRowDetail As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DteMinDate As CalendarCombo.CalendarCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DteMaxDate As CalendarCombo.CalendarCombo
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEmployeePunchClockCorrection))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.DsFrmEmployeePunchClockCorrection1 = New UCTimeSheet.DSFrmEmployeePunchClockCorrection
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DApay_punch_employee_in_out = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.DteMaxDate = New CalendarCombo.CalendarCombo
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.CmdRowDetail = New System.Windows.Forms.Button
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.DteMinDate = New CalendarCombo.CalendarCombo
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.QuickAddItem = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        CType(Me.DsFrmEmployeePunchClockCorrection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsFrmEmployeePunchClockCorrection1
        '
        Me.DsFrmEmployeePunchClockCorrection1.DataSetName = "DSFrmEmployeePunchClockCorrection"
        Me.DsFrmEmployeePunchClockCorrection1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(33, 33)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=TireMate_01"
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
        Me.SqlSelectCommand1.CommandText = "SELECT pay_punch_employee_in_out.id_punch_in_out AS id_punch_in, pay_punch_employ" & _
        "ee_in_out.id_punch_in_out AS id_punch_out, pay_punch_employee_in_out.employee_co" & _
        "de, pay_punch_employee_in_out.action_time_Hour + ':' + pay_punch_employee_in_out" & _
        ".action_time_Minute AS In_Time, pay_punch_employee_in_out.action_date, pay_punch" & _
        "_employee_in_out.punch_note_code, '     ' AS Out_Time, '     ' AS Hours, employe" & _
        "e.l_name + ' ' + employee.m_name + ' ' + employee.f_name AS EmployeeFullName FRO" & _
        "M pay_punch_employee_in_out LEFT OUTER JOIN employee ON pay_punch_employee_in_ou" & _
        "t.employee_code = employee.employee_code"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DteMaxDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.CmdRowDetail)
        Me.Panel1.Controls.Add(Me.BtnRefresh)
        Me.Panel1.Controls.Add(Me.DteMinDate)
        Me.Panel1.Controls.Add(Me.CheckBox4)
        Me.Panel1.Controls.Add(Me.QuickAddItem)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 40)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(338, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 403
        Me.Label2.Text = "To"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DteMaxDate
        '
        Me.DteMaxDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteMaxDate.BorderColor = System.Drawing.Color.Empty
        Me.DteMaxDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteMaxDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteMaxDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteMaxDate.EditableSal = True
        Me.DteMaxDate.Image = CType(resources.GetObject("DteMaxDate.Image"), System.Drawing.Image)
        Me.DteMaxDate.Location = New System.Drawing.Point(374, 7)
        Me.DteMaxDate.MaxValue = CType(2500, Short)
        Me.DteMaxDate.MinValue = CType(1800, Short)
        Me.DteMaxDate.Name = "DteMaxDate"
        Me.DteMaxDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteMaxDate.Sal_Mali = Nothing
        Me.DteMaxDate.ShowButton = True
        Me.DteMaxDate.Size = New System.Drawing.Size(110, 23)
        Me.DteMaxDate.TabIndex = 402
        Me.DteMaxDate.VisualStyle = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(189, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 14)
        Me.Label1.TabIndex = 401
        Me.Label1.Text = "From"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnDelete
        '
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(156, 8)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(24, 24)
        Me.BtnDelete.TabIndex = 400
        '
        'CmdRowDetail
        '
        Me.CmdRowDetail.Image = CType(resources.GetObject("CmdRowDetail.Image"), System.Drawing.Image)
        Me.CmdRowDetail.Location = New System.Drawing.Point(128, 8)
        Me.CmdRowDetail.Name = "CmdRowDetail"
        Me.CmdRowDetail.Size = New System.Drawing.Size(24, 24)
        Me.CmdRowDetail.TabIndex = 399
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.Black
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.Location = New System.Drawing.Point(540, 6)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(33, 29)
        Me.BtnRefresh.TabIndex = 397
        '
        'DteMinDate
        '
        Me.DteMinDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteMinDate.BorderColor = System.Drawing.Color.Empty
        Me.DteMinDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteMinDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteMinDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteMinDate.EditableSal = True
        Me.DteMinDate.Image = CType(resources.GetObject("DteMinDate.Image"), System.Drawing.Image)
        Me.DteMinDate.Location = New System.Drawing.Point(225, 8)
        Me.DteMinDate.MaxValue = CType(2500, Short)
        Me.DteMinDate.MinValue = CType(1800, Short)
        Me.DteMinDate.Name = "DteMinDate"
        Me.DteMinDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteMinDate.Sal_Mali = Nothing
        Me.DteMinDate.ShowButton = True
        Me.DteMinDate.Size = New System.Drawing.Size(110, 23)
        Me.DteMinDate.TabIndex = 396
        Me.DteMinDate.VisualStyle = False
        '
        'CheckBox4
        '
        Me.CheckBox4.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Image = CType(resources.GetObject("CheckBox4.Image"), System.Drawing.Image)
        Me.CheckBox4.Location = New System.Drawing.Point(100, 8)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(24, 24)
        Me.CheckBox4.TabIndex = 9
        '
        'QuickAddItem
        '
        Me.QuickAddItem.BackColor = System.Drawing.SystemColors.Control
        Me.QuickAddItem.Location = New System.Drawing.Point(8, 8)
        Me.QuickAddItem.Name = "QuickAddItem"
        Me.QuickAddItem.Size = New System.Drawing.Size(88, 23)
        Me.QuickAddItem.TabIndex = 0
        Me.QuickAddItem.Text = "Add New Item"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(486, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 398
        Me.Label3.Text = "Referesh"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "pay_punch_employee_in_out"
        Me.GridEX1.DataSource = Me.DsFrmEmployeePunchClockCorrection1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><AllowEdit>False</AllowEdit><Caption>pay_punch_emplo" & _
        "yee_in_out</Caption><Columns Collection=""true""><Column0 ID=""Icon""><AllowSize>Fal" & _
        "se</AllowSize><AllowSort>False</AllowSort><Bound>False</Bound><ButtonStyle>Butto" & _
        "nCell</ButtonStyle><ColumnType>Image</ColumnType><EditType>NoEdit</EditType><Key" & _
        ">Icon</Key><Position>0</Position><Width>20</Width></Column0><Column1 ID=""id_punc" & _
        "h_in_out""><Caption>id_punch_in_out</Caption><TypeNameEmptyStringValue>NULL</Type" & _
        "NameEmptyStringValue><EmptyStringValue /><DataMember>id_punch_in</DataMember><Ed" & _
        "itType>NoEdit</EditType><Key>id_punch_in_out</Key><Position>1</Position><Visible" & _
        ">False</Visible></Column1><Column2 ID=""id_punch_out""><Caption>id_punch_out</Capt" & _
        "ion><DataMember>id_punch_out</DataMember><Key>id_punch_out</Key><Position>2</Pos" & _
        "ition><Visible>False</Visible></Column2><Column3 ID=""EmployeeFullName""><Caption>" & _
        "Employee</Caption><DataMember>EmployeeFullName</DataMember><EditType>NoEdit</Edi" & _
        "tType><Key>EmployeeFullName</Key><Position>3</Position><Width>253</Width></Colum" & _
        "n3><Column4 ID=""In_Time""><Caption>IN</Caption><DataMember>In_Time</DataMember><E" & _
        "ditType>NoEdit</EditType><Key>In_Time</Key><Position>4</Position><Width>53</Widt" & _
        "h></Column4><Column5 ID=""Out_Time""><Caption>OUT</Caption><DataMember>Out_Time</D" & _
        "ataMember><EditType>NoEdit</EditType><Key>Out_Time</Key><Position>5</Position><W" & _
        "idth>51</Width></Column5><Column6 ID=""Hours""><AggregateFunction>Sum</AggregateFu" & _
        "nction><Caption>Hours</Caption><DataMember>Hours</DataMember><EditType>NoEdit</E" & _
        "ditType><Key>Hours</Key><Position>6</Position><Width>52</Width><TotalFormatStrin" & _
        "g>###:##</TotalFormatString></Column6><Column7 ID=""action_date""><Caption>Date</C" & _
        "aption><DataMember>action_date</DataMember><EditType>NoEdit</EditType><Key>actio" & _
        "n_date</Key><Position>7</Position><Width>91</Width></Column7><Column8 ID=""punch_" & _
        "note_code""><Caption>Note</Caption><DataMember>punch_note_code</DataMember><EditT" & _
        "ype>NoEdit</EditType><Key>punch_note_code</Key><Position>8</Position><Visible>Fa" & _
        "lse</Visible><Width>116</Width></Column8><Column9 ID=""employee_code""><Caption>em" & _
        "ployee_code</Caption><DataMember>employee_code</DataMember><EditType>NoEdit</Edi" & _
        "tType><Key>employee_code</Key><Position>9</Position><Visible>False</Visible></Co" & _
        "lumn9><Column10 ID=""TotalHours""><Caption>Employee :</Caption><DataMember>TotalHo" & _
        "urs</DataMember><Key>TotalHours</Key><Position>10</Position><Visible>False</Visi" & _
        "ble></Column10><Column11 ID=""TotalDate""><Caption>TotalDate</Caption><DataMember>" & _
        "TotalDate</DataMember><Key>TotalDate</Key><Position>11</Position><Visible>False<" & _
        "/Visible></Column11></Columns><GroupCondition ID="""" /><Groups Collection=""true"">" & _
        "<Group0 ID=""Group0""><ColIndex>10</ColIndex><HeaderCaption>Emplyee</HeaderCaption" & _
        "><GroupInterval>Value</GroupInterval></Group0><Group1 ID=""Group1""><ColIndex>11</" & _
        "ColIndex><GroupPrefix>Date ::</GroupPrefix><HeaderCaption>Date</HeaderCaption><G" & _
        "roupInterval>Value</GroupInterval></Group1></Groups><Key>pay_punch_employee_in_o" & _
        "ut</Key><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>7</ColInde" & _
        "x></SortKey0><SortKey1 ID=""SortKey1""><ColIndex>4</ColIndex></SortKey1></SortKeys" & _
        "></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.ExternalImageList = Me.ImageList2
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.Location = New System.Drawing.Point(0, 40)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(578, 412)
        Me.GridEX1.TabIndex = 2
        '
        'ImageList2
        '
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'FrmEmployeePunchClockCorrection
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(578, 452)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmEmployeePunchClockCorrection"
        Me.Text = "Employee Punch Clock Correction"
        CType(Me.DsFrmEmployeePunchClockCorrection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmEmployeeInOutBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        DApay_punch_employee_in_outOriginalVar = DApay_punch_employee_in_out.SelectCommand.CommandText
        DteMinDate.Text = Format(DateTime.Now, PubDateFormat.ToString)
        DteMaxDate.Text = Format(DateTime.Now, PubDateFormat.ToString)
        Call AddConditionalFormatting()
    End Sub
    Private Sub AddConditionalFormatting()
        Dim fc As GridEXFormatCondition
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GridEX1.RootTable.Columns("Hours"), ConditionOperator.NotContains, ":")
        fc.FormatStyle.BackColor = Color.Yellow
        GridEX1.RootTable.FormatConditions.Add(fc)
    End Sub
    Private Sub gridEX1_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEX1.FormattingRow
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
    Private Sub QuickAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickAddItem.Click
        Dim FrmAddnew As New FrmManageInOut
        FrmAddnew.Cnn.ConnectionString = PConnectionString
        FrmAddnew.Status = MainModule.WorkStates.AddNew
        FrmAddnew.ShowDialog()
        Call FillDataset()
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        GridEX1.GroupByBoxVisible = CheckBox4.Checked
    End Sub
    Private Sub FillDataset()
        DsFrmEmployeePunchClockCorrection1.pay_punch_employee_in_out.Clear()
        DApay_punch_employee_in_out.SelectCommand.CommandText = DApay_punch_employee_in_outOriginalVar & " Where In_Out_type=0 AND dbo.changedate(action_date)>=" & Qt(ChangeDateToYYYYMMDD(DteMinDate.Text)) & " AND dbo.changedate(action_date)<=" & Qt(ChangeDateToYYYYMMDD(DteMaxDate.Text)) & " Order by pay_punch_employee_in_out.employee_code"
        DApay_punch_employee_in_out.Fill(DsFrmEmployeePunchClockCorrection1, "pay_punch_employee_in_out")
        With DsFrmEmployeePunchClockCorrection1.pay_punch_employee_in_out
            If .Rows.Count > 0 Then
                Dim i As Integer
                Dim OutTimeVar As String
                Dim Id_punch_outVar As Decimal
                Dim SQLReader As System.Data.SqlClient.SqlDataReader
                Dim ThisEmpoyee As String = ""
                Dim ThisDate As String = ""
                Dim TotalEmployeeHoursVar As String = "000:00"
                Dim TotalOneDateHoursVar As String = "000:00"
                Dim ChangeEmployeeFlag As Boolean = False
                Dim ChangeDateFlag As Boolean = False
                For i = 0 To .Rows.Count - 1
                    If ThisEmpoyee <> .Rows(i).Item("employee_code") Or ThisDate <> .Rows(i).Item("action_date") Then
                        ThisDate = .Rows(i).Item("action_date")
                        TotalOneDateHoursVar = "000:00"
                    End If
                    If ThisEmpoyee <> .Rows(i).Item("employee_code") Then
                        ThisEmpoyee = .Rows(i).Item("employee_code")
                        TotalEmployeeHoursVar = "000:00"
                    End If

                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.CommandText = "select top 1 id_punch_in_out,action_time_Hour + ':' + action_time_Minute as TimeOut From pay_punch_employee_in_out " & _
                                         "Where employee_code=" & Qt(.Rows(i).Item("employee_code")) & " AND action_date=" & Qt(.Rows(i).Item("action_date")) & " AND In_Out_Type=1 AND action_time_Hour+':'+action_time_Minute>" & Qt(.Rows(i).Item("In_Time")) & " " & _
                                         "Order by action_time_Hour + ':' + action_time_Minute ASC"
                    SQLReader = CmdGeneral.ExecuteReader
                    If SQLReader.HasRows Then
                        SQLReader.Read()
                        OutTimeVar = SQLReader.Item("TimeOut")
                        Id_punch_outVar = SQLReader.Item("id_punch_in_out")
                    Else
                        OutTimeVar = ""
                        Id_punch_outVar = 0
                    End If
                    SQLReader.Close()
                    .Rows(i).Item("id_punch_out") = Id_punch_outVar
                    .Rows(i).Item("Out_time") = OutTimeVar
                    .Rows(i).Item("Hours") = MyClsTime.SubtractTime(.Rows(i).Item("Out_time"), .Rows(i).Item("In_time"))

                    If ThisEmpoyee = .Rows(i).Item("employee_code") Then
                        TotalEmployeeHoursVar = MyClsTime.AddTime(TotalEmployeeHoursVar, .Rows(i).Item("Hours"))
                    Else
                        ChangeEmployeeFlag = True
                    End If
                    If ThisEmpoyee = .Rows(i).Item("employee_code") And ThisDate = .Rows(i).Item("action_date") Then
                        TotalOneDateHoursVar = MyClsTime.AddTime(TotalOneDateHoursVar, .Rows(i).Item("Hours"))
                    Else
                        ChangeDateFlag = True
                    End If
                    If i = .Rows.Count - 1 Then
                        ChangeEmployeeFlag = True
                        ChangeDateFlag = True
                    Else
                        If ThisEmpoyee <> .Rows(i + 1).Item("employee_code") Then
                            ChangeEmployeeFlag = True
                            ChangeDateFlag = True
                        End If
                        If ThisDate <> .Rows(i + 1).Item("action_date") Then
                            ChangeDateFlag = True
                        End If
                    End If
                    If ChangeEmployeeFlag Then
                        ChangeEmployeeFlag = False
                        Dim j As Integer
                        .DefaultView.RowFilter = ""
                        .DefaultView.RowFilter = "employee_code=" & Qt(ThisEmpoyee)
                        Dim Thistempvar As String = .Rows(i).Item("EmployeeFullName") & "  ***  Total Hours : " & TotalEmployeeHoursVar
                        For j = 0 To .DefaultView.Count - 1
                            .DefaultView(j).Item("TotalHours") = Thistempvar
                        Next
                        .DefaultView.RowFilter = ""
                        TotalEmployeeHoursVar = "000:00"
                    End If
                    If ChangeDateFlag Then
                        ChangeDateFlag = False
                        Dim j As Integer
                        .DefaultView.RowFilter = ""
                        .DefaultView.RowFilter = "employee_code=" & Qt(ThisEmpoyee) & " AND action_date=" & Qt(ThisDate)
                        Dim Thistempvar As String = .Rows(i).Item("action_date") & "  ***  Date Total Hours : " & TotalOneDateHoursVar
                        For j = 0 To .DefaultView.Count - 1
                            .DefaultView(j).Item("TotalDate") = Thistempvar
                        Next
                        .DefaultView.RowFilter = ""
                        TotalOneDateHoursVar = "000:00"
                    End If
                Next
            End If
        End With
    End Sub
    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        Call FillDataset()
    End Sub
    Private Sub CmdRowDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRowDetail.Click
        Dim Currentrow As GridEXRow = GridEX1.GetRow
        Dim FrmAddnew As New FrmManageInOut
        FrmAddnew.Cnn.ConnectionString = PConnectionString
        FrmAddnew.Status = MainModule.WorkStates.Edit
        FrmAddnew.id_punch_inVar = Currentrow.Cells(1).Value
        FrmAddnew.id_punch_OutVar = Currentrow.Cells(2).Value
        FrmAddnew.EmployeeCodVar = Currentrow.Cells(9).Value
        FrmAddnew.Action_dateVar = Currentrow.Cells(7).Value
        FrmAddnew.TimIn_timeVar = Currentrow.Cells(4).Value
        FrmAddnew.TimOut_timeVar = Currentrow.Cells(5).Value
        FrmAddnew.Punch_note_codeVar = Currentrow.Cells(8).Value
        FrmAddnew.ShowDialog()
        Call FillDataset()
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim Currentrow As GridEXRow = GridEX1.GetRow
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Delete"
        c1.ShowFarMsg("Are you sure?")
        If c1.DialogResult = DialogResult.OK Then
            Try
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "Delete From pay_punch_employee_in_out Where id_punch_in_out=" & Currentrow.Cells(1).Value
                CmdGeneral.ExecuteNonQuery()
                CmdGeneral.CommandText = "Delete From pay_punch_employee_in_out Where id_punch_in_out=" & Currentrow.Cells(2).Value
                CmdGeneral.ExecuteNonQuery()
            Catch ex As System.Data.SqlClient.SqlException
                Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
                Call PubErrHandle(myErrors.Item(0).Number)
            End Try
            Call FillDataset()
        End If
    End Sub
    Private Sub GridEX1_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEX1.ColumnButtonClick
        Select Case e.Column.Index
            Case 0
                Call CmdRowDetail_Click(sender, e)
        End Select
    End Sub
    Private Sub DteMinDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DteMinDate.Leave, DteMaxDate.Leave
        Call FillDataset()
    End Sub
    Private Sub GridEX1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.DoubleClick
        CmdRowDetail_Click(sender, e)
    End Sub
End Class
