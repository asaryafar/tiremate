Imports CommonClass
Public Class UTQG
    Inherits System.Windows.Forms.UserControl
    Dim WithEvents MyFrm1 As FrmUTQGShow

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
    Friend WithEvents BtnUTQG As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaInv_line As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnUTQG = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.DaInv_line = New System.Data.SqlClient.SqlDataAdapter
        Me.SuspendLayout()
        '
        'BtnUTQG
        '
        Me.BtnUTQG.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnUTQG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnUTQG.Location = New System.Drawing.Point(3, 1)
        Me.BtnUTQG.Name = "BtnUTQG"
        Me.BtnUTQG.Size = New System.Drawing.Size(77, 21)
        Me.BtnUTQG.TabIndex = 372
        Me.BtnUTQG.TabStop = False
        Me.BtnUTQG.Text = "UTQG"
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
        'UTQG
        '
        Me.Controls.Add(Me.BtnUTQG)
        Me.Name = "UTQG"
        Me.Size = New System.Drawing.Size(80, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private MCnn As System.Data.SqlClient.SqlConnection
    Dim MLine As String = ""
    Public Event BeforeClick()
    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            DaInv_line.SelectCommand.Connection = Value
        End Set
    End Property
    Public Overrides Property BackColor() As Color
        Get
            Return BtnUTQG.BackColor
        End Get
        Set(ByVal Value As Color)
            BtnUTQG.BackColor = Value
            ' Me.BackColor = Value
        End Set
    End Property
    Public Overrides Property text() As String
        Get
            Return BtnUTQG.Text
        End Get
        Set(ByVal Value As String)
            BtnUTQG.Text = Value
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
    Private Sub UTQG_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        BtnUTQG.Left = Me.Left
        BtnUTQG.Top = Me.Top
        BtnUTQG.Width = Me.Width
        BtnUTQG.Height = Me.Height
    End Sub
    Private Sub BtnUTQG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUTQG.Click
        RaiseEvent BeforeClick()
        MyFrm1 = New FrmUTQGShow
        Dim DsTmp As New DataSet
        Call FitToScreen(Me, MyFrm1)
        MyFrm1.MyLeft = MyFrm1.Left
        MyFrm1.MyTop = MyFrm1.Top
        If MLine <> "" Then
            DaInv_line.SelectCommand.Parameters(0).Value = MLine
            DaInv_line.Fill(DsTmp)
            If DsTmp.Tables(0).Rows.Count > 0 Then
                MyFrm1.TreadWear.Text = DsTmp.Tables(0).Rows(0).Item("treadwear") & ""
                MyFrm1.Traction.Text = DsTmp.Tables(0).Rows(0).Item("traction") & ""
                MyFrm1.Temperature.Text = DsTmp.Tables(0).Rows(0).Item("temperature") & ""
                MyFrm1.Show()
            Else
                MyFrm1.TreadWear.Text = ""
                MyFrm1.Traction.Text = ""
                MyFrm1.Temperature.Text = ""
            End If
        End If
    End Sub
    Private Sub MyFrm1_CloseMe() Handles MyFrm1.CloseMe
        MyFrm1.Close()
        MyFrm1 = Nothing
    End Sub
End Class
