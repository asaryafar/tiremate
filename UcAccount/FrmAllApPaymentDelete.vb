Imports CommonClass
Public Class FrmAllApPaymentDelete
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbDate As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaAllVendorSum As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmAllPaymentDelete1 As UcAccount.DSFrmAllPaymentDelete
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents BtnUnmarkAll As System.Windows.Forms.Button
    Friend WithEvents BtnMarkAll As System.Windows.Forms.Button
    Friend WithEvents Grd2 As Janus.Windows.GridEX.GridEX
    Friend WithEvents DaAllDate As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdDel As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaAllDetail As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbDate = New System.Windows.Forms.ComboBox
        Me.DsFrmAllPaymentDelete1 = New UcAccount.DSFrmAllPaymentDelete
        Me.Label1 = New System.Windows.Forms.Label
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DaAllVendorSum = New System.Data.SqlClient.SqlDataAdapter
        Me.BtnExit = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.BtnUnmarkAll = New System.Windows.Forms.Button
        Me.BtnMarkAll = New System.Windows.Forms.Button
        Me.Grd2 = New Janus.Windows.GridEX.GridEX
        Me.DaAllDate = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.CmdDel = New System.Data.SqlClient.SqlCommand
        Me.DaAllDetail = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmAllPaymentDelete1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.CmbDate)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(686, 56)
        Me.Panel4.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(400, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "Payment Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDate
        '
        Me.CmbDate.DataSource = Me.DsFrmAllPaymentDelete1.AllDate
        Me.CmbDate.DisplayMember = "date_prepare"
        Me.CmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDate.Location = New System.Drawing.Point(517, 16)
        Me.CmbDate.Name = "CmbDate"
        Me.CmbDate.Size = New System.Drawing.Size(154, 21)
        Me.CmbDate.TabIndex = 204
        Me.CmbDate.ValueMember = "date_prepare"
        '
        'DsFrmAllPaymentDelete1
        '
        Me.DsFrmAllPaymentDelete1.DataSetName = "DSFrmAllPaymentDelete"
        Me.DsFrmAllPaymentDelete1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 54)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "Select payment  Date And Then Check Out The Records That You Want To Delete"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT 0 AS selected, cod_vendor, desc_vendor, SUM(amount_pay) AS sumpay FROM Vie" & _
        "w_AllVendorPaid WHERE (date_prepare = @Date_Prepar) GROUP BY cod_vendor, desc_ve" & _
        "ndor, date_prepare"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Date_Prepar", System.Data.SqlDbType.VarChar, 10, "date_prepare"))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJI1;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=Tiremate_01;password=sa"
        '
        'DaAllVendorSum
        '
        Me.DaAllVendorSum.SelectCommand = Me.SqlSelectCommand1
        Me.DaAllVendorSum.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_payment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("radif1", "radif1"), New System.Data.Common.DataColumnMapping("id_vendor_credit_head", "id_vendor_credit_head")})})
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(608, 392)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.TabIndex = 23
        Me.BtnExit.Text = "Exit"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(176, 392)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.TabIndex = 22
        Me.btndelete.Text = "Delete"
        '
        'BtnUnmarkAll
        '
        Me.BtnUnmarkAll.Location = New System.Drawing.Point(88, 392)
        Me.BtnUnmarkAll.Name = "BtnUnmarkAll"
        Me.BtnUnmarkAll.TabIndex = 21
        Me.BtnUnmarkAll.Text = "UnMark All"
        '
        'BtnMarkAll
        '
        Me.BtnMarkAll.Location = New System.Drawing.Point(8, 392)
        Me.BtnMarkAll.Name = "BtnMarkAll"
        Me.BtnMarkAll.TabIndex = 20
        Me.BtnMarkAll.Text = "Mark All"
        '
        'Grd2
        '
        Me.Grd2.AlternatingColors = True
        Me.Grd2.DataMember = "GL_AP_payment"
        Me.Grd2.DataSource = Me.DsFrmAllPaymentDelete1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_AP_payment</Caption><Columns Collection=" & _
        """true""><Column0 ID=""selected""><ColumnType>CheckBox</ColumnType><DataMember>selec" & _
        "ted</DataMember><EditType>CheckBox</EditType><Key>selected</Key><Position>0</Pos" & _
        "ition><Width>47</Width><DefaultValue>False</DefaultValue></Column0><Column1 ID=""" & _
        "cod_vendor""><Caption>Vendor</Caption><TypeNameEmptyStringValue>System.String</Ty" & _
        "peNameEmptyStringValue><EmptyStringValue /><DataMember>cod_vendor</DataMember><K" & _
        "ey>cod_vendor</Key><Position>1</Position><Width>117</Width></Column1><Column2 ID" & _
        "=""desc_vendor""><Caption>Name</Caption><DataMember>desc_vendor</DataMember><Key>d" & _
        "esc_vendor</Key><Position>2</Position><Width>287</Width></Column2><Column3 ID=""s" & _
        "umpay""><Caption>Paid Amount</Caption><DataMember>sumpay</DataMember><EditType>No" & _
        "Edit</EditType><FormatString>c</FormatString><Key>sumpay</Key><Position>3</Posit" & _
        "ion><TextAlignment>Far</TextAlignment><Width>115</Width></Column3></Columns><Gro" & _
        "upCondition ID="""" /><Key>GL_AP_payment</Key></RootTable></GridEXLayoutData>"
        Me.Grd2.DesignTimeLayout = GridEXLayout1
        Me.Grd2.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grd2.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.Grd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Grd2.Location = New System.Drawing.Point(8, 64)
        Me.Grd2.Name = "Grd2"
        Me.Grd2.Size = New System.Drawing.Size(672, 320)
        Me.Grd2.TabIndex = 19
        '
        'DaAllDate
        '
        Me.DaAllDate.SelectCommand = Me.SqlCommand3
        Me.DaAllDate.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AllDate", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT date_prepare FROM View_AllVendorPaid GROUP BY date_prepare ORDER BY dbo.Ch" & _
        "angeDate(date_prepare)"
        Me.SqlCommand3.Connection = Me.Cnn
        '
        'CmdDel
        '
        Me.CmdDel.Connection = Me.Cnn
        '
        'DaAllDetail
        '
        Me.DaAllDetail.SelectCommand = Me.SqlCommand4
        Me.DaAllDetail.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AllDetail", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("id_vendor_credit_head", "id_vendor_credit_head")})})
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "SELECT cod_vendor, ID_AP_payment, id_vendor_credit_head FROM View_AllVendorPaid W" & _
        "HERE (date_prepare = @Date_Prepar)"
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Date_Prepar", System.Data.SqlDbType.VarChar, 10, "date_prepare"))
        '
        'FrmAllApPaymentDelete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(686, 428)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.BtnUnmarkAll)
        Me.Controls.Add(Me.BtnMarkAll)
        Me.Controls.Add(Me.Grd2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmAllApPaymentDelete"
        Me.Text = "Delete Paid Bills"
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmAllPaymentDelete1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmAllApPaymentDelete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = CommonClass.PConnectionString
        Call LOadall()
    End Sub
    Private Sub BtnMarkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMarkAll.Click
        Call MarkAllUnMark(True)
    End Sub
    Sub MarkAllUnMark(ByVal What As Boolean)
        Dim i As Int64 = 0
        For i = 0 To DsFrmAllPaymentDelete1.GL_AP_payment.Rows.Count - 1
            DsFrmAllPaymentDelete1.GL_AP_payment.Rows(i).Item("selected") = IIf(What, 1, 0)
        Next
        'For i = 0 To Grd2.RowCount - 1
        '    Grd2.Row = i
        '    Grd2.GetRow.Cells(0).Value = What
        'Next
    End Sub
    Sub LoadIt()
        DsFrmAllPaymentDelete1.GL_AP_payment.Clear()
        DsFrmAllPaymentDelete1.AllDetail.Clear()
        DaAllVendorSum.SelectCommand.Parameters("@date_prepar").Value = CmbDate.SelectedValue
        DaAllVendorSum.Fill(DsFrmAllPaymentDelete1.GL_AP_payment)
        DaAllDetail.SelectCommand.Parameters("@date_prepar").Value = CmbDate.SelectedValue
        DaAllDetail.Fill(DsFrmAllPaymentDelete1.AllDetail)
    End Sub
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim i As Decimal = 0
        Dim j As Decimal = 0
        If DsFrmAllPaymentDelete1.GL_AP_payment.Rows.Count > 0 Then
            Dim c1 As New CommonClass.FrmWhatDoForMenu
            c1.BtnLeftText = "Cancel"
            c1.BtnRightText = "Ok"
            c1.Text = " Warning"
            c1.ShowFarMsg("This Operation Will Delete  From the vendor balance")
            '-------------------------------------- 
            If c1.DialogResult = DialogResult.OK Then
                CmdDel.Connection.Open()
                For i = 0 To DsFrmAllPaymentDelete1.GL_AP_payment.Rows.Count - 1
                    With DsFrmAllPaymentDelete1.GL_AP_payment.Rows(i)
                        If .Item("selected") = True Then
                            Dim Dr1() As DataRow = DsFrmAllPaymentDelete1.AllDetail.Select("cod_vendor=" & Qt(.Item("cod_vendor")))
                            If Dr1.LongLength > 0 Then
                                For j = 0 To Dr1.LongLength - 1
                                    CmdDel.CommandText = "Delete From GL_AP_payment where ID_AP_payment= " & CommonClass.Qt(Dr1(j).Item("id_ap_payment"))
                                    Dim tran1 As SqlClient.SqlTransaction
                                    Try
                                        'Dim tran1 As SqlClient.SqlTransaction
                                        tran1 = Cnn.BeginTransaction()
                                        CmdDel.Transaction = tran1
                                        CmdDel.ExecuteNonQuery()
                                        If Val(Dr1(j).Item("id_vendor_credit_head") & "") <> 0 Then
                                            CmdDel.CommandText = "update GL_vendor_credit set id_vendor_credit_head=null where id_vendor_credit_head =" & Dr1(j).Item("id_vendor_credit_head")
                                            CmdDel.ExecuteNonQuery()
                                            CmdDel.CommandText = "delete GL_vendor_credit_head  where id_vendor_credit_head =" & Dr1(j).Item("id_vendor_credit_head")
                                            CmdDel.ExecuteNonQuery()
                                        End If
                                        tran1.Commit()
                                    Catch ex As Exception
                                        tran1.Rollback()
                                        MsgFar("Error Deleting Vendor" & .Item("cod_vendor"))
                                    End Try
                                Next
                            End If
                        End If
                    End With
                Next
            End If
            CmdDel.Connection.Close()
            DsFrmAllPaymentDelete1.Clear()
            Call LoadAll()
        End If
    End Sub
    Sub LoadAll()
        DsFrmAllPaymentDelete1.AllDate.Clear()
        DaAllDate.Fill(DsFrmAllPaymentDelete1.AllDate)
        If DsFrmAllPaymentDelete1.AllDate.Rows.Count > 0 Then
            Call LoadIt()
            btndelete.Enabled = True
            BtnMarkAll.Enabled = True
            BtnUnmarkAll.Enabled = True
        Else
            btndelete.Enabled = False
            BtnMarkAll.Enabled = False
            BtnUnmarkAll.Enabled = False
            MsgFar("There is No Row To Delete")

        End If
    End Sub

    Private Sub BtnUnmarkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnmarkAll.Click
        Call MarkAllUnMark(False)
    End Sub


    Private Sub CmbDate_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbDate.SelectedValueChanged
        Try
            Call LoadIt()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CmbDate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDate.SelectedIndexChanged

    End Sub
End Class
