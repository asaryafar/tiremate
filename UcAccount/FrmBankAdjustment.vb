Imports CommonClass
Public Class FrmBankAdjusTment
    Inherits FrmBase

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
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents TxtStorNo As System.Windows.Forms.TextBox
    Friend WithEvents ChkShared As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbBankAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DaBas_Banks As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmBankAdjusment1 As UcAccount.DsFrmBankAdjusment
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtRef As System.Windows.Forms.TextBox
    Friend WithEvents Employee_Cod1 As UCEmployee.Employee_Cod
    Friend WithEvents TxtDate As CalendarCombo.CalendarCombo
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Dabank_adjustment_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Dabank_adjustment_head As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBankAdjusTment))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.Employee_Cod1 = New UCEmployee.Employee_Cod
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.TxtRef = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtDate = New CalendarCombo.CalendarCombo
        Me.TxtStorNo = New System.Windows.Forms.TextBox
        Me.ChkShared = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmbBankAccount = New System.Windows.Forms.ComboBox
        Me.DsFrmBankAdjusment1 = New UcAccount.DsFrmBankAdjusment
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label33 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label36 = New System.Windows.Forms.Label
        Me.BtnFirst = New System.Windows.Forms.Button
        Me.Label37 = New System.Windows.Forms.Label
        Me.BtnLast = New System.Windows.Forms.Button
        Me.Label32 = New System.Windows.Forms.Label
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.BtnNext = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DaBas_Banks = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Dabank_adjustment_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Dabank_adjustment_head = New System.Data.SqlClient.SqlDataAdapter
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmBankAdjusment1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.Employee_Cod1)
        Me.PnlSearch.Controls.Add(Me.TxtRef)
        Me.PnlSearch.Controls.Add(Me.Label7)
        Me.PnlSearch.Controls.Add(Me.Label6)
        Me.PnlSearch.Controls.Add(Me.Label5)
        Me.PnlSearch.Controls.Add(Me.TxtDate)
        Me.PnlSearch.Controls.Add(Me.TxtStorNo)
        Me.PnlSearch.Controls.Add(Me.ChkShared)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Controls.Add(Me.CmbBankAccount)
        Me.PnlSearch.Controls.Add(Me.Label2)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(648, 59)
        Me.PnlSearch.TabIndex = 10
        '
        'Employee_Cod1
        '
        Me.Employee_Cod1.BackColor = System.Drawing.Color.White
        Me.Employee_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Employee_Cod1.Connection = Me.Cnn
        Me.Employee_Cod1.EmployeeCod = ""
        Me.Employee_Cod1.EmployeeCodLen = 5
        Me.Employee_Cod1.Kind_Employee = ""
        Me.Employee_Cod1.Location = New System.Drawing.Point(513, 27)
        Me.Employee_Cod1.Name = "Employee_Cod1"
        Me.Employee_Cod1.NotExitIfNotFound = False
        Me.Employee_Cod1.ReleaseIfNotFoundEmployeeCod = False
        Me.Employee_Cod1.Size = New System.Drawing.Size(111, 20)
        Me.Employee_Cod1.TabIndex = 18
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH;packet size=4096;user id=sa;data source=""."";persist secur" & _
        "ity info=True;initial catalog=Tiremate_02;password="
        '
        'TxtRef
        '
        Me.TxtRef.BackColor = System.Drawing.Color.White
        Me.TxtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRef.Location = New System.Drawing.Point(306, 27)
        Me.TxtRef.MaxLength = 20
        Me.TxtRef.Name = "TxtRef"
        Me.TxtRef.ReadOnly = True
        Me.TxtRef.Size = New System.Drawing.Size(120, 20)
        Me.TxtRef.TabIndex = 17
        Me.TxtRef.Text = "0"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(438, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Writen By"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(209, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Adjustment No"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Date"
        '
        'TxtDate
        '
        Me.TxtDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDate.BorderColor = System.Drawing.Color.Empty
        Me.TxtDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtDate.EditableSal = True
        Me.TxtDate.Image = CType(resources.GetObject("TxtDate.Image"), System.Drawing.Image)
        Me.TxtDate.Location = New System.Drawing.Point(90, 24)
        Me.TxtDate.MaxValue = CType(2500, Short)
        Me.TxtDate.MinValue = CType(1800, Short)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDate.Sal_Mali = Nothing
        Me.TxtDate.ShowButton = True
        Me.TxtDate.Size = New System.Drawing.Size(110, 23)
        Me.TxtDate.TabIndex = 13
        Me.TxtDate.VisualStyle = False
        '
        'TxtStorNo
        '
        Me.TxtStorNo.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtStorNo.Location = New System.Drawing.Point(544, 0)
        Me.TxtStorNo.Name = "TxtStorNo"
        Me.TxtStorNo.ReadOnly = True
        Me.TxtStorNo.Size = New System.Drawing.Size(80, 21)
        Me.TxtStorNo.TabIndex = 12
        Me.TxtStorNo.Text = ""
        '
        'ChkShared
        '
        Me.ChkShared.Enabled = False
        Me.ChkShared.Location = New System.Drawing.Point(297, -5)
        Me.ChkShared.Name = "ChkShared"
        Me.ChkShared.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkShared.Size = New System.Drawing.Size(117, 30)
        Me.ChkShared.TabIndex = 11
        Me.ChkShared.Text = "Share By All Store"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(438, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Only for this store no"
        '
        'CmbBankAccount
        '
        Me.CmbBankAccount.DataSource = Me.DsFrmBankAdjusment1.bas_banks
        Me.CmbBankAccount.DisplayMember = "name_bank"
        Me.CmbBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBankAccount.Location = New System.Drawing.Point(90, 1)
        Me.CmbBankAccount.Name = "CmbBankAccount"
        Me.CmbBankAccount.Size = New System.Drawing.Size(192, 21)
        Me.CmbBankAccount.TabIndex = 3
        Me.CmbBankAccount.ValueMember = "id_bank"
        '
        'DsFrmBankAdjusment1
        '
        Me.DsFrmBankAdjusment1.DataSetName = "DsFrmBankAdjusment"
        Me.DsFrmBankAdjusment1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bank Account"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Controls.Add(Me.BtnCancel)
        Me.Panel4.Controls.Add(Me.Label36)
        Me.Panel4.Controls.Add(Me.BtnFirst)
        Me.Panel4.Controls.Add(Me.Label37)
        Me.Panel4.Controls.Add(Me.BtnLast)
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Controls.Add(Me.BtnEdit)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.BtnDelete)
        Me.Panel4.Controls.Add(Me.BtnNew)
        Me.Panel4.Controls.Add(Me.BtnFind)
        Me.Panel4.Controls.Add(Me.BtnNext)
        Me.Panel4.Controls.Add(Me.BtnPrev)
        Me.Panel4.Controls.Add(Me.BtnSave)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(648, 45)
        Me.Panel4.TabIndex = 9
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(376, 31)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 10)
        Me.Label33.TabIndex = 194
        Me.Label33.Text = "Cancel"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(376, 0)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 193
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Location = New System.Drawing.Point(4, 31)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(33, 10)
        Me.Label36.TabIndex = 192
        Me.Label36.Text = "First"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.SystemColors.Window
        Me.BtnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFirst.Image = CType(resources.GetObject("BtnFirst.Image"), System.Drawing.Image)
        Me.BtnFirst.Location = New System.Drawing.Point(8, 1)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(33, 27)
        Me.BtnFirst.TabIndex = 191
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Location = New System.Drawing.Point(128, 31)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(33, 10)
        Me.Label37.TabIndex = 189
        Me.Label37.Text = "Last"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLast
        '
        Me.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLast.Image = CType(resources.GetObject("BtnLast.Image"), System.Drawing.Image)
        Me.BtnLast.Location = New System.Drawing.Point(128, 1)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 27)
        Me.BtnLast.TabIndex = 188
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Location = New System.Drawing.Point(256, 31)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(33, 10)
        Me.Label32.TabIndex = 184
        Me.Label32.Text = "Edit"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(256, 1)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(336, 31)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 10)
        Me.Label25.TabIndex = 176
        Me.Label25.Text = "Save"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(296, 31)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 10)
        Me.Label24.TabIndex = 175
        Me.Label24.Text = "Delete"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(216, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 10)
        Me.Label15.TabIndex = 174
        Me.Label15.Text = "New"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(176, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 10)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Find"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(48, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 10)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Prev"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(88, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 10)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Next"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(296, 1)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(216, 1)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(176, 1)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(88, 1)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 27)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(48, 1)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(336, 1)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'imageList1
        '
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'DaBas_Banks
        '
        Me.DaBas_Banks.SelectCommand = Me.SqlSelectCommand1
        Me.DaBas_Banks.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_banks", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("name_bank", "name_bank"), New System.Data.Common.DataColumnMapping("share_all_store", "share_all_store"), New System.Data.Common.DataColumnMapping("store_no", "store_no"), New System.Data.Common.DataColumnMapping("account_no", "account_no"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("contact_name", "contact_name"), New System.Data.Common.DataColumnMapping("GL_Account", "GL_Account"), New System.Data.Common.DataColumnMapping("start_check_no", "start_check_no"), New System.Data.Common.DataColumnMapping("next_check_no", "next_check_no"), New System.Data.Common.DataColumnMapping("default_bank", "default_bank"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("cod_account_type", "cod_account_type"), New System.Data.Common.DataColumnMapping("routing_numbers", "routing_numbers"), New System.Data.Common.DataColumnMapping("Bank_ID", "Bank_ID"), New System.Data.Common.DataColumnMapping("Web_Page", "Web_Page"), New System.Data.Common.DataColumnMapping("User_ID", "User_ID"), New System.Data.Common.DataColumnMapping("Password", "Password"), New System.Data.Common.DataColumnMapping("Security_code", "Security_code"), New System.Data.Common.DataColumnMapping("online_banking", "online_banking")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_bank, name_bank, share_all_store, store_no, account_no, address, zip, p" & _
        "hone_1, extension_1, phone_type_1, phone_main_1, phone_2, extension_2, phone_typ" & _
        "e_2, phone_main_2, phone_3, extension_3, phone_type_3, phone_main_3, phone_4, ex" & _
        "tension_4, phone_type_4, phone_main_4, phone_5, extension_5, phone_type_5, phone" & _
        "_main_5, email, contact_name, GL_Account, start_check_no, next_check_no, default" & _
        "_bank, inactive, cod_account_type, routing_numbers, Bank_ID, Web_Page, User_ID, " & _
        "Password, Security_code, online_banking FROM bas_banks"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Bank_Adjustment_dtl.Id_Adjustment_no, Bank_Adjustment_dtl.Radif, Bank_Adju" & _
        "stment_dtl.Gl_Account, Bank_Adjustment_dtl.debit_amount, Bank_Adjustment_dtl.dep" & _
        "osit_amount, Bank_Adjustment_dtl.Memo_Dtl, GL_account.desc_GL_account FROM Bank_" & _
        "Adjustment_dtl INNER JOIN GL_account ON Bank_Adjustment_dtl.Gl_Account = GL_acco" & _
        "unt.GL_account WHERE (Bank_Adjustment_dtl.Id_Adjustment_no = @Id_Adjustment_no)"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Adjustment_no", System.Data.SqlDbType.Int, 4, "Id_Adjustment_no"))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Bank_Adjustment_dtl(Id_Adjustment_no, Radif, Gl_Account, debit_amount" & _
        ", deposit_amount, Memo_Dtl) VALUES (@Id_Adjustment_no, @Radif, @Gl_Account, @deb" & _
        "it_amount, @deposit_amount, @Memo_Dtl); SELECT Id_Adjustment_no, Radif, Gl_Accou" & _
        "nt, debit_amount, deposit_amount, Memo_Dtl FROM Bank_Adjustment_dtl WHERE (Id_Ad" & _
        "justment_no = @Id_Adjustment_no) AND (Radif = @Radif)"
        Me.SqlInsertCommand2.CommandTimeout = 10
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Adjustment_no", System.Data.SqlDbType.Int, 4, "Id_Adjustment_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Radif", System.Data.SqlDbType.SmallInt, 2, "Radif"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_Account", System.Data.SqlDbType.VarChar, 10, "Gl_Account"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@debit_amount", System.Data.SqlDbType.Money, 8, "debit_amount"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deposit_amount", System.Data.SqlDbType.Money, 8, "deposit_amount"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Memo_Dtl", System.Data.SqlDbType.VarChar, 50, "Memo_Dtl"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Bank_Adjustment_dtl SET Id_Adjustment_no = @Id_Adjustment_no, Radif = @Rad" & _
        "if, Gl_Account = @Gl_Account, debit_amount = @debit_amount, deposit_amount = @de" & _
        "posit_amount, Memo_Dtl = @Memo_Dtl WHERE (Id_Adjustment_no = @Original_Id_Adjust" & _
        "ment_no) AND (Radif = @Original_Radif); SELECT Id_Adjustment_no, Radif, Gl_Accou" & _
        "nt, debit_amount, deposit_amount, Memo_Dtl FROM Bank_Adjustment_dtl WHERE (Id_Ad" & _
        "justment_no = @Id_Adjustment_no) AND (Radif = @Radif)"
        Me.SqlUpdateCommand2.CommandTimeout = 10
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Adjustment_no", System.Data.SqlDbType.Int, 4, "Id_Adjustment_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Radif", System.Data.SqlDbType.SmallInt, 2, "Radif"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_Account", System.Data.SqlDbType.VarChar, 10, "Gl_Account"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@debit_amount", System.Data.SqlDbType.Money, 8, "debit_amount"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deposit_amount", System.Data.SqlDbType.Money, 8, "deposit_amount"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Memo_Dtl", System.Data.SqlDbType.VarChar, 50, "Memo_Dtl"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Adjustment_no", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Adjustment_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Radif", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Bank_Adjustment_dtl WHERE (Id_Adjustment_no = @Original_Id_Adjustment" & _
        "_no) AND (Radif = @Original_Radif) AND (Gl_Account = @Original_Gl_Account) AND (" & _
        "Memo_Dtl = @Original_Memo_Dtl OR @Original_Memo_Dtl IS NULL AND Memo_Dtl IS NULL" & _
        ") AND (debit_amount = @Original_debit_amount) AND (deposit_amount = @Original_de" & _
        "posit_amount)"
        Me.SqlDeleteCommand2.CommandTimeout = 10
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Adjustment_no", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Adjustment_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gl_Account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gl_Account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Memo_Dtl", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Memo_Dtl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_debit_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "debit_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deposit_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deposit_amount", System.Data.DataRowVersion.Original, Nothing))
        '
        'Dabank_adjustment_Dtl
        '
        Me.Dabank_adjustment_Dtl.DeleteCommand = Me.SqlDeleteCommand2
        Me.Dabank_adjustment_Dtl.InsertCommand = Me.SqlInsertCommand2
        Me.Dabank_adjustment_Dtl.SelectCommand = Me.SqlSelectCommand3
        Me.Dabank_adjustment_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bank_Adjustment_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Adjustment_no", "Id_Adjustment_no"), New System.Data.Common.DataColumnMapping("Radif", "Radif"), New System.Data.Common.DataColumnMapping("Gl_Account", "Gl_Account"), New System.Data.Common.DataColumnMapping("debit_amount", "debit_amount"), New System.Data.Common.DataColumnMapping("deposit_amount", "deposit_amount"), New System.Data.Common.DataColumnMapping("Memo_Dtl", "Memo_Dtl")})})
        Me.Dabank_adjustment_Dtl.UpdateCommand = Me.SqlUpdateCommand2
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "Bank_Adjustment_dtl"
        Me.GrdDetail.DataSource = Me.DsFrmBankAdjusment1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>bank_check_dtl</Caption><Columns Collection" & _
        "=""true""><Column0 ID=""SelectGl""><ButtonDisplayMode>Always</ButtonDisplayMode><All" & _
        "owSort>False</AllowSort><Bound>False</Bound><ButtonStyle>ButtonCell</ButtonStyle" & _
        "><EditType>NoEdit</EditType><Key>SelectGl</Key><Position>0</Position><Selectable" & _
        ">False</Selectable><Width>24</Width></Column0><Column1 ID=""GL_Account""><Caption>" & _
        "GL Account No.</Caption><DataMember>GL_Account</DataMember><Key>GL_Account</Key>" & _
        "<Position>1</Position><Width>97</Width></Column1><Column2 ID=""desc_GL_account""><" & _
        "Caption>Accunt Name</Caption><DataMember>desc_GL_account</DataMember><Key>desc_G" & _
        "L_account</Key><Position>2</Position><Selectable>False</Selectable><Width>158</W" & _
        "idth></Column2><Column3 ID=""debit_amount""><Caption>Negative(-)</Caption><DataMem" & _
        "ber>debit_amount</DataMember><FormatString>c</FormatString><Key>debit_amount</Ke" & _
        "y><NullText>0</NullText><Position>3</Position></Column3><Column4 ID=""deposit_amo" & _
        "unt""><Caption>Positive(+)</Caption><DataMember>deposit_amount</DataMember><Forma" & _
        "tString>c</FormatString><Key>deposit_amount</Key><NullText>0</NullText><Position" & _
        ">4</Position></Column4><Column5 ID=""memo_dtl""><Caption>Memo</Caption><DataMember" & _
        ">memo_dtl</DataMember><Key>memo_dtl</Key><Position>5</Position><Width>155</Width" & _
        "><UpDownMaximum>200</UpDownMaximum></Column5></Columns><GroupCondition ID="""" /><" & _
        "Key>bank_check_dtl</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.ExternalImageList = Me.imageList1
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 116)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(648, 256)
        Me.GrdDetail.TabIndex = 11
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Id_Adjustment_no, adjustment_date, employee_cod, id_Bank, id_debit_deposit" & _
        "_head, id_GL_journal FROM bank_adjustment_head WHERE (Id_Adjustment_no = @id_adj" & _
        "ustment_no)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_adjustment_no", System.Data.SqlDbType.Int, 4, "Id_Adjustment_no"))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO bank_adjustment_head(adjustment_date, employee_cod, id_Bank, id_debit" & _
        "_deposit_head, id_GL_journal) VALUES (@adjustment_date, @employee_cod, @id_Bank," & _
        " @id_debit_deposit_head, @id_GL_journal); SELECT Id_Adjustment_no, adjustment_da" & _
        "te, employee_cod, id_Bank, id_debit_deposit_head, id_GL_journal FROM bank_adjust" & _
        "ment_head WHERE (Id_Adjustment_no = @@IDENTITY)"
        Me.SqlInsertCommand3.CommandTimeout = 10
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@adjustment_date", System.Data.SqlDbType.VarChar, 10, "adjustment_date"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_cod", System.Data.SqlDbType.VarChar, 5, "employee_cod"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_Bank", System.Data.SqlDbType.SmallInt, 2, "id_Bank"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "id_debit_deposit_head"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE bank_adjustment_head SET adjustment_date = @adjustment_date, employee_cod " & _
        "= @employee_cod, id_Bank = @id_Bank, id_debit_deposit_head = @id_debit_deposit_h" & _
        "ead, id_GL_journal = @id_GL_journal WHERE (Id_Adjustment_no = @Original_Id_Adjus" & _
        "tment_no) AND (adjustment_date = @Original_adjustment_date) AND (employee_cod = " & _
        "@Original_employee_cod) AND (id_Bank = @Original_id_Bank) AND (id_GL_journal = @" & _
        "Original_id_GL_journal OR @Original_id_GL_journal IS NULL AND id_GL_journal IS N" & _
        "ULL) AND (id_debit_deposit_head = @Original_id_debit_deposit_head OR @Original_i" & _
        "d_debit_deposit_head IS NULL AND id_debit_deposit_head IS NULL); SELECT Id_Adjus" & _
        "tment_no, adjustment_date, employee_cod, id_Bank, id_debit_deposit_head, id_GL_j" & _
        "ournal FROM bank_adjustment_head WHERE (Id_Adjustment_no = @Id_Adjustment_no)"
        Me.SqlUpdateCommand3.CommandTimeout = 10
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@adjustment_date", System.Data.SqlDbType.VarChar, 10, "adjustment_date"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_cod", System.Data.SqlDbType.VarChar, 5, "employee_cod"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_Bank", System.Data.SqlDbType.SmallInt, 2, "id_Bank"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "id_debit_deposit_head"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Adjustment_no", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Adjustment_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_adjustment_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "adjustment_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_cod", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_Bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_Bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_debit_deposit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Adjustment_no", System.Data.SqlDbType.Int, 4, "Id_Adjustment_no"))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM bank_adjustment_head WHERE (Id_Adjustment_no = @Original_Id_Adjustmen" & _
        "t_no) AND (adjustment_date = @Original_adjustment_date) AND (employee_cod = @Ori" & _
        "ginal_employee_cod) AND (id_Bank = @Original_id_Bank) AND (id_GL_journal = @Orig" & _
        "inal_id_GL_journal OR @Original_id_GL_journal IS NULL AND id_GL_journal IS NULL)" & _
        " AND (id_debit_deposit_head = @Original_id_debit_deposit_head OR @Original_id_de" & _
        "bit_deposit_head IS NULL AND id_debit_deposit_head IS NULL)"
        Me.SqlDeleteCommand3.CommandTimeout = 10
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Adjustment_no", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Adjustment_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_adjustment_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "adjustment_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_cod", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_Bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_Bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_debit_deposit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit_head", System.Data.DataRowVersion.Original, Nothing))
        '
        'Dabank_adjustment_head
        '
        Me.Dabank_adjustment_head.DeleteCommand = Me.SqlDeleteCommand3
        Me.Dabank_adjustment_head.InsertCommand = Me.SqlInsertCommand3
        Me.Dabank_adjustment_head.SelectCommand = Me.SqlSelectCommand4
        Me.Dabank_adjustment_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Adjustment_no", "Id_Adjustment_no"), New System.Data.Common.DataColumnMapping("adjustment_date", "adjustment_date"), New System.Data.Common.DataColumnMapping("employee_cod", "employee_cod"), New System.Data.Common.DataColumnMapping("id_Bank", "id_Bank"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        Me.Dabank_adjustment_head.UpdateCommand = Me.SqlUpdateCommand3
        '
        'FrmBankAdjusTment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 372)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmBankAdjusTment"
        Me.Text = "Bank Adjutsment"
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmBankAdjusment1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ClsAdj As ClsBankAdjustMent
    Dim WithEvents ClsGlAccount1 As ClsGlAccount
    Dim RowNoToAdd As Integer = 10
    Dim BeforeCel As Integer = -1
    Dim BeforeRow As Integer = -1
    Dim BeforeRowEx As Janus.Windows.GridEX.GridEXRow = Nothing
    Dim WithEvents MyFrm1 As UCGl_Account.FrmSearchGlAccount
    Dim Id_Adjustment_no As Decimal = 0
    Public LoadThis As Decimal = 0
    Dim clscheck1 As ClsCheck
    Private Sub FrmBankAdjusment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        Cnn.ConnectionString = PConnectionString
        CmdGeneral.Connection = Cnn
        Employee_Cod1.Connection = Cnn
        ClsGlAccount1 = New ClsGlAccount
        clscheck1 = New ClsCheck
        ClsAdj = New ClsBankAdjustMent
        ClsAdj.Connection = Cnn
        ClsGlAccount1.Connection = Cnn
        clscheck1.Connection = Cnn
        ThisFormStatus = MainModule.WorkStates.Cancel
        DaBas_Banks.Fill(DsFrmBankAdjusment1.bas_banks)
        TxtStorNo.Text = PubStoreName
        If DsFrmBankAdjusment1.bas_banks.Rows.Count <= 0 Then
            MsgFar("There is No Bank Row In Database File")
        End If
        TxtDate.Text = Format(Now, PubDateFormat)
        Call EnableDisableField(False)
        If LoadThis = 0 Then
            Call PFirstRecord(False)
        Else
            Call LoadIt(LoadThis)
        End If
    End Sub
    Private Sub LoadIt(ByVal ThisRefNo As String)
        'DsFrmReceiveReturnProduct1.Clear()
        Call ClearAllField()
        If ThisRefNo <> "" Then
            Dabank_adjustment_head.SelectCommand.Parameters("@Id_Adjustment_no").Value = ThisRefNo
            Dabank_adjustment_head.Fill(DsFrmBankAdjusment1.bank_adjustment_head)
            Try
                Dabank_adjustment_Dtl.SelectCommand.Parameters("@Id_Adjustment_no").Value = ThisRefNo
                Dabank_adjustment_Dtl.Fill(DsFrmBankAdjusment1.Bank_Adjustment_dtl)
            Catch ex As Exception
            End Try
            Call FillDataInScreen()
        End If
    End Sub
    Private Sub FillDataInScreen()
        With DsFrmBankAdjusment1.bank_adjustment_head
            Try
                If .Rows.Count > 0 Then
                    TxtRef.Text = .Rows(0).Item("Id_Adjustment_no") & ""
                    TxtDate.Text = .Rows(0).Item("adjustment_date") & ""
                    Employee_Cod1.EmployeeCod = .Rows(0).Item("employee_cod")
                    CmbBankAccount.SelectedValue = .Rows(0).Item("id_bank") & ""
                    Id_Adjustment_no = .Rows(0).Item("Id_Adjustment_no") & ""
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End With
    End Sub
    Private Sub CmbBankAccount_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbBankAccount.SelectedValueChanged
        Try
            Dim dr As DsFrmBankAdjusment.bas_banksRow = DsFrmBankAdjusment1.bas_banks.FindByid_bank(CmbBankAccount.SelectedValue)
            If Not dr Is Nothing Then
                ChkShared.Checked = dr.share_all_store
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#Region "Clear Fields"
    Private Sub ClearAllField()
        TxtRef.Text = ""
        TxtDate.Text = ""
        'Employee_Cod1.Text = .Rows(0).Item("employee_cod")
        Employee_Cod1.EmployeeCod = ""
        'CmbBankAccount.SelectedValue = .Rows(0).Item("id_bank") & ""
        DsFrmBankAdjusment1.Clear()
        DaBas_Banks.Fill(DsFrmBankAdjusment1)
        TxtRef.Clear()

    End Sub

#End Region
#Region "Buttomns Toolbar click"
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Call Psave()
    End Sub
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Call Paddnew()
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Call PEdit()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call PCancel()
    End Sub
    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        Call PFirstRecord()
    End Sub
    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        Call PPreviousRecord()
    End Sub
    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        Call PNextRecord()
    End Sub
    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        Call PLastRecord()
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Call PDelete()
    End Sub

#End Region
#Region "AdNewEditSave"
    Sub Paddnew()
        If Not CmbBankAccount.SelectedValue Is Nothing Then
            ThisFormStatus = MainModule.WorkStates.AddNew
            Call EnableDisableField(True)
            Call EnableDisableBtn()
            Call ClearAllField()
            TxtRef.Text = ClsAdj.MakeNewRefCod()
            'TxtNo_Of_Check.Text = ClsCheck1.LastNoCheck(CmbBankAccount.SelectedValue)
            TxtDate.Text = Format(Now.Date, PubDateFormat)
            Call AddEmptyRecordInDetail()
            CmbBankAccount.Focus()
            Dim d As Integer = clscheck1.FindDefaultBank
            If d <> 0 Then
                CmbBankAccount.SelectedValue = d
            End If
        End If
    End Sub
    Sub Psave()
        Try

            Dim Dr As DataRow
            Dim flg As Boolean = False

            If DsFrmBankAdjusment1.bank_adjustment_head.Rows.Count <= 0 Then
                Dr = DsFrmBankAdjusment1.bank_adjustment_head.NewRow()
                'Dr("id_Atm") = TxtRef.Text.Trim
                flg = True
            Else
                Dr = DsFrmBankAdjusment1.bank_adjustment_head.Rows(0)
            End If
            Dr("id_bank") = CmbBankAccount.SelectedValue
            Dr("adjustment_date") = TxtDate.Text
            Dr("employee_cod") = Employee_Cod1.EmployeeCod
            If flg Then
                DsFrmBankAdjusment1.bank_adjustment_head.Addbank_adjustment_headRow(Dr)
            End If
            '            #region "delete empty row"
            Dim i As Long
            Dim dr1 As DataRow()
            dr1 = DsFrmBankAdjusment1.Bank_Adjustment_dtl.Select("trim( gl_account) =''  ")
            For i = 0 To dr1.Length - 1
                dr1(i).Delete()
            Next
            Try
                Dabank_adjustment_head.Update(DsFrmBankAdjusment1.bank_adjustment_head)
                Id_Adjustment_no = DsFrmBankAdjusment1.bank_adjustment_head.Rows(0).Item("Id_Adjustment_no")
                For i = 0 To DsFrmBankAdjusment1.Bank_Adjustment_dtl.Rows.Count - 1
                    If DsFrmBankAdjusment1.Bank_Adjustment_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                        DsFrmBankAdjusment1.Bank_Adjustment_dtl.Rows(i).Item("Id_Adjustment_no") = Id_Adjustment_no
                    End If
                Next
                Dabank_adjustment_Dtl.Update(DsFrmBankAdjusment1.Bank_Adjustment_dtl)
                '                If RbBill.Checked = True Then
                If flg Then
                    Call InsertIntoGlDebitdiposit()
                Else
                    Call UpdateGlDebitDiposit()
                End If
                If Id_Adjustment_no <> Val(TxtRef.Text.Trim & "") Then
                    MsgFar("this adjustment is saved as Adjustment No " & Id_Adjustment_no)
                End If
            Catch ex As Exception
                Try
                    Dim Exerror As String = ex.ToString.ToUpper
                    If Exerror.IndexOf("Timeout expired".ToUpper) > 0 Then
                        MsgFar("This Transaction is Going to Close And You Can not edit it")
                        LoadIt(TxtRef.Text)
                    Else
                        MsgBox(ex.ToString)
                    End If
                Catch ex1 As Exception
                    MsgBox(ex1.ToString)
                End Try
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        Call EnableDisableField(False)
        Call EnableDisableBtn()
        Call LoadIt(TxtRef.Text)
    End Sub
    Sub PCancel()
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        Call EnableDisableField(False)
        Call EnableDisableBtn()
        TxtRef.Text = ClsAdj.LastRecord()
        Call LoadIt(TxtRef.Text)
    End Sub
    Sub PEdit()
        ' Get A Copy Of Dataset
        Dim AddEmptyRecordToDetailCount As Integer
        Dim IFirstCount As Integer   'Dsfrm..Rows.Count()
        If TxtRef.Text.Trim.Length > 0 Then
            ThisFormStatus = MainModule.WorkStates.Edit
            Call EnableDisableField(True)
            Call EnableDisableBtn()
            IFirstCount = DsFrmBankAdjusment1.Bank_Adjustment_dtl.Rows.Count()
            For AddEmptyRecordToDetailCount = 1 + IFirstCount To RowNoToAdd + IFirstCount
                Call AddEmptyRecordToDetail(TxtRef.Text, AddEmptyRecordToDetailCount)
            Next
        End If
        CmbBankAccount.Focus()
    End Sub
    Sub PDelete()
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Delete"
        c1.ShowFarMsg("Are you sure To Delete  This Adjustment ?")
        If c1.DialogResult = DialogResult.OK Then
            Try
                CmdGeneral.CommandTimeout = 10
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If

                CmdGeneral.CommandText = " Delete  from  GL_debit_deposit Where id_debit_deposit_head= " & Qt(DsFrmBankAdjusment1.bank_adjustment_head.Rows(0).Item("id_debit_deposit_head"))
                CmdGeneral.ExecuteNonQuery()

                CmdGeneral.CommandText = " Delete  from  GL_debit_deposit_head Where id_debit_deposit_head= " & Qt(DsFrmBankAdjusment1.bank_adjustment_head.Rows(0).Item("id_debit_deposit_head"))
                CmdGeneral.ExecuteNonQuery()

                CmdGeneral.CommandText = " Delete  from  bank_adjustment_dtl Where Id_Adjustment_no= " & Qt(DsFrmBankAdjusment1.bank_adjustment_head.Rows(0).Item("Id_Adjustment_no"))
                CmdGeneral.ExecuteNonQuery()
                CmdGeneral.CommandText = " Delete  from  bank_adjustment_head Where Id_Adjustment_no= " & Qt(DsFrmBankAdjusment1.bank_adjustment_head.Rows(0).Item("Id_Adjustment_no"))
                CmdGeneral.ExecuteNonQuery()
                PLastRecord()
            Catch ex As Exception
                Try
                    Dim Exerror As String = ex.ToString.ToUpper
                    If Exerror.IndexOf("Timeout expired".ToUpper) > 0 Then
                        MsgFar("This Transaction is Going to Close And You Can not Delete it")
                        LoadIt(TxtRef.Text)
                    Else
                        MsgBox(ex.ToString)
                    End If
                Catch ex1 As Exception
                    MsgBox(ex1.ToString)
                End Try
            End Try


        End If
    End Sub
#End Region
#Region "EnableDisable"
    Private Sub EnableDisableSave()
        Dim RowDetails As DataRow() = DsFrmBankAdjusment1.Bank_Adjustment_dtl.Select("trim(gl_account) <> ''")
        If Not CmbBankAccount.SelectedValue Is Nothing And BtnNew.Enabled = False And RowDetails.Length > 0 And Employee_Cod1.EmployeeCod & "" <> "" Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub

    Private Sub EnableDisableField(ByVal InStatus As Boolean)
        CmbBankAccount.Enabled = InStatus
        GrdDetail.Enabled = InStatus
        TxtDate.Enabled = InStatus
        Employee_Cod1.Enabled = InStatus

    End Sub
    Private Sub EnableDisableBtn()
        Select Case ThisFormStatus
            Case MainModule.WorkStates.AddNew, MainModule.WorkStates.Edit
                BtnFirst.Enabled = False
                BtnPrev.Enabled = False
                BtnNext.Enabled = False
                BtnLast.Enabled = False
                BtnEdit.Enabled = False
                BtnDelete.Enabled = False
                BtnFind.Enabled = False
                BtnNew.Enabled = False
                BtnCancel.Enabled = True
                BtnSave.Enabled = False
            Case MainModule.WorkStates._ReadOnly
                If TxtRef.Text.Trim.Length > 0 Then
                    BtnFirst.Enabled = True
                    BtnPrev.Enabled = True
                    BtnNext.Enabled = True
                    BtnLast.Enabled = True
                    BtnEdit.Enabled = True
                    BtnDelete.Enabled = True
                    BtnFind.Enabled = True
                Else
                    BtnFirst.Enabled = False
                    BtnPrev.Enabled = False
                    BtnNext.Enabled = False
                    BtnLast.Enabled = False
                    BtnEdit.Enabled = False
                    BtnDelete.Enabled = False
                    BtnFind.Enabled = False
                End If
                BtnNew.Enabled = True
                BtnCancel.Enabled = False
                BtnSave.Enabled = False
        End Select
    End Sub
#End Region
#Region "GrdDetail"
    Sub AddEmptyRecordInDetail()
        Dim IFirstCount As Integer = DsFrmBankAdjusment1.Bank_Adjustment_dtl.Rows.Count()
        Dim AddEmptyRecordToDetailCount As Integer
        For AddEmptyRecordToDetailCount = 1 + IFirstCount To RowNoToAdd + IFirstCount
            Call AddEmptyRecordToDetail(TxtRef.Text, AddEmptyRecordToDetailCount)
        Next
    End Sub
    Private Sub GrdDetail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.GotFocus
        SelectRow(GrdDetail.Row, 0)
    End Sub
    Sub SelectRow(ByVal ThisRow As Integer, Optional ByVal ThisItemCodeFocus As Integer = 1)
        GrdDetail.Row = ThisRow
        GrdDetail.Col = ThisItemCodeFocus
        GrdDetail.SelectCurrentCellText()
    End Sub


    Private Sub GrdDetail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdDetail.KeyDown
        If ThisFormStatus <> MainModule.WorkStates._ReadOnly Then
            Dim CurrentRow As Janus.Windows.GridEX.GridEXRow = GrdDetail.GetRow()
            Dim CurrentRowGrid As Long = 2
            Dim flg2 As Boolean = False

            Dim row As Integer = GrdDetail.Row
            Dim col As Integer = GrdDetail.Col
            '-------------------------------------------------------------
            Select Case e.Control
                Case True
                Case False
                    If e.Shift = False And e.Control = False And e.Alt = False Then
                        Select Case e.KeyCode
                            Case Windows.Forms.Keys.F2
                                Select Case GrdDetail.Col
                                    Case 1 ' ItemCode
                                        Call ShowSearch()
                                        Call SelectRow(row, 0)
                                        System.Windows.Forms.SendKeys.Send(vbTab)
                                End Select
                        End Select
                    End If
            End Select
        End If
    End Sub
    Private Sub GrdDetail_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.CurrentCellChanged
        Dim ValueString As String = ""
        Dim CurrentRowGrid As Long = GrdDetail.Row
        If BeforeRowEx Is Nothing Or BeforeCel = -1 Or BeforeRow = -1 Then
            Exit Sub
        End If
        Try
            ValueString = BeforeRowEx.Cells(BeforeCel).Value & ""
            Select Case BeforeCel
                Case 1
                    If ValueString.Trim & "" <> "" Then
                        If ClsGlAccount1.FindDesc(ValueString) = False Then
                            MsgFar("Cod is invalid")
                            Call SelectRow(CurrentRowGrid, 1)
                        Else

                        End If
                    End If
                Case 3, 4
                    If ValueString = "" Then
                        BeforeRowEx.Cells(BeforeCel).Value = 0
                    End If

                Case 6, 7 'QTY  ,  Price
                Case 8, 9
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GrdDetail_CurrentCellChanging(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.CurrentCellChangingEventArgs) Handles GrdDetail.CurrentCellChanging
        Call EnableDisableSave()
        Call InitBeforeRow()
    End Sub
    Private Sub GrdDetail_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.ColumnButtonClick
        Call ShowSearch()
    End Sub
    Sub ShowSearch()
        MyFrm1 = New UCGl_Account.FrmSearchGlAccount
        MyFrm1.ShowDialog()
    End Sub
    Sub InitBeforeRow()
        BeforeCel = GrdDetail.Col
        BeforeRow = GrdDetail.Row
        BeforeRowEx = GrdDetail.GetRow
    End Sub
#End Region
#Region "Previos-Last-Frist"
    Private Sub PFirstRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            ' If TxtRef.Text.Trim.Length > 0 Then
            Dim TXTRef_NoTmp As String = ClsAdj.PFirstRecord()
            If TXTRef_NoTmp = TxtRef.Text Then
                If ShowMsgFlag Then MsgFar("First Record")
            Else
                Call LoadIt(TXTRef_NoTmp)
            End If
            ' Else
            ' MsgFar("There is no Row in Database")
            ' End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PLastRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String = ClsAdj.LastRecord()
                If TXTRef_NoTmp = TxtRef.Text Then
                    If ShowMsgFlag Then MsgFar("Last Record")
                Else
                    Call LoadIt(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String = ClsAdj.Pprevious(TxtRef.Text.Trim)
                If TXTRef_NoTmp.Trim = TxtRef.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
                    If ShowMsgFlag Then MsgFar("First Record")
                Else
                    Call LoadIt(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PNextRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String = ClsAdj.PNext(TxtRef.Text)
                If TXTRef_NoTmp.Trim = TxtRef.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
                    If ShowMsgFlag Then MsgFar("Last Record")
                Else
                    Call LoadIt(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region
#Region "All Text Changed"
    Private Sub AllTxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Employee_Cod1.TextChanged, TxtDate.TextChanged, TxtRef.TextChanged
        '  TxtNumberString.Text = NumToString_Dollar(Txtamount_check.Text)
        EnableDisableSave()
    End Sub
#End Region
    Private Sub AddEmptyRecordToDetail(ByVal ThisId As Decimal, ByVal ThisRadif As Integer)
        Dim dr As DataRow
        dr = DsFrmBankAdjusment1.Bank_Adjustment_dtl.NewRow
        dr("Id_Adjustment_no") = ThisId
        dr("radif") = ThisRadif
        dr("gl_account") = ""
        dr("debit_amount") = 0
        dr("deposit_amount") = 0
        dr("memo_dtl") = ""
        DsFrmBankAdjusment1.Bank_Adjustment_dtl.Rows.Add(dr)
    End Sub
    'Private Sub VendoreOfInvoice1_FindThisRefNoForThisVendore(ByVal ThisRow As System.Data.DataRow) Handles TxtnvoiceNo.FindThisRefNoForThisVendore
    '    'TxtInvoiceDate.Text = ThisRow("receipt_bill_date")
    'End Sub

    Private Sub MyFrm1_GlAccountFind(ByVal ThisRow As System.Data.DataRow) Handles MyFrm1.GlAccountFind
        GrdDetail.GetRow.Cells(1).Value = ThisRow("Gl_Account")
        GrdDetail.GetRow.Cells(2).Value = ThisRow("Desc_Gl_Account")
        EnableDisableSave()
    End Sub

    Private Sub ClsGlAccount1_FindGlAccuntRow(ByVal ThisRow As System.Data.DataRow) Handles ClsGlAccount1.FindGlAccuntRow
        If Trim(GrdDetail.GetRow.Cells(1).Value) & "" <> "" Then
            GrdDetail.GetRow.Cells(2).Value = ThisRow("Desc_Gl_Account")
        End If
        EnableDisableSave()
    End Sub

    Private Sub ClsGlAccount1_NotFindGlaAccount() Handles ClsGlAccount1.NotFindGlaAccount
        GrdDetail.GetRow.Cells(2).Value = ""
        GrdDetail.GetRow.Cells(1).Value = ""
        EnableDisableSave()
        ' GrdDetail.selero()
    End Sub
#Region "Gl Debit Deposit"
    Private Sub InsertIntoGlDebitdiposit()
        CmdGeneral.Connection = Cnn
        Dim Mid_debit_deposit_head As Decimal = 0
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.CommandText = " Insert into Gl_debit_deposit_head(id_bank,date_doc)  values( " & Qt(CmbBankAccount.SelectedValue) & " , " & Qt(TxtDate.Text.Trim) & " ) ;Select id_debit_deposit_head from GL_debit_deposit_head where id_debit_deposit_head=@@IDENTITY"
            Mid_debit_deposit_head = CmdGeneral.ExecuteScalar()
            Dim i As Integer = 0
            For i = 0 To DsFrmBankAdjusment1.Bank_Adjustment_dtl.Rows.Count - 1
                With DsFrmBankAdjusment1.Bank_Adjustment_dtl.Rows(i)
                    CmdGeneral.CommandText = " Insert into GL_debit_deposit(id_debit_deposit_head,id_adjustment_no,type_transaction,debit_amount,deposit_amount,GL_account,Memo) " & _
                    "values( " & Mid_debit_deposit_head & " , " & Id_Adjustment_no & " , '6' , " & .Item("debit_amount") & " , " & .Item("deposit_amount") & " , " & Qt(.Item("GL_accounT")) & " , " & Qt(.Item("memo_dtl") & "") & " ) "
                    CmdGeneral.ExecuteNonQuery()
                End With
            Next
            '--------------------------------------
            CmdGeneral.CommandText = " Update bank_adjustment_head set id_debit_deposit_head =  " & Mid_debit_deposit_head & " Where Id_Adjustment_no = " & Id_Adjustment_no
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgFar("Error: Not inserted into Debit diposit Table ")
            MsgBox(ex.ToString)
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Sub
    Private Sub UpdateGlDebitDiposit()
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim Mid_debit_deposit_head As Decimal = 0
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            Mid_debit_deposit_head = CDec("0" & DsFrmBankAdjusment1.bank_adjustment_head.Rows(0).Item("id_debit_deposit_head"))
            If Mid_debit_deposit_head <> 0 Then
                CmdGeneral.CommandText = " Delete From  GL_debit_deposit  Where Id_Adjustment_no  =" & Id_Adjustment_no ' With 
                CmdGeneral.ExecuteNonQuery()
                Call InsertIntoGlDebitdiposit()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Sub
#End Region

    
End Class
