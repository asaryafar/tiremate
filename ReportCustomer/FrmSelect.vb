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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrdMain As Janus.Windows.GridEX.GridEX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GrdPerson As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnDeselect As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSelect As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSelect))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
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
        Me.GrdPerson = New Janus.Windows.GridEX.GridEX
        Me.Panel4.SuspendLayout()
        CType(Me.GrdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPerson, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel4.Size = New System.Drawing.Size(414, 56)
        Me.Panel4.TabIndex = 9
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(352, 40)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 199
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(352, 8)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 198
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(280, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 10)
        Me.Label3.TabIndex = 197
        Me.Label3.Text = "Deselect All"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDeselect
        '
        Me.BtnDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeselect.Image = CType(resources.GetObject("BtnDeselect.Image"), System.Drawing.Image)
        Me.BtnDeselect.Location = New System.Drawing.Point(296, 8)
        Me.BtnDeselect.Name = "BtnDeselect"
        Me.BtnDeselect.Size = New System.Drawing.Size(33, 27)
        Me.BtnDeselect.TabIndex = 196
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(224, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 10)
        Me.Label2.TabIndex = 195
        Me.Label2.Text = "Select All"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSelect
        '
        Me.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.Location = New System.Drawing.Point(240, 8)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(33, 27)
        Me.BtnSelect.TabIndex = 194
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(72, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 54)
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
        Me.PictureBox2.Size = New System.Drawing.Size(72, 54)
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
        "on><SelectableCells>FilterRowCells</SelectableCells><Width>92</Width></Column1><" & _
        "Column2 ID=""name""><Caption>Description</Caption><DataMember>description</DataMem" & _
        "ber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>name" & _
        "</Key><Position>2</Position><SelectableCells>FilterRowCells</SelectableCells><Wi" & _
        "dth>241</Width></Column2></Columns><GroupCondition ID="""" /><SortKeys Collection=" & _
        """true""><SortKey0 ID=""SortKey0""><ColIndex>1</ColIndex><SortOrder>Descending</Sort" & _
        "Order></SortKey0></SortKeys></RootTable></GridEXLayoutData>"
        Me.GrdMain.DesignTimeLayout = GridEXLayout1
        Me.GrdMain.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdMain.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdMain.GroupByBoxVisible = False
        Me.GrdMain.Location = New System.Drawing.Point(0, 56)
        Me.GrdMain.Name = "GrdMain"
        Me.GrdMain.Size = New System.Drawing.Size(416, 464)
        Me.GrdMain.TabIndex = 6
        '
        'GrdPerson
        '
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>23</Width></Column0><Column1 ID" & _
        "=""cod""><Caption>Customer</Caption><DataMember>cod</DataMember><EditType>NoEdit</" & _
        "EditType><FilterEditType>TextBox</FilterEditType><Key>cod</Key><Position>1</Posi" & _
        "tion><Width>73</Width></Column1><Column2 ID=""l_name""><Caption>Last Name</Caption" & _
        "><DataMember>l_name</DataMember><EditType>NoEdit</EditType><FilterEditType>TextB" & _
        "ox</FilterEditType><Key>l_name</Key><Position>2</Position><Width>81</Width></Col" & _
        "umn2><Column3 ID=""f_name""><Caption>First Name</Caption><DataMember>f_name</DataM" & _
        "ember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>f_" & _
        "name</Key><Position>3</Position><Width>71</Width></Column3><Column4 ID=""complete" & _
        "_name""><Caption>Company</Caption><DataMember>complete_name</DataMember><EditType" & _
        ">NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>complete_name</Ke" & _
        "y><Position>4</Position><Width>137</Width></Column4></Columns><GroupCondition ID" & _
        "="""" /></RootTable></GridEXLayoutData>"
        Me.GrdPerson.DesignTimeLayout = GridEXLayout2
        Me.GrdPerson.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdPerson.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdPerson.GroupByBoxVisible = False
        Me.GrdPerson.Location = New System.Drawing.Point(0, 56)
        Me.GrdPerson.Name = "GrdPerson"
        Me.GrdPerson.Size = New System.Drawing.Size(416, 464)
        Me.GrdPerson.TabIndex = 10
        '
        'FrmSelect
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(414, 516)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GrdMain)
        Me.Controls.Add(Me.GrdPerson)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel4.ResumeLayout(False)
        CType(Me.GrdMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enum KindForm As Integer
        customer = 1
        charge = 2
        type = 3
        source = 4
        clas = 5
        terr = 6
        sale = 7
    End Enum
    Public DSMAIN As DataSet
    Public TypeOfForm As KindForm
    Dim flagselect As String = "all"
    Private Sub FrmSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case TypeOfForm
            Case KindForm.customer
                Call FillCustomer()
            Case KindForm.charge
                Call FillCharge()
            Case KindForm.type
                Call FillType()
            Case KindForm.source
                Call FillSource()
            Case KindForm.clas
                Call FillClass()
            Case KindForm.terr
                Call FillTerr()
            Case KindForm.sale
                Call FillSale()
        End Select
    End Sub
    Private Sub FillCustomer()
        Try
            GrdPerson.DataSource = DSMAIN.Tables("customer")
            GrdPerson.BringToFront()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FillCharge()
        Try
            GrdMain.DataSource = DSMAIN.Tables("charge")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FillType()
        Try
            GrdMain.DataSource = DSMAIN.Tables("type")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FillSource()
        Try
            GrdMain.DataSource = DSMAIN.Tables("source")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FillClass()
        Try
            GrdMain.DataSource = DSMAIN.Tables("clas")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FillTerr()
        Try
            GrdMain.DataSource = DSMAIN.Tables("territory")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FillSale()
        Try
            GrdPerson.RootTable.Columns(1).Caption = "Code"
            GrdPerson.RootTable.Columns(4).Visible = False
            GrdPerson.DataSource = DSMAIN.Tables("employee")
            GrdPerson.BringToFront()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        'Dim str As String
        'Select Case TypeOfForm
        '    Case KindForm.customer
        '        str = "customer"
        '    Case KindForm.charge
        '        str = "charge"
        '    Case KindForm.type
        '        str = "type"
        '    Case KindForm.source
        '        str = "source"
        '    Case KindForm.clas
        '        str = "clas"
        '    Case KindForm.terr
        '        str = "territory"
        '    Case KindForm.sale
        '        str = "employee"
        'End Select
        'If DSMAIN.Tables(str).Rows.Count = 0 Then
        '    Exit Sub
        'End If

        'For i As Integer = 0 To DSMAIN.Tables(str).Rows.Count - 1
        '    DSMAIN.Tables(str).Rows(i).Item("flag") = True
        'Next

        If TypeOfForm = KindForm.sale Or TypeOfForm = KindForm.customer Then
            Dim Currentrow As GridEXRow
            For i As Integer = 0 To GrdPerson.RowCount - 1
                GrdPerson.Row = i
                Currentrow = GrdPerson.GetRow()
                Currentrow.Cells("flag").Value = True
            Next
            GrdPerson.Refresh()
        Else
            Dim Currentrow As GridEXRow
            For i As Integer = 0 To GrdMain.RowCount - 1
                GrdMain.Row = i
                Currentrow = GrdMain.GetRow()
                Currentrow.Cells("flag").Value = True
            Next
            GrdMain.Refresh()
        End If
        


    End Sub

    Private Sub BtnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeselect.Click
        'Dim str As String
        'Select Case TypeOfForm
        '    Case KindForm.customer
        '        str = "customer"
        '    Case KindForm.charge
        '        str = "charge"
        '    Case KindForm.type
        '        str = "type"
        '    Case KindForm.source
        '        str = "source"
        '    Case KindForm.clas
        '        str = "clas"
        '    Case KindForm.terr
        '        str = "territory"
        '    Case KindForm.sale
        '        str = "employee"
        'End Select
        'If DSMAIN.Tables(str).Rows.Count = 0 Then
        '    Exit Sub
        'End If

        'For i As Integer = 0 To DSMAIN.Tables(str).Rows.Count - 1
        '    DSMAIN.Tables(str).Rows(i).Item("flag") = False
        'Next

        If TypeOfForm = KindForm.sale Or TypeOfForm = KindForm.customer Then
            Dim Currentrow As GridEXRow
            For i As Integer = 0 To GrdPerson.RowCount - 1
                GrdPerson.Row = i
                Currentrow = GrdPerson.GetRow()
                Currentrow.Cells("flag").Value = False
            Next
            GrdPerson.Refresh()
        Else
            Dim Currentrow As GridEXRow
            For i As Integer = 0 To GrdMain.RowCount - 1
                GrdMain.Row = i
                Currentrow = GrdMain.GetRow()
                Currentrow.Cells("flag").Value = False
            Next
        End If

        GrdMain.Refresh()

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Me.Close()
    End Sub


End Class
