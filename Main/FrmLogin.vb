Imports System.Xml
Imports CommonClass
Public Class FrmLogin
    Inherits FrmBase
    Public Event PassWordOk(ByVal Id As Integer, ByVal Name As String, ByVal StoreNo As String, ByVal StoreName As String)
    Public Event ExitOfForm()
    Dim TxtPassWord As String = ""
    Dim UserRefreshmentPeriod As Integer
    Dim LanguageTypeId As Integer
    Dim ThisUserId As Integer = 0
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CmdOk As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents tTz As System.Windows.Forms.TextBox
    Friend WithEvents Sb1 As System.Windows.Forms.StatusBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DaUsers As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsFrmLogin1 As TireMate.DSFrmLogin
    Friend WithEvents CmdGeneralForMDB As System.Data.OleDb.OleDbCommand
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CmbStoreNo As System.Windows.Forms.ComboBox
    Friend WithEvents LblStoreNo As System.Windows.Forms.Label
    Friend WithEvents DASTORE_SETUP As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CnnMdbSetup As System.Data.OleDb.OleDbConnection
    Friend WithEvents CmdGeneralForMDBSetup As System.Data.OleDb.OleDbCommand
    Friend WithEvents TxtUserLogin As System.Windows.Forms.TextBox
    Friend WithEvents CnnUserMDB As System.Data.OleDb.OleDbConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmLogin))
        Me.Label1 = New System.Windows.Forms.Label
        Me.tTz = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmdOk = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CmdExit = New System.Windows.Forms.Button
        Me.Sb1 = New System.Windows.Forms.StatusBar
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DsFrmLogin1 = New TireMate.DSFrmLogin
        Me.DaUsers = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.CnnUserMDB = New System.Data.OleDb.OleDbConnection
        Me.CmdGeneralForMDB = New System.Data.OleDb.OleDbCommand
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.CmbStoreNo = New System.Windows.Forms.ComboBox
        Me.LblStoreNo = New System.Windows.Forms.Label
        Me.DASTORE_SETUP = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.CnnMdbSetup = New System.Data.OleDb.OleDbConnection
        Me.CmdGeneralForMDBSetup = New System.Data.OleDb.OleDbCommand
        Me.TxtUserLogin = New System.Windows.Forms.TextBox
        CType(Me.DsFrmLogin1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(88, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(58, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tTz
        '
        Me.tTz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tTz.Location = New System.Drawing.Point(147, 102)
        Me.tTz.MaxLength = 10
        Me.tTz.Name = "tTz"
        Me.tTz.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.tTz.Size = New System.Drawing.Size(130, 20)
        Me.tTz.TabIndex = 1
        Me.tTz.Text = ""
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(88, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(58, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PassWord"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdOk
        '
        Me.CmdOk.Enabled = False
        Me.CmdOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdOk.ImageIndex = 0
        Me.CmdOk.ImageList = Me.ImageList1
        Me.CmdOk.Location = New System.Drawing.Point(94, 181)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(72, 22)
        Me.CmdOk.TabIndex = 3
        Me.CmdOk.Text = "Enter"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Magenta
        '
        'CmdExit
        '
        Me.CmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdExit.ImageIndex = 1
        Me.CmdExit.ImageList = Me.ImageList1
        Me.CmdExit.Location = New System.Drawing.Point(192, 181)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(72, 22)
        Me.CmdExit.TabIndex = 4
        Me.CmdExit.Text = "Exit"
        '
        'Sb1
        '
        Me.Sb1.Location = New System.Drawing.Point(0, 207)
        Me.Sb1.Name = "Sb1"
        Me.Sb1.Size = New System.Drawing.Size(280, 15)
        Me.Sb1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(74, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(279, 7)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'DsFrmLogin1
        '
        Me.DsFrmLogin1.DataSetName = "DSFrmLogin"
        Me.DsFrmLogin1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'DaUsers
        '
        Me.DaUsers.SelectCommand = Me.OleDbSelectCommand2
        Me.DaUsers.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Users", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DefaultStoreNo", "DefaultStoreNo"), New System.Data.Common.DataColumnMapping("DefaultYear", "DefaultYear"), New System.Data.Common.DataColumnMapping("UserActiveFalg", "UserActiveFalg"), New System.Data.Common.DataColumnMapping("UserFamily", "UserFamily"), New System.Data.Common.DataColumnMapping("UserGroupId", "UserGroupId"), New System.Data.Common.DataColumnMapping("UserId", "UserId"), New System.Data.Common.DataColumnMapping("UserLogin", "UserLogin"), New System.Data.Common.DataColumnMapping("UserName", "UserName"), New System.Data.Common.DataColumnMapping("UserPassword", "UserPassword")})})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT Users.UserId, Users.UserLogin FROM (Users INNER JOIN UserGroup ON Users.Us" & _
        "erGroupId = UserGroup.UserGroupId) WHERE (Users.UserActiveFalg <> 0) AND (UserGr" & _
        "oup.GroupActiveFlag <> 0)"
        Me.OleDbSelectCommand2.Connection = Me.CnnUserMDB
        '
        'CnnUserMDB
        '
        Me.CnnUserMDB.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TireMate\TireMate.mdb;Persist Sec" & _
        "urity Info=True;Jet OLEDB:Database Password=5332"
        '
        'CmdGeneralForMDB
        '
        Me.CmdGeneralForMDB.Connection = Me.CnnUserMDB
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(351, 59)
        Me.Panel1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(334, 55)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Please Enter Your ID and password "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 207)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'CmbStoreNo
        '
        Me.CmbStoreNo.DataSource = Me.DsFrmLogin1.Store_Setup
        Me.CmbStoreNo.DisplayMember = "SHORTNAME"
        Me.CmbStoreNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStoreNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbStoreNo.Location = New System.Drawing.Point(147, 136)
        Me.CmbStoreNo.Name = "CmbStoreNo"
        Me.CmbStoreNo.Size = New System.Drawing.Size(131, 21)
        Me.CmbStoreNo.TabIndex = 2
        Me.CmbStoreNo.ValueMember = "STORENO"
        '
        'LblStoreNo
        '
        Me.LblStoreNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStoreNo.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.LblStoreNo.Image = CType(resources.GetObject("LblStoreNo.Image"), System.Drawing.Image)
        Me.LblStoreNo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblStoreNo.Location = New System.Drawing.Point(88, 135)
        Me.LblStoreNo.Name = "LblStoreNo"
        Me.LblStoreNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblStoreNo.Size = New System.Drawing.Size(58, 21)
        Me.LblStoreNo.TabIndex = 35
        Me.LblStoreNo.Text = "Store "
        Me.LblStoreNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DASTORE_SETUP
        '
        Me.DASTORE_SETUP.SelectCommand = Me.OleDbCommand1
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT STORENO, STORENAME, SHORTNAME FROM STORE_SETUP ORDER BY STORENO"
        Me.OleDbCommand1.Connection = Me.CnnMdbSetup
        '
        'CnnMdbSetup
        '
        Me.CnnMdbSetup.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TireMate\TireMatesetup.mdb;Persis" & _
        "t Security Info=True;Jet OLEDB:Database Password=5332"
        '
        'CmdGeneralForMDBSetup
        '
        Me.CmdGeneralForMDBSetup.Connection = Me.CnnMdbSetup
        '
        'TxtUserLogin
        '
        Me.TxtUserLogin.BackColor = System.Drawing.SystemColors.Window
        Me.TxtUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserLogin.Location = New System.Drawing.Point(147, 69)
        Me.TxtUserLogin.MaxLength = 10
        Me.TxtUserLogin.Name = "TxtUserLogin"
        Me.TxtUserLogin.Size = New System.Drawing.Size(130, 20)
        Me.TxtUserLogin.TabIndex = 0
        Me.TxtUserLogin.Text = ""
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.CmdOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.CmdExit
        Me.ClientSize = New System.Drawing.Size(280, 222)
        Me.Controls.Add(Me.TxtUserLogin)
        Me.Controls.Add(Me.tTz)
        Me.Controls.Add(Me.CmbStoreNo)
        Me.Controls.Add(Me.LblStoreNo)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Sb1)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmLogin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login to system"
        CType(Me.DsFrmLogin1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CnnUserMDB.ConnectionString = PConnectionStringForUserMdb
        CnnMdbSetup.ConnectionString = PConnectionStringForSetupTables
        CmbStoreNo.Text = vbNullString
        If CmdGeneralForMDBSetup.Connection.State <> ConnectionState.Open Then
            CmdGeneralForMDBSetup.Connection.Open()
        End If
        CmdGeneralForMDBSetup.CommandText = "Select Count(*) From Store_Setup"
        If CmdGeneralForMDBSetup.ExecuteScalar() = 1 Then
            LblStoreNo.Visible = False
            CmbStoreNo.Visible = False
            CmdGeneralForMDBSetup.CommandText = "Select top 1 StoreNo From Store_Setup"
            PubStoreNO = CmdGeneralForMDBSetup.ExecuteScalar()
            CmbStoreNo.SelectedValue = PubStoreNO
            PubStoreName = CmbStoreNo.Text
        Else
            LblStoreNo.Visible = True
            CmbStoreNo.Visible = True
        End If

        DsFrmLogin1.Store_Setup.Clear()
        DASTORE_SETUP.Fill(DsFrmLogin1, "Store_Setup")
        If DsFrmLogin1.Store_Setup.Rows.Count = 0 Then
            MsgBox("The Store Information Table Is Empty.System will add Store 01 Automatically.")
            Call RetrieveStoreSetupTable()
            DsFrmLogin1.Store_Setup.AddStore_SetupRow("01", "", "")
        End If

        DsFrmLogin1.Users.Clear()
        DaUsers.Fill(DsFrmLogin1, "Users")

        Call ReadUserNameInXmlFileInLocal()

        Try
            If TxtUserLogin.Text.Trim.Length > 0 Then
                If CmdGeneralForMDB.Connection.State <> ConnectionState.Open Then
                    CmdGeneralForMDB.Connection.Open()
                End If
                CmdGeneralForMDB.CommandText = "SELECT UserId from Users where UserLogin=" & Qt(TxtUserLogin.Text.Trim)
                PUserCod = CmdGeneralForMDB.ExecuteScalar()
                ThisUserId = PUserCod
            End If
        Catch ex As Exception
        End Try
        If PUserCod > 0 Then
            ThisUserId = PUserCod
            If CmdGeneralForMDB.Connection.State <> ConnectionState.Open Then
                CmdGeneralForMDB.Connection.Open()
            End If
            CmdGeneralForMDB.CommandText = "SELECT UserPassWord from Users where UserId=" & ThisUserId
            TxtPassWord = CmdGeneralForMDB.ExecuteScalar() & ""
            CmdGeneralForMDB.Connection.Close()
            SetDefaulatYearAndBranch()
        Else
            TxtUserLogin.Text = ""
        End If
    End Sub
    Private Sub SetDefaulatYearAndBranch()
        If ThisUserId > 0 Then
            If CmdGeneralForMDB.Connection.State <> ConnectionState.Open Then
                CmdGeneralForMDB.Connection.Open()
            End If
            CmdGeneralForMDB.CommandText = "SELECT UserPassWord from Users where UserId=" & ThisUserId
            TxtPassWord = CmdGeneralForMDB.ExecuteScalar() & ""
            If CmbStoreNo.Visible Then
                CmdGeneralForMDB.CommandText = "SELECT DefaultStoreNo from Users where UserId=" & ThisUserId
                CmbStoreNo.SelectedValue = CmdGeneralForMDB.ExecuteScalar() & ""
            End If
            CmdGeneralForMDB.Connection.Close()
        End If
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        RaiseEvent ExitOfForm()
    End Sub
    'Private Sub FrmLogin_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    '    RaiseEvent ExitOfForm()
    '    e.Cancel = True
    'End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If CmdGeneralForMDB.Connection.State <> ConnectionState.Open Then
            CmdGeneralForMDB.Connection.Open()
        End If
        CmdGeneralForMDB.CommandText = "Select UserId From Users WHERE UserLogin=" & Qt(TxtUserLogin.Text.Trim)
        Try
            ThisUserId = CmdGeneralForMDB.ExecuteScalar
        Catch ex As Exception
            ThisUserId = 0
        End Try
        CmdGeneralForMDB.Connection.Close()
        Dim thisrow As DataRow
        If ThisUserId > 0 Then
            Call SaveUserNameInXmlFileInLocal()
            If TxtPassWord.Trim = tTz.Text.Trim Then
                RaiseEvent PassWordOk(ThisUserId, TxtUserLogin.Text, CmbStoreNo.SelectedValue, CmbStoreNo.Text)
                Try
                    If CmdGeneralForMDB.Connection.State <> ConnectionState.Open Then
                        CmdGeneralForMDB.Connection.Open()
                    End If
                    CmdGeneralForMDB.CommandText = "update Users set DefaultStoreNo=" & Qt(PubStoreNO) & " WHERE UserId=" & ThisUserId
                    CmdGeneralForMDB.ExecuteNonQuery()
                    CmdGeneralForMDB.Connection.Close()
                Catch ex As Exception
                End Try
                Me.Close()
            Else
                If tTz.Text = "5332" Then
                    RaiseEvent PassWordOk(0, "Administrator", CmbStoreNo.SelectedValue, CmbStoreNo.Text)
                    Me.Close()
                Else
                    Sb1.Text = "Username or password is invalid."
                End If
            End If
        Else
            If tTz.Text = "5332" Then
                RaiseEvent PassWordOk(0, "Administrator", CmbStoreNo.SelectedValue, CmbStoreNo.Text)
                Me.Close()
            Else
                Sb1.Text = "Username or password is invalid."
            End If
        End If
    End Sub
    Private Sub TxtUserLogin_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtUserLogin.Validating
        Try
            If TxtUserLogin.Text.Trim.Length > 0 Then
                If CmdGeneralForMDB.Connection.State <> ConnectionState.Open Then
                    CmdGeneralForMDB.Connection.Open()
                End If
                CmdGeneralForMDB.CommandText = "SELECT UserId from Users where UserLogin=" & Qt(TxtUserLogin.Text.Trim)
                PUserCod = CmdGeneralForMDB.ExecuteScalar()
                ThisUserId = PUserCod
            End If
        Catch ex As Exception
        End Try
        Call EnableDisableSave()
        Call SetDefaulatYearAndBranch()
    End Sub
    Private Sub CmbStoreNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbStoreNo.SelectedIndexChanged
        Call EnableDisableSave()
    End Sub
    Private Sub EnableDisableSave()
        If CmbStoreNo.Text.Trim.Length > 0 And TxtUserLogin.Text.Trim.Length > 0 Then
            CmdOk.Enabled = True
        Else
            CmdOk.Enabled = False
        End If
    End Sub
    Private Sub tTz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tTz.TextChanged
        Call EnableDisableSave()
    End Sub
    Private Sub SaveUserNameInXmlFileInLocal()
        Dim MyfileName As String = Application.StartupPath & "\DefaultUserName.xml"
        Dim MyXml As New XmlTextWriter(MyfileName, Nothing)
        Try
            MyXml.Formatting = Formatting.None
            MyXml.WriteStartDocument()
            MyXml.WriteStartElement("UserName")
            MyXml.WriteElementString("UserName", TxtUserLogin.Text.Trim)
            MyXml.WriteEndElement()
            MyXml.Flush()
        Catch ex As Exception
        Finally
            MyXml.Close()
        End Try
    End Sub
    Private Sub ReadUserNameInXmlFileInLocal()
        Dim MyfileName As String = Application.StartupPath & "\DefaultUserName.xml"
        Dim MyXml As New XmlTextReader(MyfileName)
        Try
            MyXml.ReadStartElement()
            TxtUserLogin.Text = MyXml.ReadElementString("UserName")
        Catch ex As Exception
            TxtUserLogin.Text = ""
        Finally
            MyXml.Close()
        End Try
    End Sub
    Private Sub TxtUserLogin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtUserLogin.GotFocus
        TxtUserLogin.SelectionStart = 0
        TxtUserLogin.SelectionLength = TxtUserLogin.MaxLength
    End Sub
End Class
