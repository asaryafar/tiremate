Public Class FrmChangeLine
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents LineNoTo As System.Windows.Forms.TextBox
    Friend WithEvents LineNoFrom As UCInv_Item.Line
    Friend WithEvents LineNoTo2 As UCInv_Item.Line
    Friend WithEvents Chk1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdClose = New Janus.Windows.EditControls.UIButton
        Me.LineNoFrom = New UCInv_Item.Line
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LineNoTo = New System.Windows.Forms.TextBox
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.LineNoTo2 = New UCInv_Item.Line
        Me.Chk1 = New System.Windows.Forms.CheckBox
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
        Me.Panel4.Size = New System.Drawing.Size(366, 56)
        Me.Panel4.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 32)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "Enter Old Line No Followed  by New Line No And Click Save to Change"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(8, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 4)
        Me.Panel1.TabIndex = 140
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(8, 158)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 138
        Me.CmdOk.Text = "Save"
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(288, 158)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(75, 23)
        Me.CmdClose.TabIndex = 139
        Me.CmdClose.Text = "Exit"
        '
        'LineNoFrom
        '
        Me.LineNoFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LineNoFrom.Connection = Me.Cnn
        Me.LineNoFrom.LineCod = ""
        Me.LineNoFrom.LineCodLen = 30
        Me.LineNoFrom.Location = New System.Drawing.Point(88, 64)
        Me.LineNoFrom.Name = "LineNoFrom"
        Me.LineNoFrom.NotExitIfNotFound = False
        Me.LineNoFrom.ReleaseIfNotFoundLineCod = False
        Me.LineNoFrom.Size = New System.Drawing.Size(152, 20)
        Me.LineNoFrom.TabIndex = 141
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 22)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Old Line No"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 22)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "New Line  No"
        '
        'LineNoTo
        '
        Me.LineNoTo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineNoTo.Location = New System.Drawing.Point(88, 99)
        Me.LineNoTo.MaxLength = 20
        Me.LineNoTo.Name = "LineNoTo"
        Me.LineNoTo.Size = New System.Drawing.Size(152, 20)
        Me.LineNoTo.TabIndex = 143
        Me.LineNoTo.Text = ""
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'LineNoTo2
        '
        Me.LineNoTo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LineNoTo2.Connection = Me.Cnn
        Me.LineNoTo2.LineCod = ""
        Me.LineNoTo2.LineCodLen = 30
        Me.LineNoTo2.Location = New System.Drawing.Point(88, 98)
        Me.LineNoTo2.Name = "LineNoTo2"
        Me.LineNoTo2.NotExitIfNotFound = False
        Me.LineNoTo2.ReleaseIfNotFoundLineCod = False
        Me.LineNoTo2.Size = New System.Drawing.Size(152, 20)
        Me.LineNoTo2.TabIndex = 145
        Me.LineNoTo2.Visible = False
        '
        'Chk1
        '
        Me.Chk1.Location = New System.Drawing.Point(249, 64)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(95, 24)
        Me.Chk1.TabIndex = 146
        Me.Chk1.Text = "Rename "
        '
        'FrmChangeLine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(366, 188)
        Me.Controls.Add(Me.Chk1)
        Me.Controls.Add(Me.LineNoTo2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LineNoTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LineNoFrom)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmChangeLine"
        Me.Text = "Global Line Change"
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmChangeLine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = CommonClass.PConnectionString
        Call FixThisDatabase()
        CommonClass.MainModule.MsgFar("This process requires that other users not be using SAVE or EDIT of any Transaction affecting inventory please make sure of this before clicking on SAVE .")
    End Sub
    Sub FixThisDatabase()
        Call AlterTable("inv_item", "FK_inv_item_inv_tab_line", False)
    End Sub
    Sub AlterTable(ByVal ThisTableName As String, ByVal ThisConstrantName As String, ByVal OnDeleteCasCade As Boolean)
        Dim Str1 As String = " ALTER TABLE [dbo].[" & ThisTableName.Trim & "] Drop CONSTRAINT [" & ThisConstrantName.Trim & "]"
        Dim Str2 As String = "ALTER TABLE [dbo].[" & ThisTableName.Trim & "] ADD CONSTRAINT [" & ThisConstrantName.Trim & "] FOREIGN KEY ([line]) REFERENCES [dbo].[inv_tab_line] ([line]) " & IIf(OnDeleteCasCade, " ON DELETE CASCADE ", " ") & " ON UPDATE CASCADE "
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            Try
                CmdGeneral.CommandText = Str1
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
            End Try
            '-------------------------
            CmdGeneral.CommandText = Str2
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If Chk1.Checked = False Then
            Call ChangeLineNo()
        Else
            Call RenameLineNo(LineNoFrom.Text, LineNoTo2.Text)
        End If
    End Sub
    Public Sub RenameLineNo(ByVal FromLineno As String, ByVal ToLineno As String)
        Dim tran1 As SqlClient.SqlTransaction
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If


        If FromLineno.Trim = "" Then
            CommonClass.MsgFar("Old Line No Is Empty")
            Exit Sub
        End If
        If ToLineno.Trim = "" Then
            CommonClass.MsgFar("New Line No Is Empty")
            Exit Sub
        End If

        CmdGeneral.CommandText = " Select line from inv_tab_line where line= " & CommonClass.Qt(FromLineno)
        If (CmdGeneral.ExecuteScalar & "") = "" Then
            LineNoFrom.Text = ""
            LineNoFrom.Focus()
            CommonClass.MsgFar("Old Line No Is Not Exist")
            Exit Sub
        End If

        CmdGeneral.CommandText = " Select line from inv_tab_line where line= " & CommonClass.Qt(ToLineno)
        If (CmdGeneral.ExecuteScalar & "") = "" Then
            LineNoFrom.Text = ""
            LineNoFrom.Focus()
            CommonClass.MsgFar("New line No Is Not Exist")
            Exit Sub
        End If

        Try
            tran1 = Cnn.BeginTransaction()
            CmdGeneral.Transaction = tran1
            CmdGeneral.CommandText = " select count(*) from inv_item where line= " & CommonClass.Qt(LineNoFrom.Text)
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Dim numbersline As Int64 = Val("0" & CmdGeneral.ExecuteScalar)
            CmdGeneral.CommandText = "Update inv_item set Line = " & CommonClass.Qt(LineNoTo2.Text.Trim) & " Where Line = " & CommonClass.Qt(LineNoFrom.Text)
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = " Delete From inv_tab_line where Line = " & CommonClass.Qt(LineNoFrom.Text.Trim) '& " Where Line = " & CommonClass.Qt(LineNoFrom.Text)
            CmdGeneral.ExecuteNonQuery()

            tran1.Commit()
            CommonClass.MsgFar("Change Line Number Complete " & numbersline & " Replacements made")
            LineNoFrom.Text = ""
            LineNoTo.Text = ""
            LineNoTo2.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
            tran1.Rollback()
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Sub

    Sub ChangeLineNo()
        If LineNoFrom.Text <> "" Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select line from inv_tab_line where line= " & CommonClass.Qt(LineNoFrom.Text)
            If (CmdGeneral.ExecuteScalar & "") = "" Then
                LineNoFrom.Text = ""
                LineNoFrom.Focus()
                CommonClass.MsgFar("Old Line No Is Not Exist")
                Exit Sub
            End If
        Else
            CommonClass.MsgFar("Please Enter Line No For Change ")
            LineNoFrom.Focus()
            Exit Sub
        End If

        If LineNoTo.Text <> "" Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select line from inv_tab_line where line= " & CommonClass.Qt(LineNoTo.Text)
            If (CmdGeneral.ExecuteScalar & "") <> "" Then
                LineNoTo.Clear()
                LineNoTo.Focus()
                CommonClass.MsgFar("New Line  No  Is Already Exist")
                Exit Sub
            End If
        Else
            CommonClass.MsgFar("Please Enter New Line No  ")
            LineNoTo.Focus()
            Exit Sub
        End If

        Dim tran1 As SqlClient.SqlTransaction
        CmdGeneral.CommandText = " select count(*) from inv_item where line= " & CommonClass.Qt(LineNoFrom.Text)
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim numbersline As Int64 = Val("0" & CmdGeneral.ExecuteScalar)

        tran1 = Cnn.BeginTransaction()
        CmdGeneral.Transaction = tran1
        CmdGeneral.CommandText = "Update inv_tab_line set Line = " & CommonClass.Qt(LineNoTo.Text.Trim) & " Where Line = " & CommonClass.Qt(LineNoFrom.Text)
        'If CmdGeneral.Connection.State <> ConnectionState.Open Then
        '    CmdGeneral.Connection.Open()
        'End If
        Try
            CmdGeneral.ExecuteNonQuery()
            tran1.Commit()
            CommonClass.MsgFar("Change Line Number Complete " & numbersline & " Replacements made")
        Catch ex As Exception
            tran1.Rollback()
            MsgBox(ex.ToString)
        End Try
        LineNoFrom.Text = ""
        LineNoTo.Clear()
        LineNoFrom.Focus()

    End Sub

    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub
    Private Sub Chk1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk1.CheckedChanged
        LineNoTo2.Visible = Chk1.Checked
        LineNoTo.Visible = Not Chk1.Checked
    End Sub
End Class
