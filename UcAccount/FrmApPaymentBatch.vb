Public Class FrmApPaymentBatch
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents PnlHead As System.Windows.Forms.Panel
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnEmail As System.Windows.Forms.Button
    Friend WithEvents BtnFax As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmApPaymentBatch))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.PnlHead = New System.Windows.Forms.Panel
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.BtnEmail = New System.Windows.Forms.Button
        Me.BtnFax = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.Label42 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label43 = New System.Windows.Forms.Label
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.PnlHead.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlHead
        '
        Me.PnlHead.BackColor = System.Drawing.SystemColors.Window
        Me.PnlHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlHead.Controls.Add(Me.Label31)
        Me.PnlHead.Controls.Add(Me.Label30)
        Me.PnlHead.Controls.Add(Me.Label29)
        Me.PnlHead.Controls.Add(Me.Label28)
        Me.PnlHead.Controls.Add(Me.BtnEmail)
        Me.PnlHead.Controls.Add(Me.BtnFax)
        Me.PnlHead.Controls.Add(Me.BtnPrint)
        Me.PnlHead.Controls.Add(Me.BtnPreview)
        Me.PnlHead.Controls.Add(Me.Label42)
        Me.PnlHead.Controls.Add(Me.BtnCancel)
        Me.PnlHead.Controls.Add(Me.Label43)
        Me.PnlHead.Controls.Add(Me.BtnEdit)
        Me.PnlHead.Controls.Add(Me.Label50)
        Me.PnlHead.Controls.Add(Me.Label52)
        Me.PnlHead.Controls.Add(Me.Label53)
        Me.PnlHead.Controls.Add(Me.BtnNew)
        Me.PnlHead.Controls.Add(Me.BtnFind)
        Me.PnlHead.Controls.Add(Me.BtnSave)
        Me.PnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHead.Location = New System.Drawing.Point(0, 0)
        Me.PnlHead.Name = "PnlHead"
        Me.PnlHead.Size = New System.Drawing.Size(920, 45)
        Me.PnlHead.TabIndex = 145
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(325, 32)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(36, 10)
        Me.Label31.TabIndex = 204
        Me.Label31.Text = "Email"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(293, 32)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 10)
        Me.Label30.TabIndex = 203
        Me.Label30.Text = "Fax"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(253, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 202
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(211, 32)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 201
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEmail
        '
        Me.BtnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEmail.Image = CType(resources.GetObject("BtnEmail.Image"), System.Drawing.Image)
        Me.BtnEmail.Location = New System.Drawing.Point(325, 0)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 200
        '
        'BtnFax
        '
        Me.BtnFax.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFax.Image = CType(resources.GetObject("BtnFax.Image"), System.Drawing.Image)
        Me.BtnFax.Location = New System.Drawing.Point(293, 0)
        Me.BtnFax.Name = "BtnFax"
        Me.BtnFax.Size = New System.Drawing.Size(33, 27)
        Me.BtnFax.TabIndex = 199
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(253, 0)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 198
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(219, 0)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 197
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(176, 32)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(42, 10)
        Me.Label42.TabIndex = 186
        Me.Label42.Text = "Cancel"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(176, 0)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Location = New System.Drawing.Point(96, 32)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(33, 10)
        Me.Label43.TabIndex = 184
        Me.Label43.Text = "Edit"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(96, 0)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(136, 32)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 176
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(56, 32)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(33, 10)
        Me.Label52.TabIndex = 174
        Me.Label52.Text = "New"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Location = New System.Drawing.Point(8, 32)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(33, 10)
        Me.Label53.TabIndex = 173
        Me.Label53.Text = "Find"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(56, 0)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(8, 0)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(136, 0)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GrdDetail)
        Me.Panel1.Location = New System.Drawing.Point(8, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 416)
        Me.Panel1.TabIndex = 146
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "GridRecord"
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Invoices</Caption><Columns Collection=""true" & _
        """><Column0 ID=""Check""><TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue><" & _
        "EmptyStringValue /><ColumnType>CheckBox</ColumnType><DataMember>CheckFlag</DataM" & _
        "ember><EditType>CheckBox</EditType><Key>Check</Key><Position>0</Position><Width>" & _
        "31</Width><CellStyle><BackColor>Info</BackColor></CellStyle></Column0><Column1 I" & _
        "D=""Date""><Caption>Date</Caption><DataMember>Date</DataMember><EditType>NoEdit</E" & _
        "ditType><FilterEditType>TextBox</FilterEditType><Key>Date</Key><Position>1</Posi" & _
        "tion><Width>84</Width></Column1><Column2 ID=""Refrenceno""><Caption>Refrence no</C" & _
        "aption><DataMember>Refrenceno</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><Key>Refrenceno</Key><Position>2</Position></Column" & _
        "2><Column3 ID=""OriginalAmount""><Caption>Original Amount</Caption><DataMember>Ori" & _
        "ginalAmount</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filt" & _
        "erEditType><FormatString>c2</FormatString><InputMask>Currency2</InputMask><Key>O" & _
        "riginalAmount</Key><MaskPrompt>&#x0;</MaskPrompt><Position>3</Position><Width>93" & _
        "</Width></Column3><Column4 ID=""PaiedBefore""><Caption>Amount Paid</Caption><DataM" & _
        "ember>PaiedBefore</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox" & _
        "</FilterEditType><FormatString>c2</FormatString><InputMask>Currency2</InputMask>" & _
        "<Key>PaiedBefore</Key><Position>4</Position></Column4><Column5 ID=""AmountDue""><C" & _
        "aption>Amount Due</Caption><DataMember>AmountDue</DataMember><EditType>NoEdit</E" & _
        "ditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><" & _
        "InputMask>Currency2</InputMask><Key>AmountDue</Key><MaskPrompt>&#x0;</MaskPrompt" & _
        "><Position>5</Position><Width>92</Width></Column5><Column6 ID=""DueDate""><Caption" & _
        ">Due Date</Caption><DataMember>DueDate</DataMember><EditType>NoEdit</EditType><F" & _
        "ilterEditType>TextBox</FilterEditType><Key>DueDate</Key><Position>6</Position></" & _
        "Column6><Column7 ID=""Payment""><Caption>Payment</Caption><DataMember>AmountPay</D" & _
        "ataMember><FormatString>c2</FormatString><Key>Payment</Key><MaskPrompt>&#x0;</Ma" & _
        "skPrompt><Position>7</Position><Width>85</Width><CellStyle><BackColor>Info</Back" & _
        "Color></CellStyle></Column7><Column8 ID=""ID_AP_payment""><Caption>ID_AP_payment</" & _
        "Caption><DataMember>ID_AP_payment</DataMember><Key>ID_AP_payment</Key><Position>" & _
        "8</Position><Selectable>False</Selectable><Visible>False</Visible></Column8><Col" & _
        "umn9 ID=""Radif""><Caption>Radif</Caption><DataMember>Radif</DataMember><Key>Radif" & _
        "</Key><Position>9</Position><Selectable>False</Selectable><Visible>False</Visibl" & _
        "e></Column9><Column10 ID=""Remark""><Caption>Remark</Caption><DataMember>Remark</D" & _
        "ataMember><Key>Remark</Key><Position>10</Position></Column10><Column11 ID=""Paied" & _
        "Before2""><Caption>PaiedBefore2</Caption><DataMember>PaiedBefore2</DataMember><Ke" & _
        "y>PaiedBefore2</Key><Position>11</Position><Visible>False</Visible></Column11></" & _
        "Columns><GroupCondition ID="""" /><Key>Invoices</Key></RootTable></GridEXLayoutDat" & _
        "a>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(6, 98)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(804, 262)
        Me.GrdDetail.TabIndex = 351
        '
        'FrmApPaymentBatch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(920, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlHead)
        Me.Name = "FrmApPaymentBatch"
        Me.Text = "FrmApPaymentBatch"
        Me.PnlHead.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
