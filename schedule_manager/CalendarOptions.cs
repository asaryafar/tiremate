using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Janus.Windows.Schedule;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace schedule_manager
{
	/// <summary>
	/// Summary description for CalendarOptions.
	/// </summary>
	public class CalendarOptions : CommonClass.FrmBase
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private decimal emp_cd;

		public CalendarOptions(decimal emp_code)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			emp_cd = emp_code;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//			
			cboFirstDay.Items.Add(CalendarDayOfWeek.Default);
			cboFirstDay.Items.Add(CalendarDayOfWeek.Monday);
			cboFirstDay.Items.Add(CalendarDayOfWeek.Tuesday);
			cboFirstDay.Items.Add(CalendarDayOfWeek.Wednesday);
			cboFirstDay.Items.Add(CalendarDayOfWeek.Thursday);
			cboFirstDay.Items.Add(CalendarDayOfWeek.Friday);
			cboFirstDay.Items.Add(CalendarDayOfWeek.Saturday);
			cboFirstDay.Items.Add(CalendarDayOfWeek.Sunday);

		}
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.TabPage tabGeneral;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkWeekNumbers;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private Janus.Windows.CalendarCombo.CalendarCombo clcEndTime;
		private Janus.Windows.CalendarCombo.CalendarCombo jsccStartTime;
		private System.Windows.Forms.ComboBox cboFirstDay;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkSaturday;
		private System.Windows.Forms.CheckBox chkFriday;
		private System.Windows.Forms.CheckBox chkThursday;
		private System.Windows.Forms.CheckBox chkWednesday;
		private System.Windows.Forms.CheckBox chkTuesday;
		private System.Windows.Forms.CheckBox chkMonday;
		private System.Windows.Forms.CheckBox chkSunday;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TabControl tabControl1;		
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private schedule_manager.e_s_Dataset e_s_Dataset1;
		private byte week_days = 0;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CalendarOptions));
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnApply = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkWeekNumbers = new System.Windows.Forms.CheckBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.clcEndTime = new Janus.Windows.CalendarCombo.CalendarCombo();
			this.jsccStartTime = new Janus.Windows.CalendarCombo.CalendarCombo();
			this.cboFirstDay = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.chkSaturday = new System.Windows.Forms.CheckBox();
			this.chkFriday = new System.Windows.Forms.CheckBox();
			this.chkThursday = new System.Windows.Forms.CheckBox();
			this.chkWednesday = new System.Windows.Forms.CheckBox();
			this.chkTuesday = new System.Windows.Forms.CheckBox();
			this.chkMonday = new System.Windows.Forms.CheckBox();
			this.chkSunday = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.e_s_Dataset1 = new schedule_manager.e_s_Dataset();
			this.tabGeneral.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.e_s_Dataset1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(300, 288);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(80, 24);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnApply
			// 
			this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnApply.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnApply.Location = new System.Drawing.Point(384, 288);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(80, 24);
			this.btnApply.TabIndex = 8;
			this.btnApply.Text = "Apply";
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnOk.Location = new System.Drawing.Point(216, 288);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(80, 24);
			this.btnOk.TabIndex = 7;
			this.btnOk.Text = "OK";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// tabGeneral
			// 
			this.tabGeneral.BackColor = System.Drawing.SystemColors.Menu;
			this.tabGeneral.Controls.Add(this.groupBox2);
			this.tabGeneral.Controls.Add(this.groupBox1);
			this.tabGeneral.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Size = new System.Drawing.Size(448, 238);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "General";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chkWeekNumbers);
			this.groupBox2.Controls.Add(this.pictureBox2);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(16, 152);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(416, 80);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Calendar Options";
			// 
			// chkWeekNumbers
			// 
			this.chkWeekNumbers.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkWeekNumbers.Location = new System.Drawing.Point(72, 32);
			this.chkWeekNumbers.Name = "chkWeekNumbers";
			this.chkWeekNumbers.Size = new System.Drawing.Size(240, 16);
			this.chkWeekNumbers.TabIndex = 1;
			this.chkWeekNumbers.Text = "Show week numbers in the date navigator";
			this.chkWeekNumbers.CheckedChanged += new System.EventHandler(this.Value_Changed);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(8, 24);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 32);
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.clcEndTime);
			this.groupBox1.Controls.Add(this.jsccStartTime);
			this.groupBox1.Controls.Add(this.cboFirstDay);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.chkSaturday);
			this.groupBox1.Controls.Add(this.chkFriday);
			this.groupBox1.Controls.Add(this.chkThursday);
			this.groupBox1.Controls.Add(this.chkWednesday);
			this.groupBox1.Controls.Add(this.chkTuesday);
			this.groupBox1.Controls.Add(this.chkMonday);
			this.groupBox1.Controls.Add(this.chkSunday);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(416, 128);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Calendar work week";
			// 
			// clcEndTime
			// 
			this.clcEndTime.BindableValue = new System.DateTime(2002, 1, 18, 0, 0, 0, 0);
			this.clcEndTime.CustomFormat = "h:mm tt";
			this.clcEndTime.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom;
			// 
			// clcEndTime.DropDownCalendar
			// 
			this.clcEndTime.DropDownCalendar.Location = new System.Drawing.Point(0, 0);
			this.clcEndTime.DropDownCalendar.Name = "";
			this.clcEndTime.DropDownCalendar.Size = new System.Drawing.Size(166, 136);
			this.clcEndTime.DropDownCalendar.TabIndex = 0;
			this.clcEndTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard;
			this.clcEndTime.Location = new System.Drawing.Point(312, 96);
			this.clcEndTime.Name = "clcEndTime";
			this.clcEndTime.ShowDropDown = false;
			this.clcEndTime.ShowUpDown = true;
			this.clcEndTime.Size = new System.Drawing.Size(88, 21);
			this.clcEndTime.TabIndex = 17;
			this.clcEndTime.Value = new System.DateTime(2002, 1, 18, 0, 0, 0, 0);
			this.clcEndTime.ValueChanged += new System.EventHandler(this.Value_Changed);
			// 
			// jsccStartTime
			// 
			this.jsccStartTime.BindableValue = new System.DateTime(2002, 1, 18, 0, 0, 0, 0);
			this.jsccStartTime.CustomFormat = "h:mm tt";
			this.jsccStartTime.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom;
			// 
			// jsccStartTime.DropDownCalendar
			// 
			this.jsccStartTime.DropDownCalendar.Location = new System.Drawing.Point(0, 0);
			this.jsccStartTime.DropDownCalendar.Name = "";
			this.jsccStartTime.DropDownCalendar.Size = new System.Drawing.Size(166, 136);
			this.jsccStartTime.DropDownCalendar.TabIndex = 0;
			this.jsccStartTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard;
			this.jsccStartTime.Location = new System.Drawing.Point(312, 64);
			this.jsccStartTime.Name = "jsccStartTime";
			this.jsccStartTime.ShowDropDown = false;
			this.jsccStartTime.ShowUpDown = true;
			this.jsccStartTime.Size = new System.Drawing.Size(88, 21);
			this.jsccStartTime.TabIndex = 13;
			this.jsccStartTime.Value = new System.DateTime(2002, 1, 18, 0, 0, 0, 0);
			this.jsccStartTime.ValueChanged += new System.EventHandler(this.Value_Changed);
			// 
			// cboFirstDay
			// 
			this.cboFirstDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFirstDay.ItemHeight = 13;
			this.cboFirstDay.Location = new System.Drawing.Point(120, 80);
			this.cboFirstDay.Name = "cboFirstDay";
			this.cboFirstDay.Size = new System.Drawing.Size(88, 21);
			this.cboFirstDay.TabIndex = 11;
			this.cboFirstDay.SelectedIndexChanged += new System.EventHandler(this.Value_Changed);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(224, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 17);
			this.label4.TabIndex = 16;
			this.label4.Text = "E&nd Time:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(224, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 17);
			this.label3.TabIndex = 12;
			this.label3.Text = "Sta&rt Time:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "First day of w&eek:";
			// 
			// chkSaturday
			// 
			this.chkSaturday.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkSaturday.Location = new System.Drawing.Point(368, 32);
			this.chkSaturday.Name = "chkSaturday";
			this.chkSaturday.Size = new System.Drawing.Size(40, 16);
			this.chkSaturday.TabIndex = 9;
			this.chkSaturday.Text = "Sat";
			this.chkSaturday.CheckedChanged += new System.EventHandler(this.Value_Changed);
			// 
			// chkFriday
			// 
			this.chkFriday.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkFriday.Location = new System.Drawing.Point(320, 32);
			this.chkFriday.Name = "chkFriday";
			this.chkFriday.Size = new System.Drawing.Size(40, 16);
			this.chkFriday.TabIndex = 8;
			this.chkFriday.Text = "Fri";
			this.chkFriday.CheckedChanged += new System.EventHandler(this.Value_Changed);
			// 
			// chkThursday
			// 
			this.chkThursday.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkThursday.Location = new System.Drawing.Point(272, 32);
			this.chkThursday.Name = "chkThursday";
			this.chkThursday.Size = new System.Drawing.Size(48, 16);
			this.chkThursday.TabIndex = 7;
			this.chkThursday.Text = "Thu";
			this.chkThursday.CheckedChanged += new System.EventHandler(this.Value_Changed);
			// 
			// chkWednesday
			// 
			this.chkWednesday.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkWednesday.Location = new System.Drawing.Point(216, 32);
			this.chkWednesday.Name = "chkWednesday";
			this.chkWednesday.Size = new System.Drawing.Size(48, 16);
			this.chkWednesday.TabIndex = 5;
			this.chkWednesday.Text = "Wed";
			this.chkWednesday.CheckedChanged += new System.EventHandler(this.Value_Changed);
			// 
			// chkTuesday
			// 
			this.chkTuesday.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkTuesday.Location = new System.Drawing.Point(160, 32);
			this.chkTuesday.Name = "chkTuesday";
			this.chkTuesday.Size = new System.Drawing.Size(48, 16);
			this.chkTuesday.TabIndex = 4;
			this.chkTuesday.Text = "Tue";
			this.chkTuesday.CheckedChanged += new System.EventHandler(this.Value_Changed);
			// 
			// chkMonday
			// 
			this.chkMonday.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkMonday.Location = new System.Drawing.Point(112, 32);
			this.chkMonday.Name = "chkMonday";
			this.chkMonday.Size = new System.Drawing.Size(48, 16);
			this.chkMonday.TabIndex = 3;
			this.chkMonday.Text = "Mon";
			this.chkMonday.CheckedChanged += new System.EventHandler(this.Value_Changed);
			// 
			// chkSunday
			// 
			this.chkSunday.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkSunday.Location = new System.Drawing.Point(56, 32);
			this.chkSunday.Name = "chkSunday";
			this.chkSunday.Size = new System.Drawing.Size(48, 16);
			this.chkSunday.TabIndex = 2;
			this.chkSunday.Text = "Sun";
			this.chkSunday.CheckedChanged += new System.EventHandler(this.Value_Changed);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabGeneral);
			this.tabControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabControl1.ItemSize = new System.Drawing.Size(49, 18);
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(456, 264);
			this.tabControl1.TabIndex = 6;
			// 
			// fontDialog1
			// 
			this.fontDialog1.FontMustExist = true;
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM emp_setting WHERE (emp_ID = @Original_emp_ID) AND (week_num = @Original_week_num OR @Original_week_num IS NULL AND week_num IS NULL) AND (week_start_day = @Original_week_start_day) AND (work_end_time = @Original_work_end_time OR @Original_work_end_time IS NULL AND work_end_time IS NULL) AND (work_start_time = @Original_work_start_time OR @Original_work_start_time IS NULL AND work_start_time IS NULL) AND (work_week_fri = @Original_work_week_fri OR @Original_work_week_fri IS NULL AND work_week_fri IS NULL) AND (work_week_mon = @Original_work_week_mon OR @Original_work_week_mon IS NULL AND work_week_mon IS NULL) AND (work_week_sat = @Original_work_week_sat OR @Original_work_week_sat IS NULL AND work_week_sat IS NULL) AND (work_week_sun = @Original_work_week_sun OR @Original_work_week_sun IS NULL AND work_week_sun IS NULL) AND (work_week_thu = @Original_work_week_thu OR @Original_work_week_thu IS NULL AND work_week_thu IS NULL) AND (work_week_tue = @Original_work_week_tue OR @Original_work_week_tue IS NULL AND work_week_tue IS NULL) AND (work_week_wed = @Original_work_week_wed OR @Original_work_week_wed IS NULL AND work_week_wed IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_emp_ID", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "emp_ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_week_num", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "week_num", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_week_start_day", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "week_start_day", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_end_time", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_end_time", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_start_time", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_start_time", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_fri", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_fri", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_mon", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_mon", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_sat", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_sat", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_sun", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_sun", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_thu", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_thu", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_tue", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_tue", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_wed", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_wed", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO emp_setting(emp_ID, work_start_time, work_end_time, week_num, work_week_sun, work_week_mon, work_week_tue, work_week_wed, work_week_thu, work_week_fri, work_week_sat, week_start_day) VALUES (@emp_ID, @work_start_time, @work_end_time, @week_num, @work_week_sun, @work_week_mon, @work_week_tue, @work_week_wed, @work_week_thu, @work_week_fri, @work_week_sat, @week_start_day); SELECT emp_ID, work_start_time, work_end_time, week_num, work_week_sun, work_week_mon, work_week_tue, work_week_wed, work_week_thu, work_week_fri, work_week_sat, week_start_day FROM emp_setting WHERE (emp_ID = @emp_ID)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@emp_ID", System.Data.SqlDbType.BigInt, 8, "emp_ID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_start_time", System.Data.SqlDbType.DateTime, 8, "work_start_time"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_end_time", System.Data.SqlDbType.DateTime, 8, "work_end_time"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@week_num", System.Data.SqlDbType.Bit, 1, "week_num"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_sun", System.Data.SqlDbType.Bit, 1, "work_week_sun"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_mon", System.Data.SqlDbType.Bit, 1, "work_week_mon"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_tue", System.Data.SqlDbType.Bit, 1, "work_week_tue"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_wed", System.Data.SqlDbType.Bit, 1, "work_week_wed"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_thu", System.Data.SqlDbType.Bit, 1, "work_week_thu"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_fri", System.Data.SqlDbType.Bit, 1, "work_week_fri"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_sat", System.Data.SqlDbType.Bit, 1, "work_week_sat"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@week_start_day", System.Data.SqlDbType.Int, 4, "week_start_day"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT emp_ID, work_start_time, work_end_time, week_num, work_week_sun, work_week" +
				"_mon, work_week_tue, work_week_wed, work_week_thu, work_week_fri, work_week_sat," +
				" week_start_day FROM emp_setting";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE emp_setting SET emp_ID = @emp_ID, work_start_time = @work_start_time, work" +
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
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@emp_ID", System.Data.SqlDbType.BigInt, 8, "emp_ID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_start_time", System.Data.SqlDbType.DateTime, 8, "work_start_time"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_end_time", System.Data.SqlDbType.DateTime, 8, "work_end_time"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@week_num", System.Data.SqlDbType.Bit, 1, "week_num"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_sun", System.Data.SqlDbType.Bit, 1, "work_week_sun"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_mon", System.Data.SqlDbType.Bit, 1, "work_week_mon"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_tue", System.Data.SqlDbType.Bit, 1, "work_week_tue"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_wed", System.Data.SqlDbType.Bit, 1, "work_week_wed"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_thu", System.Data.SqlDbType.Bit, 1, "work_week_thu"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_fri", System.Data.SqlDbType.Bit, 1, "work_week_fri"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@work_week_sat", System.Data.SqlDbType.Bit, 1, "work_week_sat"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@week_start_day", System.Data.SqlDbType.Int, 4, "week_start_day"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_emp_ID", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "emp_ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_week_num", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "week_num", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_week_start_day", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "week_start_day", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_end_time", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_end_time", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_start_time", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_start_time", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_fri", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_fri", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_mon", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_mon", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_sat", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_sat", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_sun", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_sun", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_thu", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_thu", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_tue", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_tue", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_work_week_wed", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "work_week_wed", System.Data.DataRowVersion.Original, null));
			// 
			// e_s_Dataset1
			// 
			this.e_s_Dataset1.DataSetName = "e_s_Dataset";
			this.e_s_Dataset1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// CalendarOptions
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(474, 328);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnApply);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MinimizeBox = false;
			this.Name = "CalendarOptions";
			this.ShowInTaskbar = false;
			this.Text = "Options";
			this.Load += new System.EventHandler(this.CalendarOptions_Load);
			this.tabGeneral.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.e_s_Dataset1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		
		public Janus.Windows.Schedule.Schedule Schedule = null;
		public Janus.Windows.Schedule.Calendar Calendar = null;
	
		
		private void ApplyChanges()
		{		
			Calendar.WeekNumbers = chkWeekNumbers.Checked;
			
			ScheduleDayOfWeek workWeek = 0;
			if(chkSunday.Checked) workWeek |= ScheduleDayOfWeek.Sunday;	
			if(chkMonday.Checked) workWeek |= ScheduleDayOfWeek.Monday;	
			if(chkTuesday.Checked) workWeek |=ScheduleDayOfWeek.Tuesday;
			if(chkWednesday.Checked) workWeek |= ScheduleDayOfWeek.Wednesday;
			if(chkThursday.Checked) workWeek |= ScheduleDayOfWeek.Thursday;
			if(chkFriday.Checked) workWeek |= ScheduleDayOfWeek.Friday;
			if(chkSaturday.Checked) workWeek |= ScheduleDayOfWeek.Saturday;
			
			
			Schedule.WorkWeek = workWeek;
			Calendar.FirstDayOfWeek = (CalendarDayOfWeek)cboFirstDay.SelectedItem;			
			Schedule.WorkStartTime = this.jsccStartTime.Value.TimeOfDay;
			Schedule.WorkEndTime = this.clcEndTime.Value.TimeOfDay;			
		
		}
		public void CreateCalendarOptions()
		{			
			chkWeekNumbers.Checked = Calendar.WeekNumbers;
			chkMonday.Checked = ((Schedule.WorkWeek & ScheduleDayOfWeek.Monday) != 0);
			chkTuesday.Checked = ((Schedule.WorkWeek & ScheduleDayOfWeek.Tuesday) != 0);
			chkWednesday.Checked = ((Schedule.WorkWeek & ScheduleDayOfWeek.Wednesday) != 0);
			chkThursday.Checked = ((Schedule.WorkWeek & ScheduleDayOfWeek.Thursday) != 0);
			chkFriday.Checked = ((Schedule.WorkWeek & ScheduleDayOfWeek.Friday) != 0);
			chkSaturday.Checked = ((Schedule.WorkWeek & ScheduleDayOfWeek.Saturday) != 0);
			chkSunday.Checked = ((Schedule.WorkWeek & ScheduleDayOfWeek.Sunday) != 0);
			cboFirstDay.SelectedItem = Calendar.FirstDayOfWeek;			
			this.jsccStartTime.Value = DateTime.Today.Date.Add(Schedule.WorkStartTime);
			this.clcEndTime.Value = DateTime.Today.Date.Add(Schedule.WorkEndTime);			
			this.btnApply.Enabled = false;
			this.ShowDialog();
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnApply_Click(object sender, System.EventArgs e)
		{
			this.ApplyChanges();
			btnApply.Enabled = false;
		}

		private void Value_Changed(object sender, System.EventArgs e)
		{
			btnApply.Enabled = true;			
		}

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			this.ApplyChanges();
			this.save_changes();
			this.Close();
		}
				

		private void ChangeTextBox(TextBox textBox, System.Drawing.Font font)
		{
			textBox.Text = font.Size + " pt. " + font.FontFamily.Name;
			System.Drawing.Font newFont = new Font(font.FontFamily, textBox.Font.Size, font.Style);
			textBox.Font = newFont;
			this.btnApply.Enabled = true;
		}

		private void save_changes ()
		{		
			int index = -1;
			DataTable dt = e_s_Dataset1.emp_setting;
			
			for (int i=0; i<dt.Rows.Count; i++)
			{
				if ((long)dt.Rows[i][0] == emp_cd)
				{
					index = i;
					break;
				}
			}
			
			if (index == -1)
			{
				DataRow dr = dt.NewRow() ;
				dr[0] = emp_cd;
				dt.Rows.Add(dr);
				index = dt.Rows.Count-1;
			}
			

			Calendar.WeekNumbers = chkWeekNumbers.Checked;
			if (chkWeekNumbers.Checked) dt.Rows[index][3]=1;	else dt.Rows[index][3]=0;
			
			ScheduleDayOfWeek workWeek = 0;
			if(chkSunday.Checked) {workWeek |= ScheduleDayOfWeek.Sunday;	dt.Rows[index][4]= 1;} else dt.Rows[index][4]= 0;	
			if(chkMonday.Checked) {workWeek |= ScheduleDayOfWeek.Monday;	dt.Rows[index][5]= 1;}	else dt.Rows[index][5]= 0;
			if(chkTuesday.Checked) {workWeek |=ScheduleDayOfWeek.Tuesday;	dt.Rows[index][6]= 1;}	else dt.Rows[index][6]= 0;
			if(chkWednesday.Checked) {workWeek |= ScheduleDayOfWeek.Wednesday;	dt.Rows[index][7] = 1;}	else dt.Rows[index][7]= 0;
			if(chkThursday.Checked) {workWeek |= ScheduleDayOfWeek.Thursday;	dt.Rows[index][8] = 1;}	else dt.Rows[index][8]= 0;
			if(chkFriday.Checked) {workWeek |= ScheduleDayOfWeek.Friday;		dt.Rows[index][9] = 1;}	else dt.Rows[index][9]= 0;
			if(chkSaturday.Checked) {workWeek |= ScheduleDayOfWeek.Saturday;	dt.Rows[index][10] = 1;}	else dt.Rows[index][10]= 0;
			
			
			Schedule.WorkWeek = workWeek;
			Calendar.FirstDayOfWeek = (CalendarDayOfWeek)cboFirstDay.SelectedItem;	
			switch (Calendar.FirstDayOfWeek)
			{
				case CalendarDayOfWeek.Sunday: 
					dt.Rows[index][11] = 1;						
					break;
				case CalendarDayOfWeek.Monday:
					dt.Rows[index][11] = 2;						
					break; 
				case CalendarDayOfWeek.Tuesday: 
					dt.Rows[index][11] = 3;						
					break;
				case CalendarDayOfWeek.Wednesday:
					dt.Rows[index][11] = 4;						
					break;
				case CalendarDayOfWeek.Thursday:
					dt.Rows[index][11] = 5;						
					break;
				case CalendarDayOfWeek.Friday:
					dt.Rows[index][11] = 6;						
					break;
				case CalendarDayOfWeek.Saturday: 
					dt.Rows[index][11] = 0;						
					break;	
				case CalendarDayOfWeek.Default: 
					dt.Rows[index][11] = 7;						
					break;

			}
			
				
			
			Schedule.WorkStartTime = this.jsccStartTime.Value.TimeOfDay;
			dt.Rows[index][1] = (this.jsccStartTime.Value);
			Schedule.WorkEndTime = this.clcEndTime.Value.TimeOfDay;
			dt.Rows[index][2] = this.clcEndTime.Value;
			
			try 
			{
				sqlDataAdapter1.Update(dt);
			}
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message);
			}

			
		}

		private void CalendarOptions_Load(object sender, System.EventArgs e)
		{
			
			sqlConnection1.ConnectionString= CommonClass.MainModule.PConnectionString;
			if (sqlConnection1.State == ConnectionState.Closed)
				sqlConnection1.Open();			
			
			sqlDataAdapter1.Fill(e_s_Dataset1.emp_setting);
			// indexe rowe employee
			// e'male setting
		}
		
	}
}