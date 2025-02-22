
Imports CommonClass
Imports Janus.Windows.GridEX
Imports Microsoft.VisualBasic

Public Class frmShowNoConvert
    Inherits System.Windows.Forms.Form
    Dim _XmlFile As String
    Dim _LabelText As String

    Public Property LabelText() As String
        Get
            Return _LabelText
        End Get
        Set(ByVal Value As String)
            _LabelText = Value
        End Set
    End Property

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
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents cPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grdShow As Janus.Windows.GridEX.GridEX
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ImgWork As System.Windows.Forms.ImageList
    Friend WithEvents dsItems1 As Convert.dsItems
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmShowNoConvert))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.cPrint = New System.Windows.Forms.ToolBarButton
        Me.ImgWork = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.grdShow = New Janus.Windows.GridEX.GridEX
        Me.dsItems1 = New Convert.dsItems
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Panel2.SuspendLayout()
        CType(Me.grdShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsItems1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.cPrint})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(55, 20)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImgWork
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(562, 28)
        Me.ToolBar1.TabIndex = 192
        Me.ToolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'cPrint
        '
        Me.cPrint.ImageIndex = 1
        Me.cPrint.Tag = "1"
        Me.cPrint.Text = "Print"
        '
        'ImgWork
        '
        Me.ImgWork.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImgWork.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgWork.ImageStream = CType(resources.GetObject("ImgWork.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgWork.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(562, 48)
        Me.Panel2.TabIndex = 193
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(416, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(488, 22)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "NO Convert"
        '
        'grdShow
        '
        Me.grdShow.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.grdShow.AlternatingColors = True
        Me.grdShow.AlternatingRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdShow.DataSource = Me.dsItems1.Temp
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Temp</Caption><Columns Collection=""true""><C" & _
        "olumn0 ID=""CusCode""><Caption>CusCode</Caption><DataMember>CusCode</DataMember><K" & _
        "ey>CusCode</Key><Position>0</Position><Width>89</Width></Column0><Column1 ID=""Na" & _
        "me""><Caption>Name</Caption><DataMember>Name</DataMember><Key>Name</Key><Position" & _
        ">1</Position><Width>252</Width></Column1><Column2 ID=""balance""><Caption>balance<" & _
        "/Caption><DataMember>balance</DataMember><FormatString>c2</FormatString><Key>bal" & _
        "ance</Key><Position>2</Position></Column2><Column3 ID=""Description""><Caption>Des" & _
        "cription</Caption><DataMember>Description</DataMember><Key>Description</Key><Pos" & _
        "ition>3</Position><Width>148</Width></Column3></Columns><GroupCondition ID="""" />" & _
        "<Key>Temp</Key><RowHeaderWidth>20</RowHeaderWidth><RowHeight>21</RowHeight></Roo" & _
        "tTable></GridEXLayoutData>"
        Me.grdShow.DesignTimeLayout = GridEXLayout1
        Me.grdShow.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.grdShow.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdShow.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grdShow.GroupByBoxVisible = False
        Me.grdShow.Location = New System.Drawing.Point(4, 82)
        Me.grdShow.Name = "grdShow"
        Me.grdShow.NewRowFormatStyle.BackColor = System.Drawing.Color.White
        Me.grdShow.NewRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True
        Me.grdShow.NewRowFormatStyle.ForeColor = System.Drawing.Color.Navy
        Me.grdShow.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.grdShow.RecordNavigator = True
        Me.grdShow.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.grdShow.Size = New System.Drawing.Size(548, 342)
        Me.grdShow.TabIndex = 214
        '
        'dsItems1
        '
        Me.dsItems1.DataSetName = "dsItems"
        Me.dsItems1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(114, 17)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'GridEXPrintDocument1
        '
        Me.GridEXPrintDocument1.GridEX = Me.grdShow
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "„”Ì— „Ê—œ ‰Ÿ— —« ÃÂ  «ÌÃ«œ ›«Ì· «‰ Œ«» ò‰Ìœ"
        '
        'frmShowNoConvert
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(562, 432)
        Me.Controls.Add(Me.grdShow)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmShowNoConvert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NO Convert"
        Me.Panel2.ResumeLayout(False)
        CType(Me.grdShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsItems1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmShowNoConvert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label8.Text = LabelText
        Me.GridEXPrintDocument1.PageHeaderCenter = LabelText
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case e.Button.Tag
            Case 1
                PrintPreviewDialog1.ShowDialog()
        End Select
    End Sub

    Private Sub grdShow_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdShow.GotFocus
        grdShow.Refresh()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class

