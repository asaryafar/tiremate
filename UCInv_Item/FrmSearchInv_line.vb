Imports CommonClass
Public Class FrmSearchInv_line
    Inherits System.Windows.Forms.Form
    Event LineFind(ByVal ThisLineCod As String, ByVal ThisCod_brand As String, ByVal ThisCod_Style As String, ByVal ThisLine_Remark As String)
    Dim WithEvents ClsInv_line1 As New ClsInv_line
    'public event 
    Public Event FindlineCodeRow(ByVal ThisRow As DataRow)
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
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents Connection As System.Data.SqlClient.SqlConnection
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents DSFrmSearchInv_Line1 As UCInv_Item.DSInv_tab_line
    Friend WithEvents BtnAddNewLine As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.Connection = New System.Data.SqlClient.SqlConnection
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DSFrmSearchInv_Line1 = New UCInv_Item.DSInv_tab_line
        Me.BtnAddNewLine = New System.Windows.Forms.Button
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSFrmSearchInv_Line1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.Location = New System.Drawing.Point(13, 334)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 15
        Me.CmdExit.Text = "Exit"
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Location = New System.Drawing.Point(105, 335)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 16
        Me.CmdOk.Text = "Ok"
        '
        'Connection
        '
        Me.Connection.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=BEH1;persist security" & _
        " info=True;initial catalog=TireMate_01;password=2191110"
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "inv_tab_line"
        Me.GrdDetail.DataSource = Me.DSFrmSearchInv_Line1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>inv_tab_line</Caption><Columns Collection=""" & _
        "true""><Column0 ID=""line""><Caption>Line</Caption><TypeNameEmptyStringValue>System" & _
        ".String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>line</DataMemb" & _
        "er><Key>line</Key><Position>0</Position><Width>138</Width></Column0><Column1 ID=" & _
        """cod_brand""><Caption>Brand Code</Caption><TypeNameEmptyStringValue>System.String" & _
        "</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>cod_brand</DataMember" & _
        "><Key>cod_brand</Key><Position>1</Position><Visible>False</Visible></Column1><Co" & _
        "lumn2 ID=""style""><Caption>style</Caption><TypeNameEmptyStringValue>System.String" & _
        "</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>style</DataMember><Ke" & _
        "y>style</Key><Position>2</Position><Visible>False</Visible></Column2><Column3 ID" & _
        "=""complete_desc_brand""><Caption>Brand</Caption><DataMember>complete_desc_brand</" & _
        "DataMember><Key>complete_desc_brand</Key><Position>3</Position><Width>134</Width" & _
        "></Column3><Column4 ID=""desc_style""><Caption>Style</Caption><DataMember>desc_sty" & _
        "le</DataMember><Key>desc_style</Key><Position>4</Position><Width>147</Width></Co" & _
        "lumn4><Column5 ID=""remark""><Caption>Remark</Caption><DataMember>remark</DataMemb" & _
        "er><Key>remark</Key><Position>5</Position><Width>231</Width></Column5></Columns>" & _
        "<GroupCondition ID="""" /><Key>inv_tab_line</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 34)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(709, 293)
        Me.GrdDetail.TabIndex = 19
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DSFrmSearchInv_Line1
        '
        Me.DSFrmSearchInv_Line1.DataSetName = "DSFrmInv_line"
        Me.DSFrmSearchInv_Line1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'BtnAddNewLine
        '
        Me.BtnAddNewLine.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnAddNewLine.ForeColor = System.Drawing.Color.Black
        Me.BtnAddNewLine.Location = New System.Drawing.Point(11, 6)
        Me.BtnAddNewLine.Name = "BtnAddNewLine"
        Me.BtnAddNewLine.Size = New System.Drawing.Size(134, 23)
        Me.BtnAddNewLine.TabIndex = 20
        Me.BtnAddNewLine.Text = "Add New Line"
        '
        'FrmSearchInv_line
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(709, 366)
        Me.Controls.Add(Me.BtnAddNewLine)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdExit)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmSearchInv_line"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Line Search"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSFrmSearchInv_Line1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSearchInvCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connection.ConnectionString = PConnectionString
        ClsInv_line1.Connection = Connection
        Call FillDataset()
    End Sub
    Private Sub FillDataset()
        DSFrmSearchInv_Line1.Clear()
        ClsInv_line1.DAlineCode.Fill(DSFrmSearchInv_Line1, "inv_tab_line")
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent LineFind(GrdDetail.GetRow.Cells(0).Value & "", GrdDetail.GetRow.Cells(1).Value & "", GrdDetail.GetRow.Cells(2).Value & "", GrdDetail.GetRow.Cells(5).Value & "")
                RaiseEvent FindlineCodeRow(DSFrmSearchInv_Line1.inv_tab_line.FindByline(GrdDetail.GetRow.Cells(0).Value & ""))
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Call GrdDetail_DoubleClick(sender, e)
        Me.Close()
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub BtnAddNewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNewLine.Click
        Dim MyFrmInv_line As New UCInv_Item.FrmInv_line
        MyFrmInv_line.QuickAddFlag = True
        MyFrmInv_line.StartPosition = FormStartPosition.CenterParent
        MyFrmInv_line.ShowDialog()
        Call FillDataset()
    End Sub

End Class
