Imports CommonClass
Imports UcEnter
Imports CommonClass.MainModule
Imports System.ComponentModel
Imports System.IO
Imports System.Drawing.Imaging
Public Class FrmGeneral
    Inherits FrmBase
    Public MyObjTabIndex As Integer
    Private mCnnString As String
    Private cm As CurrencyManager
    Private mFrmName As String
    Private cmdGeneral As New SqlClient.SqlCommand
    Private DV, DvData As Data.DataView
    Private DaData As New SqlClient.SqlDataAdapter
    Private DsData As New Data.DataSet
    Public intPos As Integer

    Private mAllowInsert As Boolean = True
    Private mAllowEdit As Boolean = True
    Private mAllowDelete As Boolean = True
    Private mSortString As String
    Private mFilterDataRow As String

    Private bAutoNumber As Boolean = False
    Private mStatus As WorkStates
    Private obj As New Collections.Hashtable
    Private objValue As New Collections.Hashtable
    Private objlabel As Label
    Private mLanguage As Language
    Private _left As Integer = 10
    Private _top As Integer = 100
    Private lblWidth As Integer = 150
    Private x, i, pos, FHeight, flgCmPosition As Integer

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal ThisFormName As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.FrmName = ThisFormName
        Me.Language = planguage
        Cnn.ConnectionString = PConnectionString
        AccessCnn.ConnectionString = PConnectionStringForGenerator
        FillAccessData()
        SetOptionForm(Me.Language)

        If Me.Language = Language.Persian Then
            Me.RightToLeft = RightToLeft.Yes
        Else
            Me.RightToLeft = RightToLeft.No
        End If
        setTextObject(Me.Language)
        FillData()
        CreateObjectOnForm()
        If DV(0).Item("FlgNew") Then
            BtnNew.Enabled = False
        End If
        If DV(0).Item("FlgDel") Then
            BtnDelete.Enabled = False
        End If

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnFirst As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnEdit As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnDelete As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnNew As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents LblFirst As System.Windows.Forms.Label
    Friend WithEvents LblLast As System.Windows.Forms.Label
    Friend WithEvents BtnLast As Janus.Windows.EditControls.UIButton
    Friend WithEvents LblCancel As System.Windows.Forms.Label
    Friend WithEvents LblEdit As System.Windows.Forms.Label
    Friend WithEvents LblSave As System.Windows.Forms.Label
    Friend WithEvents LblDelete As System.Windows.Forms.Label
    Friend WithEvents LblNew As System.Windows.Forms.Label
    Friend WithEvents LblPrev As System.Windows.Forms.Label
    Friend WithEvents LblNext As System.Windows.Forms.Label
    Friend WithEvents BtnNext As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnPrev As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnGrid As Janus.Windows.EditControls.UIButton
    Friend WithEvents LblGrid As System.Windows.Forms.Label
    Friend WithEvents AccessCnn As System.Data.OleDb.OleDbConnection
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents AccessDa As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DsAccess1 As FormGenerator.DsAccess
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmGeneral))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.AccessCnn = New System.Data.OleDb.OleDbConnection
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LblGrid = New System.Windows.Forms.Label
        Me.BtnGrid = New Janus.Windows.EditControls.UIButton
        Me.LblFirst = New System.Windows.Forms.Label
        Me.LblLast = New System.Windows.Forms.Label
        Me.BtnLast = New Janus.Windows.EditControls.UIButton
        Me.LblCancel = New System.Windows.Forms.Label
        Me.LblEdit = New System.Windows.Forms.Label
        Me.LblSave = New System.Windows.Forms.Label
        Me.LblDelete = New System.Windows.Forms.Label
        Me.LblNew = New System.Windows.Forms.Label
        Me.LblPrev = New System.Windows.Forms.Label
        Me.LblNext = New System.Windows.Forms.Label
        Me.BtnNext = New Janus.Windows.EditControls.UIButton
        Me.BtnPrev = New Janus.Windows.EditControls.UIButton
        Me.BtnFirst = New Janus.Windows.EditControls.UIButton
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.BtnEdit = New Janus.Windows.EditControls.UIButton
        Me.BtnDelete = New Janus.Windows.EditControls.UIButton
        Me.BtnNew = New Janus.Windows.EditControls.UIButton
        Me.BtnSave = New Janus.Windows.EditControls.UIButton
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.AccessDa = New System.Data.OleDb.OleDbDataAdapter
        Me.DsAccess1 = New FormGenerator.DsAccess
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.DsAccess1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'AccessCnn
        '
        Me.AccessCnn.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""E:\Project\Amval\Form.md" & _
        "b"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provid" & _
        "er=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Exte" & _
        "nded Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB" & _
        ":Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet O" & _
        "LEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Databa" & _
        "se=False"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblGrid)
        Me.Panel1.Controls.Add(Me.BtnGrid)
        Me.Panel1.Controls.Add(Me.LblFirst)
        Me.Panel1.Controls.Add(Me.LblLast)
        Me.Panel1.Controls.Add(Me.BtnLast)
        Me.Panel1.Controls.Add(Me.LblCancel)
        Me.Panel1.Controls.Add(Me.LblEdit)
        Me.Panel1.Controls.Add(Me.LblSave)
        Me.Panel1.Controls.Add(Me.LblDelete)
        Me.Panel1.Controls.Add(Me.LblNew)
        Me.Panel1.Controls.Add(Me.LblPrev)
        Me.Panel1.Controls.Add(Me.LblNext)
        Me.Panel1.Controls.Add(Me.BtnNext)
        Me.Panel1.Controls.Add(Me.BtnPrev)
        Me.Panel1.Controls.Add(Me.BtnFirst)
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.BtnEdit)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnNew)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 37)
        Me.Panel1.TabIndex = 0
        '
        'LblGrid
        '
        Me.LblGrid.BackColor = System.Drawing.Color.Transparent
        Me.LblGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblGrid.Location = New System.Drawing.Point(259, 23)
        Me.LblGrid.Name = "LblGrid"
        Me.LblGrid.Size = New System.Drawing.Size(31, 11)
        Me.LblGrid.TabIndex = 221
        Me.LblGrid.Text = "Table"
        Me.LblGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnGrid
        '
        Me.BtnGrid.BackColor = System.Drawing.SystemColors.Window
        Me.BtnGrid.ImageIndex = 10
        Me.BtnGrid.ImageList = Me.ImageList1
        Me.BtnGrid.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.Far
        Me.BtnGrid.Location = New System.Drawing.Point(262, 1)
        Me.BtnGrid.Name = "BtnGrid"
        Me.BtnGrid.Size = New System.Drawing.Size(22, 21)
        Me.BtnGrid.TabIndex = 220
        '
        'LblFirst
        '
        Me.LblFirst.BackColor = System.Drawing.Color.Transparent
        Me.LblFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblFirst.Location = New System.Drawing.Point(143, 23)
        Me.LblFirst.Name = "LblFirst"
        Me.LblFirst.Size = New System.Drawing.Size(25, 11)
        Me.LblFirst.TabIndex = 215
        Me.LblFirst.Text = "First"
        Me.LblFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblLast
        '
        Me.LblLast.BackColor = System.Drawing.Color.Transparent
        Me.LblLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblLast.Location = New System.Drawing.Point(232, 23)
        Me.LblLast.Name = "LblLast"
        Me.LblLast.Size = New System.Drawing.Size(25, 11)
        Me.LblLast.TabIndex = 214
        Me.LblLast.Text = "Last"
        Me.LblLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLast
        '
        Me.BtnLast.BackColor = System.Drawing.SystemColors.Window
        Me.BtnLast.ImageIndex = 9
        Me.BtnLast.ImageList = Me.ImageList1
        Me.BtnLast.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.Far
        Me.BtnLast.Location = New System.Drawing.Point(234, 1)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(22, 21)
        Me.BtnLast.TabIndex = 213
        '
        'LblCancel
        '
        Me.LblCancel.BackColor = System.Drawing.Color.Transparent
        Me.LblCancel.Enabled = False
        Me.LblCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblCancel.Location = New System.Drawing.Point(112, 23)
        Me.LblCancel.Name = "LblCancel"
        Me.LblCancel.Size = New System.Drawing.Size(32, 11)
        Me.LblCancel.TabIndex = 212
        Me.LblCancel.Text = "Cancel"
        Me.LblCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEdit
        '
        Me.LblEdit.BackColor = System.Drawing.Color.Transparent
        Me.LblEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblEdit.Location = New System.Drawing.Point(28, 23)
        Me.LblEdit.Name = "LblEdit"
        Me.LblEdit.Size = New System.Drawing.Size(25, 11)
        Me.LblEdit.TabIndex = 211
        Me.LblEdit.Text = "Edit"
        Me.LblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSave
        '
        Me.LblSave.BackColor = System.Drawing.Color.Transparent
        Me.LblSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblSave.Location = New System.Drawing.Point(86, 23)
        Me.LblSave.Name = "LblSave"
        Me.LblSave.Size = New System.Drawing.Size(26, 11)
        Me.LblSave.TabIndex = 210
        Me.LblSave.Text = "Save"
        Me.LblSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDelete
        '
        Me.LblDelete.BackColor = System.Drawing.Color.Transparent
        Me.LblDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblDelete.Location = New System.Drawing.Point(55, 23)
        Me.LblDelete.Name = "LblDelete"
        Me.LblDelete.Size = New System.Drawing.Size(30, 11)
        Me.LblDelete.TabIndex = 209
        Me.LblDelete.Text = "Delete"
        Me.LblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNew
        '
        Me.LblNew.BackColor = System.Drawing.Color.Transparent
        Me.LblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblNew.Location = New System.Drawing.Point(1, 23)
        Me.LblNew.Name = "LblNew"
        Me.LblNew.Size = New System.Drawing.Size(24, 11)
        Me.LblNew.TabIndex = 208
        Me.LblNew.Text = "New"
        Me.LblNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPrev
        '
        Me.LblPrev.BackColor = System.Drawing.Color.Transparent
        Me.LblPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblPrev.Location = New System.Drawing.Point(165, 23)
        Me.LblPrev.Name = "LblPrev"
        Me.LblPrev.Size = New System.Drawing.Size(40, 11)
        Me.LblPrev.TabIndex = 207
        Me.LblPrev.Text = "Previous"
        Me.LblPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNext
        '
        Me.LblNext.BackColor = System.Drawing.Color.Transparent
        Me.LblNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblNext.Location = New System.Drawing.Point(201, 23)
        Me.LblNext.Name = "LblNext"
        Me.LblNext.Size = New System.Drawing.Size(33, 11)
        Me.LblNext.TabIndex = 206
        Me.LblNext.Text = "Next"
        Me.LblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.SystemColors.Window
        Me.BtnNext.ImageIndex = 8
        Me.BtnNext.ImageList = Me.ImageList1
        Me.BtnNext.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.Far
        Me.BtnNext.Location = New System.Drawing.Point(206, 1)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(22, 21)
        Me.BtnNext.TabIndex = 205
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.ImageIndex = 7
        Me.BtnPrev.ImageList = Me.ImageList1
        Me.BtnPrev.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.Far
        Me.BtnPrev.Location = New System.Drawing.Point(174, 1)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(22, 21)
        Me.BtnPrev.TabIndex = 204
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.SystemColors.Window
        Me.BtnFirst.ImageIndex = 6
        Me.BtnFirst.ImageList = Me.ImageList1
        Me.BtnFirst.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.Far
        Me.BtnFirst.Location = New System.Drawing.Point(146, 1)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(22, 21)
        Me.BtnFirst.TabIndex = 202
        '
        'BtnCancel
        '
        Me.BtnCancel.ImageIndex = 4
        Me.BtnCancel.ImageList = Me.ImageList1
        Me.BtnCancel.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.Far
        Me.BtnCancel.Location = New System.Drawing.Point(117, 1)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(22, 21)
        Me.BtnCancel.TabIndex = 201
        '
        'BtnEdit
        '
        Me.BtnEdit.ImageIndex = 1
        Me.BtnEdit.ImageList = Me.ImageList1
        Me.BtnEdit.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.Far
        Me.BtnEdit.Location = New System.Drawing.Point(30, 1)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(22, 21)
        Me.BtnEdit.TabIndex = 198
        '
        'BtnDelete
        '
        Me.BtnDelete.ImageIndex = 2
        Me.BtnDelete.ImageList = Me.ImageList1
        Me.BtnDelete.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.Far
        Me.BtnDelete.Location = New System.Drawing.Point(60, 1)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(22, 21)
        Me.BtnDelete.TabIndex = 199
        '
        'BtnNew
        '
        Me.BtnNew.ImageIndex = 0
        Me.BtnNew.ImageList = Me.ImageList1
        Me.BtnNew.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.Far
        Me.BtnNew.Location = New System.Drawing.Point(2, 1)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(22, 21)
        Me.BtnNew.TabIndex = 197
        '
        'BtnSave
        '
        Me.BtnSave.ImageIndex = 3
        Me.BtnSave.ImageList = Me.ImageList1
        Me.BtnSave.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.Far
        Me.BtnSave.Location = New System.Drawing.Point(88, 1)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(22, 21)
        Me.BtnSave.TabIndex = 200
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=TARH;packet size=4096;user id=sa;initial catalog=maskan_01_84;pers" & _
        "ist security info=False"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT FrmBase.FrmName, FrmBase.FrmHeight, FrmBase.FrmFilter, FrmBase.FrmDesc, Fr" & _
        "mBase.FrmCaption, FrmBase.FrmPicture, FrmBase.FrmTable, FrmBase.FrmWidth, BaseTa" & _
        "ble.CMBCondition, BaseTable.CMBDisplayName, BaseTable.CMBStatic, BaseTable.CMBTa" & _
        "bleName, BaseTable.CMBValueName, BaseTable.DefaultValue, BaseTable.Enable, BaseT" & _
        "able.Fieldcaption, BaseTable.Fieldheight, BaseTable.FieldLocationX, BaseTable.Fi" & _
        "eldLocationY, BaseTable.Fieldname, BaseTable.FieldObjectType, BaseTable.FieldTyp" & _
        "e, BaseTable.Fieldwidth, BaseTable.FillZero, BaseTable.IsMandatory, BaseTable.Is" & _
        "primary, BaseTable.MaxLength, BaseTable.NoDecimal, BaseTable.prime, BaseTable.Ta" & _
        "bIndex, BaseTable.UpdateDisabled, FrmBase.FlgNew, FrmBase.FlgDel FROM (BaseTable" & _
        " INNER JOIN FrmBase ON BaseTable.FrmName = FrmBase.FrmName)"
        Me.OleDbSelectCommand1.Connection = Me.AccessCnn
        '
        'AccessDa
        '
        Me.AccessDa.SelectCommand = Me.OleDbSelectCommand1
        Me.AccessDa.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "BaseTable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AllowDelete", "AllowDelete"), New System.Data.Common.DataColumnMapping("AllowInsert", "AllowInsert"), New System.Data.Common.DataColumnMapping("Allowupdate", "Allowupdate"), New System.Data.Common.DataColumnMapping("Caption", "Caption"), New System.Data.Common.DataColumnMapping("Editable", "Editable"), New System.Data.Common.DataColumnMapping("FDisplayName", "FDisplayName"), New System.Data.Common.DataColumnMapping("Fieldname", "Fieldname"), New System.Data.Common.DataColumnMapping("FillZero", "FillZero"), New System.Data.Common.DataColumnMapping("FilterString", "FilterString"), New System.Data.Common.DataColumnMapping("FTableName", "FTableName"), New System.Data.Common.DataColumnMapping("FValueName", "FValueName"), New System.Data.Common.DataColumnMapping("IsMandatory", "IsMandatory"), New System.Data.Common.DataColumnMapping("Isprimary", "Isprimary"), New System.Data.Common.DataColumnMapping("ItemKey", "ItemKey"), New System.Data.Common.DataColumnMapping("Len", "Len"), New System.Data.Common.DataColumnMapping("prime", "prime"), New System.Data.Common.DataColumnMapping("TabIndex", "TabIndex"), New System.Data.Common.DataColumnMapping("Tablecaption", "Tablecaption"), New System.Data.Common.DataColumnMapping("Tablename", "Tablename"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("WhereClause", "WhereClause")})})
        '
        'DsAccess1
        '
        Me.DsAccess1.DataSetName = "DsAccess"
        Me.DsAccess1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(640, 48)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(104, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(532, 41)
        Me.Label1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(17, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 41)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FrmGeneral
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(640, 406)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Name = "FrmGeneral"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsAccess1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Properties"

    Public Property Language() As Language
        Get
            Return mLanguage
        End Get
        Set(ByVal Value As Language)
            mLanguage = Value
        End Set
    End Property

    <DefaultValue(True)> _
    Public Property AllowInsert() As Boolean
        Get
            Return mAllowInsert
        End Get
        Set(ByVal Value As Boolean)
            mAllowInsert = Value
        End Set
    End Property

    <DefaultValue(True)> _
    Public Property AllowEdit() As Boolean
        Get
            Return mAllowEdit
        End Get
        Set(ByVal Value As Boolean)
            mAllowEdit = Value
        End Set
    End Property

    <DefaultValue(True)> _
        Public Property AllowDelete() As Boolean
        Get
            Return mAllowDelete
        End Get
        Set(ByVal Value As Boolean)
            mAllowDelete = Value
        End Set
    End Property

    <DefaultValue("")> _
        Friend Property SortString() As String
        Get
            Return mSortString
        End Get
        Set(ByVal Value As String)
            mSortString = Value
            If mSortString & "" <> "" Then
                DvData.Sort = mSortString
            End If
        End Set
    End Property

    Public Property FrmName() As String
        Get
            Return mFrmName
        End Get
        Set(ByVal Value As String)
            mFrmName = Value
        End Set
    End Property

#End Region

#Region " Object Relations  "

    Private Sub CreateObjectOnForm()
        Dim tmpHeight As Integer = 0
        FHeight = 0
        i = 0
        For i = 0 To DV.Count - 1
            If i > 0 Then
                If DV(i - 1).Item("Fieldheight") Is DBNull.Value Then
                    tmpHeight = 0
                Else
                    tmpHeight = DV(i - 1).Item("Fieldheight")
                End If
                If tmpHeight < 25 Then
                    FHeight = FHeight + 25
                Else
                    FHeight = FHeight + tmpHeight
                End If
            End If
            objlabel = New Label
            If Me.Language = Language.Persian Then
                _left = Me.Width - lblWidth - 10
                objlabel.RightToLeft = RightToLeft.Yes
            Else
                _left = 10
                objlabel.RightToLeft = RightToLeft.No
            End If
            objlabel.Name = "Label" + Trim(Str(i))
            objlabel.Location = New System.Drawing.Point(_left, _top + FHeight)
            If Me.Language = Language.Persian Then
                CType(objlabel, Label).Anchor = AnchorStyles.Top Or AnchorStyles.Right
            Else
                CType(objlabel, Label).Anchor = AnchorStyles.Top Or AnchorStyles.Left
            End If
            objlabel.Width = lblWidth
            objlabel.Height = 25
            objlabel.Text = DV(i).Item("Fieldcaption")
            Me.Controls.Add(objlabel)
            Select Case DV(i).Item("FieldObjectType")
                Case "TextBox"
                    obj.Add(i, New UcEnter.TextBoxEnter)
                    If Me.Language = Language.Persian Then
                        x = Me.Width - lblWidth - 10 - DV(i).Item("Fieldwidth")
                        CType(obj(i), UcEnter.TextBoxEnter).RightToLeft = RightToLeft.Yes
                        CType(obj(i), UcEnter.TextBoxEnter).Anchor = AnchorStyles.Top Or AnchorStyles.Right
                    Else
                        x = lblWidth + 10
                        CType(obj(i), UcEnter.TextBoxEnter).RightToLeft = RightToLeft.No
                        CType(obj(i), UcEnter.TextBoxEnter).Anchor = AnchorStyles.Top Or AnchorStyles.Left
                    End If
                    CType(obj(i), UcEnter.TextBoxEnter).Location = New System.Drawing.Point(x, _top + FHeight)
                    CType(obj(i), UcEnter.TextBoxEnter).Width = DV(i).Item("Fieldwidth")
                    CType(obj(i), UcEnter.TextBoxEnter).MaxLength = DV(i).Item("MaxLength")
                    CType(obj(i), UcEnter.TextBoxEnter).TabIndex = DV(i).Item("TabIndex")
                    CType(obj(i), UcEnter.TextBoxEnter).Enabled = False
                    If DV(i).Item("IsMandatory") = True Then
                        CType(obj(i), UcEnter.TextBoxEnter).BackColor = SystemColors.Info
                    End If
                    ToolTip1.SetToolTip(CType(obj(i), UcEnter.TextBoxEnter), DV(i).Item("Fieldcaption"))
                    Me.Controls.Add(obj(i))
                    If DV(i).Item("FillZero") = True Then
                        AddHandler CType(obj(i), UcEnter.TextBoxEnter).Leave, AddressOf TextBoxLeaveHandler
                    End If
                    AddHandler CType(obj(i), UcEnter.TextBoxEnter).TextChanged, AddressOf ObjTextChanged
                Case "Date"
                    obj.Add(i, New Calendar.UcCalendar)
                    If Me.Language = Language.Persian Then
                        x = Me.Width - lblWidth - 10 - DV(i).Item("Fieldwidth")
                        CType(obj(i), Calendar.UcCalendar).Anchor = AnchorStyles.Top Or AnchorStyles.Right
                    Else
                        x = lblWidth + 10
                        CType(obj(i), Calendar.UcCalendar).Anchor = AnchorStyles.Top Or AnchorStyles.Left
                    End If
                    CType(obj(i), Calendar.UcCalendar).Location = New System.Drawing.Point(x, _top + FHeight)
                    CType(obj(i), Calendar.UcCalendar).Width = DV(i).Item("Fieldwidth")
                    CType(obj(i), Calendar.UcCalendar).TabIndex = DV(i).Item("TabIndex")
                    CType(obj(i), Calendar.UcCalendar).BorderStyle = BorderStyle.None
                    CType(obj(i), Calendar.UcCalendar).BorderColor = Color.LightSteelBlue
                    CType(obj(i), Calendar.UcCalendar).Enabled = False
                    If DV(i).Item("IsMandatory") = True Then
                        CType(obj(i), Calendar.UcCalendar).BackColor = SystemColors.Info
                    End If
                    ToolTip1.SetToolTip(CType(obj(i), Calendar.UcCalendar), DV(i).Item("Fieldcaption"))
                    Me.Controls.Add(obj(i))
                    AddHandler CType(obj(i), Calendar.UcCalendar).TextChanged, AddressOf ObjTextChanged
                Case "DateL"
                    obj.Add(i, New CalendarCombo.CalendarCombo)
                    If Me.Language = Language.Persian Then
                        x = Me.Width - lblWidth - 10 - DV(i).Item("Fieldwidth")
                        CType(obj(i), CalendarCombo.CalendarCombo).Anchor = AnchorStyles.Top Or AnchorStyles.Right
                    Else
                        x = lblWidth + 10
                        CType(obj(i), CalendarCombo.CalendarCombo).Anchor = AnchorStyles.Top Or AnchorStyles.Left
                    End If
                    CType(obj(i), CalendarCombo.CalendarCombo).Location = New System.Drawing.Point(x, _top + FHeight)
                    CType(obj(i), CalendarCombo.CalendarCombo).Width = DV(i).Item("Fieldwidth")
                    CType(obj(i), CalendarCombo.CalendarCombo).TabIndex = DV(i).Item("TabIndex")
                    CType(obj(i), CalendarCombo.CalendarCombo).BorderStyle = BorderStyle.None
                    CType(obj(i), CalendarCombo.CalendarCombo).BorderColor = Color.LightSteelBlue
                    CType(obj(i), CalendarCombo.CalendarCombo).Enabled = False
                    If DV(i).Item("IsMandatory") = True Then
                        CType(obj(i), CalendarCombo.CalendarCombo).BackColor = SystemColors.Info
                    End If
                    ToolTip1.SetToolTip(CType(obj(i), CalendarCombo.CalendarCombo), DV(i).Item("Fieldcaption"))
                    Me.Controls.Add(obj(i))
                    AddHandler CType(obj(i), CalendarCombo.CalendarCombo).TextChanged, AddressOf ObjTextChanged
                Case "NumericBox"
                    obj.Add(i, New CalcUtils.UcCalcText)
                    If Me.Language = Language.Persian Then
                        x = Me.Width - lblWidth - 10 - DV(i).Item("Fieldwidth")
                        CType(obj(i), CalcUtils.UcCalcText).Anchor = AnchorStyles.Top Or AnchorStyles.Right
                    Else
                        x = lblWidth + 10
                        CType(obj(i), CalcUtils.UcCalcText).Anchor = AnchorStyles.Top Or AnchorStyles.Left
                    End If
                    CType(obj(i), CalcUtils.UcCalcText).Location = New System.Drawing.Point(x, _top + FHeight)
                    CType(obj(i), CalcUtils.UcCalcText).Width = DV(i).Item("Fieldwidth")
                    CType(obj(i), CalcUtils.UcCalcText).Maxlength = DV(i).Item("Maxlength")
                    CType(obj(i), CalcUtils.UcCalcText).TabIndex = DV(i).Item("TabIndex")
                    CType(obj(i), CalcUtils.UcCalcText).DecimalDigits = IIf(DV(i).Item("NoDecimal") Is DBNull.Value, 0, DV(i).Item("NoDecimal"))
                    CType(obj(i), CalcUtils.UcCalcText).Enabled = False
                    If DV(i).Item("IsMandatory") = True Then
                        CType(obj(i), CalcUtils.UcCalcText).BackColor = SystemColors.Info
                    End If
                    ToolTip1.SetToolTip(CType(obj(i), CalcUtils.UcCalcText), DV(i).Item("Fieldcaption"))
                    Me.Controls.Add(obj(i))
                    AddHandler CType(obj(i), CalcUtils.UcCalcText).TextChanged, AddressOf ObjTextChanged
                Case "ComboBox"
                    obj.Add(i, New UcEnter.ComboBoxEnter)
                    If Me.Language = Language.Persian Then
                        x = Me.Width - lblWidth - 10 - DV(i).Item("Fieldwidth")
                        CType(obj(i), UcEnter.ComboBoxEnter).Anchor = AnchorStyles.Top Or AnchorStyles.Right
                    Else
                        x = lblWidth + 10
                        CType(obj(i), UcEnter.ComboBoxEnter).Anchor = AnchorStyles.Top Or AnchorStyles.Left
                    End If
                    CType(obj(i), UcEnter.ComboBoxEnter).Location = New System.Drawing.Point(x, _top + FHeight)
                    CType(obj(i), UcEnter.ComboBoxEnter).Width = DV(i).Item("Fieldwidth")
                    CType(obj(i), UcEnter.ComboBoxEnter).TabIndex = DV(i).Item("TabIndex")
                    CType(obj(i), UcEnter.ComboBoxEnter).ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
                    CType(obj(i), UcEnter.ComboBoxEnter).Enabled = False
                    ToolTip1.SetToolTip(CType(obj(i), UcEnter.ComboBoxEnter), DV(i).Item("Fieldcaption"))
                    If DV(i).Item("CMBStatic") & "" = "" Then
                        If DV(i).Item("CMBTableName") & "" <> "" And DV(i).Item("CMBValueName") & "" <> "" And DV(i).Item("CMBDisplayName") & "" <> "" Then
                            Dim strSelect As String = ""
                            cmdGeneral.Connection = Cnn
                            If cmdGeneral.Connection.State = ConnectionState.Closed Then
                                cmdGeneral.Connection.Open()
                            End If
                            strSelect = DV(i).Item("CMBValueName") & "," & DV(i).Item("CMBDisplayName")
                            cmdGeneral.CommandText = "SELECT " & strSelect & " From " & DV(i).Item("CMBTableName")
                            DaData.SelectCommand = cmdGeneral
                            DaData.Fill(DsData, DV(i).Item("Fieldname") & DV(i).Item("CMBTableName"))
                            cmdGeneral.Connection.Close()
                        End If
                    End If
                    CType(obj(i), UcEnter.ComboBoxEnter).DataSource = DsData
                    CType(obj(i), UcEnter.ComboBoxEnter).DataMember = DV(i).Item("Fieldname") & DV(i).Item("CMBTableName")
                    CType(obj(i), UcEnter.ComboBoxEnter).ValueMember = DV(i).Item("CMBValueName")
                    CType(obj(i), UcEnter.ComboBoxEnter).DisplayMember = DV(i).Item("CMBDisplayName")
                    If DV(i).Item("IsMandatory") = True Then
                        CType(obj(i), UcEnter.ComboBoxEnter).BackColor = SystemColors.Info
                    End If
                    Me.Controls.Add(obj(i))
                    AddHandler CType(obj(i), UcEnter.ComboBoxEnter).SelectedIndexChanged, AddressOf ObjTextChanged
                Case "Time"
                    obj.Add(i, New UcEnter.JanusCalendarComboEnter)
                    If Me.Language = Language.Persian Then
                        x = Me.Width - lblWidth - 10 - DV(i).Item("Fieldwidth")
                        CType(obj(i), UcEnter.JanusCalendarComboEnter).Anchor = AnchorStyles.Top Or AnchorStyles.Right
                    Else
                        x = lblWidth + 10
                        CType(obj(i), UcEnter.JanusCalendarComboEnter).Anchor = AnchorStyles.Top Or AnchorStyles.Left
                    End If
                    CType(obj(i), UcEnter.JanusCalendarComboEnter).Location = New System.Drawing.Point(x, _top + FHeight)
                    CType(obj(i), UcEnter.JanusCalendarComboEnter).Width = DV(i).Item("Fieldwidth")
                    CType(obj(i), UcEnter.JanusCalendarComboEnter).TabIndex = DV(i).Item("TabIndex")
                    CType(obj(i), UcEnter.JanusCalendarComboEnter).DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
                    CType(obj(i), UcEnter.JanusCalendarComboEnter).CustomFormat = "HH:mm"
                    CType(obj(i), UcEnter.JanusCalendarComboEnter).ShowUpDown = True
                    CType(obj(i), UcEnter.JanusCalendarComboEnter).ShowDropDown = False
                    CType(obj(i), UcEnter.JanusCalendarComboEnter).RightToLeft = RightToLeft.No
                    CType(obj(i), UcEnter.JanusCalendarComboEnter).Enabled = False
                    If DV(i).Item("IsMandatory") = True Then
                        CType(obj(i), UcEnter.JanusCalendarComboEnter).BackColor = SystemColors.Info
                    End If
                    ToolTip1.SetToolTip(CType(obj(i), UcEnter.JanusCalendarComboEnter), DV(i).Item("Fieldcaption"))
                    Me.Controls.Add(obj(i))
                    AddHandler CType(obj(i), UcEnter.JanusCalendarComboEnter).TextChanged, AddressOf ObjTextChanged
                Case "MTextBox"
                    obj.Add(i, New UcEnter.TextBoxEnter)
                    If Me.Language = Language.Persian Then
                        x = Me.Width - lblWidth - 10 - DV(i).Item("Fieldwidth")
                        CType(obj(i), UcEnter.TextBoxEnter).RightToLeft = RightToLeft.Yes
                        CType(obj(i), UcEnter.TextBoxEnter).Anchor = AnchorStyles.Top Or AnchorStyles.Right
                    Else
                        x = lblWidth + 10
                        CType(obj(i), UcEnter.TextBoxEnter).RightToLeft = RightToLeft.No
                        CType(obj(i), UcEnter.TextBoxEnter).Anchor = AnchorStyles.Top Or AnchorStyles.Left
                    End If
                    CType(obj(i), UcEnter.TextBoxEnter).Location = New System.Drawing.Point(x, _top + FHeight)
                    CType(obj(i), UcEnter.TextBoxEnter).Width = DV(i).Item("Fieldwidth")
                    CType(obj(i), UcEnter.TextBoxEnter).MaxLength = DV(i).Item("MaxLength")
                    CType(obj(i), UcEnter.TextBoxEnter).TabIndex = DV(i).Item("TabIndex")
                    CType(obj(i), UcEnter.TextBoxEnter).Multiline = True
                    CType(obj(i), UcEnter.TextBoxEnter).Height = DV(i).Item("Fieldheight")
                    CType(obj(i), UcEnter.TextBoxEnter).ScrollBars = ScrollBars.Both
                    CType(obj(i), UcEnter.TextBoxEnter).Enabled = False
                    If DV(i).Item("IsMandatory") = True Then
                        CType(obj(i), UcEnter.TextBoxEnter).BackColor = SystemColors.Info
                    End If
                    ToolTip1.SetToolTip(CType(obj(i), UcEnter.TextBoxEnter), DV(i).Item("Fieldcaption"))
                    Me.Controls.Add(obj(i))
                    AddHandler CType(obj(i), UcEnter.TextBoxEnter).TextChanged, AddressOf ObjTextChanged
                Case "LTextBox"
                    obj.Add(i, New UCCommentButton.CommentButton)
                    If Me.Language = Language.Persian Then
                        x = Me.Width - lblWidth - 10 - DV(i).Item("Fieldwidth")
                        CType(obj(i), UCCommentButton.CommentButton).RightToLeft = RightToLeft.Yes
                        'CType(obj(i), UCCommentButton.CommentButton).ZLanguage = UCCommentButton.Language.Persian
                        CType(obj(i), UCCommentButton.CommentButton).Anchor = AnchorStyles.Top Or AnchorStyles.Right
                    Else
                        x = lblWidth + 10
                        CType(obj(i), UCCommentButton.CommentButton).RightToLeft = RightToLeft.No
                        'CType(obj(i), UCCommentButton.CommentButton).ZLanguage = UCCommentButton.Language.English
                        CType(obj(i), UCCommentButton.CommentButton).Anchor = AnchorStyles.Top Or AnchorStyles.Left
                    End If
                    CType(obj(i), UCCommentButton.CommentButton).Location = New System.Drawing.Point(x, _top + FHeight)
                    CType(obj(i), UCCommentButton.CommentButton).ZButtonText = DV(i).Item("Fieldcaption")
                    CType(obj(i), UCCommentButton.CommentButton).ZMaxCommentLength = DV(i).Item("MaxLength")
                    CType(obj(i), UCCommentButton.CommentButton).TabIndex = DV(i).Item("TabIndex")
                    CType(obj(i), UCCommentButton.CommentButton).Width = DV(i).Item("Fieldwidth")
                    CType(obj(i), UCCommentButton.CommentButton).ZEnabled = False
                    ToolTip1.SetToolTip(CType(obj(i), UCCommentButton.CommentButton), DV(i).Item("Fieldcaption"))
                    Me.Controls.Add(obj(i))
                Case "CheckBox"
                    obj.Add(i, New Janus.Windows.EditControls.UICheckBox)
                    If Me.Language = Language.Persian Then
                        x = Me.Width - lblWidth - 10 - DV(i).Item("Fieldwidth")
                        CType(obj(i), Janus.Windows.EditControls.UICheckBox).Anchor = AnchorStyles.Top Or AnchorStyles.Right
                    Else
                        x = lblWidth + 10
                        CType(obj(i), Janus.Windows.EditControls.UICheckBox).Anchor = AnchorStyles.Top Or AnchorStyles.Left
                    End If
                    CType(obj(i), Janus.Windows.EditControls.UICheckBox).Size = New System.Drawing.Size(15, 15)
                    CType(obj(i), Janus.Windows.EditControls.UICheckBox).Location = New System.Drawing.Point(x, _top + FHeight)
                    CType(obj(i), Janus.Windows.EditControls.UICheckBox).TabIndex = DV(i).Item("TabIndex")
                    CType(obj(i), Janus.Windows.EditControls.UICheckBox).Enabled = False
                    Me.Controls.Add(obj(i))
                Case "Picture"
                    obj.Add(i, New UCPicture.PictureButton)
                    If Me.Language = Language.Persian Then
                        x = Me.Width - lblWidth - 10 - DV(i).Item("Fieldwidth")
                        CType(obj(i), UCPicture.PictureButton).RightToLeft = RightToLeft.No
                        CType(obj(i), UCPicture.PictureButton).Anchor = AnchorStyles.Top Or AnchorStyles.Right
                    Else
                        x = lblWidth + 10
                        CType(obj(i), UCPicture.PictureButton).RightToLeft = RightToLeft.No
                        CType(obj(i), UCPicture.PictureButton).Anchor = AnchorStyles.Top Or AnchorStyles.Left
                    End If
                    CType(obj(i), UCPicture.PictureButton).Location = New System.Drawing.Point(x, _top + FHeight)
                    CType(obj(i), UCPicture.PictureButton).status = WorkStates._ReadOnly
                    CType(obj(i), UCPicture.PictureButton).TabIndex = DV(i).Item("TabIndex")
                    Me.Controls.Add(obj(i))
                Case "NumericUpDown"
                    obj.Add(i, New UcEnter.IntegerUpDownEnter)
                    If Me.Language = Language.Persian Then
                        x = Me.Width - lblWidth - 10 - DV(i).Item("Fieldwidth")
                        CType(obj(i), UcEnter.IntegerUpDownEnter).RightToLeft = RightToLeft.No
                        CType(obj(i), UcEnter.IntegerUpDownEnter).Anchor = AnchorStyles.Top Or AnchorStyles.Right
                    Else
                        x = lblWidth + 10
                        CType(obj(i), UcEnter.IntegerUpDownEnter).RightToLeft = RightToLeft.No
                        CType(obj(i), UcEnter.IntegerUpDownEnter).Anchor = AnchorStyles.Top Or AnchorStyles.Left
                    End If
                    CType(obj(i), UcEnter.IntegerUpDownEnter).Location = New System.Drawing.Point(x, _top + FHeight)
                    CType(obj(i), UcEnter.IntegerUpDownEnter).Width = DV(i).Item("Fieldwidth")
                    CType(obj(i), UcEnter.IntegerUpDownEnter).MaxLength = DV(i).Item("MaxLength")
                    CType(obj(i), UcEnter.IntegerUpDownEnter).TabIndex = DV(i).Item("TabIndex")
                    Dim mMax As String = ""
                    CType(obj(i), UcEnter.IntegerUpDownEnter).Maximum = Val(mMax.PadLeft(DV(i).Item("MaxLength"), "9"))
                    CType(obj(i), UcEnter.IntegerUpDownEnter).Enabled = False
                    If DV(i).Item("IsMandatory") = True Then
                        CType(obj(i), UcEnter.IntegerUpDownEnter).BackColor = SystemColors.Info
                    End If
                    ToolTip1.SetToolTip(CType(obj(i), UcEnter.IntegerUpDownEnter), DV(i).Item("Fieldcaption"))
                    Me.Controls.Add(obj(i))
                    If DV(i).Item("Isprimary") Then
                        bAutoNumber = True
                    End If
                Case "NTextBox"
                    obj.Add(i, New UcEnter.NTextBox)
                    If Me.Language = Language.Persian Then
                        x = Me.Width - lblWidth - 10 - DV(i).Item("Fieldwidth")
                        CType(obj(i), UcEnter.NTextBox).RightToLeft = RightToLeft.Yes
                        CType(obj(i), UcEnter.NTextBox).Anchor = AnchorStyles.Top Or AnchorStyles.Right
                    Else
                        x = lblWidth + 10
                        CType(obj(i), UcEnter.NTextBox).RightToLeft = RightToLeft.No
                        CType(obj(i), UcEnter.NTextBox).Anchor = AnchorStyles.Top Or AnchorStyles.Left
                    End If
                    CType(obj(i), UcEnter.NTextBox).Location = New System.Drawing.Point(x, _top + FHeight)
                    CType(obj(i), UcEnter.NTextBox).Width = DV(i).Item("Fieldwidth")
                    CType(obj(i), UcEnter.NTextBox).MaxLength = DV(i).Item("MaxLength")
                    CType(obj(i), UcEnter.NTextBox).TabIndex = DV(i).Item("TabIndex")
                    CType(obj(i), UcEnter.NTextBox).Enabled = False
                    If DV(i).Item("IsMandatory") = True Then
                        CType(obj(i), UcEnter.NTextBox).BackColor = SystemColors.Info
                    End If
                    ToolTip1.SetToolTip(CType(obj(i), UcEnter.NTextBox), DV(i).Item("Fieldcaption"))
                    Me.Controls.Add(obj(i))
                    If DV(i).Item("FillZero") = True Then
                        AddHandler CType(obj(i), UcEnter.NTextBox).Leave, AddressOf NTextBoxLeaveHandler
                    End If
                    AddHandler CType(obj(i), UcEnter.NTextBox).TextChanged, AddressOf ObjTextChanged
                    If DV(i).Item("Isprimary") Then
                        bAutoNumber = True
                    End If
            End Select
        Next
    End Sub

    Private Sub FillObjects()
        If DvData.Count > 0 Then
            Dim FillObjI As Integer = 0
            For FillObjI = 0 To DV.Count - 1
                Select Case DV(FillObjI).Item("FieldObjectType")
                    Case "TextBox"
                        CType(obj(FillObjI), UcEnter.TextBoxEnter).Text = Trim(DvData(cm.Position).Item(DV(FillObjI).Item("Fieldname")) & "")
                    Case "Date"
                        CType(obj(FillObjI), Calendar.UcCalendar).Text = Trim(DvData(cm.Position).Item(DV(FillObjI).Item("Fieldname")) & "")
                    Case "NumericBox"
                        CType(obj(FillObjI), CalcUtils.UcCalcText).Text = Trim(DvData(cm.Position).Item(DV(FillObjI).Item("Fieldname")) & "")
                    Case "ComboBox"
                        CType(obj(FillObjI), UcEnter.ComboBoxEnter).SelectedValue = Trim(DvData(cm.Position).Item(DV(FillObjI).Item("Fieldname")) & "")
                    Case "Time"
                        CType(obj(FillObjI), UcEnter.JanusCalendarComboEnter).Value = Trim(DvData(cm.Position).Item(DV(FillObjI).Item("Fieldname")) & "")
                    Case "MTextBox"
                        CType(obj(FillObjI), UcEnter.TextBoxEnter).Text = Trim(DvData(cm.Position).Item(DV(FillObjI).Item("Fieldname")) & "")
                    Case "LTextBox"
                        CType(obj(FillObjI), UCCommentButton.CommentButton).ZCommentText = Trim(DvData(cm.Position).Item(DV(FillObjI).Item("Fieldname")) & "")
                    Case "CheckBox"
                        CType(obj(FillObjI), Janus.Windows.EditControls.UICheckBox).Checked = DvData(cm.Position).Item(DV(FillObjI).Item("Fieldname"))
                    Case "Picture"
                        CType(obj(FillObjI), UCPicture.PictureButton).MyPicture = DvData(cm.Position).Item(DV(FillObjI).Item("Fieldname"))
                    Case "NumericUpDown"
                        CType(obj(FillObjI), UcEnter.IntegerUpDownEnter).Value = DvData(cm.Position).Item(DV(FillObjI).Item("Fieldname")) & ""
                    Case "NTextBox"
                        CType(obj(FillObjI), UcEnter.NTextBox).Text = DvData(cm.Position).Item(DV(FillObjI).Item("Fieldname")) & ""
                End Select
            Next
        End If
    End Sub

    Private Sub ClearObjects()
        Dim behCounter As Integer
        For behCounter = 0 To DV.Count - 1
            Select Case DV(behCounter).Item("FieldObjectType")
                Case "TextBox"
                    If DV(behCounter).Item("DefaultValue") & "" = "" Then
                        CType(obj(behCounter), UcEnter.TextBoxEnter).Text = ""
                    Else
                        If mStatus = WorkStates.Cancel Or mStatus = WorkStates.Edit Then
                            CType(obj(behCounter), UcEnter.TextBoxEnter).Text = ""
                        Else
                            CType(obj(behCounter), UcEnter.TextBoxEnter).Text = DV(behCounter).Item("DefaultValue")
                        End If
                    End If

                Case "Date"
                    If DV(behCounter).Item("DefaultValue") & "" = "" Then
                        CType(obj(behCounter), Calendar.UcCalendar).Text = ""
                    Else
                        If mStatus = WorkStates.Cancel Or mStatus = WorkStates.Edit Then
                            CType(obj(behCounter), Calendar.UcCalendar).Text = ""
                        Else
                            CType(obj(behCounter), Calendar.UcCalendar).Text = DV(behCounter).Item("DefaultValue")
                        End If
                    End If

                Case "NumericBox"
                    If DV(behCounter).Item("DefaultValue") & "" = "" Then
                        CType(obj(behCounter), CalcUtils.UcCalcText).Text = ""
                    Else
                        If mStatus = WorkStates.Cancel Or mStatus = WorkStates.Edit Then
                            CType(obj(behCounter), CalcUtils.UcCalcText).Text = ""
                        Else
                            CType(obj(behCounter), CalcUtils.UcCalcText).Text = DV(behCounter).Item("DefaultValue")
                        End If
                    End If

                Case "ComboBox"
                    If DV(behCounter).Item("DefaultValue") & "" = "" Then
                        CType(obj(behCounter), UcEnter.ComboBoxEnter).SelectedValue = ""
                        CType(obj(behCounter), UcEnter.ComboBoxEnter).Text = ""
                    Else
                        If mStatus = WorkStates.Cancel Or mStatus = WorkStates.Edit Then
                            CType(obj(behCounter), UcEnter.ComboBoxEnter).SelectedValue = ""
                            CType(obj(behCounter), UcEnter.ComboBoxEnter).Text = ""
                        Else
                            CType(obj(behCounter), UcEnter.ComboBoxEnter).SelectedValue = DV(behCounter).Item("DefaultValue").trim
                        End If
                    End If

                Case "Time"
                    If DV(behCounter).Item("DefaultValue") & "" = "" Then
                        CType(obj(behCounter), UcEnter.JanusCalendarComboEnter).Text = ""
                    Else
                        If mStatus = WorkStates.Cancel Or mStatus = WorkStates.Edit Then
                            CType(obj(behCounter), UcEnter.JanusCalendarComboEnter).Text = ""
                        Else
                            CType(obj(behCounter), UcEnter.JanusCalendarComboEnter).Text = DV(behCounter).Item("DefaultValue")
                        End If
                    End If

                Case "MTextBox"
                    If DV(behCounter).Item("DefaultValue") & "" = "" Then
                        CType(obj(behCounter), UcEnter.TextBoxEnter).Text = ""
                    Else
                        If mStatus = WorkStates.Cancel Or mStatus = WorkStates.Edit Then
                            CType(obj(behCounter), UcEnter.TextBoxEnter).Text = ""
                        Else
                            CType(obj(behCounter), UcEnter.TextBoxEnter).Text = DV(behCounter).Item("DefaultValue")
                        End If
                    End If

                Case "LTextBox"
                    If DV(behCounter).Item("DefaultValue") & "" = "" Then
                        CType(obj(behCounter), UCCommentButton.CommentButton).ZCommentText = ""
                    Else
                        If mStatus = WorkStates.Cancel Or mStatus = WorkStates.Edit Then
                            CType(obj(behCounter), UCCommentButton.CommentButton).ZCommentText = ""
                        Else
                            CType(obj(behCounter), UCCommentButton.CommentButton).ZCommentText = DV(behCounter).Item("DefaultValue")
                        End If
                    End If
                Case "CheckBox"
                    CType(obj(behCounter), Janus.Windows.EditControls.UICheckBox).Checked = False
                Case "Picture"
                    CType(obj(behCounter), UCPicture.PictureButton).MyPicture = Nothing
                Case "NumericUpDown"
                    CType(obj(behCounter), UcEnter.IntegerUpDownEnter).Value = 0
                Case "NTextBox"
                    CType(obj(behCounter), UcEnter.NTextBox).Text = "0"
            End Select
        Next
    End Sub

    Private Sub EnableObjects(ByVal EnableStatus As Boolean)
        i = 0
        For i = 0 To DV.Count - 1
            If DV(i).Item("Enable") = True Then
                Select Case DV(i).Item("FieldObjectType")
                    Case "TextBox"
                        If mStatus = WorkStates.Edit And DV(i).Item("UpdateDisabled") = True Then
                            CType(obj(i), UcEnter.TextBoxEnter).Enabled = False
                        Else
                            CType(obj(i), UcEnter.TextBoxEnter).Enabled = EnableStatus
                        End If
                    Case "Date"
                        If mStatus = WorkStates.Edit And DV(i).Item("UpdateDisabled") = True Then
                            CType(obj(i), Calendar.UcCalendar).Enabled = False
                        Else
                            CType(obj(i), Calendar.UcCalendar).Enabled = EnableStatus
                        End If
                    Case "DateL"
                        If mStatus = WorkStates.Edit And DV(i).Item("UpdateDisabled") = True Then
                            CType(obj(i), CalendarCombo.CalendarCombo).Enabled = False
                        Else
                            CType(obj(i), CalendarCombo.CalendarCombo).Enabled = EnableStatus
                        End If
                    Case "NumericBox"
                        If mStatus = WorkStates.Edit And DV(i).Item("UpdateDisabled") = True Then
                            CType(obj(i), CalcUtils.UcCalcText).Enabled = False
                        Else
                            CType(obj(i), CalcUtils.UcCalcText).Enabled = EnableStatus
                        End If
                    Case "ComboBox"
                        If mStatus = WorkStates.Edit And DV(i).Item("UpdateDisabled") = True Then
                            CType(obj(i), UcEnter.ComboBoxEnter).Enabled = False
                        Else
                            CType(obj(i), UcEnter.ComboBoxEnter).Enabled = EnableStatus
                        End If
                    Case "Time"
                        If mStatus = WorkStates.Edit And DV(i).Item("UpdateDisabled") = True Then
                            CType(obj(i), UcEnter.JanusCalendarComboEnter).Enabled = False
                        Else
                            CType(obj(i), UcEnter.JanusCalendarComboEnter).Enabled = EnableStatus
                        End If
                    Case "MTextBox"
                        If mStatus = WorkStates.Edit And DV(i).Item("UpdateDisabled") = True Then
                            CType(obj(i), UcEnter.TextBoxEnter).Enabled = False
                        Else
                            CType(obj(i), UcEnter.TextBoxEnter).Enabled = EnableStatus
                        End If
                    Case "LTextBox"
                        If mStatus = WorkStates.Edit And DV(i).Item("UpdateDisabled") = True Then
                            CType(obj(i), UCCommentButton.CommentButton).ZEnabled = False
                        Else
                            CType(obj(i), UCCommentButton.CommentButton).ZEnabled = EnableStatus
                        End If
                    Case "CheckBox"
                        If mStatus = WorkStates.Edit And DV(i).Item("UpdateDisabled") = True Then
                            CType(obj(i), Janus.Windows.EditControls.UICheckBox).Enabled = False
                        Else
                            CType(obj(i), Janus.Windows.EditControls.UICheckBox).Enabled = EnableStatus
                        End If
                    Case "Picture"
                        If mStatus = WorkStates.Edit And DV(i).Item("UpdateDisabled") = True Then
                            CType(obj(i), UCPicture.PictureButton).status = WorkStates._ReadOnly
                        Else
                            If mStatus = WorkStates.Cancel Then
                                CType(obj(i), UCPicture.PictureButton).status = WorkStates._ReadOnly
                            Else
                                CType(obj(i), UCPicture.PictureButton).status = mStatus
                            End If
                        End If
                    Case "NumericUpDown"
                        If mStatus = WorkStates.Edit And DV(i).Item("UpdateDisabled") = True Then
                            CType(obj(i), UcEnter.IntegerUpDownEnter).Enabled = False
                        Else
                            CType(obj(i), UcEnter.IntegerUpDownEnter).Enabled = EnableStatus
                        End If
                    Case "NTextBox"
                        If mStatus = WorkStates.Edit And DV(i).Item("UpdateDisabled") = True Then
                            CType(obj(i), UcEnter.NTextBox).Enabled = False
                        Else
                            CType(obj(i), UcEnter.NTextBox).Enabled = EnableStatus
                        End If
                End Select
            End If
        Next
    End Sub

    Private Sub SetOldValue()
        objValue.Clear()
        If DvData.Count > 0 Then
            i = 0
            For i = 0 To DV.Count - 1
                Select Case DV(i).Item("FieldObjectType")
                    Case "TextBox"
                        objValue.Add(i, CType(obj(i), UcEnter.TextBoxEnter).Text)
                    Case "Date"
                        objValue.Add(i, CType(obj(i), Calendar.UcCalendar).Text)
                    Case "DateL"
                        objValue.Add(i, CType(obj(i), CalendarCombo.CalendarCombo).Text)
                    Case "NumericBox"
                        objValue.Add(i, CType(obj(i), CalcUtils.UcCalcText).Text)
                    Case "ComboBox"
                        objValue.Add(i, CType(obj(i), UcEnter.ComboBoxEnter).SelectedValue)
                    Case "Time"
                        objValue.Add(i, CType(obj(i), UcEnter.JanusCalendarComboEnter).Value)
                    Case "MTextBox"
                        objValue.Add(i, CType(obj(i), UcEnter.TextBoxEnter).Text)
                    Case "LTextBox"
                        objValue.Add(i, CType(obj(i), UCCommentButton.CommentButton).ZCommentText)
                    Case "CheckBox"
                        objValue.Add(i, CType(obj(i), Janus.Windows.EditControls.UICheckBox).Checked)
                    Case "Picture"
                        objValue.Add(i, CType(obj(i), UCPicture.PictureButton).MyPicture)
                    Case "NumericUpDown"
                        objValue.Add(i, CType(obj(i), UcEnter.IntegerUpDownEnter).Value)
                    Case "NTextBox"
                        objValue.Add(i, CType(obj(i), UcEnter.NTextBox).Text)
                End Select
            Next
        End If
    End Sub

    Private Sub EnableDisableSave()
        Dim IsMand As Boolean = True
        If mStatus = WorkStates.AddNew Or mStatus = WorkStates.Edit Then
            i = 0
            For i = 0 To DV.Count - 1
                Select Case DV(i).Item("FieldObjectType")
                    Case "TextBox"
                        If DV(i).Item("IsMandatory") = True Then
                            If CType(obj(i), UcEnter.TextBoxEnter).Text.Trim.Length = 0 Then
                                IsMand = False
                            End If
                        End If
                    Case "Date"
                        If DV(i).Item("IsMandatory") = True Then
                            If CType(obj(i), Calendar.UcCalendar).Text.Trim.Length = 0 Then
                                IsMand = False
                            End If
                        End If
                    Case "DateL"
                        If DV(i).Item("IsMandatory") = True Then
                            If CType(obj(i), CalendarCombo.CalendarCombo).Text.Trim.Length = 0 Then
                                IsMand = False
                            End If
                        End If
                    Case "NumericBox"
                        If DV(i).Item("IsMandatory") = True Then
                            If CType(obj(i), CalcUtils.UcCalcText).Text.Trim.Length = 0 Then
                                IsMand = False
                            End If
                        End If
                    Case "ComboBox"
                        If DV(i).Item("IsMandatory") = True Then
                            If CType(obj(i), UcEnter.ComboBoxEnter).Text.Trim.Length = 0 Then
                                IsMand = False
                            End If
                        End If
                    Case "Time"
                        If DV(i).Item("IsMandatory") = True Then
                            If CType(obj(i), UcEnter.JanusCalendarComboEnter).Text.Trim.Length = 0 Then
                                IsMand = False
                            End If
                        End If
                    Case "MTextBox"
                        If DV(i).Item("IsMandatory") = True Then
                            If CType(obj(i), UcEnter.TextBoxEnter).Text.Trim.Length = 0 Then
                                IsMand = False
                            End If
                        End If
                    Case "CheckBox"

                    Case "Picture"
                        If DV(i).Item("IsMandatory") = True Then
                            If CType(obj(i), UCPicture.PictureButton).MyPicture Is Nothing Then
                                IsMand = False
                            End If
                        End If

                    Case "NumericUpDown"
                        If DV(i).Item("IsMandatory") = True Then
                            If CType(obj(i), UcEnter.IntegerUpDownEnter).Text.Trim.Length = 0 Then
                                IsMand = False
                            End If
                        End If
                    Case "NTextBox"
                        If DV(i).Item("IsMandatory") = True Then
                            If CType(obj(i), UcEnter.NTextBox).Text.Trim.Length = 0 Then
                                IsMand = False
                            End If
                        End If
                End Select
            Next
            If IsMand = False Then
                BtnSave.Enabled = False
            Else
                BtnSave.Enabled = True
            End If
        End If
    End Sub

    Private Function ReternObjValue(ByVal mObj As Object, ByVal j As Integer) As String
        If TypeOf mObj Is CalcUtils.UcCalcText Then
            Return CType(mObj, CalcUtils.UcCalcText).Text
        ElseIf TypeOf mObj Is UCCommentButton.CommentButton Then
            Return Qt(CType(mObj, UCCommentButton.CommentButton).ZCommentText)
        ElseIf TypeOf mObj Is Calendar.UcCalendar Then
            Return Qt(CType(mObj, Calendar.UcCalendar).Text)
        ElseIf TypeOf mObj Is CalendarCombo.CalendarCombo Then
            Return Qt(CType(mObj, CalendarCombo.CalendarCombo).Text)
        ElseIf TypeOf mObj Is UcEnter.JanusCalendarComboEnter Then
            Return Qt(CType(mObj, UcEnter.JanusCalendarComboEnter).Value)
        ElseIf TypeOf mObj Is UcEnter.ComboBoxEnter Then
            If CType(mObj, UcEnter.ComboBoxEnter).SelectedValue.trim & "" <> "" Then
                Return Qt(CType(mObj, UcEnter.ComboBoxEnter).SelectedValue)
            Else
                Return "Null"
            End If
        ElseIf TypeOf mObj Is Janus.Windows.EditControls.UICheckBox Then
            Return IIf(CType(mObj, Janus.Windows.EditControls.UICheckBox).Checked = True, 1, 0)
        ElseIf TypeOf mObj Is UcEnter.IntegerUpDownEnter Then
            If DsData.Tables(DV(0).Item("FrmTable")).Columns(j).DataType Is System.Type.GetType("System.String") Then
                Return Qt(CType(mObj, UcEnter.IntegerUpDownEnter).Value)
            Else
                Return CType(mObj, UcEnter.IntegerUpDownEnter).Value
            End If
        ElseIf TypeOf mObj Is UcEnter.TextBoxEnter Then
            If DsData.Tables(DV(0).Item("FrmTable")).Columns(j).DataType Is System.Type.GetType("System.String") Then
                Return Qt(CType(mObj, UcEnter.TextBoxEnter).Text)
            Else
                Return CType(mObj, UcEnter.TextBoxEnter).Text
            End If
        ElseIf TypeOf mObj Is UcEnter.NTextBox Then
            If DsData.Tables(DV(0).Item("FrmTable")).Columns(j).DataType Is System.Type.GetType("System.String") Then
                Return Qt(CType(mObj, UcEnter.NTextBox).Text)
            Else
                Return CType(mObj, UcEnter.NTextBox).Text
            End If
        End If
    End Function

    Private Sub SetCondition(ByVal intIndex As Integer)
        If DV(intIndex).Item("CMBFilterOnFieldIndex") & "" <> "" And DV(intIndex).Item("CMBFilterOnFieldProperty") & "" <> "" Then
            If DV(intIndex).Item("CMBFilterOnFieldIndex1") & "" <> "" And DV(intIndex).Item("CMBFilterOnFieldProperty1") & "" <> "" Then
                Dim FilterIndex As Integer = DV(intIndex).Item("CMBFilterOnFieldIndex")
                Dim FilterIndex1 As Integer = DV(intIndex).Item("CMBFilterOnFieldIndex1")
                If FilterIndex = FilterIndex1 Then
                    If DV(FilterIndex).Item("FieldObjectType") = "ComboBox" Then
                        DsData.Tables(DV(FilterIndex).Item("Fieldname") & DV(FilterIndex).Item("CMBTableName")).Clear()
                        If DV(FilterIndex).Item("CMBTableName") & "" <> "" And DV(FilterIndex).Item("CMBValueName") & "" <> "" And DV(FilterIndex).Item("CMBDisplayName") & "" <> "" Then
                            Dim strSelect As String = ""
                            cmdGeneral.Connection = Cnn
                            If cmdGeneral.Connection.State = ConnectionState.Closed Then
                                cmdGeneral.Connection.Open()
                            End If
                            strSelect = DV(FilterIndex).Item("CMBValueName") & "," & DV(FilterIndex).Item("CMBDisplayName")
                            'cmdGeneral.CommandText = "SELECT " & strSelect & " From " & DV(FilterIndex).Item("CMBTableName") & " Where " & DV(intIndex).Item("CMBFilterOnFieldProperty") & " = " & Qt(obj(intIndex).selectedvalue)
                            cmdGeneral.CommandText = "SELECT " & strSelect & " From " & DV(FilterIndex).Item("CMBTableName") & " Where " & DV(intIndex).Item("CMBFilterOnFieldProperty") & " = " & Qt(Trim(GiveMeValue(obj(intIndex), DV(intIndex).Item("CMBFilterFromFieldProperty")) & "")) & _
                                                     " And " & DV(intIndex).Item("CMBFilterOnFieldProperty1") & " = " & Qt(Trim(GiveMeValue(obj(intIndex), DV(intIndex).Item("CMBFilterFromFieldProperty1")) & ""))
                            DaData.SelectCommand = cmdGeneral
                            DaData.Fill(DsData, DV(FilterIndex).Item("Fieldname") & DV(FilterIndex).Item("CMBTableName"))
                            cmdGeneral.Connection.Close()
                        End If
                        CType(obj(FilterIndex), UcEnter.ComboBoxEnter).DataSource = DsData
                        CType(obj(FilterIndex), UcEnter.ComboBoxEnter).DataMember = DV(FilterIndex).Item("Fieldname") & DV(FilterIndex).Item("CMBTableName")
                        CType(obj(FilterIndex), UcEnter.ComboBoxEnter).ValueMember = DV(FilterIndex).Item("CMBValueName")
                        CType(obj(FilterIndex), UcEnter.ComboBoxEnter).DisplayMember = DV(FilterIndex).Item("CMBDisplayName")
                    End If
                Else
                    '''''''''''''''''''   Add Code
                End If
            Else
                Dim FilterIndex As Integer = DV(intIndex).Item("CMBFilterOnFieldIndex")
                If DV(FilterIndex).Item("FieldObjectType") = "ComboBox" Then
                    DsData.Tables(DV(FilterIndex).Item("Fieldname") & DV(FilterIndex).Item("CMBTableName")).Clear()
                    If DV(FilterIndex).Item("CMBTableName") & "" <> "" And DV(FilterIndex).Item("CMBValueName") & "" <> "" And DV(FilterIndex).Item("CMBDisplayName") & "" <> "" Then
                        Dim strSelect As String = ""
                        cmdGeneral.Connection = Cnn
                        If cmdGeneral.Connection.State = ConnectionState.Closed Then
                            cmdGeneral.Connection.Open()
                        End If
                        strSelect = DV(FilterIndex).Item("CMBValueName") & "," & DV(FilterIndex).Item("CMBDisplayName")
                        'cmdGeneral.CommandText = "SELECT " & strSelect & " From " & DV(FilterIndex).Item("CMBTableName") & " Where " & DV(intIndex).Item("CMBFilterOnFieldProperty") & " = " & Qt(obj(intIndex).selectedvalue)
                        cmdGeneral.CommandText = "SELECT " & strSelect & " From " & DV(FilterIndex).Item("CMBTableName") & " Where " & DV(intIndex).Item("CMBFilterOnFieldProperty") & " = " & Qt(Trim(GiveMeValue(obj(intIndex), DV(intIndex).Item("CMBFilterFromFieldProperty")) & ""))
                        DaData.SelectCommand = cmdGeneral
                        DaData.Fill(DsData, DV(FilterIndex).Item("Fieldname") & DV(FilterIndex).Item("CMBTableName"))
                        cmdGeneral.Connection.Close()
                    End If
                    CType(obj(FilterIndex), UcEnter.ComboBoxEnter).DataSource = DsData
                    CType(obj(FilterIndex), UcEnter.ComboBoxEnter).DataMember = DV(FilterIndex).Item("Fieldname") & DV(FilterIndex).Item("CMBTableName")
                    CType(obj(FilterIndex), UcEnter.ComboBoxEnter).ValueMember = DV(FilterIndex).Item("CMBValueName")
                    CType(obj(FilterIndex), UcEnter.ComboBoxEnter).DisplayMember = DV(FilterIndex).Item("CMBDisplayName")
                End If
            End If
        End If
    End Sub

    Private Sub FindTextUcObject()
        Dim Lbl As Label = CType(GetControlFromName(Me, "l" & Str(MyObjTabIndex).Trim), Label)
        'If mStatus = WorkStates.AddNew Or mStatus = WorkStates.Edit Then
        EnableDisableSave()
        Dim NotEmptyField As Boolean = False
        If NotEmptyField = True Then
            NotEmptyField = False
            SetCondition(MyObjTabIndex)
        End If
        'End If
    End Sub

    Private Sub ObjTextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If mStatus = WorkStates.AddNew Or mStatus = WorkStates.Edit Then
            EnableDisableSave()
            Dim NotEmptyField As Boolean = False
            Dim intTab As Integer = 0
            If TypeOf sender Is UcEnter.ComboBoxEnter Then
                intTab = CType(sender, UcEnter.ComboBoxEnter).TabIndex
                If CType(sender, UcEnter.ComboBoxEnter).SelectedValue & "" <> "" Then
                    NotEmptyField = True
                End If
            End If
            If NotEmptyField = True Then
                NotEmptyField = False
                SetCondition(intTab)
            End If
        End If
    End Sub

#End Region

#Region " Record Navigatioin "

    Private Sub cm_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If mStatus = WorkStates.Cancel Then
            If DvData.Count <= 1 Then
                BtnFirst.Enabled = False
                BtnPrev.Enabled = False
                BtnNext.Enabled = False
                BtnLast.Enabled = False
            Else
                If cm.Position = 0 Then
                    BtnFirst.Enabled = False
                    BtnPrev.Enabled = False
                    BtnNext.Enabled = True
                    BtnLast.Enabled = True
                    flgCmPosition = 1
                ElseIf cm.Position = DvData.Count - 1 Then
                    BtnFirst.Enabled = True
                    BtnPrev.Enabled = True
                    BtnNext.Enabled = False
                    BtnLast.Enabled = False
                    flgCmPosition = 2
                Else
                    BtnFirst.Enabled = True
                    BtnPrev.Enabled = True
                    BtnNext.Enabled = True
                    BtnLast.Enabled = True
                    flgCmPosition = 3
                End If
            End If
        End If
    End Sub

    Private Sub FirstRecord()
        cm.Position = 0
        FillObjects()
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click, BtnNext.DoubleClick
        NextRecord()
    End Sub

    Private Sub NextRecord()
        If cm.Position < DvData.Count - 1 Then
            cm.Position += 1
            FillObjects()
        End If
    End Sub

    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click, BtnPrev.DoubleClick
        PreviousRecord()
    End Sub

    Private Sub PreviousRecord()
        If cm.Position > 0 Then
            cm.Position -= 1
            FillObjects()
        End If
    End Sub

    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click, BtnLast.DoubleClick
        LastRecord()
    End Sub

    Private Sub LastRecord()
        cm.Position = DvData.Count - 1
        FillObjects()
    End Sub

    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click, BtnFirst.DoubleClick
        FirstRecord()
    End Sub

#End Region

#Region " Add , Edit , Save , Delete , Cancel "

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click, BtnNew.DoubleClick
        BtnNew.Enabled = False
        BtnEdit.Enabled = False
        BtnFirst.Enabled = False
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnLast.Enabled = False
        BtnGrid.Enabled = False
        BtnDelete.Enabled = False
        BtnCancel.Enabled = True
        BtnSave.Enabled = True
        pNew()
    End Sub

    Private Sub pNew()
        mStatus = WorkStates.AddNew
        ClearObjects()
        If bAutoNumber = True Then
            If TypeOf obj(0) Is UcEnter.IntegerUpDownEnter Then
                DvData.Sort = DV(0).Item("Fieldname") & " Desc"
                If DvData.Count = 0 Then
                    CType(obj(0), UcEnter.IntegerUpDownEnter).Value = 1
                Else
                    CType(obj(0), UcEnter.IntegerUpDownEnter).Value = Val(DvData(0).Item(DV(0).Item("Fieldname"))) + 1
                End If
            ElseIf TypeOf obj(0) Is UcEnter.NTextBox Then
                DvData.Sort = DV(0).Item("Fieldname") & " Desc"
                If DvData.Count = 0 Then
                    If DV(0).Item("FillZero") = True Then
                        CType(obj(0), UcEnter.NTextBox).Text = Getcod("1", CType(obj(0), UcEnter.NTextBox).MaxLength)
                    Else
                        CType(obj(0), UcEnter.NTextBox).Text = "1"
                    End If
                Else
                    If DV(0).Item("FillZero") = True Then
                        CType(obj(0), UcEnter.NTextBox).Text = Getcod(Val(DvData(0).Item(DV(0).Item("Fieldname"))) + 1, CType(obj(0), UcEnter.NTextBox).MaxLength)
                    Else
                        CType(obj(0), UcEnter.NTextBox).Text = Val(DvData(0).Item(DV(0).Item("Fieldname"))) + 1
                    End If
                End If
            ElseIf TypeOf obj(1) Is UcEnter.IntegerUpDownEnter Then
                DvData.Sort = DV(0).Item("Fieldname") & "," & DV(1).Item("Fieldname") & " Desc"
                If DvData.Count = 0 Then
                    CType(obj(1), UcEnter.IntegerUpDownEnter).Value = 1
                Else
                    CType(obj(1), UcEnter.IntegerUpDownEnter).Value = Val(DvData(0).Item(DV(1).Item("Fieldname"))) + 1
                End If
            ElseIf TypeOf obj(1) Is UcEnter.NTextBox Then
                DvData.Sort = DV(0).Item("Fieldname") & "," & DV(1).Item("Fieldname") & " Desc"
                If DvData.Count = 0 Then
                    If DV(1).Item("FillZero") = True Then
                        CType(obj(1), UcEnter.NTextBox).Text = Getcod("1", CType(obj(1), UcEnter.NTextBox).MaxLength)
                    Else
                        CType(obj(1), UcEnter.NTextBox).Text = 1
                    End If
                Else
                    If DV(1).Item("FillZero") = True Then
                        CType(obj(1), UcEnter.NTextBox).Text = Getcod(Val(DvData(0).Item(DV(1).Item("Fieldname"))) + 1, CType(obj(1), UcEnter.NTextBox).MaxLength)
                    Else
                        CType(obj(1), UcEnter.NTextBox).Text = Val(DvData(0).Item(DV(1).Item("Fieldname"))) + 1
                    End If
                End If
            End If
            DvData.Sort = ""
        End If
        EnableObjects(True)
        i = 0
        For i = 0 To DV.Count - 1
            If DV(i).Item("Enable") = True Then
                obj(i).focus()
                Exit For
            End If
        Next
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click, BtnSave.DoubleClick
        If mStatus = WorkStates.AddNew Or mStatus = WorkStates.Edit Then
            If mStatus = WorkStates.AddNew Then
                Dim strInsert As String = "Insert into " & DV(0).Item("FrmTable") & " ("
                i = 0
                For i = 0 To DV.Count - 1
                    If DV(i).Item("FieldObjectType") <> "Picture" Then
                        If i = 0 Then
                            strInsert = strInsert & DV(i).Item("Fieldname")
                        Else
                            strInsert = strInsert & "," & DV(i).Item("Fieldname")
                        End If
                    End If
                Next
                strInsert = strInsert & ") VALUES ("
                Dim bAutoNum As Boolean = False
                Dim intRes As Integer = 0
                Do
                    If bAutoNumber = True Then
                        If cmdGeneral.Connection.State = ConnectionState.Closed Then
                            cmdGeneral.Connection.Open()
                        End If
                        SetOldValue()
                        cmdGeneral.CommandText = "Select Count(*) from " & DV(0).Item("FrmTable") & " Where " & setPkCondition()
                        intRes = cmdGeneral.ExecuteScalar
                        If intRes <> 0 Then
                            If TypeOf obj(0) Is UcEnter.IntegerUpDownEnter Then
                                CType(obj(0), UcEnter.IntegerUpDownEnter).Value = CType(obj(0), UcEnter.IntegerUpDownEnter).Value + 1
                            ElseIf TypeOf obj(0) Is UcEnter.NTextBox Then
                                CType(obj(0), UcEnter.NTextBox).Text = Val(CType(obj(0), UcEnter.NTextBox).Text) + 1
                            ElseIf TypeOf obj(1) Is UcEnter.IntegerUpDownEnter Then
                                CType(obj(1), UcEnter.IntegerUpDownEnter).Value = CType(obj(1), UcEnter.IntegerUpDownEnter).Value + 1
                            ElseIf TypeOf obj(1) Is UcEnter.NTextBox Then
                                CType(obj(1), UcEnter.NTextBox).Text = Val(CType(obj(1), UcEnter.NTextBox).Text) + 1
                            End If
                            bAutoNum = True
                        End If
                    End If
                Loop Until intRes = 0
                i = 0
                For i = 0 To DV.Count - 1
                    If DV(i).Item("FieldObjectType") <> "Picture" Then
                        If i = 0 Then
                            strInsert = strInsert & ReternObjValue(obj(i), i)
                        Else
                            strInsert = strInsert & "," & ReternObjValue(obj(i), i)
                        End If
                    End If
                Next
                strInsert = strInsert & ")"
                If cmdGeneral.Connection.State = ConnectionState.Closed Then
                    cmdGeneral.Connection.Open()
                End If
                cmdGeneral.CommandText = strInsert
                Try
                    cmdGeneral.ExecuteNonQuery()
                    SetOldValue()
                    i = 0
                    For i = 0 To DV.Count - 1
                        If DV(i).Item("FieldObjectType") = "Picture" Then
                            CType(obj(i), UCPicture.PictureButton).SavePicture(cmdGeneral.Connection, DV(i).Item("FrmTable"), DV(i).Item("Fieldname"), " Where " & setPkCondition())
                        End If
                    Next
                    If bAutoNumber = True And bAutoNum = True Then
                        If TypeOf obj(0) Is UcEnter.IntegerUpDownEnter Then
                            If Me.Language = Language.English Then
                                MsgFar("This record registerd by this number " & CType(obj(0), UcEnter.IntegerUpDownEnter).Value)
                            Else
                                MsgFar("This record registerd by this number " & CType(obj(0), UcEnter.IntegerUpDownEnter).Value)
                            End If
                        ElseIf TypeOf obj(0) Is UcEnter.NTextBox Then
                            If Me.Language = Language.English Then
                                MsgFar("This record registerd by this number " & CType(obj(0), UcEnter.NTextBox).Text)
                            Else
                                MsgFar("This record registerd by this number " & CType(obj(0), UcEnter.NTextBox).Text)
                            End If
                        ElseIf TypeOf obj(1) Is UcEnter.IntegerUpDownEnter Then
                            If Me.Language = Language.English Then
                                MsgFar("This record registerd by this number " & CType(obj(1), UcEnter.IntegerUpDownEnter).Value)
                            Else
                                MsgFar("This record registerd by this number " & CType(obj(1), UcEnter.IntegerUpDownEnter).Value)
                            End If
                        ElseIf TypeOf obj(1) Is UcEnter.NTextBox Then
                            If Me.Language = Language.English Then
                                MsgFar("This record registerd by this number " & CType(obj(1), UcEnter.NTextBox).Text)
                            Else
                                MsgFar("This record registerd by this number " & CType(obj(1), UcEnter.NTextBox).Text)
                            End If
                        End If
                    End If
                    DsData.Tables(DV(0).Item("FrmTable")).Clear()
                    FillData()
                    pNew()
                Catch ex As Exception
                    If Me.Language = Language.English Then
                        MsgFar("An error occorded in save ")
                    Else
                        MsgFar("Œÿ« œ— –ŒÌ—Â «ÿ·«⁄« ")
                    End If
                End Try
                'DsData.Tables(DV(0).Item("FrmTable")).Clear()
                'FillData()
                'pNew()
            ElseIf mStatus = WorkStates.Edit Then
                    Dim strUpdate As String = "Update " & DV(0).Item("FrmTable") & " SET "
                    i = 0
                    For i = 0 To DV.Count - 1
                        If DV(i).Item("FieldObjectType") <> "Picture" Then
                            If i = 0 Then
                                strUpdate = strUpdate & DV(i).Item("Fieldname") & " = " & ReternObjValue(obj(i), i)
                            Else
                                strUpdate = strUpdate & " , " & DV(i).Item("Fieldname") & " = " & ReternObjValue(obj(i), i)
                            End If
                        End If
                    Next
                    strUpdate = strUpdate & " WHERE " & setPkCondition()
                    If cmdGeneral.Connection.State = ConnectionState.Closed Then
                        cmdGeneral.Connection.Open()
                    End If
                    cmdGeneral.CommandText = strUpdate
                    Try
                        cmdGeneral.ExecuteNonQuery()
                        i = 0
                        For i = 0 To DV.Count - 1
                            If DV(i).Item("FieldObjectType") = "Picture" Then
                                CType(obj(i), UCPicture.PictureButton).SavePicture(cmdGeneral.Connection, DV(i).Item("FrmTable"), DV(i).Item("Fieldname"), " Where " & setPkCondition())
                            End If
                        Next
                    Catch ex As Exception
                    If Me.Language = Language.English Then
                        MsgFar("An error occorded in save ")
                    Else
                        MsgFar("Œÿ« œ— –ŒÌ—Â «ÿ·«⁄« ")
                    End If
                    End Try
                    DsData.Tables(DV(0).Item("FrmTable")).Clear()
                    FillData()
                    pCancle()
            End If
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click, BtnEdit.DoubleClick
        BtnNew.Enabled = False
        BtnEdit.Enabled = False
        BtnFirst.Enabled = False
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnLast.Enabled = False
        BtnGrid.Enabled = False
        BtnDelete.Enabled = False
        BtnSave.Enabled = True
        BtnCancel.Enabled = True
        pEdit()
    End Sub

    Private Sub pEdit()
        mStatus = WorkStates.Edit
        SetOldValue()
        EnableObjects(True)
        i = 0
        For i = 0 To DV.Count - 1
            If DV(i).Item("UpdateDisabled") = False And DV(i).Item("Enable") = True Then
                obj(i).focus()
                Exit For
            End If
        Next
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click, BtnDelete.DoubleClick
        pos = cm.Position
        Dim MyClassWhatDo As New ClassWhatDo
        If Me.Language = Language.English Then
            MyClassWhatDo.ShowMsg("Are you sure ?")
        Else
            MyClassWhatDo.ShowMsg("¬Ì« „ÿ„∆‰ Â” Ìœ ø")
        End If
        If MyClassWhatDo.Result = DialogResult.OK Then
            SetOldValue()
            Dim strDelete As String = "Delete " & DV(0).Item("FrmTable")
            strDelete = strDelete & " WHERE " & setPkCondition()
            If cmdGeneral.Connection.State = ConnectionState.Closed Then
                cmdGeneral.Connection.Open()
            End If
            cmdGeneral.CommandText = strDelete
            Try
                cmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
                If Me.Language = Language.English Then
                    'MsgFar("An error occorded in Delete ")
                    MsgFar("Because of existence of transactions or " & vbCrLf & " its usage in another form in the database " & vbCrLf & " deletion of this record is not allowded.")
                Else
                    MsgFar("Œÿ« œ— Õ–› «ÿ·«⁄« ")
                End If
            End Try
            pCancle()
            DsData.Tables(DV(0).Item("FrmTable")).Clear()
            FillData()
            cm.Position = IIf(pos - 1 < 0, 0, pos - 1)
            ClearObjects()
            FillObjects()
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click, BtnCancel.DoubleClick
        pCancle()
    End Sub

    Private Sub pCancle()
        mStatus = WorkStates.Cancel
        If DV(0).Item("FlgNew") = True Then
            BtnNew.Enabled = False
        Else
            BtnNew.Enabled = True
        End If
        If Me.AllowEdit = True Then
            BtnEdit.Enabled = True
        Else
            BtnEdit.Enabled = False
        End If
        If DV(0).Item("FlgDel") = True Then
            BtnDelete.Enabled = False
        Else
            BtnDelete.Enabled = True
        End If
        If DvData.Count = 0 Then
            BtnNew.Enabled = True
            BtnEdit.Enabled = False
            BtnDelete.Enabled = False
            BtnCancel.Enabled = False
            BtnFirst.Enabled = False
            BtnPrev.Enabled = False
            BtnNext.Enabled = False
            BtnLast.Enabled = False
            BtnGrid.Enabled = False
            BtnSave.Enabled = False
        ElseIf DvData.Count = 1 Then
            BtnNew.Enabled = True
            BtnEdit.Enabled = True
            BtnDelete.Enabled = True
            BtnCancel.Enabled = False
            BtnFirst.Enabled = False
            BtnPrev.Enabled = False
            BtnNext.Enabled = False
            BtnLast.Enabled = False
            BtnGrid.Enabled = True
            BtnSave.Enabled = False
        Else
            Select Case flgCmPosition
                Case 1
                    BtnFirst.Enabled = False
                    BtnPrev.Enabled = False
                    BtnNext.Enabled = True
                    BtnLast.Enabled = True
                Case 2
                    BtnFirst.Enabled = True
                    BtnPrev.Enabled = True
                    BtnNext.Enabled = False
                    BtnLast.Enabled = False
                Case Else
                    BtnFirst.Enabled = True
                    BtnPrev.Enabled = True
                    BtnNext.Enabled = True
                    BtnLast.Enabled = True
            End Select
            BtnGrid.Enabled = True
            BtnSave.Enabled = False
            BtnCancel.Enabled = False
        End If
        EnableObjects(False)
        If mStatus = WorkStates.Edit Or mStatus = WorkStates.Delete Then
            FillObjects()
        Else
            LastRecord()
            FillObjects()
        End If
        mStatus = WorkStates.Cancel
    End Sub

#End Region

    Private Sub FrmGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Language = planguage
        'Cnn.ConnectionString = PConnectionString
        'If Me.Language = Language.Persian Then
        '    Me.RightToLeft = RightToLeft.Yes
        'Else
        '    Me.RightToLeft = RightToLeft.No
        'End If
        'setTextObject(Me.Language)
        'FillData()
        'CreateObjectOnForm()
        mStatus = WorkStates.Cancel
        pCancle()
    End Sub

    Private Sub SetOptionForm(ByVal Thislanguage As Language)
        'If Thislanguage = Language.Persian Then
        '    Me.RightToLeft = RightToLeft.Yes
        'Else
        '    Me.RightToLeft = RightToLeft.No
        'End If
        Me.Text = DV(0).Item("FrmCaption")
        Me.Width = DV(0).Item("FrmWidth")
        Me.Height = DV(0).Item("FrmHeight")
        Me.Label1.Text = DV(0).Item("FrmDesc")

        Try
            Dim Thispicture() As Byte
            Thispicture = DV(0).Item("FrmPicture")
            Dim MyPicStream As New MemoryStream(Thispicture)
            PictureBox1.Image = Image.FromStream(MyPicStream)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
            PictureBox1.Image = Nothing
        End Try

    End Sub

    Private Sub setTextObject(ByVal ThisLanguage As Language)
        If ThisLanguage = Language.Persian Then
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblNew.Text = "ÃœÌœ"
            LblEdit.Text = "«’·«Õ"
            LblDelete.Text = "Õ–›"
            LblCancel.Text = "·€Ê"
            LblSave.Text = "–ŒÌ—Â"
            LblFirst.Text = "«» œ«"
            LblPrev.Text = "ﬁ»·Ì"
            LblNext.Text = "»⁄œÌ"
            LblLast.Text = "«‰ Â«"
            LblGrid.Text = "ÃœÊ·Ì"

            LblNew.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblEdit.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblDelete.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblCancel.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblSave.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblFirst.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblPrev.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblNext.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblLast.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblGrid.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Else
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblNew.Text = "New"
            LblEdit.Text = "Edit"
            LblDelete.Text = "Delete"
            LblCancel.Text = "Cancel"
            LblSave.Text = "Save"
            LblFirst.Text = "First"
            LblPrev.Text = "Previous"
            LblNext.Text = "Next"
            LblLast.Text = "Last"
            LblGrid.Text = "Table"

            LblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            LblGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        End If
    End Sub

    Private Sub FillAccessData()
        Try
            AccessDa.SelectCommand.CommandText = " SELECT FrmBase.FrmName, FrmBase.FrmHeight, FrmBase.FrmFilter, FrmBase.FrmDesc, FrmBase.FrmCaption, FrmBase.FrmPicture, FrmBase.FrmTable, FrmBase.FrmWidth, FrmBase.FlgNew,FrmBase.FlgDel," & _
               "BaseTable.CMBFilterOnFieldIndex,BaseTable.CMBFilterOnFieldProperty ,BaseTable.CMBFilterFromFieldProperty,BaseTable.CMBFilterOnFieldIndex1,BaseTable.CMBFilterOnFieldProperty1 ,BaseTable.CMBFilterFromFieldProperty1,BaseTable.CMBDisplayName, BaseTable.CMBStatic, BaseTable.CMBTableName, BaseTable.CMBValueName, BaseTable.DefaultValue, BaseTable.Enable, BaseTable.Fieldcaption, BaseTable.Fieldheight," & _
               "BaseTable.FieldLocationX, BaseTable.FieldLocationY, BaseTable.Fieldname, BaseTable.FieldObjectType, BaseTable.Fieldwidth, BaseTable.FillZero, BaseTable.IsMandatory, BaseTable.Isprimary," & _
               "BaseTable.MaxLength, BaseTable.NoDecimal, BaseTable.prime, BaseTable.TabIndex, BaseTable.UpdateDisabled FROM (BaseTable INNER JOIN FrmBase ON BaseTable.FrmName = FrmBase.FrmName) " & _
               "WHERE FrmBase.FrmName = " & Qt(Me.FrmName)
            AccessDa.Fill(DsAccess1.BaseTable)
        Catch ex As Exception

        End Try
        DV = DsAccess1.BaseTable.DefaultView
        DV.Sort = "tabindex asc"
    End Sub

    Private Sub FillData()
        Dim strSelect As String = ""
        cmdGeneral.Connection = Cnn
        If cmdGeneral.Connection.State = ConnectionState.Closed Then
            cmdGeneral.Connection.Open()
        End If
        i = 0
        For i = 0 To DV.Count - 1
            If i = DV.Count - 1 Then
                strSelect = strSelect & DV(i).Item("FieldName")
            Else
                strSelect = strSelect & DV(i).Item("FieldName") & ","
            End If
        Next
        If DV(0).Item("FrmFilter") & "" = "" Then
            cmdGeneral.CommandText = "SELECT " & strSelect & " From " & DV(0).Item("FrmTable")
        Else
            cmdGeneral.CommandText = "SELECT " & strSelect & " From " & DV(0).Item("FrmTable") & " Where " & DV(0).Item("FrmFilter")
        End If

        DaData.SelectCommand = cmdGeneral
        DaData.Fill(DsData, DV(0).Item("FrmTable"))
        i = 0
        Dim j As Integer = 0
        For i = 0 To DV.Count - 1
            If DV(i).Item("Isprimary") = True Then
                j = j + 1
            End If
        Next
        i = 0
        Dim keys(j) As DataColumn
        Dim k As Integer = 0
        Dim myColumn As DataColumn
        For i = 0 To DV.Count - 1
            If DV(i).Item("Isprimary") = True Then
                myColumn = DsData.Tables(DV(i).Item("FrmTable")).Columns(i)
                keys(k) = myColumn
                k = k + 1
            End If
        Next
        DsData.Tables(DV(0).Item("FrmTable")).PrimaryKey = keys
        DvData = DsData.Tables(DV(0).Item("FrmTable")).DefaultView

        If Me.SortString <> "" Then
            DvData.Sort = Me.SortString
        End If
        cm = CType(Me.BindingContext(DvData), CurrencyManager)
        AddHandler Me.cm.PositionChanged, New EventHandler(AddressOf Me.cm_PositionChanged)
        cmdGeneral.Connection.Close()
    End Sub

    Private Sub MyObjEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        MyObjTabIndex = CType(sender, Control).TabIndex
    End Sub

    Private Function GetControlFromName(ByVal ContainerObj As Object, ByVal Name As String)
        Dim TempCtrl As Control
        For Each TempCtrl In ContainerObj.controls
            If TempCtrl.Name.ToUpper.Trim = Name.ToUpper.Trim Then
                Return TempCtrl
            End If
        Next TempCtrl
    End Function

    Private Sub NotFindTextUcObject()
        Dim Lbl As Label = CType(GetControlFromName(Me, "l" & Str(MyObjTabIndex).Trim), Label)
        Lbl.Text = ""
    End Sub

    Private Function SetMeValue(ByVal Myobj As Object, ByVal ThisPropertyName As String, ByVal ThisPropertyValye As String)
        Dim t As Type
        t = Myobj.GetType
        t.GetProperty(ThisPropertyName).SetValue(Myobj, ThisPropertyValye, Nothing)
    End Function

    Function GiveMeValue(ByVal Myobj As Object, ByVal ThisPropertyName As String) As Object
        Dim t As Type
        t = Myobj.GetType
        GiveMeValue = t.GetProperty(ThisPropertyName).GetValue(Myobj, Nothing)
    End Function

    Private Sub TextBoxLeaveHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        CType(sender, UcEnter.TextBoxEnter).Text = Getcod(CType(sender, UcEnter.TextBoxEnter).Text.Trim, CType(sender, UcEnter.TextBoxEnter).MaxLength)
    End Sub

    Private Sub NTextBoxLeaveHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        CType(sender, UcEnter.NTextBox).Text = Getcod(CType(sender, UcEnter.NTextBox).Text.Trim, CType(sender, UcEnter.NTextBox).MaxLength)
    End Sub

    Private Sub BtnGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrid.Click, BtnGrid.DoubleClick
        Dim frm As FrmTableView
        If Me.Language = Language.English Then
            frm = New FrmTableView("en")
            frm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Else
            frm = New FrmTableView("fa-IR")
            frm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        End If
        frm.DvAccess = DV
        frm.DVTable = DvData
        frm.FrmTable = Me
        frm.ShowDialog()
        DvData.Sort = Me.SortString
        cm.Position = intPos
        FillObjects()
    End Sub

    Private Function setPkCondition() As String
        Dim strPk As String = ""
        i = 0
        For i = 0 To DV.Count - 1
            If DV(i).Item("Isprimary") Then
                If strPk = "" Then
                    If DV(i).Item("FieldObjectType") = "NumericBox" Then
                        strPk = DV(i).Item("Fieldname") & " = " & objValue(i)
                    Else
                        strPk = DV(i).Item("Fieldname") & " = " & Qt(objValue(i))
                    End If
                Else
                    If DV(i).Item("FieldObjectType") = "NumericBox" Then
                        strPk = strPk & " AND " & DV(i).Item("Fieldname") & " = " & objValue(i)
                    Else
                        strPk = strPk & " AND " & DV(i).Item("Fieldname") & " = " & Qt(objValue(i))
                    End If
                End If
            End If
        Next
        Return strPk
    End Function

    Private Sub FrmGeneral_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.HandleCreated
        'Me.Language = planguage
        'setTextObject(Me.Language)
        'AccessCnn.ConnectionString = PConnectionStringForGenerator
        'FillAccessData()
        'SetOptionForm(Me.Language)
    End Sub
End Class
