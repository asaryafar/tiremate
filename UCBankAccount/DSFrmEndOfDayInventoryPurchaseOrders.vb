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
Public Class DSFrmEndOfDayInventoryPurchaseOrders
    Inherits DataSet
    
    Private tableInv_purchase_order_dtl As Inv_purchase_order_dtlDataTable
    
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
            If (Not (ds.Tables("Inv_purchase_order_dtl")) Is Nothing) Then
                Me.Tables.Add(New Inv_purchase_order_dtlDataTable(ds.Tables("Inv_purchase_order_dtl")))
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
    Public ReadOnly Property Inv_purchase_order_dtl As Inv_purchase_order_dtlDataTable
        Get
            Return Me.tableInv_purchase_order_dtl
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DSFrmEndOfDayInventoryPurchaseOrders = CType(MyBase.Clone,DSFrmEndOfDayInventoryPurchaseOrders)
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
        If (Not (ds.Tables("Inv_purchase_order_dtl")) Is Nothing) Then
            Me.Tables.Add(New Inv_purchase_order_dtlDataTable(ds.Tables("Inv_purchase_order_dtl")))
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
        Me.tableInv_purchase_order_dtl = CType(Me.Tables("Inv_purchase_order_dtl"),Inv_purchase_order_dtlDataTable)
        If (Not (Me.tableInv_purchase_order_dtl) Is Nothing) Then
            Me.tableInv_purchase_order_dtl.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DSFrmEndOfDayInventoryPurchaseOrders"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DSFrmEndOfDayInventoryPurchaseOrders.xsd"
        Me.Locale = New System.Globalization.CultureInfo("fa-IR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableInv_purchase_order_dtl = New Inv_purchase_order_dtlDataTable
        Me.Tables.Add(Me.tableInv_purchase_order_dtl)
    End Sub
    
    Private Function ShouldSerializeInv_purchase_order_dtl() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub Inv_purchase_order_dtlRowChangeEventHandler(ByVal sender As Object, ByVal e As Inv_purchase_order_dtlRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Inv_purchase_order_dtlDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnpo_no As DataColumn
        
        Private columnitem_no As DataColumn
        
        Private columnqty As DataColumn
        
        Private columndesc_item As DataColumn
        
        Private columnReplCost As DataColumn
        
        Private columnfet As DataColumn
        
        Private columncod_vendor As DataColumn
        
        Private columnExtCost As DataColumn
        
        Friend Sub New()
            MyBase.New("Inv_purchase_order_dtl")
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
        
        Friend ReadOnly Property po_noColumn As DataColumn
            Get
                Return Me.columnpo_no
            End Get
        End Property
        
        Friend ReadOnly Property item_noColumn As DataColumn
            Get
                Return Me.columnitem_no
            End Get
        End Property
        
        Friend ReadOnly Property qtyColumn As DataColumn
            Get
                Return Me.columnqty
            End Get
        End Property
        
        Friend ReadOnly Property desc_itemColumn As DataColumn
            Get
                Return Me.columndesc_item
            End Get
        End Property
        
        Friend ReadOnly Property ReplCostColumn As DataColumn
            Get
                Return Me.columnReplCost
            End Get
        End Property
        
        Friend ReadOnly Property fetColumn As DataColumn
            Get
                Return Me.columnfet
            End Get
        End Property
        
        Friend ReadOnly Property cod_vendorColumn As DataColumn
            Get
                Return Me.columncod_vendor
            End Get
        End Property
        
        Friend ReadOnly Property ExtCostColumn As DataColumn
            Get
                Return Me.columnExtCost
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As Inv_purchase_order_dtlRow
            Get
                Return CType(Me.Rows(index),Inv_purchase_order_dtlRow)
            End Get
        End Property
        
        Public Event Inv_purchase_order_dtlRowChanged As Inv_purchase_order_dtlRowChangeEventHandler
        
        Public Event Inv_purchase_order_dtlRowChanging As Inv_purchase_order_dtlRowChangeEventHandler
        
        Public Event Inv_purchase_order_dtlRowDeleted As Inv_purchase_order_dtlRowChangeEventHandler
        
        Public Event Inv_purchase_order_dtlRowDeleting As Inv_purchase_order_dtlRowChangeEventHandler
        
        Public Overloads Sub AddInv_purchase_order_dtlRow(ByVal row As Inv_purchase_order_dtlRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddInv_purchase_order_dtlRow(ByVal po_no As String, ByVal item_no As String, ByVal qty As Single, ByVal desc_item As String, ByVal ReplCost As Single, ByVal fet As Single, ByVal cod_vendor As String, ByVal ExtCost As Single) As Inv_purchase_order_dtlRow
            Dim rowInv_purchase_order_dtlRow As Inv_purchase_order_dtlRow = CType(Me.NewRow,Inv_purchase_order_dtlRow)
            rowInv_purchase_order_dtlRow.ItemArray = New Object() {po_no, item_no, qty, desc_item, ReplCost, fet, cod_vendor, ExtCost}
            Me.Rows.Add(rowInv_purchase_order_dtlRow)
            Return rowInv_purchase_order_dtlRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As Inv_purchase_order_dtlDataTable = CType(MyBase.Clone,Inv_purchase_order_dtlDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New Inv_purchase_order_dtlDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnpo_no = Me.Columns("po_no")
            Me.columnitem_no = Me.Columns("item_no")
            Me.columnqty = Me.Columns("qty")
            Me.columndesc_item = Me.Columns("desc_item")
            Me.columnReplCost = Me.Columns("ReplCost")
            Me.columnfet = Me.Columns("fet")
            Me.columncod_vendor = Me.Columns("cod_vendor")
            Me.columnExtCost = Me.Columns("ExtCost")
        End Sub
        
        Private Sub InitClass()
            Me.columnpo_no = New DataColumn("po_no", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpo_no)
            Me.columnitem_no = New DataColumn("item_no", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnitem_no)
            Me.columnqty = New DataColumn("qty", GetType(System.Single), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnqty)
            Me.columndesc_item = New DataColumn("desc_item", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndesc_item)
            Me.columnReplCost = New DataColumn("ReplCost", GetType(System.Single), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnReplCost)
            Me.columnfet = New DataColumn("fet", GetType(System.Single), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfet)
            Me.columncod_vendor = New DataColumn("cod_vendor", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncod_vendor)
            Me.columnExtCost = New DataColumn("ExtCost", GetType(System.Single), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnExtCost)
            Me.columnpo_no.AllowDBNull = false
            Me.columnitem_no.AllowDBNull = false
            Me.columnReplCost.ReadOnly = true
            Me.columnExtCost.ReadOnly = true
        End Sub
        
        Public Function NewInv_purchase_order_dtlRow() As Inv_purchase_order_dtlRow
            Return CType(Me.NewRow,Inv_purchase_order_dtlRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New Inv_purchase_order_dtlRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(Inv_purchase_order_dtlRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.Inv_purchase_order_dtlRowChangedEvent) Is Nothing) Then
                RaiseEvent Inv_purchase_order_dtlRowChanged(Me, New Inv_purchase_order_dtlRowChangeEvent(CType(e.Row,Inv_purchase_order_dtlRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.Inv_purchase_order_dtlRowChangingEvent) Is Nothing) Then
                RaiseEvent Inv_purchase_order_dtlRowChanging(Me, New Inv_purchase_order_dtlRowChangeEvent(CType(e.Row,Inv_purchase_order_dtlRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.Inv_purchase_order_dtlRowDeletedEvent) Is Nothing) Then
                RaiseEvent Inv_purchase_order_dtlRowDeleted(Me, New Inv_purchase_order_dtlRowChangeEvent(CType(e.Row,Inv_purchase_order_dtlRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.Inv_purchase_order_dtlRowDeletingEvent) Is Nothing) Then
                RaiseEvent Inv_purchase_order_dtlRowDeleting(Me, New Inv_purchase_order_dtlRowChangeEvent(CType(e.Row,Inv_purchase_order_dtlRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveInv_purchase_order_dtlRow(ByVal row As Inv_purchase_order_dtlRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Inv_purchase_order_dtlRow
        Inherits DataRow
        
        Private tableInv_purchase_order_dtl As Inv_purchase_order_dtlDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableInv_purchase_order_dtl = CType(Me.Table,Inv_purchase_order_dtlDataTable)
        End Sub
        
        Public Property po_no As String
            Get
                Return CType(Me(Me.tableInv_purchase_order_dtl.po_noColumn),String)
            End Get
            Set
                Me(Me.tableInv_purchase_order_dtl.po_noColumn) = value
            End Set
        End Property
        
        Public Property item_no As String
            Get
                Return CType(Me(Me.tableInv_purchase_order_dtl.item_noColumn),String)
            End Get
            Set
                Me(Me.tableInv_purchase_order_dtl.item_noColumn) = value
            End Set
        End Property
        
        Public Property qty As Single
            Get
                Try 
                    Return CType(Me(Me.tableInv_purchase_order_dtl.qtyColumn),Single)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableInv_purchase_order_dtl.qtyColumn) = value
            End Set
        End Property
        
        Public Property desc_item As String
            Get
                Try 
                    Return CType(Me(Me.tableInv_purchase_order_dtl.desc_itemColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableInv_purchase_order_dtl.desc_itemColumn) = value
            End Set
        End Property
        
        Public Property ReplCost As Single
            Get
                Try 
                    Return CType(Me(Me.tableInv_purchase_order_dtl.ReplCostColumn),Single)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableInv_purchase_order_dtl.ReplCostColumn) = value
            End Set
        End Property
        
        Public Property fet As Single
            Get
                Try 
                    Return CType(Me(Me.tableInv_purchase_order_dtl.fetColumn),Single)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableInv_purchase_order_dtl.fetColumn) = value
            End Set
        End Property
        
        Public Property cod_vendor As String
            Get
                Try 
                    Return CType(Me(Me.tableInv_purchase_order_dtl.cod_vendorColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableInv_purchase_order_dtl.cod_vendorColumn) = value
            End Set
        End Property
        
        Public Property ExtCost As Single
            Get
                Try 
                    Return CType(Me(Me.tableInv_purchase_order_dtl.ExtCostColumn),Single)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableInv_purchase_order_dtl.ExtCostColumn) = value
            End Set
        End Property
        
        Public Function IsqtyNull() As Boolean
            Return Me.IsNull(Me.tableInv_purchase_order_dtl.qtyColumn)
        End Function
        
        Public Sub SetqtyNull()
            Me(Me.tableInv_purchase_order_dtl.qtyColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isdesc_itemNull() As Boolean
            Return Me.IsNull(Me.tableInv_purchase_order_dtl.desc_itemColumn)
        End Function
        
        Public Sub Setdesc_itemNull()
            Me(Me.tableInv_purchase_order_dtl.desc_itemColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsReplCostNull() As Boolean
            Return Me.IsNull(Me.tableInv_purchase_order_dtl.ReplCostColumn)
        End Function
        
        Public Sub SetReplCostNull()
            Me(Me.tableInv_purchase_order_dtl.ReplCostColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsfetNull() As Boolean
            Return Me.IsNull(Me.tableInv_purchase_order_dtl.fetColumn)
        End Function
        
        Public Sub SetfetNull()
            Me(Me.tableInv_purchase_order_dtl.fetColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Iscod_vendorNull() As Boolean
            Return Me.IsNull(Me.tableInv_purchase_order_dtl.cod_vendorColumn)
        End Function
        
        Public Sub Setcod_vendorNull()
            Me(Me.tableInv_purchase_order_dtl.cod_vendorColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsExtCostNull() As Boolean
            Return Me.IsNull(Me.tableInv_purchase_order_dtl.ExtCostColumn)
        End Function
        
        Public Sub SetExtCostNull()
            Me(Me.tableInv_purchase_order_dtl.ExtCostColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Inv_purchase_order_dtlRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As Inv_purchase_order_dtlRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As Inv_purchase_order_dtlRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As Inv_purchase_order_dtlRow
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
