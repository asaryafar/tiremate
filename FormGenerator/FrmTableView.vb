Imports System.Threading
Imports System.Globalization
Imports CommonClass
Public Class FrmTableView
    Inherits System.Windows.Forms.Form

    Private mDVTable As Data.DataView
    Private mDvAccess As Data.DataView
    Private i, NoSortKey As Integer
    Private mFrmTable As FrmGeneral
    Private mLanguage As Language
    Private strSort As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal LanType As String)
        MyBase.New()

        Try
            Thread.CurrentThread.CurrentUICulture = New CultureInfo(LanType, False)
        Catch
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("", False) 'Fallback to fallback resources if entered culture is not valid. 
        End Try

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
    Friend WithEvents GrdMain As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnPrint As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnFieldChooser As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTableView))
        Me.GrdMain = New Janus.Windows.GridEX.GridEX
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnFieldChooser = New Janus.Windows.EditControls.UIButton
        Me.BtnPrint = New Janus.Windows.EditControls.UIButton
        CType(Me.GrdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdMain
        '
        Me.GrdMain.AccessibleDescription = resources.GetString("GrdMain.AccessibleDescription")
        Me.GrdMain.AccessibleName = resources.GetString("GrdMain.AccessibleName")
        Me.GrdMain.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdMain.AlternatingColors = True
        Me.GrdMain.Anchor = CType(resources.GetObject("GrdMain.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GrdMain.BackgroundImage = CType(resources.GetObject("GrdMain.BackgroundImage"), System.Drawing.Image)
        Me.GrdMain.BuiltInTextsData = resources.GetString("GrdMain.BuiltInTextsData")
        Me.GrdMain.CardCaptionPrefix = resources.GetString("GrdMain.CardCaptionPrefix")
        Me.GrdMain.Dock = CType(resources.GetObject("GrdMain.Dock"), System.Windows.Forms.DockStyle)
        Me.GrdMain.Enabled = CType(resources.GetObject("GrdMain.Enabled"), Boolean)
        Me.GrdMain.FilterRowInfoText = resources.GetString("GrdMain.FilterRowInfoText")
        Me.GrdMain.Font = CType(resources.GetObject("GrdMain.Font"), System.Drawing.Font)
        Me.GrdMain.ImeMode = CType(resources.GetObject("GrdMain.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GrdMain.Location = CType(resources.GetObject("GrdMain.Location"), System.Drawing.Point)
        Me.GrdMain.Name = "GrdMain"
        Me.GrdMain.RecordNavigator = True
        Me.GrdMain.RightToLeft = CType(resources.GetObject("GrdMain.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GrdMain.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdMain.Size = CType(resources.GetObject("GrdMain.Size"), System.Drawing.Size)
        Me.GrdMain.TabIndex = CType(resources.GetObject("GrdMain.TabIndex"), Integer)
        Me.GrdMain.Visible = CType(resources.GetObject("GrdMain.Visible"), Boolean)
        '
        'GridEXPrintDocument1
        '
        Me.GridEXPrintDocument1.GridEX = Me.GrdMain
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AccessibleDescription = resources.GetString("PrintPreviewDialog1.AccessibleDescription")
        Me.PrintPreviewDialog1.AccessibleName = resources.GetString("PrintPreviewDialog1.AccessibleName")
        Me.PrintPreviewDialog1.Anchor = CType(resources.GetObject("PrintPreviewDialog1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.PrintPreviewDialog1.AutoScaleBaseSize = CType(resources.GetObject("PrintPreviewDialog1.AutoScaleBaseSize"), System.Drawing.Size)
        Me.PrintPreviewDialog1.AutoScroll = CType(resources.GetObject("PrintPreviewDialog1.AutoScroll"), Boolean)
        Me.PrintPreviewDialog1.AutoScrollMargin = CType(resources.GetObject("PrintPreviewDialog1.AutoScrollMargin"), System.Drawing.Size)
        Me.PrintPreviewDialog1.AutoScrollMinSize = CType(resources.GetObject("PrintPreviewDialog1.AutoScrollMinSize"), System.Drawing.Size)
        Me.PrintPreviewDialog1.BackgroundImage = CType(resources.GetObject("PrintPreviewDialog1.BackgroundImage"), System.Drawing.Image)
        Me.PrintPreviewDialog1.ClientSize = CType(resources.GetObject("PrintPreviewDialog1.ClientSize"), System.Drawing.Size)
        Me.PrintPreviewDialog1.Dock = CType(resources.GetObject("PrintPreviewDialog1.Dock"), System.Windows.Forms.DockStyle)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = CType(resources.GetObject("PrintPreviewDialog1.Enabled"), Boolean)
        Me.PrintPreviewDialog1.Font = CType(resources.GetObject("PrintPreviewDialog1.Font"), System.Drawing.Font)
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.ImeMode = CType(resources.GetObject("PrintPreviewDialog1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.PrintPreviewDialog1.Location = CType(resources.GetObject("PrintPreviewDialog1.Location1"), System.Drawing.Point)
        Me.PrintPreviewDialog1.MaximumSize = CType(resources.GetObject("PrintPreviewDialog1.MaximumSize"), System.Drawing.Size)
        Me.PrintPreviewDialog1.MinimumSize = CType(resources.GetObject("PrintPreviewDialog1.MinimumSize"), System.Drawing.Size)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.RightToLeft = CType(resources.GetObject("PrintPreviewDialog1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.PrintPreviewDialog1.StartPosition = CType(resources.GetObject("PrintPreviewDialog1.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.PrintPreviewDialog1.Text = resources.GetString("PrintPreviewDialog1.Text")
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = CType(resources.GetObject("PrintPreviewDialog1.Visible"), Boolean)
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = resources.GetString("Panel1.AccessibleDescription")
        Me.Panel1.AccessibleName = resources.GetString("Panel1.AccessibleName")
        Me.Panel1.Anchor = CType(resources.GetObject("Panel1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = CType(resources.GetObject("Panel1.AutoScroll"), Boolean)
        Me.Panel1.AutoScrollMargin = CType(resources.GetObject("Panel1.AutoScrollMargin"), System.Drawing.Size)
        Me.Panel1.AutoScrollMinSize = CType(resources.GetObject("Panel1.AutoScrollMinSize"), System.Drawing.Size)
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.BtnFieldChooser)
        Me.Panel1.Controls.Add(Me.BtnPrint)
        Me.Panel1.Dock = CType(resources.GetObject("Panel1.Dock"), System.Windows.Forms.DockStyle)
        Me.Panel1.Enabled = CType(resources.GetObject("Panel1.Enabled"), Boolean)
        Me.Panel1.Font = CType(resources.GetObject("Panel1.Font"), System.Drawing.Font)
        Me.Panel1.ImeMode = CType(resources.GetObject("Panel1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Panel1.Location = CType(resources.GetObject("Panel1.Location"), System.Drawing.Point)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = CType(resources.GetObject("Panel1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
        Me.Panel1.TabIndex = CType(resources.GetObject("Panel1.TabIndex"), Integer)
        Me.Panel1.Text = resources.GetString("Panel1.Text")
        Me.Panel1.Visible = CType(resources.GetObject("Panel1.Visible"), Boolean)
        '
        'BtnFieldChooser
        '
        Me.BtnFieldChooser.AccessibleDescription = resources.GetString("BtnFieldChooser.AccessibleDescription")
        Me.BtnFieldChooser.AccessibleName = resources.GetString("BtnFieldChooser.AccessibleName")
        Me.BtnFieldChooser.Anchor = CType(resources.GetObject("BtnFieldChooser.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.BtnFieldChooser.BackgroundImage = CType(resources.GetObject("BtnFieldChooser.BackgroundImage"), System.Drawing.Image)
        Me.BtnFieldChooser.DisabledImageIndex = CType(resources.GetObject("BtnFieldChooser.DisabledImageIndex"), Integer)
        Me.BtnFieldChooser.Dock = CType(resources.GetObject("BtnFieldChooser.Dock"), System.Windows.Forms.DockStyle)
        Me.BtnFieldChooser.Enabled = CType(resources.GetObject("BtnFieldChooser.Enabled"), Boolean)
        Me.BtnFieldChooser.Font = CType(resources.GetObject("BtnFieldChooser.Font"), System.Drawing.Font)
        Me.BtnFieldChooser.HotImageIndex = CType(resources.GetObject("BtnFieldChooser.HotImageIndex"), Integer)
        Me.BtnFieldChooser.ImageIndex = CType(resources.GetObject("BtnFieldChooser.ImageIndex"), Integer)
        Me.BtnFieldChooser.ImageSize = CType(resources.GetObject("BtnFieldChooser.ImageSize"), System.Drawing.Size)
        Me.BtnFieldChooser.ImeMode = CType(resources.GetObject("BtnFieldChooser.ImeMode"), System.Windows.Forms.ImeMode)
        Me.BtnFieldChooser.Location = CType(resources.GetObject("BtnFieldChooser.Location"), System.Drawing.Point)
        Me.BtnFieldChooser.Name = "BtnFieldChooser"
        Me.BtnFieldChooser.PressedImageIndex = CType(resources.GetObject("BtnFieldChooser.PressedImageIndex"), Integer)
        Me.BtnFieldChooser.RightToLeft = CType(resources.GetObject("BtnFieldChooser.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.BtnFieldChooser.Size = CType(resources.GetObject("BtnFieldChooser.Size"), System.Drawing.Size)
        Me.BtnFieldChooser.TabIndex = CType(resources.GetObject("BtnFieldChooser.TabIndex"), Integer)
        Me.BtnFieldChooser.Text = resources.GetString("BtnFieldChooser.Text")
        Me.BtnFieldChooser.TextHorizontalAlignment = CType(resources.GetObject("BtnFieldChooser.TextHorizontalAlignment"), Janus.Windows.EditControls.TextAlignment)
        Me.BtnFieldChooser.TextVerticalAlignment = CType(resources.GetObject("BtnFieldChooser.TextVerticalAlignment"), Janus.Windows.EditControls.TextAlignment)
        Me.BtnFieldChooser.UseThemes = CType(resources.GetObject("BtnFieldChooser.UseThemes"), Boolean)
        Me.BtnFieldChooser.Visible = CType(resources.GetObject("BtnFieldChooser.Visible"), Boolean)
        Me.BtnFieldChooser.VisualStyle = CType(resources.GetObject("BtnFieldChooser.VisualStyle"), Janus.Windows.UI.VisualStyle)
        '
        'BtnPrint
        '
        Me.BtnPrint.AccessibleDescription = resources.GetString("BtnPrint.AccessibleDescription")
        Me.BtnPrint.AccessibleName = resources.GetString("BtnPrint.AccessibleName")
        Me.BtnPrint.Anchor = CType(resources.GetObject("BtnPrint.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.DisabledImageIndex = CType(resources.GetObject("BtnPrint.DisabledImageIndex"), Integer)
        Me.BtnPrint.Dock = CType(resources.GetObject("BtnPrint.Dock"), System.Windows.Forms.DockStyle)
        Me.BtnPrint.Enabled = CType(resources.GetObject("BtnPrint.Enabled"), Boolean)
        Me.BtnPrint.Font = CType(resources.GetObject("BtnPrint.Font"), System.Drawing.Font)
        Me.BtnPrint.HotImageIndex = CType(resources.GetObject("BtnPrint.HotImageIndex"), Integer)
        Me.BtnPrint.ImageIndex = CType(resources.GetObject("BtnPrint.ImageIndex"), Integer)
        Me.BtnPrint.ImageSize = CType(resources.GetObject("BtnPrint.ImageSize"), System.Drawing.Size)
        Me.BtnPrint.ImeMode = CType(resources.GetObject("BtnPrint.ImeMode"), System.Windows.Forms.ImeMode)
        Me.BtnPrint.Location = CType(resources.GetObject("BtnPrint.Location"), System.Drawing.Point)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.PressedImageIndex = CType(resources.GetObject("BtnPrint.PressedImageIndex"), Integer)
        Me.BtnPrint.RightToLeft = CType(resources.GetObject("BtnPrint.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.BtnPrint.Size = CType(resources.GetObject("BtnPrint.Size"), System.Drawing.Size)
        Me.BtnPrint.TabIndex = CType(resources.GetObject("BtnPrint.TabIndex"), Integer)
        Me.BtnPrint.Text = resources.GetString("BtnPrint.Text")
        Me.BtnPrint.TextHorizontalAlignment = CType(resources.GetObject("BtnPrint.TextHorizontalAlignment"), Janus.Windows.EditControls.TextAlignment)
        Me.BtnPrint.TextVerticalAlignment = CType(resources.GetObject("BtnPrint.TextVerticalAlignment"), Janus.Windows.EditControls.TextAlignment)
        Me.BtnPrint.UseThemes = CType(resources.GetObject("BtnPrint.UseThemes"), Boolean)
        Me.BtnPrint.Visible = CType(resources.GetObject("BtnPrint.Visible"), Boolean)
        Me.BtnPrint.VisualStyle = CType(resources.GetObject("BtnPrint.VisualStyle"), Janus.Windows.UI.VisualStyle)
        '
        'FrmTableView
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GrdMain)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "FrmTableView"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        CType(Me.GrdMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property FrmTable() As FrmGeneral
        Get
            Return mFrmTable
        End Get
        Set(ByVal Value As FrmGeneral)
            mFrmTable = Value
        End Set
    End Property

    Public Property DVTable() As Data.DataView
        Get
            Return mDVTable
        End Get
        Set(ByVal Value As Data.DataView)
            mDVTable = Value
        End Set
    End Property

    Public Property DvAccess() As Data.DataView
        Get
            Return mDvAccess
        End Get
        Set(ByVal Value As Data.DataView)
            mDvAccess = Value
        End Set
    End Property

    Private Sub FrmTableView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GrdMain.DataSource = Me.DVTable
        Me.GrdMain.RetrieveStructure()
        Me.GrdMain.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        For i = 0 To DvAccess.Count - 1
            Me.GrdMain.RootTable.Columns.Item(i).Caption = DvAccess(i).Item("Fieldcaption")
            Me.GrdMain.RootTable.Columns.Item(i).FilterEditType = Janus.Windows.GridEX.FilterEditType.Combo
        Next
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub BtnFieldChooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFieldChooser.Click
        Me.GrdMain.ShowFieldChooser(Me)
    End Sub

    Private Sub GrdMain_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GrdMain.RowDoubleClick
        Dim keys() As DataColumn
        keys = DVTable.Table.PrimaryKey
        Dim Vals(keys.Length - 1) As Object
        Dim k As Integer = 0
        Dim RowEx As Janus.Windows.GridEX.GridEXRow
        Dim FindSort As String = ""
        RowEx = GrdMain.GetRow
        If RowEx Is Nothing Then
            Exit Sub
        End If
        For k = 0 To keys.Length - 1
            i = 0
            For i = 0 To RowEx.Cells.Count - 1
                If RowEx.Cells(i).Column.Key = keys(k).ColumnName Then
                    Vals(k) = RowEx.Cells(i).Value
                    If k = 0 Then
                        FindSort = FindSort & RowEx.Cells(i).Column.Key
                    Else
                        FindSort = FindSort & "," & RowEx.Cells(i).Column.Key
                    End If

                End If
            Next
        Next
        DVTable.Sort = FindSort
        FrmTable.SortString = FindSort
        FrmTable.intPos = DVTable.Find(Vals)
        FrmTable.SortString = FindSort
        Me.Close()
    End Sub
End Class
