Imports CommonClass
Imports System.Data
Public Class FrmCloseDay
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaAverage As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TxtToDate As CalendarCombo.CalendarCombo
    Friend WithEvents TxtFromDate As CalendarCombo.CalendarCombo
    Friend WithEvents DsFrmCloseDay1 As UcAccount.DsFrmCloseDay
    Friend WithEvents DaAllItems As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGL_journal_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGL_journal_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaDeposit1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaDeposit3 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GlPaid As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaDeposit4 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaBankAtm As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaBaseBank As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGlTransferFrom As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGlTransferTo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaBankAdjustment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaForosh1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaTax As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGlAccountAdjustment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGlPaiedReceived As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaGlPaiedReceived2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GlReceviePayment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents InvRecevieReturn As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents InvRecevieReturnCreadit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents invAdjustment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents InvAdjustment2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaAnbar2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaForosh2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaForosh3 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaAnbar As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaAndbarCustomerReturn2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGlAccountAdjustment2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaInvSalesTransfer As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaAnbarCustomerReturn As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaForoshDeposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Daforosh4 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGlPaiedReceived3 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaInterStor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Cnn1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Cnn3 As System.Data.SqlClient.SqlConnection
    Friend WithEvents CnnUnlock As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaBank_Check As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Grd1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblStoreNo As System.Windows.Forms.Label
    Friend WithEvents LblCompanyName As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaDepositeBank1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaDepositeBank2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmdMakeJurnal As Janus.Windows.EditControls.UIButton
    Friend WithEvents DaForosh5 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand21 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCloseDay))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtToDate = New CalendarCombo.CalendarCombo
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtFromDate = New CalendarCombo.CalendarCombo
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdClose = New Janus.Windows.EditControls.UIButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CnnUnlock = New System.Data.SqlClient.SqlConnection
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaAverage = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmCloseDay1 = New UcAccount.DsFrmCloseDay
        Me.DaAllItems = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaGL_journal_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaGL_journal_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DaDeposit1 = New System.Data.SqlClient.SqlDataAdapter
        Me.DaDeposit3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.GlPaid = New System.Data.SqlClient.SqlDataAdapter
        Me.DaDeposit4 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.DaBankAtm = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.DaBaseBank = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.DaGlTransferFrom = New System.Data.SqlClient.SqlDataAdapter
        Me.DaGlTransferTo = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.DaBankAdjustment = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand
        Me.DaAnbar = New System.Data.SqlClient.SqlDataAdapter
        Me.DaForosh1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DaTax = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DaForoshDeposit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand
        Me.Grd1 = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand13 = New System.Data.SqlClient.SqlCommand
        Me.DaGlAccountAdjustment = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand14 = New System.Data.SqlClient.SqlCommand
        Me.DaGlPaiedReceived = New System.Data.SqlClient.SqlDataAdapter
        Me.DaGlPaiedReceived2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand15 = New System.Data.SqlClient.SqlCommand
        Me.GlReceviePayment = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand16 = New System.Data.SqlClient.SqlCommand
        Me.InvRecevieReturn = New System.Data.SqlClient.SqlDataAdapter
        Me.InvRecevieReturnCreadit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand17 = New System.Data.SqlClient.SqlCommand
        Me.invAdjustment = New System.Data.SqlClient.SqlDataAdapter
        Me.InvAdjustment2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand10 = New System.Data.SqlClient.SqlCommand
        Me.DaAnbar2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand11 = New System.Data.SqlClient.SqlCommand
        Me.DaForosh2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand12 = New System.Data.SqlClient.SqlCommand
        Me.DaForosh3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand13 = New System.Data.SqlClient.SqlCommand
        Me.DaAnbarCustomerReturn = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand14 = New System.Data.SqlClient.SqlCommand
        Me.DaAndbarCustomerReturn2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand15 = New System.Data.SqlClient.SqlCommand
        Me.DaGlAccountAdjustment2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand16 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaInvSalesTransfer = New System.Data.SqlClient.SqlDataAdapter
        Me.Daforosh4 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand17 = New System.Data.SqlClient.SqlCommand
        Me.DaGlPaiedReceived3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand18 = New System.Data.SqlClient.SqlCommand
        Me.DaInterStor = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand19 = New System.Data.SqlClient.SqlCommand
        Me.Cnn2 = New System.Data.SqlClient.SqlConnection
        Me.Cnn1 = New System.Data.SqlClient.SqlConnection
        Me.Cnn3 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DaBank_Check = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblStoreNo = New System.Windows.Forms.Label
        Me.LblCompanyName = New System.Windows.Forms.Label
        Me.SqlSelectCommand18 = New System.Data.SqlClient.SqlCommand
        Me.DaDepositeBank1 = New System.Data.SqlClient.SqlDataAdapter
        Me.DaDepositeBank2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand20 = New System.Data.SqlClient.SqlCommand
        Me.CmdMakeJurnal = New Janus.Windows.EditControls.UIButton
        Me.DaForosh5 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand21 = New System.Data.SqlClient.SqlCommand
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DsFrmCloseDay1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(478, 45)
        Me.Panel4.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(417, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Close Of Day Process"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OldLace
        Me.Panel1.Controls.Add(Me.TxtToDate)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtFromDate)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(4, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(476, 50)
        Me.Panel1.TabIndex = 132
        '
        'TxtToDate
        '
        Me.TxtToDate.BackColor = System.Drawing.SystemColors.Info
        Me.TxtToDate.BorderColor = System.Drawing.Color.Empty
        Me.TxtToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtToDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtToDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtToDate.EditableSal = True
        Me.TxtToDate.Image = CType(resources.GetObject("TxtToDate.Image"), System.Drawing.Image)
        Me.TxtToDate.Location = New System.Drawing.Point(320, 8)
        Me.TxtToDate.MaxValue = CType(2500, Short)
        Me.TxtToDate.MinValue = CType(1800, Short)
        Me.TxtToDate.Name = "TxtToDate"
        Me.TxtToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtToDate.Sal_Mali = Nothing
        Me.TxtToDate.ShowButton = True
        Me.TxtToDate.Size = New System.Drawing.Size(120, 23)
        Me.TxtToDate.TabIndex = 136
        Me.ToolTip1.SetToolTip(Me.TxtToDate, "The Lat Date Of Close Day ")
        Me.TxtToDate.VisualStyle = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(280, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 23)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "To"
        '
        'TxtFromDate
        '
        Me.TxtFromDate.BackColor = System.Drawing.SystemColors.Info
        Me.TxtFromDate.BorderColor = System.Drawing.Color.Empty
        Me.TxtFromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFromDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtFromDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtFromDate.EditableSal = True
        Me.TxtFromDate.Image = CType(resources.GetObject("TxtFromDate.Image"), System.Drawing.Image)
        Me.TxtFromDate.Location = New System.Drawing.Point(48, 14)
        Me.TxtFromDate.MaxValue = CType(2500, Short)
        Me.TxtFromDate.MinValue = CType(1800, Short)
        Me.TxtFromDate.Name = "TxtFromDate"
        Me.TxtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtFromDate.Sal_Mali = Nothing
        Me.TxtFromDate.ShowButton = True
        Me.TxtFromDate.Size = New System.Drawing.Size(120, 23)
        Me.TxtFromDate.TabIndex = 134
        Me.ToolTip1.SetToolTip(Me.TxtFromDate, "The Lat Date Of Close Day ")
        Me.TxtFromDate.VisualStyle = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 23)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "From "
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(8, 144)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 133
        Me.CmdOk.Text = "Ok"
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(402, 144)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(75, 23)
        Me.CmdClose.TabIndex = 134
        Me.CmdClose.Text = "Exit"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.CnnUnlock
        '
        'CnnUnlock
        '
        Me.CnnUnlock.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=ARMANDEHserver;p" & _
        "ersist security info=True;initial catalog=TireMate_01"
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJI;packet size=4096;user id=sa;data source=""."";persist securit" & _
        "y info=True;initial catalog=Tiremate_02;password=sa"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT '1' AS TABLENAME, Inv_Receive_Products_head.id_receive_ref AS IDHEAD, 0 AS" & _
        " radif, dbo.ChangeDate(Inv_Receive_Products_head.date_receive) AS Date1, Inv_Rec" & _
        "eive_Products_head.id_GL_journal AS idjournal, Inv_Receive_product_dtl.item_no, " & _
        "CASE WHEN bill_credit = 1 THEN '1' ELSE '2' END AS 'AddSubtract ', Inv_Receive_p" & _
        "roduct_dtl.qty, Inv_Receive_product_dtl.cost, Inv_Receive_product_dtl.qty * Inv_" & _
        "Receive_product_dtl.cost AS QtyPrice, 0 AS AVERAGE_COST FROM Inv_Receive_Product" & _
        "s_head INNER JOIN Inv_Receive_product_dtl ON Inv_Receive_Products_head.id_receiv" & _
        "e_ref = Inv_Receive_product_dtl.id_receive_ref WHERE (Inv_Receive_Products_head." & _
        "id_GL_journal IS NULL) AND (dbo.ChangeDate(Inv_Receive_Products_head.date_receiv" & _
        "e) >= @FromDate) AND (dbo.ChangeDate(Inv_Receive_Products_head.date_receive) <= " & _
        "@ToDate) UNION ALL SELECT '2' AS TABLENAME, service_center_head.id_service_cente" & _
        "r AS IDHEAD, service_center_dtl.radif AS radif, dbo.ChangeDate(service_center_he" & _
        "ad.date_refer) AS Date1, service_center_head.id_GL_journal AS idjournal, service" & _
        "_center_dtl.cod_select AS item_no, '1' AS Addsubtract, service_center_dtl.qty, s" & _
        "ervice_center_dtl.price AS cost, service_center_dtl.qty * service_center_dtl.pri" & _
        "ce AS qtyCost, service_center_dtl.AVERAGE_COST FROM service_center_head INNER JO" & _
        "IN service_center_dtl ON service_center_head.id_service_center = service_center_" & _
        "dtl.id_service_center WHERE (service_center_head.type_of_form = 'IN') AND (servi" & _
        "ce_center_dtl.type_select = 'I') AND (service_center_head.id_GL_journal IS NULL)" & _
        " AND (dbo.ChangeDate(service_center_head.date_refer) >= @FromDate) AND (dbo.Chan" & _
        "geDate(service_center_head.date_refer) <= @ToDate) ORDER BY date1"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaAverage
        '
        Me.DaAverage.SelectCommand = Me.SqlSelectCommand1
        Me.DaAverage.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Average", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TABLENAME", "TABLENAME"), New System.Data.Common.DataColumnMapping("IDHEAD", "IDHEAD"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("Date1", "Date1"), New System.Data.Common.DataColumnMapping("idjournal", "idjournal"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("AddSubtract ", "AddSubtract "), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("QtyPrice", "QtyPrice"), New System.Data.Common.DataColumnMapping("AVERAGE_COST", "AVERAGE_COST")})})
        '
        'DsFrmCloseDay1
        '
        Me.DsFrmCloseDay1.DataSetName = "DsFrmCloseDay"
        Me.DsFrmCloseDay1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'DaAllItems
        '
        Me.DaAllItems.SelectCommand = Me.SqlCommand1
        Me.DaAllItems.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Average", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TABLENAME", "TABLENAME"), New System.Data.Common.DataColumnMapping("IDHEAD", "IDHEAD"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("Date1", "Date1"), New System.Data.Common.DataColumnMapping("idjournal", "idjournal"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("AddSubtract ", "AddSubtract "), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("QtyPrice", "QtyPrice"), New System.Data.Common.DataColumnMapping("AVERAGE_COST", "AVERAGE_COST")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT Inv_Receive_product_dtl.item_no FROM Inv_Receive_Products_head INNER JOIN " & _
        "Inv_Receive_product_dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_Receiv" & _
        "e_product_dtl.id_receive_ref WHERE (Inv_Receive_Products_head.id_GL_journal IS N" & _
        "ULL) AND (dbo.ChangeDate(Inv_Receive_Products_head.date_receive) >= @FromDate) A" & _
        "ND (dbo.ChangeDate(Inv_Receive_Products_head.date_receive) <= @ToDate) AND (Inv_" & _
        "Receive_Products_head.bill_credit = '2') UNION SELECT service_center_dtl.cod_sel" & _
        "ect AS item_no FROM service_center_head INNER JOIN service_center_dtl ON service" & _
        "_center_head.id_service_center = service_center_dtl.id_service_center WHERE (ser" & _
        "vice_center_head.type_of_form = 'IN') AND (service_center_dtl.type_select = 'I')" & _
        " AND (service_center_head.id_GL_journal IS NULL) AND (dbo.ChangeDate(service_cen" & _
        "ter_head.date_refer) >= @FromDate) AND (dbo.ChangeDate(service_center_head.date_" & _
        "refer) <= @ToDate)"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT id_GL_journal, GL_journal_date, GL_journal_reference, GL_journal_type_code" & _
        ", GL_picture FROM GL_journal_head"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO GL_journal_head(GL_journal_date, GL_journal_reference, GL_journal_typ" & _
        "e_code, GL_picture) VALUES (@GL_journal_date, @GL_journal_reference, @GL_journal" & _
        "_type_code, @GL_picture); SELECT id_GL_journal, GL_journal_date, GL_journal_refe" & _
        "rence, GL_journal_type_code, GL_picture FROM GL_journal_head WHERE (id_GL_journa" & _
        "l = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_journal_date", System.Data.SqlDbType.VarChar, 10, "GL_journal_date"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_journal_reference", System.Data.SqlDbType.VarChar, 80, "GL_journal_reference"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_journal_type_code", System.Data.SqlDbType.VarChar, 2, "GL_journal_type_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_picture", System.Data.SqlDbType.VarBinary, 2147483647, "GL_picture"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE GL_journal_head SET GL_journal_date = @GL_journal_date, GL_journal_referen" & _
        "ce = @GL_journal_reference, GL_journal_type_code = @GL_journal_type_code, GL_pic" & _
        "ture = @GL_picture WHERE (id_GL_journal = @Original_id_GL_journal) AND (GL_journ" & _
        "al_date = @Original_GL_journal_date OR @Original_GL_journal_date IS NULL AND GL_" & _
        "journal_date IS NULL) AND (GL_journal_reference = @Original_GL_journal_reference" & _
        " OR @Original_GL_journal_reference IS NULL AND GL_journal_reference IS NULL) AND" & _
        " (GL_journal_type_code = @Original_GL_journal_type_code OR @Original_GL_journal_" & _
        "type_code IS NULL AND GL_journal_type_code IS NULL); SELECT id_GL_journal, GL_jo" & _
        "urnal_date, GL_journal_reference, GL_journal_type_code, GL_picture FROM GL_journ" & _
        "al_head WHERE (id_GL_journal = @id_GL_journal)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_journal_date", System.Data.SqlDbType.VarChar, 10, "GL_journal_date"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_journal_reference", System.Data.SqlDbType.VarChar, 80, "GL_journal_reference"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_journal_type_code", System.Data.SqlDbType.VarChar, 2, "GL_journal_type_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_picture", System.Data.SqlDbType.VarBinary, 2147483647, "GL_picture"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_journal_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_journal_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_journal_reference", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_journal_reference", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_journal_type_code", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_journal_type_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM GL_journal_head WHERE (id_GL_journal = @Original_id_GL_journal) AND (" & _
        "GL_journal_date = @Original_GL_journal_date OR @Original_GL_journal_date IS NULL" & _
        " AND GL_journal_date IS NULL) AND (GL_journal_reference = @Original_GL_journal_r" & _
        "eference OR @Original_GL_journal_reference IS NULL AND GL_journal_reference IS N" & _
        "ULL) AND (GL_journal_type_code = @Original_GL_journal_type_code OR @Original_GL_" & _
        "journal_type_code IS NULL AND GL_journal_type_code IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_journal_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_journal_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_journal_reference", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_journal_reference", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_journal_type_code", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_journal_type_code", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaGL_journal_head
        '
        Me.DaGL_journal_head.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaGL_journal_head.InsertCommand = Me.SqlInsertCommand1
        Me.DaGL_journal_head.SelectCommand = Me.SqlSelectCommand3
        Me.DaGL_journal_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_journal_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("GL_journal_date", "GL_journal_date"), New System.Data.Common.DataColumnMapping("GL_journal_reference", "GL_journal_reference"), New System.Data.Common.DataColumnMapping("GL_journal_type_code", "GL_journal_type_code"), New System.Data.Common.DataColumnMapping("GL_picture", "GL_picture")})})
        Me.DaGL_journal_head.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT id_GL_journal, radif, GL_account, GL_journal_reference, GL_journal_amount_" & _
        "debit, GL_journal_amount_credit FROM GL_journal_dtl"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO GL_journal_dtl(id_GL_journal, radif, GL_account, GL_journal_reference" & _
        ", GL_journal_amount_debit, GL_journal_amount_credit) VALUES (@id_GL_journal, @ra" & _
        "dif, @GL_account, @GL_journal_reference, @GL_journal_amount_debit, @GL_journal_a" & _
        "mount_credit); SELECT id_GL_journal, radif, GL_account, GL_journal_reference, GL" & _
        "_journal_amount_debit, GL_journal_amount_credit FROM GL_journal_dtl WHERE (id_GL" & _
        "_journal = @id_GL_journal) AND (radif = @radif)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_journal_reference", System.Data.SqlDbType.VarChar, 80, "GL_journal_reference"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_journal_amount_debit", System.Data.SqlDbType.Money, 8, "GL_journal_amount_debit"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_journal_amount_credit", System.Data.SqlDbType.Money, 8, "GL_journal_amount_credit"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE GL_journal_dtl SET id_GL_journal = @id_GL_journal, radif = @radif, GL_acco" & _
        "unt = @GL_account, GL_journal_reference = @GL_journal_reference, GL_journal_amou" & _
        "nt_debit = @GL_journal_amount_debit, GL_journal_amount_credit = @GL_journal_amou" & _
        "nt_credit WHERE (id_GL_journal = @Original_id_GL_journal) AND (radif = @Original" & _
        "_radif) AND (GL_account = @Original_GL_account OR @Original_GL_account IS NULL A" & _
        "ND GL_account IS NULL) AND (GL_journal_amount_credit = @Original_GL_journal_amou" & _
        "nt_credit OR @Original_GL_journal_amount_credit IS NULL AND GL_journal_amount_cr" & _
        "edit IS NULL) AND (GL_journal_amount_debit = @Original_GL_journal_amount_debit O" & _
        "R @Original_GL_journal_amount_debit IS NULL AND GL_journal_amount_debit IS NULL)" & _
        " AND (GL_journal_reference = @Original_GL_journal_reference OR @Original_GL_jour" & _
        "nal_reference IS NULL AND GL_journal_reference IS NULL); SELECT id_GL_journal, r" & _
        "adif, GL_account, GL_journal_reference, GL_journal_amount_debit, GL_journal_amou" & _
        "nt_credit FROM GL_journal_dtl WHERE (id_GL_journal = @id_GL_journal) AND (radif " & _
        "= @radif)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_journal_reference", System.Data.SqlDbType.VarChar, 80, "GL_journal_reference"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_journal_amount_debit", System.Data.SqlDbType.Money, 8, "GL_journal_amount_debit"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_journal_amount_credit", System.Data.SqlDbType.Money, 8, "GL_journal_amount_credit"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_journal_amount_credit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_journal_amount_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_journal_amount_debit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_journal_amount_debit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_journal_reference", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_journal_reference", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM GL_journal_dtl WHERE (id_GL_journal = @Original_id_GL_journal) AND (r" & _
        "adif = @Original_radif) AND (GL_account = @Original_GL_account OR @Original_GL_a" & _
        "ccount IS NULL AND GL_account IS NULL) AND (GL_journal_amount_credit = @Original" & _
        "_GL_journal_amount_credit OR @Original_GL_journal_amount_credit IS NULL AND GL_j" & _
        "ournal_amount_credit IS NULL) AND (GL_journal_amount_debit = @Original_GL_journa" & _
        "l_amount_debit OR @Original_GL_journal_amount_debit IS NULL AND GL_journal_amoun" & _
        "t_debit IS NULL) AND (GL_journal_reference = @Original_GL_journal_reference OR @" & _
        "Original_GL_journal_reference IS NULL AND GL_journal_reference IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_journal_amount_credit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_journal_amount_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_journal_amount_debit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_journal_amount_debit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_journal_reference", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_journal_reference", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaGL_journal_dtl
        '
        Me.DaGL_journal_dtl.DeleteCommand = Me.SqlDeleteCommand2
        Me.DaGL_journal_dtl.InsertCommand = Me.SqlInsertCommand2
        Me.DaGL_journal_dtl.SelectCommand = Me.SqlSelectCommand4
        Me.DaGL_journal_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_journal_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("GL_journal_reference", "GL_journal_reference"), New System.Data.Common.DataColumnMapping("GL_journal_amount_debit", "GL_journal_amount_debit"), New System.Data.Common.DataColumnMapping("GL_journal_amount_credit", "GL_journal_amount_credit")})})
        Me.DaGL_journal_dtl.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT bas_banks.GL_Account AS Gl_AccountBank, SUM(ROUND(GL_debit_deposit.deposit" & _
        "_amount, 2)) AS Sumdeposit_amount FROM GL_debit_deposit_head INNER JOIN GL_debit" & _
        "_deposit ON GL_debit_deposit_head.id_debit_deposit_head = GL_debit_deposit.id_de" & _
        "bit_deposit_head INNER JOIN bas_banks ON GL_debit_deposit_head.id_bank = bas_ban" & _
        "ks.id_bank WHERE (GL_debit_deposit.type_transaction = '1') AND (GL_debit_deposit" & _
        "_head.id_GL_journal IS NULL) AND (dbo.ChangeDate(GL_debit_deposit_head.date_doc)" & _
        " >= @FromDate) AND (dbo.ChangeDate(GL_debit_deposit_head.date_doc) <= @ToDate) G" & _
        "ROUP BY bas_banks.GL_Account"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaDeposit1
        '
        Me.DaDeposit1.SelectCommand = Me.SqlSelectCommand6
        Me.DaDeposit1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_debit_deposit_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("date_doc", "date_doc"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("cash_back_memo", "cash_back_memo"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'DaDeposit3
        '
        Me.DaDeposit3.SelectCommand = Me.SqlCommand2
        Me.DaDeposit3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_debit_deposit_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("date_doc", "date_doc"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("cash_back_memo", "cash_back_memo"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT bas_banks.GL_Account AS Gl_AccountBank, SUM(ROUND(GL_debit_deposit.debit_a" & _
        "mount, 2)) AS Sumdebit_amount FROM GL_debit_deposit_head INNER JOIN GL_debit_dep" & _
        "osit ON GL_debit_deposit_head.id_debit_deposit_head = GL_debit_deposit.id_debit_" & _
        "deposit_head INNER JOIN bas_banks ON GL_debit_deposit_head.id_bank = bas_banks.i" & _
        "d_bank WHERE (GL_debit_deposit.type_transaction = '3') AND (GL_debit_deposit_hea" & _
        "d.id_GL_journal IS NULL) AND (dbo.ChangeDate(GL_debit_deposit_head.date_doc) >= " & _
        "@FromDate) AND (dbo.ChangeDate(GL_debit_deposit_head.date_doc) <= @ToDate) GROUP" & _
        " BY bas_banks.GL_Account"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT SUM(ROUND(amount, 2)) AS SumAmount, GL_account FROM GL_Paid_received WHERE" & _
        " (tran_type = @Tran_type) AND (Id_GL_journal IS NULL) AND (dbo.ChangeDate(action" & _
        "_date) >= @FromDate) AND (dbo.ChangeDate(action_date) <= @ToDate) GROUP BY GL_ac" & _
        "count"
        Me.SqlSelectCommand7.Connection = Me.Cnn
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tran_type", System.Data.SqlDbType.VarChar, 1, "tran_type"))
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'GlPaid
        '
        Me.GlPaid.SelectCommand = Me.SqlSelectCommand7
        Me.GlPaid.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_Paid_received", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_code", "refrence_code"), New System.Data.Common.DataColumnMapping("tran_type", "tran_type"), New System.Data.Common.DataColumnMapping("action_date", "action_date"), New System.Data.Common.DataColumnMapping("customer_code", "customer_code"), New System.Data.Common.DataColumnMapping("vendor_code", "vendor_code"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'DaDeposit4
        '
        Me.DaDeposit4.SelectCommand = Me.SqlCommand3
        Me.DaDeposit4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_debit_deposit_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("date_doc", "date_doc"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("cash_back_memo", "cash_back_memo"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT GL_debit_deposit.debit_amount, GL_debit_deposit.GL_account FROM GL_debit_d" & _
        "eposit_head INNER JOIN GL_debit_deposit ON GL_debit_deposit_head.id_debit_deposi" & _
        "t_head = GL_debit_deposit.id_debit_deposit_head WHERE (GL_debit_deposit.type_tra" & _
        "nsaction = '3') AND (GL_debit_deposit_head.id_GL_journal IS NULL) AND (dbo.Chang" & _
        "eDate(GL_debit_deposit_head.date_doc) >= @FromDate) AND (dbo.ChangeDate(GL_debit" & _
        "_deposit_head.date_doc) <= @ToDate) AND (GL_debit_deposit.debit_amount > 0)"
        Me.SqlCommand3.Connection = Me.Cnn
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT bank_ATM.id_ATM, bank_ATM.id_bank, bank_ATM.date_transaction, bank_ATM.amo" & _
        "unt_ATM, bas_banks.GL_Account AS GL_AccountBank, bank_ATM_dtl.GL_account, bank_A" & _
        "TM_dtl.amount, bas_banks.name_bank FROM bank_ATM INNER JOIN bas_banks ON bank_AT" & _
        "M.id_bank = bas_banks.id_bank INNER JOIN bank_ATM_dtl ON bank_ATM.id_ATM = bank_" & _
        "ATM_dtl.id_ATM WHERE (bank_ATM.id_GL_journal IS NULL) AND (bank_ATM.id_bank = @i" & _
        "d_bank) AND (bank_ATM.ChargeCredit = @ChargeCredit) AND (dbo.ChangeDate(bank_ATM" & _
        ".date_transaction) >= @FromDate) AND (dbo.ChangeDate(bank_ATM.date_transaction) " & _
        "<= @ToDate)"
        Me.SqlSelectCommand8.Connection = Me.Cnn
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ChargeCredit", System.Data.SqlDbType.VarChar, 1, "ChargeCredit"))
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaBankAtm
        '
        Me.DaBankAtm.SelectCommand = Me.SqlSelectCommand8
        Me.DaBankAtm.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_ATM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_ATM", "id_ATM"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("date_transaction", "date_transaction"), New System.Data.Common.DataColumnMapping("amount_ATM", "amount_ATM"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("memo_address", "memo_address"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("ChargeCredit", "ChargeCredit"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT id_bank, name_bank, share_all_store, store_no, account_no, address, zip, p" & _
        "hone_1, extension_1, phone_type_1, phone_main_1, phone_2, extension_2, phone_typ" & _
        "e_2, phone_main_2, phone_3, extension_3, phone_type_3, phone_main_3, phone_4, ex" & _
        "tension_4, phone_type_4, phone_main_4, phone_5, extension_5, phone_type_5, phone" & _
        "_main_5, email, contact_name, GL_Account, start_check_no, next_check_no, default" & _
        "_bank, inactive, cod_account_type, routing_numbers, Bank_ID, Web_Page, User_ID, " & _
        "Password, Security_code, online_banking FROM bas_banks WHERE (NOT (GL_Account IS" & _
        " NULL))"
        Me.SqlSelectCommand9.Connection = Me.CnnUnlock
        '
        'DaBaseBank
        '
        Me.DaBaseBank.SelectCommand = Me.SqlSelectCommand9
        Me.DaBaseBank.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_banks", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("name_bank", "name_bank"), New System.Data.Common.DataColumnMapping("share_all_store", "share_all_store"), New System.Data.Common.DataColumnMapping("store_no", "store_no"), New System.Data.Common.DataColumnMapping("account_no", "account_no"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("contact_name", "contact_name"), New System.Data.Common.DataColumnMapping("GL_Account", "GL_Account"), New System.Data.Common.DataColumnMapping("start_check_no", "start_check_no"), New System.Data.Common.DataColumnMapping("next_check_no", "next_check_no"), New System.Data.Common.DataColumnMapping("default_bank", "default_bank"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("cod_account_type", "cod_account_type"), New System.Data.Common.DataColumnMapping("routing_numbers", "routing_numbers"), New System.Data.Common.DataColumnMapping("Bank_ID", "Bank_ID"), New System.Data.Common.DataColumnMapping("Web_Page", "Web_Page"), New System.Data.Common.DataColumnMapping("User_ID", "User_ID"), New System.Data.Common.DataColumnMapping("Password", "Password"), New System.Data.Common.DataColumnMapping("Security_code", "Security_code"), New System.Data.Common.DataColumnMapping("online_banking", "online_banking")})})
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT GL_transfer_amount.id_transfer, GL_transfer_amount.id_bank_from_transfer, " & _
        "GL_transfer_amount.date_transfer, GL_transfer_amount.amount_transfer, bas_banks." & _
        "GL_Account AS GL_AccountBank FROM GL_transfer_amount INNER JOIN bas_banks ON GL_" & _
        "transfer_amount.id_bank_from_transfer = bas_banks.id_bank WHERE (GL_transfer_amo" & _
        "unt.id_bank_from_transfer = @Id_Bank) AND (GL_transfer_amount.id_GL_journal IS N" & _
        "ULL) AND (bas_banks.id_bank = @Id_Bank) AND (dbo.ChangeDate(GL_transfer_amount.d" & _
        "ate_transfer) >= @FromDate) AND (dbo.ChangeDate(GL_transfer_amount.date_transfer" & _
        ") <= @ToDate)"
        Me.SqlSelectCommand10.Connection = Me.Cnn
        Me.SqlSelectCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Bank", System.Data.SqlDbType.Int, 4, "id_bank_from_transfer"))
        Me.SqlSelectCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaGlTransferFrom
        '
        Me.DaGlTransferFrom.SelectCommand = Me.SqlSelectCommand10
        Me.DaGlTransferFrom.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_transfer_amount", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_transfer", "id_transfer"), New System.Data.Common.DataColumnMapping("id_bank_from_transfer", "id_bank_from_transfer"), New System.Data.Common.DataColumnMapping("id_bank_to_transfer", "id_bank_to_transfer"), New System.Data.Common.DataColumnMapping("date_transfer", "date_transfer"), New System.Data.Common.DataColumnMapping("amount_transfer", "amount_transfer"), New System.Data.Common.DataColumnMapping("memo", "memo")})})
        '
        'DaGlTransferTo
        '
        Me.DaGlTransferTo.SelectCommand = Me.SqlCommand4
        Me.DaGlTransferTo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_transfer_amount", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_transfer", "id_transfer"), New System.Data.Common.DataColumnMapping("id_bank_from_transfer", "id_bank_from_transfer"), New System.Data.Common.DataColumnMapping("id_bank_to_transfer", "id_bank_to_transfer"), New System.Data.Common.DataColumnMapping("date_transfer", "date_transfer"), New System.Data.Common.DataColumnMapping("amount_transfer", "amount_transfer"), New System.Data.Common.DataColumnMapping("memo", "memo")})})
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "SELECT GL_transfer_amount.id_transfer, GL_transfer_amount.date_transfer, GL_trans" & _
        "fer_amount.amount_transfer, bas_banks.GL_Account AS GL_AccountBank, GL_transfer_" & _
        "amount.id_bank_to_transfer FROM GL_transfer_amount INNER JOIN bas_banks ON GL_tr" & _
        "ansfer_amount.id_bank_to_transfer = bas_banks.id_bank WHERE (GL_transfer_amount." & _
        "id_GL_journal IS NULL) AND (bas_banks.id_bank = @Id_Bank) AND (dbo.ChangeDate(GL" & _
        "_transfer_amount.date_transfer) >= @FromDate) AND (dbo.ChangeDate(GL_transfer_am" & _
        "ount.date_transfer) <= @ToDate) AND (GL_transfer_amount.id_bank_to_transfer = @I" & _
        "d_Bank)"
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT bank_adjustment_head.Id_Adjustment_no, bank_adjustment_head.adjustment_dat" & _
        "e, Bank_Adjustment_dtl.Gl_Account, Bank_Adjustment_dtl.debit_amount, Bank_Adjust" & _
        "ment_dtl.deposit_amount, bas_banks.GL_Account AS Gl_AccountBank FROM bank_adjust" & _
        "ment_head INNER JOIN Bank_Adjustment_dtl ON bank_adjustment_head.Id_Adjustment_n" & _
        "o = Bank_Adjustment_dtl.Id_Adjustment_no INNER JOIN bas_banks ON bank_adjustment" & _
        "_head.id_Bank = bas_banks.id_bank WHERE (bank_adjustment_head.id_GL_journal IS N" & _
        "ULL) AND (dbo.ChangeDate(bank_adjustment_head.adjustment_date) >= @FromDate) AND" & _
        " (dbo.ChangeDate(bank_adjustment_head.adjustment_date) <= @ToDate) AND (bas_bank" & _
        "s.id_bank = @id_bank)"
        Me.SqlSelectCommand11.Connection = Me.Cnn
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        '
        'DaBankAdjustment
        '
        Me.DaBankAdjustment.SelectCommand = Me.SqlSelectCommand11
        Me.DaBankAdjustment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Adjustment_no", "Id_Adjustment_no"), New System.Data.Common.DataColumnMapping("adjustment_date", "adjustment_date"), New System.Data.Common.DataColumnMapping("employee_cod", "employee_cod"), New System.Data.Common.DataColumnMapping("id_Bank", "id_Bank"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "SELECT inv_tab_type_item.GL_account, service_center_dtl.qty, service_center_dtl.A" & _
        "VERAGE_COST, inv_tab_type_item.GL_account_cost_good, service_center_dtl.price, i" & _
        "nv_item_cost_transaction.cost + inv_item_cost_transaction.delivery + inv_item_co" & _
        "st_transaction.frieght AS ReplceMentCost, service_center_head.id_service_center," & _
        " service_center_dtl.type_select FROM inv_item INNER JOIN inv_tab_type_item ON in" & _
        "v_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN service_center" & _
        "_head INNER JOIN service_center_dtl ON service_center_head.id_service_center = s" & _
        "ervice_center_dtl.id_service_center ON inv_item.item_no = service_center_dtl.cod" & _
        "_select INNER JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item_cost" & _
        "_transaction.item_no WHERE (service_center_head.id_GL_journal IS NULL) AND (serv" & _
        "ice_center_head.type_of_form = @type_of_form) AND (service_center_dtl.type_selec" & _
        "t = 'I' OR service_center_dtl.type_select = 'A') AND (dbo.ChangeDate(service_cen" & _
        "ter_head.date_refer) >= @FromDate) AND (dbo.ChangeDate(service_center_head.date_" & _
        "refer) <= @ToDate) AND (inv_item_cost_transaction.last_flag = 1)"
        Me.SqlSelectCommand12.Connection = Me.Cnn
        Me.SqlSelectCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlSelectCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaAnbar
        '
        Me.DaAnbar.SelectCommand = Me.SqlSelectCommand12
        Me.DaAnbar.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'DaForosh1
        '
        Me.DaForosh1.SelectCommand = Me.SqlCommand5
        Me.DaForosh1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT SUM(ROUND(service_center_dtl.qty * (service_center_dtl.fet + service_cente" & _
        "r_dtl.price), 2)) AS QtyCost, inv_tab_type_item.cod_item_type, inv_tab_type_item" & _
        ".GL_account_sales_income, inv_tab_type_item.desc_item_type FROM service_center_h" & _
        "ead LEFT OUTER JOIN inv_tab_type_item RIGHT OUTER JOIN inv_item RIGHT OUTER JOIN" & _
        " service_center_dtl ON inv_item.item_no = service_center_dtl.cod_select ON inv_t" & _
        "ab_type_item.cod_item_type = inv_item.cod_item_type ON service_center_head.id_se" & _
        "rvice_center = service_center_dtl.id_service_center WHERE (service_center_head.i" & _
        "d_GL_journal IS NULL) AND (service_center_head.type_of_form = @type_of_form) AND" & _
        " (service_center_dtl.type_select IN ('I', 'O', 'A')) AND (dbo.ChangeDate(service" & _
        "_center_head.date_refer) >= @FromDate) AND (dbo.ChangeDate(service_center_head.d" & _
        "ate_refer) <= @ToDate) AND (service_center_head.id_service_center IN (SELECT id_" & _
        "service_center FROM gl_payment_deposit)) GROUP BY inv_tab_type_item.cod_item_typ" & _
        "e, inv_tab_type_item.GL_account_sales_income, inv_tab_type_item.desc_item_type"
        Me.SqlCommand5.Connection = Me.Cnn
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaTax
        '
        Me.DaTax.SelectCommand = Me.SqlCommand6
        Me.DaTax.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = "SELECT SUM(ROUND(tax, 2)) AS SumTax FROM service_center_head WHERE (id_GL_journal" & _
        " IS NULL) AND (type_of_form = @type_of_form) AND (dbo.ChangeDate(date_refer) >= " & _
        "@FromDate) AND (dbo.ChangeDate(date_refer) <= @ToDate) AND (id_service_center IN" & _
        " (SELECT id_service_center FROM gl_payment_deposit))"
        Me.SqlCommand6.Connection = Me.Cnn
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaForoshDeposit
        '
        Me.DaForoshDeposit.SelectCommand = Me.SqlCommand7
        Me.DaForoshDeposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = "SELECT service_center_head.id_service_center, service_center_head.type_of_form, s" & _
        "ervice_center_head.cod_customer, service_center_head.date_refer, inv_tab_service" & _
        "_type.income_GL_account, GL_payment_deposit.payment_amount, GL_payment_deposit.p" & _
        "ayment_type, GL_payment_deposit.refer_type FROM service_center_head INNER JOIN G" & _
        "L_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit." & _
        "id_service_center LEFT OUTER JOIN inv_tab_type_item INNER JOIN inv_item INNER JO" & _
        "IN service_center_dtl ON inv_item.item_no = service_center_dtl.cod_select ON inv" & _
        "_tab_type_item.cod_item_type = inv_item.cod_item_type INNER JOIN inv_tab_labor_s" & _
        "ervice INNER JOIN inv_tab_service_type ON inv_tab_labor_service.service_type = i" & _
        "nv_tab_service_type.service_type ON service_center_dtl.cod_select = inv_tab_labo" & _
        "r_service.cod_service ON service_center_head.id_service_center = service_center_" & _
        "dtl.id_service_center WHERE (service_center_head.id_GL_journal IS NULL) AND (ser" & _
        "vice_center_head.type_of_form = @type_of_form) AND (dbo.ChangeDate(service_cente" & _
        "r_head.date_refer) >= @FromDate) AND (dbo.ChangeDate(service_center_head.date_re" & _
        "fer) <= @ToDate) AND (service_center_head.id_service_center NOT IN (SELECT id_se" & _
        "rvice_center FROM service_center_dtl WHERE (type_select = 'B')))"
        Me.SqlCommand7.Connection = Me.Cnn
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'Grd1
        '
        Me.Grd1.AllowColumnDrag = False
        Me.Grd1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.Grd1.AlternatingRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.Grd1.AlternatingRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.Grd1.AlternatingRowFormatStyle.ForeColor = System.Drawing.SystemColors.Window
        Me.Grd1.AutomaticSort = False
        Me.Grd1.BackColor = System.Drawing.SystemColors.Control
        Me.Grd1.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.Grd1.DataSource = Me.DsFrmCloseDay1.GL_journal_dtl
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_journal_dtl</Caption><Columns Collection" & _
        "=""true""><Column0 ID=""id_GL_journal""><Caption>id_GL_journal</Caption><TypeNameEmp" & _
        "tyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>id_" & _
        "GL_journal</DataMember><Key>id_GL_journal</Key><Position>0</Position><Visible>Fa" & _
        "lse</Visible><Width>93</Width></Column0><Column1 ID=""radif""><Caption>Line Number" & _
        "</Caption><TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringV" & _
        "alue /><DataMember>radif</DataMember><Key>radif</Key><Position>1</Position><Widt" & _
        "h>56</Width></Column1><Column2 ID=""GL_account""><Caption>GL Account No</Caption><" & _
        "DataMember>GL_account</DataMember><Key>GL_account</Key><Position>2</Position><Wi" & _
        "dth>125</Width></Column2><Column3 ID=""GL_journal_reference""><Caption>Reference</" & _
        "Caption><DataMember>GL_journal_reference</DataMember><Key>GL_journal_reference</" & _
        "Key><Position>3</Position><Width>327</Width></Column3><Column4 ID=""GL_journal_am" & _
        "ount_debit""><AggregateFunction>Sum</AggregateFunction><Caption>Debit</Caption><D" & _
        "ataMember>GL_journal_amount_debit</DataMember><FormatString>c2</FormatString><Ke" & _
        "y>GL_journal_amount_debit</Key><Position>4</Position><TextAlignment>Far</TextAli" & _
        "gnment><Width>180</Width><TotalFormatString>c2</TotalFormatString></Column4><Col" & _
        "umn5 ID=""GL_journal_amount_credit""><AggregateFunction>Sum</AggregateFunction><Ca" & _
        "ption>Credit</Caption><DataMember>GL_journal_amount_credit</DataMember><FormatSt" & _
        "ring>c2</FormatString><Key>GL_journal_amount_credit</Key><Position>5</Position><" & _
        "TextAlignment>Far</TextAlignment><Width>131</Width><TotalFormatString>c2</TotalF" & _
        "ormatString></Column5></Columns><GroupCondition ID="""" /><Key>GL_journal_dtl</Key" & _
        "><TotalRow>True</TotalRow></RootTable></GridEXLayoutData>"
        Me.Grd1.DesignTimeLayout = GridEXLayout1
        Me.Grd1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grd1.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.False
        Me.Grd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grd1.GridLineColor = System.Drawing.SystemColors.Control
        Me.Grd1.GridLines = Janus.Windows.GridEX.GridLines.Vertical
        Me.Grd1.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.Grd1.GroupByBoxVisible = False
        Me.Grd1.Location = New System.Drawing.Point(8, 217)
        Me.Grd1.Name = "Grd1"
        Me.Grd1.Size = New System.Drawing.Size(824, 72)
        Me.Grd1.TabIndex = 136
        Me.Grd1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'SqlSelectCommand13
        '
        Me.SqlSelectCommand13.CommandText = "SELECT refrence_no, amount_adjustment, date_adjustment, GL_account FROM GL_accoun" & _
        "t_adjustment_head WHERE (dbo.ChangeDate(date_adjustment) >= @FromDate) AND (dbo." & _
        "ChangeDate(date_adjustment) <= @ToDate) AND (id_GL_journal IS NULL) AND (amount_" & _
        "adjustment < 0)"
        Me.SqlSelectCommand13.Connection = Me.Cnn
        Me.SqlSelectCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaGlAccountAdjustment
        '
        Me.DaGlAccountAdjustment.SelectCommand = Me.SqlSelectCommand13
        Me.DaGlAccountAdjustment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlSelectCommand14
        '
        Me.SqlSelectCommand14.CommandText = "SELECT refrence_code, tran_type, action_date, customer_code, vendor_code, amount," & _
        " GL_account, memo, Id_GL_journal FROM GL_Paid_received WHERE (Id_GL_journal IS N" & _
        "ULL) AND (tran_type = '1') AND (dbo.ChangeDate(action_date) >= @FromDate) AND (d" & _
        "bo.ChangeDate(action_date) <= @ToDate)"
        Me.SqlSelectCommand14.Connection = Me.Cnn
        Me.SqlSelectCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaGlPaiedReceived
        '
        Me.DaGlPaiedReceived.SelectCommand = Me.SqlSelectCommand14
        Me.DaGlPaiedReceived.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_Paid_received", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_code", "refrence_code"), New System.Data.Common.DataColumnMapping("tran_type", "tran_type"), New System.Data.Common.DataColumnMapping("action_date", "action_date"), New System.Data.Common.DataColumnMapping("customer_code", "customer_code"), New System.Data.Common.DataColumnMapping("vendor_code", "vendor_code"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'DaGlPaiedReceived2
        '
        Me.DaGlPaiedReceived2.SelectCommand = Me.SqlCommand8
        Me.DaGlPaiedReceived2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_Paid_received", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_code", "refrence_code"), New System.Data.Common.DataColumnMapping("tran_type", "tran_type"), New System.Data.Common.DataColumnMapping("action_date", "action_date"), New System.Data.Common.DataColumnMapping("customer_code", "customer_code"), New System.Data.Common.DataColumnMapping("vendor_code", "vendor_code"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand8
        '
        Me.SqlCommand8.CommandText = "SELECT refrence_code, tran_type, action_date, customer_code, vendor_code, amount," & _
        " GL_account, memo, Id_GL_journal FROM GL_Paid_received WHERE (Id_GL_journal IS N" & _
        "ULL) AND (tran_type = '2') AND (dbo.ChangeDate(action_date) >= @FromDate) AND (d" & _
        "bo.ChangeDate(action_date) <= @ToDate)"
        Me.SqlCommand8.Connection = Me.Cnn
        Me.SqlCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'SqlSelectCommand15
        '
        Me.SqlSelectCommand15.CommandText = "SELECT SUM(ROUND(amount_receive, 2)) AS amount_receive FROM Gl_receive_payment WH" & _
        "ERE (dbo.ChangeDate(date_receive_payment) >= @FromDate) AND (dbo.ChangeDate(date" & _
        "_receive_payment) <= @ToDate) AND (id_GL_journal IS NULL)"
        Me.SqlSelectCommand15.Connection = Me.Cnn
        Me.SqlSelectCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'GlReceviePayment
        '
        Me.GlReceviePayment.SelectCommand = Me.SqlSelectCommand15
        Me.GlReceviePayment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Gl_receive_payment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("amount_receive", "amount_receive"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("pmt_method", "pmt_method"), New System.Data.Common.DataColumnMapping("cc_type", "cc_type"), New System.Data.Common.DataColumnMapping("cc_no", "cc_no"), New System.Data.Common.DataColumnMapping("Gl_account", "Gl_account"), New System.Data.Common.DataColumnMapping("date_receive_payment", "date_receive_payment"), New System.Data.Common.DataColumnMapping("check_no", "check_no"), New System.Data.Common.DataColumnMapping("expir_date_year", "expir_date_year"), New System.Data.Common.DataColumnMapping("expir_date_month", "expir_date_month")})})
        '
        'SqlSelectCommand16
        '
        Me.SqlSelectCommand16.CommandText = "SELECT SUM(ROUND(Inv_Receive_product_dtl.qty * Inv_Receive_product_dtl.cost, 2)) " & _
        "AS QtyCost, Inv_Receive_Products_head.bill_credit FROM Inv_Receive_Products_head" & _
        " INNER JOIN Inv_Receive_product_dtl ON Inv_Receive_Products_head.id_receive_ref " & _
        "= Inv_Receive_product_dtl.id_receive_ref WHERE (dbo.ChangeDate(Inv_Receive_Produ" & _
        "cts_head.date_receive) >= @FromDate) AND (dbo.ChangeDate(Inv_Receive_Products_he" & _
        "ad.date_receive) <= @ToDate) AND (Inv_Receive_Products_head.bill_credit = @BillC" & _
        "redit) AND (Inv_Receive_Products_head.id_GL_journal IS NULL) GROUP BY Inv_Receiv" & _
        "e_Products_head.bill_credit"
        Me.SqlSelectCommand16.Connection = Me.Cnn
        Me.SqlSelectCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillCredit", System.Data.SqlDbType.VarChar, 1, "bill_credit"))
        '
        'InvRecevieReturn
        '
        Me.InvRecevieReturn.SelectCommand = Me.SqlSelectCommand16
        Me.InvRecevieReturn.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_Products_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("date_receive", "date_receive"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("bill_credit", "bill_credit"), New System.Data.Common.DataColumnMapping("bill_receive", "bill_receive"), New System.Data.Common.DataColumnMapping("ap_term", "ap_term"), New System.Data.Common.DataColumnMapping("receipt_bill_date", "receipt_bill_date"), New System.Data.Common.DataColumnMapping("vendor_ref_no", "vendor_ref_no"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("house_comments", "house_comments"), New System.Data.Common.DataColumnMapping("vend_comments", "vend_comments"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'InvRecevieReturnCreadit
        '
        Me.InvRecevieReturnCreadit.SelectCommand = Me.SqlCommand9
        Me.InvRecevieReturnCreadit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_Products_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("date_receive", "date_receive"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("bill_credit", "bill_credit"), New System.Data.Common.DataColumnMapping("bill_receive", "bill_receive"), New System.Data.Common.DataColumnMapping("ap_term", "ap_term"), New System.Data.Common.DataColumnMapping("receipt_bill_date", "receipt_bill_date"), New System.Data.Common.DataColumnMapping("vendor_ref_no", "vendor_ref_no"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("house_comments", "house_comments"), New System.Data.Common.DataColumnMapping("vend_comments", "vend_comments"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand9
        '
        Me.SqlCommand9.CommandText = "SELECT SUM(ROUND(Inv_Receive_product_dtl.qty * Inv_Receive_product_dtl.cost, 2)) " & _
        "AS QtyCost, inv_tab_type_item.GL_account, inv_tab_type_item.cod_item_type, inv_t" & _
        "ab_type_item.desc_item_type FROM Inv_Receive_Products_head INNER JOIN Inv_Receiv" & _
        "e_product_dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_Receive_product_" & _
        "dtl.id_receive_ref INNER JOIN inv_item ON Inv_Receive_product_dtl.item_no = inv_" & _
        "item.item_no INNER JOIN inv_tab_type_item ON inv_item.cod_item_type = inv_tab_ty" & _
        "pe_item.cod_item_type WHERE (dbo.ChangeDate(Inv_Receive_Products_head.date_recei" & _
        "ve) >= @FromDate) AND (dbo.ChangeDate(Inv_Receive_Products_head.date_receive) <=" & _
        " @ToDate) AND (Inv_Receive_Products_head.bill_credit = @BillCredit) AND (Inv_Rec" & _
        "eive_Products_head.id_GL_journal IS NULL) GROUP BY inv_tab_type_item.GL_account," & _
        " inv_tab_type_item.cod_item_type, inv_tab_type_item.desc_item_type"
        Me.SqlCommand9.Connection = Me.Cnn
        Me.SqlCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillCredit", System.Data.SqlDbType.VarChar, 1, "bill_credit"))
        '
        'SqlSelectCommand17
        '
        Me.SqlSelectCommand17.CommandText = "SELECT inv_tab_type_item.GL_account, SUM(ROUND(inv_adjustment_dtl.QTY * inv_adjus" & _
        "tment_dtl.Cost, 2)) AS QtyCost, inv_tab_type_item.cod_item_type, inv_adjustment_" & _
        "head.GL_account_adjustment FROM inv_adjustment_head INNER JOIN inv_adjustment_dt" & _
        "l ON inv_adjustment_head.referID_adjustment = inv_adjustment_dtl.referID_adjustm" & _
        "ent INNER JOIN inv_item ON inv_adjustment_dtl.item_no = inv_item.item_no INNER J" & _
        "OIN inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_typ" & _
        "e WHERE (dbo.ChangeDate(inv_adjustment_head.date_adjustment) >= @FromDate) AND (" & _
        "dbo.ChangeDate(inv_adjustment_head.date_adjustment) <= @ToDate) AND (inv_adjustm" & _
        "ent_dtl.QTY < 0) AND (inv_adjustment_head.id_GL_journal IS NULL) GROUP BY inv_ta" & _
        "b_type_item.GL_account, inv_tab_type_item.cod_item_type, inv_adjustment_head.GL_" & _
        "account_adjustment"
        Me.SqlSelectCommand17.Connection = Me.Cnn
        Me.SqlSelectCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'invAdjustment
        '
        Me.invAdjustment.SelectCommand = Me.SqlSelectCommand17
        Me.invAdjustment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("referID_adjustment", "referID_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("adjustment_by", "adjustment_by"), New System.Data.Common.DataColumnMapping("authorized_by", "authorized_by"), New System.Data.Common.DataColumnMapping("explanation", "explanation"), New System.Data.Common.DataColumnMapping("GL_account_adjustment", "GL_account_adjustment"), New System.Data.Common.DataColumnMapping("comment", "comment"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'InvAdjustment2
        '
        Me.InvAdjustment2.SelectCommand = Me.SqlCommand10
        Me.InvAdjustment2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("referID_adjustment", "referID_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("adjustment_by", "adjustment_by"), New System.Data.Common.DataColumnMapping("authorized_by", "authorized_by"), New System.Data.Common.DataColumnMapping("explanation", "explanation"), New System.Data.Common.DataColumnMapping("GL_account_adjustment", "GL_account_adjustment"), New System.Data.Common.DataColumnMapping("comment", "comment"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand10
        '
        Me.SqlCommand10.CommandText = "SELECT inv_tab_type_item.GL_account, SUM(ROUND(inv_adjustment_dtl.QTY * inv_adjus" & _
        "tment_dtl.Cost, 2)) AS QtyCost, inv_tab_type_item.cod_item_type, inv_adjustment_" & _
        "head.GL_account_adjustment FROM inv_adjustment_head INNER JOIN inv_adjustment_dt" & _
        "l ON inv_adjustment_head.referID_adjustment = inv_adjustment_dtl.referID_adjustm" & _
        "ent INNER JOIN inv_item ON inv_adjustment_dtl.item_no = inv_item.item_no INNER J" & _
        "OIN inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_typ" & _
        "e WHERE (dbo.ChangeDate(inv_adjustment_head.date_adjustment) >= @FromDate) AND (" & _
        "dbo.ChangeDate(inv_adjustment_head.date_adjustment) <= @ToDate) AND (inv_adjustm" & _
        "ent_dtl.QTY > 0) AND (inv_adjustment_head.id_GL_journal IS NULL) GROUP BY inv_ta" & _
        "b_type_item.GL_account, inv_tab_type_item.cod_item_type, inv_adjustment_head.GL_" & _
        "account_adjustment"
        Me.SqlCommand10.Connection = Me.Cnn
        Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaAnbar2
        '
        Me.DaAnbar2.SelectCommand = Me.SqlCommand11
        Me.DaAnbar2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand11
        '
        Me.SqlCommand11.CommandText = "SELECT service_center_head.id_service_center, service_center_head.type_of_form, s" & _
        "ervice_center_head.cod_customer, service_center_head.date_refer, inv_tab_type_it" & _
        "em.GL_account, service_center_dtl.qty, service_center_dtl.AVERAGE_COST, inv_tab_" & _
        "type_item.GL_account_cost_good, service_center_dtl.price, inv_tab_type_item.GL_a" & _
        "ccount_sales_income, inv_tab_type_item.GL_account_returns, service_out_purchases" & _
        ".cost AS ReplacementCost FROM inv_item INNER JOIN inv_tab_type_item ON inv_item." & _
        "cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN service_center_head I" & _
        "NNER JOIN service_center_dtl ON service_center_head.id_service_center = service_" & _
        "center_dtl.id_service_center ON inv_item.item_no = service_center_dtl.cod_select" & _
        " INNER JOIN service_out_purchases ON service_center_dtl.id_service_center = serv" & _
        "ice_out_purchases.id_service_center AND service_center_dtl.radif = service_out_p" & _
        "urchases.radif WHERE (service_center_head.id_GL_journal IS NULL) AND (service_ce" & _
        "nter_head.type_of_form = @type_of_form) AND (service_center_dtl.type_select = 'O" & _
        "') AND (dbo.ChangeDate(service_center_head.date_refer) >= @FromDate) AND (dbo.Ch" & _
        "angeDate(service_center_head.date_refer) <= @ToDate)"
        Me.SqlCommand11.Connection = Me.Cnn
        Me.SqlCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaForosh2
        '
        Me.DaForosh2.SelectCommand = Me.SqlCommand12
        Me.DaForosh2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand12
        '
        Me.SqlCommand12.CommandText = "SELECT SUM(ROUND(service_center_dtl.qty * (service_center_dtl.fet + service_cente" & _
        "r_dtl.price), 2)) AS QtyCost, inv_tab_service_type.service_type, inv_tab_service" & _
        "_type.income_GL_account FROM service_center_head LEFT OUTER JOIN inv_tab_type_it" & _
        "em RIGHT OUTER JOIN inv_item RIGHT OUTER JOIN inv_tab_labor_service INNER JOIN i" & _
        "nv_tab_service_type ON inv_tab_labor_service.service_type = inv_tab_service_type" & _
        ".service_type INNER JOIN service_center_dtl ON inv_tab_labor_service.cod_service" & _
        " = service_center_dtl.cod_select ON inv_item.item_no = service_center_dtl.cod_se" & _
        "lect ON inv_tab_type_item.cod_item_type = inv_item.cod_item_type ON service_cent" & _
        "er_head.id_service_center = service_center_dtl.id_service_center WHERE (service_" & _
        "center_head.id_GL_journal IS NULL) AND (service_center_head.type_of_form = @type" & _
        "_of_form) AND (service_center_dtl.type_select IN ('L', 'F', 'S')) AND (dbo.Chang" & _
        "eDate(service_center_head.date_refer) >= @FromDate) AND (dbo.ChangeDate(service_" & _
        "center_head.date_refer) <= @ToDate) AND (service_center_head.id_service_center I" & _
        "N (SELECT id_service_center FROM gl_payment_deposit)) GROUP BY inv_tab_type_item" & _
        ".cod_item_type, inv_tab_service_type.service_type, inv_tab_service_type.income_G" & _
        "L_account"
        Me.SqlCommand12.Connection = Me.Cnn
        Me.SqlCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaForosh3
        '
        Me.DaForosh3.SelectCommand = Me.SqlCommand13
        Me.DaForosh3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand13
        '
        Me.SqlCommand13.CommandText = "SELECT SUM(ROUND(service_center_dtl.qty * (service_center_dtl.fet + service_cente" & _
        "r_dtl.price), 2)) AS QtyCost, inv_tab_service_type.service_type, inv_tab_service" & _
        "_type.income_GL_account FROM service_center_head LEFT OUTER JOIN inv_tab_type_it" & _
        "em RIGHT OUTER JOIN inv_item RIGHT OUTER JOIN inv_tab_labor_service INNER JOIN i" & _
        "nv_tab_service_type ON inv_tab_labor_service.service_type = inv_tab_service_type" & _
        ".service_type INNER JOIN service_center_dtl ON inv_tab_labor_service.cod_service" & _
        " = service_center_dtl.cod_select ON inv_item.item_no = service_center_dtl.cod_se" & _
        "lect ON inv_tab_type_item.cod_item_type = inv_item.cod_item_type ON service_cent" & _
        "er_head.id_service_center = service_center_dtl.id_service_center WHERE (service_" & _
        "center_head.id_GL_journal IS NULL) AND (service_center_head.type_of_form = @type" & _
        "_of_form) AND (service_center_dtl.type_select IN ('C')) AND (dbo.ChangeDate(serv" & _
        "ice_center_head.date_refer) >= @FromDate) AND (dbo.ChangeDate(service_center_hea" & _
        "d.date_refer) <= @ToDate) AND (service_center_head.id_service_center IN (SELECT " & _
        "id_service_center FROM gl_payment_deposit)) GROUP BY inv_tab_type_item.cod_item_" & _
        "type, inv_tab_service_type.service_type, inv_tab_service_type.income_GL_account"
        Me.SqlCommand13.Connection = Me.Cnn
        Me.SqlCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaAnbarCustomerReturn
        '
        Me.DaAnbarCustomerReturn.SelectCommand = Me.SqlCommand14
        Me.DaAnbarCustomerReturn.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand14
        '
        Me.SqlCommand14.CommandText = "SELECT service_center_head.id_service_center, service_center_head.type_of_form, s" & _
        "ervice_center_head.cod_customer, service_center_head.date_refer, inv_tab_type_it" & _
        "em.GL_account, service_center_dtl.qty, service_center_dtl.AVERAGE_COST, inv_tab_" & _
        "type_item.GL_account_cost_good, service_center_dtl.price, inv_tab_type_item.GL_a" & _
        "ccount_sales_income, inv_tab_type_item.GL_account_returns, inv_item_cost_transac" & _
        "tion.cost + inv_item_cost_transaction.delivery + inv_item_cost_transaction.frieg" & _
        "ht AS ReplaceMentCost FROM inv_item INNER JOIN inv_tab_type_item ON inv_item.cod" & _
        "_item_type = inv_tab_type_item.cod_item_type INNER JOIN service_center_head INNE" & _
        "R JOIN service_center_dtl ON service_center_head.id_service_center = service_cen" & _
        "ter_dtl.id_service_center ON inv_item.item_no = service_center_dtl.cod_select IN" & _
        "NER JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transacti" & _
        "on.item_no WHERE (service_center_head.id_GL_journal IS NULL) AND (service_center" & _
        "_head.type_of_form = @type_of_form) AND (service_center_dtl.type_select IN ('I'," & _
        " 'A')) AND (dbo.ChangeDate(service_center_head.date_refer) >= @FromDate) AND (db" & _
        "o.ChangeDate(service_center_head.date_refer) <= @ToDate) AND (inv_item_cost_tran" & _
        "saction.last_flag = 1)"
        Me.SqlCommand14.Connection = Me.Cnn
        Me.SqlCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaAndbarCustomerReturn2
        '
        Me.DaAndbarCustomerReturn2.SelectCommand = Me.SqlCommand15
        Me.DaAndbarCustomerReturn2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand15
        '
        Me.SqlCommand15.CommandText = "SELECT service_center_head.id_service_center, service_center_head.type_of_form, s" & _
        "ervice_center_head.cod_customer, service_center_head.date_refer, inv_tab_type_it" & _
        "em.GL_account, service_center_dtl.qty, service_center_dtl.AVERAGE_COST, inv_tab_" & _
        "type_item.GL_account_cost_good, service_center_dtl.price, inv_tab_type_item.GL_a" & _
        "ccount_sales_income, inv_tab_type_item.GL_account_returns, service_out_purchases" & _
        ".cost AS ReplaceMentCost FROM inv_item INNER JOIN inv_tab_type_item ON inv_item." & _
        "cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN service_center_head I" & _
        "NNER JOIN service_center_dtl ON service_center_head.id_service_center = service_" & _
        "center_dtl.id_service_center ON inv_item.item_no = service_center_dtl.cod_select" & _
        " INNER JOIN service_out_purchases ON service_center_dtl.id_service_center = serv" & _
        "ice_out_purchases.id_service_center AND service_center_dtl.radif = service_out_p" & _
        "urchases.radif WHERE (service_center_head.id_GL_journal IS NULL) AND (service_ce" & _
        "nter_head.type_of_form = @type_of_form) AND (service_center_dtl.type_select IN (" & _
        "'O')) AND (dbo.ChangeDate(service_center_head.date_refer) >= @FromDate) AND (dbo" & _
        ".ChangeDate(service_center_head.date_refer) <= @ToDate)"
        Me.SqlCommand15.Connection = Me.Cnn
        Me.SqlCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaGlAccountAdjustment2
        '
        Me.DaGlAccountAdjustment2.SelectCommand = Me.SqlCommand16
        Me.DaGlAccountAdjustment2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand16
        '
        Me.SqlCommand16.CommandText = "SELECT refrence_no, amount_adjustment, date_adjustment, GL_account FROM GL_accoun" & _
        "t_adjustment_head WHERE (dbo.ChangeDate(date_adjustment) >= @FromDate) AND (dbo." & _
        "ChangeDate(date_adjustment) <= @ToDate) AND (id_GL_journal IS NULL) AND (amount_" & _
        "adjustment > 0)"
        Me.SqlCommand16.Connection = Me.Cnn
        Me.SqlCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT inv_tab_type_item.GL_account, SUM(ROUND((inv_sales_transfer_dtl.price + in" & _
        "v_sales_transfer_dtl.fet) * inv_sales_transfer_dtl.qty, 2)) AS sum1, inv_tab_typ" & _
        "e_item.GL_account_cost_good, inv_salse_transfer_head.store_from FROM inv_sales_t" & _
        "ransfer_dtl INNER JOIN inv_salse_transfer_head ON inv_sales_transfer_dtl.ID_sale" & _
        "s_transfer = inv_salse_transfer_head.ID_sales_transfer INNER JOIN inv_item ON in" & _
        "v_sales_transfer_dtl.item_no = inv_item.item_no INNER JOIN inv_tab_type_item ON " & _
        "inv_item.cod_item_type = inv_tab_type_item.cod_item_type WHERE (inv_salse_transf" & _
        "er_head.store_from = @StoreFrom) AND (inv_salse_transfer_head.type_sales_transfe" & _
        "r = @type1) AND (dbo.ChangeDate(inv_salse_transfer_head.date_action) >= @FromDat" & _
        "e) AND (dbo.ChangeDate(inv_salse_transfer_head.date_action) <= @ToDate) AND (inv" & _
        "_salse_transfer_head.id_GL_journal IS NULL) GROUP BY inv_tab_type_item.GL_accoun" & _
        "t, inv_tab_type_item.GL_account_cost_good, inv_salse_transfer_head.store_from"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreFrom", System.Data.SqlDbType.VarChar, 2, "store_from"))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type1", System.Data.SqlDbType.VarChar, 1, "type_sales_transfer"))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaInvSalesTransfer
        '
        Me.DaInvSalesTransfer.SelectCommand = Me.SqlSelectCommand2
        Me.DaInvSalesTransfer.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_sales_transfer_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_sales_transfer", "ID_sales_transfer"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet")})})
        '
        'Daforosh4
        '
        Me.Daforosh4.SelectCommand = Me.SqlCommand17
        Me.Daforosh4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand17
        '
        Me.SqlCommand17.CommandText = "SELECT SUM(ROUND(service_center_dtl.qty * (service_center_dtl.price + service_cen" & _
        "ter_dtl.fet), 2)) AS Subtotal, SUM(service_center_dtl.qty * (service_center_dtl." & _
        "price + service_center_dtl.fet) * service_center_head.discount / 100) AS amountd" & _
        "iscount FROM service_center_head INNER JOIN service_center_dtl ON service_center" & _
        "_head.id_service_center = service_center_dtl.id_service_center WHERE (dbo.Change" & _
        "Date(service_center_head.date_refer) >= @FromDate) AND (dbo.ChangeDate(service_c" & _
        "enter_head.date_refer) <= @ToDate) AND (service_center_head.type_of_form = @type" & _
        "_of_form) AND (service_center_head.id_GL_journal IS NULL)"
        Me.SqlCommand17.Connection = Me.Cnn
        Me.SqlCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand17.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        '
        'DaGlPaiedReceived3
        '
        Me.DaGlPaiedReceived3.SelectCommand = Me.SqlCommand18
        Me.DaGlPaiedReceived3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_Paid_received", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_code", "refrence_code"), New System.Data.Common.DataColumnMapping("tran_type", "tran_type"), New System.Data.Common.DataColumnMapping("action_date", "action_date"), New System.Data.Common.DataColumnMapping("customer_code", "customer_code"), New System.Data.Common.DataColumnMapping("vendor_code", "vendor_code"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand18
        '
        Me.SqlCommand18.CommandText = "SELECT refrence_code, tran_type, action_date, customer_code, vendor_code, amount," & _
        " GL_account, memo, Id_GL_journal FROM GL_Paid_received WHERE (Id_GL_journal IS N" & _
        "ULL) AND (tran_type = '3') AND (dbo.ChangeDate(action_date) >= @FromDate) AND (d" & _
        "bo.ChangeDate(action_date) <= @ToDate)"
        Me.SqlCommand18.Connection = Me.Cnn
        Me.SqlCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaInterStor
        '
        Me.DaInterStor.SelectCommand = Me.SqlCommand19
        Me.DaInterStor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_sales_transfer_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_sales_transfer", "ID_sales_transfer"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet")})})
        '
        'SqlCommand19
        '
        Me.SqlCommand19.CommandText = "SELECT inv_tab_type_item.GL_account, SUM(ROUND((inv_sales_transfer_dtl.price + in" & _
        "v_sales_transfer_dtl.fet) * inv_sales_transfer_dtl.qty, 2)) AS sum1, inv_tab_typ" & _
        "e_item.GL_account_cost_good, inv_salse_transfer_head.store_from FROM inv_sales_t" & _
        "ransfer_dtl INNER JOIN inv_salse_transfer_head ON inv_sales_transfer_dtl.ID_sale" & _
        "s_transfer = inv_salse_transfer_head.ID_sales_transfer INNER JOIN inv_item ON in" & _
        "v_sales_transfer_dtl.item_no = inv_item.item_no INNER JOIN inv_tab_type_item ON " & _
        "inv_item.cod_item_type = inv_tab_type_item.cod_item_type WHERE (inv_salse_transf" & _
        "er_head.store_from = @StoreFrom) AND (inv_salse_transfer_head.type_sales_transfe" & _
        "r = @type1) AND (dbo.ChangeDate(inv_salse_transfer_head.date_action) >= @FromDat" & _
        "e) AND (dbo.ChangeDate(inv_salse_transfer_head.date_action) <= @ToDate) AND (inv" & _
        "_salse_transfer_head.id_GL_journal IS NULL) GROUP BY inv_tab_type_item.GL_accoun" & _
        "t, inv_tab_type_item.GL_account_cost_good, inv_salse_transfer_head.store_from"
        Me.SqlCommand19.Connection = Me.Cnn
        Me.SqlCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreFrom", System.Data.SqlDbType.VarChar, 2, "store_from"))
        Me.SqlCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type1", System.Data.SqlDbType.VarChar, 1, "type_sales_transfer"))
        Me.SqlCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand19.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'Cnn2
        '
        Me.Cnn2.ConnectionString = "workstation id=FARAJI;packet size=4096;user id=sa;data source=""."";persist securit" & _
        "y info=True;initial catalog=TireMate_01;password=5332"
        '
        'Cnn1
        '
        Me.Cnn1.ConnectionString = "workstation id=FARAJI;packet size=4096;user id=sa;data source=""."";persist securit" & _
        "y info=True;initial catalog=TireMate_01;password=5332"
        '
        'Cnn3
        '
        Me.Cnn3.ConnectionString = "workstation id=FARAJI;packet size=4096;user id=sa;data source=""."";persist securit" & _
        "y info=True;initial catalog=TireMate_01;password=5332"
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT bank_check.id_check, bank_check.id_bank, bank_check.no_of_check, bank_chec" & _
        "k.date_of_check, bank_check.amount_check, bank_check.cod_vendor, bank_check.empl" & _
        "oyee_code, bank_check.address_payee, bank_check.memo_check, bank_check.invoice_n" & _
        "o, bank_check.manual_check, bank_check.print_later, bank_check.cleared_bank, ban" & _
        "k_check.check_status, bank_check.id_debit_deposit_head, bank_check.id_GL_journal" & _
        ", bank_check_dtl.GL_Account, bank_check_dtl.amount, bas_banks.GL_Account AS Gl_A" & _
        "ccountBank, bas_banks.name_bank FROM bank_check INNER JOIN bank_check_dtl ON ban" & _
        "k_check.id_check = bank_check_dtl.id_check INNER JOIN bas_banks ON bank_check.id" & _
        "_bank = bas_banks.id_bank WHERE (dbo.ChangeDate(bank_check.date_of_check) >= @Fr" & _
        "omDate) AND (dbo.ChangeDate(bank_check.date_of_check) <= @ToDate) AND (bank_chec" & _
        "k.id_GL_journal IS NULL)"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'DaBank_Check
        '
        Me.DaBank_Check.SelectCommand = Me.SqlSelectCommand5
        Me.DaBank_Check.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_check", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("no_of_check", "no_of_check"), New System.Data.Common.DataColumnMapping("date_of_check", "date_of_check"), New System.Data.Common.DataColumnMapping("amount_check", "amount_check"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("address_payee", "address_payee"), New System.Data.Common.DataColumnMapping("memo_check", "memo_check"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("manual_check", "manual_check"), New System.Data.Common.DataColumnMapping("print_later", "print_later"), New System.Data.Common.DataColumnMapping("cleared_bank", "cleared_bank"), New System.Data.Common.DataColumnMapping("check_status", "check_status"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.LblStoreNo)
        Me.Panel2.Controls.Add(Me.LblCompanyName)
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(488, 40)
        Me.Panel2.TabIndex = 137
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(312, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Store No"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Company Name"
        '
        'LblStoreNo
        '
        Me.LblStoreNo.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblStoreNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStoreNo.Location = New System.Drawing.Point(368, 5)
        Me.LblStoreNo.Name = "LblStoreNo"
        Me.LblStoreNo.Size = New System.Drawing.Size(112, 25)
        Me.LblStoreNo.TabIndex = 133
        Me.LblStoreNo.Text = "LblStoreNo"
        Me.LblStoreNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCompanyName
        '
        Me.LblCompanyName.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCompanyName.Location = New System.Drawing.Point(101, 2)
        Me.LblCompanyName.Name = "LblCompanyName"
        Me.LblCompanyName.Size = New System.Drawing.Size(203, 38)
        Me.LblCompanyName.TabIndex = 132
        Me.LblCompanyName.Text = "LblCompanyName"
        Me.LblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlSelectCommand18
        '
        Me.SqlSelectCommand18.CommandText = "SELECT SUM(ROUND(GL_debit_deposit.debit_amount, 2)) AS Sum_Debit_Amount, SUM(ROUN" & _
        "D(GL_debit_deposit.deposit_amount, 2)) AS Sum_Deposit_Amount, GL_debit_deposit_h" & _
        "ead.id_bank, GL_debit_deposit.GL_account FROM GL_debit_deposit INNER JOIN GL_deb" & _
        "it_deposit_head ON GL_debit_deposit.id_debit_deposit_head = GL_debit_deposit_hea" & _
        "d.id_debit_deposit_head WHERE (GL_debit_deposit_head.id_GL_journal IS NULL) AND " & _
        "(GL_debit_deposit_head.id_bank = @id_bank) AND (dbo.ChangeDate(GL_debit_deposit_" & _
        "head.date_doc) >= @FromDate) AND (dbo.ChangeDate(GL_debit_deposit_head.date_doc)" & _
        " <= @ToDate) AND (GL_debit_deposit.GL_account = @Gl_Account) AND (GL_debit_depos" & _
        "it.type_transaction = @type_Transaction) GROUP BY GL_debit_deposit_head.id_bank," & _
        " GL_debit_deposit.GL_account"
        Me.SqlSelectCommand18.Connection = Me.CnnUnlock
        Me.SqlSelectCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        Me.SqlSelectCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_Account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlSelectCommand18.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_Transaction", System.Data.SqlDbType.VarChar, 1, "type_transaction"))
        '
        'DaDepositeBank1
        '
        Me.DaDepositeBank1.SelectCommand = Me.SqlSelectCommand18
        Me.DaDepositeBank1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_debit_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_debit_deposit", "id_debit_deposit"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("type_transaction", "type_transaction"), New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_transfer", "id_transfer"), New System.Data.Common.DataColumnMapping("id_external_cash", "id_external_cash"), New System.Data.Common.DataColumnMapping("id_ATM", "id_ATM"), New System.Data.Common.DataColumnMapping("id_adjustment_no", "id_adjustment_no"), New System.Data.Common.DataColumnMapping("debit_amount", "debit_amount"), New System.Data.Common.DataColumnMapping("deposit_amount", "deposit_amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("Cleared_bank", "Cleared_bank"), New System.Data.Common.DataColumnMapping("Memo", "Memo")})})
        '
        'DaDepositeBank2
        '
        Me.DaDepositeBank2.SelectCommand = Me.SqlCommand20
        Me.DaDepositeBank2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_debit_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_debit_deposit", "id_debit_deposit"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("type_transaction", "type_transaction"), New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_transfer", "id_transfer"), New System.Data.Common.DataColumnMapping("id_external_cash", "id_external_cash"), New System.Data.Common.DataColumnMapping("id_ATM", "id_ATM"), New System.Data.Common.DataColumnMapping("id_adjustment_no", "id_adjustment_no"), New System.Data.Common.DataColumnMapping("debit_amount", "debit_amount"), New System.Data.Common.DataColumnMapping("deposit_amount", "deposit_amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("Cleared_bank", "Cleared_bank"), New System.Data.Common.DataColumnMapping("Memo", "Memo")})})
        '
        'SqlCommand20
        '
        Me.SqlCommand20.CommandText = "SELECT GL_debit_deposit.debit_amount, GL_debit_deposit.deposit_amount, GL_debit_d" & _
        "eposit_head.id_bank, GL_debit_deposit.GL_account FROM GL_debit_deposit INNER JOI" & _
        "N GL_debit_deposit_head ON GL_debit_deposit.id_debit_deposit_head = GL_debit_dep" & _
        "osit_head.id_debit_deposit_head WHERE (GL_debit_deposit_head.id_GL_journal IS NU" & _
        "LL) AND (GL_debit_deposit_head.id_bank = @id_bank) AND (dbo.ChangeDate(GL_debit_" & _
        "deposit_head.date_doc) >= @FromDate) AND (dbo.ChangeDate(GL_debit_deposit_head.d" & _
        "ate_doc) <= @ToDate) AND (GL_debit_deposit.GL_account = @Gl_Account) AND (GL_deb" & _
        "it_deposit.type_transaction = @type_Transaction)"
        Me.SqlCommand20.Connection = Me.CnnUnlock
        Me.SqlCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        Me.SqlCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gl_Account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlCommand20.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_Transaction", System.Data.SqlDbType.VarChar, 1, "type_transaction"))
        '
        'CmdMakeJurnal
        '
        Me.CmdMakeJurnal.Location = New System.Drawing.Point(8, 448)
        Me.CmdMakeJurnal.Name = "CmdMakeJurnal"
        Me.CmdMakeJurnal.Size = New System.Drawing.Size(136, 23)
        Me.CmdMakeJurnal.TabIndex = 138
        Me.CmdMakeJurnal.Text = "Make Journal"
        '
        'DaForosh5
        '
        Me.DaForosh5.SelectCommand = Me.SqlCommand21
        Me.DaForosh5.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand21
        '
        Me.SqlCommand21.CommandText = "SELECT SUM(ROUND(ABS(service_center_dtl.qty) * (service_center_dtl.fet + service_" & _
        "center_dtl.price), 2)) AS QtyCost FROM service_center_head LEFT OUTER JOIN servi" & _
        "ce_center_dtl ON service_center_head.id_service_center = service_center_dtl.id_s" & _
        "ervice_center WHERE (service_center_head.id_GL_journal IS NULL) AND (service_cen" & _
        "ter_head.type_of_form = @type_of_form) AND (service_center_dtl.type_select IN ('" & _
        "T')) AND (dbo.ChangeDate(service_center_head.date_refer) >= @FromDate) AND (dbo." & _
        "ChangeDate(service_center_head.date_refer) <= @ToDate) AND (service_center_head." & _
        "id_service_center IN (SELECT id_service_center FROM gl_payment_deposit))"
        Me.SqlCommand21.Connection = Me.Cnn
        Me.SqlCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlCommand21.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        '
        'FrmCloseDay
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(478, 172)
        Me.Controls.Add(Me.CmdMakeJurnal)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Grd1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdClose)
        Me.Name = "FrmCloseDay"
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsFrmCloseDay1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Variables"
    Dim drdtl As DsFrmCloseDay.GL_journal_dtlRow
    Dim lastradif As Int64 = 1
    Dim OleDbReader As System.Data.OleDb.OleDbDataReader
    Dim Ds As DataSet
    Dim i As Integer
    Dim j As Integer
    Dim k As Integer
    Dim fromdate1 As String
    Dim todate1 As String
    Dim WithEvents Clslock1 As New SqlTableUtilityMbs.Mbs '   ClsLock
    Dim WithEvents Clslock2 As New SqlTableUtilityMbs.Mbs 'ClsLock
    Dim WithEvents Clslock3 As New SqlTableUtilityMbs.Mbs 'ClsLock
    Dim trans1 As SqlClient.SqlTransaction
    Dim WithEvents MakeFrmJournal As FrmJournal
    Public WithEvents ClsGlAccount1 As ClsGlAccount
    '    Dim BiginLockStatements As String = ""
#End Region
    Private Sub FrmCloseDay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        Cnn1.ConnectionString = PConnectionString
        Cnn2.ConnectionString = PConnectionString
        Cnn3.ConnectionString = PConnectionString
        CnnUnlock.ConnectionString = PConnectionString
        ClsGlAccount1 = New ClsGlAccount
        ClsGlAccount1.Connection = CnnUnlock
        ' MsgBox(Cnn1.ConnectionTimeout.ToString)
        ' trans1.IsolationLevel = IsolationLevel.Serializable
        '  Cnn3.ConnectionString = PConnectionString
        Clslock1.Sql_Connection = Cnn1
        Clslock2.Sql_Connection = Cnn2
        Clslock3.Sql_Connection = Cnn3

        'Clslock2.Cnn1 = Cnn3
        'Clslock1.LockThisItemInLockTable( "1", "lockTable")
        Clslock1.LockThisItemInLockTable("lockTable", "DummyValue", "locktype", "1")

        LblCompanyName.Text = PubCompanyName
        LblStoreNo.Text = PubStoreName
        TxtFromDate.Text = Format(Now.Date, PubDateFormat)
        TxtToDate.Text = Format(Now.Date, PubDateFormat)
        '       BiginLockStatements = " set transaction isolation level repeatable Read" + vbCrLf + " go " + vbCrLf + " begin transaction " '«Ì‰ ò«—Â« œ—”  ‰Ì”  
        Call FixthisDatabase()

    End Sub
    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        'Dim i As Integer, j As Integer, k As Integer
        'Clslock2.LockThisItemInLockTable("1", "LockTable2")
        Clslock2.LockThisItemInLockTable("lockTable2", "DummyValue", "locktype", "1")
        lastradif = 1
        fromdate1 = Mid(TxtFromDate.Text, 7, 4) + "/" + Mid(TxtFromDate.Text, 1, 2) + "/" + Mid(TxtFromDate.Text, 4, 2)
        todate1 = Mid(TxtToDate.Text, 7, 4) + "/" + Mid(TxtToDate.Text, 1, 2) + "/" + Mid(TxtToDate.Text, 4, 2)
        Dim tedad As Decimal = 0
        Dim SumBefore As Decimal = 0
        Dim MQtyPrice As Decimal = 0
        Dim itemno As String = ""
        Ds = New DataSet
        'Ds.Clear()
        DsFrmCloseDay1.GL_journal_dtl.Clear()
        DsFrmCloseDay1.Clear()
        Try
            DaBaseBank.SelectCommand.Connection = CnnUnlock
            DaBaseBank.Fill(Ds, "Banks")
            Call cheque()
            Call bankdeposite()
            Call Atm()
            Call BankTransfer()
            Call BankAdjustment()
            Call invoice()
            Call CustomerReturn()
            Call CachPaidOut()
            Call OtherCachPaidOut()
            Call AccountAdjustment()
            Call ReceiveOnAccount()
            Call Inventory("1") '----
            Call Inventory("2")
            Call InventoryAdjustment()
            Call InterStoreRelease()
            Call InventoryTransfer()
            Call MakeJournalform()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
            Clslock2.UnLockIt()
            Clslock2.FirstExecuted = False
        Catch ex As Exception
        Finally
        End Try
    End Sub
    Sub BankTransfer()
        For i = 0 To Ds.Tables("Banks").Rows.Count - 1
            With DaGlTransferTo
                .SelectCommand.Parameters("@FromDate").Value = fromdate1
                .SelectCommand.Parameters("@ToDate").Value = todate1
                .SelectCommand.Parameters("@Id_Bank").Value = Ds.Tables("Banks").Rows(i).Item("id_bank")
            End With
            DaGlTransferTo.Fill(Ds, "t8")
            Clslock3.Sql_SelectLock(DaGlTransferTo)
            For j = 0 To Ds.Tables("t8").Rows.Count - 1
                drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                drdtl.GL_account = Ds.Tables("t8").Rows(j).Item("Gl_AccountBank")
                drdtl.GL_journal_amount_credit = Ds.Tables("t8").Rows(j).Item("Amount_transfer")
                drdtl.GL_journal_reference = "Bank Transfer Id Bank= " & Ds.Tables("Banks").Rows(i).Item("id_bank")
                drdtl.id_GL_journal = 1
                drdtl.radif = lastradif
                lastradif += 1
                DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
            Next
            Ds.Tables("t8").Clear()
            With DaGlTransferFrom
                .SelectCommand.Parameters("@FromDate").Value = fromdate1
                .SelectCommand.Parameters("@ToDate").Value = todate1
                .SelectCommand.Parameters("@Id_Bank").Value = Ds.Tables("Banks").Rows(i).Item("id_bank")
            End With
            DaGlTransferFrom.Fill(Ds, "t9")
            Clslock3.Sql_SelectLock(DaGlTransferFrom)
            For j = 0 To Ds.Tables("T9").Rows.Count - 1
                drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                drdtl.GL_account = Ds.Tables("t9").Rows(j).Item("Gl_AccountBank")
                drdtl.GL_journal_amount_debit = Ds.Tables("t9").Rows(j).Item("Amount_transfer")
                drdtl.GL_journal_reference = "Bank Transfer Id Bank= " & Ds.Tables("Banks").Rows(i).Item("id_bank")
                drdtl.id_GL_journal = 1
                drdtl.radif = lastradif
                lastradif += 1
                DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
            Next
            Ds.Tables("t9").Clear()
        Next
    End Sub

    Sub Inventory(ByVal BillCreadit)
        Dim Dco As String
        'Dim I As Integer = 0
        '------------------------------------------------'
        Try
            Ds.Tables("InvRecevieReturn").Clear()
            Ds.Tables("InvRecevieReturnCreadit").Clear()
        Catch ex As Exception
        End Try

        Try
            With InvRecevieReturn
                .SelectCommand.Parameters("@FromDate").Value = fromdate1
                .SelectCommand.Parameters("@ToDate").Value = todate1
                .SelectCommand.Parameters("@BillCredit").Value = BillCreadit
                .Fill(Ds, "InvRecevieReturn")
            End With
            Clslock3.Sql_SelectLock(InvRecevieReturn)
            If Ds.Tables("InvRecevieReturn").Rows.Count > 0 Then
                OleDbReader = RetrieveAccountsPayableSetupTable()
                Dco = OleDbReader.Item("Default_AP_TRADE_GL_Account") & ""
                drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                drdtl.GL_account = Dco
                drdtl.id_GL_journal = 1
                If BillCreadit = "1" Then
                    drdtl.GL_journal_amount_debit = Ds.Tables("InvRecevieReturn").Rows(0).Item("QtyCost")
                Else
                    drdtl.GL_journal_amount_credit = Ds.Tables("InvRecevieReturn").Rows(0).Item("QtyCost")
                End If
                drdtl.GL_journal_reference = "Sunm Of " & IIf(BillCreadit = "1", "Inventory Recevie", "Inventory Return")
                drdtl.radif = lastradif
                lastradif += 1
                DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
            End If
            '------------------------------------------------------'
            'Creadit
            With InvRecevieReturnCreadit
                .SelectCommand.Parameters("@FromDate").Value = fromdate1
                .SelectCommand.Parameters("@ToDate").Value = todate1
                .SelectCommand.Parameters("@BillCredit").Value = BillCreadit
                .Fill(Ds, "InvRecevieReturnCreadit")
            End With
            Clslock3.Sql_SelectLock(InvRecevieReturnCreadit)
            With Ds.Tables("InvRecevieReturnCreadit")
                For i = 0 To .Rows.Count - 1
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = .Rows(i).Item("gl_account") & ""
                    drdtl.id_GL_journal = 1
                    If BillCreadit = "1" Then
                        drdtl.GL_journal_amount_credit = CDec(Val("" & .Rows(i).Item("QtyCost")))
                    Else
                        drdtl.GL_journal_amount_debit = CDec(Val("" & .Rows(i).Item("QtyCost")))
                    End If
                    drdtl.id_GL_journal = 1
                    drdtl.GL_journal_reference = "Item Type " & .Rows(i).Item("desc_item_type")
                    drdtl.radif = lastradif
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                Next
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub invoice()
        With DaAnbar
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
            .SelectCommand.Parameters("@type_of_form").Value = "IN"
        End With
        '        Dim sum1 As Decimal = 0

        Dim str1 As String = " SELECT SUM(round(ReplceMentCost * qty,2)) AS replqty, GL_account_cost_good, GL_account FROM  " & _
            "( SELECT inv_tab_type_item.GL_account, service_center_dtl.qty, service_center_dtl.AVERAGE_COST, inv_tab_type_item.GL_account_cost_good, service_center_dtl.price, inv_item_cost_transaction.cost + inv_item_cost_transaction.delivery + inv_item_cost_transaction.frieght AS ReplceMentCost, service_center_head.id_service_center, service_center_dtl.type_select FROM inv_item INNER JOIN inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN service_center_head INNER JOIN service_center_dtl ON service_center_head.id_service_center = service_center_dtl.id_service_center ON inv_item.item_no = service_center_dtl.cod_select INNER JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no WHERE (service_center_head.id_GL_journal IS NULL) AND (service_center_head.type_of_form = 'IN') AND (service_center_dtl.type_select in( 'I' ,'A')) AND (dbo.ChangeDate(service_center_head.date_refer) >= " & Qt(fromdate1) & ") AND (dbo.ChangeDate(service_center_head.date_refer) <= " & Qt(todate1) & ") AND (inv_item_cost_transaction.last_flag = 1)" & _
            " AND (service_center_head.id_service_center IN (SELECT id_service_center FROM  gl_payment_deposit)))   DERIVEDTBL gROUP BY GL_account_cost_good, GL_account"
        DaAnbar.SelectCommand.CommandText = str1
        '-------------------------------------- you will die if u change it
        DaAnbar.Fill(Ds, "anbar")
        Clslock3.Sql_SelectLock(DaAnbar)
        If Ds.Tables("anbar").Rows.Count > 0 Then
            'dim aa as DataRow()=ds.Tables("anbar").Select(

            For i = 0 To Ds.Tables("anbar").Rows.Count - 1
                drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                drdtl.GL_account = Ds.Tables("anbar").Rows(i).Item("Gl_Account") & ""
                drdtl.GL_journal_amount_credit = Ds.Tables("anbar").Rows(i).Item("replqty")  'Ds.Tables("anbar").Rows(i).Item("ReplqaceMentCost") * Ds.Tables("anbar").Rows(i).Item("Qty")
                drdtl.id_GL_journal = 1
                drdtl.radif = lastradif
                drdtl.GL_journal_reference = " Inventory  "
                lastradif += 1
                DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
            Next

            With DaAnbar2
                .SelectCommand.Parameters("@FromDate").Value = fromdate1 ' fromdate1
                .SelectCommand.Parameters("@ToDate").Value = todate1 'Todate1
                .SelectCommand.Parameters("@type_of_form").Value = "IN"
            End With
            Dim str2 As String = " SELECT SUM(round(ReplceMentCost * qty,2)) AS replqty, GL_account_cost_good, GL_account FROM  " & _
               "( SELECT inv_tab_type_item.GL_account, service_center_dtl.qty, service_center_dtl.AVERAGE_COST, inv_tab_type_item.GL_account_cost_good, service_center_dtl.price, inv_item_cost_transaction.cost + inv_item_cost_transaction.delivery + inv_item_cost_transaction.frieght AS ReplceMentCost, service_center_head.id_service_center, service_center_dtl.type_select FROM inv_item INNER JOIN inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN service_center_head INNER JOIN service_center_dtl ON service_center_head.id_service_center = service_center_dtl.id_service_center ON inv_item.item_no = service_center_dtl.cod_select INNER JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no WHERE (service_center_head.id_GL_journal IS NULL) AND (service_center_head.type_of_form = 'IN') AND (service_center_dtl.type_select in( 'O')) AND (dbo.ChangeDate(service_center_head.date_refer) >= " & Qt(fromdate1) & ") AND (dbo.ChangeDate(service_center_head.date_refer) <= " & Qt(todate1) & ") AND (inv_item_cost_transaction.last_flag = 1) " & _
               " AND (service_center_head.id_service_center IN (SELECT id_service_center FROM  gl_payment_deposit)))   DERIVEDTBL gROUP BY GL_account_cost_good, GL_account"
            'DERIVEDTBL gROUP BY GL_account_cost_good, GL_account"
            DaAnbar2.SelectCommand.CommandText = str2
            DaAnbar2.Fill(Ds, "anbar2")
            Clslock3.Sql_SelectLock(DaAnbar2)
            If Ds.Tables("anbar2").Rows.Count > 0 Then
                For i = 0 To Ds.Tables("anbar2").Rows.Count - 1
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = Ds.Tables("anbar2").Rows(i).Item("Gl_Account") & ""
                    drdtl.GL_journal_amount_credit = Ds.Tables("anbar2").Rows(i).Item("replqty")  '(Ds.Tables("anbar2").Rows(i).Item("ReplqaceMentCost") * Ds.Tables("anbar").Rows(i).Item("Qty"))
                    drdtl.GL_journal_reference = " Inventory  "
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                Next
            End If
            '-----------------------------------------
            For i = 0 To Ds.Tables("anbar").Rows.Count - 1
                If Ds.Tables("anbar").Rows(i).Item("replqty") > 0 Then
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = Ds.Tables("anbar").Rows(i).Item("GL_account_cost_good") & ""
                    drdtl.GL_journal_amount_debit = Ds.Tables("anbar").Rows(i).Item("replqty") 'Ds.Tables("anbar").Rows(i).Item("ReplqaceMentCost") * Ds.Tables("anbar").Rows(i).Item("Qty")
                    drdtl.GL_journal_reference = " Inventory  "
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                End If
            Next
            For i = 0 To Ds.Tables("anbar2").Rows.Count - 1
                If Ds.Tables("anbar2").Rows(i).Item("replqty") > 0 Then
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = Ds.Tables("anbar2").Rows(i).Item("GL_account_cost_good") & ""
                    drdtl.GL_journal_amount_debit = Ds.Tables("anbar2").Rows(i).Item("replqty") 'Ds.Tables("anbar2").Rows(i).Item("ReplqaceMentCost") * Ds.Tables("anbar").Rows(i).Item("Qty")
                    drdtl.GL_journal_reference = " Inventory  "
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                End If
            Next
        End If
        Call Forosh("IN")
    End Sub
    Sub CustomerReturn()
        'Dim i As Integer = 0
        With DaAnbarCustomerReturn
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
            .SelectCommand.Parameters("@type_of_form").Value = "RT"
        End With
        Dim str1 As String = " SELECT SUM(round(ReplceMentCost * qty,2)) AS replqty, GL_account_cost_good, GL_account FROM  " & _
           "( SELECT inv_tab_type_item.GL_account, service_center_dtl.qty, service_center_dtl.AVERAGE_COST, inv_tab_type_item.GL_account_cost_good, service_center_dtl.price, inv_item_cost_transaction.cost + inv_item_cost_transaction.delivery + inv_item_cost_transaction.frieght AS ReplceMentCost, service_center_head.id_service_center, service_center_dtl.type_select FROM inv_item INNER JOIN inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN service_center_head INNER JOIN service_center_dtl ON service_center_head.id_service_center = service_center_dtl.id_service_center ON inv_item.item_no = service_center_dtl.cod_select INNER JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no WHERE (service_center_head.id_GL_journal IS NULL) AND (service_center_head.type_of_form = 'RT') AND (service_center_dtl.type_select in( 'I' ,'A')) AND (dbo.ChangeDate(service_center_head.date_refer) >= " & Qt(fromdate1) & ") AND (dbo.ChangeDate(service_center_head.date_refer) <= " & Qt(todate1) & ") AND (inv_item_cost_transaction.last_flag = 1))   DERIVEDTBL gROUP BY GL_account_cost_good, GL_account"
        DaAnbarCustomerReturn.SelectCommand.CommandText = str1
        DaAnbarCustomerReturn.Fill(Ds, "anbarCustomerReturn")
        Clslock3.Sql_SelectLock(DaAnbarCustomerReturn)
        Try
            With Ds.Tables("anbarCustomerReturn")
                If .Rows.Count > 0 Then
                    For i = 0 To .Rows.Count - 1
                        If Math.Abs(CDec(Val(.Rows(i).Item("ReplQty") & ""))) > 0 Then
                            drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                            drdtl.GL_account = .Rows(i).Item("Gl_Account") & ""
                            drdtl.GL_journal_amount_debit = Math.Abs(CDec(Val(.Rows(i).Item("ReplQty") & "")))
                            drdtl.id_GL_journal = 1
                            drdtl.radif = lastradif
                            lastradif += 1
                            DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                        End If
                    Next
                End If

            End With
            '-------------------
            With DaAndbarCustomerReturn2
                .SelectCommand.Parameters("@FromDate").Value = fromdate1
                .SelectCommand.Parameters("@ToDate").Value = todate1
                .SelectCommand.Parameters("@type_of_form").Value = "RT"
            End With

            Dim str2 As String = " SELECT SUM(round(ReplceMentCost * qty,2)) AS replqty, GL_account_cost_good, GL_account FROM  " & _
               "( SELECT inv_tab_type_item.GL_account, service_center_dtl.qty, service_center_dtl.AVERAGE_COST, inv_tab_type_item.GL_account_cost_good, service_center_dtl.price, inv_item_cost_transaction.cost + inv_item_cost_transaction.delivery + inv_item_cost_transaction.frieght AS ReplceMentCost, service_center_head.id_service_center, service_center_dtl.type_select FROM inv_item INNER JOIN inv_tab_type_item ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN service_center_head INNER JOIN service_center_dtl ON service_center_head.id_service_center = service_center_dtl.id_service_center ON inv_item.item_no = service_center_dtl.cod_select INNER JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no WHERE (service_center_head.id_GL_journal IS NULL) AND (service_center_head.type_of_form = 'RT') AND (service_center_dtl.type_select in( 'O')) AND (dbo.ChangeDate(service_center_head.date_refer) >= " & Qt(fromdate1) & ") AND (dbo.ChangeDate(service_center_head.date_refer) <= " & Qt(todate1) & ") AND (inv_item_cost_transaction.last_flag = 1))   DERIVEDTBL gROUP BY GL_account_cost_good, GL_account"

            DaAndbarCustomerReturn2.SelectCommand.CommandText = str2
            DaAndbarCustomerReturn2.Fill(Ds, "anbarCustomerReturn2")
            Clslock3.Sql_SelectLock(DaAndbarCustomerReturn2)
            If Ds.Tables("anbarCustomerReturn2").Rows.Count > 0 Then
                With Ds.Tables("anbarCustomerReturn2")
                    For i = 0 To .Rows.Count - 1
                        If Math.Abs(CDec(Val("" & .Rows(i).Item("ReplQty")))) > 0 Then
                            drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                            drdtl.GL_account = .Rows(i).Item("Gl_Account") & ""
                            drdtl.GL_journal_amount_debit = Math.Abs(CDec(Val("" & .Rows(i).Item("ReplQty"))))
                            drdtl.id_GL_journal = 1
                            drdtl.radif = lastradif
                            lastradif += 1
                            DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                        End If
                    Next
                End With
            End If
            'credit begin
            With Ds.Tables("anbarCustomerReturn")
                For i = 0 To .Rows.Count - 1
                    If Math.Abs(CDec(Val("" & .Rows(i).Item("ReplQty")))) > 0 Then
                        drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                        drdtl.GL_account = .Rows(i).Item("GL_account_cost_good") & ""
                        drdtl.GL_journal_amount_credit = Math.Abs(CDec(Val("" & .Rows(i).Item("ReplQty")))) ' CDec(Val("" & .Rows(i).Item("AVERAGE_COST"))) * CDec(Val("" & .Rows(i).Item("Qty")))
                        drdtl.id_GL_journal = 1
                        drdtl.radif = lastradif
                        lastradif += 1
                        DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                    End If
                Next
            End With
            With Ds.Tables("anbarCustomerReturn2")
                For i = 0 To .Rows.Count - 1
                    If Math.Abs(CDec(Val("" & .Rows(i).Item("ReplQty")))) > 0 Then
                        drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                        drdtl.GL_account = .Rows(i).Item("GL_account_cost_good") & ""
                        drdtl.GL_journal_amount_credit = Math.Abs(CDec(Val("" & .Rows(i).Item("ReplQty")))) ' CDec(Val("" & .Rows(i).Item("price"))) * CDec(Val("" & .Rows(i).Item("Qty")))
                        drdtl.id_GL_journal = 1
                        drdtl.radif = lastradif
                        lastradif += 1
                        DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                    End If
                Next
            End With
            'credit end
            Call Forosh("RT")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    ' INVOICE   type_of_form=IN œ— ÃœÊ· 
    ' CUSTOMER RETURNS   type_of_form=IN œ— ÃœÊ· 
    Sub Forosh(ByVal This1 As String)
        '2 -  ”‰œ ›—Ê‘ 
        'invoice credit
        'rt debit
        '»Â „” ‰œ „—«Ã⁄Â ò‰
        Dim X1 As Decimal = 0
        Dim X2 As Decimal = 0
        Dim X3 As Decimal = 0
        Dim X4 As Decimal = 0
        Try
            Ds.Tables("Forosh1").Clear()
            Ds.Tables("Forosh2").Clear()
            Ds.Tables("Forosh3").Clear()
            Ds.Tables("Forosh4").Clear()
            Ds.Tables("Forosh5").Clear()
            Ds.Tables("ForoshDeposit").Clear()
            Ds.Tables("GlPaiedReceived3").Clear()
            Ds.Tables("tax").Clear()
        Catch ex As Exception

        End Try

        'Dim TotalInvoice As Decimal = 0
        'Dim i As Integer
        With DaForosh1
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
            .SelectCommand.Parameters("@type_of_form").Value = This1 '"IN"
        End With
        'this is X1
        DaForosh1.Fill(Ds, "Forosh1")
        Clslock3.Sql_SelectLock(DaForosh1)
        If Ds.Tables("Forosh1").Rows.Count > 0 Then
            For i = 0 To Ds.Tables("Forosh1").Rows.Count - 1
                Dim w As Decimal = Math.Round(Math.Abs(CDec(Ds.Tables("Forosh1").Rows(i).Item("QtyCost") & "")), 2)
                If w > 0 Then
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = Ds.Tables("Forosh1").Rows(i).Item("GL_account_sales_income") & ""
                    ' Dim w As Decimal = CDec(Ds.Tables("Forosh1").Rows(i).Item("QtyCost") & "")
                    X1 = X1 + w
                    If This1.ToUpper = "IN" Then
                        drdtl.GL_journal_amount_credit = w
                    Else
                        drdtl.GL_journal_amount_debit = w
                    End If
                    drdtl.id_GL_journal = 1
                    drdtl.GL_journal_reference = "Item Type " & Ds.Tables("Forosh1").Rows(i).Item("desc_item_type")
                    drdtl.radif = lastradif
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                End If
            Next
        End If
        'end this is X1

        ' this is X2
        With DaForosh2
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
            .SelectCommand.Parameters("@type_of_form").Value = This1 '"IN"
        End With
        DaForosh2.Fill(Ds, "Forosh2")
        Clslock3.Sql_SelectLock(DaForosh2)
        If Ds.Tables("Forosh2").Rows.Count > 0 Then
            For i = 0 To Ds.Tables("Forosh2").Rows.Count - 1
                Dim w As Decimal = Math.Round(Math.Abs(CDec(Ds.Tables("Forosh2").Rows(i).Item("QtyCost") & "")), 2) '* Ds.Tables("anbar").Rows(i).Item("Qty")
                If w > 0 Then
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = Ds.Tables("Forosh2").Rows(i).Item("income_GL_account") & ""
                    If This1.ToUpper = "IN" Then
                        drdtl.GL_journal_amount_credit = w
                    Else
                        drdtl.GL_journal_amount_debit = w
                    End If
                    X2 = X2 + w
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    drdtl.GL_journal_reference = "income GLaccount"
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                End If
            Next
        End If
        ' this is X3

        With DaForosh3
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
            .SelectCommand.Parameters("@type_of_form").Value = This1 '"IN"
        End With
        DaForosh3.Fill(Ds, "Forosh3")
        Clslock3.Sql_SelectLock(DaForosh3)
        If Ds.Tables("Forosh3").Rows.Count > 0 Then
            For i = 0 To Ds.Tables("Forosh3").Rows.Count - 1
                Dim w As Decimal = Math.Round(Math.Abs(Ds.Tables("Forosh3").Rows(i).Item("QtyCost")), 2)
                If w > 0 And This1.ToUpper = "IN" Then
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = Ds.Tables("Forosh3").Rows(i).Item("income_GL_account") & ""

                    If This1.ToUpper = "IN" Then
                        drdtl.GL_journal_amount_credit = w
                    Else
                        drdtl.GL_journal_amount_debit = w
                    End If
                    X3 = X3 + w
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    drdtl.GL_journal_reference = "income GLaccount"
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                End If
            Next
        End If
        'End this is X3
        '„»·€ tax  œ—ÃœÊ·  service_center_head   »Â Õ”«» œ— ÃœÊ· ( mdb ) GL_ledger_setup  Ê ›Ì·œ defult_sales_tax    

        With DaTax
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
            .SelectCommand.Parameters("@type_of_form").Value = This1 '"IN"
        End With
        DaTax.Fill(Ds, "tax")
        Clslock3.Sql_SelectLock(DaTax)

        OleDbReader = RetrieveGeneralLedgerSetupTable()
        Dim SaletaxAccount As String = OleDbReader.Item("default_sales_tax") & ""
        If Ds.Tables("tax").Rows.Count > 0 Then
            If SaletaxAccount <> "" Then
                Dim w As Decimal = Math.Round(CDec(Val("" & Ds.Tables("tax").Rows(0).Item("Sumtax"))), 2)

                If w > 0 And This1.ToUpper = "RT" Then  '
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = SaletaxAccount & ""
                    If This1.ToUpper = "IN" Then
                        drdtl.GL_journal_amount_debit = w
                    Else
                        drdtl.GL_journal_amount_credit = w
                    End If
                    X4 = X4 + w
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    drdtl.GL_journal_reference = "Sales Tax Amount"
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                End If
            End If
        End If

        '2 -  ”‰œ ›—Ê‘ 
        'err »—«Ì Â„«‰ ›«ò Ê—Â«
        'debit
        Try
            With DaForoshDeposit
                .SelectCommand.Parameters("@FromDate").Value = fromdate1
                .SelectCommand.Parameters("@ToDate").Value = todate1
                .SelectCommand.Parameters("@type_of_form").Value = This1 ' "IN"
            End With
            DaForoshDeposit.Fill(Ds, "ForoshDeposit")
            Clslock3.Sql_SelectLock(DaForoshDeposit)

            If Ds.Tables("ForoshDeposit").Rows.Count > 0 Then
                Dim a As Decimal = Val(Ds.Tables("ForoshDeposit").Compute("sum(payment_amount)", "payment_type = '4'") & "")
                Dim b As Decimal = Val(Ds.Tables("ForoshDeposit").Compute("sum(payment_amount)", "payment_type <> '4' and refer_type='1'") & "")
                If This1.ToUpper = "RT" Then
                    With DaGlPaiedReceived3
                        .SelectCommand.Parameters("@FromDate").Value = fromdate1
                        .SelectCommand.Parameters("@ToDate").Value = todate1
                        .Fill(Ds, "GlPaiedReceived3")
                        If Ds.Tables("GlPaiedReceived3").Rows.Count > 0 Then
                            b = Val(Ds.Tables("GlPaiedReceived3").Compute("sum(amount)", "tran_type = '3'") & "")
                        End If
                    End With

                End If

                If a <> 0 Then
                    OleDbReader = RetrieveAccountsReceivableSetupTable()
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = OleDbReader.Item("default_ar_GL_account") & ""


                    If This1.ToUpper = "IN" Then
                        drdtl.GL_journal_amount_debit = a
                    Else
                        drdtl.GL_journal_amount_credit = a
                    End If
                    'drdtl.GL_journal_amount_debit = a
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    drdtl.GL_journal_reference = "AR "
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                End If
                If b <> 0 Then
                    OleDbReader = RetrieveGeneralLedgerSetupTable()
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = OleDbReader.Item("default_cash_over")
                    If This1.ToUpper = "IN" Then
                        drdtl.GL_journal_amount_debit = b
                    Else
                        drdtl.GL_journal_amount_credit = b
                    End If
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    drdtl.GL_journal_reference = "Cash "
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                End If
            End If
            '- „Õ«”»Â  Œ›Ì› Discount
            With Daforosh4
                .SelectCommand.Parameters("@FromDate").Value = fromdate1
                .SelectCommand.Parameters("@ToDate").Value = todate1
                .SelectCommand.Parameters("@type_of_form").Value = This1 '"IN"
            End With
            Daforosh4.Fill(Ds, "Forosh4")
            Clslock3.Sql_SelectLock(Daforosh4)
            'TotalInvoice = 0
            Dim alldiscount As Decimal = 0
            If Ds.Tables("Forosh4").Rows.Count > 0 Then
                alldiscount = Math.Abs(CDec(Val("" & Ds.Tables("Forosh4").Rows(0).Item("amountdiscount"))))
            End If
            If alldiscount > 0 Then ' - Math.Abs((X1 + X2 + X3 + X4)) > 0 Then
                OleDbReader = RetrieveGeneralLedgerSetupTable()
                Dim Dco As String
                Try
                    Dco = OleDbReader.Item("default_discount_for_sales") & ""
                Catch ex As Exception
                    Dco = "Error default_discount_for_sales"
                End Try

                drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                drdtl.GL_account = Dco
                drdtl.GL_journal_amount_debit = alldiscount   ' TotalInvoice - Math.Abs((X1 + X2 + X3 + X4))
                drdtl.id_GL_journal = 1
                drdtl.radif = lastradif
                drdtl.GL_journal_reference = "Discount For Sales "
                lastradif += 1
                DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
            End If

            With DaForosh5
                .SelectCommand.Parameters("@FromDate").Value = fromdate1
                .SelectCommand.Parameters("@ToDate").Value = todate1
                .SelectCommand.Parameters("@type_of_form").Value = This1 '"IN"
            End With
            If This1 <> "RT" Then
                DaForosh5.Fill(Ds, "Forosh5")
                OleDbReader = RetrieveGeneralLedgerSetupTable()
                Clslock3.Sql_SelectLock(DaForosh5)
                If Ds.Tables("Forosh5").Rows.Count > 0 Then
                    For i = 0 To Ds.Tables("Forosh5").Rows.Count - 1
                        Dim w As Decimal = Math.Round(Math.Abs(Val("0" & Ds.Tables("Forosh5").Rows(i).Item("QtyCost"))), 2)     '
                        If w > 0 Then
                            drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                            drdtl.GL_account = OleDbReader.Item("default_traded_item") & ""  '   Ds.Tables("Forosh5").Rows(i).Item("income_GL_account") & ""
                            If This1.ToUpper = "IN" Then
                                drdtl.GL_journal_amount_debit = w
                            Else
                                drdtl.GL_journal_amount_credit = w
                            End If
                            drdtl.id_GL_journal = 1
                            drdtl.radif = lastradif
                            drdtl.GL_journal_reference = "Trade Item"
                            lastradif += 1
                            DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub AccountAdjustment()
        With DaGlAccountAdjustment
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
        End With
        DaGlAccountAdjustment.Fill(Ds, "AccountAdjustment")
        Clslock3.Sql_SelectLock(DaGlAccountAdjustment)
        Dim sum1 As Decimal = 0
        If Ds.Tables("AccountAdjustment").Rows.Count > 0 Then
            For i = 0 To Ds.Tables("AccountAdjustment").Rows.Count - 1
                If Math.Abs(CDec(Val("" & System.Math.Abs(Ds.Tables("AccountAdjustment").Rows(i).Item("amount_adjustment"))))) > 0 Then
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = Ds.Tables("AccountAdjustment").Rows(i).Item("Gl_Account") & ""
                    drdtl.GL_journal_amount_debit = Math.Abs(CDec(Val("" & System.Math.Abs(Ds.Tables("AccountAdjustment").Rows(i).Item("amount_adjustment")))))
                    sum1 = sum1 + Math.Abs(CDec(Val("" & Ds.Tables("AccountAdjustment").Rows(i).Item("amount_adjustment"))))
                    drdtl.GL_journal_reference = "Account Adjustment"
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                End If
            Next
            If Math.Abs(sum1) > 0 Then
                OleDbReader = RetrieveAccountsReceivableSetupTable()
                Dim DaG As String = OleDbReader.Item("Default_AR_GL_account") & ""
                drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                drdtl.GL_journal_reference = "Account Receivable"
                drdtl.GL_account = DaG
                drdtl.GL_journal_amount_credit = Math.Abs(sum1) 'Ds.Tables("AccountAdjustment").Rows(0).Item("amount_adjustment")
                drdtl.id_GL_journal = 1
                drdtl.radif = lastradif
                lastradif += 1
                DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
            End If
        End If
        With DaGlAccountAdjustment2
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
        End With
        DaGlAccountAdjustment2.Fill(Ds, "AccountAdjustment2")
        Clslock3.Sql_SelectLock(DaGlAccountAdjustment2)
        sum1 = 0
        If Ds.Tables("AccountAdjustment2").Rows.Count > 0 Then
            For i = 0 To Ds.Tables("AccountAdjustment2").Rows.Count - 1
                If Math.Abs(CDec(Val("" & System.Math.Abs(Ds.Tables("AccountAdjustment2").Rows(i).Item("amount_adjustment"))))) > 0 Then
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = Ds.Tables("AccountAdjustment2").Rows(i).Item("Gl_Account") & ""
                    drdtl.GL_journal_amount_credit = Math.Abs(CDec(Val("" & System.Math.Abs(Ds.Tables("AccountAdjustment2").Rows(i).Item("amount_adjustment")))))
                    sum1 = sum1 + Math.Abs(CDec(Val("" & Ds.Tables("AccountAdjustment2").Rows(i).Item("amount_adjustment"))))
                    drdtl.GL_journal_reference = "Account adjustment"
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                End If
            Next
            If sum1 > 0 Then
                OleDbReader = RetrieveAccountsReceivableSetupTable()
                Dim DaG As String = OleDbReader.Item("Default_AR_GL_account") & ""
                drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                drdtl.GL_account = DaG
                drdtl.GL_journal_reference = "Account Receivable"
                drdtl.GL_journal_amount_debit = sum1
                drdtl.id_GL_journal = 1
                drdtl.radif = lastradif
                lastradif += 1
                DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
            End If
        End If
    End Sub
    Sub CachPaidOut()
        With DaGlPaiedReceived
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
            .Fill(Ds, "GlPaiedReceived")

        End With
        Clslock3.Sql_SelectLock(DaGlPaiedReceived)
        Dim sum1 As Decimal = 0
        With Ds.Tables("GlPaiedReceived")
            For i = 0 To .Rows.Count - 1
                drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                drdtl.GL_account = .Rows(i).Item("Gl_Account") & ""
                drdtl.GL_journal_amount_debit = CDec("0" & Ds.Tables("GlPaiedReceived").Rows(i).Item("amount"))
                sum1 = sum1 + CDec(Val("" & .Rows(i).Item("amount")))
                drdtl.id_GL_journal = 1
                drdtl.GL_journal_reference = "Cach Paid Out Number " & .Rows(i).Item("refrence_code")
                drdtl.radif = lastradif
                lastradif += 1
                DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
            Next
        End With
        If sum1 > 0 Then
            OleDbReader = RetrieveGeneralLedgerSetupTable()
            Dim Dco As String = OleDbReader.Item("default_cash_over") & ""
            drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
            drdtl.GL_account = Dco
            drdtl.GL_journal_amount_credit = sum1 'Ds.Tables("AccountAdjustment").Rows(0).Item("amount_adjustment")
            drdtl.GL_journal_reference = "Cach Over "
            drdtl.id_GL_journal = 1
            drdtl.radif = lastradif
            DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
            lastradif += 1
        End If
    End Sub
    '-------------------------------------------------------------
    Sub OtherCachPaidOut()
        With DaGlPaiedReceived2
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
            .Fill(Ds, "GlPaiedReceived2")
        End With
        Clslock3.Sql_SelectLock(DaGlPaiedReceived2)
        Dim sum1 As Decimal = 0
        With Ds.Tables("GlPaiedReceived2")
            For i = 0 To .Rows.Count - 1
                If CDec(Val("" & Ds.Tables("GlPaiedReceived2").Rows(i).Item("amount"))) > 0 Then
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = .Rows(i).Item("Gl_Account") & ""
                    drdtl.GL_journal_amount_credit = CDec(Val("" & Ds.Tables("GlPaiedReceived2").Rows(i).Item("amount")))
                    sum1 = sum1 + CDec("0" & .Rows(i).Item("amount"))
                    drdtl.id_GL_journal = 1
                    drdtl.GL_journal_reference = "Other Receipt Number " & .Rows(i).Item("refrence_code")
                    drdtl.radif = lastradif
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                End If
            Next
        End With
        If sum1 > 0 Then
            OleDbReader = RetrieveGeneralLedgerSetupTable()
            Dim Dco As String = OleDbReader.Item("default_cash_over") & ""
            drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
            drdtl.GL_account = Dco
            drdtl.GL_journal_amount_debit = sum1 'Ds.Tables("AccountAdjustment").Rows(0).Item("amount_adjustment")
            drdtl.id_GL_journal = 1
            drdtl.radif = lastradif
            drdtl.GL_journal_reference = " Sum Other Receipt "
            lastradif += 1
            DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
        End If
    End Sub
    '-------------------------------------------------------------
    Sub ReceiveOnAccount()
        With GlReceviePayment
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
            .Fill(Ds, "GlReceviePayment")
        End With
        Clslock3.Sql_SelectLock(GlReceviePayment)
        Dim sum1 As Decimal = 0
        OleDbReader = RetrieveAccountsReceivableSetupTable()
        Dim Dco As String = OleDbReader.Item("Default_AR_GL_account") & ""
        With Ds.Tables("GlReceviePayment")
            For i = 0 To .Rows.Count - 1
                If CDec(Val("" & .Rows(i).Item("amount_receive"))) > 0 Then
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = Dco
                    drdtl.GL_journal_amount_credit = CDec("0" & .Rows(i).Item("amount_receive"))
                    sum1 = sum1 + CDec(Val("" & .Rows(i).Item("amount_receive")))
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    drdtl.GL_journal_reference = "Cach Over"
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                End If
            Next
        End With
        If sum1 > 0 Then
            OleDbReader = RetrieveGeneralLedgerSetupTable()
            Dco = OleDbReader.Item("default_cash_over") & ""
            drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
            drdtl.id_GL_journal = 1
            drdtl.GL_account = Dco
            drdtl.GL_journal_amount_debit = sum1
            drdtl.GL_journal_reference = "Receive Payment"
            drdtl.radif = lastradif
            lastradif += 1
            DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
        End If
    End Sub
    '-------------------------------------------------------------
    Sub InventoryAdjustment()
        With invAdjustment
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
            .Fill(Ds, "invAdjustment")
        End With
        Clslock3.Sql_SelectLock(invAdjustment)
        Dim sum1 As Decimal = 0
        If Ds.Tables("invAdjustment").Rows.Count > 0 Then
            With Ds.Tables("invAdjustment")
                For i = 0 To .Rows.Count - 1
                    If Math.Abs(CDec(Val("" & .Rows(i).Item("qtycost")))) > 0 Then
                        drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                        drdtl.GL_account = .Rows(i).Item("Gl_Account") & ""
                        drdtl.GL_journal_amount_credit = Math.Abs(CDec(Val("" & .Rows(i).Item("qtycost"))))
                        sum1 = sum1 + Math.Abs(CDec(Val("" & .Rows(i).Item("qtycost"))))
                        drdtl.id_GL_journal = 1
                        drdtl.GL_journal_reference = "inventory adjustment"
                        drdtl.radif = lastradif
                        lastradif += 1
                        DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                    End If
                Next
            End With
            If sum1 > 0 Then
                drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                drdtl.GL_account = Ds.Tables("invAdjustment").Rows(0).Item("GL_account_adjustment")
                drdtl.GL_journal_amount_debit = sum1
                drdtl.id_GL_journal = 1
                drdtl.GL_journal_reference = "inventory adjustment"
                drdtl.radif = lastradif
                lastradif += 1
                DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
            End If
        End If
        With InvAdjustment2
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
            .Fill(Ds, "invAdjustment2")
        End With
        Clslock3.Sql_SelectLock(InvAdjustment2)
        sum1 = 0
        If Ds.Tables("invAdjustment2").Rows.Count > 0 Then
            With Ds.Tables("invAdjustment2")
                For i = 0 To .Rows.Count - 1
                    If Math.Abs(CDec(Val("" & .Rows(i).Item("QtyCost")))) > 0 Then
                        drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                        drdtl.GL_account = .Rows(i).Item("Gl_Account") & ""
                        drdtl.GL_journal_amount_debit = Math.Abs(CDec(Val("" & .Rows(i).Item("QtyCost"))))
                        sum1 = sum1 + Math.Abs(CDec(Val("" & .Rows(i).Item("QtyCost"))))
                        drdtl.id_GL_journal = 1
                        drdtl.radif = lastradif
                        lastradif += 1
                        DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                    End If
                Next
            End With
            If sum1 > 0 Then
                drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                drdtl.GL_account = Ds.Tables("invAdjustment2").Rows(0).Item("GL_account_adjustment")
                drdtl.GL_journal_amount_credit = sum1
                drdtl.id_GL_journal = 1
                drdtl.radif = lastradif
                lastradif += 1
                DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
            End If
        End If
    End Sub

    Sub BankAdjustment()
        For i = 0 To Ds.Tables("Banks").Rows.Count - 1
            With DaBankAdjustment
                .SelectCommand.Parameters("@FromDate").Value = fromdate1
                .SelectCommand.Parameters("@ToDate").Value = todate1
                .SelectCommand.Parameters("@Id_Bank").Value = Ds.Tables("Banks").Rows(i).Item("id_bank")
            End With
            DaBankAdjustment.Fill(Ds, "t10")
            Clslock3.Sql_SelectLock(DaBankAdjustment)
            Dim D As Decimal = Math.Abs(CDec(Val("" & Ds.Tables("t10").Compute("sum(debit_amount)", "Gl_Account <> ''"))))
            If D > 0 Then
                drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                If Ds.Tables("t10").Rows.Count > 0 Then
                    drdtl.GL_account = Ds.Tables("t10").Rows(0).Item("Gl_AccountBank")
                Else
                    drdtl.GL_account = "not found 1"
                End If
                drdtl.GL_journal_amount_debit = D
                drdtl.id_GL_journal = 1
                drdtl.radif = lastradif
                drdtl.GL_journal_reference = "Bank Adjustment Id Bank =" & Ds.Tables("Banks").Rows(i).Item("id_bank")
                lastradif += 1
                DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
            End If

            For j = 0 To Ds.Tables("t10").Rows.Count - 1
                If Math.Abs(Ds.Tables("t10").Rows(j).Item("debit_amount")) > 0 Then
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = Ds.Tables("t10").Rows(j).Item("Gl_Account")
                    drdtl.GL_journal_amount_credit = Math.Abs(Ds.Tables("t10").Rows(j).Item("debit_amount"))
                    drdtl.GL_journal_reference = "Bank Adjustment Transaction"
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                End If
            Next

            D = Math.Abs(CDec(Val(("" & Ds.Tables("t10").Compute("sum(Deposit_amount)", "Gl_Account <> ''")))))

            If D > 0 Then
                drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                If Ds.Tables("t10").Rows.Count > 0 Then
                    drdtl.GL_account = Ds.Tables("t10").Rows(0).Item("Gl_AccountBank")
                Else
                    drdtl.GL_account = "Error 2"
                End If
                drdtl.GL_journal_amount_debit = D
                drdtl.id_GL_journal = 1
                drdtl.GL_journal_reference = "Bank Adjustment Id Bank =" & Ds.Tables("Banks").Rows(i).Item("id_bank")
                drdtl.radif = lastradif
                lastradif += 1
                DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
            End If
            For j = 0 To Ds.Tables("t10").Rows.Count - 1
                If Math.Abs(Ds.Tables("t10").Rows(j).Item("deposit_amount")) > 0 Then
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = Ds.Tables("t10").Rows(j).Item("Gl_Account")
                    drdtl.GL_journal_amount_credit = Math.Abs(Ds.Tables("t10").Rows(j).Item("deposit_amount"))
                    drdtl.GL_journal_reference = "Bank Adjustment Transaction"
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    lastradif += 1

                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                End If
            Next
            Ds.Tables("t10").Clear()
        Next
    End Sub
    Sub Atm()
        '3 ñ ATM  »«‰ò Ê œ— Õ«·  CHARGE
        '4 -  ATM  »«‰ò Ê œ— Õ«·  CREDIT   

        Dim Tname As String
        For k = 1 To 2
            For i = 0 To Ds.Tables("Banks").Rows.Count - 1
                With DaBankAtm
                    .SelectCommand.Parameters("@FromDate").Value = fromdate1
                    .SelectCommand.Parameters("@ToDate").Value = todate1
                    .SelectCommand.Parameters("@Id_Bank").Value = Ds.Tables("Banks").Rows(i).Item("id_bank")
                    .SelectCommand.Parameters("@ChargeCredit").Value = k.ToString.Trim
                    Tname = "T7" & Trim(Str(k)) 't71,72
                    Try
                        Ds.Tables(Tname).Clear()
                    Catch ex As Exception
                    End Try
                    DaBankAtm.Fill(Ds, Tname)
                    Clslock3.Sql_SelectLock(DaBankAtm)
                    If Ds.Tables(Tname).Rows.Count > 0 Then
                        drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                        drdtl.GL_account = Ds.Tables(Tname).Rows(0).Item("Gl_AccountBank")
                        If k = 1 Then 'charge
                            drdtl.GL_journal_amount_credit = Ds.Tables(Tname).Rows(0).Item("Amount_atm")
                        Else
                            drdtl.GL_journal_amount_debit = Ds.Tables(Tname).Rows(0).Item("Amount_atm")
                        End If
                        drdtl.GL_journal_reference = "Bank " & Ds.Tables(Tname).Rows(0).Item("Name_Bank") & " " & " Atm Id " & Ds.Tables(Tname).Rows(0).Item("Id_atm") & ""
                        drdtl.id_GL_journal = 1
                        drdtl.radif = lastradif
                        lastradif += 1
                        DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                        For j = 0 To Ds.Tables(Tname).Rows.Count - 1
                            drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                            drdtl.GL_account = Ds.Tables(Tname).Rows(j).Item("Gl_Account")
                            drdtl.GL_journal_reference = "Atm Transaction Gl Account" & Ds.Tables(Tname).Rows(j).Item("Gl_Account")
                            drdtl.id_GL_journal = 1
                            drdtl.radif = lastradif
                            lastradif += 1
                            If k = 1 Then
                                drdtl.GL_journal_amount_debit = Ds.Tables(Tname).Rows(j).Item("Amount")
                            Else
                                drdtl.GL_journal_amount_credit = Ds.Tables(Tname).Rows(j).Item("Amount")
                            End If
                            DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                        Next
                        'Ds.Tables(Tname).Clear()
                    End If
                End With
            Next
        Next
        '3 ñ ATM  »«‰ò Ê œ— Õ«·  CHARGE 
        '4 -  ATM  »«‰ò Ê œ— Õ«·  CREDIT   

    End Sub
    '16 -     INTER-STORE RESALE ñ IS     
    Sub InterStoreRelease()
        Try
            Ds.Tables("InvInterstore").Clear()
        Catch ex As Exception
        End Try
        With DaInterStor
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
            .SelectCommand.Parameters("@StoreFrom").Value = PubStoreNO
            .SelectCommand.Parameters("@Type1").Value = "1"
            .Fill(Ds, "InvInterstore")
        End With
        Clslock3.Sql_SelectLock(DaInterStor)
        With Ds.Tables("InvInterstore")
            If .Rows.Count > 0 Then
                For i = 0 To .Rows.Count - 1
                    If CDec(Val(("" & .Rows(i).Item("sum1")))) > 0 Then
                        drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                        drdtl.GL_account = .Rows(i).Item("Gl_Account") & ""
                        drdtl.GL_journal_amount_credit = CDec(Val(("" & .Rows(i).Item("sum1"))))
                        drdtl.GL_journal_reference = "Inter store " & .Rows(i).Item("Store_from")
                        drdtl.id_GL_journal = 1
                        drdtl.radif = lastradif
                        lastradif += 1
                        DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                    End If
                Next
                For i = 0 To .Rows.Count - 1
                    If CDec(Val("" & .Rows(i).Item("sum1"))) > 0 Then
                        drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                        drdtl.GL_account = .Rows(i).Item("GL_account_cost_good") & ""
                        drdtl.GL_journal_amount_debit = CDec(Val("" & .Rows(i).Item("sum1")))
                        drdtl.GL_journal_reference = "Inter store " & .Rows(i).Item("Store_from")
                        drdtl.id_GL_journal = 1
                        drdtl.radif = lastradif
                        lastradif += 1
                        DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                    End If
                Next
            End If
        End With
    End Sub
    Sub InventoryTransfer()
        Try
            Ds.Tables("InvSalesTransfer").Clear()
        Catch ex As Exception
        End Try

        With DaInvSalesTransfer
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
            .SelectCommand.Parameters("@StoreFrom").Value = PubStoreNO
            .SelectCommand.Parameters("@Type1").Value = "2"
            .Fill(Ds, "InvSalesTransfer")
        End With
        Clslock3.Sql_SelectLock(DaInvSalesTransfer)
        With Ds.Tables("InvSalesTransfer")
            If .Rows.Count > 0 Then
                For i = 0 To .Rows.Count - 1
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = .Rows(i).Item("Gl_Account") & ""
                    drdtl.GL_journal_amount_credit = CDec(Val(("" & .Rows(i).Item("sum1"))))
                    drdtl.GL_journal_reference = "Inventory sale transfer store " & .Rows(i).Item("Store_from")
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                Next
                'OleDbReader = RetrieveGeneralLedgerSetupTable()
                Dim Dco As String = ""
                For i = 0 To .Rows.Count - 1
                    OleDbReader = RetrieveStoreSetupTable(.Rows(i).Item("Store_from"))
                    Dco = OleDbReader.Item("InterStoreReceivableAccount") & ""
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = Dco & "" '.Rows(i).Item("GL_account_cost_good") & ""
                    drdtl.GL_journal_amount_debit = CDec(Val("" & .Rows(i).Item("sum1")))
                    drdtl.GL_journal_reference = "Inventory sale transfer store " & .Rows(i).Item("Store_from")
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                Next
            End If
        End With
    End Sub
    Private Sub FrmCloseDay_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Clslock1.UnLockIt()
        Clslock3.UnLockIt()
        'Clslock2.UnLockIt()
    End Sub
    Private Sub Clslock1_ICantLockThis(ByVal ThisId As String) Handles Clslock1.ICantLockThis
        Select Case ThisId
            Case "1"
                MsgFar("This Program  is Running by another person")
                Call DisableAllComponet(Me, False)
                CmdClose.Enabled = True
            Case "2"
                MsgFar("nnnnnnn")
        End Select
    End Sub
    Friend Sub DisableAllComponet(ByVal MyForm As Form, Optional ByVal MyStat As Boolean = False)
        Dim i As Integer
        For i = 0 To MyForm.Controls.Count - 1
            MyForm.Controls(i).Enabled = MyStat
        Next i
    End Sub
    Sub cheque()
        With DaBank_Check
            .SelectCommand.Parameters("@FromDate").Value = fromdate1
            .SelectCommand.Parameters("@ToDate").Value = todate1
            .Fill(DsFrmCloseDay1.bank_check)
            Clslock3.Sql_SelectLock(DaBank_Check)
            If DsFrmCloseDay1.bank_check.Rows.Count > 0 Then
                For i = 0 To DsFrmCloseDay1.bank_check.Rows.Count - 1
                    With DsFrmCloseDay1.bank_check.Rows(i)
                        drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                        drdtl.id_GL_journal = 1
                        drdtl.radif = lastradif
                        drdtl.GL_account = .Item("Gl_Account")
                        drdtl.GL_journal_reference = "Bank Name " & .Item("name_bank") & "Check Id " & .Item("id_check") & ""
                        drdtl.GL_journal_amount_debit = .Item("amount")
                        DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                        lastradif = lastradif + 1
                    End With
                Next
                Dim drdtl1 As DsFrmCloseDay.GL_journal_dtlRow = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                drdtl1.id_GL_journal = 1
                drdtl1.radif = lastradif
                drdtl1.GL_account = DsFrmCloseDay1.bank_check.Rows(0).Item("Gl_AccountBank")
                drdtl1.GL_journal_amount_credit = DsFrmCloseDay1.bank_check.Compute("sum(Amount)", "Gl_Account <> ''")
                DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl1)
                lastradif = lastradif + 1
            End If
        End With
        '1 ñ »—«Ì çò ’«œ—Â
        '  Next
        '------------------------
    End Sub

    Sub bankdeposite()
        Dim i As Integer
        Dim j As Integer
        Dim _Id_Bank As Integer
        Dim _Gl_account As String = ""
        Dim _name_bank As String
        For i = 0 To Ds.Tables("Banks").Rows.Count - 1
            _Id_Bank = Ds.Tables("Banks").Rows(i).Item("Id_Bank") & ""
            _Gl_account = Ds.Tables("Banks").Rows(i).Item("Gl_account") & ""
            _name_bank = Ds.Tables("Banks").Rows(i).Item("name_bank") & ""
            With DaDepositeBank1.SelectCommand
                .Parameters("@id_Bank").Value = _Id_Bank
                .Parameters("@Gl_Account").Value = _Gl_account
                .Parameters("@type_Transaction").Value = "1"
                .Parameters("@FromDate").Value = fromdate1
                .Parameters("@ToDate").Value = todate1
            End With
            DaDepositeBank1.Fill(Ds, "t2")
            Dim t1 As Decimal = 0
            If Ds.Tables("t2").Rows.Count > 0 Then
                t1 = Ds.Tables("t2").Rows(0).Item("Sum_deposit_amount")
            End If

            Ds.Tables("t2").Clear()
            With DaDepositeBank1.SelectCommand
                .Parameters("@id_Bank").Value = _Id_Bank
                .Parameters("@Gl_Account").Value = _Gl_account
                .Parameters("@type_Transaction").Value = "9"
                .Parameters("@FromDate").Value = fromdate1
                .Parameters("@ToDate").Value = todate1

            End With
            DaDepositeBank1.Fill(Ds, "t2")
            Dim t9 As Decimal = 0
            If Ds.Tables("t2").Rows.Count > 0 Then
                t9 = Val("" & Ds.Tables("t2").Rows(0).Item("Sum_deposit_amount"))
            End If
            Ds.Tables("t2").Clear()

            With DaDepositeBank1.SelectCommand
                .Parameters("@id_Bank").Value = _Id_Bank
                .Parameters("@Gl_Account").Value = _Gl_account
                .Parameters("@type_Transaction").Value = "A"
                .Parameters("@FromDate").Value = fromdate1
                .Parameters("@ToDate").Value = todate1

            End With
            DaDepositeBank1.Fill(Ds, "t2")
            Dim tA As Decimal = 0
            If Ds.Tables("t2").Rows.Count > 0 Then
                tA = Val("" & Ds.Tables("t2").Rows(0).Item("Sum_deposit_amount"))
            End If

            Ds.Tables("t2").Clear()
            With DaDepositeBank1.SelectCommand
                .Parameters("@id_Bank").Value = _Id_Bank
                .Parameters("@Gl_Account").Value = _Gl_account
                .Parameters("@type_Transaction").Value = "8"
                .Parameters("@FromDate").Value = fromdate1
                .Parameters("@ToDate").Value = todate1

            End With
            DaDepositeBank1.Fill(Ds, "t2")
            Dim t8 As Decimal = 0
            If Ds.Tables("t2").Rows.Count > 0 Then
                t8 = Val("" & Ds.Tables("t2").Rows(0).Item("Sum_deposit_amount"))
            End If


            Ds.Tables("t2").Clear()
            With DaDepositeBank1.SelectCommand
                .Parameters("@id_Bank").Value = _Id_Bank
                .Parameters("@Gl_Account").Value = _Gl_account
                .Parameters("@type_Transaction").Value = "3"
                .Parameters("@FromDate").Value = fromdate1
                .Parameters("@ToDate").Value = todate1
            End With
            DaDepositeBank1.Fill(Ds, "t2")
            Dim t3 As Decimal = 0
            If Ds.Tables("t2").Rows.Count > 0 Then
                t3 = Val("" & Ds.Tables("t2").Rows(0).Item("Sum_deposit_amount"))
            End If

            Ds.Tables("t2").Clear()
            With DaDepositeBank2.SelectCommand
                .Parameters("@id_Bank").Value = _Id_Bank
                .Parameters("@Gl_Account").Value = _Gl_account
                .Parameters("@type_Transaction").Value = "3"
                .Parameters("@FromDate").Value = fromdate1
                .Parameters("@ToDate").Value = todate1
            End With
            DaDepositeBank2.Fill(Ds, "t3")

            '--------
            '‰Ê‘ ‰ œ— Dataset ”‰œ
            If t1 + t9 + tA - t8 <> 0 Then
                drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                drdtl.GL_account = _Gl_account
                drdtl.GL_journal_amount_credit = Math.Abs(t1 + t9 + tA - t8)
                drdtl.GL_journal_reference = "Bank Deposit For Bank " & _name_bank
                drdtl.id_GL_journal = 1
                drdtl.radif = lastradif
                lastradif += 1
                DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                For j = 0 To Ds.Tables("t3").Rows.Count - 1
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    lastradif += 1
                    drdtl.GL_account = Ds.Tables("t3").Rows(i).Item("Gl_account")
                    drdtl.GL_journal_amount_debit = Val("" & Ds.Tables("t3").Rows(i).Item("Debit_amount"))
                    drdtl.GL_journal_reference = "Bank Deposit For Bank " & _name_bank
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                Next

                OleDbReader = RetrieveGeneralLedgerSetupTable()
                Dim Dco As String = OleDbReader.Item("defult_cash_over") & ""
                If t1 + t9 + tA - t8 - t3 <> 0 Then
                    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
                    drdtl.GL_account = Dco
                    drdtl.GL_journal_amount_debit = Math.Abs(t1 + t9 + tA - t8 - t3)
                    drdtl.GL_journal_reference = "Bank Deposit For Bank " & _name_bank
                    drdtl.id_GL_journal = 1
                    drdtl.radif = lastradif
                    lastradif += 1
                    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
                End If
            End If
        Next
        '2 -  »—«Ì deposit   »«‰ò 
        '''''''''With DaDeposit1
        '''''''''    .SelectCommand.Parameters("@FromDate").Value = fromdate1
        '''''''''    .SelectCommand.Parameters("@ToDate").Value = todate1
        '''''''''End With
        ''''''''''Sum(GL_debit_deposit.deposit_amount) where type_transaction=1
        '''''''''DaDeposit1.Fill(Ds, "t2")
        '''''''''Clslock3.Sql_SelectLock(DaDeposit1)
        '''''''''Dim Dep1 As Decimal = 0
        '''''''''If Ds.Tables("t2").Rows.Count > 0 Then
        '''''''''    Dep1 = Ds.Tables("t2").Rows(0).Item("Sumdeposit_amount")
        '''''''''End If

        ''''''''''        type_transaction Where  Sum(GL_debit_deposit.debit_amount) 

        '''''''''With DaDeposit3
        '''''''''    .SelectCommand.Parameters("@FromDate").Value = fromdate1
        '''''''''    .SelectCommand.Parameters("@ToDate").Value = todate1
        '''''''''End With
        '''''''''DaDeposit3.Fill(Ds, "t3")
        '''''''''Clslock3.Sql_SelectLock(DaDeposit3)
        '''''''''Dim Deb3 As Decimal = 0
        '''''''''If Ds.Tables("t3").Rows.Count > 0 Then
        '''''''''    Deb3 = Ds.Tables("t3").Rows(0).Item("SumdeBit_amount")
        '''''''''End If

        '''''''''With GlPaid
        '''''''''    .SelectCommand.Parameters("@FromDate").Value = fromdate1
        '''''''''    .SelectCommand.Parameters("@ToDate").Value = todate1
        '''''''''    .SelectCommand.Parameters("@tran_type").Value = "1"
        '''''''''End With
        '''''''''Try
        '''''''''    '                GlPaid.Fill(Ds, "t4")

        '''''''''Catch ex As Exception
        '''''''''    MsgBox(ex.ToString)
        '''''''''End Try
        '''''''''GlPaid.Fill(Ds, "t4")
        '''''''''Clslock3.Sql_SelectLock(GlPaid)
        '''''''''Dim Paid1 As Decimal = 0
        '''''''''If Ds.Tables("t4").Rows.Count > 0 Then
        '''''''''    Paid1 = Ds.Tables("t4").Rows(0).Item("SumAmount")
        '''''''''End If
        '''''''''With GlPaid
        '''''''''    .SelectCommand.Parameters("@FromDate").Value = fromdate1
        '''''''''    .SelectCommand.Parameters("@ToDate").Value = todate1
        '''''''''    .SelectCommand.Parameters("@tran_type").Value = "2"
        '''''''''End With
        '''''''''GlPaid.Fill(Ds, "t5")
        '''''''''Clslock3.Sql_SelectLock(GlPaid)
        '''''''''Dim Paid2 As Decimal = 0
        '''''''''If Ds.Tables("t5").Rows.Count > 0 Then
        '''''''''    Paid2 = Ds.Tables("t5").Rows(0).Item("SumAmount")
        '''''''''End If
        ''''''''''Õ”«» debit  = GL_debit_deposit. GL_account » ⁄œ«œ Â——òÊ—œ
        ''''''''''„»·€ Õ”«» debit =
        ''''''''''3= type_transaction Where  GL_debit_deposit.debit_amount »—«Ì Â—„»·€

        '''''''''With DaDeposit4
        '''''''''    .SelectCommand.Parameters("@FromDate").Value = fromdate1
        '''''''''    .SelectCommand.Parameters("@ToDate").Value = todate1
        '''''''''End With
        '''''''''DaDeposit4.Fill(Ds, "t6")
        '''''''''Clslock3.Sql_SelectLock(DaDeposit4)
        ''''''''''œ— ›«Ì· access  »‰«„ TireMatesetup 
        ''''''''''„«‰œÂ  « »« «—„‰œÂ ’Õ»  ò‰„

        ''''''''''Dim drdtl As DsFrmCloseDay.GL_journal_dtlRow

        ''''''''''‰Ê‘ ‰ œ— Dataset ”‰œ
        '''''''''If Ds.Tables("t2").Rows.Count > 0 Then
        '''''''''    drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
        '''''''''    drdtl.GL_account = Ds.Tables("t2").Rows(0).Item("Gl_AccountBank")
        '''''''''    drdtl.GL_journal_amount_debit = Dep1 + Paid2 - (Paid1 + Deb3)
        '''''''''    drdtl.GL_journal_reference = "Bank Deposit"
        '''''''''    drdtl.id_GL_journal = 1
        '''''''''    drdtl.radif = lastradif
        '''''''''    lastradif += 1

        '''''''''    DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
        '''''''''    For i = 0 To Ds.Tables("t6").Rows.Count - 1
        '''''''''        drdtl = DsFrmCloseDay1.GL_journal_dtl.NewGL_journal_dtlRow
        '''''''''        drdtl.id_GL_journal = 1
        '''''''''        drdtl.radif = lastradif
        '''''''''        lastradif += 1
        '''''''''        drdtl.GL_account = Ds.Tables("t6").Rows(i).Item("Gl_account")
        '''''''''        drdtl.GL_journal_amount_debit = Ds.Tables("t6").Rows(i).Item("Debit_amount")
        '''''''''        drdtl.GL_journal_reference = "Bank Deposit"
        '''''''''        DsFrmCloseDay1.GL_journal_dtl.AddGL_journal_dtlRow(drdtl)
        '''''''''    Next
        '''''''''End If
        ''''''''''2 -  »—«Ì deposit   »«‰ò 
    End Sub
    Sub SaveAsanad()


    End Sub

    Sub AfterSaveSanad(ByVal ThisIdJournal As Int64)
        Dim i As Integer
        CmdGeneral.Connection = CnnUnlock
        '-----------------------
        If CmdGeneral.Connection.State = ConnectionState.Closed Then
            CmdGeneral.Connection.Open()
        End If
        Clslock3.UnLockIt()
        Dim tran1 As SqlClient.SqlTransaction
        tran1 = CnnUnlock.BeginTransaction()
        CmdGeneral.Transaction = tran1
        Try
            For i = 0 To DsFrmCloseDay1.bank_check.Rows.Count - 1
                CmdGeneral.CommandText = " Update bank_check  set id_GL_journal=" & ThisIdJournal & " where id_check =" & DsFrmCloseDay1.bank_check.Rows(i).Item("id_check")
                CmdGeneral.ExecuteNonQuery()
            Next
            'DaDeposit1
            'DaDeposit3
            'DaDeposit4
            CmdGeneral.CommandText = "Update GL_debit_deposit_head   set id_GL_journal= " & ThisIdJournal & "   WHERE      (id_GL_journal IS NULL) AND dbo.ChangeDate(date_doc) >= " & Qt(fromdate1) & "  AND dbo.ChangeDate(date_doc) <= " & Qt(todate1) & " and  id_debit_deposit_head in ( select id_debit_deposit_head from  GL_debit_deposit where  type_transaction in( '1', '2' , '3' ))"
            CmdGeneral.ExecuteNonQuery()
            'glpaied tran_type = "1"
            'CmdGeneral.CommandText = "Update GL_Paid_received   set id_GL_journal= " & ThisIdJournal & "   WHERE     (tran_type =  '2')  AND (id_GL_journal IS NULL) AND dbo.ChangeDate(action_date) >= " & Qt(fromdate1) & " ) AND (dbo.ChangeDate(action_date) <= " & Qt(todate1)
            'CmdGeneral.ExecuteNonQuery()
            'DaBankAtm
            CmdGeneral.CommandText = "Update bank_ATM   set id_GL_journal= " & ThisIdJournal & "   WHERE  (id_GL_journal IS NULL) AND dbo.ChangeDate(date_transaction) >= " & Qt(fromdate1) & "  AND dbo.ChangeDate(date_transaction) <= " & Qt(todate1)
            CmdGeneral.ExecuteNonQuery()
            'DaGlTransferFrom()
            'DaGlTransferTo()
            CmdGeneral.CommandText = "Update GL_transfer_amount   set id_GL_journal= " & ThisIdJournal & "   WHERE  (id_GL_journal IS NULL) AND dbo.ChangeDate(date_transfer) >= " & Qt(fromdate1) & "  AND dbo.ChangeDate(date_transfer) <= " & Qt(todate1)
            CmdGeneral.ExecuteNonQuery()
            'DaBankAdjustment
            CmdGeneral.CommandText = "Update bank_adjustment_head  set id_GL_journal= " & ThisIdJournal & "   WHERE  (id_GL_journal IS NULL) AND dbo.ChangeDate(adjustment_date) >= " & Qt(fromdate1) & "  AND dbo.ChangeDate(adjustment_date) <= " & Qt(todate1)
            CmdGeneral.ExecuteNonQuery()

            '--------type_of_form='IN'
            'DaAnbar  and type_select='I','A'
            'Daanbar2   and type_select='O'
            '----------------------
            '--------type_of_form='RT'
            'DaAnbarCustomerReturn and type_select='I','A'
            'DaAnbarCustomerReturn2 and type_select='O'
            '----------------------
            CmdGeneral.CommandText = "Update service_center_head  set id_GL_journal= " & ThisIdJournal & "   WHERE  (id_GL_journal IS NULL)   AND (service_center_head.type_of_form in  ('IN','RT'))  AND   dbo.ChangeDate(date_refer) >= " & Qt(fromdate1) & "  AND dbo.ChangeDate(date_refer) <= " & Qt(todate1) & " and id_service_center in (select id_service_center from service_center_dtl where type_select in( 'I' ,'A','O') )"
            CmdGeneral.ExecuteNonQuery()
            'DaGlPaiedReceived  tran_type = '1'
            'DaGlPaiedReceived2 tran_type = '2'
            CmdGeneral.CommandText = "Update GL_Paid_received  set id_GL_journal= " & ThisIdJournal & "   WHERE  (id_GL_journal IS NULL)    AND (tran_type in ('1','2'))   AND    dbo.ChangeDate(action_date) >= " & Qt(fromdate1) & "  AND dbo.ChangeDate(action_date) <= " & Qt(todate1)
            CmdGeneral.ExecuteNonQuery()
            'DaGlAccountAdjustment

            CmdGeneral.CommandText = " Update  GL_account_adjustment_head set id_GL_journal= " & ThisIdJournal & "   WHERE  (id_GL_journal IS NULL)   AND (amount_adjustment < 0) And  dbo.ChangeDate(date_adjustment) >= " & Qt(fromdate1) & "  AND dbo.ChangeDate(date_adjustment) <= " & Qt(todate1)
            CmdGeneral.ExecuteNonQuery()
            'DaGlAccountAdjustment2

            CmdGeneral.CommandText = " Update  GL_account_adjustment_head set id_GL_journal= " & ThisIdJournal & "   WHERE  (id_GL_journal IS NULL)   AND (amount_adjustment > 0) And  dbo.ChangeDate(date_adjustment) >= " & Qt(fromdate1) & "  AND dbo.ChangeDate(date_adjustment) <= " & Qt(todate1)
            CmdGeneral.ExecuteNonQuery()


            'GlReceviePayment
            CmdGeneral.CommandText = " Update  Gl_receive_payment set id_GL_journal= " & ThisIdJournal & "   WHERE  (id_GL_journal IS NULL)   And  dbo.ChangeDate(date_receive_payment) >= " & Qt(fromdate1) & "  AND dbo.ChangeDate(date_receive_payment) <= " & Qt(todate1)
            CmdGeneral.ExecuteNonQuery()
            'InvRecevieReturn
            CmdGeneral.CommandText = " Update  Inv_Receive_Products_head  set id_GL_journal= " & ThisIdJournal & "   WHERE  (id_GL_journal IS NULL)   And  dbo.ChangeDate(date_receive) >= " & Qt(fromdate1) & "  AND dbo.ChangeDate(date_receive) <= " & Qt(todate1)
            CmdGeneral.ExecuteNonQuery()
            'invAdjustment
            'InvAdjustment2
            CmdGeneral.CommandText = " Update  inv_adjustment_head  set id_GL_journal= " & ThisIdJournal & "   WHERE  (id_GL_journal IS NULL)   And  dbo.ChangeDate(date_adjustment) >= " & Qt(fromdate1) & "  AND dbo.ChangeDate(date_adjustment) <= " & Qt(todate1)
            CmdGeneral.ExecuteNonQuery()
            'DaInterStor
            CmdGeneral.CommandText = " Update  inv_salse_transfer_head  set id_GL_journal= " & ThisIdJournal & "   WHERE  (id_GL_journal IS NULL)   And  dbo.ChangeDate(date_action) >= " & Qt(fromdate1) & "  AND dbo.ChangeDate(date_action) <= " & Qt(todate1)
            CmdGeneral.ExecuteNonQuery()
            'DaInvSalesTransfer
            'Remidnders
            CmdGeneral.CommandText = " Update  service_center_head  set id_GL_journal= " & ThisIdJournal & "   WHERE  (id_GL_journal IS NULL)   And  dbo.ChangeDate(date_refer) >= " & Qt(fromdate1) & "  AND dbo.ChangeDate(date_refer) <= " & Qt(todate1)
            CmdGeneral.ExecuteNonQuery()


            tran1.Commit()
            MsgFar("Close day Successed ")

        Catch ex As Exception
            tran1.Rollback()
            MsgBox(ex.ToString)

        Finally
            CmdGeneral.Connection.Close()
        End Try
        '------------------------
    End Sub

    Sub FixthisDatabase()
        CmdGeneral.Connection = CnnUnlock
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

        CmdGeneral.CommandText = "alter table inv_salse_transfer_head add id_GL_journal int "
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        'Gl_receive_payment
        CmdGeneral.CommandText = "alter table Gl_receive_payment add id_GL_journal int"
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Sub
    Sub MakeJournalform()
        If DsFrmCloseDay1.GL_journal_dtl.Rows.Count > 0 Then
            MakeFrmJournal = New FrmJournal
            MakeFrmJournal.ExitAfterSaveOrCancel = True
            MakeFrmJournal.StartPosition = FormStartPosition.CenterScreen
            MakeFrmJournal.LoadFromCloseDay = True
            MakeFrmJournal.ShowDialog()
        Else
            MsgFar("There is no Transaction For Close Day ")
        End If
    End Sub
    Private Sub MakeFrmJournal_AfterSave(ByVal ThisIdJournal As Long) Handles MakeFrmJournal.AfterSave
        Call AfterSaveSanad(ThisIdJournal)
    End Sub

    Private Sub MakeFrmJournal_LoadFromCloseDayToThisFrm(ByRef ThisFrm As FrmJournal) Handles MakeFrmJournal.LoadFromCloseDayToThisFrm
        ThisFrm.Paddnew()
        ThisFrm.DsFrmJournal1.GL_journal_dtl.Clear()
        ThisFrm.DsFrmJournal1.GL_journal_head.Clear()
        ThisFrm.TxtGL_journal_reference.Text = "From Close day "
        Dim Debit As Decimal = 0
        Dim Credit As Decimal = 0
        For i = 0 To DsFrmCloseDay1.GL_journal_dtl.Rows.Count - 1
            Dim dr As DataRow
            dr = ThisFrm.DsFrmJournal1.GL_journal_dtl.NewRow
            dr("id_GL_journal") = MakeFrmJournal.TxtRef.Text.Trim
            dr("radif") = DsFrmCloseDay1.GL_journal_dtl.Rows(i).Item("radif")
            dr("gl_account") = DsFrmCloseDay1.GL_journal_dtl.Rows(i).Item("gl_account") & ""
            dr("desc_GL_account") = ClsGlAccount1.FindDesc1(DsFrmCloseDay1.GL_journal_dtl.Rows(i).Item("gl_account") & "")
            dr("GL_journal_reference") = DsFrmCloseDay1.GL_journal_dtl.Rows(i).Item("GL_journal_reference") & ""
            Debit = Math.Round(CDec(Val(DsFrmCloseDay1.GL_journal_dtl.Rows(i).Item("GL_journal_amount_debit") & "")), 2)
            Credit = Math.Round(CDec(Val(DsFrmCloseDay1.GL_journal_dtl.Rows(i).Item("GL_journal_amount_Credit") & "")), 2)
            dr("GL_journal_amount_debit") = Debit
            dr("GL_journal_amount_Credit") = Credit
            'If Debit <> 0 Then
            '    dr("GL_journal_amount_debit") = Debit
            'End If
            'If Credit <> 0 Then
            '    dr("GL_journal_amount_Credit") = Credit
            'End If
            ThisFrm.DsFrmJournal1.GL_journal_dtl.Rows.Add(dr)
        Next
        Call ThisFrm.AddEmptyRecordInDetail()
        ThisFrm.GrdDetail.Refetch()
    End Sub
End Class

