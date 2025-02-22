Imports CommonClass
Public Class FrmGlChartOfAccount
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
    Friend WithEvents cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GlAccount1 As UCGl_Account.GlAccount
    Friend WithEvents TxtRemark As System.Windows.Forms.TextBox
    'Friend WithEvents DsFrmGlChartOfAccount1 As UcAccount.DSFrmGlChartOfAccount
    Friend WithEvents TxtGl_Account As System.Windows.Forms.TextBox
    Friend WithEvents txtdesc_GL_account As System.Windows.Forms.TextBox
    Friend WithEvents Cmbgroup_GL_account As System.Windows.Forms.ComboBox
    Friend WithEvents CmbGl_account_group_subgroup1_code As System.Windows.Forms.ComboBox
    Friend WithEvents CmbGl_account_group_subgroup2_code As System.Windows.Forms.ComboBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGL_account_group As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGL_account_group_subgroup1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGL_account_group_subgroup2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmGlChartOfAccount1 As UcAccount.DSFrmGlChartOfAccount
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdInsert As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdUpdate As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmGlChartOfAccount))
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label40 = New System.Windows.Forms.Label
        Me.BtnFirst = New System.Windows.Forms.Button
        Me.Label41 = New System.Windows.Forms.Label
        Me.BtnLast = New System.Windows.Forms.Button
        Me.Label42 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label43 = New System.Windows.Forms.Label
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.BtnNext = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.cnn = New System.Data.SqlClient.SqlConnection
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.GlAccount1 = New UCGl_Account.GlAccount
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtGl_Account = New System.Windows.Forms.TextBox
        Me.txtdesc_GL_account = New System.Windows.Forms.TextBox
        Me.Cmbgroup_GL_account = New System.Windows.Forms.ComboBox
        Me.DsFrmGlChartOfAccount1 = New UcAccount.DSFrmGlChartOfAccount
        Me.CmbGl_account_group_subgroup1_code = New System.Windows.Forms.ComboBox
        Me.CmbGl_account_group_subgroup2_code = New System.Windows.Forms.ComboBox
        Me.TxtRemark = New System.Windows.Forms.TextBox
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaGL_account_group = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaGL_account_group_subgroup1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaGL_account_group_subgroup2 = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CmdInsert = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdate = New System.Data.SqlClient.SqlCommand
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4.SuspendLayout()
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmGlChartOfAccount1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label40)
        Me.Panel4.Controls.Add(Me.BtnFirst)
        Me.Panel4.Controls.Add(Me.Label41)
        Me.Panel4.Controls.Add(Me.BtnLast)
        Me.Panel4.Controls.Add(Me.Label42)
        Me.Panel4.Controls.Add(Me.BtnCancel)
        Me.Panel4.Controls.Add(Me.Label43)
        Me.Panel4.Controls.Add(Me.BtnEdit)
        Me.Panel4.Controls.Add(Me.Label50)
        Me.Panel4.Controls.Add(Me.Label51)
        Me.Panel4.Controls.Add(Me.Label52)
        Me.Panel4.Controls.Add(Me.Label53)
        Me.Panel4.Controls.Add(Me.Label54)
        Me.Panel4.Controls.Add(Me.Label55)
        Me.Panel4.Controls.Add(Me.BtnDelete)
        Me.Panel4.Controls.Add(Me.BtnNew)
        Me.Panel4.Controls.Add(Me.BtnFind)
        Me.Panel4.Controls.Add(Me.BtnNext)
        Me.Panel4.Controls.Add(Me.BtnPrev)
        Me.Panel4.Controls.Add(Me.BtnSave)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(574, 45)
        Me.Panel4.TabIndex = 6
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Location = New System.Drawing.Point(17, 31)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(33, 10)
        Me.Label40.TabIndex = 212
        Me.Label40.Text = "First"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.SystemColors.Window
        Me.BtnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFirst.Image = CType(resources.GetObject("BtnFirst.Image"), System.Drawing.Image)
        Me.BtnFirst.Location = New System.Drawing.Point(14, 2)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(33, 27)
        Me.BtnFirst.TabIndex = 211
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Location = New System.Drawing.Point(144, 31)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(33, 10)
        Me.Label41.TabIndex = 210
        Me.Label41.Text = "Last"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLast
        '
        Me.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLast.Image = CType(resources.GetObject("BtnLast.Image"), System.Drawing.Image)
        Me.BtnLast.Location = New System.Drawing.Point(143, 2)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 27)
        Me.BtnLast.TabIndex = 209
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(436, 31)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(39, 10)
        Me.Label42.TabIndex = 208
        Me.Label42.Text = "Cancel"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(439, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 200
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Location = New System.Drawing.Point(314, 31)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(33, 10)
        Me.Label43.TabIndex = 207
        Me.Label43.Text = "Edit"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(311, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 197
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(395, 31)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 206
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Location = New System.Drawing.Point(353, 31)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(37, 10)
        Me.Label51.TabIndex = 205
        Me.Label51.Text = "Delete"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(270, 31)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(33, 10)
        Me.Label52.TabIndex = 204
        Me.Label52.Text = "New"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Location = New System.Drawing.Point(208, 31)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(33, 10)
        Me.Label53.TabIndex = 203
        Me.Label53.Text = "Find"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Location = New System.Drawing.Point(57, 31)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(33, 10)
        Me.Label54.TabIndex = 202
        Me.Label54.Text = "Prev"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Location = New System.Drawing.Point(102, 31)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(33, 10)
        Me.Label55.TabIndex = 201
        Me.Label55.Text = "Next"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(353, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 198
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(271, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 196
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(207, 2)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 195
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(100, 2)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 27)
        Me.BtnNext.TabIndex = 194
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(57, 2)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrev.TabIndex = 193
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(395, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 199
        '
        'cnn
        '
        Me.cnn.ConnectionString = "workstation id=FARAJI1;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_01;password=sa"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Account No"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Description"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "GL Account Groups"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "GL Account Subgroup1"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "GL Account Subgroup2"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 23)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "General Desc"
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.GlAccount1)
        Me.PnlSearch.Controls.Add(Me.Label9)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(574, 27)
        Me.PnlSearch.TabIndex = 14
        '
        'GlAccount1
        '
        Me.GlAccount1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GlAccount1.Cod_Gl = ""
        Me.GlAccount1.Connection = Me.cnn
        Me.GlAccount1.Location = New System.Drawing.Point(96, 1)
        Me.GlAccount1.Name = "GlAccount1"
        Me.GlAccount1.NotExitIfNotFound = False
        Me.GlAccount1.ReleaseIfNotFoundEmployeeCod = False
        Me.GlAccount1.Size = New System.Drawing.Size(152, 20)
        Me.GlAccount1.TabIndex = 189
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(6, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 188
        Me.Label9.Text = "Account No"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtGl_Account
        '
        Me.TxtGl_Account.Location = New System.Drawing.Point(144, 8)
        Me.TxtGl_Account.MaxLength = 10
        Me.TxtGl_Account.Name = "TxtGl_Account"
        Me.TxtGl_Account.Size = New System.Drawing.Size(128, 20)
        Me.TxtGl_Account.TabIndex = 15
        Me.TxtGl_Account.Text = ""
        '
        'txtdesc_GL_account
        '
        Me.txtdesc_GL_account.Location = New System.Drawing.Point(144, 40)
        Me.txtdesc_GL_account.MaxLength = 50
        Me.txtdesc_GL_account.Name = "txtdesc_GL_account"
        Me.txtdesc_GL_account.Size = New System.Drawing.Size(354, 20)
        Me.txtdesc_GL_account.TabIndex = 16
        Me.txtdesc_GL_account.Text = ""
        '
        'Cmbgroup_GL_account
        '
        Me.Cmbgroup_GL_account.DataSource = Me.DsFrmGlChartOfAccount1.GL_account_group
        Me.Cmbgroup_GL_account.DisplayMember = "desc_group_account"
        Me.Cmbgroup_GL_account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbgroup_GL_account.Location = New System.Drawing.Point(144, 72)
        Me.Cmbgroup_GL_account.Name = "Cmbgroup_GL_account"
        Me.Cmbgroup_GL_account.Size = New System.Drawing.Size(258, 21)
        Me.Cmbgroup_GL_account.TabIndex = 17
        Me.Cmbgroup_GL_account.ValueMember = "group_GL_account"
        '
        'DsFrmGlChartOfAccount1
        '
        Me.DsFrmGlChartOfAccount1.DataSetName = "DSFrmGlChartOfAccount"
        Me.DsFrmGlChartOfAccount1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmbGl_account_group_subgroup1_code
        '
        Me.CmbGl_account_group_subgroup1_code.DataSource = Me.DsFrmGlChartOfAccount1.GL_account_group_subgroup1
        Me.CmbGl_account_group_subgroup1_code.DisplayMember = "Gl_account_group_subgroup1_desc"
        Me.CmbGl_account_group_subgroup1_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGl_account_group_subgroup1_code.Location = New System.Drawing.Point(144, 104)
        Me.CmbGl_account_group_subgroup1_code.Name = "CmbGl_account_group_subgroup1_code"
        Me.CmbGl_account_group_subgroup1_code.Size = New System.Drawing.Size(258, 21)
        Me.CmbGl_account_group_subgroup1_code.TabIndex = 18
        Me.CmbGl_account_group_subgroup1_code.ValueMember = "Gl_account_group_subgroup1_code"
        '
        'CmbGl_account_group_subgroup2_code
        '
        Me.CmbGl_account_group_subgroup2_code.DataSource = Me.DsFrmGlChartOfAccount1.GL_account_group_subgroup2
        Me.CmbGl_account_group_subgroup2_code.DisplayMember = "Gl_account_group_subgroup2_desc"
        Me.CmbGl_account_group_subgroup2_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGl_account_group_subgroup2_code.Location = New System.Drawing.Point(144, 136)
        Me.CmbGl_account_group_subgroup2_code.Name = "CmbGl_account_group_subgroup2_code"
        Me.CmbGl_account_group_subgroup2_code.Size = New System.Drawing.Size(258, 21)
        Me.CmbGl_account_group_subgroup2_code.TabIndex = 19
        Me.CmbGl_account_group_subgroup2_code.ValueMember = "Gl_account_group_subgroup2_code"
        '
        'TxtRemark
        '
        Me.TxtRemark.Location = New System.Drawing.Point(144, 168)
        Me.TxtRemark.MaxLength = 30
        Me.TxtRemark.Multiline = True
        Me.TxtRemark.Name = "TxtRemark"
        Me.TxtRemark.Size = New System.Drawing.Size(352, 56)
        Me.TxtRemark.TabIndex = 20
        Me.TxtRemark.Text = ""
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT group_GL_account, desc_group_account FROM GL_account_group"
        Me.SqlSelectCommand1.Connection = Me.cnn
        '
        'DaGL_account_group
        '
        Me.DaGL_account_group.SelectCommand = Me.SqlSelectCommand1
        Me.DaGL_account_group.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_group", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("group_GL_account", "group_GL_account"), New System.Data.Common.DataColumnMapping("desc_group_account", "desc_group_account")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Gl_account_group_subgroup1_code, Gl_account_group_subgroup1_desc FROM GL_a" & _
        "ccount_group_subgroup1"
        Me.SqlSelectCommand2.Connection = Me.cnn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO GL_account_group_subgroup1(Gl_account_group_subgroup1_code, Gl_accoun" & _
        "t_group_subgroup1_desc) VALUES (@Gl_account_group_subgroup1_code, @Gl_account_gr" & _
        "oup_subgroup1_desc); SELECT Gl_account_group_subgroup1_code, Gl_account_group_su" & _
        "bgroup1_desc FROM GL_account_group_subgroup1 WHERE (Gl_account_group_subgroup1_c" & _
        "ode = @Gl_account_group_subgroup1_code)"
        Me.SqlInsertCommand1.Connection = Me.cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_account_group_subgroup1_code", System.Data.SqlDbType.VarChar, 2, "Gl_account_group_subgroup1_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_account_group_subgroup1_desc", System.Data.SqlDbType.VarChar, 50, "Gl_account_group_subgroup1_desc"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE GL_account_group_subgroup1 SET Gl_account_group_subgroup1_code = @Gl_accou" & _
        "nt_group_subgroup1_code, Gl_account_group_subgroup1_desc = @Gl_account_group_sub" & _
        "group1_desc WHERE (Gl_account_group_subgroup1_code = @Original_Gl_account_group_" & _
        "subgroup1_code) AND (Gl_account_group_subgroup1_desc = @Original_Gl_account_grou" & _
        "p_subgroup1_desc OR @Original_Gl_account_group_subgroup1_desc IS NULL AND Gl_acc" & _
        "ount_group_subgroup1_desc IS NULL); SELECT Gl_account_group_subgroup1_code, Gl_a" & _
        "ccount_group_subgroup1_desc FROM GL_account_group_subgroup1 WHERE (Gl_account_gr" & _
        "oup_subgroup1_code = @Gl_account_group_subgroup1_code)"
        Me.SqlUpdateCommand1.Connection = Me.cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_account_group_subgroup1_code", System.Data.SqlDbType.VarChar, 2, "Gl_account_group_subgroup1_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_account_group_subgroup1_desc", System.Data.SqlDbType.VarChar, 50, "Gl_account_group_subgroup1_desc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gl_account_group_subgroup1_code", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gl_account_group_subgroup1_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gl_account_group_subgroup1_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gl_account_group_subgroup1_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM GL_account_group_subgroup1 WHERE (Gl_account_group_subgroup1_code = @" & _
        "Original_Gl_account_group_subgroup1_code) AND (Gl_account_group_subgroup1_desc =" & _
        " @Original_Gl_account_group_subgroup1_desc OR @Original_Gl_account_group_subgrou" & _
        "p1_desc IS NULL AND Gl_account_group_subgroup1_desc IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gl_account_group_subgroup1_code", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gl_account_group_subgroup1_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gl_account_group_subgroup1_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gl_account_group_subgroup1_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaGL_account_group_subgroup1
        '
        Me.DaGL_account_group_subgroup1.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaGL_account_group_subgroup1.InsertCommand = Me.SqlInsertCommand1
        Me.DaGL_account_group_subgroup1.SelectCommand = Me.SqlSelectCommand2
        Me.DaGL_account_group_subgroup1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_group_subgroup1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Gl_account_group_subgroup1_code", "Gl_account_group_subgroup1_code"), New System.Data.Common.DataColumnMapping("Gl_account_group_subgroup1_desc", "Gl_account_group_subgroup1_desc")})})
        Me.DaGL_account_group_subgroup1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Gl_account_group_subgroup2_code, Gl_account_group_subgroup2_desc FROM GL_a" & _
        "ccount_group_subgroup2"
        Me.SqlSelectCommand3.Connection = Me.cnn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO GL_account_group_subgroup2(Gl_account_group_subgroup2_code, Gl_accoun" & _
        "t_group_subgroup2_desc) VALUES (@Gl_account_group_subgroup2_code, @Gl_account_gr" & _
        "oup_subgroup2_desc); SELECT Gl_account_group_subgroup2_code, Gl_account_group_su" & _
        "bgroup2_desc FROM GL_account_group_subgroup2 WHERE (Gl_account_group_subgroup2_c" & _
        "ode = @Gl_account_group_subgroup2_code)"
        Me.SqlInsertCommand2.Connection = Me.cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_account_group_subgroup2_code", System.Data.SqlDbType.VarChar, 2, "Gl_account_group_subgroup2_code"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_account_group_subgroup2_desc", System.Data.SqlDbType.VarChar, 50, "Gl_account_group_subgroup2_desc"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE GL_account_group_subgroup2 SET Gl_account_group_subgroup2_code = @Gl_accou" & _
        "nt_group_subgroup2_code, Gl_account_group_subgroup2_desc = @Gl_account_group_sub" & _
        "group2_desc WHERE (Gl_account_group_subgroup2_code = @Original_Gl_account_group_" & _
        "subgroup2_code) AND (Gl_account_group_subgroup2_desc = @Original_Gl_account_grou" & _
        "p_subgroup2_desc OR @Original_Gl_account_group_subgroup2_desc IS NULL AND Gl_acc" & _
        "ount_group_subgroup2_desc IS NULL); SELECT Gl_account_group_subgroup2_code, Gl_a" & _
        "ccount_group_subgroup2_desc FROM GL_account_group_subgroup2 WHERE (Gl_account_gr" & _
        "oup_subgroup2_code = @Gl_account_group_subgroup2_code)"
        Me.SqlUpdateCommand2.Connection = Me.cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_account_group_subgroup2_code", System.Data.SqlDbType.VarChar, 2, "Gl_account_group_subgroup2_code"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_account_group_subgroup2_desc", System.Data.SqlDbType.VarChar, 50, "Gl_account_group_subgroup2_desc"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gl_account_group_subgroup2_code", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gl_account_group_subgroup2_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gl_account_group_subgroup2_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gl_account_group_subgroup2_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM GL_account_group_subgroup2 WHERE (Gl_account_group_subgroup2_code = @" & _
        "Original_Gl_account_group_subgroup2_code) AND (Gl_account_group_subgroup2_desc =" & _
        " @Original_Gl_account_group_subgroup2_desc OR @Original_Gl_account_group_subgrou" & _
        "p2_desc IS NULL AND Gl_account_group_subgroup2_desc IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gl_account_group_subgroup2_code", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gl_account_group_subgroup2_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gl_account_group_subgroup2_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gl_account_group_subgroup2_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaGL_account_group_subgroup2
        '
        Me.DaGL_account_group_subgroup2.DeleteCommand = Me.SqlDeleteCommand2
        Me.DaGL_account_group_subgroup2.InsertCommand = Me.SqlInsertCommand2
        Me.DaGL_account_group_subgroup2.SelectCommand = Me.SqlSelectCommand3
        Me.DaGL_account_group_subgroup2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_group_subgroup2", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Gl_account_group_subgroup2_code", "Gl_account_group_subgroup2_code"), New System.Data.Common.DataColumnMapping("Gl_account_group_subgroup2_desc", "Gl_account_group_subgroup2_desc")})})
        Me.DaGL_account_group_subgroup2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.cnn
        '
        'CmdInsert
        '
        Me.CmdInsert.CommandText = "INSERT INTO GL_account (GL_account, desc_GL_account, group_GL_account, Gl_account" & _
        "_group_subgroup1_code, Gl_account_group_subgroup2_code, remark) VALUES (@GL_acco" & _
        "unt, @desc_GL_account, @group_GL_account, @Gl_account_group_subgroup1_code, @Gl_" & _
        "account_group_subgroup2_code, @remark)"
        Me.CmdInsert.Connection = Me.cnn
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_GL_account", System.Data.SqlDbType.VarChar, 50, "desc_GL_account"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@group_GL_account", System.Data.SqlDbType.VarChar, 2, "group_GL_account"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_account_group_subgroup1_code", System.Data.SqlDbType.VarChar, 2, "Gl_account_group_subgroup1_code"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_account_group_subgroup2_code", System.Data.SqlDbType.VarChar, 2, "Gl_account_group_subgroup2_code"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE GL_account SET desc_GL_account = @desc_GL_account, group_GL_account = @gro" & _
        "up_GL_account, Gl_account_group_subgroup1_code = @Gl_account_group_subgroup1_cod" & _
        "e, Gl_account_group_subgroup2_code = @Gl_account_group_subgroup2_code, remark = " & _
        "@remark WHERE (GL_account = @GL_account)"
        Me.CmdUpdate.Connection = Me.cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_GL_account", System.Data.SqlDbType.VarChar, 50, "desc_GL_account"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@group_GL_account", System.Data.SqlDbType.VarChar, 2, "group_GL_account"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_account_group_subgroup1_code", System.Data.SqlDbType.VarChar, 2, "Gl_account_group_subgroup1_code"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_account_group_subgroup2_code", System.Data.SqlDbType.VarChar, 2, "Gl_account_group_subgroup2_code"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtdesc_GL_account)
        Me.Panel1.Controls.Add(Me.Cmbgroup_GL_account)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.CmbGl_account_group_subgroup1_code)
        Me.Panel1.Controls.Add(Me.CmbGl_account_group_subgroup2_code)
        Me.Panel1.Controls.Add(Me.TxtRemark)
        Me.Panel1.Controls.Add(Me.TxtGl_Account)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 248)
        Me.Panel1.TabIndex = 21
        '
        'FrmGlChartOfAccount
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(574, 324)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmGlChartOfAccount"
        Me.Text = "Gl Chart Of Accounts"
        Me.Panel4.ResumeLayout(False)
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmGlChartOfAccount1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim PnlSearchHeight As Int32
    Dim GlaccountCodTempVar As String = ""
    Dim WithEvents frmshow1 As UCGl_Account.FrmGlChartOfAccountSearch
    Private Sub FrmGlChartOfAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cnn.ConnectionString = PConnectionString
        PnlSearchHeight = PnlSearch.Height
        ThisFormStatus = MainModule.WorkStates.Cancel
        Call FillDataSets()
        Call PFirstRecord(False)
        Call AfterSaveOrCancel()
        GlAccount1.Focus()
    End Sub
