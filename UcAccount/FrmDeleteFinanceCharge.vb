Public Class FrmDeleteFinanceCharge
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaGlaccountAdjustment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmDeleteFinance1 As UcAccount.DSFrmDeleteFinance
    Friend WithEvents Grd2 As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnUnmarkAll As System.Windows.Forms.Button
    Friend WithEvents BtnMarkAll As System.Windows.Forms.Button
    Friend WithEvents CmdDel As System.Data.SqlClient.SqlCommand
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents CmbDate As System.Windows.Forms.ComboBox
    Friend WithEvents DAFinanceDate As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbDate = New System.Windows.Forms.ComboBox
        Me.DsFrmDeleteFinance1 = New UcAccount.DSFrmDeleteFinance
        Me.Label1 = New System.Windows.Forms.Label
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DaGlaccountAdjustment = New System.Data.SqlClient.SqlDataAdapter
        Me.Grd2 = New Janus.Windows.GridEX.GridEX
        Me.BtnUnmarkAll = New System.Windows.Forms.Button
        Me.BtnMarkAll = New System.Windows.Forms.Button
        Me.CmdDel = New System.Data.SqlClient.SqlCommand
        Me.btndelete = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.DAFinanceDate = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmDeleteFinance1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.CmbDate)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(694, 56)
        Me.Panel4.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(344, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "Assessment Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDate
        '
        Me.CmbDate.DataSource = Me.DsFrmDeleteFinance1.FinanceDate
        Me.CmbDate.DisplayMember = "date_adjustment"
        Me.CmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDate.Location = New System.Drawing.Point(456, 16)
        Me.CmbDate.Name = "CmbDate"
        Me.CmbDate.Size = New System.Drawing.Size(208, 21)
        Me.CmbDate.TabIndex = 204
        Me.CmbDate.ValueMember = "date_adjustment"
        '
        'DsFrmDeleteFinance1
        '
        Me.DsFrmDeleteFinance1.DataSetName = "DSFrmDeleteFinance"
        Me.DsFrmDeleteFinance1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 54)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "Select Assessment Date And Then Check Out The Records That You Want To Delete"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_account_adjustment_head.refrence_no, GL_account_adjustment_head.cod_cus" & _
        "tomer, GL_account_adjustment_head.date_adjustment, GL_account_adjustment_head.Re" & _
        "mark, GL_account_adjustment_head.GL_account, GL_account_adjustment_head.id_GL_jo" & _
        "urnal, GL_account_adjustment_head.Gl_receive_payment_Refrence_no, GL_account_adj" & _
        "ustment_head.finance_charge_flag, cust_company.complete_name, CASE cust_trtab_ma" & _
        "in.cod_customer WHEN NULL THEN RTRIM(LTRIM(cust_trtab_main.l_name)) + ' ' + RTRI" & _
        "M(LTRIM(cust_trtab_main.m_name)) + ' ' + RTRIM(LTRIM(cust_trtab_main.f_name)) EL" & _
        "SE RTRIM(LTRIM(cust_trtab_main.l_name)) + ' ' + RTRIM(LTRIM(cust_trtab_main.m_na" & _
        "me)) + ' ' + RTRIM(LTRIM(cust_trtab_main.f_name)) END AS m_name, SUM(GL_account_" & _
        "adjustment_dtl.amount_adjustment) AS amount_adjustment FROM GL_account_adjustmen" & _
        "t_head INNER JOIN cust_trtab_main ON GL_account_adjustment_head.cod_customer = c" & _
        "ust_trtab_main.cod_customer INNER JOIN GL_account_adjustment_dtl ON GL_account_a" & _
        "djustment_head.refrence_no = GL_account_adjustment_dtl.refrence_no LEFT OUTER JO" & _
        "IN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company WHERE " & _
        "(GL_account_adjustment_head.finance_charge_flag = 1) AND (GL_account_adjustment_" & _
        "head.id_GL_journal IS NULL) AND (GL_account_adjustment_head.date_adjustment = @d" & _
        "ate_adjustment) GROUP BY GL_account_adjustment_head.refrence_no, GL_account_adju" & _
        "stment_head.cod_customer, GL_account_adjustment_head.date_adjustment, GL_account" & _
        "_adjustment_head.Remark, GL_account_adjustment_head.GL_account, GL_account_adjus" & _
        "tment_head.id_GL_journal, GL_account_adjustment_head.Gl_receive_payment_Refrence" & _
        "_no, GL_account_adjustment_head.finance_charge_flag, cust_company.complete_name," & _
        " CASE cust_trtab_main.cod_customer WHEN NULL THEN RTRIM(LTRIM(cust_trtab_main.l_" & _
        "name)) + ' ' + RTRIM(LTRIM(cust_trtab_main.m_name)) + ' ' + RTRIM(LTRIM(cust_trt" & _
        "ab_main.f_name)) ELSE RTRIM(LTRIM(cust_trtab_main.l_name)) + ' ' + RTRIM(LTRIM(c" & _
        "ust_trtab_main.m_name)) + ' ' + RTRIM(LTRIM(cust_trtab_main.f_name)) END"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_adjustment", System.Data.SqlDbType.VarChar, 10, "date_adjustment"))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJI1;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_01;password=sa"
        '
        'DaGlaccountAdjustment
        '
        Me.DaGlaccountAdjustment.SelectCommand = Me.SqlSelectCommand1
        Me.DaGlaccountAdjustment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("Remark", "Remark"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Gl_receive_payment_Refrence_no", "Gl_receive_payment_Refrence_no"), New System.Data.Common.DataColumnMapping("finance_charge_flag", "finance_charge_flag")})})
        '
        'Grd2
        '
        Me.Grd2.AlternatingColors = True
        Me.Grd2.DataMember = "GL_account_adjustment_head"
        Me.Grd2.DataSource = Me.DsFrmDeleteFinance1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_account_adjustment_head</Caption><Column" & _
        "s Collection=""true""><Column0 ID=""finance_charge_flag""><ColumnType>CheckBox</Colu" & _
        "mnType><DataMember>finance_charge_flag</DataMember><EditType>CheckBox</EditType>" & _
        "<Key>finance_charge_flag</Key><Position>0</Position><Width>28</Width></Column0><" & _
        "Column1 ID=""refrence_no""><Caption>Reference</Caption><TypeNameEmptyStringValue>S" & _
        "ystem.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>refrence_" & _
        "no</DataMember><EditType>NoEdit</EditType><Key>refrence_no</Key><Position>1</Pos" & _
        "ition><Width>92</Width></Column1><Column2 ID=""date_adjustment""><Caption>Adjustme" & _
        "nt Date</Caption><DataMember>date_adjustment</DataMember><EditType>NoEdit</EditT" & _
        "ype><Key>date_adjustment</Key><Position>2</Position></Column2><Column3 ID=""m_nam" & _
        "e""><Caption>Customer Name</Caption><DataMember>m_name</DataMember><EditType>NoEd" & _
        "it</EditType><Key>m_name</Key><Position>3</Position><Width>128</Width></Column3>" & _
        "<Column4 ID=""complete_name""><Caption>Company</Caption><DataMember>complete_name<" & _
        "/DataMember><EditType>NoEdit</EditType><Key>complete_name</Key><Position>4</Posi" & _
        "tion><Width>184</Width></Column4><Column5 ID=""amount_adjustment""><Caption>Amount" & _
        "</Caption><DataMember>amount_adjustment</DataMember><EditType>NoEdit</EditType><" & _
        "FormatString>c</FormatString><Key>amount_adjustment</Key><Position>5</Position><" & _
        "TextAlignment>Far</TextAlignment></Column5><Column6 ID=""cod_customer""><Caption>c" & _
        "od_customer</Caption><DataMember>cod_customer</DataMember><EditType>NoEdit</Edit" & _
        "Type><Key>cod_customer</Key><Position>6</Position><Visible>False</Visible></Colu" & _
        "mn6><Column7 ID=""Gl_receive_payment_Refrence_no""><Caption>Gl_receive_payment_Ref" & _
        "rence_no</Caption><DataMember>Gl_receive_payment_Refrence_no</DataMember><EditTy" & _
        "pe>NoEdit</EditType><Key>Gl_receive_payment_Refrence_no</Key><Position>7</Positi" & _
        "on><Visible>False</Visible><Width>139</Width></Column7></Columns><GroupCondition" & _
        " ID="""" /><Key>GL_account_adjustment_head</Key></RootTable></GridEXLayoutData>"
        Me.Grd2.DesignTimeLayout = GridEXLayout1
        Me.Grd2.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grd2.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.Grd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Grd2.Location = New System.Drawing.Point(8, 64)
        Me.Grd2.Name = "Grd2"
        Me.Grd2.Size = New System.Drawing.Size(672, 320)
        Me.Grd2.TabIndex = 9
        '
        'BtnUnmarkAll
        '
        Me.BtnUnmarkAll.Location = New System.Drawing.Point(88, 392)
        Me.BtnUnmarkAll.Name = "BtnUnmarkAll"
        Me.BtnUnmarkAll.TabIndex = 15
        Me.BtnUnmarkAll.Text = "UnMark All"
        '
        'BtnMarkAll
        '
        Me.BtnMarkAll.Location = New System.Drawing.Point(8, 392)
        Me.BtnMarkAll.Name = "BtnMarkAll"
        Me.BtnMarkAll.TabIndex = 14
        Me.BtnMarkAll.Text = "Mark All"
        '
        'CmdDel
        '
        Me.CmdDel.Connection = Me.Cnn
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(175, 392)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.TabIndex = 17
        Me.btndelete.Text = "Delete"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(608, 392)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.TabIndex = 18
        Me.BtnExit.Text = "Exit"
        '
        'DAFinanceDate
        '
        Me.DAFinanceDate.SelectCommand = Me.SqlCommand1
        Me.DAFinanceDate.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("Remark", "Remark"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Gl_receive_payment_Refrence_no", "Gl_receive_payment_Refrence_no"), New System.Data.Common.DataColumnMapping("finance_charge_flag", "finance_charge_flag")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT TOP 1 date_adjustment FROM GL_account_adjustment_head WHERE (finance_charg" & _
        "e_flag = 1) AND (id_GL_journal IS NULL) ORDER BY dbo.ChangeDate(date_adjustment)" & _
        " DESC"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'FrmDeleteFinanceCharge
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(694, 428)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.BtnUnmarkAll)
        Me.Controls.Add(Me.BtnMarkAll)
        Me.Controls.Add(Me.Grd2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmDeleteFinanceCharge"
        Me.Text = "Delete Finance Charge"
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmDeleteFinance1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmDeleteFinanceCharge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cnn.ConnectionString = CommonClass.PConnectionString
            DAFinanceDate.Fill(DsFrmDeleteFinance1.FinanceDate)
            If DsFrmDeleteFinance1.FinanceDate.Rows.Count > 0 Then
                DaGlaccountAdjustment.SelectCommand.Parameters("@date_adjustment").Value = CmbDate.SelectedValue
                DaGlaccountAdjustment.Fill(DsFrmDeleteFinance1.GL_account_adjustment_head)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub BtnUnmarkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnmarkAll.Click
        Dim i As Integer = 0
        For i = 0 To DsFrmDeleteFinance1.GL_account_adjustment_head.Rows.Count - 1
            DsFrmDeleteFinance1.GL_account_adjustment_head.Rows(i).Item("finance_charge_flag") = False
        Next
        Grd2.Refetch()
    End Sub

    Private Sub BtnMarkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMarkAll.Click
        Dim i As Integer = 0
        For i = 0 To DsFrmDeleteFinance1.GL_account_adjustment_head.Rows.Count - 1
            DsFrmDeleteFinance1.GL_account_adjustment_head.Rows(i).Item("finance_charge_flag") = True
        Next
        Grd2.Refetch()
    End Sub
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If DsFrmDeleteFinance1.GL_account_adjustment_head.Rows.Count > 0 Then
            Dim i As Integer = 0
            'If Grd2.GetRow.Cells(0).Value & "" <> "" Then
            Dim c1 As New CommonClass.FrmWhatDoForMenu
            c1.BtnLeftText = "Cancel"
            c1.BtnRightText = "Ok"
            c1.Text = "Finance Charges Warning"
            c1.ShowFarMsg("This Operation Will Delete Finance Charge From the customer balance")
            '-------------------------------------- 
            If c1.DialogResult = DialogResult.OK Then
                CmdDel.Connection.Open()
                For i = 0 To DsFrmDeleteFinance1.GL_account_adjustment_head.Rows.Count - 1
                    If DsFrmDeleteFinance1.GL_account_adjustment_head.Rows(i).Item("finance_charge_flag") = True Then
                        CmdDel.CommandText = "Delete From GL_account_adjustment_head where refrence_no= " & CommonClass.Qt(DsFrmDeleteFinance1.GL_account_adjustment_head.Rows(i).Item("refrence_no") & "")
                        Try
                            CmdDel.ExecuteNonQuery()
                        Catch ex As Exception
                            CommonClass.MsgFar("Adjustment no : " & DsFrmDeleteFinance1.GL_account_adjustment_head.Rows(i).Item("refrence_no") & " was Passed by some payment or adjustment.")
                            '  MsgBox(ex.ToString)
                        End Try

                    End If
                Next
                CmdDel.Connection.Close()
                DsFrmDeleteFinance1.Clear()
                DsFrmDeleteFinance1.FinanceDate.AddFinanceDateRow("")
                DAFinanceDate.Fill(DsFrmDeleteFinance1.FinanceDate)
                CmbDate.SelectedValue = ""
                'DaGlaccountAdjustment.Fill(DsFrmDeleteFinance1)
            End If
            'End If
        End If
        DsFrmDeleteFinance1.Clear()
        DAFinanceDate.Fill(DsFrmDeleteFinance1.FinanceDate)
        If DsFrmDeleteFinance1.FinanceDate.Rows.Count > 0 Then
            DaGlaccountAdjustment.SelectCommand.Parameters("@date_adjustment").Value = CmbDate.SelectedValue
            DaGlaccountAdjustment.Fill(DsFrmDeleteFinance1.GL_account_adjustment_head)
        End If
    End Sub
End Class
