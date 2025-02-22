Imports CommonClass
Public Class FrmRepBank
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelDate As System.Windows.Forms.GroupBox
    Friend WithEvents PanelInnerDate As System.Windows.Forms.Panel
    Friend WithEvents CalendarCombo1 As CalendarCombo.CalendarCombo
    Friend WithEvents CalendarCombo2 As CalendarCombo.CalendarCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkDate As System.Windows.Forms.CheckBox
    Friend WithEvents PanelDetail As System.Windows.Forms.Panel
    Friend WithEvents RdoSummery As System.Windows.Forms.RadioButton
    Friend WithEvents RdoDetail As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PanelBank As System.Windows.Forms.GroupBox
    Friend WithEvents RdoSelectedBank As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllBank As System.Windows.Forms.RadioButton
    Friend WithEvents BtnBank As System.Windows.Forms.Button
    Friend WithEvents RdoSelectedVendor As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllVendor As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSTActive As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSTAll As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSTReturn As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSTVoid As System.Windows.Forms.RadioButton
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents RdoSTDelete As System.Windows.Forms.RadioButton
    Friend WithEvents BtnVendor As System.Windows.Forms.Button
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmRepBank1 As ReportBank.DSFrmRepBank
    Friend WithEvents DABas_Bank As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInv_Vendor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents PanelVendor As System.Windows.Forms.GroupBox
    Friend WithEvents PanelCheck As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelDeposit As System.Windows.Forms.GroupBox
    Friend WithEvents RdoDepAll As System.Windows.Forms.RadioButton
    Friend WithEvents RdoDepCash As System.Windows.Forms.RadioButton
    Friend WithEvents RdoDepCredit As System.Windows.Forms.RadioButton
    Friend WithEvents PanelRdo As System.Windows.Forms.GroupBox
    Friend WithEvents PanelATM As System.Windows.Forms.GroupBox
    Friend WithEvents RdoATMAll As System.Windows.Forms.RadioButton
    Friend WithEvents RdoATMCharge As System.Windows.Forms.RadioButton
    Friend WithEvents RdoATMCredit As System.Windows.Forms.RadioButton
    Friend WithEvents PanelCheckByGlAcount As System.Windows.Forms.GroupBox
    Friend WithEvents RdoAllAcount As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedAcount As System.Windows.Forms.RadioButton
    Friend WithEvents BtnGlAcount As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_Acount As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepBank))
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PanelBank = New System.Windows.Forms.GroupBox
        Me.RdoSelectedBank = New System.Windows.Forms.RadioButton
        Me.BtnBank = New System.Windows.Forms.Button
        Me.RdoAllBank = New System.Windows.Forms.RadioButton
        Me.PanelDate = New System.Windows.Forms.GroupBox
        Me.PanelInnerDate = New System.Windows.Forms.Panel
        Me.CalendarCombo1 = New CalendarCombo.CalendarCombo
        Me.CalendarCombo2 = New CalendarCombo.CalendarCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ChkDate = New System.Windows.Forms.CheckBox
        Me.PanelVendor = New System.Windows.Forms.GroupBox
        Me.BtnVendor = New System.Windows.Forms.Button
        Me.RdoSelectedVendor = New System.Windows.Forms.RadioButton
        Me.RdoAllVendor = New System.Windows.Forms.RadioButton
        Me.PanelCheck = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RdoSTDelete = New System.Windows.Forms.RadioButton
        Me.RdoSTVoid = New System.Windows.Forms.RadioButton
        Me.RdoSTReturn = New System.Windows.Forms.RadioButton
        Me.RdoSTAll = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.RdoSTActive = New System.Windows.Forms.RadioButton
        Me.PanelDetail = New System.Windows.Forms.Panel
        Me.RdoSummery = New System.Windows.Forms.RadioButton
        Me.RdoDetail = New System.Windows.Forms.RadioButton
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnOk = New System.Windows.Forms.Button
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DABas_Bank = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DsFrmRepBank1 = New ReportBank.DSFrmRepBank
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_Vendor = New System.Data.SqlClient.SqlDataAdapter
        Me.PanelDeposit = New System.Windows.Forms.GroupBox
        Me.RdoDepCredit = New System.Windows.Forms.RadioButton
        Me.RdoDepCash = New System.Windows.Forms.RadioButton
        Me.RdoDepAll = New System.Windows.Forms.RadioButton
        Me.PanelRdo = New System.Windows.Forms.GroupBox
        Me.PanelCheckByGlAcount = New System.Windows.Forms.GroupBox
        Me.BtnGlAcount = New System.Windows.Forms.Button
        Me.RdoSelectedAcount = New System.Windows.Forms.RadioButton
        Me.RdoAllAcount = New System.Windows.Forms.RadioButton
        Me.PanelATM = New System.Windows.Forms.GroupBox
        Me.RdoATMCredit = New System.Windows.Forms.RadioButton
        Me.RdoATMCharge = New System.Windows.Forms.RadioButton
        Me.RdoATMAll = New System.Windows.Forms.RadioButton
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_Acount = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Panel4.SuspendLayout()
        Me.PanelBank.SuspendLayout()
        Me.PanelDate.SuspendLayout()
        Me.PanelInnerDate.SuspendLayout()
        Me.PanelVendor.SuspendLayout()
        Me.PanelCheck.SuspendLayout()
        Me.PanelDetail.SuspendLayout()
        CType(Me.DsFrmRepBank1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDeposit.SuspendLayout()
        Me.PanelRdo.SuspendLayout()
        Me.PanelCheckByGlAcount.SuspendLayout()
        Me.PanelATM.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel4.Size = New System.Drawing.Size(486, 48)
        Me.Panel4.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(72, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(264, 46)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Select a date range and any desired options followed by OK  to print the report"
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
        'PanelBank
        '
        Me.PanelBank.Controls.Add(Me.RdoSelectedBank)
        Me.PanelBank.Controls.Add(Me.BtnBank)
        Me.PanelBank.Controls.Add(Me.RdoAllBank)
        Me.PanelBank.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBank.Location = New System.Drawing.Point(0, 48)
        Me.PanelBank.Name = "PanelBank"
        Me.PanelBank.Size = New System.Drawing.Size(486, 48)
        Me.PanelBank.TabIndex = 10
        Me.PanelBank.TabStop = False
        '
        'RdoSelectedBank
        '
        Me.RdoSelectedBank.Location = New System.Drawing.Point(152, 16)
        Me.RdoSelectedBank.Name = "RdoSelectedBank"
        Me.RdoSelectedBank.Size = New System.Drawing.Size(120, 24)
        Me.RdoSelectedBank.TabIndex = 1
        Me.RdoSelectedBank.Text = "Selected Bank"
        '
        'BtnBank
        '
        Me.BtnBank.Enabled = False
        Me.BtnBank.Location = New System.Drawing.Point(296, 16)
        Me.BtnBank.Name = "BtnBank"
        Me.BtnBank.TabIndex = 3
        Me.BtnBank.Text = "Choose..."
        '
        'RdoAllBank
        '
        Me.RdoAllBank.Checked = True
        Me.RdoAllBank.Location = New System.Drawing.Point(24, 16)
        Me.RdoAllBank.Name = "RdoAllBank"
        Me.RdoAllBank.TabIndex = 0
        Me.RdoAllBank.TabStop = True
        Me.RdoAllBank.Text = "All Banks"
        '
        'PanelDate
        '
        Me.PanelDate.Controls.Add(Me.PanelInnerDate)
        Me.PanelDate.Controls.Add(Me.ChkDate)
        Me.PanelDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDate.Location = New System.Drawing.Point(0, 96)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(486, 48)
        Me.PanelDate.TabIndex = 11
        Me.PanelDate.TabStop = False
        '
        'PanelInnerDate
        '
        Me.PanelInnerDate.Controls.Add(Me.CalendarCombo1)
        Me.PanelInnerDate.Controls.Add(Me.CalendarCombo2)
        Me.PanelInnerDate.Controls.Add(Me.Label2)
        Me.PanelInnerDate.Controls.Add(Me.Label3)
        Me.PanelInnerDate.Location = New System.Drawing.Point(152, 16)
        Me.PanelInnerDate.Name = "PanelInnerDate"
        Me.PanelInnerDate.Size = New System.Drawing.Size(320, 24)
        Me.PanelInnerDate.TabIndex = 6
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
        Me.CalendarCombo1.Location = New System.Drawing.Point(48, 0)
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
        Me.CalendarCombo2.Location = New System.Drawing.Point(192, 0)
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
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(160, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To"
        '
        'ChkDate
        '
        Me.ChkDate.Location = New System.Drawing.Point(40, 16)
        Me.ChkDate.Name = "ChkDate"
        Me.ChkDate.TabIndex = 5
        Me.ChkDate.Text = "All Dates"
        '
        'PanelVendor
        '
        Me.PanelVendor.Controls.Add(Me.BtnVendor)
        Me.PanelVendor.Controls.Add(Me.RdoSelectedVendor)
        Me.PanelVendor.Controls.Add(Me.RdoAllVendor)
        Me.PanelVendor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelVendor.Location = New System.Drawing.Point(0, 144)
        Me.PanelVendor.Name = "PanelVendor"
        Me.PanelVendor.Size = New System.Drawing.Size(486, 48)
        Me.PanelVendor.TabIndex = 12
        Me.PanelVendor.TabStop = False
        '
        'BtnVendor
        '
        Me.BtnVendor.Enabled = False
        Me.BtnVendor.Location = New System.Drawing.Point(296, 16)
        Me.BtnVendor.Name = "BtnVendor"
        Me.BtnVendor.TabIndex = 3
        Me.BtnVendor.Text = "Choose..."
        '
        'RdoSelectedVendor
        '
        Me.RdoSelectedVendor.Location = New System.Drawing.Point(152, 16)
        Me.RdoSelectedVendor.Name = "RdoSelectedVendor"
        Me.RdoSelectedVendor.Size = New System.Drawing.Size(120, 24)
        Me.RdoSelectedVendor.TabIndex = 1
        Me.RdoSelectedVendor.Text = "Selected Vendor"
        '
        'RdoAllVendor
        '
        Me.RdoAllVendor.Checked = True
        Me.RdoAllVendor.Location = New System.Drawing.Point(24, 16)
        Me.RdoAllVendor.Name = "RdoAllVendor"
        Me.RdoAllVendor.TabIndex = 0
        Me.RdoAllVendor.TabStop = True
        Me.RdoAllVendor.Text = "All Vendors"
        '
        'PanelCheck
        '
        Me.PanelCheck.Controls.Add(Me.GroupBox2)
        Me.PanelCheck.Controls.Add(Me.RdoSTDelete)
        Me.PanelCheck.Controls.Add(Me.RdoSTVoid)
        Me.PanelCheck.Controls.Add(Me.RdoSTReturn)
        Me.PanelCheck.Controls.Add(Me.RdoSTAll)
        Me.PanelCheck.Controls.Add(Me.Label5)
        Me.PanelCheck.Controls.Add(Me.RdoSTActive)
        Me.PanelCheck.Location = New System.Drawing.Point(0, 0)
        Me.PanelCheck.Name = "PanelCheck"
        Me.PanelCheck.Size = New System.Drawing.Size(376, 96)
        Me.PanelCheck.TabIndex = 13
        Me.PanelCheck.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(25, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 96)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'RdoSTDelete
        '
        Me.RdoSTDelete.Location = New System.Drawing.Point(152, 64)
        Me.RdoSTDelete.Name = "RdoSTDelete"
        Me.RdoSTDelete.Size = New System.Drawing.Size(120, 24)
        Me.RdoSTDelete.TabIndex = 11
        Me.RdoSTDelete.Text = "Deleted"
        '
        'RdoSTVoid
        '
        Me.RdoSTVoid.Location = New System.Drawing.Point(152, 16)
        Me.RdoSTVoid.Name = "RdoSTVoid"
        Me.RdoSTVoid.Size = New System.Drawing.Size(120, 24)
        Me.RdoSTVoid.TabIndex = 10
        Me.RdoSTVoid.Text = "Void"
        '
        'RdoSTReturn
        '
        Me.RdoSTReturn.Location = New System.Drawing.Point(152, 40)
        Me.RdoSTReturn.Name = "RdoSTReturn"
        Me.RdoSTReturn.Size = New System.Drawing.Size(120, 24)
        Me.RdoSTReturn.TabIndex = 9
        Me.RdoSTReturn.Text = "Returned"
        '
        'RdoSTAll
        '
        Me.RdoSTAll.Checked = True
        Me.RdoSTAll.Location = New System.Drawing.Point(24, 40)
        Me.RdoSTAll.Name = "RdoSTAll"
        Me.RdoSTAll.TabIndex = 0
        Me.RdoSTAll.TabStop = True
        Me.RdoSTAll.Text = "All Status"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(24, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Check Status"
        '
        'RdoSTActive
        '
        Me.RdoSTActive.Location = New System.Drawing.Point(24, 64)
        Me.RdoSTActive.Name = "RdoSTActive"
        Me.RdoSTActive.Size = New System.Drawing.Size(120, 24)
        Me.RdoSTActive.TabIndex = 1
        Me.RdoSTActive.Text = "Active"
        '
        'PanelDetail
        '
        Me.PanelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetail.Controls.Add(Me.RdoSummery)
        Me.PanelDetail.Controls.Add(Me.RdoDetail)
        Me.PanelDetail.Location = New System.Drawing.Point(384, 16)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(80, 64)
        Me.PanelDetail.TabIndex = 8
        '
        'RdoSummery
        '
        Me.RdoSummery.Location = New System.Drawing.Point(8, 32)
        Me.RdoSummery.Name = "RdoSummery"
        Me.RdoSummery.Size = New System.Drawing.Size(72, 24)
        Me.RdoSummery.TabIndex = 1
        Me.RdoSummery.Text = "Summary"
        '
        'RdoDetail
        '
        Me.RdoDetail.Checked = True
        Me.RdoDetail.Location = New System.Drawing.Point(8, 8)
        Me.RdoDetail.Name = "RdoDetail"
        Me.RdoDetail.Size = New System.Drawing.Size(72, 24)
        Me.RdoDetail.TabIndex = 0
        Me.RdoDetail.TabStop = True
        Me.RdoDetail.Text = "Detail"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(272, 296)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.TabIndex = 15
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(120, 296)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.TabIndex = 14
        Me.BtnOk.Text = "OK"
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=MILAD;packet size=4096;integrated security=SSPI;data source=milad;" & _
        "persist security info=False;initial catalog=TireMate_01_db"
        '
        'DABas_Bank
        '
        Me.DABas_Bank.SelectCommand = Me.SqlSelectCommand1
        Me.DABas_Bank.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_banks", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("name_bank", "name_bank")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_bank AS cod, name_bank AS name, 0 AS flag FROM bas_banks"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DsFrmRepBank1
        '
        Me.DsFrmRepBank1.DataSetName = "DSFrmRepBank"
        Me.DsFrmRepBank1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_vendor AS cod, desc_vendor AS name, 0 AS flag FROM inv_vendor"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAInv_Vendor
        '
        Me.DAInv_Vendor.SelectCommand = Me.SqlSelectCommand2
        Me.DAInv_Vendor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_vendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("desc_vendor", "desc_vendor")})})
        '
        'PanelDeposit
        '
        Me.PanelDeposit.Controls.Add(Me.RdoDepCredit)
        Me.PanelDeposit.Controls.Add(Me.RdoDepCash)
        Me.PanelDeposit.Controls.Add(Me.RdoDepAll)
        Me.PanelDeposit.Location = New System.Drawing.Point(0, 0)
        Me.PanelDeposit.Name = "PanelDeposit"
        Me.PanelDeposit.Size = New System.Drawing.Size(376, 96)
        Me.PanelDeposit.TabIndex = 16
        Me.PanelDeposit.TabStop = False
        '
        'RdoDepCredit
        '
        Me.RdoDepCredit.Location = New System.Drawing.Point(240, 40)
        Me.RdoDepCredit.Name = "RdoDepCredit"
        Me.RdoDepCredit.TabIndex = 2
        Me.RdoDepCredit.Text = "Credit Cards"
        '
        'RdoDepCash
        '
        Me.RdoDepCash.Location = New System.Drawing.Point(120, 40)
        Me.RdoDepCash.Name = "RdoDepCash"
        Me.RdoDepCash.Size = New System.Drawing.Size(120, 24)
        Me.RdoDepCash.TabIndex = 1
        Me.RdoDepCash.Text = "Cash And Checks"
        '
        'RdoDepAll
        '
        Me.RdoDepAll.Checked = True
        Me.RdoDepAll.Location = New System.Drawing.Point(16, 40)
        Me.RdoDepAll.Name = "RdoDepAll"
        Me.RdoDepAll.TabIndex = 0
        Me.RdoDepAll.TabStop = True
        Me.RdoDepAll.Text = "All Deposit"
        '
        'PanelRdo
        '
        Me.PanelRdo.Controls.Add(Me.PanelDetail)
        Me.PanelRdo.Controls.Add(Me.PanelCheckByGlAcount)
        Me.PanelRdo.Controls.Add(Me.PanelATM)
        Me.PanelRdo.Controls.Add(Me.PanelCheck)
        Me.PanelRdo.Controls.Add(Me.PanelDeposit)
        Me.PanelRdo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRdo.Location = New System.Drawing.Point(0, 192)
        Me.PanelRdo.Name = "PanelRdo"
        Me.PanelRdo.Size = New System.Drawing.Size(486, 96)
        Me.PanelRdo.TabIndex = 17
        Me.PanelRdo.TabStop = False
        '
        'PanelCheckByGlAcount
        '
        Me.PanelCheckByGlAcount.Controls.Add(Me.BtnGlAcount)
        Me.PanelCheckByGlAcount.Controls.Add(Me.RdoSelectedAcount)
        Me.PanelCheckByGlAcount.Controls.Add(Me.RdoAllAcount)
        Me.PanelCheckByGlAcount.Location = New System.Drawing.Point(0, 0)
        Me.PanelCheckByGlAcount.Name = "PanelCheckByGlAcount"
        Me.PanelCheckByGlAcount.Size = New System.Drawing.Size(376, 96)
        Me.PanelCheckByGlAcount.TabIndex = 18
        Me.PanelCheckByGlAcount.TabStop = False
        '
        'BtnGlAcount
        '
        Me.BtnGlAcount.Enabled = False
        Me.BtnGlAcount.Location = New System.Drawing.Point(296, 40)
        Me.BtnGlAcount.Name = "BtnGlAcount"
        Me.BtnGlAcount.TabIndex = 4
        Me.BtnGlAcount.Text = "Choose..."
        '
        'RdoSelectedAcount
        '
        Me.RdoSelectedAcount.Location = New System.Drawing.Point(128, 40)
        Me.RdoSelectedAcount.Name = "RdoSelectedAcount"
        Me.RdoSelectedAcount.Size = New System.Drawing.Size(128, 24)
        Me.RdoSelectedAcount.TabIndex = 1
        Me.RdoSelectedAcount.Text = "Selected Acount"
        '
        'RdoAllAcount
        '
        Me.RdoAllAcount.Checked = True
        Me.RdoAllAcount.Location = New System.Drawing.Point(24, 40)
        Me.RdoAllAcount.Name = "RdoAllAcount"
        Me.RdoAllAcount.TabIndex = 0
        Me.RdoAllAcount.TabStop = True
        Me.RdoAllAcount.Text = "All Acounts"
        '
        'PanelATM
        '
        Me.PanelATM.Controls.Add(Me.RdoATMCredit)
        Me.PanelATM.Controls.Add(Me.RdoATMCharge)
        Me.PanelATM.Controls.Add(Me.RdoATMAll)
        Me.PanelATM.Location = New System.Drawing.Point(0, 0)
        Me.PanelATM.Name = "PanelATM"
        Me.PanelATM.Size = New System.Drawing.Size(376, 96)
        Me.PanelATM.TabIndex = 17
        Me.PanelATM.TabStop = False
        '
        'RdoATMCredit
        '
        Me.RdoATMCredit.Location = New System.Drawing.Point(248, 40)
        Me.RdoATMCredit.Name = "RdoATMCredit"
        Me.RdoATMCredit.TabIndex = 2
        Me.RdoATMCredit.Text = "Credits"
        '
        'RdoATMCharge
        '
        Me.RdoATMCharge.Location = New System.Drawing.Point(136, 40)
        Me.RdoATMCharge.Name = "RdoATMCharge"
        Me.RdoATMCharge.TabIndex = 1
        Me.RdoATMCharge.Text = "Charges"
        '
        'RdoATMAll
        '
        Me.RdoATMAll.Checked = True
        Me.RdoATMAll.Location = New System.Drawing.Point(24, 40)
        Me.RdoATMAll.Name = "RdoATMAll"
        Me.RdoATMAll.TabIndex = 0
        Me.RdoATMAll.TabStop = True
        Me.RdoATMAll.Text = "All ATMs"
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT GL_account AS cod, desc_GL_account AS name, 0 AS flag FROM GL_account"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAGL_Acount
        '
        Me.DAGL_Acount.SelectCommand = Me.SqlSelectCommand3
        Me.DAGL_Acount.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account")})})
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'FrmRepBank
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(486, 332)
        Me.Controls.Add(Me.PanelRdo)
        Me.Controls.Add(Me.PanelVendor)
        Me.Controls.Add(Me.PanelDate)
        Me.Controls.Add(Me.PanelBank)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOk)
        Me.Name = "FrmRepBank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel4.ResumeLayout(False)
        Me.PanelBank.ResumeLayout(False)
        Me.PanelDate.ResumeLayout(False)
        Me.PanelInnerDate.ResumeLayout(False)
        Me.PanelVendor.ResumeLayout(False)
        Me.PanelCheck.ResumeLayout(False)
        Me.PanelDetail.ResumeLayout(False)
        CType(Me.DsFrmRepBank1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDeposit.ResumeLayout(False)
        Me.PanelRdo.ResumeLayout(False)
        Me.PanelCheckByGlAcount.ResumeLayout(False)
        Me.PanelATM.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enum KindReport As Integer
        CheckReport = 1
        DepositReport = 2
        ATMReport = 3
        TransferReport = 4
        AdjustmentReport = 5
        CheckByAcount = 6
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
    Dim StrBank As String
    Dim StrVendor As String
    Dim StrRdo As String
    Dim StrDate As String
    Dim StrAcount As String
    Dim ComName As String = SystemInformation.ComputerName

    Private Sub FrmRepBank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        CalendarCombo1.Text = "01/01/" & PSalMali
        CalendarCombo2.Text = "12/28/" & PSalMali
        Call FillTextForm()
        Call VisibleControl()

    End Sub

    Private Sub ChkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDate.CheckedChanged
        If ChkDate.Checked Then
            PanelInnerDate.Enabled = False
        Else
            PanelInnerDate.Enabled = True
        End If
    End Sub


    Private Sub RdoAllBank_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllBank.CheckedChanged
        If RdoAllBank.Checked Then
            BtnBank.Enabled = False
        Else
            BtnBank.Enabled = True
        End If
    End Sub
    Private Sub RdoAllVendor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllVendor.CheckedChanged
        If RdoAllVendor.Checked Then
            BtnVendor.Enabled = False
        Else
            BtnVendor.Enabled = True
        End If
    End Sub

    Private Sub RdoAllAcount_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllAcount.CheckedChanged
        If RdoAllAcount.Checked Then
            BtnGlAcount.Enabled = False
        Else
            BtnGlAcount.Enabled = True
        End If
    End Sub

    Private Sub BtnVendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVendor.Click
        BtnVendor.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepBank1.vendor.Count = 0 Then
            DAInv_Vendor.Fill(DsFrmRepBank1.vendor)
        End If
        f.Text = "  Select Vendor"
        f.TypeOfForm = FrmSelect.KindForm.vendor
        f.DSMAIN = DsFrmRepBank1
        f.ShowDialog()
        BtnVendor.Enabled = True
    End Sub

    Private Sub BtnBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBank.Click
        BtnBank.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepBank1.bank.Count = 0 Then
            DABas_Bank.Fill(DsFrmRepBank1.bank)
        End If
        f.Text = "  Select Bank"
        f.TypeOfForm = FrmSelect.KindForm.bank
        f.DSMAIN = DsFrmRepBank1
        f.ShowDialog()
        BtnBank.Enabled = True
    End Sub

    Private Sub BtnGlAcount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGlAcount.Click
        BtnGlAcount.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepBank1.account.Count = 0 Then
            DAGL_Acount.Fill(DsFrmRepBank1.account)
        End If
        f.Text = "  Select Gl Acount"
        f.TypeOfForm = FrmSelect.KindForm.account
        f.DSMAIN = DsFrmRepBank1
        f.ShowDialog()
        BtnGlAcount.Enabled = True

    End Sub
    Private Sub VisibleControl()
        Select Case MKindOfReport
            Case KindReport.CheckReport
                PanelCheck.BringToFront()
            Case KindReport.DepositReport
                PanelDeposit.BringToFront()
                PanelVendor.Visible = False
            Case KindReport.ATMReport
                PanelATM.BringToFront()
            Case KindReport.TransferReport
                PanelRdo.Visible = False
                PanelVendor.Visible = False
            Case KindReport.AdjustmentReport
                PanelRdo.Visible = False
                PanelVendor.Visible = False
            Case KindReport.CheckByAcount
                PanelCheckByGlAcount.BringToFront()
        End Select
    End Sub
    Private Sub FillTextForm()
        Select Case MKindOfReport
            Case KindReport.CheckReport
                Me.Text = "   Checks Reports"
            Case KindReport.DepositReport
                Me.Text = " Bank Deposit Report"
            Case KindReport.ATMReport
                Me.Text = "  ATM Listing Report"
            Case KindReport.TransferReport
                Me.Text = "  Transfer Reports"
            Case KindReport.AdjustmentReport
                Me.Text = "   Adjustment Reports"
            Case KindReport.CheckByAcount
                Me.Text = "  Checks By GL Account Reports"
        End Select
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If ControlSelect() Then
            Dim f As New FrmPrint
            f.StrWhere = ""
            f.StrFilter = ""
            If RdoSelectedBank.Checked Then
                f.StrWhere = f.StrWhere & " (" & StrBank & ") and "
                f.StrFilter = f.StrFilter & "Bank, "
                f.FBank = True
            Else
                f.FBank = False
            End If
            If RdoSelectedVendor.Checked Then
                f.StrWhere = f.StrWhere & " (" & StrVendor & ") and "
                f.StrFilter = f.StrFilter & "Vendor,"
            End If
            If StrDate.Trim.Length > 0 Then
                f.StrWhere = f.StrWhere & " (" & StrDate & ") and "
                f.StrFilter = f.StrFilter & "Date, "
                f.Date1 = CalendarCombo1.Text
                f.Date2 = CalendarCombo2.Text
            Else
                f.Date1 = ""
                f.Date2 = ""
            End If
            If StrRdo.Trim.Length > 0 Then
                f.StrWhere = f.StrWhere & "(" & StrRdo & ") and "
            End If
            If RdoSelectedAcount.Checked Then
                f.StrWhere = f.StrWhere & " (" & StrAcount & ") and "
                f.StrFilter = f.StrFilter & "Acount, "

            End If
            If f.StrWhere.Trim.Length > 0 Then f.StrWhere = Mid(f.StrWhere, 1, f.StrWhere.Length - 4)
            If f.StrFilter.Trim.Length > 0 Then f.StrFilter = Mid(f.StrFilter, 1, f.StrFilter.Length - 2)
            Select Case MKindOfReport
                Case KindReport.CheckReport
                    If RdoDetail.Checked Then
                        f.KindOfReport = FrmPrint.KindReport.CheckDetail
                    Else
                        f.KindOfReport = FrmPrint.KindReport.CheckSummery
                    End If
                Case KindReport.DepositReport
                    If RdoDetail.Checked Then
                        f.KindOfReport = FrmPrint.KindReport.DepositDetail
                    Else
                        f.KindOfReport = FrmPrint.KindReport.DepositSummery
                    End If
                Case KindReport.ATMReport
                    If RdoDetail.Checked Then
                        f.KindOfReport = FrmPrint.KindReport.ATMDetail
                    Else
                        f.KindOfReport = FrmPrint.KindReport.ATMSummery
                    End If
                Case KindReport.TransferReport
                    f.KindOfReport = FrmPrint.KindReport.Transfer
                Case KindReport.AdjustmentReport
                    f.KindOfReport = FrmPrint.KindReport.Adjustment
                Case KindReport.CheckByAcount
                    If RdoDetail.Checked Then
                        f.KindOfReport = FrmPrint.KindReport.CheckByAcountDetail
                    Else
                        f.KindOfReport = FrmPrint.KindReport.CheckByAcountSummery
                    End If
            End Select
            f.DSMain = DsFrmRepBank1
            If MKindOfReport = 1 Or MKindOfReport = 2 Or MKindOfReport = 3 Or MKindOfReport = 6 Then
                If RdoDetail.Checked Then
                    f.Text = Me.Text & " In Detail "
                Else
                    f.Text = Me.Text & " In Summary "
                End If
            Else
                f.Text = Me.Text
            End If

            f.ShowDialog()

            If RdoSelectedBank.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Bank_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If

            If RdoSelectedVendor.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Vendor" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                Try
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                End Try
            End If

            If RdoSelectedAcount.Checked Then
                CmdGeneral.CommandText = " DROP TABLE ACC_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If


        End If


    End Sub
    Private Function ControlSelect() As Boolean
        ControlSelect = True
        StrRdo = ""
        StrDate = ""
        StrVendor = ""
        StrBank = ""
        StrAcount = ""
        Dim i As Integer
        If RdoSelectedBank.Checked Then

            If DsFrmRepBank1.bank.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Banks that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Bank_" & ComName & "(id_bank smallint)"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Bank_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepBank1.bank.Count - 1
                    If DsFrmRepBank1.bank(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Bank_" & ComName & " (id_bank ) VALUES (" & Qt(DsFrmRepBank1.bank(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrBank = " bas_banks.id_bank in (select id_bank from Bank_" & ComName & ") "
            End If





            'For i = 0 To DsFrmRepBank1.bank.Count - 1
            '    If DsFrmRepBank1.bank(i).flag Then
            '        StrBank = StrBank & " bas_banks.id_bank = " & Qt(DsFrmRepBank1.bank(i).cod) & " or "
            '    End If
            'Next
            'If StrBank.Trim.Length > 0 Then
            '    StrBank = Mid(StrBank, 1, StrBank.Length - 3)
            'Else
            '    ControlSelect = False
            '    MsgBox("First Select Banks that you want")
            '    Exit Function
            'End If


            If DsFrmRepBank1.bank.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgFar("First Select Banks that you want")
                Exit Function
            End If

        End If
        '''''''vendor
        If RdoSelectedVendor.Checked Then


            If DsFrmRepBank1.vendor.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgFar("First Select Vendor that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Vendor" & ComName & "(cod_vendor char(6))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Vendor" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepBank1.vendor.Count - 1
                    If DsFrmRepBank1.vendor(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Vendor" & ComName & " (cod_vendor ) VALUES (" & Qt(DsFrmRepBank1.vendor(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next

                Select Case MKindOfReport
                    Case KindReport.CheckReport
                        StrVendor = " bank_check.cod_vendor IN (select cod_vendor from Vendor" & ComName & ") "
                    Case KindReport.ATMReport
                        StrVendor = " bank_ATM.cod_vendor IN (select cod_vendor from Vendor" & ComName & ") "
                    Case KindReport.CheckByAcount
                        StrVendor = " bank_check.cod_vendor IN (select cod_vendor from Vendor" & ComName & ") "

                End Select

            End If





            'If DsFrmRepBank1.vendor.Select(" flag = 1 ").Length > 50 Then
            '    ControlSelect = False
            '    MsgFar("You Can Select At List 50 Acount")
            '    Exit Function
            'End If
            'If DsFrmRepBank1.vendor.Select(" flag = 1 ").Length > 0 Then
            '    Select Case MKindOfReport
            '        Case KindReport.CheckReport
            '            StrVendor = " bank_check.cod_vendor IN ("
            '        Case KindReport.ATMReport
            '            StrVendor = " bank_ATM.cod_vendor IN ("
            '        Case KindReport.CheckByAcount
            '            StrVendor = " bank_check.cod_vendor IN ("
            '    End Select
            '    For i = 0 To DsFrmRepBank1.vendor.Count - 1
            '        If DsFrmRepBank1.vendor(i).flag Then
            '            Select Case MKindOfReport
            '                Case KindReport.CheckReport
            '                    StrVendor = StrVendor & Qt(DsFrmRepBank1.vendor(i).cod) & " , "
            '                Case KindReport.ATMReport
            '                    StrVendor = StrVendor & Qt(DsFrmRepBank1.vendor(i).cod) & " , "
            '                Case KindReport.CheckByAcount
            '                    StrVendor = StrVendor & Qt(DsFrmRepBank1.vendor(i).cod) & " , "
            '            End Select
            '        End If
            '    Next
            'Else
            '    ControlSelect = False
            '    MsgFar("First Select Vendor that you want")
            '    Exit Function
            'End If
            'StrVendor = Mid(StrVendor, 1, StrVendor.Length - 3)
            'StrVendor = StrVendor & " ) "
        End If
        '''''''''''Acount
        If RdoSelectedAcount.Checked Then
            If DsFrmRepBank1.account.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Acount that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table ACC_" & ComName & "(GL_account char(10))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM ACC_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepBank1.account.Count - 1
                    If DsFrmRepBank1.account(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO ACC_" & ComName & " (GL_account ) VALUES (" & Qt(DsFrmRepBank1.account(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrAcount = " bank_check_dtl.GL_Account in (select GL_account from ACC_" & ComName & ") "
            End If




            'If DsFrmRepBank1.account.Select(" flag = 1 ").Length > 150 Then
            '    ControlSelect = False
            '    MsgBox("You Can Select At List 150 Acount")
            '    Exit Function
            'End If
            'If DsFrmRepBank1.account.Select(" flag = 1 ").Length > 0 Then
            '    StrAcount = " bank_check_dtl.GL_Account IN ("
            '    For i = 0 To DsFrmRepBank1.account.Count - 1
            '        If DsFrmRepBank1.account(i).flag Then
            '            StrAcount = StrAcount & Qt(DsFrmRepBank1.account(i).cod) & " , "
            '        End If
            '    Next

            '    StrAcount = Mid(StrAcount, 1, StrAcount.Length - 2)
            '    StrAcount = StrAcount & " ) "
            'Else
            '    ControlSelect = False
            '    MsgBox("First Select Acount that you want")
            '    Exit Function

            'End If


        End If

        If Not (ChkDate.Checked) Then
            If ChangeDateToYYYYMMDD(CalendarCombo1.Text) > ChangeDateToYYYYMMDD(CalendarCombo2.Text) Then
                ControlSelect = False
                MsgBox("First Date Must Be Befor To Date")
                Exit Function
            Else
                Select Case MKindOfReport
                    Case KindReport.CheckReport
                        StrDate = " dbo.ChangeDate(bank_check.date_of_check) between " & Qt(ChangeDateToYYYYMMDD(CalendarCombo1.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalendarCombo2.Text))
                    Case KindReport.DepositReport
                        StrDate = " dbo.ChangeDate(GL_debit_deposit_head.date_doc) between " & Qt(ChangeDateToYYYYMMDD(CalendarCombo1.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalendarCombo2.Text))
                    Case KindReport.ATMReport
                        StrDate = " dbo.ChangeDate(bank_ATM.date_transaction) between " & Qt(ChangeDateToYYYYMMDD(CalendarCombo1.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalendarCombo2.Text))
                    Case KindReport.TransferReport
                        StrDate = " dbo.ChangeDate(GL_transfer_amount.date_transfer) between " & Qt(ChangeDateToYYYYMMDD(CalendarCombo1.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalendarCombo2.Text))
                    Case KindReport.AdjustmentReport
                        StrDate = " dbo.ChangeDate(bank_adjustment_head.adjustment_date) between " & Qt(ChangeDateToYYYYMMDD(CalendarCombo1.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalendarCombo2.Text))
                    Case KindReport.CheckByAcount
                        StrDate = " dbo.ChangeDate(bank_check.date_of_check) between " & Qt(ChangeDateToYYYYMMDD(CalendarCombo1.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalendarCombo2.Text))
                End Select
            End If
        End If

        Select Case MKindOfReport
            Case KindReport.CheckReport
                If RdoSTActive.Checked Then StrRdo = " bank_check.check_status = '0'"
                If RdoSTVoid.Checked Then StrRdo = " bank_check.check_status = '1'"
                If RdoSTDelete.Checked Then StrRdo = " bank_check.check_status = '2'"
                If RdoSTReturn.Checked Then StrRdo = " bank_check.check_status = '3'"
            Case KindReport.DepositReport
                If RdoDepCash.Checked Then StrRdo = " GL_payment_deposit.payment_type ='1' or GL_payment_deposit.payment_type ='2'"
                If RdoDepCredit.Checked Then StrRdo = " GL_payment_deposit.payment_type ='3' "
            Case KindReport.ATMReport
                If RdoATMCharge.Checked Then StrRdo = " bank_ATM.ChargeCredit = '1'"
                If RdoATMCredit.Checked Then StrRdo = " bank_ATM.ChargeCredit = '2'"
        End Select
    End Function


    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class
