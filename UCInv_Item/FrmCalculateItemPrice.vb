Imports CommonClass
Public Class FrmCalculateItemPrice
    Inherits CommonClass.FrmBase
    Dim WithEvents MyItem As UCInv_Item.Clsitem_no
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneralForReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents CnnForReader As System.Data.SqlClient.SqlConnection
    Friend WithEvents CnnTemp As System.Data.SqlClient.SqlConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneralForReader = New System.Data.SqlClient.SqlCommand
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdClose = New Janus.Windows.EditControls.UIButton
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CnnForReader = New System.Data.SqlClient.SqlConnection
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJIXP;packet size=4096;user id=sa;data source=""."";persist secur" & _
        "ity info=True;initial catalog=Tiremate_01;password=sa"
        '
        'CmdGeneralForReader
        '
        Me.CmdGeneralForReader.Connection = Me.CnnForReader
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 219)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(350, 10)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 479
        Me.ProgressBar1.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(366, 49)
        Me.Panel9.TabIndex = 480
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Items Selling Prices"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 123)
        Me.Label2.TabIndex = 481
        Me.Label2.Text = "This process must be performed whenever changes are made to the replacement costs" & _
        " or list price of items, through inventory receipt and /or new purchases.using p" & _
        "rice codes,new selling prices are calculated for each item this process may take" & _
        " several minutes to complete."
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(16, 193)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 482
        Me.CmdOk.Text = "Calculate"
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(280, 193)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(75, 23)
        Me.CmdClose.TabIndex = 483
        Me.CmdClose.Text = "Cancel"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.CnnTemp
        '
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'FrmCalculateItemPrice
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(366, 236)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "FrmCalculateItemPrice"
        Me.Text = "Calculate Item Price"
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCalculateItemPrice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        CnnTemp.ConnectionString = PConnectionString
        CnnForReader.ConnectionString = PConnectionString
        'CmdGeneralForReader.Connection = Me.Cnn
    End Sub

    Private Sub UpdateItemPrice(ByVal ThisPriceCose As String)
        MyItem = New UCInv_Item.Clsitem_no
        MyItem.Connection = Me.Cnn
        Dim Pl1 As Double
        Dim Pl2 As Double
        Dim Pl3 As Double
        Dim Pl4 As Double
        Dim Pl5 As Double
        Dim Pl6 As Double
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
            CmdGeneralForReader.Connection.Open()
        End If
        ProgressBar1.Visible = True
        ProgressBar1.Value = 0
        ProgressBar1.Minimum = 0
        If ThisPriceCose.Trim.Length = 0 Then
            CmdGeneralForReader.CommandText = "SELECT count(*) from inv_item_cost_transaction Where last_flag=1"
            ProgressBar1.Maximum = CmdGeneralForReader.ExecuteScalar
            CmdGeneralForReader.CommandText = "SELECT * from inv_item_cost_transaction Where last_flag=1"
        Else
            CmdGeneralForReader.CommandText = "SELECT count(*) from inv_item_cost_transaction Where price_code=" & Qt(ThisPriceCose) & " AND last_flag=1"
            ProgressBar1.Maximum = CmdGeneralForReader.ExecuteScalar
            CmdGeneralForReader.CommandText = "SELECT * from inv_item_cost_transaction Where price_code=" & Qt(ThisPriceCose) & " AND last_flag=1"
        End If
        SQLReader = CmdGeneralForReader.ExecuteReader
        If SQLReader.HasRows Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Do While SQLReader.Read()
                Pl1 = 0
                Pl2 = 0
                Pl3 = 0
                Pl4 = 0
                Pl5 = 0
                Pl6 = 0
                Pl1 = MyItem.CalculatePriceCode(SQLReader.Item("Item_No"), 1)
                Pl2 = MyItem.CalculatePriceCode(SQLReader.Item("Item_No"), 2)
                Pl3 = MyItem.CalculatePriceCode(SQLReader.Item("Item_No"), 3)
                Pl4 = MyItem.CalculatePriceCode(SQLReader.Item("Item_No"), 4)
                Pl5 = MyItem.CalculatePriceCode(SQLReader.Item("Item_No"), 5)
                Pl6 = MyItem.CalculatePriceCode(SQLReader.Item("Item_No"), 6)
                CmdGeneral.CommandText = "Update inv_item_cost_transaction SET amount_price1=" & Pl1 & ",amount_price2=" & Pl2 & ",amount_price3=" & Pl3 & ",amount_price4=" & Pl4 & ",amount_price5=" & Pl5 & ",amount_price6=" & Pl6 & " WHERE item_no=" & Qt(SQLReader.Item("Item_No")) & " AND last_flag=1"
                CmdGeneral.ExecuteNonQuery()
                ProgressBar1.Value = ProgressBar1.Value + 1
                'System.Windows.Forms.Application.DoEvents()
                Me.Refresh()
                Application.DoEvents()
            Loop
        End If
        SQLReader.Close()
        ProgressBar1.Visible = False
    End Sub

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        CmdClose.Enabled = False
        CmdOk.Enabled = False
        Call UpdateItemPrice("")
        MsgFar("Update Successfully Completed")
        CmdClose.Enabled = True
        CmdOk.Enabled = True
    End Sub

    Private Sub UiButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub
End Class
