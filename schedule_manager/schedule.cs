using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Janus.Windows.Schedule;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data;



namespace schedule_manager
{
	/// <summary>
	/// Summary description for schedule.
	/// </summary>
	public class schedule : CommonClass.FrmBase
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Janus.Windows.Schedule.Schedule schedule1;
		private Janus.Windows.Schedule.Calendar calendar1;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton Day;
		private System.Windows.Forms.ToolBarButton WorkWeek;
		private System.Windows.Forms.ToolBarButton week;
		private System.Windows.Forms.ToolBarButton month;		
		private System.Windows.Forms.ToolBarButton Save;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter3;
		private schedule_manager.S_DataSet s_DataSet1;
		private System.Windows.Forms.ToolBarButton delete;
		private Janus.Windows.Schedule.SchedulePrintDocument schedulePrintDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.ToolBarButton print_prev;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;		
		private System.Windows.Forms.ToolBarButton new_ap;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ImageList imgAppointments;
		private System.Windows.Forms.ImageList imgMain;
		private System.Windows.Forms.ToolBarButton toolBarspr1;
		private System.Windows.Forms.ToolBarButton prev;
		private System.Windows.Forms.ToolBarButton next;
		private System.Windows.Forms.ToolBarButton toolBarspr2;
		private System.Windows.Forms.ToolBarButton toolBarspr3;
		private System.Windows.Forms.ToolBarButton print;
		private System.Windows.Forms.ToolBarButton toolBarspr4;
		private System.Windows.Forms.ToolBarButton options;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		private System.Windows.Forms.ContextMenu donectm;
		private System.Windows.Forms.ToolBarButton done;
		private System.Windows.Forms.ToolBarButton toolBarspr5;
		private System.Windows.Forms.MenuItem go_to_date;
		private System.Windows.Forms.ComboBox combo_other_emps;
		private System.ComponentModel.IContainer components;

		private string mode;
		public string Mode
		{
			set{mode = value;}
			get{return mode;}
		}
		public decimal employee_code;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
		private schedule_manager.e_s_Dataset e_s_Dataset1;
		private bool hasChanged = false;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
		private Object current_combo_value = null;
		private bool change_cancled;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private schedule_manager.e_Dataset e_Dataset2;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private schedule_manager.user_dataset user_dataset1;
		private DataTable changed_dataTable;


	/*	public schedule(int emp_code)
		{
			employee_code = emp_code;
			
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			calendar1.CurrentDate = schedule1.Date = DateTime.Today;
			mode = 1; // user can see his own appointments

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}*/

