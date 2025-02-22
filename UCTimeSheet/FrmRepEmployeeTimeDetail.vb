Imports TimeBox
Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmRepEmployeeTimeDetail
    Inherits FrmBase
    Dim DApay_punch_employee_in_outOriginalVar
    Dim So As New Janus.Windows.GridEX.SortOrder
    Dim MyClsTime As New ClsTime
    Public WhereCluaseVar As String
    Public Date1 As String
    Public Date2 As String
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DApay_punch_employee_in_out As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnFchooser As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents DsFrmRepEmployeeTime1 As UCTimeSheet.DSFrmRepEmployeeTime
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepEmployeeTimeDetail))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DApay_punch_employee_in_out = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.BtnFchooser = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
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
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmRepEmployeeTime1 = New UCTimeSheet.DSFrmRepEmployeeTime
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmRepEmployeeTime1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(33, 33)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=TireMate_01"
        '
        'DApay_punch_employee_in_out
        '
        Me.DApay_punch_employee_in_out.SelectCommand = Me.SqlSelectCommand1
        Me.DApay_punch_employee_in_out.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_punch_employee_in_out", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_punch_in_out", "id_punch_in_out"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("action_date", "action_date"), New System.Data.Common.DataColumnMapping("action_time_Hour", "action_time_Hour"), New System.Data.Common.DataColumnMapping("action_time_Minute", "action_time_Minute"), New System.Data.Common.DataColumnMapping("punch_note_code", "punch_note_code"), New System.Data.Common.DataColumnMapping("In_Out_type", "In_Out_type")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT pay_punch_employee_in_out.id_punch_in_out AS id_punch_in, pay_punch_employ" & _
        "ee_in_out.id_punch_in_out AS id_punch_out, pay_punch_employee_in_out.employee_co" & _
        "de, pay_punch_employee_in_out.action_time_Hour + ':' + pay_punch_employee_in_out" & _
        ".action_time_Minute AS In_Time, pay_punch_employee_in_out.action_date, pay_punch" & _
        "_employee_in_out.punch_note_code, '     ' AS Out_Time, '     ' AS Hours, employe" & _
        "e.l_name + ' ' + employee.m_name + ' ' + employee.f_name AS EmployeeFullName FRO" & _
        "M pay_punch_employee_in_out LEFT OUTER JOIN employee ON pay_punch_employee_in_ou" & _
        "t.employee_code = employee.employee_code"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 64)
        Me.Panel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BtnFchooser)
        Me.Panel4.Controls.Add(Me.Label3)
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
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(578, 64)
        Me.Panel4.TabIndex = 5
        '
        'BtnFchooser
        '
        Me.BtnFchooser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFchooser.Image = CType(resources.GetObject("BtnFchooser.Image"), System.Drawing.Image)
        Me.BtnFchooser.Location = New System.Drawing.Point(510, 4)
        Me.BtnFchooser.Name = "BtnFchooser"
        Me.BtnFchooser.Size = New System.Drawing.Size(33, 27)
        Me.BtnFchooser.TabIndex = 192
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(502, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "Field  Chooser"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(458, 35)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(43, 25)
        Me.Label31.TabIndex = 182
        Me.Label31.Text = "Send to Excel"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(406, 35)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 24)
        Me.Label30.TabIndex = 181
        Me.Label30.Text = "Grid Print"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(353, 38)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 180
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(296, 38)
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
        Me.BtnEmail.Location = New System.Drawing.Point(460, 4)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 13
        '
        'BtnJPrint
        '
        Me.BtnJPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnJPrint.Image = CType(resources.GetObject("BtnJPrint.Image"), System.Drawing.Image)
        Me.BtnJPrint.Location = New System.Drawing.Point(408, 4)
        Me.BtnJPrint.Name = "BtnJPrint"
        Me.BtnJPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnJPrint.TabIndex = 12
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(355, 4)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 11
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(304, 4)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 62)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select the Item That you want to print"
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
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "pay_punch_employee_in_out"
        Me.GridEX1.DataSource = Me.DsFrmRepEmployeeTime1
        GridEXLayout1.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage", CType(resources.GetObject("resource"), System.Drawing.Bitmap))})
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><AllowEdit>False</AllowEdit><Caption>pay_punch_emplo" & _
        "yee_in_out</Caption><Columns Collection=""true""><Column0 ID=""Icon""><AllowSize>Fal" & _
        "se</AllowSize><AllowSort>False</AllowSort><Bound>False</Bound><ButtonImage Refer" & _
        "ence=""GridEXLayoutData.RootTable.Columns.Column0.ButtonImage"" /><ButtonStyle>Ell" & _
        "ipsis</ButtonStyle><ColumnType>Image</ColumnType><EditType>NoEdit</EditType><Ima" & _
        "geIndex>0</ImageIndex><Key>Icon</Key><Position>0</Position><Width>20</Width></Co" & _
        "lumn0><Column1 ID=""id_punch_in_out""><Caption>id_punch_in_out</Caption><TypeNameE" & _
        "mptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>i" & _
        "d_punch_in</DataMember><EditType>NoEdit</EditType><Key>id_punch_in_out</Key><Pos" & _
        "ition>1</Position><Visible>False</Visible></Column1><Column2 ID=""id_punch_out""><" & _
        "Caption>id_punch_out</Caption><DataMember>id_punch_out</DataMember><Key>id_punch" & _
        "_out</Key><Position>2</Position><Visible>False</Visible></Column2><Column3 ID=""E" & _
        "mployeeFullName""><Caption>Employee</Caption><DataMember>EmployeeFullName</DataMe" & _
        "mber><EditType>NoEdit</EditType><Key>EmployeeFullName</Key><Position>3</Position" & _
        "><Width>253</Width></Column3><Column4 ID=""In_Time""><Caption>IN</Caption><DataMem" & _
        "ber>In_Time</DataMember><EditType>NoEdit</EditType><Key>In_Time</Key><Position>4" & _
        "</Position><Width>53</Width></Column4><Column5 ID=""Out_Time""><Caption>OUT</Capti" & _
        "on><DataMember>Out_Time</DataMember><EditType>NoEdit</EditType><Key>Out_Time</Ke" & _
        "y><Position>5</Position><Width>51</Width></Column5><Column6 ID=""Hours""><Aggregat" & _
        "eFunction>Sum</AggregateFunction><Caption>Hours</Caption><DataMember>Hours</Data" & _
        "Member><EditType>NoEdit</EditType><Key>Hours</Key><Position>6</Position><Width>5" & _
        "2</Width><TotalFormatString>###:##</TotalFormatString></Column6><Column7 ID=""act" & _
        "ion_date""><Caption>Date</Caption><DataMember>action_date</DataMember><EditType>N" & _
        "oEdit</EditType><Key>action_date</Key><Position>7</Position><Width>91</Width></C" & _
        "olumn7><Column8 ID=""punch_note_code""><Caption>Note</Caption><DataMember>punch_no" & _
        "te_code</DataMember><EditType>NoEdit</EditType><Key>punch_note_code</Key><Positi" & _
        "on>8</Position><Visible>False</Visible><Width>116</Width></Column8><Column9 ID=""" & _
        "employee_code""><Caption>employee_code</Caption><DataMember>employee_code</DataMe" & _
        "mber><EditType>NoEdit</EditType><Key>employee_code</Key><Position>9</Position><V" & _
        "isible>False</Visible></Column9><Column10 ID=""TotalHours""><Caption>Employee :</C" & _
        "aption><DataMember>TotalHours</DataMember><Key>TotalHours</Key><Position>10</Pos" & _
        "ition><Visible>False</Visible></Column10></Columns><GroupCondition ID="""" /><Grou" & _
        "ps Collection=""true""><Group0 ID=""Group0""><ColIndex>10</ColIndex><HeaderCaption>E" & _
        "mplyee :</HeaderCaption><GroupInterval>Value</GroupInterval></Group0></Groups><K" & _
        "ey>pay_punch_employee_in_out</Key><SortKeys Collection=""true""><SortKey0 ID=""Sort" & _
        "Key0""><ColIndex>7</ColIndex></SortKey0><SortKey1 ID=""SortKey1""><ColIndex>4</ColI" & _
        "ndex></SortKey1></SortKeys></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.ExternalImageList = Me.ImageList2
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.Location = New System.Drawing.Point(0, 65)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(578, 387)
        Me.GridEX1.TabIndex = 2
        '
        'DsFrmRepEmployeeTime1
        '
        Me.DsFrmRepEmployeeTime1.DataSetName = "DSFrmRepEmployeeTime"
        Me.DsFrmRepEmployeeTime1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'ImageList2
        '
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(17, 17)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'GridEXPrintDocument1
        '
        Me.GridEXPrintDocument1.GridEX = Me.GridEX1
        '
        'FrmRepEmployeeTimeDetail
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(578, 452)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmRepEmployeeTimeDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Time Report - Detail"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmRepEmployeeTime1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmEmployeeInOutBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        DApay_punch_employee_in_outOriginalVar = DApay_punch_employee_in_out.SelectCommand.CommandText
        Call AddConditionalFormatting()
        Call FillDataset()

        If date1.Trim.Length > 0 Then
            GridEXPrintDocument1.PageHeaderCenter = " From: " & date1 & "  To: " & Date2 & vbNewLine & Me.Text()
        Else
            GridEXPrintDocument1.PageHeaderCenter = Me.Text
        End If
        GridEXPrintDocument1.PageHeaderRight = "Date : " & Format(Now(), "MM/dd/yyyy")
    End Sub
    Private Sub AddConditionalFormatting()
        Dim fc As GridEXFormatCondition
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GridEX1.RootTable.Columns("Hours"), ConditionOperator.NotContains, ":")
        fc.FormatStyle.BackColor = Color.Yellow
        GridEX1.RootTable.FormatConditions.Add(fc)
    End Sub
    Private Sub gridEX1_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs)
        If e.Row.RowType = RowType.Record Then
            If e.Row.Cells("IN_Out_type").Value = 0 Then
                e.Row.Cells("IN").ImageIndex = 0
                e.Row.Cells("IN").ToolTipText = "IN"
            End If
            If e.Row.Cells("IN_Out_type").Value = 1 Then
                e.Row.Cells("OUT").ImageIndex = 1
                e.Row.Cells("OUT").ToolTipText = "OUT"
            End If
        End If
    End Sub
    Private Sub FillDataset()
        DsFrmRepEmployeeTime1.pay_punch_employee_in_out.Clear()
        DApay_punch_employee_in_out.SelectCommand.CommandText = DApay_punch_employee_in_outOriginalVar & WhereCluaseVar & " Order by pay_punch_employee_in_out.employee_code"
        Try
            DApay_punch_employee_in_out.Fill(DsFrmRepEmployeeTime1, "pay_punch_employee_in_out")
        Catch ex As Exception

        End Try
        With DsFrmRepEmployeeTime1.pay_punch_employee_in_out
            If .Rows.Count > 0 Then
                Dim i As Integer
                Dim OutTimeVar As String
                Dim Id_punch_outVar As Decimal
                Dim SQLReader As System.Data.SqlClient.SqlDataReader
                Dim ThisEmpoyee As String = ""
                Dim TotalHoursVar As String = "000:00"
                Dim ChangeEmployeeFlag As Boolean = False
                For i = 0 To .Rows.Count - 1
                    If ThisEmpoyee.ToUpper <> (.Rows(i).Item("employee_code") & "").ToUpper Then
                        ThisEmpoyee = .Rows(i).Item("employee_code")
                        TotalHoursVar = "000:00"
                    End If

                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.CommandText = "select top 1 id_punch_in_out,action_time_Hour + ':' + action_time_Minute as TimeOut From pay_punch_employee_in_out " & _
                                         "Where employee_code=" & Qt(.Rows(i).Item("employee_code")) & " AND action_date=" & Qt(.Rows(i).Item("action_date")) & " AND In_Out_Type=1 AND action_time_Hour+':'+action_time_Minute>" & Qt(.Rows(i).Item("In_Time")) & " " & _
                                         "Order by action_time_Hour + ':' + action_time_Minute ASC"
                    SQLReader = CmdGeneral.ExecuteReader
                    If SQLReader.HasRows Then
                        SQLReader.Read()
                        OutTimeVar = SQLReader.Item("TimeOut")
                        Id_punch_outVar = SQLReader.Item("id_punch_in_out")
                    Else
                        OutTimeVar = ""
                        Id_punch_outVar = 0
                    End If
                    SQLReader.Close()
                    .Rows(i).Item("id_punch_out") = Id_punch_outVar
                    .Rows(i).Item("Out_time") = OutTimeVar
                    .Rows(i).Item("Hours") = MyClsTime.SubtractTime(.Rows(i).Item("Out_time"), .Rows(i).Item("In_time"))

                    If ThisEmpoyee.ToUpper = (.Rows(i).Item("employee_code") & "").ToUpper Then
                        TotalHoursVar = MyClsTime.AddTime(TotalHoursVar, .Rows(i).Item("Hours"))
                    Else
                        ChangeEmployeeFlag = True
                    End If
                    If i = .Rows.Count - 1 Then
                        ChangeEmployeeFlag = True
                    Else
                        If ThisEmpoyee.ToUpper <> (.Rows(i + 1).Item("employee_code") & "").ToUpper Then
                            ChangeEmployeeFlag = True
                        End If
                    End If
                    If ChangeEmployeeFlag Then
                        ChangeEmployeeFlag = False
                        Dim j As Integer
                        .DefaultView.RowFilter = "employee_code=" & Qt(ThisEmpoyee)
                        Dim Thistempvar As String = .Rows(i).Item("EmployeeFullName") & "  ***  Total Hours : " & TotalHoursVar
                        For j = 0 To .DefaultView.Count - 1
                            .DefaultView(j).Item("TotalHours") = Thistempvar
                        Next
                        .DefaultView.RowFilter = ""
                        TotalHoursVar = "000:00"
                    End If
                Next
            End If
        End With
    End Sub
    Private Sub BtnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmail.Click
        Dim FileName As String
        If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If
        FileName = "report.CSV"
        Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GridEX1)
    End Sub
    Private Sub BtnFchooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFchooser.Click
        Me.GridEX1.ShowFieldChooser(Me)
    End Sub
    Private Sub BtnJprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJPrint.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class
