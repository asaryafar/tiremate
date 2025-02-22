Public Class FrmItemVendors
    Inherits CommonClass.FrmBase
    Public Item_no As String = ""
    Dim WithEvents MyFrmAddNewVendor As UCVendor.FrmSearchvendorCod
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaItemVendor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmItemVendors1 As UCInv_Item.DSFrmItemVendors
    Friend WithEvents Grd As Janus.Windows.GridEX.GridEX
    Friend WithEvents Cm1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents PubCmd As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Grd = New Janus.Windows.GridEX.GridEX
        Me.Cm1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.DsFrmItemVendors1 = New UCInv_Item.DSFrmItemVendors
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaItemVendor = New System.Data.SqlClient.SqlDataAdapter
        Me.PubCmd = New System.Data.SqlClient.SqlCommand
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmItemVendors1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grd
        '
        Me.Grd.AlternatingColors = True
        Me.Grd.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.Grd.ContextMenu = Me.Cm1
        Me.Grd.DataMember = "inv_item_vendor"
        Me.Grd.DataSource = Me.DsFrmItemVendors1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>inv_item_vendor</Caption><Columns Collectio" & _
        "n=""true""><Column0 ID=""cod_vendor""><Caption>Vendor Code</Caption><DataMember>cod_" & _
        "vendor</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEdi" & _
        "tType><Key>cod_vendor</Key><Position>0</Position><Width>110</Width></Column0><Co" & _
        "lumn1 ID=""desc_vendor""><Caption>Vendor Name</Caption><DataMember>desc_vendor</Da" & _
        "taMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key" & _
        ">desc_vendor</Key><Position>1</Position><Width>321</Width></Column1><Column2 ID=" & _
        """item_no""><Caption>item_no</Caption><DataMember>item_no</DataMember><Key>item_no" & _
        "</Key><Position>2</Position><Visible>False</Visible></Column2></Columns><GroupCo" & _
        "ndition ID="""" /><Key>inv_item_vendor</Key></RootTable></GridEXLayoutData>"
        Me.Grd.DesignTimeLayout = GridEXLayout1
        Me.Grd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Grd.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.Grd.GroupByBoxVisible = False
        Me.Grd.Location = New System.Drawing.Point(0, 52)
        Me.Grd.Name = "Grd"
        Me.Grd.Size = New System.Drawing.Size(445, 266)
        Me.Grd.TabIndex = 0
        '
        'Cm1
        '
        Me.Cm1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Delete Vendor"
        '
        'DsFrmItemVendors1
        '
        Me.DsFrmItemVendors1.DataSetName = "DSFrmItemVendors"
        Me.DsFrmItemVendors1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.CmdOk)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(445, 50)
        Me.Panel4.TabIndex = 25
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(92, 12)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 204
        Me.CmdOk.Text = "Add Vendor"
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(776, 48)
        Me.Label3.TabIndex = 203
        Me.Label3.Text = "Item Vendors"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UiButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 318)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(445, 38)
        Me.Panel1.TabIndex = 26
        '
        'UiButton1
        '
        Me.UiButton1.Location = New System.Drawing.Point(356, 7)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(75, 23)
        Me.UiButton1.TabIndex = 0
        Me.UiButton1.Text = "Exit"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT inv_item_vendor.item_no, inv_item_vendor.cod_vendor, inv_item_vendor.ven_p" & _
        "art_no, inv_item_vendor.remark, inv_vendor.desc_vendor FROM inv_item_vendor INNE" & _
        "R JOIN inv_vendor ON inv_item_vendor.cod_vendor = inv_vendor.cod_vendor WHERE (i" & _
        "nv_item_vendor.item_no = @itemno)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@itemno", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEHXP;packet size=4096;user id=sa;data source=armandehserver;" & _
        "persist security info=False;initial catalog=TireMate_01"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO inv_item_vendor(item_no, cod_vendor, ven_part_no, remark) VALUES (@it" & _
        "em_no, @cod_vendor, @ven_part_no, @remark); SELECT item_no, cod_vendor, ven_part" & _
        "_no, remark FROM inv_item_vendor WHERE (cod_vendor = @cod_vendor) AND (item_no =" & _
        " @item_no)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ven_part_no", System.Data.SqlDbType.VarChar, 30, "ven_part_no"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE inv_item_vendor SET item_no = @item_no, cod_vendor = @cod_vendor, ven_part" & _
        "_no = @ven_part_no, remark = @remark WHERE (cod_vendor = @Original_cod_vendor) A" & _
        "ND (item_no = @Original_item_no) AND (remark = @Original_remark OR @Original_rem" & _
        "ark IS NULL AND remark IS NULL) AND (ven_part_no = @Original_ven_part_no OR @Ori" & _
        "ginal_ven_part_no IS NULL AND ven_part_no IS NULL); SELECT item_no, cod_vendor, " & _
        "ven_part_no, remark FROM inv_item_vendor WHERE (cod_vendor = @cod_vendor) AND (i" & _
        "tem_no = @item_no)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ven_part_no", System.Data.SqlDbType.VarChar, 30, "ven_part_no"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ven_part_no", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ven_part_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM inv_item_vendor WHERE (cod_vendor = @Original_cod_vendor) AND (item_n" & _
        "o = @Original_item_no) AND (remark = @Original_remark OR @Original_remark IS NUL" & _
        "L AND remark IS NULL) AND (ven_part_no = @Original_ven_part_no OR @Original_ven_" & _
        "part_no IS NULL AND ven_part_no IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ven_part_no", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ven_part_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaItemVendor
        '
        Me.DaItemVendor.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaItemVendor.InsertCommand = Me.SqlInsertCommand1
        Me.DaItemVendor.SelectCommand = Me.SqlSelectCommand1
        Me.DaItemVendor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item_vendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("ven_part_no", "ven_part_no"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        Me.DaItemVendor.UpdateCommand = Me.SqlUpdateCommand1
        '
        'PubCmd
        '
        Me.PubCmd.Connection = Me.Cnn
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "add Vendor"
        '
        'FrmItemVendors
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(445, 356)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Grd)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmItemVendors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmItemVendors1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmItemVendors_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cnn.ConnectionString = CommonClass.PConnectionString
            Call FillData()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub FillData()
        DsFrmItemVendors1.Clear()
        If Item_no & "" <> "" Then
            DaItemVendor.SelectCommand.Parameters("@itemno").Value = Item_no
            DaItemVendor.Fill(DsFrmItemVendors1)
        Else
            CommonClass.MsgFar("Error In Parameter")
        End If
    End Sub
    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        Me.Close()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim igrd As Int64 = 0
        If Grd.GetRows.LongLength > 0 Then
            igrd = Grd.Row
            PubCmd.CommandText = "Delete from inv_item_vendor where item_no = " & CommonClass.Qt(Grd.GetRow.Cells(2).Value & "") & " And  cod_vendor = " & CommonClass.Qt(Grd.GetRow.Cells(0).Value & "")
            If PubCmd.Connection.State <> ConnectionState.Open Then
                PubCmd.Connection.Open()
            End If
            Try
                PubCmd.ExecuteNonQuery()
            Catch ex As Exception
            Finally
                PubCmd.Connection.Close()
            End Try
            Call FillData()
            If Grd.GetRows.LongLength - 1 > 0 Then
                Grd.Row = igrd - 1
            End If
        End If
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        MyFrmAddNewVendor = New UCVendor.FrmSearchvendorCod
        MyFrmAddNewVendor.ShowDialog()
    End Sub

    Private Sub MyFrmAddNewVendor_vendorFind(ByVal ThisvendorCod As String, ByVal Thisdesc_vendor As String) Handles MyFrmAddNewVendor.vendorFind
        Dim igrd As Int64 = 0
        If Grd.GetRows.LongLength > 0 Then
            igrd = Grd.Row
        End If

        PubCmd.CommandText = "insert into inv_item_vendor (item_no,cod_vendor) Values ( " & CommonClass.Qt(Item_no) & " , " & CommonClass.Qt(ThisvendorCod) & " )"
        If PubCmd.Connection.State <> ConnectionState.Open Then
            PubCmd.Connection.Open()
        End If
        Try
            PubCmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            PubCmd.Connection.Close()
        End Try
        Call FillData()
        If Grd.GetRows.LongLength - 1 > 0 Then
            Grd.Row = igrd - 1
        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        MyFrmAddNewVendor = New UCVendor.FrmSearchvendorCod
        MyFrmAddNewVendor.ShowDialog()
    End Sub
End Class
