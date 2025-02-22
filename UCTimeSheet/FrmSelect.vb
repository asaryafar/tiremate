Imports CommonClass
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
    Friend WithEvents GrdMain As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnDeselect As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSelect As System.Windows.Forms.Button
    Friend WithEvents DsFrmRepEmployeeTime1 As UCTimeSheet.DSFrmRepEmployeeTime
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSelect))
        Me.GrdMain = New Janus.Windows.GridEX.GridEX
        Me.DsFrmRepEmployeeTime1 = New UCTimeSheet.DSFrmRepEmployeeTime
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label50 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnDeselect = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnSelect = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.GrdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmRepEmployeeTime1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdMain
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Flag""><Capti" & _
        "on>Flag</Caption><ColumnType>CheckBox</ColumnType><DataMember>Flag</DataMember><" & _
        "EditType>CheckBox</EditType><Key>Flag</Key><Position>0</Position><Width>35</Widt" & _
        "h></Column0><Column1 ID=""code""><Caption>Code</Caption><DataMember>code</DataMemb" & _
        "er><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>code<" & _
        "/Key><Position>1</Position><SelectableCells>FilterRowCells</SelectableCells><Wid" & _
        "th>96</Width></Column1><Column2 ID=""name""><Caption>Description</Caption><DataMem" & _
        "ber>name</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterE" & _
        "ditType><Key>name</Key><Position>2</Position><SelectableCells>FilterRowCells</Se" & _
        "lectableCells><Width>222</Width></Column2></Columns><GroupCondition ID="""" /></Ro" & _
        "otTable></GridEXLayoutData>"
        Me.GrdMain.DesignTimeLayout = GridEXLayout1
        Me.GrdMain.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdMain.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdMain.GroupByBoxVisible = False
        Me.GrdMain.Location = New System.Drawing.Point(0, 48)
        Me.GrdMain.Name = "GrdMain"
        Me.GrdMain.Size = New System.Drawing.Size(400, 480)
        Me.GrdMain.TabIndex = 0
        '
        'DsFrmRepEmployeeTime1
        '
        Me.DsFrmRepEmployeeTime1.DataSetName = "DSFrmRepEmployeeTime"
        Me.DsFrmRepEmployeeTime1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select the Item that reports you want to print"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Panel4.Size = New System.Drawing.Size(394, 48)
        Me.Panel4.TabIndex = 5
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(336, 32)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 205
        Me.Label50.Text = "Ok"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(336, 0)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 204
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(264, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 10)
        Me.Label3.TabIndex = 203
        Me.Label3.Text = "Deselect All"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDeselect
        '
        Me.BtnDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeselect.Image = CType(resources.GetObject("BtnDeselect.Image"), System.Drawing.Image)
        Me.BtnDeselect.Location = New System.Drawing.Point(280, 0)
        Me.BtnDeselect.Name = "BtnDeselect"
        Me.BtnDeselect.Size = New System.Drawing.Size(33, 27)
        Me.BtnDeselect.TabIndex = 202
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(200, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 10)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "Select All"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSelect
        '
        Me.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.Location = New System.Drawing.Point(216, 0)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(33, 27)
        Me.BtnSelect.TabIndex = 200
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 192
        Me.PictureBox2.TabStop = False
        '
        'FrmSelect
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(394, 528)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GrdMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.GrdMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmRepEmployeeTime1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enum KindForm As Integer
        Employee = 1
        EmployeePosition = 2
    End Enum

    Public DSFrmSelectDatasetVar As DataSet
    Public TypeOfForm As KindForm
    Dim flagselect As String = "all"
    Private Sub FrmSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case TypeOfForm
            Case KindForm.Employee
                GrdMain.DataSource = DSFrmSelectDatasetVar.Tables("Employee")
            Case KindForm.EmployeePosition
                GrdMain.DataSource = DSFrmSelectDatasetVar.Tables("employee_position")
        End Select
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Me.Close()
    End Sub
    Private Sub BtnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeselect.Click
        Dim Currentrow As GridEXRow
        For i As Integer = 0 To GrdMain.RowCount - 1
            GrdMain.Row = i
            Currentrow = GrdMain.GetRow()
            Currentrow.Cells("flag").Value = False
        Next
        GrdMain.Refresh()
    End Sub
    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        Dim Currentrow As GridEXRow
        For i As Integer = 0 To GrdMain.RowCount - 1
            GrdMain.Row = i
            Currentrow = GrdMain.GetRow()
            Currentrow.Cells("flag").Value = True
        Next
        GrdMain.Refresh()
    End Sub
End Class
