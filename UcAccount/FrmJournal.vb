Imports CommonClass
Public Class FrmJournal
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaTypeJournal As System.Data.SqlClient.SqlDataAdapter
    Public WithEvents DsFrmJournal1 As UcAccount.DSFrmJournal
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaJournalHead As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaJournalDtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents TxtRef As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaReadyDescription As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents TxtGL_journal_reference As System.Windows.Forms.TextBox
    Friend WithEvents CmbGL_journal_type_code As System.Windows.Forms.ComboBox
    Friend WithEvents txtGL_journal_date As CalendarCombo.CalendarCombo
    Friend WithEvents SumCredit As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SumDebit As System.Windows.Forms.Label
    Friend WithEvents Tp1 As System.Windows.Forms.ToolTip
    Friend WithEvents Defer As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmJournal))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label33 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label36 = New System.Windows.Forms.Label
        Me.BtnFirst = New System.Windows.Forms.Button
        Me.Label37 = New System.Windows.Forms.Label
        Me.BtnLast = New System.Windows.Forms.Button
        Me.Label32 = New System.Windows.Forms.Label
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.BtnNext = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaTypeJournal = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmJournal1 = New UcAccount.DSFrmJournal
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaJournalHead = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaJournalDtl = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtGL_journal_reference = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmbGL_journal_type_code = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtGL_journal_date = New CalendarCombo.CalendarCombo
        Me.TxtRef = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DaReadyDescription = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.SumDebit = New System.Windows.Forms.Label
        Me.SumCredit = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Defer = New System.Windows.Forms.Label
        Me.Tp1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmJournal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJI;packet size=4096;user id=sa;initial catalog=TireMate_01;per" & _
        "sist security info=True;password=5332"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Controls.Add(Me.BtnCancel)
        Me.Panel4.Controls.Add(Me.Label36)
        Me.Panel4.Controls.Add(Me.BtnFirst)
        Me.Panel4.Controls.Add(Me.Label37)
        Me.Panel4.Controls.Add(Me.BtnLast)
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Controls.Add(Me.BtnEdit)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.BtnDelete)
        Me.Panel4.Controls.Add(Me.BtnNew)
        Me.Panel4.Controls.Add(Me.BtnFind)
        Me.Panel4.Controls.Add(Me.BtnNext)
        Me.Panel4.Controls.Add(Me.BtnPrev)
        Me.Panel4.Controls.Add(Me.BtnSave)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(670, 45)
        Me.Panel4.TabIndex = 7
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(376, 31)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 10)
        Me.Label33.TabIndex = 194
        Me.Label33.Text = "Cancel"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(376, 0)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 193
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Location = New System.Drawing.Point(4, 31)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(33, 10)
        Me.Label36.TabIndex = 192
        Me.Label36.Text = "First"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.SystemColors.Window
        Me.BtnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFirst.Image = CType(resources.GetObject("BtnFirst.Image"), System.Drawing.Image)
        Me.BtnFirst.Location = New System.Drawing.Point(8, 1)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(33, 27)
        Me.BtnFirst.TabIndex = 191
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Location = New System.Drawing.Point(128, 31)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(33, 10)
        Me.Label37.TabIndex = 189
        Me.Label37.Text = "Last"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLast
        '
        Me.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLast.Image = CType(resources.GetObject("BtnLast.Image"), System.Drawing.Image)
        Me.BtnLast.Location = New System.Drawing.Point(128, 1)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 27)
        Me.BtnLast.TabIndex = 188
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Location = New System.Drawing.Point(256, 31)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(33, 10)
        Me.Label32.TabIndex = 184
        Me.Label32.Text = "Edit"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(256, 1)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(336, 31)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 10)
        Me.Label25.TabIndex = 176
        Me.Label25.Text = "Save"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(296, 31)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 10)
        Me.Label24.TabIndex = 175
        Me.Label24.Text = "Delete"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(216, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 10)
        Me.Label15.TabIndex = 174
        Me.Label15.Text = "New"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(176, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 10)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Find"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(48, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 10)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Prev"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(88, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 10)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Next"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(296, 1)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(216, 1)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(176, 1)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(88, 1)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 27)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(48, 1)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(336, 1)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'imageList1
        '
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_type_journal.GL_journal_type_code, GL_type_journal.GL_journal_type_desc" & _
        ", GL_ready_description.GL_ready_desc FROM GL_type_journal LEFT OUTER JOIN GL_rea" & _
        "dy_description ON GL_type_journal.GL_journal_type_code = GL_ready_description.GL" & _
        "_journal_type_code"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DaTypeJournal
        '
        Me.DaTypeJournal.SelectCommand = Me.SqlSelectCommand1
        Me.DaTypeJournal.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_type_journal", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GL_journal_type_code", "GL_journal_type_code"), New System.Data.Common.DataColumnMapping("GL_journal_type_desc", "GL_journal_type_desc")})})
        '
        'DsFrmJournal1
        '
        Me.DsFrmJournal1.DataSetName = "DSFrmJournal"
        Me.DsFrmJournal1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_GL_journal, GL_journal_date, GL_journal_reference, GL_journal_type_code" & _
        ", GL_picture FROM GL_journal_head WHERE (id_GL_journal = @id_GL_journal)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
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
        'DaJournalHead
        '
        Me.DaJournalHead.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaJournalHead.InsertCommand = Me.SqlInsertCommand1
        Me.DaJournalHead.SelectCommand = Me.SqlSelectCommand2
        Me.DaJournalHead.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_journal_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("GL_journal_date", "GL_journal_date"), New System.Data.Common.DataColumnMapping("GL_journal_reference", "GL_journal_reference"), New System.Data.Common.DataColumnMapping("GL_journal_type_code", "GL_journal_type_code"), New System.Data.Common.DataColumnMapping("GL_picture", "GL_picture")})})
        Me.DaJournalHead.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT GL_journal_dtl.id_GL_journal, GL_journal_dtl.radif, GL_journal_dtl.GL_acco" & _
        "unt, GL_journal_dtl.GL_journal_reference, GL_journal_dtl.GL_journal_amount_debit" & _
        ", GL_journal_dtl.GL_journal_amount_credit, GL_account.desc_GL_account FROM GL_jo" & _
        "urnal_dtl INNER JOIN GL_account ON GL_journal_dtl.GL_account = GL_account.GL_acc" & _
        "ount WHERE (GL_journal_dtl.id_GL_journal = @id_GL_journal)"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
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
        'DaJournalDtl
        '
        Me.DaJournalDtl.DeleteCommand = Me.SqlDeleteCommand2
        Me.DaJournalDtl.InsertCommand = Me.SqlInsertCommand2
        Me.DaJournalDtl.SelectCommand = Me.SqlSelectCommand3
        Me.DaJournalDtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_journal_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("GL_journal_reference", "GL_journal_reference"), New System.Data.Common.DataColumnMapping("GL_journal_amount_debit", "GL_journal_amount_debit"), New System.Data.Common.DataColumnMapping("GL_journal_amount_credit", "GL_journal_amount_credit")})})
        Me.DaJournalDtl.UpdateCommand = Me.SqlUpdateCommand2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtGL_journal_reference)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CmbGL_journal_type_code)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtGL_journal_date)
        Me.Panel1.Controls.Add(Me.TxtRef)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(6, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(658, 70)
        Me.Panel1.TabIndex = 8
        '
        'TxtGL_journal_reference
        '
        Me.TxtGL_journal_reference.Location = New System.Drawing.Point(384, 40)
        Me.TxtGL_journal_reference.MaxLength = 80
        Me.TxtGL_journal_reference.Name = "TxtGL_journal_reference"
        Me.TxtGL_journal_reference.Size = New System.Drawing.Size(248, 20)
        Me.TxtGL_journal_reference.TabIndex = 20
        Me.TxtGL_journal_reference.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(296, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Refrence"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CmbGL_journal_type_code
        '
        Me.CmbGL_journal_type_code.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DsFrmJournal1, "GL_type_journal.GL_ready_desc"))
        Me.CmbGL_journal_type_code.DataSource = Me.DsFrmJournal1.GL_type_journal
        Me.CmbGL_journal_type_code.DisplayMember = "GL_journal_type_desc"
        Me.CmbGL_journal_type_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGL_journal_type_code.Location = New System.Drawing.Point(128, 40)
        Me.CmbGL_journal_type_code.Name = "CmbGL_journal_type_code"
        Me.CmbGL_journal_type_code.Size = New System.Drawing.Size(152, 21)
        Me.CmbGL_journal_type_code.TabIndex = 18
        Me.CmbGL_journal_type_code.ValueMember = "GL_journal_type_code"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Journal Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(291, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 23)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Journal Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtGL_journal_date
        '
        Me.txtGL_journal_date.BackColor = System.Drawing.SystemColors.Info
        Me.txtGL_journal_date.BorderColor = System.Drawing.Color.Empty
        Me.txtGL_journal_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGL_journal_date.ButtonBackColor = System.Drawing.Color.Empty
        Me.txtGL_journal_date.ButtonForeColor = System.Drawing.Color.Empty
        Me.txtGL_journal_date.EditableSal = True
        Me.txtGL_journal_date.Image = CType(resources.GetObject("txtGL_journal_date.Image"), System.Drawing.Image)
        Me.txtGL_journal_date.Location = New System.Drawing.Point(379, 8)
        Me.txtGL_journal_date.MaxValue = CType(2500, Short)
        Me.txtGL_journal_date.MinValue = CType(1800, Short)
        Me.txtGL_journal_date.Name = "txtGL_journal_date"
        Me.txtGL_journal_date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGL_journal_date.Sal_Mali = Nothing
        Me.txtGL_journal_date.ShowButton = True
        Me.txtGL_journal_date.Size = New System.Drawing.Size(120, 23)
        Me.txtGL_journal_date.TabIndex = 15
        Me.txtGL_journal_date.VisualStyle = False
        '
        'TxtRef
        '
        Me.TxtRef.BackColor = System.Drawing.SystemColors.Info
        Me.TxtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRef.Location = New System.Drawing.Point(130, 8)
        Me.TxtRef.MaxLength = 20
        Me.TxtRef.Name = "TxtRef"
        Me.TxtRef.ReadOnly = True
        Me.TxtRef.Size = New System.Drawing.Size(102, 20)
        Me.TxtRef.TabIndex = 14
        Me.TxtRef.Text = "0"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(14, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Ref No (Journal No)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT id_GL_ready_desc, GL_ready_desc, GL_journal_type_code FROM GL_ready_descri" & _
        "ption"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DaReadyDescription
        '
        Me.DaReadyDescription.SelectCommand = Me.SqlSelectCommand4
        Me.DaReadyDescription.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_ready_description", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_GL_ready_desc", "id_GL_ready_desc"), New System.Data.Common.DataColumnMapping("GL_ready_desc", "GL_ready_desc"), New System.Data.Common.DataColumnMapping("GL_journal_type_code", "GL_journal_type_code")})})
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GrdDetail)
        Me.Panel2.Location = New System.Drawing.Point(4, 135)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(668, 208)
        Me.Panel2.TabIndex = 9
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "GL_journal_dtl"
        Me.GrdDetail.DataSource = Me.DsFrmJournal1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>bank_check_dtl</Caption><Columns Collection" & _
        "=""true""><Column0 ID=""SelectGl""><ButtonDisplayMode>Always</ButtonDisplayMode><All" & _
        "owSort>False</AllowSort><Bound>False</Bound><ButtonStyle>ButtonCell</ButtonStyle" & _
        "><EditType>NoEdit</EditType><Key>SelectGl</Key><Position>0</Position><Selectable" & _
        ">False</Selectable><Width>24</Width></Column0><Column1 ID=""GL_Account""><Caption>" & _
        "GL Account No.</Caption><DataMember>GL_account</DataMember><Key>GL_Account</Key>" & _
        "<Position>1</Position><Width>90</Width></Column1><Column2 ID=""desc_GL_account""><" & _
        "Caption>Accunt Name</Caption><DataMember>desc_GL_account</DataMember><Key>desc_G" & _
        "L_account</Key><Position>2</Position><Selectable>False</Selectable><Width>164</W" & _
        "idth></Column2><Column3 ID=""GL_journal_reference""><Caption>Refrence</Caption><Da" & _
        "taMember>GL_journal_reference</DataMember><Key>GL_journal_reference</Key><Positi" & _
        "on>3</Position><Width>124</Width></Column3><Column4 ID=""GL_journal_amount_debit""" & _
        "><Caption>Debit</Caption><DataMember>GL_journal_amount_debit</DataMember><Format" & _
        "String>c2</FormatString><Key>GL_journal_amount_debit</Key><Position>4</Position>" & _
        "<Width>114</Width></Column4><Column5 ID=""GL_journal_amount_credit""><Caption>Cred" & _
        "it</Caption><DataMember>GL_journal_amount_credit</DataMember><FormatString>c2</F" & _
        "ormatString><Key>GL_journal_amount_credit</Key><Position>5</Position><Width>108<" & _
        "/Width></Column5></Columns><GroupCondition ID="""" /><Key>bank_check_dtl</Key></Ro" & _
        "otTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.ExternalImageList = Me.imageList1
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 8)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(668, 200)
        Me.GrdDetail.TabIndex = 11
        Me.GrdDetail.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        '
        'SumDebit
        '
        Me.SumDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SumDebit.Location = New System.Drawing.Point(432, 344)
        Me.SumDebit.Name = "SumDebit"
        Me.SumDebit.Size = New System.Drawing.Size(112, 23)
        Me.SumDebit.TabIndex = 10
        Me.SumDebit.Text = "0"
        '
        'SumCredit
        '
        Me.SumCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SumCredit.Location = New System.Drawing.Point(546, 344)
        Me.SumCredit.Name = "SumCredit"
        Me.SumCredit.Size = New System.Drawing.Size(110, 23)
        Me.SumCredit.TabIndex = 11
        Me.SumCredit.Text = "0"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(384, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 23)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Sum "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(320, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 23)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Sum (debit - Credit)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Defer
        '
        Me.Defer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Defer.Location = New System.Drawing.Point(432, 370)
        Me.Defer.Name = "Defer"
        Me.Defer.Size = New System.Drawing.Size(112, 23)
        Me.Defer.TabIndex = 20
        '
        'FrmJournal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(670, 403)
        Me.Controls.Add(Me.Defer)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SumCredit)
        Me.Controls.Add(Me.SumDebit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmJournal"
        Me.Text = "Journal"
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmJournal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ClsJournal1 As ClsJournal
    Public WithEvents ClsGlAccount1 As ClsGlAccount
    Dim RowNoToAdd As Integer = 15
    Dim BeforeCel As Integer = -1
    Dim BeforeRow As Integer = -1
    Dim BeforeRowEx As Janus.Windows.GridEX.GridEXRow = Nothing
    Dim WithEvents MyFrm1 As UCGl_Account.FrmSearchGlAccount
    Dim id_journal As Decimal = 0
    Public LoadThis As Decimal = 0
    Dim WithEvents MyFrmSearch As FrmSearchJournal
    Public Event AfterSave(ByVal ThisIdJournal As Int64)
    Public ExitAfterSaveOrCancel As Boolean = False
    Public LoadFromCloseDay As Boolean = False
    Public Event LoadFromCloseDayToThisFrm(ByRef ThisFrm As FrmJournal)
    Private Sub FrmJournal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call first()
        Call EnableDisableField(False)
        If LoadThis = 0 Then
            Call PFirstRecord(False)
        Else
            Call LoadIt(LoadThis)
        End If
        If LoadFromCloseDay Then
            RaiseEvent LoadFromCloseDayToThisFrm(Me)
        End If

    End Sub

    Private Sub LoadIt(ByVal ThisRefNo As String)
        'DsFrmReceiveReturnProduct1.Clear()
        Call ClearAllField()
        If ThisRefNo <> "" Then
            DaJournalHead.SelectCommand.Parameters("@id_GL_journal").Value = ThisRefNo
            DaJournalHead.Fill(DsFrmJournal1.GL_journal_head)
            Try
                DaJournalDtl.SelectCommand.Parameters("@id_GL_journal").Value = ThisRefNo
                DaJournalDtl.Fill(DsFrmJournal1.GL_journal_dtl)
            Catch ex As Exception
            End Try
            Call FillDataInScreen()
            Call CalcSum1()
        End If
    End Sub
    Private Sub FillDataInScreen()
        With DsFrmJournal1.GL_journal_head
            Try
                If .Rows.Count > 0 Then
                    TxtRef.Text = .Rows(0).Item("id_GL_journal") & ""
                    txtGL_journal_date.Text = .Rows(0).Item("GL_journal_date") & ""
                    TxtGL_journal_reference.Text = .Rows(0).Item("GL_journal_reference") & ""
                    Try
                        CmbGL_journal_type_code.SelectedValue = .Rows(0).Item("GL_journal_type_code")
                    Catch ex As Exception
                    End Try
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End With
    End Sub
#Region "GrdDetail"
    Public Sub AddEmptyRecordInDetail()
        Dim IFirstCount As Integer = DsFrmJournal1.GL_journal_dtl.Rows.Count()
        Dim AddEmptyRecordToDetailCount As Integer
        For AddEmptyRecordToDetailCount = 1 + IFirstCount To RowNoToAdd + IFirstCount
            Call AddEmptyRecordToDetail(TxtRef.Text, AddEmptyRecordToDetailCount)
        Next
    End Sub
    Private Sub GrdDetail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.GotFocus
        SelectRow(GrdDetail.Row, 0)
    End Sub
    Sub SelectRow(ByVal ThisRow As Integer, Optional ByVal ThisItemCodeFocus As Integer = 1)
        GrdDetail.Row = ThisRow
        GrdDetail.Col = ThisItemCodeFocus
        GrdDetail.SelectCurrentCellText()
    End Sub
    Private Sub GrdDetail_CellEdited(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.CellEdited
        Dim CurrentRow As Janus.Windows.GridEX.GridEXRow = GrdDetail.GetRow()
        Select Case GrdDetail.Col
            Case 4
                If Val(CurrentRow.Cells(4).Value & "") <> 0 Then
                    If ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Then
                        CurrentRow.Cells(5).Value = 0
                    End If
                    GrdDetail.Row = GrdDetail.Row + 1
                    GrdDetail.Col = 0
                End If
            Case 5
                If Val(CurrentRow.Cells(5).Value & "") <> 0 Then
                    If ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Then
                        CurrentRow.Cells(4).Value = 0
                    End If
                    GrdDetail.Row = GrdDetail.Row + 1
                    GrdDetail.Col = 0
                End If
        End Select
        Call CalcSum1()
    End Sub
    Private Sub GrdDetail_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GrdDetail.UpdatingCell
        Call CalcSum1()
    End Sub
    Private Sub GrdDetail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdDetail.KeyDown
        If ThisFormStatus <> MainModule.WorkStates._ReadOnly Then

            Dim CurrentRow As Janus.Windows.GridEX.GridEXRow = GrdDetail.GetRow()
            Dim CurrentRowGrid As Long = 2
            Dim flg2 As Boolean = False

            Dim row As Integer = GrdDetail.Row
            Dim col As Integer = GrdDetail.Col
            '-------------------------------------------------------------
            Select Case e.Control
                Case True
                Case False
                    If e.Shift = False And e.Control = False And e.Alt = False Then
                        Select Case e.KeyCode
                            Case Windows.Forms.Keys.F2
                                Select Case GrdDetail.Col
                                    Case 1 ' ItemCode
                                        Call ShowSearch()
                                        Call SelectRow(row, 0)
                                        System.Windows.Forms.SendKeys.Send(vbTab)
                                End Select
                            Case Windows.Forms.Keys.Enter


                        End Select
                    End If
            End Select
        End If
    End Sub
    Private Sub GrdDetail_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.CurrentCellChanged
        Dim ValueString As String = ""
        Dim CurrentRowGrid As Long = GrdDetail.Row
        Call CalcSum1()
        If BeforeRowEx Is Nothing Or BeforeCel = -1 Or BeforeRow = -1 Then
            Exit Sub
        End If
        Try
            ValueString = BeforeRowEx.Cells(BeforeCel).Value & ""
            Select Case BeforeCel
                Case 1
                    If ValueString.Trim & "" <> "" Then
                        If ClsGlAccount1.FindDesc(ValueString) = False Then
                            MsgFar("Cod is invalid")
                            Call SelectRow(CurrentRowGrid, 1)
                        Else

                        End If
                    End If
                Case 4
                Case 6, 7 'QTY  ,  Price
                Case 8, 9
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GrdDetail_CurrentCellChanging(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.CurrentCellChangingEventArgs) Handles GrdDetail.CurrentCellChanging
        Call EnableDisableSave()
        Call InitBeforeRow()
    End Sub
    Private Sub GrdDetail_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.ColumnButtonClick
        Call ShowSearch()
    End Sub
    Sub ShowSearch()
        MyFrm1 = New UCGl_Account.FrmSearchGlAccount
        MyFrm1.ShowDialog()
    End Sub
    Sub InitBeforeRow()
        BeforeCel = GrdDetail.Col
        BeforeRow = GrdDetail.Row
        BeforeRowEx = GrdDetail.GetRow
    End Sub
    Sub CalcSum1()
        Dim dr As DataRow()
        SumDebit.Text = CDec("0" & DsFrmJournal1.GL_journal_dtl.Compute("Sum(GL_journal_amount_debit)", "GL_journal_amount_debit > 0 and  GL_account <> ''"))
        SumDebit.Text = Format(CDec(SumDebit.Text), "###,###,###,###,###.##")
        SumCredit.Text = CDec("0" & DsFrmJournal1.GL_journal_dtl.Compute("Sum(GL_journal_amount_Credit)", "GL_journal_amount_Credit > 0 and  GL_account <> ''"))
        SumCredit.Text = Format(CDec(SumCredit.Text), "###,###,###,###,###.##")
        Tp1.SetToolTip(SumDebit, NumToString_Dollar(SumDebit.Text))
        Tp1.SetToolTip(SumCredit, NumToString_Dollar(SumCredit.Text))
        Defer.Text = Format(CDec("0" & SumDebit.Text) - CDec("0" & SumCredit.Text), "###,###,###,###.##")
        Call EnableDisableSave()
    End Sub
#End Region
#Region "Clear Fields"
    Private Sub ClearAllField()
        txtGL_journal_date.Text = ""
        TxtGL_journal_reference.Text = ""
        Try
            'CmbGL_journal_type_code.SelectedValue = 0
        Catch ex As Exception
        End Try
        DsFrmJournal1.Clear()
        DaTypeJournal.Fill(DsFrmJournal1.GL_type_journal)
        TxtRef.Clear()
    End Sub
#End Region
#Region "EnableDisable"
    Private Sub EnableDisableSave()
        Dim RowDetails As DataRow() = DsFrmJournal1.GL_journal_dtl.Select("trim(gl_account) <> ''")
        If Not CmbGL_journal_type_code.SelectedValue Is Nothing And BtnNew.Enabled = False And RowDetails.Length > 0 And txtGL_journal_date.Text <> "" And Val(Defer.Text) = 0 Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub

    Private Sub EnableDisableField(ByVal InStatus As Boolean)
        txtGL_journal_date.Enabled = InStatus
        TxtGL_journal_reference.Enabled = InStatus
        GrdDetail.Enabled = InStatus
        TxtRef.Enabled = InStatus
        CmbGL_journal_type_code.Enabled = InStatus
    End Sub
    Private Sub EnableDisableBtn()
        Select Case ThisFormStatus
            Case MainModule.WorkStates.AddNew, MainModule.WorkStates.Edit
                BtnFirst.Enabled = False
                BtnPrev.Enabled = False
                BtnNext.Enabled = False
                BtnLast.Enabled = False
                BtnEdit.Enabled = False
                BtnDelete.Enabled = False
                BtnFind.Enabled = False
                BtnNew.Enabled = False
                BtnCancel.Enabled = True
                BtnSave.Enabled = False
            Case MainModule.WorkStates._ReadOnly
                If TxtRef.Text.Trim.Length > 0 Then
                    BtnFirst.Enabled = True
                    BtnPrev.Enabled = True
                    BtnNext.Enabled = True
                    BtnLast.Enabled = True
                    BtnEdit.Enabled = True
                    BtnDelete.Enabled = True
                    BtnFind.Enabled = True
                Else
                    BtnFirst.Enabled = False
                    BtnPrev.Enabled = False
                    BtnNext.Enabled = False
                    BtnLast.Enabled = False
                    BtnEdit.Enabled = False
                    BtnDelete.Enabled = False
                    BtnFind.Enabled = False
                End If
                BtnNew.Enabled = True
                BtnCancel.Enabled = False
                BtnSave.Enabled = False
        End Select
    End Sub
#End Region
#Region "Buttomns Toolbar click"
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Call Psave()
    End Sub
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Call Paddnew()
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Call PEdit()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call PCancel()
    End Sub
    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        Call PFirstRecord()
    End Sub
    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        Call PPreviousRecord()
    End Sub
    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        Call PNextRecord()
    End Sub
    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        Call PLastRecord()
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Call PDelete()
    End Sub

#End Region
#Region "AdNewEditSave"
    Public Sub Paddnew()
        ThisFormStatus = MainModule.WorkStates.AddNew
        Call EnableDisableField(True)
        Call EnableDisableBtn()
        Call ClearAllField()
        TxtRef.Text = ClsJournal1.MakeNewRefCod()
        txtGL_journal_date.Text = Format(Now.Date, PubDateFormat)
        Call AddEmptyRecordInDetail()

        txtGL_journal_date.Focus()
    End Sub
    Sub Psave()
        Dim Dr As DataRow
        Dim flg As Boolean = False
        Try
            If DsFrmJournal1.GL_journal_head.Rows.Count <= 0 Then
                Dr = DsFrmJournal1.GL_journal_head.NewRow()
                Dr("id_GL_journal") = TxtRef.Text.Trim
                flg = True
            Else
                Dr = DsFrmJournal1.GL_journal_head.Rows(0)
            End If
            Dr("GL_journal_date") = txtGL_journal_date.Text
            Dr("GL_journal_reference") = TxtGL_journal_reference.Text
            Dr("GL_journal_type_code") = CmbGL_journal_type_code.SelectedValue

            If flg Then
                DsFrmJournal1.GL_journal_head.AddGL_journal_headRow(Dr)
            End If
            '            #region "delete empty row"
            Dim i As Long
            Dim dr1 As DataRow()
            dr1 = DsFrmJournal1.GL_journal_dtl.Select("trim( gl_account) =''")
            For i = 0 To dr1.Length - 1
                dr1(i).Delete()
            Next
            Try
                DaJournalHead.Update(DsFrmJournal1.GL_journal_head)
                'MsgBox(DsFrmCheckScreen1.bank_check.Rows(0).Item("id_check"))
                id_journal = DsFrmJournal1.GL_journal_head.Rows(0).Item("id_GL_journal")
                DaJournalDtl.Update(DsFrmJournal1.GL_journal_dtl)
                RaiseEvent AfterSave(id_journal)
                '                If RbBill.Checked = True Then
            Catch ex As Exception
                MsgFar("Error In Update ")
                MsgBox(ex.ToString)
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        Call EnableDisableField(False)
        Call EnableDisableBtn()
        If ExitAfterSaveOrCancel Then
            Me.Close()
        End If
    End Sub
    Sub PCancel()
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        Call EnableDisableField(False)
        Call EnableDisableBtn()
        TxtRef.Text = ClsJournal1.LastRecord()
        Call LoadIt(TxtRef.Text)
        If ExitAfterSaveOrCancel Then
            Me.Close()
        End If

    End Sub
    Sub PEdit()
        ' Get A Copy Of Dataset
        Dim AddEmptyRecordToDetailCount As Integer
        Dim IFirstCount As Integer   'Dsfrm..Rows.Count()
        If TxtRef.Text.Trim.Length > 0 Then
            ThisFormStatus = MainModule.WorkStates.Edit
            Call EnableDisableField(True)
            Call EnableDisableBtn()
            IFirstCount = DsFrmJournal1.GL_journal_dtl.Rows.Count()
            For AddEmptyRecordToDetailCount = 1 + IFirstCount To RowNoToAdd + IFirstCount
                Call AddEmptyRecordToDetail(TxtRef.Text, AddEmptyRecordToDetailCount)
            Next
        End If
        txtGL_journal_date.Focus()
    End Sub
    Sub PDelete()
        Dim c1 As New CommonClass.FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Ok"
        c1.Text = " Delete Warning "
        c1.ShowFarMsg("This Operation Will Delete Journal ")
        '----------------------------------------
        If c1.DialogResult = DialogResult.OK Then
            Try
                CmdGeneral.CommandText = " Delete  from  GL_journal_head Where id_GL_journal= " & Qt(TxtRef.Text)
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
                MsgFar("Error in delete please check delete cascade integrity mr armandeh! ")
            End Try
            PLastRecord(False)
        End If
    End Sub
#End Region
#Region "Previos-Last-Frist"
    Private Sub PFirstRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            ' If TxtRef.Text.Trim.Length > 0 Then
            Dim TXTRef_NoTmp As String = ClsJournal1.PFirstRecord()
            If TXTRef_NoTmp = TxtRef.Text Then
                If ShowMsgFlag Then MsgFar("First Record")
            Else
                Call LoadIt(TXTRef_NoTmp)
            End If
            ' Else
            ' MsgFar("There is no Row in Database")
            ' End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PLastRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String = ClsJournal1.LastRecord()
                If TXTRef_NoTmp = TxtRef.Text Then
                    If ShowMsgFlag Then MsgFar("Last Record")
                Else
                    Call LoadIt(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String = ClsJournal1.Pprevious(TxtRef.Text.Trim)
                If TXTRef_NoTmp.Trim = TxtRef.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
                    If ShowMsgFlag Then MsgFar("First Record")
                Else
                    Call LoadIt(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PNextRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String = ClsJournal1.PNext(TxtRef.Text)
                If TXTRef_NoTmp.Trim = TxtRef.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
                    If ShowMsgFlag Then MsgFar("Last Record")
                Else
                    Call LoadIt(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region
#Region "All Text Changed"
    Private Sub AllTxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtGL_journal_reference.TextChanged, txtGL_journal_date.TextChanged, TxtRef.TextChanged
        EnableDisableSave()
    End Sub
    Private Sub CmbGL_journal_type_code_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbGL_journal_type_code.SelectedIndexChanged
        EnableDisableSave()
    End Sub

    Private Sub CmbGL_journal_type_code_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbGL_journal_type_code.SelectedValueChanged
        EnableDisableSave()
        If TxtRef.Text.Trim & "" <> "" Then
            'TxtRef.Text = CmbGL_journal_type_code.Tag & ""
        End If
    End Sub
#End Region
    Private Sub AddEmptyRecordToDetail(ByVal ThisId As Decimal, ByVal ThisRadif As Integer)
        Dim dr As DataRow
        dr = DsFrmJournal1.GL_journal_dtl.NewRow
        dr("id_GL_journal") = ThisId
        dr("radif") = ThisRadif
        dr("gl_account") = ""
        dr("GL_journal_reference") = ""
        dr("GL_journal_amount_debit") = 0
        dr("GL_journal_amount_Credit") = 0
        DsFrmJournal1.GL_journal_dtl.Rows.Add(dr)
    End Sub
    Private Sub MyFrm1_GlAccountFind(ByVal ThisRow As System.Data.DataRow) Handles MyFrm1.GlAccountFind
        GrdDetail.GetRow.Cells(1).Value = ThisRow("Gl_Account")
        GrdDetail.GetRow.Cells(2).Value = ThisRow("Desc_Gl_Account")
        EnableDisableSave()
    End Sub
    Private Sub ClsGlAccount1_FindGlAccuntRow(ByVal ThisRow As System.Data.DataRow) Handles ClsGlAccount1.FindGlAccuntRow
        If Trim(GrdDetail.GetRow.Cells(1).Value) & "" <> "" Then
            GrdDetail.GetRow.Cells(2).Value = ThisRow("Desc_Gl_Account")
        End If
        EnableDisableSave()
    End Sub
    Private Sub ClsGlAccount1_NotFindGlaAccount() Handles ClsGlAccount1.NotFindGlaAccount
        GrdDetail.GetRow.Cells(2).Value = ""
        GrdDetail.GetRow.Cells(1).Value = ""
        EnableDisableSave()
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        MyFrmSearch = New FrmSearchJournal
        MyFrmSearch.ShowDialog()
    End Sub
    Private Sub MyFrmSearch_FindThisJournalNo(ByVal ThisId As Decimal) Handles MyFrmSearch.FindThisJournalNo
        Call LoadIt(ThisId)
    End Sub
    Public Sub first()
        Cnn.ConnectionString = PConnectionString
        CmdGeneral.Connection = Cnn
        ClsJournal1 = New ClsJournal
        ClsGlAccount1 = New ClsGlAccount
        ClsJournal1.Connection = Cnn
        ClsGlAccount1.Connection = Cnn
        ThisFormStatus = MainModule.WorkStates.Cancel
        DaTypeJournal.Fill(DsFrmJournal1.GL_type_journal)
    End Sub
End Class
