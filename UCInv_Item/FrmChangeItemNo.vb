Public Class FrmChangeItemNo
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ItemNoFrom As UCInv_Item.ItemNo
    Friend WithEvents ItemNoTo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmdClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtDesc_Item As System.Windows.Forms.TextBox
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ItemNoto2 As UCInv_Item.ItemNo
    Friend WithEvents Chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblTxtDesc_Item2 As System.Windows.Forms.Label
    Friend WithEvents TxtDesc_Item2 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.ItemNoFrom = New UCInv_Item.ItemNo
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Label2 = New System.Windows.Forms.Label
        Me.ItemNoTo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdClose = New Janus.Windows.EditControls.UIButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.TxtDesc_Item = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ItemNoto2 = New UCInv_Item.ItemNo
        Me.Chk1 = New System.Windows.Forms.CheckBox
        Me.lblTxtDesc_Item2 = New System.Windows.Forms.Label
        Me.TxtDesc_Item2 = New System.Windows.Forms.TextBox
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(376, 56)
        Me.Panel4.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 32)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "Enter Old Item No Followed  by New Item No And Click Save to Change"
        '
        'ItemNoFrom
        '
        Me.ItemNoFrom.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItemNoFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemNoFrom.Connection = Me.Cnn
        Me.ItemNoFrom.ItemNo = ""
        Me.ItemNoFrom.ItemNoLen = 20
        Me.ItemNoFrom.Location = New System.Drawing.Point(71, 64)
        Me.ItemNoFrom.Name = "ItemNoFrom"
        Me.ItemNoFrom.NotExitIfNotFound = False
        Me.ItemNoFrom.ReleaseIfNotFoundItemNo = False
        Me.ItemNoFrom.Size = New System.Drawing.Size(160, 20)
        Me.ItemNoFrom.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 22)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Old Item No"
        '
        'ItemNoTo
        '
        Me.ItemNoTo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItemNoTo.Location = New System.Drawing.Point(72, 120)
        Me.ItemNoTo.MaxLength = 20
        Me.ItemNoTo.Name = "ItemNoTo"
        Me.ItemNoTo.Size = New System.Drawing.Size(152, 20)
        Me.ItemNoTo.TabIndex = 16
        Me.ItemNoTo.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 22)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "New Item No"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(8, 198)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 135
        Me.CmdOk.Text = "Save"
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(288, 198)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(75, 23)
        Me.CmdClose.TabIndex = 136
        Me.CmdClose.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(10, 183)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 4)
        Me.Panel1.TabIndex = 137
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'TxtDesc_Item
        '
        Me.TxtDesc_Item.Location = New System.Drawing.Point(72, 91)
        Me.TxtDesc_Item.MaxLength = 50
        Me.TxtDesc_Item.Name = "TxtDesc_Item"
        Me.TxtDesc_Item.ReadOnly = True
        Me.TxtDesc_Item.Size = New System.Drawing.Size(296, 20)
        Me.TxtDesc_Item.TabIndex = 138
        Me.TxtDesc_Item.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 22)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Description"
        '
        'ItemNoto2
        '
        Me.ItemNoto2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItemNoto2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemNoto2.Connection = Me.Cnn
        Me.ItemNoto2.ItemNo = ""
        Me.ItemNoto2.ItemNoLen = 20
        Me.ItemNoto2.Location = New System.Drawing.Point(73, 120)
        Me.ItemNoto2.Name = "ItemNoto2"
        Me.ItemNoto2.NotExitIfNotFound = False
        Me.ItemNoto2.ReleaseIfNotFoundItemNo = False
        Me.ItemNoto2.Size = New System.Drawing.Size(160, 20)
        Me.ItemNoto2.TabIndex = 140
        Me.ItemNoto2.Visible = False
        '
        'Chk1
        '
        Me.Chk1.Location = New System.Drawing.Point(240, 64)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(120, 24)
        Me.Chk1.TabIndex = 141
        Me.Chk1.Text = "Rename "
        '
        'lblTxtDesc_Item2
        '
        Me.lblTxtDesc_Item2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTxtDesc_Item2.Location = New System.Drawing.Point(6, 153)
        Me.lblTxtDesc_Item2.Name = "lblTxtDesc_Item2"
        Me.lblTxtDesc_Item2.Size = New System.Drawing.Size(68, 22)
        Me.lblTxtDesc_Item2.TabIndex = 143
        Me.lblTxtDesc_Item2.Text = "Description"
        Me.lblTxtDesc_Item2.Visible = False
        '
        'TxtDesc_Item2
        '
        Me.TxtDesc_Item2.Location = New System.Drawing.Point(74, 153)
        Me.TxtDesc_Item2.MaxLength = 50
        Me.TxtDesc_Item2.Name = "TxtDesc_Item2"
        Me.TxtDesc_Item2.ReadOnly = True
        Me.TxtDesc_Item2.Size = New System.Drawing.Size(296, 20)
        Me.TxtDesc_Item2.TabIndex = 142
        Me.TxtDesc_Item2.Text = ""
        Me.TxtDesc_Item2.Visible = False
        '
        'FrmChangeItemNo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(376, 236)
        Me.Controls.Add(Me.lblTxtDesc_Item2)
        Me.Controls.Add(Me.TxtDesc_Item2)
        Me.Controls.Add(Me.Chk1)
        Me.Controls.Add(Me.ItemNoto2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtDesc_Item)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ItemNoTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.ItemNoFrom)
        Me.Name = "FrmChangeItemNo"
        Me.Text = "Change Item No"
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmChangeItemNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = CommonClass.PConnectionString
        Call FixThisDatabase()
        CommonClass.MainModule.MsgFar("This process requires that other users not be using SAVE or EDIT of any Transaction affecting inventory please make sure of this before clicking on SAVE .")
    End Sub
    Sub FixThisDatabase()
        'Call AlterTable("inv_item_cost_transaction", "FK_inv_item_cost_transaction_inv_item", True)
        'Call AlterTable("inv_item_vendor", "FK_inv_item_vendor_inv_item", True)
        'Call AlterTable("inv_sales_transfer_dtl", "FK_inv_sales_transfer_dtl_inv_item", False)
        'Call AlterTable("inv_tab_autopart_specification", "FK_inv_tab_autopart_specification_inv_item", False)
        'Call AlterTable("inv_tab_item_warehouse", "FK_inv_tab_item_warehouse_inv_item", True)
        'Call AlterTable("Inv_Receive_product_dtl", "FK_Inv_Receive_product_dtl_inv_item", False)
        'Call AlterTable("inv_adjustment_dtl", "FK_inv_adjustment_dtl_inv_item", False)
        'Call AlterTable("Inv_purchase_order_dtl", "FK_Inv_purchase_order_dtl_inv_item", False)
        'Call AlterTable("inv_dtl_item", "FK_inv_dtl_item_inv_item", True)
        'Call AlterTable("inv_tab_tire_specification", "FK_inv_tab_tire_specification_inv_item", False)
        'Call AlterTable("inv_tab_wheels_specification", "FK_inv_tab_wheels_specification_inv_item", False)
        'Call AlterTable("inv_discount_item", "FK_inv_discount_item_inv_item", True)
    End Sub
    'Sub AlterTable(ByVal ThisTableName As String, ByVal ThisConstrantName As String, ByVal OnDeleteCasCade As Boolean)
    '    Dim Str1 As String = " ALTER TABLE [dbo].[" & ThisTableName.Trim & "] Drop CONSTRAINT [" & ThisConstrantName.Trim & "]"
    '    Dim Str2 As String = "ALTER TABLE [dbo].[" & ThisTableName.Trim & "] ADD CONSTRAINT [" & ThisConstrantName.Trim & "] FOREIGN KEY ([item_no]) REFERENCES [dbo].[inv_item] ([item_no]) " & IIf(OnDeleteCasCade, " ON DELETE CASCADE ", " ") & " ON UPDATE CASCADE "
    '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '        CmdGeneral.Connection.Open()
    '    End If
    '    Try
    '        Try
    '            CmdGeneral.CommandText = Str1
    '            CmdGeneral.ExecuteNonQuery()
    '        Catch ex As Exception
    '        End Try
    '        '-------------------------
    '        CmdGeneral.CommandText = Str2
    '        CmdGeneral.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    'End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click

        If Chk1.Checked = False Then
            Call ChangeItemNo()
        Else
            Call RenameItemno(ItemNoFrom.Text, ItemNoto2.Text)
        End If

    End Sub
    Sub ChangeItemNo()
        If ItemNoFrom.Text <> "" Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select item_no from inv_item where item_no= " & CommonClass.Qt(ItemNoFrom.Text)
            If (CmdGeneral.ExecuteScalar & "") = "" Then
                ItemNoFrom.Text = ""
                ItemNoFrom.Focus()
                CommonClass.MsgFar("Old Item No Is Not Exist")
                Exit Sub
            End If
        Else
            CommonClass.MsgFar("Please Enter Item No For Change ")
            ItemNoFrom.Focus()
            Exit Sub
        End If

        If ItemNoTo.Text <> "" Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select item_no from inv_item where item_no= " & CommonClass.Qt(ItemNoTo.Text)
            If (CmdGeneral.ExecuteScalar & "") <> "" Then
                ItemNoTo.Clear()
                ItemNoTo.Focus()
                CommonClass.MsgFar("New Item No  Is Already Exist")
                Exit Sub
            End If
        Else
            CommonClass.MsgFar("Please Enter New Item No  ")
            ItemNoTo.Focus()
            Exit Sub
        End If

        Dim tran1 As SqlClient.SqlTransaction
        tran1 = Cnn.BeginTransaction()
        CmdGeneral.Transaction = tran1
        CmdGeneral.CommandText = "Update Inv_item set item_no = " & CommonClass.Qt(ItemNoTo.Text.Trim) & " Where item_no = " & CommonClass.Qt(ItemNoFrom.Text)
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = "Update Service_center_dtl set Cod_Select = " & CommonClass.Qt(ItemNoTo.Text.Trim) & " Where type_select in ('I','A') And Cod_Select = " & CommonClass.Qt(ItemNoFrom.Text)
            CmdGeneral.ExecuteNonQuery()
            tran1.Commit()
            CommonClass.MsgFar(ItemNoTo.Text & " has replaced " & ItemNoFrom.Text & " No in all sales and purchase records")
        Catch ex As Exception
            tran1.Rollback()
            MsgBox(ex.ToString)
        End Try
        ItemNoFrom.Text = ""
        TxtDesc_Item.Clear()
        ItemNoTo.Clear()
        ItemNoFrom.Focus()
    End Sub
    Private Sub ItemNo1_FindItem_no() Handles ItemNoFrom.FindItemNo
        ItemNoFrom.ClsItem_No1.FindDesc(ItemNoFrom.Text)
        TxtDesc_Item.Text = ItemNoFrom.ClsItem_No1.desc_Item & ""
    End Sub

    Private Sub ItemNo2_FindItem_no() Handles ItemNoto2.FindItemNo
        ItemNoto2.ClsItem_No1.FindDesc(ItemNoto2.Text)
        TxtDesc_Item2.Text = ItemNoto2.ClsItem_No1.desc_Item & ""
    End Sub

    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub
    Private Sub ItemNo2_NotFindItemNo() Handles ItemNoFrom.NotFindItemNo
        TxtDesc_Item.Clear()
    End Sub
    Private Sub ItemNoFrom_NotFindItemNo() Handles ItemNoto2.NotFindItemNo
        TxtDesc_Item2.Clear()
    End Sub
    Public Sub RenameItemno(ByVal Fromitemno As String, ByVal ToItemno As String)
        Dim tran1 As SqlClient.SqlTransaction
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        If Fromitemno.Trim = "" Then
            CommonClass.MsgFar("Old Item No Is Empty")
            Exit Sub
        End If
        If ToItemno.Trim = "" Then
            CommonClass.MsgFar("New Item No Is Empty")
            Exit Sub
        End If

        CmdGeneral.CommandText = "Select item_no from inv_item where item_no= " & CommonClass.Qt(Fromitemno)
        If (CmdGeneral.ExecuteScalar & "") = "" Then
            ItemNoFrom.Text = ""
            ItemNoFrom.Focus()
            CommonClass.MsgFar("Old Item No Is Not Exist")
            Exit Sub
        End If

        CmdGeneral.CommandText = "Select item_no from inv_item where item_no= " & CommonClass.Qt(ToItemno)
        If (CmdGeneral.ExecuteScalar & "") = "" Then
            ItemNoFrom.Text = ""
            ItemNoFrom.Focus()
            CommonClass.MsgFar("New Item No Is Not Exist")
            Exit Sub
        End If

        Try
            tran1 = Cnn.BeginTransaction()
            CmdGeneral.Transaction = tran1

            Try
                CmdGeneral.CommandText = "Update inv_item_vendor set item_no = " & CommonClass.Qt(ToItemno) & " Where item_no = " & CommonClass.Qt(Fromitemno)
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
            End Try

            CmdGeneral.CommandText = "Update inv_sales_transfer_dtl " + " set item_no = " & CommonClass.Qt(ToItemno) & " Where item_no = " & CommonClass.Qt(Fromitemno)
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = "Update Inv_Receive_product_dtl " + " set item_no = " & CommonClass.Qt(ToItemno) & " Where item_no = " & CommonClass.Qt(Fromitemno)
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = "Update inv_adjustment_dtl " + " set item_no = " & CommonClass.Qt(ToItemno) & " Where item_no = " & CommonClass.Qt(Fromitemno)
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = "Update Inv_purchase_order_dtl " + " set item_no = " & CommonClass.Qt(ToItemno) & " Where item_no = " & CommonClass.Qt(Fromitemno)
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = "Update inv_dtl_item  " + " set item_no = " & CommonClass.Qt(ToItemno) & " Where item_no = " & CommonClass.Qt(Fromitemno)
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = "Update Service_center_dtl set Cod_Select = " & CommonClass.Qt(ItemNoTo.Text.Trim) & " Where type_select in ('I','A') And Cod_Select = " & CommonClass.Qt(ItemNoFrom.Text)
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = "delete from  inv_tab_tire_specification where item_no= " & CommonClass.Qt(Fromitemno)
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = "delete from  inv_tab_wheels_specification where item_no= " & CommonClass.Qt(Fromitemno)
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = "delete from  inv_tab_autopart_specification where item_no= " & CommonClass.Qt(Fromitemno)
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = "delete from  inv_item where item_no= " & CommonClass.Qt(Fromitemno)
            CmdGeneral.ExecuteNonQuery()
            tran1.Commit()
            CommonClass.MsgFar(ItemNoFrom.Text & " has Changed " & ItemNoto2.Text & " No in all sales and purchase records")
            ItemNoFrom.Text = ""
            TxtDesc_Item.Clear()
            TxtDesc_Item2.Clear()
            ItemNoto2.Text = ""
            ItemNoTo.Clear()
            ItemNoFrom.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
            tran1.Rollback()
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Sub
    Private Sub Chk1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk1.CheckedChanged
        If Chk1.Checked = True Then
            TxtDesc_Item2.Visible = True
            lblTxtDesc_Item2.Visible = True
            ItemNoto2.Visible = True
            ItemNoTo.Visible = False
        Else
            TxtDesc_Item2.Visible = False
            lblTxtDesc_Item2.Visible = False
            ItemNoto2.Visible = False
            ItemNoTo.Visible = True
        End If
    End Sub
End Class
