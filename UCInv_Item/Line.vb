Imports CommonClass
Public Class Line
    Inherits System.Windows.Forms.UserControl
    Private MCnn As System.Data.SqlClient.SqlConnection
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Private MLine_Remark As String = ""
    Private MCod_Style As String = ""
    Private MCod_Brand As String = ""
    Private MLine_Code As String = ""
    Private MLenLine As Integer = LenLine
    Private MNotExitIfNotFound As Boolean
    Private MReleaseIfNotFoundLineCod As Boolean
    Public Event FindLineCode()
    Public Event NotFindLineCode()
    Dim WithEvents MyFrmSearchInv_line As New FrmSearchInv_line
    Dim WithEvents ClsInv_line1 As New ClsInv_line
    Public CanAddNewCod As Boolean = True
    Public Event FindLineRow(ByVal ThisRow As DataRow)

    '<Description("ÇÑ ˜Ï ˜á ãæÑÏ äÙÑ íÏÇ äÔÏ ÓíÓÊã ÂäÑÇ ÍÐÝ ˜äÏ"), Category("Behavior")> _
    Property BorderStyle() As BorderStyle
        Get
            Return TxtLine.BorderStyle
        End Get
        Set(ByVal Value As BorderStyle)
            TxtLine.BorderStyle = Value
        End Set
    End Property
    Public Property NotExitIfNotFound() As Boolean
        Get
            Return MNotExitIfNotFound
        End Get
        Set(ByVal Value As Boolean)
            MNotExitIfNotFound = Value
        End Set
    End Property
    Public Property ReleaseIfNotFoundLineCod() As Boolean
        Get
            Return MReleaseIfNotFoundLineCod
        End Get
        Set(ByVal Value As Boolean)
            MReleaseIfNotFoundLineCod = Value
        End Set
    End Property
    ReadOnly Property Line_Code() As String
        Get
            Return MLine_Code
        End Get
    End Property
    ReadOnly Property Line_Remark() As String
        Get
            Return MLine_Remark
        End Get
    End Property
    ReadOnly Property Cod_Brand() As String
        Get
            Return MCod_Brand
        End Get
    End Property
    ReadOnly Property Cod_Style() As String
        Get
            Return MCod_Style
        End Get
    End Property
    Public Property LineCodLen() As Integer
        Get
            Return MLenLine
        End Get
        Set(ByVal Value As Integer)
            MLenLine = MLenLine
            TxtLine.MaxLength = MLenLine
        End Set
    End Property
    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            ClsInv_line1.Connection = MCnn
        End Set
    End Property

    Public Property LineCod() As String
        Get
            Return TxtLine.Text()
        End Get
        Set(ByVal Value As String)
            TxtLine.Text = Value
            Call FindThisLineCod()
        End Set
    End Property
    Shadows Property Text() As String
        Get
            Return TxtLine.Text
        End Get
        Set(ByVal Value As String)
            TxtLine.Text = Value
        End Set
    End Property
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl1 overrides dispose to clean up the component list.
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
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents TxtLine As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Line))
        Me.TxtLine = New System.Windows.Forms.TextBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TxtLine
        '
        Me.TxtLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLine.BackColor = System.Drawing.Color.YellowGreen
        Me.TxtLine.Location = New System.Drawing.Point(0, 0)
        Me.TxtLine.Name = "TxtLine"
        Me.TxtLine.Size = New System.Drawing.Size(154, 20)
        Me.TxtLine.TabIndex = 0
        Me.TxtLine.Text = ""
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(154, 0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(24, 20)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.TabStop = False
        '
        'Line
        '
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtLine)
        Me.Name = "Line"
        Me.Size = New System.Drawing.Size(179, 20)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub TxtLine_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged, TxtLine.TextChanged
        RaiseEvent TextChanged(sender, e)
        Call FindThisLineCod()
    End Sub
    Private Sub TxtLine_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus, TxtLine.LostFocus
        TxtLine.Text = TxtLine.Text.Trim
        Call FindThisLineCod()
        'If Not FindThisLineCod() Then
        '    If CanAddNewCod And TxtLine.Text.Length > 0 Then
        '        Dim c1 As New FrmWhatDoForMenu
        '        c1.BtnLeftText = "Re-enter"
        '        c1.BtnRightText = "Add"
        '        c1.ShowFarMsg(TxtLine.Text & " is not in the Line table")
        '        Select Case c1.DialogResult
        '            Case DialogResult.OK ' Detail Add
        '                Dim MyFrmInv_line As New FrmInv_line
        '                'MyFrmInv_line.Cod_customerVar = TxtLine.Text
        '                MyFrmInv_line.ShowDialog()
        '                'If MyFrmInv_line.Cod_customerVar.Trim.Length > 0 Then
        '                'Me.CustomerCod = MyFrmInv_line.Cod_customerVar
        '                'End If
        '            Case Else 'Re enter
        '                TxtLine.Clear()
        '        End Select
        '        TxtLine.Focus()
        '    End If
        'End If
    End Sub
    Private Function FindThisLineCod() As Boolean
        'If TxtLine.Text = "" Then Exit Function
        'If ClsInv_line1.FindDesc(Getcod(TxtLine.Text, MLineCodLen)) Then
        If ClsInv_line1.FindDesc(TxtLine.Text.Trim) Then
            FindThisLineCod = True
            MLine_Code = ClsInv_line1.cod_Line.Trim
            MLine_Remark = ClsInv_line1.LineRemark.Trim
            RaiseEvent FindLineCode()
        Else
            FindThisLineCod = False
            MLine_Code = ""
            MLine_Remark = ""
            If MReleaseIfNotFoundLineCod = True Then TxtLine.Text = ""
            RaiseEvent NotFindLineCode()
        End If
    End Function
    Private Sub TxtLine_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Validating, TxtLine.Validating
        'TxtLine.Text = Getcod(TxtLine.Text, MLineCodLen)
        TxtLine.Text = TxtLine.Text.Trim
        Call FindThisLineCod()
        If MNotExitIfNotFound = True And MLine_Remark = "" Then
            e.Cancel = True
        End If
    End Sub
    Private Sub TxtLine_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, TxtLine.KeyUp
        Select Case e.KeyCode
            Case Keys.F4
                If e.Shift = False And e.Alt = False And e.Control = False Then
                    MyFrmSearchInv_line.ShowDialog()
                End If
                'Case Keys.Enter
                '    TxtLine.Text = "CASH"
                '    SendKeys.Send("{TAB}")
                '    SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub MyFrmSearchInv_line_LineCodFind(ByVal ThisLineCod As String, ByVal ThisCod_brand As String, ByVal ThisCod_Style As String, ByVal ThisLine_Remark As String) Handles MyFrmSearchInv_line.LineFind
        TxtLine.Text = ThisLineCod
        MLine_Code = ThisLineCod
        MLine_Remark = ThisLine_Remark
        MCod_Brand = ThisCod_brand
        MCod_Style = ThisCod_Style
        RaiseEvent FindLineCode()
    End Sub
    Private Sub CodKolUC_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.BackColorChanged
        TxtLine.BackColor = Me.BackColor
    End Sub
    Public Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        MyFrmSearchInv_line.ShowDialog()
    End Sub
    Private Sub ClsInv_line1_FindLineRow(ByVal ThisRow As System.Data.DataRow) Handles ClsInv_line1.FindlineCodeRow
        RaiseEvent FindLineRow(ThisRow)
    End Sub

    Private Sub MyFrmSearchInv_line_FindlineCodeRow(ByVal ThisRow As System.Data.DataRow) Handles MyFrmSearchInv_line.FindlineCodeRow
        RaiseEvent FindLineRow(ThisRow)
    End Sub
End Class
