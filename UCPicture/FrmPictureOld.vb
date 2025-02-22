Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Public Class FrmPicture
    Inherits CommonClass.FrmBase
    Public MMyPicture As Byte
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
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Public WithEvents DsFrmPicture1 As DSUCPicture
    Public WithEvents Picture1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnZoom As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnOpen As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPicture))
        Me.DsFrmPicture1 = New UCPicture.DSUCPicture
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnClear = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnOpen = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnZoom = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.DsFrmPicture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsFrmPicture1
        '
        Me.DsFrmPicture1.DataSetName = "DSUCPicture"
        Me.DsFrmPicture1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Picture1
        '
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Picture1.Location = New System.Drawing.Point(0, 52)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Size = New System.Drawing.Size(330, 239)
        Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture1.TabIndex = 63
        Me.Picture1.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Controls.Add(Me.BtnClear)
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Controls.Add(Me.BtnOpen)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.BtnZoom)
        Me.Panel9.Controls.Add(Me.PictureBox2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(330, 49)
        Me.Panel9.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(66, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 11)
        Me.Label3.TabIndex = 203
        Me.Label3.Text = "Clear"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnClear
        '
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClear.Image = CType(resources.GetObject("BtnClear.Image"), System.Drawing.Image)
        Me.BtnClear.Location = New System.Drawing.Point(68, 4)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(33, 29)
        Me.BtnClear.TabIndex = 202
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 11)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "Open"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnOpen
        '
        Me.BtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOpen.Image = CType(resources.GetObject("BtnOpen.Image"), System.Drawing.Image)
        Me.BtnOpen.Location = New System.Drawing.Point(11, 4)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(33, 29)
        Me.BtnOpen.TabIndex = 200
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(123, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 11)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "Zoom"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnZoom
        '
        Me.BtnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnZoom.Image = CType(resources.GetObject("BtnZoom.Image"), System.Drawing.Image)
        Me.BtnZoom.Location = New System.Drawing.Point(125, 4)
        Me.BtnZoom.Name = "BtnZoom"
        Me.BtnZoom.Size = New System.Drawing.Size(33, 29)
        Me.BtnZoom.TabIndex = 198
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(254, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 197
        Me.PictureBox2.TabStop = False
        '
        'FrmPicture
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(330, 291)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Picture1)
        Me.Name = "FrmPicture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.DsFrmPicture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public img As Image
    Public Property MyPicture()
        Get
            Picture1.Image.Save("C:\Tmp.Jpeg", ImageFormat.Jpeg)
            Dim fs As New FileStream("C:\Tmp.jpeg", FileMode.OpenOrCreate, FileAccess.Read)
            Dim MyData(fs.Length) As Byte
            Try
                fs.Read(MyData, 0, fs.Length)
                MMyPicture = MyData(fs.Length)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Return MyData
        End Get
        Set(ByVal Value)
            MMyPicture = Value
            Dim MyPicStream As New MemoryStream(MMyPicture)
            Picture1.Image = Image.FromStream(MyPicStream)
        End Set
    End Property
    Private Sub FrmPicture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        img = Nothing
        If Not IsNothing(Picture1.Image) Then
            Call SaveToDataset()
            Call ShowDataInForm()
        End If
        Call EnableZoom()
    End Sub
    Sub ShowDataInForm()
        Dim MyData() As Byte
        If DsFrmPicture1.PictureTable.Rows.Count = 0 Then
            img = Nothing
            Picture1.Image = Nothing
        Else
            MyData = DsFrmPicture1.Tables("PictureTable").Rows(0).Item("Picture")
            Dim MyPicStream As New MemoryStream(MyData)
            img = Image.FromStream(MyPicStream)
            Picture1.Image = img
            MyData = Nothing
            MyPicStream = Nothing
        End If
    End Sub
    Sub SaveDatainform(ByRef Myrow As DataRow)
        Picture1.Image.Save("C:\Tmp.Jpeg", ImageFormat.Jpeg)
        Dim fs As New FileStream("C:\Tmp.jpeg", FileMode.OpenOrCreate, FileAccess.Read)
        Dim MyData(fs.Length) As Byte
        Try
            fs.Read(MyData, 0, fs.Length)
            fs.Close()
            Myrow = DsFrmPicture1.Tables("PictureTable").NewRow()
            Myrow("picture") = MyData
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        fs = Nothing
        MyData = Nothing
    End Sub
    Sub EnableZoom()
        If Not IsNothing(Picture1.Image) Then
            BtnZoom.Enabled = True
        Else
            BtnZoom.Enabled = False
        End If
    End Sub
    Private Sub BtnZoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnZoom.Click
        Dim FrmZom As New FrmZoomPicture
        FrmZom.Picture1.Image = img
        FrmZom.ShowDialog()
    End Sub
    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        DsFrmPicture1.PictureTable.Clear()
        Picture1.Image = Nothing
        img = Nothing
        Call EnableZoom()
    End Sub
    Private Sub BtnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpen.Click
        OFD.Filter = "Images | *.bmp;*.tif;*.jpg;*.gif;*.jpeg"
        OFD.ShowDialog()
        If OFD.FileName.Trim & "" <> "" Then
            img = Image.FromFile(OFD.FileName)
            Picture1.Image = img
            Call SaveToDataset()
        End If
        Call ShowDataInForm()
    End Sub
    Public Sub SaveToDataset()
        If DsFrmPicture1.PictureTable.Rows.Count = 1 Then
            Dim myRow As DataRow = DsFrmPicture1.Tables("PictureTable").Rows(0)
            myRow = DsFrmPicture1.Tables("PictureTable").NewRow()
            Call SaveDatainform(myRow)
        Else
            Dim myRow As DataRow
            myRow = DsFrmPicture1.Tables("PictureTable").NewRow()
            Call SaveDatainform(myRow)
            DsFrmPicture1.Tables("PictureTable").Rows.Add(myRow)
        End If
        Call EnableZoom()
    End Sub
End Class

