Public Class FrmReplacePricecod
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CmdChoose As System.Windows.Forms.Button
    Friend WithEvents RdSelect As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAll As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents DAItem As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmRepItem1 As UCInv_Item.DSFrmRepItem
    Friend WithEvents DAInv_price_code As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmInv_Price_Code1 As UCInv_Item.DSFrmInv_Price_Code
    Friend WithEvents CmbPrice_Code2 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice_Code1 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CmbPrice_Code2 = New System.Windows.Forms.ComboBox
        Me.DsFrmInv_Price_Code1 = New UCInv_Item.DSFrmInv_Price_Code
        Me.CmbPrice_Code1 = New System.Windows.Forms.ComboBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.CmdChoose = New System.Windows.Forms.Button
        Me.RdSelect = New System.Windows.Forms.RadioButton
        Me.RdoAll = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdClose = New Janus.Windows.EditControls.UIButton
        Me.DAItem = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.DsFrmRepItem1 = New UCInv_Item.DSFrmRepItem
        Me.DAInv_price_code = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Panel1.SuspendLayout()
        CType(Me.DsFrmInv_Price_Code1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DsFrmRepItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CmbPrice_Code2)
        Me.Panel1.Controls.Add(Me.CmbPrice_Code1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.CmdOk)
        Me.Panel1.Controls.Add(Me.CmdClose)
        Me.Panel1.Location = New System.Drawing.Point(7, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 207)
        Me.Panel1.TabIndex = 1
        '
        'CmbPrice_Code2
        '
        Me.CmbPrice_Code2.DataSource = Me.DsFrmInv_Price_Code1.inv_price_code2
        Me.CmbPrice_Code2.DisplayMember = "desc_price_code"
        Me.CmbPrice_Code2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice_Code2.Location = New System.Drawing.Point(96, 48)
        Me.CmbPrice_Code2.Name = "CmbPrice_Code2"
        Me.CmbPrice_Code2.Size = New System.Drawing.Size(272, 21)
        Me.CmbPrice_Code2.TabIndex = 369
        Me.CmbPrice_Code2.ValueMember = "price_code"
        '
        'DsFrmInv_Price_Code1
        '
        Me.DsFrmInv_Price_Code1.DataSetName = "DSFrmInv_Price_Code"
        Me.DsFrmInv_Price_Code1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmbPrice_Code1
        '
        Me.CmbPrice_Code1.DataSource = Me.DsFrmInv_Price_Code1.inv_price_code1
        Me.CmbPrice_Code1.DisplayMember = "desc_price_code"
        Me.CmbPrice_Code1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice_Code1.Location = New System.Drawing.Point(96, 8)
        Me.CmbPrice_Code1.Name = "CmbPrice_Code1"
        Me.CmbPrice_Code1.Size = New System.Drawing.Size(272, 21)
        Me.CmbPrice_Code1.TabIndex = 368
        Me.CmbPrice_Code1.ValueMember = "price_code"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.CmdChoose)
        Me.Panel3.Controls.Add(Me.RdSelect)
        Me.Panel3.Controls.Add(Me.RdoAll)
        Me.Panel3.Location = New System.Drawing.Point(2, 111)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(368, 40)
        Me.Panel3.TabIndex = 367
        '
        'CmdChoose
        '
        Me.CmdChoose.Enabled = False
        Me.CmdChoose.Location = New System.Drawing.Point(295, 10)
        Me.CmdChoose.Name = "CmdChoose"
        Me.CmdChoose.Size = New System.Drawing.Size(61, 23)
        Me.CmdChoose.TabIndex = 2
        Me.CmdChoose.Text = "Choose..."
        '
        'RdSelect
        '
        Me.RdSelect.Location = New System.Drawing.Point(181, 8)
        Me.RdSelect.Name = "RdSelect"
        Me.RdSelect.TabIndex = 1
        Me.RdSelect.Text = "Selected  Items"
        '
        'RdoAll
        '
        Me.RdoAll.Checked = True
        Me.RdoAll.Location = New System.Drawing.Point(16, 8)
        Me.RdoAll.Name = "RdoAll"
        Me.RdoAll.Size = New System.Drawing.Size(72, 24)
        Me.RdoAll.TabIndex = 0
        Me.RdoAll.TabStop = True
        Me.RdoAll.Text = "All Items"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(6, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 4)
        Me.Panel2.TabIndex = 366
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(3, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 21)
        Me.Label1.TabIndex = 365
        Me.Label1.Text = "New Price Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(11, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 364
        Me.Label3.Text = "Old Price Cod"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Location = New System.Drawing.Point(4, 162)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(364, 4)
        Me.Panel4.TabIndex = 365
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(2, 175)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(73, 23)
        Me.CmdOk.TabIndex = 363
        Me.CmdOk.Text = "Save"
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(288, 175)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(73, 23)
        Me.CmdClose.TabIndex = 364
        Me.CmdClose.Text = "Exit"
        '
        'DAItem
        '
        Me.DAItem.SelectCommand = Me.SqlSelectCommand1
        Me.DAItem.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT inv_item.item_no AS code, inv_item.desc_item AS name FROM inv_item INNER J" & _
        "OIN inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.it" & _
        "em_no WHERE (inv_item_cost_transaction.price_code = @price_code) ORDER BY inv_it" & _
        "em.item_no"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, "price_code"))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJIXP;packet size=4096;user id=sa;data source=""."";persist secur" & _
        "ity info=True;initial catalog=Tiremate_01;password=sa"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'DsFrmRepItem1
        '
        Me.DsFrmRepItem1.DataSetName = "DSFrmRepItem"
        Me.DsFrmRepItem1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'DAInv_price_code
        '
        Me.DAInv_price_code.SelectCommand = Me.SqlCommand1
        Me.DAInv_price_code.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_price_code", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("price_code", "price_code"), New System.Data.Common.DataColumnMapping("desc_price_code", "desc_price_code"), New System.Data.Common.DataColumnMapping("price1_c_l_a_p", "price1_c_l_a_p"), New System.Data.Common.DataColumnMapping("price1_operator", "price1_operator"), New System.Data.Common.DataColumnMapping("price1_d_persent", "price1_d_persent"), New System.Data.Common.DataColumnMapping("price1_amount", "price1_amount"), New System.Data.Common.DataColumnMapping("price1_odd_price", "price1_odd_price"), New System.Data.Common.DataColumnMapping("price1_price_level", "price1_price_level"), New System.Data.Common.DataColumnMapping("price2_c_l_a_p", "price2_c_l_a_p"), New System.Data.Common.DataColumnMapping("price2_operator", "price2_operator"), New System.Data.Common.DataColumnMapping("price2_d_persent", "price2_d_persent"), New System.Data.Common.DataColumnMapping("price2_amount", "price2_amount"), New System.Data.Common.DataColumnMapping("price2_odd_price", "price2_odd_price"), New System.Data.Common.DataColumnMapping("price2_price_level", "price2_price_level"), New System.Data.Common.DataColumnMapping("price3_c_l_a_p", "price3_c_l_a_p"), New System.Data.Common.DataColumnMapping("price3_operator", "price3_operator"), New System.Data.Common.DataColumnMapping("price3_d_persent", "price3_d_persent"), New System.Data.Common.DataColumnMapping("price3_amount", "price3_amount"), New System.Data.Common.DataColumnMapping("price3_odd_price", "price3_odd_price"), New System.Data.Common.DataColumnMapping("price3_price_level", "price3_price_level"), New System.Data.Common.DataColumnMapping("price4_c_l_a_p", "price4_c_l_a_p"), New System.Data.Common.DataColumnMapping("price4_operator", "price4_operator"), New System.Data.Common.DataColumnMapping("price4_d_persent", "price4_d_persent"), New System.Data.Common.DataColumnMapping("price4_amount", "price4_amount"), New System.Data.Common.DataColumnMapping("price4_odd_price", "price4_odd_price"), New System.Data.Common.DataColumnMapping("price4_price_level", "price4_price_level"), New System.Data.Common.DataColumnMapping("price5_c_l_a_p", "price5_c_l_a_p"), New System.Data.Common.DataColumnMapping("price5_operator", "price5_operator"), New System.Data.Common.DataColumnMapping("price5_d_persent", "price5_d_persent"), New System.Data.Common.DataColumnMapping("price5_amount", "price5_amount"), New System.Data.Common.DataColumnMapping("price5_odd_price", "price5_odd_price"), New System.Data.Common.DataColumnMapping("price5_price_level", "price5_price_level"), New System.Data.Common.DataColumnMapping("price6_c_l_a_p", "price6_c_l_a_p"), New System.Data.Common.DataColumnMapping("price6_operator", "price6_operator"), New System.Data.Common.DataColumnMapping("price6_d_persent", "price6_d_persent"), New System.Data.Common.DataColumnMapping("price6_amount", "price6_amount"), New System.Data.Common.DataColumnMapping("price6_odd_price", "price6_odd_price"), New System.Data.Common.DataColumnMapping("price6_price_level", "price6_price_level"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT price_code, desc_price_code + ' - ' + price_code AS desc_price_code FROM i" & _
        "nv_price_code"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'FrmReplacePricecod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(390, 220)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmReplacePricecod"
        Me.Text = "Change Price Code"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsFrmInv_Price_Code1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DsFrmRepItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ComName As String = SystemInformation.ComputerName
    Private Sub FrmReplacePricecod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = CommonClass.PConnectionString
        DsFrmInv_Price_Code1.Clear()
        DAInv_price_code.Fill(DsFrmInv_Price_Code1, "inv_price_code1")
        DAInv_price_code.Fill(DsFrmInv_Price_Code1, "inv_price_code2")
    End Sub

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If CmbPrice_Code1.Text = "" Then
            CommonClass.MsgFar("Old Price Code Is Not Exist")
            Exit Sub
        End If

        If CmbPrice_Code2.Text = "" Then
            CommonClass.MsgFar("New Price Code Is Not Exist")
            Exit Sub
        End If

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim i As Int64 = 0
        For i = 0 To DsFrmRepItem1.item.Count - 1
            If DsFrmRepItem1.item(i).flag Then
                CmdGeneral.CommandText = " INSERT INTO Item_" & ComName & " (item_no ) VALUES (" & CommonClass.Qt(DsFrmRepItem1.item(i).code) & ") "
                CmdGeneral.ExecuteNonQuery()
            End If
        Next
        Dim Stritem As String = " 1 =1 "
        If Not RdoAll.Checked Then
            Stritem = " item_no  in (select item_no from Item_" & ComName & ") "
        End If


        Dim tran1 As SqlClient.SqlTransaction
        'CmdGeneral.CommandText = " select count(*) from inv_item where line= " & CommonClass.Qt(CustomerCodFrom.Text)
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        tran1 = Cnn.BeginTransaction()
        CmdGeneral.Transaction = tran1
        CmdGeneral.CommandText = "update inv_item_cost_transaction set price_code = " & CommonClass.Qt(CmbPrice_Code2.SelectedValue) & " where  Price_code =" & CommonClass.Qt(CmbPrice_Code1.SelectedValue) & " and " & Stritem
        Try
            CmdGeneral.ExecuteNonQuery()
            tran1.Commit()
            CommonClass.MsgFar(" task completed ")
            DsFrmRepItem1.item.Clear()
        Catch ex As Exception
            tran1.Rollback()
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub CmbPrice_Code1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPrice_Code1.SelectedIndexChanged
        DsFrmRepItem1.item.Clear()
    End Sub
    Private Sub CmbPrice_Code1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbPrice_Code1.SelectedValueChanged
        DsFrmRepItem1.item.Clear()
    End Sub
    Private Sub CmdChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdChoose.Click
        Dim f As New FrmSelect
        If DsFrmRepItem1.item.Count = 0 Then
            DsFrmRepItem1.item.Clear()
            DAItem.SelectCommand.Parameters("@price_code").Value = CmbPrice_Code1.SelectedValue & ""
            DAItem.Fill(DsFrmRepItem1.item)
        End If
        f.Text = " Select Item Price code " & CmbPrice_Code1.SelectedValue & ""
        f.DSITEM = DsFrmRepItem1
        f.TypeOfForm = FrmSelect.KindForm.Item
        f.ShowDialog()
    End Sub

    Private Sub RdSelect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdSelect.CheckedChanged
        Call enabledisable()
    End Sub
    Sub enabledisable()
        If RdoAll.Checked = True Then
            CmdChoose.Enabled = False
        Else
            CmdChoose.Enabled = True
        End If
    End Sub
    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub
End Class
