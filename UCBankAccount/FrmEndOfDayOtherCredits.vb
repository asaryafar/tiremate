Imports CommonClass
Public Class FrmEndOfDayOtherCredits
    Inherits FrmBase
    Public WhereClauseVar As String
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account_adjustment_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayOtherCredits1 As UCBankAccount.DSFrmEndOfDayOtherCredits
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayOtherCredits))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayOtherCredits1 = New UCBankAccount.DSFrmEndOfDayOtherCredits
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account_adjustment_head = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayOtherCredits1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "GL_account_adjustment_head"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayOtherCredits1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_account_adjustment_head</Caption><Column" & _
        "s Collection=""true""><Column0 ID=""refrence_no""><Caption>Refrence No</Caption><Typ" & _
        "eNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue " & _
        "/><DataMember>refrence_no</DataMember><Key>refrence_no</Key><Position>0</Positio" & _
        "n></Column0><Column1 ID=""date_adjustment""><Caption>Date</Caption><DataMember>dat" & _
        "e_adjustment</DataMember><Key>date_adjustment</Key><Position>1</Position><Width>" & _
        "73</Width></Column1><Column2 ID=""amount_adjustment""><Caption>Debit Amount</Capti" & _
        "on><DataMember>amount_adjustment</DataMember><FormatString>c</FormatString><Key>" & _
        "amount_adjustment</Key><Position>2</Position><TextAlignment>Far</TextAlignment><" & _
        "/Column2><Column3 ID=""desc_GL_account""><Caption>GL Account Name</Caption><DataMe" & _
        "mber>desc_GL_account</DataMember><Key>desc_GL_account</Key><Position>3</Position" & _
        "><Width>217</Width></Column3></Columns><GroupCondition ID="""" /><Key>GL_account_a" & _
        "djustment_head</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 40)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(510, 348)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayOtherCredits1
        '
        Me.DsFrmEndOfDayOtherCredits1.DataSetName = "DSFrmEndOfDayOtherCredits"
        Me.DsFrmEndOfDayOtherCredits1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_01;password=sa"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_account_adjustment_head.refrence_no, GL_account_adjustment_head.date_ad" & _
        "justment, GL_account_adjustment_head.amount_adjustment, GL_account.desc_GL_accou" & _
        "nt FROM GL_account_adjustment_head INNER JOIN GL_account ON GL_account_adjustmen" & _
        "t_head.GL_account = GL_account.GL_account"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAGL_account_adjustment_head
        '
        Me.DAGL_account_adjustment_head.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_account_adjustment_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("Remark", "Remark"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Gl_receive_payment_Refrence_no", "Gl_receive_payment_Refrence_no")})})
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.UcPrintGrid1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(510, 45)
        Me.Panel4.TabIndex = 10
        '
        'UcPrintGrid1
        '
        Me.UcPrintGrid1.GridEx = Me.GridEX1
        Me.UcPrintGrid1.Location = New System.Drawing.Point(312, 8)
        Me.UcPrintGrid1.Name = "UcPrintGrid1"
        Me.UcPrintGrid1.Size = New System.Drawing.Size(176, 24)
        Me.UcPrintGrid1.TabIndex = 209
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 208
        Me.PictureBox2.TabStop = False
        '
        'FrmEndOfDayOtherCredits
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(510, 388)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayOtherCredits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Other Credits"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayOtherCredits1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAGL_account_adjustment_head.SelectCommand.CommandText = DAGL_account_adjustment_head.SelectCommand.CommandText & WhereClauseVar & " ORDER BY GL_account_adjustment_head.refrence_no"
        DAGL_account_adjustment_head.Fill(DsFrmEndOfDayOtherCredits1.GL_account_adjustment_head)

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
End Class
