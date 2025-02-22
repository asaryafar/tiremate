Imports CommonClass
Public Class FormCheckConsistencyAll
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAGL_account_adjustment_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account_adjustment_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtDtlDtlAdjustment As System.Windows.Forms.TextBox
    Friend WithEvents TxtDtlAdjustment As System.Windows.Forms.TextBox
    Friend WithEvents TxtHeadAdjustment As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmdAdjustment As System.Windows.Forms.Button
    Friend WithEvents DsFrmCheckDataConsistancy1 As Utility.DsFrmCheckDataConsistancy1
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents cmd1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGl_Account_adjustmentDtlDtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGlDtlDtlSelfCheck As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Dageneral As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GridEX2 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DAService_center_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_payment_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GridEX3 As Janus.Windows.GridEX.GridEX
    Public WithEvents DaGl_payment_deposit_head_dtlCheck As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents daglrecpay1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GridEX4 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents GridEX5 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Pb1 As Janus.Windows.EditControls.UIProgressBar
    Friend WithEvents DaSP_CustomerAging1to30 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAging31to60 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAging61to90 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerBalance As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaCoustomerbalanceview As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAgingNotDueYet As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAgingOver90 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents GridEX6 As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaPaymentGreatThatAdjustment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents GridEX7 As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daserviceoutpurchase As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents LblNote1 As System.Windows.Forms.Label
    Friend WithEvents LblNote4 As System.Windows.Forms.Label
    Friend WithEvents LblNote5 As System.Windows.Forms.Label
    Friend WithEvents LblNote6 As System.Windows.Forms.Label
    Friend WithEvents LblNote7 As System.Windows.Forms.Label
    Friend WithEvents LblNote2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormCheckConsistencyAll))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout4 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout5 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout6 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout7 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.LblNote1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmCheckDataConsistancy1 = New Utility.DsFrmCheckDataConsistancy1
        Me.CmdAdjustment = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtDtlDtlAdjustment = New System.Windows.Forms.TextBox
        Me.TxtDtlAdjustment = New System.Windows.Forms.TextBox
        Me.TxtHeadAdjustment = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.LblNote2 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.GridEX3 = New Janus.Windows.GridEX.GridEX
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Pb1 = New Janus.Windows.EditControls.UIProgressBar
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.GridEX5 = New Janus.Windows.GridEX.GridEX
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.LblNote4 = New System.Windows.Forms.Label
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.GridEX6 = New Janus.Windows.GridEX.GridEX
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.LblNote5 = New System.Windows.Forms.Label
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.GridEX7 = New Janus.Windows.GridEX.GridEX
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.LblNote6 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GridEX2 = New Janus.Windows.GridEX.GridEX
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.LblNote7 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.GridEX4 = New Janus.Windows.GridEX.GridEX
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAGL_account_adjustment_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account_adjustment_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.cmd1 = New System.Data.SqlClient.SqlCommand
        Me.DaGl_Account_adjustmentDtlDtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaGlDtlDtlSelfCheck = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand
        Me.Dageneral = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DAService_center_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DaGl_payment_deposit_head_dtlCheck = New System.Data.SqlClient.SqlDataAdapter
        Me.daglrecpay1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAging1to30 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAging31to60 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAging61to90 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerBalance = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.DaCoustomerbalanceview = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAgingNotDueYet = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAgingOver90 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.DaPaymentGreatThatAdjustment = New System.Data.SqlClient.SqlDataAdapter
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.daserviceoutpurchase = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmCheckDataConsistancy1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.GridEX3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.GridEX5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.GridEX6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.GridEX7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.GridEX4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(864, 48)
        Me.Panel2.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(240, 46)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Check Consistency In All Transaction"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(8, 56)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(848, 464)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LblNote1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.GridEX1)
        Me.TabPage1.Controls.Add(Me.CmdAdjustment)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(840, 438)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Adjustments Check"
        '
        'LblNote1
        '
        Me.LblNote1.ForeColor = System.Drawing.Color.Red
        Me.LblNote1.Location = New System.Drawing.Point(184, 360)
        Me.LblNote1.Name = "LblNote1"
        Me.LblNote1.Size = New System.Drawing.Size(144, 23)
        Me.LblNote1.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(88, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Print"
        '
        'GridEX1
        '
        Me.GridEX1.BackColor = System.Drawing.SystemColors.Control
        Me.GridEX1.BlendColor = System.Drawing.SystemColors.Control
        Me.GridEX1.DataMember = "Adjustmentall"
        Me.GridEX1.DataSource = Me.DsFrmCheckDataConsistancy1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Adjustmentall</Caption><Columns Collection=" & _
        """true""><Column0 ID=""refrence_no""><Caption>refrence_no</Caption><TypeNameEmptyStr" & _
        "ingValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember" & _
        ">refrence_no</DataMember><Key>refrence_no</Key><Position>0</Position></Column0><" & _
        "Column1 ID=""cod_customer""><Caption>cod_customer</Caption><DataMember>cod_custome" & _
        "r</DataMember><Key>cod_customer</Key><Position>1</Position></Column1><Column2 ID" & _
        "=""amount_adjustment_head""><Caption>amount_adjustment_head</Caption><DataMember>a" & _
        "mount_adjustment_head</DataMember><FormatString>c</FormatString><Key>amount_adju" & _
        "stment_head</Key><Position>2</Position><TextAlignment>Far</TextAlignment></Colum" & _
        "n2><Column3 ID=""amount_adjustment_Dtl""><Caption>amount_adjustment_Dtl</Caption><" & _
        "DataMember>amount_adjustment_Dtl</DataMember><FormatString>c</FormatString><Key>" & _
        "amount_adjustment_Dtl</Key><Position>3</Position><TextAlignment>Far</TextAlignme" & _
        "nt><Width>143</Width></Column3><Column4 ID=""amount_adjustment_Dtl_Dtl""><Caption>" & _
        "amount_adjustment_Dtl_Dtl</Caption><DataMember>amount_adjustment_Dtl_Dtl</DataMe" & _
        "mber><FormatString>c</FormatString><Key>amount_adjustment_Dtl_Dtl</Key><Position" & _
        ">4</Position><TextAlignment>Far</TextAlignment><Width>137</Width></Column4><Colu" & _
        "mn5 ID=""Note""><Caption>Note</Caption><DataMember>Note</DataMember><Key>Note</Key" & _
        "><Position>5</Position></Column5></Columns><GroupCondition ID="""" /><Key>Adjustme" & _
        "ntall</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(8, 8)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RowFormatStyle.BackColor = System.Drawing.SystemColors.Control
        Me.GridEX1.Size = New System.Drawing.Size(824, 344)
        Me.GridEX1.TabIndex = 10
        '
        'DsFrmCheckDataConsistancy1
        '
        Me.DsFrmCheckDataConsistancy1.DataSetName = "FrmCheckDataConsistancy1"
        Me.DsFrmCheckDataConsistancy1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'CmdAdjustment
        '
        Me.CmdAdjustment.Location = New System.Drawing.Point(8, 360)
        Me.CmdAdjustment.Name = "CmdAdjustment"
        Me.CmdAdjustment.TabIndex = 9
        Me.CmdAdjustment.Text = "Check"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtDtlDtlAdjustment)
        Me.Panel1.Controls.Add(Me.TxtDtlAdjustment)
        Me.Panel1.Controls.Add(Me.TxtHeadAdjustment)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(3, 389)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(837, 40)
        Me.Panel1.TabIndex = 8
        '
        'TxtDtlDtlAdjustment
        '
        Me.TxtDtlDtlAdjustment.Location = New System.Drawing.Point(701, 8)
        Me.TxtDtlDtlAdjustment.Name = "TxtDtlDtlAdjustment"
        Me.TxtDtlDtlAdjustment.ReadOnly = True
        Me.TxtDtlDtlAdjustment.Size = New System.Drawing.Size(120, 20)
        Me.TxtDtlDtlAdjustment.TabIndex = 12
        Me.TxtDtlDtlAdjustment.Text = ""
        '
        'TxtDtlAdjustment
        '
        Me.TxtDtlAdjustment.Location = New System.Drawing.Point(408, 8)
        Me.TxtDtlAdjustment.Name = "TxtDtlAdjustment"
        Me.TxtDtlAdjustment.ReadOnly = True
        Me.TxtDtlAdjustment.Size = New System.Drawing.Size(128, 20)
        Me.TxtDtlAdjustment.TabIndex = 11
        Me.TxtDtlAdjustment.Text = ""
        '
        'TxtHeadAdjustment
        '
        Me.TxtHeadAdjustment.Location = New System.Drawing.Point(144, 8)
        Me.TxtHeadAdjustment.Name = "TxtHeadAdjustment"
        Me.TxtHeadAdjustment.ReadOnly = True
        Me.TxtHeadAdjustment.Size = New System.Drawing.Size(120, 20)
        Me.TxtHeadAdjustment.TabIndex = 10
        Me.TxtHeadAdjustment.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(548, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Dtl Dtl Adjustment summery"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(264, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Detail Adjustment Summery"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Head Adjustment Summery"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.LblNote2)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.GridEX3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(840, 438)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "GL payment deposi head and detail check"
        '
        'LblNote2
        '
        Me.LblNote2.ForeColor = System.Drawing.Color.Red
        Me.LblNote2.Location = New System.Drawing.Point(176, 408)
        Me.LblNote2.Name = "LblNote2"
        Me.LblNote2.Size = New System.Drawing.Size(144, 23)
        Me.LblNote2.TabIndex = 16
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(88, 408)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Print"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(8, 408)
        Me.Button5.Name = "Button5"
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Check"
        '
        'GridEX3
        '
        Me.GridEX3.BackColor = System.Drawing.SystemColors.Control
        Me.GridEX3.BlendColor = System.Drawing.SystemColors.Control
        Me.GridEX3.DataMember = "Gl_Payment_deposit_head_dtl"
        Me.GridEX3.DataSource = Me.DsFrmCheckDataConsistancy1
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Caption>Gl_Payment_deposit_head_dtl</Caption><Colum" & _
        "ns Collection=""true""><Column0 ID=""ID_payment""><Caption>ID payment</Caption><Type" & _
        "NameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMem" & _
        "ber>ID_payment</DataMember><Key>ID_payment</Key><Position>0</Position></Column0>" & _
        "<Column1 ID=""refrence_no""><Caption>refrence no</Caption><DataMember>refrence_no<" & _
        "/DataMember><Key>refrence_no</Key><Position>1</Position></Column1><Column2 ID=""p" & _
        "ayment_amount1""><Caption>Sum Head</Caption><DataMember>payment_amount1</DataMemb" & _
        "er><FormatString>c</FormatString><Key>payment_amount1</Key><Position>2</Position" & _
        "><TextAlignment>Far</TextAlignment><Width>146</Width></Column2><Column3 ID=""paym" & _
        "ent_amount2""><Caption>Sum Detail</Caption><DataMember>payment_amount2</DataMembe" & _
        "r><FormatString>c</FormatString><Key>payment_amount2</Key><Position>3</Position>" & _
        "<TextAlignment>Far</TextAlignment><Width>165</Width></Column3></Columns><GroupCo" & _
        "ndition ID="""" /><Key>Gl_Payment_deposit_head_dtl</Key></RootTable></GridEXLayout" & _
        "Data>"
        Me.GridEX3.DesignTimeLayout = GridEXLayout2
        Me.GridEX3.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX3.GroupByBoxVisible = False
        Me.GridEX3.Location = New System.Drawing.Point(8, 19)
        Me.GridEX3.Name = "GridEX3"
        Me.GridEX3.RowFormatStyle.BackColor = System.Drawing.SystemColors.Control
        Me.GridEX3.Size = New System.Drawing.Size(824, 381)
        Me.GridEX3.TabIndex = 12
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Pb1)
        Me.TabPage5.Controls.Add(Me.Button8)
        Me.TabPage5.Controls.Add(Me.Button9)
        Me.TabPage5.Controls.Add(Me.GridEX5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(840, 438)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Customer Balance Conflict"
        '
        'Pb1
        '
        Me.Pb1.Location = New System.Drawing.Point(176, 408)
        Me.Pb1.Name = "Pb1"
        Me.Pb1.Size = New System.Drawing.Size(656, 16)
        Me.Pb1.TabIndex = 21
        Me.Pb1.Text = "UiProgressBar1"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(88, 407)
        Me.Button8.Name = "Button8"
        Me.Button8.TabIndex = 20
        Me.Button8.Text = "Print"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(8, 407)
        Me.Button9.Name = "Button9"
        Me.Button9.TabIndex = 19
        Me.Button9.Text = "Check"
        '
        'GridEX5
        '
        Me.GridEX5.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX5.BackColor = System.Drawing.SystemColors.Control
        Me.GridEX5.BlendColor = System.Drawing.SystemColors.Control
        Me.GridEX5.DataMember = "View_Customer_Balance"
        Me.GridEX5.DataSource = Me.DsFrmCheckDataConsistancy1
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><Caption>View_Customer_Balance</Caption><Columns Col" & _
        "lection=""true""><Column0 ID=""cod_customer""><Caption>cod_customer</Caption><TypeNa" & _
        "meEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><" & _
        "DataMember>cod_customer</DataMember><Key>cod_customer</Key><Position>0</Position" & _
        "></Column0><Column1 ID=""BalanceSP""><Caption>BalanceSP</Caption><DataMember>Balan" & _
        "ceSP</DataMember><FormatString>c</FormatString><Key>BalanceSP</Key><Position>1</" & _
        "Position><TextAlignment>Far</TextAlignment></Column1><Column2 ID=""BalanceAmount""" & _
        "><Caption>BalanceAmount</Caption><DataMember>BalanceAmount</DataMember><FormatSt" & _
        "ring>c</FormatString><Key>BalanceAmount</Key><Position>2</Position><TextAlignmen" & _
        "t>Far</TextAlignment></Column2><Column3 ID=""sumall1""><Caption>sumall1</Caption><" & _
        "DataMember>sumall1</DataMember><FormatString>c</FormatString><Key>sumall1</Key><" & _
        "Position>3</Position><TextAlignment>Far</TextAlignment></Column3><Column4 ID=""no" & _
        "tdue""><Caption>notdue</Caption><DataMember>notdue</DataMember><FormatString>c</F" & _
        "ormatString><Key>notdue</Key><Position>4</Position><TextAlignment>Far</TextAlign" & _
        "ment></Column4><Column5 ID=""a1to30""><Caption>a1to30</Caption><DataMember>a1to30<" & _
        "/DataMember><FormatString>c</FormatString><Key>a1to30</Key><Position>5</Position" & _
        "><TextAlignment>Far</TextAlignment></Column5><Column6 ID=""a31to60""><Caption>a31t" & _
        "o60</Caption><DataMember>a31to60</DataMember><FormatString>c</FormatString><Key>" & _
        "a31to60</Key><Position>6</Position><TextAlignment>Far</TextAlignment></Column6><" & _
        "Column7 ID=""a61to90""><Caption>a61to90</Caption><DataMember>a61to90</DataMember><" & _
        "FormatString>c</FormatString><Key>a61to90</Key><Position>7</Position><TextAlignm" & _
        "ent>Far</TextAlignment></Column7><Column8 ID=""over90""><Caption>over90</Caption><" & _
        "DataMember>over90</DataMember><FormatString>c</FormatString><Key>over90</Key><Po" & _
        "sition>8</Position><TextAlignment>Far</TextAlignment></Column8></Columns><GroupC" & _
        "ondition ID="""" /><Key>View_Customer_Balance</Key></RootTable></GridEXLayoutData>" & _
        ""
        Me.GridEX5.DesignTimeLayout = GridEXLayout3
        Me.GridEX5.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX5.GroupByBoxVisible = False
        Me.GridEX5.Location = New System.Drawing.Point(8, 9)
        Me.GridEX5.Name = "GridEX5"
        Me.GridEX5.RowFormatStyle.BackColor = System.Drawing.SystemColors.Control
        Me.GridEX5.Size = New System.Drawing.Size(824, 392)
        Me.GridEX5.TabIndex = 18
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.LblNote4)
        Me.TabPage6.Controls.Add(Me.Button10)
        Me.TabPage6.Controls.Add(Me.Button11)
        Me.TabPage6.Controls.Add(Me.GridEX6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(840, 438)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "payment > adjustment"
        '
        'LblNote4
        '
        Me.LblNote4.ForeColor = System.Drawing.Color.Red
        Me.LblNote4.Location = New System.Drawing.Point(192, 408)
        Me.LblNote4.Name = "LblNote4"
        Me.LblNote4.Size = New System.Drawing.Size(144, 23)
        Me.LblNote4.TabIndex = 17
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(88, 412)
        Me.Button10.Name = "Button10"
        Me.Button10.TabIndex = 16
        Me.Button10.Text = "Print"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(8, 412)
        Me.Button11.Name = "Button11"
        Me.Button11.TabIndex = 15
        Me.Button11.Text = "Check"
        '
        'GridEX6
        '
        Me.GridEX6.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX6.BackColor = System.Drawing.SystemColors.Control
        Me.GridEX6.BlendColor = System.Drawing.SystemColors.Control
        Me.GridEX6.DataMember = "View1"
        Me.GridEX6.DataSource = Me.DsFrmCheckDataConsistancy1
        GridEXLayout4.LayoutString = "<GridEXLayoutData><RootTable><Caption>View1</Caption><Columns Collection=""true""><" & _
        "Column0 ID=""refrence_no""><Caption>Refrence no</Caption><DataMember>refrence_no</" & _
        "DataMember><Key>refrence_no</Key><Position>0</Position></Column0><Column1 ID=""su" & _
        "mpayment""><Caption>SumPayment</Caption><DataMember>sumpayment</DataMember><Forma" & _
        "tString>c</FormatString><Key>sumpayment</Key><Position>1</Position><TextAlignmen" & _
        "t>Far</TextAlignment><Width>130</Width></Column1><Column2 ID=""amount_adjustment""" & _
        "><Caption>Amount Adjustment</Caption><DataMember>amount_adjustment</DataMember><" & _
        "FormatString>c</FormatString><Key>amount_adjustment</Key><Position>2</Position><" & _
        "TextAlignment>Far</TextAlignment><Width>217</Width></Column2></Columns><GroupCon" & _
        "dition ID="""" /><Key>View1</Key></RootTable></GridEXLayoutData>"
        Me.GridEX6.DesignTimeLayout = GridEXLayout4
        Me.GridEX6.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX6.GroupByBoxVisible = False
        Me.GridEX6.Location = New System.Drawing.Point(8, 4)
        Me.GridEX6.Name = "GridEX6"
        Me.GridEX6.RowFormatStyle.BackColor = System.Drawing.SystemColors.Control
        Me.GridEX6.Size = New System.Drawing.Size(824, 400)
        Me.GridEX6.TabIndex = 14
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.LblNote5)
        Me.TabPage7.Controls.Add(Me.Button12)
        Me.TabPage7.Controls.Add(Me.Button13)
        Me.TabPage7.Controls.Add(Me.GridEX7)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(840, 438)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Check Service center detail and  service out purchases"
        '
        'LblNote5
        '
        Me.LblNote5.ForeColor = System.Drawing.Color.Red
        Me.LblNote5.Location = New System.Drawing.Point(184, 408)
        Me.LblNote5.Name = "LblNote5"
        Me.LblNote5.Size = New System.Drawing.Size(144, 23)
        Me.LblNote5.TabIndex = 22
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(88, 407)
        Me.Button12.Name = "Button12"
        Me.Button12.TabIndex = 21
        Me.Button12.Text = "Print"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(8, 407)
        Me.Button13.Name = "Button13"
        Me.Button13.TabIndex = 20
        Me.Button13.Text = "Check"
        '
        'GridEX7
        '
        Me.GridEX7.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX7.BackColor = System.Drawing.SystemColors.Control
        Me.GridEX7.BlendColor = System.Drawing.SystemColors.Control
        Me.GridEX7.DataMember = "outpo"
        Me.GridEX7.DataSource = Me.DsFrmCheckDataConsistancy1
        GridEXLayout5.LayoutString = "<GridEXLayoutData><RootTable><Caption>outpo</Caption><Columns Collection=""true""><" & _
        "Column0 ID=""id_service_center""><Caption>Invoice no</Caption><TypeNameEmptyString" & _
        "Value>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>id" & _
        "_service_center</DataMember><Key>id_service_center</Key><Position>0</Position></" & _
        "Column0><Column1 ID=""radif""><Caption>radif</Caption><TypeNameEmptyStringValue>NU" & _
        "LL</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>radif</DataMember><" & _
        "Key>radif</Key><Position>1</Position></Column1><Column2 ID=""type_select""><Captio" & _
        "n>Type</Caption><DataMember>type_select</DataMember><Key>type_select</Key><Posit" & _
        "ion>2</Position></Column2><Column3 ID=""cod_select""><Caption>Item no</Caption><Da" & _
        "taMember>cod_select</DataMember><Key>cod_select</Key><Position>3</Position></Col" & _
        "umn3><Column4 ID=""qty""><Caption>qty</Caption><TypeNameEmptyStringValue>NULL</Typ" & _
        "eNameEmptyStringValue><EmptyStringValue /><DataMember>qty</DataMember><FormatStr" & _
        "ing>c</FormatString><Key>qty</Key><Position>4</Position><TextAlignment>Far</Text" & _
        "Alignment></Column4><Column5 ID=""price""><Caption>price</Caption><TypeNameEmptySt" & _
        "ringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>price</" & _
        "DataMember><FormatString>c</FormatString><Key>price</Key><Position>5</Position><" & _
        "TextAlignment>Far</TextAlignment></Column5><Column6 ID=""fet""><Caption>fet</Capti" & _
        "on><TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue />" & _
        "<DataMember>fet</DataMember><FormatString>c</FormatString><Key>fet</Key><Positio" & _
        "n>6</Position><TextAlignment>Far</TextAlignment></Column6></Columns><GroupCondit" & _
        "ion ID="""" /><Key>outpo</Key></RootTable></GridEXLayoutData>"
        Me.GridEX7.DesignTimeLayout = GridEXLayout5
        Me.GridEX7.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX7.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX7.GroupByBoxVisible = False
        Me.GridEX7.Location = New System.Drawing.Point(8, 13)
        Me.GridEX7.Name = "GridEX7"
        Me.GridEX7.RowFormatStyle.BackColor = System.Drawing.SystemColors.Control
        Me.GridEX7.Size = New System.Drawing.Size(816, 379)
        Me.GridEX7.TabIndex = 19
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LblNote6)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.GridEX2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(840, 438)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Service center "
        '
        'LblNote6
        '
        Me.LblNote6.ForeColor = System.Drawing.Color.Red
        Me.LblNote6.Location = New System.Drawing.Point(184, 408)
        Me.LblNote6.Name = "LblNote6"
        Me.LblNote6.Size = New System.Drawing.Size(144, 23)
        Me.LblNote6.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(88, 408)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Print"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(8, 408)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Check"
        '
        'GridEX2
        '
        Me.GridEX2.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX2.BackColor = System.Drawing.SystemColors.Control
        Me.GridEX2.BlendColor = System.Drawing.SystemColors.Control
        Me.GridEX2.DataMember = "GL_payment_deposit"
        Me.GridEX2.DataSource = Me.DsFrmCheckDataConsistancy1
        GridEXLayout6.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_payment_deposit</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""id_service_center""><Caption>Invoice No </Caption><TypeN" & _
        "ameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue />" & _
        "<DataMember>id_service_center</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><Key>id_service_center</Key><Position>0</Position><" & _
        "/Column0><Column1 ID=""sumpayment""><Caption>Sum</Caption><DataMember>sumpayment</" & _
        "DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><F" & _
        "ormatString>c</FormatString><Key>sumpayment</Key><Position>1</Position><TextAlig" & _
        "nment>Far</TextAlignment></Column1><Column2 ID=""Note""><Caption>Note</Caption><Da" & _
        "taMember>Note</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Fi" & _
        "lterEditType><Key>Note</Key><Position>2</Position><Width>477</Width></Column2></" & _
        "Columns><GroupCondition ID="""" /><Key>GL_payment_deposit</Key></RootTable></GridE" & _
        "XLayoutData>"
        Me.GridEX2.DesignTimeLayout = GridEXLayout6
        Me.GridEX2.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX2.GroupByBoxVisible = False
        Me.GridEX2.Location = New System.Drawing.Point(8, 0)
        Me.GridEX2.Name = "GridEX2"
        Me.GridEX2.RowFormatStyle.BackColor = System.Drawing.SystemColors.Control
        Me.GridEX2.Size = New System.Drawing.Size(824, 400)
        Me.GridEX2.TabIndex = 11
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.LblNote7)
        Me.TabPage4.Controls.Add(Me.Button6)
        Me.TabPage4.Controls.Add(Me.Button7)
        Me.TabPage4.Controls.Add(Me.GridEX4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(840, 438)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "receive payment And  payment deposit check"
        '
        'LblNote7
        '
        Me.LblNote7.ForeColor = System.Drawing.Color.Red
        Me.LblNote7.Location = New System.Drawing.Point(176, 408)
        Me.LblNote7.Name = "LblNote7"
        Me.LblNote7.Size = New System.Drawing.Size(144, 23)
        Me.LblNote7.TabIndex = 18
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(88, 406)
        Me.Button6.Name = "Button6"
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Print"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(8, 406)
        Me.Button7.Name = "Button7"
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "Check"
        '
        'GridEX4
        '
        Me.GridEX4.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX4.BackColor = System.Drawing.SystemColors.Control
        Me.GridEX4.BlendColor = System.Drawing.SystemColors.Control
        Me.GridEX4.DataMember = "Glreceivepayment"
        Me.GridEX4.DataSource = Me.DsFrmCheckDataConsistancy1
        GridEXLayout7.LayoutString = "<GridEXLayoutData><RootTable><Caption>Glreceivepayment</Caption><Columns Collecti" & _
        "on=""true""><Column0 ID=""refrence_no""><Caption>RefrenceNo</Caption><TypeNameEmptyS" & _
        "tringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMemb" & _
        "er>refrence_no</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</F" & _
        "ilterEditType><Key>refrence_no</Key><Position>0</Position></Column0><Column1 ID=" & _
        """Head_Amount""><Caption>Amount Receive </Caption><DataMember>Head_Amount</DataMem" & _
        "ber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>Head" & _
        "_Amount</Key><Position>1</Position><Width>127</Width></Column1><Column2 ID=""Deta" & _
        "il_Amount""><Caption>Sum Paid</Caption><DataMember>Detail_Amount</DataMember><Edi" & _
        "tType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c</" & _
        "FormatString><Key>Detail_Amount</Key><Position>2</Position><TextAlignment>Far</T" & _
        "extAlignment><Width>117</Width></Column2></Columns><GroupCondition ID="""" /><Key>" & _
        "Glreceivepayment</Key></RootTable></GridEXLayoutData>"
        Me.GridEX4.DesignTimeLayout = GridEXLayout7
        Me.GridEX4.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX4.GroupByBoxVisible = False
        Me.GridEX4.Location = New System.Drawing.Point(8, 8)
        Me.GridEX4.Name = "GridEX4"
        Me.GridEX4.RowFormatStyle.BackColor = System.Drawing.SystemColors.Control
        Me.GridEX4.Size = New System.Drawing.Size(824, 392)
        Me.GridEX4.TabIndex = 11
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=SA;data source=""."";persist security " & _
        "info=True;initial catalog=Tiremate_03;password=2191110"
        '
        'DAGL_account_adjustment_dtl
        '
        Me.DAGL_account_adjustment_dtl.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_account_adjustment_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("Old_Amount_adjustment", "Old_Amount_adjustment")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT refrence_no, SUM(amount_adjustment) AS sumdtl FROM GL_account_adjustment_d" & _
        "tl GROUP BY refrence_no"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAGL_account_adjustment_head
        '
        Me.DAGL_account_adjustment_head.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_account_adjustment_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("Remark", "Remark"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Gl_receive_payment_Refrence_no", "Gl_receive_payment_Refrence_no"), New System.Data.Common.DataColumnMapping("finance_charge_flag", "finance_charge_flag"), New System.Data.Common.DataColumnMapping("Old_Amount_adjustment", "Old_Amount_adjustment"), New System.Data.Common.DataColumnMapping("FromStoreNo", "FromStoreNo")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT refrence_no, cod_customer, amount_adjustment, date_adjustment, Remark, GL_" & _
        "account, id_GL_journal, Gl_receive_payment_Refrence_no, finance_charge_flag, Old" & _
        "_Amount_adjustment, FromStoreNo FROM GL_account_adjustment_head"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'cmd1
        '
        Me.cmd1.Connection = Me.Cnn
        '
        'DaGl_Account_adjustmentDtlDtl
        '
        Me.DaGl_Account_adjustmentDtlDtl.SelectCommand = Me.SqlCommand1
        Me.DaGl_Account_adjustmentDtlDtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_dtl_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("sumdtlDtl", "sumdtlDtl")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT refrence_no_due AS refrence_no, SUM(amount_adjustment) AS sumdtlDtl FROM G" & _
        "L_account_adjustment_dtl_dtl GROUP BY refrence_no_due"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'DaGlDtlDtlSelfCheck
        '
        Me.DaGlDtlDtlSelfCheck.SelectCommand = Me.SqlCommand6
        Me.DaGlDtlDtlSelfCheck.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_dtl_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IDGL_account_adjustment_dtl", "IDGL_account_adjustment_dtl"), New System.Data.Common.DataColumnMapping("refrence_no_due", "refrence_no_due"), New System.Data.Common.DataColumnMapping("id_service_center_due", "id_service_center_due"), New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("IDGL_account_adjustment_dtl_Due", "IDGL_account_adjustment_dtl_Due"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("old_amount_adjustment", "old_amount_adjustment")})})
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = "SELECT * FROM GL_account_adjustment_dtl_dtl WHERE (IDGL_account_adjustment_dtl_Du" & _
        "e NOT IN (SELECT IDGL_account_adjustment_dtl FROM GL_account_adjustment_dtl_dtl)" & _
        ")"
        Me.SqlCommand6.Connection = Me.Cnn
        '
        'Dageneral
        '
        Me.Dageneral.SelectCommand = Me.SqlSelectCommand6
        Me.Dageneral.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_vehicle_size", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vehicle", "cod_vehicle"), New System.Data.Common.DataColumnMapping("cod_main", "cod_main"), New System.Data.Common.DataColumnMapping("cod_size_main", "cod_size_main"), New System.Data.Common.DataColumnMapping("cod_size_option", "cod_size_option")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT cod_vehicle, cod_main, cod_size_main, cod_size_option FROM bas_vehicle_siz" & _
        "e"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'DAService_center_head
        '
        Me.DAService_center_head.SelectCommand = Me.SqlSelectCommand4
        Me.DAService_center_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT id_service_center, type_of_form, cod_customer, id_vehicle, date_refer, dis" & _
        "count, tax, house_comment, cust_comment, add_user, chg_user, po_no, id_service_c" & _
        "enter_before, id_GL_journal, Total FROM service_center_head"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DAGL_payment_deposit
        '
        Me.DAGL_payment_deposit.SelectCommand = Me.SqlSelectCommand3
        Me.DAGL_payment_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Paid_amount", "Paid_amount"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("refrence_no_Adjustment", "refrence_no_Adjustment"), New System.Data.Common.DataColumnMapping("refrence_no_Gl_receive_payment", "refrence_no_Gl_receive_payment"), New System.Data.Common.DataColumnMapping("Downpayment_Wo_No", "Downpayment_Wo_No")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT id_service_center, SUM(ROUND(payment_amount, 2)) AS sumpayment FROM GL_pay" & _
        "ment_deposit WHERE (refer_type = '1') GROUP BY id_service_center"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT * FROM (SELECT ROUND(A.payment_amount, 2) AS payment_amount1, A.ID_payment" & _
        ", (SELECT SUM(ROUND(GL_payment_deposit.payment_amount, 2)) AS Expr1 FROM GL_paym" & _
        "ent_deposit_Detail INNER JOIN GL_payment_deposit ON GL_payment_deposit_Detail.ID" & _
        "_payment_Paid = GL_payment_deposit.ID_payment WHERE A.ID_payment = GL_payment_de" & _
        "posit_Detail.ID_payment_Paid) AS payment_amount2, A.refrence_no FROM GL_payment_" & _
        "deposit A INNER JOIN Gl_receive_payment ON A.refrence_no = Gl_receive_payment.re" & _
        "frence_no WHERE (A.refer_type = '2') OR (A.refer_type = '3')) DERIVEDTBL WHERE (" & _
        "payment_amount1 <> payment_amount2)"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'DaGl_payment_deposit_head_dtlCheck
        '
        Me.DaGl_payment_deposit_head_dtlCheck.SelectCommand = Me.SqlSelectCommand5
        Me.DaGl_payment_deposit_head_dtlCheck.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Gl_Payment_deposit_head_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("payment_amount1", "payment_amount1"), New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("payment_amount2", "payment_amount2"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no")})})
        '
        'daglrecpay1
        '
        Me.daglrecpay1.SelectCommand = Me.SqlCommand2
        Me.daglrecpay1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Glreceivepayment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("Head_Amount", "Head_Amount"), New System.Data.Common.DataColumnMapping("Detail_Amount", "Detail_Amount")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT Gl_receive_payment.refrence_no, ROUND(ISNULL(Gl_receive_payment.amount_rec" & _
        "eive, 0), 2) - ROUND(ISNULL(Gl_receive_payment.amount_over, 0), 2) AS Head_Amoun" & _
        "t, a.sumpay AS Detail_Amount FROM Gl_receive_payment INNER JOIN (SELECT refrence" & _
        "_no AS refrence_noglpayment, SUM(round(isnull(payment_amount, 0), 2)) AS sumpay " & _
        "FROM GL_payment_deposit WHERE (NOT (refrence_no IS NULL)) GROUP BY refrence_no) " & _
        "a ON Gl_receive_payment.refrence_no = a.refrence_noglpayment AND ROUND(ISNULL(Gl" & _
        "_receive_payment.amount_receive, 0), 2) - ROUND(ISNULL(Gl_receive_payment.amount" & _
        "_over, 0), 2) <> a.sumpay ORDER BY Gl_receive_payment.refrence_no"
        Me.SqlCommand2.Connection = Me.Cnn
        '
        'DaSP_CustomerAging1to30
        '
        Me.DaSP_CustomerAging1to30.SelectCommand = Me.SqlCommand3
        Me.DaSP_CustomerAging1to30.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerAging1to30", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_CUSTOMER", "COD_CUSTOMER"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "[SP_CustomerAging1to30]"
        Me.SqlCommand3.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand3.Connection = Me.Cnn
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        '
        'DaSP_CustomerAging31to60
        '
        Me.DaSP_CustomerAging31to60.SelectCommand = Me.SqlCommand5
        Me.DaSP_CustomerAging31to60.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerAging31to60", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_CUSTOMER", "COD_CUSTOMER"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "[SP_CustomerAging31to60]"
        Me.SqlCommand5.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand5.Connection = Me.Cnn
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        '
        'DaSP_CustomerAging61to90
        '
        Me.DaSP_CustomerAging61to90.SelectCommand = Me.SqlCommand4
        Me.DaSP_CustomerAging61to90.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerAging61to90", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_CUSTOMER", "COD_CUSTOMER"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "[SP_CustomerAging61to90]"
        Me.SqlCommand4.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        '
        'DaSP_CustomerBalance
        '
        Me.DaSP_CustomerBalance.SelectCommand = Me.SqlSelectCommand9
        Me.DaSP_CustomerBalance.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerBalance", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")}), New System.Data.Common.DataTableMapping("Table1", "Table1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "[SP_CustomerBalance]"
        Me.SqlSelectCommand9.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand9.Connection = Me.Cnn
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisCustomer", System.Data.SqlDbType.VarChar, 10))
        '
        'DaCoustomerbalanceview
        '
        Me.DaCoustomerbalanceview.InsertCommand = Me.SqlInsertCommand3
        Me.DaCoustomerbalanceview.SelectCommand = Me.SqlSelectCommand7
        Me.DaCoustomerbalanceview.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "View_Customer_Balance", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO View_Customer_Balance(cod_customer, BalanceAmount) VALUES (@cod_custo" & _
        "mer, @BalanceAmount); SELECT cod_customer, BalanceAmount FROM View_Customer_Bala" & _
        "nce"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BalanceAmount", System.Data.SqlDbType.Money, 8, "BalanceAmount"))
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT cod_customer, BalanceAmount FROM View_Customer_Balance"
        Me.SqlSelectCommand7.Connection = Me.Cnn
        '
        'DaSP_CustomerAgingNotDueYet
        '
        Me.DaSP_CustomerAgingNotDueYet.SelectCommand = Me.SqlCommand7
        Me.DaSP_CustomerAgingNotDueYet.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerAgingNotDueYet", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_CUSTOMER", "COD_CUSTOMER"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = "[SP_CustomerAgingNotDueYet]"
        Me.SqlCommand7.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand7.Connection = Me.Cnn
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        '
        'DaSP_CustomerAgingOver90
        '
        Me.DaSP_CustomerAgingOver90.SelectCommand = Me.SqlCommand8
        Me.DaSP_CustomerAgingOver90.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerAgingOver90", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_CUSTOMER", "COD_CUSTOMER"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlCommand8
        '
        Me.SqlCommand8.CommandText = "[SP_CustomerAgingOver90]"
        Me.SqlCommand8.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand8.Connection = Me.Cnn
        Me.SqlCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT view1.refrence_no_Adjustment, view1.sumpayment, GL_account_adjustment_head" & _
        ".amount_adjustment, GL_payment_deposit.refrence_no FROM (SELECT refrence_no_Adju" & _
        "stment, SUM(payment_amount) AS sumpayment FROM dbo.GL_payment_deposit WHERE (NOT" & _
        " (refrence_no_Adjustment IS NULL)) GROUP BY refrence_no_Adjustment) view1 INNER " & _
        "JOIN GL_account_adjustment_head ON view1.refrence_no_Adjustment = GL_account_adj" & _
        "ustment_head.refrence_no AND view1.sumpayment > GL_account_adjustment_head.amoun" & _
        "t_adjustment INNER JOIN GL_payment_deposit ON GL_account_adjustment_head.refrenc" & _
        "e_no = GL_payment_deposit.refrence_no_Adjustment"
        Me.SqlSelectCommand8.Connection = Me.Cnn
        '
        'DaPaymentGreatThatAdjustment
        '
        Me.DaPaymentGreatThatAdjustment.SelectCommand = Me.SqlSelectCommand8
        Me.DaPaymentGreatThatAdjustment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "View1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no_Adjustment", "refrence_no_Adjustment"), New System.Data.Common.DataColumnMapping("sumpayment", "sumpayment"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no")})})
        '
        'GridEXPrintDocument1
        '
        Me.GridEXPrintDocument1.GridEX = Me.GridEX1
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(17, 169)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT * FROM service_center_dtl WHERE (type_select = 'O') AND ((id_service_cente" & _
        "r + STR(radif)) NOT IN (SELECT id_service_center + str(radif) FROM service_out_p" & _
        "urchases))"
        Me.SqlSelectCommand10.Connection = Me.Cnn
        '
        'daserviceoutpurchase
        '
        Me.daserviceoutpurchase.SelectCommand = Me.SqlSelectCommand10
        Me.daserviceoutpurchase.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "outpo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE"), New System.Data.Common.DataColumnMapping("AVERAGE_COST", "AVERAGE_COST")})})
        '
        'FormCheckConsistencyAll
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(864, 526)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FormCheckConsistencyAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Consistency "
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmCheckDataConsistancy1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.GridEX3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.GridEX5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.GridEX6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        CType(Me.GridEX7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.GridEX4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FormCheckConsistencyAll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
    End Sub

    Private Sub CmdAdjustment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdjustment.Click
        LblNote1.Text = "In Progress ..."
        System.Windows.Forms.Application.DoEvents()
        Call AllAdjustment()
        Call SumHeadDtlDtlDtl()
        LblNote1.Text = "Finished"
    End Sub

    Sub SumHeadDtlDtlDtl()
        Try
            If cmd1.Connection.State <> ConnectionState.Open Then
                cmd1.Connection.Open()
            End If
            cmd1.CommandText = " SELECT     SUM(ROUND(amount_adjustment, 2)) AS SumHead FROM  GL_account_adjustment_head"
            TxtHeadAdjustment.Text = cmd1.ExecuteScalar & ""

            cmd1.CommandText = " SELECT     SUM(ROUND(amount_adjustment, 2)) AS SumHead FROM  GL_account_adjustment_dtl"
            TxtDtlAdjustment.Text = cmd1.ExecuteScalar & ""

            cmd1.CommandText = " SELECT     SUM(ROUND(amount_adjustment, 2)) AS SumHead FROM  GL_account_adjustment_dtl_dtl"
            TxtDtlDtlAdjustment.Text = cmd1.ExecuteScalar & ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub AllAdjustment()
        Dim ds1 As New DataSet
        DsFrmCheckDataConsistancy1.Adjustmentall.Clear()
        DsFrmCheckDataConsistancy1.GL_account_adjustment_head.Clear()
        DsFrmCheckDataConsistancy1.GL_account_adjustment_dtl.Clear()
        DsFrmCheckDataConsistancy1.GL_account_adjustment_dtl_dtl.Clear()
        DAGL_account_adjustment_head.Fill(DsFrmCheckDataConsistancy1.GL_account_adjustment_head)
        DAGL_account_adjustment_dtl.Fill(DsFrmCheckDataConsistancy1.GL_account_adjustment_dtl)
        DaGl_Account_adjustmentDtlDtl.Fill(DsFrmCheckDataConsistancy1.GL_account_adjustment_dtl_dtl)

        Dim i As Integer = 0
        Dim Mablaghead As Decimal = 0
        Dim MablagDtl As Decimal = 0
        Dim MablagDtlDtl As Decimal = 0
        Dim RefrenceNo As String = ""
        Dim CodCustomer As String = ""
        For i = 0 To DsFrmCheckDataConsistancy1.GL_account_adjustment_head.Rows.Count - 1
            Mablaghead = DsFrmCheckDataConsistancy1.GL_account_adjustment_head.Rows(i).Item("Amount_adjustment")
            RefrenceNo = DsFrmCheckDataConsistancy1.GL_account_adjustment_head.Rows(i).Item("refrence_no")
            CodCustomer = DsFrmCheckDataConsistancy1.GL_account_adjustment_head.Rows(i).Item("Cod_customer")
            Dim drDtl As DsFrmCheckDataConsistancy1.GL_account_adjustment_dtlRow = DsFrmCheckDataConsistancy1.GL_account_adjustment_dtl.FindByrefrence_no(RefrenceNo)
            Dim drDtlDtl As DsFrmCheckDataConsistancy1.GL_account_adjustment_dtl_dtlRow = DsFrmCheckDataConsistancy1.GL_account_adjustment_dtl_dtl.FindByrefrence_no(RefrenceNo)
            If drDtl Is Nothing Then
                Dim dr As DsFrmCheckDataConsistancy1.AdjustmentallRow = DsFrmCheckDataConsistancy1.Adjustmentall.NewAdjustmentallRow
                dr.amount_adjustment_head = Mablaghead
                dr.refrence_no = RefrenceNo
                dr.cod_customer = CodCustomer
                dr.Note = " this record Not exist in gl_acount_adjustment_dtl and gl_acount_adjustment_dtl_dtl"
                DsFrmCheckDataConsistancy1.Adjustmentall.AddAdjustmentallRow(dr)
            Else
                MablagDtl = Math.Round(Val("" & drDtl.sumdtl), 2)
                If Math.Round(MablagDtl, 2) <> Mablaghead Then
                    Dim dr As DsFrmCheckDataConsistancy1.AdjustmentallRow = DsFrmCheckDataConsistancy1.Adjustmentall.NewAdjustmentallRow
                    dr.amount_adjustment_head = Mablaghead
                    dr.amount_adjustment_Dtl = MablagDtl
                    dr.refrence_no = RefrenceNo
                    dr.Note = "Sum gl_acount_adjustment_dtl and gl_acount_adjustment_Head Not equal"
                    DsFrmCheckDataConsistancy1.Adjustmentall.AddAdjustmentallRow(dr)
                Else
                    If drDtlDtl Is Nothing Then
                        Dim dr As DsFrmCheckDataConsistancy1.AdjustmentallRow = DsFrmCheckDataConsistancy1.Adjustmentall.NewAdjustmentallRow
                        dr.amount_adjustment_head = Mablaghead
                        dr.refrence_no = RefrenceNo
                        dr.cod_customer = CodCustomer
                        dr.amount_adjustment_Dtl = MablagDtl
                        dr.Note = " this record Not exist in gl_acount_adjustment_dtl_Dtl "
                        DsFrmCheckDataConsistancy1.Adjustmentall.AddAdjustmentallRow(dr)
                    Else
                        MablagDtlDtl = Math.Round(Val("" & drDtlDtl.sumdtlDtl), 2)
                        If MablagDtlDtl <> MablagDtl Then
                            Dim dr As DsFrmCheckDataConsistancy1.AdjustmentallRow = DsFrmCheckDataConsistancy1.Adjustmentall.NewAdjustmentallRow
                            dr.amount_adjustment_head = Mablaghead
                            dr.refrence_no = RefrenceNo
                            dr.cod_customer = CodCustomer
                            dr.amount_adjustment_Dtl = MablagDtl
                            dr.amount_adjustment_Dtl_Dtl = MablagDtlDtl
                            dr.Note = " Sum gl_acount_adjustment_dtl_Dtl and gl_acount_adjustment_Head,Dtl Not equal "
                            DsFrmCheckDataConsistancy1.Adjustmentall.AddAdjustmentallRow(dr)
                        End If
                    End If
                End If
            End If
        Next
        DaGlDtlDtlSelfCheck.Fill(ds1, "t1")
        If ds1.Tables("t1").Rows.Count > 0 Then
            For i = 0 To ds1.Tables("t1").Rows.Count - 1
                With ds1.Tables("t1").Rows(i)
                    Dim dr As DsFrmCheckDataConsistancy1.AdjustmentallRow = DsFrmCheckDataConsistancy1.Adjustmentall.NewAdjustmentallRow
                    dr.refrence_no = .Item("Refrence_No_Due")
                    dr.amount_adjustment_Dtl_Dtl = .Item("amount_adjustment")
                    dr.Note = " IDGL_account_adjustment_dtl_Due NOT IN account_adjustment_dtl_dtl"
                    DsFrmCheckDataConsistancy1.Adjustmentall.AddAdjustmentallRow(dr)
                End With
            Next
        End If
        Dageneral.SelectCommand.CommandText = "SELECT refrence_no  FROM   GL_payment_deposit_Detail " & _
                  " WHERE     (ID_payment_due NOT IN (SELECT ID_payment  FROM   gl_payment_deposit)) "
        Dageneral.Fill(ds1, "t2")
        If ds1.Tables("t2").Rows.Count > 0 Then
            For i = 0 To ds1.Tables("t2").Rows.Count - 1
                With ds1.Tables("t2").Rows(i)
                    Dim dr As DsFrmCheckDataConsistancy1.AdjustmentallRow = DsFrmCheckDataConsistancy1.Adjustmentall.NewAdjustmentallRow
                    dr.refrence_no = .Item("Refrence_No")
                    dr.Note = " Not in gl_payment_deposit and exist in GL_payment_deposit_Detail"
                    DsFrmCheckDataConsistancy1.Adjustmentall.AddAdjustmentallRow(dr)
                End With
            Next
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        LblNote6.Text = "In Progress ..."
        System.Windows.Forms.Application.DoEvents()
        DsFrmCheckDataConsistancy1.GL_payment_deposit.Clear()
        DsFrmCheckDataConsistancy1.service_center_head.Clear()
        Dim i As Integer = 0

        If cmd1.Connection.State <> ConnectionState.Open Then
            cmd1.Connection.Open()
        End If

        DAGL_payment_deposit.Fill(DsFrmCheckDataConsistancy1.GL_payment_deposit)
        DAService_center_head.Fill(DsFrmCheckDataConsistancy1.service_center_head)
        For i = 0 To DsFrmCheckDataConsistancy1.GL_payment_deposit.Rows.Count - 1
            Try
                Dim dr1 As DsFrmCheckDataConsistancy1.service_center_headRow = DsFrmCheckDataConsistancy1.service_center_head.FindByid_service_center(DsFrmCheckDataConsistancy1.GL_payment_deposit.Rows(i).Item("Id_service_center"))
                If Not dr1 Is Nothing Then
                    If Math.Round(dr1.Total, 2) <> DsFrmCheckDataConsistancy1.GL_payment_deposit.Rows(i).Item("sumpayment") Then
                        DsFrmCheckDataConsistancy1.GL_payment_deposit.Rows(i).Item("Note") = " Sum In Gl_Pament_Deposit is " & DsFrmCheckDataConsistancy1.GL_payment_deposit.Rows(i).Item("sumpayment") & " And In service_center_head is " & Math.Round(dr1.Total, 2)
                        cmd1.CommandText = "UPDATE    service_center_head SET  Total= " & DsFrmCheckDataConsistancy1.GL_payment_deposit.Rows(i).Item("sumpayment")
                        cmd1.ExecuteNonQuery()
                    Else
                        DsFrmCheckDataConsistancy1.GL_payment_deposit.Rows(i).Delete()
                    End If
                Else
                    DsFrmCheckDataConsistancy1.GL_payment_deposit.Rows(i).Item("Note") = "No row In Gl_Pament_Deposit"
                End If
            Catch ex As Exception
            End Try
        Next
        LblNote6.Text = "Finished"
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        LblNote2.Text = "In Progress ..."
        System.Windows.Forms.Application.DoEvents()
        DsFrmCheckDataConsistancy1.Gl_Payment_deposit_head_dtl.Clear()
        DaGl_payment_deposit_head_dtlCheck.Fill(DsFrmCheckDataConsistancy1.Gl_Payment_deposit_head_dtl)
        LblNote2.Text = "Finished"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        LblNote7.Text = "In Progress ..."
        System.Windows.Forms.Application.DoEvents()
        DsFrmCheckDataConsistancy1.Glreceivepayment.Clear()
        daglrecpay1.Fill(DsFrmCheckDataConsistancy1.Glreceivepayment)
        LblNote7.Text = "Finished"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        LblNote1.Text = "In Progress ..."
        System.Windows.Forms.Application.DoEvents()
        DsFrmCheckDataConsistancy1.View_Customer_Balance.Clear()
        DsFrmCheckDataConsistancy1.SP_CustomerAging1to30.Clear()
        DsFrmCheckDataConsistancy1.SP_CustomerAging31to60.Clear()
        DsFrmCheckDataConsistancy1.SP_CustomerAging61to90.Clear()
        DsFrmCheckDataConsistancy1.SP_CustomerAgingNotDueYet.Clear()
        DsFrmCheckDataConsistancy1.SP_CustomerAgingOver90.Clear()
        DsFrmCheckDataConsistancy1.SP_CustomerBalance.Clear()

        DaCoustomerbalanceview.Fill(DsFrmCheckDataConsistancy1.View_Customer_Balance)
        With DaSP_CustomerAging1to30
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmCheckDataConsistancy1.SP_CustomerAging1to30)
        End With


        With DaSP_CustomerAging31to60
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmCheckDataConsistancy1.SP_CustomerAging31to60)
        End With


        With DaSP_CustomerAging61to90
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmCheckDataConsistancy1.SP_CustomerAging61to90)
        End With


        With DaSP_CustomerAgingNotDueYet
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmCheckDataConsistancy1.SP_CustomerAgingNotDueYet)
        End With


        With DaSP_CustomerAgingOver90
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmCheckDataConsistancy1.SP_CustomerAgingOver90)
        End With

        With DaSP_CustomerBalance
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmCheckDataConsistancy1.SP_CustomerBalance)
        End With

        Dim i As Long
        Pb1.Maximum = DsFrmCheckDataConsistancy1.View_Customer_Balance.Rows.Count + 1
        Pb1.Value = 0
        For i = 0 To DsFrmCheckDataConsistancy1.View_Customer_Balance.Rows.Count - 1
            Pb1.Value = i
            Application.DoEvents()
            With DsFrmCheckDataConsistancy1.View_Customer_Balance.Rows(i)
                .Item("BalanceSP") = Math.Round(Val("" & DsFrmCheckDataConsistancy1.SP_CustomerBalance.FindByCOD_CUSTOMER(.Item("Cod_customer")).BalanceAmount), 2)
                .Item("notdue") = Math.Round(Val("" & DsFrmCheckDataConsistancy1.SP_CustomerAgingNotDueYet.FindByCOD_CUSTOMER(.Item("Cod_customer")).BalanceAmount), 2)
                .Item("a1to30") = Math.Round(Val("" & DsFrmCheckDataConsistancy1.SP_CustomerAging1to30.FindByCOD_CUSTOMER(.Item("Cod_customer")).BalanceAmount), 2)
                .Item("a31to60") = Math.Round(Val("" & DsFrmCheckDataConsistancy1.SP_CustomerAging31to60.FindByCOD_CUSTOMER(.Item("Cod_customer")).BalanceAmount), 2)
                .Item("a61to90") = Math.Round(Val("" & DsFrmCheckDataConsistancy1.SP_CustomerAging61to90.FindByCOD_CUSTOMER(.Item("Cod_customer")).BalanceAmount), 2)
                .Item("over90") = Math.Round(Val("" & DsFrmCheckDataConsistancy1.SP_CustomerAgingOver90.FindByCOD_CUSTOMER(.Item("Cod_customer")).BalanceAmount), 2)
                .Item("sumall1") = .Item("notdue") + .Item("a1to30") + .Item("a31to60") + .Item("a61to90") + .Item("over90") 'Math.Round(CDec("0" & DsFrmCheckDataConsistancy1.SP_CustomerAgingNotDueYet.FindByCOD_CUSTOMER(.Item("Cod_customer")).BalanceAmount), 2)
            End With
        Next
        GridEX5.SuspendLayout()
        For i = 0 To DsFrmCheckDataConsistancy1.View_Customer_Balance.Rows.Count - 1
            With DsFrmCheckDataConsistancy1.View_Customer_Balance.Rows(i)
                If .Item("sumall1") = .Item("BalanceAmount") And .Item("BalanceSP") = .Item("BalanceAmount") Then
                    .Delete()
                End If
            End With
        Next
        GridEX5.ResumeLayout()
        GridEX5.Refetch()

        LblNote1.Text = "Finished"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        LblNote4.Text = "In Progress ..."
        System.Windows.Forms.Application.DoEvents()
        DsFrmCheckDataConsistancy1.View1.Clear()
        DaPaymentGreatThatAdjustment.Fill(DsFrmCheckDataConsistancy1.View1)
        LblNote4.Text = "Finished"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GridEXPrintDocument1.GridEX = GridEX1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        GridEXPrintDocument1.GridEX = GridEX6
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GridEXPrintDocument1.GridEX = GridEX2
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GridEXPrintDocument1.GridEX = GridEX3
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        GridEXPrintDocument1.GridEX = GridEX4
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        GridEXPrintDocument1.GridEX = GridEX5
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        LblNote5.Text = "In Progress ..."
        System.Windows.Forms.Application.DoEvents()
        DsFrmCheckDataConsistancy1.outpo.Clear()
        daserviceoutpurchase.Fill(DsFrmCheckDataConsistancy1.outpo)
        LblNote5.Text = "Finished"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        GridEXPrintDocument1.GridEX = GridEX7
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class