		public schedule ()
		{
			InitializeComponent();
			calendar1.CurrentDate = schedule1.Date = DateTime.Today;
	/*		this.combo_other_emps.Enabled = true;	
			schedule1.Enabled = false;
			this.toolBar1.Buttons[15].Enabled = false;*/
		//	mode = 2;// user can see the appointments of the other users
            
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(schedule));
			Janus.Windows.Schedule.ScheduleAppointmentOwner scheduleAppointmentOwner1 = new Janus.Windows.Schedule.ScheduleAppointmentOwner();
			this.panel1 = new System.Windows.Forms.Panel();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.prev = new System.Windows.Forms.ToolBarButton();
			this.next = new System.Windows.Forms.ToolBarButton();
			this.toolBarspr1 = new System.Windows.Forms.ToolBarButton();
			this.new_ap = new System.Windows.Forms.ToolBarButton();
			this.Save = new System.Windows.Forms.ToolBarButton();
			this.delete = new System.Windows.Forms.ToolBarButton();
			this.toolBarspr2 = new System.Windows.Forms.ToolBarButton();
			this.Day = new System.Windows.Forms.ToolBarButton();
			this.WorkWeek = new System.Windows.Forms.ToolBarButton();
			this.week = new System.Windows.Forms.ToolBarButton();
			this.month = new System.Windows.Forms.ToolBarButton();
			this.toolBarspr3 = new System.Windows.Forms.ToolBarButton();
			this.print_prev = new System.Windows.Forms.ToolBarButton();
			this.print = new System.Windows.Forms.ToolBarButton();
			this.toolBarspr4 = new System.Windows.Forms.ToolBarButton();
			this.options = new System.Windows.Forms.ToolBarButton();
			this.toolBarspr5 = new System.Windows.Forms.ToolBarButton();
			this.done = new System.Windows.Forms.ToolBarButton();
			this.imgMain = new System.Windows.Forms.ImageList(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.combo_other_emps = new System.Windows.Forms.ComboBox();
			this.calendar1 = new Janus.Windows.Schedule.Calendar();
			this.schedule1 = new Janus.Windows.Schedule.Schedule();
			this.s_DataSet1 = new schedule_manager.S_DataSet();
			this.imgAppointments = new System.Windows.Forms.ImageList(this.components);
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlDataAdapter3 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.schedulePrintDocument1 = new Janus.Windows.Schedule.SchedulePrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.donectm = new System.Windows.Forms.ContextMenu();
			this.go_to_date = new System.Windows.Forms.MenuItem();
			this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
			this.e_s_Dataset1 = new schedule_manager.e_s_Dataset();
			this.e_Dataset2 = new schedule_manager.e_Dataset();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.user_dataset1 = new schedule_manager.user_dataset();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.calendar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.schedule1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.s_DataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.e_s_Dataset1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.e_Dataset2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.user_dataset1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.toolBar1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 28);
			this.panel1.TabIndex = 0;
			// 
			// toolBar1
			// 
			this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.prev,
																						this.next,
																						this.toolBarspr1,
																						this.new_ap,
																						this.Save,
																						this.delete,
																						this.toolBarspr2,
																						this.Day,
																						this.WorkWeek,
																						this.week,
																						this.month,
																						this.toolBarspr3,
																						this.print_prev,
																						this.print,
																						this.toolBarspr4,
																						this.options,
																						this.toolBarspr5,
																						this.done});
			this.toolBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imgMain;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(800, 30);
			this.toolBar1.TabIndex = 0;
			this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// prev
			// 
			this.prev.ImageIndex = 0;
			// 
			// next
			// 
			this.next.ImageIndex = 1;
			// 
			// toolBarspr1
			// 
			this.toolBarspr1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// new_ap
			// 
			this.new_ap.ImageIndex = 2;
			this.new_ap.Tag = "n_t";
			this.new_ap.Text = "New";
			// 
			// Save
			// 
			this.Save.ImageIndex = 3;
			this.Save.Tag = "s_t";
			this.Save.Text = "Save";
			// 
			// delete
			// 
			this.delete.Enabled = false;
			this.delete.ImageIndex = 4;
			this.delete.Tag = "d_t";
			this.delete.Text = "Delete";
			// 
			// toolBarspr2
			// 
			this.toolBarspr2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// Day
			// 
			this.Day.ImageIndex = 5;
			this.Day.Pushed = true;
			this.Day.Tag = "day_t";
			this.Day.Text = "Day";
			// 
			// WorkWeek
			// 
			this.WorkWeek.ImageIndex = 6;
			this.WorkWeek.Tag = "ww_t";
			this.WorkWeek.Text = "Work Week";
			// 
			// week
			// 
			this.week.ImageIndex = 7;
			this.week.Tag = "w_t";
			this.week.Text = "Week";
			// 
			// month
			// 
			this.month.ImageIndex = 8;
			this.month.Tag = "m_t";
			this.month.Text = "Month";
			// 
			// toolBarspr3
			// 
			this.toolBarspr3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// print_prev
			// 
			this.print_prev.ImageIndex = 10;
			this.print_prev.Tag = "pp_t";
			// 
			// print
			// 
			this.print.ImageIndex = 11;
			// 
			// toolBarspr4
			// 
			this.toolBarspr4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// options
			// 
			this.options.ImageIndex = 12;
			this.options.Text = "Options";
			// 
			// toolBarspr5
			// 
			this.toolBarspr5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// done
			// 
			this.done.Enabled = false;
			this.done.ImageIndex = 13;
			this.done.Text = "Set as done";
			// 
			// imgMain
			// 
			this.imgMain.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imgMain.ImageSize = new System.Drawing.Size(18, 18);
			this.imgMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMain.ImageStream")));
			this.imgMain.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(232)), ((System.Byte)(240)), ((System.Byte)(255)));
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.schedule1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 434);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(253)), ((System.Byte)(218)));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.combo_other_emps);
			this.panel3.Controls.Add(this.calendar1);
			this.panel3.Location = new System.Drawing.Point(632, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(216, 434);
			this.panel3.TabIndex = 2;
			// 
			// combo_other_emps
			// 
			this.combo_other_emps.DisplayMember = "employeeID";
			this.combo_other_emps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combo_other_emps.Enabled = false;
			this.combo_other_emps.Location = new System.Drawing.Point(24, 184);
			this.combo_other_emps.Name = "combo_other_emps";
			this.combo_other_emps.TabIndex = 6;
			this.combo_other_emps.ValueMember = "employeeID";
			this.combo_other_emps.SelectedValueChanged += new System.EventHandler(this.combo_other_emps_SelectedValueChanged_1);
			this.combo_other_emps.SelectedIndexChanged += new System.EventHandler(this.combo_other_emps_SelectedIndexChanged);
			// 
			// calendar1
			// 
			this.calendar1.AllowDrop = true;
			this.calendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.calendar1.BorderStyle = Janus.Windows.Schedule.BorderStyle.None;
			this.calendar1.CurrentDate = new System.DateTime(2007, 5, 21, 0, 0, 0, 0);
			this.calendar1.FirstMonth = new System.DateTime(2007, 5, 1, 0, 0, 0, 0);
			this.calendar1.HideSelection = Janus.Windows.Schedule.HideSelection.HighlightInactive;
			this.calendar1.Location = new System.Drawing.Point(0, 0);
			this.calendar1.MonthBackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(253)), ((System.Byte)(218)));
			this.calendar1.Name = "calendar1";
			this.calendar1.Schedule = this.schedule1;
			this.calendar1.SelectionStyle = Janus.Windows.Schedule.CalendarSelectionStyle.Schedule;
			this.calendar1.Size = new System.Drawing.Size(170, 144);
			this.calendar1.TabIndex = 5;
			this.calendar1.CurrentDateChanged += new System.EventHandler(this.calendar1_CurrentDateChanged);
			// 
			// schedule1
			// 
			this.schedule1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.schedule1.AppointmentSettingsMember = "AppointmentLayout";
			this.schedule1.AppointmentsFormatStyle.BackColor = System.Drawing.SystemColors.Window;
			this.schedule1.DataMember = "appointments";
			this.schedule1.DataSource = this.s_DataSet1;
			this.schedule1.Date = new System.DateTime(2007, 5, 21, 0, 0, 0, 0);
			this.schedule1.Dates.Add(new System.DateTime(2007, 5, 21, 0, 0, 0, 0));
			this.schedule1.DescriptionMember = "Description";
			this.schedule1.EndTimeMember = "EndDate";
			this.schedule1.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.schedule1.HeadersFormatStyle.BackColor = System.Drawing.SystemColors.ControlLight;
			this.schedule1.HideSelection = Janus.Windows.Schedule.HideSelection.HighlightInactive;
			this.schedule1.HourBackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(219)), ((System.Byte)(219)), ((System.Byte)(219)));
			this.schedule1.HourBackgroundStyle.BackColorGradient = System.Drawing.Color.White;
			this.schedule1.HourBackgroundStyle.ForeColor = System.Drawing.Color.White;
			this.schedule1.ImageList = this.imgAppointments;
			this.schedule1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.schedule1.Location = new System.Drawing.Point(0, 0);
			this.schedule1.MonthFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.schedule1.MultiSelect = false;
			this.schedule1.Name = "schedule1";
			scheduleAppointmentOwner1.Key = "Owner1";
			scheduleAppointmentOwner1.Tag = null;
			this.schedule1.Owners.AddRange(new Janus.Windows.Schedule.ScheduleAppointmentOwner[] {
																									 scheduleAppointmentOwner1});
			this.schedule1.RecurrenceInfoMember = "RecurrencePattern";
			this.schedule1.ShowAllDayArea = false;
			this.schedule1.Size = new System.Drawing.Size(632, 434);
			this.schedule1.StartTimeMember = "StartDate";
			this.schedule1.TabIndex = 0;
			this.schedule1.TextMember = "Subject";
			this.schedule1.TimeFormat = Janus.Windows.Schedule.TimeFormat.TwentyFourHours;
			this.schedule1.TimeNavigatorFormatStyle.BackColor = System.Drawing.SystemColors.Control;
			this.schedule1.VisualStyle = Janus.Windows.Schedule.VisualStyle.Office2003;
			this.schedule1.WorkingHourBackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(209)), ((System.Byte)(216)), ((System.Byte)(254)));
			this.schedule1.AppointmentChanging += new Janus.Windows.Schedule.AppointmentChangeCancelEventHandler(this.schedule1_AppointmentChanging);
			this.schedule1.Reminder += new Janus.Windows.Schedule.AppointmentEventHandler(this.schedule1_Reminder);
			this.schedule1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.schedule1_MouseDown);
			this.schedule1.AppointmentDoubleClick += new Janus.Windows.Schedule.AppointmentEventHandler(this.schedule1_AppointmentDoubleClick);
			this.schedule1.ViewChanged += new System.EventHandler(this.schedule1_ViewChanged);
			this.schedule1.DatesChanged += new System.EventHandler(this.schedule1_DatesChanged);
			this.schedule1.AppointmentChanged += new Janus.Windows.Schedule.AppointmentChangeEventHandler(this.schedule1_AppointmentChanged);
			this.schedule1.SelectedAppointmentsChanged += new System.EventHandler(this.schedule1_SelectedAppointmentsChanged);
			this.schedule1.AddingAppointment += new Janus.Windows.Schedule.AddAppointmentEventHandler(this.schedule1_AddingAppointment);
			this.schedule1.RemovingRecurrentAppointment += new Janus.Windows.Schedule.RemovingRecurrentAppointmentEventHandler(this.schedule1_RemovingRecurrentAppointment);
			this.schedule1.AppointmentAdded += new Janus.Windows.Schedule.AppointmentEventHandler(this.schedule1_AppointmentAdded);
			// 
			// s_DataSet1
			// 
			this.s_DataSet1.DataSetName = "S_DataSet";
			this.s_DataSet1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// imgAppointments
			// 
			this.imgAppointments.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imgAppointments.ImageSize = new System.Drawing.Size(16, 16);
			this.imgAppointments.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgAppointments.ImageStream")));
			this.imgAppointments.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=ARMANDEH4;persist sec" +
				"urity info=False;initial catalog=schedule";
			// 
			// sqlDataAdapter3
			// 
			this.sqlDataAdapter3.DeleteCommand = this.sqlDeleteCommand2;
			this.sqlDataAdapter3.InsertCommand = this.sqlInsertCommand2;
			this.sqlDataAdapter3.SelectCommand = this.sqlSelectCommand2;
			this.sqlDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "appointments", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("AppointmentID", "AppointmentID"),
																																																					  new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
																																																					  new System.Data.Common.DataColumnMapping("Subject", "Subject"),
																																																					  new System.Data.Common.DataColumnMapping("Description", "Description"),
																																																					  new System.Data.Common.DataColumnMapping("StartDate", "StartDate"),
																																																					  new System.Data.Common.DataColumnMapping("EndDate", "EndDate"),
																																																					  new System.Data.Common.DataColumnMapping("AppointmentCategoryID", "AppointmentCategoryID"),
																																																					  new System.Data.Common.DataColumnMapping("RecurrencePattern", "RecurrencePattern"),
																																																					  new System.Data.Common.DataColumnMapping("AppointmentLayout", "AppointmentLayout")})});
			this.sqlDataAdapter3.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = @"DELETE FROM appointments WHERE (AppointmentID = @Original_AppointmentID) AND (AppointmentCategoryID = @Original_AppointmentCategoryID OR @Original_AppointmentCategoryID IS NULL AND AppointmentCategoryID IS NULL) AND (AppointmentLayout = @Original_AppointmentLayout OR @Original_AppointmentLayout IS NULL AND AppointmentLayout IS NULL) AND (Description = @Original_Description OR @Original_Description IS NULL AND Description IS NULL) AND (EmployeeID = @Original_EmployeeID OR @Original_EmployeeID IS NULL AND EmployeeID IS NULL) AND (EndDate = @Original_EndDate OR @Original_EndDate IS NULL AND EndDate IS NULL) AND (RecurrencePattern = @Original_RecurrencePattern OR @Original_RecurrencePattern IS NULL AND RecurrencePattern IS NULL) AND (StartDate = @Original_StartDate OR @Original_StartDate IS NULL AND StartDate IS NULL) AND (Subject = @Original_Subject OR @Original_Subject IS NULL AND Subject IS NULL)";
			this.sqlDeleteCommand2.Connection = this.sqlConnection1;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AppointmentID", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AppointmentID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AppointmentCategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AppointmentCategoryID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AppointmentLayout", System.Data.SqlDbType.NVarChar, 4000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AppointmentLayout", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Description", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EndDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EndDate", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_RecurrencePattern", System.Data.SqlDbType.NVarChar, 4000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RecurrencePattern", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_StartDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "StartDate", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Subject", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Subject", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = @"INSERT INTO appointments (EmployeeID, Subject, Description, StartDate, EndDate, AppointmentCategoryID, RecurrencePattern, AppointmentLayout) VALUES (@EmployeeID, @Subject, @Description, @StartDate, @EndDate, @AppointmentCategoryID, @RecurrencePattern, @AppointmentLayout); SELECT AppointmentID, EmployeeID, Subject, Description, StartDate, EndDate, AppointmentCategoryID, RecurrencePattern, AppointmentLayout FROM appointments WHERE (AppointmentID = @@IDENTITY)";
			this.sqlInsertCommand2.Connection = this.sqlConnection1;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.BigInt, 8, "EmployeeID"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Subject", System.Data.SqlDbType.VarChar, 50, "Subject"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 1000, "Description"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@StartDate", System.Data.SqlDbType.DateTime, 8, "StartDate"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EndDate", System.Data.SqlDbType.DateTime, 8, "EndDate"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AppointmentCategoryID", System.Data.SqlDbType.Int, 4, "AppointmentCategoryID"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RecurrencePattern", System.Data.SqlDbType.NVarChar, 4000, "RecurrencePattern"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AppointmentLayout", System.Data.SqlDbType.NVarChar, 4000, "AppointmentLayout"));
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT AppointmentID, EmployeeID, Subject, Description, StartDate, EndDate, Appoi" +
				"ntmentCategoryID, RecurrencePattern, AppointmentLayout FROM appointments WHERE (" +
				"AppointmentID = @AppointmentdID)";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			this.sqlSelectCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AppointmentdID", System.Data.SqlDbType.BigInt, 8, "AppointmentID"));
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = @"UPDATE appointments SET EmployeeID = @EmployeeID, Subject = @Subject, Description = @Description, StartDate = @StartDate, EndDate = @EndDate, AppointmentCategoryID = @AppointmentCategoryID, RecurrencePattern = @RecurrencePattern, AppointmentLayout = @AppointmentLayout WHERE (AppointmentID = @Original_AppointmentID) AND (AppointmentCategoryID = @Original_AppointmentCategoryID OR @Original_AppointmentCategoryID IS NULL AND AppointmentCategoryID IS NULL) AND (AppointmentLayout = @Original_AppointmentLayout OR @Original_AppointmentLayout IS NULL AND AppointmentLayout IS NULL) AND (Description = @Original_Description OR @Original_Description IS NULL AND Description IS NULL) AND (EmployeeID = @Original_EmployeeID OR @Original_EmployeeID IS NULL AND EmployeeID IS NULL) AND (EndDate = @Original_EndDate OR @Original_EndDate IS NULL AND EndDate IS NULL) AND (RecurrencePattern = @Original_RecurrencePattern OR @Original_RecurrencePattern IS NULL AND RecurrencePattern IS NULL) AND (StartDate = @Original_StartDate OR @Original_StartDate IS NULL AND StartDate IS NULL) AND (Subject = @Original_Subject OR @Original_Subject IS NULL AND Subject IS NULL); SELECT AppointmentID, EmployeeID, Subject, Description, StartDate, EndDate, AppointmentCategoryID, RecurrencePattern, AppointmentLayout FROM appointments WHERE (AppointmentID = @AppointmentID)";
			this.sqlUpdateCommand2.Connection = this.sqlConnection1;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.BigInt, 8, "EmployeeID"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Subject", System.Data.SqlDbType.VarChar, 50, "Subject"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 1000, "Description"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@StartDate", System.Data.SqlDbType.DateTime, 8, "StartDate"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EndDate", System.Data.SqlDbType.DateTime, 8, "EndDate"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AppointmentCategoryID", System.Data.SqlDbType.Int, 4, "AppointmentCategoryID"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RecurrencePattern", System.Data.SqlDbType.NVarChar, 4000, "RecurrencePattern"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AppointmentLayout", System.Data.SqlDbType.NVarChar, 4000, "AppointmentLayout"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AppointmentID", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AppointmentID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AppointmentCategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AppointmentCategoryID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AppointmentLayout", System.Data.SqlDbType.NVarChar, 4000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AppointmentLayout", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Description", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EndDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EndDate", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_RecurrencePattern", System.Data.SqlDbType.NVarChar, 4000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RecurrencePattern", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_StartDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "StartDate", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Subject", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Subject", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AppointmentID", System.Data.SqlDbType.BigInt, 8, "AppointmentID"));
			// 
			// schedulePrintDocument1
			// 
			this.schedulePrintDocument1.FooterRight = "2007/06/06";
			this.schedulePrintDocument1.Schedule = this.schedule1;
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.schedulePrintDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(151, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "employee", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("employee_code", "employee_code"),
																																																				  new System.Data.Common.DataColumnMapping("f_name", "f_name"),
																																																				  new System.Data.Common.DataColumnMapping("m_name", "m_name"),
																																																				  new System.Data.Common.DataColumnMapping("l_name", "l_name")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM employee WHERE (employee_code = @Original_employee_code) AND (f_name = @Original_f_name OR @Original_f_name IS NULL AND f_name IS NULL) AND (l_name = @Original_l_name OR @Original_l_name IS NULL AND l_name IS NULL) AND (m_name = @Original_m_name OR @Original_m_name IS NULL AND m_name IS NULL)";
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "employee_code", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_f_name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "f_name", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_l_name", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "l_name", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_m_name", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "m_name", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO employee(employee_code, f_name, m_name, l_name) VALUES (@employee_cod" +
				"e, @f_name, @m_name, @l_name); SELECT employee_code, f_name, m_name, l_name FROM" +
				" employee WHERE (employee_code = @employee_code)";
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 30, "l_name"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT employee_code, f_name, m_name, l_name FROM employee";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE employee SET employee_code = @employee_code, f_name = @f_name, m_name = @m_name, l_name = @l_name WHERE (employee_code = @Original_employee_code) AND (f_name = @Original_f_name OR @Original_f_name IS NULL AND f_name IS NULL) AND (l_name = @Original_l_name OR @Original_l_name IS NULL AND l_name IS NULL) AND (m_name = @Original_m_name OR @Original_m_name IS NULL AND m_name IS NULL); SELECT employee_code, f_name, m_name, l_name FROM employee WHERE (employee_code = @employee_code)";
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 30, "l_name"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "employee_code", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_f_name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "f_name", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_l_name", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "l_name", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_m_name", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "m_name", System.Data.DataRowVersion.Original, null));
			// 
			// donectm
			// 
			this.donectm.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.go_to_date});
			// 
			// go_to_date
			// 
			this.go_to_date.Index = 0;
			this.go_to_date.Text = "Go to date";
			this.go_to_date.Click += new System.EventHandler(this.go_to_date_Click);
			// 
			// sqlDataAdapter2
			// 
			this.sqlDataAdapter2.DeleteCommand = this.sqlDeleteCommand3;
			this.sqlDataAdapter2.InsertCommand = this.sqlInsertCommand3;
			this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand3;
			this.sqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "emp_setting", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("emp_ID", "emp_ID"),
																																																					 new System.Data.Common.DataColumnMapping("work_start_time", "work_start_time"),
																																																					 new System.Data.Common.DataColumnMapping("work_end_time", "work_end_time"),
																																																					 new System.Data.Common.DataColumnMapping("week_num", "week_num"),
																																																					 new System.Data.Common.DataColumnMapping("work_week_sun", "work_week_sun"),
																																																					 new System.Data.Common.DataColumnMapping("work_week_mon", "work_week_mon"),
																																																					 new System.Data.Common.DataColumnMapping("work_week_tue", "work_week_tue"),
																																																					 new System.Data.Common.DataColumnMapping("work_week_wed", "work_week_wed"),
																																																					 new System.Data.Common.DataColumnMapping("work_week_thu", "work_week_thu"),
																																																					 new System.Data.Common.DataColumnMapping("work_week_fri", "work_week_fri"),
																																																					 new System.Data.Common.DataColumnMapping("work_week_sat", "work_week_sat"),
																																																					 new System.Data.Common.DataColumnMapping("week_start_day", "week_start_day")})});
			this.sqlDataAdapter2.UpdateCommand = this.sqlUpdateCommand3;
			// 
			// sqlDeleteCommand3
			// 
			this.sqlDeleteCommand3.CommandText = @"DELETE FROM emp_setting WHERE (emp_ID = @Original_emp_ID) AND (week_num = @Original_week_num OR @Original_week_num IS NULL AND week_num IS NULL) AND (week_start_day = @Original_week_start_day) AND (work_end_time = @Original_work_end_time OR @Original_work_end_time IS NULL AND work_end_time IS NULL) AND (work_start_time = @Original_work_start_time OR @Original_work_start_time IS NULL AND work_start_time IS NULL) AND (work_week_fri = @Original_work_week_fri OR @Original_work_week_fri IS NULL AND work_week_fri IS NULL) AND (work_week_mon = @Original_work_week_mon OR @Original_work_week_mon IS NULL AND work_week_mon IS NULL) AND (work_week_sat = @Original_work_week_sat OR @Original_work_week_sat IS NULL AND work_week_sat IS NULL) AND (work_week_sun = @Original_work_week_sun OR @Original_work_week_sun IS NULL AND work_week_sun IS NULL) AND (work_week_thu = @Original_work_week_thu OR @Original_work_week_thu IS NULL AND work_week_thu IS NULL) AND (work_week_tue = @Original_work_week_tue OR @Original_work_week_tue IS NULL AND work_week_tue IS NULL) AND (work_week_wed = @Original_work_week_wed OR @Original_work_week_wed IS NULL AND work_week_wed IS NULL)";
			this.sqlDeleteCommand3.Connection = this.sqlConnection1;
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_emp_ID", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "emp_ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_week_num", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "week_num", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_week_start_day", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "week_start_day", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_end_time", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_end_time", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_start_time", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_start_time", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_fri", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_fri", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_mon", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_mon", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_sat", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_sat", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_sun", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_sun", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_thu", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_thu", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_tue", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_tue", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_wed", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_wed", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand3
			// 
			this.sqlInsertCommand3.CommandText = @"INSERT INTO emp_setting(emp_ID, work_start_time, work_end_time, week_num, work_week_sun, work_week_mon, work_week_tue, work_week_wed, work_week_thu, work_week_fri, work_week_sat, week_start_day) VALUES (@emp_ID, @work_start_time, @work_end_time, @week_num, @work_week_sun, @work_week_mon, @work_week_tue, @work_week_wed, @work_week_thu, @work_week_fri, @work_week_sat, @week_start_day); SELECT emp_ID, work_start_time, work_end_time, week_num, work_week_sun, work_week_mon, work_week_tue, work_week_wed, work_week_thu, work_week_fri, work_week_sat, week_start_day FROM emp_setting WHERE (emp_ID = @emp_ID)";
			this.sqlInsertCommand3.Connection = this.sqlConnection1;
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@emp_ID", System.Data.SqlDbType.BigInt, 8, "emp_ID"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_start_time", System.Data.SqlDbType.DateTime, 8, "work_start_time"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_end_time", System.Data.SqlDbType.DateTime, 8, "work_end_time"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@week_num", System.Data.SqlDbType.Bit, 1, "week_num"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_sun", System.Data.SqlDbType.Bit, 1, "work_week_sun"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_mon", System.Data.SqlDbType.Bit, 1, "work_week_mon"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_tue", System.Data.SqlDbType.Bit, 1, "work_week_tue"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_wed", System.Data.SqlDbType.Bit, 1, "work_week_wed"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_thu", System.Data.SqlDbType.Bit, 1, "work_week_thu"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_fri", System.Data.SqlDbType.Bit, 1, "work_week_fri"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_sat", System.Data.SqlDbType.Bit, 1, "work_week_sat"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@week_start_day", System.Data.SqlDbType.Int, 4, "week_start_day"));
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "SELECT emp_ID, work_start_time, work_end_time, week_num, work_week_sun, work_week" +
				"_mon, work_week_tue, work_week_wed, work_week_thu, work_week_fri, work_week_sat," +
				" week_start_day FROM emp_setting";
			this.sqlSelectCommand3.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand3
			// 
			this.sqlUpdateCommand3.CommandText = "UPDATE emp_setting SET emp_ID = @emp_ID, work_start_time = @work_start_time, work" +
				"_end_time = @work_end_time, week_num = @week_num, work_week_sun = @work_week_sun" +
				", work_week_mon = @work_week_mon, work_week_tue = @work_week_tue, work_week_wed " +
				"= @work_week_wed, work_week_thu = @work_week_thu, work_week_fri = @work_week_fri" +
				", work_week_sat = @work_week_sat, week_start_day = @week_start_day WHERE (emp_ID" +
				" = @Original_emp_ID) AND (week_num = @Original_week_num OR @Original_week_num IS" +
				" NULL AND week_num IS NULL) AND (week_start_day = @Original_week_start_day) AND " +
				"(work_end_time = @Original_work_end_time OR @Original_work_end_time IS NULL AND " +
				"work_end_time IS NULL) AND (work_start_time = @Original_work_start_time OR @Orig" +
				"inal_work_start_time IS NULL AND work_start_time IS NULL) AND (work_week_fri = @" +
				"Original_work_week_fri OR @Original_work_week_fri IS NULL AND work_week_fri IS N" +
				"ULL) AND (work_week_mon = @Original_work_week_mon OR @Original_work_week_mon IS " +
				"NULL AND work_week_mon IS NULL) AND (work_week_sat = @Original_work_week_sat OR " +
				"@Original_work_week_sat IS NULL AND work_week_sat IS NULL) AND (work_week_sun = " +
				"@Original_work_week_sun OR @Original_work_week_sun IS NULL AND work_week_sun IS " +
				"NULL) AND (work_week_thu = @Original_work_week_thu OR @Original_work_week_thu IS" +
				" NULL AND work_week_thu IS NULL) AND (work_week_tue = @Original_work_week_tue OR" +
				" @Original_work_week_tue IS NULL AND work_week_tue IS NULL) AND (work_week_wed =" +
				" @Original_work_week_wed OR @Original_work_week_wed IS NULL AND work_week_wed IS" +
				" NULL); SELECT emp_ID, work_start_time, work_end_time, week_num, work_week_sun, " +
				"work_week_mon, work_week_tue, work_week_wed, work_week_thu, work_week_fri, work_" +
				"week_sat, week_start_day FROM emp_setting WHERE (emp_ID = @emp_ID)";
			this.sqlUpdateCommand3.Connection = this.sqlConnection1;
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@emp_ID", System.Data.SqlDbType.BigInt, 8, "emp_ID"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_start_time", System.Data.SqlDbType.DateTime, 8, "work_start_time"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_end_time", System.Data.SqlDbType.DateTime, 8, "work_end_time"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@week_num", System.Data.SqlDbType.Bit, 1, "week_num"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_sun", System.Data.SqlDbType.Bit, 1, "work_week_sun"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_mon", System.Data.SqlDbType.Bit, 1, "work_week_mon"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_tue", System.Data.SqlDbType.Bit, 1, "work_week_tue"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_wed", System.Data.SqlDbType.Bit, 1, "work_week_wed"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_thu", System.Data.SqlDbType.Bit, 1, "work_week_thu"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_fri", System.Data.SqlDbType.Bit, 1, "work_week_fri"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_sat", System.Data.SqlDbType.Bit, 1, "work_week_sat"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@week_start_day", System.Data.SqlDbType.Int, 4, "week_start_day"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_emp_ID", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "emp_ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_week_num", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "week_num", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_week_start_day", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "week_start_day", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_end_time", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_end_time", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_start_time", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_start_time", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_fri", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_fri", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_mon", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_mon", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_sat", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_sat", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_sun", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_sun", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_thu", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_thu", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_tue", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_tue", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_wed", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_wed", System.Data.DataRowVersion.Original, null));
			// 
			// e_s_Dataset1
			// 
			this.e_s_Dataset1.DataSetName = "e_s_Dataset";
			this.e_s_Dataset1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// e_Dataset2
			// 
			this.e_Dataset2.DataSetName = "e_Dataset";
			this.e_Dataset2.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\\TireMate\\User.mdb;Persist Securit" +
				"y Info=True;Jet OLEDB:Database Password=5332";
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT UserId, UserFamily, UserName FROM Users";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// user_dataset1
			// 
			this.user_dataset1.DataSetName = "user_dataset";
			this.user_dataset1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// schedule
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(232)), ((System.Byte)(240)), ((System.Byte)(255)));
			this.ClientSize = new System.Drawing.Size(800, 462);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.MaximizeBox = true;
			this.Name = "schedule";
			this.Text = "schedule";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.schedule_Closing);
			this.Load += new System.EventHandler(this.schedule_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.calendar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.schedule1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.s_DataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.e_s_Dataset1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.e_Dataset2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.user_dataset1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		
		
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
		//	schedule1.EndEdit();
			DataTable dt = s_DataSet1.appointments;
			int cnt = dt.Rows.Count;
			switch(toolBar1.Buttons.IndexOf(e.Button))
			{
				case 0:
					this.schedule1.MovePrevious();
					break;
				case 1:
					this.schedule1.MoveNext();
					break;				
				case 3:
					DateTime date = this.schedule1.SelectedDays.Start;
					TimeSpan duration = this.schedule1.SelectedDays.End.Subtract(date);					
					this.CreateNewAppointment(date, duration, null);
					
					break;
				case 4:
					save_appointments();
					break;
				case 5:
					delete_appointment();
					break;				
				case 7:
					schedule1.View = ScheduleView.DayView;
					break;
				case 8:
					schedule1.View = ScheduleView.WorkWeek;
					break;
				case 9:
					schedule1.View = ScheduleView.WeekView;
					break;
				case 10:
					schedule1.View = ScheduleView.MonthView;					
					break;
				case 11:
				case 12:
					try
					{
						System.Windows.Forms.PrintPreviewDialog printPreview = new PrintPreviewDialog();
						printPreview.Document = this.schedulePrintDocument1;
						printPreview.UseAntiAlias = true;
						printPreview.ShowDialog();
					}
					catch(Exception exc)
					{
						MessageBox.Show(exc.Message, "Janus Schedule for Microsoft .NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
				case 13:
					try
					{
						schedulePrintDocument1.Print();
					}
					catch(Exception exc)
					{
						MessageBox.Show(exc.Message, "Janus Schedule for Microsoft .NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
				case 15:
					OpenCalendarOptions();
					break;

				case 17:
					set_done();
					break;

			}	
	
							
		}

		private void save_appointments()
		{
			
			schedule1.EndEdit();
			hasChanged = false;	

			DataTable dt = (schedule1.DataSource as S_DataSet).appointments;
			
			
			for  (int i=0; i< s_DataSet1.appointments.Rows.Count; i++)
			{
				if (s_DataSet1.appointments.Rows[i].RowState != DataRowState.Deleted)
				{
					s_DataSet1.appointments.Rows[i]["employeeId"]=employee_code ;

					if (s_DataSet1.appointments.Rows[i][6]== DBNull.Value)
					{
						s_DataSet1.appointments.Rows[i][6] =-1;
					}
				}
			}							
		
			try
			{
				sqlDataAdapter3.Update(dt);				
				
			}
			catch (Exception ex )
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void schedule_Load(object sender, System.EventArgs e)
		{		
			employee_code = CommonClass.MainModule.PUserCod;

			sqlConnection1.ConnectionString= CommonClass.MainModule.PConnectionString;
			oleDbConnection1.ConnectionString = CommonClass.MainModule.PConnectionStringForUserMdb;
			try
			{
				if (sqlConnection1.State == ConnectionState.Closed)
					sqlConnection1.Open();

				string cmd1 = "select * from information_schema.tables where table_name = 'appointments'";
				sqlCommand1.CommandText = cmd1;
				sqlCommand1.CommandType = CommandType.Text;
				sqlCommand1.Connection = sqlConnection1;
				DataSet ds = new DataSet();
				SqlDataAdapter ada = new SqlDataAdapter (sqlCommand1);
				ada.Fill (ds);
				if (ds == null || ds.Tables == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
				{
				
					
					sqlCommand1.CommandText="CREATE TABLE [dbo].[appointments]([AppointmentID] [bigint] IDENTITY (1, 1) NOT NULL, [EmployeeID] [bigint] NULL, [Subject] [varchar](50)  " +  
						"COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,[Description] [varchar] (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ," +
						"[StartDate] [datetime] NULL ,[EndDate] [datetime] NULL ,[AppointmentCategoryID] [int] NULL ," +
						"[RecurrencePattern] [nvarchar] (4000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ," +
						"[AppointmentLayout] [nvarchar] (4000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ) ON [PRIMARY]";
					sqlCommand1.ExecuteNonQuery();
				}

				cmd1 = "select * from information_schema.tables where table_name = 'emp_setting'";
				sqlCommand1.CommandText = cmd1;
				sqlCommand1.CommandType = CommandType.Text;
				sqlCommand1.Connection = sqlConnection1;
				ds = new DataSet();
				ada = new SqlDataAdapter (sqlCommand1);
				ada.Fill (ds);
				if (ds == null || ds.Tables == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
				{
					sqlCommand1.CommandText = "CREATE TABLE [dbo].[emp_setting] ([emp_ID] [bigint] NOT NULL ,"
						+"	[work_start_time] [datetime] NULL ,	[work_end_time] [datetime] NULL ,"
						+"	[week_num] [bit] NULL ,	[work_week_sun] [bit] NULL ,	[work_week_mon] [bit] NULL ,"
						+"	[work_week_tue] [bit] NULL ,	[work_week_wed] [bit] NULL ,	[work_week_thu] [bit] NULL ,"
						+"	[work_week_fri] [bit] NULL ,	[work_week_sat] [bit] NULL ,"
						+" [week_start_day] [int] NOT NULL ) ON [PRIMARY]";
					sqlCommand1.ExecuteNonQuery();
				}

			}
			catch(Exception  ex)
			{
				MessageBox.Show(ex.Message);
			}
						
		
			
			string s_smd = "select * from appointments where [employeeID]=@f1";
			SqlCommand cmd = new SqlCommand(s_smd, sqlConnection1);

			
			SqlParameter p = new SqlParameter ();
			p.ParameterName = "@f1";
			p.SourceColumn = "employeeId";
			p.SqlDbType = SqlDbType.BigInt;
			p.Value = employee_code;
			cmd.Parameters.Add(p);

			sqlDataAdapter3.SelectCommand = cmd;
			
			sqlDataAdapter3.Fill (s_DataSet1.appointments);
			oleDbDataAdapter1.Fill(user_dataset1._Table);//******************************

			if (mode == "user")	load_emp_settings();

			DataTable e_dt = user_dataset1._Table;

			if (mode == "privileged")
			{
			//	this.schedule1.Enabled = false;
				this.combo_other_emps.Enabled = true;
				this.toolBar1.Buttons[15].Enabled = false;
				String st;
				foreach(DataRow e_dr in e_dt.Rows)
				{
					st = e_dr[1] + " " + e_dr[2];
					this.combo_other_emps.Items.Add(st);
				}
			}
			

		}

		private void calendar1_CurrentDateChanged(object sender, System.EventArgs e)
		{
			schedule1.Date = calendar1.CurrentDate;
		}

		private void calendar1_DatesChanged(object sender, System.EventArgs e)
		{
		
		}

		private void schedule1_DatesChanged(object sender, System.EventArgs e)
		{
			calendar1.CurrentDate = schedule1.Date;
		}

		private void schedule_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			schedule1.EndEdit();			
			if(hasChanged)
			{
				DialogResult result = MessageBox.Show("Do you want to save changes", "Janus Schedule Net",  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if(result == DialogResult.Yes)
				{
					save_appointments();
					
				}
				else if(result == DialogResult.Cancel)
				{
					e.Cancel = true;
				}
				else if (result == DialogResult.No)
				{
					
				}
			}
			
			
		}

		private void schedule1_AppointmentChanging(object sender, Janus.Windows.Schedule.AppointmentChangeCancelEventArgs e)
		{
			hasChanged = true;
		}

		private void schedule1_AppointmentChanged(object sender, Janus.Windows.Schedule.AppointmentChangeEventArgs e)
		{
			hasChanged = true;		
		}

		private void schedule1_SelectedAppointmentsChanged(object sender, System.EventArgs e)
		{
			if(schedule1.SelectedAppointments.Count > 0)
			{
				delete.Enabled = true;
				done.Enabled = true;
			}
			else
			{
				delete.Enabled = false;
				done.Enabled = false;
			}
		}

		private void options_Click(object sender, System.EventArgs e)
		{
		
			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			CalendarOptions form = new CalendarOptions(employee_code);
			form.Calendar = this.calendar1;
			form.Schedule = this.schedule1;
			form.CreateCalendarOptions();
			this.Cursor = System.Windows.Forms.Cursors.Default;
		

		}
		private void CreateNewAppointment(DateTime date, TimeSpan duration, ScheduleAppointment appointment)
		{
			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
		
			Appoint form = new Appoint();			
			form.CreateAppointmentForm(this.schedule1, date, duration, appointment);			
			this.Cursor = System.Windows.Forms.Cursors.Default;
			
		}

		private ReminderForm reminderForm;
		public ReminderForm ReminderForm
		{
			get
			{
				return reminderForm;
			}
			set
			{
				if(reminderForm != value)
				{
					if(value == null)
					{
						reminderForm.Closed -= new EventHandler(this.reminderForm_Closed);
						reminderForm = null;
					}
					else
					{
						reminderForm = value;
						reminderForm.Closed += new EventHandler(this.reminderForm_Closed);;
					}
				}
			}
		}


		private void schedule1_Reminder(object sender, Janus.Windows.Schedule.AppointmentEventArgs e)
		{
			
			if(reminderForm == null)
			{
				ReminderForm = new ReminderForm();
				reminderForm.CreateReminder(this.schedule1, e.Appointment);
				reminderForm.BringToFront();
			}
			else
			{
				reminderForm.AddItem(e.Appointment);
			}
		}
		private void reminderForm_Closed(object sender, EventArgs e)
		{
			reminderForm.Dispose();
			ReminderForm = null;
		}

		private void schedule1_RemovingRecurrentAppointment(object sender, Janus.Windows.Schedule.RemovingRecurrentAppointmentEventArgs e)
		{
			
			RecurrenceOptionDialog frm = new RecurrenceOptionDialog();
			frm.ShowRecurrenceOptionDialog(e.RecurrentAppointment.Text, true);
			if(frm.DialogResult == DialogResult.OK)
			{
				e.DeleteTheSeries = frm.ApplyToTheSeries;
				hasChanged = true;
			}
			else
			{
				e.Cancel = true;
			}
			
		}

		private void schedule1_AppointmentDoubleClick(object sender, Janus.Windows.Schedule.AppointmentEventArgs e)
		{
			ScheduleAppointment appointment = e.Appointment;
			if(appointment.IsRecurring)
			{
				RecurrenceOptionDialog frm = new RecurrenceOptionDialog();
				frm.ShowRecurrenceOptionDialog(appointment.Text, false);
				if(frm.DialogResult != DialogResult.OK)
				{
					return;
				}
				if(frm.ApplyToTheSeries)
				{
					appointment = appointment.MasterAppointment;
				}				
			}

			this.CreateNewAppointment(appointment.StartTime, appointment.Duration, appointment);
		}

		private void delete_appointment()
		{
			hasChanged = true;			
				
			DataTable dt = (schedule1.DataSource as S_DataSet).appointments;			
		
			if  (schedule1.CurrentAppointment.IsRecurring)
			{
				schedule1.CurrentAppointment.Delete();
				hasChanged = true;
				schedule1.EndEdit();										
			}
			else
			{
				schedule1.CurrentAppointment.Delete();				
				schedule1.EndEdit(false);
			}
		
		}

		private void OpenCalendarOptions()
		{
			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			CalendarOptions form = new CalendarOptions(employee_code);
			form.Calendar = this.calendar1;
			form.Schedule = this.schedule1;
			form.CreateCalendarOptions();
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void schedule1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				if(this.schedule1.HitTest(e.X, e.Y) == HitTest.Schedule)
					
				{
					this.schedule1.ContextMenu = this.donectm;
				}
			
			}
		}

		private void set_done()
		{
			
			schedule1.SelectedAppointments[0].BorderColor =  Color.FromArgb( 15, 90, 130);
			schedule1.SelectedAppointments[0].FormatStyle.BackColor =  Color.FromArgb(120, 200, 240);
			schedule1.SelectedAppointments[0].FormatStyle.FontBold = TriState.True;
			schedule1.SelectedAppointments[0].FormatStyle.ForeColor = Color.Black;
			schedule1.SelectedAppointments[0].ImageIndex2 = 11;
			DataRowView drv = (DataRowView)schedule1.SelectedAppointments[0].DataRow;
			drv.Row[6]= 11;
			schedule1.EndEdit();
			hasChanged = true;

		}

		private void go_to_date_Click(object sender, System.EventArgs e)
		{
			schedule_manager.DateNavigator date_n = new schedule_manager.DateNavigator();
			date_n.ShowDateNavigator(schedule1);
		}

		private void combo_other_emps_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (change_cancled)	
			{
				change_cancled=false;
			//	s_DataSet1.appointments.
				return;
			}
			change_cancled = false;
			int indx = combo_other_emps.SelectedIndex;
			DataTable e_dt = user_dataset1._Table;
			long emp_id = (long) e_dt.Rows[indx][0];

			employee_code = emp_id;
			

			string s_smd = "select * from appointments where [employeeID]=@f1";
			SqlCommand cmd = new SqlCommand(s_smd, sqlConnection1);

			
			SqlParameter p = new SqlParameter ();
			p.ParameterName = "@f1";
			p.SourceColumn = "employeeId";
			p.SqlDbType = SqlDbType.BigInt;
			p.Value = emp_id;
			cmd.Parameters.Add(p);

			sqlDataAdapter3.SelectCommand = cmd;
			s_DataSet1.appointments.Clear();
			sqlDataAdapter3.Fill(s_DataSet1.appointments);

		}


		private void combo_other_emps_SelectedValueChanged_1(object sender, System.EventArgs e)
		{
			
			if (schedule1.Enabled == false)schedule1.Enabled = true;
			schedule1.EndEdit();			
		
			if(hasChanged)
			{				
				if (combo_other_emps.SelectedItem == current_combo_value)
				{
					change_cancled = true;
					return;
				}
				DialogResult result = MessageBox.Show("Do you want to save changes", "Janus Schedule Net",  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if(result == DialogResult.Yes)
				{
					save_appointments();
					
				}	
				else if (result == DialogResult.No)
				{
					hasChanged = false;
				}
				else if (result == DialogResult.Cancel)					
				{ 
					changed_dataTable = s_DataSet1.appointments;
					
					combo_other_emps.SelectedItem = current_combo_value;
					change_cancled = true;
					return;
				}
			}
			current_combo_value = combo_other_emps.SelectedItem;
			
		}

		private void load_emp_settings()
		{
			int index = -1;
			bool found = false;
			sqlDataAdapter2.Fill(e_s_Dataset1.emp_setting);
			for (int i=0; i < e_s_Dataset1.emp_setting.Rows.Count; i++)
			{
				if (Convert.ToDecimal(e_s_Dataset1.emp_setting.Rows[i][0]) == employee_code) 
				{
					found = true;
					index = i;
				}
			}

			if (found)
			{
				DataRow dr = e_s_Dataset1.emp_setting.Rows[index];
				schedule1.WorkStartTime = ((DateTime) dr[1]).TimeOfDay;
				schedule1.WorkEndTime = ((DateTime)dr[2]).TimeOfDay;
				if ((bool)dr[3])	calendar1.WeekNumbers = true;
				ScheduleDayOfWeek sdw = 0;
				if ((bool)dr[4])	sdw |= ScheduleDayOfWeek.Sunday;
				if ((bool)dr[5])	sdw |= ScheduleDayOfWeek.Monday;
				if ((bool)dr[6])	sdw |= ScheduleDayOfWeek.Tuesday;
				if ((bool)dr[7])	sdw |= ScheduleDayOfWeek.Wednesday;
				if ((bool)dr[8])	sdw |= ScheduleDayOfWeek.Thursday;
				if ((bool)dr[9])	sdw |= ScheduleDayOfWeek.Friday;
				if ((bool)dr[10])	sdw |= ScheduleDayOfWeek.Saturday;
				schedule1.WorkWeek = sdw;

				switch ((int)dr[11])
				{
					case 0:	calendar1.FirstDayOfWeek = CalendarDayOfWeek.Saturday;	break;
					case 1: calendar1.FirstDayOfWeek = CalendarDayOfWeek.Sunday;	break;
					case 2: calendar1.FirstDayOfWeek = CalendarDayOfWeek.Monday;	break;
					case 3: calendar1.FirstDayOfWeek = CalendarDayOfWeek.Tuesday;	break;
					case 4: calendar1.FirstDayOfWeek = CalendarDayOfWeek.Wednesday;	break;
					case 5: calendar1.FirstDayOfWeek = CalendarDayOfWeek.Thursday;	break;
					case 6: calendar1.FirstDayOfWeek = CalendarDayOfWeek.Friday;	break;
					case 7: calendar1.FirstDayOfWeek = CalendarDayOfWeek.Default;	break;

				}

			}
			
		}

		private void schedule1_AddingAppointment(object sender, Janus.Windows.Schedule.AddAppointmentEventArgs e)
		{
		
		}

		private void schedule1_AppointmentAdded(object sender, Janus.Windows.Schedule.AppointmentEventArgs e)
		{
			hasChanged = true;
			schedule1.EndEdit();
		}

		private void schedule1_ViewChanged(object sender, System.EventArgs e)
		{
			this.Day.Pushed = false;
			this.WorkWeek.Pushed = false;
			this.week.Pushed = false;
			this.month.Pushed = false;						
			switch(schedule1.View)
			{
				case ScheduleView.DayView:
					this.Day.Pushed = true;
					break;
				case ScheduleView.WorkWeek:
					this.WorkWeek.Pushed = true;
					break;
				case ScheduleView.WeekView:
					this.week.Pushed = true;
					break;
				case ScheduleView.MonthView:
					this.month.Pushed = true;
					break;
			}
		}
		
	}
}
