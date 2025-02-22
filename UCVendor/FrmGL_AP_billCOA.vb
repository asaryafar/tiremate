Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmGL_AP_billCOA
    Inherits FrmBase
    Public Id_AP_bill_dtlVar As Double = 0
    Public OriginalDS As DSFrmGL_AP_bill
    Dim ThisFormDS As New DSFrmGL_AP_bill
    Dim WithEvents MyFrmSearchGlAccount As New UCGl_Account.FrmSearchGlAccount
    Dim BeforeCel As Integer = -1
    Dim BeforeRow As Integer = -1
    Dim BeforeRowEx As GridEXRow = Nothing
    Dim WithEvents MyGl_Account As UCGl_Account.ClsGlAccount
    Public TotalVar As Decimal = 0
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
    Friend WithEvents BtnSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents DsFrmGL_AP_bill1 As UCVendor.DSFrmGL_AP_bill
    Friend WithEvents CmbGL_account As System.Windows.Forms.ComboBox
    Friend WithEvents DAGL_account As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents GlAccount1 As UCGl_Account.GlAccount
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumSubtotal As CalcUtils.UcCalcText
    Friend WithEvents NumTotal As CalcUtils.UcCalcText
    Friend WithEvents NumReminder As CalcUtils.UcCalcText
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItemDelete As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmGL_AP_billCOA))
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmGL_AP_bill1 = New UCVendor.DSFrmGL_AP_bill
        Me.BtnSave = New Janus.Windows.EditControls.UIButton
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.CmbGL_account = New System.Windows.Forms.ComboBox
        Me.DAGL_account = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.GlAccount1 = New UCGl_Account.GlAccount
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.NumSubtotal = New CalcUtils.UcCalcText
        Me.NumTotal = New CalcUtils.UcCalcText
        Me.NumReminder = New CalcUtils.UcCalcText
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItemDelete = New System.Windows.Forms.MenuItem
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmGL_AP_bill1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.ContextMenu = Me.ContextMenu1
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "GL_payment_bill_COA"
        Me.GrdDetail.DataSource = Me.DsFrmGL_AP_bill1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_payment_bill_COA</Caption><Columns Colle" & _
        "ction=""true""><Column0 ID=""Id_AP_bill_dtl""><Caption>Id_AP_bill_dtl</Caption><Type" & _
        "NameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMem" & _
        "ber>Id_AP_bill_dtl</DataMember><Key>Id_AP_bill_dtl</Key><Position>0</Position><V" & _
        "isible>False</Visible></Column0><Column1 ID=""GL_account""><Caption>GL Account</Ca" & _
        "ption><TypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptySt" & _
        "ringValue /><DataMember>GL_account</DataMember><Key>GL_account</Key><Position>1<" & _
        "/Position><Width>88</Width></Column1><Column2 ID=""desc_GL_account""><Caption>Acco" & _
        "unt Description</Caption><DataMember>desc_GL_account</DataMember><Key>desc_GL_ac" & _
        "count</Key><Position>2</Position><Selectable>False</Selectable><Width>213</Width" & _
        "></Column2><Column3 ID=""Amount""><Caption>Amount</Caption><DataMember>Amount</Dat" & _
        "aMember><FormatString>c2</FormatString><InputMask>Currency2 </InputMask><Key>Amo" & _
        "unt</Key><MaskPrompt>&#x0;</MaskPrompt><NullText>0</NullText><Position>3</Positi" & _
        "on><TextAlignment>Far</TextAlignment><Width>112</Width></Column3><Column4 ID=""Me" & _
        "mo""><Caption>Memo</Caption><DataMember>Memo</DataMember><Key>Memo</Key><Position" & _
        ">4</Position><Width>121</Width></Column4></Columns><GroupCondition ID="""" /><Key>" & _
        "GL_payment_bill_COA</Key><RowHeight>25</RowHeight></RootTable></GridEXLayoutData" & _
        ">"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 45)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(560, 223)
        Me.GrdDetail.TabIndex = 1
        '
        'DsFrmGL_AP_bill1
        '
        Me.DsFrmGL_AP_bill1.DataSetName = "DSFrmGL_AP_bill"
        Me.DsFrmGL_AP_bill1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Location = New System.Drawing.Point(426, 300)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(99, 24)
        Me.BtnSave.TabIndex = 21
        Me.BtnSave.Text = "Save"
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(34, 300)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(99, 24)
        Me.BtnCancel.TabIndex = 20
        Me.BtnCancel.Text = "Cancel"
        '
        'CmbGL_account
        '
        Me.CmbGL_account.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbGL_account.DataSource = Me.DsFrmGL_AP_bill1.GL_account
        Me.CmbGL_account.DisplayMember = "desc_GL_account"
        Me.CmbGL_account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGL_account.Location = New System.Drawing.Point(161, 118)
        Me.CmbGL_account.Name = "CmbGL_account"
        Me.CmbGL_account.Size = New System.Drawing.Size(114, 21)
        Me.CmbGL_account.TabIndex = 22
        Me.CmbGL_account.ValueMember = "GL_account"
        '
        'DAGL_account
        '
        Me.DAGL_account.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_account.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account"), New System.Data.Common.DataColumnMapping("GL_account_master", "GL_account_master"), New System.Data.Common.DataColumnMapping("group_GL_account", "group_GL_account"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT GL_account, desc_GL_account, GL_account_master, group_GL_account, remark F" & _
        "ROM GL_account"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'GlAccount1
        '
        Me.GlAccount1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GlAccount1.Cod_Gl = ""
        Me.GlAccount1.Connection = Me.Cnn
        Me.GlAccount1.Enabled = False
        Me.GlAccount1.Location = New System.Drawing.Point(239, 143)
        Me.GlAccount1.Name = "GlAccount1"
        Me.GlAccount1.NotExitIfNotFound = False
        Me.GlAccount1.ReleaseIfNotFoundEmployeeCod = False
        Me.GlAccount1.Size = New System.Drawing.Size(128, 20)
        Me.GlAccount1.TabIndex = 23
        Me.GlAccount1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(560, 45)
        Me.Panel4.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 43)
        Me.Label1.TabIndex = 207
        Me.Label1.Text = "Pressing F2 Key on GL Account will display Account Numbers.                      " & _
        "  To delete a row , press space bar on GL Account column to clear its value."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 208
        Me.PictureBox2.TabStop = False
        '
        'NumSubtotal
        '
        Me.NumSubtotal.BackColor = System.Drawing.Color.Gold
        Me.NumSubtotal.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumSubtotal.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumSubtotal.DecimalDigits = 2
        Me.NumSubtotal.DefaultSendValue = False
        Me.NumSubtotal.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumSubtotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumSubtotal.Image = CType(resources.GetObject("NumSubtotal.Image"), System.Drawing.Image)
        Me.NumSubtotal.Location = New System.Drawing.Point(254, 273)
        Me.NumSubtotal.Maxlength = 12
        Me.NumSubtotal.MinusColor = System.Drawing.Color.Empty
        Me.NumSubtotal.Name = "NumSubtotal"
        Me.NumSubtotal.ReadOnly = True
        Me.NumSubtotal.Size = New System.Drawing.Size(108, 21)
        Me.NumSubtotal.TabIndex = 453
        Me.NumSubtotal.TabStop = False
        Me.NumSubtotal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumSubtotal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumTotal
        '
        Me.NumTotal.BackColor = System.Drawing.Color.Gold
        Me.NumTotal.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumTotal.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumTotal.DecimalDigits = 2
        Me.NumTotal.DefaultSendValue = False
        Me.NumTotal.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumTotal.Image = CType(resources.GetObject("NumTotal.Image"), System.Drawing.Image)
        Me.NumTotal.Location = New System.Drawing.Point(56, 273)
        Me.NumTotal.Maxlength = 12
        Me.NumTotal.MinusColor = System.Drawing.Color.Empty
        Me.NumTotal.Name = "NumTotal"
        Me.NumTotal.ReadOnly = True
        Me.NumTotal.Size = New System.Drawing.Size(109, 21)
        Me.NumTotal.TabIndex = 454
        Me.NumTotal.TabStop = False
        Me.NumTotal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumTotal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumReminder
        '
        Me.NumReminder.BackColor = System.Drawing.Color.Gold
        Me.NumReminder.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumReminder.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumReminder.DecimalDigits = 2
        Me.NumReminder.DefaultSendValue = False
        Me.NumReminder.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumReminder.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumReminder.Image = CType(resources.GetObject("NumReminder.Image"), System.Drawing.Image)
        Me.NumReminder.Location = New System.Drawing.Point(450, 272)
        Me.NumReminder.Maxlength = 12
        Me.NumReminder.MinusColor = System.Drawing.Color.Empty
        Me.NumReminder.Name = "NumReminder"
        Me.NumReminder.ReadOnly = True
        Me.NumReminder.Size = New System.Drawing.Size(108, 21)
        Me.NumReminder.TabIndex = 455
        Me.NumReminder.TabStop = False
        Me.NumReminder.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumReminder.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(4, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 21)
        Me.Label10.TabIndex = 456
        Me.Label10.Text = "Total"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(191, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 457
        Me.Label2.Text = "Distributed"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(388, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 21)
        Me.Label3.TabIndex = 458
        Me.Label3.Text = "Remainder"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(369, 273)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 22)
        Me.Label12.TabIndex = 463
        Me.Label12.Text = "="
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(171, 272)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 22)
        Me.Label13.TabIndex = 464
        Me.Label13.Text = "-"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemDelete})
        '
        'MenuItemDelete
        '
        Me.MenuItemDelete.Index = 0
        Me.MenuItemDelete.Text = "Delete This Record"
        '
        'FrmGL_AP_billCOA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 327)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NumReminder)
        Me.Controls.Add(Me.NumTotal)
        Me.Controls.Add(Me.NumSubtotal)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.CmbGL_account)
        Me.Controls.Add(Me.GlAccount1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmGL_AP_billCOA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "GL Distribution"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmGL_AP_bill1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmGL_AP_billCOA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString

        MyGl_Account = New UCGl_Account.ClsGlAccount
        MyGl_Account.Connection = Me.Cnn

        DsFrmGL_AP_bill1.GL_account.Clear()
        DAGL_account.Fill(DsFrmGL_AP_bill1, "GL_account")
        If DsFrmGL_AP_bill1.GL_account.Rows.Count < 1 Then
            MsgFar("Please Fill The GL_account Table")
            Call DisableAllComponet(Me)
            BtnCancel.Enabled = True
        End If

        OriginalDS.GL_payment_bill_COA.DefaultView.RowFilter = "Id_AP_bill_dtl=" & Id_AP_bill_dtlVar
        Dim i As Integer
        For i = 0 To OriginalDS.GL_payment_bill_COA.DefaultView.Count - 1
            If OriginalDS.GL_payment_bill_COA.DefaultView(i).Row.RowState <> DataRowState.Deleted Then
                Dim dr As DataRow
                dr = ThisFormDS.GL_payment_bill_COA.NewRow
                dr("Id_AP_bill_dtl") = OriginalDS.GL_payment_bill_COA.DefaultView(i).Item("Id_AP_bill_dtl")
                dr("GL_account") = OriginalDS.GL_payment_bill_COA.DefaultView(i).Item("GL_account")
                dr("Amount") = OriginalDS.GL_payment_bill_COA.DefaultView(i).Item("Amount")
                dr("Memo") = OriginalDS.GL_payment_bill_COA.DefaultView(i).Item("Memo")
                dr("desc_GL_account") = OriginalDS.GL_payment_bill_COA.DefaultView(i).Item("desc_GL_account")
                ThisFormDS.GL_payment_bill_COA.Rows.Add(dr)
            End If
        Next
        For i = 0 To 10
            Dim dr As DataRow
            dr = ThisFormDS.GL_payment_bill_COA.NewRow
            dr("Id_AP_bill_dtl") = 0
            dr("GL_account") = ""
            dr("Amount") = 0
            dr("Memo") = ""
            dr("desc_GL_account") = ""
            ThisFormDS.GL_payment_bill_COA.Rows.Add(dr)
        Next
        GrdDetail.DataSource = ThisFormDS
        GrdDetail.DataMember = "GL_payment_bill_COA"
        GrdDetail.Refetch()

        If ThisFormStatus = MainModule.WorkStates._ReadOnly Then
            Call DisableAllComponet(Me, False)
            BtnCancel.Enabled = True
        End If

        NumTotal.Text = TotalVar

        Call CalcTotals()

    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If NumReminder.Numbervalue <> 0 Then
            MsgBox("Please make sure SUM of the AMOUNT of Gl distribution " & vbCrLf & "is equal to the Bill Amount before saving this record.")
            Exit Sub
        End If
        Dim i As Integer
        Dim j As Integer
        If CmdGeneral.Connection.State = ConnectionState.Closed Then
            CmdGeneral.Connection.Open()
        End If
        For i = 0 To ThisFormDS.GL_payment_bill_COA.DefaultView.Count - 1
            If ThisFormDS.GL_payment_bill_COA.DefaultView(i).Row.RowState <> DataRowState.Deleted Then
                If Trim(ThisFormDS.GL_payment_bill_COA.Rows(i).Item("GL_account")).Length > 0 And Val(ThisFormDS.GL_payment_bill_COA.Rows(i).Item("Amount") & "") > 0 Then
                    CmdGeneral.CommandText = "select count(*) from GL_account where GL_account=" & Qt(ThisFormDS.GL_payment_bill_COA.Rows(i).Item("GL_account")) & ""
                    If CmdGeneral.ExecuteScalar < 1 Then
                        MsgBox("Account no : " & ThisFormDS.GL_payment_bill_COA.Rows(i).Item("GL_account") & " is invalid.")
                        Exit Sub
                    End If
                    If i < ThisFormDS.GL_payment_bill_COA.DefaultView.Count - 1 Then
                        For j = i + 1 To ThisFormDS.GL_payment_bill_COA.DefaultView.Count - 1
                            If Trim(ThisFormDS.GL_payment_bill_COA.Rows(j).Item("GL_account")).Length > 0 And Val(ThisFormDS.GL_payment_bill_COA.Rows(j).Item("Amount") & "") > 0 Then
                                If ThisFormDS.GL_payment_bill_COA.Rows(i).Item("GL_account") = ThisFormDS.GL_payment_bill_COA.Rows(j).Item("GL_account") Then
                                    MsgBox("Gl Account numbers cannot be repeated." + vbCrLf + "Please correct it before saving.")
                                    Exit Sub
                                End If
                            End If
                        Next
                    End If
                End If
            End If
        Next
        For i = 0 To OriginalDS.GL_payment_bill_COA.DefaultView.Count - 1
            If OriginalDS.GL_payment_bill_COA.DefaultView(i).Row.RowState <> DataRowState.Deleted Then
                OriginalDS.GL_payment_bill_COA.DefaultView(i).Row.Delete()
                i = i - 1
            End If
            If i >= OriginalDS.GL_payment_bill_COA.DefaultView.Count Or OriginalDS.GL_payment_bill_COA.DefaultView.Count = 0 Then
                Exit For
            End If
        Next
        OriginalDS.GL_payment_bill_COA.DefaultView.RowFilter = ""
        For i = 0 To ThisFormDS.GL_payment_bill_COA.DefaultView.Count - 1
            If ThisFormDS.GL_payment_bill_COA.DefaultView(i).Row.RowState <> DataRowState.Deleted Then
                If Trim(ThisFormDS.GL_payment_bill_COA.Rows(i).Item("GL_account")).Length > 0 And Val(ThisFormDS.GL_payment_bill_COA.Rows(i).Item("Amount") & "") > 0 Then
                    Dim dr As DataRow
                    dr = OriginalDS.GL_payment_bill_COA.NewRow
                    dr("Id_AP_bill_dtl") = Id_AP_bill_dtlVar
                    dr("GL_account") = ThisFormDS.GL_payment_bill_COA.Rows(i).Item("GL_account")
                    dr("Amount") = ThisFormDS.GL_payment_bill_COA.Rows(i).Item("Amount")
                    dr("Memo") = ThisFormDS.GL_payment_bill_COA.Rows(i).Item("Memo")
                    dr("desc_GL_account") = ThisFormDS.GL_payment_bill_COA.Rows(i).Item("desc_GL_account")
                    OriginalDS.GL_payment_bill_COA.Rows.Add(dr)
                End If
            End If
        Next
        Me.Close()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        OriginalDS.GL_payment_bill_COA.DefaultView.RowFilter = ""
        Me.Close()
    End Sub
    Friend Sub DisableAllComponet(ByVal MyForm As Form, Optional ByVal MyStat As Boolean = False)
        Dim i As Integer
        For i = 0 To MyForm.Controls.Count - 1
            MyForm.Controls(i).Enabled = MyStat
        Next i
    End Sub
    Private Sub GrdDetail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdDetail.KeyDown
        If ThisFormStatus <> MainModule.WorkStates._ReadOnly Then
            Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
            Dim CurrentRowGrid As Long = 2
            Dim flg2 As Boolean = False

            Dim row As Integer = GrdDetail.Row
            Dim col As Integer = GrdDetail.Col
            '-------------------------------------------------------------
            Select Case e.Control
                Case True
                    'Select Case e.KeyCode
                    '    Case Keys.Delete
                    '        Call DeleteThisRecord()
                    '    Case Keys.Insert
                    '        Call InsertThisRecord()
                    'End Select
                Case False
                    If e.Shift = False And e.Control = False And e.Alt = False Then
                        Select Case e.KeyCode
                            Case Keys.F2
                                Select Case GrdDetail.Col
                                    Case 1 ' Gl_Account
                                        Call FndGlAccount()
                                        Call SelectRow(row, 1)
                                End Select
                        End Select
                    End If
            End Select
        End If
    End Sub
    Private Function FndGlAccount() As String
        Try
            Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
            'MyFrmSearchItemCode.cod = Val(CustomerCod1.Price_Level & "")
            MyFrmSearchGlAccount.ShowDialog()
            GrdDetail.Focus()
            SelectRow(CurrentRow.RowIndex, 3)
        Catch ex As Exception
        End Try
        Try
            'DsFrmWorkOrders1.inv
        Catch ex As Exception
        End Try
    End Function
    Sub SelectRow(ByVal ThisRow As Integer, Optional ByVal ThisItemCodeFocus As Integer = 1)
        GrdDetail.Focus()
        GrdDetail.Row = ThisRow
        GrdDetail.Col = ThisItemCodeFocus
        GrdDetail.SelectCurrentCellText()
    End Sub
    Private Sub MyFrmSearchGlAccount_GlAccountFind(ByVal ThisRow As System.Data.DataRow) Handles MyFrmSearchGlAccount.GlAccountFind
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        If ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Then
            If CurrentRow Is Nothing Then Exit Sub
            SelectRow(GrdDetail.Row, 3)
            CurrentRow.Cells(1).Value = ThisRow(0)
            SelectRow(GrdDetail.Row, 1)
            CurrentRow.Cells(2).Value = ThisRow(1)
            'SelectRow(GrdDetail.Row, 3)
            SendKeys.Send("{TAB}")
            GrdDetail.Focus()
        End If
    End Sub
    Private Sub GrdDetail_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.CurrentCellChanged
        Dim ValueString As String = ""
        Dim CurrentRowGrid As Long = GrdDetail.Row
        If BeforeRowEx Is Nothing Or BeforeCel < 0 Or BeforeRow < 0 Then
            Exit Sub
        End If

        Try
            ValueString = BeforeRowEx.Cells(BeforeCel).Value & ""
            Call CalcTotals()
            Select Case BeforeCel
                Case 1
                    If Not SayItemName() Then
                        MsgFar("Cod is invalid")
                        Call SelectRow(CurrentRowGrid)
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub InitBeforeRow()
        BeforeCel = GrdDetail.Col
        BeforeRow = GrdDetail.Row
        BeforeRowEx = GrdDetail.GetRow
    End Sub
    Private Sub GrdDetail_CurrentCellChanging(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.CurrentCellChangingEventArgs) Handles GrdDetail.CurrentCellChanging
        'Call EnableDisableSave()
        Call InitBeforeRow()
        Call CalcTotals()
    End Sub
    Private Function SayItemName() As Boolean
        SayItemName = True
        Dim ThisRowGrid As GridEXRow = GrdDetail.GetRow
        Try
            MyGl_Account.Cod_Gl = ThisRowGrid.Cells(1).Value
            MyGl_Account.FindDesc(MyGl_Account.Cod_Gl)
            ThisRowGrid.Cells(2).Value = MyGl_Account.Desc_Gl
            If Trim(ThisRowGrid.Cells(2).Value & "").Length = 0 Then
                ThisRowGrid.Cells(3).Value = 0
                ThisRowGrid.Cells(4).Value = ""
            End If
            GrdDetail.Focus()
        Catch ex As Exception
            SayItemName = True
        End Try
    End Function
    Private Sub CalcTotals()
        Try
            NumSubtotal.Text = Math.Round(ThisFormDS.GL_payment_bill_COA.Compute("Sum(Amount)", ""), 2)
        Catch ex As Exception
        End Try
        NumReminder.Text = NumTotal.Numbervalue - NumSubtotal.Numbervalue
    End Sub
    Private Sub GrdDetail_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.CellValueChanged
        Call CalcTotals()
    End Sub
    Private Sub MenuItemDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDelete.Click
        If ThisFormStatus <> MainModule.WorkStates._ReadOnly Then
            Dim ThisRowGrid As GridEXRow = GrdDetail.GetRow
            ThisRowGrid.Cells("Id_AP_bill_dtl").Value = 0
            ThisRowGrid.Cells("GL_account").Value = ""
            ThisRowGrid.Cells("Amount").Value = 0
            ThisRowGrid.Cells("Memo").Value = ""
            ThisRowGrid.Cells("desc_GL_account").Value = ""
            Call CalcTotals()
            'SelectRow(ThisRowGrid.RowIndex, 1)
        End If
    End Sub
End Class
