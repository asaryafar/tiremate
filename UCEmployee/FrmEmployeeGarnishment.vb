Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmEmployeeGarnishment
    Inherits FrmBase
    Friend Status As WorkStates = MainModule.WorkStates._ReadOnly
    Public EmployeeCodVar As String = ""
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DteDate_start As CalendarCombo.CalendarCombo
    Friend WithEvents ChkActive As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtremark As System.Windows.Forms.TextBox
    Friend WithEvents Numamount_garnishment As CalcUtils.UcCalcText
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents ChkBeforeTax As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEmployeeGarnishment))
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DteDate_start = New CalendarCombo.CalendarCombo
        Me.Numamount_garnishment = New CalcUtils.UcCalcText
        Me.ChkActive = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txtremark = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.BtnSave = New Janus.Windows.EditControls.UIButton
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.ChkBeforeTax = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'DteDate_start
        '
        Me.DteDate_start.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteDate_start.BorderColor = System.Drawing.Color.Empty
        Me.DteDate_start.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteDate_start.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteDate_start.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteDate_start.EditableSal = True
        Me.DteDate_start.Image = CType(resources.GetObject("DteDate_start.Image"), System.Drawing.Image)
        Me.DteDate_start.Location = New System.Drawing.Point(66, 6)
        Me.DteDate_start.MaxValue = CType(2500, Short)
        Me.DteDate_start.MinValue = CType(1800, Short)
        Me.DteDate_start.Name = "DteDate_start"
        Me.DteDate_start.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteDate_start.Sal_Mali = Nothing
        Me.DteDate_start.ShowButton = True
        Me.DteDate_start.Size = New System.Drawing.Size(104, 23)
        Me.DteDate_start.TabIndex = 0
        Me.DteDate_start.VisualStyle = False
        '
        'Numamount_garnishment
        '
        Me.Numamount_garnishment.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numamount_garnishment.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numamount_garnishment.DecimalDigits = 2
        Me.Numamount_garnishment.DefaultSendValue = False
        Me.Numamount_garnishment.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numamount_garnishment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Numamount_garnishment.Image = CType(resources.GetObject("Numamount_garnishment.Image"), System.Drawing.Image)
        Me.Numamount_garnishment.Location = New System.Drawing.Point(67, 37)
        Me.Numamount_garnishment.Maxlength = 10
        Me.Numamount_garnishment.MinusColor = System.Drawing.Color.Empty
        Me.Numamount_garnishment.Name = "Numamount_garnishment"
        Me.Numamount_garnishment.Size = New System.Drawing.Size(103, 22)
        Me.Numamount_garnishment.TabIndex = 1
        Me.Numamount_garnishment.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numamount_garnishment.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'ChkActive
        '
        Me.ChkActive.BackColor = System.Drawing.SystemColors.Control
        Me.ChkActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkActive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkActive.Location = New System.Drawing.Point(3, 96)
        Me.ChkActive.Name = "ChkActive"
        Me.ChkActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkActive.Size = New System.Drawing.Size(77, 16)
        Me.ChkActive.TabIndex = 3
        Me.ChkActive.Text = "Active"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(-1, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Start Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Amount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtremark
        '
        Me.Txtremark.Location = New System.Drawing.Point(67, 67)
        Me.Txtremark.MaxLength = 100
        Me.Txtremark.Name = "Txtremark"
        Me.Txtremark.Size = New System.Drawing.Size(389, 20)
        Me.Txtremark.TabIndex = 2
        Me.Txtremark.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(2, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Remark"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(326, 118)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(107, 23)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "Save"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(25, 118)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(107, 23)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "Cancel"
        '
        'ChkBeforeTax
        '
        Me.ChkBeforeTax.BackColor = System.Drawing.SystemColors.Control
        Me.ChkBeforeTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBeforeTax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkBeforeTax.Location = New System.Drawing.Point(193, 96)
        Me.ChkBeforeTax.Name = "ChkBeforeTax"
        Me.ChkBeforeTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkBeforeTax.Size = New System.Drawing.Size(123, 16)
        Me.ChkBeforeTax.TabIndex = 4
        Me.ChkBeforeTax.Text = "Before Tax"
        '
        'FrmEmployeeGarnishment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(459, 147)
        Me.Controls.Add(Me.ChkBeforeTax)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Txtremark)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChkActive)
        Me.Controls.Add(Me.Numamount_garnishment)
        Me.Controls.Add(Me.DteDate_start)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmEmployeeGarnishment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Garnishment"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmEmployeeLoan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Call FillFields()
        If Status = MainModule.WorkStates._ReadOnly Then
            Txtremark.Enabled = False
            Numamount_garnishment.Enabled = False
            ChkActive.Enabled = False
            ChkBeforeTax.Enabled = False
            DteDate_start.Enabled = False
        Else
            Txtremark.Enabled = True
            Numamount_garnishment.Enabled = True
            ChkActive.Enabled = True
            ChkBeforeTax.Enabled = True
            DteDate_start.Enabled = True
        End If
    End Sub
    Private Sub TxtEmployeeCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkActive.CheckedChanged, DteDate_start.TextChanged, Numamount_garnishment.TextChanged, ChkBeforeTax.CheckedChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub
    Private Sub FillFields()
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT * from pay_Garnishment_employee where Employee_Code=" & Qt(EmployeeCodVar)
        SQLReader = CmdGeneral.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            Txtremark.Text = Trim(SQLReader.Item("remark") & "")
            Numamount_garnishment.Text = SQLReader.Item("amount_garnishment")
            ChkActive.Checked = DecodeCheckBox(SQLReader.Item("Active"))
            ChkBeforeTax.Checked = DecodeCheckBox(SQLReader.Item("BeforeTax"))
            DteDate_start.Text = Trim(SQLReader.Item("Date_start") & "")
        Else
            Txtremark.Text = ""
            Numamount_garnishment.Text = 0
            ChkActive.Checked = True
            ChkBeforeTax.Checked = True
            DteDate_start.Text = ""
        End If
        SQLReader.Close()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT count(*) from pay_Garnishment_employee where Employee_Code=" & Qt(EmployeeCodVar)
        If CmdGeneral.ExecuteScalar > 0 Then
            CmdGeneral.CommandText = "Update pay_Garnishment_employee " & _
                                     "Set employee_code=" & Qt(EmployeeCodVar) & ", date_start=" & Qt(DteDate_start.Text) & ", remark=" & Qt(Txtremark.Text) & ", amount_garnishment=" & Numamount_garnishment.Text & ", active=" & DecodeCheckBox(ChkActive.Checked) & ", BeforeTax=" & DecodeCheckBox(ChkBeforeTax.Checked) & " " & _
                                     "Where Employee_Code=" & Qt(EmployeeCodVar)
        Else
            CmdGeneral.CommandText = "INSERT INTO pay_Garnishment_employee " & _
                                     "(employee_code, date_start, remark, amount_garnishment, active,BeforeTax) " & _
                                     "VALUES (" & Qt(EmployeeCodVar) & "," & Qt(DteDate_start.Text) & "," & Qt(Txtremark.Text) & "," & Numamount_garnishment.Text & "," & DecodeCheckBox(ChkActive.Checked) & "," & DecodeCheckBox(ChkBeforeTax.Checked) & ")"
        End If
        CmdGeneral.ExecuteNonQuery()
        Me.Close()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class
