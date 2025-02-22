Imports CommonClass
Public Class FrmShowItemsForPo2
    Inherits CommonClass.FrmBase

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
    Friend WithEvents DsFrmPurchaseOrderItems1 As UcPurchaseOrder.DSFrmPurchaseOrderItems
    Friend WithEvents GrdSelect As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CmdSelectAll As System.Windows.Forms.Button
    Friend WithEvents CmdUnselectAll As System.Windows.Forms.Button
    Friend WithEvents CmdOk As System.Windows.Forms.Button
    Friend WithEvents BtnDeselect As System.Windows.Forms.Button
    Friend WithEvents BtnFchooser As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSelect As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnEmail As System.Windows.Forms.Button
    Friend WithEvents BtnJPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmShowItemsForPo2))
        Me.DsFrmPurchaseOrderItems1 = New UcPurchaseOrder.DSFrmPurchaseOrderItems
        Me.GrdSelect = New Janus.Windows.GridEX.GridEX
        Me.CmdSelectAll = New System.Windows.Forms.Button
        Me.CmdUnselectAll = New System.Windows.Forms.Button
        Me.CmdOk = New System.Windows.Forms.Button
        Me.CmdCancel = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.BtnDeselect = New System.Windows.Forms.Button
        Me.BtnFchooser = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnSelect = New System.Windows.Forms.Button
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.BtnEmail = New System.Windows.Forms.Button
        Me.BtnJPrint = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        CType(Me.DsFrmPurchaseOrderItems1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsFrmPurchaseOrderItems1
        '
        Me.DsFrmPurchaseOrderItems1.DataSetName = "DSFrmPurchaseOrderItems"
        Me.DsFrmPurchaseOrderItems1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GrdSelect
        '
        Me.GrdSelect.AlternatingColors = True
        Me.GrdSelect.DataMember = "inv_item"
        Me.GrdSelect.DataSource = Me.DsFrmPurchaseOrderItems1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_head</Caption><Columns Colle" & _
        "ction=""true""><Column0 ID=""selected""><ColumnType>CheckBox</ColumnType><DataMember" & _
        ">selected</DataMember><EditType>CheckBox</EditType><Key>selected</Key><Position>" & _
        "0</Position><Width>34</Width></Column0><Column1 ID=""complete_desc_brand""><Captio" & _
        "n>Brand</Caption><DataMember>complete_desc_brand</DataMember><EditType>NoEdit</E" & _
        "ditType><FilterEditType>Combo</FilterEditType><Key>complete_desc_brand</Key><Pos" & _
        "ition>1</Position><Width>87</Width></Column1><Column2 ID=""line""><Caption>Line</C" & _
        "aption><DataMember>line</DataMember><EditType>NoEdit</EditType><FilterEditType>C" & _
        "ombo</FilterEditType><Key>line</Key><Position>2</Position><Width>92</Width></Col" & _
        "umn2><Column3 ID=""cod_select""><Caption>Item No</Caption><DataMember>cod_select</" & _
        "DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><K" & _
        "ey>cod_select</Key><Position>3</Position><Width>73</Width></Column3><Column4 ID=" & _
        """desc_item""><Caption>Description</Caption><DataMember>desc_item</DataMember><Edi" & _
        "tType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>desc_item</K" & _
        "ey><Position>4</Position><Width>116</Width></Column4><Column5 ID=""min_stock""><Ca" & _
        "ption>Min Stock Qty</Caption><DataMember>min_stock</DataMember><Key>min_stock</K" & _
        "ey><Position>5</Position><Width>82</Width></Column5><Column6 ID=""on_hand""><Capti" & _
        "on>QTY On Hand</Caption><DataMember>on_hand</DataMember><Key>on_hand</Key><Posit" & _
        "ion>6</Position><Width>85</Width></Column6><Column7 ID=""qtyOrder""><Caption>Order" & _
        " QTY</Caption><DataMember>qtyOrder</DataMember><FilterEditType>TextBox</FilterEd" & _
        "itType><InputMask>####</InputMask><Key>qtyOrder</Key><MaskPrompt>&#x0;</MaskProm" & _
        "pt><Position>7</Position><Width>69</Width></Column7><Column8 ID=""qtyReOrder""><Ca" & _
        "ption>Reorder QTY</Caption><DataMember>qtyReOrder</DataMember><EditType>NoEdit</" & _
        "EditType><InputMask>####</InputMask><Key>qtyReOrder</Key><MaskPrompt>&#x0;</Mask" & _
        "Prompt><Position>8</Position><Width>82</Width></Column8><Column9 ID=""cost""><Capt" & _
        "ion>Unit Cost</Caption><TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue>" & _
        "<EmptyStringValue /><DataMember>cost</DataMember><EditType>NoEdit</EditType><Fil" & _
        "terEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>cost</Ke" & _
        "y><Position>9</Position><Width>70</Width></Column9><Column10 ID=""fet""><Caption>F" & _
        "et</Caption><DataMember>fet</DataMember><EditType>NoEdit</EditType><FilterEditTy" & _
        "pe>TextBox</FilterEditType><FormatString>c2</FormatString><Key>fet</Key><Positio" & _
        "n>10</Position><Width>67</Width></Column10><Column11 ID=""ExCost""><Caption>Ext.Co" & _
        "st</Caption><DataMember>ExCost</DataMember><EditType>NoEdit</EditType><FilterEdi" & _
        "tType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>ExCost</Key><P" & _
        "osition>11</Position><Width>84</Width></Column11></Columns><GroupCondition ID=""""" & _
        " /><Key>service_center_head</Key></RootTable></GridEXLayoutData>"
        Me.GrdSelect.DesignTimeLayout = GridEXLayout1
        Me.GrdSelect.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdSelect.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdSelect.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters
        Me.GrdSelect.Location = New System.Drawing.Point(0, 72)
        Me.GrdSelect.Name = "GrdSelect"
        Me.GrdSelect.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdSelect.Size = New System.Drawing.Size(1000, 344)
        Me.GrdSelect.TabIndex = 0
        '
        'CmdSelectAll
        '
        Me.CmdSelectAll.Location = New System.Drawing.Point(8, 426)
        Me.CmdSelectAll.Name = "CmdSelectAll"
        Me.CmdSelectAll.TabIndex = 1
        Me.CmdSelectAll.Text = "Select All"
        '
        'CmdUnselectAll
        '
        Me.CmdUnselectAll.Location = New System.Drawing.Point(104, 426)
        Me.CmdUnselectAll.Name = "CmdUnselectAll"
        Me.CmdUnselectAll.TabIndex = 2
        Me.CmdUnselectAll.Text = "UnSelect All"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(827, 424)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.TabIndex = 3
        Me.CmdOk.Text = "Ok"
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(915, 424)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.TabIndex = 4
        Me.CmdCancel.Text = "Cancel"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BtnDeselect)
        Me.Panel4.Controls.Add(Me.BtnFchooser)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.BtnSelect)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.BtnEmail)
        Me.Panel4.Controls.Add(Me.BtnJPrint)
        Me.Panel4.Controls.Add(Me.BtnPrint)
        Me.Panel4.Controls.Add(Me.BtnPreview)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1006, 64)
        Me.Panel4.TabIndex = 10
        '
        'BtnDeselect
        '
        Me.BtnDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeselect.Image = CType(resources.GetObject("BtnDeselect.Image"), System.Drawing.Image)
        Me.BtnDeselect.Location = New System.Drawing.Point(712, 1)
        Me.BtnDeselect.Name = "BtnDeselect"
        Me.BtnDeselect.Size = New System.Drawing.Size(33, 27)
        Me.BtnDeselect.TabIndex = 219
        '
        'BtnFchooser
        '
        Me.BtnFchooser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFchooser.Image = CType(resources.GetObject("BtnFchooser.Image"), System.Drawing.Image)
        Me.BtnFchooser.Location = New System.Drawing.Point(968, 1)
        Me.BtnFchooser.Name = "BtnFchooser"
        Me.BtnFchooser.Size = New System.Drawing.Size(33, 27)
        Me.BtnFchooser.TabIndex = 218
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(960, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 217
        Me.Label3.Text = "Field  Chooser"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(704, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 23)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "Deselect All"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSelect
        '
        Me.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.Location = New System.Drawing.Point(712, 1)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(33, 27)
        Me.BtnSelect.TabIndex = 215
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(912, 33)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(43, 25)
        Me.Label31.TabIndex = 214
        Me.Label31.Text = "Send to Excel"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(864, 33)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 24)
        Me.Label30.TabIndex = 213
        Me.Label30.Text = "Grid Print"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(816, 33)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 212
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(752, 33)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 211
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEmail
        '
        Me.BtnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEmail.Image = CType(resources.GetObject("BtnEmail.Image"), System.Drawing.Image)
        Me.BtnEmail.Location = New System.Drawing.Point(920, 1)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 210
        '
        'BtnJPrint
        '
        Me.BtnJPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnJPrint.Image = CType(resources.GetObject("BtnJPrint.Image"), System.Drawing.Image)
        Me.BtnJPrint.Location = New System.Drawing.Point(864, 1)
        Me.BtnJPrint.Name = "BtnJPrint"
        Me.BtnJPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnJPrint.TabIndex = 209
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(816, 1)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 208
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(760, 1)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 207
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(96, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Your Items and Press Ok To Make Your Peurchase Order"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(22, 29)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'FrmShowItemsForPo2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1006, 460)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdUnselectAll)
        Me.Controls.Add(Me.CmdSelectAll)
        Me.Controls.Add(Me.GrdSelect)
        Me.Name = "FrmShowItemsForPo2"
        Me.Text = "Select Items To Reorder"
        CType(Me.DsFrmPurchaseOrderItems1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim i As Integer = 0
    Public Event AddThis(ByVal ItemNo As String, ByVal ThisQty As Decimal)
    Public Event ClearDataSet()
    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub
    Private Sub CmdSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSelectAll.Click
        For i = 0 To GrdSelect.RowCount - 1
            GrdSelect.Row = i
            GrdSelect.GetRow(i).Cells(0).Value = True
        Next
    End Sub

    Private Sub CmdUnselectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdUnselectAll.Click
        For i = 0 To GrdSelect.RowCount - 1
            GrdSelect.Row = i
            GrdSelect.GetRow(i).Cells(0).Value = False
        Next
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        RaiseEvent ClearDataSet()
        For i = 0 To GrdSelect.RowCount - 1
            GrdSelect.Row = i
            If GrdSelect.GetRow.Cells(0).Value = True Then
                RaiseEvent AddThis(GrdSelect.GetRow.Cells(3).Value & "", Val(GrdSelect.GetRow.Cells(7).Value & ""))
            End If
        Next
        Me.Close()
    End Sub
    Private Sub BtnFchooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFchooser.Click
        Me.GrdSelect.ShowFieldChooser(Me)
    End Sub

    Private Sub BtnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmail.Click
        Dim FileName As String
        If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If
        FileName = "reportItemForPo.CSV"
        Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdSelect)
    End Sub

    Private Sub BtnJPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJPrint.Click
        GridEXPrintDocument1.GridEX = GrdSelect
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub BtnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeselect.Click
        For i = 0 To GrdSelect.RowCount - 1
            GrdSelect.Row = i
            GrdSelect.GetRow(i).Cells(0).Value = False
        Next
    End Sub
    Private Sub GrdSelect_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GrdSelect.FormattingRow

    End Sub

    Private Sub FrmShowItemsForPo2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Call print(1)
    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Call print(2)
    End Sub

    Sub print(ByVal what As Integer)
        Dim rpt As New RptShowItemForPo2
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")
        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetDataSource(DsFrmPurchaseOrderItems1)
        Select Case what
            Case 1
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try
            Case 2
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
        End Select


    End Sub


End Class
