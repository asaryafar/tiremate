Imports Janus.Windows.GridEX
Public Class FrmSelect
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
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GrdMain As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnDeselect As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSelect As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSelect))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label50 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnDeselect = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GrdMain = New Janus.Windows.GridEX.GridEX
        Me.Panel4.SuspendLayout()
        CType(Me.GrdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label50)
        Me.Panel4.Controls.Add(Me.BtnSave)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.BtnDeselect)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.BtnSelect)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(398, 48)
        Me.Panel4.TabIndex = 10
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(336, 34)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 211
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(336, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 210
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(264, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 10)
        Me.Label3.TabIndex = 209
        Me.Label3.Text = "Deselect All"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDeselect
        '
        Me.BtnDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeselect.Image = CType(resources.GetObject("BtnDeselect.Image"), System.Drawing.Image)
        Me.BtnDeselect.Location = New System.Drawing.Point(280, 2)
        Me.BtnDeselect.Name = "BtnDeselect"
        Me.BtnDeselect.Size = New System.Drawing.Size(33, 27)
        Me.BtnDeselect.TabIndex = 208
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(208, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 10)
        Me.Label2.TabIndex = 207
        Me.Label2.Text = "Select All"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSelect
        '
        Me.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.Location = New System.Drawing.Point(224, 2)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(33, 27)
        Me.BtnSelect.TabIndex = 206
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(72, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select the Item that reports you want to print"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PictureBox2.ForeColor = System.Drawing.Color.Black
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'GrdMain
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>Flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>Flag</Key><Position>0</Position><Width>21</Width></Column0><Column1 ID" & _
        "=""code""><Caption>Code</Caption><DataMember>cod</DataMember><EditType>NoEdit</Edi" & _
        "tType><FilterEditType>TextBox</FilterEditType><Key>code</Key><Position>1</Positi" & _
        "on><SelectableCells>FilterRowCells</SelectableCells><Width>91</Width></Column1><" & _
        "Column2 ID=""name""><Caption>Description</Caption><DataMember>name</DataMember><Ed" & _
        "itType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>name</Key><" & _
        "Position>2</Position><SelectableCells>FilterRowCells</SelectableCells><Width>196" & _
        "</Width></Column2></Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutDa" & _
        "ta>"
        Me.GrdMain.DesignTimeLayout = GridEXLayout1
        Me.GrdMain.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdMain.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdMain.GroupByBoxVisible = False
        Me.GrdMain.Location = New System.Drawing.Point(0, 48)
        Me.GrdMain.Name = "GrdMain"
        Me.GrdMain.Size = New System.Drawing.Size(400, 472)
        Me.GrdMain.TabIndex = 11
        '
        'FrmSelect
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(398, 516)
        Me.Controls.Add(Me.GrdMain)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel4.ResumeLayout(False)
        CType(Me.GrdMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enum KindForm As Integer
        bank = 1
        vendor = 2
        account = 3
        Service = 4
    End Enum
    Public DSMAIN As New DataSet
    Public TypeOfForm As KindForm
    Dim flagselect As String = "all"
    Private Sub FrmSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case TypeOfForm
            Case KindForm.bank
                Call FillBank()
            Case KindForm.vendor
                Call FillVendor()
            Case KindForm.account
                Call FillAcount()
            Case KindForm.Service
                Call FillService()
        End Select
    End Sub
    Private Sub FillService()
        Try
            GrdMain.DataSource = DSMAIN.Tables("inv_tab_labor_service")
            GrdMain.RootTable.Columns.Add("days")
            GrdMain.RootTable.Columns("days").DataMember = "days"
            GrdMain.RootTable.Columns("days").Caption = "Days"
            GrdMain.RootTable.Columns("days").Width = 58
            GrdMain.RootTable.Columns("days").EditType = EditType.NoEdit
            GrdMain.RootTable.Columns("days").FilterEditType = FilterEditType.TextBox
            GrdMain.BringToFront()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FillBank()
        Try
            GrdMain.DataSource = DSMAIN.Tables("bank")
            GrdMain.BringToFront()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FillVendor()
        Try
            GrdMain.DataSource = DSMAIN.Tables("vendor")
            GrdMain.BringToFront()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FillAcount()
        Try
            GrdMain.DataSource = DSMAIN.Tables("account")
            GrdMain.BringToFront()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Me.Close()
    End Sub

    Private Sub BtnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeselect.Click

        'Dim str As String
        'Select Case TypeOfForm
        '    Case KindForm.bank
        '        str = "bank"
        '    Case KindForm.vendor
        '        str = "vendor"
        '    Case KindForm.account
        '        str = "account"
        'End Select
        'If DSMAIN.Tables(str).Rows.Count = 0 Then
        '    Exit Sub
        'End If

        'For i As Integer = 0 To DSMAIN.Tables(str).Rows.Count - 1
        '    DSMAIN.Tables(str).Rows(i).Item("flag") = False
        'Next
        Dim Currentrow As GridEXRow
        For i As Integer = 0 To GrdMain.RowCount - 1
            GrdMain.Row = i
            Currentrow = GrdMain.GetRow()
            Currentrow.Cells("flag").Value = False
        Next
        GrdMain.Refresh()





    End Sub

    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click

        'Dim str As String
        'Select Case TypeOfForm
        '    Case KindForm.bank
        '        str = "bank"
        '    Case KindForm.vendor
        '        str = "vendor"
        '    Case KindForm.account
        '        str = "account"
        'End Select
        'If DSMAIN.Tables(str).Rows.Count = 0 Then
        '    Exit Sub
        'End If

        'For i As Integer = 0 To DSMAIN.Tables(str).Rows.Count - 1
        '    DSMAIN.Tables(str).Rows(i).Item("flag") = True
        'Next


        Dim Currentrow As GridEXRow
        For i As Integer = 0 To GrdMain.RowCount - 1
            GrdMain.Row = i
            Currentrow = GrdMain.GetRow()
            Currentrow.Cells("flag").Value = True
        Next
        GrdMain.Refresh()


    End Sub

End Class
