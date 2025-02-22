Imports CommonClass
Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Public Class InvLine_Detail
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
    Friend WithEvents BtnLine As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaInv_line As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(InvLine_Detail))
        Me.BtnLine = New System.Windows.Forms.Button
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.DaInv_line = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SuspendLayout()
        '
        'BtnLine
        '
        Me.BtnLine.BackColor = System.Drawing.SystemColors.Control
        Me.BtnLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLine.Image = CType(resources.GetObject("BtnLine.Image"), System.Drawing.Image)
        Me.BtnLine.Location = New System.Drawing.Point(0, 0)
        Me.BtnLine.Name = "BtnLine"
        Me.BtnLine.Size = New System.Drawing.Size(23, 21)
        Me.BtnLine.TabIndex = 6
        Me.BtnLine.TabStop = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ARMANDEH;packet size=4096;user id=sa;data source=""."";persist secur" & _
        "ity info=False;initial catalog=TireMate_01"
        '
        'DaInv_line
        '
        Me.DaInv_line.SelectCommand = Me.SqlSelectCommand1
        Me.DaInv_line.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_line", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("features", "features"), New System.Data.Common.DataColumnMapping("benefits", "benefits"), New System.Data.Common.DataColumnMapping("treadwear", "treadwear"), New System.Data.Common.DataColumnMapping("traction", "traction"), New System.Data.Common.DataColumnMapping("temperature", "temperature"), New System.Data.Common.DataColumnMapping("limit_warranty", "limit_warranty"), New System.Data.Common.DataColumnMapping("construction", "construction"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("image_remark", "image_remark"), New System.Data.Common.DataColumnMapping("tread_life", "tread_life"), New System.Data.Common.DataColumnMapping("wet_traction", "wet_traction"), New System.Data.Common.DataColumnMapping("quiet_ride", "quiet_ride"), New System.Data.Common.DataColumnMapping("handling", "handling"), New System.Data.Common.DataColumnMapping("winter_traction", "winter_traction"), New System.Data.Common.DataColumnMapping("nud_traction", "nud_traction"), New System.Data.Common.DataColumnMapping("overall_score", "overall_score"), New System.Data.Common.DataColumnMapping("dry_traction", "dry_traction"), New System.Data.Common.DataColumnMapping("ride_comfort", "ride_comfort")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_brand, style, line, features, benefits, treadwear, traction, temperatu" & _
        "re, limit_warranty, construction, remark, image_remark, tread_life, wet_traction" & _
        ", quiet_ride, handling, winter_traction, nud_traction, overall_score, dry_tracti" & _
        "on, ride_comfort FROM inv_tab_line WHERE (line = @Line)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Line", System.Data.SqlDbType.VarChar, 30, "line"))
        '
        'InvLine_Detail
        '
        Me.Controls.Add(Me.BtnLine)
        Me.Name = "InvLine_Detail"
        Me.Size = New System.Drawing.Size(24, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private MCnn As System.Data.SqlClient.SqlConnection
    Dim MLine As String = ""
    Public Event BeforeClick()
    Dim WithEvents MyFrm1 As FrmInv_line_DetailShow
    Dim Thispicture() As Byte
    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            DaInv_line.SelectCommand.Connection = Value
        End Set
    End Property

    Public Property Line() As String
        Get
            Return MLine
        End Get
        Set(ByVal Value As String)
            MLine = Value

        End Set
    End Property
    Private Sub MyFrm1_CloseMe() Handles MyFrm1.CloseMe
        MyFrm1.Close()
        MyFrm1 = Nothing
    End Sub
    Private Sub BtnLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLine.Click
        RaiseEvent BeforeClick()
        MyFrm1 = New FrmInv_line_DetailShow
        Dim DsTmp As New DataSet
        Call FitToScreen(Me, MyFrm1)
        MyFrm1.MyLeft = MyFrm1.Left
        MyFrm1.MyTop = MyFrm1.Top
        Try
            If MLine <> "" Then
                DaInv_line.SelectCommand.Parameters(0).Value = MLine
                DaInv_line.Fill(DsTmp)
                If DsTmp.Tables(0).Rows.Count > 0 Then

                    If Not (DsTmp.Tables(0).Rows(0).Item("image_remark") Is System.DBNull.Value) Then

                        Try
                            Thispicture = DsTmp.Tables(0).Rows(0).Item("image_remark")
                        Catch ex As Exception
                            Thispicture = Nothing
                        End Try
                        Dim MyPicStream As New MemoryStream(Thispicture)
                        MyFrm1.image_remark.Image = Image.FromStream(MyPicStream)

                        'bb = DsTmp.Tables(0).Rows(0).Item("image_remark")
                        'Dim aa As New MemoryStream(bb)
                        '  MyFrm1.image_remark.Image = Image.FromStream(aa)
                    End If
                    MyFrm1.TxtRemak.Text = DsTmp.Tables(0).Rows(0).Item("remark") & ""
                    MyFrm1.Txtlimit_warranty.Text = DsTmp.Tables(0).Rows(0).Item("limit_warranty") & ""
                    MyFrm1.txtoverall_score.Text = DsTmp.Tables(0).Rows(0).Item("overall_score") & ""
                    MyFrm1.txtRide_Comfort.Text = DsTmp.Tables(0).Rows(0).Item("Ride_Comfort") & ""
                    MyFrm1.txtDry_Traction.Text = DsTmp.Tables(0).Rows(0).Item("Dry_Traction") & ""
                    MyFrm1.txtnud_traction.Text = DsTmp.Tables(0).Rows(0).Item("nud_traction") & ""
                    MyFrm1.txtwinter_traction.Text = DsTmp.Tables(0).Rows(0).Item("winter_traction") & ""
                    MyFrm1.txthandling.Text = DsTmp.Tables(0).Rows(0).Item("handling") & ""
                    MyFrm1.txtquiet_ride.Text = DsTmp.Tables(0).Rows(0).Item("quiet_ride") & ""
                    MyFrm1.txtwet_traction.Text = DsTmp.Tables(0).Rows(0).Item("wet_traction") & ""
                    MyFrm1.txttread_life.Text = DsTmp.Tables(0).Rows(0).Item("tread_life") & ""
                    MyFrm1.Utqg1.Connection = Me.Connection
                    MyFrm1.Utqg1.Line = MLine
                    MyFrm1.ShowDialog()
                Else
                End If
            End If
        Catch ex As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub

End Class
