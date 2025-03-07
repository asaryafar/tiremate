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
Public Class DSFrmUserGroup
    Inherits DataSet
    
    Private tableUserGroup As UserGroupDataTable
    
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
            If (Not (ds.Tables("UserGroup")) Is Nothing) Then
                Me.Tables.Add(New UserGroupDataTable(ds.Tables("UserGroup")))
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
    Public ReadOnly Property UserGroup As UserGroupDataTable
        Get
            Return Me.tableUserGroup
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DSFrmUserGroup = CType(MyBase.Clone,DSFrmUserGroup)
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
        If (Not (ds.Tables("UserGroup")) Is Nothing) Then
            Me.Tables.Add(New UserGroupDataTable(ds.Tables("UserGroup")))
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
        Me.tableUserGroup = CType(Me.Tables("UserGroup"),UserGroupDataTable)
        If (Not (Me.tableUserGroup) Is Nothing) Then
            Me.tableUserGroup.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DSFrmUserGroup"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DSFrmUserGroup.xsd"
        Me.Locale = New System.Globalization.CultureInfo("fa-IR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableUserGroup = New UserGroupDataTable
        Me.Tables.Add(Me.tableUserGroup)
    End Sub
    
    Private Function ShouldSerializeUserGroup() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub UserGroupRowChangeEventHandler(ByVal sender As Object, ByVal e As UserGroupRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class UserGroupDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnGroupActiveFlag As DataColumn
        
        Private columnUserGroupId As DataColumn
        
        Private columnUserGroupName As DataColumn
        
        Friend Sub New()
            MyBase.New("UserGroup")
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
        
        Friend ReadOnly Property GroupActiveFlagColumn As DataColumn
            Get
                Return Me.columnGroupActiveFlag
            End Get
        End Property
        
        Friend ReadOnly Property UserGroupIdColumn As DataColumn
            Get
                Return Me.columnUserGroupId
            End Get
        End Property
        
        Friend ReadOnly Property UserGroupNameColumn As DataColumn
            Get
                Return Me.columnUserGroupName
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As UserGroupRow
            Get
                Return CType(Me.Rows(index),UserGroupRow)
            End Get
        End Property
        
        Public Event UserGroupRowChanged As UserGroupRowChangeEventHandler
        
        Public Event UserGroupRowChanging As UserGroupRowChangeEventHandler
        
        Public Event UserGroupRowDeleted As UserGroupRowChangeEventHandler
        
        Public Event UserGroupRowDeleting As UserGroupRowChangeEventHandler
        
        Public Overloads Sub AddUserGroupRow(ByVal row As UserGroupRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddUserGroupRow(ByVal GroupActiveFlag As Boolean, ByVal UserGroupName As String) As UserGroupRow
            Dim rowUserGroupRow As UserGroupRow = CType(Me.NewRow,UserGroupRow)
            rowUserGroupRow.ItemArray = New Object() {GroupActiveFlag, Nothing, UserGroupName}
            Me.Rows.Add(rowUserGroupRow)
            Return rowUserGroupRow
        End Function
        
        Public Function FindByUserGroupId(ByVal UserGroupId As Integer) As UserGroupRow
            Return CType(Me.Rows.Find(New Object() {UserGroupId}),UserGroupRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As UserGroupDataTable = CType(MyBase.Clone,UserGroupDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New UserGroupDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnGroupActiveFlag = Me.Columns("GroupActiveFlag")
            Me.columnUserGroupId = Me.Columns("UserGroupId")
            Me.columnUserGroupName = Me.Columns("UserGroupName")
        End Sub
        
        Private Sub InitClass()
            Me.columnGroupActiveFlag = New DataColumn("GroupActiveFlag", GetType(System.Boolean), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnGroupActiveFlag)
            Me.columnUserGroupId = New DataColumn("UserGroupId", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnUserGroupId)
            Me.columnUserGroupName = New DataColumn("UserGroupName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnUserGroupName)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnUserGroupId}, true))
            Me.columnUserGroupId.AutoIncrement = true
            Me.columnUserGroupId.AllowDBNull = false
            Me.columnUserGroupId.Unique = true
        End Sub
        
        Public Function NewUserGroupRow() As UserGroupRow
            Return CType(Me.NewRow,UserGroupRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New UserGroupRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(UserGroupRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.UserGroupRowChangedEvent) Is Nothing) Then
                RaiseEvent UserGroupRowChanged(Me, New UserGroupRowChangeEvent(CType(e.Row,UserGroupRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.UserGroupRowChangingEvent) Is Nothing) Then
                RaiseEvent UserGroupRowChanging(Me, New UserGroupRowChangeEvent(CType(e.Row,UserGroupRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.UserGroupRowDeletedEvent) Is Nothing) Then
                RaiseEvent UserGroupRowDeleted(Me, New UserGroupRowChangeEvent(CType(e.Row,UserGroupRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.UserGroupRowDeletingEvent) Is Nothing) Then
                RaiseEvent UserGroupRowDeleting(Me, New UserGroupRowChangeEvent(CType(e.Row,UserGroupRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveUserGroupRow(ByVal row As UserGroupRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class UserGroupRow
        Inherits DataRow
        
        Private tableUserGroup As UserGroupDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableUserGroup = CType(Me.Table,UserGroupDataTable)
        End Sub
        
        Public Property GroupActiveFlag As Boolean
            Get
                Try 
                    Return CType(Me(Me.tableUserGroup.GroupActiveFlagColumn),Boolean)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableUserGroup.GroupActiveFlagColumn) = value
            End Set
        End Property
        
        Public Property UserGroupId As Integer
            Get
                Return CType(Me(Me.tableUserGroup.UserGroupIdColumn),Integer)
            End Get
            Set
                Me(Me.tableUserGroup.UserGroupIdColumn) = value
            End Set
        End Property
        
        Public Property UserGroupName As String
            Get
                Try 
                    Return CType(Me(Me.tableUserGroup.UserGroupNameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableUserGroup.UserGroupNameColumn) = value
            End Set
        End Property
        
        Public Function IsGroupActiveFlagNull() As Boolean
            Return Me.IsNull(Me.tableUserGroup.GroupActiveFlagColumn)
        End Function
        
        Public Sub SetGroupActiveFlagNull()
            Me(Me.tableUserGroup.GroupActiveFlagColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsUserGroupNameNull() As Boolean
            Return Me.IsNull(Me.tableUserGroup.UserGroupNameColumn)
        End Function
        
        Public Sub SetUserGroupNameNull()
            Me(Me.tableUserGroup.UserGroupNameColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class UserGroupRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As UserGroupRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As UserGroupRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As UserGroupRow
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
