Imports CommonClass
Public Class FrmImportData
    Inherits FrmBase

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
    Friend WithEvents BtnBrand As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtBrandPath As System.Windows.Forms.TextBox
    Friend WithEvents TxtCategoryPath As System.Windows.Forms.TextBox
    Friend WithEvents BtnCategory As System.Windows.Forms.Button
    Friend WithEvents txtCustomerPath As System.Windows.Forms.TextBox
    Friend WithEvents BtnCustomer As System.Windows.Forms.Button
    Friend WithEvents txtStylePath As System.Windows.Forms.TextBox
    Friend WithEvents BtnStylePath As System.Windows.Forms.Button
    Friend WithEvents txtLinePath As System.Windows.Forms.TextBox
    Friend WithEvents BtnLine As System.Windows.Forms.Button
    Friend WithEvents txtServicePath As System.Windows.Forms.TextBox
    Friend WithEvents BtnService As System.Windows.Forms.Button
    Friend WithEvents TxtVehiclePath As System.Windows.Forms.TextBox
    Friend WithEvents BtnVehicle As System.Windows.Forms.Button
    Friend WithEvents txtItemPath As System.Windows.Forms.TextBox
    Friend WithEvents BtnItem As System.Windows.Forms.Button
    Friend WithEvents txtPriceCode As System.Windows.Forms.TextBox
    Friend WithEvents BtnPriceCode As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnImport As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtVendor As System.Windows.Forms.TextBox
    Friend WithEvents btnVendor As System.Windows.Forms.Button
    Friend WithEvents cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents command As System.Data.SqlClient.SqlCommand
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrBrand As System.Windows.Forms.ProgressBar
    Friend WithEvents PrCategory As System.Windows.Forms.ProgressBar
    Friend WithEvents PrStyle As System.Windows.Forms.ProgressBar
    Friend WithEvents PrLine As System.Windows.Forms.ProgressBar
    Friend WithEvents PrCustomer As System.Windows.Forms.ProgressBar
    Friend WithEvents PrVendor As System.Windows.Forms.ProgressBar
    Friend WithEvents PrService As System.Windows.Forms.ProgressBar
    Friend WithEvents PrVehicle As System.Windows.Forms.ProgressBar
    Friend WithEvents PrItem As System.Windows.Forms.ProgressBar
    Friend WithEvents PrPrice As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmImportData))
        Me.BtnBrand = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txtBrandPath = New System.Windows.Forms.TextBox
        Me.TxtCategoryPath = New System.Windows.Forms.TextBox
        Me.BtnCategory = New System.Windows.Forms.Button
        Me.txtCustomerPath = New System.Windows.Forms.TextBox
        Me.BtnCustomer = New System.Windows.Forms.Button
        Me.txtStylePath = New System.Windows.Forms.TextBox
        Me.BtnStylePath = New System.Windows.Forms.Button
        Me.txtLinePath = New System.Windows.Forms.TextBox
        Me.BtnLine = New System.Windows.Forms.Button
        Me.txtVendor = New System.Windows.Forms.TextBox
        Me.btnVendor = New System.Windows.Forms.Button
        Me.txtServicePath = New System.Windows.Forms.TextBox
        Me.BtnService = New System.Windows.Forms.Button
        Me.TxtVehiclePath = New System.Windows.Forms.TextBox
        Me.BtnVehicle = New System.Windows.Forms.Button
        Me.txtItemPath = New System.Windows.Forms.TextBox
        Me.BtnItem = New System.Windows.Forms.Button
        Me.txtPriceCode = New System.Windows.Forms.TextBox
        Me.BtnPriceCode = New System.Windows.Forms.Button
        Me.BtnImport = New System.Windows.Forms.Button
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cnn = New System.Data.SqlClient.SqlConnection
        Me.command = New System.Data.SqlClient.SqlCommand
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Label1 = New System.Windows.Forms.Label
        Me.PrBrand = New System.Windows.Forms.ProgressBar
        Me.PrCategory = New System.Windows.Forms.ProgressBar
        Me.PrStyle = New System.Windows.Forms.ProgressBar
        Me.PrLine = New System.Windows.Forms.ProgressBar
        Me.PrCustomer = New System.Windows.Forms.ProgressBar
        Me.PrVendor = New System.Windows.Forms.ProgressBar
        Me.PrService = New System.Windows.Forms.ProgressBar
        Me.PrVehicle = New System.Windows.Forms.ProgressBar
        Me.PrItem = New System.Windows.Forms.ProgressBar
        Me.PrPrice = New System.Windows.Forms.ProgressBar
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBrand
        '
        Me.BtnBrand.Location = New System.Drawing.Point(70, 444)
        Me.BtnBrand.Name = "BtnBrand"
        Me.BtnBrand.Size = New System.Drawing.Size(363, 85)
        Me.BtnBrand.TabIndex = 0
        Me.BtnBrand.Text = "Brand"
        '
        'txtBrandPath
        '
        Me.txtBrandPath.Location = New System.Drawing.Point(510, 456)
        Me.txtBrandPath.Name = "txtBrandPath"
        Me.txtBrandPath.Size = New System.Drawing.Size(1133, 32)
        Me.txtBrandPath.TabIndex = 1
        Me.txtBrandPath.Text = ""
        '
        'TxtCategoryPath
        '
        Me.TxtCategoryPath.Location = New System.Drawing.Point(510, 569)
        Me.TxtCategoryPath.Name = "TxtCategoryPath"
        Me.TxtCategoryPath.Size = New System.Drawing.Size(1133, 32)
        Me.TxtCategoryPath.TabIndex = 3
        Me.TxtCategoryPath.Text = ""
        '
        'BtnCategory
        '
        Me.BtnCategory.Location = New System.Drawing.Point(70, 569)
        Me.BtnCategory.Name = "BtnCategory"
        Me.BtnCategory.Size = New System.Drawing.Size(363, 85)
        Me.BtnCategory.TabIndex = 2
        Me.BtnCategory.Text = "Category"
        '
        'txtCustomerPath
        '
        Me.txtCustomerPath.Location = New System.Drawing.Point(510, 923)
        Me.txtCustomerPath.Name = "txtCustomerPath"
        Me.txtCustomerPath.Size = New System.Drawing.Size(1133, 32)
        Me.txtCustomerPath.TabIndex = 5
        Me.txtCustomerPath.Text = ""
        '
        'BtnCustomer
        '
        Me.BtnCustomer.Location = New System.Drawing.Point(70, 908)
        Me.BtnCustomer.Name = "BtnCustomer"
        Me.BtnCustomer.Size = New System.Drawing.Size(363, 84)
        Me.BtnCustomer.TabIndex = 4
        Me.BtnCustomer.Text = "Customer"
        '
        'txtStylePath
        '
        Me.txtStylePath.Location = New System.Drawing.Point(510, 692)
        Me.txtStylePath.Name = "txtStylePath"
        Me.txtStylePath.Size = New System.Drawing.Size(1133, 32)
        Me.txtStylePath.TabIndex = 7
        Me.txtStylePath.Text = ""
        '
        'BtnStylePath
        '
        Me.BtnStylePath.Location = New System.Drawing.Point(70, 677)
        Me.BtnStylePath.Name = "BtnStylePath"
        Me.BtnStylePath.Size = New System.Drawing.Size(363, 86)
        Me.BtnStylePath.TabIndex = 6
        Me.BtnStylePath.Text = "Style"
        '
        'txtLinePath
        '
        Me.txtLinePath.Location = New System.Drawing.Point(510, 812)
        Me.txtLinePath.Name = "txtLinePath"
        Me.txtLinePath.Size = New System.Drawing.Size(1133, 32)
        Me.txtLinePath.TabIndex = 9
        Me.txtLinePath.Text = ""
        '
        'BtnLine
        '
        Me.BtnLine.Location = New System.Drawing.Point(70, 800)
        Me.BtnLine.Name = "BtnLine"
        Me.BtnLine.Size = New System.Drawing.Size(363, 85)
        Me.BtnLine.TabIndex = 8
        Me.BtnLine.Text = "Line"
        '
        'txtVendor
        '
        Me.txtVendor.Location = New System.Drawing.Point(510, 1042)
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Size = New System.Drawing.Size(1133, 32)
        Me.txtVendor.TabIndex = 11
        Me.txtVendor.Text = ""
        '
        'btnVendor
        '
        Me.btnVendor.Location = New System.Drawing.Point(70, 1031)
        Me.btnVendor.Name = "btnVendor"
        Me.btnVendor.Size = New System.Drawing.Size(363, 84)
        Me.btnVendor.TabIndex = 10
        Me.btnVendor.Text = "Vendor"
        '
        'txtServicePath
        '
        Me.txtServicePath.Location = New System.Drawing.Point(510, 1169)
        Me.txtServicePath.Name = "txtServicePath"
        Me.txtServicePath.Size = New System.Drawing.Size(1133, 32)
        Me.txtServicePath.TabIndex = 13
        Me.txtServicePath.Text = ""
        '
        'BtnService
        '
        Me.BtnService.Location = New System.Drawing.Point(70, 1158)
        Me.BtnService.Name = "BtnService"
        Me.BtnService.Size = New System.Drawing.Size(363, 84)
        Me.BtnService.TabIndex = 12
        Me.BtnService.Text = "Service"
        '
        'TxtVehiclePath
        '
        Me.TxtVehiclePath.Location = New System.Drawing.Point(510, 1292)
        Me.TxtVehiclePath.Name = "TxtVehiclePath"
        Me.TxtVehiclePath.Size = New System.Drawing.Size(1133, 32)
        Me.TxtVehiclePath.TabIndex = 15
        Me.TxtVehiclePath.Text = ""
        '
        'BtnVehicle
        '
        Me.BtnVehicle.Location = New System.Drawing.Point(70, 1277)
        Me.BtnVehicle.Name = "BtnVehicle"
        Me.BtnVehicle.Size = New System.Drawing.Size(363, 85)
        Me.BtnVehicle.TabIndex = 14
        Me.BtnVehicle.Text = "Vehicle"
        '
        'txtItemPath
        '
        Me.txtItemPath.Location = New System.Drawing.Point(510, 1412)
        Me.txtItemPath.Name = "txtItemPath"
        Me.txtItemPath.Size = New System.Drawing.Size(1133, 32)
        Me.txtItemPath.TabIndex = 17
        Me.txtItemPath.Text = ""
        '
        'BtnItem
        '
        Me.BtnItem.Location = New System.Drawing.Point(70, 1400)
        Me.BtnItem.Name = "BtnItem"
        Me.BtnItem.Size = New System.Drawing.Size(363, 85)
        Me.BtnItem.TabIndex = 16
        Me.BtnItem.Text = "Item"
        '
        'txtPriceCode
        '
        Me.txtPriceCode.Location = New System.Drawing.Point(510, 1535)
        Me.txtPriceCode.Name = "txtPriceCode"
        Me.txtPriceCode.Size = New System.Drawing.Size(1133, 32)
        Me.txtPriceCode.TabIndex = 19
        Me.txtPriceCode.Text = ""
        '
        'BtnPriceCode
        '
        Me.BtnPriceCode.Location = New System.Drawing.Point(70, 1523)
        Me.BtnPriceCode.Name = "BtnPriceCode"
        Me.BtnPriceCode.Size = New System.Drawing.Size(363, 85)
        Me.BtnPriceCode.TabIndex = 18
        Me.BtnPriceCode.Text = "Price Code"
        '
        'BtnImport
        '
        Me.BtnImport.Location = New System.Drawing.Point(70, 1815)
        Me.BtnImport.Name = "BtnImport"
        Me.BtnImport.Size = New System.Drawing.Size(363, 87)
        Me.BtnImport.TabIndex = 20
        Me.BtnImport.Text = "Import"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(387, 1692)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(264, 32)
        Me.txtCode.TabIndex = 21
        Me.txtCode.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2582, 340)
        Me.Panel2.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(513, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1830, 338)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Update Database"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(513, 338)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(-53, 1631)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(425, 165)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Security Code :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'command
        '
        Me.command.Connection = Me.cnn
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(880, 1631)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1795, 307)
        Me.ListView1.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(651, 1631)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 44)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Error"
        '
        'PrBrand
        '
        Me.PrBrand.Location = New System.Drawing.Point(1690, 462)
        Me.PrBrand.Name = "PrBrand"
        Me.PrBrand.Size = New System.Drawing.Size(968, 44)
        Me.PrBrand.TabIndex = 37
        '
        'PrCategory
        '
        Me.PrCategory.Location = New System.Drawing.Point(1690, 585)
        Me.PrCategory.Name = "PrCategory"
        Me.PrCategory.Size = New System.Drawing.Size(968, 44)
        Me.PrCategory.TabIndex = 38
        '
        'PrStyle
        '
        Me.PrStyle.Location = New System.Drawing.Point(1690, 708)
        Me.PrStyle.Name = "PrStyle"
        Me.PrStyle.Size = New System.Drawing.Size(968, 44)
        Me.PrStyle.TabIndex = 39
        '
        'PrLine
        '
        Me.PrLine.Location = New System.Drawing.Point(1690, 815)
        Me.PrLine.Name = "PrLine"
        Me.PrLine.Size = New System.Drawing.Size(968, 45)
        Me.PrLine.TabIndex = 40
        '
        'PrCustomer
        '
        Me.PrCustomer.Location = New System.Drawing.Point(1690, 923)
        Me.PrCustomer.Name = "PrCustomer"
        Me.PrCustomer.Size = New System.Drawing.Size(968, 44)
        Me.PrCustomer.TabIndex = 41
        '
        'PrVendor
        '
        Me.PrVendor.Location = New System.Drawing.Point(1690, 1062)
        Me.PrVendor.Name = "PrVendor"
        Me.PrVendor.Size = New System.Drawing.Size(968, 44)
        Me.PrVendor.TabIndex = 42
        '
        'PrService
        '
        Me.PrService.Location = New System.Drawing.Point(1690, 1169)
        Me.PrService.Name = "PrService"
        Me.PrService.Size = New System.Drawing.Size(968, 44)
        Me.PrService.TabIndex = 43
        '
        'PrVehicle
        '
        Me.PrVehicle.Location = New System.Drawing.Point(1690, 1292)
        Me.PrVehicle.Name = "PrVehicle"
        Me.PrVehicle.Size = New System.Drawing.Size(968, 45)
        Me.PrVehicle.TabIndex = 44
        '
        'PrItem
        '
        Me.PrItem.Location = New System.Drawing.Point(1690, 1400)
        Me.PrItem.Name = "PrItem"
        Me.PrItem.Size = New System.Drawing.Size(968, 44)
        Me.PrItem.TabIndex = 45
        '
        'PrPrice
        '
        Me.PrPrice.Location = New System.Drawing.Point(1690, 1538)
        Me.PrPrice.Name = "PrPrice"
        Me.PrPrice.Size = New System.Drawing.Size(968, 45)
        Me.PrPrice.TabIndex = 46
        '
        'FrmImportData
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(2582, 1673)
        Me.Controls.Add(Me.PrPrice)
        Me.Controls.Add(Me.PrItem)
        Me.Controls.Add(Me.PrVehicle)
        Me.Controls.Add(Me.PrService)
        Me.Controls.Add(Me.PrVendor)
        Me.Controls.Add(Me.PrCustomer)
        Me.Controls.Add(Me.PrLine)
        Me.Controls.Add(Me.PrStyle)
        Me.Controls.Add(Me.PrCategory)
        Me.Controls.Add(Me.PrBrand)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.BtnImport)
        Me.Controls.Add(Me.txtPriceCode)
        Me.Controls.Add(Me.BtnPriceCode)
        Me.Controls.Add(Me.txtItemPath)
        Me.Controls.Add(Me.BtnItem)
        Me.Controls.Add(Me.TxtVehiclePath)
        Me.Controls.Add(Me.BtnVehicle)
        Me.Controls.Add(Me.txtServicePath)
        Me.Controls.Add(Me.BtnService)
        Me.Controls.Add(Me.txtVendor)
        Me.Controls.Add(Me.btnVendor)
        Me.Controls.Add(Me.txtLinePath)
        Me.Controls.Add(Me.BtnLine)
        Me.Controls.Add(Me.txtStylePath)
        Me.Controls.Add(Me.BtnStylePath)
        Me.Controls.Add(Me.txtCustomerPath)
        Me.Controls.Add(Me.BtnCustomer)
        Me.Controls.Add(Me.TxtCategoryPath)
        Me.Controls.Add(Me.BtnCategory)
        Me.Controls.Add(Me.txtBrandPath)
        Me.Controls.Add(Me.BtnBrand)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmImportData"
        Me.Text = "Import Data"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub BtnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImport.Click
        If txtCode.Text = 2231 Then
            'If txtBrandPath.Text.Length > 10 And TxtCategoryPath.Text.Length > 10 And txtCustomerPath.Text.Length > 10 And txtStylePath.Text.Length > 10 And txtLinePath.Text.Length > 10 And txtServicePath.Text.Length > 10 And  TxtVehiclePath.Text.Length > 10 And txtItemPath.Text.Length > 10 And   txtPriceCode.Text.Length > 10 and txtVendor.Text.Length>10 Then
            ReadExcelAndInsertToBrand()
            ReadExcelAndInsertToCategory()
            ReadExcelAndInsertTostyle()
            ReadExcelAndInsertToLine()
            ReadExcelAndInsertToCustomer()
            'End If
        End If

    End Sub

    Dim Brandmap As New Hashtable
    Dim Stylemap As New Hashtable
    Dim Categorymap As New Hashtable
    Dim LineMap As New Hashtable

    Private Sub ReadExcelAndInsertToBrand()
        Dim excelApp As New Excel.Application
        Dim workbook As Excel.Workbook = Nothing
        Dim worksheet As Excel.Worksheet = Nothing

        Try
            ' ????? ?? ???????
            ' ????? ????? ??? ???? ???? ??? ?? ??
            Dim checkQuery As String = "SELECT COUNT(*) FROM inv_tab_brand"
            Dim checkCommand As New System.Data.SqlClient.SqlCommand(checkQuery, cnn)
            If checkCommand.Connection.State <> ConnectionState.Open Then
                checkCommand.Connection.Open()

            End If
            Dim recordCount As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
            If recordCount > 0 Then
                MessageBox.Show("Error: The Brand table already contains data. Operation aborted.")
                Return
            End If


            workbook = excelApp.Workbooks.Open(txtBrandPath.Text)
            worksheet = CType(workbook.Sheets(1), Excel.Worksheet)
            Dim rangeBrand As Excel.Range = worksheet.UsedRange

            PrBrand.Maximum = rangeBrand.Rows.Count
            For row As Integer = 2 To rangeBrand.Rows.Count
                PrBrand.Value = row
                Dim codBrand As String = rangeBrand.Cells(row, 1).Value.ToString()
                Dim descBrand As String = rangeBrand.Cells(row, 2).Value.ToString()

                Dim sql As String = "INSERT INTO inv_tab_brand (cod_brand, complete_desc_brand) VALUES ('" + codBrand + "', '" + descBrand + "' )"
                Dim command As New System.Data.SqlClient.SqlCommand(sql, cnn)



                command.ExecuteNonQuery()
                Brandmap.Add(codBrand, descBrand)
            Next



        Catch ex As Exception
            MessageBox.Show("Error insert Brand: " & ex.Message)
        Finally
            ' ???? ???? ????
            ''If workbook = Nothing Then workbook.Close(False)
            excelApp.Quit()
        End Try
    End Sub

    Private Sub ReadExcelAndInsertToCategory()
        Dim excelApp As New Excel.Application
        Dim workbook As Excel.Workbook = Nothing
        Dim worksheet As Excel.Worksheet = Nothing

        Try
            ' ????? ?? ???????




            ' ????? ????? ??? ???? ???? ??? ?? ??
            Dim checkQuery As String = "SELECT COUNT(*) FROM inv_tab_service_category"
            Dim checkCommand As New System.Data.SqlClient.SqlCommand(checkQuery, cnn)
            If checkCommand.Connection.State <> ConnectionState.Open Then
                checkCommand.Connection.Open()

            End If
            Dim recordCount As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
            If recordCount > 0 Then
                MessageBox.Show("Error: The Category table already contains data. Operation aborted.")
                Return
            End If


            workbook = excelApp.Workbooks.Open(TxtCategoryPath.Text)
            worksheet = CType(workbook.Sheets(1), Excel.Worksheet)
            Dim rangeBrand As Excel.Range = worksheet.UsedRange
            PrCategory.Maximum = rangeBrand.Rows.Count
            For row As Integer = 2 To rangeBrand.Rows.Count
                PrCategory.Value = row

                Dim cod As String = rangeBrand.Cells(row, 1).Value.ToString()
                Dim desc As String = rangeBrand.Cells(row, 2).Value.ToString()

                Dim sql As String = "INSERT INTO inv_tab_service_category (service_category,desc_srvice_category) VALUES ('" + cod + "', '" + desc + "' )"
                Dim command As New System.Data.SqlClient.SqlCommand(sql, cnn)

                command.ExecuteNonQuery()
                Categorymap.Add(cod, desc)
            Next



        Catch ex As Exception
            MessageBox.Show("Error Insert Category: " & ex.Message)
        Finally
            ' ???? ???? ????
            ''If workbook = Nothing Then workbook.Close(False)
            excelApp.Quit()
        End Try
    End Sub

    Private Sub ReadExcelAndInsertTostyle()
        Dim excelApp As New Excel.Application
        Dim workbook As Excel.Workbook = Nothing
        Dim worksheet As Excel.Worksheet = Nothing

        Try
            ' ????? ?? ???????




            ' ????? ????? ??? ???? ???? ??? ?? ??
            Dim checkQuery As String = "SELECT COUNT(*) FROM inv_tab_style"
            Dim checkCommand As New System.Data.SqlClient.SqlCommand(checkQuery, cnn)
            If checkCommand.Connection.State <> ConnectionState.Open Then
                checkCommand.Connection.Open()

            End If
            Dim recordCount As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
            If recordCount > 0 Then
                MessageBox.Show("Error: The Style table already contains data. Operation aborted.")
                Return
            End If


            workbook = excelApp.Workbooks.Open(txtStylePath.Text)
            worksheet = CType(workbook.Sheets(1), Excel.Worksheet)
            Dim rangeBrand As Excel.Range = worksheet.UsedRange

            PrStyle.Maximum = rangeBrand.Rows.Count
            For row As Integer = 2 To rangeBrand.Rows.Count
                PrStyle.Value = row

                Dim cod As String = rangeBrand.Cells(row, 1).Value.ToString()
                Dim desc As String = rangeBrand.Cells(row, 2).Value.ToString()

                Dim sql As String = "INSERT INTO inv_tab_style (style,desc_style) VALUES ('" + cod + "', '" + desc + "' )"
                Dim command As New System.Data.SqlClient.SqlCommand(sql, cnn)

                command.ExecuteNonQuery()

                Stylemap.Add(cod, desc)
            Next



        Catch ex As Exception
            MessageBox.Show("Error Insert Style: " & ex.Message)
        Finally
            ' ???? ???? ????
            ''If workbook = Nothing Then workbook.Close(False)
            excelApp.Quit()
        End Try
    End Sub

    Private Sub ReadExcelAndInsertToLine()
        Dim excelApp As New Excel.Application
        Dim workbook As Excel.Workbook = Nothing
        Dim worksheet As Excel.Worksheet = Nothing

        Try
 
            Dim checkQuery As String = "SELECT COUNT(*) FROM inv_tab_line"
            Dim checkCommand As New System.Data.SqlClient.SqlCommand(checkQuery, cnn)
            If checkCommand.Connection.State <> ConnectionState.Open Then
                checkCommand.Connection.Open()

            End If
            Dim recordCount As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
            If recordCount > 0 Then
                MessageBox.Show("Error: The Line table already contains data. Operation aborted.")
                Return
            End If


            workbook = excelApp.Workbooks.Open(txtLinePath.Text)
            worksheet = CType(workbook.Sheets(1), Excel.Worksheet)
            Dim rangeBrand As Excel.Range = worksheet.UsedRange

            PrLine.Maximum = rangeBrand.Rows.Count

            For row As Integer = 2 To rangeBrand.Rows.Count
                PrLine.Value = row

                Dim brand As String = rangeBrand.Cells(row, 3).Value.ToString()
                Dim style As String = rangeBrand.Cells(row, 4).Value.ToString()
                Dim desc As String = rangeBrand.Cells(row, 2).Value.ToString()

                If Brandmap.ContainsKey(brand) And Stylemap.ContainsKey(style) Then
                    Dim sql As String = "INSERT INTO inv_tab_line (cod_brand,style,line) VALUES ('" + brand + "', '" + style + "', '" + desc + "' )"
                    Dim command As New System.Data.SqlClient.SqlCommand(sql, cnn)

                    command.ExecuteNonQuery()
                Else
                    Dim st As String
                    st = "Error add Line " + desc

                    If Not Brandmap.ContainsKey(brand) Then
                        st = st + " Brand " + brand + " Not found"
                    End If
                    If Not Stylemap.ContainsKey(style) Then
                        st = st + " Style " + style + " Not found"
                    End If
                    ListView1.Items.Add(st)
                End If

            Next



        Catch ex As Exception
            MessageBox.Show("Error Insert Line: " & ex.Message)
        Finally
            ' ???? ???? ????
            ''If workbook = Nothing Then workbook.Close(False)
            excelApp.Quit()
        End Try
    End Sub


    Private Sub ReadExcelAndInsertToCustomer()
        Dim excelApp As New Excel.Application
        Dim workbook As Excel.Workbook = Nothing
        Dim worksheet As Excel.Worksheet = Nothing
        Dim CompanyCod As Int32 = 1
        Dim i As Int16
        Dim CompanyCodString As String
        Dim codsaleTax As String
        Dim codType As String
        Dim codClass As String
        Dim codSource As String

        Try
            CompanyCodString = ""

            Dim checkQuery As String = "SELECT COUNT(*) FROM cust_trtab_main"
            Dim checkCommand As New System.Data.SqlClient.SqlCommand(checkQuery, cnn)
            If checkCommand.Connection.State <> ConnectionState.Open Then
                checkCommand.Connection.Open()

            End If
            Dim recordCount As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
            If recordCount > 0 Then
                MessageBox.Show("Error: The Customer table already contains data. Operation aborted.")
                Return
            End If


            workbook = excelApp.Workbooks.Open(txtCustomerPath.Text)
            worksheet = CType(workbook.Sheets(1), Excel.Worksheet)
            Dim rangeBrand As Excel.Range = worksheet.UsedRange

            PrCustomer.Maximum = rangeBrand.Rows.Count

            For row As Integer = 2 To rangeBrand.Rows.Count
                PrCustomer.Value = row

                Dim cod As String = rangeBrand.Cells(row, 1).Value.ToString()
                Dim FirstLatName As String = rangeBrand.Cells(row, 2).Value.ToString()
                Dim COMPANY As String = rangeBrand.Cells(row, 3).Value.ToString()
                Dim ADDRESS As String = rangeBrand.Cells(row, 4).Value.ToString()
                Dim CITY As String = rangeBrand.Cells(row, 5).Value.ToString()
                Dim STATE As String = rangeBrand.Cells(row, 6).Value.ToString()
                Dim ZIP As String = rangeBrand.Cells(row, 7).Value.ToString()
                Dim HomePhone As String = rangeBrand.Cells(row, 8).Value.ToString()
                Dim CHARGE As String = rangeBrand.Cells(row, 9).Value.ToString()
                Dim SalesTax As String = rangeBrand.Cells(row, 10).Value.ToString()
                Dim Taxable As String = rangeBrand.Cells(row, 11).Value.ToString()
                Dim PriceLevel As String = rangeBrand.Cells(row, 12).Value.ToString()
                Dim Type As String = rangeBrand.Cells(row, 13).Value.ToString()
                Dim Classs As String = rangeBrand.Cells(row, 14).Value.ToString()
                Dim Source As String = rangeBrand.Cells(row, 15).Value.ToString()
                Dim Since As String = rangeBrand.Cells(row, 16).Value.ToString()
                Dim Term As String = rangeBrand.Cells(row, 17).Value.ToString()
                Dim Statement As String = rangeBrand.Cells(row, 18).Value.ToString()
                Dim Finence As String = rangeBrand.Cells(row, 19).Value.ToString()
                Dim Accept As String = rangeBrand.Cells(row, 20).Value.ToString()
                Dim VIP As String = rangeBrand.Cells(row, 21).Value.ToString()
                Dim WorkPhone As String = rangeBrand.Cells(row, 22).Value.ToString()

                Dim parts() As String = FirstLatName.Split(",")
                Dim firstName As String = ""
                Dim lastName As String = ""

                If parts.Length = 2 Then
                    firstName = parts(1)
                    lastName = parts(0)

                ElseIf parts.Length = 1 Then
                    lastName = parts(0)
                End If


                If Classs.Trim.ToUpper = "COMPANY" Then
                    CompanyCodString = CompanyCod

                    For i = CompanyCod.ToString().Length To 3
                        CompanyCodString = "0" & CompanyCodString
                    Next

                    CompanyCodString = "C" + CompanyCodString
                    Dim sqlCompany As String = "  INSERT  INTO    cust_company(cod_company, abbreviation_name,complete_name, zip_code) " & _
                                        "VALUES ('" & CompanyCodString & "','" & COMPANY & "','" & COMPANY & "','" & ZIP & "')"

                    Dim commandCompany As New System.Data.SqlClient.SqlCommand(sqlCompany, cnn)

                    If cnn.State <> ConnectionState.Open Then
                        cnn.Open()
                    End If

                    commandCompany.ExecuteNonQuery()
                    CompanyCod = CompanyCod + 1


                End If



                If SalesTax.Length > 0 Then
                    Dim cmd As New SqlClient.SqlCommand("select top 1 cod_sales_tax from cust_sales_tax where desc_sales_tax like '%" & SalesTax & "%' ", cnn)

                    If cnn.State <> ConnectionState.Open Then
                        cnn.Open()
                    End If

                    codsaleTax = cmd.ExecuteScalar()

                    If codsaleTax.Length = 0 Then
                        cmd.CommandText = "insert into cust_sales_tax(cod_sales_tax,desc_sales_tax) values (05,'" & SalesTax & " Sales Tax')"
                        cmd.ExecuteNonQuery()

                        codsaleTax = "05"
                    End If

                End If

                If Type.Trim.ToUpper = "RETAIL" Then
                    codType = "01"
                ElseIf Type.Trim.ToUpper = "Wholesale" Then
                    codType = "02"
                ElseIf Type.Trim.ToUpper = "NON TAXABLE" Then
                    codType = "01"
                ElseIf Type.Trim.ToUpper = "GOVERNMENT" Then
                    codType = "03"
                ElseIf Type.Trim.ToUpper = "NATIONAL ACCOUNT" Then
                    codType = "04"
                ElseIf Type.Trim.ToUpper = "NON PROFIT" Then
                    codType = "05"
                ElseIf Type.Trim.ToUpper = "CAR DEALER" Then
                    codType = "07"
                ElseIf Type.Trim.ToUpper = "AUTO REPAIR" Then
                    codType = "08"
                ElseIf Type.Trim.ToUpper = "INTERSTATE COMMERCE" Then
                    codType = "09"
                Else
                    codType = "1"
                End If
                If Source.Trim.ToUpper = "DRIVE BY" Then
                    codSource = "1"
                ElseIf Source.Trim.ToUpper = "NEWSPAPER" Then
                    codSource = "2"
                ElseIf Source.Trim.ToUpper = "RADIO" Then
                    codSource = "3"
                ElseIf Source.Trim.ToUpper = "TVhen" Then
                    codSource = "4"
                Else
                    codSource = 0
                End If


                Dim sql As String = " INSERT  INTO    cust_trtab_main(cod_customer, vip_code, cod_company, f_name, l_name," & _
                " address, phone_1, phone_type_1, phone_main_1, phone_2, phone_type_2, phone_main_2, " & _
                " zip, scrap_check, scrap_value, AR_term, cod_sales_tax, cod_price," & _
                " discount, cod_type, cod_source,  cod_territory," & _
                " AR_statement, AR_send_copy, AR_finance_charge, AR_require_PO, AR_credit_hold, AR_accept_check," & _
                " Taxable, inactive, PrintStatementDetailFlag,cust_notes) " & _
                " VALUES (" & cod & ",'" & VIP & "','" & CompanyCodString & "','" & firstName & "','" & lastName & "','" & _
                ADDRESS & "','" & HomePhone.Replace("(", "").Replace(")", "-").Trim() & "',1,1,'" & WorkPhone.Replace("(", "").Replace(")", "-").Trim() & "',2,0,'" & _
                ZIP & "',0,0,'" & Term & "','" & codsaleTax & "'," & PriceLevel & _
                ",0,'" & codType & "','" & codSource & "','01'," & _
                IIf(Statement = "YES", "1", "0") & ",0," & IIf(Finence = "YES", "1", "0") & ",0,0," & IIf(Accept = "YES", "1", "0") & _
                IIf(Taxable = "YES", "1", "0") & ",0,0," & CITY & ") "
                Dim command As New System.Data.SqlClient.SqlCommand(sql, cnn)

                If cnn.State <> ConnectionState.Open Then
                    cnn.Open()
                End If
                command.ExecuteNonQuery()


            Next



        Catch ex As Exception
            MessageBox.Show("Error Insert Style: " & ex.Message)
        Finally
            ' ???? ???? ????
            ''If workbook = Nothing Then workbook.Close(False)
            excelApp.Quit()
        End Try
    End Sub


