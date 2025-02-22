Imports CommonClass
Public Class FrmEndOfDayBankTransfers
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
    Friend WithEvents DAGL_transfer_amount As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayBankTransfers1 As UCBankAccount.DSFrmEndOfDayBankTransfers
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayBankTransfers))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayBankTransfers1 = New UCBankAccount.DSFrmEndOfDayBankTransfers
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_transfer_amount = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayBankTransfers1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "GL_transfer_amount"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayBankTransfers1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>bank_check</Caption><Columns Collection=""tr" & _
        "ue""><Column0 ID=""date_of_check""><Caption>Date</Caption><DataMember>date_transfer" & _
        "</DataMember><Key>date_of_check</Key><Position>0</Position><Width>74</Width></Co" & _
        "lumn0><Column1 ID=""amount_check""><Caption>Transfer Amount</Caption><DataMember>a" & _
        "mount_transfer</DataMember><FormatString>c</FormatString><Key>amount_check</Key>" & _
        "<Position>1</Position><TextAlignment>Far</TextAlignment></Column1><Column2 ID=""f" & _
        "romBank""><Caption>From Bank</Caption><DataMember>fromBank</DataMember><Key>fromB" & _
        "ank</Key><Position>2</Position><Width>128</Width></Column2><Column3 ID=""ToBank"">" & _
        "<Caption>To Bank</Caption><DataMember>ToBank</DataMember><Key>ToBank</Key><Posit" & _
        "ion>3</Position><Width>127</Width></Column3><Column4 ID=""memo""><Caption>Memo</Ca" & _
        "ption><DataMember>memo</DataMember><Key>memo</Key><Position>4</Position><Width>2" & _
        "61</Width></Column4></Columns><GroupCondition ID="""" /><Key>bank_check</Key></Roo" & _
        "tTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 40)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(718, 348)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayBankTransfers1
        '
        Me.DsFrmEndOfDayBankTransfers1.DataSetName = "DSFrmEndOfDayBankTransfers"
        Me.DsFrmEndOfDayBankTransfers1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_01;password=sa"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_transfer_amount.date_transfer, GL_transfer_amount.amount_transfer, GL_t" & _
        "ransfer_amount.memo, bas_banks.name_bank AS fromBank, bas_banks_1.name_bank AS T" & _
        "oBank FROM GL_transfer_amount INNER JOIN bas_banks ON GL_transfer_amount.id_bank" & _
        "_from_transfer = bas_banks.id_bank INNER JOIN bas_banks bas_banks_1 ON GL_transf" & _
        "er_amount.id_bank_to_transfer = bas_banks_1.id_bank"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAGL_transfer_amount
        '
        Me.DAGL_transfer_amount.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_transfer_amount.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_transfer_amount", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_transfer", "id_transfer"), New System.Data.Common.DataColumnMapping("id_bank_from_transfer", "id_bank_from_transfer"), New System.Data.Common.DataColumnMapping("id_bank_to_transfer", "id_bank_to_transfer"), New System.Data.Common.DataColumnMapping("date_transfer", "date_transfer"), New System.Data.Common.DataColumnMapping("amount_transfer", "amount_transfer"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
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
        Me.Panel4.Size = New System.Drawing.Size(718, 45)
        Me.Panel4.TabIndex = 10
        '
        'UcPrintGrid1
        '
        Me.UcPrintGrid1.GridEx = Me.GridEX1
        Me.UcPrintGrid1.Location = New System.Drawing.Point(513, 8)
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
        'FrmEndOfDayBankTransfers
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 388)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayBankTransfers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank Transfers"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayBankTransfers1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAGL_transfer_amount.SelectCommand.CommandText = DAGL_transfer_amount.SelectCommand.CommandText & WhereClauseVar & " ORDER BY GL_transfer_amount.id_transfer"
        DAGL_transfer_amount.Fill(DsFrmEndOfDayBankTransfers1.GL_transfer_amount)

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
End Class
