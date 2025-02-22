Public Class FrmShowAllVendorsHaveCreadit
    Inherits CommonClass.FrmBase
    Public DtView_AllVendorCreadit As DsFrmAllApPayMent.View_AllVendorCreaditDataTable
    Public DsFrmAllApPayMent2 As DsFrmAllApPayMent
    Public Event AfterOk(ByVal DtView_AllVendorCreadit As DsFrmAllApPayMent.View_AllVendorCreaditDataTable, ByVal what1 As Integer)
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
    Friend WithEvents DsFrmAllApPayMent1 As UcAccount.DsFrmAllApPayMent
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents DaAllVendorCreadit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmdSelectAll As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdDeselectAll As Janus.Windows.EditControls.UIButton
    Friend WithEvents t1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DaAllVendor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents grdcheck As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents PanelClass As System.Windows.Forms.Panel
    Friend WithEvents BtnClass As System.Windows.Forms.Button
    Friend WithEvents RdoSelectedClass As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllClass As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Dv1 As System.Data.DataView
    Friend WithEvents Dv2 As System.Data.DataView
    Friend WithEvents Dvclas As System.Data.DataView
    Friend WithEvents DAClass As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DsFrmAllApPayMent1 = New UcAccount.DsFrmAllApPayMent
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaAllVendorCreadit = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.CmdSelectAll = New Janus.Windows.EditControls.UIButton
        Me.CmdDeselectAll = New Janus.Windows.EditControls.UIButton
        Me.t1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.Dv1 = New System.Data.DataView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.grdcheck = New Janus.Windows.GridEX.GridEX
        Me.Dv2 = New System.Data.DataView
        Me.DaAllVendor = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Label7 = New System.Windows.Forms.Label
        Me.LblDate = New System.Windows.Forms.Label
        Me.PanelClass = New System.Windows.Forms.Panel
        Me.BtnClass = New System.Windows.Forms.Button
        Me.RdoSelectedClass = New System.Windows.Forms.RadioButton
        Me.RdoAllClass = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.Dvclas = New System.Data.DataView
        Me.DAClass = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.DsFrmAllApPayMent1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.t1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.grdcheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelClass.SuspendLayout()
        CType(Me.Dvclas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=""YAVARAN-77CB79F"";packet size=4096;user id=sa;initial catalog=Tire" & _
        "mate_01;persist security info=False"
        '
        'DsFrmAllApPayMent1
        '
        Me.DsFrmAllApPayMent1.DataSetName = "DsFrmAllApPayMent"
        Me.DsFrmAllApPayMent1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT View_AllVendorCreadit.selected, View_AllVendorCreadit.cod_vendor, View_All" & _
        "VendorCreadit.desc_vendor, SUM(View_AllVendorCreadit.sumamount_credit) AS sumamo" & _
        "unt_credit, inv_tab_vendor_class.class_vendor, inv_tab_vendor_class.desc_class F" & _
        "ROM inv_tab_vendor_class INNER JOIN inv_vendor ON inv_tab_vendor_class.class_ven" & _
        "dor = inv_vendor.class_vendor RIGHT OUTER JOIN View_AllVendorCreadit ON inv_vend" & _
        "or.cod_vendor = View_AllVendorCreadit.cod_vendor WHERE (dbo.ChangeDate(View_AllV" & _
        "endorCreadit.due_date) <= @due_date) GROUP BY View_AllVendorCreadit.selected, Vi" & _
        "ew_AllVendorCreadit.cod_vendor, View_AllVendorCreadit.desc_vendor, inv_tab_vendo" & _
        "r_class.class_vendor, inv_tab_vendor_class.desc_class"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@due_date", System.Data.SqlDbType.VarChar))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO View_AllVendorCreadit(selected, cod_vendor, desc_vendor, sumamount_cr" & _
        "edit) VALUES (@selected, @cod_vendor, @desc_vendor, @sumamount_credit); SELECT s" & _
        "elected, cod_vendor, desc_vendor, sumamount_credit FROM View_AllVendorCreadit"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@selected", System.Data.SqlDbType.Int, 4, "selected"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_vendor", System.Data.SqlDbType.VarChar, 50, "desc_vendor"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sumamount_credit", System.Data.SqlDbType.Money, 8, "sumamount_credit"))
        '
        'DaAllVendorCreadit
        '
        Me.DaAllVendorCreadit.InsertCommand = Me.SqlInsertCommand2
        Me.DaAllVendorCreadit.SelectCommand = Me.SqlSelectCommand2
        Me.DaAllVendorCreadit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "View_AllVendorCreadit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("selected", "selected"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("desc_vendor", "desc_vendor"), New System.Data.Common.DataColumnMapping("sumamount_credit", "sumamount_credit")})})
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(608, 378)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 1
        Me.CmdOk.Text = "Ok"
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(528, 378)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 2
        Me.CmdExit.Text = "Exit"
        '
        'CmdSelectAll
        '
        Me.CmdSelectAll.Location = New System.Drawing.Point(16, 378)
        Me.CmdSelectAll.Name = "CmdSelectAll"
        Me.CmdSelectAll.Size = New System.Drawing.Size(75, 23)
        Me.CmdSelectAll.TabIndex = 3
        Me.CmdSelectAll.Text = "Select All"
        '
        'CmdDeselectAll
        '
        Me.CmdDeselectAll.Location = New System.Drawing.Point(100, 378)
        Me.CmdDeselectAll.Name = "CmdDeselectAll"
        Me.CmdDeselectAll.Size = New System.Drawing.Size(75, 23)
        Me.CmdDeselectAll.TabIndex = 4
        Me.CmdDeselectAll.Text = "DeSelect All"
        '
        't1
        '
        Me.t1.Controls.Add(Me.TabPage1)
        Me.t1.Controls.Add(Me.TabPage2)
        Me.t1.Location = New System.Drawing.Point(16, 48)
        Me.t1.Name = "t1"
        Me.t1.SelectedIndex = 0
        Me.t1.Size = New System.Drawing.Size(669, 312)
        Me.t1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GridEX1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(661, 286)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Apply Credit"
        '
        'GridEX1
        '
        Me.GridEX1.DataSource = Me.Dv1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>View_AllVendorCreadit</Caption><Columns Col" & _
        "lection=""true""><Column0 ID=""selected""><TypeNameEmptyStringValue>NULL</TypeNameEm" & _
        "ptyStringValue><EmptyStringValue /><ColumnType>CheckBox</ColumnType><DataMember>" & _
        "selected</DataMember><EditType>CheckBox</EditType><Key>selected</Key><Position>0" & _
        "</Position><Width>68</Width><DefaultValue>False</DefaultValue></Column0><Column1" & _
        " ID=""cod_vendor""><Caption>Vendor</Caption><TypeNameEmptyStringValue>System.Strin" & _
        "g</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>cod_vendor</DataMemb" & _
        "er><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_v" & _
        "endor</Key><Position>1</Position></Column1><Column2 ID=""desc_vendor""><Caption>De" & _
        "scription</Caption><DataMember>desc_vendor</DataMember><DefaultGroupInterval>Tex" & _
        "t</DefaultGroupInterval><EditType>MultiColumnCombo</EditType><FilterEditType>Tex" & _
        "tBox</FilterEditType><Key>desc_vendor</Key><Position>2</Position><CompareTarget>" & _
        "Text</CompareTarget><Width>249</Width><DropDownIndex>0</DropDownIndex></Column2>" & _
        "<Column3 ID=""desc_class""><Caption>Class Vendor</Caption><DataMember>desc_class</" & _
        "DataMember><Key>desc_class</Key><Position>3</Position></Column3><Column4 ID=""sum" & _
        "amount_credit""><Caption>Total Credit</Caption><DataMember>sumamount_credit</Data" & _
        "Member><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Forma" & _
        "tString>c</FormatString><Key>sumamount_credit</Key><Position>4</Position><TextAl" & _
        "ignment>Far</TextAlignment><Width>105</Width></Column4><Column5 ID=""class_vendor" & _
        """><Caption>class_vendor</Caption><DataMember>class_vendor</DataMember><Key>class" & _
        "_vendor</Key><Position>5</Position><Visible>False</Visible></Column5></Columns><" & _
        "GroupCondition ID="""" /><Key>View_AllVendorCreadit</Key></RootTable><DropDowns Co" & _
        "llection=""true""><DropDown0><RootTable><Columns Collection=""true""><Column0 ID=""de" & _
        "sc_class""><Caption>desc_class</Caption><DataMember>desc_class</DataMember><Filte" & _
        "rEditType>DropDownList</FilterEditType><Key>desc_class</Key><Position>0</Positio" & _
        "n></Column0></Columns><GroupCondition ID="""" /></RootTable><WatermarkImage /><Fon" & _
        "t>Microsoft Sans Serif, 8.25pt</Font><ControlStyle /><AllowEdit>False</AllowEdit" & _
        "><ExpandableGroups>False</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxV" & _
        "isible><HideSelection>Highlight</HideSelection><Key>DropDown1</Key><DisplayMembe" & _
        "r>desc_class</DisplayMember><ValueMember>class_vendor</ValueMember></DropDown0><" & _
        "/DropDowns></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.GroupTotals = Janus.Windows.GridEX.GroupTotals.Default
        Me.GridEX1.Location = New System.Drawing.Point(0, 0)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(661, 286)
        Me.GridEX1.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grdcheck)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(661, 286)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Prepare for Check"
        '
        'grdcheck
        '
        Me.grdcheck.DataSource = Me.Dv2
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Caption>View_AllVendorCreadit</Caption><Columns Col" & _
        "lection=""true""><Column0 ID=""selected""><TypeNameEmptyStringValue>NULL</TypeNameEm" & _
        "ptyStringValue><EmptyStringValue /><ColumnType>CheckBox</ColumnType><DataMember>" & _
        "selected</DataMember><EditType>CheckBox</EditType><Key>selected</Key><Position>0" & _
        "</Position><Width>69</Width><DefaultValue>False</DefaultValue></Column0><Column1" & _
        " ID=""cod_vendor""><Caption>Vendor</Caption><TypeNameEmptyStringValue>System.Strin" & _
        "g</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>cod_vendor</DataMemb" & _
        "er><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_v" & _
        "endor</Key><Position>1</Position></Column1><Column2 ID=""desc_vendor""><Caption>De" & _
        "scription</Caption><DataMember>desc_vendor</DataMember><EditType>NoEdit</EditTyp" & _
        "e><FilterEditType>TextBox</FilterEditType><Key>desc_vendor</Key><Position>2</Pos" & _
        "ition><Width>292</Width></Column2><Column3 ID=""desc_class""><Caption>Class Vendor" & _
        "</Caption><DataMember>desc_class</DataMember><EditType>NoEdit</EditType><Key>des" & _
        "c_class</Key><Position>3</Position></Column3><Column4 ID=""class_vendor""><Caption" & _
        ">class_vendor</Caption><DataMember>class_vendor</DataMember><EditType>NoEdit</Ed" & _
        "itType><Key>class_vendor</Key><Position>4</Position><Visible>False</Visible></Co" & _
        "lumn4></Columns><GroupCondition ID="""" /><Key>View_AllVendorCreadit</Key></RootTa" & _
        "ble></GridEXLayoutData>"
        Me.grdcheck.DesignTimeLayout = GridEXLayout2
        Me.grdcheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdcheck.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.grdcheck.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdcheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grdcheck.GroupByBoxVisible = False
        Me.grdcheck.Location = New System.Drawing.Point(0, 0)
        Me.grdcheck.Name = "grdcheck"
        Me.grdcheck.Size = New System.Drawing.Size(661, 286)
        Me.grdcheck.TabIndex = 3
        '
        'DaAllVendor
        '
        Me.DaAllVendor.SelectCommand = Me.SqlCommand2
        Me.DaAllVendor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_vendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("selected", "selected"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("desc_vendor", "desc_vendor"), New System.Data.Common.DataColumnMapping("class_vendor", "class_vendor"), New System.Data.Common.DataColumnMapping("desc_class", "desc_class")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT 0 AS selected, inv_vendor.cod_vendor, inv_vendor.desc_vendor, inv_tab_vend" & _
        "or_class.class_vendor, inv_tab_vendor_class.desc_class FROM inv_vendor INNER JOI" & _
        "N inv_tab_vendor_class ON inv_vendor.class_vendor = inv_tab_vendor_class.class_v" & _
        "endor WHERE (inv_vendor.cod_vendor IN (SELECT DISTINCT cod_vendor FROM View_AllU" & _
        "nPaidGl_Ap_Bill_Dtl_Dtl WHERE (sumoriginalamount <> sumpayment) AND dbo.changeda" & _
        "te(due_date) <= @thisdate AND (NOT (due_date IS NULL)) UNION SELECT DISTINCT cod" & _
        "_vendor FROM View_AllUnPaidReceive_product_ap_Dtl WHERE (sumoriginalamount <> su" & _
        "mpayment) AND dbo.changedate(due_date) <= @thisdate AND (NOT (due_date IS NULL))" & _
        " UNION SELECT DISTINCT cod_vendor FROM View_AllUnPaidService_out_purchase WHERE " & _
        "(sumoriginalamount <> sumpayment) AND dbo.changedate(due_date) <= @thisdate AND " & _
        "(NOT (due_date IS NULL))))"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@thisdate", System.Data.SqlDbType.NVarChar))
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(24, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 23)
        Me.Label7.TabIndex = 460
        Me.Label7.Text = "Due Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDate
        '
        Me.LblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDate.Location = New System.Drawing.Point(88, 12)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(152, 24)
        Me.LblDate.TabIndex = 461
        '
        'PanelClass
        '
        Me.PanelClass.Controls.Add(Me.BtnClass)
        Me.PanelClass.Controls.Add(Me.RdoSelectedClass)
        Me.PanelClass.Controls.Add(Me.RdoAllClass)
        Me.PanelClass.Controls.Add(Me.Label8)
        Me.PanelClass.Location = New System.Drawing.Point(303, 3)
        Me.PanelClass.Name = "PanelClass"
        Me.PanelClass.Size = New System.Drawing.Size(376, 40)
        Me.PanelClass.TabIndex = 462
        '
        'BtnClass
        '
        Me.BtnClass.Enabled = False
        Me.BtnClass.Location = New System.Drawing.Point(280, 16)
        Me.BtnClass.Name = "BtnClass"
        Me.BtnClass.TabIndex = 3
        Me.BtnClass.Text = "Choose..."
        '
        'RdoSelectedClass
        '
        Me.RdoSelectedClass.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedClass.Name = "RdoSelectedClass"
        Me.RdoSelectedClass.Size = New System.Drawing.Size(112, 24)
        Me.RdoSelectedClass.TabIndex = 1
        Me.RdoSelectedClass.Text = "Selected Classes"
        '
        'RdoAllClass
        '
        Me.RdoAllClass.Checked = True
        Me.RdoAllClass.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllClass.Name = "RdoAllClass"
        Me.RdoAllClass.TabIndex = 0
        Me.RdoAllClass.TabStop = True
        Me.RdoAllClass.Text = "All Classes"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "For Customer Classes"
        '
        'DAClass
        '
        Me.DAClass.SelectCommand = Me.SqlCommand1
        Me.DAClass.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_vendor_class", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("class_vendor", "class_vendor"), New System.Data.Common.DataColumnMapping("desc_class", "desc_class")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT class_vendor AS cod, desc_class AS name FROM inv_tab_vendor_class"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'FrmShowAllVendorsHaveCreadit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(694, 414)
        Me.Controls.Add(Me.PanelClass)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.CmdDeselectAll)
        Me.Controls.Add(Me.CmdSelectAll)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdOk)
        Me.Name = "FrmShowAllVendorsHaveCreadit"
        Me.Text = "Select Vendor"
        CType(Me.DsFrmAllApPayMent1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.t1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.grdcheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelClass.ResumeLayout(False)
        CType(Me.Dvclas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmShowAllVendorsHaveCreadit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        t1.SelectedIndex = 1
        Cnn.ConnectionString = CommonClass.PConnectionString
        DsFrmAllApPayMent2.clas.Clear()
        DAClass.Fill(DsFrmAllApPayMent2.clas)
        Try
            If DsFrmAllApPayMent2.View_AllVendorCreadit.Rows.Count = 0 Then
                DsFrmAllApPayMent2.inv_vendor.Clear()
                DsFrmAllApPayMent2.View_AllVendorCreadit.Clear()
                DaAllVendorCreadit.SelectCommand.Parameters(0).Value = Mid(LblDate.Text, 7, 4) + "/" + Mid(LblDate.Text, 1, 2) + "/" + Mid(LblDate.Text, 4, 2)
                DaAllVendorCreadit.Fill(DsFrmAllApPayMent2.View_AllVendorCreadit)
                DaAllVendor.SelectCommand.Parameters(0).Value = Mid(LblDate.Text, 7, 4) + "/" + Mid(LblDate.Text, 1, 2) + "/" + Mid(LblDate.Text, 4, 2)
                DaAllVendor.Fill(DsFrmAllApPayMent2.inv_vendor)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dvclas.Table = DsFrmAllApPayMent2.clas
        Dv1.Table = DsFrmAllApPayMent2.View_AllVendorCreadit
        Dv2.Table = DsFrmAllApPayMent2.inv_vendor
        Call setgrids()
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Try
            'Me.grdcheck.DataMember = ""
            'Me.grdcheck.DataSource = Nothing
            'Me.grdcheck.Refetch()

            RaiseEvent AfterOk(DtView_AllVendorCreadit, t1.SelectedIndex)
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub CmdSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSelectAll.Click
        Call selectit(True)
    End Sub
    Sub selectit(ByVal what As Boolean)
        Dim i As Int64 = 0
        Select Case t1.SelectedIndex
            Case 0
                For i = 0 To GridEX1.RowCount - 1
                    GridEX1.Row = i
                    GridEX1.GetRow.Cells(0).Value = what
                Next
            Case 1
                For i = 0 To grdcheck.RowCount - 1
                    grdcheck.Row = i
                    grdcheck.GetRow.Cells(0).Value = what
                Next
        End Select
    End Sub
    Private Sub CmdDeselectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDeselectAll.Click
        selectit(False)
    End Sub
    Private Sub BtnClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClass.Click
        BtnClass.Enabled = False
        Dim f As New FrmSelectVendor
        If DsFrmAllApPayMent2.clas.Count = 0 Then
            DAClass.Fill(DsFrmAllApPayMent2.clas)
        End If
        f.Text = "  Select Class"
        f.TypeOfForm = FrmSelectVendor.KindForm.Clas
        f.DSMAIN = DsFrmAllApPayMent2
        f.ShowDialog()
        'BtnClass.Enabled = True
        'BtnClass.Enabled = False
        'Dim f As New FrmSelect
        'If DsFrmAllApPayMent2.clas.Count = 0 Then
        '    DsFrmAllApPayMent2.clas.Clear()
        '    DAClass.Fill(DsFrmAllApPayMent2.clas)
        'End If
        'f.Text = "  Select Class"
        'f.TypeOfForm = FrmSelect.KindForm.clas
        'f.DSMAIN = DsFrmAllApPayMent2
        'f.ShowDialog()
        BtnClass.Enabled = True
        Call Filterit()
    End Sub

    Private Sub RdoAllClass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllClass.CheckedChanged
        If RdoAllClass.Checked Then
            BtnClass.Enabled = False
        Else
            BtnClass.Enabled = True
        End If
        Call Filterit()
    End Sub
    Sub Filterit()
        Dim i As Integer
        Dvclas.RowFilter = "flag= true"
        If RdoAllClass.Checked Then
            Dv1.RowFilter = ""
            Dv2.RowFilter = ""
        Else
            Dv1.RowFilter = ""
            Dv2.RowFilter = ""
            If Dvclas.Count > 0 Then
                For i = 0 To Dvclas.Count - 1
                    Dv1.RowFilter = Dv1.RowFilter + IIf(i = 0, "", " or ") + "class_vendor=" & "'" & (Dvclas(i).Item("cod")) & "'"
                    Dv2.RowFilter = Dv2.RowFilter + IIf(i = 0, "", " or ") + "class_vendor=" & "'" & (Dvclas(i).Item("cod")) & "'"
                Next
            End If
        End If
    End Sub
    Sub setgrids()
        grdcheck.DataSource = Dv2
        GridEX1.DataSource = Dv1
        GridEX1.Refetch()
        grdcheck.Refetch()
    End Sub

    Private Sub RdoSelectedClass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoSelectedClass.CheckedChanged

    End Sub
End Class
