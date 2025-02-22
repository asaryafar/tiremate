Imports CommonClass
Public Class FrmMonthDailySales
    Inherits FrmBase
    Dim WithEvents Prn As CommonClass.FrmRepView
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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAService_center_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents DsFrmMonthDailySales1 As GraphicalReports.DSFrmMonthDailySales
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnPreview As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnOK As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAService_center_head = New System.Data.SqlClient.SqlDataAdapter
        Me.CmbMonth = New System.Windows.Forms.ComboBox
        Me.DsFrmMonthDailySales1 = New GraphicalReports.DSFrmMonthDailySales
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.BtnPreview = New Janus.Windows.EditControls.UIButton
        Me.BtnExit = New Janus.Windows.EditControls.UIButton
        Me.BtnOK = New Janus.Windows.EditControls.UIButton
        CType(Me.DsFrmMonthDailySales1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT SUBSTRING(service_center_head.date_refer, 4, 2) AS date_refer, SUM(GL_paym" & _
        "ent_deposit.payment_amount) AS Total FROM GL_payment_deposit INNER JOIN service_" & _
        "center_head ON GL_payment_deposit.id_service_center = service_center_head.id_ser" & _
        "vice_center WHERE (dbo.ChangeDate(service_center_head.date_refer) >= @FromDate) " & _
        "AND (dbo.ChangeDate(service_center_head.date_refer) <= @ToDate) AND (GL_payment_" & _
        "deposit.refer_type = '1') AND (GL_payment_deposit.id_service_center NOT IN (SELE" & _
        "CT id_service_center FROM service_center_dtl WHERE type_select = 'B')) GROUP BY " & _
        "SUBSTRING(service_center_head.date_refer, 4, 2)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=armandehserver;p" & _
        "ersist security info=True;initial catalog=TireMate_04"
        '
        'DAService_center_head
        '
        Me.DAService_center_head.SelectCommand = Me.SqlSelectCommand1
        Me.DAService_center_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'CmbMonth
        '
        Me.CmbMonth.DataSource = Me.DsFrmMonthDailySales1.MonthTable
        Me.CmbMonth.DisplayMember = "MonthName"
        Me.CmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMonth.Location = New System.Drawing.Point(54, 7)
        Me.CmbMonth.Name = "CmbMonth"
        Me.CmbMonth.Size = New System.Drawing.Size(184, 21)
        Me.CmbMonth.TabIndex = 1
        Me.CmbMonth.ValueMember = "MonthCode"
        '
        'DsFrmMonthDailySales1
        '
        Me.DsFrmMonthDailySales1.DataSetName = "DSFrmMonthDailySales"
        Me.DsFrmMonthDailySales1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Month :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridEX1
        '
        Me.GridEX1.DataMember = "service_center_head"
        Me.GridEX1.DataSource = Me.DsFrmMonthDailySales1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_head</Caption><Columns Colle" & _
        "ction=""true""><Column0 ID=""date_refer""><Caption>Days</Caption><TypeNameEmptyStrin" & _
        "gValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>d" & _
        "ate_refer</DataMember><EditType>NoEdit</EditType><Key>date_refer</Key><Position>" & _
        "0</Position><Width>66</Width></Column0><Column1 ID=""Total""><AggregateFunction>Su" & _
        "m</AggregateFunction><Caption>Total</Caption><DataMember>Total</DataMember><Edit" & _
        "Type>NoEdit</EditType><FormatString>c2</FormatString><Key>Total</Key><Position>1" & _
        "</Position><TextAlignment>Far</TextAlignment><Width>143</Width><TotalFormatStrin" & _
        "g>c2</TotalFormatString></Column1></Columns><GroupCondition ID="""" /><Key>service" & _
        "_center_head</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(31, 33)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(249, 327)
        Me.GridEX1.TabIndex = 3
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'BtnPreview
        '
        Me.BtnPreview.Location = New System.Drawing.Point(224, 365)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(75, 23)
        Me.BtnPreview.TabIndex = 4
        Me.BtnPreview.Text = "Preview"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(12, 365)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(241, 5)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(65, 23)
        Me.BtnOK.TabIndex = 6
        Me.BtnOK.Text = "OK"
        '
        'FrmMonthDailySales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(310, 390)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnPreview)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.CmbMonth)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMonthDailySales"
        Me.Text = "Month Daily Sales"
        CType(Me.DsFrmMonthDailySales1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmMonthDailySales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        Dim i As Integer
        For i = 1 To 12
            DsFrmMonthDailySales1.MonthTable.AddMonthTableRow(MonthName(i), Getcod(Str(i), 2))
        Next
    End Sub
    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        Dim FromDate As String = PSalMali & "/" & CmbMonth.SelectedValue & "/01"
        Dim ToDate As String = PSalMali & "/" & CmbMonth.SelectedValue & "/31"

        DsFrmMonthDailySales1.service_center_head.Clear()
        DsFrmMonthDailySales1.service_center_headSummery.Clear()
        DAService_center_head.SelectCommand.Parameters("@fromDate").Value = FromDate
        DAService_center_head.SelectCommand.Parameters("@ToDate").Value = ToDate
        DAService_center_head.Fill(DsFrmMonthDailySales1.service_center_headSummery)
        Dim i As Integer
        Dim j As String
        Dim TotalVar As Decimal
        Dim DateVar As Date
        For i = 0 To DateVar.DaysInMonth(PSalMali, CmbMonth.SelectedValue)
            j = Getcod(Str(i), 2)
            Dim dr As DataRow
            dr = DsFrmMonthDailySales1.service_center_headSummery.FindBydate_refer(j)
            If IsNothing(dr) Then
                TotalVar = 0
            Else
                TotalVar = dr.Item("Total")
            End If
            DsFrmMonthDailySales1.service_center_head.Addservice_center_headRow(j, TotalVar)
        Next
    End Sub
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Dim OrptGraph As RepMonthDailySales

        OrptGraph = New RepMonthDailySales
        Prn = New FrmRepView
        OrptGraph.SetParameterValue("ReportTitle", CmbMonth.Text & " Sales ")
        OrptGraph.SetDataSource(DsFrmMonthDailySales1.service_center_head)
        Prn.CrViewer.ReportSource = OrptGraph
        Prn.Show()
    End Sub
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
