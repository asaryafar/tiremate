
Imports CommonClass
Imports Janus.Windows.GridEX
Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Text

Public Class frmConvertFromText
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
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ImgWork As System.Windows.Forms.ImageList
    Friend WithEvents txtPath As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblWait As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents CnnSql As System.Data.SqlClient.SqlConnection
    Friend WithEvents CnnAccess As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents daFile_Destination As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DsConvertFromText1 As Convert.dsConvertFromText
    Friend WithEvents daFile_Destination_DTL As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmConvertFromText))
        Me.ImgWork = New System.Windows.Forms.ImageList(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.txtPath = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblWait = New System.Windows.Forms.Label
        Me.btnConvert = New System.Windows.Forms.Button
        Me.CnnSql = New System.Data.SqlClient.SqlConnection
        Me.CnnAccess = New System.Data.OleDb.OleDbConnection
        Me.daFile_Destination = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DsConvertFromText1 = New Convert.dsConvertFromText
        Me.daFile_Destination_DTL = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DsConvertFromText1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImgWork
        '
        Me.ImgWork.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImgWork.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgWork.ImageStream = CType(resources.GetObject("ImgWork.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgWork.TransparentColor = System.Drawing.Color.Transparent
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Please select the path of Text Files ...."
        '
        'txtPath
        '
        Me.txtPath.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.txtPath.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.txtPath.ButtonFont = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtPath.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis
        Me.txtPath.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtPath.Location = New System.Drawing.Point(16, 32)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPath.Size = New System.Drawing.Size(432, 25)
        Me.txtPath.TabIndex = 217
        Me.txtPath.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 218
        Me.Label1.Text = "Text files path :"
        '
        'lblWait
        '
        Me.lblWait.BackColor = System.Drawing.Color.Transparent
        Me.lblWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblWait.ForeColor = System.Drawing.Color.Red
        Me.lblWait.Location = New System.Drawing.Point(96, 327)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(104, 16)
        Me.lblWait.TabIndex = 221
        Me.lblWait.Text = "Please wait ....."
        Me.lblWait.Visible = False
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnConvert.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnConvert.Location = New System.Drawing.Point(16, 320)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(64, 24)
        Me.btnConvert.TabIndex = 220
        Me.btnConvert.Text = "Convert"
        '
        'CnnSql
        '
        Me.CnnSql.ConnectionString = "workstation id=NET;packet size=4096;integrated security=SSPI;data source=Net;pers" & _
        "ist security info=False;initial catalog=TireMate_03"
        '
        'CnnAccess
        '
        Me.CnnAccess.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""E:\VB.NET My Programs\My" & _
        "Projects\TireMateConvert\BaseConvert.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet " & _
        "OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:Sy" & _
        "stem database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet" & _
        " OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:D" & _
        "on't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False" & _
        ";User ID=Admin;Jet OLEDB:Encrypt Database=False"
        '
        'daFile_Destination
        '
        Me.daFile_Destination.SelectCommand = Me.OleDbSelectCommand1
        Me.daFile_Destination.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "File_Destination", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DesFileCode", "DesFileCode"), New System.Data.Common.DataColumnMapping("DesFileName", "DesFileName"), New System.Data.Common.DataColumnMapping("TarTableName", "TarTableName"), New System.Data.Common.DataColumnMapping("IsActive", "IsActive"), New System.Data.Common.DataColumnMapping("Priority", "Priority")})})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT DesFileCode, DesFileName, TarTableName, IsActive, Priority FROM File_Desti" & _
        "nation WHERE (IsActive = - 1)"
        Me.OleDbSelectCommand1.Connection = Me.CnnAccess
        '
        'DsConvertFromText1
        '
        Me.DsConvertFromText1.DataSetName = "dsConvertFromText"
        Me.DsConvertFromText1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'daFile_Destination_DTL
        '
        Me.daFile_Destination_DTL.SelectCommand = Me.OleDbSelectCommand2
        Me.daFile_Destination_DTL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "File_Destination_DTL", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DesFileCode", "DesFileCode"), New System.Data.Common.DataColumnMapping("DesFieldCode", "DesFieldCode"), New System.Data.Common.DataColumnMapping("DesFieldName", "DesFieldName"), New System.Data.Common.DataColumnMapping("Begin", "Begin"), New System.Data.Common.DataColumnMapping("Len", "Len"), New System.Data.Common.DataColumnMapping("TargetFieldType", "TargetFieldType")})})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT DesFileCode, DesFieldCode, DesFieldName, Begin, Len, TargetFieldType FROM " & _
        "File_Destination_DTL"
        Me.OleDbSelectCommand2.Connection = Me.CnnAccess
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 72)
        Me.Button1.TabIndex = 222
        Me.Button1.Text = "Button1"
        '
        'frmConvertFromText
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 360)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConvertFromText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convert"
        CType(Me.DsConvertFromText1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmConvertFromText_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CnnSql.ConnectionString = PConnectionString
        'Me.CnnAccess.ConnectionString = PConnectionStringForConvertMDB
    End Sub

    Private Sub txtPath_ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPath.ButtonClick
        FolderBrowserDialog1.ShowDialog()
        txtPath.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        lblWait.Visible = True
        Me.Refresh()
        Dim FilePath As String
        Dim fs As FileStream
        Dim FileCount, I As Byte
        Dim FileFieldCount, I_Field As Byte
        Dim FileCode As String
        Dim FileName As String
        Dim MdbTableName As String
        Dim TextLine As String
        Dim Fields, Values As String
        'Dim Reader As Boolean
        Dim cmdInsert As New System.Data.OleDb.OleDbCommand
        Dim I_Insert As Integer
        FilePath = txtPath.Text.Trim

        DsConvertFromText1.File_Destination_DTL.Clear()
        DsConvertFromText1.File_Destination.Clear()
        daFile_Destination.Fill(DsConvertFromText1.File_Destination)
        daFile_Destination_DTL.Fill(DsConvertFromText1.File_Destination_DTL)
        FileCount = DsConvertFromText1.File_Destination.Count

        Try
            cmdInsert.Connection = CnnAccess
            If CnnAccess.State <> ConnectionState.Open Then CnnAccess.Open()
            For I = 0 To FileCount - 1
                FileCode = DsConvertFromText1.File_Destination.Rows(I).Item("DesFileCode").ToString.Trim
                FileName = DsConvertFromText1.File_Destination.Rows(I).Item("DesFileName").ToString.Trim
                MdbTableName = DsConvertFromText1.File_Destination.Rows(I).Item("TarTableName").ToString.Trim
                Dim ReaderText As StreamReader = New StreamReader(FilePath & "\" & FileName, System.Text.Encoding.Default)
                
                'fs = File.Open(FilePath & "\" & FileName, FileMode.Open, FileAccess.Read)

                DsConvertFromText1.File_Destination_DTL.DefaultView.RowFilter = "DesFileCode = '" & FileCode & "'"
                FileFieldCount = DsConvertFromText1.File_Destination_DTL.DefaultView.Count
                Dim FieldName(FileFieldCount) As Object
                Dim BeginChar(FileFieldCount) As Object
                Dim LenChar(FileFieldCount) As Object
                Dim TargetFieldType(FileFieldCount) As Object

                For I_Field = 0 To FileFieldCount - 1
                    FieldName(I_Field) = DsConvertFromText1.File_Destination_DTL.DefaultView(I_Field).Item("DesFieldName")
                    BeginChar(I_Field) = DsConvertFromText1.File_Destination_DTL.DefaultView(I_Field).Item("Begin")
                    LenChar(I_Field) = DsConvertFromText1.File_Destination_DTL.DefaultView(I_Field).Item("Len")
                    TargetFieldType(I_Field) = DsConvertFromText1.File_Destination_DTL.DefaultView(I_Field).Item("TargetFieldType")
                Next

                For I_Field = 0 To FileFieldCount - 1
                    If I_Field <> FileFieldCount - 1 Then
                        Fields = Fields & FieldName(I_Field) & ", "
                    Else
                        Fields = Fields & FieldName(I_Field)
                    End If
                Next

                Dim m As Integer
                Do While ReaderText.Peek() >= 0
                    m = m + 1

                    TextLine = Mid(ReaderText.ReadLine, 5, 185)

                    If m = 41 Then
                        MsgBox(TextLine)
                    End If

                    Values = ""
                    For I_Field = 0 To FileFieldCount - 1
                        If I_Field <> FileFieldCount - 1 Then
                            Values = Values & "'" & Mid(TextLine, BeginChar(I_Field), LenChar(I_Field)) & "', "
                        Else
                            Values = Values & "'" & Mid(TextLine, BeginChar(I_Field), LenChar(I_Field)) & "' "
                        End If
                    Next
                    cmdInsert.CommandText = "Insert InTo " & MdbTableName & " (" & Fields & ") VALUES (" & Values & ")"
                    cmdInsert.ExecuteNonQuery()
                Loop

            Next
            'CnnAccess.Close()




            'cmdInsert.Connection = CnnAccess
            'If CnnAccess.State <> ConnectionState.Open Then CnnAccess.Open()
            'cmdInsert.CommandText = "Insert InTo [" & FileName & "] VALUES ('" & Hesab_No & "', '" & Mablagh & "', '" & Prs_No & "')"
            'cmdInsert.ExecuteNonQuery()
            'CnnAccess.Close()
        Catch ex As System.IO.FileNotFoundException
            MsgBox("Path or filename of text file is wrong, Try again ...", MsgBoxStyle.Exclamation, "Error")
        Catch ex As Exception
            MsgBox(ex.Message() + "    " + ex.GetType.ToString + "   ", , "btn Convert")
        Finally
            lblWait.Visible = False
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim path As String = "c:\temp\ar001.txt"
        Dim fs As FileStream

        '' Delete the file if it exists.
        'If File.Exists(path) = False Then
        '    ' Create the file.
        '    fs = File.Create(path)
        '    Dim info As Byte() = New UTF8Encoding(True).GetBytes("This is some text in the file.")

        '    ' Add some information to the file.
        '    fs.Write(info, 0, info.Length)
        '    fs.Close()
        'End If

        ' Open the stream and read it back.
        fs = File.Open(path, FileMode.Open, FileAccess.Read)
        Dim b(275) As Byte
        Dim temp As UTF8Encoding = New UTF8Encoding(True)

        Do While fs.Read(b, 0, b.Length) > 0
            MsgBox(temp.GetString(b))

            'Console.WriteLine(temp.GetString(b))
        Loop

        Try
            ' Try to get another handle to the same file.
            Dim fs2 As FileStream = File.Open(path, FileMode.Open)
            ' Do some task here.
            fs2.Close()
        Catch ex As Exception
            Console.Write("Opening the file twice is disallowed.")
            Console.WriteLine(", as expected: {0}", e.ToString())
        End Try

        fs.Close()
    End Sub
End Class