#Region "Open file Dialogue"
    Private Sub BtnBrand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrand.Click
        ' ??? ???? ???? ????
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Excel Files|*.xlsx;*.xls"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            txtBrandPath.Text = openFileDialog.FileName ' ????? ???? ???? ?? ?? TextBox
        End If
    End Sub
    Private Sub BtnCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCategory.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Excel Files|*.xlsx;*.xls"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            TxtCategoryPath.Text = openFileDialog.FileName ' ????? ???? ???? ?? ?? TextBox
        End If
    End Sub
    Private Sub BtnStylePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStylePath.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Excel Files|*.xlsx;*.xls"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            txtStylePath.Text = openFileDialog.FileName ' ????? ???? ???? ?? ?? TextBox
        End If
    End Sub
    Private Sub BtnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomer.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Excel Files|*.xlsx;*.xls"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            txtCustomerPath.Text = openFileDialog.FileName ' ????? ???? ???? ?? ?? TextBox
        End If
    End Sub
    Private Sub BtnLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLine.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Excel Files|*.xlsx;*.xls"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            txtLinePath.Text = openFileDialog.FileName ' ????? ???? ???? ?? ?? TextBox
        End If
    End Sub
    Private Sub BtnService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnService.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Excel Files|*.xlsx;*.xls"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            txtServicePath.Text = openFileDialog.FileName ' ????? ???? ???? ?? ?? TextBox
        End If
    End Sub
    Private Sub BtnVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVehicle.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Excel Files|*.xlsx;*.xls"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            TxtVehiclePath.Text = openFileDialog.FileName ' ????? ???? ???? ?? ?? TextBox
        End If
    End Sub
    Private Sub BtnItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItem.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Excel Files|*.xlsx;*.xls"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            txtItemPath.Text = openFileDialog.FileName ' ????? ???? ???? ?? ?? TextBox
        End If
    End Sub
    Private Sub BtnPriceCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPriceCode.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Excel Files|*.xlsx;*.xls"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            txtPriceCode.Text = openFileDialog.FileName ' ????? ???? ???? ?? ?? TextBox
        End If
    End Sub
    Private Sub btnVendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVendor.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Excel Files|*.xlsx;*.xls"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            TxtVehiclePath.Text = openFileDialog.FileName ' ????? ???? ???? ?? ?? TextBox
        End If
    End Sub
#End Region
    Private Sub FrmImportData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn.ConnectionString = PConnectionString
    End Sub
End Class
