Imports CommonClass
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Drawing.Imaging
Imports System.ComponentModel
Public Class PictureButton
    Inherits System.Windows.Forms.UserControl
    Dim MyFrmPicture As New UCPicture.FrmPicture
    Public status As WorkStates = MainModule.WorkStates._ReadOnly
    Shadows Event Click(ByVal sender As Object, ByVal e As System.EventArgs)
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        Select Case Me.RightToLeft
            Case RightToLeft.Yes
                BtNPicture.TextAlign = ContentAlignment.MiddleRight
            Case RightToLeft.No
                BtNPicture.TextAlign = ContentAlignment.MiddleLeft
        End Select

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
    Public WithEvents Picture1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtNPicture As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtNPicture = New System.Windows.Forms.Button
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'BtNPicture
        '
        Me.BtNPicture.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtNPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtNPicture.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtNPicture.Location = New System.Drawing.Point(0, 0)
        Me.BtNPicture.Name = "BtNPicture"
        Me.BtNPicture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtNPicture.Size = New System.Drawing.Size(79, 23)
        Me.BtNPicture.TabIndex = 0
        Me.BtNPicture.Text = "Picture"
        Me.BtNPicture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Picture1
        '
        Me.Picture1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture1.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picture1.Location = New System.Drawing.Point(45, 0)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Size = New System.Drawing.Size(34, 23)
        Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture1.TabIndex = 1
        Me.Picture1.TabStop = False
        '
        'PictureButton
        '
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.BtNPicture)
        Me.Name = "PictureButton"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Size = New System.Drawing.Size(79, 23)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Thispicture() As Byte
    <Description("Form Picture."), Category("Behavior")> _
    Public Property MyPicture()
        Get
            Try
                If Not IsNothing(Picture1.Image) Then
                    Dim ms As New MemoryStream
                    Picture1.Image.Save(ms, Picture1.Image.RawFormat)
                    Dim arrImage() As Byte = ms.GetBuffer
                    arrImage = ms.GetBuffer
                    ms.Close()
                    Try
                        Thispicture = arrImage
                    Catch ex As Exception
                        Thispicture = Nothing
                    End Try
                Else
                    Thispicture = Nothing
                End If
            Catch ex As Exception
                Thispicture = Nothing
            End Try
            Return Thispicture
        End Get
        Set(ByVal Value)
            Try
                If Not IsNothing(Value) Then
                    Thispicture = Value
                    Dim MyPicStream As New MemoryStream(Thispicture)
                    Picture1.Image = Image.FromStream(MyPicStream)
                Else
                    Picture1.Image = Nothing
                End If
            Catch ex As Exception
                Picture1.Image = Nothing
            End Try
        End Set
    End Property
    Private Sub BtNPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNPicture.Click
        RaiseEvent Click(sender, e)
        MyFrmPicture.ThisFormStatus = status
        MyFrmPicture.Picture1.Image = Me.Picture1.Image
        Call FitToScreen(Me, MyFrmPicture)
        MyFrmPicture.MyLeft = MyFrmPicture.Left
        MyFrmPicture.MyTop = MyFrmPicture.Top

        MyFrmPicture.ShowDialog()
        Me.Picture1.Image = MyFrmPicture.Picture1.Image
    End Sub
    Private Sub PictureButton_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Public Sub SavePicture(ByVal Cnn As System.Data.SqlClient.SqlConnection, ByVal TblName As String, ByVal PictureFieldName As String, ByVal UpdateWhereClause As String, Optional ByVal CnnForMdb As System.Data.OleDb.OleDbConnection = Nothing)
        Dim strSQL As String
        strSQL = "update " & TblName & " set " & PictureFieldName & " =@picture " & UpdateWhereClause
        If IsNothing(CnnForMdb) Then
            Dim cmd As New SqlCommand(strSQL, Cnn)
            With cmd
                .Parameters.Add(New SqlParameter("@Picture", _
                    SqlDbType.Image)).Value = IIf(IsNothing(Me.MyPicture), System.DBNull.Value, Me.MyPicture)
            End With
            Try
                If Cnn.State <> ConnectionState.Open Then
                    Cnn.Open()
                End If
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error In Saving Picture.Please Try Again.")
            End Try
        Else
            Dim cmd As New OleDbCommand(strSQL, CnnForMdb)
            With cmd
                .Parameters.Add(New OleDbParameter("@Picture", _
                    OleDbType.LongVarBinary)).Value = IIf(IsNothing(Me.MyPicture), System.DBNull.Value, Me.MyPicture)
            End With
            Try
                If CnnForMdb.State <> ConnectionState.Open Then
                    CnnForMdb.Open()
                End If
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error In Saving Picture.Please Try Again.")
            End Try
        End If
    End Sub
End Class
