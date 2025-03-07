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
Public Class DSFrmSearchSize
    Inherits DataSet
    
    Private tablebas_vehicle_size As bas_vehicle_sizeDataTable
    
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
            If (Not (ds.Tables("bas_vehicle_size")) Is Nothing) Then
                Me.Tables.Add(New bas_vehicle_sizeDataTable(ds.Tables("bas_vehicle_size")))
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
    Public ReadOnly Property bas_vehicle_size As bas_vehicle_sizeDataTable
        Get
            Return Me.tablebas_vehicle_size
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DSFrmSearchSize = CType(MyBase.Clone,DSFrmSearchSize)
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
        If (Not (ds.Tables("bas_vehicle_size")) Is Nothing) Then
            Me.Tables.Add(New bas_vehicle_sizeDataTable(ds.Tables("bas_vehicle_size")))
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
        Me.tablebas_vehicle_size = CType(Me.Tables("bas_vehicle_size"),bas_vehicle_sizeDataTable)
        If (Not (Me.tablebas_vehicle_size) Is Nothing) Then
            Me.tablebas_vehicle_size.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DSFrmSearchSize"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DSFrmSearchSize.xsd"
        Me.Locale = New System.Globalization.CultureInfo("fa-IR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablebas_vehicle_size = New bas_vehicle_sizeDataTable
        Me.Tables.Add(Me.tablebas_vehicle_size)
    End Sub
    
    Private Function ShouldSerializebas_vehicle_size() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub bas_vehicle_sizeRowChangeEventHandler(ByVal sender As Object, ByVal e As bas_vehicle_sizeRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class bas_vehicle_sizeDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columncod_vehicle As DataColumn
        
        Private columncod_main As DataColumn
        
        Private columncod_size_main As DataColumn
        
        Private columncod_size_option As DataColumn
        
        Private columnDesc_Main As DataColumn
        
        Private columnDesc_Option As DataColumn
        
        Private columncod_make As DataColumn
        
        Private columncod_model As DataColumn
        
        Private columnmake_year As DataColumn
        
        Private columnoptions As DataColumn
        
        Friend Sub New()
            MyBase.New("bas_vehicle_size")
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
        
        Friend ReadOnly Property cod_vehicleColumn As DataColumn
            Get
                Return Me.columncod_vehicle
            End Get
        End Property
        
        Friend ReadOnly Property cod_mainColumn As DataColumn
            Get
                Return Me.columncod_main
            End Get
        End Property
        
        Friend ReadOnly Property cod_size_mainColumn As DataColumn
            Get
                Return Me.columncod_size_main
            End Get
        End Property
        
        Friend ReadOnly Property cod_size_optionColumn As DataColumn
            Get
                Return Me.columncod_size_option
            End Get
        End Property
        
        Friend ReadOnly Property Desc_MainColumn As DataColumn
            Get
                Return Me.columnDesc_Main
            End Get
        End Property
        
        Friend ReadOnly Property Desc_OptionColumn As DataColumn
            Get
                Return Me.columnDesc_Option
            End Get
        End Property
        
        Friend ReadOnly Property cod_makeColumn As DataColumn
            Get
                Return Me.columncod_make
            End Get
        End Property
        
        Friend ReadOnly Property cod_modelColumn As DataColumn
            Get
                Return Me.columncod_model
            End Get
        End Property
        
        Friend ReadOnly Property make_yearColumn As DataColumn
            Get
                Return Me.columnmake_year
            End Get
        End Property
        
        Friend ReadOnly Property optionsColumn As DataColumn
            Get
                Return Me.columnoptions
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As bas_vehicle_sizeRow
            Get
                Return CType(Me.Rows(index),bas_vehicle_sizeRow)
            End Get
        End Property
        
        Public Event bas_vehicle_sizeRowChanged As bas_vehicle_sizeRowChangeEventHandler
        
        Public Event bas_vehicle_sizeRowChanging As bas_vehicle_sizeRowChangeEventHandler
        
        Public Event bas_vehicle_sizeRowDeleted As bas_vehicle_sizeRowChangeEventHandler
        
        Public Event bas_vehicle_sizeRowDeleting As bas_vehicle_sizeRowChangeEventHandler
        
        Public Overloads Sub Addbas_vehicle_sizeRow(ByVal row As bas_vehicle_sizeRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addbas_vehicle_sizeRow(ByVal cod_vehicle As String, ByVal cod_main As String, ByVal cod_size_main As String, ByVal cod_size_option As String, ByVal Desc_Main As String, ByVal Desc_Option As String, ByVal cod_make As String, ByVal cod_model As String, ByVal make_year As String, ByVal options As String) As bas_vehicle_sizeRow
            Dim rowbas_vehicle_sizeRow As bas_vehicle_sizeRow = CType(Me.NewRow,bas_vehicle_sizeRow)
            rowbas_vehicle_sizeRow.ItemArray = New Object() {cod_vehicle, cod_main, cod_size_main, cod_size_option, Desc_Main, Desc_Option, cod_make, cod_model, make_year, options}
            Me.Rows.Add(rowbas_vehicle_sizeRow)
            Return rowbas_vehicle_sizeRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As bas_vehicle_sizeDataTable = CType(MyBase.Clone,bas_vehicle_sizeDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New bas_vehicle_sizeDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columncod_vehicle = Me.Columns("cod_vehicle")
            Me.columncod_main = Me.Columns("cod_main")
            Me.columncod_size_main = Me.Columns("cod_size_main")
            Me.columncod_size_option = Me.Columns("cod_size_option")
            Me.columnDesc_Main = Me.Columns("Desc_Main")
            Me.columnDesc_Option = Me.Columns("Desc_Option")
            Me.columncod_make = Me.Columns("cod_make")
            Me.columncod_model = Me.Columns("cod_model")
            Me.columnmake_year = Me.Columns("make_year")
            Me.columnoptions = Me.Columns("options")
        End Sub
        
        Private Sub InitClass()
            Me.columncod_vehicle = New DataColumn("cod_vehicle", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncod_vehicle)
            Me.columncod_main = New DataColumn("cod_main", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncod_main)
            Me.columncod_size_main = New DataColumn("cod_size_main", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncod_size_main)
            Me.columncod_size_option = New DataColumn("cod_size_option", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncod_size_option)
            Me.columnDesc_Main = New DataColumn("Desc_Main", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDesc_Main)
            Me.columnDesc_Option = New DataColumn("Desc_Option", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDesc_Option)
            Me.columncod_make = New DataColumn("cod_make", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncod_make)
            Me.columncod_model = New DataColumn("cod_model", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncod_model)
            Me.columnmake_year = New DataColumn("make_year", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnmake_year)
            Me.columnoptions = New DataColumn("options", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnoptions)
            Me.columncod_vehicle.AllowDBNull = false
            Me.columncod_main.AllowDBNull = false
            Me.columncod_size_main.AllowDBNull = false
            Me.columncod_make.AllowDBNull = false
            Me.columncod_model.AllowDBNull = false
            Me.columnmake_year.AllowDBNull = false
            Me.columnoptions.AllowDBNull = false
        End Sub
        
        Public Function Newbas_vehicle_sizeRow() As bas_vehicle_sizeRow
            Return CType(Me.NewRow,bas_vehicle_sizeRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New bas_vehicle_sizeRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(bas_vehicle_sizeRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.bas_vehicle_sizeRowChangedEvent) Is Nothing) Then
                RaiseEvent bas_vehicle_sizeRowChanged(Me, New bas_vehicle_sizeRowChangeEvent(CType(e.Row,bas_vehicle_sizeRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.bas_vehicle_sizeRowChangingEvent) Is Nothing) Then
                RaiseEvent bas_vehicle_sizeRowChanging(Me, New bas_vehicle_sizeRowChangeEvent(CType(e.Row,bas_vehicle_sizeRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.bas_vehicle_sizeRowDeletedEvent) Is Nothing) Then
                RaiseEvent bas_vehicle_sizeRowDeleted(Me, New bas_vehicle_sizeRowChangeEvent(CType(e.Row,bas_vehicle_sizeRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.bas_vehicle_sizeRowDeletingEvent) Is Nothing) Then
                RaiseEvent bas_vehicle_sizeRowDeleting(Me, New bas_vehicle_sizeRowChangeEvent(CType(e.Row,bas_vehicle_sizeRow), e.Action))
            End If
        End Sub
        
        Public Sub Removebas_vehicle_sizeRow(ByVal row As bas_vehicle_sizeRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class bas_vehicle_sizeRow
        Inherits DataRow
        
        Private tablebas_vehicle_size As bas_vehicle_sizeDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablebas_vehicle_size = CType(Me.Table,bas_vehicle_sizeDataTable)
        End Sub
        
        Public Property cod_vehicle As String
            Get
                Return CType(Me(Me.tablebas_vehicle_size.cod_vehicleColumn),String)
            End Get
            Set
                Me(Me.tablebas_vehicle_size.cod_vehicleColumn) = value
            End Set
        End Property
        
        Public Property cod_main As String
            Get
                Return CType(Me(Me.tablebas_vehicle_size.cod_mainColumn),String)
            End Get
            Set
                Me(Me.tablebas_vehicle_size.cod_mainColumn) = value
            End Set
        End Property
        
        Public Property cod_size_main As String
            Get
                Return CType(Me(Me.tablebas_vehicle_size.cod_size_mainColumn),String)
            End Get
            Set
                Me(Me.tablebas_vehicle_size.cod_size_mainColumn) = value
            End Set
        End Property
        
        Public Property cod_size_option As String
            Get
                Try 
                    Return CType(Me(Me.tablebas_vehicle_size.cod_size_optionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablebas_vehicle_size.cod_size_optionColumn) = value
            End Set
        End Property
        
        Public Property Desc_Main As String
            Get
                Try 
                    Return CType(Me(Me.tablebas_vehicle_size.Desc_MainColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablebas_vehicle_size.Desc_MainColumn) = value
            End Set
        End Property
        
        Public Property Desc_Option As String
            Get
                Try 
                    Return CType(Me(Me.tablebas_vehicle_size.Desc_OptionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablebas_vehicle_size.Desc_OptionColumn) = value
            End Set
        End Property
        
        Public Property cod_make As String
            Get
                Return CType(Me(Me.tablebas_vehicle_size.cod_makeColumn),String)
            End Get
            Set
                Me(Me.tablebas_vehicle_size.cod_makeColumn) = value
            End Set
        End Property
        
        Public Property cod_model As String
            Get
                Return CType(Me(Me.tablebas_vehicle_size.cod_modelColumn),String)
            End Get
            Set
                Me(Me.tablebas_vehicle_size.cod_modelColumn) = value
            End Set
        End Property
        
        Public Property make_year As String
            Get
                Return CType(Me(Me.tablebas_vehicle_size.make_yearColumn),String)
            End Get
            Set
                Me(Me.tablebas_vehicle_size.make_yearColumn) = value
            End Set
        End Property
        
        Public Property options As String
            Get
                Return CType(Me(Me.tablebas_vehicle_size.optionsColumn),String)
            End Get
            Set
                Me(Me.tablebas_vehicle_size.optionsColumn) = value
            End Set
        End Property
        
        Public Function Iscod_size_optionNull() As Boolean
            Return Me.IsNull(Me.tablebas_vehicle_size.cod_size_optionColumn)
        End Function
        
        Public Sub Setcod_size_optionNull()
            Me(Me.tablebas_vehicle_size.cod_size_optionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDesc_MainNull() As Boolean
            Return Me.IsNull(Me.tablebas_vehicle_size.Desc_MainColumn)
        End Function
        
        Public Sub SetDesc_MainNull()
            Me(Me.tablebas_vehicle_size.Desc_MainColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDesc_OptionNull() As Boolean
            Return Me.IsNull(Me.tablebas_vehicle_size.Desc_OptionColumn)
        End Function
        
        Public Sub SetDesc_OptionNull()
            Me(Me.tablebas_vehicle_size.Desc_OptionColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class bas_vehicle_sizeRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As bas_vehicle_sizeRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As bas_vehicle_sizeRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As bas_vehicle_sizeRow
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
