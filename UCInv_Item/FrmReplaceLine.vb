Public Class FrmReplaceLine
    Inherits CommonClass.FrmBase
    Dim ComName As String = SystemInformation.ComputerName
    Dim findline1 As Boolean = False
    Dim findline2 As Boolean = False

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
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LineFrom As UCInv_Item.Line
    Friend WithEvents LineTo As UCInv_Item.Line
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RdoAll As System.Windows.Forms.RadioButton
    Friend WithEvents RdSelect As System.Windows.Forms.RadioButton
    Friend WithEvents CmdChoose As System.Windows.Forms.Button
    Friend WithEvents DsFrmRepItem1 As DSFrmRepItem
    Friend WithEvents DAItem As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdClose As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.CmdChoose = New System.Windows.Forms.Button
        Me.RdSelect = New System.Windows.Forms.RadioButton
        Me.RdoAll = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LineTo = New UCInv_Item.Line
        Me.LineFrom = New UCInv_Item.Line
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdClose = New Janus.Windows.EditControls.UIButton
        Me.DsFrmRepItem1 = New UCInv_Item.DSFrmRepItem
        Me.DAItem = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DsFrmRepItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LineTo)
        Me.Panel1.Controls.Add(Me.LineFrom)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.CmdOk)
        Me.Panel1.Controls.Add(Me.CmdClose)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 200)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CmdChoose)
        Me.Panel3.Controls.Add(Me.RdSelect)
        Me.Panel3.Controls.Add(Me.RdoAll)
        Me.Panel3.Location = New System.Drawing.Point(0, 111)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(304, 40)
        Me.Panel3.TabIndex = 367
        '
        'CmdChoose
        '
        Me.CmdChoose.Enabled = False
        Me.CmdChoose.Location = New System.Drawing.Point(234, 10)
        Me.CmdChoose.Name = "CmdChoose"
        Me.CmdChoose.Size = New System.Drawing.Size(61, 23)
        Me.CmdChoose.TabIndex = 2
        Me.CmdChoose.Text = "Choose..."
        '
        'RdSelect
        '
        Me.RdSelect.Location = New System.Drawing.Point(103, 8)
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
        Me.Panel2.Size = New System.Drawing.Size(298, 4)
        Me.Panel2.TabIndex = 366
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 365
        Me.Label1.Text = "New Line"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 21)
        Me.Label3.TabIndex = 364
        Me.Label3.Text = "Old Line"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LineTo
        '
        Me.LineTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LineTo.Connection = Me.Cnn
        Me.LineTo.LineCod = ""
        Me.LineTo.LineCodLen = 30
        Me.LineTo.Location = New System.Drawing.Point(83, 48)
        Me.LineTo.Name = "LineTo"
        Me.LineTo.NotExitIfNotFound = False
        Me.LineTo.ReleaseIfNotFoundLineCod = False
        Me.LineTo.Size = New System.Drawing.Size(167, 20)
        Me.LineTo.TabIndex = 67
        '
        'LineFrom
        '
        Me.LineFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LineFrom.Connection = Me.Cnn
        Me.LineFrom.LineCod = ""
        Me.LineFrom.LineCodLen = 30
        Me.LineFrom.Location = New System.Drawing.Point(83, 8)
        Me.LineFrom.Name = "LineFrom"
        Me.LineFrom.NotExitIfNotFound = False
        Me.LineFrom.ReleaseIfNotFoundLineCod = False
        Me.LineFrom.Size = New System.Drawing.Size(167, 20)
        Me.LineFrom.TabIndex = 66
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Location = New System.Drawing.Point(4, 162)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(300, 4)
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
        Me.CmdClose.Location = New System.Drawing.Point(236, 175)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(73, 23)
        Me.CmdClose.TabIndex = 364
        Me.CmdClose.Text = "Exit"
        '
        'DsFrmRepItem1
        '
        Me.DsFrmRepItem1.DataSetName = "DSFrmRepItem"
        Me.DsFrmRepItem1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'DAItem
        '
        Me.DAItem.SelectCommand = Me.SqlSelectCommand1
        Me.DAItem.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT item_no AS code, desc_item AS name FROM inv_item WHERE (line = @line) ORDE" & _
        "R BY item_no"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@line", System.Data.SqlDbType.VarChar, 30, "line"))
        '
        'FrmReplaceLine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(326, 220)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmReplaceLine"
        Me.Text = "Merge Line code"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DsFrmRepItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FormReplaceLine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = CommonClass.PConnectionString
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
    Private Sub RdoAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAll.CheckedChanged
        Call enabledisable()
    End Sub
    Private Sub CmdChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdChoose.Click
        RdSelect.Checked = True
        Dim f As New FrmSelect
        If DsFrmRepItem1.item.Count = 0 Then
            DsFrmRepItem1.item.Clear()
            DAItem.SelectCommand.Parameters("@line").Value = LineFrom.Line_Code.Trim & ""
            DAItem.Fill(DsFrmRepItem1.item)
        End If
        f.Text = " Select Item line " & LineFrom.Line_Code.Trim & ""
        f.DSITEM = DsFrmRepItem1
        f.TypeOfForm = FrmSelect.KindForm.Item
        f.ShowDialog()
    End Sub
    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If LineFrom.Text.Trim = LineTo.Text.Trim Then
            CommonClass.MsgFar("two lines are equal !")
            Exit Sub
        End If

        If (findline1 And findline2) = False Then
            CommonClass.MsgFar("the values for Lines are Incorrect! ")
            Exit Sub
        End If
        If RdSelect.Checked Then
            If DsFrmRepItem1.item.Select(" flag = 1 ").Length = 0 Then
                MsgBox("First Select Item that you want")
                Exit Sub
            End If

            Try
                CmdGeneral.CommandText = " create table Item_" & ComName & "(item_no char(20))"
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
                CmdGeneral.CommandText = " DELETE FROM Item_" & ComName
                CmdGeneral.ExecuteNonQuery()
            End Try
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
            Stritem = " inv_item.item_no  in (select item_no from Item_" & ComName & ") "
        End If
        Dim tran1 As SqlClient.SqlTransaction
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        tran1 = Cnn.BeginTransaction()
        CmdGeneral.Transaction = tran1
        CmdGeneral.CommandText = "update inv_item set line=" & CommonClass.Qt(LineTo.Line_Code) & " where " & Stritem & " and line =" & CommonClass.Qt(LineFrom.Line_Code)
        Try
            CmdGeneral.ExecuteNonQuery()
            tran1.Commit()
            CommonClass.MsgFar(" task completed ")
            DsFrmRepItem1.item.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            tran1.Rollback()
        End Try

    End Sub

    Private Sub LineFrom_FindLineCode() Handles LineFrom.FindLineCode
        findline1 = True
    End Sub

    Private Sub LineFrom_NotFindLineCode() Handles LineFrom.NotFindLineCode
        findline1 = False
    End Sub

    Private Sub LineTo_FindLineCode() Handles LineTo.FindLineCode
        findline2 = True
    End Sub
    Private Sub LineTo_NotFindLineCode() Handles LineTo.NotFindLineCode
        findline2 = False
    End Sub
    Private Sub LineFrom_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LineFrom.TextChanged
        DsFrmRepItem1.item.Clear()
    End Sub
End Class
