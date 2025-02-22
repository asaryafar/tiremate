Imports CommonClass
Public Class FrmTireAdjustment
    Inherits FrmBase
    Public IsOK As Boolean = False
    Public ItemPriceVar As Decimal = 0
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
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.TextBox
    Friend WithEvents lblLine As System.Windows.Forms.TextBox
    Friend WithEvents lblSize As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblItemNo As System.Windows.Forms.TextBox
    Friend WithEvents Numcostomer_portion As CalcUtils.UcCalcText
    Friend WithEvents Numsupplier_percent As CalcUtils.UcCalcText
    Friend WithEvents TxtDOT_safety_code As System.Windows.Forms.TextBox
    Friend WithEvents TXTDOT_serial_no As System.Windows.Forms.TextBox
    Friend WithEvents Txtmeasured_tread_depth As System.Windows.Forms.TextBox
    Friend WithEvents Txtcondition_code As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTireAdjustment))
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.BtnSave = New Janus.Windows.EditControls.UIButton
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Numcostomer_portion = New CalcUtils.UcCalcText
        Me.Numsupplier_percent = New CalcUtils.UcCalcText
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblCustomer = New System.Windows.Forms.TextBox
        Me.lblDate = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblLine = New System.Windows.Forms.TextBox
        Me.lblSize = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.TextBox
        Me.lblItemNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtDOT_safety_code = New System.Windows.Forms.TextBox
        Me.TXTDOT_serial_no = New System.Windows.Forms.TextBox
        Me.Txtmeasured_tread_depth = New System.Windows.Forms.TextBox
        Me.Txtcondition_code = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(13, 209)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(99, 24)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Location = New System.Drawing.Point(318, 209)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(99, 24)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "Save"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(221, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 23)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "DOT Serial No."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(229, 137)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 23)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Condition Code"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(221, 171)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 23)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Customer Portion $"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Numcostomer_portion
        '
        Me.Numcostomer_portion.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numcostomer_portion.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numcostomer_portion.DecimalDigits = 2
        Me.Numcostomer_portion.DefaultSendValue = False
        Me.Numcostomer_portion.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numcostomer_portion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Numcostomer_portion.Image = CType(resources.GetObject("Numcostomer_portion.Image"), System.Drawing.Image)
        Me.Numcostomer_portion.Location = New System.Drawing.Point(327, 173)
        Me.Numcostomer_portion.Maxlength = 10
        Me.Numcostomer_portion.MinusColor = System.Drawing.Color.Empty
        Me.Numcostomer_portion.Name = "Numcostomer_portion"
        Me.Numcostomer_portion.Size = New System.Drawing.Size(96, 22)
        Me.Numcostomer_portion.TabIndex = 5
        Me.Numcostomer_portion.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numcostomer_portion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Numsupplier_percent
        '
        Me.Numsupplier_percent.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numsupplier_percent.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numsupplier_percent.DecimalDigits = 2
        Me.Numsupplier_percent.DefaultSendValue = False
        Me.Numsupplier_percent.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numsupplier_percent.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Numsupplier_percent.Image = CType(resources.GetObject("Numsupplier_percent.Image"), System.Drawing.Image)
        Me.Numsupplier_percent.Location = New System.Drawing.Point(118, 173)
        Me.Numsupplier_percent.Maxlength = 6
        Me.Numsupplier_percent.MinusColor = System.Drawing.Color.Empty
        Me.Numsupplier_percent.Name = "Numsupplier_percent"
        Me.Numsupplier_percent.Size = New System.Drawing.Size(96, 22)
        Me.Numsupplier_percent.TabIndex = 4
        Me.Numsupplier_percent.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numsupplier_percent.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Suplier Percent %"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(18, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 28)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Measured Tread Depth (in 32 nds)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "DOT Safety Code"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.Controls.Add(Me.lblCustomer)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblLine)
        Me.Panel1.Controls.Add(Me.lblSize)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblDescription)
        Me.Panel1.Controls.Add(Me.lblItemNo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 93)
        Me.Panel1.TabIndex = 39
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(223, 64)
        Me.lblCustomer.MaxLength = 100
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.ReadOnly = True
        Me.lblCustomer.Size = New System.Drawing.Size(201, 20)
        Me.lblCustomer.TabIndex = 48
        Me.lblCustomer.TabStop = False
        Me.lblCustomer.Text = ""
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(56, 64)
        Me.lblDate.MaxLength = 20
        Me.lblDate.Name = "lblDate"
        Me.lblDate.ReadOnly = True
        Me.lblDate.Size = New System.Drawing.Size(96, 20)
        Me.lblDate.TabIndex = 47
        Me.lblDate.TabStop = False
        Me.lblDate.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(159, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 23)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Customer"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(9, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 23)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLine
        '
        Me.lblLine.Location = New System.Drawing.Point(223, 37)
        Me.lblLine.MaxLength = 100
        Me.lblLine.Name = "lblLine"
        Me.lblLine.ReadOnly = True
        Me.lblLine.Size = New System.Drawing.Size(201, 20)
        Me.lblLine.TabIndex = 44
        Me.lblLine.TabStop = False
        Me.lblLine.Text = ""
        '
        'lblSize
        '
        Me.lblSize.Location = New System.Drawing.Point(56, 37)
        Me.lblSize.MaxLength = 20
        Me.lblSize.Name = "lblSize"
        Me.lblSize.ReadOnly = True
        Me.lblSize.Size = New System.Drawing.Size(96, 20)
        Me.lblSize.TabIndex = 43
        Me.lblSize.TabStop = False
        Me.lblSize.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(159, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 23)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Line"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(9, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 23)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Size"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(223, 9)
        Me.lblDescription.MaxLength = 100
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.ReadOnly = True
        Me.lblDescription.Size = New System.Drawing.Size(201, 20)
        Me.lblDescription.TabIndex = 40
        Me.lblDescription.TabStop = False
        Me.lblDescription.Text = ""
        '
        'lblItemNo
        '
        Me.lblItemNo.Location = New System.Drawing.Point(56, 9)
        Me.lblItemNo.MaxLength = 20
        Me.lblItemNo.Name = "lblItemNo"
        Me.lblItemNo.ReadOnly = True
        Me.lblItemNo.Size = New System.Drawing.Size(96, 20)
        Me.lblItemNo.TabIndex = 39
        Me.lblItemNo.TabStop = False
        Me.lblItemNo.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(159, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 23)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 23)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Item No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDOT_safety_code
        '
        Me.TxtDOT_safety_code.Location = New System.Drawing.Point(118, 106)
        Me.TxtDOT_safety_code.MaxLength = 4
        Me.TxtDOT_safety_code.Name = "TxtDOT_safety_code"
        Me.TxtDOT_safety_code.Size = New System.Drawing.Size(96, 20)
        Me.TxtDOT_safety_code.TabIndex = 0
        Me.TxtDOT_safety_code.Text = ""
        '
        'TXTDOT_serial_no
        '
        Me.TXTDOT_serial_no.Location = New System.Drawing.Point(327, 106)
        Me.TXTDOT_serial_no.MaxLength = 12
        Me.TXTDOT_serial_no.Name = "TXTDOT_serial_no"
        Me.TXTDOT_serial_no.Size = New System.Drawing.Size(96, 20)
        Me.TXTDOT_serial_no.TabIndex = 1
        Me.TXTDOT_serial_no.Text = ""
        '
        'Txtmeasured_tread_depth
        '
        Me.Txtmeasured_tread_depth.Location = New System.Drawing.Point(118, 140)
        Me.Txtmeasured_tread_depth.MaxLength = 20
        Me.Txtmeasured_tread_depth.Name = "Txtmeasured_tread_depth"
        Me.Txtmeasured_tread_depth.Size = New System.Drawing.Size(96, 20)
        Me.Txtmeasured_tread_depth.TabIndex = 2
        Me.Txtmeasured_tread_depth.Text = ""
        '
        'Txtcondition_code
        '
        Me.Txtcondition_code.Location = New System.Drawing.Point(327, 140)
        Me.Txtcondition_code.MaxLength = 20
        Me.Txtcondition_code.Name = "Txtcondition_code"
        Me.Txtcondition_code.Size = New System.Drawing.Size(96, 20)
        Me.Txtcondition_code.TabIndex = 3
        Me.Txtcondition_code.Text = ""
        '
        'FrmTireAdjustment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(431, 239)
        Me.Controls.Add(Me.Txtcondition_code)
        Me.Controls.Add(Me.Txtmeasured_tread_depth)
        Me.Controls.Add(Me.TXTDOT_serial_no)
        Me.Controls.Add(Me.TxtDOT_safety_code)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Numsupplier_percent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Numcostomer_portion)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCancel)
        Me.Location = New System.Drawing.Point(200, 200)
        Me.Name = "FrmTireAdjustment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tire Adjustment"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmWorkOrders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT inv_item.line FROM inv_item WHERE inv_item.item_no= " & Qt(lblItemNo.Text)
        lblLine.Text = CmdGeneral.ExecuteScalar & ""
        CmdGeneral.CommandText = "SELECT  inv_tab_public.desc_table FROM inv_item LEFT OUTER JOIN inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_specification.item_no LEFT OUTER JOIN inv_tab_public ON inv_tab_tire_specification.tire_size = inv_tab_public.cod_table_public WHERE  (inv_tab_public.cod_main = '01') AND inv_item.item_no= " & Qt(lblItemNo.Text)
        lblSize.Text = CmdGeneral.ExecuteScalar & ""

        Call EnableDisableBtn()
    End Sub
    Private Sub EnableDisableBtn()
        Select Case ThisFormStatus
            Case MainModule.WorkStates.AddNew, MainModule.WorkStates.Edit
                BtnCancel.Enabled = True
                BtnSave.Enabled = True
            Case MainModule.WorkStates._ReadOnly
                BtnSave.Enabled = False
                Numcostomer_portion.Enabled = False
                Numsupplier_percent.Enabled = False
                Txtcondition_code.Enabled = False
                TxtDOT_safety_code.Enabled = False
                TXTDOT_serial_no.Enabled = False
                Txtmeasured_tread_depth.Enabled = False
                BtnCancel.Enabled = True
        End Select
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        IsOK = False
        Me.Close()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        IsOK = True
        Me.Close()
    End Sub
    Private Sub NumCustomerPortion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Numcostomer_portion.TextChanged, TxtDOT_safety_code.TextChanged, TXTDOT_serial_no.TextChanged, Txtmeasured_tread_depth.TextChanged, Txtcondition_code.TextChanged
        Call EnableDisableSave()
    End Sub
    Private Sub EnableDisableSave()
        If Txtcondition_code.Enabled = True Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub
    Private Sub Numsupplier_percent_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Numsupplier_percent.TextChanged
        Try
            Numcostomer_portion.Text = Math.Round(((100 - Numsupplier_percent.Text) * ItemPriceVar) / 100, 2)
        Catch ex As Exception
        End Try
        Call EnableDisableSave()
    End Sub
End Class
