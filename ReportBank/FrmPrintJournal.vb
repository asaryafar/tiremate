Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmPrintJournal
    Inherits CommonClass.FrmBase

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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnFchooser As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnEmail As System.Windows.Forms.Button
    Friend WithEvents BtnJPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnDeselect As System.Windows.Forms.Button
    Friend WithEvents BtnSelect As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents DAGeneral As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmPrintJournal1 As ReportBank.DSFrmPrintJournal
    Friend WithEvents GrdIncome As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmbChildLedger As Janus.Windows.EditControls.UIButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtIncome As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TxtExpense As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtnet As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPrintJournal))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.CmbChildLedger = New Janus.Windows.EditControls.UIButton
        Me.BtnFchooser = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.BtnEmail = New System.Windows.Forms.Button
        Me.BtnJPrint = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnDeselect = New System.Windows.Forms.Button
        Me.BtnSelect = New System.Windows.Forms.Button
        Me.GrdIncome = New Janus.Windows.GridEX.GridEX
        Me.DsFrmPrintJournal1 = New ReportBank.DSFrmPrintJournal
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.DAGeneral = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtnet = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtExpense = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtIncome = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4.SuspendLayout()
        CType(Me.GrdIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmPrintJournal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.CmbChildLedger)
        Me.Panel4.Controls.Add(Me.BtnFchooser)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.BtnEmail)
        Me.Panel4.Controls.Add(Me.BtnJPrint)
        Me.Panel4.Controls.Add(Me.BtnPrint)
        Me.Panel4.Controls.Add(Me.BtnPreview)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.BtnDeselect)
        Me.Panel4.Controls.Add(Me.BtnSelect)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(686, 64)
        Me.Panel4.TabIndex = 7
        '
        'CmbChildLedger
        '
        Me.CmbChildLedger.Location = New System.Drawing.Point(299, 14)
        Me.CmbChildLedger.Name = "CmbChildLedger"
        Me.CmbChildLedger.Size = New System.Drawing.Size(50, 27)
        Me.CmbChildLedger.TabIndex = 195
        Me.CmbChildLedger.Text = "Expand"
        '
        'BtnFchooser
        '
        Me.BtnFchooser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFchooser.Image = CType(resources.GetObject("BtnFchooser.Image"), System.Drawing.Image)
        Me.BtnFchooser.Location = New System.Drawing.Point(635, 5)
        Me.BtnFchooser.Name = "BtnFchooser"
        Me.BtnFchooser.Size = New System.Drawing.Size(33, 27)
        Me.BtnFchooser.TabIndex = 192
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(627, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "Field  Chooser"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(368, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 23)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "Deselect All"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(583, 36)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(43, 25)
        Me.Label31.TabIndex = 182
        Me.Label31.Text = "Send to Excel"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(531, 36)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 24)
        Me.Label30.TabIndex = 181
        Me.Label30.Text = "Grid Print"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(478, 39)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 180
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(421, 39)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 179
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEmail
        '
        Me.BtnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEmail.Image = CType(resources.GetObject("BtnEmail.Image"), System.Drawing.Image)
        Me.BtnEmail.Location = New System.Drawing.Point(585, 5)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 13
        '
        'BtnJPrint
        '
        Me.BtnJPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnJPrint.Image = CType(resources.GetObject("BtnJPrint.Image"), System.Drawing.Image)
        Me.BtnJPrint.Location = New System.Drawing.Point(533, 5)
        Me.BtnJPrint.Name = "BtnJPrint"
        Me.BtnJPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnJPrint.TabIndex = 12
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(480, 5)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 11
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(429, 5)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 62)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select your options for printing this report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 190
        Me.PictureBox2.TabStop = False
        '
        'BtnDeselect
        '
        Me.BtnDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeselect.Image = CType(resources.GetObject("BtnDeselect.Image"), System.Drawing.Image)
        Me.BtnDeselect.Location = New System.Drawing.Point(377, 5)
        Me.BtnDeselect.Name = "BtnDeselect"
        Me.BtnDeselect.Size = New System.Drawing.Size(33, 27)
        Me.BtnDeselect.TabIndex = 193
        '
        'BtnSelect
        '
        Me.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.Location = New System.Drawing.Point(377, 5)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(33, 27)
        Me.BtnSelect.TabIndex = 183
        '
        'GrdIncome
        '
        Me.GrdIncome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdIncome.DataMember = "Income"
        Me.GrdIncome.DataSource = Me.DsFrmPrintJournal1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""GL_account"">" & _
        "<Caption>GL Account No</Caption><DataMember>GL_account</DataMember><EditType>NoE" & _
        "dit</EditType><Key>GL_account</Key><Position>0</Position><Width>106</Width></Col" & _
        "umn0><Column1 ID=""desc_GL_account""><Caption>Acount Name</Caption><DataMember>des" & _
        "c_GL_account</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Fil" & _
        "terEditType><Key>desc_GL_account</Key><Position>1</Position><Width>120</Width></" & _
        "Column1><Column2 ID=""amount""><AggregateFunction>Sum</AggregateFunction><Caption>" & _
        "Amount</Caption><DataMember>amount</DataMember><EditType>NoEdit</EditType><Filte" & _
        "rEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>amount</Ke" & _
        "y><Position>2</Position><TextAlignment>Far</TextAlignment><TotalFormatString>c2<" & _
        "/TotalFormatString></Column2><Column3 ID=""desc_group_account""><Caption>Gl Acount" & _
        " Group</Caption><DataMember>desc_group_account</DataMember><EditType>NoEdit</Edi" & _
        "tType><FilterEditType>TextBox</FilterEditType><Key>desc_group_account</Key><Posi" & _
        "tion>3</Position></Column3><Column4 ID=""Gl_account_group_subgroup1_desc""><Captio" & _
        "n>Gl Acount SubGroup1</Caption><DataMember>Gl_account_group_subgroup1_desc</Data" & _
        "Member><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>G" & _
        "l_account_group_subgroup1_desc</Key><Position>4</Position><Width>126</Width></Co" & _
        "lumn4><Column5 ID=""GL_journal_date""><Caption>Date</Caption><DataMember>GL_journa" & _
        "l_date</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEdi" & _
        "tType><Key>GL_journal_date</Key><Position>5</Position><Width>85</Width></Column5" & _
        "><Column6 ID=""GL_journal_reference""><Caption>Reference</Caption><DataMember>GL_j" & _
        "ournal_reference</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox<" & _
        "/FilterEditType><Key>GL_journal_reference</Key><Position>6</Position></Column6><" & _
        "Column7 ID=""GL_journal_type_desc""><Caption>Journal Type</Caption><DataMember>GL_" & _
        "journal_type_desc</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox" & _
        "</FilterEditType><Key>GL_journal_type_desc</Key><Position>7</Position></Column7>" & _
        "<Column8 ID=""id_GL_journal""><Caption>Journal No</Caption><DataMember>id_GL_journ" & _
        "al</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTyp" & _
        "e><Key>id_GL_journal</Key><Position>8</Position></Column8></Columns><GroupCondit" & _
        "ion ID="""" /><Groups Collection=""true""><Group0 ID=""Group0""><ColIndex>0</ColIndex>" & _
        "</Group0></Groups></RootTable></GridEXLayoutData>"
        Me.GrdIncome.DesignTimeLayout = GridEXLayout1
        Me.GrdIncome.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdIncome.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdIncome.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GrdIncome.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdIncome.Location = New System.Drawing.Point(0, 64)
        Me.GrdIncome.Name = "GrdIncome"
        Me.GrdIncome.Size = New System.Drawing.Size(688, 328)
        Me.GrdIncome.TabIndex = 16
        Me.GrdIncome.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DsFrmPrintJournal1
        '
        Me.DsFrmPrintJournal1.DataSetName = "DSFrmPrintJournal"
        Me.DsFrmPrintJournal1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(517, 17)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'GridEXPrintDocument1
        '
        '
        'DAGeneral
        '
        Me.DAGeneral.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAGeneral.InsertCommand = Me.SqlInsertCommand1
        Me.DAGeneral.SelectCommand = Me.SqlSelectCommand1
        Me.DAGeneral.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_check", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("no_of_check", "no_of_check"), New System.Data.Common.DataColumnMapping("date_of_check", "date_of_check"), New System.Data.Common.DataColumnMapping("amount_check", "amount_check"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("address_payee", "address_payee"), New System.Data.Common.DataColumnMapping("memo_check", "memo_check"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("manual_check", "manual_check"), New System.Data.Common.DataColumnMapping("print_later", "print_later"), New System.Data.Common.DataColumnMapping("cleared_bank", "cleared_bank"), New System.Data.Common.DataColumnMapping("check_status", "check_status"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        Me.DAGeneral.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM bank_check WHERE (id_check = @Original_id_check) AND (address_payee =" & _
        " @Original_address_payee OR @Original_address_payee IS NULL AND address_payee IS" & _
        " NULL) AND (amount_check = @Original_amount_check OR @Original_amount_check IS N" & _
        "ULL AND amount_check IS NULL) AND (check_status = @Original_check_status OR @Ori" & _
        "ginal_check_status IS NULL AND check_status IS NULL) AND (cleared_bank = @Origin" & _
        "al_cleared_bank OR @Original_cleared_bank IS NULL AND cleared_bank IS NULL) AND " & _
        "(cod_vendor = @Original_cod_vendor OR @Original_cod_vendor IS NULL AND cod_vendo" & _
        "r IS NULL) AND (date_of_check = @Original_date_of_check OR @Original_date_of_che" & _
        "ck IS NULL AND date_of_check IS NULL) AND (employee_code = @Original_employee_co" & _
        "de OR @Original_employee_code IS NULL AND employee_code IS NULL) AND (id_GL_jour" & _
        "nal = @Original_id_GL_journal OR @Original_id_GL_journal IS NULL AND id_GL_journ" & _
        "al IS NULL) AND (id_bank = @Original_id_bank OR @Original_id_bank IS NULL AND id" & _
        "_bank IS NULL) AND (id_debit_deposit_head = @Original_id_debit_deposit_head OR @" & _
        "Original_id_debit_deposit_head IS NULL AND id_debit_deposit_head IS NULL) AND (i" & _
        "nvoice_no = @Original_invoice_no OR @Original_invoice_no IS NULL AND invoice_no " & _
        "IS NULL) AND (manual_check = @Original_manual_check OR @Original_manual_check IS" & _
        " NULL AND manual_check IS NULL) AND (memo_check = @Original_memo_check OR @Origi" & _
        "nal_memo_check IS NULL AND memo_check IS NULL) AND (no_of_check = @Original_no_o" & _
        "f_check OR @Original_no_of_check IS NULL AND no_of_check IS NULL) AND (print_lat" & _
        "er = @Original_print_later OR @Original_print_later IS NULL AND print_later IS N" & _
        "ULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_check", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address_payee", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address_payee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_check", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_check_status", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "check_status", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cleared_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cleared_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_of_check", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_of_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_debit_deposit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_invoice_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "invoice_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_manual_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "manual_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo_check", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_no_of_check", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "no_of_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_print_later", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "print_later", System.Data.DataRowVersion.Original, Nothing))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARYAFAR;packet size=4096;user id=sa;data source=aryafar;persist se" & _
        "curity info=False;initial catalog=TireMate_02"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO bank_check(id_bank, no_of_check, date_of_check, amount_check, cod_ven" & _
        "dor, employee_code, address_payee, memo_check, invoice_no, manual_check, print_l" & _
        "ater, cleared_bank, check_status, id_debit_deposit_head, id_GL_journal) VALUES (" & _
        "@id_bank, @no_of_check, @date_of_check, @amount_check, @cod_vendor, @employee_co" & _
        "de, @address_payee, @memo_check, @invoice_no, @manual_check, @print_later, @clea" & _
        "red_bank, @check_status, @id_debit_deposit_head, @id_GL_journal); SELECT id_chec" & _
        "k, id_bank, no_of_check, date_of_check, amount_check, cod_vendor, employee_code," & _
        " address_payee, memo_check, invoice_no, manual_check, print_later, cleared_bank," & _
        " check_status, id_debit_deposit_head, id_GL_journal FROM bank_check WHERE (id_ch" & _
        "eck = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@no_of_check", System.Data.SqlDbType.VarChar, 20, "no_of_check"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_of_check", System.Data.SqlDbType.VarChar, 10, "date_of_check"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_check", System.Data.SqlDbType.Money, 8, "amount_check"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address_payee", System.Data.SqlDbType.VarChar, 150, "address_payee"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo_check", System.Data.SqlDbType.VarChar, 200, "memo_check"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@invoice_no", System.Data.SqlDbType.VarChar, 20, "invoice_no"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@manual_check", System.Data.SqlDbType.Bit, 1, "manual_check"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@print_later", System.Data.SqlDbType.Bit, 1, "print_later"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cleared_bank", System.Data.SqlDbType.Bit, 1, "cleared_bank"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@check_status", System.Data.SqlDbType.VarChar, 1, "check_status"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "id_debit_deposit_head"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_journal_head.GL_journal_date, GL_journal_dtl.GL_account, GL_account.des" & _
        "c_GL_account, GL_journal_dtl.GL_journal_amount_debit, GL_journal_dtl.GL_journal_" & _
        "amount_credit, GL_journal_dtl.GL_journal_reference, GL_type_journal.GL_journal_t" & _
        "ype_desc, GL_type_journal.GL_journal_type_code, GL_account_group.desc_group_acco" & _
        "unt, GL_account_group_subgroup1.Gl_account_group_subgroup1_desc, GL_account_grou" & _
        "p_subgroup2.Gl_account_group_subgroup2_desc FROM GL_journal_head INNER JOIN GL_j" & _
        "ournal_dtl ON GL_journal_head.id_GL_journal = GL_journal_dtl.id_GL_journal INNER" & _
        " JOIN GL_account ON GL_journal_dtl.GL_account = GL_account.GL_account INNER JOIN" & _
        " GL_type_journal ON GL_journal_head.GL_journal_type_code = GL_type_journal.GL_jo" & _
        "urnal_type_code INNER JOIN GL_account_group ON GL_account.group_GL_account = GL_" & _
        "account_group.group_GL_account INNER JOIN GL_account_group_subgroup1 ON GL_accou" & _
        "nt.Gl_account_group_subgroup1_code = GL_account_group_subgroup1.Gl_account_group" & _
        "_subgroup1_code INNER JOIN GL_account_group_subgroup2 ON GL_account.Gl_account_g" & _
        "roup_subgroup2_code = GL_account_group_subgroup2.Gl_account_group_subgroup2_code" & _
        ""
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE bank_check SET id_bank = @id_bank, no_of_check = @no_of_check, date_of_che" & _
        "ck = @date_of_check, amount_check = @amount_check, cod_vendor = @cod_vendor, emp" & _
        "loyee_code = @employee_code, address_payee = @address_payee, memo_check = @memo_" & _
        "check, invoice_no = @invoice_no, manual_check = @manual_check, print_later = @pr" & _
        "int_later, cleared_bank = @cleared_bank, check_status = @check_status, id_debit_" & _
        "deposit_head = @id_debit_deposit_head, id_GL_journal = @id_GL_journal WHERE (id_" & _
        "check = @Original_id_check) AND (address_payee = @Original_address_payee OR @Ori" & _
        "ginal_address_payee IS NULL AND address_payee IS NULL) AND (amount_check = @Orig" & _
        "inal_amount_check OR @Original_amount_check IS NULL AND amount_check IS NULL) AN" & _
        "D (check_status = @Original_check_status OR @Original_check_status IS NULL AND c" & _
        "heck_status IS NULL) AND (cleared_bank = @Original_cleared_bank OR @Original_cle" & _
        "ared_bank IS NULL AND cleared_bank IS NULL) AND (cod_vendor = @Original_cod_vend" & _
        "or OR @Original_cod_vendor IS NULL AND cod_vendor IS NULL) AND (date_of_check = " & _
        "@Original_date_of_check OR @Original_date_of_check IS NULL AND date_of_check IS " & _
        "NULL) AND (employee_code = @Original_employee_code OR @Original_employee_code IS" & _
        " NULL AND employee_code IS NULL) AND (id_GL_journal = @Original_id_GL_journal OR" & _
        " @Original_id_GL_journal IS NULL AND id_GL_journal IS NULL) AND (id_bank = @Orig" & _
        "inal_id_bank OR @Original_id_bank IS NULL AND id_bank IS NULL) AND (id_debit_dep" & _
        "osit_head = @Original_id_debit_deposit_head OR @Original_id_debit_deposit_head I" & _
        "S NULL AND id_debit_deposit_head IS NULL) AND (invoice_no = @Original_invoice_no" & _
        " OR @Original_invoice_no IS NULL AND invoice_no IS NULL) AND (manual_check = @Or" & _
        "iginal_manual_check OR @Original_manual_check IS NULL AND manual_check IS NULL) " & _
        "AND (memo_check = @Original_memo_check OR @Original_memo_check IS NULL AND memo_" & _
        "check IS NULL) AND (no_of_check = @Original_no_of_check OR @Original_no_of_check" & _
        " IS NULL AND no_of_check IS NULL) AND (print_later = @Original_print_later OR @O" & _
        "riginal_print_later IS NULL AND print_later IS NULL); SELECT id_check, id_bank, " & _
        "no_of_check, date_of_check, amount_check, cod_vendor, employee_code, address_pay" & _
        "ee, memo_check, invoice_no, manual_check, print_later, cleared_bank, check_statu" & _
        "s, id_debit_deposit_head, id_GL_journal FROM bank_check WHERE (id_check = @id_ch" & _
        "eck)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@no_of_check", System.Data.SqlDbType.VarChar, 20, "no_of_check"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_of_check", System.Data.SqlDbType.VarChar, 10, "date_of_check"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_check", System.Data.SqlDbType.Money, 8, "amount_check"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address_payee", System.Data.SqlDbType.VarChar, 150, "address_payee"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo_check", System.Data.SqlDbType.VarChar, 200, "memo_check"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@invoice_no", System.Data.SqlDbType.VarChar, 20, "invoice_no"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@manual_check", System.Data.SqlDbType.Bit, 1, "manual_check"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@print_later", System.Data.SqlDbType.Bit, 1, "print_later"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cleared_bank", System.Data.SqlDbType.Bit, 1, "cleared_bank"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@check_status", System.Data.SqlDbType.VarChar, 1, "check_status"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "id_debit_deposit_head"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_check", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address_payee", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address_payee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_check", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_check_status", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "check_status", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cleared_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cleared_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_of_check", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_of_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_debit_deposit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_invoice_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "invoice_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_manual_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "manual_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo_check", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_no_of_check", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "no_of_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_print_later", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "print_later", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtnet)
        Me.GroupBox1.Controls.Add(Me.TxtExpense)
        Me.GroupBox1.Controls.Add(Me.TxtIncome)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 392)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(686, 48)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'txtnet
        '
        Me.txtnet.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.txtnet.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.txtnet.Location = New System.Drawing.Point(568, 18)
        Me.txtnet.Name = "txtnet"
        Me.txtnet.Size = New System.Drawing.Size(75, 20)
        Me.txtnet.TabIndex = 2
        Me.txtnet.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtExpense
        '
        Me.TxtExpense.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtExpense.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtExpense.Location = New System.Drawing.Point(304, 18)
        Me.TxtExpense.Name = "TxtExpense"
        Me.TxtExpense.Size = New System.Drawing.Size(75, 20)
        Me.TxtExpense.TabIndex = 1
        Me.TxtExpense.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtIncome
        '
        Me.TxtIncome.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtIncome.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtIncome.Location = New System.Drawing.Point(104, 18)
        Me.TxtIncome.Name = "TxtIncome"
        Me.TxtIncome.Size = New System.Drawing.Size(75, 20)
        Me.TxtIncome.TabIndex = 0
        Me.TxtIncome.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(432, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "NET Income (Loss)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(200, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Expenses"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Income"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GridEX1
        '
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.DataMember = "Income"
        Me.GridEX1.DataSource = Me.DsFrmPrintJournal1
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""GL_account"">" & _
        "<Caption>GL Account No</Caption><DataMember>GL_account</DataMember><EditType>NoE" & _
        "dit</EditType><Key>GL_account</Key><Position>0</Position><Width>106</Width></Col" & _
        "umn0><Column1 ID=""desc_GL_account""><Caption>Acount Name</Caption><DataMember>des" & _
        "c_GL_account</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Fil" & _
        "terEditType><Key>desc_GL_account</Key><Position>1</Position><Width>120</Width></" & _
        "Column1><Column2 ID=""amount""><AggregateFunction>Sum</AggregateFunction><Caption>" & _
        "Amount</Caption><DataMember>amount</DataMember><EditType>NoEdit</EditType><Filte" & _
        "rEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>amount</Ke" & _
        "y><Position>2</Position><TextAlignment>Far</TextAlignment><TotalFormatString>c2<" & _
        "/TotalFormatString></Column2><Column3 ID=""desc_group_account""><Caption>Gl Acount" & _
        " Group</Caption><DataMember>desc_group_account</DataMember><EditType>NoEdit</Edi" & _
        "tType><FilterEditType>TextBox</FilterEditType><Key>desc_group_account</Key><Posi" & _
        "tion>3</Position></Column3><Column4 ID=""Gl_account_group_subgroup1_desc""><Captio" & _
        "n>Gl Acount SubGroup1</Caption><DataMember>Gl_account_group_subgroup1_desc</Data" & _
        "Member><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>G" & _
        "l_account_group_subgroup1_desc</Key><Position>4</Position><Width>126</Width></Co" & _
        "lumn4><Column5 ID=""GL_journal_date""><Caption>Date</Caption><DataMember>GL_journa" & _
        "l_date</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEdi" & _
        "tType><Key>GL_journal_date</Key><Position>5</Position><Width>85</Width></Column5" & _
        "><Column6 ID=""GL_journal_reference""><Caption>Reference</Caption><DataMember>GL_j" & _
        "ournal_reference</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox<" & _
        "/FilterEditType><Key>GL_journal_reference</Key><Position>6</Position></Column6><" & _
        "Column7 ID=""GL_journal_type_desc""><Caption>Journal Type</Caption><DataMember>GL_" & _
        "journal_type_desc</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox" & _
        "</FilterEditType><Key>GL_journal_type_desc</Key><Position>7</Position></Column7>" & _
        "<Column8 ID=""id_GL_journal""><Caption>Journal No</Caption><DataMember>id_GL_journ" & _
        "al</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTyp" & _
        "e><Key>id_GL_journal</Key><Position>8</Position></Column8></Columns><GroupCondit" & _
        "ion ID="""" /><Groups Collection=""true""><Group0 ID=""Group0""><ColIndex>0</ColIndex>" & _
        "</Group0></Groups></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout2
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GridEX1.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GridEX1.Location = New System.Drawing.Point(-1, 64)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(688, 376)
        Me.GridEX1.TabIndex = 18
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT GL_journal_head.GL_journal_date, GL_journal_dtl.GL_account, GL_account.des" & _
        "c_GL_account, GL_journal_dtl.GL_journal_amount_debit, GL_journal_dtl.GL_journal_" & _
        "amount_credit, GL_journal_dtl.GL_journal_reference, GL_type_journal.GL_journal_t" & _
        "ype_desc, GL_type_journal.GL_journal_type_code, GL_account_group.desc_group_acco" & _
        "unt, GL_account_group_subgroup1.Gl_account_group_subgroup1_desc, GL_account_grou" & _
        "p_subgroup2.Gl_account_group_subgroup2_desc FROM GL_journal_head INNER JOIN GL_j" & _
        "ournal_dtl ON GL_journal_head.id_GL_journal = GL_journal_dtl.id_GL_journal INNER" & _
        " JOIN GL_account ON GL_journal_dtl.GL_account = GL_account.GL_account INNER JOIN" & _
        " GL_type_journal ON GL_journal_head.GL_journal_type_code = GL_type_journal.GL_jo" & _
        "urnal_type_code INNER JOIN GL_account_group ON GL_account.group_GL_account = GL_" & _
        "account_group.group_GL_account INNER JOIN GL_account_group_subgroup1 ON GL_accou" & _
        "nt.Gl_account_group_subgroup1_code = GL_account_group_subgroup1.Gl_account_group" & _
        "_subgroup1_code INNER JOIN GL_account_group_subgroup2 ON GL_account.Gl_account_g" & _
        "roup_subgroup2_code = GL_account_group_subgroup2.Gl_account_group_subgroup2_code" & _
        ""
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO bas_banks(name_bank, share_all_store, store_no, account_no, address, " & _
        "zip, phone_1, extension_1, phone_type_1, phone_main_1, phone_2, extension_2, pho" & _
        "ne_type_2, phone_main_2, phone_3, extension_3, phone_type_3, phone_main_3, phone" & _
        "_4, extension_4, phone_type_4, phone_main_4, phone_5, extension_5, phone_type_5," & _
        " phone_main_5, email, contact_name, GL_Account, start_check_no, next_check_no, d" & _
        "efault_bank, inactive, cod_account_type, routing_numbers, Bank_ID, Web_Page, Use" & _
        "r_ID, Password, Security_code, online_banking, WWW) VALUES (@name_bank, @share_a" & _
        "ll_store, @store_no, @account_no, @address, @zip, @phone_1, @extension_1, @phone" & _
        "_type_1, @phone_main_1, @phone_2, @extension_2, @phone_type_2, @phone_main_2, @p" & _
        "hone_3, @extension_3, @phone_type_3, @phone_main_3, @phone_4, @extension_4, @pho" & _
        "ne_type_4, @phone_main_4, @phone_5, @extension_5, @phone_type_5, @phone_main_5, " & _
        "@email, @contact_name, @GL_Account, @start_check_no, @next_check_no, @default_ba" & _
        "nk, @inactive, @cod_account_type, @routing_numbers, @Bank_ID, @Web_Page, @User_I" & _
        "D, @Password, @Security_code, @online_banking, @WWW); SELECT id_bank, name_bank," & _
        " share_all_store, store_no, account_no, address, zip, phone_1, extension_1, phon" & _
        "e_type_1, phone_main_1, phone_2, extension_2, phone_type_2, phone_main_2, phone_" & _
        "3, extension_3, phone_type_3, phone_main_3, phone_4, extension_4, phone_type_4, " & _
        "phone_main_4, phone_5, extension_5, phone_type_5, phone_main_5, email, contact_n" & _
        "ame, GL_Account, start_check_no, next_check_no, default_bank, inactive, cod_acco" & _
        "unt_type, routing_numbers, Bank_ID, Web_Page, User_ID, Password, Security_code, " & _
        "online_banking, WWW FROM bas_banks WHERE (id_bank = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@name_bank", System.Data.SqlDbType.VarChar, 50, "name_bank"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@share_all_store", System.Data.SqlDbType.Bit, 1, "share_all_store"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@store_no", System.Data.SqlDbType.VarChar, 2, "store_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@account_no", System.Data.SqlDbType.VarChar, 25, "account_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 5, "zip"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 4, "extension_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 4, "extension_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 4, "extension_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 4, "extension_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 4, "extension_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 100, "email"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contact_name", System.Data.SqlDbType.VarChar, 50, "contact_name"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_Account", System.Data.SqlDbType.VarChar, 10, "GL_Account"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@start_check_no", System.Data.SqlDbType.VarChar, 20, "start_check_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@next_check_no", System.Data.SqlDbType.VarChar, 20, "next_check_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@default_bank", System.Data.SqlDbType.Bit, 1, "default_bank"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_account_type", System.Data.SqlDbType.VarChar, 1, "cod_account_type"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@routing_numbers", System.Data.SqlDbType.VarChar, 25, "routing_numbers"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Bank_ID", System.Data.SqlDbType.VarChar, 25, "Bank_ID"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Web_Page", System.Data.SqlDbType.VarChar, 100, "Web_Page"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@User_ID", System.Data.SqlDbType.VarChar, 25, "User_ID"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Password", System.Data.SqlDbType.VarChar, 25, "Password"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Security_code", System.Data.SqlDbType.VarChar, 25, "Security_code"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@online_banking", System.Data.SqlDbType.Bit, 1, "online_banking"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@WWW", System.Data.SqlDbType.VarChar, 50, "WWW"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE bas_banks SET name_bank = @name_bank, share_all_store = @share_all_store, " & _
        "store_no = @store_no, account_no = @account_no, address = @address, zip = @zip, " & _
        "phone_1 = @phone_1, extension_1 = @extension_1, phone_type_1 = @phone_type_1, ph" & _
        "one_main_1 = @phone_main_1, phone_2 = @phone_2, extension_2 = @extension_2, phon" & _
        "e_type_2 = @phone_type_2, phone_main_2 = @phone_main_2, phone_3 = @phone_3, exte" & _
        "nsion_3 = @extension_3, phone_type_3 = @phone_type_3, phone_main_3 = @phone_main" & _
        "_3, phone_4 = @phone_4, extension_4 = @extension_4, phone_type_4 = @phone_type_4" & _
        ", phone_main_4 = @phone_main_4, phone_5 = @phone_5, extension_5 = @extension_5, " & _
        "phone_type_5 = @phone_type_5, phone_main_5 = @phone_main_5, email = @email, cont" & _
        "act_name = @contact_name, GL_Account = @GL_Account, start_check_no = @start_chec" & _
        "k_no, next_check_no = @next_check_no, default_bank = @default_bank, inactive = @" & _
        "inactive, cod_account_type = @cod_account_type, routing_numbers = @routing_numbe" & _
        "rs, Bank_ID = @Bank_ID, Web_Page = @Web_Page, User_ID = @User_ID, Password = @Pa" & _
        "ssword, Security_code = @Security_code, online_banking = @online_banking, WWW = " & _
        "@WWW WHERE (id_bank = @Original_id_bank) AND (Bank_ID = @Original_Bank_ID OR @Or" & _
        "iginal_Bank_ID IS NULL AND Bank_ID IS NULL) AND (GL_Account = @Original_GL_Accou" & _
        "nt OR @Original_GL_Account IS NULL AND GL_Account IS NULL) AND (Password = @Orig" & _
        "inal_Password OR @Original_Password IS NULL AND Password IS NULL) AND (Security_" & _
        "code = @Original_Security_code OR @Original_Security_code IS NULL AND Security_c" & _
        "ode IS NULL) AND (User_ID = @Original_User_ID OR @Original_User_ID IS NULL AND U" & _
        "ser_ID IS NULL) AND (WWW = @Original_WWW OR @Original_WWW IS NULL AND WWW IS NUL" & _
        "L) AND (Web_Page = @Original_Web_Page OR @Original_Web_Page IS NULL AND Web_Page" & _
        " IS NULL) AND (account_no = @Original_account_no OR @Original_account_no IS NULL" & _
        " AND account_no IS NULL) AND (address = @Original_address OR @Original_address I" & _
        "S NULL AND address IS NULL) AND (cod_account_type = @Original_cod_account_type O" & _
        "R @Original_cod_account_type IS NULL AND cod_account_type IS NULL) AND (contact_" & _
        "name = @Original_contact_name OR @Original_contact_name IS NULL AND contact_name" & _
        " IS NULL) AND (default_bank = @Original_default_bank OR @Original_default_bank I" & _
        "S NULL AND default_bank IS NULL) AND (email = @Original_email OR @Original_email" & _
        " IS NULL AND email IS NULL) AND (extension_1 = @Original_extension_1 OR @Origina" & _
        "l_extension_1 IS NULL AND extension_1 IS NULL) AND (extension_2 = @Original_exte" & _
        "nsion_2 OR @Original_extension_2 IS NULL AND extension_2 IS NULL) AND (extension" & _
        "_3 = @Original_extension_3 OR @Original_extension_3 IS NULL AND extension_3 IS N" & _
        "ULL) AND (extension_4 = @Original_extension_4 OR @Original_extension_4 IS NULL A" & _
        "ND extension_4 IS NULL) AND (extension_5 = @Original_extension_5 OR @Original_ex" & _
        "tension_5 IS NULL AND extension_5 IS NULL) AND (inactive = @Original_inactive OR" & _
        " @Original_inactive IS NULL AND inactive IS NULL) AND (name_bank = @Original_nam" & _
        "e_bank OR @Original_name_bank IS NULL AND name_bank IS NULL) AND (next_check_no " & _
        "= @Original_next_check_no OR @Original_next_check_no IS NULL AND next_check_no I" & _
        "S NULL) AND (online_banking = @Original_online_banking OR @Original_online_banki" & _
        "ng IS NULL AND online_banking IS NULL) AND (phone_1 = @Original_phone_1 OR @Orig" & _
        "inal_phone_1 IS NULL AND phone_1 IS NULL) AND (phone_2 = @Original_phone_2 OR @O" & _
        "riginal_phone_2 IS NULL AND phone_2 IS NULL) AND (phone_3 = @Original_phone_3 OR" & _
        " @Original_phone_3 IS NULL AND phone_3 IS NULL) AND (phone_4 = @Original_phone_4" & _
        " OR @Original_phone_4 IS NULL AND phone_4 IS NULL) AND (phone_5 = @Original_phon" & _
        "e_5 OR @Original_phone_5 IS NULL AND phone_5 IS NULL) AND (phone_main_1 = @Origi" & _
        "nal_phone_main_1 OR @Original_phone_main_1 IS NULL AND phone_main_1 IS NULL) AND" & _
        " (phone_main_2 = @Original_phone_main_2 OR @Original_phone_main_2 IS NULL AND ph" & _
        "one_main_2 IS NULL) AND (phone_main_3 = @Original_phone_main_3 OR @Original_phon" & _
        "e_main_3 IS NULL AND phone_main_3 IS NULL) AND (phone_main_4 = @Original_phone_m" & _
        "ain_4 OR @Original_phone_main_4 IS NULL AND phone_main_4 IS NULL) AND (phone_mai" & _
        "n_5 = @Original_phone_main_5 OR @Original_phone_main_5 IS NULL AND phone_main_5 " & _
        "IS NULL) AND (phone_type_1 = @Original_phone_type_1 OR @Original_phone_type_1 IS" & _
        " NULL AND phone_type_1 IS NULL) AND (phone_type_2 = @Original_phone_type_2 OR @O" & _
        "riginal_phone_type_2 IS NULL AND phone_type_2 IS NULL) AND (phone_type_3 = @Orig" & _
        "inal_phone_type_3 OR @Original_phone_type_3 IS NULL AND phone_type_3 IS NULL) AN" & _
        "D (phone_type_4 = @Original_phone_type_4 OR @Original_phone_type_4 IS NULL AND p" & _
        "hone_type_4 IS NULL) AND (phone_type_5 = @Original_phone_type_5 OR @Original_pho" & _
        "ne_type_5 IS NULL AND phone_type_5 IS NULL) AND (routing_numbers = @Original_rou" & _
        "ting_numbers OR @Original_routing_numbers IS NULL AND routing_numbers IS NULL) A" & _
        "ND (share_all_store = @Original_share_all_store OR @Original_share_all_store IS " & _
        "NULL AND share_all_store IS NULL) AND (start_check_no = @Original_start_check_no" & _
        " OR @Original_start_check_no IS NULL AND start_check_no IS NULL) AND (store_no =" & _
        " @Original_store_no OR @Original_store_no IS NULL AND store_no IS NULL) AND (zip" & _
        " = @Original_zip OR @Original_zip IS NULL AND zip IS NULL); SELECT id_bank, name" & _
        "_bank, share_all_store, store_no, account_no, address, zip, phone_1, extension_1" & _
        ", phone_type_1, phone_main_1, phone_2, extension_2, phone_type_2, phone_main_2, " & _
        "phone_3, extension_3, phone_type_3, phone_main_3, phone_4, extension_4, phone_ty" & _
        "pe_4, phone_main_4, phone_5, extension_5, phone_type_5, phone_main_5, email, con" & _
        "tact_name, GL_Account, start_check_no, next_check_no, default_bank, inactive, co" & _
        "d_account_type, routing_numbers, Bank_ID, Web_Page, User_ID, Password, Security_" & _
        "code, online_banking, WWW FROM bas_banks WHERE (id_bank = @id_bank)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@name_bank", System.Data.SqlDbType.VarChar, 50, "name_bank"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@share_all_store", System.Data.SqlDbType.Bit, 1, "share_all_store"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@store_no", System.Data.SqlDbType.VarChar, 2, "store_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@account_no", System.Data.SqlDbType.VarChar, 25, "account_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 5, "zip"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 4, "extension_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 4, "extension_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 4, "extension_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 4, "extension_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 4, "extension_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 100, "email"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contact_name", System.Data.SqlDbType.VarChar, 50, "contact_name"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_Account", System.Data.SqlDbType.VarChar, 10, "GL_Account"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@start_check_no", System.Data.SqlDbType.VarChar, 20, "start_check_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@next_check_no", System.Data.SqlDbType.VarChar, 20, "next_check_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@default_bank", System.Data.SqlDbType.Bit, 1, "default_bank"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_account_type", System.Data.SqlDbType.VarChar, 1, "cod_account_type"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@routing_numbers", System.Data.SqlDbType.VarChar, 25, "routing_numbers"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Bank_ID", System.Data.SqlDbType.VarChar, 25, "Bank_ID"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Web_Page", System.Data.SqlDbType.VarChar, 100, "Web_Page"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@User_ID", System.Data.SqlDbType.VarChar, 25, "User_ID"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Password", System.Data.SqlDbType.VarChar, 25, "Password"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Security_code", System.Data.SqlDbType.VarChar, 25, "Security_code"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@online_banking", System.Data.SqlDbType.Bit, 1, "online_banking"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@WWW", System.Data.SqlDbType.VarChar, 50, "WWW"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Bank_ID", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Bank_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_Account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_Account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Password", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Password", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Security_code", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Security_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_User_ID", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "User_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_WWW", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WWW", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Web_Page", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Web_Page", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_account_no", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "account_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_account_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_account_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_contact_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "contact_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_default_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "default_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_name_bank", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "name_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_next_check_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "next_check_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_online_banking", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "online_banking", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_routing_numbers", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "routing_numbers", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_share_all_store", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "share_all_store", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_start_check_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "start_check_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_store_no", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "store_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zip", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zip", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM bas_banks WHERE (id_bank = @Original_id_bank) AND (Bank_ID = @Origina" & _
        "l_Bank_ID OR @Original_Bank_ID IS NULL AND Bank_ID IS NULL) AND (GL_Account = @O" & _
        "riginal_GL_Account OR @Original_GL_Account IS NULL AND GL_Account IS NULL) AND (" & _
        "Password = @Original_Password OR @Original_Password IS NULL AND Password IS NULL" & _
        ") AND (Security_code = @Original_Security_code OR @Original_Security_code IS NUL" & _
        "L AND Security_code IS NULL) AND (User_ID = @Original_User_ID OR @Original_User_" & _
        "ID IS NULL AND User_ID IS NULL) AND (WWW = @Original_WWW OR @Original_WWW IS NUL" & _
        "L AND WWW IS NULL) AND (Web_Page = @Original_Web_Page OR @Original_Web_Page IS N" & _
        "ULL AND Web_Page IS NULL) AND (account_no = @Original_account_no OR @Original_ac" & _
        "count_no IS NULL AND account_no IS NULL) AND (address = @Original_address OR @Or" & _
        "iginal_address IS NULL AND address IS NULL) AND (cod_account_type = @Original_co" & _
        "d_account_type OR @Original_cod_account_type IS NULL AND cod_account_type IS NUL" & _
        "L) AND (contact_name = @Original_contact_name OR @Original_contact_name IS NULL " & _
        "AND contact_name IS NULL) AND (default_bank = @Original_default_bank OR @Origina" & _
        "l_default_bank IS NULL AND default_bank IS NULL) AND (email = @Original_email OR" & _
        " @Original_email IS NULL AND email IS NULL) AND (extension_1 = @Original_extensi" & _
        "on_1 OR @Original_extension_1 IS NULL AND extension_1 IS NULL) AND (extension_2 " & _
        "= @Original_extension_2 OR @Original_extension_2 IS NULL AND extension_2 IS NULL" & _
        ") AND (extension_3 = @Original_extension_3 OR @Original_extension_3 IS NULL AND " & _
        "extension_3 IS NULL) AND (extension_4 = @Original_extension_4 OR @Original_exten" & _
        "sion_4 IS NULL AND extension_4 IS NULL) AND (extension_5 = @Original_extension_5" & _
        " OR @Original_extension_5 IS NULL AND extension_5 IS NULL) AND (inactive = @Orig" & _
        "inal_inactive OR @Original_inactive IS NULL AND inactive IS NULL) AND (name_bank" & _
        " = @Original_name_bank OR @Original_name_bank IS NULL AND name_bank IS NULL) AND" & _
        " (next_check_no = @Original_next_check_no OR @Original_next_check_no IS NULL AND" & _
        " next_check_no IS NULL) AND (online_banking = @Original_online_banking OR @Origi" & _
        "nal_online_banking IS NULL AND online_banking IS NULL) AND (phone_1 = @Original_" & _
        "phone_1 OR @Original_phone_1 IS NULL AND phone_1 IS NULL) AND (phone_2 = @Origin" & _
        "al_phone_2 OR @Original_phone_2 IS NULL AND phone_2 IS NULL) AND (phone_3 = @Ori" & _
        "ginal_phone_3 OR @Original_phone_3 IS NULL AND phone_3 IS NULL) AND (phone_4 = @" & _
        "Original_phone_4 OR @Original_phone_4 IS NULL AND phone_4 IS NULL) AND (phone_5 " & _
        "= @Original_phone_5 OR @Original_phone_5 IS NULL AND phone_5 IS NULL) AND (phone" & _
        "_main_1 = @Original_phone_main_1 OR @Original_phone_main_1 IS NULL AND phone_mai" & _
        "n_1 IS NULL) AND (phone_main_2 = @Original_phone_main_2 OR @Original_phone_main_" & _
        "2 IS NULL AND phone_main_2 IS NULL) AND (phone_main_3 = @Original_phone_main_3 O" & _
        "R @Original_phone_main_3 IS NULL AND phone_main_3 IS NULL) AND (phone_main_4 = @" & _
        "Original_phone_main_4 OR @Original_phone_main_4 IS NULL AND phone_main_4 IS NULL" & _
        ") AND (phone_main_5 = @Original_phone_main_5 OR @Original_phone_main_5 IS NULL A" & _
        "ND phone_main_5 IS NULL) AND (phone_type_1 = @Original_phone_type_1 OR @Original" & _
        "_phone_type_1 IS NULL AND phone_type_1 IS NULL) AND (phone_type_2 = @Original_ph" & _
        "one_type_2 OR @Original_phone_type_2 IS NULL AND phone_type_2 IS NULL) AND (phon" & _
        "e_type_3 = @Original_phone_type_3 OR @Original_phone_type_3 IS NULL AND phone_ty" & _
        "pe_3 IS NULL) AND (phone_type_4 = @Original_phone_type_4 OR @Original_phone_type" & _
        "_4 IS NULL AND phone_type_4 IS NULL) AND (phone_type_5 = @Original_phone_type_5 " & _
        "OR @Original_phone_type_5 IS NULL AND phone_type_5 IS NULL) AND (routing_numbers" & _
        " = @Original_routing_numbers OR @Original_routing_numbers IS NULL AND routing_nu" & _
        "mbers IS NULL) AND (share_all_store = @Original_share_all_store OR @Original_sha" & _
        "re_all_store IS NULL AND share_all_store IS NULL) AND (start_check_no = @Origina" & _
        "l_start_check_no OR @Original_start_check_no IS NULL AND start_check_no IS NULL)" & _
        " AND (store_no = @Original_store_no OR @Original_store_no IS NULL AND store_no I" & _
        "S NULL) AND (zip = @Original_zip OR @Original_zip IS NULL AND zip IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Bank_ID", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Bank_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_Account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_Account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Password", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Password", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Security_code", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Security_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_User_ID", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "User_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_WWW", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WWW", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Web_Page", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Web_Page", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_account_no", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "account_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_account_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_account_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_contact_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "contact_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_default_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "default_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_name_bank", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "name_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_next_check_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "next_check_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_online_banking", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "online_banking", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_routing_numbers", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "routing_numbers", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_share_all_store", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "share_all_store", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_start_check_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "start_check_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_store_no", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "store_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zip", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_banks", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("name_bank", "name_bank"), New System.Data.Common.DataColumnMapping("share_all_store", "share_all_store"), New System.Data.Common.DataColumnMapping("store_no", "store_no"), New System.Data.Common.DataColumnMapping("account_no", "account_no"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("contact_name", "contact_name"), New System.Data.Common.DataColumnMapping("GL_Account", "GL_Account"), New System.Data.Common.DataColumnMapping("start_check_no", "start_check_no"), New System.Data.Common.DataColumnMapping("next_check_no", "next_check_no"), New System.Data.Common.DataColumnMapping("default_bank", "default_bank"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("cod_account_type", "cod_account_type"), New System.Data.Common.DataColumnMapping("routing_numbers", "routing_numbers"), New System.Data.Common.DataColumnMapping("Bank_ID", "Bank_ID"), New System.Data.Common.DataColumnMapping("Web_Page", "Web_Page"), New System.Data.Common.DataColumnMapping("User_ID", "User_ID"), New System.Data.Common.DataColumnMapping("Password", "Password"), New System.Data.Common.DataColumnMapping("Security_code", "Security_code"), New System.Data.Common.DataColumnMapping("online_banking", "online_banking"), New System.Data.Common.DataColumnMapping("WWW", "WWW")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand2
        '
        'FrmPrintJournal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(686, 436)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.GrdIncome)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.MaximizeBox = True
        Me.Name = "FrmPrintJournal"
        Me.Panel4.ResumeLayout(False)
        CType(Me.GrdIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmPrintJournal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Enum KindReport As Integer
        Income = 1
        GLHistory = 2
        BalanceSHeet = 3
        CashFlowStatemwnt = 4
        GLHistorySummery = 5
    End Enum
    Public KindOfReport As KindReport
    Public StrWhere As String
    Public StrFilter As String

    Public Date1 As String
    Public Date2 As String
    Private Sub FrmPrintJournal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString

        Select Case KindOfReport
            Case KindReport.Income
                Call FillIncome()
            Case KindReport.GLHistory
                Call FillHistory()

        End Select
        If Date1.Trim.Length > 0 Then
            GridEXPrintDocument1.PageHeaderCenter = " From: " & Date1 & "  To: " & Date2 & vbNewLine & Me.Text()
        Else
            GridEXPrintDocument1.PageHeaderCenter = Me.Text
        End If
        GridEXPrintDocument1.PageHeaderRight = "Date : " & Format(Now(), "MM/dd/yyyy")
    End Sub
    Private Sub FillIncome()

        DsFrmPrintJournal1.Income.Clear()
        DAGeneral.SelectCommand.CommandText = "  SELECT     GL_journal_head.GL_journal_date, GL_journal_dtl.GL_account, GL_account.desc_GL_account, GL_journal_dtl.GL_journal_amount_debit,  " & _
"                      GL_journal_dtl.GL_journal_amount_credit, GL_journal_dtl.GL_journal_reference, GL_type_journal.GL_journal_type_desc,  " & _
"                       GL_type_journal.GL_journal_type_code, GL_account_group.desc_group_account, GL_account_group_subgroup1.Gl_account_group_subgroup1_desc,  " & _
"                       GL_account_group_subgroup2.Gl_account_group_subgroup2_desc " & _
" FROM         GL_journal_head INNER JOIN " & _
"                       GL_journal_dtl ON GL_journal_head.id_GL_journal = GL_journal_dtl.id_GL_journal INNER JOIN " & _
"                       GL_account ON GL_journal_dtl.GL_account = GL_account.GL_account INNER JOIN " & _
"                       GL_type_journal ON GL_journal_head.GL_journal_type_code = GL_type_journal.GL_journal_type_code INNER JOIN " & _
"                       GL_account_group ON GL_account.group_GL_account = GL_account_group.group_GL_account INNER JOIN " & _
"                       GL_account_group_subgroup1 ON  " & _
"                       GL_account.Gl_account_group_subgroup1_code = GL_account_group_subgroup1.Gl_account_group_subgroup1_code INNER JOIN " & _
"                       GL_account_group_subgroup2 ON  " & _
"                       GL_account.Gl_account_group_subgroup2_code = GL_account_group_subgroup2.Gl_account_group_subgroup2_code "

        DAGeneral.Fill(DsFrmPrintJournal1.Income)
        Dim Income As Decimal = 0
        Dim Expence As Decimal = 0
        Dim Net As Decimal = 0
        For i As Integer = 0 To DsFrmPrintJournal1.Income.Count - 1
            If DsFrmPrintJournal1.Income(i).group_GL_account.Trim = "04" Then
                Income = DsFrmPrintJournal1.Income(i).amount + Income
            Else
                Expence = DsFrmPrintJournal1.Income(i).amount + Expence
            End If
        Next

        Net = Income - Expence

        TxtExpense.Text = Expence
        TxtIncome.Text = Income
        txtnet.Text = Net
        Label4.Text = "Total Assets"
        Label5.Text = "Total Liabilities"
        Label6.Text = "Total "
        GrdIncome.BringToFront()

        GroupBox1.BringToFront()
    End Sub
    Private Sub FillHistory()

        DsFrmPrintJournal1.Income.Clear()
        DAGeneral.SelectCommand.CommandText = " SELECT     GL_account.GL_account, GL_account.desc_GL_account, SUM(ROUND(ISNULL(GL_journal_dtl.GL_journal_amount_debit, 0), 2)  " & _
        "                       - ROUND(ISNULL(GL_journal_dtl.GL_journal_amount_credit, 0), 2)) AS amount, GL_account_group.desc_group_account,  " & _
        "                       GL_account_group_subgroup1.Gl_account_group_subgroup1_desc, GL_journal_head.GL_journal_date, GL_journal_head.GL_journal_reference,  " & _
        "                       GL_type_journal.GL_journal_type_desc, GL_journal_head.id_GL_journal,1 as flag,GL_account_group.group_GL_account,0 as NetIncome " & _
        " FROM         GL_account INNER JOIN " & _
        "                       GL_account_group ON GL_account.group_GL_account = GL_account_group.group_GL_account INNER JOIN " & _
        "                       GL_journal_head INNER JOIN " & _
        "                       GL_journal_dtl ON GL_journal_head.id_GL_journal = GL_journal_dtl.id_GL_journal ON  " & _
        "                       GL_account.GL_account = GL_journal_dtl.GL_account INNER JOIN " & _
        "                       GL_type_journal ON GL_journal_head.GL_journal_type_code = GL_type_journal.GL_journal_type_code LEFT OUTER JOIN " & _
        "                       GL_account_group_subgroup1 ON  " & _
        "                       GL_account.Gl_account_group_subgroup1_code = GL_account_group_subgroup1.Gl_account_group_subgroup1_code " & _
        " WHERE     (GL_account_group.group_GL_account IN ('04', '05')) " & _
        " GROUP BY GL_account.GL_account, GL_account_group.group_GL_account, GL_account.desc_GL_account, GL_account_group.desc_group_account,  " & _
        "                       GL_account_group_subgroup1.Gl_account_group_subgroup1_desc, GL_journal_head.GL_journal_date, GL_journal_head.GL_journal_reference,  " & _
        "                       GL_type_journal.GL_journal_type_desc, GL_journal_head.id_GL_journal " & _
        " ORDER BY GL_account_group.group_GL_account "

        DAGeneral.Fill(DsFrmPrintJournal1.Income)
        Dim Income As Decimal = 0
        Dim Expence As Decimal = 0
        Dim Net As Decimal = 0
        For i As Integer = 0 To DsFrmPrintJournal1.Income.Count - 1
            If DsFrmPrintJournal1.Income(i).group_GL_account.Trim = "04" Then
                Income = DsFrmPrintJournal1.Income(i).amount + Income
            Else
                Expence = DsFrmPrintJournal1.Income(i).amount + Expence
            End If
        Next

        Net = Income - Expence

        TxtExpense.Text = Expence
        TxtIncome.Text = Income
        txtnet.Text = Net
        Label4.Text = "Total Assets"
        Label5.Text = "Total Liabilities"
        Label6.Text = "Total "
        GrdIncome.BringToFront()

        GroupBox1.BringToFront()

    End Sub
    Private Sub FillBalanceSheet()

        DsFrmPrintJournal1.Income.Clear()
        DAGeneral.SelectCommand.CommandText = " SELECT     GL_account.GL_account, GL_account.desc_GL_account, SUM(ROUND(ISNULL(GL_journal_dtl.GL_journal_amount_debit, 0), 2)  " & _
        "                       - ROUND(ISNULL(GL_journal_dtl.GL_journal_amount_credit, 0), 2)) AS amount, GL_account_group.desc_group_account,  " & _
        "                       GL_account_group_subgroup1.Gl_account_group_subgroup1_desc, GL_journal_head.GL_journal_date, GL_journal_head.GL_journal_reference,  " & _
        "                       GL_type_journal.GL_journal_type_desc, GL_journal_head.id_GL_journal,1 as flag,GL_account_group.group_GL_account,0 as NetIncome " & _
        " FROM         GL_account INNER JOIN " & _
        "                       GL_account_group ON GL_account.group_GL_account = GL_account_group.group_GL_account INNER JOIN " & _
        "                       GL_journal_head INNER JOIN " & _
        "                       GL_journal_dtl ON GL_journal_head.id_GL_journal = GL_journal_dtl.id_GL_journal ON  " & _
        "                       GL_account.GL_account = GL_journal_dtl.GL_account INNER JOIN " & _
        "                       GL_type_journal ON GL_journal_head.GL_journal_type_code = GL_type_journal.GL_journal_type_code LEFT OUTER JOIN " & _
        "                       GL_account_group_subgroup1 ON  " & _
        "                       GL_account.Gl_account_group_subgroup1_code = GL_account_group_subgroup1.Gl_account_group_subgroup1_code " & _
        " WHERE     (GL_account_group.group_GL_account IN ('01', '02','03')) " & _
        " GROUP BY GL_account.GL_account, GL_account_group.group_GL_account, GL_account.desc_GL_account, GL_account_group.desc_group_account,  " & _
        "                       GL_account_group_subgroup1.Gl_account_group_subgroup1_desc, GL_journal_head.GL_journal_date, GL_journal_head.GL_journal_reference,  " & _
        "                       GL_type_journal.GL_journal_type_desc, GL_journal_head.id_GL_journal " & _
        " ORDER BY GL_account_group.group_GL_account "

        DAGeneral.Fill(DsFrmPrintJournal1.Income)
        Dim Asset As Decimal = 0
        Dim Liability As Decimal = 0
        Dim Equity As Decimal = 0
        For i As Integer = 0 To DsFrmPrintJournal1.Income.Count - 1
            Select Case DsFrmPrintJournal1.Income(i).group_GL_account.Trim
                Case "01"
                    Asset = DsFrmPrintJournal1.Income(i).amount + Asset
                Case "02"
                    Liability = DsFrmPrintJournal1.Income(i).amount + Liability
                Case "03"
                    Equity = DsFrmPrintJournal1.Income(i).amount + Equity
            End Select
        Next

        TxtIncome.Text = Asset
        TxtExpense.Text = Liability
        txtnet.Text = Equity
        Label4.Text = "Total Assets"
        Label5.Text = "Total Liabilities"
        Label6.Text = "Total Equities"
        GrdIncome.BringToFront()

        GroupBox1.BringToFront()
    End Sub
    Private Sub CmbChildLedger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbChildLedger.Click
        If CmbChildLedger.Text = "Expand" Then
            CmbChildLedger.Text = "Collaps"
            GrdIncome.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded
        Else
            CmbChildLedger.Text = "Expand"
            GrdIncome.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        End If
        GrdIncome.AcceptsEscape = True
        GrdIncome.Refresh()


    End Sub
    Private Sub BtnFchooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFchooser.Click
        Select Case KindOfReport
            Case KindReport.Income, KindReport.BalanceSHeet
                Me.GrdIncome.ShowFieldChooser(Me)
                'Case KindReport.DepositDetail
                '    Me.GrdDepositListDetail.ShowFieldChooser(Me)
                'Case KindReport.ATMDetail
                '    Me.GrdATMDetail.ShowFieldChooser(Me)
                'Case KindReport.Transfer
                '    Me.GrdTransfer.ShowFieldChooser(Me)

        End Select

    End Sub

    Private Sub BtnJPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJPrint.Click
        Select Case KindOfReport
            Case KindReport.Income, KindReport.BalanceSHeet
                GridEXPrintDocument1.GridEX = GrdIncome
                'Case KindReport.DepositDetail
                '    GridEXPrintDocument1.GridEX = GrdDepositListDetail
                'Case KindReport.ATMDetail
                '    GridEXPrintDocument1.GridEX = GrdATMDetail
                'Case KindReport.Transfer
                '    GridEXPrintDocument1.GridEX = GrdTransfer
        End Select
        Dim filter As GridEXFilterCondition
        Dim filter1 As GridEXFilterCondition = GridEXPrintDocument1.GridEX.RootTable.FilterCondition
        filter = New GridEXFilterCondition(GridEXPrintDocument1.GridEX.RootTable.Columns("flag"), ConditionOperator.Equal, True)
        'filter1 = GridEXPrintDocument1.GridEX.RootTable.FilterCondition
        If filter1 Is Nothing Then
            filter1 = New GridEXFilterCondition
        End If
        GridEXPrintDocument1.GridEX.RootTable.FilterCondition = Nothing
        filter1.AddCondition(LogicalOperator.And, filter)

        GridEXPrintDocument1.GridEX.RootTable.FilterCondition = filter1
        GridEXPrintDocument1.GridEX.RootTable.Columns("flag").Visible = False

        PrintPreviewDialog1.ShowDialog()
        'Grd1.RemoveFilters()
        GridEXPrintDocument1.GridEX.RootTable.FilterCondition = Nothing
        filter1.RemoveCondition(filter)
        GridEXPrintDocument1.GridEX.RootTable.FilterCondition = filter1
        GridEXPrintDocument1.GridEX.RootTable.Columns("flag").Visible = True
    End Sub

    Private Sub BtnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmail.Click

        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.Filter = "CSV files (*.csv)|*.csv"
        SaveFileDialog1.Title = "Save CSV File"
        SaveFileDialog1.DefaultExt = "csv"
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.FileName = "report"

        Dim FileName As String
        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If
        FileName = SaveFileDialog1.FileName
        If System.IO.Path.GetExtension(FileName) <> ".csv" Then
            FileName = FileName.Replace(System.IO.Path.GetExtension(FileName), ".csv")

        End If
        Select Case KindOfReport
            Case KindReport.Income, KindReport.BalanceSHeet
                Call GridToExcel2(FileName, GrdIncome)
                'Case KindReport.DepositDetail
                '    Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdDepositListDetail)
                'Case KindReport.ATMDetail
                '    Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdATMDetail)
                'Case KindReport.Transfer
                '    Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdTransfer)

        End Select

    End Sub

    Private Sub BtnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeselect.Click
        Select Case KindOfReport
            Case KindReport.Income, KindReport.BalanceSHeet
                For i As Integer = 0 To DsFrmPrintJournal1.Income.Count - 1
                    DsFrmPrintJournal1.Income(i).flag = False
                Next
                'Case KindReport.DepositDetail
                '    For i As Integer = 0 To DsFrmPrint1.DepositListDetail.Count - 1
                '        DsFrmPrint1.DepositListDetail(i).flag = False
                '    Next
                'Case KindReport.ATMDetail
                '    For i As Integer = 0 To DsFrmPrint1.ATMDetail.Count - 1
                '        DsFrmPrint1.ATMDetail(i).flag = False
                '    Next
                'Case KindReport.Transfer
                '    For i As Integer = 0 To DsFrmPrint1.Transfer.Count - 1
                '        DsFrmPrint1.Transfer(i).flag = False
                '    Next

        End Select

        BtnDeselect.SendToBack()
        Label2.Text = "Select All"
    End Sub
    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        Select Case KindOfReport
            Case KindReport.Income, KindReport.BalanceSHeet
                For i As Integer = 0 To DsFrmPrintJournal1.Income.Count - 1
                    DsFrmPrintJournal1.Income(i).flag = True
                Next
                'Case KindReport.DepositDetail
                '    For i As Integer = 0 To DsFrmPrint1.DepositListDetail.Count - 1
                '        DsFrmPrint1.DepositListDetail(i).flag = True
                '    Next
                'Case KindReport.ATMDetail
                '    For i As Integer = 0 To DsFrmPrint1.ATMDetail.Count - 1
                '        DsFrmPrint1.ATMDetail(i).flag = True
                '    Next
                'Case KindReport.Transfer
                '    For i As Integer = 0 To DsFrmPrint1.Transfer.Count - 1
                '        DsFrmPrint1.Transfer(i).flag = True
                '    Next

        End Select
        BtnSelect.SendToBack()
        Label2.Text = "Deselect All"
    End Sub




    Dim x As Integer = 0
    Private Sub GridEXPrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles GridEXPrintDocument1.PrintPage
        x = x + 1
        GridEXPrintDocument1.PageFooterRight = x
    End Sub
    Private Sub GridEXPrintDocument1_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GridEXPrintDocument1.EndPrint
        x = 0
    End Sub



    Private Sub GrdIncome_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdIncome.DoubleClick
        If GrdIncome.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GrdIncome.GetRow


            Try
                If GrdIncome.GetRow.Cells(8).Value <> 0 Then
                    Dim MyFrm As New UcAccount.FrmJournal
                    MyFrm.LoadThis = GrdIncome.GetRow.Cells(8).Value
                    MyFrm.ShowDialog()
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
