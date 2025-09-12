Imports CommonClass
Imports System.ComponentModel
Public Class PhoneDriverButton
    Inherits System.Windows.Forms.UserControl
    Dim WithEvents MyFrmPhoneScreen As New FrmPhoneDriverScreen
    Private MCnn As New System.Data.SqlClient.SqlConnection(PConnectionString)
    Public HeaderName As String
    Public Event PhoneScreenAfterClose()
    Shadows Event Click(ByVal sender As Object, ByVal e As System.EventArgs)
    Dim tbName As String
    Dim where As String
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
    Friend WithEvents btnPhone As System.Windows.Forms.Button
    Public WithEvents DsPhone1 As UCPhone.DSPhone
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAPhone As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DABas_tab_phone_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PhoneDriverButton))
        Me.btnPhone = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAPhone = New System.Data.SqlClient.SqlDataAdapter
        Me.DABas_tab_phone_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DsPhone1 = New UCPhone.DSPhone
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        CType(Me.DsPhone1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPhone
        '
        Me.btnPhone.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.btnPhone.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPhone.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnPhone.Image = CType(resources.GetObject("btnPhone.Image"), System.Drawing.Image)
        Me.btnPhone.Location = New System.Drawing.Point(0, 0)
        Me.btnPhone.Name = "btnPhone"
        Me.btnPhone.Size = New System.Drawing.Size(23, 23)
        Me.btnPhone.TabIndex = 6
        Me.btnPhone.TabStop = False
        '
        'DAPhone
        '
        Me.DAPhone.SelectCommand = Me.SqlSelectCommand1
        Me.DAPhone.UpdateCommand = Me.SqlCommand1
        '
        'DABas_tab_phone_type
        '
        Me.DABas_tab_phone_type.SelectCommand = Me.SqlSelectCommand2
        Me.DABas_tab_phone_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_tab_phone_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_type_phone", "cod_type_phone"), New System.Data.Common.DataColumnMapping("desc_type_phone", "desc_type_phone")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_type_phone, desc_type_phone FROM bas_tab_phone_type"
        '
        'DsPhone1
        '
        Me.DsPhone1.DataSetName = "DsPhone"
        Me.DsPhone1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlCommand1
        '
        Me.SqlCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=TIRE;packet size=4096;user id=sa;data source=""."";persist security " & _
        "info=False;initial catalog=TireMate_05"
        '
        'PhoneDriverButton
        '
        Me.Controls.Add(Me.btnPhone)
        Me.Name = "PhoneDriverButton"
        Me.Size = New System.Drawing.Size(23, 23)
        CType(Me.DsPhone1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim _ZEnabled As Boolean = True
    <Description("Indicates whether the control is enabled"), Category("Behavior")> _
    Public Property ZEnabled() As Boolean
        Get
            ZEnabled = _ZEnabled
        End Get
        Set(ByVal Value As Boolean)
            _ZEnabled = Value
        End Set
    End Property
    Public Sub FillDataSet(ByVal TableName As String, ByVal WhereClause As String)
        Dim aa As String
        Try
            MCnn.Open()
        Catch ex As Exception
        End Try

        tbName = TableName
        where = WhereClause

        DAPhone.SelectCommand.CommandText = "Select " _
                   & "phone_1,extension_1,phone_type_1,phone_main_1,driver_name1, " _
                   & "phone_2,extension_2,phone_type_2,phone_main_2, driver_name2," _
                   & "phone_3,extension_3,phone_type_3,phone_main_3, driver_name3," _
                   & "phone_4,extension_4,phone_type_4,phone_main_4, driver_name4," _
                   & "phone_5,extension_5,phone_type_5,phone_main_5, driver_name5  " _
                   & "From " & TableName & " Where " & WhereClause
        DAPhone.SelectCommand.Connection = MCnn
        DsPhone1.Phone.Clear()
        DAPhone.Fill(DsPhone1, "Phone")
        Call AddRecordToDatasetIFEmpty()
        Call FillBas_tab_phone_type()
    End Sub
    Private Sub AddRecordToDatasetIFEmpty(Optional ByVal EmptyItFlag As Boolean = False)
        If EmptyItFlag Then DsPhone1.Phone.Clear()
        If DsPhone1.Phone.Rows.Count < 1 Then
            Dim dr As DataRow
            dr = DsPhone1.Phone.NewRow
            dr.Item("phone_1") = ""
            dr.Item("phone_2") = ""
            dr.Item("phone_3") = ""
            dr.Item("phone_4") = ""
            dr.Item("phone_5") = ""
            dr.Item("phone_main_1") = True
            dr.Item("phone_main_2") = False
            dr.Item("phone_main_3") = False
            dr.Item("phone_main_4") = False
            dr.Item("phone_main_5") = False
            dr.Item("extension_1") = ""
            dr.Item("extension_2") = ""
            dr.Item("extension_3") = ""
            dr.Item("extension_4") = ""
            dr.Item("extension_5") = ""
            dr.Item("phone_type_1") = "1"
            dr.Item("phone_type_2") = "2"
            dr.Item("phone_type_3") = "3"
            dr.Item("phone_type_4") = "4"
            dr.Item("phone_type_5") = "5"
            dr.Item("driver_name1") = ""
            dr.Item("driver_name2") = ""
            dr.Item("driver_name3") = ""
            dr.Item("driver_name4") = ""
            dr.Item("driver_name5") = ""

            DsPhone1.Phone.Rows.Add(dr)
            Call FillBas_tab_phone_type()
        End If
    End Sub
    Private Sub FillBas_tab_phone_type()
        If MyFrmPhoneScreen.DsFrmPhoneScreen1.bas_tab_phone_type1.Rows.Count = 0 Then
            DABas_tab_phone_type.SelectCommand.Connection = MCnn
            DABas_tab_phone_type.Fill(MyFrmPhoneScreen.DsFrmPhoneScreen1, "bas_tab_phone_type1")
            DABas_tab_phone_type.Fill(MyFrmPhoneScreen.DsFrmPhoneScreen1, "bas_tab_phone_type2")
            DABas_tab_phone_type.Fill(MyFrmPhoneScreen.DsFrmPhoneScreen1, "bas_tab_phone_type3")
            DABas_tab_phone_type.Fill(MyFrmPhoneScreen.DsFrmPhoneScreen1, "bas_tab_phone_type4")
            DABas_tab_phone_type.Fill(MyFrmPhoneScreen.DsFrmPhoneScreen1, "bas_tab_phone_type5")
        End If
    End Sub
    Private Sub btnPhone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhone.Click
        RaiseEvent Click(sender, e)
        Call FitToScreen(Me, MyFrmPhoneScreen)
        If ZEnabled Then
            MyFrmPhoneScreen.ThisFormStatus = MainModule.WorkStates.AddNew
        Else
            MyFrmPhoneScreen.ThisFormStatus = MainModule.WorkStates._ReadOnly
        End If
        MyFrmPhoneScreen.Left = MyFrmPhoneScreen.Left
        MyFrmPhoneScreen.Top = MyFrmPhoneScreen.Top
        Call FillPhoneScreen()
        MyFrmPhoneScreen.TxtName.Text = HeaderName
        MyFrmPhoneScreen.ShowDialog()

        If MyFrmPhoneScreen.Changed Then

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = " Update   Cust_trtab_main  Set " & _
                   " phone_1 = '" & MyFrmPhoneScreen.UcPhoneNo1Var.Trim() & "', phone_main_1 = " & IIf(MyFrmPhoneScreen.RdoMain1Var, "1", "0") & ",driver_name1 = '" & MyFrmPhoneScreen.UcDriverName1 & "'" & _
                   " ,phone_2 = '" & MyFrmPhoneScreen.UcPhoneNo2Var.Trim() & "', phone_main_2 = " & IIf(MyFrmPhoneScreen.RdoMain2Var, "1", "0") & ",driver_name2 = '" & MyFrmPhoneScreen.UcDriverName2 & "'" & _
                   " ,phone_3 = '" & MyFrmPhoneScreen.UcPhoneNo3Var.Trim() & "', phone_main_3 = " & IIf(MyFrmPhoneScreen.RdoMain3Var, "1", "0") & ",driver_name3 = '" & MyFrmPhoneScreen.UcDriverName3 & "'" & _
                   " ,phone_4 = '" & MyFrmPhoneScreen.UcPhoneNo4Var.Trim() & "', phone_main_4 = " & IIf(MyFrmPhoneScreen.RdoMain4Var, "1", "0") & ",driver_name4 = '" & MyFrmPhoneScreen.UcDriverName4 & "'" & _
                   " ,phone_5 = '" & MyFrmPhoneScreen.UcPhoneNo5Var.Trim() & "', phone_main_5 = " & IIf(MyFrmPhoneScreen.RdoMain5Var, "1", "0") & ",driver_name5 = '" & MyFrmPhoneScreen.UcDriverName5 & "'" & _
                   " Where " & where
            cmd.Connection = MCnn

            If cmd.Connection.State <> ConnectionState.Open Then
                cmd.Connection.Open()
            End If

            cmd.ExecuteNonQuery()

            FillDataSet(tbName, where)
        End If
    End Sub
    Private Sub FillPhoneScreen()
        Call AddRecordToDatasetIFEmpty()
        MyFrmPhoneScreen.UcPhoneNo1Var = DsPhone1.Phone.Rows(0).Item("phone_1") & ""
        MyFrmPhoneScreen.UcPhoneNo2Var = DsPhone1.Phone.Rows(0).Item("phone_2") & ""
        MyFrmPhoneScreen.UcPhoneNo3Var = DsPhone1.Phone.Rows(0).Item("phone_3") & ""
        MyFrmPhoneScreen.UcPhoneNo4Var = DsPhone1.Phone.Rows(0).Item("phone_4") & ""
        MyFrmPhoneScreen.UcPhoneNo5Var = DsPhone1.Phone.Rows(0).Item("phone_5") & ""
        MyFrmPhoneScreen.RdoMain1Var = DsPhone1.Phone.Rows(0).Item("phone_main_1")
        MyFrmPhoneScreen.RdoMain2Var = DsPhone1.Phone.Rows(0).Item("phone_main_2")
        MyFrmPhoneScreen.RdoMain3Var = DsPhone1.Phone.Rows(0).Item("phone_main_3")
        MyFrmPhoneScreen.RdoMain4Var = DsPhone1.Phone.Rows(0).Item("phone_main_4")
        MyFrmPhoneScreen.RdoMain5Var = DsPhone1.Phone.Rows(0).Item("phone_main_5")
        MyFrmPhoneScreen.UcDriverName1 = DsPhone1.Phone.Rows(0).Item("driver_name1") & ""
        MyFrmPhoneScreen.UcDriverName2 = DsPhone1.Phone.Rows(0).Item("driver_name2") & ""
        MyFrmPhoneScreen.UcDriverName3 = DsPhone1.Phone.Rows(0).Item("driver_name3") & ""
        MyFrmPhoneScreen.UcDriverName4 = DsPhone1.Phone.Rows(0).Item("driver_name4") & ""
        MyFrmPhoneScreen.UcDriverName5 = DsPhone1.Phone.Rows(0).Item("driver_name5") & ""

    End Sub
    Public Sub ClearPhoneScreen()
        Call AddRecordToDatasetIFEmpty(True)
        MyFrmPhoneScreen.UcPhoneNo1Var = ""
        MyFrmPhoneScreen.UcPhoneNo2Var = ""
        MyFrmPhoneScreen.UcPhoneNo3Var = ""
        MyFrmPhoneScreen.UcPhoneNo4Var = ""
        MyFrmPhoneScreen.UcPhoneNo5Var = ""
        MyFrmPhoneScreen.RdoMain1Var = True
        MyFrmPhoneScreen.RdoMain2Var = False
        MyFrmPhoneScreen.RdoMain3Var = False
        MyFrmPhoneScreen.RdoMain4Var = False
        MyFrmPhoneScreen.RdoMain5Var = False
        MyFrmPhoneScreen.UcDriverName1 = ""
        MyFrmPhoneScreen.UcDriverName2 = ""
        MyFrmPhoneScreen.UcDriverName3 = ""
        MyFrmPhoneScreen.UcDriverName4 = ""
        MyFrmPhoneScreen.UcDriverName5 = ""

    End Sub
    Public Function FillPhoneNoMain() As Array
        Dim ff() As String = {"", "", ""}

        If DsPhone1.Phone.Rows(0).Item("phone_main_1") Then
            ff(1) = DsPhone1.Phone.Rows(0).Item("phone_1") & ""
            ff(2) = DsPhone1.Phone.Rows(0).Item("driver_name1") & ""
        End If
        If DsPhone1.Phone.Rows(0).Item("phone_main_2") Then
            ff(1) = DsPhone1.Phone.Rows(0).Item("phone_2") & ""
            ff(2) = DsPhone1.Phone.Rows(0).Item("driver_name2") & ""
        End If
        If DsPhone1.Phone.Rows(0).Item("phone_main_3") Then
            ff(1) = DsPhone1.Phone.Rows(0).Item("phone_3") & ""
            ff(2) = DsPhone1.Phone.Rows(0).Item("driver_name3") & ""
        End If
        If DsPhone1.Phone.Rows(0).Item("phone_main_4") Then
            ff(1) = DsPhone1.Phone.Rows(0).Item("phone_4") & ""
            ff(2) = DsPhone1.Phone.Rows(0).Item("driver_name4") & ""
        End If
        If DsPhone1.Phone.Rows(0).Item("phone_main_5") Then
            ff(1) = DsPhone1.Phone.Rows(0).Item("phone_5") & ""
            ff(2) = DsPhone1.Phone.Rows(0).Item("driver_name5") & ""
        End If
        FillPhoneNoMain = ff
    End Function
    Public Sub GetPhoneNoMain(ByVal InPhoneNo As String, ByVal DriverName As String)
        If MyFrmPhoneScreen.RdoMain1.Checked Then
            MyFrmPhoneScreen.UcPhoneNo1Var = InPhoneNo
            DsPhone1.Phone.Rows(0).Item("phone_1") = InPhoneNo
            DsPhone1.Phone.Rows(0).Item("driver_name1") = DriverName
        End If
        If MyFrmPhoneScreen.RdoMain2.Checked Then
            MyFrmPhoneScreen.UcPhoneNo2Var = InPhoneNo
            DsPhone1.Phone.Rows(0).Item("phone_2") = InPhoneNo
            DsPhone1.Phone.Rows(0).Item("driver_name2") = DriverName
        End If
        If MyFrmPhoneScreen.RdoMain3.Checked Then
            MyFrmPhoneScreen.UcPhoneNo3Var = InPhoneNo
            DsPhone1.Phone.Rows(0).Item("phone_3") = InPhoneNo
            DsPhone1.Phone.Rows(0).Item("driver_name3") = DriverName
        End If
        If MyFrmPhoneScreen.RdoMain4.Checked Then
            MyFrmPhoneScreen.UcPhoneNo4Var = InPhoneNo
            DsPhone1.Phone.Rows(0).Item("phone_4") = InPhoneNo
            DsPhone1.Phone.Rows(0).Item("driver_name4") = DriverName
        End If
        If MyFrmPhoneScreen.RdoMain5.Checked Then
            MyFrmPhoneScreen.UcPhoneNo5Var = InPhoneNo
            DsPhone1.Phone.Rows(0).Item("phone_5") = InPhoneNo
            DsPhone1.Phone.Rows(0).Item("driver_name5") = DriverName
        End If
    End Sub
    Private Sub CommentButton_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'BtNComments.Text = ZButtonText
    End Sub
    Private Sub MyFrmPhoneScreen_PhoneScreenAfterClose() Handles MyFrmPhoneScreen.PhoneScreenAfterClose
        If ZEnabled Then
            DsPhone1.Phone.Rows(0).Item("phone_1") = MyFrmPhoneScreen.UcPhoneNo1Var
            DsPhone1.Phone.Rows(0).Item("phone_2") = MyFrmPhoneScreen.UcPhoneNo2Var
            DsPhone1.Phone.Rows(0).Item("phone_3") = MyFrmPhoneScreen.UcPhoneNo3Var
            DsPhone1.Phone.Rows(0).Item("phone_4") = MyFrmPhoneScreen.UcPhoneNo4Var
            DsPhone1.Phone.Rows(0).Item("phone_5") = MyFrmPhoneScreen.UcPhoneNo5Var
            DsPhone1.Phone.Rows(0).Item("phone_main_1") = MyFrmPhoneScreen.RdoMain1Var
            DsPhone1.Phone.Rows(0).Item("phone_main_2") = MyFrmPhoneScreen.RdoMain2Var
            DsPhone1.Phone.Rows(0).Item("phone_main_3") = MyFrmPhoneScreen.RdoMain3Var
            DsPhone1.Phone.Rows(0).Item("phone_main_4") = MyFrmPhoneScreen.RdoMain4Var
            DsPhone1.Phone.Rows(0).Item("phone_main_5") = MyFrmPhoneScreen.RdoMain5Var
            DsPhone1.Phone.Rows(0).Item("driver_name1") = MyFrmPhoneScreen.UcDriverName1
            DsPhone1.Phone.Rows(0).Item("driver_name2") = MyFrmPhoneScreen.UcDriverName2
            DsPhone1.Phone.Rows(0).Item("driver_name3") = MyFrmPhoneScreen.UcDriverName3
            DsPhone1.Phone.Rows(0).Item("driver_name4") = MyFrmPhoneScreen.UcDriverName4
            DsPhone1.Phone.Rows(0).Item("driver_name5") = MyFrmPhoneScreen.UcDriverName5

            RaiseEvent PhoneScreenAfterClose()
        End If
    End Sub
    'Private Sub MyFrmPhoneScreen_CloseMe() Handles MyFrmPhoneScreen.CloseMe
    '    MyFrmPhoneScreen.Close()
    '    MyFrmPhoneScreen = Nothing
    'End Sub
End Class
