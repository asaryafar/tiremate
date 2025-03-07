﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace schedule_manager {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class S_DataSet : DataSet {
        
        private appointmentsDataTable tableappointments;
        
        public S_DataSet() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected S_DataSet(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["appointments"] != null)) {
                    this.Tables.Add(new appointmentsDataTable(ds.Tables["appointments"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public appointmentsDataTable appointments {
            get {
                return this.tableappointments;
            }
        }
        
        public override DataSet Clone() {
            S_DataSet cln = ((S_DataSet)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["appointments"] != null)) {
                this.Tables.Add(new appointmentsDataTable(ds.Tables["appointments"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableappointments = ((appointmentsDataTable)(this.Tables["appointments"]));
            if ((this.tableappointments != null)) {
                this.tableappointments.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "S_DataSet";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/S_DataSet.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableappointments = new appointmentsDataTable();
            this.Tables.Add(this.tableappointments);
        }
        
        private bool ShouldSerializeappointments() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void appointmentsRowChangeEventHandler(object sender, appointmentsRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class appointmentsDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnAppointmentID;
            
            private DataColumn columnEmployeeID;
            
            private DataColumn columnSubject;
            
            private DataColumn columnDescription;
            
            private DataColumn columnStartDate;
            
            private DataColumn columnEndDate;
            
            private DataColumn columnAppointmentCategoryID;
            
            private DataColumn columnRecurrencePattern;
            
            private DataColumn columnAppointmentLayout;
            
            internal appointmentsDataTable() : 
                    base("appointments") {
                this.InitClass();
            }
            
            internal appointmentsDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn AppointmentIDColumn {
                get {
                    return this.columnAppointmentID;
                }
            }
            
            internal DataColumn EmployeeIDColumn {
                get {
                    return this.columnEmployeeID;
                }
            }
            
            internal DataColumn SubjectColumn {
                get {
                    return this.columnSubject;
                }
            }
            
            internal DataColumn DescriptionColumn {
                get {
                    return this.columnDescription;
                }
            }
            
            internal DataColumn StartDateColumn {
                get {
                    return this.columnStartDate;
                }
            }
            
            internal DataColumn EndDateColumn {
                get {
                    return this.columnEndDate;
                }
            }
            
            internal DataColumn AppointmentCategoryIDColumn {
                get {
                    return this.columnAppointmentCategoryID;
                }
            }
            
            internal DataColumn RecurrencePatternColumn {
                get {
                    return this.columnRecurrencePattern;
                }
            }
            
            internal DataColumn AppointmentLayoutColumn {
                get {
                    return this.columnAppointmentLayout;
                }
            }
            
            public appointmentsRow this[int index] {
                get {
                    return ((appointmentsRow)(this.Rows[index]));
                }
            }
            
            public event appointmentsRowChangeEventHandler appointmentsRowChanged;
            
            public event appointmentsRowChangeEventHandler appointmentsRowChanging;
            
            public event appointmentsRowChangeEventHandler appointmentsRowDeleted;
            
            public event appointmentsRowChangeEventHandler appointmentsRowDeleting;
            
            public void AddappointmentsRow(appointmentsRow row) {
                this.Rows.Add(row);
            }
            
            public appointmentsRow AddappointmentsRow(long EmployeeID, string Subject, string Description, System.DateTime StartDate, System.DateTime EndDate, int AppointmentCategoryID, string RecurrencePattern, string AppointmentLayout) {
                appointmentsRow rowappointmentsRow = ((appointmentsRow)(this.NewRow()));
                rowappointmentsRow.ItemArray = new object[] {
                        null,
                        EmployeeID,
                        Subject,
                        Description,
                        StartDate,
                        EndDate,
                        AppointmentCategoryID,
                        RecurrencePattern,
                        AppointmentLayout};
                this.Rows.Add(rowappointmentsRow);
                return rowappointmentsRow;
            }
            
            public appointmentsRow FindByAppointmentID(long AppointmentID) {
                return ((appointmentsRow)(this.Rows.Find(new object[] {
                            AppointmentID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                appointmentsDataTable cln = ((appointmentsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new appointmentsDataTable();
            }
            
            internal void InitVars() {
                this.columnAppointmentID = this.Columns["AppointmentID"];
                this.columnEmployeeID = this.Columns["EmployeeID"];
                this.columnSubject = this.Columns["Subject"];
                this.columnDescription = this.Columns["Description"];
                this.columnStartDate = this.Columns["StartDate"];
                this.columnEndDate = this.Columns["EndDate"];
                this.columnAppointmentCategoryID = this.Columns["AppointmentCategoryID"];
                this.columnRecurrencePattern = this.Columns["RecurrencePattern"];
                this.columnAppointmentLayout = this.Columns["AppointmentLayout"];
            }
            
            private void InitClass() {
                this.columnAppointmentID = new DataColumn("AppointmentID", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAppointmentID);
                this.columnEmployeeID = new DataColumn("EmployeeID", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnEmployeeID);
                this.columnSubject = new DataColumn("Subject", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSubject);
                this.columnDescription = new DataColumn("Description", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescription);
                this.columnStartDate = new DataColumn("StartDate", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnStartDate);
                this.columnEndDate = new DataColumn("EndDate", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnEndDate);
                this.columnAppointmentCategoryID = new DataColumn("AppointmentCategoryID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAppointmentCategoryID);
                this.columnRecurrencePattern = new DataColumn("RecurrencePattern", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRecurrencePattern);
                this.columnAppointmentLayout = new DataColumn("AppointmentLayout", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAppointmentLayout);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnAppointmentID}, true));
                this.columnAppointmentID.AutoIncrement = true;
                this.columnAppointmentID.AllowDBNull = false;
                this.columnAppointmentID.ReadOnly = true;
                this.columnAppointmentID.Unique = true;
            }
            
            public appointmentsRow NewappointmentsRow() {
                return ((appointmentsRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new appointmentsRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(appointmentsRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.appointmentsRowChanged != null)) {
                    this.appointmentsRowChanged(this, new appointmentsRowChangeEvent(((appointmentsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.appointmentsRowChanging != null)) {
                    this.appointmentsRowChanging(this, new appointmentsRowChangeEvent(((appointmentsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.appointmentsRowDeleted != null)) {
                    this.appointmentsRowDeleted(this, new appointmentsRowChangeEvent(((appointmentsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.appointmentsRowDeleting != null)) {
                    this.appointmentsRowDeleting(this, new appointmentsRowChangeEvent(((appointmentsRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveappointmentsRow(appointmentsRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class appointmentsRow : DataRow {
            
            private appointmentsDataTable tableappointments;
            
            internal appointmentsRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableappointments = ((appointmentsDataTable)(this.Table));
            }
            
            public long AppointmentID {
                get {
                    return ((long)(this[this.tableappointments.AppointmentIDColumn]));
                }
                set {
                    this[this.tableappointments.AppointmentIDColumn] = value;
                }
            }
            
            public long EmployeeID {
                get {
                    try {
                        return ((long)(this[this.tableappointments.EmployeeIDColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableappointments.EmployeeIDColumn] = value;
                }
            }
            
            public string Subject {
                get {
                    try {
                        return ((string)(this[this.tableappointments.SubjectColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableappointments.SubjectColumn] = value;
                }
            }
            
            public string Description {
                get {
                    try {
                        return ((string)(this[this.tableappointments.DescriptionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableappointments.DescriptionColumn] = value;
                }
            }
            
            public System.DateTime StartDate {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableappointments.StartDateColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableappointments.StartDateColumn] = value;
                }
            }
            
            public System.DateTime EndDate {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableappointments.EndDateColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableappointments.EndDateColumn] = value;
                }
            }
            
            public int AppointmentCategoryID {
                get {
                    try {
                        return ((int)(this[this.tableappointments.AppointmentCategoryIDColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableappointments.AppointmentCategoryIDColumn] = value;
                }
            }
            
            public string RecurrencePattern {
                get {
                    try {
                        return ((string)(this[this.tableappointments.RecurrencePatternColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableappointments.RecurrencePatternColumn] = value;
                }
            }
            
            public string AppointmentLayout {
                get {
                    try {
                        return ((string)(this[this.tableappointments.AppointmentLayoutColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableappointments.AppointmentLayoutColumn] = value;
                }
            }
            
            public bool IsEmployeeIDNull() {
                return this.IsNull(this.tableappointments.EmployeeIDColumn);
            }
            
            public void SetEmployeeIDNull() {
                this[this.tableappointments.EmployeeIDColumn] = System.Convert.DBNull;
            }
            
            public bool IsSubjectNull() {
                return this.IsNull(this.tableappointments.SubjectColumn);
            }
            
            public void SetSubjectNull() {
                this[this.tableappointments.SubjectColumn] = System.Convert.DBNull;
            }
            
            public bool IsDescriptionNull() {
                return this.IsNull(this.tableappointments.DescriptionColumn);
            }
            
            public void SetDescriptionNull() {
                this[this.tableappointments.DescriptionColumn] = System.Convert.DBNull;
            }
            
            public bool IsStartDateNull() {
                return this.IsNull(this.tableappointments.StartDateColumn);
            }
            
            public void SetStartDateNull() {
                this[this.tableappointments.StartDateColumn] = System.Convert.DBNull;
            }
            
            public bool IsEndDateNull() {
                return this.IsNull(this.tableappointments.EndDateColumn);
            }
            
            public void SetEndDateNull() {
                this[this.tableappointments.EndDateColumn] = System.Convert.DBNull;
            }
            
            public bool IsAppointmentCategoryIDNull() {
                return this.IsNull(this.tableappointments.AppointmentCategoryIDColumn);
            }
            
            public void SetAppointmentCategoryIDNull() {
                this[this.tableappointments.AppointmentCategoryIDColumn] = System.Convert.DBNull;
            }
            
            public bool IsRecurrencePatternNull() {
                return this.IsNull(this.tableappointments.RecurrencePatternColumn);
            }
            
            public void SetRecurrencePatternNull() {
                this[this.tableappointments.RecurrencePatternColumn] = System.Convert.DBNull;
            }
            
            public bool IsAppointmentLayoutNull() {
                return this.IsNull(this.tableappointments.AppointmentLayoutColumn);
            }
            
            public void SetAppointmentLayoutNull() {
                this[this.tableappointments.AppointmentLayoutColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class appointmentsRowChangeEvent : EventArgs {
            
            private appointmentsRow eventRow;
            
            private DataRowAction eventAction;
            
            public appointmentsRowChangeEvent(appointmentsRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public appointmentsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
