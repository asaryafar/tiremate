Imports CommonClass
Public Class FrmSearchSize
    Inherits FrmBase
    Event SizeFind(ByVal ThisMake As String, ByVal ThisModel As String, ByVal ThisYear As String, ByVal ThisOption As String, ByVal ThisMainSize As String, ByVal ThisOptionSize As String)
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
    Friend WithEvents TxtOption As System.Windows.Forms.TextBox
    Friend WithEvents TxtMainSize As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbas_vehicle_size As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmSearchSize1 As UCInv_Item.DSFrmSearchSize
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSearchSize))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnFind = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtOption = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtMainSize = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.DsFrmSearchSize1 = New UCInv_Item.DSFrmSearchSize
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_vehicle_size = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchSize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnFind)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtOption)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtMainSize)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 62)
        Me.Panel1.TabIndex = 1
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(574, 11)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 346
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
        'TxtOption
        '
        Me.TxtOption.Location = New System.Drawing.Point(76, 36)
        Me.TxtOption.MaxLength = 20
        Me.TxtOption.Name = "TxtOption"
        Me.TxtOption.Size = New System.Drawing.Size(245, 20)
        Me.TxtOption.TabIndex = 3
        Me.TxtOption.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(5, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 22)
        Me.Label1.TabIndex = 334
        Me.Label1.Text = "Option Size"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtMainSize
        '
        Me.TxtMainSize.Location = New System.Drawing.Point(76, 7)
        Me.TxtMainSize.MaxLength = 20
        Me.TxtMainSize.Name = "TxtMainSize"
        Me.TxtMainSize.Size = New System.Drawing.Size(245, 20)
        Me.TxtMainSize.TabIndex = 0
        Me.TxtMainSize.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.YellowGreen
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(5, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 22)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "Main Size"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataSource = Me.DataView1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>bas_vehicle_size</Caption><Columns Collecti" & _
        "on=""true""><Column0 ID=""cod_make""><Caption>cod_make</Caption><TypeNameEmptyString" & _
        "Value>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>co" & _
        "d_make</DataMember><EditType>NoEdit</EditType><FilterEditType>Combo</FilterEditT" & _
        "ype><Key>cod_make</Key><Position>0</Position><Width>64</Width></Column0><Column1" & _
        " ID=""cod_model""><Caption>cod_model</Caption><TypeNameEmptyStringValue>System.Str" & _
        "ing</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>cod_model</DataMem" & _
        "ber><EditType>NoEdit</EditType><FilterEditType>Combo</FilterEditType><Key>cod_mo" & _
        "del</Key><Position>1</Position><Width>75</Width></Column1><Column2 ID=""make_year" & _
        """><Caption>make_year</Caption><TypeNameEmptyStringValue>System.String</TypeNameE" & _
        "mptyStringValue><EmptyStringValue /><DataMember>make_year</DataMember><EditType>" & _
        "Combo</EditType><Key>make_year</Key><Position>2</Position><Width>66</Width></Col" & _
        "umn2><Column3 ID=""options""><Caption>options</Caption><TypeNameEmptyStringValue>S" & _
        "ystem.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>options</" & _
        "DataMember><EditType>Combo</EditType><Key>options</Key><Position>3</Position><Wi" & _
        "dth>64</Width></Column3><Column4 ID=""cod_size_main""><Caption>cod_size_main</Capt" & _
        "ion><TypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStri" & _
        "ngValue /><DataMember>cod_size_main</DataMember><EditType>NoEdit</EditType><Filt" & _
        "erEditType>Combo</FilterEditType><Key>cod_size_main</Key><Position>4</Position><" & _
        "Visible>False</Visible><Width>85</Width></Column4><Column5 ID=""Desc_Main""><Capti" & _
        "on>Desc_Main</Caption><DataMember>Desc_Main</DataMember><EditType>NoEdit</EditTy" & _
        "pe><FilterEditType>TextBox</FilterEditType><Key>Desc_Main</Key><Position>5</Posi" & _
        "tion><Width>136</Width></Column5><Column6 ID=""cod_size_option""><Caption>cod_size" & _
        "_option</Caption><DataMember>cod_size_option</DataMember><EditType>NoEdit</EditT" & _
        "ype><FilterEditType>Combo</FilterEditType><Key>cod_size_option</Key><Position>6<" & _
        "/Position><Visible>False</Visible><Width>94</Width></Column6><Column7 ID=""Desc_O" & _
        "ption""><Caption>Desc_Option</Caption><DataMember>Desc_Option</DataMember><EditTy" & _
        "pe>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>Desc_Option</Ke" & _
        "y><Position>7</Position><Width>132</Width></Column7><Column8 ID=""cod_vehicle""><C" & _
        "aption>cod_vehicle</Caption><TypeNameEmptyStringValue>System.String</TypeNameEmp" & _
        "tyStringValue><EmptyStringValue /><DataMember>cod_vehicle</DataMember><Key>cod_v" & _
        "ehicle</Key><Position>8</Position><Visible>False</Visible><Width>80</Width></Col" & _
        "umn8><Column9 ID=""cod_main""><Caption>cod_main</Caption><TypeNameEmptyStringValue" & _
        ">System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>cod_mai" & _
        "n</DataMember><Key>cod_main</Key><Position>9</Position><Visible>False</Visible><" & _
        "Width>71</Width></Column9></Columns><GroupCondition ID="""" /><Key>bas_vehicle_siz" & _
        "e</Key></RootTable></GridEXLayoutData>"
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
        Me.GrdDetail.TabIndex = 2
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsFrmSearchSize1.bas_vehicle_size
        '
        'DsFrmSearchSize1
        '
        Me.DsFrmSearchSize1.DataSetName = "DSFrmSearchSize"
        Me.DsFrmSearchSize1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
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
        Me.Panel2.TabIndex = 21
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdOk.ForeColor = System.Drawing.Color.Black
        Me.CmdOk.Location = New System.Drawing.Point(447, 5)
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
        Me.CmdExit.Location = New System.Drawing.Point(543, 5)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT bas_vehicle_size.cod_vehicle, bas_vehicle_size.cod_main, bas_vehicle_size." & _
        "cod_size_main, bas_vehicle_size.cod_size_option, inv_tab_public.desc_table AS De" & _
        "sc_Main, inv_tab_public_1.desc_table AS Desc_Option, bas_vehicle.cod_make, bas_v" & _
        "ehicle.cod_model, bas_vehicle.make_year, bas_vehicle.options FROM bas_vehicle_si" & _
        "ze INNER JOIN inv_tab_public ON bas_vehicle_size.cod_main = inv_tab_public.cod_m" & _
        "ain AND bas_vehicle_size.cod_size_main = inv_tab_public.cod_table_public INNER J" & _
        "OIN inv_tab_public inv_tab_public_1 ON bas_vehicle_size.cod_main = inv_tab_publi" & _
        "c_1.cod_main AND bas_vehicle_size.cod_size_option = inv_tab_public_1.cod_table_p" & _
        "ublic INNER JOIN bas_vehicle ON bas_vehicle_size.cod_vehicle = bas_vehicle.cod_v" & _
        "ehicle"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAbas_vehicle_size
        '
        Me.DAbas_vehicle_size.SelectCommand = Me.SqlSelectCommand2
        Me.DAbas_vehicle_size.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_vehicle_size", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vehicle", "cod_vehicle"), New System.Data.Common.DataColumnMapping("cod_main", "cod_main"), New System.Data.Common.DataColumnMapping("cod_size_main", "cod_size_main"), New System.Data.Common.DataColumnMapping("cod_size_option", "cod_size_option")})})
        '
        'FrmSearchSize
        '
        Me.AcceptButton = Me.BtnFind
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(629, 388)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSearchSize"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find Size"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchSize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmFindServiceRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Try
            Cnn.ConnectionString = PConnectionString
        Catch ex As Exception
        End Try
        Call FillDataSet()
    End Sub
    Private Sub ActFilter()
        Dim WhereClauseVar As String = ""
        Dim OPerand As String = " "
        If TxtMainSize.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & " l_name like '%" & TxtMainSize.Text.Trim & "%' "
            OPerand = " AND "
        End If
        If TxtOption.Text.Trim.Length > 2 Then
            WhereClauseVar = WhereClauseVar & OPerand & " phone_1 like '%" & TxtOption.Text.Trim & "%' "
            OPerand = " AND "
        End If
        DataView1.RowFilter = WhereClauseVar
    End Sub
    Private Sub FillDataSet()
        DsFrmSearchSize1.bas_vehicle_size.Clear()
        DAbas_vehicle_size.Fill(DsFrmSearchSize1, "bas_vehicle_size")
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Call ActFilter()
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent SizeFind(GrdDetail.GetRow.Cells(0).Value & "", GrdDetail.GetRow.Cells(1).Value & "", GrdDetail.GetRow.Cells(2).Value & "", GrdDetail.GetRow.Cells(3).Value & "", GrdDetail.GetRow.Cells(4).Value & "", GrdDetail.GetRow.Cells(6).Value & "")
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
End Class
