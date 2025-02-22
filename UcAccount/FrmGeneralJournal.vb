Imports CommonClass
Public Class FrmGeneralJournal
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GlAccount1 As UCGl_Account.GlAccount
    Friend WithEvents GlAccount2 As UCGl_Account.GlAccount
    Friend WithEvents LblFrom As System.Windows.Forms.Label
    Friend WithEvents LblTo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents Pb1 As System.Windows.Forms.ProgressBar
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGeneralJournal As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmJournal1 As UcAccount.DSFrmJournal
    Friend WithEvents DateFrom As CalendarCombo.CalendarCombo
    Friend WithEvents DateTo As CalendarCombo.CalendarCombo
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmGeneralJournal))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DateTo = New CalendarCombo.CalendarCombo
        Me.DateFrom = New CalendarCombo.CalendarCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblTo = New System.Windows.Forms.Label
        Me.LblFrom = New System.Windows.Forms.Label
        Me.GlAccount2 = New UCGl_Account.GlAccount
        Me.GlAccount1 = New UCGl_Account.GlAccount
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.Pb1 = New System.Windows.Forms.ProgressBar
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaGeneralJournal = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmJournal1 = New UcAccount.DSFrmJournal
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmJournal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DateTo)
        Me.Panel1.Controls.Add(Me.DateFrom)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LblTo)
        Me.Panel1.Controls.Add(Me.LblFrom)
        Me.Panel1.Controls.Add(Me.GlAccount2)
        Me.Panel1.Controls.Add(Me.GlAccount1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(4, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 112)
        Me.Panel1.TabIndex = 0
        '
        'DateTo
        '
        Me.DateTo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DateTo.BorderColor = System.Drawing.Color.Empty
        Me.DateTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DateTo.ButtonBackColor = System.Drawing.Color.Empty
        Me.DateTo.ButtonForeColor = System.Drawing.Color.Empty
        Me.DateTo.EditableSal = True
        Me.DateTo.Image = CType(resources.GetObject("DateTo.Image"), System.Drawing.Image)
        Me.DateTo.Location = New System.Drawing.Point(584, 72)
        Me.DateTo.MaxValue = CType(2500, Short)
        Me.DateTo.MinValue = CType(1800, Short)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTo.Sal_Mali = Nothing
        Me.DateTo.ShowButton = True
        Me.DateTo.Size = New System.Drawing.Size(112, 23)
        Me.DateTo.TabIndex = 3
        Me.DateTo.VisualStyle = False
        '
        'DateFrom
        '
        Me.DateFrom.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DateFrom.BorderColor = System.Drawing.Color.Empty
        Me.DateFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DateFrom.ButtonBackColor = System.Drawing.Color.Empty
        Me.DateFrom.ButtonForeColor = System.Drawing.Color.Empty
        Me.DateFrom.EditableSal = True
        Me.DateFrom.Image = CType(resources.GetObject("DateFrom.Image"), System.Drawing.Image)
        Me.DateFrom.Location = New System.Drawing.Point(88, 72)
        Me.DateFrom.MaxValue = CType(2500, Short)
        Me.DateFrom.MinValue = CType(1800, Short)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateFrom.Sal_Mali = Nothing
        Me.DateFrom.ShowButton = True
        Me.DateFrom.Size = New System.Drawing.Size(120, 23)
        Me.DateFrom.TabIndex = 2
        Me.DateFrom.VisualStyle = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(528, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "To Date"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "From Date"
        '
        'LblTo
        '
        Me.LblTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTo.Location = New System.Drawing.Point(224, 40)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(480, 23)
        Me.LblTo.TabIndex = 7
        '
        'LblFrom
        '
        Me.LblFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFrom.Location = New System.Drawing.Point(224, 8)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(480, 23)
        Me.LblFrom.TabIndex = 6
        '
        'GlAccount2
        '
        Me.GlAccount2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GlAccount2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GlAccount2.Cod_Gl = ""
        Me.GlAccount2.Connection = Me.Cnn
        Me.GlAccount2.Location = New System.Drawing.Point(88, 40)
        Me.GlAccount2.Name = "GlAccount2"
        Me.GlAccount2.NotExitIfNotFound = False
        Me.GlAccount2.ReleaseIfNotFoundEmployeeCod = False
        Me.GlAccount2.Size = New System.Drawing.Size(120, 20)
        Me.GlAccount2.TabIndex = 1
        '
        'GlAccount1
        '
        Me.GlAccount1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GlAccount1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GlAccount1.Cod_Gl = ""
        Me.GlAccount1.Connection = Me.Cnn
        Me.GlAccount1.Location = New System.Drawing.Point(88, 8)
        Me.GlAccount1.Name = "GlAccount1"
        Me.GlAccount1.NotExitIfNotFound = False
        Me.GlAccount1.ReleaseIfNotFoundEmployeeCod = False
        Me.GlAccount1.Size = New System.Drawing.Size(120, 20)
        Me.GlAccount1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To Account"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From Account"
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJI;packet size=4096;user id=sa;initial catalog=TireMate_01;per" & _
        "sist security info=True;password=5332"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(758, 56)
        Me.Panel4.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(300, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(456, 54)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "General Journal"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(16, 187)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 1
        Me.CmdOk.Text = "Ok"
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(117, 187)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 2
        Me.CmdExit.Text = "Exit"
        '
        'Pb1
        '
        Me.Pb1.Location = New System.Drawing.Point(207, 187)
        Me.Pb1.Name = "Pb1"
        Me.Pb1.Size = New System.Drawing.Size(529, 23)
        Me.Pb1.TabIndex = 11
        Me.Pb1.Visible = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_journal_head.id_GL_journal, GL_journal_head.GL_journal_date, GL_journal" & _
        "_head.GL_journal_reference, GL_journal_head.GL_journal_type_code, GL_journal_hea" & _
        "d.GL_picture, GL_journal_dtl.radif, GL_journal_dtl.GL_account, GL_journal_dtl.GL" & _
        "_journal_amount_debit, GL_journal_dtl.GL_journal_amount_credit, GL_account.desc_" & _
        "GL_account FROM GL_journal_head INNER JOIN GL_journal_dtl ON GL_journal_head.id_" & _
        "GL_journal = GL_journal_dtl.id_GL_journal INNER JOIN GL_account ON GL_journal_dt" & _
        "l.GL_account = GL_account.GL_account WHERE (GL_account.GL_account >= @FromGl) AN" & _
        "D (GL_account.GL_account <= @ToGl) AND (SUBSTRING(GL_journal_head.GL_journal_dat" & _
        "e, 7, 4) + '/' + SUBSTRING(GL_journal_head.GL_journal_date, 1, 2) + '/' + SUBSTR" & _
        "ING(GL_journal_head.GL_journal_date, 4, 2) >= @FromDate) AND (SUBSTRING(GL_journ" & _
        "al_head.GL_journal_date, 7, 4) + '/' + SUBSTRING(GL_journal_head.GL_journal_date" & _
        ", 1, 2) + '/' + SUBSTRING(GL_journal_head.GL_journal_date, 4, 2) <= @ToDate) ORD" & _
        "ER BY GL_journal_head.GL_journal_date, GL_journal_head.id_GL_journal, GL_journal" & _
        "_dtl.radif"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromGl", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToGl", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaGeneralJournal
        '
        Me.DaGeneralJournal.SelectCommand = Me.SqlSelectCommand1
        Me.DaGeneralJournal.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GeneralJournal", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("GL_journal_date", "GL_journal_date"), New System.Data.Common.DataColumnMapping("GL_journal_reference", "GL_journal_reference"), New System.Data.Common.DataColumnMapping("GL_journal_type_code", "GL_journal_type_code"), New System.Data.Common.DataColumnMapping("GL_picture", "GL_picture"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("GL_journal_amount_debit", "GL_journal_amount_debit"), New System.Data.Common.DataColumnMapping("GL_journal_amount_credit", "GL_journal_amount_credit"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account")})})
        '
        'DsFrmJournal1
        '
        Me.DsFrmJournal1.DataSetName = "DSFrmJournal"
        Me.DsFrmJournal1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.DataMember = "GeneralJournal"
        Me.GridEX1.DataSource = Me.DsFrmJournal1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GeneralJournal</Caption><Columns Collection" & _
        "=""true""><Column0 ID=""Column1""><EditButtonDisplayMode>Always</EditButtonDisplayMo" & _
        "de><Bound>False</Bound><ButtonStyle>ButtonCell</ButtonStyle><ColumnType>Link</Co" & _
        "lumnType><EditType>Custom</EditType><Key>Column1</Key><Position>0</Position><Wid" & _
        "th>20</Width></Column0><Column1 ID=""id_GL_journal""><Caption>id_GL_journal</Capti" & _
        "on><TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue />" & _
        "<DataMember>id_GL_journal</DataMember><EditType>NoEdit</EditType><Key>id_GL_jour" & _
        "nal</Key><Position>1</Position><Visible>False</Visible></Column1><Column2 ID=""GL" & _
        "_journal_date""><Caption>Date</Caption><DataMember>GL_journal_date</DataMember><K" & _
        "ey>GL_journal_date</Key><Position>2</Position><Width>69</Width></Column2><Column" & _
        "3 ID=""GL_journal_reference""><Caption>Reference</Caption><DataMember>GL_journal_r" & _
        "eference</DataMember><Key>GL_journal_reference</Key><Position>3</Position><Width" & _
        ">97</Width></Column3><Column4 ID=""GL_account""><Caption>Account</Caption><DataMem" & _
        "ber>GL_account</DataMember><Key>GL_account</Key><Position>4</Position><Width>77<" & _
        "/Width></Column4><Column5 ID=""desc_GL_account""><Caption>Account Name</Caption><D" & _
        "ataMember>desc_GL_account</DataMember><Key>desc_GL_account</Key><Position>5</Pos" & _
        "ition></Column5><Column6 ID=""GL_journal_amount_debit""><Caption>Debit</Caption><D" & _
        "ataMember>GL_journal_amount_debit</DataMember><FormatString>c</FormatString><Key" & _
        ">GL_journal_amount_debit</Key><Position>6</Position><TextAlignment>Far</TextAlig" & _
        "nment><Width>97</Width></Column6><Column7 ID=""GL_journal_amount_credit""><Caption" & _
        ">Credit</Caption><DataMember>GL_journal_amount_credit</DataMember><FormatString>" & _
        "c</FormatString><Key>GL_journal_amount_credit</Key><Position>7</Position><TextAl" & _
        "ignment>Far</TextAlignment></Column7><Column8 ID=""SumBes""><Caption>Debit</Captio" & _
        "n><DataMember>SumBes</DataMember><FormatString>c</FormatString><Key>SumBes</Key>" & _
        "<Position>8</Position><Width>91</Width></Column8><Column9 ID=""SumBed""><Caption>C" & _
        "redit</Caption><DataMember>SumBed</DataMember><FormatString>c</FormatString><Key" & _
        ">SumBed</Key><Position>9</Position><Width>94</Width></Column9></Columns><GroupCo" & _
        "ndition ID="""" /><Key>GeneralJournal</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.Location = New System.Drawing.Point(4, 229)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(756, 208)
        Me.GridEX1.TabIndex = 12
        '
        'FrmGeneralJournal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(758, 444)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.Pb1)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmGeneralJournal"
        Me.Text = "General Journal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmJournal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmGeneralJournal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        If DateTo.Text = "" Then DateTo.Text = Format(Now, PubDateFormat)
        If DateFrom.Text = "" Then DateFrom.Text = Format(Now.AddMonths(-1), PubDateFormat)
        LblFrom.Text = GlAccount1.Desc_Gl
        LblTo.Text = GlAccount2.Desc_Gl
    End Sub
    Private Sub GlAccount1_FindGlCod() Handles GlAccount1.FindGlCod
        LblFrom.Text = GlAccount1.Desc_Gl
    End Sub
    Private Sub GlAccount2_FindGlCod() Handles GlAccount2.FindGlCod
        LblTo.Text = GlAccount2.Desc_Gl
    End Sub
    Private Sub GlAccount1_NotFindGlCod() Handles GlAccount1.NotFindGlCod
        LblFrom.Text = ""
    End Sub
    Private Sub GlAccount2_NotFindGlCod() Handles GlAccount2.NotFindGlCod
        LblTo.Text = ""
    End Sub
    Private Sub GlAccount1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GlAccount1.TextChanged, GlAccount2.TextChanged, DateTo.TextChanged, DateFrom.TextChanged
        Call EnableDisableField()
    End Sub
    Sub EnableDisableField()
        If GlAccount1.Cod_Gl.Trim & "" <> "" And GlAccount2.Cod_Gl.Trim & "" <> "" And DateFrom.Text.Trim & "" <> "" And DateTo.Text.Trim & "" <> "" Then
            CmdOk.Enabled = True
        Else
            CmdOk.Enabled = False
        End If
        If GlAccount1.Cod_Gl.Trim & "" = "" Then
            LblFrom.Text = ""
        End If
        If GlAccount2.Cod_Gl.Trim & "" = "" Then
            LblTo.Text = ""
        End If
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Call CalCulate()
    End Sub
    Private Sub GridEX1_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridEX1.ColumnButtonClick
        If GridEX1.GetRow.Cells(1).Value <> 0 Then
            Dim MyFrm As New UcAccount.FrmJournal
            MyFrm.LoadThis = GridEX1.GetRow.Cells(1).Value
            MyFrm.ShowDialog()
        End If
    End Sub

    Private Sub GridEX1_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridEX1.FormattingRow

    End Sub
    Public Sub Calculate()
        DaGeneralJournal.SelectCommand.Parameters("@FromGl").Value = GlAccount1.Cod_Gl
        DaGeneralJournal.SelectCommand.Parameters("@ToGl").Value = GlAccount2.Cod_Gl
        DaGeneralJournal.SelectCommand.Parameters("@FromDate").Value = DateFrom.Text.Substring(6, 4) + "/" + DateFrom.Text.Substring(0, 2) + "/" + DateFrom.Text.Substring(3, 2)
        DaGeneralJournal.SelectCommand.Parameters("@ToDate").Value = DateTo.Text.Substring(6, 4) + "/" + DateTo.Text.Substring(0, 2) + "/" + DateTo.Text.Substring(3, 2)
        Try
            DsFrmJournal1.GeneralJournal.Clear()
            DaGeneralJournal.Fill(DsFrmJournal1.GeneralJournal)
            Dim Reminder As Decimal = 0
            Dim i As Integer = 0
            If DsFrmJournal1.GeneralJournal.Rows.Count > 0 Then
                With DsFrmJournal1.GeneralJournal
                    For i = 0 To .Rows.Count - 1
                        Reminder = CDec("0" & .Rows(i).Item("GL_journal_amount_debit")) - CDec("0" & .Rows(i).Item("GL_journal_amount_Credit")) + Reminder
                        If Reminder < 0 Then
                            DsFrmJournal1.GeneralJournal.Rows(i).Item("SumBed") = Reminder * -1
                            Reminder = Reminder * -1
                        Else
                            DsFrmJournal1.GeneralJournal.Rows(i).Item("SumBes") = Reminder
                        End If
                    Next


                End With

            Else
                MsgFar(" No Transaction Found ")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
End Class
