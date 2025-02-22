Imports CommonClass
Public Class FrmSearchLabor_ServiceCod
    Inherits FrmBase
    Event Labor_ServiceFind(ByVal ThisLabor_ServiceCod As String, ByVal Thisdesc_Service As String)
    Public KindService As String
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DSFrmSearchLabor_ServiceCod1 As UCLabor_Service.DSInv_tab_labor_service
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtCode As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_labor_service As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSearchLabor_ServiceCod))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnFind = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCode = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.DSFrmSearchLabor_ServiceCod1 = New UCLabor_Service.DSInv_tab_labor_service
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_labor_service = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSFrmSearchLabor_ServiceCod1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnFind)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtCode)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 62)
        Me.Panel1.TabIndex = 0
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(574, 11)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(574, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 10)
        Me.Label14.TabIndex = 345
        Me.Label14.Text = "Find"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(69, 36)
        Me.TxtName.MaxLength = 20
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(245, 20)
        Me.TxtName.TabIndex = 1
        Me.TxtName.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(5, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 22)
        Me.Label1.TabIndex = 334
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCode
        '
        Me.TxtCode.Location = New System.Drawing.Point(69, 7)
        Me.TxtCode.MaxLength = 20
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(106, 20)
        Me.TxtCode.TabIndex = 0
        Me.TxtCode.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.YellowGreen
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(5, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 22)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "Code"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataSource = Me.DataView1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>inv_tab_labor_service</Caption><Columns Col" & _
        "lection=""true""><Column0 ID=""cod_service""><Caption>Code</Caption><TypeNameEmptySt" & _
        "ringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMembe" & _
        "r>cod_service</DataMember><Key>cod_service</Key><Position>0</Position><Width>77<" & _
        "/Width></Column0><Column1 ID=""desc_service""><Caption>Service Name</Caption><Data" & _
        "Member>desc_service</DataMember><Key>desc_service</Key><Position>1</Position><Wi" & _
        "dth>387</Width></Column1><Column2 ID=""taxable""><Caption>Taxable</Caption><Column" & _
        "Type>CheckBox</ColumnType><DataMember>taxable</DataMember><EditType>CheckBox</Ed" & _
        "itType><Key>taxable</Key><Position>2</Position><Width>59</Width></Column2></Colu" & _
        "mns><GroupCondition ID="""" /><Key>inv_tab_labor_service</Key></RootTable></GridEX" & _
        "LayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 62)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(629, 293)
        Me.GrdDetail.TabIndex = 1
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DSFrmSearchLabor_ServiceCod1.inv_tab_labor_service
        '
        'DSFrmSearchLabor_ServiceCod1
        '
        Me.DSFrmSearchLabor_ServiceCod1.DataSetName = "DSInv_tab_labor_service"
        Me.DSFrmSearchLabor_ServiceCod1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=TireMate_01"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CmdOk)
        Me.Panel2.Controls.Add(Me.CmdExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 355)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(629, 33)
        Me.Panel2.TabIndex = 2
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdOk.ForeColor = System.Drawing.Color.Black
        Me.CmdOk.Location = New System.Drawing.Point(447, 5)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 24)
        Me.CmdOk.TabIndex = 0
        Me.CmdOk.Text = "Ok"
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdExit.ForeColor = System.Drawing.Color.Black
        Me.CmdExit.Location = New System.Drawing.Point(543, 5)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 1
        Me.CmdExit.Text = "Exit"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_service, desc_service, cost, taxable, service_type FROM inv_tab_labor_" & _
        "service"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAinv_tab_labor_service
        '
        Me.DAinv_tab_labor_service.SelectCommand = Me.SqlSelectCommand2
        Me.DAinv_tab_labor_service.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_labor_service", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_service", "cod_service"), New System.Data.Common.DataColumnMapping("desc_service", "desc_service"), New System.Data.Common.DataColumnMapping("ext_desc", "ext_desc"), New System.Data.Common.DataColumnMapping("service_type", "service_type"), New System.Data.Common.DataColumnMapping("service_category", "service_category"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("use_cost", "use_cost"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("require_technician", "require_technician"), New System.Data.Common.DataColumnMapping("charge_shop_supply", "charge_shop_supply"), New System.Data.Common.DataColumnMapping("schedule", "schedule"), New System.Data.Common.DataColumnMapping("avg_time", "avg_time"), New System.Data.Common.DataColumnMapping("use_avg_time", "use_avg_time"), New System.Data.Common.DataColumnMapping("bay_no", "bay_no"), New System.Data.Common.DataColumnMapping("use_bay_no", "use_bay_no"), New System.Data.Common.DataColumnMapping("reminder", "reminder"), New System.Data.Common.DataColumnMapping("miles", "miles"), New System.Data.Common.DataColumnMapping("days", "days"), New System.Data.Common.DataColumnMapping("type_b_t_d_v_r", "type_b_t_d_v_r")})})
        '
        'FrmSearchLabor_ServiceCod
        '
        Me.AcceptButton = Me.BtnFind
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(629, 388)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSearchLabor_ServiceCod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Service Search"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSFrmSearchLabor_ServiceCod1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSearchLabor_ServiceCod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Try
            Cnn.ConnectionString = PConnectionString
        Catch ex As Exception
        End Try
        TxtCode.Text = ""
        TxtName.Text = ""
        Call FillDataSet()
    End Sub
    Private Sub FillDataSet()
        DSFrmSearchLabor_ServiceCod1.inv_tab_labor_service.Clear()
        DAinv_tab_labor_service.Fill(DSFrmSearchLabor_ServiceCod1, "inv_tab_labor_service")
        Select Case KindService
            Case "L" '01 Labor
                DataView1.RowFilter = " service_type='01'"
                Me.Text = "Service Search (Labor)"
            Case "F" '02 Fees
                DataView1.RowFilter = " service_type='02'"
                Me.Text = "Service Search (Fees)"
            Case "S" '03 Shop Supply
                DataView1.RowFilter = " service_type='03'"
                Me.Text = "Service Search (Shop Supply)"
            Case Else
                DataView1.RowFilter = " "
                Me.Text = "Service Search"
        End Select
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent Labor_ServiceFind(GrdDetail.GetRow.Cells(0).Value & "", GrdDetail.GetRow.Cells(1).Value & " ")
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Call GrdDetail_DoubleClick(sender, e)
        Me.Close()
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub ActFilter()
        Dim WhereClauseVar As String = ""
        Dim OPerand As String = " "
        Select Case KindService
            Case "L" '01 Labor
                WhereClauseVar = " service_type='01'"
                OPerand = " AND "
            Case "F" '02 Fees
                WhereClauseVar = " service_type='02'"
                OPerand = " AND "
            Case "S" '03 Shop Supply
                WhereClauseVar = " service_type='03'"
                OPerand = " AND "
        End Select

        If TxtCode.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & " cod_service like '%" & TxtCode.Text.Trim & "%' "
            OPerand = " AND "
        End If
        If TxtName.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & " desc_service like '%" & TxtName.Text.Trim & "%' "
            OPerand = " AND "
        End If
        DataView1.RowFilter = WhereClauseVar
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Call ActFilter()
    End Sub
End Class
