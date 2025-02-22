Imports CommonClass
Public Class FrmPayCheck
    Inherits FrmBase
    Friend ConfirmFlag As Boolean = False
    Friend CountinueFlag As Boolean = True
    Friend EmplyeeCodeVar As String
    Friend PayrollDateVar As String
    Friend Id_bankVar As Int64
    Friend CheckDateVar As String
    Friend Id_pay_periodVar As Int64
    Dim WithEvents MyFrmCheckScreen As UcAccount.FrmCheckScreen
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents DsFrmPayCheck1 As UCPayroll.DSFrmPayCheck
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Employee_Cod1 As UCEmployee.Employee_Cod
    Friend WithEvents GridEX2 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintCheque As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnConfirm As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnNotConfirm As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumCheckAmount As CalcUtils.UcCalcText
    Friend WithEvents BtnConfirmAndPrintCheck As Janus.Windows.EditControls.UIButton
    Friend WithEvents GridEX3 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPayCheck))
        Dim GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblEmployeeName = New System.Windows.Forms.Label
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmPayCheck1 = New UCPayroll.DSFrmPayCheck
        Me.Label1 = New System.Windows.Forms.Label
        Me.Employee_Cod1 = New UCEmployee.Employee_Cod
        Me.GridEX2 = New Janus.Windows.GridEX.GridEX
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnPrintCheque = New Janus.Windows.EditControls.UIButton
        Me.BtnConfirm = New Janus.Windows.EditControls.UIButton
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.BtnNotConfirm = New Janus.Windows.EditControls.UIButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.NumCheckAmount = New CalcUtils.UcCalcText
        Me.BtnConfirmAndPrintCheck = New Janus.Windows.EditControls.UIButton
        Me.GridEX3 = New Janus.Windows.GridEX.GridEX
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmPayCheck1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(6, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 416
        Me.Label5.Text = "Employee"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblEmployeeName
        '
        Me.LblEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEmployeeName.Location = New System.Drawing.Point(167, 2)
        Me.LblEmployeeName.Name = "LblEmployeeName"
        Me.LblEmployeeName.Size = New System.Drawing.Size(287, 23)
        Me.LblEmployeeName.TabIndex = 417
        Me.LblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridEX1
        '
        Me.GridEX1.DataMember = "PayCheckEmployee"
        Me.GridEX1.DataSource = Me.DsFrmPayCheck1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>PayCheck</Caption><Columns Collection=""true" & _
        """><Column0 ID=""Desc""><Caption>Desc</Caption><DataMember>Desc</DataMember><EditTy" & _
        "pe>NoEdit</EditType><Key>Desc</Key><Position>0</Position><Width>245</Width></Col" & _
        "umn0><Column1 ID=""Amount""><AggregateFunction>Sum</AggregateFunction><Caption>Amo" & _
        "unt</Caption><DataMember>Amount</DataMember><EditType>NoEdit</EditType><FilterEd" & _
        "itType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>Amount</Key><" & _
        "Position>1</Position><TextAlignment>Far</TextAlignment><TotalFormatString>c2</To" & _
        "talFormatString></Column1></Columns><GroupCondition ID="""" /><Key>PayCheck</Key><" & _
        "/RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(65, 46)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(373, 99)
        Me.GridEX1.TabIndex = 418
        '
        'DsFrmPayCheck1
        '
        Me.DsFrmPayCheck1.DataSetName = "DSFrmPayCheck"
        Me.DsFrmPayCheck1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(67, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 19)
        Me.Label1.TabIndex = 419
        Me.Label1.Text = "Employee Summary"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Employee_Cod1
        '
        Me.Employee_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Employee_Cod1.Connection = Me.Cnn
        Me.Employee_Cod1.EmployeeCod = ""
        Me.Employee_Cod1.EmployeeCodLen = 5
        Me.Employee_Cod1.Enabled = False
        Me.Employee_Cod1.Kind_Employee = ""
        Me.Employee_Cod1.Location = New System.Drawing.Point(63, 3)
        Me.Employee_Cod1.Name = "Employee_Cod1"
        Me.Employee_Cod1.NotExitIfNotFound = False
        Me.Employee_Cod1.ReleaseIfNotFoundEmployeeCod = False
        Me.Employee_Cod1.Size = New System.Drawing.Size(101, 20)
        Me.Employee_Cod1.TabIndex = 420
        '
        'GridEX2
        '
        Me.GridEX2.DataMember = "PayCheckEmployer"
        Me.GridEX2.DataSource = Me.DsFrmPayCheck1
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Caption>PayCheck</Caption><Columns Collection=""true" & _
        """><Column0 ID=""Desc""><Caption>Desc</Caption><DataMember>Desc</DataMember><EditTy" & _
        "pe>NoEdit</EditType><Key>Desc</Key><Position>0</Position><Width>245</Width></Col" & _
        "umn0><Column1 ID=""Amount""><AggregateFunction>Sum</AggregateFunction><Caption>Amo" & _
        "unt</Caption><DataMember>Amount</DataMember><EditType>NoEdit</EditType><FormatSt" & _
        "ring>c2</FormatString><Key>Amount</Key><Position>1</Position><TextAlignment>Far<" & _
        "/TextAlignment><TotalFormatString>c2</TotalFormatString></Column1></Columns><Gro" & _
        "upCondition ID="""" /><Key>PayCheck</Key></RootTable></GridEXLayoutData>"
        Me.GridEX2.DesignTimeLayout = GridEXLayout2
        Me.GridEX2.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX2.GroupByBoxVisible = False
        Me.GridEX2.Location = New System.Drawing.Point(65, 293)
        Me.GridEX2.Name = "GridEX2"
        Me.GridEX2.Size = New System.Drawing.Size(373, 119)
        Me.GridEX2.TabIndex = 421
        Me.GridEX2.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GridEX2.TotalRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(68, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 422
        Me.Label2.Text = "Employer Summary"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnPrintCheque
        '
        Me.BtnPrintCheque.Location = New System.Drawing.Point(287, 416)
        Me.BtnPrintCheque.Name = "BtnPrintCheque"
        Me.BtnPrintCheque.Size = New System.Drawing.Size(76, 51)
        Me.BtnPrintCheque.TabIndex = 423
        Me.BtnPrintCheque.Text = "Print Check"
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Location = New System.Drawing.Point(195, 416)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(76, 51)
        Me.BtnConfirm.TabIndex = 424
        Me.BtnConfirm.Text = "Confirm Payment"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(11, 416)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(76, 51)
        Me.BtnCancel.TabIndex = 425
        Me.BtnCancel.Text = "Cancel"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'BtnNotConfirm
        '
        Me.BtnNotConfirm.Location = New System.Drawing.Point(103, 416)
        Me.BtnNotConfirm.Name = "BtnNotConfirm"
        Me.BtnNotConfirm.Size = New System.Drawing.Size(76, 51)
        Me.BtnNotConfirm.TabIndex = 426
        Me.BtnNotConfirm.Text = "Not Confirm Payment"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(196, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 427
        Me.Label3.Text = "Check Amount :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumCheckAmount
        '
        Me.NumCheckAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumCheckAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumCheckAmount.DecimalDigits = 2
        Me.NumCheckAmount.DefaultSendValue = False
        Me.NumCheckAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumCheckAmount.FireTabAfterEnter = True
        Me.NumCheckAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumCheckAmount.Image = CType(resources.GetObject("NumCheckAmount.Image"), System.Drawing.Image)
        Me.NumCheckAmount.Location = New System.Drawing.Point(312, 262)
        Me.NumCheckAmount.Maxlength = 10
        Me.NumCheckAmount.MinusColor = System.Drawing.Color.Empty
        Me.NumCheckAmount.Name = "NumCheckAmount"
        Me.NumCheckAmount.ReadOnly = True
        Me.NumCheckAmount.Size = New System.Drawing.Size(110, 22)
        Me.NumCheckAmount.TabIndex = 428
        Me.NumCheckAmount.TabStop = False
        Me.NumCheckAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCheckAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'BtnConfirmAndPrintCheck
        '
        Me.BtnConfirmAndPrintCheck.Location = New System.Drawing.Point(379, 416)
        Me.BtnConfirmAndPrintCheck.Name = "BtnConfirmAndPrintCheck"
        Me.BtnConfirmAndPrintCheck.Size = New System.Drawing.Size(76, 51)
        Me.BtnConfirmAndPrintCheck.TabIndex = 429
        Me.BtnConfirmAndPrintCheck.Text = "Confirm Payment And Print Check"
        '
        'GridEX3
        '
        Me.GridEX3.DataMember = "PayCheckEmployeeForChange"
        Me.GridEX3.DataSource = Me.DsFrmPayCheck1
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><Caption>PayCheck</Caption><Columns Collection=""true" & _
        """><Column0 ID=""Desc""><Caption>Desc</Caption><DataMember>Desc</DataMember><EditTy" & _
        "pe>NoEdit</EditType><Key>Desc</Key><Position>0</Position><Width>245</Width></Col" & _
        "umn0><Column1 ID=""Amount""><AggregateFunction>Sum</AggregateFunction><Caption>Amo" & _
        "unt</Caption><DataMember>Amount</DataMember><FormatString>c2</FormatString><Inpu" & _
        "tMask>Currency2</InputMask><Key>Amount</Key><Position>1</Position><TextAlignment" & _
        ">Far</TextAlignment><TotalFormatString>c2</TotalFormatString></Column1></Columns" & _
        "><GroupCondition ID="""" /><Key>PayCheck</Key></RootTable></GridEXLayoutData>"
        Me.GridEX3.DesignTimeLayout = GridEXLayout3
        Me.GridEX3.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX3.GroupByBoxVisible = False
        Me.GridEX3.Location = New System.Drawing.Point(65, 146)
        Me.GridEX3.Name = "GridEX3"
        Me.GridEX3.Size = New System.Drawing.Size(373, 110)
        Me.GridEX3.TabIndex = 430
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(4, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 81)
        Me.Label4.TabIndex = 431
        Me.Label4.Text = "Changable Value "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmPayCheck
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 468)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GridEX3)
        Me.Controls.Add(Me.GridEX2)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.BtnConfirmAndPrintCheck)
        Me.Controls.Add(Me.NumCheckAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnNotConfirm)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.BtnPrintCheque)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Employee_Cod1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblEmployeeName)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FrmPayCheck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pay Check"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmPayCheck1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmPayCheck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Employee_Cod1.EmployeeCod = EmplyeeCodeVar
        Call CalcNetPay()
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT PaymentFlag FROM pay_main_employee WHERE employee_code=" & Qt(EmplyeeCodeVar) & " AND PayrollDate=" & Qt(MakeDateCorrect(PayrollDateVar))
        Try
            If CmdGeneral.ExecuteScalar Then
                GridEX3.RootTable.Columns("Amount").EditType = Janus.Windows.GridEX.EditType.NoEdit
            Else
                GridEX3.RootTable.Columns("Amount").EditType = Janus.Windows.GridEX.EditType.TextBox
            End If
        Catch ex As Exception
            GridEX3.RootTable.Columns("Amount").EditType = Janus.Windows.GridEX.EditType.TextBox
        End Try
    End Sub
    Private Sub Employee_Cod1_FindEmployeeCod() Handles Employee_Cod1.FindEmployeeCod
        LblEmployeeName.Text = Employee_Cod1.Desc_Employee
    End Sub
    Private Sub Employee_Cod1_NotFindEmployeeCod() Handles Employee_Cod1.NotFindEmployeeCod
        LblEmployeeName.Text = ""
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        CountinueFlag = False
        ConfirmFlag = False
        Me.Close()
    End Sub
    Private Sub BtnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirm.Click
        CountinueFlag = True
        ConfirmFlag = True
        Call SaveDetail()
        Me.Close()
    End Sub
    Private Sub BtnNotConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotConfirm.Click
        CountinueFlag = True
        ConfirmFlag = False
        Me.Close()
    End Sub
    Private Sub BtnPrintCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintCheque.Click
        'MsgBox("Under Construction")
        'Exit Sub
        MyFrmCheckScreen = New UcAccount.FrmCheckScreen
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT id_check FROM pay_main_employee WHERE employee_code=" & Qt(EmplyeeCodeVar) & " AND PayrollDate=" & Qt(PayrollDateVar)
        Dim ReturndIdcheck As Int64
        Try
            ReturndIdcheck = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            ReturndIdcheck = 0
        End Try
        If ReturndIdcheck > 0 Then
            MyFrmCheckScreen.PrintThis(ReturndIdcheck)
        Else
            CmdGeneral.CommandText = "SELECT PaymentFlag FROM pay_main_employee WHERE employee_code=" & Qt(EmplyeeCodeVar) & " AND PayrollDate=" & Qt(MakeDateCorrect(PayrollDateVar))
            If NumCheckAmount.Numbervalue > 0 Then
                If CmdGeneral.ExecuteScalar Then
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If

                    Dim ds1 As New UcAccount.DSFrmCheckScreen
                    'Dim Dt1 As DSFrmCheckScreen.bank_check_dtlDataTable
                    ReturndIdcheck = 0

                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If

                    Dim dr As DataRow
                    dr = ds1.bank_check_dtl.NewRow
                    dr("id_check") = 0
                    dr("radif") = 1
                    dr("gl_account") = Retrieve_GLAccount("01")
                    dr("amount") = NumCheckAmount.Text
                    dr("memo_dtl") = "Net Pay"
                    ds1.bank_check_dtl.Rows.Add(dr)
                    MyFrmCheckScreen.SaveAndPrint(Id_bankVar, CheckDateVar, NumCheckAmount.Text, EmplyeeCodeVar, ds1.bank_check_dtl, ReturndIdcheck)
                    'If ReturndIdcheck > 0 Then
                    '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    '        CmdGeneral.Connection.Open()
                    '    End If
                    '    CmdGeneral.CommandText = "UPDATE pay_main_employee SET id_check = " & ReturndIdcheck & " WHERE id_pay_period=" & Id_pay_periodVar
                    '    CmdGeneral.ExecuteNonQuery()
                    'End If
                Else
                    MsgBox("Please Confirm Payment and then print Check")
                End If
            End If
        End If
    End Sub
    Private Sub BtnConfirmAndPrintCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirmAndPrintCheck.Click
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Update pay_main_employee Set PaymentFlag=1 Where id_pay_period=" & Id_pay_periodVar
        CmdGeneral.ExecuteNonQuery()
        CountinueFlag = True
        ConfirmFlag = False
        Call BtnPrintCheque_Click(sender, e)
        Me.Close()
    End Sub
    Private Sub MyFrmCheckScreen_AfterSaveAnEmployee(ByVal ThisIdCheck As Long) Handles MyFrmCheckScreen.AfterSaveAnEmployee
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "UPDATE pay_main_employee SET id_check = " & ThisIdCheck & " WHERE id_pay_period=" & Id_pay_periodVar
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub SaveDetail()
        Dim SaveDetailCounter As Integer
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        For SaveDetailCounter = 0 To DsFrmPayCheck1.PayCheckEmployeeForChange.Rows.Count - 1
            Try
                CmdGeneral.CommandText = "UPDATE pay_deductin_main_dtl SET amount_deduction_employee = " & DsFrmPayCheck1.PayCheckEmployeeForChange.Rows(SaveDetailCounter).Item("Amount") & " WHERE id_pay_period=" & DsFrmPayCheck1.PayCheckEmployeeForChange.Rows(SaveDetailCounter).Item("id_pay_period") & " AND deduction_type=" & DsFrmPayCheck1.PayCheckEmployeeForChange.Rows(SaveDetailCounter).Item("deduction_type") & " AND id_deduction=" & DsFrmPayCheck1.PayCheckEmployeeForChange.Rows(SaveDetailCounter).Item("id_deduction")
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error in Save")
            End Try
        Next
    End Sub
    Private Sub GridEX3_CurrentCellChanging(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.CurrentCellChangingEventArgs) Handles GridEX3.CurrentCellChanging
        Call CalcNetPay()
    End Sub
    Private Sub CalcNetPay()
        NumCheckAmount.Text = 0
        Dim i As Integer
        For i = 0 To DsFrmPayCheck1.PayCheckEmployee.Rows.Count - 1
            NumCheckAmount.Text = NumCheckAmount.Numbervalue + (DsFrmPayCheck1.PayCheckEmployee.Rows(i).Item("DeductionZarib") * DsFrmPayCheck1.PayCheckEmployee.Rows(i).Item("Amount"))
        Next
        For i = 0 To DsFrmPayCheck1.PayCheckEmployeeForChange.Rows.Count - 1
            NumCheckAmount.Text = NumCheckAmount.Numbervalue + (DsFrmPayCheck1.PayCheckEmployeeForChange.Rows(i).Item("DeductionZarib") * DsFrmPayCheck1.PayCheckEmployeeForChange.Rows(i).Item("Amount"))
        Next
    End Sub
End Class
