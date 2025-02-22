Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmSearchReferenceNoVendorCredit
    Inherits FrmBase
    Event VendorCreditFind(ByVal ThisReferenceNo As String, ByVal ThisVendorCod As String)
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
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents Connection As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents DAGL_vendor_credit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmSearchReferenceNoVendorCredit1 As UCVendor.DSFrmSearchReferenceNoVendorCredit
    Friend WithEvents ChkUnApplied As System.Windows.Forms.CheckBox
    Friend WithEvents ChkApplied As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.Connection = New System.Data.SqlClient.SqlConnection
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmSearchReferenceNoVendorCredit1 = New UCVendor.DSFrmSearchReferenceNoVendorCredit
        Me.DAGL_vendor_credit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.ChkUnApplied = New System.Windows.Forms.CheckBox
        Me.ChkApplied = New System.Windows.Forms.CheckBox
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchReferenceNoVendorCredit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(108, 281)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 16
        Me.CmdOk.Text = "Ok"
        '
        'Connection
        '
        Me.Connection.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=""."";persist security " & _
        "info=True;initial catalog=Tiremate_01;password=2191110"
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(11, 281)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 19
        Me.CmdExit.Text = "Exit"
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "GL_vendor_credit"
        Me.GrdDetail.DataSource = Me.DsFrmSearchReferenceNoVendorCredit1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_vendor_credit</Caption><Columns Collecti" & _
        "on=""true""><Column0 ID=""ref_no""><Caption>Vendor Ref</Caption><DataMember>ref_no</" & _
        "DataMember><Key>ref_no</Key><Position>0</Position><Width>96</Width></Column0><Co" & _
        "lumn1 ID=""cod_vendor""><Caption>Vendor</Caption><TypeNameEmptyStringValue>System." & _
        "String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>cod_vendor</Dat" & _
        "aMember><Key>cod_vendor</Key><Position>1</Position><Width>54</Width></Column1><C" & _
        "olumn2 ID=""desc_vendor""><Caption>Vendor Name</Caption><DataMember>desc_vendor</D" & _
        "ataMember><Key>desc_vendor</Key><Position>2</Position><Width>166</Width></Column" & _
        "2><Column3 ID=""date_credit""><Caption>Date</Caption><DataMember>date_credit</Data" & _
        "Member><Key>date_credit</Key><Position>3</Position><Width>80</Width></Column3><C" & _
        "olumn4 ID=""amount_credit""><Caption>Amount</Caption><DataMember>amount_credit</Da" & _
        "taMember><FormatString>c</FormatString><Key>amount_credit</Key><Position>4</Posi" & _
        "tion><TextAlignment>Far</TextAlignment><Width>88</Width></Column4><Column5 ID=""d" & _
        "ue_date""><Caption>Due Date</Caption><DataMember>due_date</DataMember><Key>due_da" & _
        "te</Key><Position>5</Position><Width>79</Width></Column5><Column6 ID=""id_vendor_" & _
        "credit""><Caption>Ref. No</Caption><TypeNameEmptyStringValue>NULL</TypeNameEmptyS" & _
        "tringValue><EmptyStringValue /><DataMember>id_vendor_credit</DataMember><EditTyp" & _
        "e>NoEdit</EditType><Key>id_vendor_credit</Key><Position>6</Position><Width>73</W" & _
        "idth></Column6><Column7 ID=""Remark""><Caption>Remark</Caption><DataMember>Remark<" & _
        "/DataMember><Key>Remark</Key><Position>7</Position><Width>125</Width></Column7><" & _
        "Column8 ID=""id_vendor_credit_head""><Caption>id_vendor_credit_head</Caption><Data" & _
        "Member>id_vendor_credit_head</DataMember><Key>id_vendor_credit_head</Key><Positi" & _
        "on>8</Position><Visible>False</Visible></Column8></Columns><GroupCondition ID=""""" & _
        " /><Key>GL_vendor_credit</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 0)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(642, 273)
        Me.GrdDetail.TabIndex = 20
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DsFrmSearchReferenceNoVendorCredit1
        '
        Me.DsFrmSearchReferenceNoVendorCredit1.DataSetName = "DSFrmSearchReferenceNoVendorCredit"
        Me.DsFrmSearchReferenceNoVendorCredit1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DAGL_vendor_credit
        '
        Me.DAGL_vendor_credit.SelectCommand = Me.SqlCommand1
        Me.DAGL_vendor_credit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_vendor_credit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_vendor_credit", "id_vendor_credit"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("date_credit", "date_credit"), New System.Data.Common.DataColumnMapping("amount_credit", "amount_credit"), New System.Data.Common.DataColumnMapping("Remark", "Remark")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT GL_vendor_credit.id_vendor_credit, GL_vendor_credit.cod_vendor, GL_vendor_" & _
        "credit.date_credit, GL_vendor_credit.amount_credit, GL_vendor_credit.Remark, inv" & _
        "_vendor.desc_vendor, GL_vendor_credit.ref_no, GL_vendor_credit.due_date, ISNULL(" & _
        "GL_vendor_credit.id_vendor_credit_head, 0) AS id_vendor_credit_head FROM GL_vend" & _
        "or_credit INNER JOIN inv_vendor ON GL_vendor_credit.cod_vendor = inv_vendor.cod_" & _
        "vendor"
        Me.SqlCommand1.Connection = Me.Connection
        '
        'ChkUnApplied
        '
        Me.ChkUnApplied.BackColor = System.Drawing.Color.LightBlue
        Me.ChkUnApplied.Checked = True
        Me.ChkUnApplied.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkUnApplied.Location = New System.Drawing.Point(467, 282)
        Me.ChkUnApplied.Name = "ChkUnApplied"
        Me.ChkUnApplied.Size = New System.Drawing.Size(95, 20)
        Me.ChkUnApplied.TabIndex = 349
        Me.ChkUnApplied.Text = "Un-Applied"
        '
        'ChkApplied
        '
        Me.ChkApplied.BackColor = System.Drawing.Color.Pink
        Me.ChkApplied.Checked = True
        Me.ChkApplied.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkApplied.Location = New System.Drawing.Point(289, 282)
        Me.ChkApplied.Name = "ChkApplied"
        Me.ChkApplied.Size = New System.Drawing.Size(95, 20)
        Me.ChkApplied.TabIndex = 350
        Me.ChkApplied.Text = "Applied"
        '
        'FrmSearchReferenceNoVendorCredit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(642, 310)
        Me.Controls.Add(Me.ChkApplied)
        Me.Controls.Add(Me.ChkUnApplied)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdOk)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "FrmSearchReferenceNoVendorCredit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Vendor Credit"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchReferenceNoVendorCredit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSearchReferenceNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connection.ConnectionString = PConnectionString

        Call AddConditionalFormatting()

        Call FillData()
    End Sub
    Private Sub FillData()
        DsFrmSearchReferenceNoVendorCredit1.Clear()
        DAGL_vendor_credit.SelectCommand.CommandText = "SELECT  GL_vendor_credit.id_vendor_credit, GL_vendor_credit.cod_vendor, GL_vendor_credit.date_credit, GL_vendor_credit.amount_credit, " & _
                      " GL_vendor_credit.Remark, inv_vendor.desc_vendor, GL_vendor_credit.ref_no, GL_vendor_credit.due_date, " & _
                      " ISNULL(GL_vendor_credit.id_vendor_credit_head, 0) AS id_vendor_credit_head FROM  GL_vendor_credit INNER JOIN " & _
                      " inv_vendor ON GL_vendor_credit.cod_vendor = inv_vendor.cod_vendor Where 1=1 "
        If Not ChkApplied.Checked Then
            DAGL_vendor_credit.SelectCommand.CommandText = DAGL_vendor_credit.SelectCommand.CommandText & " AND id_vendor_credit_head=0 OR id_vendor_credit_head is null"
        End If
        If Not ChkUnApplied.Checked Then
            DAGL_vendor_credit.SelectCommand.CommandText = DAGL_vendor_credit.SelectCommand.CommandText & " AND id_vendor_credit_head<>0 "
        End If
        Try
            DAGL_vendor_credit.Fill(DsFrmSearchReferenceNoVendorCredit1, "GL_vendor_credit")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub AddConditionalFormatting()
        Dim fc As GridEXFormatCondition
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("id_vendor_credit_head"), ConditionOperator.NotEqual, 0)
        fc.FormatStyle.BackColor = Color.Pink
        GrdDetail.RootTable.FormatConditions.Add(fc)
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("id_vendor_credit_head"), ConditionOperator.Equal, 0)
        fc.FormatStyle.BackColor = Color.LightBlue
        GrdDetail.RootTable.FormatConditions.Add(fc)
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent VendorCreditFind(GrdDetail.GetRow.Cells("id_vendor_credit").Value & "", GrdDetail.GetRow.Cells(2).Value & "")
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Call GrdDetail_DoubleClick(sender, e)
        Me.Close()
    End Sub
    Private Sub ChkApplied_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkApplied.CheckedChanged, ChkUnApplied.CheckedChanged
        Call FillData()
    End Sub
End Class
