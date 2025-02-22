Imports CommonClass
Public Class FrmSearchReferenceNo
    Inherits FrmBase
    Event ReceivePaymentFind(ByVal ThisReferenceNo As String, ByVal ThisVendorCod As String)
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
    Friend WithEvents DsFrmSearchReferenceNo1 As DSFrmSearchReferenceNo
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_AP_Bill_Head As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.Connection = New System.Data.SqlClient.SqlConnection
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmSearchReferenceNo1 = New UCVendor.DSFrmSearchReferenceNo
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_AP_Bill_Head = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchReferenceNo1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Connection.ConnectionString = "workstation id=ARMANDEH3;packet size=4096;user id=sa;data source=armandehxp;persi" & _
        "st security info=True;initial catalog=TireMate_01"
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
        Me.GrdDetail.DataMember = "GL_AP_Bill_Head"
        Me.GrdDetail.DataSource = Me.DsFrmSearchReferenceNo1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_AP_Bill_Head</Caption><Columns Collectio" & _
        "n=""true""><Column0 ID=""Id_AP_bill_Head""><Caption>Ref. No</Caption><TypeNameEmptyS" & _
        "tringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMemb" & _
        "er>Id_AP_bill_Head</DataMember><Key>Id_AP_bill_Head</Key><Position>0</Position><" & _
        "Width>90</Width></Column0><Column1 ID=""Date_Bill""><Caption>Date</Caption><DataMe" & _
        "mber>Date_Bill</DataMember><Key>Date_Bill</Key><Position>1</Position><Width>79</" & _
        "Width></Column1><Column2 ID=""cod_vendor""><Caption>Vendor Code</Caption><TypeName" & _
        "EmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><Da" & _
        "taMember>cod_vendor</DataMember><Key>cod_vendor</Key><Position>2</Position></Col" & _
        "umn2><Column3 ID=""desc_vendor""><Caption>Name</Caption><DataMember>desc_vendor</D" & _
        "ataMember><Key>desc_vendor</Key><Position>3</Position><Width>255</Width></Column" & _
        "3></Columns><GroupCondition ID="""" /><Key>GL_AP_Bill_Head</Key></RootTable></Grid" & _
        "EXLayoutData>"
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
        Me.GrdDetail.Size = New System.Drawing.Size(575, 273)
        Me.GrdDetail.TabIndex = 20
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DsFrmSearchReferenceNo1
        '
        Me.DsFrmSearchReferenceNo1.DataSetName = "DSFrmSearchReferenceNo"
        Me.DsFrmSearchReferenceNo1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT GL_AP_Bill_Head.Id_AP_bill_Head, GL_AP_Bill_Head.cod_vendor, GL_AP_Bill_He" & _
        "ad.Date_Bill, inv_vendor.desc_vendor FROM GL_AP_Bill_Head INNER JOIN inv_vendor " & _
        "ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor"
        Me.SqlSelectCommand2.Connection = Me.Connection
        '
        'DAGL_AP_Bill_Head
        '
        Me.DAGL_AP_Bill_Head.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_AP_Bill_Head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_Bill_Head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_AP_bill_Head", "Id_AP_bill_Head"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("Date_Bill", "Date_Bill")})})
        '
        'FrmSearchReferenceNo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(575, 310)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdOk)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "FrmSearchReferenceNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Vendor Bills"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchReferenceNo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSearchReferenceNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connection.ConnectionString = PConnectionString
        DsFrmSearchReferenceNo1.Clear()
        DAGL_AP_Bill_Head.Fill(DsFrmSearchReferenceNo1, "GL_AP_Bill_Head")
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent ReceivePaymentFind(GrdDetail.GetRow.Cells(0).Value & "", GrdDetail.GetRow.Cells(2).Value & "")
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Call GrdDetail_DoubleClick(sender, e)
        Me.Close()
    End Sub
End Class
