Imports CommonClass
Public Class FrmSearchReadyComments
    Inherits FrmBase
    Event ReadyCommentFind(ByVal ThisReadyCommentsDesc As String, ByVal ThisReadyCommentsCode As String)
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
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DABas_Ready_Comment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmSearchReadyComments1 As DSFrmSearchReadyComments
    Friend WithEvents BtnAdd As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmSearchReadyComments1 = New UCInv_Package.DSFrmSearchReadyComments
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DABas_Ready_Comment = New System.Data.SqlClient.SqlDataAdapter
        Me.BtnAdd = New Janus.Windows.EditControls.UIButton
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchReadyComments1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "Bas_Ready_Comment"
        Me.GrdDetail.DataSource = Me.DsFrmSearchReadyComments1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Bas_Ready_Comment</Caption><Columns Collect" & _
        "ion=""true""><Column0 ID=""CommentDesc""><Caption>Description</Caption><TypeNameEmpt" & _
        "yStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMe" & _
        "mber>CommentDesc</DataMember><Key>CommentDesc</Key><Position>0</Position><Width>" & _
        "483</Width></Column0><Column1 ID=""CommentCode""><Caption>Code</Caption><TypeNameE" & _
        "mptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><Dat" & _
        "aMember>CommentCode</DataMember><Key>CommentCode</Key><Position>1</Position><Vis" & _
        "ible>False</Visible><Width>51</Width></Column1></Columns><GroupCondition ID="""" /" & _
        "><Key>Bas_Ready_Comment</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 0)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(528, 272)
        Me.GrdDetail.TabIndex = 2
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DsFrmSearchReadyComments1
        '
        Me.DsFrmSearchReadyComments1.DataSetName = "DSFrmSearchReadyComments"
        Me.DsFrmSearchReadyComments1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnAdd)
        Me.Panel2.Controls.Add(Me.CmdOk)
        Me.Panel2.Controls.Add(Me.CmdExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 272)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(528, 33)
        Me.Panel2.TabIndex = 21
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdOk.ForeColor = System.Drawing.Color.Black
        Me.CmdOk.Location = New System.Drawing.Point(346, 5)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 24)
        Me.CmdOk.TabIndex = 22
        Me.CmdOk.Text = "Ok"
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdExit.ForeColor = System.Drawing.Color.Black
        Me.CmdExit.Location = New System.Drawing.Point(442, 5)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CommentCode, CommentDesc FROM Bas_Ready_Comment"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=KETABIE;persist se" & _
        "curity info=True;initial catalog=TireMate_01;password=sa"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Bas_Ready_Comment(CommentCode, CommentDesc) VALUES (@CommentCode, @Co" & _
        "mmentDesc); SELECT CommentCode, CommentDesc FROM Bas_Ready_Comment WHERE (Commen" & _
        "tCode = @CommentCode)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CommentCode", System.Data.SqlDbType.VarChar, 4, "CommentCode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CommentDesc", System.Data.SqlDbType.VarChar, 100, "CommentDesc"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Bas_Ready_Comment SET CommentCode = @CommentCode, CommentDesc = @CommentDe" & _
        "sc WHERE (CommentCode = @Original_CommentCode) AND (CommentDesc = @Original_Comm" & _
        "entDesc); SELECT CommentCode, CommentDesc FROM Bas_Ready_Comment WHERE (CommentC" & _
        "ode = @CommentCode)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CommentCode", System.Data.SqlDbType.VarChar, 4, "CommentCode"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CommentDesc", System.Data.SqlDbType.VarChar, 100, "CommentDesc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CommentCode", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CommentCode", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CommentDesc", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CommentDesc", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Bas_Ready_Comment WHERE (CommentCode = @Original_CommentCode) AND (Co" & _
        "mmentDesc = @Original_CommentDesc)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CommentCode", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CommentCode", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CommentDesc", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CommentDesc", System.Data.DataRowVersion.Original, Nothing))
        '
        'DABas_Ready_Comment
        '
        Me.DABas_Ready_Comment.DeleteCommand = Me.SqlDeleteCommand1
        Me.DABas_Ready_Comment.InsertCommand = Me.SqlInsertCommand1
        Me.DABas_Ready_Comment.SelectCommand = Me.SqlSelectCommand1
        Me.DABas_Ready_Comment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bas_Ready_Comment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CommentCode", "CommentCode"), New System.Data.Common.DataColumnMapping("CommentDesc", "CommentDesc")})})
        Me.DABas_Ready_Comment.UpdateCommand = Me.SqlUpdateCommand1
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnAdd.ForeColor = System.Drawing.Color.Black
        Me.BtnAdd.Location = New System.Drawing.Point(23, 6)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(122, 24)
        Me.BtnAdd.TabIndex = 23
        Me.BtnAdd.Text = "Add Comments"
        '
        'FrmSearchReadyComments
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 305)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSearchReadyComments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Comments"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchReadyComments1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmFindServiceRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Try
            Cnn.ConnectionString = PConnectionString
        Catch ex As Exception
        End Try
        Call FillDataSet()
    End Sub
    Private Sub FillDataSet()
        DsFrmSearchReadyComments1.Bas_Ready_Comment.Clear()
        DABas_Ready_Comment.Fill(DsFrmSearchReadyComments1, "Bas_Ready_Comment")
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent ReadyCommentFind(GrdDetail.GetRow.Cells(0).Value & "", GrdDetail.GetRow.Cells(1).Value & "")
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
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim ar(0) As Object
        ar(0) = "605112400" 'Ready comments
        Dim tempAssembly As System.Reflection.Assembly
        tempAssembly = System.Reflection.Assembly.LoadFrom(Application.StartupPath & "\" & "FormGenerator.dll")
        Dim t As Type = tempAssembly.GetType("FormGenerator.FrmGeneral")
        Dim c As Form = CType(Activator.CreateInstance(t, ar), Form)
        c.ShowDialog()
        Call FillDataSet()
    End Sub
End Class
