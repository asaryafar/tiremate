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
Public Class DSFrmLogin
    Inherits DataSet
    
    Private tableUsers As UsersDataTable
    
    Private tableStore_Setup As Store_SetupDataTable
    
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
            If (Not (ds.Tables("Users")) Is Nothing) Then
                Me.Tables.Add(New UsersDataTable(ds.Tables("Users")))
            End If
            If (Not (ds.Tables("Store_Setup")) Is Nothing) Then
                Me.Tables.Add(New Store_SetupDataTable(ds.Tables("Store_Setup")))
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
    Public ReadOnly Property Users As UsersDataTable
        Get
            Return Me.tableUsers
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Store_Setup As Store_SetupDataTable
        Get
            Return Me.tableStore_Setup
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DSFrmLogin = CType(MyBase.Clone,DSFrmLogin)
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
        If (Not (ds.Tables("Users")) Is Nothing) Then
            Me.Tables.Add(New UsersDataTable(ds.Tables("Users")))
        End If
        If (Not (ds.Tables("Store_Setup")) Is Nothing) Then
            Me.Tables.Add(New Store_SetupDataTable(ds.Tables("Store_Setup")))
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
        Me.tableUsers = CType(Me.Tables("Users"),UsersDataTable)
        If (Not (Me.tableUsers) Is Nothing) Then
            Me.tableUsers.InitVars
        End If
        Me.tableStore_Setup = CType(Me.Tables("Store_Setup"),Store_SetupDataTable)
        If (Not (Me.tableStore_Setup) Is Nothing) Then
            Me.tableStore_Setup.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DSFrmLogin"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DSFrmLogin.xsd"
        Me.Locale = New System.Globalization.CultureInfo("fa-IR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableUsers = New UsersDataTable
        Me.Tables.Add(Me.tableUsers)
        Me.tableStore_Setup = New Store_SetupDataTable
        Me.Tables.Add(Me.tableStore_Setup)
    End Sub
    
    Private Function ShouldSerializeUsers() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeStore_Setup() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub UsersRowChangeEventHandler(ByVal sender As Object, ByVal e As UsersRowChangeEvent)
    
    Public Delegate Sub Store_SetupRowChangeEventHandler(ByVal sender As Object, ByVal e As Store_SetupRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class UsersDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnUserId As DataColumn
        
        Private columnUserLogin As DataColumn
        
        Friend Sub New()
            MyBase.New("Users")
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
        
        Friend ReadOnly Property UserIdColumn As DataColumn
            Get
                Return Me.columnUserId
            End Get
        End Property
        
        Friend ReadOnly Property UserLoginColumn As DataColumn
            Get
                Return Me.columnUserLogin
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As UsersRow
            Get
                Return CType(Me.Rows(index),UsersRow)
            End Get
        End Property
        
        Public Event UsersRowChanged As UsersRowChangeEventHandler
        
        Public Event UsersRowChanging As UsersRowChangeEventHandler
        
        Public Event UsersRowDeleted As UsersRowChangeEventHandler
        
        Public Event UsersRowDeleting As UsersRowChangeEventHandler
        
        Public Overloads Sub AddUsersRow(ByVal row As UsersRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddUsersRow(ByVal UserLogin As String) As UsersRow
            Dim rowUsersRow As UsersRow = CType(Me.NewRow,UsersRow)
            rowUsersRow.ItemArray = New Object() {Nothing, UserLogin}
            Me.Rows.Add(rowUsersRow)
            Return rowUsersRow
        End Function
        
        Public Function FindByUserId(ByVal UserId As Integer) As UsersRow
            Return CType(Me.Rows.Find(New Object() {UserId}),UsersRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As UsersDataTable = CType(MyBase.Clone,UsersDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New UsersDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnUserId = Me.Columns("UserId")
            Me.columnUserLogin = Me.Columns("UserLogin")
        End Sub
        
        Private Sub InitClass()
            Me.columnUserId = New DataColumn("UserId", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnUserId)
            Me.columnUserLogin = New DataColumn("UserLogin", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnUserLogin)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnUserId}, true))
            Me.columnUserId.AutoIncrement = true
            Me.columnUserId.AllowDBNull = false
            Me.columnUserId.Unique = true
        End Sub
        
        Public Function NewUsersRow() As UsersRow
            Return CType(Me.NewRow,UsersRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New UsersRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(UsersRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.UsersRowChangedEvent) Is Nothing) Then
                RaiseEvent UsersRowChanged(Me, New UsersRowChangeEvent(CType(e.Row,UsersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.UsersRowChangingEvent) Is Nothing) Then
                RaiseEvent UsersRowChanging(Me, New UsersRowChangeEvent(CType(e.Row,UsersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.UsersRowDeletedEvent) Is Nothing) Then
                RaiseEvent UsersRowDeleted(Me, New UsersRowChangeEvent(CType(e.Row,UsersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.UsersRowDeletingEvent) Is Nothing) Then
                RaiseEvent UsersRowDeleting(Me, New UsersRowChangeEvent(CType(e.Row,UsersRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveUsersRow(ByVal row As UsersRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class UsersRow
        Inherits DataRow
        
        Private tableUsers As UsersDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableUsers = CType(Me.Table,UsersDataTable)
        End Sub
        
        Public Property UserId As Integer
            Get
                Return CType(Me(Me.tableUsers.UserIdColumn),Integer)
            End Get
            Set
                Me(Me.tableUsers.UserIdColumn) = value
            End Set
        End Property
        
        Public Property UserLogin As String
            Get
                Try 
                    Return CType(Me(Me.tableUsers.UserLoginColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableUsers.UserLoginColumn) = value
            End Set
        End Property
        
        Public Function IsUserLoginNull() As Boolean
            Return Me.IsNull(Me.tableUsers.UserLoginColumn)
        End Function
        
        Public Sub SetUserLoginNull()
            Me(Me.tableUsers.UserLoginColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class UsersRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As UsersRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As UsersRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As UsersRow
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
    Public Class Store_SetupDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnSTORENO As DataColumn
        
        Private columnSTORENAME As DataColumn
        
        Private columnSHORTNAME As DataColumn
        
        Friend Sub New()
            MyBase.New("Store_Setup")
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
        
        Friend ReadOnly Property STORENOColumn As DataColumn
            Get
                Return Me.columnSTORENO
            End Get
        End Property
        
        Friend ReadOnly Property STORENAMEColumn As DataColumn
            Get
                Return Me.columnSTORENAME
            End Get
        End Property
        
        Friend ReadOnly Property SHORTNAMEColumn As DataColumn
            Get
                Return Me.columnSHORTNAME
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As Store_SetupRow
            Get
                Return CType(Me.Rows(index),Store_SetupRow)
            End Get
        End Property
        
        Public Event Store_SetupRowChanged As Store_SetupRowChangeEventHandler
        
        Public Event Store_SetupRowChanging As Store_SetupRowChangeEventHandler
        
        Public Event Store_SetupRowDeleted As Store_SetupRowChangeEventHandler
        
        Public Event Store_SetupRowDeleting As Store_SetupRowChangeEventHandler
        
        Public Overloads Sub AddStore_SetupRow(ByVal row As Store_SetupRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddStore_SetupRow(ByVal STORENO As String, ByVal STORENAME As String, ByVal SHORTNAME As String) As Store_SetupRow
            Dim rowStore_SetupRow As Store_SetupRow = CType(Me.NewRow,Store_SetupRow)
            rowStore_SetupRow.ItemArray = New Object() {STORENO, STORENAME, SHORTNAME}
            Me.Rows.Add(rowStore_SetupRow)
            Return rowStore_SetupRow
        End Function
        
        Public Function FindBySTORENO(ByVal STORENO As String) As Store_SetupRow
            Return CType(Me.Rows.Find(New Object() {STORENO}),Store_SetupRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As Store_SetupDataTable = CType(MyBase.Clone,Store_SetupDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New Store_SetupDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnSTORENO = Me.Columns("STORENO")
            Me.columnSTORENAME = Me.Columns("STORENAME")
            Me.columnSHORTNAME = Me.Columns("SHORTNAME")
        End Sub
        
        Private Sub InitClass()
            Me.columnSTORENO = New DataColumn("STORENO", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSTORENO)
            Me.columnSTORENAME = New DataColumn("STORENAME", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSTORENAME)
            Me.columnSHORTNAME = New DataColumn("SHORTNAME", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSHORTNAME)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnSTORENO}, true))
            Me.columnSTORENO.AllowDBNull = false
            Me.columnSTORENO.Unique = true
        End Sub
        
        Public Function NewStore_SetupRow() As Store_SetupRow
            Return CType(Me.NewRow,Store_SetupRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New Store_SetupRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(Store_SetupRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.Store_SetupRowChangedEvent) Is Nothing) Then
                RaiseEvent Store_SetupRowChanged(Me, New Store_SetupRowChangeEvent(CType(e.Row,Store_SetupRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.Store_SetupRowChangingEvent) Is Nothing) Then
                RaiseEvent Store_SetupRowChanging(Me, New Store_SetupRowChangeEvent(CType(e.Row,Store_SetupRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.Store_SetupRowDeletedEvent) Is Nothing) Then
                RaiseEvent Store_SetupRowDeleted(Me, New Store_SetupRowChangeEvent(CType(e.Row,Store_SetupRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.Store_SetupRowDeletingEvent) Is Nothing) Then
                RaiseEvent Store_SetupRowDeleting(Me, New Store_SetupRowChangeEvent(CType(e.Row,Store_SetupRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveStore_SetupRow(ByVal row As Store_SetupRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Store_SetupRow
        Inherits DataRow
        
        Private tableStore_Setup As Store_SetupDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableStore_Setup = CType(Me.Table,Store_SetupDataTable)
        End Sub
        
        Public Property STORENO As String
            Get
                Return CType(Me(Me.tableStore_Setup.STORENOColumn),String)
            End Get
            Set
                Me(Me.tableStore_Setup.STORENOColumn) = value
            End Set
        End Property
        
        Public Property STORENAME As String
            Get
                Try 
                    Return CType(Me(Me.tableStore_Setup.STORENAMEColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableStore_Setup.STORENAMEColumn) = value
            End Set
        End Property
        
        Public Property SHORTNAME As String
            Get
                Try 
                    Return CType(Me(Me.tableStore_Setup.SHORTNAMEColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableStore_Setup.SHORTNAMEColumn) = value
            End Set
        End Property
        
        Public Function IsSTORENAMENull() As Boolean
            Return Me.IsNull(Me.tableStore_Setup.STORENAMEColumn)
        End Function
        
        Public Sub SetSTORENAMENull()
            Me(Me.tableStore_Setup.STORENAMEColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSHORTNAMENull() As Boolean
            Return Me.IsNull(Me.tableStore_Setup.SHORTNAMEColumn)
        End Function
        
        Public Sub SetSHORTNAMENull()
            Me(Me.tableStore_Setup.SHORTNAMEColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Store_SetupRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As Store_SetupRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As Store_SetupRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As Store_SetupRow
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
