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
Public Class DSFrmRepLabortAndFees
    Inherits DataSet
    
    Private tableServices As ServicesDataTable
    
    Private tableCategories As CategoriesDataTable
    
    Private tableinv_tab_service_type As inv_tab_service_typeDataTable
    
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
            If (Not (ds.Tables("Services")) Is Nothing) Then
                Me.Tables.Add(New ServicesDataTable(ds.Tables("Services")))
            End If
            If (Not (ds.Tables("Categories")) Is Nothing) Then
                Me.Tables.Add(New CategoriesDataTable(ds.Tables("Categories")))
            End If
            If (Not (ds.Tables("inv_tab_service_type")) Is Nothing) Then
                Me.Tables.Add(New inv_tab_service_typeDataTable(ds.Tables("inv_tab_service_type")))
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
    Public ReadOnly Property Services As ServicesDataTable
        Get
            Return Me.tableServices
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Categories As CategoriesDataTable
        Get
            Return Me.tableCategories
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property inv_tab_service_type As inv_tab_service_typeDataTable
        Get
            Return Me.tableinv_tab_service_type
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DSFrmRepLabortAndFees = CType(MyBase.Clone,DSFrmRepLabortAndFees)
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
        If (Not (ds.Tables("Services")) Is Nothing) Then
            Me.Tables.Add(New ServicesDataTable(ds.Tables("Services")))
        End If
        If (Not (ds.Tables("Categories")) Is Nothing) Then
            Me.Tables.Add(New CategoriesDataTable(ds.Tables("Categories")))
        End If
        If (Not (ds.Tables("inv_tab_service_type")) Is Nothing) Then
            Me.Tables.Add(New inv_tab_service_typeDataTable(ds.Tables("inv_tab_service_type")))
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
        Me.tableServices = CType(Me.Tables("Services"),ServicesDataTable)
        If (Not (Me.tableServices) Is Nothing) Then
            Me.tableServices.InitVars
        End If
        Me.tableCategories = CType(Me.Tables("Categories"),CategoriesDataTable)
        If (Not (Me.tableCategories) Is Nothing) Then
            Me.tableCategories.InitVars
        End If
        Me.tableinv_tab_service_type = CType(Me.Tables("inv_tab_service_type"),inv_tab_service_typeDataTable)
        If (Not (Me.tableinv_tab_service_type) Is Nothing) Then
            Me.tableinv_tab_service_type.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DSFrmRepLabortAndFees"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DSFrmRepLabortAndFees.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableServices = New ServicesDataTable
        Me.Tables.Add(Me.tableServices)
        Me.tableCategories = New CategoriesDataTable
        Me.Tables.Add(Me.tableCategories)
        Me.tableinv_tab_service_type = New inv_tab_service_typeDataTable
        Me.Tables.Add(Me.tableinv_tab_service_type)
    End Sub
    
    Private Function ShouldSerializeServices() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeCategories() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeinv_tab_service_type() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub ServicesRowChangeEventHandler(ByVal sender As Object, ByVal e As ServicesRowChangeEvent)
    
    Public Delegate Sub CategoriesRowChangeEventHandler(ByVal sender As Object, ByVal e As CategoriesRowChangeEvent)
    
    Public Delegate Sub inv_tab_service_typeRowChangeEventHandler(ByVal sender As Object, ByVal e As inv_tab_service_typeRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ServicesDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnflag As DataColumn
        
        Private columncode As DataColumn
        
        Private columnname As DataColumn
        
        Friend Sub New()
            MyBase.New("Services")
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
        
        Friend ReadOnly Property flagColumn As DataColumn
            Get
                Return Me.columnflag
            End Get
        End Property
        
        Friend ReadOnly Property codeColumn As DataColumn
            Get
                Return Me.columncode
            End Get
        End Property
        
        Friend ReadOnly Property nameColumn As DataColumn
            Get
                Return Me.columnname
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As ServicesRow
            Get
                Return CType(Me.Rows(index),ServicesRow)
            End Get
        End Property
        
        Public Event ServicesRowChanged As ServicesRowChangeEventHandler
        
        Public Event ServicesRowChanging As ServicesRowChangeEventHandler
        
        Public Event ServicesRowDeleted As ServicesRowChangeEventHandler
        
        Public Event ServicesRowDeleting As ServicesRowChangeEventHandler
        
        Public Overloads Sub AddServicesRow(ByVal row As ServicesRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddServicesRow(ByVal flag As Boolean, ByVal code As String, ByVal name As String) As ServicesRow
            Dim rowServicesRow As ServicesRow = CType(Me.NewRow,ServicesRow)
            rowServicesRow.ItemArray = New Object() {flag, code, name}
            Me.Rows.Add(rowServicesRow)
            Return rowServicesRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As ServicesDataTable = CType(MyBase.Clone,ServicesDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New ServicesDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnflag = Me.Columns("flag")
            Me.columncode = Me.Columns("code")
            Me.columnname = Me.Columns("name")
        End Sub
        
        Private Sub InitClass()
            Me.columnflag = New DataColumn("flag", GetType(System.Boolean), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnflag)
            Me.columncode = New DataColumn("code", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncode)
            Me.columnname = New DataColumn("name", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnname)
        End Sub
        
        Public Function NewServicesRow() As ServicesRow
            Return CType(Me.NewRow,ServicesRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New ServicesRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(ServicesRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ServicesRowChangedEvent) Is Nothing) Then
                RaiseEvent ServicesRowChanged(Me, New ServicesRowChangeEvent(CType(e.Row,ServicesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ServicesRowChangingEvent) Is Nothing) Then
                RaiseEvent ServicesRowChanging(Me, New ServicesRowChangeEvent(CType(e.Row,ServicesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ServicesRowDeletedEvent) Is Nothing) Then
                RaiseEvent ServicesRowDeleted(Me, New ServicesRowChangeEvent(CType(e.Row,ServicesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ServicesRowDeletingEvent) Is Nothing) Then
                RaiseEvent ServicesRowDeleting(Me, New ServicesRowChangeEvent(CType(e.Row,ServicesRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveServicesRow(ByVal row As ServicesRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ServicesRow
        Inherits DataRow
        
        Private tableServices As ServicesDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableServices = CType(Me.Table,ServicesDataTable)
        End Sub
        
        Public Property flag As Boolean
            Get
                Try 
                    Return CType(Me(Me.tableServices.flagColumn),Boolean)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableServices.flagColumn) = value
            End Set
        End Property
        
        Public Property code As String
            Get
                Try 
                    Return CType(Me(Me.tableServices.codeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableServices.codeColumn) = value
            End Set
        End Property
        
        Public Property name As String
            Get
                Try 
                    Return CType(Me(Me.tableServices.nameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableServices.nameColumn) = value
            End Set
        End Property
        
        Public Function IsflagNull() As Boolean
            Return Me.IsNull(Me.tableServices.flagColumn)
        End Function
        
        Public Sub SetflagNull()
            Me(Me.tableServices.flagColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IscodeNull() As Boolean
            Return Me.IsNull(Me.tableServices.codeColumn)
        End Function
        
        Public Sub SetcodeNull()
            Me(Me.tableServices.codeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsnameNull() As Boolean
            Return Me.IsNull(Me.tableServices.nameColumn)
        End Function
        
        Public Sub SetnameNull()
            Me(Me.tableServices.nameColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ServicesRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As ServicesRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As ServicesRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As ServicesRow
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
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CategoriesDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnflag As DataColumn
        
        Private columncode As DataColumn
        
        Private columnname As DataColumn
        
        Friend Sub New()
            MyBase.New("Categories")
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
        
        Friend ReadOnly Property flagColumn As DataColumn
            Get
                Return Me.columnflag
            End Get
        End Property
        
        Friend ReadOnly Property codeColumn As DataColumn
            Get
                Return Me.columncode
            End Get
        End Property
        
        Friend ReadOnly Property nameColumn As DataColumn
            Get
                Return Me.columnname
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As CategoriesRow
            Get
                Return CType(Me.Rows(index),CategoriesRow)
            End Get
        End Property
        
        Public Event CategoriesRowChanged As CategoriesRowChangeEventHandler
        
        Public Event CategoriesRowChanging As CategoriesRowChangeEventHandler
        
        Public Event CategoriesRowDeleted As CategoriesRowChangeEventHandler
        
        Public Event CategoriesRowDeleting As CategoriesRowChangeEventHandler
        
        Public Overloads Sub AddCategoriesRow(ByVal row As CategoriesRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddCategoriesRow(ByVal flag As Boolean, ByVal code As String, ByVal name As String) As CategoriesRow
            Dim rowCategoriesRow As CategoriesRow = CType(Me.NewRow,CategoriesRow)
            rowCategoriesRow.ItemArray = New Object() {flag, code, name}
            Me.Rows.Add(rowCategoriesRow)
            Return rowCategoriesRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As CategoriesDataTable = CType(MyBase.Clone,CategoriesDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New CategoriesDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnflag = Me.Columns("flag")
            Me.columncode = Me.Columns("code")
            Me.columnname = Me.Columns("name")
        End Sub
        
        Private Sub InitClass()
            Me.columnflag = New DataColumn("flag", GetType(System.Boolean), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnflag)
            Me.columncode = New DataColumn("code", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncode)
            Me.columnname = New DataColumn("name", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnname)
        End Sub
        
        Public Function NewCategoriesRow() As CategoriesRow
            Return CType(Me.NewRow,CategoriesRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New CategoriesRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(CategoriesRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.CategoriesRowChangedEvent) Is Nothing) Then
                RaiseEvent CategoriesRowChanged(Me, New CategoriesRowChangeEvent(CType(e.Row,CategoriesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.CategoriesRowChangingEvent) Is Nothing) Then
                RaiseEvent CategoriesRowChanging(Me, New CategoriesRowChangeEvent(CType(e.Row,CategoriesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.CategoriesRowDeletedEvent) Is Nothing) Then
                RaiseEvent CategoriesRowDeleted(Me, New CategoriesRowChangeEvent(CType(e.Row,CategoriesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.CategoriesRowDeletingEvent) Is Nothing) Then
                RaiseEvent CategoriesRowDeleting(Me, New CategoriesRowChangeEvent(CType(e.Row,CategoriesRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveCategoriesRow(ByVal row As CategoriesRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CategoriesRow
        Inherits DataRow
        
        Private tableCategories As CategoriesDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableCategories = CType(Me.Table,CategoriesDataTable)
        End Sub
        
        Public Property flag As Boolean
            Get
                Try 
                    Return CType(Me(Me.tableCategories.flagColumn),Boolean)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCategories.flagColumn) = value
            End Set
        End Property
        
        Public Property code As String
            Get
                Try 
                    Return CType(Me(Me.tableCategories.codeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCategories.codeColumn) = value
            End Set
        End Property
        
        Public Property name As String
            Get
                Try 
                    Return CType(Me(Me.tableCategories.nameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCategories.nameColumn) = value
            End Set
        End Property
        
        Public Function IsflagNull() As Boolean
            Return Me.IsNull(Me.tableCategories.flagColumn)
        End Function
        
        Public Sub SetflagNull()
            Me(Me.tableCategories.flagColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IscodeNull() As Boolean
            Return Me.IsNull(Me.tableCategories.codeColumn)
        End Function
        
        Public Sub SetcodeNull()
            Me(Me.tableCategories.codeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsnameNull() As Boolean
            Return Me.IsNull(Me.tableCategories.nameColumn)
        End Function
        
        Public Sub SetnameNull()
            Me(Me.tableCategories.nameColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CategoriesRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As CategoriesRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As CategoriesRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As CategoriesRow
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
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class inv_tab_service_typeDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnCode As DataColumn
        
        Private columnName As DataColumn
        
        Private columnFlag As DataColumn
        
        Friend Sub New()
            MyBase.New("inv_tab_service_type")
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
        
        Friend ReadOnly Property CodeColumn As DataColumn
            Get
                Return Me.columnCode
            End Get
        End Property
        
        Friend ReadOnly Property NameColumn As DataColumn
            Get
                Return Me.columnName
            End Get
        End Property
        
        Friend ReadOnly Property FlagColumn As DataColumn
            Get
                Return Me.columnFlag
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As inv_tab_service_typeRow
            Get
                Return CType(Me.Rows(index),inv_tab_service_typeRow)
            End Get
        End Property
        
        Public Event inv_tab_service_typeRowChanged As inv_tab_service_typeRowChangeEventHandler
        
        Public Event inv_tab_service_typeRowChanging As inv_tab_service_typeRowChangeEventHandler
        
        Public Event inv_tab_service_typeRowDeleted As inv_tab_service_typeRowChangeEventHandler
        
        Public Event inv_tab_service_typeRowDeleting As inv_tab_service_typeRowChangeEventHandler
        
        Public Overloads Sub Addinv_tab_service_typeRow(ByVal row As inv_tab_service_typeRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addinv_tab_service_typeRow(ByVal Code As String, ByVal Name As String, ByVal Flag As Integer) As inv_tab_service_typeRow
            Dim rowinv_tab_service_typeRow As inv_tab_service_typeRow = CType(Me.NewRow,inv_tab_service_typeRow)
            rowinv_tab_service_typeRow.ItemArray = New Object() {Code, Name, Flag}
            Me.Rows.Add(rowinv_tab_service_typeRow)
            Return rowinv_tab_service_typeRow
        End Function
        
        Public Function FindByCode(ByVal Code As String) As inv_tab_service_typeRow
            Return CType(Me.Rows.Find(New Object() {Code}),inv_tab_service_typeRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As inv_tab_service_typeDataTable = CType(MyBase.Clone,inv_tab_service_typeDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New inv_tab_service_typeDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnCode = Me.Columns("Code")
            Me.columnName = Me.Columns("Name")
            Me.columnFlag = Me.Columns("Flag")
        End Sub
        
        Private Sub InitClass()
            Me.columnCode = New DataColumn("Code", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCode)
            Me.columnName = New DataColumn("Name", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnName)
            Me.columnFlag = New DataColumn("Flag", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFlag)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnCode}, true))
            Me.columnCode.AllowDBNull = false
            Me.columnCode.Unique = true
            Me.columnFlag.ReadOnly = true
        End Sub
        
        Public Function Newinv_tab_service_typeRow() As inv_tab_service_typeRow
            Return CType(Me.NewRow,inv_tab_service_typeRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New inv_tab_service_typeRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(inv_tab_service_typeRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.inv_tab_service_typeRowChangedEvent) Is Nothing) Then
                RaiseEvent inv_tab_service_typeRowChanged(Me, New inv_tab_service_typeRowChangeEvent(CType(e.Row,inv_tab_service_typeRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.inv_tab_service_typeRowChangingEvent) Is Nothing) Then
                RaiseEvent inv_tab_service_typeRowChanging(Me, New inv_tab_service_typeRowChangeEvent(CType(e.Row,inv_tab_service_typeRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.inv_tab_service_typeRowDeletedEvent) Is Nothing) Then
                RaiseEvent inv_tab_service_typeRowDeleted(Me, New inv_tab_service_typeRowChangeEvent(CType(e.Row,inv_tab_service_typeRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.inv_tab_service_typeRowDeletingEvent) Is Nothing) Then
                RaiseEvent inv_tab_service_typeRowDeleting(Me, New inv_tab_service_typeRowChangeEvent(CType(e.Row,inv_tab_service_typeRow), e.Action))
            End If
        End Sub
        
        Public Sub Removeinv_tab_service_typeRow(ByVal row As inv_tab_service_typeRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class inv_tab_service_typeRow
        Inherits DataRow
        
        Private tableinv_tab_service_type As inv_tab_service_typeDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableinv_tab_service_type = CType(Me.Table,inv_tab_service_typeDataTable)
        End Sub
        
        Public Property Code As String
            Get
                Return CType(Me(Me.tableinv_tab_service_type.CodeColumn),String)
            End Get
            Set
                Me(Me.tableinv_tab_service_type.CodeColumn) = value
            End Set
        End Property
        
        Public Property Name As String
            Get
                Try 
                    Return CType(Me(Me.tableinv_tab_service_type.NameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableinv_tab_service_type.NameColumn) = value
            End Set
        End Property
        
        Public Property Flag As Integer
            Get
                Try 
                    Return CType(Me(Me.tableinv_tab_service_type.FlagColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableinv_tab_service_type.FlagColumn) = value
            End Set
        End Property
        
        Public Function IsNameNull() As Boolean
            Return Me.IsNull(Me.tableinv_tab_service_type.NameColumn)
        End Function
        
        Public Sub SetNameNull()
            Me(Me.tableinv_tab_service_type.NameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsFlagNull() As Boolean
            Return Me.IsNull(Me.tableinv_tab_service_type.FlagColumn)
        End Function
        
        Public Sub SetFlagNull()
            Me(Me.tableinv_tab_service_type.FlagColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class inv_tab_service_typeRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As inv_tab_service_typeRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As inv_tab_service_typeRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As inv_tab_service_typeRow
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
