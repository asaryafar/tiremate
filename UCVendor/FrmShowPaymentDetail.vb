Imports CommonClass
Public Class FrmShowPaymentDetail
    Inherits FrmBase
    Public Id_AP_bill_dtlVar As Double = 0
    Public OriginalDS As DSFrmGL_AP_bill
    Dim ThisFormDS As New DSFrmGL_AP_bill
    Public AR_termsVar As String
    Public Ref_dateVar As String
    Public AmountVar As Decimal
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
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents DsFrmShowPaymentDetail1 As UCVendor.DSFrmShowPaymentDetail
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmShowPaymentDetail1 = New UCVendor.DSFrmShowPaymentDetail
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmShowPaymentDetail1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH3;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=TireMate_01"
        '
        'GridEX1
        '
        Me.GridEX1.DataMember = "GL_AP_bill_Dtl_Dtl"
        Me.GridEX1.DataSource = Me.DsFrmShowPaymentDetail1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Due_Detail</Caption><Columns Collection=""tr" & _
        "ue""><Column0 ID=""Due_Date""><Caption>Due Date</Caption><TypeNameEmptyStringValue>" & _
        "System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>due_date" & _
        "</DataMember><EditType>NoEdit</EditType><Key>Due_Date</Key><Position>0</Position" & _
        "><Width>86</Width></Column0><Column1 ID=""Due_Amount""><Caption>Due Amount</Captio" & _
        "n><DataMember>amount</DataMember><EditType>NoEdit</EditType><FormatString>c2</Fo" & _
        "rmatString><Key>Due_Amount</Key><Position>1</Position><TextAlignment>Far</TextAl" & _
        "ignment><Width>102</Width></Column1></Columns><GroupCondition ID="""" /><Key>Due_D" & _
        "etail</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 0)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(214, 115)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmShowPaymentDetail1
        '
        Me.DsFrmShowPaymentDetail1.DataSetName = "DSFrmShowPaymentDetail"
        Me.DsFrmShowPaymentDetail1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'FrmShowPaymentDetail
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(214, 115)
        Me.Controls.Add(Me.GridEX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmShowPaymentDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Show Detail"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmShowPaymentDetail1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmShowPaymentDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString

        OriginalDS.GL_AP_bill_Dtl_Dtl.DefaultView.RowFilter = "Id_AP_bill_dtl=" & Id_AP_bill_dtlVar
        If OriginalDS.GL_AP_bill_Dtl_Dtl.DefaultView.Count > 0 Then
            Dim i As Integer
            For i = 0 To OriginalDS.GL_AP_bill_Dtl_Dtl.DefaultView.Count - 1
                If OriginalDS.GL_AP_bill_Dtl_Dtl.DefaultView(i).Row.RowState <> DataRowState.Deleted Then
                    Dim dr As DataRow
                    dr = ThisFormDS.GL_AP_bill_Dtl_Dtl.NewRow
                    dr("Id_AP_bill_dtl") = OriginalDS.GL_AP_bill_Dtl_Dtl.DefaultView(i).Item("Id_AP_bill_dtl")
                    dr("Amount") = OriginalDS.GL_AP_bill_Dtl_Dtl.DefaultView(i).Item("Amount")
                    dr("due_date") = OriginalDS.GL_AP_bill_Dtl_Dtl.DefaultView(i).Item("due_date")
                    ThisFormDS.GL_AP_bill_Dtl_Dtl.Rows.Add(dr)
                End If
            Next
        Else
            Call CalcDueDetail(AR_termsVar, AmountVar, Ref_dateVar, ThisFormDS.GL_AP_bill_Dtl_Dtl)
        End If
        GridEX1.DataSource = ThisFormDS
        GridEX1.DataMember = "GL_AP_bill_Dtl_Dtl"
        GridEX1.Refetch()
    End Sub
End Class
