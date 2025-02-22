Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmWorkOrderOfItem
    Inherits CommonClass.FrmBase
    Public MyTop As Integer
    Public MyLeft As Integer
    Public Event CloseMe()
    Private MItem_No As String
    Property Item_no() As String
        Get
            Return MItem_No
        End Get
        Set(ByVal Value As String)
            MItem_No = Value
        End Set
    End Property
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
    Friend WithEvents DaWorkOrders As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsFrmWorkOrderOfItem1 As DsFrmWorkOrderOfItem
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DaWorkOrders = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmWorkOrderOfItem1 = New WorkOrderUtility.DsFrmWorkOrderOfItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmWorkOrderOfItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=Tiremate_02"
        '
        'DaWorkOrders
        '
        Me.DaWorkOrders.SelectCommand = Me.SqlSelectCommand1
        Me.DaWorkOrders.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT service_center_head.id_service_center, service_center_head.type_of_form, s" & _
        "ervice_center_head.cod_customer, service_center_head.date_refer, service_center_" & _
        "dtl.cod_select, service_center_dtl.qty, cust_trtab_main.f_name + ' ' + cust_trta" & _
        "b_main.m_name + ' ' + cust_trtab_main.l_name AS customer FROM service_center_hea" & _
        "d INNER JOIN service_center_dtl ON service_center_head.id_service_center = servi" & _
        "ce_center_dtl.id_service_center LEFT OUTER JOIN cust_trtab_main ON service_cente" & _
        "r_head.cod_customer = cust_trtab_main.cod_customer WHERE (service_center_head.ty" & _
        "pe_of_form = 'WO') AND (service_center_dtl.type_select = 'I') AND (service_cente" & _
        "r_dtl.cod_select = @item_no) AND (service_center_head.id_service_center NOT IN (" & _
        "SELECT service_center_head.id_service_center_before FROM service_center_head WHE" & _
        "RE service_center_head.id_service_center_before IS NOT NULL))"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "cod_select"))
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.GridEX1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GridEX1.DataMember = "service_center_head"
        Me.GridEX1.DataSource = Me.DsFrmWorkOrderOfItem1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_head</Caption><Columns Colle" & _
        "ction=""true""><Column0 ID=""Cust Cod""><Caption>Cust Cod</Caption><DataMember>cod_c" & _
        "ustomer</DataMember><Key>Cust Cod</Key><Position>0</Position><Width>68</Width></" & _
        "Column0><Column1 ID=""customer""><Caption>Customer Name</Caption><DataMember>custo" & _
        "mer</DataMember><EditType>NoEdit</EditType><Key>customer</Key><Position>1</Posit" & _
        "ion><Width>150</Width></Column1><Column2 ID=""date_refer""><Caption>Order Date</Ca" & _
        "ption><DataMember>date_refer</DataMember><Key>date_refer</Key><Position>2</Posit" & _
        "ion><Width>89</Width></Column2><Column3 ID=""cod_select""><Caption>cod_select</Cap" & _
        "tion><DataMember>cod_select</DataMember><Key>cod_select</Key><Position>3</Positi" & _
        "on><Visible>False</Visible></Column3><Column4 ID=""qty""><Caption>qty</Caption><Ty" & _
        "peNameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataM" & _
        "ember>qty</DataMember><Key>qty</Key><Position>4</Position><Width>48</Width></Col" & _
        "umn4><Column5 ID=""id_service_center""><Caption>WO No.</Caption><TypeNameEmptyStri" & _
        "ngValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>" & _
        "id_service_center</DataMember><Key>id_service_center</Key><Position>5</Position>" & _
        "</Column5></Columns><GroupCondition ID="""" /><Key>service_center_head</Key></Root" & _
        "Table></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.GridEX1.FilterRowFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.GridEX1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridEX1.Location = New System.Drawing.Point(0, 0)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(478, 271)
        Me.GridEX1.TabIndex = 0
        Me.GridEX1.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DsFrmWorkOrderOfItem1
        '
        Me.DsFrmWorkOrderOfItem1.DataSetName = "DsFrmWorkOrderOfItem"
        Me.DsFrmWorkOrderOfItem1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UiButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 234)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 37)
        Me.Panel1.TabIndex = 1
        '
        'UiButton1
        '
        Me.UiButton1.Location = New System.Drawing.Point(408, 8)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(64, 22)
        Me.UiButton1.TabIndex = 0
        Me.UiButton1.Text = "Ok"
        '
        'FrmWorkOrderOfItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(478, 271)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmWorkOrderOfItem"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmWorkOrderOfItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmWorkOrderOfItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = MyTop
        Me.Left = MyLeft
        Me.Text = "List of pending Work Orders"
        DsFrmWorkOrderOfItem1.Clear()
        DaWorkOrders.SelectCommand.Parameters(0).Value = MItem_No
        DaWorkOrders.Fill(DsFrmWorkOrderOfItem1)
    End Sub
    Private Sub FrmWorkOrderOfItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            RaiseEvent CloseMe()
        End If
    End Sub
    Private Sub FrmWorkOrderOfItem_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        RaiseEvent CloseMe()
    End Sub
    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        RaiseEvent CloseMe()
    End Sub
    'Private Sub GridEX1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.DoubleClick
    '    Dim Currentrow As GridEXRow = GridEX1.GetRow
    '    If Val(Currentrow.Cells(2).Value) > 0 Then
    '        Dim MyFrmWorkOrderOfItem As New FrmWorkOrderOfItem
    '        'MyFrmReciept.TopLevel = False
    '        'MyFrmReciept.Parent = Me.Parent
    '        'MyFrmReciept.ThisFormStatus = MainModule.WorkStates._ReadOnly
    '        'MyFrmReciept.InvCodeParam = InvCode1.Text
    '        'MyFrmReciept.Resid_NoParam = Currentrow.Cells(2).Value
    '        'MyFrmReciept.Show()
    '        'MyFrmReciept.BringToFront()
    '    End If
    'End Sub

    Private Sub FrmWorkOrderOfItem_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        RaiseEvent CloseMe()
    End Sub
End Class
