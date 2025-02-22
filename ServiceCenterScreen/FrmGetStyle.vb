Imports CommonClass
Public Class FrmGetStyle
    Inherits FrmBase
    Public OkVar As Boolean = False
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
    Friend WithEvents BtnOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmbStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents DAinv_tab_style As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmGetStyle1 As ServiceCenterScreen.DSFrmGetStyle
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnOk = New Janus.Windows.EditControls.UIButton
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.CmbStyle = New System.Windows.Forms.ComboBox
        Me.DsFrmGetStyle1 = New ServiceCenterScreen.DSFrmGetStyle
        Me.Label39 = New System.Windows.Forms.Label
        Me.DAinv_tab_style = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        CType(Me.DsFrmGetStyle1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(269, 45)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(80, 24)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "OK"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(27, 45)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(80, 24)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel"
        '
        'CmbStyle
        '
        Me.CmbStyle.DataSource = Me.DsFrmGetStyle1.inv_tab_style
        Me.CmbStyle.DisplayMember = "desc_style"
        Me.CmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStyle.Location = New System.Drawing.Point(207, 9)
        Me.CmbStyle.Name = "CmbStyle"
        Me.CmbStyle.Size = New System.Drawing.Size(165, 21)
        Me.CmbStyle.TabIndex = 3
        Me.CmbStyle.TabStop = False
        Me.CmbStyle.ValueMember = "style"
        '
        'DsFrmGetStyle1
        '
        Me.DsFrmGetStyle1.DataSetName = "DSFrmGetStyle"
        Me.DsFrmGetStyle1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(6, 9)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(211, 23)
        Me.Label39.TabIndex = 4
        Me.Label39.Text = "Please Select The Style Of This Vehicle"
        '
        'DAinv_tab_style
        '
        Me.DAinv_tab_style.SelectCommand = Me.SqlSelectCommand5
        Me.DAinv_tab_style.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_style", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("desc_style", "desc_style"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("image_remark", "image_remark")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT inv_tab_style.style, inv_tab_style.desc_style FROM inv_tab_style INNER JOI" & _
        "N inv_tab_labor_service_price ON inv_tab_style.style = inv_tab_labor_service_pri" & _
        "ce.style WHERE (inv_tab_labor_service_price.cod_service = @cod_service)"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_service", System.Data.SqlDbType.VarChar, 6, "cod_service"))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'FrmGetStyle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(376, 76)
        Me.Controls.Add(Me.CmbStyle)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmGetStyle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Set Style"
        CType(Me.DsFrmGetStyle1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmGetStyle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        OkVar = True
        Me.Close()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        OkVar = False
        Me.Close()
    End Sub
End Class
