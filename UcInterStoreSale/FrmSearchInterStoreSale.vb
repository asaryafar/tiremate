Public Class FrmSearchInterStoreSale
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
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Dainv_salse_transfer_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmSearchInterStoreSales1 As UcInterStoreSale.DSFrmSearchInterStoreSales
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmSearchInterStoreSales1 = New UcInterStoreSale.DSFrmSearchInterStoreSales
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Dainv_salse_transfer_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchInterStoreSales1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "inv_salse_transfer_head"
        Me.GrdDetail.DataSource = Me.DsFrmSearchInterStoreSales1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>inv_salse_transfer_head</Caption><Columns C" & _
        "ollection=""true""><Column0 ID=""ID_sales_transfer""><Caption>Ref No</Caption><TypeN" & _
        "ameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue />" & _
        "<DataMember>ID_sales_transfer</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><Key>ID_sales_transfer</Key><Position>0</Position><" & _
        "Width>96</Width></Column0><Column1 ID=""type_sales_transfer""><Caption>type_sales_" & _
        "transfer</Caption><TypeNameEmptyStringValue>System.String</TypeNameEmptyStringVa" & _
        "lue><EmptyStringValue /><DataMember>type_sales_transfer</DataMember><Key>type_sa" & _
        "les_transfer</Key><Position>1</Position><Visible>False</Visible></Column1><Colum" & _
        "n2 ID=""store_from""><Caption>From</Caption><DataMember>store_from</DataMember><Ed" & _
        "itType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>store_from<" & _
        "/Key><Position>2</Position><Width>82</Width></Column2><Column3 ID=""store_to""><Ca" & _
        "ption>To</Caption><DataMember>store_to</DataMember><EditType>NoEdit</EditType><F" & _
        "ilterEditType>TextBox</FilterEditType><Key>store_to</Key><Position>3</Position><" & _
        "Width>80</Width></Column3><Column4 ID=""note""><Caption>Note</Caption><DataMember>" & _
        "note</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditT" & _
        "ype><Key>note</Key><Position>4</Position></Column4><Column5 ID=""excost""><Caption" & _
        ">Amount</Caption><DataMember>excost</DataMember><EditType>NoEdit</EditType><Filt" & _
        "erEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>excost</K" & _
        "ey><Position>5</Position><TextAlignment>Far</TextAlignment></Column5><Column6 ID" & _
        "=""qty""><Caption>Qty</Caption><DataMember>qty</DataMember><EditType>NoEdit</EditT" & _
        "ype><FilterEditType>TextBox</FilterEditType><FormatString>c</FormatString><Key>q" & _
        "ty</Key><Position>6</Position><TextAlignment>Far</TextAlignment><Width>63</Width" & _
        "></Column6><Column7 ID=""date_action""><Caption>Date</Caption><DataMember>date_act" & _
        "ion</DataMember><Key>date_action</Key><Position>7</Position><Width>93</Width></C" & _
        "olumn7></Columns><GroupCondition ID="""" /><Key>inv_salse_transfer_head</Key></Roo" & _
        "tTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, -5)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(670, 368)
        Me.GrdDetail.TabIndex = 22
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DsFrmSearchInterStoreSales1
        '
        Me.DsFrmSearchInterStoreSales1.DataSetName = "DSFrmSearchInterStoreSales"
        Me.DsFrmSearchInterStoreSales1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CmdOk)
        Me.Panel2.Controls.Add(Me.CmdExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 363)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(670, 33)
        Me.Panel2.TabIndex = 23
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdOk.ForeColor = System.Drawing.Color.Black
        Me.CmdOk.Location = New System.Drawing.Point(488, 5)
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
        Me.CmdExit.Location = New System.Drawing.Point(584, 5)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJI;packet size=4096;user id=sa;data source=""."";persist securit" & _
        "y info=True;initial catalog=TireMate_05;password=5332"
        '
        'Dainv_salse_transfer_head
        '
        Me.Dainv_salse_transfer_head.SelectCommand = Me.SqlSelectCommand2
        Me.Dainv_salse_transfer_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_salse_transfer_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_sales_transfer", "ID_sales_transfer"), New System.Data.Common.DataColumnMapping("type_sales_transfer", "type_sales_transfer"), New System.Data.Common.DataColumnMapping("by_action", "by_action"), New System.Data.Common.DataColumnMapping("authoriz_action", "authoriz_action"), New System.Data.Common.DataColumnMapping("store_from", "store_from"), New System.Data.Common.DataColumnMapping("store_to", "store_to"), New System.Data.Common.DataColumnMapping("date_action", "date_action"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("comment", "comment")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT inv_salse_transfer_head.ID_sales_transfer, inv_salse_transfer_head.type_sa" & _
        "les_transfer, inv_salse_transfer_head.by_action, inv_salse_transfer_head.authori" & _
        "z_action, inv_salse_transfer_head.store_from, inv_salse_transfer_head.store_to, " & _
        "inv_salse_transfer_head.date_action, inv_salse_transfer_head.note, inv_salse_tra" & _
        "nsfer_head.comment, SUM(inv_sales_transfer_dtl.qty) AS qty, SUM(inv_sales_transf" & _
        "er_dtl.qty * (inv_sales_transfer_dtl.fet + inv_sales_transfer_dtl.price)) AS exc" & _
        "ost FROM inv_salse_transfer_head INNER JOIN inv_sales_transfer_dtl ON inv_salse_" & _
        "transfer_head.ID_sales_transfer = inv_sales_transfer_dtl.ID_sales_transfer WHERE" & _
        " (inv_salse_transfer_head.type_sales_transfer = @type_sales_transfer) GROUP BY i" & _
        "nv_salse_transfer_head.ID_sales_transfer, inv_salse_transfer_head.type_sales_tra" & _
        "nsfer, inv_salse_transfer_head.by_action, inv_salse_transfer_head.authoriz_actio" & _
        "n, inv_salse_transfer_head.store_from, inv_salse_transfer_head.store_to, inv_sal" & _
        "se_transfer_head.date_action, inv_salse_transfer_head.note, inv_salse_transfer_h" & _
        "ead.comment"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_sales_transfer", System.Data.SqlDbType.VarChar, 1, "type_sales_transfer"))
        '
        'FrmSearchInterStoreSale
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(670, 396)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSearchInterStoreSale"
        Me.Text = "Find Inter Store Sales"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchInterStoreSales1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public TypeOfForm As String = "1"
    Public Event InterStoreSalesFind(ByVal ThisId As String)
    Private Sub FrmSearchInterStoreSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = CommonClass.PConnectionString
        Dainv_salse_transfer_head.SelectCommand.Parameters(0).Value = TypeOfForm
        Dainv_salse_transfer_head.Fill(DsFrmSearchInterStoreSales1)
        Select Case TypeOfForm
            Case "1"
            Case "2"
                Me.Text = "Find Inventory Transfer "
        End Select
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent InterStoreSalesFind(GrdDetail.GetRow.Cells(0).Value & "")
                Me.Close()
            End If
        Catch ex As Exception
        End Try

    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent InterStoreSalesFind(GrdDetail.GetRow.Cells(0).Value & "")
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
End Class
