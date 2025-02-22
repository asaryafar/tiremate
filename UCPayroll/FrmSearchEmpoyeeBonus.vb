Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmSearchEmpoyeeBonus
    Inherits FrmBase
    Event EmployeeBonusFind(ByVal Thisid_pay_period As Int16)
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
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_main_employee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmSearchEmpoyeeBonus1 As UCPayroll.DSFrmSearchEmpoyeeBonus
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.DsFrmSearchEmpoyeeBonus1 = New UCPayroll.DSFrmSearchEmpoyeeBonus
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DApay_main_employee = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchEmpoyeeBonus1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataSource = Me.DataView1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>pay_main_employee</Caption><Columns Collect" & _
        "ion=""true""><Column0 ID=""id_pay_period""><Caption>id_pay_period</Caption><TypeName" & _
        "EmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>" & _
        "id_pay_period</DataMember><EditType>NoEdit</EditType><Key>id_pay_period</Key><Po" & _
        "sition>0</Position><Visible>False</Visible></Column0><Column1 ID=""employee_code""" & _
        "><Caption>Emp Code</Caption><DataMember>employee_code</DataMember><Key>employee_" & _
        "code</Key><Position>1</Position><Width>72</Width></Column1><Column2 ID=""l_name"">" & _
        "<Caption>Last Name</Caption><DataMember>l_name</DataMember><Key>l_name</Key><Pos" & _
        "ition>2</Position><Width>127</Width></Column2><Column3 ID=""f_name""><Caption>Firs" & _
        "t Name</Caption><DataMember>f_name</DataMember><Key>f_name</Key><Position>3</Pos" & _
        "ition></Column3><Column4 ID=""Other_Pay""><Caption>Commision / Bonus</Caption><Dat" & _
        "aMember>Other_Pay</DataMember><FormatString>c</FormatString><Key>Other_Pay</Key>" & _
        "<Position>4</Position><TextAlignment>Far</TextAlignment><Width>113</Width></Colu" & _
        "mn4><Column5 ID=""PayrollDate""><Caption>Pay Date</Caption><DataMember>PayrollDate" & _
        "</DataMember><Key>PayrollDate</Key><Position>5</Position><Width>83</Width></Colu" & _
        "mn5><Column6 ID=""PaymentFlag""><Caption>PaymentFlag</Caption><ColumnType>CheckBox" & _
        "</ColumnType><DataMember>PaymentFlag</DataMember><EditType>CheckBox</EditType><K" & _
        "ey>PaymentFlag</Key><Position>6</Position><Visible>False</Visible></Column6><Col" & _
        "umn7 ID=""gross_pay""><Caption>Gross Pay</Caption><DataMember>gross_pay</DataMembe" & _
        "r><FormatString>c2</FormatString><Key>gross_pay</Key><Position>7</Position><Text" & _
        "Alignment>Far</TextAlignment><Visible>False</Visible><Width>88</Width></Column7>" & _
        "<Column8 ID=""id_check""><Caption>id_check</Caption><DataMember>id_check</DataMemb" & _
        "er><Key>id_check</Key><Position>8</Position><Visible>False</Visible></Column8><C" & _
        "olumn9 ID=""NetPay""><Caption>Net Pay</Caption><DataMember>NetPay</DataMember><For" & _
        "matString>c2</FormatString><Key>NetPay</Key><Position>9</Position><TextAlignment" & _
        ">Far</TextAlignment><Width>91</Width></Column9></Columns><GroupCondition ID="""" /" & _
        "><Key>pay_main_employee</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 0)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(629, 355)
        Me.GrdDetail.TabIndex = 2
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsFrmSearchEmpoyeeBonus1.pay_main_employee
        '
        'DsFrmSearchEmpoyeeBonus1
        '
        Me.DsFrmSearchEmpoyeeBonus1.DataSetName = "DSFrmSearchEmpoyeeBonus"
        Me.DsFrmSearchEmpoyeeBonus1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=Tiremate_03"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CmdOk)
        Me.Panel2.Controls.Add(Me.CmdExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 355)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(629, 33)
        Me.Panel2.TabIndex = 21
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdOk.ForeColor = System.Drawing.Color.Black
        Me.CmdOk.Location = New System.Drawing.Point(447, 5)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 24)
        Me.CmdOk.TabIndex = 22
        Me.CmdOk.Text = "Ok"
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdExit.ForeColor = System.Drawing.Color.Black
        Me.CmdExit.Location = New System.Drawing.Point(543, 5)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT pay_main_employee.id_pay_period, pay_main_employee.employee_code, pay_main" & _
        "_employee.Other_Pay, pay_main_employee.PayrollDate, pay_main_employee.PaymentFla" & _
        "g, employee.l_name, employee.f_name, pay_main_employee.gross_pay, pay_main_emplo" & _
        "yee.id_check, View_EmployeeNetPay.NetPay FROM pay_main_employee INNER JOIN emplo" & _
        "yee ON pay_main_employee.employee_code = employee.employee_code INNER JOIN View_" & _
        "EmployeeNetPay ON pay_main_employee.employee_code = View_EmployeeNetPay.employee" & _
        "_code AND pay_main_employee.PayrollDate = View_EmployeeNetPay.PayrollDate WHERE " & _
        "(pay_main_employee.Payment_Type = '1')"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DApay_main_employee
        '
        Me.DApay_main_employee.SelectCommand = Me.SqlSelectCommand2
        Me.DApay_main_employee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_main_employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_pay_period", "id_pay_period"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("day_work", "day_work"), New System.Data.Common.DataColumnMapping("time_work_Hour", "time_work_Hour"), New System.Data.Common.DataColumnMapping("time_work_Minute", "time_work_Minute"), New System.Data.Common.DataColumnMapping("Other_Pay", "Other_Pay"), New System.Data.Common.DataColumnMapping("gross_pay", "gross_pay"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("PayrollDate", "PayrollDate"), New System.Data.Common.DataColumnMapping("PaymentFlag", "PaymentFlag"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'FrmSearchEmpoyeeBonus
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(629, 388)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSearchEmpoyeeBonus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find Employee Bonus"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchEmpoyeeBonus1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSearchBankDeposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Try
            Cnn.ConnectionString = PConnectionString
        Catch ex As Exception
        End Try
        Call FillDataSet()
    End Sub
    Private Sub FillDataSet()
        DsFrmSearchEmpoyeeBonus1.pay_main_employee.Clear()
        DApay_main_employee.Fill(DsFrmSearchEmpoyeeBonus1, "pay_main_employee")
        DataView1.RowFilter = ""
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent EmployeeBonusFind(GrdDetail.GetRow.Cells(0).Value)
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Call GrdDetail_DoubleClick(sender, e)
        Me.Close()
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
End Class