#Region " last first next previ"


    Private Sub PFirstRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Try
            Dim TXTSearchGlCodTemp As String
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 Gl_account from GL_account Order BY  gl_account  ASC"
            TXTSearchGlCodTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchGlCodTemp) Then
                TXTSearchGlCodTemp = ""
            End If
            If TXTSearchGlCodTemp = GlAccount1.Text Or TXTSearchGlCodTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the First record of this table.")
            Else
                GlAccount1.Text = TXTSearchGlCodTemp
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchGlCodTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 Gl_account from GL_account where gl_account <" & Qt(GlAccount1.Text) & " Order BY  gl_account DESC"
        TXTSearchGlCodTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchGlCodTemp) Then
            TXTSearchGlCodTemp = ""
        End If
        If TXTSearchGlCodTemp = GlAccount1.Text Or TXTSearchGlCodTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            GlAccount1.Text = TXTSearchGlCodTemp
            GlaccountCodTempVar = TXTSearchGlCodTemp

        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchGlCodTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 Gl_account from GL_account where GL_account >" & Qt(GlAccount1.Text) & " Order BY  GL_account ASC"
        TXTSearchGlCodTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchGlCodTemp) Then
            TXTSearchGlCodTemp = ""
        End If
        If TXTSearchGlCodTemp = GlAccount1.Text Or TXTSearchGlCodTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            GlAccount1.Text = TXTSearchGlCodTemp
            GlaccountCodTempVar = TXTSearchGlCodTemp
            ' = TXTSearchCustomerCodTemp
            '''''''''''''Call FillFields(CustomerCod1.Text)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Try
            Dim TXTSearchCustomerCodTemp As String
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 Gl_account from Gl_account Order BY Gl_account  DESC"
            TXTSearchCustomerCodTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchCustomerCodTemp) Then
                TXTSearchCustomerCodTemp = ""
            End If
            If TXTSearchCustomerCodTemp = GlAccount1.Text Or TXTSearchCustomerCodTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the Last record of this table.")
            Else
                GlAccount1.Text = TXTSearchCustomerCodTemp
                '''''''''''''Call FillFields(CustomerCod1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region
    Sub AfterSaveOrCancel()
        BtnSave.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        If TxtGl_Account.Text.Trim.Length = 0 Then
            BtnDelete.Enabled = False

            BtnEdit.Enabled = False

            BtnPrev.Enabled = False
            BtnNext.Enabled = False
            BtnFirst.Enabled = False
            BtnLast.Enabled = False
        Else
            BtnDelete.Enabled = True
            BtnEdit.Enabled = True
            BtnPrev.Enabled = True
            BtnNext.Enabled = True
            BtnFirst.Enabled = True
            BtnLast.Enabled = True
        End If
        Call EnableField(False)
    End Sub
    Friend Sub EnableField(ByVal instatus As Boolean)
        If ThisFormStatus = MainModule.WorkStates.AddNew Then
            TxtGl_Account.Enabled = instatus
        Else
            TxtGl_Account.Enabled = False
        End If
        txtdesc_GL_account.Enabled = instatus
        Cmbgroup_GL_account.Enabled = instatus
        CmbGl_account_group_subgroup1_code.Enabled = instatus
        CmbGl_account_group_subgroup2_code.Enabled = instatus
        TxtRemark.Enabled = instatus
    End Sub
    Private Sub FillDataSets()
        DsFrmGlChartOfAccount1.Clear()
        DaGL_account_group.Fill(DsFrmGlChartOfAccount1)
        DaGL_account_group_subgroup1.Fill(DsFrmGlChartOfAccount1)
        DaGL_account_group_subgroup2.Fill(DsFrmGlChartOfAccount1)
    End Sub
    Private Sub GlAccount1_FindGlCod() Handles GlAccount1.FindGlCod
        Call FillFields(GlAccount1.Text)
    End Sub
    Friend Function FillFields(ByVal ThisCod As String) As Boolean
        FillFields = False
        If ThisCod.Trim.Length = 0 Then
            Exit Function
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT * from Gl_account  where Gl_account=" & Qt(ThisCod)
        SQLReader = CmdGeneral.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            TxtGl_Account.Text = Trim(SQLReader.Item("Gl_Account") & "")
            txtdesc_GL_account.Text = Trim(SQLReader.Item("desc_GL_account") & "")
            Cmbgroup_GL_account.SelectedValue = Trim(SQLReader.Item("group_GL_account") & "")
            CmbGl_account_group_subgroup1_code.SelectedValue = Trim(SQLReader.Item("Gl_account_group_subgroup1_code") & "")
            CmbGl_account_group_subgroup2_code.SelectedValue = Trim(SQLReader.Item("Gl_account_group_subgroup2_code") & "")
            TxtRemark.Text = Trim(SQLReader.Item("Remark") & "")

            FillFields = True
        Else
            Call ClearField()
        End If
        SQLReader.Close()
        CmdGeneral.Connection.Close()
    End Function
    Friend Sub ClearField()
        TxtGl_Account.Text = ""
        txtdesc_GL_account.Text = ""
        Cmbgroup_GL_account.SelectedValue = ""
        CmbGl_account_group_subgroup1_code.SelectedValue = ""
        CmbGl_account_group_subgroup2_code.SelectedValue = ""
        TxtRemark.Text = ""
    End Sub


    Sub PAddNew()
        ThisFormStatus = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        GlaccountCodTempVar = GlAccount1.Text
        GlAccount1.Text = ""
        Call ClearField()

        'GlAccount1.Text = MakeNewCustomerCod()
        TxtGl_Account.Focus()
        BtnNew.Enabled = False
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
        
    End Sub
    Sub PEdit()
        ThisFormStatus = MainModule.WorkStates.Edit
        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()
        EnableField(True)
        GlaccountCodTempVar = GlAccount1.Text
        TxtGl_Account.Focus()

        BtnNew.Enabled = False
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
    End Sub
    Sub PDelete()
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Delete"
        c1.ShowFarMsg("Are you sure?")
        If c1.DialogResult = DialogResult.OK Then
            Try
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "Delete from gl_account where gl_account=" & Qt(GlAccount1.Text)

                CmdGeneral.ExecuteNonQuery()
                GlaccountCodTempVar = ""
                Call PNextRecord(False)
                If GlaccountCodTempVar.Trim.Length = 0 Then
                    Call PPreviousRecord(False)
                    If GlaccountCodTempVar.Trim.Length = 0 Then
                        Call ClearField()
                    End If
                End If
            Catch ex As System.Data.SqlClient.SqlException
                Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
                'Call PubErrHandle(myErrors.Item(0).Number)
                MsgFar("Can not Delete This Record")
            Finally
                CmdGeneral.Connection.Close()
            End Try
            Call AfterSaveOrCancel()
        Else
            GlAccount1.Focus()
        End If
        ThisFormStatus = MainModule.WorkStates._ReadOnly
    End Sub
    Sub PSave()
        If TxtGl_Account.Text.Trim.Length = 0 Or txtdesc_GL_account.Text.Length = 0 Then
            MsgBox("Please set gl code and description")
            Exit Sub
        End If
        Dim ChangeOK As Boolean = False
        Select Case ThisFormStatus
            Case MainModule.WorkStates.AddNew
                GlaccountCodTempVar = PInsert()
                ChangeOK = IIf(GlaccountCodTempVar.Trim.Length = 0, False, True)
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(GlaccountCodTempVar)
        End Select
        If ChangeOK Then
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            ThisFormStatus = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            GlAccount1.Text = GlaccountCodTempVar
            GlAccount1.Focus()
        End If
    End Sub
    Sub PCancel()
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        GlAccount1.Text = GlaccountCodTempVar
        '''''''''''''Call FillFields(CustomerCod1.Text)
        Call AfterSaveOrCancel()
        GlAccount1.Focus()
    End Sub
    Friend Function PInsert() As String
        Dim thisrow As DataRow
        PInsert = ""
        Try
            With CmdInsert
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@Gl_Account").Value = TxtGl_Account.Text
                .Parameters("@desc_GL_account").Value = txtdesc_GL_account.Text.Trim
                .Parameters("@group_GL_account").Value = Cmbgroup_GL_account.SelectedValue
                .Parameters("@Gl_account_group_subgroup1_code").Value = CmbGl_account_group_subgroup1_code.SelectedValue
                .Parameters("@Gl_account_group_subgroup2_code").Value = CmbGl_account_group_subgroup2_code.SelectedValue
                .Parameters("@remark").Value = TxtRemark.Text.Trim & ""
                .ExecuteNonQuery()
                PInsert = TxtGl_Account.Text
                .Connection.Close()
            End With
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PInsert = ""
        End Try
    End Function

    Friend Function PUpdate(ByVal ThisCod_Customer As String) As Boolean
        PUpdate = True
        Try
            With CmdUpdate
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@Gl_Account").Value = TxtGl_Account.Text
                .Parameters("@desc_GL_account").Value = txtdesc_GL_account.Text.Trim
                .Parameters("@group_GL_account").Value = Cmbgroup_GL_account.SelectedValue
                .Parameters("@Gl_account_group_subgroup1_code").Value = CmbGl_account_group_subgroup1_code.SelectedValue
                .Parameters("@Gl_account_group_subgroup2_code").Value = CmbGl_account_group_subgroup2_code.SelectedValue
                .Parameters("@remark").Value = TxtRemark.Text.Trim & ""
                .ExecuteNonQuery()
                PUpdate = True
                .Connection.Close()
            End With
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PUpdate = False
        End Try
    End Function
    Private Sub ShowFilterProcPanel()
        Dim I As Integer, k As Integer
        If PnlSearch.Height = 0 Then
            k = -1
        Else
            k = 1
        End If
        Try
            For I = 1 To PnlSearchHeight
                PnlSearch.Height = PnlSearch.Height - k
                Me.Height = Me.Height - k
            Next I
        Catch
            '                    PanelSearch.Visible = Not PanelSearch.Visible
        End Try
        If PnlSearch.Height <> 0 Then

            TxtGl_Account.Focus()
        Else

        End If
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Call PAddNew()
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Call PEdit()
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Call PDelete()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Call PSave()
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
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        frmshow1 = New UCGl_Account.FrmGlChartOfAccountSearch
        frmshow1.ShowDialog()
    End Sub
    Private Sub TXTCustomerCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtGl_Account.TextChanged, txtdesc_GL_account.TextChanged, Cmbgroup_GL_account.SelectedIndexChanged, CmbGl_account_group_subgroup1_code.SelectedIndexChanged, CmbGl_account_group_subgroup2_code.SelectedIndexChanged, TxtRemark.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If ThisFormStatus = MainModule.WorkStates.Edit Or ThisFormStatus = MainModule.WorkStates.AddNew Then

            If TxtGl_Account.Text.Trim.Length > 0 And txtdesc_GL_account.Text.Trim.Length > 0 Then
                BtnSave.Enabled = True
            Else
                BtnSave.Enabled = False
            End If
        End If
    End Sub

    Private Sub frmshow1_Gl_accountFind(ByVal GL_account As String, ByVal Desc_GL_account As String) Handles frmshow1.Gl_accountFind
        GlAccount1.Text = GL_account.Trim & ""
    End Sub

    Private Sub GlAccount1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlAccount1.Load

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class
