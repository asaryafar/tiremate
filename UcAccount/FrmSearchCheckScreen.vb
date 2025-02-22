Imports CommonClass
Public Class FrmSearchCheckScreen
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
    Friend WithEvents Dabank_check As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmSearchCheckScreen1 As UcAccount.DSFrmSearchCheckScreen
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Dabank_check = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DsFrmSearchCheckScreen1 = New UcAccount.DSFrmSearchCheckScreen
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        CType(Me.DsFrmSearchCheckScreen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dabank_check
        '
        Me.Dabank_check.SelectCommand = Me.SqlSelectCommand3
        Me.Dabank_check.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_check", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("no_of_check", "no_of_check"), New System.Data.Common.DataColumnMapping("date_of_check", "date_of_check"), New System.Data.Common.DataColumnMapping("amount_check", "amount_check"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("address_payee", "address_payee"), New System.Data.Common.DataColumnMapping("memo_check", "memo_check"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("manual_check", "manual_check"), New System.Data.Common.DataColumnMapping("print_later", "print_later"), New System.Data.Common.DataColumnMapping("cleared_bank", "cleared_bank"), New System.Data.Common.DataColumnMapping("check_status", "check_status"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT bank_check.id_check, bank_check.id_bank, bank_check.no_of_check, bank_chec" & _
        "k.date_of_check, bank_check.amount_check, bank_check.cod_vendor, bank_check.empl" & _
        "oyee_code, bank_check.address_payee, bank_check.memo_check, bank_check.invoice_n" & _
        "o, bank_check.manual_check, bank_check.print_later, bank_check.cleared_bank, ban" & _
        "k_check.id_debit_deposit_head, inv_vendor.desc_vendor, CASE bank_check.check_sta" & _
        "tus WHEN 0 THEN 'active' WHEN 1 THEN 'void ' WHEN 2 THEN 'delete ' WHEN 3 THEN '" & _
        "return ' END AS check_status, employee.l_name + ',' + employee.f_name AS Emplyee" & _
        "Name, bas_banks.name_bank FROM bank_check INNER JOIN bas_banks ON bank_check.id_" & _
        "bank = bas_banks.id_bank LEFT OUTER JOIN employee ON bank_check.employee_code = " & _
        "employee.employee_code LEFT OUTER JOIN inv_vendor ON bank_check.cod_vendor = inv" & _
        "_vendor.cod_vendor"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;p" & _
        "ersist security info=True;password=sa"
        '
        'DsFrmSearchCheckScreen1
        '
        Me.DsFrmSearchCheckScreen1.DataSetName = "DSFrmSearchCheckScreen"
        Me.DsFrmSearchCheckScreen1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "bank_check"
        Me.GrdDetail.DataSource = Me.DsFrmSearchCheckScreen1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>bank_check</Caption><Columns Collection=""tr" & _
        "ue""><Column0 ID=""id_check""><Caption>id_check</Caption><TypeNameEmptyStringValue>" & _
        "NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>id_check</DataMem" & _
        "ber><EditType>NoEdit</EditType><Key>id_check</Key><Position>0</Position><Visible" & _
        ">False</Visible></Column0><Column1 ID=""id_bank""><Caption>id_bank</Caption><DataM" & _
        "ember>id_bank</DataMember><Key>id_bank</Key><Position>1</Position><Visible>False" & _
        "</Visible></Column1><Column2 ID=""no_of_check""><Caption>Check No</Caption><DataMe" & _
        "mber>no_of_check</DataMember><Key>no_of_check</Key><Position>2</Position><Width>" & _
        "85</Width></Column2><Column3 ID=""name_bank""><Caption>Bank Name</Caption><DataMem" & _
        "ber>name_bank</DataMember><Key>name_bank</Key><Position>3</Position><Width>118</" & _
        "Width></Column3><Column4 ID=""desc_vendor""><Caption>Paid To</Caption><DataMember>" & _
        "desc_vendor</DataMember><Key>desc_vendor</Key><Position>4</Position><Width>143</" & _
        "Width></Column4><Column5 ID=""EmplyeeName""><Caption>Emplyee Name</Caption><DataMe" & _
        "mber>EmplyeeName</DataMember><Key>EmplyeeName</Key><Position>5</Position><Width>" & _
        "151</Width></Column5><Column6 ID=""date_of_check""><Caption>Date</Caption><DataMem" & _
        "ber>date_of_check</DataMember><Key>date_of_check</Key><Position>6</Position><Wid" & _
        "th>76</Width></Column6><Column7 ID=""amount_check""><Caption>Amount</Caption><Data" & _
        "Member>amount_check</DataMember><FormatString>c2</FormatString><Key>amount_check" & _
        "</Key><Position>7</Position><TextAlignment>Far</TextAlignment></Column7><Column8" & _
        " ID=""memo_check""><Caption>Memo</Caption><DataMember>memo_check</DataMember><Key>" & _
        "memo_check</Key><Position>8</Position><Width>89</Width></Column8><Column9 ID=""co" & _
        "d_vendor""><Caption>cod_vendor</Caption><DataMember>cod_vendor</DataMember><Key>c" & _
        "od_vendor</Key><Position>9</Position><Visible>False</Visible></Column9><Column10" & _
        " ID=""employee_code""><Caption>employee_code</Caption><DataMember>employee_code</D" & _
        "ataMember><Key>employee_code</Key><Position>10</Position><Visible>False</Visible" & _
        "></Column10><Column11 ID=""address_payee""><Caption>address_payee</Caption><DataMe" & _
        "mber>address_payee</DataMember><Key>address_payee</Key><Position>11</Position><V" & _
        "isible>False</Visible></Column11><Column12 ID=""invoice_no""><Caption>invoice_no</" & _
        "Caption><DataMember>invoice_no</DataMember><Key>invoice_no</Key><Position>12</Po" & _
        "sition><Visible>False</Visible></Column12><Column13 ID=""manual_check""><Caption>m" & _
        "anual_check</Caption><ColumnType>CheckBox</ColumnType><DataMember>manual_check</" & _
        "DataMember><EditType>CheckBox</EditType><Key>manual_check</Key><Position>13</Pos" & _
        "ition><Visible>False</Visible></Column13><Column14 ID=""print_later""><Caption>pri" & _
        "nt_later</Caption><ColumnType>CheckBox</ColumnType><DataMember>print_later</Data" & _
        "Member><EditType>CheckBox</EditType><Key>print_later</Key><Position>14</Position" & _
        "><Visible>False</Visible></Column14><Column15 ID=""cleared_bank""><Caption>cleared" & _
        "_bank</Caption><ColumnType>CheckBox</ColumnType><DataMember>cleared_bank</DataMe" & _
        "mber><EditType>CheckBox</EditType><Key>cleared_bank</Key><Position>15</Position>" & _
        "<Visible>False</Visible></Column15><Column16 ID=""id_debit_deposit_head""><Caption" & _
        ">id_debit_deposit_head</Caption><DataMember>id_debit_deposit_head</DataMember><K" & _
        "ey>id_debit_deposit_head</Key><Position>16</Position><Visible>False</Visible></C" & _
        "olumn16><Column17 ID=""check_status""><Caption>Status</Caption><DataMember>check_s" & _
        "tatus</DataMember><EditType>NoEdit</EditType><Key>check_status</Key><Position>17" & _
        "</Position><Width>72</Width></Column17></Columns><GroupCondition ID="""" /><Key>ba" & _
        "nk_check</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
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
        Me.GrdDetail.Size = New System.Drawing.Size(888, 320)
        Me.GrdDetail.TabIndex = 24
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CmdOk)
        Me.Panel2.Controls.Add(Me.CmdExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 331)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(886, 33)
        Me.Panel2.TabIndex = 25
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdOk.ForeColor = System.Drawing.Color.Black
        Me.CmdOk.Location = New System.Drawing.Point(704, 5)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 24)
        Me.CmdOk.TabIndex = 22
        Me.CmdOk.Text = "Ok"
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdExit.ForeColor = System.Drawing.Color.Black
        Me.CmdExit.Location = New System.Drawing.Point(800, 5)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        '
        'FrmSearchCheckScreen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(886, 364)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GrdDetail)
        Me.Name = "FrmSearchCheckScreen"
        Me.Text = "Search Check"
        CType(Me.DsFrmSearchCheckScreen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Event FindThisCeck(ByVal idcheck As Decimal)
    Private Sub FrmSearchCheckScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        DsFrmSearchCheckScreen1.Clear()
        Dabank_check.Fill(DsFrmSearchCheckScreen1)
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If GrdDetail.RowCount >= 1 Then
            If GrdDetail.GetRow().Cells(0).Value & "" <> "" Then
                RaiseEvent FindThisCeck(GrdDetail.GetRow().Cells(0).Value)
                Me.Close()
            End If
        End If
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
End Class
