Imports CommonClass
Public Class FrmRepJournal
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
    Friend WithEvents PanelInnerDate As System.Windows.Forms.Panel
    Friend WithEvents CalendarCombo1 As CalendarCombo.CalendarCombo
    Friend WithEvents CalendarCombo2 As CalendarCombo.CalendarCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelSaler As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PanelClass As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PanelSource As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PanelType As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PanelDetail As System.Windows.Forms.Panel
    Friend WithEvents RdoSummery As System.Windows.Forms.RadioButton
    Friend WithEvents RdoDetail As System.Windows.Forms.RadioButton
    Friend WithEvents PanelDate As System.Windows.Forms.GroupBox
    Friend WithEvents ChkDate As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RdoSelectedJournal As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllJournal As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedSub2 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllSub2 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedSub1 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllSub1 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedGroup As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllGroup As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedAcounts As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllAcounts As System.Windows.Forms.RadioButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAGl_acount As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account_group_subgroup1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account_group_subgroup2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_type_journal As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents BtnJournal As System.Windows.Forms.Button
    Friend WithEvents BtnSub2 As System.Windows.Forms.Button
    Friend WithEvents BtnSub1 As System.Windows.Forms.Button
    Friend WithEvents BtnGroup As System.Windows.Forms.Button
    Friend WithEvents BtnAcount As System.Windows.Forms.Button
    Friend WithEvents DsFrmRepJournal1 As ReportBank.DSFrmRepJournal
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account_group As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Pnl2 As System.Windows.Forms.GroupBox
    Friend WithEvents Pnl3 As System.Windows.Forms.GroupBox
    Friend WithEvents Pnl1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepJournal))
        Me.PanelInnerDate = New System.Windows.Forms.Panel
        Me.CalendarCombo1 = New CalendarCombo.CalendarCombo
        Me.CalendarCombo2 = New CalendarCombo.CalendarCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnOk = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Pnl2 = New System.Windows.Forms.GroupBox
        Me.PanelSaler = New System.Windows.Forms.Panel
        Me.BtnJournal = New System.Windows.Forms.Button
        Me.RdoSelectedJournal = New System.Windows.Forms.RadioButton
        Me.RdoAllJournal = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.Pnl3 = New System.Windows.Forms.GroupBox
        Me.PanelClass = New System.Windows.Forms.Panel
        Me.BtnSub2 = New System.Windows.Forms.Button
        Me.RdoSelectedSub2 = New System.Windows.Forms.RadioButton
        Me.RdoAllSub2 = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.PanelSource = New System.Windows.Forms.Panel
        Me.BtnSub1 = New System.Windows.Forms.Button
        Me.RdoSelectedSub1 = New System.Windows.Forms.RadioButton
        Me.RdoAllSub1 = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.PanelType = New System.Windows.Forms.Panel
        Me.BtnGroup = New System.Windows.Forms.Button
        Me.RdoSelectedGroup = New System.Windows.Forms.RadioButton
        Me.RdoAllGroup = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Pnl1 = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnAcount = New System.Windows.Forms.Button
        Me.RdoSelectedAcounts = New System.Windows.Forms.RadioButton
        Me.RdoAllAcounts = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.PanelDetail = New System.Windows.Forms.Panel
        Me.RdoSummery = New System.Windows.Forms.RadioButton
        Me.RdoDetail = New System.Windows.Forms.RadioButton
        Me.PanelDate = New System.Windows.Forms.GroupBox
        Me.ChkDate = New System.Windows.Forms.CheckBox
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAGl_acount = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account_group_subgroup1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account_group_subgroup2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_type_journal = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmRepJournal1 = New ReportBank.DSFrmRepJournal
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account_group = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.PanelInnerDate.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Pnl2.SuspendLayout()
        Me.PanelSaler.SuspendLayout()
        Me.Pnl3.SuspendLayout()
        Me.PanelClass.SuspendLayout()
        Me.PanelSource.SuspendLayout()
        Me.PanelType.SuspendLayout()
        Me.Pnl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelDetail.SuspendLayout()
        Me.PanelDate.SuspendLayout()
        CType(Me.DsFrmRepJournal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelInnerDate
        '
        Me.PanelInnerDate.Controls.Add(Me.CalendarCombo1)
        Me.PanelInnerDate.Controls.Add(Me.CalendarCombo2)
        Me.PanelInnerDate.Controls.Add(Me.Label2)
        Me.PanelInnerDate.Controls.Add(Me.Label3)
        Me.PanelInnerDate.Location = New System.Drawing.Point(96, 24)
        Me.PanelInnerDate.Name = "PanelInnerDate"
        Me.PanelInnerDate.Size = New System.Drawing.Size(392, 32)
        Me.PanelInnerDate.TabIndex = 7
        '
        'CalendarCombo1
        '
        Me.CalendarCombo1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalendarCombo1.BorderColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalendarCombo1.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.EditableSal = True
        Me.CalendarCombo1.Image = CType(resources.GetObject("CalendarCombo1.Image"), System.Drawing.Image)
        Me.CalendarCombo1.Location = New System.Drawing.Point(64, 0)
        Me.CalendarCombo1.MaxValue = CType(2500, Short)
        Me.CalendarCombo1.MinValue = CType(1800, Short)
        Me.CalendarCombo1.Name = "CalendarCombo1"
        Me.CalendarCombo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalendarCombo1.Sal_Mali = Nothing
        Me.CalendarCombo1.ShowButton = True
        Me.CalendarCombo1.Size = New System.Drawing.Size(110, 23)
        Me.CalendarCombo1.TabIndex = 3
        Me.CalendarCombo1.VisualStyle = False
        '
        'CalendarCombo2
        '
        Me.CalendarCombo2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalendarCombo2.BorderColor = System.Drawing.Color.Empty
        Me.CalendarCombo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalendarCombo2.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalendarCombo2.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalendarCombo2.EditableSal = True
        Me.CalendarCombo2.Image = CType(resources.GetObject("CalendarCombo2.Image"), System.Drawing.Image)
        Me.CalendarCombo2.Location = New System.Drawing.Point(256, 0)
        Me.CalendarCombo2.MaxValue = CType(2500, Short)
        Me.CalendarCombo2.MinValue = CType(1800, Short)
        Me.CalendarCombo2.Name = "CalendarCombo2"
        Me.CalendarCombo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalendarCombo2.Sal_Mali = Nothing
        Me.CalendarCombo2.ShowButton = True
        Me.CalendarCombo2.Size = New System.Drawing.Size(110, 23)
        Me.CalendarCombo2.TabIndex = 4
        Me.CalendarCombo2.VisualStyle = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(224, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(248, 440)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.TabIndex = 17
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(96, 440)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.TabIndex = 16
        Me.BtnOk.Text = "OK"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(510, 48)
        Me.Panel4.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(72, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(288, 46)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Select a date range followed by OK  to print the report"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 190
        Me.PictureBox2.TabStop = False
        '
        'Pnl2
        '
        Me.Pnl2.Controls.Add(Me.PanelSaler)
        Me.Pnl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl2.Location = New System.Drawing.Point(0, 184)
        Me.Pnl2.Name = "Pnl2"
        Me.Pnl2.Size = New System.Drawing.Size(510, 72)
        Me.Pnl2.TabIndex = 22
        Me.Pnl2.TabStop = False
        '
        'PanelSaler
        '
        Me.PanelSaler.Controls.Add(Me.BtnJournal)
        Me.PanelSaler.Controls.Add(Me.RdoSelectedJournal)
        Me.PanelSaler.Controls.Add(Me.RdoAllJournal)
        Me.PanelSaler.Controls.Add(Me.Label9)
        Me.PanelSaler.Location = New System.Drawing.Point(22, 16)
        Me.PanelSaler.Name = "PanelSaler"
        Me.PanelSaler.Size = New System.Drawing.Size(376, 40)
        Me.PanelSaler.TabIndex = 6
        '
        'BtnJournal
        '
        Me.BtnJournal.Enabled = False
        Me.BtnJournal.Location = New System.Drawing.Point(280, 16)
        Me.BtnJournal.Name = "BtnJournal"
        Me.BtnJournal.TabIndex = 3
        Me.BtnJournal.Text = "Choose..."
        '
        'RdoSelectedJournal
        '
        Me.RdoSelectedJournal.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedJournal.Name = "RdoSelectedJournal"
        Me.RdoSelectedJournal.Size = New System.Drawing.Size(144, 24)
        Me.RdoSelectedJournal.TabIndex = 1
        Me.RdoSelectedJournal.Text = "Selected Journal Types"
        '
        'RdoAllJournal
        '
        Me.RdoAllJournal.Checked = True
        Me.RdoAllJournal.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllJournal.Name = "RdoAllJournal"
        Me.RdoAllJournal.Size = New System.Drawing.Size(112, 24)
        Me.RdoAllJournal.TabIndex = 0
        Me.RdoAllJournal.TabStop = True
        Me.RdoAllJournal.Text = "All Journal Types"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(16, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "For Salespersons"
        '
        'Pnl3
        '
        Me.Pnl3.Controls.Add(Me.PanelClass)
        Me.Pnl3.Controls.Add(Me.PanelSource)
        Me.Pnl3.Controls.Add(Me.PanelType)
        Me.Pnl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl3.Location = New System.Drawing.Point(0, 256)
        Me.Pnl3.Name = "Pnl3"
        Me.Pnl3.Size = New System.Drawing.Size(510, 168)
        Me.Pnl3.TabIndex = 21
        Me.Pnl3.TabStop = False
        '
        'PanelClass
        '
        Me.PanelClass.Controls.Add(Me.BtnSub2)
        Me.PanelClass.Controls.Add(Me.RdoSelectedSub2)
        Me.PanelClass.Controls.Add(Me.RdoAllSub2)
        Me.PanelClass.Controls.Add(Me.Label8)
        Me.PanelClass.Location = New System.Drawing.Point(22, 112)
        Me.PanelClass.Name = "PanelClass"
        Me.PanelClass.Size = New System.Drawing.Size(384, 40)
        Me.PanelClass.TabIndex = 7
        '
        'BtnSub2
        '
        Me.BtnSub2.Enabled = False
        Me.BtnSub2.Location = New System.Drawing.Point(280, 16)
        Me.BtnSub2.Name = "BtnSub2"
        Me.BtnSub2.TabIndex = 3
        Me.BtnSub2.Text = "Choose..."
        '
        'RdoSelectedSub2
        '
        Me.RdoSelectedSub2.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedSub2.Name = "RdoSelectedSub2"
        Me.RdoSelectedSub2.Size = New System.Drawing.Size(144, 24)
        Me.RdoSelectedSub2.TabIndex = 1
        Me.RdoSelectedSub2.Text = "Selected Sub-Groups2"
        '
        'RdoAllSub2
        '
        Me.RdoAllSub2.Checked = True
        Me.RdoAllSub2.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllSub2.Name = "RdoAllSub2"
        Me.RdoAllSub2.Size = New System.Drawing.Size(136, 24)
        Me.RdoAllSub2.TabIndex = 0
        Me.RdoAllSub2.TabStop = True
        Me.RdoAllSub2.Text = "All Sub-Groups2"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "For Customer Classes"
        '
        'PanelSource
        '
        Me.PanelSource.Controls.Add(Me.BtnSub1)
        Me.PanelSource.Controls.Add(Me.RdoSelectedSub1)
        Me.PanelSource.Controls.Add(Me.RdoAllSub1)
        Me.PanelSource.Controls.Add(Me.Label6)
        Me.PanelSource.Location = New System.Drawing.Point(22, 64)
        Me.PanelSource.Name = "PanelSource"
        Me.PanelSource.Size = New System.Drawing.Size(384, 40)
        Me.PanelSource.TabIndex = 6
        '
        'BtnSub1
        '
        Me.BtnSub1.Enabled = False
        Me.BtnSub1.Location = New System.Drawing.Point(280, 16)
        Me.BtnSub1.Name = "BtnSub1"
        Me.BtnSub1.TabIndex = 3
        Me.BtnSub1.Text = "Choose..."
        '
        'RdoSelectedSub1
        '
        Me.RdoSelectedSub1.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedSub1.Name = "RdoSelectedSub1"
        Me.RdoSelectedSub1.Size = New System.Drawing.Size(144, 24)
        Me.RdoSelectedSub1.TabIndex = 1
        Me.RdoSelectedSub1.Text = "Selected Sub-groups 1"
        '
        'RdoAllSub1
        '
        Me.RdoAllSub1.Checked = True
        Me.RdoAllSub1.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllSub1.Name = "RdoAllSub1"
        Me.RdoAllSub1.Size = New System.Drawing.Size(136, 24)
        Me.RdoAllSub1.TabIndex = 0
        Me.RdoAllSub1.TabStop = True
        Me.RdoAllSub1.Text = "All Sub-Groups1"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "For Customer Sources"
        '
        'PanelType
        '
        Me.PanelType.Controls.Add(Me.BtnGroup)
        Me.PanelType.Controls.Add(Me.RdoSelectedGroup)
        Me.PanelType.Controls.Add(Me.RdoAllGroup)
        Me.PanelType.Controls.Add(Me.Label5)
        Me.PanelType.Location = New System.Drawing.Point(22, 16)
        Me.PanelType.Name = "PanelType"
        Me.PanelType.Size = New System.Drawing.Size(384, 40)
        Me.PanelType.TabIndex = 5
        '
        'BtnGroup
        '
        Me.BtnGroup.Enabled = False
        Me.BtnGroup.Location = New System.Drawing.Point(280, 16)
        Me.BtnGroup.Name = "BtnGroup"
        Me.BtnGroup.TabIndex = 2
        Me.BtnGroup.Text = "Choose..."
        '
        'RdoSelectedGroup
        '
        Me.RdoSelectedGroup.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedGroup.Name = "RdoSelectedGroup"
        Me.RdoSelectedGroup.Size = New System.Drawing.Size(152, 24)
        Me.RdoSelectedGroup.TabIndex = 1
        Me.RdoSelectedGroup.Text = "Selected Acount Groups"
        '
        'RdoAllGroup
        '
        Me.RdoAllGroup.Checked = True
        Me.RdoAllGroup.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllGroup.Name = "RdoAllGroup"
        Me.RdoAllGroup.Size = New System.Drawing.Size(120, 24)
        Me.RdoAllGroup.TabIndex = 0
        Me.RdoAllGroup.TabStop = True
        Me.RdoAllGroup.Text = "All Acount Groups"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "For Customer Types"
        '
        'Pnl1
        '
        Me.Pnl1.Controls.Add(Me.Panel2)
        Me.Pnl1.Controls.Add(Me.PanelDetail)
        Me.Pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl1.Location = New System.Drawing.Point(0, 112)
        Me.Pnl1.Name = "Pnl1"
        Me.Pnl1.Size = New System.Drawing.Size(510, 72)
        Me.Pnl1.TabIndex = 20
        Me.Pnl1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnAcount)
        Me.Panel2.Controls.Add(Me.RdoSelectedAcounts)
        Me.Panel2.Controls.Add(Me.RdoAllAcounts)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(22, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(384, 48)
        Me.Panel2.TabIndex = 9
        '
        'BtnAcount
        '
        Me.BtnAcount.Enabled = False
        Me.BtnAcount.Location = New System.Drawing.Point(280, 16)
        Me.BtnAcount.Name = "BtnAcount"
        Me.BtnAcount.TabIndex = 3
        Me.BtnAcount.Text = "Choose..."
        '
        'RdoSelectedAcounts
        '
        Me.RdoSelectedAcounts.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedAcounts.Name = "RdoSelectedAcounts"
        Me.RdoSelectedAcounts.Size = New System.Drawing.Size(120, 24)
        Me.RdoSelectedAcounts.TabIndex = 1
        Me.RdoSelectedAcounts.Text = "Selected Acounts"
        '
        'RdoAllAcounts
        '
        Me.RdoAllAcounts.Checked = True
        Me.RdoAllAcounts.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllAcounts.Name = "RdoAllAcounts"
        Me.RdoAllAcounts.TabIndex = 0
        Me.RdoAllAcounts.TabStop = True
        Me.RdoAllAcounts.Text = "All Acounts"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "For Customer Territories"
        '
        'PanelDetail
        '
        Me.PanelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetail.Controls.Add(Me.RdoSummery)
        Me.PanelDetail.Controls.Add(Me.RdoDetail)
        Me.PanelDetail.Location = New System.Drawing.Point(408, 15)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(80, 49)
        Me.PanelDetail.TabIndex = 8
        '
        'RdoSummery
        '
        Me.RdoSummery.Location = New System.Drawing.Point(8, 25)
        Me.RdoSummery.Name = "RdoSummery"
        Me.RdoSummery.Size = New System.Drawing.Size(72, 24)
        Me.RdoSummery.TabIndex = 1
        Me.RdoSummery.Text = "Summary"
        '
        'RdoDetail
        '
        Me.RdoDetail.Checked = True
        Me.RdoDetail.Location = New System.Drawing.Point(8, 1)
        Me.RdoDetail.Name = "RdoDetail"
        Me.RdoDetail.Size = New System.Drawing.Size(72, 24)
        Me.RdoDetail.TabIndex = 0
        Me.RdoDetail.TabStop = True
        Me.RdoDetail.Text = "Detail"
        '
        'PanelDate
        '
        Me.PanelDate.Controls.Add(Me.PanelInnerDate)
        Me.PanelDate.Controls.Add(Me.ChkDate)
        Me.PanelDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDate.Location = New System.Drawing.Point(0, 48)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(510, 64)
        Me.PanelDate.TabIndex = 19
        Me.PanelDate.TabStop = False
        '
        'ChkDate
        '
        Me.ChkDate.Location = New System.Drawing.Point(32, 24)
        Me.ChkDate.Name = "ChkDate"
        Me.ChkDate.TabIndex = 5
        Me.ChkDate.Text = "All Date"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_account AS code, desc_GL_account AS name, 0 AS flag FROM GL_account"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARYAFAR;packet size=4096;user id=sa;data source=aryafar;persist se" & _
        "curity info=False;initial catalog=TireMate_04"
        '
        'DAGl_acount
        '
        Me.DAGl_acount.SelectCommand = Me.SqlSelectCommand1
        Me.DAGl_acount.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Gl_account_group_subgroup1_code AS code, Gl_account_group_subgroup1_desc A" & _
        "S name FROM GL_account_group_subgroup1"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAGL_account_group_subgroup1
        '
        Me.DAGL_account_group_subgroup1.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_account_group_subgroup1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_group_subgroup1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Gl_account_group_subgroup1_code", "Gl_account_group_subgroup1_code"), New System.Data.Common.DataColumnMapping("Gl_account_group_subgroup1_desc", "Gl_account_group_subgroup1_desc")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Gl_account_group_subgroup2_code AS code, Gl_account_group_subgroup2_desc A" & _
        "S name, 0 AS flag FROM GL_account_group_subgroup2"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAGL_account_group_subgroup2
        '
        Me.DAGL_account_group_subgroup2.SelectCommand = Me.SqlSelectCommand3
        Me.DAGL_account_group_subgroup2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_group_subgroup2", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Gl_account_group_subgroup2_code", "Gl_account_group_subgroup2_code"), New System.Data.Common.DataColumnMapping("Gl_account_group_subgroup2_desc", "Gl_account_group_subgroup2_desc")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT GL_journal_type_code AS code, GL_journal_type_desc AS name, 0 AS flag FROM" & _
        " GL_type_journal"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DAGL_type_journal
        '
        Me.DAGL_type_journal.SelectCommand = Me.SqlSelectCommand4
        Me.DAGL_type_journal.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_type_journal", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GL_journal_type_code", "GL_journal_type_code"), New System.Data.Common.DataColumnMapping("GL_journal_type_desc", "GL_journal_type_desc")})})
        '
        'DsFrmRepJournal1
        '
        Me.DsFrmRepJournal1.DataSetName = "DSFrmRepJournal"
        Me.DsFrmRepJournal1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT group_GL_account AS code, desc_group_account AS name, 0 AS flag FROM GL_ac" & _
        "count_group"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'DAGL_account_group
        '
        Me.DAGL_account_group.SelectCommand = Me.SqlSelectCommand5
        Me.DAGL_account_group.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_group", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("group_GL_account", "group_GL_account"), New System.Data.Common.DataColumnMapping("desc_group_account", "desc_group_account")})})
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'FrmRepJournal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(510, 476)
        Me.Controls.Add(Me.Pnl3)
        Me.Controls.Add(Me.Pnl2)
        Me.Controls.Add(Me.Pnl1)
        Me.Controls.Add(Me.PanelDate)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOk)
        Me.Name = "FrmRepJournal"
        Me.PanelInnerDate.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Pnl2.ResumeLayout(False)
        Me.PanelSaler.ResumeLayout(False)
        Me.Pnl3.ResumeLayout(False)
        Me.PanelClass.ResumeLayout(False)
        Me.PanelSource.ResumeLayout(False)
        Me.PanelType.ResumeLayout(False)
        Me.Pnl1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PanelDetail.ResumeLayout(False)
        Me.PanelDate.ResumeLayout(False)
        CType(Me.DsFrmRepJournal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enum KindReport As Integer
        Income = 1
        GLHistory = 2
        BalanceSHeet = 3
        CashFlowStatemwnt = 4

    End Enum
    Public Property KindOfReport() As String
        Get
            Return MKindOfReport
        End Get
        Set(ByVal Value As String)
            MKindOfReport = Value
        End Set
    End Property
    Dim MKindOfReport As KindReport
    Dim StrDate As String
    Dim StrAcount As String
    Dim StrGroup As String
    Dim StrSub1 As String
    Dim StrSub2 As String
    Dim StrJournal As String
    Dim ComName As String = SystemInformation.ComputerName
    Private Sub FrmRepJournal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
        CalendarCombo1.Text = "01/01/" & PSalMali
        CalendarCombo2.Text = "12/28/" & PSalMali
        Call FillTextForm()

    End Sub
    Private Sub FillTextForm()
        Select Case MKindOfReport
            Case KindReport.Income
                Me.Text = "   Income Statement Report"
            Case KindReport.GLHistory
                Me.Text = "   General Ledger History Report"
                Pnl1.Visible = False
                Pnl2.Visible = False
                Pnl3.Visible = False
                BtnOk.Top = 176
                BtnCancel.Top = 176
                Me.Width = 520
                Me.Height = 264
            Case KindReport.BalanceSHeet
                Me.Text = "   Balance Sheet Report"
            Case KindReport.CashFlowStatemwnt
                Me.Text = "   Cash Flow Statment  Report"

        End Select
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()

    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click

        If ControlSelect() Then
            Dim f As New FrmPrintJournal
            f.StrWhere = ""
            f.StrFilter = ""

            If StrDate.Trim.Length > 0 Then
                f.StrWhere = f.StrWhere & " (" & StrDate & ") and "
                f.StrFilter = f.StrFilter & "Date, "
                f.Date1 = CalendarCombo1.Text
                f.Date2 = CalendarCombo2.Text
            Else
                f.Date1 = ""
                f.Date2 = ""
            End If
            If RdoSelectedAcounts.Checked Then
                f.StrFilter = f.StrFilter & "Type, "
                f.StrWhere = f.StrWhere & " (" & StrAcount & ") and "

            End If
            If RdoSelectedJournal.Checked Then
                f.StrFilter = f.StrFilter & "Source, "
                f.StrWhere = f.StrWhere & " (" & StrJournal & ") and "

            End If
            If RdoSelectedGroup.Checked Then
                f.StrFilter = f.StrFilter & "Class, "
                f.StrWhere = f.StrWhere & "(" & StrGroup & ") and "

            End If
            If RdoSelectedSub1.Checked Then
                f.StrFilter = f.StrFilter & "Territory, "
                f.StrWhere = f.StrWhere & " (" & StrSub1 & ") and "

            End If
            If RdoSelectedSub2.Checked Then
                f.StrFilter = f.StrFilter & "Sales Person, "
                f.StrWhere = f.StrWhere & " (" & StrSub2 & ") and "

            End If

            If f.StrWhere.Trim.Length > 0 Then f.StrWhere = Mid(f.StrWhere, 1, f.StrWhere.Length - 4)
            If f.StrFilter.Trim.Length > 0 Then f.StrFilter = Mid(f.StrFilter, 1, f.StrFilter.Length - 2)
            'Select Case MKindOfReport
            '    Case KindReport.Income
            f.KindOfReport = MKindOfReport
            f.Text = Me.Text

            'End Select

            f.ShowDialog()


            If RdoSelectedAcounts.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Acount_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
            If RdoSelectedJournal.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Journal_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
            If RdoSelectedGroup.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Group_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If

            If RdoSelectedSub1.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Sub1_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If

                CmdGeneral.ExecuteNonQuery()
            End If

            If RdoSelectedSub2.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Sub2_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If

        End If


    End Sub
    Private Sub ChkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDate.CheckedChanged
        If ChkDate.Checked Then
            PanelInnerDate.Enabled = False
        Else
            PanelInnerDate.Enabled = True
        End If
    End Sub

    Private Sub RdoAllAcounts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllAcounts.CheckedChanged
        If RdoAllAcounts.Checked Then
            BtnAcount.Enabled = False
        Else
            BtnAcount.Enabled = True
        End If

    End Sub

    Private Sub RdoAllJournal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllJournal.CheckedChanged
        If RdoAllJournal.Checked Then
            BtnJournal.Enabled = False
        Else
            BtnJournal.Enabled = True
        End If
    End Sub

    Private Sub RdoAllGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllGroup.CheckedChanged
        If RdoAllGroup.Checked Then
            BtnGroup.Enabled = False
        Else
            BtnGroup.Enabled = True
        End If
    End Sub

    Private Sub RdoAllSub1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllSub1.CheckedChanged
        If RdoAllSub1.Checked Then
            BtnSub1.Enabled = False
        Else
            BtnSub1.Enabled = True
        End If
    End Sub

    Private Sub RdoAllSub2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllSub2.CheckedChanged
        If RdoAllSub2.Checked Then
            BtnSub2.Enabled = False
        Else
            BtnSub2.Enabled = True
        End If
    End Sub
    Private Sub BtnGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGroup.Click
        BtnGroup.Enabled = False
        Dim f As New FrmSelectJournal
        If DsFrmRepJournal1.group.Count = 0 Then
            DsFrmRepJournal1.group.Clear()
            DAGL_account_group.Fill(DsFrmRepJournal1.group)
        End If
        f.Text = "  Select Acount Group"
        f.TypeOfForm = FrmSelectJournal.KindForm.Group
        f.DSMAIN = DsFrmRepJournal1
        f.ShowDialog()

        BtnGroup.Enabled = True
    End Sub

    Private Sub BtnSub1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSub1.Click
        BtnSub1.Enabled = False
        Dim f As New FrmSelectJournal
        If DsFrmRepJournal1.sub1.Count = 0 Then
            DsFrmRepJournal1.sub1.Clear()
            DAGL_account_group_subgroup1.Fill(DsFrmRepJournal1.sub1)
        End If
        f.Text = "  Select sub-Group1"
        f.TypeOfForm = FrmSelectJournal.KindForm.sub1
        f.DSMAIN = DsFrmRepJournal1
        f.ShowDialog()



        BtnSub1.Enabled = True
    End Sub

    Private Sub Btnsub2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSub2.Click
        BtnSub2.Enabled = False
        Dim f As New FrmSelectJournal
        If DsFrmRepJournal1.sub2.Count = 0 Then
            DsFrmRepJournal1.sub2.Clear()
            DAGL_account_group_subgroup2.Fill(DsFrmRepJournal1.sub2)
        End If
        f.Text = "  Select sub-Group1"
        f.TypeOfForm = FrmSelectJournal.KindForm.Sub2
        f.DSMAIN = DsFrmRepJournal1
        f.ShowDialog()



        BtnSub2.Enabled = True
    End Sub

    Private Sub BtnAcount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAcount.Click
        BtnAcount.Enabled = False
        Dim f As New FrmSelectJournal
        If DsFrmRepJournal1.account.Count = 0 Then
            DsFrmRepJournal1.account.Clear()
            DAGl_acount.Fill(DsFrmRepJournal1.account)
        End If
        f.Text = "  Select Acounts"
        f.TypeOfForm = FrmSelectJournal.KindForm.Acount
        f.DSMAIN = DsFrmRepJournal1
        f.ShowDialog()

        BtnAcount.Enabled = True
    End Sub

    Private Sub BtnJournal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJournal.Click
        BtnJournal.Enabled = False
        Dim f As New FrmSelectJournal
        If DsFrmRepJournal1.journal.Count = 0 Then
            DsFrmRepJournal1.journal.Clear()
            DAGL_type_journal.Fill(DsFrmRepJournal1.journal)
        End If
        f.Text = "  Select Journals "
        f.TypeOfForm = FrmSelectJournal.KindForm.Journal
        f.DSMAIN = DsFrmRepJournal1
        f.ShowDialog()

        BtnJournal.Enabled = True
    End Sub

    Private Function ControlSelect() As Boolean
        ControlSelect = True

        StrDate = ""

        Dim i As Integer
        StrAcount = ""
        'flagcontrol = False
        If RdoSelectedAcounts.Checked Then
            If DsFrmRepJournal1.account.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Type that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Acount_" & ComName & "(cod_Acount char(1))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Acount_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepJournal1.account.Count - 1
                    If DsFrmRepJournal1.account(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Acount_" & ComName & " (cod_Acount ) VALUES (" & Qt(DsFrmRepJournal1.account(i).code) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrAcount = " GL_account.GL_account in (select cod_type from Acount_" & ComName & ") "
            End If
            'If DsFrmRepJournal1.type.Select(" flag = 1 ").Length = 0 Then
            '    ControlSelect = False
            '    MsgBox("First Select Type that you want")
            '    Exit Function
            'End If


        End If
        '''''''''''journal
        StrJournal = ""
        If RdoSelectedJournal.Checked Then

            If DsFrmRepJournal1.journal.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Source that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Journal_" & ComName & "(cod_Journal char(1))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Journal_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepJournal1.journal.Count - 1
                    If DsFrmRepJournal1.journal(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Journal_" & ComName & " (cod_Journal ) VALUES (" & Qt(DsFrmRepJournal1.journal(i).code) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrJournal = " GL_type_journal.GL_journal_type_code in (select cod_Journal from Journal_" & ComName & ") "
            End If
            'If DsFrmRepJournal1.source.Select(" flag = 1 ").Length = 0 Then
            '    ControlSelect = False
            '    MsgBox("First Select Source that you want")
            '    Exit Function
            'End If

        End If
        '''''''''''''''group
        StrGroup = ""
        If RdoSelectedGroup.Checked Then
            If DsFrmRepJournal1.group.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Class that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Group_" & ComName & "(cod_Group char(1))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Group_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepJournal1.group.Count - 1
                    If DsFrmRepJournal1.group(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Group_" & ComName & " (cod_Group ) VALUES (" & Qt(DsFrmRepJournal1.group(i).code) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrGroup = " GL_account_group.group_GL_account in (select cod_class from Group_" & ComName & ") "
            End If
            'If DsFrmRepJournal1.clas.Select(" flag = 1 ").Length = 0 Then
            '    ControlSelect = False
            '    MsgBox("First Select Class that you want")
            '    Exit Function
            'End If

        End If
        '''''''''''''''Sub1
        StrSub1 = ""
        If RdoSelectedSub1.Checked Then
            If DsFrmRepJournal1.sub1.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select territory that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Sub1_" & ComName & "(cod_Sub1 char(2))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Sub1_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepJournal1.sub1.Count - 1
                    If DsFrmRepJournal1.sub1(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Sub1_" & ComName & " (cod_Sub1 ) VALUES (" & Qt(DsFrmRepJournal1.sub1(i).code) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrSub1 = " GL_account_group_subgroup1.Gl_account_group_subgroup1_code  in (select cod_Sub1 from Sub1_" & ComName & ") "
            End If
            'If DsFrmRepJournal1.territory.Select(" flag = 1 ").Length = 0 Then
            '    ControlSelect = False
            '    MsgBox("First Select territory that you want")
            '    Exit Function
            'End If
        End If
        '''''''''''''''Saler
        StrSub2 = ""
        If RdoSelectedSub2.Checked Then
            If DsFrmRepJournal1.sub2.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select SalesPersons that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Sub2_" & ComName & "(cod_Sub2 char(5))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Sub2_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepJournal1.sub2.Count - 1
                    If DsFrmRepJournal1.sub2(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Sub2_" & ComName & " (cod_Sub2 ) VALUES (" & Qt(DsFrmRepJournal1.sub2(i).code) & ") "
                        CmdGeneral.ExecuteNonQuery()
                    End If
                Next
                StrSub2 = " GL_account_group_subgroup2.Gl_account_group_subgroup2_code  in (select cod_Sub2 from Employee_" & ComName & ") "
            End If
            'If DsFrmRepJournal1.employee.Select(" flag = 1 ").Length = 0 Then
            '    ControlSelect = False
            '    MsgBox("First Select SalesPersons that you want")
            '    Exit Function
            'End If
        End If
        If ChangeDateToYYYYMMDD(CalendarCombo1.Text) > ChangeDateToYYYYMMDD(CalendarCombo2.Text) Then
            ControlSelect = False
            MsgBox("First Date Must Be Befor To Date")
            Exit Function
        Else
            Select Case MKindOfReport
                Case KindReport.Income
                    StrDate = " dbo.ChangeDate(bank_check.date_of_check) between " & Qt(ChangeDateToYYYYMMDD(CalendarCombo1.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalendarCombo2.Text))

            End Select
        End If

    End Function


End Class
