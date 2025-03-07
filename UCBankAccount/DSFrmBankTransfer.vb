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
Public Class DSFrmBankTransfer
    Inherits DataSet
    
    Private tablebas_banks As bas_banksDataTable
    
    Private tablebas_banks1 As bas_banks1DataTable
    
    Private tableGL_transfer_amount As GL_transfer_amountDataTable
    
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
            If (Not (ds.Tables("bas_banks")) Is Nothing) Then
                Me.Tables.Add(New bas_banksDataTable(ds.Tables("bas_banks")))
            End If
            If (Not (ds.Tables("bas_banks1")) Is Nothing) Then
                Me.Tables.Add(New bas_banks1DataTable(ds.Tables("bas_banks1")))
            End If
            If (Not (ds.Tables("GL_transfer_amount")) Is Nothing) Then
                Me.Tables.Add(New GL_transfer_amountDataTable(ds.Tables("GL_transfer_amount")))
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
    Public ReadOnly Property bas_banks As bas_banksDataTable
        Get
            Return Me.tablebas_banks
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property bas_banks1 As bas_banks1DataTable
        Get
            Return Me.tablebas_banks1
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property GL_transfer_amount As GL_transfer_amountDataTable
        Get
            Return Me.tableGL_transfer_amount
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DSFrmBankTransfer = CType(MyBase.Clone,DSFrmBankTransfer)
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
        If (Not (ds.Tables("bas_banks")) Is Nothing) Then
            Me.Tables.Add(New bas_banksDataTable(ds.Tables("bas_banks")))
        End If
        If (Not (ds.Tables("bas_banks1")) Is Nothing) Then
            Me.Tables.Add(New bas_banks1DataTable(ds.Tables("bas_banks1")))
        End If
        If (Not (ds.Tables("GL_transfer_amount")) Is Nothing) Then
            Me.Tables.Add(New GL_transfer_amountDataTable(ds.Tables("GL_transfer_amount")))
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
        Me.tablebas_banks = CType(Me.Tables("bas_banks"),bas_banksDataTable)
        If (Not (Me.tablebas_banks) Is Nothing) Then
            Me.tablebas_banks.InitVars
        End If
        Me.tablebas_banks1 = CType(Me.Tables("bas_banks1"),bas_banks1DataTable)
        If (Not (Me.tablebas_banks1) Is Nothing) Then
            Me.tablebas_banks1.InitVars
        End If
        Me.tableGL_transfer_amount = CType(Me.Tables("GL_transfer_amount"),GL_transfer_amountDataTable)
        If (Not (Me.tableGL_transfer_amount) Is Nothing) Then
            Me.tableGL_transfer_amount.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DSFrmBankTransfer"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DSFrmBankTransfer.xsd"
        Me.Locale = New System.Globalization.CultureInfo("fa-IR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablebas_banks = New bas_banksDataTable
        Me.Tables.Add(Me.tablebas_banks)
        Me.tablebas_banks1 = New bas_banks1DataTable
        Me.Tables.Add(Me.tablebas_banks1)
        Me.tableGL_transfer_amount = New GL_transfer_amountDataTable
        Me.Tables.Add(Me.tableGL_transfer_amount)
    End Sub
    
    Private Function ShouldSerializebas_banks() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializebas_banks1() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeGL_transfer_amount() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub bas_banksRowChangeEventHandler(ByVal sender As Object, ByVal e As bas_banksRowChangeEvent)
    
    Public Delegate Sub bas_banks1RowChangeEventHandler(ByVal sender As Object, ByVal e As bas_banks1RowChangeEvent)
    
    Public Delegate Sub GL_transfer_amountRowChangeEventHandler(ByVal sender As Object, ByVal e As GL_transfer_amountRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class bas_banksDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnid_bank As DataColumn
        
        Private columnname_bank As DataColumn
        
        Friend Sub New()
            MyBase.New("bas_banks")
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
        
        Friend ReadOnly Property id_bankColumn As DataColumn
            Get
                Return Me.columnid_bank
            End Get
        End Property
        
        Friend ReadOnly Property name_bankColumn As DataColumn
            Get
                Return Me.columnname_bank
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As bas_banksRow
            Get
                Return CType(Me.Rows(index),bas_banksRow)
            End Get
        End Property
        
        Public Event bas_banksRowChanged As bas_banksRowChangeEventHandler
        
        Public Event bas_banksRowChanging As bas_banksRowChangeEventHandler
        
        Public Event bas_banksRowDeleted As bas_banksRowChangeEventHandler
        
        Public Event bas_banksRowDeleting As bas_banksRowChangeEventHandler
        
        Public Overloads Sub Addbas_banksRow(ByVal row As bas_banksRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addbas_banksRow(ByVal name_bank As String) As bas_banksRow
            Dim rowbas_banksRow As bas_banksRow = CType(Me.NewRow,bas_banksRow)
            rowbas_banksRow.ItemArray = New Object() {Nothing, name_bank}
            Me.Rows.Add(rowbas_banksRow)
            Return rowbas_banksRow
        End Function
        
        Public Function FindByid_bank(ByVal id_bank As Short) As bas_banksRow
            Return CType(Me.Rows.Find(New Object() {id_bank}),bas_banksRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As bas_banksDataTable = CType(MyBase.Clone,bas_banksDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New bas_banksDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnid_bank = Me.Columns("id_bank")
            Me.columnname_bank = Me.Columns("name_bank")
        End Sub
        
        Private Sub InitClass()
            Me.columnid_bank = New DataColumn("id_bank", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnid_bank)
            Me.columnname_bank = New DataColumn("name_bank", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnname_bank)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnid_bank}, true))
            Me.columnid_bank.AutoIncrement = true
            Me.columnid_bank.AllowDBNull = false
            Me.columnid_bank.ReadOnly = true
            Me.columnid_bank.Unique = true
        End Sub
        
        Public Function Newbas_banksRow() As bas_banksRow
            Return CType(Me.NewRow,bas_banksRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New bas_banksRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(bas_banksRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.bas_banksRowChangedEvent) Is Nothing) Then
                RaiseEvent bas_banksRowChanged(Me, New bas_banksRowChangeEvent(CType(e.Row,bas_banksRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.bas_banksRowChangingEvent) Is Nothing) Then
                RaiseEvent bas_banksRowChanging(Me, New bas_banksRowChangeEvent(CType(e.Row,bas_banksRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.bas_banksRowDeletedEvent) Is Nothing) Then
                RaiseEvent bas_banksRowDeleted(Me, New bas_banksRowChangeEvent(CType(e.Row,bas_banksRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.bas_banksRowDeletingEvent) Is Nothing) Then
                RaiseEvent bas_banksRowDeleting(Me, New bas_banksRowChangeEvent(CType(e.Row,bas_banksRow), e.Action))
            End If
        End Sub
        
        Public Sub Removebas_banksRow(ByVal row As bas_banksRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class bas_banksRow
        Inherits DataRow
        
        Private tablebas_banks As bas_banksDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablebas_banks = CType(Me.Table,bas_banksDataTable)
        End Sub
        
        Public Property id_bank As Short
            Get
                Return CType(Me(Me.tablebas_banks.id_bankColumn),Short)
            End Get
            Set
                Me(Me.tablebas_banks.id_bankColumn) = value
            End Set
        End Property
        
        Public Property name_bank As String
            Get
                Try 
                    Return CType(Me(Me.tablebas_banks.name_bankColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablebas_banks.name_bankColumn) = value
            End Set
        End Property
        
        Public Function Isname_bankNull() As Boolean
            Return Me.IsNull(Me.tablebas_banks.name_bankColumn)
        End Function
        
        Public Sub Setname_bankNull()
            Me(Me.tablebas_banks.name_bankColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class bas_banksRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As bas_banksRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As bas_banksRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As bas_banksRow
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
    Public Class bas_banks1DataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnid_bank As DataColumn
        
        Private columnname_bank As DataColumn
        
        Friend Sub New()
            MyBase.New("bas_banks1")
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
        
        Friend ReadOnly Property id_bankColumn As DataColumn
            Get
                Return Me.columnid_bank
            End Get
        End Property
        
        Friend ReadOnly Property name_bankColumn As DataColumn
            Get
                Return Me.columnname_bank
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As bas_banks1Row
            Get
                Return CType(Me.Rows(index),bas_banks1Row)
            End Get
        End Property
        
        Public Event bas_banks1RowChanged As bas_banks1RowChangeEventHandler
        
        Public Event bas_banks1RowChanging As bas_banks1RowChangeEventHandler
        
        Public Event bas_banks1RowDeleted As bas_banks1RowChangeEventHandler
        
        Public Event bas_banks1RowDeleting As bas_banks1RowChangeEventHandler
        
        Public Overloads Sub Addbas_banks1Row(ByVal row As bas_banks1Row)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addbas_banks1Row(ByVal name_bank As String) As bas_banks1Row
            Dim rowbas_banks1Row As bas_banks1Row = CType(Me.NewRow,bas_banks1Row)
            rowbas_banks1Row.ItemArray = New Object() {Nothing, name_bank}
            Me.Rows.Add(rowbas_banks1Row)
            Return rowbas_banks1Row
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As bas_banks1DataTable = CType(MyBase.Clone,bas_banks1DataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New bas_banks1DataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnid_bank = Me.Columns("id_bank")
            Me.columnname_bank = Me.Columns("name_bank")
        End Sub
        
        Private Sub InitClass()
            Me.columnid_bank = New DataColumn("id_bank", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnid_bank)
            Me.columnname_bank = New DataColumn("name_bank", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnname_bank)
            Me.columnid_bank.AutoIncrement = true
            Me.columnid_bank.AllowDBNull = false
            Me.columnid_bank.ReadOnly = true
        End Sub
        
        Public Function Newbas_banks1Row() As bas_banks1Row
            Return CType(Me.NewRow,bas_banks1Row)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New bas_banks1Row(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(bas_banks1Row)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.bas_banks1RowChangedEvent) Is Nothing) Then
                RaiseEvent bas_banks1RowChanged(Me, New bas_banks1RowChangeEvent(CType(e.Row,bas_banks1Row), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.bas_banks1RowChangingEvent) Is Nothing) Then
                RaiseEvent bas_banks1RowChanging(Me, New bas_banks1RowChangeEvent(CType(e.Row,bas_banks1Row), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.bas_banks1RowDeletedEvent) Is Nothing) Then
                RaiseEvent bas_banks1RowDeleted(Me, New bas_banks1RowChangeEvent(CType(e.Row,bas_banks1Row), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.bas_banks1RowDeletingEvent) Is Nothing) Then
                RaiseEvent bas_banks1RowDeleting(Me, New bas_banks1RowChangeEvent(CType(e.Row,bas_banks1Row), e.Action))
            End If
        End Sub
        
        Public Sub Removebas_banks1Row(ByVal row As bas_banks1Row)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class bas_banks1Row
        Inherits DataRow
        
        Private tablebas_banks1 As bas_banks1DataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablebas_banks1 = CType(Me.Table,bas_banks1DataTable)
        End Sub
        
        Public Property id_bank As Short
            Get
                Return CType(Me(Me.tablebas_banks1.id_bankColumn),Short)
            End Get
            Set
                Me(Me.tablebas_banks1.id_bankColumn) = value
            End Set
        End Property
        
        Public Property name_bank As String
            Get
                Try 
                    Return CType(Me(Me.tablebas_banks1.name_bankColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablebas_banks1.name_bankColumn) = value
            End Set
        End Property
        
        Public Function Isname_bankNull() As Boolean
            Return Me.IsNull(Me.tablebas_banks1.name_bankColumn)
        End Function
        
        Public Sub Setname_bankNull()
            Me(Me.tablebas_banks1.name_bankColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class bas_banks1RowChangeEvent
        Inherits EventArgs
        
        Private eventRow As bas_banks1Row
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As bas_banks1Row, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As bas_banks1Row
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
    Public Class GL_transfer_amountDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnid_transfer As DataColumn
        
        Private columnid_bank_from_transfer As DataColumn
        
        Private columnid_bank_to_transfer As DataColumn
        
        Private columndate_transfer As DataColumn
        
        Private columnamount_transfer As DataColumn
        
        Friend Sub New()
            MyBase.New("GL_transfer_amount")
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
        
        Friend ReadOnly Property id_transferColumn As DataColumn
            Get
                Return Me.columnid_transfer
            End Get
        End Property
        
        Friend ReadOnly Property id_bank_from_transferColumn As DataColumn
            Get
                Return Me.columnid_bank_from_transfer
            End Get
        End Property
        
        Friend ReadOnly Property id_bank_to_transferColumn As DataColumn
            Get
                Return Me.columnid_bank_to_transfer
            End Get
        End Property
        
        Friend ReadOnly Property date_transferColumn As DataColumn
            Get
                Return Me.columndate_transfer
            End Get
        End Property
        
        Friend ReadOnly Property amount_transferColumn As DataColumn
            Get
                Return Me.columnamount_transfer
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As GL_transfer_amountRow
            Get
                Return CType(Me.Rows(index),GL_transfer_amountRow)
            End Get
        End Property
        
        Public Event GL_transfer_amountRowChanged As GL_transfer_amountRowChangeEventHandler
        
        Public Event GL_transfer_amountRowChanging As GL_transfer_amountRowChangeEventHandler
        
        Public Event GL_transfer_amountRowDeleted As GL_transfer_amountRowChangeEventHandler
        
        Public Event GL_transfer_amountRowDeleting As GL_transfer_amountRowChangeEventHandler
        
        Public Overloads Sub AddGL_transfer_amountRow(ByVal row As GL_transfer_amountRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddGL_transfer_amountRow(ByVal id_bank_from_transfer As Integer, ByVal id_bank_to_transfer As Integer, ByVal date_transfer As String, ByVal amount_transfer As Decimal) As GL_transfer_amountRow
            Dim rowGL_transfer_amountRow As GL_transfer_amountRow = CType(Me.NewRow,GL_transfer_amountRow)
            rowGL_transfer_amountRow.ItemArray = New Object() {Nothing, id_bank_from_transfer, id_bank_to_transfer, date_transfer, amount_transfer}
            Me.Rows.Add(rowGL_transfer_amountRow)
            Return rowGL_transfer_amountRow
        End Function
        
        Public Function FindByid_transfer(ByVal id_transfer As Integer) As GL_transfer_amountRow
            Return CType(Me.Rows.Find(New Object() {id_transfer}),GL_transfer_amountRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As GL_transfer_amountDataTable = CType(MyBase.Clone,GL_transfer_amountDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New GL_transfer_amountDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnid_transfer = Me.Columns("id_transfer")
            Me.columnid_bank_from_transfer = Me.Columns("id_bank_from_transfer")
            Me.columnid_bank_to_transfer = Me.Columns("id_bank_to_transfer")
            Me.columndate_transfer = Me.Columns("date_transfer")
            Me.columnamount_transfer = Me.Columns("amount_transfer")
        End Sub
        
        Private Sub InitClass()
            Me.columnid_transfer = New DataColumn("id_transfer", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnid_transfer)
            Me.columnid_bank_from_transfer = New DataColumn("id_bank_from_transfer", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnid_bank_from_transfer)
            Me.columnid_bank_to_transfer = New DataColumn("id_bank_to_transfer", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnid_bank_to_transfer)
            Me.columndate_transfer = New DataColumn("date_transfer", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndate_transfer)
            Me.columnamount_transfer = New DataColumn("amount_transfer", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnamount_transfer)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnid_transfer}, true))
            Me.columnid_transfer.AutoIncrement = true
            Me.columnid_transfer.AllowDBNull = false
            Me.columnid_transfer.ReadOnly = true
            Me.columnid_transfer.Unique = true
        End Sub
        
        Public Function NewGL_transfer_amountRow() As GL_transfer_amountRow
            Return CType(Me.NewRow,GL_transfer_amountRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New GL_transfer_amountRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(GL_transfer_amountRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.GL_transfer_amountRowChangedEvent) Is Nothing) Then
                RaiseEvent GL_transfer_amountRowChanged(Me, New GL_transfer_amountRowChangeEvent(CType(e.Row,GL_transfer_amountRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.GL_transfer_amountRowChangingEvent) Is Nothing) Then
                RaiseEvent GL_transfer_amountRowChanging(Me, New GL_transfer_amountRowChangeEvent(CType(e.Row,GL_transfer_amountRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.GL_transfer_amountRowDeletedEvent) Is Nothing) Then
                RaiseEvent GL_transfer_amountRowDeleted(Me, New GL_transfer_amountRowChangeEvent(CType(e.Row,GL_transfer_amountRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.GL_transfer_amountRowDeletingEvent) Is Nothing) Then
                RaiseEvent GL_transfer_amountRowDeleting(Me, New GL_transfer_amountRowChangeEvent(CType(e.Row,GL_transfer_amountRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveGL_transfer_amountRow(ByVal row As GL_transfer_amountRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class GL_transfer_amountRow
        Inherits DataRow
        
        Private tableGL_transfer_amount As GL_transfer_amountDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableGL_transfer_amount = CType(Me.Table,GL_transfer_amountDataTable)
        End Sub
        
        Public Property id_transfer As Integer
            Get
                Return CType(Me(Me.tableGL_transfer_amount.id_transferColumn),Integer)
            End Get
            Set
                Me(Me.tableGL_transfer_amount.id_transferColumn) = value
            End Set
        End Property
        
        Public Property id_bank_from_transfer As Integer
            Get
                Try 
                    Return CType(Me(Me.tableGL_transfer_amount.id_bank_from_transferColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_transfer_amount.id_bank_from_transferColumn) = value
            End Set
        End Property
        
        Public Property id_bank_to_transfer As Integer
            Get
                Try 
                    Return CType(Me(Me.tableGL_transfer_amount.id_bank_to_transferColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_transfer_amount.id_bank_to_transferColumn) = value
            End Set
        End Property
        
        Public Property date_transfer As String
            Get
                Try 
                    Return CType(Me(Me.tableGL_transfer_amount.date_transferColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_transfer_amount.date_transferColumn) = value
            End Set
        End Property
        
        Public Property amount_transfer As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableGL_transfer_amount.amount_transferColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_transfer_amount.amount_transferColumn) = value
            End Set
        End Property
        
        Public Function Isid_bank_from_transferNull() As Boolean
            Return Me.IsNull(Me.tableGL_transfer_amount.id_bank_from_transferColumn)
        End Function
        
        Public Sub Setid_bank_from_transferNull()
            Me(Me.tableGL_transfer_amount.id_bank_from_transferColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isid_bank_to_transferNull() As Boolean
            Return Me.IsNull(Me.tableGL_transfer_amount.id_bank_to_transferColumn)
        End Function
        
        Public Sub Setid_bank_to_transferNull()
            Me(Me.tableGL_transfer_amount.id_bank_to_transferColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isdate_transferNull() As Boolean
            Return Me.IsNull(Me.tableGL_transfer_amount.date_transferColumn)
        End Function
        
        Public Sub Setdate_transferNull()
            Me(Me.tableGL_transfer_amount.date_transferColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isamount_transferNull() As Boolean
            Return Me.IsNull(Me.tableGL_transfer_amount.amount_transferColumn)
        End Function
        
        Public Sub Setamount_transferNull()
            Me(Me.tableGL_transfer_amount.amount_transferColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class GL_transfer_amountRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As GL_transfer_amountRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As GL_transfer_amountRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As GL_transfer_amountRow
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
