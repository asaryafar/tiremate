Imports CommonClass
Public Class FrmCashPaidOutPrintGrd
    Inherits Frmbase
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
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents DsFrmCashPaidOutPrint1 As UCBankAccount.DSFrmCashPaidOutPrint
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCashPaidOutPrintGrd))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmCashPaidOutPrint1 = New UCBankAccount.DSFrmCashPaidOutPrint
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmCashPaidOutPrint1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "GL_Paid_received"
        Me.GridEX1.DataSource = Me.DsFrmCashPaidOutPrint1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_Paid_received</Caption><Columns Collecti" & _
        "on=""true""><Column0 ID=""CustomerName""><Caption>Customer Name</Caption><DataMember" & _
        ">CustomerName</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Fi" & _
        "lterEditType><Key>CustomerName</Key><Position>0</Position><Width>154</Width></Co" & _
        "lumn0><Column1 ID=""company""><Caption>Company</Caption><DataMember>company</DataM" & _
        "ember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>co" & _
        "mpany</Key><Position>1</Position><Width>160</Width></Column1><Column2 ID=""desc_v" & _
        "endor""><Caption>Vendor Name</Caption><DataMember>desc_vendor</DataMember><EditTy" & _
        "pe>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>desc_vendor</Ke" & _
        "y><Position>2</Position><Width>181</Width></Column2><Column3 ID=""refrence_code"">" & _
        "<Caption>Ref No</Caption><TypeNameEmptyStringValue>System.String</TypeNameEmptyS" & _
        "tringValue><EmptyStringValue /><DataMember>refrence_code</DataMember><EditType>N" & _
        "oEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>refrence_code</Key>" & _
        "<Position>3</Position><Width>71</Width></Column3><Column4 ID=""id_service_center""" & _
        "><Caption>Work Order</Caption><DataMember>id_service_center</DataMember><EditTyp" & _
        "e>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>id_service_cente" & _
        "r</Key><Position>4</Position><Width>72</Width></Column4><Column5 ID=""action_date" & _
        """><Caption>Date</Caption><DataMember>action_date</DataMember><EditType>NoEdit</E" & _
        "ditType><FilterEditType>TextBox</FilterEditType><Key>action_date</Key><Position>" & _
        "5</Position><Width>72</Width></Column5><Column6 ID=""amount""><AggregateFunction>S" & _
        "um</AggregateFunction><Caption>Amount</Caption><DataMember>amount</DataMember><E" & _
        "ditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c" & _
        "</FormatString><Key>amount</Key><Position>6</Position><TextAlignment>Far</TextAl" & _
        "ignment><Width>87</Width><TotalFormatString>c2</TotalFormatString></Column6><Col" & _
        "umn7 ID=""PayMethod""><Caption>Pay Method</Caption><DataMember>PayMethod</DataMemb" & _
        "er><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>PayMe" & _
        "thod</Key><Position>7</Position><Width>75</Width></Column7><Column8 ID=""desc_GL_" & _
        "account""><Caption>GL Account</Caption><DataMember>desc_GL_account</DataMember><E" & _
        "ditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>desc_GL_ac" & _
        "count</Key><Position>8</Position><Width>155</Width></Column8><Column9 ID=""memo"">" & _
        "<Caption>Memo</Caption><DataMember>memo</DataMember><EditType>NoEdit</EditType><" & _
        "FilterEditType>TextBox</FilterEditType><Key>memo</Key><Position>9</Position><Wid" & _
        "th>81</Width></Column9></Columns><GroupCondition ID="""" /><GroupTotals>Always</Gr" & _
        "oupTotals><Key>GL_Paid_received</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.Location = New System.Drawing.Point(0, 0)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(752, 440)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmCashPaidOutPrint1
        '
        Me.DsFrmCashPaidOutPrint1.DataSetName = "DSFrmCashPaidOutPrint"
        Me.DsFrmCashPaidOutPrint1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CmdExit)
        Me.Panel3.Controls.Add(Me.CmdOk)
        Me.Panel3.Location = New System.Drawing.Point(5, 448)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(739, 32)
        Me.Panel3.TabIndex = 4
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(633, 4)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(94, 23)
        Me.CmdExit.TabIndex = 1
        Me.CmdExit.Text = "Exit"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(15, 4)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(94, 23)
        Me.CmdOk.TabIndex = 0
        Me.CmdOk.Text = "Print"
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
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(203, 22)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'FrmCashPaidOutPrintGrd
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(752, 486)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmCashPaidOutPrintGrd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Paid Out Print"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmCashPaidOutPrint1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public LeftTop As String
    Public CenterTop As String
    Public RightTop As String
    Public LeftDown As String
    Public CenterDown As String
    Public RightDown As String
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
End Class
