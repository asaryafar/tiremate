Imports TimeBox
Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmWeeklyTimeSheet
    Inherits FrmBase
    Dim DApay_punch_employee_in_outOriginalVar As String
    Dim DAPay_employee_timesheetVar As String
    Dim So As New Janus.Windows.GridEX.SortOrder
    Dim MyClsTime As New ClsTime
    Dim StartDateVar As Integer = 0
    Private CM As CurrencyManager
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
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAEmployee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmWeeklyTimeSheet1 As UCTimeSheet.DSFrmWeeklyTimeSheet
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAPay_employee_timesheet As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents RdoCalculated As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RdoNotCalculated As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents CmbWeeks As System.Windows.Forms.ComboBox
    Friend WithEvents CmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAYears As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmWeeklyTimeSheet))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DApay_punch_employee_in_out = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmWeeklyTimeSheet1 = New UCTimeSheet.DSFrmWeeklyTimeSheet
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.CmbYear = New System.Windows.Forms.ComboBox
        Me.CmbWeeks = New System.Windows.Forms.ComboBox
        Me.RdoNotCalculated = New Janus.Windows.EditControls.UIRadioButton
        Me.RdoCalculated = New Janus.Windows.EditControls.UIRadioButton
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.Label42 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label43 = New System.Windows.Forms.Label
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnNext = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAEmployee = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAPay_employee_timesheet = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAYears = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmWeeklyTimeSheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SqlSelectCommand1.CommandText = "SELECT id_punch_in_out, employee_code, action_time_hour + ':' + action_time_minut" & _
        "e AS action_Time, in_out_type, action_date FROM pay_punch_employee_in_out"
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
        'GridEX1
        '
        Me.GridEX1.DataMember = "employeeWeeklyTimeSheet"
        Me.GridEX1.DataSource = Me.DsFrmWeeklyTimeSheet1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>employeeWeeklyTimeSheet</Caption><Columns C" & _
        "ollection=""true""><Column0 ID=""employee_code""><Caption>Employee</Caption><TypeNam" & _
        "eEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><D" & _
        "ataMember>employee_code</DataMember><DefaultGroupInterval>Text</DefaultGroupInte" & _
        "rval><EditType>MultiColumnCombo</EditType><Key>employee_code</Key><Position>0</P" & _
        "osition><CompareTarget>Text</CompareTarget><Width>151</Width><DropDownIndex>0</D" & _
        "ropDownIndex></Column0><Column1 ID=""Day1""><Caption>Day1</Caption><DataMember>Day" & _
        "1</DataMember><InputMask>00:00</InputMask><Key>Day1</Key><MaskPrompt>&#x0;</Mask" & _
        "Prompt><Position>1</Position><TextAlignment>Center</TextAlignment><Width>60</Wid" & _
        "th></Column1><Column2 ID=""Day2""><Caption>Day2</Caption><DataMember>Day2</DataMem" & _
        "ber><InputMask>00:00</InputMask><Key>Day2</Key><MaskPrompt>&#x0;</MaskPrompt><Po" & _
        "sition>2</Position><TextAlignment>Center</TextAlignment><Width>60</Width></Colum" & _
        "n2><Column3 ID=""Day3""><Caption>Day3</Caption><DataMember>Day3</DataMember><Input" & _
        "Mask>00:00</InputMask><Key>Day3</Key><MaskPrompt>&#x0;</MaskPrompt><Position>3</" & _
        "Position><TextAlignment>Center</TextAlignment><Width>60</Width></Column3><Column" & _
        "4 ID=""Day4""><Caption>Day4</Caption><DataMember>Day4</DataMember><InputMask>00:00" & _
        "</InputMask><Key>Day4</Key><MaskPrompt>&#x0;</MaskPrompt><Position>4</Position><" & _
        "TextAlignment>Center</TextAlignment><Width>60</Width></Column4><Column5 ID=""Day5" & _
        """><Caption>Day5</Caption><DataMember>Day5</DataMember><InputMask>00:00</InputMas" & _
        "k><Key>Day5</Key><MaskPrompt>&#x0;</MaskPrompt><Position>5</Position><TextAlignm" & _
        "ent>Center</TextAlignment><Width>60</Width></Column5><Column6 ID=""Day6""><Caption" & _
        ">Day6</Caption><DataMember>Day6</DataMember><InputMask>00:00</InputMask><Key>Day" & _
        "6</Key><MaskPrompt>&#x0;</MaskPrompt><Position>6</Position><TextAlignment>Center" & _
        "</TextAlignment><Width>60</Width></Column6><Column7 ID=""Day7""><Caption>Day7</Cap" & _
        "tion><DataMember>Day7</DataMember><InputMask>00:00</InputMask><Key>Day7</Key><Ma" & _
        "skPrompt>&#x0;</MaskPrompt><Position>7</Position><TextAlignment>Center</TextAlig" & _
        "nment><Width>60</Width></Column7><Column8 ID=""Total""><Caption>Total</Caption><Da" & _
        "taMember>Total</DataMember><EditType>NoEdit</EditType><Key>Total</Key><MaskPromp" & _
        "t>&#x0;</MaskPrompt><Position>8</Position><TextAlignment>Center</TextAlignment><" & _
        "Width>40</Width></Column8><Column9 ID=""FlagCanEdit""><Caption>FlagCanEdit</Captio" & _
        "n><DataMember>FlagCanEdit</DataMember><Key>FlagCanEdit</Key><Position>9</Positio" & _
        "n><Visible>False</Visible></Column9></Columns><GroupCondition ID="""" /><Key>emplo" & _
        "yeeWeeklyTimeSheet</Key></RootTable><DropDowns Collection=""true""><DropDown0><Roo" & _
        "tTable><Columns Collection=""true""><Column0 ID=""EmployeeFullName""><Caption>Employ" & _
        "eeFullName</Caption><DataMember>EmployeeFullName</DataMember><EditType>NoEdit</E" & _
        "ditType><Key>EmployeeFullName</Key><Position>0</Position><Width>300</Width></Col" & _
        "umn0></Columns><GroupCondition ID="""" /></RootTable><WatermarkImage /><Font>Micro" & _
        "soft Sans Serif, 8.25pt</Font><ControlStyle /><AllowEdit>False</AllowEdit><Expan" & _
        "dableGroups>False</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible>" & _
        "<HideSelection>Highlight</HideSelection><Key>Employee</Key><DisplayMember>Employ" & _
        "eeFullName</DisplayMember><ValueMember>employee_code</ValueMember></DropDown0></" & _
        "DropDowns></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 59)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(635, 393)
        Me.GridEX1.TabIndex = 2
        '
        'DsFrmWeeklyTimeSheet1
        '
        Me.DsFrmWeeklyTimeSheet1.DataSetName = "DSFrmWeeklyTimeSheet"
        Me.DsFrmWeeklyTimeSheet1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.CmbYear)
        Me.Panel9.Controls.Add(Me.CmbWeeks)
        Me.Panel9.Controls.Add(Me.RdoNotCalculated)
        Me.Panel9.Controls.Add(Me.RdoCalculated)
        Me.Panel9.Controls.Add(Me.Label29)
        Me.Panel9.Controls.Add(Me.Label28)
        Me.Panel9.Controls.Add(Me.BtnPrint)
        Me.Panel9.Controls.Add(Me.BtnPreview)
        Me.Panel9.Controls.Add(Me.Label42)
        Me.Panel9.Controls.Add(Me.BtnCancel)
        Me.Panel9.Controls.Add(Me.Label43)
        Me.Panel9.Controls.Add(Me.BtnEdit)
        Me.Panel9.Controls.Add(Me.Label50)
        Me.Panel9.Controls.Add(Me.Label51)
        Me.Panel9.Controls.Add(Me.Label54)
        Me.Panel9.Controls.Add(Me.Label55)
        Me.Panel9.Controls.Add(Me.BtnDelete)
        Me.Panel9.Controls.Add(Me.BtnNext)
        Me.Panel9.Controls.Add(Me.BtnPrev)
        Me.Panel9.Controls.Add(Me.BtnSave)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(635, 59)
        Me.Panel9.TabIndex = 3
        '
        'CmbYear
        '
        Me.CmbYear.DataSource = Me.DsFrmWeeklyTimeSheet1.Years
        Me.CmbYear.DisplayMember = "YearNo"
        Me.CmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbYear.Location = New System.Drawing.Point(487, 4)
        Me.CmbYear.Name = "CmbYear"
        Me.CmbYear.Size = New System.Drawing.Size(85, 21)
        Me.CmbYear.TabIndex = 194
        Me.CmbYear.ValueMember = "YearNo"
        '
        'CmbWeeks
        '
        Me.CmbWeeks.DataSource = Me.DsFrmWeeklyTimeSheet1.YearWeeks
        Me.CmbWeeks.DisplayMember = "Desc"
        Me.CmbWeeks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWeeks.Location = New System.Drawing.Point(398, 30)
        Me.CmbWeeks.Name = "CmbWeeks"
        Me.CmbWeeks.Size = New System.Drawing.Size(229, 21)
        Me.CmbWeeks.TabIndex = 193
        Me.CmbWeeks.ValueMember = "WeekNo"
        '
        'RdoNotCalculated
        '
        Me.RdoNotCalculated.Location = New System.Drawing.Point(311, 2)
        Me.RdoNotCalculated.Name = "RdoNotCalculated"
        Me.RdoNotCalculated.Size = New System.Drawing.Size(126, 23)
        Me.RdoNotCalculated.TabIndex = 192
        Me.RdoNotCalculated.Text = "Un-Approved Hours"
        '
        'RdoCalculated
        '
        Me.RdoCalculated.Checked = True
        Me.RdoCalculated.Location = New System.Drawing.Point(311, 29)
        Me.RdoCalculated.Name = "RdoCalculated"
        Me.RdoCalculated.Size = New System.Drawing.Size(86, 23)
        Me.RdoCalculated.TabIndex = 191
        Me.RdoCalculated.Text = "Approved"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(269, 33)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 190
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(226, 33)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 189
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(269, 4)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 188
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(232, 4)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 187
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(184, 32)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(39, 10)
        Me.Label42.TabIndex = 186
        Me.Label42.Text = "Cancel"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(187, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Location = New System.Drawing.Point(81, 33)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(33, 10)
        Me.Label43.TabIndex = 184
        Me.Label43.Text = "Edit"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(80, 3)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(150, 32)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 176
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Location = New System.Drawing.Point(115, 32)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(37, 10)
        Me.Label51.TabIndex = 175
        Me.Label51.Text = "Delete"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Location = New System.Drawing.Point(3, 31)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(34, 22)
        Me.Label54.TabIndex = 172
        Me.Label54.Text = "Prev Week"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Location = New System.Drawing.Point(38, 31)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(34, 22)
        Me.Label55.TabIndex = 171
        Me.Label55.Text = "Next Week"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(115, 3)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(39, 2)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 27)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(3, 2)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(150, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(450, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 195
        Me.Label1.Text = "Year"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT l_name + ', ' + f_name + ' ' + m_name AS EmployeeFullName, employee_code F" & _
        "ROM employee"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO employee(employee_code, f_name, m_name, l_name, address, zipcode, tec" & _
        "hnecian, social_security_no, cod_position, cod_deparment, phone_1, extension_1, " & _
        "phone_type_1, phone_main_1, phone_2, extension_2, phone_type_2, phone_main_2, ph" & _
        "one_3, extension_3, phone_type_3, phone_main_3, phone_4, extension_4, phone_type" & _
        "_4, phone_main_4, phone_5, extension_5, phone_type_5, phone_main_5, email, notes" & _
        ", pic, birthday_date, hired_date, last_reiew_date, terminate_date, temporary_ina" & _
        "ctive, last_basis, last_period, last_status, last_salary, last_hourly, last_over" & _
        "time, Last_raise_date, Allowance_Federal, Allowance_state, Allowance_depndnts, T" & _
        "erminated) VALUES (@employee_code, @f_name, @m_name, @l_name, @address, @zipcode" & _
        ", @technecian, @social_security_no, @cod_position, @cod_deparment, @phone_1, @ex" & _
        "tension_1, @phone_type_1, @phone_main_1, @phone_2, @extension_2, @phone_type_2, " & _
        "@phone_main_2, @phone_3, @extension_3, @phone_type_3, @phone_main_3, @phone_4, @" & _
        "extension_4, @phone_type_4, @phone_main_4, @phone_5, @extension_5, @phone_type_5" & _
        ", @phone_main_5, @email, @notes, @pic, @birthday_date, @hired_date, @last_reiew_" & _
        "date, @terminate_date, @temporary_inactive, @last_basis, @last_period, @last_sta" & _
        "tus, @last_salary, @last_hourly, @last_overtime, @Last_raise_date, @Allowance_Fe" & _
        "deral, @Allowance_state, @Allowance_depndnts, @Terminated); SELECT employee_code" & _
        ", f_name, m_name, l_name, address, zipcode, technecian, social_security_no, cod_" & _
        "position, cod_deparment, phone_1, extension_1, phone_type_1, phone_main_1, phone" & _
        "_2, extension_2, phone_type_2, phone_main_2, phone_3, extension_3, phone_type_3," & _
        " phone_main_3, phone_4, extension_4, phone_type_4, phone_main_4, phone_5, extens" & _
        "ion_5, phone_type_5, phone_main_5, email, notes, pic, birthday_date, hired_date," & _
        " last_reiew_date, terminate_date, temporary_inactive, last_basis, last_period, l" & _
        "ast_status, last_salary, last_hourly, last_overtime, Last_raise_date, Allowance_" & _
        "Federal, Allowance_state, Allowance_depndnts, Terminated FROM employee WHERE (em" & _
        "ployee_code = @employee_code)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 30, "l_name"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.VarChar, 5, "zipcode"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@technecian", System.Data.SqlDbType.Bit, 1, "technecian"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 25, "social_security_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_position", System.Data.SqlDbType.VarChar, 2, "cod_position"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_deparment", System.Data.SqlDbType.VarChar, 3, "cod_deparment"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 2, "extension_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 2, "extension_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 2, "extension_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 2, "extension_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50, "email"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@notes", System.Data.SqlDbType.VarChar, 300, "notes"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pic", System.Data.SqlDbType.VarBinary, 2147483647, "pic"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@birthday_date", System.Data.SqlDbType.VarChar, 10, "birthday_date"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hired_date", System.Data.SqlDbType.VarChar, 10, "hired_date"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_reiew_date", System.Data.SqlDbType.VarChar, 10, "last_reiew_date"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@terminate_date", System.Data.SqlDbType.VarChar, 10, "terminate_date"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@temporary_inactive", System.Data.SqlDbType.Bit, 1, "temporary_inactive"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_basis", System.Data.SqlDbType.VarChar, 1, "last_basis"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_period", System.Data.SqlDbType.VarChar, 1, "last_period"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_status", System.Data.SqlDbType.VarChar, 1, "last_status"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_salary", System.Data.SqlDbType.Money, 8, "last_salary"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_hourly", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "last_hourly", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_overtime", System.Data.SqlDbType.Decimal, 13, System.Data.ParameterDirection.Input, False, CType(24, Byte), CType(0, Byte), "last_overtime", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Last_raise_date", System.Data.SqlDbType.VarChar, 10, "Last_raise_date"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Allowance_Federal", System.Data.SqlDbType.SmallInt, 2, "Allowance_Federal"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Allowance_state", System.Data.SqlDbType.SmallInt, 2, "Allowance_state"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Allowance_depndnts", System.Data.SqlDbType.SmallInt, 2, "Allowance_depndnts"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Terminated", System.Data.SqlDbType.Bit, 1, "Terminated"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE employee SET employee_code = @employee_code, f_name = @f_name, m_name = @m" & _
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
        "ry = @last_salary, last_hourly = @last_hourly, last_overtime = @last_overtime, L" & _
        "ast_raise_date = @Last_raise_date, Allowance_Federal = @Allowance_Federal, Allow" & _
        "ance_state = @Allowance_state, Allowance_depndnts = @Allowance_depndnts, Termina" & _
        "ted = @Terminated WHERE (employee_code = @Original_employee_code) AND (Allowance" & _
        "_Federal = @Original_Allowance_Federal OR @Original_Allowance_Federal IS NULL AN" & _
        "D Allowance_Federal IS NULL) AND (Allowance_depndnts = @Original_Allowance_depnd" & _
        "nts OR @Original_Allowance_depndnts IS NULL AND Allowance_depndnts IS NULL) AND " & _
        "(Allowance_state = @Original_Allowance_state OR @Original_Allowance_state IS NUL" & _
        "L AND Allowance_state IS NULL) AND (Last_raise_date = @Original_Last_raise_date " & _
        "OR @Original_Last_raise_date IS NULL AND Last_raise_date IS NULL) AND (Terminate" & _
        "d = @Original_Terminated OR @Original_Terminated IS NULL AND Terminated IS NULL)" & _
        " AND (address = @Original_address OR @Original_address IS NULL AND address IS NU" & _
        "LL) AND (birthday_date = @Original_birthday_date OR @Original_birthday_date IS N" & _
        "ULL AND birthday_date IS NULL) AND (cod_deparment = @Original_cod_deparment OR @" & _
        "Original_cod_deparment IS NULL AND cod_deparment IS NULL) AND (cod_position = @O" & _
        "riginal_cod_position OR @Original_cod_position IS NULL AND cod_position IS NULL)" & _
        " AND (email = @Original_email OR @Original_email IS NULL AND email IS NULL) AND " & _
        "(extension_1 = @Original_extension_1 OR @Original_extension_1 IS NULL AND extens" & _
        "ion_1 IS NULL) AND (extension_2 = @Original_extension_2 OR @Original_extension_2" & _
        " IS NULL AND extension_2 IS NULL) AND (extension_3 = @Original_extension_3 OR @O" & _
        "riginal_extension_3 IS NULL AND extension_3 IS NULL) AND (extension_4 = @Origina" & _
        "l_extension_4 OR @Original_extension_4 IS NULL AND extension_4 IS NULL) AND (ext" & _
        "ension_5 = @Original_extension_5 OR @Original_extension_5 IS NULL AND extension_" & _
        "5 IS NULL) AND (f_name = @Original_f_name OR @Original_f_name IS NULL AND f_name" & _
        " IS NULL) AND (hired_date = @Original_hired_date OR @Original_hired_date IS NULL" & _
        " AND hired_date IS NULL) AND (l_name = @Original_l_name OR @Original_l_name IS N" & _
        "ULL AND l_name IS NULL) AND (last_basis = @Original_last_basis OR @Original_last" & _
        "_basis IS NULL AND last_basis IS NULL) AND (last_hourly = @Original_last_hourly " & _
        "OR @Original_last_hourly IS NULL AND last_hourly IS NULL) AND (last_overtime = @" & _
        "Original_last_overtime OR @Original_last_overtime IS NULL AND last_overtime IS N" & _
        "ULL) AND (last_period = @Original_last_period OR @Original_last_period IS NULL A" & _
        "ND last_period IS NULL) AND (last_reiew_date = @Original_last_reiew_date OR @Ori" & _
        "ginal_last_reiew_date IS NULL AND last_reiew_date IS NULL) AND (last_salary = @O" & _
        "riginal_last_salary OR @Original_last_salary IS NULL AND last_salary IS NULL) AN" & _
        "D (last_status = @Original_last_status OR @Original_last_status IS NULL AND last" & _
        "_status IS NULL) AND (m_name = @Original_m_name OR @Original_m_name IS NULL AND " & _
        "m_name IS NULL) AND (notes = @Original_notes OR @Original_notes IS NULL AND note" & _
        "s IS NULL) AND (phone_1 = @Original_phone_1 OR @Original_phone_1 IS NULL AND pho" & _
        "ne_1 IS NULL) AND (phone_2 = @Original_phone_2 OR @Original_phone_2 IS NULL AND " & _
        "phone_2 IS NULL) AND (phone_3 = @Original_phone_3 OR @Original_phone_3 IS NULL A" & _
        "ND phone_3 IS NULL) AND (phone_4 = @Original_phone_4 OR @Original_phone_4 IS NUL" & _
        "L AND phone_4 IS NULL) AND (phone_5 = @Original_phone_5 OR @Original_phone_5 IS " & _
        "NULL AND phone_5 IS NULL) AND (phone_main_1 = @Original_phone_main_1 OR @Origina" & _
        "l_phone_main_1 IS NULL AND phone_main_1 IS NULL) AND (phone_main_2 = @Original_p" & _
        "hone_main_2 OR @Original_phone_main_2 IS NULL AND phone_main_2 IS NULL) AND (pho" & _
        "ne_main_3 = @Original_phone_main_3 OR @Original_phone_main_3 IS NULL AND phone_m" & _
        "ain_3 IS NULL) AND (phone_main_4 = @Original_phone_main_4 OR @Original_phone_mai" & _
        "n_4 IS NULL AND phone_main_4 IS NULL) AND (phone_main_5 = @Original_phone_main_5" & _
        " OR @Original_phone_main_5 IS NULL AND phone_main_5 IS NULL) AND (phone_type_1 =" & _
        " @Original_phone_type_1 OR @Original_phone_type_1 IS NULL AND phone_type_1 IS NU" & _
        "LL) AND (phone_type_2 = @Original_phone_type_2 OR @Original_phone_type_2 IS NULL" & _
        " AND phone_type_2 IS NULL) AND (phone_type_3 = @Original_phone_type_3 OR @Origin" & _
        "al_phone_type_3 IS NULL AND phone_type_3 IS NULL) AND (phone_type_4 = @Original_" & _
        "phone_type_4 OR @Original_phone_type_4 IS NULL AND phone_type_4 IS NULL) AND (ph" & _
        "one_type_5 = @Original_phone_type_5 OR @Original_phone_type_5 IS NULL AND phone_" & _
        "type_5 IS NULL) AND (social_security_no = @Original_social_security_no OR @Origi" & _
        "nal_social_security_no IS NULL AND social_security_no IS NULL) AND (technecian =" & _
        " @Original_technecian OR @Original_technecian IS NULL AND technecian IS NULL) AN" & _
        "D (temporary_inactive = @Original_temporary_inactive OR @Original_temporary_inac" & _
        "tive IS NULL AND temporary_inactive IS NULL) AND (terminate_date = @Original_ter" & _
        "minate_date OR @Original_terminate_date IS NULL AND terminate_date IS NULL) AND " & _
        "(zipcode = @Original_zipcode OR @Original_zipcode IS NULL AND zipcode IS NULL); " & _
        "SELECT employee_code, f_name, m_name, l_name, address, zipcode, technecian, soci" & _
        "al_security_no, cod_position, cod_deparment, phone_1, extension_1, phone_type_1," & _
        " phone_main_1, phone_2, extension_2, phone_type_2, phone_main_2, phone_3, extens" & _
        "ion_3, phone_type_3, phone_main_3, phone_4, extension_4, phone_type_4, phone_mai" & _
        "n_4, phone_5, extension_5, phone_type_5, phone_main_5, email, notes, pic, birthd" & _
        "ay_date, hired_date, last_reiew_date, terminate_date, temporary_inactive, last_b" & _
        "asis, last_period, last_status, last_salary, last_hourly, last_overtime, Last_ra" & _
        "ise_date, Allowance_Federal, Allowance_state, Allowance_depndnts, Terminated FRO" & _
        "M employee WHERE (employee_code = @employee_code)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 30, "l_name"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.VarChar, 5, "zipcode"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@technecian", System.Data.SqlDbType.Bit, 1, "technecian"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 25, "social_security_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_position", System.Data.SqlDbType.VarChar, 2, "cod_position"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_deparment", System.Data.SqlDbType.VarChar, 3, "cod_deparment"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 2, "extension_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 2, "extension_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 2, "extension_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 2, "extension_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50, "email"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@notes", System.Data.SqlDbType.VarChar, 300, "notes"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pic", System.Data.SqlDbType.VarBinary, 2147483647, "pic"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@birthday_date", System.Data.SqlDbType.VarChar, 10, "birthday_date"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hired_date", System.Data.SqlDbType.VarChar, 10, "hired_date"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_reiew_date", System.Data.SqlDbType.VarChar, 10, "last_reiew_date"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@terminate_date", System.Data.SqlDbType.VarChar, 10, "terminate_date"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@temporary_inactive", System.Data.SqlDbType.Bit, 1, "temporary_inactive"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_basis", System.Data.SqlDbType.VarChar, 1, "last_basis"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_period", System.Data.SqlDbType.VarChar, 1, "last_period"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_status", System.Data.SqlDbType.VarChar, 1, "last_status"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_salary", System.Data.SqlDbType.Money, 8, "last_salary"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_hourly", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "last_hourly", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_overtime", System.Data.SqlDbType.Decimal, 13, System.Data.ParameterDirection.Input, False, CType(24, Byte), CType(0, Byte), "last_overtime", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Last_raise_date", System.Data.SqlDbType.VarChar, 10, "Last_raise_date"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Allowance_Federal", System.Data.SqlDbType.SmallInt, 2, "Allowance_Federal"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Allowance_state", System.Data.SqlDbType.SmallInt, 2, "Allowance_state"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Allowance_depndnts", System.Data.SqlDbType.SmallInt, 2, "Allowance_depndnts"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Terminated", System.Data.SqlDbType.Bit, 1, "Terminated"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Allowance_Federal", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Allowance_Federal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Allowance_depndnts", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Allowance_depndnts", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Allowance_state", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Allowance_state", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Last_raise_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Last_raise_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Terminated", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Terminated", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_birthday_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "birthday_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_deparment", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_deparment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_position", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_position", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_f_name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "f_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_hired_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hired_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_l_name", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "l_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_basis", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_basis", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_hourly", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "last_hourly", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_overtime", System.Data.SqlDbType.Decimal, 13, System.Data.ParameterDirection.Input, False, CType(24, Byte), CType(0, Byte), "last_overtime", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_period", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_period", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_reiew_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_reiew_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_salary", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_salary", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_status", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_status", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_m_name", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "m_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_notes", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "notes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_security_no", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "social_security_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_technecian", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "technecian", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_temporary_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "temporary_inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_terminate_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "terminate_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zipcode", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zipcode", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM employee WHERE (employee_code = @Original_employee_code) AND (Allowan" & _
        "ce_Federal = @Original_Allowance_Federal OR @Original_Allowance_Federal IS NULL " & _
        "AND Allowance_Federal IS NULL) AND (Allowance_depndnts = @Original_Allowance_dep" & _
        "ndnts OR @Original_Allowance_depndnts IS NULL AND Allowance_depndnts IS NULL) AN" & _
        "D (Allowance_state = @Original_Allowance_state OR @Original_Allowance_state IS N" & _
        "ULL AND Allowance_state IS NULL) AND (Last_raise_date = @Original_Last_raise_dat" & _
        "e OR @Original_Last_raise_date IS NULL AND Last_raise_date IS NULL) AND (Termina" & _
        "ted = @Original_Terminated OR @Original_Terminated IS NULL AND Terminated IS NUL" & _
        "L) AND (address = @Original_address OR @Original_address IS NULL AND address IS " & _
        "NULL) AND (birthday_date = @Original_birthday_date OR @Original_birthday_date IS" & _
        " NULL AND birthday_date IS NULL) AND (cod_deparment = @Original_cod_deparment OR" & _
        " @Original_cod_deparment IS NULL AND cod_deparment IS NULL) AND (cod_position = " & _
        "@Original_cod_position OR @Original_cod_position IS NULL AND cod_position IS NUL" & _
        "L) AND (email = @Original_email OR @Original_email IS NULL AND email IS NULL) AN" & _
        "D (extension_1 = @Original_extension_1 OR @Original_extension_1 IS NULL AND exte" & _
        "nsion_1 IS NULL) AND (extension_2 = @Original_extension_2 OR @Original_extension" & _
        "_2 IS NULL AND extension_2 IS NULL) AND (extension_3 = @Original_extension_3 OR " & _
        "@Original_extension_3 IS NULL AND extension_3 IS NULL) AND (extension_4 = @Origi" & _
        "nal_extension_4 OR @Original_extension_4 IS NULL AND extension_4 IS NULL) AND (e" & _
        "xtension_5 = @Original_extension_5 OR @Original_extension_5 IS NULL AND extensio" & _
        "n_5 IS NULL) AND (f_name = @Original_f_name OR @Original_f_name IS NULL AND f_na" & _
        "me IS NULL) AND (hired_date = @Original_hired_date OR @Original_hired_date IS NU" & _
        "LL AND hired_date IS NULL) AND (l_name = @Original_l_name OR @Original_l_name IS" & _
        " NULL AND l_name IS NULL) AND (last_basis = @Original_last_basis OR @Original_la" & _
        "st_basis IS NULL AND last_basis IS NULL) AND (last_hourly = @Original_last_hourl" & _
        "y OR @Original_last_hourly IS NULL AND last_hourly IS NULL) AND (last_overtime =" & _
        " @Original_last_overtime OR @Original_last_overtime IS NULL AND last_overtime IS" & _
        " NULL) AND (last_period = @Original_last_period OR @Original_last_period IS NULL" & _
        " AND last_period IS NULL) AND (last_reiew_date = @Original_last_reiew_date OR @O" & _
        "riginal_last_reiew_date IS NULL AND last_reiew_date IS NULL) AND (last_salary = " & _
        "@Original_last_salary OR @Original_last_salary IS NULL AND last_salary IS NULL) " & _
        "AND (last_status = @Original_last_status OR @Original_last_status IS NULL AND la" & _
        "st_status IS NULL) AND (m_name = @Original_m_name OR @Original_m_name IS NULL AN" & _
        "D m_name IS NULL) AND (notes = @Original_notes OR @Original_notes IS NULL AND no" & _
        "tes IS NULL) AND (phone_1 = @Original_phone_1 OR @Original_phone_1 IS NULL AND p" & _
        "hone_1 IS NULL) AND (phone_2 = @Original_phone_2 OR @Original_phone_2 IS NULL AN" & _
        "D phone_2 IS NULL) AND (phone_3 = @Original_phone_3 OR @Original_phone_3 IS NULL" & _
        " AND phone_3 IS NULL) AND (phone_4 = @Original_phone_4 OR @Original_phone_4 IS N" & _
        "ULL AND phone_4 IS NULL) AND (phone_5 = @Original_phone_5 OR @Original_phone_5 I" & _
        "S NULL AND phone_5 IS NULL) AND (phone_main_1 = @Original_phone_main_1 OR @Origi" & _
        "nal_phone_main_1 IS NULL AND phone_main_1 IS NULL) AND (phone_main_2 = @Original" & _
        "_phone_main_2 OR @Original_phone_main_2 IS NULL AND phone_main_2 IS NULL) AND (p" & _
        "hone_main_3 = @Original_phone_main_3 OR @Original_phone_main_3 IS NULL AND phone" & _
        "_main_3 IS NULL) AND (phone_main_4 = @Original_phone_main_4 OR @Original_phone_m" & _
        "ain_4 IS NULL AND phone_main_4 IS NULL) AND (phone_main_5 = @Original_phone_main" & _
        "_5 OR @Original_phone_main_5 IS NULL AND phone_main_5 IS NULL) AND (phone_type_1" & _
        " = @Original_phone_type_1 OR @Original_phone_type_1 IS NULL AND phone_type_1 IS " & _
        "NULL) AND (phone_type_2 = @Original_phone_type_2 OR @Original_phone_type_2 IS NU" & _
        "LL AND phone_type_2 IS NULL) AND (phone_type_3 = @Original_phone_type_3 OR @Orig" & _
        "inal_phone_type_3 IS NULL AND phone_type_3 IS NULL) AND (phone_type_4 = @Origina" & _
        "l_phone_type_4 OR @Original_phone_type_4 IS NULL AND phone_type_4 IS NULL) AND (" & _
        "phone_type_5 = @Original_phone_type_5 OR @Original_phone_type_5 IS NULL AND phon" & _
        "e_type_5 IS NULL) AND (social_security_no = @Original_social_security_no OR @Ori" & _
        "ginal_social_security_no IS NULL AND social_security_no IS NULL) AND (technecian" & _
        " = @Original_technecian OR @Original_technecian IS NULL AND technecian IS NULL) " & _
        "AND (temporary_inactive = @Original_temporary_inactive OR @Original_temporary_in" & _
        "active IS NULL AND temporary_inactive IS NULL) AND (terminate_date = @Original_t" & _
        "erminate_date OR @Original_terminate_date IS NULL AND terminate_date IS NULL) AN" & _
        "D (zipcode = @Original_zipcode OR @Original_zipcode IS NULL AND zipcode IS NULL)" & _
        ""
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Allowance_Federal", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Allowance_Federal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Allowance_depndnts", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Allowance_depndnts", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Allowance_state", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Allowance_state", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Last_raise_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Last_raise_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Terminated", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Terminated", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_birthday_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "birthday_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_deparment", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_deparment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_position", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_position", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_f_name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "f_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_hired_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hired_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_l_name", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "l_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_basis", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_basis", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_hourly", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "last_hourly", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_overtime", System.Data.SqlDbType.Decimal, 13, System.Data.ParameterDirection.Input, False, CType(24, Byte), CType(0, Byte), "last_overtime", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_period", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_period", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_reiew_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_reiew_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_salary", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_salary", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_status", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_status", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_m_name", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "m_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_notes", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "notes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_security_no", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "social_security_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_technecian", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "technecian", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_temporary_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "temporary_inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_terminate_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "terminate_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zipcode", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zipcode", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAEmployee
        '
        Me.DAEmployee.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAEmployee.InsertCommand = Me.SqlInsertCommand2
        Me.DAEmployee.SelectCommand = Me.SqlSelectCommand2
        Me.DAEmployee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("technecian", "technecian"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("cod_deparment", "cod_deparment"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("pic", "pic"), New System.Data.Common.DataColumnMapping("birthday_date", "birthday_date"), New System.Data.Common.DataColumnMapping("hired_date", "hired_date"), New System.Data.Common.DataColumnMapping("last_reiew_date", "last_reiew_date"), New System.Data.Common.DataColumnMapping("terminate_date", "terminate_date"), New System.Data.Common.DataColumnMapping("temporary_inactive", "temporary_inactive"), New System.Data.Common.DataColumnMapping("last_basis", "last_basis"), New System.Data.Common.DataColumnMapping("last_period", "last_period"), New System.Data.Common.DataColumnMapping("last_status", "last_status"), New System.Data.Common.DataColumnMapping("last_salary", "last_salary"), New System.Data.Common.DataColumnMapping("last_hourly", "last_hourly"), New System.Data.Common.DataColumnMapping("last_overtime", "last_overtime"), New System.Data.Common.DataColumnMapping("Last_raise_date", "Last_raise_date"), New System.Data.Common.DataColumnMapping("Allowance_Federal", "Allowance_Federal"), New System.Data.Common.DataColumnMapping("Allowance_state", "Allowance_state"), New System.Data.Common.DataColumnMapping("Allowance_depndnts", "Allowance_depndnts"), New System.Data.Common.DataColumnMapping("Terminated", "Terminated")})})
        Me.DAEmployee.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT pay_employee_timesheet.employee_code, pay_employee_timesheet.timesheet_dat" & _
        "e, pay_employee_timesheet.action_time_hour, pay_employee_timesheet.action_time_m" & _
        "inute, pay_employee_timesheet.calculate, pay_employee_timesheet.action_time_hour" & _
        " + ':' + pay_employee_timesheet.action_time_minute AS Action_Time FROM pay_emplo" & _
        "yee_timesheet RIGHT OUTER JOIN employee ON pay_employee_timesheet.employee_code " & _
        "= employee.employee_code"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO pay_employee_timesheet(employee_code, timesheet_date, action_time_hou" & _
        "r, action_time_minute, calculate) VALUES (@employee_code, @timesheet_date, @acti" & _
        "on_time_hour, @action_time_minute, @calculate); SELECT employee_code, timesheet_" & _
        "date, action_time_hour, action_time_minute, calculate FROM pay_employee_timeshee" & _
        "t WHERE (employee_code = @employee_code) AND (timesheet_date = @timesheet_date)"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@timesheet_date", System.Data.SqlDbType.VarChar, 10, "timesheet_date"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@action_time_hour", System.Data.SqlDbType.VarChar, 2, "action_time_hour"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@action_time_minute", System.Data.SqlDbType.VarChar, 2, "action_time_minute"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@calculate", System.Data.SqlDbType.Bit, 1, "calculate"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE pay_employee_timesheet SET employee_code = @employee_code, timesheet_date " & _
        "= @timesheet_date, action_time_hour = @action_time_hour, action_time_minute = @a" & _
        "ction_time_minute, calculate = @calculate WHERE (employee_code = @Original_emplo" & _
        "yee_code) AND (timesheet_date = @Original_timesheet_date) AND (action_time_hour " & _
        "= @Original_action_time_hour OR @Original_action_time_hour IS NULL AND action_ti" & _
        "me_hour IS NULL) AND (action_time_minute = @Original_action_time_minute OR @Orig" & _
        "inal_action_time_minute IS NULL AND action_time_minute IS NULL) AND (calculate =" & _
        " @Original_calculate OR @Original_calculate IS NULL AND calculate IS NULL); SELE" & _
        "CT employee_code, timesheet_date, action_time_hour, action_time_minute, calculat" & _
        "e FROM pay_employee_timesheet WHERE (employee_code = @employee_code) AND (timesh" & _
        "eet_date = @timesheet_date)"
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@timesheet_date", System.Data.SqlDbType.VarChar, 10, "timesheet_date"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@action_time_hour", System.Data.SqlDbType.VarChar, 2, "action_time_hour"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@action_time_minute", System.Data.SqlDbType.VarChar, 2, "action_time_minute"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@calculate", System.Data.SqlDbType.Bit, 1, "calculate"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_timesheet_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timesheet_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_action_time_hour", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "action_time_hour", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_action_time_minute", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "action_time_minute", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_calculate", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "calculate", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM pay_employee_timesheet WHERE (employee_code = @Original_employee_code" & _
        ") AND (timesheet_date = @Original_timesheet_date) AND (action_time_hour = @Origi" & _
        "nal_action_time_hour OR @Original_action_time_hour IS NULL AND action_time_hour " & _
        "IS NULL) AND (action_time_minute = @Original_action_time_minute OR @Original_act" & _
        "ion_time_minute IS NULL AND action_time_minute IS NULL) AND (calculate = @Origin" & _
        "al_calculate OR @Original_calculate IS NULL AND calculate IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_timesheet_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timesheet_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_action_time_hour", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "action_time_hour", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_action_time_minute", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "action_time_minute", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_calculate", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "calculate", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAPay_employee_timesheet
        '
        Me.DAPay_employee_timesheet.DeleteCommand = Me.SqlDeleteCommand3
        Me.DAPay_employee_timesheet.InsertCommand = Me.SqlInsertCommand3
        Me.DAPay_employee_timesheet.SelectCommand = Me.SqlSelectCommand3
        Me.DAPay_employee_timesheet.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_employee_timesheet", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("timesheet_date", "timesheet_date"), New System.Data.Common.DataColumnMapping("action_time_hour", "action_time_hour"), New System.Data.Common.DataColumnMapping("action_time_minute", "action_time_minute"), New System.Data.Common.DataColumnMapping("calculate", "calculate")})})
        Me.DAPay_employee_timesheet.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT DISTINCT SUBSTRING(action_date, 7, 4) AS YearNo FROM pay_punch_employee_in" & _
        "_out ORDER BY SUBSTRING(action_date, 7, 4) DESC"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DAYears
        '
        Me.DAYears.SelectCommand = Me.SqlSelectCommand4
        '
        'FrmWeeklyTimeSheet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(635, 452)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmWeeklyTimeSheet"
        Me.Text = "Weekly Time Sheet"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmWeeklyTimeSheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmEmployeeInOutBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        DsFrmWeeklyTimeSheet1.Clear()
        DAEmployee.Fill(DsFrmWeeklyTimeSheet1, "employee")
        DApay_punch_employee_in_outOriginalVar = DApay_punch_employee_in_out.SelectCommand.CommandText
        DAPay_employee_timesheetVar = DAPay_employee_timesheet.SelectCommand.CommandText


        DAYears.Fill(DsFrmWeeklyTimeSheet1.Years)

        Call FillWeeks()

        'Call FillDataset(DateTime.Now)

        GridEX1.DropDowns("Employee").SetDataBinding(DsFrmWeeklyTimeSheet1, "employee")

        Call FillDataset(DsFrmWeeklyTimeSheet1.YearWeeks.Rows(0).Item("WeekNo"))

        CM = CType(Me.BindingContext(DsFrmWeeklyTimeSheet1.YearWeeks), CurrencyManager)

        GridEX1.AllowEdit = InheritableBoolean.False

        Call SetBtnEnable(True)
    End Sub
    Private Sub FillWeeks()
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrievePayrollSetupTable()
        If Trim(OleDbReaderForStore.Item("DEFAULT_PaymentDay") & "").Length > 0 Then
            Select Case Trim(OleDbReaderForStore.Item("DEFAULT_PaymentDay") & "").ToUpper
                Case "Sunday".ToUpper
                    StartDateVar = 2
                Case "Monday".ToUpper
                    StartDateVar = 1
                Case "Tuesday".ToUpper
                    StartDateVar = 0
                Case "Wednesday".ToUpper
                    StartDateVar = -1
                Case "Thursday".ToUpper
                    StartDateVar = -2
                Case "Friday".ToUpper
                    StartDateVar = -3
                Case "Saturday".ToUpper
                    StartDateVar = -4
            End Select
        Else
            StartDateVar = 0
        End If

        DsFrmWeeklyTimeSheet1.YearWeeks.Clear()
        Dim FirstDayOfYearVar As String = "01/01/" & PSalMali
        If Trim(CmbYear.Text & "").Length > 0 Then
            FirstDayOfYearVar = "01/01/" & CmbYear.Text.Trim
        End If
        Dim FirstDayOfFirstWeekOfYearVar As Integer = 0

        If CDate(FirstDayOfYearVar).DayOfWeek() > StartDateVar Then
            FirstDayOfFirstWeekOfYearVar = CDate(FirstDayOfYearVar).DayOfWeek() - StartDateVar
        Else
            FirstDayOfFirstWeekOfYearVar = StartDateVar - CDate(FirstDayOfYearVar).DayOfWeek()
        End If
        If FirstDayOfFirstWeekOfYearVar >= 7 Then
            FirstDayOfFirstWeekOfYearVar = FirstDayOfFirstWeekOfYearVar - 7
        End If

        Dim i As Integer
        For i = 0 To 51
            DsFrmWeeklyTimeSheet1.YearWeeks.AddYearWeeksRow(CStr(CDate(FirstDayOfYearVar).AddDays(FirstDayOfFirstWeekOfYearVar + (i * 7)).Date), Str(i + 1) & " - " & CStr(CDate(FirstDayOfYearVar).AddDays(FirstDayOfFirstWeekOfYearVar + (i * 7)).Date) & " TO " & CStr(CDate(FirstDayOfYearVar).AddDays(FirstDayOfFirstWeekOfYearVar + (i * 7) + 6).Date))
        Next
    End Sub
    Private Sub FillDataset(ByVal StartDate As Date)
        If Trim(DAPay_employee_timesheetVar & "").Length > 0 And Trim(DApay_punch_employee_in_outOriginalVar & "").Length > 0 Then
            Dim MinDate As String
            Dim MaxDate As String
            Dim I As Integer = 0
            Dim NoOfDay As Integer
            Dim EmployeeWeeklyTimeSheetRowVar As Integer = -1

            NoOfDay = StartDate.Day - StartDateVar
            NoOfDay = 0

            MinDate = Format(StartDate.AddDays(-NoOfDay), PubDateFormat.ToString)
            MaxDate = Format(StartDate.AddDays(6 - NoOfDay), PubDateFormat.ToString)

            DsFrmWeeklyTimeSheet1.pay_punch_employee_in_out.Clear()
            DsFrmWeeklyTimeSheet1.pay_employee_timesheet.Clear()
            DsFrmWeeklyTimeSheet1.employeeWeeklyTimeSheet.Clear()

            GridEX1.RootTable.Columns(1).Caption = DayName(StartDate.AddDays(-NoOfDay).DayOfWeek)
            GridEX1.RootTable.Columns(2).Caption = DayName(StartDate.AddDays(-NoOfDay + 1).DayOfWeek)
            GridEX1.RootTable.Columns(3).Caption = DayName(StartDate.AddDays(-NoOfDay + 2).DayOfWeek)
            GridEX1.RootTable.Columns(4).Caption = DayName(StartDate.AddDays(-NoOfDay + 3).DayOfWeek)
            GridEX1.RootTable.Columns(5).Caption = DayName(StartDate.AddDays(-NoOfDay + 4).DayOfWeek)
            GridEX1.RootTable.Columns(6).Caption = DayName(StartDate.AddDays(-NoOfDay + 5).DayOfWeek)
            GridEX1.RootTable.Columns(7).Caption = DayName(StartDate.AddDays(-NoOfDay + 6).DayOfWeek)
            GridEX1.RootTable.Columns(8).Caption = "Total"

            If RdoCalculated.Checked Then
                DAPay_employee_timesheet.SelectCommand.CommandText = DAPay_employee_timesheetVar & " Where  dbo.ChangeDate(timesheet_date)>=" & Qt(ChangeDateToYYYYMMDD(MinDate)) & " AND dbo.ChangeDate(timesheet_date)<=" & Qt(ChangeDateToYYYYMMDD(MaxDate))
                DAPay_employee_timesheet.SelectCommand.CommandText = DAPay_employee_timesheet.SelectCommand.CommandText & " Order by pay_employee_timesheet.employee_code,dbo.ChangeDate(pay_employee_timesheet.timesheet_date)"
                DAPay_employee_timesheet.Fill(DsFrmWeeklyTimeSheet1, "pay_employee_timesheet")
                If DsFrmWeeklyTimeSheet1.pay_employee_timesheet.Rows.Count > 0 Then
                    Dim EmployeeCodeVar As String = ""
                    Dim MyDataRow As DataRow
                    Dim WhichDayVar As Integer
                    With DsFrmWeeklyTimeSheet1
                        For I = 0 To .pay_employee_timesheet.Rows.Count - 1
                            If EmployeeCodeVar = .pay_employee_timesheet.Rows(I).Item("employee_code") Then
                                MyDataRow = .employeeWeeklyTimeSheet.Rows(EmployeeWeeklyTimeSheetRowVar)
                            Else
                                EmployeeWeeklyTimeSheetRowVar = EmployeeWeeklyTimeSheetRowVar + 1
                                MyDataRow = .employeeWeeklyTimeSheet.NewRow
                                MyDataRow("employee_code") = .pay_employee_timesheet.Rows(I).Item("employee_code")
                                MyDataRow("Total") = "00:00"
                            End If
                            Try
                                WhichDayVar = CType(.pay_employee_timesheet.Rows(I).Item("timesheet_date"), Date).Subtract(CType(MinDate, Date)).Days + 1
                            Catch ex As Exception
                                WhichDayVar = 0
                            End Try
                            Select Case WhichDayVar
                                Case 1
                                    MyDataRow("Day1") = .pay_employee_timesheet.Rows(I).Item("action_time")
                                    MyDataRow("Total") = MyClsTime.AddTime(MyDataRow("Total"), MyDataRow("Day1"))
                                Case 2
                                    MyDataRow("Day2") = .pay_employee_timesheet.Rows(I).Item("action_time")
                                    MyDataRow("Total") = MyClsTime.AddTime(MyDataRow("Total"), MyDataRow("Day2"))
                                Case 3
                                    MyDataRow("Day3") = .pay_employee_timesheet.Rows(I).Item("action_time")
                                    MyDataRow("Total") = MyClsTime.AddTime(MyDataRow("Total"), MyDataRow("Day3"))
                                Case 4
                                    MyDataRow("Day4") = .pay_employee_timesheet.Rows(I).Item("action_time")
                                    MyDataRow("Total") = MyClsTime.AddTime(MyDataRow("Total"), MyDataRow("Day4"))
                                Case 5
                                    MyDataRow("Day5") = .pay_employee_timesheet.Rows(I).Item("action_time")
                                    MyDataRow("Total") = MyClsTime.AddTime(MyDataRow("Total"), MyDataRow("Day5"))
                                Case 6
                                    MyDataRow("Day6") = .pay_employee_timesheet.Rows(I).Item("action_time")
                                    MyDataRow("Total") = MyClsTime.AddTime(MyDataRow("Total"), MyDataRow("Day6"))
                                Case 7
                                    MyDataRow("Day7") = .pay_employee_timesheet.Rows(I).Item("action_time")
                                    MyDataRow("Total") = MyClsTime.AddTime(MyDataRow("Total"), MyDataRow("Day7"))
                            End Select
                            If EmployeeCodeVar <> .pay_employee_timesheet.Rows(I).Item("employee_code") And WhichDayVar > 0 Then
                                MyDataRow("FlagCanEdit") = 1
                                .employeeWeeklyTimeSheet.Rows.Add(MyDataRow)
                                EmployeeCodeVar = .employeeWeeklyTimeSheet.Rows(EmployeeWeeklyTimeSheetRowVar).Item("employee_code")
                            End If
                        Next
                    End With
                End If
            End If
            If RdoNotCalculated.Checked Then
                DApay_punch_employee_in_out.SelectCommand.CommandText = DApay_punch_employee_in_outOriginalVar & " Where dbo.ChangeDate(action_date)>=" & Qt(ChangeDateToYYYYMMDD(MinDate)) & " AND dbo.ChangeDate(action_date)<=" & Qt(ChangeDateToYYYYMMDD(MaxDate))
                DApay_punch_employee_in_out.SelectCommand.CommandText = DApay_punch_employee_in_out.SelectCommand.CommandText & " AND employee_code Not in (select employee_code From pay_employee_timesheet Where dbo.ChangeDate(timesheet_date)>=" & Qt(ChangeDateToYYYYMMDD(MinDate)) & " AND dbo.ChangeDate(timesheet_date)<=" & Qt(ChangeDateToYYYYMMDD(MaxDate)) & ") "
                DApay_punch_employee_in_out.SelectCommand.CommandText = DApay_punch_employee_in_out.SelectCommand.CommandText & " Order by employee_code,action_date,id_punch_in_out"
                DApay_punch_employee_in_out.Fill(DsFrmWeeklyTimeSheet1, "pay_punch_employee_in_out")
                If DsFrmWeeklyTimeSheet1.pay_punch_employee_in_out.Rows.Count > 0 Then
                    Dim EmployeeCodeVar As String = ""
                    Dim MyDataRow As DataRow
                    Dim WhichDayVar As Integer
                    With DsFrmWeeklyTimeSheet1
                        For I = 0 To .pay_punch_employee_in_out.Rows.Count - 2
                            If .pay_punch_employee_in_out.Rows(I).Item("employee_code") = .pay_punch_employee_in_out.Rows(I + 1).Item("employee_code") And _
                               .pay_punch_employee_in_out.Rows(I).Item("action_Date") = .pay_punch_employee_in_out.Rows(I + 1).Item("action_Date") And _
                               .pay_punch_employee_in_out.Rows(I).Item("action_Time") <= .pay_punch_employee_in_out.Rows(I + 1).Item("action_Time") And _
                               .pay_punch_employee_in_out.Rows(I).Item("in_out_type") = 0 And _
                               .pay_punch_employee_in_out.Rows(I + 1).Item("in_out_type") = 1 Then
                                If EmployeeCodeVar = .pay_punch_employee_in_out.Rows(I).Item("employee_code") Then
                                    MyDataRow = .employeeWeeklyTimeSheet.Rows(EmployeeWeeklyTimeSheetRowVar)
                                Else
                                    EmployeeWeeklyTimeSheetRowVar = EmployeeWeeklyTimeSheetRowVar + 1
                                    MyDataRow = .employeeWeeklyTimeSheet.NewRow
                                    MyDataRow("employee_code") = .pay_punch_employee_in_out.Rows(I).Item("employee_code")
                                    MyDataRow("Total") = "00:00"
                                End If
                                Try
                                    WhichDayVar = CType(.pay_punch_employee_in_out.Rows(I).Item("action_date"), Date).Subtract(CType(MinDate, Date)).Days + 1
                                Catch ex As Exception
                                    WhichDayVar = 0
                                End Try
                                Select Case WhichDayVar
                                    Case 1
                                        MyDataRow("Day1") = MyClsTime.AddTime(MyDataRow("Day1") & "", MyClsTime.SubtractTime(.pay_punch_employee_in_out.Rows(I + 1).Item("action_time"), .pay_punch_employee_in_out.Rows(I).Item("action_time")))
                                        MyDataRow("Total") = MyClsTime.AddTime(MyDataRow("Total") & "", MyClsTime.SubtractTime(.pay_punch_employee_in_out.Rows(I + 1).Item("action_time"), .pay_punch_employee_in_out.Rows(I).Item("action_time")))
                                    Case 2
                                        MyDataRow("Day2") = MyClsTime.AddTime(MyDataRow("Day2") & "", MyClsTime.SubtractTime(.pay_punch_employee_in_out.Rows(I + 1).Item("action_time"), .pay_punch_employee_in_out.Rows(I).Item("action_time")))
                                        MyDataRow("Total") = MyClsTime.AddTime(MyDataRow("Total") & "", MyClsTime.SubtractTime(.pay_punch_employee_in_out.Rows(I + 1).Item("action_time"), .pay_punch_employee_in_out.Rows(I).Item("action_time")))
                                    Case 3
                                        MyDataRow("Day3") = MyClsTime.AddTime(MyDataRow("Day3") & "", MyClsTime.SubtractTime(.pay_punch_employee_in_out.Rows(I + 1).Item("action_time"), .pay_punch_employee_in_out.Rows(I).Item("action_time")))
                                        MyDataRow("Total") = MyClsTime.AddTime(MyDataRow("Total") & "", MyClsTime.SubtractTime(.pay_punch_employee_in_out.Rows(I + 1).Item("action_time"), .pay_punch_employee_in_out.Rows(I).Item("action_time")))
                                    Case 4
                                        MyDataRow("Day4") = MyClsTime.AddTime(MyDataRow("Day4") & "", MyClsTime.SubtractTime(.pay_punch_employee_in_out.Rows(I + 1).Item("action_time"), .pay_punch_employee_in_out.Rows(I).Item("action_time")))
                                        MyDataRow("Total") = MyClsTime.AddTime(MyDataRow("Total") & "", MyClsTime.SubtractTime(.pay_punch_employee_in_out.Rows(I + 1).Item("action_time"), .pay_punch_employee_in_out.Rows(I).Item("action_time")))
                                    Case 5
                                        MyDataRow("Day5") = MyClsTime.AddTime(MyDataRow("Day5") & "", MyClsTime.SubtractTime(.pay_punch_employee_in_out.Rows(I + 1).Item("action_time"), .pay_punch_employee_in_out.Rows(I).Item("action_time")))
                                        MyDataRow("Total") = MyClsTime.AddTime(MyDataRow("Total") & "", MyClsTime.SubtractTime(.pay_punch_employee_in_out.Rows(I + 1).Item("action_time"), .pay_punch_employee_in_out.Rows(I).Item("action_time")))
                                    Case 6
                                        MyDataRow("Day6") = MyClsTime.AddTime(MyDataRow("Day6") & "", MyClsTime.SubtractTime(.pay_punch_employee_in_out.Rows(I + 1).Item("action_time"), .pay_punch_employee_in_out.Rows(I).Item("action_time")))
                                        MyDataRow("Total") = MyClsTime.AddTime(MyDataRow("Total") & "", MyClsTime.SubtractTime(.pay_punch_employee_in_out.Rows(I + 1).Item("action_time"), .pay_punch_employee_in_out.Rows(I).Item("action_time")))
                                    Case 7
                                        MyDataRow("Day7") = MyClsTime.AddTime(MyDataRow("Day7") & "", MyClsTime.SubtractTime(.pay_punch_employee_in_out.Rows(I + 1).Item("action_time"), .pay_punch_employee_in_out.Rows(I).Item("action_time")))
                                        MyDataRow("Total") = MyClsTime.AddTime(MyDataRow("Total") & "", MyClsTime.SubtractTime(.pay_punch_employee_in_out.Rows(I + 1).Item("action_time"), .pay_punch_employee_in_out.Rows(I).Item("action_time")))
                                End Select
                                If EmployeeCodeVar <> .pay_punch_employee_in_out.Rows(I).Item("employee_code") And WhichDayVar > 0 Then
                                    MyDataRow("FlagCanEdit") = 1
                                    .employeeWeeklyTimeSheet.Rows.Add(MyDataRow)
                                    EmployeeCodeVar = .employeeWeeklyTimeSheet.Rows(EmployeeWeeklyTimeSheetRowVar).Item("employee_code")
                                End If
                                I = I + 1
                            End If
                        Next
                    End With
                End If
            End If
        End If
    End Sub
    Private Sub CmbWeeks_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbWeeks.SelectedIndexChanged, RdoCalculated.CheckedChanged, RdoNotCalculated.CheckedChanged
        Call FillDataset(CDate(CmbWeeks.SelectedValue))
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Delete From pay_employee_timesheet Where dbo.ChangeDate(timesheet_date)>=" & Qt(ChangeDateToYYYYMMDD(CmbWeeks.SelectedValue)) & " AND dbo.ChangeDate(timesheet_date)<=" & Qt(ChangeDateToYYYYMMDD(CStr(CDate(CmbWeeks.SelectedValue).AddDays(6).Date)))
        CmdGeneral.ExecuteNonQuery()
        If DsFrmWeeklyTimeSheet1.employeeWeeklyTimeSheet.Rows.Count > 0 Then
            Dim i As Integer, j As Integer
            Dim TimeHourTempVar As String
            Dim TimeMinuteTempVar As String
            Dim DayNoVar As String
            Dim ThisDateTempVar As String
            For i = 0 To DsFrmWeeklyTimeSheet1.employeeWeeklyTimeSheet.Rows.Count - 1
                For j = 0 To 6
                    DayNoVar = "DAY" & Str(j + 1).Trim
                    ThisDateTempVar = MakeDateCorrect(CStr(CDate(CmbWeeks.SelectedValue).AddDays(j).Date))
                    If Len(DsFrmWeeklyTimeSheet1.employeeWeeklyTimeSheet.Rows(i).Item(DayNoVar) & "") = 5 Then
                        If Mid(DsFrmWeeklyTimeSheet1.employeeWeeklyTimeSheet.Rows(i).Item(DayNoVar), 3, 1) = ":" Then
                            TimeHourTempVar = Mid(DsFrmWeeklyTimeSheet1.employeeWeeklyTimeSheet.Rows(i).Item(DayNoVar), 1, 2)
                            TimeMinuteTempVar = Mid(DsFrmWeeklyTimeSheet1.employeeWeeklyTimeSheet.Rows(i).Item(DayNoVar), 4, 2)
                            CmdGeneral.CommandText = "Insert Into pay_employee_timesheet(employee_code,timesheet_date,action_time_hour,action_time_minute) Values (" & Qt(DsFrmWeeklyTimeSheet1.employeeWeeklyTimeSheet.Rows(i).Item("employee_code")) & "," & Qt(ThisDateTempVar) & "," & Qt(TimeHourTempVar) & " ," & Qt(TimeMinuteTempVar) & " )"
                            Try
                                CmdGeneral.ExecuteNonQuery()
                            Catch ex As Exception
                            End Try
                        End If
                    End If
                Next
            Next
        End If
        RdoCalculated.Checked = True
        Call SetBtnEnable(True)
    End Sub
    Private Sub GridEX1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.CurrentCellChanged
        Try
            Dim CurrentRow As GridEXRow = GridEX1.GetRow()
            Call EnableDisableEditRow(CurrentRow.Cells("FlagCanEdit").Value)
            GridEX1.UpdateData()
            Dim i As Integer
            With DsFrmWeeklyTimeSheet1.employeeWeeklyTimeSheet
                For i = 0 To .Rows.Count - 1
                    .Rows(i).Item("Total") = .Rows(i).Item("Day1") & ""
                    .Rows(i).Item("Total") = MyClsTime.AddTime(.Rows(i).Item("Total") & "", .Rows(i).Item("Day2") & "")
                    .Rows(i).Item("Total") = MyClsTime.AddTime(.Rows(i).Item("Total") & "", .Rows(i).Item("Day3") & "")
                    .Rows(i).Item("Total") = MyClsTime.AddTime(.Rows(i).Item("Total") & "", .Rows(i).Item("Day4") & "")
                    .Rows(i).Item("Total") = MyClsTime.AddTime(.Rows(i).Item("Total") & "", .Rows(i).Item("Day5") & "")
                    .Rows(i).Item("Total") = MyClsTime.AddTime(.Rows(i).Item("Total") & "", .Rows(i).Item("Day6") & "")
                    .Rows(i).Item("Total") = MyClsTime.AddTime(.Rows(i).Item("Total") & "", .Rows(i).Item("Day7") & "")
                Next
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            CM.Position = CM.Position - 1
            Call FillDataset(CmbWeeks.SelectedValue)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        If CM.Position = DsFrmWeeklyTimeSheet1.employeeWeeklyTimeSheet.Rows.Count - 1 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            CM.Position = CM.Position + 1
            Call FillDataset(CmbWeeks.SelectedValue)
        End If
    End Sub
    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        Call PPreviousRecord()
    End Sub
    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        Call PNextRecord()
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Call SetBtnEnable(False)
        Call AddEmptyRecordToGrid()
        GridEX1.Focus()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call SetBtnEnable(True)
    End Sub
    Private Sub SetBtnEnable(ByVal Instatus As Boolean)
        CmbWeeks.Enabled = Instatus
        If Instatus Then
            GridEX1.AllowEdit = InheritableBoolean.False
        Else
            GridEX1.AllowEdit = InheritableBoolean.True
        End If
        RdoCalculated.Enabled = Instatus
        RdoNotCalculated.Enabled = Instatus
        BtnCancel.Enabled = Not Instatus
        BtnDelete.Enabled = Instatus
        BtnEdit.Enabled = Instatus
        BtnNext.Enabled = Instatus
        BtnPrev.Enabled = Instatus
        BtnPreview.Enabled = Instatus
        BtnPrint.Enabled = Instatus
        BtnSave.Enabled = Not Instatus
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        RdoCalculated.Checked = True
        If CmbWeeks.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Delete"
        c1.ShowFarMsg("Are you sure?")
        If c1.DialogResult = DialogResult.OK Then
            Try
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "Delete From pay_employee_timesheet Where dbo.ChangeDate(timesheet_date)>=" & Qt(ChangeDateToYYYYMMDD(MakeDateCorrect(CmbWeeks.SelectedValue))) & " AND dbo.ChangeDate(timesheet_date)<=" & Qt(ChangeDateToYYYYMMDD(MakeDateCorrect(CStr(CDate(CmbWeeks.SelectedValue).AddDays(6).Date))))
                CmdGeneral.ExecuteNonQuery()
            Catch ex As System.Data.SqlClient.SqlException
                Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
                Call PubErrHandle(myErrors.Item(0).Number)
            End Try
            Call FillDataset(CmbWeeks.SelectedValue)
        Else
            CmbWeeks.Focus()
        End If
    End Sub
    Private Sub EnableDisableEditRow(ByVal ThisValue As String)
        Try
            If ThisValue = 1 Then
                'GridEX1.RootTable.AllowEdit = InheritableBoolean.False
                GridEX1.RootTable.Columns("employee_code").Selectable = False
            Else
                'GridEX1.RootTable.AllowEdit = InheritableBoolean.True
                GridEX1.RootTable.Columns("employee_code").Selectable = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub AddEmptyRecordToGrid()
        If DsFrmWeeklyTimeSheet1.employee.Rows.Count > DsFrmWeeklyTimeSheet1.employeeWeeklyTimeSheet.Rows.Count Then
            Dim IFirstCount As Integer = DsFrmWeeklyTimeSheet1.employeeWeeklyTimeSheet.Rows.Count()
            Dim AddEmptyRecordToDetailCount As Integer
            For AddEmptyRecordToDetailCount = 1 To DsFrmWeeklyTimeSheet1.employee.Rows.Count - IFirstCount
                Call AddEmptyRecordToDetail()
            Next
        End If
    End Sub
    Private Sub AddConditionalFormatting()
        'Imports Janus.Windows.GridEX is used in this module

        'adding a format condition to use font bold when OnSale field is true
        Dim fc As GridEXFormatCondition
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GridEX1.RootTable.Columns("FlagCanEdit"), ConditionOperator.Equal, 1)
        fc.FormatStyle.FontBold = Janus.Windows.GridEX.TriState.True
        fc.FormatStyle.ForeColor = Color.Red
        GridEX1.RootTable.FormatConditions.Add(fc)

        Call AddEmptyRecordToGrid()

    End Sub
    Private Sub AddEmptyRecordToDetail()
        Dim dr As DataRow
        dr = DsFrmWeeklyTimeSheet1.employeeWeeklyTimeSheet.NewRow
        dr("employee_code") = ""
        dr("FlagCanEdit") = 0
        DsFrmWeeklyTimeSheet1.employeeWeeklyTimeSheet.Rows.Add(dr)
    End Sub
    Private Function DayName(ByVal InDay As Integer)
        Select Case InDay
            Case 0
                DayName = "Sunday"
            Case 1
                DayName = "Monday"
            Case 2
                DayName = "Tuesday"
            Case 3
                DayName = "Wednesday"
            Case 4
                DayName = "Thursday"
            Case 5
                DayName = "Friday"
            Case 6
                DayName = "Saturday"
            Case Else
                DayName = ""
        End Select
    End Function
    Private Sub CmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbYear.SelectedIndexChanged
        Call FillWeeks()
        Call FillDataset(DsFrmWeeklyTimeSheet1.YearWeeks.Rows(0).Item("WeekNo"))
        GridEX1.AllowEdit = InheritableBoolean.False
        Call SetBtnEnable(True)
    End Sub
End Class
