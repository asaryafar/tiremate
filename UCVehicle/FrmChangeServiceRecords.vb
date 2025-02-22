Imports CommonClass
Public Class FrmChangeServiceRecords
    Inherits FrmBase
    Public ChangeDateVar As String
    Event SaveThis(ByVal LicenceNo As String, ByVal coustomercod As String, ByVal ChangeDate As String)
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
    Public WithEvents CustomerCod1 As UCCustomer.CustomerCod
    Public WithEvents TXTLicenseNo As System.Windows.Forms.TextBox
    Friend WithEvents LblCustomerName As System.Windows.Forms.Label
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents LblCustomerCod1 As System.Windows.Forms.Label
    Friend WithEvents LblLicenseNo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmChangeServiceRecords))
        Me.CustomerCod1 = New UCCustomer.CustomerCod
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.LblCustomerCod1 = New System.Windows.Forms.Label
        Me.TXTLicenseNo = New System.Windows.Forms.TextBox
        Me.LblLicenseNo = New System.Windows.Forms.Label
        Me.LblCustomerName = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label42 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label50 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerCod1
        '
        Me.CustomerCod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerCod1.Connection = Me.Cnn
        Me.CustomerCod1.CustomerCod = ""
        Me.CustomerCod1.CustomerCodLen = 10
        Me.CustomerCod1.Location = New System.Drawing.Point(87, 76)
        Me.CustomerCod1.Name = "CustomerCod1"
        Me.CustomerCod1.NotExitIfNotFound = False
        Me.CustomerCod1.ReleaseIfNotFoundCustomerCod = False
        Me.CustomerCod1.Size = New System.Drawing.Size(128, 19)
        Me.CustomerCod1.TabIndex = 328
        '
        'LblCustomerCod1
        '
        Me.LblCustomerCod1.BackColor = System.Drawing.Color.Transparent
        Me.LblCustomerCod1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblCustomerCod1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblCustomerCod1.Location = New System.Drawing.Point(22, 77)
        Me.LblCustomerCod1.Name = "LblCustomerCod1"
        Me.LblCustomerCod1.Size = New System.Drawing.Size(63, 14)
        Me.LblCustomerCod1.TabIndex = 330
        Me.LblCustomerCod1.Text = "New Owner"
        Me.LblCustomerCod1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTLicenseNo
        '
        Me.TXTLicenseNo.BackColor = System.Drawing.SystemColors.Window
        Me.TXTLicenseNo.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TXTLicenseNo.Location = New System.Drawing.Point(87, 50)
        Me.TXTLicenseNo.MaxLength = 50
        Me.TXTLicenseNo.Name = "TXTLicenseNo"
        Me.TXTLicenseNo.TabIndex = 327
        Me.TXTLicenseNo.Text = ""
        '
        'LblLicenseNo
        '
        Me.LblLicenseNo.BackColor = System.Drawing.Color.Transparent
        Me.LblLicenseNo.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblLicenseNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblLicenseNo.Location = New System.Drawing.Point(2, 52)
        Me.LblLicenseNo.Name = "LblLicenseNo"
        Me.LblLicenseNo.Size = New System.Drawing.Size(88, 14)
        Me.LblLicenseNo.TabIndex = 329
        Me.LblLicenseNo.Text = "New License No."
        Me.LblLicenseNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCustomerName
        '
        Me.LblCustomerName.BackColor = System.Drawing.Color.Transparent
        Me.LblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCustomerName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblCustomerName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblCustomerName.Location = New System.Drawing.Point(217, 76)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(201, 20)
        Me.LblCustomerName.TabIndex = 331
        Me.LblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label42)
        Me.Panel9.Controls.Add(Me.BtnCancel)
        Me.Panel9.Controls.Add(Me.Label50)
        Me.Panel9.Controls.Add(Me.BtnSave)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.PictureBox2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(421, 45)
        Me.Panel9.TabIndex = 332
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(365, 31)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(39, 10)
        Me.Label42.TabIndex = 202
        Me.Label42.Text = "Cancel"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(368, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 200
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(307, 31)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 201
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(307, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 199
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(74, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 43)
        Me.Label5.TabIndex = 198
        Me.Label5.Text = "Changes in Vehicle Ownership and License No "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 197
        Me.PictureBox2.TabStop = False
        '
        'FrmChangeServiceRecords
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(421, 101)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.LblCustomerName)
        Me.Controls.Add(Me.CustomerCod1)
        Me.Controls.Add(Me.LblCustomerCod1)
        Me.Controls.Add(Me.TXTLicenseNo)
        Me.Controls.Add(Me.LblLicenseNo)
        Me.MinimizeBox = False
        Me.Name = "FrmChangeServiceRecords"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Service Records"
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmChangeServiceRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        'TXTLicenseNo.Text = ""
        'CustomerCod1.Text = ""
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        TXTLicenseNo.Text = ""
        CustomerCod1.Text = ""
        Me.Close()
    End Sub
    Private Sub TXTLicenseNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTLicenseNo.TextChanged, CustomerCod1.TextChanged, LblCustomerName.TextChanged
        If (TXTLicenseNo.Text.Trim.Length > 0 Or TXTLicenseNo.Visible = False) And (LblCustomerName.Text.Trim.Length > 0 Or TXTLicenseNo.Visible = False) And ThisFormStatus = MainModule.WorkStates.AddNew Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        ChangeDateVar = Format(Now.Today, PubDateFormat)
        If TXTLicenseNo.Text.Trim <> "" And CustomerCod1.Text <> "" And LblCustomerName.Text.Trim <> "" Then
            RaiseEvent SaveThis(TXTLicenseNo.Text.Trim, CustomerCod1.Text, ChangeDateVar)
        Else
            MsgFar("Data Is not Complete For save Try Again")
        End If

        Me.Close()
    End Sub
    Private Sub CustomerCod1_FindCustomerCod() Handles CustomerCod1.FindCustomerCod
        LblCustomerName.Text = CustomerCod1.CustomerDesc
    End Sub
    Private Sub CustomerCod1_NotFindCustomerCod() Handles CustomerCod1.NotFindCustomerCod
        LblCustomerName.Text = ""
    End Sub

   
End Class
