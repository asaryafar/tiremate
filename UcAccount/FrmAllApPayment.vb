Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmAllApPayment
    Inherits FrmBase
    Dim WithEvents FrmShowAllVendorsHaveCreadit1 As FrmShowAllVendorsHaveCreadit
    Dim What As Integer = -1
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
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaAllVendorCreadit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmAllApPayMent1 As UcAccount.DsFrmAllApPayMent
    Friend WithEvents DaInv_Receive_product_Ap_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Daservice_out_purchases As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGL_AP_bill_Dtl_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGl_Vendor_Creadit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtVendorCod As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GrdCredit As Janus.Windows.GridEX.GridEX
    Friend WithEvents DvDebit As System.Data.DataView
    Friend WithEvents DvCreadit As System.Data.DataView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmdAutoApply As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents CmdAll As Janus.Windows.EditControls.UIButton
    Friend WithEvents Leftpanel As System.Windows.Forms.Panel
    Friend WithEvents rightpanel As System.Windows.Forms.Panel
    Friend WithEvents TxtVendorName As System.Windows.Forms.Label
    Friend WithEvents LblSumAmountDue As CalcUtils.UcCalcText
    Friend WithEvents LblSumPayment As CalcUtils.UcCalcText
    Friend WithEvents LblCreadit As CalcUtils.UcCalcText
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtDueDate As CalendarCombo.CalendarCombo
    Friend WithEvents LblError As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaFindSumOrginalRecevie As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataSet11 As UcAccount.DataSet1
    Friend WithEvents Label11 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmAllApPayment))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.PnlHead = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.Label36 = New System.Windows.Forms.Label
        Me.BtnFirst = New System.Windows.Forms.Button
        Me.Label37 = New System.Windows.Forms.Label
        Me.BtnLast = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnNext = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.Label42 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.BtnFind = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Leftpanel = New System.Windows.Forms.Panel
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DvDebit = New System.Data.DataView
        Me.DsFrmAllApPayMent1 = New UcAccount.DsFrmAllApPayMent
        Me.rightpanel = New System.Windows.Forms.Panel
        Me.LblCreadit = New CalcUtils.UcCalcText
        Me.GrdCredit = New Janus.Windows.GridEX.GridEX
        Me.DvCreadit = New System.Data.DataView
        Me.Label5 = New System.Windows.Forms.Label
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaAllVendorCreadit = New System.Data.SqlClient.SqlDataAdapter
        Me.DaInv_Receive_product_Ap_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Daservice_out_purchases = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaGL_AP_bill_Dtl_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.DaGl_Vendor_Creadit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtVendorCod = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmdAutoApply = New Janus.Windows.EditControls.UIButton
        Me.CmdAll = New Janus.Windows.EditControls.UIButton
        Me.TxtVendorName = New System.Windows.Forms.Label
        Me.LblSumAmountDue = New CalcUtils.UcCalcText
        Me.LblSumPayment = New CalcUtils.UcCalcText
        Me.TxtDueDate = New CalendarCombo.CalendarCombo
        Me.Label7 = New System.Windows.Forms.Label
        Me.LblError = New System.Windows.Forms.Label
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DaFindSumOrginalRecevie = New System.Data.SqlClient.SqlDataAdapter
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.DataSet11 = New UcAccount.DataSet1
        Me.Label11 = New System.Windows.Forms.Label
        Me.PnlHead.SuspendLayout()
        Me.Leftpanel.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvDebit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmAllApPayMent1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rightpanel.SuspendLayout()
        CType(Me.GrdCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvCreadit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlHead
        '
        Me.PnlHead.BackColor = System.Drawing.SystemColors.Window
        Me.PnlHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlHead.Controls.Add(Me.Label8)
        Me.PnlHead.Controls.Add(Me.Label29)
        Me.PnlHead.Controls.Add(Me.BtnPrint)
        Me.PnlHead.Controls.Add(Me.Label36)
        Me.PnlHead.Controls.Add(Me.BtnFirst)
        Me.PnlHead.Controls.Add(Me.Label37)
        Me.PnlHead.Controls.Add(Me.BtnLast)
        Me.PnlHead.Controls.Add(Me.Label3)
        Me.PnlHead.Controls.Add(Me.Label6)
        Me.PnlHead.Controls.Add(Me.BtnNext)
        Me.PnlHead.Controls.Add(Me.BtnPrev)
        Me.PnlHead.Controls.Add(Me.Label42)
        Me.PnlHead.Controls.Add(Me.BtnCancel)
        Me.PnlHead.Controls.Add(Me.Label50)
        Me.PnlHead.Controls.Add(Me.Label53)
        Me.PnlHead.Controls.Add(Me.BtnFind)
        Me.PnlHead.Controls.Add(Me.BtnSave)
        Me.PnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHead.Location = New System.Drawing.Point(0, 0)
        Me.PnlHead.Name = "PnlHead"
        Me.PnlHead.Size = New System.Drawing.Size(926, 64)
        Me.PnlHead.TabIndex = 145
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(416, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(472, 40)
        Me.Label8.TabIndex = 215
        Me.Label8.Text = "To Prepare Bills For  Payment , Enter a Due Date  Click On ""Select Vendor"" and th" & _
        "en Choose   ""Prepare For Check ""  Tab.  To Apply Vendor Credits choose Credit Ta" & _
        "b."
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(368, 37)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 214
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(368, 5)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 213
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Location = New System.Drawing.Point(96, 38)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(33, 10)
        Me.Label36.TabIndex = 212
        Me.Label36.Text = "First"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.SystemColors.Window
        Me.BtnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFirst.Image = CType(resources.GetObject("BtnFirst.Image"), System.Drawing.Image)
        Me.BtnFirst.Location = New System.Drawing.Point(96, 5)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(33, 27)
        Me.BtnFirst.TabIndex = 211
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Location = New System.Drawing.Point(216, 38)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(33, 10)
        Me.Label37.TabIndex = 210
        Me.Label37.Text = "Last"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLast
        '
        Me.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLast.Image = CType(resources.GetObject("BtnLast.Image"), System.Drawing.Image)
        Me.BtnLast.Location = New System.Drawing.Point(216, 5)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 27)
        Me.BtnLast.TabIndex = 209
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(136, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 10)
        Me.Label3.TabIndex = 208
        Me.Label3.Text = "Prev"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(176, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 10)
        Me.Label6.TabIndex = 207
        Me.Label6.Text = "Next"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(176, 5)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 27)
        Me.BtnNext.TabIndex = 206
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(136, 5)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrev.TabIndex = 205
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(320, 38)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(42, 10)
        Me.Label42.TabIndex = 186
        Me.Label42.Text = "Exit"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(324, 5)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(267, 37)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(55, 25)
        Me.Label50.TabIndex = 176
        Me.Label50.Text = "Save and  Print"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Location = New System.Drawing.Point(7, 32)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(80, 16)
        Me.Label53.TabIndex = 173
        Me.Label53.Text = "Select Vendor"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(22, 5)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(280, 5)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'Leftpanel
        '
        Me.Leftpanel.Controls.Add(Me.GrdDetail)
        Me.Leftpanel.Location = New System.Drawing.Point(2, 128)
        Me.Leftpanel.Name = "Leftpanel"
        Me.Leftpanel.Size = New System.Drawing.Size(654, 360)
        Me.Leftpanel.TabIndex = 146
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataSource = Me.DvDebit
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Invoices</Caption><Columns Collection=""true" & _
        """><Column0 ID=""Check""><TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue><" & _
        "EmptyStringValue /><ColumnType>CheckBox</ColumnType><DataMember>CheckFlag</DataM" & _
        "ember><EditType>CheckBox</EditType><Key>Check</Key><Position>0</Position><Width>" & _
        "27</Width><CellStyle><BackColor>Info</BackColor></CellStyle></Column0><Column1 I" & _
        "D=""Date""><Caption>Date</Caption><DataMember>Date</DataMember><EditType>NoEdit</E" & _
        "ditType><FilterEditType>TextBox</FilterEditType><Key>Date</Key><Position>1</Posi" & _
        "tion><Width>66</Width></Column1><Column2 ID=""vendorrefno""><Caption>Vendor Ref.</" & _
        "Caption><DataMember>vendorrefno</DataMember><EditType>NoEdit</EditType><Key>vend" & _
        "orrefno</Key><Position>2</Position><Width>68</Width></Column2><Column3 ID=""Refre" & _
        "nceno""><Caption>Refrence no</Caption><DataMember>Refrenceno</DataMember><EditTyp" & _
        "e>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>Refrenceno</Key>" & _
        "<Position>3</Position><Width>72</Width></Column3><Column4 ID=""OriginalAmount""><C" & _
        "aption>Original Amount</Caption><DataMember>OriginalAmount</DataMember><EditType" & _
        ">NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</Form" & _
        "atString><InputMask>Currency2</InputMask><Key>OriginalAmount</Key><MaskPrompt>&#" & _
        "x0;</MaskPrompt><Position>4</Position><Width>90</Width></Column4><Column5 ID=""Pa" & _
        "iedBefore""><Caption>Amount Paid</Caption><DataMember>PaiedBefore</DataMember><Ed" & _
        "itType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2" & _
        "</FormatString><InputMask>Currency2</InputMask><Key>PaiedBefore</Key><Position>5" & _
        "</Position><Width>87</Width></Column5><Column6 ID=""AmountDue""><Caption>Amount Du" & _
        "e</Caption><DataMember>AmountDue</DataMember><EditType>NoEdit</EditType><FilterE" & _
        "ditType>TextBox</FilterEditType><FormatString>c2</FormatString><InputMask>Curren" & _
        "cy2</InputMask><Key>AmountDue</Key><MaskPrompt>&#x0;</MaskPrompt><Position>6</Po" & _
        "sition><Width>74</Width></Column6><Column7 ID=""DueDate""><Caption>Due Date</Capti" & _
        "on><DataMember>DueDate</DataMember><EditType>NoEdit</EditType><FilterEditType>Te" & _
        "xtBox</FilterEditType><Key>DueDate</Key><Position>7</Position><Width>65</Width><" & _
        "/Column7><Column8 ID=""Payment""><Caption>Payment</Caption><DataMember>AmountPay</" & _
        "DataMember><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatStrin" & _
        "g><Key>Payment</Key><MaskPrompt>&#x0;</MaskPrompt><Position>8</Position><Width>8" & _
        "5</Width><CellStyle><BackColor>Info</BackColor></CellStyle></Column8><Column9 ID" & _
        "=""ID_AP_payment""><Caption>ID_AP_payment</Caption><DataMember>ID_AP_payment</Data" & _
        "Member><Key>ID_AP_payment</Key><Position>9</Position><Selectable>False</Selectab" & _
        "le><Visible>False</Visible></Column9><Column10 ID=""Radif""><Caption>Radif</Captio" & _
        "n><DataMember>Radif</DataMember><Key>Radif</Key><Position>10</Position><Selectab" & _
        "le>False</Selectable><Visible>False</Visible></Column10><Column11 ID=""Remark""><C" & _
        "aption>Remark</Caption><DataMember>Remark</DataMember><Key>Remark</Key><Position" & _
        ">11</Position></Column11><Column12 ID=""PaiedBefore2""><Caption>PaiedBefore2</Capt" & _
        "ion><DataMember>PaiedBefore2</DataMember><Key>PaiedBefore2</Key><Position>12</Po" & _
        "sition><Visible>False</Visible></Column12></Columns><GroupCondition ID="""" /><Key" & _
        ">Invoices</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 0)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(654, 360)
        Me.GrdDetail.TabIndex = 350
        '
        'DvDebit
        '
        Me.DvDebit.Sort = "vendorrefno"
        Me.DvDebit.Table = Me.DsFrmAllApPayMent1.GridRecord
        '
        'DsFrmAllApPayMent1
        '
        Me.DsFrmAllApPayMent1.DataSetName = "DsFrmAllApPayMent"
        Me.DsFrmAllApPayMent1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'rightpanel
        '
        Me.rightpanel.Controls.Add(Me.LblCreadit)
        Me.rightpanel.Controls.Add(Me.GrdCredit)
        Me.rightpanel.Controls.Add(Me.Label5)
        Me.rightpanel.Location = New System.Drawing.Point(659, 120)
        Me.rightpanel.Name = "rightpanel"
        Me.rightpanel.Size = New System.Drawing.Size(264, 408)
        Me.rightpanel.TabIndex = 147
        '
        'LblCreadit
        '
        Me.LblCreadit.BackColor = System.Drawing.Color.Gold
        Me.LblCreadit.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblCreadit.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblCreadit.DecimalDigits = 2
        Me.LblCreadit.DefaultSendValue = False
        Me.LblCreadit.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblCreadit.FireTabAfterEnter = True
        Me.LblCreadit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblCreadit.Image = CType(resources.GetObject("LblCreadit.Image"), System.Drawing.Image)
        Me.LblCreadit.Location = New System.Drawing.Point(80, 376)
        Me.LblCreadit.Maxlength = 12
        Me.LblCreadit.MinusColor = System.Drawing.Color.Empty
        Me.LblCreadit.Name = "LblCreadit"
        Me.LblCreadit.ReadOnly = True
        Me.LblCreadit.Size = New System.Drawing.Size(112, 21)
        Me.LblCreadit.TabIndex = 458
        Me.LblCreadit.TabStop = False
        Me.LblCreadit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblCreadit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'GrdCredit
        '
        Me.GrdCredit.AllowColumnDrag = False
        Me.GrdCredit.AlternatingColors = True
        Me.GrdCredit.AutomaticSort = False
        Me.GrdCredit.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdCredit.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdCredit.DataSource = Me.DvCreadit
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_vendor_credit</Caption><Columns Collecti" & _
        "on=""true""><Column0 ID=""selected""><ColumnType>CheckBox</ColumnType><DataMember>se" & _
        "lected</DataMember><EditType>CheckBox</EditType><Key>selected</Key><Position>0</" & _
        "Position><Width>23</Width></Column0><Column1 ID=""ref_no""><Caption>Credit Ref.</C" & _
        "aption><DataMember>ref_no</DataMember><EditType>NoEdit</EditType><Key>ref_no</Ke" & _
        "y><Position>1</Position><Width>78</Width></Column1><Column2 ID=""due_date""><Capti" & _
        "on>Due Date</Caption><DataMember>due_date</DataMember><EditType>NoEdit</EditType" & _
        "><Key>due_date</Key><Position>2</Position><Width>66</Width></Column2><Column3 ID" & _
        "=""amount_credit""><Caption>Credit Amount</Caption><TypeNameEmptyStringValue>NULL<" & _
        "/TypeNameEmptyStringValue><EmptyStringValue /><DataMember>amount_credit</DataMem" & _
        "ber><EditType>NoEdit</EditType><FormatString>c</FormatString><Key>amount_credit<" & _
        "/Key><Position>3</Position><TextAlignment>Far</TextAlignment><Width>87</Width></" & _
        "Column3><Column4 ID=""id_vendor_credit""><Caption>id_vendor_credit</Caption><TypeN" & _
        "ameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMemb" & _
        "er>id_vendor_credit</DataMember><EditType>NoEdit</EditType><Key>id_vendor_credit" & _
        "</Key><Position>4</Position><Visible>False</Visible><Width>9</Width></Column4><C" & _
        "olumn5 ID=""cod_vendor""><Caption>cod_vendor</Caption><TypeNameEmptyStringValue>Sy" & _
        "stem.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>cod_vendor" & _
        "</DataMember><Key>cod_vendor</Key><Position>5</Position><Visible>False</Visible>" & _
        "<Width>48</Width></Column5><Column6 ID=""date_credit""><Caption>date_credit</Capti" & _
        "on><DataMember>date_credit</DataMember><Key>date_credit</Key><Position>6</Positi" & _
        "on><Visible>False</Visible><Width>9</Width></Column6><Column7 ID=""Remark""><Capti" & _
        "on>Remark</Caption><DataMember>Remark</DataMember><Key>Remark</Key><Position>7</" & _
        "Position><Visible>False</Visible><Width>9</Width></Column7><Column8 ID=""id_vendo" & _
        "r_credit_head""><Caption>id_vendor_credit_head</Caption><DataMember>id_vendor_cre" & _
        "dit_head</DataMember><Key>id_vendor_credit_head</Key><Position>8</Position><Visi" & _
        "ble>False</Visible></Column8></Columns><GroupCondition ID="""" /><Key>GL_vendor_cr" & _
        "edit</Key></RootTable></GridEXLayoutData>"
        Me.GrdCredit.DesignTimeLayout = GridEXLayout2
        Me.GrdCredit.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdCredit.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdCredit.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdCredit.GroupByBoxVisible = False
        Me.GrdCredit.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdCredit.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdCredit.Location = New System.Drawing.Point(4, 8)
        Me.GrdCredit.Name = "GrdCredit"
        Me.GrdCredit.Size = New System.Drawing.Size(268, 360)
        Me.GrdCredit.TabIndex = 351
        '
        'DvCreadit
        '
        Me.DvCreadit.Sort = "ref_no"
        Me.DvCreadit.Table = Me.DsFrmAllApPayMent1.GL_vendor_credit
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 363
        Me.Label5.Text = "Total Credit"
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEHXP;packet size=4096;user id=SA;data source=""."";persist sec" & _
        "urity info=True;initial catalog=TireMate_01"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT sumoriginalamount, sumpayment, Id_AP_bill_dtl_dtl FROM View_AllUnPaidGl_Ap" & _
        "_Bill_Dtl_Dtl WHERE (dbo.ChangeDate(due_date) <= @due_date) ORDER BY dbo.ChangeD" & _
        "ate(due_date)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@due_date", System.Data.SqlDbType.VarChar))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO View_AllUnPaidGl_Ap_Bill_Dtl_Dtl(sumoriginalamount, sumpayment, Id_AP" & _
        "_bill_dtl_dtl) VALUES (@sumoriginalamount, @sumpayment, @Id_AP_bill_dtl_dtl); SE" & _
        "LECT sumoriginalamount, sumpayment, Id_AP_bill_dtl_dtl FROM View_AllUnPaidGl_Ap_" & _
        "Bill_Dtl_Dtl"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sumoriginalamount", System.Data.SqlDbType.Money, 8, "sumoriginalamount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sumpayment", System.Data.SqlDbType.Money, 8, "sumpayment"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_AP_bill_dtl_dtl", System.Data.SqlDbType.Int, 4, "Id_AP_bill_dtl_dtl"))
        '
        'DaAllVendorCreadit
        '
        Me.DaAllVendorCreadit.InsertCommand = Me.SqlInsertCommand1
        Me.DaAllVendorCreadit.SelectCommand = Me.SqlSelectCommand1
        Me.DaAllVendorCreadit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "View_AllUnPaidGl_Ap_Bill_Dtl_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("sumoriginalamount", "sumoriginalamount"), New System.Data.Common.DataColumnMapping("sumpayment", "sumpayment"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl")})})
        '
        'DaInv_Receive_product_Ap_Dtl
        '
        Me.DaInv_Receive_product_Ap_Dtl.SelectCommand = Me.SqlCommand1
        Me.DaInv_Receive_product_Ap_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_product_Ap_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("due_date", "due_date")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl, Inv_Receive_prod" & _
        "uct_Ap_Dtl.id_receive_ref, Inv_Receive_product_Ap_Dtl.amount, Inv_Receive_produc" & _
        "t_Ap_Dtl.due_date, Inv_Receive_Products_head.date_receive AS DateTransaction, Vi" & _
        "ew_AllUnPaidReceive_product_ap_Dtl.sumoriginalamount, View_AllUnPaidReceive_prod" & _
        "uct_ap_Dtl.sumpayment, Inv_Receive_Products_head.vendor_ref_no AS vendorrefno FR" & _
        "OM Inv_Receive_product_Ap_Dtl INNER JOIN Inv_Receive_Products_head ON Inv_Receiv" & _
        "e_product_Ap_Dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref INNER" & _
        " JOIN View_AllUnPaidReceive_product_ap_Dtl ON Inv_Receive_Products_head.id_recei" & _
        "ve_ref = View_AllUnPaidReceive_product_ap_Dtl.id_receive_ref AND Inv_Receive_pro" & _
        "duct_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = View_AllUnPaidReceive_product_ap_Dtl" & _
        ".ID_Inv_Receive_product_Ap_Dtl WHERE (Inv_Receive_Products_head.cod_vendor = @co" & _
        "d_vendor) AND (Inv_Receive_product_Ap_Dtl.id_receive_ref IN (SELECT id_receive_r" & _
        "ef FROM View_AllUnPaidReceive_product_ap_Dtl)) AND (dbo.ChangeDate(Inv_Receive_P" & _
        "roducts_head.date_receive) <= @thisDate) AND (View_AllUnPaidReceive_product_ap_D" & _
        "tl.sumoriginalamount <> View_AllUnPaidReceive_product_ap_Dtl.sumpayment) AND (db" & _
        "o.ChangeDate(Inv_Receive_product_Ap_Dtl.due_date) <= @due_date) AND (NOT (Inv_Re" & _
        "ceive_product_Ap_Dtl.due_date IS NULL)) AND (LTRIM(RTRIM(Inv_Receive_product_Ap_" & _
        "Dtl.due_date)) <> '') AND (Inv_Receive_Products_head.Prepaid <> 1)"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@thisDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@due_date", System.Data.SqlDbType.VarChar))
        '
        'Daservice_out_purchases
        '
        Me.Daservice_out_purchases.SelectCommand = Me.SqlSelectCommand2
        Me.Daservice_out_purchases.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_out_purchases", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("markup", "markup"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("invoice_date", "invoice_date"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("tracking_warranty", "tracking_warranty"), New System.Data.Common.DataColumnMapping("in_day", "in_day"), New System.Data.Common.DataColumnMapping("in_mile", "in_mile"), New System.Data.Common.DataColumnMapping("tracking_core", "tracking_core"), New System.Data.Common.DataColumnMapping("core_value", "core_value"), New System.Data.Common.DataColumnMapping("Line", "Line")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT service_out_purchases.radif, View_AllUnPaidService_out_purchase.Cost AS am" & _
        "ount, View_AllUnPaidService_out_purchase.Due_Date, service_out_purchases.id_serv" & _
        "ice_center, service_center_head.date_refer AS DateTransaction, View_AllUnPaidSer" & _
        "vice_out_purchase.sumoriginalamount, View_AllUnPaidService_out_purchase.sumpayme" & _
        "nt, service_out_purchases.invoice_no AS vendorrefno, View_AllUnPaidService_out_p" & _
        "urchase.IDService_out_purchases_dtl FROM service_out_purchases INNER JOIN servic" & _
        "e_center_head ON service_out_purchases.id_service_center = service_center_head.i" & _
        "d_service_center INNER JOIN View_AllUnPaidService_out_purchase ON service_out_pu" & _
        "rchases.id_service_center = View_AllUnPaidService_out_purchase.id_service_center" & _
        " AND service_out_purchases.radif = View_AllUnPaidService_out_purchase.radif WHER" & _
        "E (service_out_purchases.cod_vendor = @cod_vendor) AND ((service_out_purchases.i" & _
        "d_service_center + STR(service_out_purchases.radif)) IN (SELECT id_service_cente" & _
        "r + str(radif) FROM View_AllUnPaidService_out_purchase)) AND (service_center_hea" & _
        "d.type_of_form = 'IN') AND (service_out_purchases.PaidFlag = 0) AND (NOT (View_A" & _
        "llUnPaidService_out_purchase.Due_Date IS NULL)) AND (dbo.ChangeDate(View_AllUnPa" & _
        "idService_out_purchase.Due_Date) <= @Due_Date) AND (LTRIM(RTRIM(View_AllUnPaidSe" & _
        "rvice_out_purchase.Due_Date)) <> '') AND (dbo.ChangeDate(service_center_head.dat" & _
        "e_refer) <= @ThisDate) AND (View_AllUnPaidService_out_purchase.Cost <> View_AllU" & _
        "nPaidService_out_purchase.sumpayment)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Due_Date", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar))
        '
        'DaGL_AP_bill_Dtl_Dtl
        '
        Me.DaGL_AP_bill_Dtl_Dtl.SelectCommand = Me.SqlSelectCommand3
        Me.DaGL_AP_bill_Dtl_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_bill_Dtl_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl", "Id_AP_bill_dtl"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("due_date", "due_date")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl, GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl, " & _
        "GL_AP_bill_Dtl_Dtl.due_date, GL_AP_Bill_Head.Date_Bill AS DateTransaction, GL_AP" & _
        "_Bill_Head.Id_AP_bill_Head, View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.sumpayment, View_Al" & _
        "lUnPaidGl_Ap_Bill_Dtl_Dtl.sumoriginalamount, GL_AP_bill_Dtl.ref_no AS vendorrefn" & _
        "o, GL_AP_bill_Dtl.amount, GL_AP_bill_Dtl.Discount FROM GL_AP_bill_Dtl_Dtl INNER " & _
        "JOIN GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_" & _
        "bill_dtl INNER JOIN GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bi" & _
        "ll_Head.Id_AP_bill_Head INNER JOIN View_AllUnPaidGl_Ap_Bill_Dtl_Dtl ON GL_AP_bil" & _
        "l_Dtl_Dtl.Id_AP_bill_dtl_dtl = View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.Id_AP_bill_dtl_d" & _
        "tl WHERE (GL_AP_Bill_Head.cod_vendor = @cod_vendor) AND (GL_AP_bill_Dtl_Dtl.Id_A" & _
        "P_bill_dtl_dtl IN (SELECT id_ap_bill_dtl_dtl FROM View_AllUnPaidGl_Ap_Bill_Dtl_D" & _
        "tl)) AND (dbo.ChangeDate(GL_AP_Bill_Head.Date_Bill) <= @thisDate) AND (View_AllU" & _
        "nPaidGl_Ap_Bill_Dtl_Dtl.sumoriginalamount <> View_AllUnPaidGl_Ap_Bill_Dtl_Dtl.su" & _
        "mpayment) AND (dbo.ChangeDate(GL_AP_bill_Dtl_Dtl.due_date) <= @due_date) AND (NO" & _
        "T (GL_AP_bill_Dtl_Dtl.due_date IS NULL)) AND (LTRIM(RTRIM(GL_AP_bill_Dtl_Dtl.due" & _
        "_date)) <> '')"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@thisDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@due_date", System.Data.SqlDbType.VarChar))
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'DaGl_Vendor_Creadit
        '
        Me.DaGl_Vendor_Creadit.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaGl_Vendor_Creadit.InsertCommand = Me.SqlInsertCommand2
        Me.DaGl_Vendor_Creadit.SelectCommand = Me.SqlSelectCommand4
        Me.DaGl_Vendor_Creadit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_vendor_credit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_vendor_credit", "id_vendor_credit"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("date_credit", "date_credit"), New System.Data.Common.DataColumnMapping("amount_credit", "amount_credit"), New System.Data.Common.DataColumnMapping("Remark", "Remark"), New System.Data.Common.DataColumnMapping("ref_no", "ref_no"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("id_vendor_credit_head", "id_vendor_credit_head")})})
        Me.DaGl_Vendor_Creadit.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM GL_vendor_credit WHERE (id_vendor_credit = @Original_id_vendor_credit" & _
        ") AND (Remark = @Original_Remark OR @Original_Remark IS NULL AND Remark IS NULL)" & _
        " AND (amount_credit = @Original_amount_credit) AND (cod_vendor = @Original_cod_v" & _
        "endor) AND (date_credit = @Original_date_credit OR @Original_date_credit IS NULL" & _
        " AND date_credit IS NULL) AND (due_date = @Original_due_date OR @Original_due_da" & _
        "te IS NULL AND due_date IS NULL) AND (id_vendor_credit_head = @Original_id_vendo" & _
        "r_credit_head OR @Original_id_vendor_credit_head IS NULL AND id_vendor_credit_he" & _
        "ad IS NULL) AND (ref_no = @Original_ref_no OR @Original_ref_no IS NULL AND ref_n" & _
        "o IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vendor_credit", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vendor_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Remark", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_credit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_credit", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_due_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "due_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vendor_credit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vendor_credit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ref_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ref_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO GL_vendor_credit(cod_vendor, date_credit, amount_credit, Remark, ref_" & _
        "no, due_date, id_vendor_credit_head) VALUES (@cod_vendor, @date_credit, @amount_" & _
        "credit, @Remark, @ref_no, @due_date, @id_vendor_credit_head); SELECT id_vendor_c" & _
        "redit, cod_vendor, date_credit, amount_credit, Remark, ref_no, due_date, id_vend" & _
        "or_credit_head FROM GL_vendor_credit WHERE (id_vendor_credit = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_credit", System.Data.SqlDbType.VarChar, 10, "date_credit"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_credit", System.Data.SqlDbType.Money, 8, "amount_credit"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Remark", System.Data.SqlDbType.VarChar, 100, "Remark"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ref_no", System.Data.SqlDbType.VarChar, 20, "ref_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@due_date", System.Data.SqlDbType.VarChar, 10, "due_date"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vendor_credit_head", System.Data.SqlDbType.Int, 4, "id_vendor_credit_head"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT id_vendor_credit, cod_vendor, date_credit, amount_credit, Remark, ref_no, " & _
        "due_date, id_vendor_credit_head, CAST(1 AS bit) AS selected FROM GL_vendor_credi" & _
        "t WHERE (id_vendor_credit_head IS NULL) AND (dbo.ChangeDate(due_date) <= @due_da" & _
        "te) ORDER BY cod_vendor, date_credit"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@due_date", System.Data.SqlDbType.VarChar))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE GL_vendor_credit SET cod_vendor = @cod_vendor, date_credit = @date_credit," & _
        " amount_credit = @amount_credit, Remark = @Remark, ref_no = @ref_no, due_date = " & _
        "@due_date, id_vendor_credit_head = @id_vendor_credit_head WHERE (id_vendor_credi" & _
        "t = @Original_id_vendor_credit) AND (Remark = @Original_Remark OR @Original_Rema" & _
        "rk IS NULL AND Remark IS NULL) AND (amount_credit = @Original_amount_credit) AND" & _
        " (cod_vendor = @Original_cod_vendor) AND (date_credit = @Original_date_credit OR" & _
        " @Original_date_credit IS NULL AND date_credit IS NULL) AND (due_date = @Origina" & _
        "l_due_date OR @Original_due_date IS NULL AND due_date IS NULL) AND (id_vendor_cr" & _
        "edit_head = @Original_id_vendor_credit_head OR @Original_id_vendor_credit_head I" & _
        "S NULL AND id_vendor_credit_head IS NULL) AND (ref_no = @Original_ref_no OR @Ori" & _
        "ginal_ref_no IS NULL AND ref_no IS NULL); SELECT id_vendor_credit, cod_vendor, d" & _
        "ate_credit, amount_credit, Remark, ref_no, due_date, id_vendor_credit_head FROM " & _
        "GL_vendor_credit WHERE (id_vendor_credit = @id_vendor_credit)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_credit", System.Data.SqlDbType.VarChar, 10, "date_credit"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_credit", System.Data.SqlDbType.Money, 8, "amount_credit"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Remark", System.Data.SqlDbType.VarChar, 100, "Remark"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ref_no", System.Data.SqlDbType.VarChar, 20, "ref_no"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@due_date", System.Data.SqlDbType.VarChar, 10, "due_date"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vendor_credit_head", System.Data.SqlDbType.Int, 4, "id_vendor_credit_head"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vendor_credit", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vendor_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Remark", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_credit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_credit", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_due_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "due_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vendor_credit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vendor_credit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ref_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ref_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vendor_credit", System.Data.SqlDbType.Int, 4, "id_vendor_credit"))
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(7, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 24)
        Me.Label1.TabIndex = 364
        Me.Label1.Text = "Vendor"
        '
        'TxtVendorCod
        '
        Me.TxtVendorCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVendorCod.Location = New System.Drawing.Point(60, 67)
        Me.TxtVendorCod.Name = "TxtVendorCod"
        Me.TxtVendorCod.Size = New System.Drawing.Size(100, 24)
        Me.TxtVendorCod.TabIndex = 365
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(199, 498)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 368
        Me.Label4.Text = "Amount Due"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 498)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 370
        Me.Label2.Text = "Payment"
        '
        'CmdAutoApply
        '
        Me.CmdAutoApply.Location = New System.Drawing.Point(378, 66)
        Me.CmdAutoApply.Name = "CmdAutoApply"
        Me.CmdAutoApply.Size = New System.Drawing.Size(151, 23)
        Me.CmdAutoApply.TabIndex = 372
        Me.CmdAutoApply.Text = "AutoApply To This Vendor"
        '
        'CmdAll
        '
        Me.CmdAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdAll.ForeColor = System.Drawing.Color.Black
        Me.CmdAll.Location = New System.Drawing.Point(534, 66)
        Me.CmdAll.Name = "CmdAll"
        Me.CmdAll.Size = New System.Drawing.Size(151, 23)
        Me.CmdAll.TabIndex = 373
        Me.CmdAll.Text = "AutoApply To All Vendors"
        '
        'TxtVendorName
        '
        Me.TxtVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVendorName.Location = New System.Drawing.Point(167, 66)
        Me.TxtVendorName.Name = "TxtVendorName"
        Me.TxtVendorName.Size = New System.Drawing.Size(201, 24)
        Me.TxtVendorName.TabIndex = 374
        '
        'LblSumAmountDue
        '
        Me.LblSumAmountDue.BackColor = System.Drawing.Color.Gold
        Me.LblSumAmountDue.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblSumAmountDue.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblSumAmountDue.DecimalDigits = 2
        Me.LblSumAmountDue.DefaultSendValue = False
        Me.LblSumAmountDue.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblSumAmountDue.FireTabAfterEnter = True
        Me.LblSumAmountDue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblSumAmountDue.Image = CType(resources.GetObject("LblSumAmountDue.Image"), System.Drawing.Image)
        Me.LblSumAmountDue.Location = New System.Drawing.Point(272, 496)
        Me.LblSumAmountDue.Maxlength = 12
        Me.LblSumAmountDue.MinusColor = System.Drawing.Color.Empty
        Me.LblSumAmountDue.Name = "LblSumAmountDue"
        Me.LblSumAmountDue.ReadOnly = True
        Me.LblSumAmountDue.Size = New System.Drawing.Size(112, 21)
        Me.LblSumAmountDue.TabIndex = 457
        Me.LblSumAmountDue.TabStop = False
        Me.LblSumAmountDue.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblSumAmountDue.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblSumPayment
        '
        Me.LblSumPayment.BackColor = System.Drawing.Color.Gold
        Me.LblSumPayment.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblSumPayment.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblSumPayment.DecimalDigits = 2
        Me.LblSumPayment.DefaultSendValue = False
        Me.LblSumPayment.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblSumPayment.FireTabAfterEnter = True
        Me.LblSumPayment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblSumPayment.Image = CType(resources.GetObject("LblSumPayment.Image"), System.Drawing.Image)
        Me.LblSumPayment.Location = New System.Drawing.Point(72, 496)
        Me.LblSumPayment.Maxlength = 12
        Me.LblSumPayment.MinusColor = System.Drawing.Color.Empty
        Me.LblSumPayment.Name = "LblSumPayment"
        Me.LblSumPayment.ReadOnly = True
        Me.LblSumPayment.Size = New System.Drawing.Size(112, 21)
        Me.LblSumPayment.TabIndex = 458
        Me.LblSumPayment.TabStop = False
        Me.LblSumPayment.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblSumPayment.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtDueDate
        '
        Me.TxtDueDate.BackColor = System.Drawing.SystemColors.Info
        Me.TxtDueDate.BorderColor = System.Drawing.Color.Empty
        Me.TxtDueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDueDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtDueDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtDueDate.EditableSal = True
        Me.TxtDueDate.Image = CType(resources.GetObject("TxtDueDate.Image"), System.Drawing.Image)
        Me.TxtDueDate.Location = New System.Drawing.Point(770, 66)
        Me.TxtDueDate.MaxValue = CType(2500, Short)
        Me.TxtDueDate.MinValue = CType(1800, Short)
        Me.TxtDueDate.Name = "TxtDueDate"
        Me.TxtDueDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDueDate.Sal_Mali = Nothing
        Me.TxtDueDate.ShowButton = True
        Me.TxtDueDate.Size = New System.Drawing.Size(142, 23)
        Me.TxtDueDate.TabIndex = 460
        Me.TxtDueDate.VisualStyle = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(699, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 23)
        Me.Label7.TabIndex = 459
        Me.Label7.Text = "Due Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblError
        '
        Me.LblError.BackColor = System.Drawing.SystemColors.Control
        Me.LblError.ForeColor = System.Drawing.Color.Maroon
        Me.LblError.Location = New System.Drawing.Point(128, 96)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(356, 24)
        Me.LblError.TabIndex = 461
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT SUM(ROUND(Inv_Receive_product_dtl.qty, 2) * (ROUND(Inv_Receive_product_dtl" & _
        ".cost, 2) + ROUND(Inv_Receive_product_dtl.fet, 2))) - Inv_Receive_Products_head." & _
        "Discount AS sumrec FROM Inv_Receive_Products_head INNER JOIN Inv_Receive_product" & _
        "_dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_Receive_product_dtl.id_re" & _
        "ceive_ref WHERE (Inv_Receive_Products_head.id_receive_ref = @id_receive_re) GROU" & _
        "P BY Inv_Receive_Products_head.Discount"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_receive_re", System.Data.SqlDbType.VarChar, 6, "id_receive_ref"))
        '
        'DaFindSumOrginalRecevie
        '
        Me.DaFindSumOrginalRecevie.SelectCommand = Me.SqlSelectCommand5
        Me.DaFindSumOrginalRecevie.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_Products_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("date_receive", "date_receive"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("bill_credit", "bill_credit"), New System.Data.Common.DataColumnMapping("bill_receive", "bill_receive"), New System.Data.Common.DataColumnMapping("ap_term", "ap_term"), New System.Data.Common.DataColumnMapping("receipt_bill_date", "receipt_bill_date"), New System.Data.Common.DataColumnMapping("vendor_ref_no", "vendor_ref_no"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("house_comments", "house_comments"), New System.Data.Common.DataColumnMapping("vend_comments", "vend_comments"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Prepaid", "Prepaid")})})
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(6, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 23)
        Me.Label9.TabIndex = 462
        Me.Label9.Text = "Vendor Bills"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(663, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 23)
        Me.Label10.TabIndex = 464
        Me.Label10.Text = "Vendor Credits"
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(400, 496)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(248, 40)
        Me.Label11.TabIndex = 465
        '
        'FrmAllApPayment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(926, 540)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.TxtDueDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblSumPayment)
        Me.Controls.Add(Me.LblSumAmountDue)
        Me.Controls.Add(Me.TxtVendorName)
        Me.Controls.Add(Me.CmdAll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtVendorCod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rightpanel)
        Me.Controls.Add(Me.Leftpanel)
        Me.Controls.Add(Me.PnlHead)
        Me.Controls.Add(Me.CmdAutoApply)
        Me.Name = "FrmAllApPayment"
        Me.Text = "Pay Bill"
        Me.PnlHead.ResumeLayout(False)
        Me.Leftpanel.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvDebit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmAllApPayMent1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rightpanel.ResumeLayout(False)
        CType(Me.GrdCredit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvCreadit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmAllApPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        TxtDueDate.Text = Format(Now.Date, PubDateFormat)
        TxtDueDate.Focus()
        '  Call ShowCustomers()
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        ShowCustomers(False)
    End Sub
    Sub ShowCustomers(Optional ByVal clear As Boolean = True)
        DsFrmAllApPayMent1.GL_vendor_credit.Clear()
        DsFrmAllApPayMent1.GridRecord.Clear()
        '    If clear Then
        DsFrmAllApPayMent1.View_AllVendorCreadit.Clear()
        DsFrmAllApPayMent1.inv_vendor.Clear()
        '   End If
        FrmShowAllVendorsHaveCreadit1 = New FrmShowAllVendorsHaveCreadit
        FrmShowAllVendorsHaveCreadit1.LblDate.Text = TxtDueDate.Text & ""
        FrmShowAllVendorsHaveCreadit1.DsFrmAllApPayMent2 = DsFrmAllApPayMent1
        FrmShowAllVendorsHaveCreadit1.ShowDialog()
        BtnSave.Enabled = False
    End Sub
    Sub Ploadall()
        Dim i As Integer = 0
        Dim k1 As Integer
        Dim vendorcod As String = ""
        DsFrmAllApPayMent1.GridRecord.Clear()
        DsFrmAllApPayMent1.GL_vendor_credit.Clear()
        DsFrmAllApPayMent1.credit_debit.Clear()
        Dim DueDate As String = Mid(TxtDueDate.Text, 7, 4) + "/" + Mid(TxtDueDate.Text, 1, 2) + "/" + Mid(TxtDueDate.Text, 4, 2)
        If What = 0 Then
            DaGl_Vendor_Creadit.SelectCommand.Parameters("@due_date").Value = DueDate
            DaGl_Vendor_Creadit.Fill(DsFrmAllApPayMent1.GL_vendor_credit)
        Else
            DsFrmAllApPayMent1.GL_vendor_credit.Clear()
        End If
        Dim dt1 As DataTable = IIf(What = 0, DsFrmAllApPayMent1.View_AllVendorCreadit, DsFrmAllApPayMent1.inv_vendor)
        For k1 = 0 To dt1.Rows.Count - 1
            If dt1.Rows(k1).Item("selected") = True Then
                vendorcod = dt1.Rows(k1).Item("cod_vendor") & ""
                Dim FromDate As String = "9999/01/01"   ' Mid(TxtToDate.Text, 7, 4) + "/" + Mid(TxtToDate.Text, 1, 2) + "/" + Mid(TxtToDate.Text, 4, 2)
                'DsFrmApPayment1.Clear()
                DsFrmAllApPayMent1.GL_AP_bill_Dtl_Dtl.Clear()
                DsFrmAllApPayMent1.Inv_Receive_product_Ap_Dtl.Clear()
                DsFrmAllApPayMent1.service_out_purchases.Clear()

                '  Label11.Text = "startFill"

                DaInv_Receive_product_Ap_Dtl.SelectCommand.Parameters("@cod_vendor").Value = vendorcod
                DaInv_Receive_product_Ap_Dtl.SelectCommand.Parameters("@ThisDate").Value = FromDate
                DaInv_Receive_product_Ap_Dtl.SelectCommand.Parameters("@due_date").Value = DueDate
                DaInv_Receive_product_Ap_Dtl.Fill(DsFrmAllApPayMent1)

                'Label11.Text = "DaInv_Receive_product_Ap_Dtl"

                Daservice_out_purchases.SelectCommand.Parameters("@cod_vendor").Value = vendorcod
                Daservice_out_purchases.SelectCommand.Parameters("@ThisDate").Value = FromDate
                Daservice_out_purchases.SelectCommand.Parameters("@due_date").Value = DueDate

                'Label11.Text = "Daservice_out_purchases"
                Try

                    Daservice_out_purchases.Fill(DsFrmAllApPayMent1)

                Catch ex As Exception
                    Label11.Text = "purchase " & ex.Message
                End Try
                Try

                    DaGL_AP_bill_Dtl_Dtl.SelectCommand.Parameters("@cod_vendor").Value = vendorcod
                    DaGL_AP_bill_Dtl_Dtl.SelectCommand.Parameters("@ThisDate").Value = FromDate
                    DaGL_AP_bill_Dtl_Dtl.SelectCommand.Parameters("@due_date").Value = DueDate
                    DaGL_AP_bill_Dtl_Dtl.Fill(DsFrmAllApPayMent1)

                Catch ex As Exception
                    Label11.Text = "dtl " & ex.Message
                End Try
                ' Label11.Text = "DaGL_AP_bill_Dtl_Dtl"
                '        DaGL_AP_payment.Fill(DsFrmApPayment1)

                Dim today As String = Format(Now.Date, PubDateFormat)
                'DsFrmAllApPayMent1.GridRecord.Clear()
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                For i = 0 To DsFrmAllApPayMent1.GL_AP_bill_Dtl_Dtl.Rows.Count - 1
                    Dim dr1 As DataRow = DsFrmAllApPayMent1.GridRecord.NewGridRecordRow
                    With DsFrmAllApPayMent1.GL_AP_bill_Dtl_Dtl.Rows(i)
                        '    CmdGeneral.CommandText = "Select top 1 Id_AP_bill_dtl_dtl from GL_AP_payment where Id_AP_bill_dtl_dtl =" & .Item("Id_AP_bill_dtl_dtl") & " and date_prepare=" & Qt(today) & " and id_check is null"
                        '     If (CmdGeneral.ExecuteScalar & "") = "" Then
                        dr1("cod_vendor") = vendorcod
                        dr1("Date") = .Item("DateTransaction")
                        dr1("Refrenceno") = .Item("Id_AP_bill_Dtl")
                        dr1("Id_AP_bill_dtl_dtl") = .Item("Id_AP_bill_dtl_dtl")
                        dr1("Radif") = -1
                        dr1("RefrenceType") = "BL"
                        dr1("PaiedBefore") = .Item("sumpayment")
                        dr1("OriginalAmount") = .Item("amount") - .Item("discount")
                        dr1("AmountDue") = .Item("sumoriginalamount") - .Item("sumpayment")
                        dr1("AmountPay") = 0
                        dr1("DueDate") = .Item("due_date")
                        dr1("Remark") = ""
                        dr1("CheckFlag") = False
                        dr1("vendorrefno") = .Item("vendorrefno")
                        DsFrmAllApPayMent1.GridRecord.AddGridRecordRow(dr1)

                        '    End If
                    End With
                Next
                ' Label11.Text = "For1"
                For i = 0 To DsFrmAllApPayMent1.Inv_Receive_product_Ap_Dtl.Rows.Count - 1
                    Dim dr1 As DataRow = DsFrmAllApPayMent1.GridRecord.NewGridRecordRow
                    With DsFrmAllApPayMent1.Inv_Receive_product_Ap_Dtl.Rows(i)
                        '  CmdGeneral.CommandText = "Select top 1 ID_Inv_Receive_product_Ap_Dtl from GL_AP_payment where ID_Inv_Receive_product_Ap_Dtl =" & .Item("ID_Inv_Receive_product_Ap_Dtl") & " and date_prepare=" & Qt(today) & " and id_check is null"
                        '    If today <> .Item("due_date") Then
                        ' If (CmdGeneral.ExecuteScalar & "") = "" Then
                        dr1("cod_vendor") = vendorcod
                        dr1("Date") = .Item("DateTransaction")
                        dr1("Refrenceno") = .Item("id_receive_ref")
                        DR1("ID_Inv_Receive_product_Ap_Dtl") = .Item("ID_Inv_Receive_product_Ap_Dtl")
                        dr1("Radif") = -1
                        dr1("RefrenceType") = "RR"
                        dr1("PaiedBefore") = .Item("sumpayment")
                        dr1("OriginalAmount") = FindSumreceive(.Item("id_receive_ref") & "") ' .Item("amount")
                        dr1("AmountDue") = .Item("sumoriginalamount") - .Item("sumpayment")
                        dr1("AmountPay") = 0
                        dr1("DueDate") = .Item("due_date")
                        dr1("Remark") = ""
                        dr1("CheckFlag") = False
                        dr1("vendorrefno") = .Item("vendorrefno")
                        DsFrmAllApPayMent1.GridRecord.AddGridRecordRow(dr1)
                        '  End If
                    End With
                Next

                '' Label11.Text = "For2"
                For i = 0 To DsFrmAllApPayMent1.service_out_purchases.Rows.Count - 1
                    Dim dr1 As DataRow = DsFrmAllApPayMent1.GridRecord.NewGridRecordRow
                    With DsFrmAllApPayMent1.service_out_purchases.Rows(i)
                        '  CmdGeneral.CommandText = "Select top 1  id_service_center  from GL_AP_payment where id_service_center =" & Qt(.Item("id_service_center")) & " and radif =" & .Item("Radif") & " and date_prepare=" & Qt(today) & " and id_check is null"
                        '    If today <> .Item("due_date") Then
                        '  If (CmdGeneral.ExecuteScalar & "") = "" Then
                        dr1("cod_vendor") = vendorcod
                        dr1("Date") = .Item("DateTransaction")
                        dr1("Refrenceno") = .Item("id_service_center")
                        dr1("Radif") = .Item("Radif")
                        dr1("RefrenceType") = "OP"
                        dr1("PaiedBefore") = .Item("sumpayment")
                        dr1("OriginalAmount") = .Item("sumoriginalamount")
                        dr1("AmountDue") = Math.Round(Val("" & .Item("amount")), 2) - .Item("sumpayment") ' .Item("sumoriginalamount") - .Item("sumpayment") 'Math.Round(Val("" & .Item("amount")),2)
                        ' ketabi  dr1("AmountDue") = Math.Round(Val("" & .Item("sumoriginalamount")), 2) - .Item("sumpayment") ' .Item("sumoriginalamount") - .Item("sumpayment") 'Math.Round(Val("" & .Item("amount")),2)
                        dr1("AmountPay") = 0
                        dr1("DueDate") = .Item("due_date")
                        dr1("vendorrefno") = .Item("vendorrefno")
                        dr1("Remark") = ""
                        dr1("CheckFlag") = False
                        dr1("IDService_out_purchases_dtl") = .Item("IDService_out_purchases_dtl")
                        DsFrmAllApPayMent1.GridRecord.AddGridRecordRow(dr1)
                        '  End If
                    End With
                Next
                ''  Label11.Text = "For3"
            End If
        Next
        If What = 1 Then

        End If
    End Sub
    Sub LoadAvendor(Optional ByVal ThisVendor As String = "", Optional ByVal VendorName As String = "")
        Call ClearDate()
        Dim dt1 As DataTable = IIf(What = 0, DsFrmAllApPayMent1.View_AllVendorCreadit, DsFrmAllApPayMent1.inv_vendor)

        If dt1.Rows.Count > 0 Then
            If ThisVendor = "" Then
                ThisVendor = dt1.Rows(0).Item("cod_vendor")
            End If
            TxtVendorCod.Text = ThisVendor
            With DvDebit
                .Table = DsFrmAllApPayMent1.GridRecord
                .RowFilter = "Cod_Vendor =" & Qt(ThisVendor)
            End With
            TxtVendorName.Text = VendorName
            With DvCreadit
                .Table = DsFrmAllApPayMent1.GL_vendor_credit
                .RowFilter = "Cod_Vendor =" & Qt(ThisVendor)
            End With
            GrdCredit.Refresh()
            GrdDetail.Refresh()
            ClaculateSum(ThisVendor)
        End If

    End Sub
    Sub ClaculateSum(ByVal ThisVendor As String)
        Dim i As Integer = 0
        Dim amount1 As Decimal = 0
        Dim payment1 As Decimal = 0
        amount1 = Val("" & DsFrmAllApPayMent1.GridRecord.Compute("sum(AmountDue)", "Cod_Vendor =" & Qt(ThisVendor)))    '  amount1 + Val("" & .Item("AmountDue"))
        payment1 = Val("" & DsFrmAllApPayMent1.GridRecord.Compute("sum(AmountPay)", "Cod_Vendor =" & Qt(ThisVendor)))    'payment1 + Val("" & .Item("AmountPay"))
        LblSumAmountDue.Text = Math.Round(amount1, 2)
        LblSumPayment.Text = Math.Round(payment1, 2)
        LblCreadit.Text = Math.Round(Val("" & DsFrmAllApPayMent1.GL_vendor_credit.Compute("sum(amount_credit)", "Cod_Vendor =" & Qt(ThisVendor) & " and selected= true ")), 2)
        If Val(LblSumPayment.Text) > Val(LblCreadit.Text) And What = 0 Then
            LblError.Text = "Payment is more than credit"
        Else
            LblError.Text = ""
        End If
        'Next
    End Sub

    Function CanPassThisCreadit(ByVal ThisAmount As Decimal, ByVal ThisVendor As String) As Boolean
        Dim amount1 As Decimal = Val("" & DsFrmAllApPayMent1.GridRecord.Compute("sum(AmountDue)", "Cod_Vendor =" & Qt(ThisVendor)))
        Dim amount2 As Decimal = Val("" & DsFrmAllApPayMent1.GridRecord.Compute("sum(AmountPay)", "Cod_Vendor =" & Qt(ThisVendor)))
        If amount1 - amount2 >= ThisAmount Then
            CanPassThisCreadit = True
        Else
            CanPassThisCreadit = False
        End If
    End Function

    Function CanPassThisCreadit2(ByVal ThisAmount As Decimal, ByVal ThisVendor As String, Optional ByVal Reminder As Decimal = 0) As Boolean
        'Dim amount1 As Decimal = Val("" & DsFrmAllApPayMent1.GridRecord.Compute("sum(AmountDue)", "Cod_Vendor =" & Qt(ThisVendor)))
        Dim amount2 As Decimal = Val("" & DsFrmAllApPayMent1.GridRecord.Compute("sum(AmountPay)", "Cod_Vendor =" & Qt(ThisVendor)))
        Dim amount3 As Decimal = Val("" & DsFrmAllApPayMent1.credit_debit.Compute("sum(AmountPay)", "Cod_Vendor =" & Qt(ThisVendor)))
        If amount2 - amount3 >= ThisAmount Then
            CanPassThisCreadit2 = True
        Else
            CanPassThisCreadit2 = False
        End If
    End Function


#Region "Grid"
    Private Sub GrdDetail_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.CellUpdated
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        If Val("" & CurrentRow.Cells(8).Value) > Val("" & CurrentRow.Cells(6).Value) Then
            CurrentRow.Cells(8).Value = Math.Round(Val("" & CurrentRow.Cells(6).Value), 2)
        End If
        GrdDetail.UpdateData()
        ClaculateSum(TxtVendorCod.Text)

        CurrentRow = GrdDetail.GetRow()
        CurrentRow.BeginEdit()
        If Val(LblSumPayment.Text) > Val(LblCreadit.Text) And What = 0 Then
            GrdDetail.GetRow.Cells(8).Value = Math.Round(Val(LblCreadit.Text) - (Val(LblSumPayment.Text) - CurrentRow.Cells(8).Value), 2)
            'GrdDetail.UpdateData()
            ' GrdDetail.Col = 8
            Call ClaculateSum(TxtVendorCod.Text)
        End If
        'Dim ThisTableIDVar As Integer = CurrentRow.Cells("ID_AP_payment").Value
        If Val(CurrentRow.Cells(8).Value & "") = 0 Then
            CurrentRow.Cells(0).Value = False
            'DsFrmAllApPayMent1.GridRecord.Rows.Find(ThisTableIDVar).Item("CheckFlag") = 0
        Else
            CurrentRow.Cells(0).Value = True
            'DsFrmAllApPayMent1.GridRecord.Rows.Find(ThisTableIDVar).Item("CheckFlag") = 1
        End If
        CurrentRow.EndEdit()
        GrdDetail.UpdateData()
        GrdDetail.Col = 8
        ClaculateSum(TxtVendorCod.Text)
    End Sub
    Private Sub GrdDetail_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.CellValueChanged
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        Dim ThisTableIDVar As Integer = CurrentRow.Cells("ID_AP_payment").Value
        If ThisFormStatus = MainModule.WorkStates.AddNew Then
            Select Case e.Column.Index
                Case 0
                    If CurrentRow.Cells(0).Value = True Then
                        DsFrmAllApPayMent1.GridRecord.Rows.Find(ThisTableIDVar).Item("CheckFlag") = 0
                        DsFrmAllApPayMent1.GridRecord.Rows.Find(ThisTableIDVar).Item("AmountPay") = 0
                        CurrentRow.Cells(8).Value = 0
                    Else
                        DsFrmAllApPayMent1.GridRecord.Rows.Find(ThisTableIDVar).Item("CheckFlag") = 1
                        DsFrmAllApPayMent1.GridRecord.Rows.Find(ThisTableIDVar).Item("AmountPay") = Math.Round(Val("" & CurrentRow.Cells(6).Value), 2)
                        GrdDetail.GetRow.Cells(8).Value = Math.Round(Val("" & CurrentRow.Cells(6).Value), 2)
                        GrdDetail.UpdateData()
                        GrdDetail.Col = 8
                    End If
            End Select
        End If

        Call ClaculateSum(TxtVendorCod.Text)
        '    GrdDetail.Refetch()
    End Sub
    Private Sub GrdDetail_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.RecordUpdated
        Call EnableDisableSave()
    End Sub

#End Region
    Private Sub EnableDisableSave()
        BtnSave.Enabled = True
    End Sub
    Sub AddIdToTemp(ByVal id As Int64, ByVal AmountPay As Decimal, ByVal ThisVendor As String, ByVal ID_AP_payment As Int64)
        Dim dr1 As DataRow = DsFrmAllApPayMent1.credit_debit.Newcredit_debitRow
        dr1("id_vendor_credit") = id
        dr1("ID_AP_payment") = ID_AP_payment
        dr1("cod_vendor") = ThisVendor
        dr1("AmountPay") = AmountPay
        DsFrmAllApPayMent1.credit_debit.Addcredit_debitRow(dr1)
    End Sub
#Region "Auto Apply"
    Private Sub CmdAutoApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAutoApply.Click
        Dim ThisVendor As String = ""
        ThisVendor = TxtVendorCod.Text
        Dim payment1 As String = 0
        Call ClaculateSum(ThisVendor)
        Dim credit As Decimal = CDec(LblCreadit.Text)
        Dim amount1 As Decimal = CDec(LblSumAmountDue.Text)
        DsFrmAllApPayMent1.credit_debit.Clear()
        Call applyforThis(ThisVendor)
        GrdDetail.Refetch()
        ClaculateSum(TxtVendorCod.Text)
        EnableDisableSave()
    End Sub


    Private Sub CmdAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAll.Click
        Dim tmpj As Int64 = 0
        Dim vendorcod As String = ""
        DsFrmAllApPayMent1.credit_debit.Clear()
        Dim dt1 As DataTable = IIf(What = 0, DsFrmAllApPayMent1.View_AllVendorCreadit, DsFrmAllApPayMent1.inv_vendor)
        For tmpj = 0 To dt1.Rows.Count - 1
            If dt1.Rows(tmpj).Item("selected") = True Then
                vendorcod = dt1.Rows(tmpj).Item("cod_vendor") & ""
                Call LoadAvendor(vendorcod, dt1.Rows(tmpj).Item("desc_vendor") & "")
                TxtVendorCod.Tag = tmpj
                Call applyforThis(vendorcod)
            End If
        Next
        EnableDisableSave()
    End Sub
#End Region
#Region "next previous "
    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        Dim i1 As Int64 = 0
        Dim dt1 As DataTable = IIf(What = 0, DsFrmAllApPayMent1.View_AllVendorCreadit, DsFrmAllApPayMent1.inv_vendor)
        If TxtVendorCod.Tag > 0 And dt1.Rows.Count > 0 Then
            i1 = Val(TxtVendorCod.Tag & "") - 1
            Call LoadAvendor(dt1.Rows(i1).Item("cod_vendor"), dt1.Rows(i1).Item("desc_vendor") & "")
            TxtVendorCod.Tag = i1
        End If
    End Sub
    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        Call PFirst()
    End Sub
    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        Dim i1 As Int64 = Val(TxtVendorCod.Tag & "")
        Dim dt1 As DataTable = IIf(What = 0, DsFrmAllApPayMent1.View_AllVendorCreadit, DsFrmAllApPayMent1.inv_vendor)
        If dt1.Rows.Count - 1 > i1 Then
            i1 = Val(TxtVendorCod.Tag & "") + 1
            Call LoadAvendor(dt1.Rows(i1).Item("cod_vendor"), dt1.Rows(i1).Item("desc_vendor") & "")
            TxtVendorCod.Tag = i1
        End If
    End Sub

    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        Dim i1 As Int64 = 0
        Dim dt1 As DataTable = IIf(What = 0, DsFrmAllApPayMent1.View_AllVendorCreadit, DsFrmAllApPayMent1.inv_vendor)
        If dt1.Rows.Count > 0 Then
            i1 = dt1.Rows.Count - 1
            Call LoadAvendor(dt1.Rows(i1).Item("cod_vendor"), dt1.Rows(i1).Item("desc_vendor") & "")
            TxtVendorCod.Tag = i1
        End If
    End Sub

#End Region
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        GrdDetail.UpdateData()

        If CheckAllVendor() = False Then
            Exit Sub
        End If
        Dim tran1 As SqlClient.SqlTransaction
        tran1 = Cnn.BeginTransaction()
        CmdGeneral.Transaction = tran1
        Dim i As Integer = 0
        Dim j As Int64 = 0
        Dim k As Int64 = 0
        Dim CodVendor As String = ""
        Try
            Dim dt1 As DataTable = IIf(What = 0, DsFrmAllApPayMent1.View_AllVendorCreadit, DsFrmAllApPayMent1.inv_vendor)
            Dim id As Int64

            For j = 0 To dt1.Rows.Count - 1
                CodVendor = dt1.Rows(j).Item("cod_vendor")
                If dt1.Rows(j).Item("selected") = True Then
                    If What = 0 Then
                        Dim dr1 As DataRow() = DsFrmAllApPayMent1.credit_debit.Select("cod_vendor=" & Qt(CodVendor))
                        If dr1.LongLength > 0 Then
                            CmdGeneral.CommandText = "insert into GL_vendor_credit_head (date_pass) values (" & Qt(Format(Now.Date, PubDateFormat)) & " ) ; Select @@Identity from GL_vendor_credit_head"
                            id = CmdGeneral.ExecuteScalar()
                            For k = 0 To dr1.LongLength - 1
                                CmdGeneral.CommandText = "update GL_vendor_credit set id_vendor_credit_head= " & id & " where id_vendor_credit = " & dr1(k).Item("id_vendor_credit")
                                CmdGeneral.ExecuteNonQuery()
                                Dim dr3 As DsFrmAllApPayMent.GridRecordRow = DsFrmAllApPayMent1.GridRecord.FindByID_AP_payment(dr1(k).Item("ID_AP_payment"))
                                If Not dr3 Is Nothing Then
                                    dr3.id_vendor_credit_head = id
                                End If
                            Next
                        End If
                    Else
                        'CmdGeneral.CommandText = "insert into GL_vendor_credit_head (date_pass) values (" & Qt(Format(Now.Date, PubDateFormat)) & " ) ; Select @@Identity from GL_vendor_credit_head"
                        'id = CmdGeneral.ExecuteScalar()
                    End If
                    Dim dr2 As DataRow() = DsFrmAllApPayMent1.GridRecord.Select("cod_vendor=" & Qt(CodVendor))
                    '                Call LoadAvendor(CodVendor)
                    For i = 0 To dr2.Length - 1
                        With dr2(i)
                            If .Item("AmountPay") > 0 Then
                                Dim Id_AP_bill_dtl_dtl As Object = "Null"
                                Dim ID_Inv_Receive_product_Ap_Dtl As Object = "Null"
                                Dim id_service_center As Object = "Null"
                                Dim id_vendor_credit_head As Object = "NULL"
                                Dim Radif As Object = "Null"
                                Dim IDService_out_purchases_dtl As Object = "NULL"
                                Select Case .Item("RefrenceType")
                                    Case "BL"
                                        Id_AP_bill_dtl_dtl = .Item("Id_AP_bill_dtl_dtl")
                                    Case "RR"
                                        ID_Inv_Receive_product_Ap_Dtl = .Item("ID_Inv_Receive_product_Ap_Dtl")
                                    Case "OP"
                                        id_service_center = .Item("Refrenceno")
                                        Radif = .Item("Radif")
                                        IDService_out_purchases_dtl = .Item("IDService_out_purchases_dtl")
                                    Case Else
                                        MsgBox("error")
                                End Select
                                '  If Val("" & .Item("id_vendor_credit_head")) <> 0 Then
                                If What = 0 Then
                                    id_vendor_credit_head = id '.Item("id_vendor_credit_head")
                                Else
                                    id_vendor_credit_head = "Null"
                                End If

                                'Else
                                '   id_vendor_credit_head = "null"
                                'End If
                                If Math.Round(.Item("AmountPay"), 2) <= Math.Round(.Item("Amountdue"), 2) Then
                                    CmdGeneral.CommandText = "insert into GL_AP_payment (date_prepare,Id_AP_bill_dtl_dtl,ID_Inv_Receive_product_Ap_Dtl,id_service_center,radif,amount_pay,remark,id_vendor_credit_head,IDService_out_purchases_dtl) values (" & Qt(Format(Now.Date, PubDateFormat)) & "," & Id_AP_bill_dtl_dtl & "," & ID_Inv_Receive_product_Ap_Dtl & "," & Qt(id_service_center) & "," & Radif & "," & Math.Round(.Item("AmountPay"), 2) & "," & Qt(.Item("remark")) & " ," & id_vendor_credit_head & "," & IDService_out_purchases_dtl & ")"
                                    CmdGeneral.ExecuteNonQuery()
                                    .Item("AmountPay") = 0
                                End If
                            End If
                        End With
                    Next
                End If
            Next
            tran1.Commit()
            DsFrmAllApPayMent1.Clear()
            BtnPrint.Enabled = True
            Try
                Dim aa As New FrmPrintAllApPayment
                aa.flag = False
                aa.dateshow = Format(Now.Date, PubDateFormat)
                aa.FillDate()
                aa.CmbDate.Text = Format(Now.Date, PubDateFormat) 'TxtDueDate.Text
                aa.fillall(Format(Now.Date, PubDateFormat))
                aa.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            'Call ShowCustomers(True)
        Catch ex As Exception
            tran1.Rollback()
            MsgFar("error transaction roll backed")
            MsgBox(ex.ToString)
        End Try
        BtnPrint.Enabled = True
    End Sub
    Sub ClearDate()
        LblSumAmountDue.Text = 0
        LblSumPayment.Text = 0
        LblCreadit.Text = 0
    End Sub
    Private Sub FrmShowAllVendorsHaveCreadit1_AfterOk(ByVal DtView_AllVendorCreadit As DsFrmAllApPayMent.View_AllVendorCreaditDataTable, ByVal what1 As Integer) Handles FrmShowAllVendorsHaveCreadit1.AfterOk
        What = what1
        ' Label11.Text = "start"
        Call Ploadall()
        'Label11.Text = "Ploadall"
        Call DeleteUnTick()
        ' Label11.Text = "DeleteUnTick"
        Call PFirst()
        'Label11.Text = "PFirst"
        BtnPrint.Enabled = False
        TxtVendorCod.Tag = 0
        'Leftpanel.Size.Width = 100 ' Me.Size.Width - 10
        If DsFrmAllApPayMent1.GridRecord.Rows.Count = 0 Then
            MsgFar(" No Transaction Found")
        End If
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If DsFrmAllApPayMent1.GridRecord.Rows.Count > 0 Then
            Dim c1 As New FrmWhatDoForMenu
            c1.BtnLeftText = "Cancel"
            c1.BtnRightText = "Ok"
            c1.ShowFarMsg("This Form Has Data Do you Realy Want To Exit ?")
            If c1.DialogResult = DialogResult.OK Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If

    End Sub
    Sub applyforThis(ByVal ThisVendor As String)
        Dim j As Int64 = 0
        Dim k As Int64 = 0
        Dim reminder As Decimal = 0
        If What = 0 Then
            For k = 0 To DvDebit.Count - 1
                With DvDebit.Item(k)
                    .Item("AmountPay") = 0
                End With
            Next
            For k = 0 To DvCreadit.Count - 1
                If DvCreadit.Item(k).Item("selected") = True Then
                    reminder = DvCreadit.Item(k).Item("amount_credit")
                    Dim id As Decimal = DvCreadit.Item(k).Item("id_vendor_credit")
                    If CanPassThisCreadit(reminder, ThisVendor) Then
                        For j = 0 To DvDebit.Count - 1
                            With DvDebit.Item(j)
                                If .Item("AmountPay") < .Item("AmountDue") Then  'already pass with before amount ' or .Item("id_vendor_credit") <> null
                                    If .Item("AmountDue") <= reminder + .Item("AmountPay") Then
                                        reminder = reminder - (.Item("AmountDue") - .Item("AmountPay"))
                                        .Item("AmountPay") = Math.Round(.Item("AmountDue"), 2)
                                        .Item("CheckFlag") = 1
                                        .Item("id_vendor_credit") = id
                                        Call AddIdToTemp(id, .Item("AmountPay"), ThisVendor, .Item("ID_AP_payment"))
                                    Else
                                        If reminder > 0 Then
                                            If .Item("AmountDue") > .Item("AmountPay") + reminder Then
                                                'Dim r As Decimal = reminder
                                                .Item("AmountPay") = Math.Round(reminder, 2) + .Item("AmountPay")
                                                .Item("CheckFlag") = 1
                                                reminder = reminder - .Item("AmountPay")
                                                .Item("id_vendor_credit") = id
                                                Call AddIdToTemp(id, .Item("AmountPay"), ThisVendor, .Item("ID_AP_payment"))
                                            Else
                                                .Item("AmountPay") = Math.Round(reminder, 2)
                                                .Item("CheckFlag") = 1
                                                .Item("id_vendor_credit") = id
                                                reminder = 0
                                                Call AddIdToTemp(id, .Item("AmountPay"), ThisVendor, .Item("ID_AP_payment"))
                                            End If
                                        End If
                                    End If
                                End If
                            End With
                        Next
                    End If
                    DvCreadit.Item(k).Item("Reminder") = reminder
                End If
            Next
        Else
            For j = 0 To DvDebit.Count - 1
                With DvDebit.Item(j)
                    'reminder = reminder - (.Item("AmountDue") - .Item("AmountPay"))
                    .Item("AmountPay") = Math.Round(.Item("AmountDue"), 2)
                    .Item("CheckFlag") = 1
                End With
            Next
        End If
        '    GrdDetail.Refetch()
    End Sub

    Function CheckAllVendor() As Boolean
        If What = 1 Then
            CheckAllVendor = True
        Else
            Dim j As Int64 = 0
            Dim k As Int64 = 0
            Dim tmpj As Int64 = 0
            Dim reminder As Decimal = 0
            Dim VendorCod As String
            DsFrmAllApPayMent1.credit_debit.Clear()
            Dim dt1 As DataTable = IIf(What = 0, DsFrmAllApPayMent1.View_AllVendorCreadit, DsFrmAllApPayMent1.inv_vendor)

            For tmpj = 0 To dt1.Rows.Count - 1
                If dt1.Rows(tmpj).Item("selected") = True Then
                    VendorCod = dt1.Rows(tmpj).Item("cod_vendor") & ""
                    With DvCreadit
                        .Table = DsFrmAllApPayMent1.GL_vendor_credit
                        .RowFilter = "Cod_Vendor =" & Qt(VendorCod)
                    End With
                    With DvDebit
                        .Table = DsFrmAllApPayMent1.GridRecord
                        .RowFilter = "Cod_Vendor =" & Qt(VendorCod)
                    End With
                    CheckAllVendor = CheckThisVendor(VendorCod)
                End If
            Next

        End If
    End Function
    Function CheckThisVendor(ByVal THisVendor As String) As Boolean
        If What = 1 Then
            CheckThisVendor = True
            Exit Function
        End If
        Dim j As Int64 = 0
        Dim k As Int64 = 0
        Dim reminderCredit As Decimal = 0
        Dim ReminderDebit As Decimal = 0
        For k = 0 To DvDebit.Count - 1
            With DvDebit.Item(k)
                .Item("passbefor") = False
            End With
        Next
        For k = 0 To DvCreadit.Count - 1
            With DvCreadit.Item(k)
                .Item("partialOrComplitepass") = False
            End With
        Next
        '--------------------------------------
        For k = 0 To DvCreadit.Count - 1
            If DvCreadit(k).Item("selected") = True Then
                reminderCredit = DvCreadit.Item(k).Item("amount_credit") + reminderCredit
                Dim id As Decimal = DvCreadit.Item(k).Item("id_vendor_credit")
                If CanPassThisCreadit2(DvCreadit.Item(k).Item("amount_credit"), THisVendor, ReminderDebit) Then
                    DvCreadit.Item(k).Item("partialOrComplitepass") = True
                    For j = 0 To DvDebit.Count - 1
                        With DvDebit.Item(j)
                            ReminderDebit = ReminderDebit + .Item("AmountPay")
                            If reminderCredit >= ReminderDebit Then
                                reminderCredit = reminderCredit - (ReminderDebit)
                                Call AddIdToTemp(id, ReminderDebit, THisVendor, .Item("ID_AP_payment"))
                                ReminderDebit = 0
                            Else
                                ' reminderCredit = 0
                                ReminderDebit = ReminderDebit - reminderCredit '.Item("AmountPay")
                                Call AddIdToTemp(id, reminderCredit, THisVendor, .Item("ID_AP_payment"))
                                reminderCredit = 0
                                Exit For
                            End If



                            'If .Item("AmountPay") + ReminderDebit >= reminderCredit Then
                            '    ReminderDebit = .Item("AmountPay") - reminderCredit
                            '    .Item("passbefor") = True
                            '    Call AddIdToTemp(id, .Item("AmountPay"), THisVendor, .Item("ID_AP_payment"))
                            'Else ' AmountPay + ReminderDebit < reminderCredit
                            '    ReminderDebit = 0
                            '    .Item("passbefor") = True
                            '    Call AddIdToTemp(id, .Item("AmountPay"), THisVendor, .Item("ID_AP_payment"))
                            'End If



                            'If .Item("AmountPay") < .Item("AmountDue") Then  'already pass with before amount ' or .Item("id_vendor_credit") <> null
                            '    If .Item("AmountDue") <= reminderCredit + .Item("AmountPay") Then
                            '        reminderCredit = reminderCredit - (.Item("AmountDue") - .Item("AmountPay"))
                            '        .Item("AmountPay") = Math.Round(.Item("AmountDue"), 2)
                            '        .Item("id_vendor_credit") = id
                            '        Call AddIdToTemp(id, .Item("AmountPay"), THisVendor, .Item("ID_AP_payment"))
                            '    Else
                            '        If reminderCredit > 0 Then
                            '            If .Item("AmountDue") > .Item("AmountPay") + reminderCredit Then
                            '                'Dim r As Decimal = reminder
                            '                .Item("AmountPay") = Math.Round(reminderCredit, 2) + .Item("AmountPay")
                            '                reminderCredit = reminderCredit - .Item("AmountPay")
                            '                .Item("id_vendor_credit") = id
                            '                Call AddIdToTemp(id, .Item("AmountPay"), THisVendor, .Item("ID_AP_payment"))
                            '            Else
                            '                .Item("AmountPay") = Math.Round(reminderCredit, 2)
                            '                .Item("id_vendor_credit") = id
                            '                reminderCredit = 0
                            '                Call AddIdToTemp(id, .Item("AmountPay"), THisVendor, .Item("ID_AP_payment"))
                            '            End If
                            '        End If
                            '    End If
                            'End If
                        End With
                    Next
                Else
                    reminderCredit = reminderCredit - DvCreadit.Item(k).Item("amount_credit")
                End If
            End If
        Next
        '--------------------------------------------------
        'For k = 0 To DvCreadit.Count - 1
        '    With DvCreadit.Item(k)
        '        Dim id_vendor_credit As Int64 = DvCreadit.Item(k).Item("id_vendor_credit")
        '        If .Item("partialOrComplitepass") = True Then
        '            Dim sum1 As Decimal = DsFrmAllApPayMent1.credit_debit.Compute("sum(AmountPay)", " id_vendor_credit= " & id_vendor_credit & " and cod_vendor=" & Qt(THisVendor))
        '            If sum1 <> DvCreadit.Item(k).Item("amount_credit") Then
        '                MsgFar("vendor " & DvCreadit.Item(k).Item("cod_vendor") & "Has a problenm in debit credit passing")
        '            End If
        '        End If
        '    End With
        'Next
        '--------------------------------------------------
        Dim sum1 As Decimal = Val("" & DsFrmAllApPayMent1.credit_debit.Compute("sum(AmountPay)", " cod_vendor= " & Qt(THisVendor)))
        Dim sum2 As Decimal = Val("" & DsFrmAllApPayMent1.GL_vendor_credit.Compute("sum(amount_credit)", "partialOrComplitepass =1 and cod_vendor= " & Qt(THisVendor)))
        Dim sum3 As Decimal = Val("" & DsFrmAllApPayMent1.GridRecord.Compute("sum(AmountPay)", "cod_vendor= " & Qt(THisVendor)))
        '----------
        If sum1 <> sum3 Then
            MsgFar(" Unable To Apply Credits To Debits For Vendor" & " ( " & THisVendor & " ) ")
            CheckThisVendor = False
        Else
            CheckThisVendor = True
        End If
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DsFrmAllApPayMent1.credit_debit.Clear()
        Call CheckThisVendor(TxtVendorCod.Text)
    End Sub

    Sub PFirst()
        Dim i1 As Int64 = 0
        Dim dt1 As DataTable = IIf(What = 0, DsFrmAllApPayMent1.View_AllVendorCreadit, DsFrmAllApPayMent1.inv_vendor)
        If dt1.Rows.Count > 0 Then
            i1 = 0
            Call LoadAvendor(dt1.Rows(i1).Item("cod_vendor"), dt1.Rows(i1).Item("desc_vendor") & "")
            TxtVendorCod.Tag = i1
        End If
    End Sub
    Sub DeleteUnTick()
        Dim i As Int64 = 0
        GrdCredit.SuspendLayout()
        GrdDetail.SuspendLayout()
        Dim dt1 As DataTable = IIf(What = 0, DsFrmAllApPayMent1.View_AllVendorCreadit, DsFrmAllApPayMent1.inv_vendor)
        '        If What = 1 Then
        Dim count As Int64 = dt1.Rows.Count
        For i = 0 To count - 1
            Try
                If dt1.Rows(i).Item("selected") = False Then
                    dt1.Rows(i).Delete()
                End If
            Catch ex As Exception
            End Try
        Next
        dt1.AcceptChanges()
        GrdCredit.ResumeLayout()
        GrdDetail.ResumeLayout()

        '       End If
    End Sub
    Private Sub TxtDueDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDueDate.TextChanged
        DsFrmAllApPayMent1.Clear()
        BtnPrint.Enabled = True
    End Sub

    Private Sub GrdDetail_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GrdDetail.FormattingRow

    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Try
            Dim FrmPrintAllApPayment1 As New FrmPrintAllApPayment
            With FrmPrintAllApPayment1
                .TopLevel = False
                '.Parent = Me.Parent
                '.IsMdiChild = True
                .MdiParent = Me.MdiParent

                .StartPosition = FormStartPosition.Manual
                .Top = 10
                .Left = 10
                .Show()
                .BringToFront()
            End With
            
            'MyFrmReciept.TopLevel = False
            '        'MyFrmReciept.Parent = Me.Parent
            '        'MyFrmReciept.ThisFormStatus = MainModule.WorkStates._ReadOnly
            '        'MyFrmReciept.InvCodeParam = InvCode1.Text
            '        'MyFrmReciept.Resid_NoParam = Currentrow.Cells(2).Value
            '        'MyFrmReciept.Show()
            '        'MyFrmReciept.BringToFront()
            '    aa.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function FindSumreceive(ByVal thisreceive) As Decimal
        Try
            Dim a As New DataSet
            DaFindSumOrginalRecevie.SelectCommand.Parameters(0).Value = thisreceive
            DaFindSumOrginalRecevie.Fill(a, "t1")
            If a.Tables("t1").Rows.Count > 0 Then
                FindSumreceive = a.Tables("t1").Rows(0).Item(0)
            Else
                FindSumreceive = 0
            End If

        Catch ex As Exception
            FindSumreceive = 0
        End Try

    End Function

    Private Sub GrdCredit_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdCredit.CellValueChanged

        If e.Column.Index = 0 Then
            GrdCredit.UpdateData()
            ' Dim id As Int64 = GrdCredit.GetRow.Cells(4).Value
            ' DsFrmAllApPayMent1.GL_vendor_credit.FindByid_vendor_credit(id).selected = GrdCredit.GetRow.Cells(0).Value
            ClaculateSum(TxtVendorCod.Text)
        End If

        'Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        'Dim ThisTableIDVar As Integer = CurrentRow.Cells("ID_AP_payment").Value
        'If CurrentRow.Cells(0).Value = True Then
        '    DsFrmAllApPayMent1.GridRecord.Rows.Find(ThisTableIDVar).Item("CheckFlag") = 0
        '    DsFrmAllApPayMent1.GridRecord.Rows.Find(ThisTableIDVar).Item("AmountPay") = 0
        '    CurrentRow.Cells(8).Value = 0
        'Else
        '    DsFrmAllApPayMent1.GridRecord.Rows.Find(ThisTableIDVar).Item("CheckFlag") = 1
        '    DsFrmAllApPayMent1.GridRecord.Rows.Find(ThisTableIDVar).Item("AmountPay") = Math.Round(Val("" & CurrentRow.Cells(6).Value), 2)
        '    GrdDetail.GetRow.Cells(8).Value = Math.Round(Val("" & CurrentRow.Cells(6).Value), 2)
        '    GrdDetail.UpdateData()
        '    GrdDetail.Col = 8
        'End If
        '    End Select
        'End If


    End Sub
End Class
