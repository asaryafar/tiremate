Imports CommonClass
Public Class FrmEndOfDayChecksWritten
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
    Friend WithEvents DAbank_check As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDayChecksWritten1 As UCBankAccount.DSFrmEndOfDayChecksWritten
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDayChecksWritten))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmEndOfDayChecksWritten1 = New UCBankAccount.DSFrmEndOfDayChecksWritten
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAbank_check = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmEndOfDayChecksWritten1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "bank_check"
        Me.GridEX1.DataSource = Me.DsFrmEndOfDayChecksWritten1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>bank_check</Caption><Columns Collection=""tr" & _
        "ue""><Column0 ID=""no_of_check""><Caption>Check No.</Caption><DataMember>no_of_chec" & _
        "k</DataMember><Key>no_of_check</Key><Position>0</Position><Width>79</Width></Col" & _
        "umn0><Column1 ID=""date_of_check""><Caption>Date</Caption><DataMember>date_of_chec" & _
        "k</DataMember><Key>date_of_check</Key><Position>1</Position><Width>67</Width></C" & _
        "olumn1><Column2 ID=""name_bank""><Caption>Bank</Caption><DataMember>name_bank</Dat" & _
        "aMember><Key>name_bank</Key><Position>2</Position><Width>138</Width></Column2><C" & _
        "olumn3 ID=""amount_check""><Caption>Check Amount</Caption><DataMember>amount_check" & _
        "</DataMember><FormatString>c</FormatString><Key>amount_check</Key><Position>3</P" & _
        "osition><TextAlignment>Far</TextAlignment><Width>91</Width></Column3><Column4 ID" & _
        "=""payee""><Caption>Payee</Caption><DataMember>payee</DataMember><Key>payee</Key><" & _
        "Position>4</Position><Width>144</Width></Column4><Column5 ID=""memo_check""><Capti" & _
        "on>Memo</Caption><DataMember>memo_check</DataMember><Key>memo_check</Key><Positi" & _
        "on>5</Position><Width>174</Width></Column5></Columns><GroupCondition ID="""" /><Ke" & _
        "y>bank_check</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 40)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(718, 348)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmEndOfDayChecksWritten1
        '
        Me.DsFrmEndOfDayChecksWritten1.DataSetName = "DSFrmEndOfDayChecksWritten"
        Me.DsFrmEndOfDayChecksWritten1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_01;password=sa"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT bank_check.no_of_check, bank_check.date_of_check, bas_banks.name_bank, ban" & _
        "k_check.amount_check, bank_check.memo_check, inv_vendor.desc_vendor AS payee FRO" & _
        "M bank_check LEFT OUTER JOIN bas_banks ON bank_check.id_bank = bas_banks.id_bank" & _
        " LEFT OUTER JOIN inv_vendor ON bank_check.cod_vendor = inv_vendor.cod_vendor"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAbank_check
        '
        Me.DAbank_check.SelectCommand = Me.SqlSelectCommand1
        Me.DAbank_check.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_check", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("no_of_check", "no_of_check"), New System.Data.Common.DataColumnMapping("date_of_check", "date_of_check"), New System.Data.Common.DataColumnMapping("amount_check", "amount_check"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("address_payee", "address_payee"), New System.Data.Common.DataColumnMapping("memo_check", "memo_check"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("manual_check", "manual_check"), New System.Data.Common.DataColumnMapping("print_later", "print_later"), New System.Data.Common.DataColumnMapping("cleared_bank", "cleared_bank"), New System.Data.Common.DataColumnMapping("check_status", "check_status"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
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
        'FrmEndOfDayChecksWritten
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 388)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmEndOfDayChecksWritten"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checks Written"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmEndOfDayChecksWritten1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAbank_check.SelectCommand.CommandText = DAbank_check.SelectCommand.CommandText & WhereClauseVar & " ORDER BY bank_check.no_of_check"
        DAbank_check.Fill(DsFrmEndOfDayChecksWritten1.bank_check)

        GridEX1.Refetch()
        GridEX1.Refresh()

    End Sub
End Class
