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
    Friend WithEvents GrdPos As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdEmp As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnDeselect As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSelect As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSelect))
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GrdPos = New Janus.Windows.GridEX.GridEX
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label50 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnDeselect = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GrdEmp = New Janus.Windows.GridEX.GridEX
        CType(Me.GrdPos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GrdEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrdPos
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>Flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>Flag</Key><Position>0</Position><Width>21</Width></Column0><Column1 ID" & _
        "=""code""><Caption>Code</Caption><DataMember>cod</DataMember><EditType>NoEdit</Edi" & _
        "tType><FilterEditType>TextBox</FilterEditType><Key>code</Key><Position>1</Positi" & _
        "on><SelectableCells>FilterRowCells</SelectableCells><Width>66</Width></Column1><" & _
        "Column2 ID=""col1""><Caption>Positions Desc</Caption><DataMember>col1</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>col1</Ke" & _
        "y><Position>2</Position><SelectableCells>FilterRowCells</SelectableCells><Width>" & _
        "177</Width></Column2><Column3 ID=""col2""><Caption>Service-Ok</Caption><ColumnType" & _
        ">CheckBox</ColumnType><DataMember>col2</DataMember><EditType>NoEdit</EditType><K" & _
        "ey>col2</Key><Position>3</Position><Width>66</Width></Column3></Columns><GroupCo" & _
        "ndition ID="""" /></RootTable></GridEXLayoutData>"
        Me.GrdPos.DesignTimeLayout = GridEXLayout1
        Me.GrdPos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdPos.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdPos.GroupByBoxVisible = False
        Me.GrdPos.Location = New System.Drawing.Point(0, 48)
        Me.GrdPos.Name = "GrdPos"
        Me.GrdPos.Size = New System.Drawing.Size(400, 472)
        Me.GrdPos.TabIndex = 7
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
        Me.Panel4.TabIndex = 12
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(336, 34)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 217
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
        Me.BtnSave.TabIndex = 216
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(264, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 10)
        Me.Label3.TabIndex = 215
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
        Me.BtnDeselect.TabIndex = 214
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(208, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 10)
        Me.Label2.TabIndex = 213
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
        Me.BtnSelect.TabIndex = 212
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
        'GrdEmp
        '
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>Flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>Flag</Key><Position>0</Position><Width>21</Width></Column0><Column1 ID" & _
        "=""code""><Caption>Code</Caption><DataMember>cod</DataMember><EditType>NoEdit</Edi" & _
        "tType><FilterEditType>TextBox</FilterEditType><Key>code</Key><Position>1</Positi" & _
        "on><SelectableCells>FilterRowCells</SelectableCells><Width>76</Width></Column1><" & _
        "Column2 ID=""col1""><Caption>Last Name</Caption><DataMember>col1</DataMember><Edit" & _
        "Type>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>col1</Key><Po" & _
        "sition>2</Position><SelectableCells>FilterRowCells</SelectableCells><Width>132</" & _
        "Width></Column2><Column3 ID=""col2""><Caption>First Name</Caption><DataMember>col2" & _
        "</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType>" & _
        "<Key>col2</Key><Position>3</Position><Width>114</Width></Column3></Columns><Grou" & _
        "pCondition ID="""" /><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex" & _
        ">2</ColIndex><SortOrder>Descending</SortOrder></SortKey0></SortKeys></RootTable>" & _
        "</GridEXLayoutData>"
        Me.GrdEmp.DesignTimeLayout = GridEXLayout2
        Me.GrdEmp.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdEmp.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdEmp.GroupByBoxVisible = False
        Me.GrdEmp.Location = New System.Drawing.Point(0, 48)
        Me.GrdEmp.Name = "GrdEmp"
        Me.GrdEmp.Size = New System.Drawing.Size(400, 472)
        Me.GrdEmp.TabIndex = 13
        '
        'FrmSelect
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(398, 516)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GrdPos)
        Me.Controls.Add(Me.GrdEmp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.GrdPos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GrdEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Enum KindForm As Integer
        Employee = 1
        Position = 2

    End Enum
    Public DSMAIN As New DataSet
    Public TypeOfForm As KindForm
    Dim flagselect As String = "all"
    Private Sub FrmSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case TypeOfForm
            Case KindForm.Employee
                Call FillEmp()
            Case KindForm.Position
                Call FillPos()

        End Select
    End Sub
    Private Sub FillEmp()
        Try
            GrdEmp.DataSource = DSMAIN.Tables("employee")
            GrdEmp.BringToFront()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FillPos()
        Try
            GrdPos.DataSource = DSMAIN.Tables("employee_position")
            GrdPos.BringToFront()
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
        '    Case KindForm.Employee
        '        str = "employee"
        '    Case KindForm.Position
        '        str = "employee_position"
        'End Select
        'If DSMAIN.Tables(str).Rows.Count = 0 Then
        '    Exit Sub
        'End If

        'For i As Integer = 0 To DSMAIN.Tables(str).Rows.Count - 1
        '    DSMAIN.Tables(str).Rows(i).Item("flag") = False
        'Next
        Select Case TypeOfForm
            Case KindForm.Employee
                Dim Currentrow As GridEXRow
                For i As Integer = 0 To GrdEmp.RowCount - 1
                    GrdEmp.Row = i
                    Currentrow = GrdEmp.GetRow()
                    Currentrow.Cells("flag").Value = False
                Next
                GrdEmp.Refresh()

            Case KindForm.Position
                Dim Currentrow As GridEXRow
                For i As Integer = 0 To GrdPos.RowCount - 1
                    GrdPos.Row = i
                    Currentrow = GrdPos.GetRow()
                    Currentrow.Cells("flag").Value = False
                Next
                GrdPos.Refresh()


        End Select




    End Sub

    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click

        'Dim str As String
        'Select Case TypeOfForm
        '    Case KindForm.Employee
        '        str = "employee"
        '    Case KindForm.Position
        '        str = "employee_position"
        'End Select
        'If DSMAIN.Tables(str).Rows.Count = 0 Then
        '    Exit Sub
        'End If

        'For i As Integer = 0 To DSMAIN.Tables(str).Rows.Count - 1
        '    DSMAIN.Tables(str).Rows(i).Item("flag") = True
        'Next
        Select Case TypeOfForm
            Case KindForm.Employee
                Dim Currentrow As GridEXRow
                For i As Integer = 0 To GrdEmp.RowCount - 1
                    GrdEmp.Row = i
                    Currentrow = GrdEmp.GetRow()
                    Currentrow.Cells("flag").Value = True
                Next
                GrdEmp.Refresh()

            Case KindForm.Position
                Dim Currentrow As GridEXRow
                For i As Integer = 0 To GrdPos.RowCount - 1
                    GrdPos.Row = i
                    Currentrow = GrdPos.GetRow()
                    Currentrow.Cells("flag").Value = True
                Next
                GrdPos.Refresh()


        End Select




    End Sub
End Class
