﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.573
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class DSFrmVendorCredit
    Inherits DataSet
    
    Private tableGL_vendor_credit As GL_vendor_creditDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("GL_vendor_credit")) Is Nothing) Then
                Me.Tables.Add(New GL_vendor_creditDataTable(ds.Tables("GL_vendor_credit")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property GL_vendor_credit As GL_vendor_creditDataTable
        Get
            Return Me.tableGL_vendor_credit
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DSFrmVendorCredit = CType(MyBase.Clone,DSFrmVendorCredit)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("GL_vendor_credit")) Is Nothing) Then
            Me.Tables.Add(New GL_vendor_creditDataTable(ds.Tables("GL_vendor_credit")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableGL_vendor_credit = CType(Me.Tables("GL_vendor_credit"),GL_vendor_creditDataTable)
        If (Not (Me.tableGL_vendor_credit) Is Nothing) Then
            Me.tableGL_vendor_credit.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DSFrmVendorCredit"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DSFrmVendorCredit.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableGL_vendor_credit = New GL_vendor_creditDataTable
        Me.Tables.Add(Me.tableGL_vendor_credit)
    End Sub
    
    Private Function ShouldSerializeGL_vendor_credit() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub GL_vendor_creditRowChangeEventHandler(ByVal sender As Object, ByVal e As GL_vendor_creditRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class GL_vendor_creditDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnid_vendor_credit As DataColumn
        
        Private columncod_vendor As DataColumn
        
        Private columndate_credit As DataColumn
        
        Private columnamount_credit As DataColumn
        
        Private columnRemark As DataColumn
        
        Private columnRef_No As DataColumn
        
        Private columnDue_Date As DataColumn
        
        Private columnGL_vendor_credit As DataColumn
        
        Private columnid_receive_ref As DataColumn
        
        Friend Sub New()
            MyBase.New("GL_vendor_credit")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property id_vendor_creditColumn As DataColumn
            Get
                Return Me.columnid_vendor_credit
            End Get
        End Property
        
        Friend ReadOnly Property cod_vendorColumn As DataColumn
            Get
                Return Me.columncod_vendor
            End Get
        End Property
        
        Friend ReadOnly Property date_creditColumn As DataColumn
            Get
                Return Me.columndate_credit
            End Get
        End Property
        
        Friend ReadOnly Property amount_creditColumn As DataColumn
            Get
                Return Me.columnamount_credit
            End Get
        End Property
        
        Friend ReadOnly Property RemarkColumn As DataColumn
            Get
                Return Me.columnRemark
            End Get
        End Property
        
        Friend ReadOnly Property Ref_NoColumn As DataColumn
            Get
                Return Me.columnRef_No
            End Get
        End Property
        
        Friend ReadOnly Property Due_DateColumn As DataColumn
            Get
                Return Me.columnDue_Date
            End Get
        End Property
        
        Friend ReadOnly Property GL_vendor_creditColumn As DataColumn
            Get
                Return Me.columnGL_vendor_credit
            End Get
        End Property
        
        Friend ReadOnly Property id_receive_refColumn As DataColumn
            Get
                Return Me.columnid_receive_ref
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As GL_vendor_creditRow
            Get
                Return CType(Me.Rows(index),GL_vendor_creditRow)
            End Get
        End Property
        
        Public Event GL_vendor_creditRowChanged As GL_vendor_creditRowChangeEventHandler
        
        Public Event GL_vendor_creditRowChanging As GL_vendor_creditRowChangeEventHandler
        
        Public Event GL_vendor_creditRowDeleted As GL_vendor_creditRowChangeEventHandler
        
        Public Event GL_vendor_creditRowDeleting As GL_vendor_creditRowChangeEventHandler
        
        Public Overloads Sub AddGL_vendor_creditRow(ByVal row As GL_vendor_creditRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddGL_vendor_creditRow(ByVal cod_vendor As String, ByVal date_credit As String, ByVal amount_credit As Decimal, ByVal Remark As String, ByVal Ref_No As String, ByVal Due_Date As String, ByVal GL_vendor_credit As String, ByVal id_receive_ref As String) As GL_vendor_creditRow
            Dim rowGL_vendor_creditRow As GL_vendor_creditRow = CType(Me.NewRow,GL_vendor_creditRow)
            rowGL_vendor_creditRow.ItemArray = New Object() {Nothing, cod_vendor, date_credit, amount_credit, Remark, Ref_No, Due_Date, GL_vendor_credit, id_receive_ref}
            Me.Rows.Add(rowGL_vendor_creditRow)
            Return rowGL_vendor_creditRow
        End Function
        
        Public Function FindByid_vendor_credit(ByVal id_vendor_credit As Integer) As GL_vendor_creditRow
            Return CType(Me.Rows.Find(New Object() {id_vendor_credit}),GL_vendor_creditRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As GL_vendor_creditDataTable = CType(MyBase.Clone,GL_vendor_creditDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New GL_vendor_creditDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnid_vendor_credit = Me.Columns("id_vendor_credit")
            Me.columncod_vendor = Me.Columns("cod_vendor")
            Me.columndate_credit = Me.Columns("date_credit")
            Me.columnamount_credit = Me.Columns("amount_credit")
            Me.columnRemark = Me.Columns("Remark")
            Me.columnRef_No = Me.Columns("Ref_No")
            Me.columnDue_Date = Me.Columns("Due_Date")
            Me.columnGL_vendor_credit = Me.Columns("GL_vendor_credit")
            Me.columnid_receive_ref = Me.Columns("id_receive_ref")
        End Sub
        
        Private Sub InitClass()
            Me.columnid_vendor_credit = New DataColumn("id_vendor_credit", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnid_vendor_credit)
            Me.columncod_vendor = New DataColumn("cod_vendor", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncod_vendor)
            Me.columndate_credit = New DataColumn("date_credit", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndate_credit)
            Me.columnamount_credit = New DataColumn("amount_credit", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnamount_credit)
            Me.columnRemark = New DataColumn("Remark", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRemark)
            Me.columnRef_No = New DataColumn("Ref_No", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRef_No)
            Me.columnDue_Date = New DataColumn("Due_Date", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDue_Date)
            Me.columnGL_vendor_credit = New DataColumn("GL_vendor_credit", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnGL_vendor_credit)
            Me.columnid_receive_ref = New DataColumn("id_receive_ref", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnid_receive_ref)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnid_vendor_credit}, true))
            Me.columnid_vendor_credit.AutoIncrement = true
            Me.columnid_vendor_credit.AllowDBNull = false
            Me.columnid_vendor_credit.ReadOnly = true
            Me.columnid_vendor_credit.Unique = true
            Me.columncod_vendor.AllowDBNull = false
        End Sub
        
        Public Function NewGL_vendor_creditRow() As GL_vendor_creditRow
            Return CType(Me.NewRow,GL_vendor_creditRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New GL_vendor_creditRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(GL_vendor_creditRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.GL_vendor_creditRowChangedEvent) Is Nothing) Then
                RaiseEvent GL_vendor_creditRowChanged(Me, New GL_vendor_creditRowChangeEvent(CType(e.Row,GL_vendor_creditRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.GL_vendor_creditRowChangingEvent) Is Nothing) Then
                RaiseEvent GL_vendor_creditRowChanging(Me, New GL_vendor_creditRowChangeEvent(CType(e.Row,GL_vendor_creditRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.GL_vendor_creditRowDeletedEvent) Is Nothing) Then
                RaiseEvent GL_vendor_creditRowDeleted(Me, New GL_vendor_creditRowChangeEvent(CType(e.Row,GL_vendor_creditRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.GL_vendor_creditRowDeletingEvent) Is Nothing) Then
                RaiseEvent GL_vendor_creditRowDeleting(Me, New GL_vendor_creditRowChangeEvent(CType(e.Row,GL_vendor_creditRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveGL_vendor_creditRow(ByVal row As GL_vendor_creditRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class GL_vendor_creditRow
        Inherits DataRow
        
        Private tableGL_vendor_credit As GL_vendor_creditDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableGL_vendor_credit = CType(Me.Table,GL_vendor_creditDataTable)
        End Sub
        
        Public Property id_vendor_credit As Integer
            Get
                Return CType(Me(Me.tableGL_vendor_credit.id_vendor_creditColumn),Integer)
            End Get
            Set
                Me(Me.tableGL_vendor_credit.id_vendor_creditColumn) = value
            End Set
        End Property
        
        Public Property cod_vendor As String
            Get
                Return CType(Me(Me.tableGL_vendor_credit.cod_vendorColumn),String)
            End Get
            Set
                Me(Me.tableGL_vendor_credit.cod_vendorColumn) = value
            End Set
        End Property
        
        Public Property date_credit As String
            Get
                Try 
                    Return CType(Me(Me.tableGL_vendor_credit.date_creditColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_vendor_credit.date_creditColumn) = value
            End Set
        End Property
        
        Public Property amount_credit As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableGL_vendor_credit.amount_creditColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_vendor_credit.amount_creditColumn) = value
            End Set
        End Property
        
        Public Property Remark As String
            Get
                Try 
                    Return CType(Me(Me.tableGL_vendor_credit.RemarkColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_vendor_credit.RemarkColumn) = value
            End Set
        End Property
        
        Public Property Ref_No As String
            Get
                Try 
                    Return CType(Me(Me.tableGL_vendor_credit.Ref_NoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_vendor_credit.Ref_NoColumn) = value
            End Set
        End Property
        
        Public Property Due_Date As String
            Get
                Try 
                    Return CType(Me(Me.tableGL_vendor_credit.Due_DateColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_vendor_credit.Due_DateColumn) = value
            End Set
        End Property
        
        Public Property GL_vendor_credit As String
            Get
                Try 
                    Return CType(Me(Me.tableGL_vendor_credit.GL_vendor_creditColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_vendor_credit.GL_vendor_creditColumn) = value
            End Set
        End Property
        
        Public Property id_receive_ref As String
            Get
                Try 
                    Return CType(Me(Me.tableGL_vendor_credit.id_receive_refColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_vendor_credit.id_receive_refColumn) = value
            End Set
        End Property
        
        Public Function Isdate_creditNull() As Boolean
            Return Me.IsNull(Me.tableGL_vendor_credit.date_creditColumn)
        End Function
        
        Public Sub Setdate_creditNull()
            Me(Me.tableGL_vendor_credit.date_creditColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isamount_creditNull() As Boolean
            Return Me.IsNull(Me.tableGL_vendor_credit.amount_creditColumn)
        End Function
        
        Public Sub Setamount_creditNull()
            Me(Me.tableGL_vendor_credit.amount_creditColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRemarkNull() As Boolean
            Return Me.IsNull(Me.tableGL_vendor_credit.RemarkColumn)
        End Function
        
        Public Sub SetRemarkNull()
            Me(Me.tableGL_vendor_credit.RemarkColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRef_NoNull() As Boolean
            Return Me.IsNull(Me.tableGL_vendor_credit.Ref_NoColumn)
        End Function
        
        Public Sub SetRef_NoNull()
            Me(Me.tableGL_vendor_credit.Ref_NoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDue_DateNull() As Boolean
            Return Me.IsNull(Me.tableGL_vendor_credit.Due_DateColumn)
        End Function
        
        Public Sub SetDue_DateNull()
            Me(Me.tableGL_vendor_credit.Due_DateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsGL_vendor_creditNull() As Boolean
            Return Me.IsNull(Me.tableGL_vendor_credit.GL_vendor_creditColumn)
        End Function
        
        Public Sub SetGL_vendor_creditNull()
            Me(Me.tableGL_vendor_credit.GL_vendor_creditColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isid_receive_refNull() As Boolean
            Return Me.IsNull(Me.tableGL_vendor_credit.id_receive_refColumn)
        End Function
        
        Public Sub Setid_receive_refNull()
            Me(Me.tableGL_vendor_credit.id_receive_refColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class GL_vendor_creditRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As GL_vendor_creditRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As GL_vendor_creditRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As GL_vendor_creditRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
