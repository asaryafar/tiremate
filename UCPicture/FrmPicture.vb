Imports CommonClass
Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Public Class FrmPicture
    Inherits CommonClass.FrmBase
    Public ShowRealSizeFlag As Boolean = True
    Public MyTop As Integer
    Public MyLeft As Integer
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
    Public WithEvents Picture1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnOpen As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PnlHead As System.Windows.Forms.Panel
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents UiContextMenu1 As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents Zoom1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Zoom2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents BtnZoom As Janus.Windows.EditControls.UIButton
    Friend WithEvents Zoom3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Zoom4 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Zoom5 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Zoom6 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Zoom7 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Zoom8 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Zoom11 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Zoom21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Zoom31 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Zoom41 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Zoom51 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Zoom61 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Zoom71 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Zoom81 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPicture))
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.PnlHead = New System.Windows.Forms.Panel
        Me.BtnZoom = New Janus.Windows.EditControls.UIButton
        Me.UiContextMenu1 = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.UiCommandManager1 = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.Zoom1 = New Janus.Windows.UI.CommandBars.UICommand("Zoom1")
        Me.Zoom2 = New Janus.Windows.UI.CommandBars.UICommand("Zoom2")
        Me.Zoom3 = New Janus.Windows.UI.CommandBars.UICommand("Zoom3")
        Me.Zoom4 = New Janus.Windows.UI.CommandBars.UICommand("Zoom4")
        Me.Zoom5 = New Janus.Windows.UI.CommandBars.UICommand("Zoom5")
        Me.Zoom6 = New Janus.Windows.UI.CommandBars.UICommand("Zoom6")
        Me.Zoom7 = New Janus.Windows.UI.CommandBars.UICommand("Zoom7")
        Me.Zoom8 = New Janus.Windows.UI.CommandBars.UICommand("Zoom8")
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Zoom11 = New Janus.Windows.UI.CommandBars.UICommand("Zoom1")
        Me.Zoom21 = New Janus.Windows.UI.CommandBars.UICommand("Zoom2")
        Me.Zoom31 = New Janus.Windows.UI.CommandBars.UICommand("Zoom3")
        Me.Zoom41 = New Janus.Windows.UI.CommandBars.UICommand("Zoom4")
        Me.Zoom51 = New Janus.Windows.UI.CommandBars.UICommand("Zoom5")
        Me.Zoom61 = New Janus.Windows.UI.CommandBars.UICommand("Zoom6")
        Me.Zoom71 = New Janus.Windows.UI.CommandBars.UICommand("Zoom7")
        Me.Zoom81 = New Janus.Windows.UI.CommandBars.UICommand("Zoom8")
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnClear = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnOpen = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PnlHead.SuspendLayout()
        CType(Me.UiContextMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picture1
        '
        Me.Picture1.Location = New System.Drawing.Point(0, 50)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Size = New System.Drawing.Size(554, 408)
        Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Picture1.TabIndex = 63
        Me.Picture1.TabStop = False
        '
        'PnlHead
        '
        Me.PnlHead.BackColor = System.Drawing.SystemColors.Window
        Me.PnlHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlHead.Controls.Add(Me.BtnZoom)
        Me.PnlHead.Controls.Add(Me.Label4)
        Me.PnlHead.Controls.Add(Me.Label3)
        Me.PnlHead.Controls.Add(Me.BtnClear)
        Me.PnlHead.Controls.Add(Me.Label2)
        Me.PnlHead.Controls.Add(Me.BtnOpen)
        Me.PnlHead.Controls.Add(Me.Label1)
        Me.PnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHead.Location = New System.Drawing.Point(0, 0)
        Me.PnlHead.Name = "PnlHead"
        Me.PnlHead.Size = New System.Drawing.Size(214, 49)
        Me.PnlHead.TabIndex = 64
        '
        'BtnZoom
        '
        Me.BtnZoom.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.DropDownButton
        Me.BtnZoom.DropDownContextMenu = Me.UiContextMenu1
        Me.BtnZoom.Image = CType(resources.GetObject("BtnZoom.Image"), System.Drawing.Image)
        Me.BtnZoom.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnZoom.Location = New System.Drawing.Point(73, 4)
        Me.BtnZoom.Name = "BtnZoom"
        Me.BtnZoom.Size = New System.Drawing.Size(49, 29)
        Me.BtnZoom.TabIndex = 205
        '
        'UiContextMenu1
        '
        Me.UiContextMenu1.CommandManager = Me.UiCommandManager1
        Me.UiContextMenu1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Zoom11, Me.Zoom21, Me.Zoom31, Me.Zoom41, Me.Zoom51, Me.Zoom61, Me.Zoom71, Me.Zoom81})
        Me.UiContextMenu1.Key = "ContextMenu1"
        Me.UiContextMenu1.UseThemes = Janus.Windows.UI.InheritableBoolean.True
        Me.UiContextMenu1.VisualStyle = Janus.Windows.UI.VisualStyle.Standard
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.BottomRebar = Me.BottomRebar1
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Zoom1, Me.Zoom2, Me.Zoom3, Me.Zoom4, Me.Zoom5, Me.Zoom6, Me.Zoom7, Me.Zoom8})
        Me.UiCommandManager1.ContainerControl = Me
        Me.UiCommandManager1.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.UiContextMenu1})
        Me.UiCommandManager1.Id = New System.Guid("102a2b45-efe9-466c-a198-ab55836f679b")
        Me.UiCommandManager1.LeftRebar = Me.LeftRebar1
        Me.UiCommandManager1.RightRebar = Me.RightRebar1
        Me.UiCommandManager1.TopRebar = Me.TopRebar1
        '
        'Zoom1
        '
        Me.Zoom1.Key = "Zoom1"
        Me.Zoom1.Name = "Zoom1"
        Me.Zoom1.Text = "25%"
        '
        'Zoom2
        '
        Me.Zoom2.Key = "Zoom2"
        Me.Zoom2.Name = "Zoom2"
        Me.Zoom2.Text = "50%"
        '
        'Zoom3
        '
        Me.Zoom3.Key = "Zoom3"
        Me.Zoom3.Name = "Zoom3"
        Me.Zoom3.Text = "100%"
        '
        'Zoom4
        '
        Me.Zoom4.Key = "Zoom4"
        Me.Zoom4.Name = "Zoom4"
        Me.Zoom4.Text = "150%"
        '
        'Zoom5
        '
        Me.Zoom5.Key = "Zoom5"
        Me.Zoom5.Name = "Zoom5"
        Me.Zoom5.Text = "200%"
        '
        'Zoom6
        '
        Me.Zoom6.Key = "Zoom6"
        Me.Zoom6.Name = "Zoom6"
        Me.Zoom6.Text = "300%"
        '
        'Zoom7
        '
        Me.Zoom7.Key = "Zoom7"
        Me.Zoom7.Name = "Zoom7"
        Me.Zoom7.Text = "400%"
        '
        'Zoom8
        '
        Me.Zoom8.Key = "Zoom8"
        Me.Zoom8.Name = "Zoom8"
        Me.Zoom8.Text = "500%"
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.UiCommandManager1
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.TabIndex = 0
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.UiCommandManager1
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 0)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.TabIndex = 0
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.UiCommandManager1
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.TabIndex = 0
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.UiCommandManager1
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(0, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.TabIndex = 0
        '
        'Zoom11
        '
        Me.Zoom11.Key = "Zoom1"
        Me.Zoom11.Name = "Zoom11"
        '
        'Zoom21
        '
        Me.Zoom21.Key = "Zoom2"
        Me.Zoom21.Name = "Zoom21"
        '
        'Zoom31
        '
        Me.Zoom31.Key = "Zoom3"
        Me.Zoom31.Name = "Zoom31"
        '
        'Zoom41
        '
        Me.Zoom41.Key = "Zoom4"
        Me.Zoom41.Name = "Zoom41"
        '
        'Zoom51
        '
        Me.Zoom51.Key = "Zoom5"
        Me.Zoom51.Name = "Zoom51"
        '
        'Zoom61
        '
        Me.Zoom61.Key = "Zoom6"
        Me.Zoom61.Name = "Zoom61"
        '
        'Zoom71
        '
        Me.Zoom71.Key = "Zoom7"
        Me.Zoom71.Name = "Zoom71"
        '
        'Zoom81
        '
        Me.Zoom81.Key = "Zoom8"
        Me.Zoom81.Name = "Zoom81"
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Location = New System.Drawing.Point(129, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 47)
        Me.Label4.TabIndex = 204
        Me.Label4.Text = "Select The Picture"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(37, 35)
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
        Me.BtnClear.Location = New System.Drawing.Point(38, 4)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(33, 29)
        Me.BtnClear.TabIndex = 202
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(1, 35)
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
        Me.BtnOpen.Location = New System.Drawing.Point(3, 4)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(33, 29)
        Me.BtnOpen.TabIndex = 200
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(77, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 11)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "Zoom"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmPicture
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(214, 196)
        Me.Controls.Add(Me.PnlHead)
        Me.Controls.Add(Me.Picture1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmPicture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.PnlHead.ResumeLayout(False)
        CType(Me.UiContextMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmPicture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ThisFormStatus = MainModule.WorkStates._ReadOnly Then
            BtnOpen.Enabled = False
            BtnClear.Enabled = False
        Else
            BtnOpen.Enabled = True
            BtnClear.Enabled = True
        End If
        Me.Top = MyTop
        Me.Left = MyLeft
        Call SetScreenSize()
        Call EnableZoom()
    End Sub
    Sub EnableZoom()
        If Not IsNothing(Picture1.Image) Then
            BtnZoom.Enabled = True
        Else
            BtnZoom.Enabled = False
        End If
    End Sub
    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Picture1.Image = Nothing
        Call EnableZoom()
    End Sub
    Private Sub BtnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpen.Click
        OFD.Filter = "Images | *.bmp;*.tif;*.jpg;*.gif;*.jpeg"
        OFD.ShowDialog()
        If OFD.FileName.Trim & "" <> "" Then
            Picture1.Image = Image.FromFile(OFD.FileName)
        End If
        Call EnableZoom()
    End Sub
    Private Sub Picture1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Picture1.Resize
        Call SetScreenSize()
    End Sub
    Private Sub SetScreenSize()
        If ShowRealSizeFlag Then
            If IsNothing(Picture1.Image) Then
                Me.Width = 220
                Me.Height = 220
            Else
                Me.Width = Picture1.Width + 6
                Me.Height = Picture1.Height + PnlHead.Height + 25
            End If
        End If
        If Me.Width < 220 Then
            Me.Width = 220
        End If
        If Me.Height < 220 Then
            Me.Height = 220
        End If
    End Sub
    Private Sub UiContextMenu1_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UiContextMenu1.CommandClick
        Dim i As Integer
        For i = 0 To 7
            UiContextMenu1.Commands(i).Checked() = Janus.Windows.UI.InheritableBoolean.False
        Next
        UiContextMenu1.Commands(e.Command.Key).Checked() = Janus.Windows.UI.InheritableBoolean.True
        Dim ZaribForZoom As Integer = 100
        Select Case e.Command.Key.ToUpper
            Case "ZOOM1"
                ZaribForZoom = 25
            Case "ZOOM2"
                ZaribForZoom = 50
            Case "ZOOM3"
                ZaribForZoom = 100
            Case "ZOOM4"
                ZaribForZoom = 150
            Case "ZOOM5"
                ZaribForZoom = 200
            Case "ZOOM6"
                ZaribForZoom = 300
            Case "ZOOM7"
                ZaribForZoom = 400
            Case "ZOOM8"
                ZaribForZoom = 500
        End Select
        Dim FrmZom As New FrmZoomPicture
        FrmZom.Picture1.Image = Picture1.Image
        FrmZom.Picture1.Width = (Me.Picture1.Width * ZaribForZoom) / 100
        FrmZom.Picture1.Height = (Me.Picture1.Height * ZaribForZoom) / 100
        FrmZom.Width = FrmZom.Picture1.Width + 6
        If FrmZom.Width > PubScreenResolutionX Then FrmZom.Width = PubScreenResolutionX - 20
        FrmZom.Height = FrmZom.Picture1.Height + 25
        If FrmZom.Height > PubScreenResolutionY Then FrmZom.Height = PubScreenResolutionY - 20
        FrmZom.ShowDialog()
    End Sub
End Class

