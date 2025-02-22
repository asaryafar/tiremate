Imports TimeBox
Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmRepEmployeeTime
    Inherits FrmBase
    Dim DApay_punch_employee_in_outOriginalVar
    Dim So As New Janus.Windows.GridEX.SortOrder
    Dim MyClsTime As New ClsTime
    Dim WhereCluaseVar As String
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents PanelStor As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DteMaxDate As CalendarCombo.CalendarCombo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DteMinDate As CalendarCombo.CalendarCombo
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnChooseEmployee As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnChoosePosition As Janus.Windows.EditControls.UIButton
    Friend WithEvents RdoSelectedeEmployee As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RdoAllEmployee As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RdoSelectedPosition As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RdoAllPosition As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAEmployee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAemployee_position As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents RdoSummary As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RdoDetail As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents DsFrmRepEmployeeTime1 As UCTimeSheet.DSFrmRepEmployeeTime
    Friend WithEvents ChkAllDate As Janus.Windows.EditControls.UICheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepEmployeeTime))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RdoSummary = New Janus.Windows.EditControls.UIRadioButton
        Me.RdoDetail = New Janus.Windows.EditControls.UIRadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnChoosePosition = New Janus.Windows.EditControls.UIButton
        Me.RdoSelectedPosition = New Janus.Windows.EditControls.UIRadioButton
        Me.RdoAllPosition = New Janus.Windows.EditControls.UIRadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnChooseEmployee = New Janus.Windows.EditControls.UIButton
        Me.RdoSelectedeEmployee = New Janus.Windows.EditControls.UIRadioButton
        Me.RdoAllEmployee = New Janus.Windows.EditControls.UIRadioButton
        Me.PanelStor = New System.Windows.Forms.GroupBox
        Me.ChkAllDate = New Janus.Windows.EditControls.UICheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.DteMaxDate = New CalendarCombo.CalendarCombo
        Me.Label1 = New System.Windows.Forms.Label
        Me.DteMinDate = New CalendarCombo.CalendarCombo
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.BtnOk = New Janus.Windows.EditControls.UIButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAEmployee = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAemployee_position = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmRepEmployeeTime1 = New UCTimeSheet.DSFrmRepEmployeeTime
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelStor.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmRepEmployeeTime1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=TireMate_01"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PanelStor)
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.BtnOk)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 246)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RdoSummary)
        Me.GroupBox3.Controls.Add(Me.RdoDetail)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(410, 101)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(83, 81)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'RdoSummary
        '
        Me.RdoSummary.Location = New System.Drawing.Point(8, 48)
        Me.RdoSummary.Name = "RdoSummary"
        Me.RdoSummary.Size = New System.Drawing.Size(73, 23)
        Me.RdoSummary.TabIndex = 1
        Me.RdoSummary.Text = "Summary"
        '
        'RdoDetail
        '
        Me.RdoDetail.Checked = True
        Me.RdoDetail.Location = New System.Drawing.Point(8, 13)
        Me.RdoDetail.Name = "RdoDetail"
        Me.RdoDetail.Size = New System.Drawing.Size(57, 23)
        Me.RdoDetail.TabIndex = 0
        Me.RdoDetail.Text = "Detail"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnChoosePosition)
        Me.GroupBox2.Controls.Add(Me.RdoSelectedPosition)
        Me.GroupBox2.Controls.Add(Me.RdoAllPosition)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(0, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 48)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'BtnChoosePosition
        '
        Me.BtnChoosePosition.Location = New System.Drawing.Point(319, 13)
        Me.BtnChoosePosition.Name = "BtnChoosePosition"
        Me.BtnChoosePosition.Size = New System.Drawing.Size(75, 23)
        Me.BtnChoosePosition.TabIndex = 2
        Me.BtnChoosePosition.Text = "Choose"
        '
        'RdoSelectedPosition
        '
        Me.RdoSelectedPosition.Location = New System.Drawing.Point(151, 13)
        Me.RdoSelectedPosition.Name = "RdoSelectedPosition"
        Me.RdoSelectedPosition.Size = New System.Drawing.Size(135, 23)
        Me.RdoSelectedPosition.TabIndex = 1
        Me.RdoSelectedPosition.Text = "Selected Positions"
        '
        'RdoAllPosition
        '
        Me.RdoAllPosition.Checked = True
        Me.RdoAllPosition.Location = New System.Drawing.Point(15, 13)
        Me.RdoAllPosition.Name = "RdoAllPosition"
        Me.RdoAllPosition.Size = New System.Drawing.Size(104, 23)
        Me.RdoAllPosition.TabIndex = 0
        Me.RdoAllPosition.Text = "All Positions"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnChooseEmployee)
        Me.GroupBox1.Controls.Add(Me.RdoSelectedeEmployee)
        Me.GroupBox1.Controls.Add(Me.RdoAllEmployee)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'BtnChooseEmployee
        '
        Me.BtnChooseEmployee.Location = New System.Drawing.Point(319, 13)
        Me.BtnChooseEmployee.Name = "BtnChooseEmployee"
        Me.BtnChooseEmployee.Size = New System.Drawing.Size(75, 23)
        Me.BtnChooseEmployee.TabIndex = 2
        Me.BtnChooseEmployee.Text = "Choose"
        '
        'RdoSelectedeEmployee
        '
        Me.RdoSelectedeEmployee.Location = New System.Drawing.Point(151, 13)
        Me.RdoSelectedeEmployee.Name = "RdoSelectedeEmployee"
        Me.RdoSelectedeEmployee.Size = New System.Drawing.Size(135, 23)
        Me.RdoSelectedeEmployee.TabIndex = 1
        Me.RdoSelectedeEmployee.Text = "Selected Employee"
        '
        'RdoAllEmployee
        '
        Me.RdoAllEmployee.Checked = True
        Me.RdoAllEmployee.Location = New System.Drawing.Point(15, 13)
        Me.RdoAllEmployee.Name = "RdoAllEmployee"
        Me.RdoAllEmployee.Size = New System.Drawing.Size(104, 23)
        Me.RdoAllEmployee.TabIndex = 0
        Me.RdoAllEmployee.Text = "All Employees"
        '
        'PanelStor
        '
        Me.PanelStor.Controls.Add(Me.ChkAllDate)
        Me.PanelStor.Controls.Add(Me.Label2)
        Me.PanelStor.Controls.Add(Me.DteMaxDate)
        Me.PanelStor.Controls.Add(Me.Label1)
        Me.PanelStor.Controls.Add(Me.DteMinDate)
        Me.PanelStor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelStor.Location = New System.Drawing.Point(0, 48)
        Me.PanelStor.Name = "PanelStor"
        Me.PanelStor.Size = New System.Drawing.Size(497, 48)
        Me.PanelStor.TabIndex = 0
        Me.PanelStor.TabStop = False
        '
        'ChkAllDate
        '
        Me.ChkAllDate.Location = New System.Drawing.Point(9, 13)
        Me.ChkAllDate.Name = "ChkAllDate"
        Me.ChkAllDate.Size = New System.Drawing.Size(78, 23)
        Me.ChkAllDate.TabIndex = 0
        Me.ChkAllDate.Text = "All Dates"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(279, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 408
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
        Me.DteMaxDate.Location = New System.Drawing.Point(313, 13)
        Me.DteMaxDate.MaxValue = CType(2500, Short)
        Me.DteMaxDate.MinValue = CType(1800, Short)
        Me.DteMaxDate.Name = "DteMaxDate"
        Me.DteMaxDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteMaxDate.Sal_Mali = Nothing
        Me.DteMaxDate.ShowButton = True
        Me.DteMaxDate.Size = New System.Drawing.Size(110, 23)
        Me.DteMaxDate.TabIndex = 2
        Me.DteMaxDate.VisualStyle = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(107, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 14)
        Me.Label1.TabIndex = 406
        Me.Label1.Text = "From"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.DteMinDate.Location = New System.Drawing.Point(145, 13)
        Me.DteMinDate.MaxValue = CType(2500, Short)
        Me.DteMinDate.MinValue = CType(1800, Short)
        Me.DteMinDate.Name = "DteMinDate"
        Me.DteMinDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteMinDate.Sal_Mali = Nothing
        Me.DteMinDate.ShowButton = True
        Me.DteMinDate.Size = New System.Drawing.Size(110, 23)
        Me.DteMinDate.TabIndex = 1
        Me.DteMinDate.VisualStyle = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(378, 208)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 0
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(43, 208)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(75, 23)
        Me.BtnOk.TabIndex = 6
        Me.BtnOk.Text = "Ok"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(497, 48)
        Me.Panel4.TabIndex = 405
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(64, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 46)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Select a date range and any desired options followed by OK  to print the report"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 190
        Me.PictureBox2.TabStop = False
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
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT employee_code AS Code, f_name + ' ' + m_name + ' ' + l_name AS Name, 0 AS " & _
        "Flag FROM employee"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAEmployee
        '
        Me.DAEmployee.SelectCommand = Me.SqlSelectCommand1
        Me.DAEmployee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("technecian", "technecian"), New System.Data.Common.DataColumnMapping("SalesPerson", "SalesPerson"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("cod_deparment", "cod_deparment"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("pic", "pic"), New System.Data.Common.DataColumnMapping("birthday_date", "birthday_date"), New System.Data.Common.DataColumnMapping("hired_date", "hired_date"), New System.Data.Common.DataColumnMapping("last_reiew_date", "last_reiew_date"), New System.Data.Common.DataColumnMapping("terminate_date", "terminate_date"), New System.Data.Common.DataColumnMapping("temporary_inactive", "temporary_inactive"), New System.Data.Common.DataColumnMapping("last_basis", "last_basis"), New System.Data.Common.DataColumnMapping("last_period", "last_period"), New System.Data.Common.DataColumnMapping("last_status", "last_status"), New System.Data.Common.DataColumnMapping("last_salary", "last_salary"), New System.Data.Common.DataColumnMapping("last_hourly", "last_hourly"), New System.Data.Common.DataColumnMapping("last_overtime", "last_overtime"), New System.Data.Common.DataColumnMapping("Last_raise_date", "Last_raise_date"), New System.Data.Common.DataColumnMapping("Allowance_Federal", "Allowance_Federal"), New System.Data.Common.DataColumnMapping("Allowance_state", "Allowance_state"), New System.Data.Common.DataColumnMapping("Allowance_depndnts", "Allowance_depndnts"), New System.Data.Common.DataColumnMapping("Terminated", "Terminated"), New System.Data.Common.DataColumnMapping("StoreNo", "StoreNo"), New System.Data.Common.DataColumnMapping("UsePunchClock", "UsePunchClock")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_position AS code, desc_position AS Name, 0 AS Flag FROM employee_posit" & _
        "ion"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAemployee_position
        '
        Me.DAemployee_position.SelectCommand = Me.SqlSelectCommand2
        Me.DAemployee_position.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee_position", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("desc_position", "desc_position"), New System.Data.Common.DataColumnMapping("service_ok", "service_ok")})})
        '
        'DsFrmRepEmployeeTime1
        '
        Me.DsFrmRepEmployeeTime1.DataSetName = "DSFrmRepEmployeeTime"
        Me.DsFrmRepEmployeeTime1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'FrmRepEmployeeTime
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(497, 246)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmRepEmployeeTime"
        Me.Text = "Employee Reports"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.PanelStor.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmRepEmployeeTime1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmEmployeeInOutBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        DteMinDate.Text = Format(DateTime.Now, PubDateFormat.ToString)
        DteMaxDate.Text = Format(DateTime.Now, PubDateFormat.ToString)
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If ChkAllDate.Checked Then
            WhereCluaseVar = " Where In_Out_type=0 "
        Else
            WhereCluaseVar = " Where In_Out_type=0 AND dbo.changedate(action_date)>=" & Qt(ChangeDateToYYYYMMDD(DteMinDate.Text)) & " AND dbo.changedate(action_date)<=" & Qt(ChangeDateToYYYYMMDD(DteMaxDate.Text))
        End If
        If RdoSelectedeEmployee.Checked Then
            Dim i As Integer
            Dim InlistVar As String = ""
            Dim InlistOperator As String = "("
            For i = 0 To DsFrmRepEmployeeTime1.employee.Rows.Count - 1
                If DsFrmRepEmployeeTime1.employee.Rows(i).Item("Flag") = True Then
                    InlistVar = InlistVar & InlistOperator & Qt(DsFrmRepEmployeeTime1.employee.Rows(i).Item("code"))
                    InlistOperator = ","
                End If
            Next
            If InlistVar.Trim.Length > 0 Then
                InlistVar = InlistVar & "))"
                WhereCluaseVar = WhereCluaseVar & " AND (pay_punch_employee_in_out.employee_code IN " & InlistVar
            Else
                WhereCluaseVar = WhereCluaseVar & " AND 1=2 "
            End If
        End If
        If RdoSelectedPosition.Checked Then
            Dim i As Integer
            Dim InlistVar As String = ""
            Dim InlistOperator As String = "("
            For i = 0 To DsFrmRepEmployeeTime1.employee_position.Rows.Count - 1
                If DsFrmRepEmployeeTime1.employee_position.Rows(i).Item("Flag") = True Then
                    InlistVar = InlistVar & InlistOperator & Qt(DsFrmRepEmployeeTime1.employee_position.Rows(i).Item("code"))
                    InlistOperator = ","
                End If
            Next
            If InlistVar.Trim.Length > 0 Then
                InlistVar = InlistVar & "))"
                WhereCluaseVar = WhereCluaseVar & " AND (employee.cod_position IN " & InlistVar
            Else
                WhereCluaseVar = WhereCluaseVar & " AND 1=2 "
            End If
        End If
        If RdoDetail.Checked Then
            Dim MyFrmRepEmployeeTimeDetail As New FrmRepEmployeeTimeDetail
            MyFrmRepEmployeeTimeDetail.WhereCluaseVar = WhereCluaseVar
            If ChkAllDate.Checked Then
                MyFrmRepEmployeeTimeDetail.Date1 = ""
                MyFrmRepEmployeeTimeDetail.Date2 = ""
            Else
                MyFrmRepEmployeeTimeDetail.Date1 = DteMinDate.Text
                MyFrmRepEmployeeTimeDetail.Date2 = DteMaxDate.Text
            End If
            MyFrmRepEmployeeTimeDetail.ShowDialog()
        Else
            Dim MyFrmRepEmployeeTimeSummary As New FrmRepEmployeeTimeSummary
            MyFrmRepEmployeeTimeSummary.WhereCluaseVar = WhereCluaseVar
            If ChkAllDate.Checked Then
                MyFrmRepEmployeeTimeSummary.Date1 = ""
                MyFrmRepEmployeeTimeSummary.Date2 = ""
            Else
                MyFrmRepEmployeeTimeSummary.Date1 = DteMinDate.Text
                MyFrmRepEmployeeTimeSummary.Date2 = DteMaxDate.Text
            End If
            MyFrmRepEmployeeTimeSummary.ShowDialog()
        End If

    End Sub
    Private Sub BtnChooseEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChooseEmployee.Click
        Dim f As New FrmSelect
        BtnChooseEmployee.Enabled = False
        RdoSelectedeEmployee.Checked = True
        If DsFrmRepEmployeeTime1.employee.Count = 0 Then
            DsFrmRepEmployeeTime1.employee.Clear()
            DAEmployee.Fill(DsFrmRepEmployeeTime1.employee)
        End If
        f.Text = "  Select Employee"
        f.DSFrmSelectDatasetVar = DsFrmRepEmployeeTime1
        f.TypeOfForm = FrmSelect.KindForm.Employee
        f.StartPosition = FormStartPosition.CenterScreen
        f.ShowDialog()
        BtnChooseEmployee.Enabled = True
    End Sub
    Private Sub BtnChoosePosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChoosePosition.Click
        Dim f As New FrmSelect
        BtnChoosePosition.Enabled = False
        RdoSelectedPosition.Checked = True
        If DsFrmRepEmployeeTime1.employee_position.Count = 0 Then
            DsFrmRepEmployeeTime1.employee_position.Clear()
            DAemployee_position.Fill(DsFrmRepEmployeeTime1.employee_position)
        End If
        f.Text = "  Select Position"
        f.DSFrmSelectDatasetVar = DsFrmRepEmployeeTime1
        f.TypeOfForm = FrmSelect.KindForm.EmployeePosition
        f.StartPosition = FormStartPosition.CenterScreen
        f.ShowDialog()
        BtnChoosePosition.Enabled = True
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class
