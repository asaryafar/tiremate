Imports CommonClass
Public Class FrmCashPaidOutPrint
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents TxtFromDate As CalendarCombo.CalendarCombo
    Friend WithEvents TxtToDate As CalendarCombo.CalendarCombo
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaGlPaied As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents RD1 As System.Windows.Forms.RadioButton
    Friend WithEvents RD2 As System.Windows.Forms.RadioButton
    Friend WithEvents RD3 As System.Windows.Forms.RadioButton
    Friend WithEvents RD4 As System.Windows.Forms.RadioButton
    Friend WithEvents DsFrmCashPaidOutPrint1 As UCBankAccount.DSFrmCashPaidOutPrint
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAservice_center_head As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCashPaidOutPrint))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RD4 = New System.Windows.Forms.RadioButton
        Me.RD3 = New System.Windows.Forms.RadioButton
        Me.RD2 = New System.Windows.Forms.RadioButton
        Me.RD1 = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TxtToDate = New CalendarCombo.CalendarCombo
        Me.TxtFromDate = New CalendarCombo.CalendarCombo
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DaGlPaied = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmCashPaidOutPrint1 = New UCBankAccount.DSFrmCashPaidOutPrint
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAservice_center_head = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DsFrmCashPaidOutPrint1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RD4)
        Me.Panel1.Controls.Add(Me.RD3)
        Me.Panel1.Controls.Add(Me.RD2)
        Me.Panel1.Controls.Add(Me.RD1)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 72)
        Me.Panel1.TabIndex = 1
        '
        'RD4
        '
        Me.RD4.Location = New System.Drawing.Point(248, 40)
        Me.RD4.Name = "RD4"
        Me.RD4.Size = New System.Drawing.Size(136, 24)
        Me.RD4.TabIndex = 3
        Me.RD4.Text = "Down Payment"
        '
        'RD3
        '
        Me.RD3.Location = New System.Drawing.Point(24, 40)
        Me.RD3.Name = "RD3"
        Me.RD3.Size = New System.Drawing.Size(136, 24)
        Me.RD3.TabIndex = 2
        Me.RD3.Text = "Return Payment"
        '
        'RD2
        '
        Me.RD2.Checked = True
        Me.RD2.Location = New System.Drawing.Point(248, 8)
        Me.RD2.Name = "RD2"
        Me.RD2.Size = New System.Drawing.Size(136, 24)
        Me.RD2.TabIndex = 1
        Me.RD2.TabStop = True
        Me.RD2.Text = "Other Receipt"
        '
        'RD1
        '
        Me.RD1.Location = New System.Drawing.Point(24, 8)
        Me.RD1.Name = "RD1"
        Me.RD1.Size = New System.Drawing.Size(136, 24)
        Me.RD1.TabIndex = 0
        Me.RD1.Text = "Cash Paid Out"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxtToDate)
        Me.Panel2.Controls.Add(Me.TxtFromDate)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(8, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 40)
        Me.Panel2.TabIndex = 2
        '
        'TxtToDate
        '
        Me.TxtToDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtToDate.BorderColor = System.Drawing.Color.Empty
        Me.TxtToDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtToDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtToDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtToDate.EditableSal = True
        Me.TxtToDate.Image = CType(resources.GetObject("TxtToDate.Image"), System.Drawing.Image)
        Me.TxtToDate.Location = New System.Drawing.Point(283, 7)
        Me.TxtToDate.MaxValue = CType(2500, Short)
        Me.TxtToDate.MinValue = CType(1800, Short)
        Me.TxtToDate.Name = "TxtToDate"
        Me.TxtToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtToDate.Sal_Mali = Nothing
        Me.TxtToDate.ShowButton = True
        Me.TxtToDate.Size = New System.Drawing.Size(110, 23)
        Me.TxtToDate.TabIndex = 2
        Me.TxtToDate.VisualStyle = False
        '
        'TxtFromDate
        '
        Me.TxtFromDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtFromDate.BorderColor = System.Drawing.Color.Empty
        Me.TxtFromDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtFromDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtFromDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtFromDate.EditableSal = True
        Me.TxtFromDate.Image = CType(resources.GetObject("TxtFromDate.Image"), System.Drawing.Image)
        Me.TxtFromDate.Location = New System.Drawing.Point(89, 7)
        Me.TxtFromDate.MaxValue = CType(2500, Short)
        Me.TxtFromDate.MinValue = CType(1800, Short)
        Me.TxtFromDate.Name = "TxtFromDate"
        Me.TxtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtFromDate.Sal_Mali = Nothing
        Me.TxtFromDate.ShowButton = True
        Me.TxtFromDate.Size = New System.Drawing.Size(110, 23)
        Me.TxtFromDate.TabIndex = 0
        Me.TxtFromDate.VisualStyle = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(30, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "From Date"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(235, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To Date"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CmdExit)
        Me.Panel3.Controls.Add(Me.CmdOk)
        Me.Panel3.Location = New System.Drawing.Point(8, 136)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(400, 32)
        Me.Panel3.TabIndex = 3
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(316, 4)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 1
        Me.CmdExit.Text = "Exit"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(16, 3)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 0
        Me.CmdOk.Text = "Ok"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_Paid_received.refrence_code, GL_Paid_received.tran_type, GL_Paid_receiv" & _
        "ed.action_date, GL_Paid_received.customer_code, GL_Paid_received.vendor_code, GL" & _
        "_Paid_received.amount, GL_Paid_received.GL_account, GL_Paid_received.memo, GL_Pa" & _
        "id_received.Id_GL_journal, GL_Paid_received.OtherReceipType, GL_Paid_received.Id" & _
        "_debit_deposit_head, GL_Paid_received.id_service_center, CASE cust_trtab_main.co" & _
        "d_customer WHEN NULL THEN RTRIM(LTRIM(cust_trtab_main.l_name)) + ' ' + RTRIM(LTR" & _
        "IM(cust_trtab_main.m_name)) + ' ' + RTRIM(LTRIM(cust_trtab_main.f_name)) ELSE RT" & _
        "RIM(LTRIM(cust_trtab_main.l_name)) + ' ' + RTRIM(LTRIM(cust_trtab_main.m_name)) " & _
        "+ ' ' + RTRIM(LTRIM(cust_trtab_main.f_name)) END AS CustomerName, cust_company.c" & _
        "omplete_name AS company, CASE OtherReceipType WHEN '1' THEN 'Cash' WHEN '2' THEN" & _
        " 'CHECK' WHEN '3' THEN 'Credit Card' END AS PayMethod, GL_account.desc_GL_accoun" & _
        "t, inv_vendor.desc_vendor FROM GL_Paid_received LEFT OUTER JOIN inv_vendor ON GL" & _
        "_Paid_received.vendor_code = inv_vendor.cod_vendor LEFT OUTER JOIN GL_account ON" & _
        " GL_Paid_received.GL_account = GL_account.GL_account LEFT OUTER JOIN cust_trtab_" & _
        "main ON GL_Paid_received.customer_code = cust_trtab_main.cod_customer LEFT OUTER" & _
        " JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company WHE" & _
        "RE (GL_Paid_received.tran_type = @tran_type) AND (dbo.ChangeDate(GL_Paid_receive" & _
        "d.action_date) >= @FromDate) AND (dbo.ChangeDate(GL_Paid_received.action_date) <" & _
        "= @ToDate)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tran_type", System.Data.SqlDbType.VarChar, 1, "tran_type"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH;packet size=4096;user id=sa;data source=""."";persist security i" & _
        "nfo=True;initial catalog=TireMate_01;password=2191110"
        '
        'DaGlPaied
        '
        Me.DaGlPaied.SelectCommand = Me.SqlSelectCommand1
        Me.DaGlPaied.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_Paid_received", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_code", "refrence_code"), New System.Data.Common.DataColumnMapping("tran_type", "tran_type"), New System.Data.Common.DataColumnMapping("action_date", "action_date"), New System.Data.Common.DataColumnMapping("customer_code", "customer_code"), New System.Data.Common.DataColumnMapping("vendor_code", "vendor_code"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("Id_GL_journal", "Id_GL_journal"), New System.Data.Common.DataColumnMapping("OtherReceipType", "OtherReceipType"), New System.Data.Common.DataColumnMapping("Id_debit_deposit_head", "Id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center")})})
        '
        'DsFrmCashPaidOutPrint1
        '
        Me.DsFrmCashPaidOutPrint1.DataSetName = "DSFrmCashPaidOutPrint"
        Me.DsFrmCashPaidOutPrint1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT service_center_head.id_service_center AS refrence_code, '3' AS tran_type, " & _
        "service_center_head.cod_customer AS customer_code, service_center_head.id_vehicl" & _
        "e, service_center_head.date_refer AS action_date, service_center_head.discount, " & _
        "service_center_head.tax, service_center_head.cust_comment AS memo, service_cente" & _
        "r_head.add_user, service_center_head.chg_user, service_center_head.po_no, servic" & _
        "e_center_head.id_service_center_before, service_center_head.id_GL_journal, servi" & _
        "ce_center_head.Total AS amount, '3' AS OtherReceipType, service_center_head.id_s" & _
        "ervice_center, CASE cust_trtab_main.cod_customer WHEN NULL THEN RTRIM(LTRIM(cust" & _
        "_trtab_main.l_name)) + ' ' + RTRIM(LTRIM(cust_trtab_main.m_name)) + ' ' + RTRIM(" & _
        "LTRIM(cust_trtab_main.f_name)) ELSE RTRIM(LTRIM(cust_trtab_main.l_name)) + ' ' +" & _
        " RTRIM(LTRIM(cust_trtab_main.m_name)) + ' ' + RTRIM(LTRIM(cust_trtab_main.f_name" & _
        ")) END AS CustomerName, cust_company.complete_name AS company, CASE GL_payment_d" & _
        "eposit.payment_type WHEN '3' THEN 'Credit Card' WHEN '4' THEN 'AR' ELSE 'Cash' E" & _
        "ND AS PayMethod, GL_Paid_received.GL_account, GL_account.desc_GL_account FROM GL" & _
        "_payment_deposit RIGHT OUTER JOIN GL_Paid_received RIGHT OUTER JOIN service_cent" & _
        "er_head ON GL_Paid_received.id_service_center = service_center_head.id_service_c" & _
        "enter ON GL_payment_deposit.id_service_center = service_center_head.id_service_c" & _
        "enter LEFT OUTER JOIN GL_account ON GL_Paid_received.GL_account = GL_account.GL_" & _
        "account LEFT OUTER JOIN cust_company RIGHT OUTER JOIN cust_trtab_main ON cust_co" & _
        "mpany.cod_company = cust_trtab_main.cod_company ON service_center_head.cod_custo" & _
        "mer = cust_trtab_main.cod_customer WHERE (service_center_head.type_of_form = 'RT" & _
        "') AND (dbo.ChangeDate(service_center_head.date_refer) >= @FromDate) AND (dbo.Ch" & _
        "angeDate(service_center_head.date_refer) <= @ToDate)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DAservice_center_head
        '
        Me.DAservice_center_head.SelectCommand = Me.SqlSelectCommand2
        Me.DAservice_center_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'FrmCashPaidOutPrint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 180)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCashPaidOutPrint"
        Me.Text = "Cash Paid Out Print"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DsFrmCashPaidOutPrint1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCashPaidOutPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        TxtFromDate.Text = Format(Now.Date.AddMonths(-1), PubDateFormat)
        TxtToDate.Text = Format(Now.Date, PubDateFormat)
    End Sub

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        DsFrmCashPaidOutPrint1.Clear()
        If RD3.Checked Then
            DAservice_center_head.SelectCommand.Parameters("@FromDate").Value = Mid(TxtFromDate.Text, 7, 4) + "/" + Mid(TxtFromDate.Text, 1, 2) + "/" + Mid(TxtFromDate.Text, 4, 2)
            DAservice_center_head.SelectCommand.Parameters("@ToDate").Value = Mid(TxtToDate.Text, 7, 4) + "/" + Mid(TxtToDate.Text, 1, 2) + "/" + Mid(TxtToDate.Text, 4, 2)
            DAservice_center_head.Fill(DsFrmCashPaidOutPrint1.GL_Paid_received)
        Else
            DaGlPaied.SelectCommand.Parameters("@tran_type").Value = WhichRadio()
            DaGlPaied.SelectCommand.Parameters("@FromDate").Value = Mid(TxtFromDate.Text, 7, 4) + "/" + Mid(TxtFromDate.Text, 1, 2) + "/" + Mid(TxtFromDate.Text, 4, 2)
            DaGlPaied.SelectCommand.Parameters("@ToDate").Value = Mid(TxtToDate.Text, 7, 4) + "/" + Mid(TxtToDate.Text, 1, 2) + "/" + Mid(TxtToDate.Text, 4, 2)
            DaGlPaied.Fill(DsFrmCashPaidOutPrint1.GL_Paid_received)
        End If

        Try
            If DsFrmCashPaidOutPrint1.GL_Paid_received.Rows.Count > 0 Then
                Dim FrmShow As New FrmCashPaidOutPrintGrd
                FrmShow.GridEX1.DataSource = DsFrmCashPaidOutPrint1
                FrmShow.GridEX1.DataMember = "GL_Paid_received"

                If RD1.Checked Then
                    FrmShow.GridEX1.RootTable.Columns(0).Visible = False
                    FrmShow.GridEX1.RootTable.Columns(1).Visible = False
                    FrmShow.GridEX1.RootTable.Columns(2).Visible = True
                    FrmShow.GridEX1.RootTable.Columns(4).Visible = False
                ElseIf RD2.Checked Then
                    FrmShow.GridEX1.RootTable.Columns(0).Visible = True
                    FrmShow.GridEX1.RootTable.Columns(1).Visible = True
                    FrmShow.GridEX1.RootTable.Columns(2).Visible = False
                    FrmShow.GridEX1.RootTable.Columns(4).Visible = False
                ElseIf RD3.Checked Then
                    FrmShow.GridEX1.RootTable.Columns(0).Visible = True
                    FrmShow.GridEX1.RootTable.Columns(1).Visible = True
                    FrmShow.GridEX1.RootTable.Columns(2).Visible = False
                    FrmShow.GridEX1.RootTable.Columns(4).Visible = False
                ElseIf RD4.Checked Then
                    FrmShow.GridEX1.RootTable.Columns(0).Visible = True
                    FrmShow.GridEX1.RootTable.Columns(1).Visible = True
                    FrmShow.GridEX1.RootTable.Columns(2).Visible = False
                    FrmShow.GridEX1.RootTable.Columns(4).Visible = True
                End If

                FrmShow.GridEXPrintDocument1.PageHeaderLeft = "Cash Paid Out Report " & What2()
                FrmShow.GridEXPrintDocument1.PageHeaderRight = "Report date :" + Format(Now.Date, PubDateFormat)
                FrmShow.GridEXPrintDocument1.PageHeaderCenter = PubCompanyName
                FrmShow.GridEXPrintDocument1.PageFooterCenter = " from date : " & TxtFromDate.Text & " To Date :" & TxtToDate.Text
                If RD1.Checked Then
                    FrmShow.Text = RD1.Text
                ElseIf RD2.Checked Then
                    FrmShow.Text = RD2.Text
                ElseIf RD3.Checked Then
                    FrmShow.Text = RD3.Text
                ElseIf RD4.Checked Then
                    FrmShow.Text = RD4.Text
                End If
                FrmShow.ShowDialog()
            Else
                MsgFar("No Records Found")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Function WhichRadio() As String
        If RD1.Checked Then
            Return "1"
        End If
        If RD2.Checked Then
            Return "2"
        End If
        If RD3.Checked Then
            Return "3"
        End If
        If RD4.Checked Then
            Return "4"
        End If
    End Function
    Function What2() As String
        If RD1.Checked Then
            Return RD1.Text
        End If
        If RD2.Checked Then
            Return RD2.Text
        End If
        If RD3.Checked Then
            Return RD3.Text
        End If
        If RD4.Checked Then
            Return RD4.Text
        End If
    End Function
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
End Class
