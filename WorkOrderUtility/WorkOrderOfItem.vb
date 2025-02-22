Imports CommonClass
Public Class WorkOrderOfItem
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Friend WithEvents BtnWorkOrderOfLine As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(WorkOrderOfItem))
        Me.BtnWorkOrderOfLine = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtnWorkOrderOfLine
        '
        Me.BtnWorkOrderOfLine.BackColor = System.Drawing.SystemColors.Control
        Me.BtnWorkOrderOfLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWorkOrderOfLine.Image = CType(resources.GetObject("BtnWorkOrderOfLine.Image"), System.Drawing.Image)
        Me.BtnWorkOrderOfLine.Location = New System.Drawing.Point(0, 0)
        Me.BtnWorkOrderOfLine.Name = "BtnWorkOrderOfLine"
        Me.BtnWorkOrderOfLine.Size = New System.Drawing.Size(23, 21)
        Me.BtnWorkOrderOfLine.TabIndex = 7
        Me.BtnWorkOrderOfLine.TabStop = False
        '
        'WorkOrderOfItem
        '
        Me.Controls.Add(Me.BtnWorkOrderOfLine)
        Me.Name = "WorkOrderOfItem"
        Me.Size = New System.Drawing.Size(24, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private MCnn As System.Data.SqlClient.SqlConnection
    Dim MItem_no As String = ""
    Public Event BeforeClick()
    Dim WithEvents MyFrm1 As FrmWorkOrderOfItem
    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            ' DaInv_line.SelectCommand.Connection = Value
        End Set
    End Property

    Public Property Item_no() As String
        Get
            Return MItem_no
        End Get
        Set(ByVal Value As String)
            MItem_no = Value
        End Set
    End Property

    Private Sub BtnLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWorkOrderOfLine.Click
        Try
            RaiseEvent BeforeClick()
            MyFrm1 = New FrmWorkOrderOfItem
            Dim DsTmp As New DataSet
            Call FitToScreen(Me, MyFrm1)
            MyFrm1.MyLeft = MyFrm1.Left
            MyFrm1.MyTop = MyFrm1.Top
            If MItem_no <> "" Then
                With MyFrm1
                    .Item_no = MItem_no
                    .Cnn.ConnectionString = PConnectionString
                    .Show()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub MyFrm1_CloseMe() Handles MyFrm1.CloseMe
        MyFrm1.Close()
        MyFrm1 = Nothing
    End Sub
End Class
