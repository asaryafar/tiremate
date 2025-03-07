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
Public Class DSFrmEndOfDayCreditCardInvoices
    Inherits DataSet
    
    Private tableGL_payment_credit As GL_payment_creditDataTable
    
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
            If (Not (ds.Tables("GL_payment_credit")) Is Nothing) Then
                Me.Tables.Add(New GL_payment_creditDataTable(ds.Tables("GL_payment_credit")))
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
    Public ReadOnly Property GL_payment_credit As GL_payment_creditDataTable
        Get
            Return Me.tableGL_payment_credit
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DSFrmEndOfDayCreditCardInvoices = CType(MyBase.Clone,DSFrmEndOfDayCreditCardInvoices)
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
        If (Not (ds.Tables("GL_payment_credit")) Is Nothing) Then
            Me.Tables.Add(New GL_payment_creditDataTable(ds.Tables("GL_payment_credit")))
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
        Me.tableGL_payment_credit = CType(Me.Tables("GL_payment_credit"),GL_payment_creditDataTable)
        If (Not (Me.tableGL_payment_credit) Is Nothing) Then
            Me.tableGL_payment_credit.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DSFrmEndOfDayCreditCardInvoices"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DSFrmEndOfDayCreditCardInvoices.xsd"
        Me.Locale = New System.Globalization.CultureInfo("fa-IR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableGL_payment_credit = New GL_payment_creditDataTable
        Me.Tables.Add(Me.tableGL_payment_credit)
    End Sub
    
    Private Function ShouldSerializeGL_payment_credit() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub GL_payment_creditRowChangeEventHandler(ByVal sender As Object, ByVal e As GL_payment_creditRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class GL_payment_creditDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnid_service_center As DataColumn
        
        Private columndate_refer As DataColumn
        
        Private columnTotal As DataColumn
        
        Private columnfullname As DataColumn
        
        Private columnabbreviation_name As DataColumn
        
        Private columnpayment_amount As DataColumn
        
        Private columncc_type_desc As DataColumn
        
        Friend Sub New()
            MyBase.New("GL_payment_credit")
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
        
        Friend ReadOnly Property TotalColumn As DataColumn
            Get
                Return Me.columnTotal
            End Get
        End Property
        
        Friend ReadOnly Property fullnameColumn As DataColumn
            Get
                Return Me.columnfullname
            End Get
        End Property
        
        Friend ReadOnly Property abbreviation_nameColumn As DataColumn
            Get
                Return Me.columnabbreviation_name
            End Get
        End Property
        
        Friend ReadOnly Property payment_amountColumn As DataColumn
            Get
                Return Me.columnpayment_amount
            End Get
        End Property
        
        Friend ReadOnly Property cc_type_descColumn As DataColumn
            Get
                Return Me.columncc_type_desc
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As GL_payment_creditRow
            Get
                Return CType(Me.Rows(index),GL_payment_creditRow)
            End Get
        End Property
        
        Public Event GL_payment_creditRowChanged As GL_payment_creditRowChangeEventHandler
        
        Public Event GL_payment_creditRowChanging As GL_payment_creditRowChangeEventHandler
        
        Public Event GL_payment_creditRowDeleted As GL_payment_creditRowChangeEventHandler
        
        Public Event GL_payment_creditRowDeleting As GL_payment_creditRowChangeEventHandler
        
        Public Overloads Sub AddGL_payment_creditRow(ByVal row As GL_payment_creditRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddGL_payment_creditRow(ByVal id_service_center As String, ByVal date_refer As String, ByVal Total As Decimal, ByVal fullname As String, ByVal abbreviation_name As String, ByVal payment_amount As Decimal, ByVal cc_type_desc As String) As GL_payment_creditRow
            Dim rowGL_payment_creditRow As GL_payment_creditRow = CType(Me.NewRow,GL_payment_creditRow)
            rowGL_payment_creditRow.ItemArray = New Object() {id_service_center, date_refer, Total, fullname, abbreviation_name, payment_amount, cc_type_desc}
            Me.Rows.Add(rowGL_payment_creditRow)
            Return rowGL_payment_creditRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As GL_payment_creditDataTable = CType(MyBase.Clone,GL_payment_creditDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New GL_payment_creditDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnid_service_center = Me.Columns("id_service_center")
            Me.columndate_refer = Me.Columns("date_refer")
            Me.columnTotal = Me.Columns("Total")
            Me.columnfullname = Me.Columns("fullname")
            Me.columnabbreviation_name = Me.Columns("abbreviation_name")
            Me.columnpayment_amount = Me.Columns("payment_amount")
            Me.columncc_type_desc = Me.Columns("cc_type_desc")
        End Sub
        
        Private Sub InitClass()
            Me.columnid_service_center = New DataColumn("id_service_center", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnid_service_center)
            Me.columndate_refer = New DataColumn("date_refer", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndate_refer)
            Me.columnTotal = New DataColumn("Total", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTotal)
            Me.columnfullname = New DataColumn("fullname", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfullname)
            Me.columnabbreviation_name = New DataColumn("abbreviation_name", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnabbreviation_name)
            Me.columnpayment_amount = New DataColumn("payment_amount", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpayment_amount)
            Me.columncc_type_desc = New DataColumn("cc_type_desc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncc_type_desc)
            Me.columnid_service_center.AllowDBNull = false
            Me.columnfullname.ReadOnly = true
        End Sub
        
        Public Function NewGL_payment_creditRow() As GL_payment_creditRow
            Return CType(Me.NewRow,GL_payment_creditRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New GL_payment_creditRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(GL_payment_creditRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.GL_payment_creditRowChangedEvent) Is Nothing) Then
                RaiseEvent GL_payment_creditRowChanged(Me, New GL_payment_creditRowChangeEvent(CType(e.Row,GL_payment_creditRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.GL_payment_creditRowChangingEvent) Is Nothing) Then
                RaiseEvent GL_payment_creditRowChanging(Me, New GL_payment_creditRowChangeEvent(CType(e.Row,GL_payment_creditRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.GL_payment_creditRowDeletedEvent) Is Nothing) Then
                RaiseEvent GL_payment_creditRowDeleted(Me, New GL_payment_creditRowChangeEvent(CType(e.Row,GL_payment_creditRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.GL_payment_creditRowDeletingEvent) Is Nothing) Then
                RaiseEvent GL_payment_creditRowDeleting(Me, New GL_payment_creditRowChangeEvent(CType(e.Row,GL_payment_creditRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveGL_payment_creditRow(ByVal row As GL_payment_creditRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class GL_payment_creditRow
        Inherits DataRow
        
        Private tableGL_payment_credit As GL_payment_creditDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableGL_payment_credit = CType(Me.Table,GL_payment_creditDataTable)
        End Sub
        
        Public Property id_service_center As String
            Get
                Return CType(Me(Me.tableGL_payment_credit.id_service_centerColumn),String)
            End Get
            Set
                Me(Me.tableGL_payment_credit.id_service_centerColumn) = value
            End Set
        End Property
        
        Public Property date_refer As String
            Get
                Try 
                    Return CType(Me(Me.tableGL_payment_credit.date_referColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_payment_credit.date_referColumn) = value
            End Set
        End Property
        
        Public Property Total As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableGL_payment_credit.TotalColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_payment_credit.TotalColumn) = value
            End Set
        End Property
        
        Public Property fullname As String
            Get
                Try 
                    Return CType(Me(Me.tableGL_payment_credit.fullnameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_payment_credit.fullnameColumn) = value
            End Set
        End Property
        
        Public Property abbreviation_name As String
            Get
                Try 
                    Return CType(Me(Me.tableGL_payment_credit.abbreviation_nameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_payment_credit.abbreviation_nameColumn) = value
            End Set
        End Property
        
        Public Property payment_amount As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableGL_payment_credit.payment_amountColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_payment_credit.payment_amountColumn) = value
            End Set
        End Property
        
        Public Property cc_type_desc As String
            Get
                Try 
                    Return CType(Me(Me.tableGL_payment_credit.cc_type_descColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGL_payment_credit.cc_type_descColumn) = value
            End Set
        End Property
        
        Public Function Isdate_referNull() As Boolean
            Return Me.IsNull(Me.tableGL_payment_credit.date_referColumn)
        End Function
        
        Public Sub Setdate_referNull()
            Me(Me.tableGL_payment_credit.date_referColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTotalNull() As Boolean
            Return Me.IsNull(Me.tableGL_payment_credit.TotalColumn)
        End Function
        
        Public Sub SetTotalNull()
            Me(Me.tableGL_payment_credit.TotalColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsfullnameNull() As Boolean
            Return Me.IsNull(Me.tableGL_payment_credit.fullnameColumn)
        End Function
        
        Public Sub SetfullnameNull()
            Me(Me.tableGL_payment_credit.fullnameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isabbreviation_nameNull() As Boolean
            Return Me.IsNull(Me.tableGL_payment_credit.abbreviation_nameColumn)
        End Function
        
        Public Sub Setabbreviation_nameNull()
            Me(Me.tableGL_payment_credit.abbreviation_nameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Ispayment_amountNull() As Boolean
            Return Me.IsNull(Me.tableGL_payment_credit.payment_amountColumn)
        End Function
        
        Public Sub Setpayment_amountNull()
            Me(Me.tableGL_payment_credit.payment_amountColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Iscc_type_descNull() As Boolean
            Return Me.IsNull(Me.tableGL_payment_credit.cc_type_descColumn)
        End Function
        
        Public Sub Setcc_type_descNull()
            Me(Me.tableGL_payment_credit.cc_type_descColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class GL_payment_creditRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As GL_payment_creditRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As GL_payment_creditRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As GL_payment_creditRow
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
