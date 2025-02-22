Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmRepBeginingBalance
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
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAservice_center_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmRepBeginingBalance1 As ServiceCenterScreen.DSFrmRepBeginingBalance
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepBeginingBalance))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmRepBeginingBalance1 = New ServiceCenterScreen.DSFrmRepBeginingBalance
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAservice_center_dtl = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmRepBeginingBalance1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.DataMember = "service_center_dtl"
        Me.GridEX1.DataSource = Me.DsFrmRepBeginingBalance1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""id_service_center""><Caption>Reference No</Caption><Type" & _
        "NameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /" & _
        "><DataMember>id_service_center</DataMember><EditType>NoEdit</EditType><FilterEdi" & _
        "tType>TextBox</FilterEditType><Key>id_service_center</Key><Position>0</Position>" & _
        "<Width>92</Width></Column0><Column1 ID=""date_refer""><Caption>Date</Caption><Data" & _
        "Member>date_refer</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox" & _
        "</FilterEditType><Key>date_refer</Key><Position>1</Position><Width>76</Width></C" & _
        "olumn1><Column2 ID=""cod_customer""><Caption>Customer Code</Caption><DataMember>co" & _
        "d_customer</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filte" & _
        "rEditType><Key>cod_customer</Key><Position>2</Position><Visible>False</Visible><" & _
        "Width>85</Width></Column2><Column3 ID=""FullName""><Caption>Customer Name</Caption" & _
        "><DataMember>FullName</DataMember><EditType>NoEdit</EditType><FilterEditType>Tex" & _
        "tBox</FilterEditType><Key>FullName</Key><Position>3</Position><Width>150</Width>" & _
        "</Column3><Column4 ID=""CompanyName""><Caption>Company</Caption><DataMember>Compan" & _
        "yName</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEdit" & _
        "Type><Key>CompanyName</Key><Position>4</Position><Width>159</Width></Column4><Co" & _
        "lumn5 ID=""Total""><Caption>Add To Balance</Caption><DataMember>Total</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString" & _
        ">c</FormatString><Key>Total</Key><Position>5</Position><TextAlignment>Far</TextA" & _
        "lignment><Width>112</Width></Column5></Columns><GroupCondition ID="""" /><Key>serv" & _
        "ice_center_dtl</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.Location = New System.Drawing.Point(0, 46)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(611, 406)
        Me.GridEX1.TabIndex = 0
        '
        'DsFrmRepBeginingBalance1
        '
        Me.DsFrmRepBeginingBalance1.DataSetName = "DSFrmRepBeginingBalance"
        Me.DsFrmRepBeginingBalance1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.BtnPrint)
        Me.Panel4.Controls.Add(Me.BtnPreview)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(611, 45)
        Me.Panel4.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 43)
        Me.Label1.TabIndex = 181
        Me.Label1.Text = "Beginning Balance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(504, 31)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 180
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(453, 31)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 179
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(504, 2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 11
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(460, 2)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 10
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cust_company.abbreviation_name AS CompanyName, service_center_head.Total, " & _
        "service_center_head.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main" & _
        ".m_name + ' ' + cust_trtab_main.l_name AS FullName, service_center_head.date_ref" & _
        "er, service_center_head.id_service_center FROM service_center_head LEFT OUTER JO" & _
        "IN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_cus" & _
        "tomer LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_company" & _
        ".cod_company WHERE (service_center_head.type_of_form = 'IN') AND (service_center" & _
        "_head.id_service_center IN (SELECT id_service_center FROM service_center_dtl WHE" & _
        "RE type_select = 'B'))"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=""."";persist security " & _
        "info=True;initial catalog=TireMate_02;password=2191110"
        '
        'DAservice_center_dtl
        '
        Me.DAservice_center_dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DAservice_center_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE"), New System.Data.Common.DataColumnMapping("AVERAGE_COST", "AVERAGE_COST")})})
        '
        'FrmRepBeginingBalance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(611, 452)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmRepBeginingBalance"
        Me.Text = "Beginning Balance Report"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmRepBeginingBalance1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmRepBeginingBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DAservice_center_dtl.Fill(DsFrmRepBeginingBalance1.service_center_dtl)
    End Sub
    Private Sub pprint(ByVal PrintType As String)
        Dim rpt As New RepBeginingBalance
        Dim prn As New FrmRepView
        'rpt.SetParameterValue("Parconame", "")
        rpt.SetDataSource(DsFrmRepBeginingBalance1.service_center_dtl)
        Select Case PrintType.ToUpper
            Case "print".ToUpper
                rpt.PrintToPrinter(1, True, 0, 0)
            Case "preview".ToUpper
                prn.CrViewer.ReportSource = rpt
                prn.Show()
        End Select

    End Sub
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Call pprint("preview")
    End Sub
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Call pprint("print")
    End Sub
End Class
