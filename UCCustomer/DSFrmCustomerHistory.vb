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
Public Class DSFrmCustomerHistory
    Inherits DataSet
    
    Private tableservice_center_head As service_center_headDataTable
    
    Private tableUsers As UsersDataTable
    
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
            If (Not (ds.Tables("service_center_head")) Is Nothing) Then
                Me.Tables.Add(New service_center_headDataTable(ds.Tables("service_center_head")))
            End If
            If (Not (ds.Tables("Users")) Is Nothing) Then
                Me.Tables.Add(New UsersDataTable(ds.Tables("Users")))
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
    Public ReadOnly Property service_center_head As service_center_headDataTable
        Get
            Return Me.tableservice_center_head
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Users As UsersDataTable
        Get
            Return Me.tableUsers
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DSFrmCustomerHistory = CType(MyBase.Clone,DSFrmCustomerHistory)
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
        If (Not (ds.Tables("service_center_head")) Is Nothing) Then
            Me.Tables.Add(New service_center_headDataTable(ds.Tables("service_center_head")))
        End If
        If (Not (ds.Tables("Users")) Is Nothing) Then
            Me.Tables.Add(New UsersDataTable(ds.Tables("Users")))
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
        Me.tableservice_center_head = CType(Me.Tables("service_center_head"),service_center_headDataTable)
        If (Not (Me.tableservice_center_head) Is Nothing) Then
            Me.tableservice_center_head.InitVars
        End If
        Me.tableUsers = CType(Me.Tables("Users"),UsersDataTable)
        If (Not (Me.tableUsers) Is Nothing) Then
            Me.tableUsers.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DSFrmCustomerHistory"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DSFrmCustomerHistory.xsd"
        Me.Locale = New System.Globalization.CultureInfo("fa-IR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableservice_center_head = New service_center_headDataTable
        Me.Tables.Add(Me.tableservice_center_head)
        Me.tableUsers = New UsersDataTable
        Me.Tables.Add(Me.tableUsers)
    End Sub
    
    Private Function ShouldSerializeservice_center_head() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeUsers() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub service_center_headRowChangeEventHandler(ByVal sender As Object, ByVal e As service_center_headRowChangeEvent)
    
    Public Delegate Sub UsersRowChangeEventHandler(ByVal sender As Object, ByVal e As UsersRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class service_center_headDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnid_service_center As DataColumn
        
        Private columndate_refer As DataColumn
        
        Private columnlicense_no_vehicle As DataColumn
        
        Private columndesc_model As DataColumn
        
        Private columnadd_user As DataColumn
        
        Private columnTotal As DataColumn
        
        Private columntype_of_form As DataColumn
        
        Private columndesc_make As DataColumn
        
        Private columncurrent_mileage As DataColumn
        
        Private columnRecordType As DataColumn
        
        Private columnOrderDate As DataColumn
        
        Friend Sub New()
            MyBase.New("service_center_head")
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
        
        Friend ReadOnly Property id_service_centerColumn As DataColumn
            Get
                Return Me.columnid_service_center
            End Get
        End Property
        
        Friend ReadOnly Property date_referColumn As DataColumn
            Get
                Return Me.columndate_refer
            End Get
        End Property
        
        Friend ReadOnly Property license_no_vehicleColumn As DataColumn
            Get
                Return Me.columnlicense_no_vehicle
            End Get
        End Property
        
        Friend ReadOnly Property desc_modelColumn As DataColumn
            Get
                Return Me.columndesc_model
            End Get
        End Property
        
        Friend ReadOnly Property add_userColumn As DataColumn
            Get
                Return Me.columnadd_user
            End Get
        End Property
        
        Friend ReadOnly Property TotalColumn As DataColumn
            Get
                Return Me.columnTotal
            End Get
        End Property
        
        Friend ReadOnly Property type_of_formColumn As DataColumn
            Get
                Return Me.columntype_of_form
            End Get
        End Property
        
        Friend ReadOnly Property desc_makeColumn As DataColumn
            Get
                Return Me.columndesc_make
            End Get
        End Property
        
        Friend ReadOnly Property current_mileageColumn As DataColumn
            Get
                Return Me.columncurrent_mileage
            End Get
        End Property
        
        Friend ReadOnly Property RecordTypeColumn As DataColumn
            Get
                Return Me.columnRecordType
            End Get
        End Property
        
        Friend ReadOnly Property OrderDateColumn As DataColumn
            Get
                Return Me.columnOrderDate
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As service_center_headRow
            Get
                Return CType(Me.Rows(index),service_center_headRow)
            End Get
        End Property
        
        Public Event service_center_headRowChanged As service_center_headRowChangeEventHandler
        
        Public Event service_center_headRowChanging As service_center_headRowChangeEventHandler
        
        Public Event service_center_headRowDeleted As service_center_headRowChangeEventHandler
        
        Public Event service_center_headRowDeleting As service_center_headRowChangeEventHandler
        
        Public Overloads Sub Addservice_center_headRow(ByVal row As service_center_headRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addservice_center_headRow(ByVal id_service_center As String, ByVal date_refer As String, ByVal license_no_vehicle As String, ByVal desc_model As String, ByVal add_user As Integer, ByVal Total As Decimal, ByVal type_of_form As String, ByVal desc_make As String, ByVal current_mileage As Single, ByVal RecordType As String, ByVal OrderDate As String) As service_center_headRow
            Dim rowservice_center_headRow As service_center_headRow = CType(Me.NewRow,service_center_headRow)
            rowservice_center_headRow.ItemArray = New Object() {id_service_center, date_refer, license_no_vehicle, desc_model, add_user, Total, type_of_form, desc_make, current_mileage, RecordType, OrderDate}
            Me.Rows.Add(rowservice_center_headRow)
            Return rowservice_center_headRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As service_center_headDataTable = CType(MyBase.Clone,service_center_headDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New service_center_headDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnid_service_center = Me.Columns("id_service_center")
            Me.columndate_refer = Me.Columns("date_refer")
            Me.columnlicense_no_vehicle = Me.Columns("license_no_vehicle")
            Me.columndesc_model = Me.Columns("desc_model")
            Me.columnadd_user = Me.Columns("add_user")
            Me.columnTotal = Me.Columns("Total")
            Me.columntype_of_form = Me.Columns("type_of_form")
            Me.columndesc_make = Me.Columns("desc_make")
            Me.columncurrent_mileage = Me.Columns("current_mileage")
            Me.columnRecordType = Me.Columns("RecordType")
            Me.columnOrderDate = Me.Columns("OrderDate")
        End Sub
        
        Private Sub InitClass()
            Me.columnid_service_center = New DataColumn("id_service_center", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnid_service_center)
            Me.columndate_refer = New DataColumn("date_refer", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndate_refer)
            Me.columnlicense_no_vehicle = New DataColumn("license_no_vehicle", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnlicense_no_vehicle)
            Me.columndesc_model = New DataColumn("desc_model", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndesc_model)
            Me.columnadd_user = New DataColumn("add_user", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnadd_user)
            Me.columnTotal = New DataColumn("Total", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTotal)
            Me.columntype_of_form = New DataColumn("type_of_form", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columntype_of_form)
            Me.columndesc_make = New DataColumn("desc_make", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndesc_make)
            Me.columncurrent_mileage = New DataColumn("current_mileage", GetType(System.Single), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncurrent_mileage)
            Me.columnRecordType = New DataColumn("RecordType", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRecordType)
            Me.columnOrderDate = New DataColumn("OrderDate", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnOrderDate)
            Me.columnid_service_center.AllowDBNull = false
        End Sub
        
        Public Function Newservice_center_headRow() As service_center_headRow
            Return CType(Me.NewRow,service_center_headRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New service_center_headRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(service_center_headRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.service_center_headRowChangedEvent) Is Nothing) Then
                RaiseEvent service_center_headRowChanged(Me, New service_center_headRowChangeEvent(CType(e.Row,service_center_headRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.service_center_headRowChangingEvent) Is Nothing) Then
                RaiseEvent service_center_headRowChanging(Me, New service_center_headRowChangeEvent(CType(e.Row,service_center_headRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.service_center_headRowDeletedEvent) Is Nothing) Then
                RaiseEvent service_center_headRowDeleted(Me, New service_center_headRowChangeEvent(CType(e.Row,service_center_headRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.service_center_headRowDeletingEvent) Is Nothing) Then
                RaiseEvent service_center_headRowDeleting(Me, New service_center_headRowChangeEvent(CType(e.Row,service_center_headRow), e.Action))
            End If
        End Sub
        
        Public Sub Removeservice_center_headRow(ByVal row As service_center_headRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class service_center_headRow
        Inherits DataRow
        
        Private tableservice_center_head As service_center_headDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableservice_center_head = CType(Me.Table,service_center_headDataTable)
        End Sub
        
        Public Property id_service_center As String
            Get
                Return CType(Me(Me.tableservice_center_head.id_service_centerColumn),String)
            End Get
            Set
                Me(Me.tableservice_center_head.id_service_centerColumn) = value
            End Set
        End Property
        
        Public Property date_refer As String
            Get
                Try 
                    Return CType(Me(Me.tableservice_center_head.date_referColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableservice_center_head.date_referColumn) = value
            End Set
        End Property
        
        Public Property license_no_vehicle As String
            Get
                Try 
                    Return CType(Me(Me.tableservice_center_head.license_no_vehicleColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableservice_center_head.license_no_vehicleColumn) = value
            End Set
        End Property
        
        Public Property desc_model As String
            Get
                Try 
                    Return CType(Me(Me.tableservice_center_head.desc_modelColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableservice_center_head.desc_modelColumn) = value
            End Set
        End Property
        
        Public Property add_user As Integer
            Get
                Try 
                    Return CType(Me(Me.tableservice_center_head.add_userColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableservice_center_head.add_userColumn) = value
            End Set
        End Property
        
        Public Property Total As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableservice_center_head.TotalColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableservice_center_head.TotalColumn) = value
            End Set
        End Property
        
        Public Property type_of_form As String
            Get
                Try 
                    Return CType(Me(Me.tableservice_center_head.type_of_formColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableservice_center_head.type_of_formColumn) = value
            End Set
        End Property
        
        Public Property desc_make As String
            Get
                Try 
                    Return CType(Me(Me.tableservice_center_head.desc_makeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableservice_center_head.desc_makeColumn) = value
            End Set
        End Property
        
        Public Property current_mileage As Single
            Get
                Try 
                    Return CType(Me(Me.tableservice_center_head.current_mileageColumn),Single)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableservice_center_head.current_mileageColumn) = value
            End Set
        End Property
        
        Public Property RecordType As String
            Get
                Try 
                    Return CType(Me(Me.tableservice_center_head.RecordTypeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableservice_center_head.RecordTypeColumn) = value
            End Set
        End Property
        
        Public Property OrderDate As String
            Get
                Try 
                    Return CType(Me(Me.tableservice_center_head.OrderDateColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableservice_center_head.OrderDateColumn) = value
            End Set
        End Property
        
        Public Function Isdate_referNull() As Boolean
            Return Me.IsNull(Me.tableservice_center_head.date_referColumn)
        End Function
        
        Public Sub Setdate_referNull()
            Me(Me.tableservice_center_head.date_referColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Islicense_no_vehicleNull() As Boolean
            Return Me.IsNull(Me.tableservice_center_head.license_no_vehicleColumn)
        End Function
        
        Public Sub Setlicense_no_vehicleNull()
            Me(Me.tableservice_center_head.license_no_vehicleColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isdesc_modelNull() As Boolean
            Return Me.IsNull(Me.tableservice_center_head.desc_modelColumn)
        End Function
        
        Public Sub Setdesc_modelNull()
            Me(Me.tableservice_center_head.desc_modelColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isadd_userNull() As Boolean
            Return Me.IsNull(Me.tableservice_center_head.add_userColumn)
        End Function
        
        Public Sub Setadd_userNull()
            Me(Me.tableservice_center_head.add_userColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTotalNull() As Boolean
            Return Me.IsNull(Me.tableservice_center_head.TotalColumn)
        End Function
        
        Public Sub SetTotalNull()
            Me(Me.tableservice_center_head.TotalColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Istype_of_formNull() As Boolean
            Return Me.IsNull(Me.tableservice_center_head.type_of_formColumn)
        End Function
        
        Public Sub Settype_of_formNull()
            Me(Me.tableservice_center_head.type_of_formColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isdesc_makeNull() As Boolean
            Return Me.IsNull(Me.tableservice_center_head.desc_makeColumn)
        End Function
        
        Public Sub Setdesc_makeNull()
            Me(Me.tableservice_center_head.desc_makeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Iscurrent_mileageNull() As Boolean
            Return Me.IsNull(Me.tableservice_center_head.current_mileageColumn)
        End Function
        
        Public Sub Setcurrent_mileageNull()
            Me(Me.tableservice_center_head.current_mileageColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRecordTypeNull() As Boolean
            Return Me.IsNull(Me.tableservice_center_head.RecordTypeColumn)
        End Function
        
        Public Sub SetRecordTypeNull()
            Me(Me.tableservice_center_head.RecordTypeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsOrderDateNull() As Boolean
            Return Me.IsNull(Me.tableservice_center_head.OrderDateColumn)
        End Function
        
        Public Sub SetOrderDateNull()
            Me(Me.tableservice_center_head.OrderDateColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class service_center_headRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As service_center_headRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As service_center_headRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As service_center_headRow
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
            Me.columnUserId.AutoIncrement = true
            Me.columnUserId.AllowDBNull = false
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
End Class
