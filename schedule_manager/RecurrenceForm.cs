using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Janus.Windows.Schedule;

namespace schedule_manager
{
	/// <summary>
	/// Summary description for RecurrenceForm.
	/// </summary>
	public class RecurrenceForm : CommonClass.FrmBase
	{
		private Janus.Windows.CalendarCombo.CalendarCombo jccStartTime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Janus.Windows.CalendarCombo.CalendarCombo jccEndTime;
		private System.Windows.Forms.RadioButton rdbDaily;
		private System.Windows.Forms.RadioButton rdbDailyInterval;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private Janus.Windows.CalendarCombo.CalendarCombo jccRecurrenceStart;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rdbNoEndDate;
		private System.Windows.Forms.RadioButton rdbOccurrences;
		private Janus.Windows.CalendarCombo.CalendarCombo jccRecurrenceEndDate;
		private System.Windows.Forms.TextBox txtOccurrences;
		private System.Windows.Forms.RadioButton rdbPatternEndDate;
		private System.Windows.Forms.RadioButton rdbWeekly;
		private System.Windows.Forms.GroupBox grbDailyPattern;
		private System.Windows.Forms.CheckBox chkMonday;
		private System.Windows.Forms.CheckBox chkTuesday;
		private System.Windows.Forms.CheckBox chkWednesday;
		private System.Windows.Forms.CheckBox chkSunday;
		private System.Windows.Forms.CheckBox chkThursday;
		private System.Windows.Forms.CheckBox chkFriday;
		private System.Windows.Forms.GroupBox grbWeeklyPattern;
		private System.Windows.Forms.GroupBox grbPattern;
		private System.Windows.Forms.TextBox txtDailyInterval;
		private System.Windows.Forms.GroupBox grbRecurrenceRange;
		private System.Windows.Forms.CheckBox chkSaturday;
		private System.Windows.Forms.RadioButton rdbWeekDay;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtWeeklyInterval;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RadioButton rdbMonthly;
		private System.Windows.Forms.GroupBox grbMonthlyPattern;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboMonthlyDayWeek;
		private System.Windows.Forms.TextBox txtMonthlyInterval;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDayOfMonth;
		private System.Windows.Forms.RadioButton rdbDayOfMonth;
		private System.Windows.Forms.RadioButton rdbMonthNth;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtMonthNthInterval;
		private System.Windows.Forms.GroupBox grbAppointmentTime;
		private System.Windows.Forms.ComboBox cboMonthlyOccurrence;
		private System.Windows.Forms.RadioButton rdbYearly;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cboYearlyOccurrence;
		private System.Windows.Forms.TextBox txtYearlyDayOfMonth;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.RadioButton rdbMonthOfYear;
		private System.Windows.Forms.ComboBox cboYearlyDayOfWeek;
		private System.Windows.Forms.ComboBox cboMonthOfYear;
		private System.Windows.Forms.ComboBox cboMonthOfYearNth;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox grbYearlyPattern;
		private System.Windows.Forms.RadioButton rdbYearNth;
		private System.Windows.Forms.Button btnRemoveRecurrence;
		private System.Windows.Forms.RadioButton rdbWeekendDay;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RecurrenceForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.grbAppointmentTime = new System.Windows.Forms.GroupBox();
			this.jccStartTime = new Janus.Windows.CalendarCombo.CalendarCombo();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.jccEndTime = new Janus.Windows.CalendarCombo.CalendarCombo();
			this.jccRecurrenceEndDate = new Janus.Windows.CalendarCombo.CalendarCombo();
			this.jccRecurrenceStart = new Janus.Windows.CalendarCombo.CalendarCombo();
			this.grbPattern = new System.Windows.Forms.GroupBox();
			this.grbWeeklyPattern = new System.Windows.Forms.GroupBox();
			this.chkMonday = new System.Windows.Forms.CheckBox();
			this.txtWeeklyInterval = new System.Windows.Forms.TextBox();
			this.chkTuesday = new System.Windows.Forms.CheckBox();
			this.chkWednesday = new System.Windows.Forms.CheckBox();
			this.chkSunday = new System.Windows.Forms.CheckBox();
			this.chkThursday = new System.Windows.Forms.CheckBox();
			this.chkSaturday = new System.Windows.Forms.CheckBox();
			this.chkFriday = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.rdbWeekly = new System.Windows.Forms.RadioButton();
			this.rdbDaily = new System.Windows.Forms.RadioButton();
			this.rdbMonthly = new System.Windows.Forms.RadioButton();
			this.rdbYearly = new System.Windows.Forms.RadioButton();
			this.grbMonthlyPattern = new System.Windows.Forms.GroupBox();
			this.txtMonthNthInterval = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cboMonthlyDayWeek = new System.Windows.Forms.ComboBox();
			this.cboMonthlyOccurrence = new System.Windows.Forms.ComboBox();
			this.txtMonthlyInterval = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDayOfMonth = new System.Windows.Forms.TextBox();
			this.rdbDayOfMonth = new System.Windows.Forms.RadioButton();
			this.rdbMonthNth = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.grbYearlyPattern = new System.Windows.Forms.GroupBox();
			this.cboYearlyOccurrence = new System.Windows.Forms.ComboBox();
			this.txtYearlyDayOfMonth = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.rdbMonthOfYear = new System.Windows.Forms.RadioButton();
			this.cboYearlyDayOfWeek = new System.Windows.Forms.ComboBox();
			this.rdbYearNth = new System.Windows.Forms.RadioButton();
			this.cboMonthOfYear = new System.Windows.Forms.ComboBox();
			this.cboMonthOfYearNth = new System.Windows.Forms.ComboBox();
			this.grbDailyPattern = new System.Windows.Forms.GroupBox();
			this.txtDailyInterval = new System.Windows.Forms.TextBox();
			this.rdbDailyInterval = new System.Windows.Forms.RadioButton();
			this.rdbWeekDay = new System.Windows.Forms.RadioButton();
			this.label11 = new System.Windows.Forms.Label();
			this.rdbWeekendDay = new System.Windows.Forms.RadioButton();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.grbRecurrenceRange = new System.Windows.Forms.GroupBox();
			this.txtOccurrences = new System.Windows.Forms.TextBox();
			this.rdbNoEndDate = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.rdbOccurrences = new System.Windows.Forms.RadioButton();
			this.rdbPatternEndDate = new System.Windows.Forms.RadioButton();
			this.label10 = new System.Windows.Forms.Label();
			this.btnRemoveRecurrence = new System.Windows.Forms.Button();
			this.grbAppointmentTime.SuspendLayout();
			this.grbPattern.SuspendLayout();
			this.grbWeeklyPattern.SuspendLayout();
			this.grbMonthlyPattern.SuspendLayout();
			this.grbYearlyPattern.SuspendLayout();
			this.grbDailyPattern.SuspendLayout();
			this.grbRecurrenceRange.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbAppointmentTime
			// 
			this.grbAppointmentTime.Controls.AddRange(new System.Windows.Forms.Control[] {
																							 this.jccStartTime,
																							 this.label1,
																							 this.label2,
																							 this.jccEndTime});
			this.grbAppointmentTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grbAppointmentTime.Location = new System.Drawing.Point(8, 8);
			this.grbAppointmentTime.Name = "grbAppointmentTime";
			this.grbAppointmentTime.Size = new System.Drawing.Size(472, 48);
			this.grbAppointmentTime.TabIndex = 0;
			this.grbAppointmentTime.TabStop = false;
			this.grbAppointmentTime.Text = "Appointment Time:";
			// 
			// jccStartTime
			// 
			this.jccStartTime.BindableValue = new System.DateTime(2004, 2, 15, 0, 0, 0, 0);
			this.jccStartTime.CustomFormat = "hh:mm tt";
			this.jccStartTime.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom;
			// 
			// jccStartTime.DropDownCalendar
			// 
			this.jccStartTime.DropDownCalendar.Size = new System.Drawing.Size(164, 167);
			this.jccStartTime.DropDownCalendar.TabIndex = 0;
			this.jccStartTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard;
			this.jccStartTime.HoverMode = Janus.Windows.CalendarCombo.HoverMode.None;
			this.jccStartTime.Location = new System.Drawing.Point(45, 20);
			this.jccStartTime.Name = "jccStartTime";
			this.jccStartTime.ShowDropDown = false;
			this.jccStartTime.ShowUpDown = true;
			this.jccStartTime.Size = new System.Drawing.Size(100, 21);
			this.jccStartTime.TabIndex = 3;
			this.jccStartTime.Value = new System.DateTime(2004, 2, 15, 0, 0, 0, 0);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 14);
			this.label1.TabIndex = 1;
			this.label1.Text = "Start:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(166, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 14);
			this.label2.TabIndex = 1;
			this.label2.Text = "End:";
			// 
			// jccEndTime
			// 
			this.jccEndTime.BindableValue = new System.DateTime(2004, 2, 15, 0, 0, 0, 0);
			this.jccEndTime.CustomFormat = "hh:mm tt";
			this.jccEndTime.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom;
			// 
			// jccEndTime.DropDownCalendar
			// 
			this.jccEndTime.DropDownCalendar.Size = new System.Drawing.Size(164, 167);
			this.jccEndTime.DropDownCalendar.TabIndex = 0;
			this.jccEndTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard;
			this.jccEndTime.HoverMode = Janus.Windows.CalendarCombo.HoverMode.None;
			this.jccEndTime.Location = new System.Drawing.Point(198, 20);
			this.jccEndTime.Name = "jccEndTime";
			this.jccEndTime.ShowDropDown = false;
			this.jccEndTime.ShowUpDown = true;
			this.jccEndTime.Size = new System.Drawing.Size(100, 21);
			this.jccEndTime.TabIndex = 1;
			this.jccEndTime.Value = new System.DateTime(2004, 2, 15, 0, 0, 0, 0);
			// 
			// jccRecurrenceEndDate
			// 
			this.jccRecurrenceEndDate.BindableValue = new System.DateTime(2004, 2, 15, 0, 0, 0, 0);
			// 
			// jccRecurrenceEndDate.DropDownCalendar
			// 
			this.jccRecurrenceEndDate.DropDownCalendar.Size = new System.Drawing.Size(164, 167);
			this.jccRecurrenceEndDate.DropDownCalendar.TabIndex = 0;
			this.jccRecurrenceEndDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard;
			this.jccRecurrenceEndDate.HoverMode = Janus.Windows.CalendarCombo.HoverMode.None;
			this.jccRecurrenceEndDate.Location = new System.Drawing.Point(292, 78);
			this.jccRecurrenceEndDate.Name = "jccRecurrenceEndDate";
			this.jccRecurrenceEndDate.Size = new System.Drawing.Size(172, 21);
			this.jccRecurrenceEndDate.TabIndex = 0;
			this.jccRecurrenceEndDate.Value = new System.DateTime(2004, 2, 15, 0, 0, 0, 0);
			// 
			// jccRecurrenceStart
			// 
			this.jccRecurrenceStart.BindableValue = new System.DateTime(2004, 2, 15, 0, 0, 0, 0);
			// 
			// jccRecurrenceStart.DropDownCalendar
			// 
			this.jccRecurrenceStart.DropDownCalendar.Size = new System.Drawing.Size(164, 167);
			this.jccRecurrenceStart.DropDownCalendar.TabIndex = 0;
			this.jccRecurrenceStart.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard;
			this.jccRecurrenceStart.HoverMode = Janus.Windows.CalendarCombo.HoverMode.None;
			this.jccRecurrenceStart.Location = new System.Drawing.Point(44, 20);
			this.jccRecurrenceStart.Name = "jccRecurrenceStart";
			this.jccRecurrenceStart.Size = new System.Drawing.Size(156, 21);
			this.jccRecurrenceStart.TabIndex = 3;
			this.jccRecurrenceStart.Value = new System.DateTime(2004, 2, 15, 0, 0, 0, 0);
			// 
			// grbPattern
			// 
			this.grbPattern.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.grbWeeklyPattern,
																					 this.rdbWeekly,
																					 this.rdbDaily,
																					 this.rdbMonthly,
																					 this.rdbYearly,
																					 this.grbMonthlyPattern,
																					 this.grbYearlyPattern,
																					 this.grbDailyPattern});
			this.grbPattern.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grbPattern.Location = new System.Drawing.Point(8, 64);
			this.grbPattern.Name = "grbPattern";
			this.grbPattern.Size = new System.Drawing.Size(472, 120);
			this.grbPattern.TabIndex = 1;
			this.grbPattern.TabStop = false;
			this.grbPattern.Text = "Recurrence Pattern";
			// 
			// grbWeeklyPattern
			// 
			this.grbWeeklyPattern.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.chkMonday,
																						   this.txtWeeklyInterval,
																						   this.chkTuesday,
																						   this.chkWednesday,
																						   this.chkSunday,
																						   this.chkThursday,
																						   this.chkSaturday,
																						   this.chkFriday,
																						   this.label4,
																						   this.label9});
			this.grbWeeklyPattern.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grbWeeklyPattern.Location = new System.Drawing.Point(100, 12);
			this.grbWeeklyPattern.Name = "grbWeeklyPattern";
			this.grbWeeklyPattern.Size = new System.Drawing.Size(364, 100);
			this.grbWeeklyPattern.TabIndex = 5;
			this.grbWeeklyPattern.TabStop = false;
			// 
			// chkMonday
			// 
			this.chkMonday.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkMonday.Location = new System.Drawing.Point(96, 48);
			this.chkMonday.Name = "chkMonday";
			this.chkMonday.Size = new System.Drawing.Size(64, 16);
			this.chkMonday.TabIndex = 3;
			this.chkMonday.Text = "Monday";
			// 
			// txtWeeklyInterval
			// 
			this.txtWeeklyInterval.Location = new System.Drawing.Point(84, 16);
			this.txtWeeklyInterval.Name = "txtWeeklyInterval";
			this.txtWeeklyInterval.Size = new System.Drawing.Size(32, 21);
			this.txtWeeklyInterval.TabIndex = 2;
			this.txtWeeklyInterval.Text = "1";
			this.txtWeeklyInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// chkTuesday
			// 
			this.chkTuesday.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkTuesday.Location = new System.Drawing.Point(184, 48);
			this.chkTuesday.Name = "chkTuesday";
			this.chkTuesday.Size = new System.Drawing.Size(64, 16);
			this.chkTuesday.TabIndex = 3;
			this.chkTuesday.Text = "Tuesday";
			// 
			// chkWednesday
			// 
			this.chkWednesday.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkWednesday.Location = new System.Drawing.Point(272, 48);
			this.chkWednesday.Name = "chkWednesday";
			this.chkWednesday.Size = new System.Drawing.Size(80, 16);
			this.chkWednesday.TabIndex = 3;
			this.chkWednesday.Text = "Wednesday";
			// 
			// chkSunday
			// 
			this.chkSunday.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkSunday.Location = new System.Drawing.Point(8, 48);
			this.chkSunday.Name = "chkSunday";
			this.chkSunday.Size = new System.Drawing.Size(64, 16);
			this.chkSunday.TabIndex = 3;
			this.chkSunday.Text = "Sunday";
			// 
			// chkThursday
			// 
			this.chkThursday.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkThursday.Location = new System.Drawing.Point(8, 72);
			this.chkThursday.Name = "chkThursday";
			this.chkThursday.Size = new System.Drawing.Size(72, 16);
			this.chkThursday.TabIndex = 3;
			this.chkThursday.Text = "Thursday";
			// 
			// chkSaturday
			// 
			this.chkSaturday.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkSaturday.Location = new System.Drawing.Point(184, 72);
			this.chkSaturday.Name = "chkSaturday";
			this.chkSaturday.Size = new System.Drawing.Size(68, 16);
			this.chkSaturday.TabIndex = 3;
			this.chkSaturday.Text = "Saturday";
			// 
			// chkFriday
			// 
			this.chkFriday.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkFriday.Location = new System.Drawing.Point(96, 72);
			this.chkFriday.Name = "chkFriday";
			this.chkFriday.Size = new System.Drawing.Size(56, 16);
			this.chkFriday.TabIndex = 3;
			this.chkFriday.Text = "Friday";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 14);
			this.label4.TabIndex = 4;
			this.label4.Text = "Recurr every";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(124, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 14);
			this.label9.TabIndex = 4;
			this.label9.Text = "week(s) on:";
			// 
			// rdbWeekly
			// 
			this.rdbWeekly.Checked = true;
			this.rdbWeekly.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbWeekly.Location = new System.Drawing.Point(8, 43);
			this.rdbWeekly.Name = "rdbWeekly";
			this.rdbWeekly.Size = new System.Drawing.Size(64, 16);
			this.rdbWeekly.TabIndex = 3;
			this.rdbWeekly.TabStop = true;
			this.rdbWeekly.Text = "Weekly";
			this.rdbWeekly.CheckedChanged += new System.EventHandler(this.rdbWeekly_CheckedChanged);
			// 
			// rdbDaily
			// 
			this.rdbDaily.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbDaily.Location = new System.Drawing.Point(8, 20);
			this.rdbDaily.Name = "rdbDaily";
			this.rdbDaily.Size = new System.Drawing.Size(64, 16);
			this.rdbDaily.TabIndex = 0;
			this.rdbDaily.Text = "Daily";
			this.rdbDaily.CheckedChanged += new System.EventHandler(this.rdbDaily_CheckedChanged);
			// 
			// rdbMonthly
			// 
			this.rdbMonthly.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbMonthly.Location = new System.Drawing.Point(8, 66);
			this.rdbMonthly.Name = "rdbMonthly";
			this.rdbMonthly.Size = new System.Drawing.Size(64, 16);
			this.rdbMonthly.TabIndex = 5;
			this.rdbMonthly.Text = "Monthly";
			this.rdbMonthly.CheckedChanged += new System.EventHandler(this.rdbMonthly_CheckedChanged);
			// 
			// rdbYearly
			// 
			this.rdbYearly.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbYearly.Location = new System.Drawing.Point(8, 89);
			this.rdbYearly.Name = "rdbYearly";
			this.rdbYearly.Size = new System.Drawing.Size(64, 16);
			this.rdbYearly.TabIndex = 5;
			this.rdbYearly.Text = "Yearly";
			this.rdbYearly.CheckedChanged += new System.EventHandler(this.rdbYearly_CheckedChanged);
			// 
			// grbMonthlyPattern
			// 
			this.grbMonthlyPattern.Controls.AddRange(new System.Windows.Forms.Control[] {
																							this.txtMonthNthInterval,
																							this.label6,
																							this.cboMonthlyDayWeek,
																							this.cboMonthlyOccurrence,
																							this.txtMonthlyInterval,
																							this.label5,
																							this.txtDayOfMonth,
																							this.rdbDayOfMonth,
																							this.rdbMonthNth,
																							this.label7,
																							this.label8});
			this.grbMonthlyPattern.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grbMonthlyPattern.Location = new System.Drawing.Point(100, 12);
			this.grbMonthlyPattern.Name = "grbMonthlyPattern";
			this.grbMonthlyPattern.Size = new System.Drawing.Size(364, 100);
			this.grbMonthlyPattern.TabIndex = 6;
			this.grbMonthlyPattern.TabStop = false;
			this.grbMonthlyPattern.Visible = false;
			// 
			// txtMonthNthInterval
			// 
			this.txtMonthNthInterval.Location = new System.Drawing.Point(268, 50);
			this.txtMonthNthInterval.Name = "txtMonthNthInterval";
			this.txtMonthNthInterval.Size = new System.Drawing.Size(32, 21);
			this.txtMonthNthInterval.TabIndex = 2;
			this.txtMonthNthInterval.Text = "1";
			this.txtMonthNthInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Location = new System.Drawing.Point(224, 54);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 14);
			this.label6.TabIndex = 6;
			this.label6.Text = "of every";
			// 
			// cboMonthlyDayWeek
			// 
			this.cboMonthlyDayWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMonthlyDayWeek.Location = new System.Drawing.Point(124, 50);
			this.cboMonthlyDayWeek.Name = "cboMonthlyDayWeek";
			this.cboMonthlyDayWeek.Size = new System.Drawing.Size(96, 21);
			this.cboMonthlyDayWeek.TabIndex = 5;
			// 
			// cboMonthlyOccurrence
			// 
			this.cboMonthlyOccurrence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMonthlyOccurrence.Location = new System.Drawing.Point(48, 50);
			this.cboMonthlyOccurrence.Name = "cboMonthlyOccurrence";
			this.cboMonthlyOccurrence.Size = new System.Drawing.Size(72, 21);
			this.cboMonthlyOccurrence.TabIndex = 5;
			// 
			// txtMonthlyInterval
			// 
			this.txtMonthlyInterval.Location = new System.Drawing.Point(144, 18);
			this.txtMonthlyInterval.Name = "txtMonthlyInterval";
			this.txtMonthlyInterval.Size = new System.Drawing.Size(32, 21);
			this.txtMonthlyInterval.TabIndex = 2;
			this.txtMonthlyInterval.Text = "1";
			this.txtMonthlyInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(96, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 14);
			this.label5.TabIndex = 4;
			this.label5.Text = "of every";
			// 
			// txtDayOfMonth
			// 
			this.txtDayOfMonth.Location = new System.Drawing.Point(56, 18);
			this.txtDayOfMonth.Name = "txtDayOfMonth";
			this.txtDayOfMonth.Size = new System.Drawing.Size(32, 21);
			this.txtDayOfMonth.TabIndex = 2;
			this.txtDayOfMonth.Text = "1";
			this.txtDayOfMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// rdbDayOfMonth
			// 
			this.rdbDayOfMonth.Checked = true;
			this.rdbDayOfMonth.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbDayOfMonth.Location = new System.Drawing.Point(8, 20);
			this.rdbDayOfMonth.Name = "rdbDayOfMonth";
			this.rdbDayOfMonth.Size = new System.Drawing.Size(48, 16);
			this.rdbDayOfMonth.TabIndex = 1;
			this.rdbDayOfMonth.TabStop = true;
			this.rdbDayOfMonth.Text = "Day";
			// 
			// rdbMonthNth
			// 
			this.rdbMonthNth.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbMonthNth.Location = new System.Drawing.Point(8, 52);
			this.rdbMonthNth.Name = "rdbMonthNth";
			this.rdbMonthNth.Size = new System.Drawing.Size(44, 16);
			this.rdbMonthNth.TabIndex = 1;
			this.rdbMonthNth.Text = "The";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label7.Location = new System.Drawing.Point(304, 54);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 14);
			this.label7.TabIndex = 6;
			this.label7.Text = "month(s)";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label8.Location = new System.Drawing.Point(180, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 14);
			this.label8.TabIndex = 6;
			this.label8.Text = "month(s)";
			// 
			// grbYearlyPattern
			// 
			this.grbYearlyPattern.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.cboYearlyOccurrence,
																						   this.txtYearlyDayOfMonth,
																						   this.label14,
																						   this.rdbMonthOfYear,
																						   this.cboYearlyDayOfWeek,
																						   this.rdbYearNth,
																						   this.cboMonthOfYear,
																						   this.cboMonthOfYearNth});
			this.grbYearlyPattern.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grbYearlyPattern.Location = new System.Drawing.Point(100, 12);
			this.grbYearlyPattern.Name = "grbYearlyPattern";
			this.grbYearlyPattern.Size = new System.Drawing.Size(364, 100);
			this.grbYearlyPattern.TabIndex = 5;
			this.grbYearlyPattern.TabStop = false;
			this.grbYearlyPattern.Visible = false;
			// 
			// cboYearlyOccurrence
			// 
			this.cboYearlyOccurrence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboYearlyOccurrence.Location = new System.Drawing.Point(54, 50);
			this.cboYearlyOccurrence.Name = "cboYearlyOccurrence";
			this.cboYearlyOccurrence.Size = new System.Drawing.Size(76, 21);
			this.cboYearlyOccurrence.TabIndex = 5;
			// 
			// txtYearlyDayOfMonth
			// 
			this.txtYearlyDayOfMonth.Location = new System.Drawing.Point(176, 18);
			this.txtYearlyDayOfMonth.Name = "txtYearlyDayOfMonth";
			this.txtYearlyDayOfMonth.Size = new System.Drawing.Size(32, 21);
			this.txtYearlyDayOfMonth.TabIndex = 2;
			this.txtYearlyDayOfMonth.Text = "1";
			this.txtYearlyDayOfMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label14.Location = new System.Drawing.Point(234, 54);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(14, 14);
			this.label14.TabIndex = 6;
			this.label14.Text = "of";
			// 
			// rdbMonthOfYear
			// 
			this.rdbMonthOfYear.Checked = true;
			this.rdbMonthOfYear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbMonthOfYear.Location = new System.Drawing.Point(8, 20);
			this.rdbMonthOfYear.Name = "rdbMonthOfYear";
			this.rdbMonthOfYear.Size = new System.Drawing.Size(48, 16);
			this.rdbMonthOfYear.TabIndex = 1;
			this.rdbMonthOfYear.TabStop = true;
			this.rdbMonthOfYear.Text = "Every";
			// 
			// cboYearlyDayOfWeek
			// 
			this.cboYearlyDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboYearlyDayOfWeek.Location = new System.Drawing.Point(132, 50);
			this.cboYearlyDayOfWeek.Name = "cboYearlyDayOfWeek";
			this.cboYearlyDayOfWeek.Size = new System.Drawing.Size(100, 21);
			this.cboYearlyDayOfWeek.TabIndex = 5;
			// 
			// rdbYearNth
			// 
			this.rdbYearNth.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbYearNth.Location = new System.Drawing.Point(8, 52);
			this.rdbYearNth.Name = "rdbYearNth";
			this.rdbYearNth.Size = new System.Drawing.Size(44, 16);
			this.rdbYearNth.TabIndex = 1;
			this.rdbYearNth.Text = "The";
			// 
			// cboMonthOfYear
			// 
			this.cboMonthOfYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMonthOfYear.Location = new System.Drawing.Point(64, 18);
			this.cboMonthOfYear.Name = "cboMonthOfYear";
			this.cboMonthOfYear.Size = new System.Drawing.Size(104, 21);
			this.cboMonthOfYear.TabIndex = 5;
			// 
			// cboMonthOfYearNth
			// 
			this.cboMonthOfYearNth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMonthOfYearNth.Location = new System.Drawing.Point(250, 50);
			this.cboMonthOfYearNth.Name = "cboMonthOfYearNth";
			this.cboMonthOfYearNth.Size = new System.Drawing.Size(104, 21);
			this.cboMonthOfYearNth.TabIndex = 5;
			// 
			// grbDailyPattern
			// 
			this.grbDailyPattern.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.txtDailyInterval,
																						  this.rdbDailyInterval,
																						  this.rdbWeekDay,
																						  this.label11,
																						  this.rdbWeekendDay});
			this.grbDailyPattern.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grbDailyPattern.Location = new System.Drawing.Point(100, 12);
			this.grbDailyPattern.Name = "grbDailyPattern";
			this.grbDailyPattern.Size = new System.Drawing.Size(364, 100);
			this.grbDailyPattern.TabIndex = 4;
			this.grbDailyPattern.TabStop = false;
			this.grbDailyPattern.Visible = false;
			// 
			// txtDailyInterval
			// 
			this.txtDailyInterval.Location = new System.Drawing.Point(64, 18);
			this.txtDailyInterval.Name = "txtDailyInterval";
			this.txtDailyInterval.Size = new System.Drawing.Size(32, 21);
			this.txtDailyInterval.TabIndex = 2;
			this.txtDailyInterval.Text = "1";
			this.txtDailyInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// rdbDailyInterval
			// 
			this.rdbDailyInterval.Checked = true;
			this.rdbDailyInterval.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbDailyInterval.Location = new System.Drawing.Point(8, 20);
			this.rdbDailyInterval.Name = "rdbDailyInterval";
			this.rdbDailyInterval.Size = new System.Drawing.Size(48, 16);
			this.rdbDailyInterval.TabIndex = 1;
			this.rdbDailyInterval.TabStop = true;
			this.rdbDailyInterval.Text = "Every";
			// 
			// rdbWeekDay
			// 
			this.rdbWeekDay.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbWeekDay.Location = new System.Drawing.Point(8, 46);
			this.rdbWeekDay.Name = "rdbWeekDay";
			this.rdbWeekDay.Size = new System.Drawing.Size(100, 16);
			this.rdbWeekDay.TabIndex = 1;
			this.rdbWeekDay.Text = "Every weekday";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(104, 22);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(36, 14);
			this.label11.TabIndex = 4;
			this.label11.Text = "day(s)";
			// 
			// rdbWeekendDay
			// 
			this.rdbWeekendDay.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbWeekendDay.Location = new System.Drawing.Point(8, 72);
			this.rdbWeekendDay.Name = "rdbWeekendDay";
			this.rdbWeekendDay.Size = new System.Drawing.Size(124, 16);
			this.rdbWeekendDay.TabIndex = 1;
			this.rdbWeekendDay.Text = "Every weekend day";
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOK.Location = new System.Drawing.Point(93, 308);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(86, 24);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCancel.Location = new System.Drawing.Point(186, 308);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(86, 24);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// grbRecurrenceRange
			// 
			this.grbRecurrenceRange.Controls.AddRange(new System.Windows.Forms.Control[] {
																							 this.txtOccurrences,
																							 this.rdbNoEndDate,
																							 this.jccRecurrenceStart,
																							 this.label3,
																							 this.rdbOccurrences,
																							 this.rdbPatternEndDate,
																							 this.jccRecurrenceEndDate,
																							 this.label10});
			this.grbRecurrenceRange.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grbRecurrenceRange.Location = new System.Drawing.Point(8, 192);
			this.grbRecurrenceRange.Name = "grbRecurrenceRange";
			this.grbRecurrenceRange.Size = new System.Drawing.Size(472, 108);
			this.grbRecurrenceRange.TabIndex = 4;
			this.grbRecurrenceRange.TabStop = false;
			this.grbRecurrenceRange.Text = "Range of Recurrence";
			// 
			// txtOccurrences
			// 
			this.txtOccurrences.Location = new System.Drawing.Point(292, 49);
			this.txtOccurrences.Name = "txtOccurrences";
			this.txtOccurrences.Size = new System.Drawing.Size(32, 21);
			this.txtOccurrences.TabIndex = 2;
			this.txtOccurrences.Text = "10";
			this.txtOccurrences.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// rdbNoEndDate
			// 
			this.rdbNoEndDate.Checked = true;
			this.rdbNoEndDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbNoEndDate.Location = new System.Drawing.Point(208, 22);
			this.rdbNoEndDate.Name = "rdbNoEndDate";
			this.rdbNoEndDate.Size = new System.Drawing.Size(88, 16);
			this.rdbNoEndDate.TabIndex = 2;
			this.rdbNoEndDate.TabStop = true;
			this.rdbNoEndDate.Text = "No end date";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(8, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 14);
			this.label3.TabIndex = 1;
			this.label3.Text = "Start:";
			// 
			// rdbOccurrences
			// 
			this.rdbOccurrences.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbOccurrences.Location = new System.Drawing.Point(208, 51);
			this.rdbOccurrences.Name = "rdbOccurrences";
			this.rdbOccurrences.Size = new System.Drawing.Size(72, 16);
			this.rdbOccurrences.TabIndex = 2;
			this.rdbOccurrences.Text = "End after:";
			// 
			// rdbPatternEndDate
			// 
			this.rdbPatternEndDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbPatternEndDate.Location = new System.Drawing.Point(208, 80);
			this.rdbPatternEndDate.Name = "rdbPatternEndDate";
			this.rdbPatternEndDate.Size = new System.Drawing.Size(72, 16);
			this.rdbPatternEndDate.TabIndex = 2;
			this.rdbPatternEndDate.Text = "End date:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(332, 53);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 14);
			this.label10.TabIndex = 4;
			this.label10.Text = "occurrences";
			// 
			// btnRemoveRecurrence
			// 
			this.btnRemoveRecurrence.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnRemoveRecurrence.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnRemoveRecurrence.Location = new System.Drawing.Point(279, 308);
			this.btnRemoveRecurrence.Name = "btnRemoveRecurrence";
			this.btnRemoveRecurrence.Size = new System.Drawing.Size(116, 24);
			this.btnRemoveRecurrence.TabIndex = 5;
			this.btnRemoveRecurrence.Text = "Remove Recurrence";
			this.btnRemoveRecurrence.Click += new System.EventHandler(this.btnRemoveRecurrence_Click);
			// 
			// RecurrenceForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(488, 342);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnRemoveRecurrence,
																		  this.grbRecurrenceRange,
																		  this.btnCancel,
																		  this.btnOK,
																		  this.grbPattern,
																		  this.grbAppointmentTime});
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RecurrenceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Appointment Recurrence";
			this.grbAppointmentTime.ResumeLayout(false);
			this.grbPattern.ResumeLayout(false);
			this.grbWeeklyPattern.ResumeLayout(false);
			this.grbMonthlyPattern.ResumeLayout(false);
			this.grbYearlyPattern.ResumeLayout(false);
			this.grbDailyPattern.ResumeLayout(false);
			this.grbRecurrenceRange.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private RecurrencePattern recurrencePattern = null;
		private ScheduleAppointment Appointment = null;
		public void ShowRecurrenceForm(ScheduleAppointment appointment)
		{
			this.PopulateCombos();
			this.Appointment = appointment;
			if(this.Appointment.RecurrencePattern != null)
			{
				this.recurrencePattern = appointment.RecurrencePattern;
			}
			else
			{
				this.recurrencePattern = new RecurrencePattern();
			}
			this.SetDefaultValues();
			this.ShowDialog();
		}

		private ScheduleDayOfWeek GetSelectedWeekDays()
		{
			ScheduleDayOfWeek daysOfWeek = 0;
			if(this.chkMonday.Checked)
			{
				daysOfWeek |= ScheduleDayOfWeek.Monday;
			}
			if(this.chkTuesday.Checked)
			{
				daysOfWeek |= ScheduleDayOfWeek.Tuesday;
			}
			if(this.chkWednesday.Checked)
			{
				daysOfWeek |= ScheduleDayOfWeek.Wednesday;
			}
			if(this.chkThursday.Checked)
			{
				daysOfWeek |= ScheduleDayOfWeek.Thursday;
			}
			if(this.chkFriday.Checked)
			{
				daysOfWeek |= ScheduleDayOfWeek.Friday;
			}
			if(this.chkSaturday.Checked)
			{
				daysOfWeek |= ScheduleDayOfWeek.Saturday;
			}
			if(this.chkSunday.Checked)
			{
				daysOfWeek |= ScheduleDayOfWeek.Sunday;
			}
			return daysOfWeek;
		}

		private void SelectDaysOfWeek()
		{
			if((this.recurrencePattern.DayOfWeek & ScheduleDayOfWeek.Monday) != 0)
				this.chkMonday.Checked = true;
			else
				this.chkMonday.Checked = false;
			
			if((this.recurrencePattern.DayOfWeek & ScheduleDayOfWeek.Tuesday) != 0)
				this.chkTuesday.Checked = true;
			else
				this.chkTuesday.Checked = false;
			
			if((this.recurrencePattern.DayOfWeek & ScheduleDayOfWeek.Wednesday) != 0)
				this.chkWednesday.Checked = true;
			else
				this.chkWednesday.Checked = false;
			
			if((this.recurrencePattern.DayOfWeek & ScheduleDayOfWeek.Thursday) != 0)
				this.chkThursday.Checked = true;
			else
				this.chkThursday.Checked = false;

			if((this.recurrencePattern.DayOfWeek & ScheduleDayOfWeek.Friday) != 0)
				this.chkFriday.Checked = true;
			else
				this.chkFriday.Checked = false;

			if((this.recurrencePattern.DayOfWeek & ScheduleDayOfWeek.Saturday) != 0)
				this.chkSaturday.Checked = true;
			else
				this.chkSaturday.Checked = false;
			
			if((this.recurrencePattern.DayOfWeek & ScheduleDayOfWeek.Sunday) != 0)
				this.chkSunday.Checked = true;
			else
				this.chkSunday.Checked = false;
		}

		private void SetDefaultValues()
		{
			this.btnRemoveRecurrence.Enabled = (this.Appointment.RecurrencePattern != null);
			
			if(this.Appointment.RecurrencePattern != null)
			{
				this.jccRecurrenceEndDate.Value = recurrencePattern.PatternEndDate;
				this.jccRecurrenceStart.Value = recurrencePattern.PatternStartDate;

				this.jccStartTime.Value = jccRecurrenceStart.Value.Date.Add(recurrencePattern.StartTime);
				this.jccEndTime.Value = jccRecurrenceStart.Value.Date.Add(recurrencePattern.EndTime);
				this.txtOccurrences.Text = this.recurrencePattern.Occurrences.ToString();
				switch(this.recurrencePattern.RecurrenceType)
				{
					case RecurrenceType.Daily:
						this.rdbDaily.Checked = true;
						break;
					case RecurrenceType.Weekly:
						this.rdbWeekly.Checked = true;
						this.SelectDaysOfWeek();
						this.txtWeeklyInterval.Text = this.recurrencePattern.Interval.ToString();
						break;
					case RecurrenceType.Monthly:
						this.rdbMonthly.Checked = true;
						break;
					case RecurrenceType.MontNth:
						this.rdbMonthNth.Checked = true;
						break;
					case RecurrenceType.Yearly:
						this.rdbYearly.Checked = true;
						break;
					case RecurrenceType.YearNth:
						this.rdbYearNth.Checked = true;
						break;
				}
				if(this.recurrencePattern.RecurrenceEndMode == RecurrenceEndMode.EndDate)
				{
					this.rdbPatternEndDate.Checked = true;
				}
				else if(this.recurrencePattern.RecurrenceEndMode == RecurrenceEndMode.Occurrences)
				{
					this.rdbOccurrences.Checked = true;
				}
			}
			else
			{
				this.jccStartTime.Value = Appointment.StartTime;
				this.jccEndTime.Value = Appointment.EndTime;
				this.jccRecurrenceStart.Value = Appointment.StartTime.Date;
				this.jccRecurrenceEndDate.Value = this.jccRecurrenceStart.Value.AddDays(9 * 7);
				this.rdbWeekly.Checked = true;
				this.recurrencePattern.SetDefaultValuesForDate(this.jccRecurrenceStart.Value);
				this.SelectDaysOfWeek();
			}
		}

		private void PopulateCombos()
		{
			ScheduleDayOfWeek dayOption = ScheduleDayOfWeek.Monday | ScheduleDayOfWeek.Tuesday |
				ScheduleDayOfWeek.Wednesday | ScheduleDayOfWeek.Thursday | ScheduleDayOfWeek.Friday | 
				ScheduleDayOfWeek.Saturday | ScheduleDayOfWeek.Sunday;

			ScheduleDayOfWeek weekDayOption = ScheduleDayOfWeek.Monday | ScheduleDayOfWeek.Tuesday |
				ScheduleDayOfWeek.Wednesday | ScheduleDayOfWeek.Thursday | ScheduleDayOfWeek.Friday;

			ScheduleDayOfWeek weekEndDayOption = ScheduleDayOfWeek.Saturday | ScheduleDayOfWeek.Sunday;
									

			ComboItem dayItem = new ComboItem("Day", dayOption);
			ComboItem weekDayItem = new ComboItem("Week day", weekDayOption);
			ComboItem weekEndDayItem = new ComboItem("Weekend day", weekEndDayOption);
			ComboItem sundayItem = new ComboItem("Sunday", ScheduleDayOfWeek.Sunday);
			ComboItem mondayItem = new ComboItem("Monday", ScheduleDayOfWeek.Monday);
			ComboItem tuesdayItem = new ComboItem("Tuesday", ScheduleDayOfWeek.Tuesday);
			ComboItem wednesdayItem = new ComboItem("Wednesday", ScheduleDayOfWeek.Wednesday);
			ComboItem thursdayItem = new ComboItem("Thursday", ScheduleDayOfWeek.Thursday);
			ComboItem fridayItem = new ComboItem("Friday", ScheduleDayOfWeek.Friday);
			ComboItem saturdayItem = new ComboItem("Saturday", ScheduleDayOfWeek.Saturday);

			this.cboMonthlyDayWeek.Items.Add(dayItem);
			this.cboMonthlyDayWeek.Items.Add(weekDayItem);
			this.cboMonthlyDayWeek.Items.Add(weekEndDayItem);
			this.cboMonthlyDayWeek.Items.Add(sundayItem);
			this.cboMonthlyDayWeek.Items.Add(mondayItem);
			this.cboMonthlyDayWeek.Items.Add(tuesdayItem);
			this.cboMonthlyDayWeek.Items.Add(wednesdayItem);
			this.cboMonthlyDayWeek.Items.Add(thursdayItem);
			this.cboMonthlyDayWeek.Items.Add(fridayItem);
			this.cboMonthlyDayWeek.Items.Add(saturdayItem);

			this.cboMonthlyDayWeek.DisplayMember = "Text";
			this.cboMonthlyDayWeek.ValueMember = "Value";

			this.cboYearlyDayOfWeek.Items.Add(dayItem);
			this.cboYearlyDayOfWeek.Items.Add(weekDayItem);
			this.cboYearlyDayOfWeek.Items.Add(weekEndDayItem);
			this.cboYearlyDayOfWeek.Items.Add(sundayItem);
			this.cboYearlyDayOfWeek.Items.Add(mondayItem);
			this.cboYearlyDayOfWeek.Items.Add(tuesdayItem);
			this.cboYearlyDayOfWeek.Items.Add(wednesdayItem);
			this.cboYearlyDayOfWeek.Items.Add(thursdayItem);
			this.cboYearlyDayOfWeek.Items.Add(fridayItem);
			this.cboYearlyDayOfWeek.Items.Add(saturdayItem);

			this.cboYearlyDayOfWeek.DisplayMember = "Text";
			this.cboYearlyDayOfWeek.ValueMember = "Value";

			this.cboMonthlyOccurrence.Items.Add(Janus.Windows.Schedule.OccurrenceInMonth.First);
			this.cboMonthlyOccurrence.Items.Add(Janus.Windows.Schedule.OccurrenceInMonth.Second);
			this.cboMonthlyOccurrence.Items.Add(Janus.Windows.Schedule.OccurrenceInMonth.Third);
			this.cboMonthlyOccurrence.Items.Add(Janus.Windows.Schedule.OccurrenceInMonth.Fourth);
			this.cboMonthlyOccurrence.Items.Add(Janus.Windows.Schedule.OccurrenceInMonth.Last);

			this.cboMonthlyOccurrence.SelectedIndex = 0;
			this.cboMonthlyOccurrence.ValueMember = "Value";

			this.cboYearlyOccurrence.Items.Add(Janus.Windows.Schedule.OccurrenceInMonth.First);
			this.cboYearlyOccurrence.Items.Add(Janus.Windows.Schedule.OccurrenceInMonth.Second);
			this.cboYearlyOccurrence.Items.Add(Janus.Windows.Schedule.OccurrenceInMonth.Third);
			this.cboYearlyOccurrence.Items.Add(Janus.Windows.Schedule.OccurrenceInMonth.Fourth);
			this.cboYearlyOccurrence.Items.Add(Janus.Windows.Schedule.OccurrenceInMonth.Last);

			this.cboYearlyOccurrence.SelectedIndex = 0;
			this.cboYearlyOccurrence.ValueMember = "Value";

			this.cboMonthOfYear.Items.Add(new ComboItem("January", 1));
			this.cboMonthOfYear.Items.Add(new ComboItem("February", 2));
			this.cboMonthOfYear.Items.Add(new ComboItem("March", 3));
			this.cboMonthOfYear.Items.Add(new ComboItem("April", 4));
			this.cboMonthOfYear.Items.Add(new ComboItem("May", 5));
			this.cboMonthOfYear.Items.Add(new ComboItem("June", 6));
			this.cboMonthOfYear.Items.Add(new ComboItem("July", 7));
			this.cboMonthOfYear.Items.Add(new ComboItem("August", 8));
			this.cboMonthOfYear.Items.Add(new ComboItem("September", 9));
			this.cboMonthOfYear.Items.Add(new ComboItem("October", 10));
			this.cboMonthOfYear.Items.Add(new ComboItem("November", 11));
			this.cboMonthOfYear.Items.Add(new ComboItem("December", 12));
			this.cboMonthOfYear.DisplayMember = "Text";
			this.cboMonthOfYear.ValueMember = "Value";

			this.cboMonthOfYearNth.Items.Add(new ComboItem("January", 1));
			this.cboMonthOfYearNth.Items.Add(new ComboItem("February", 2));
			this.cboMonthOfYearNth.Items.Add(new ComboItem("March", 3));
			this.cboMonthOfYearNth.Items.Add(new ComboItem("April", 4));
			this.cboMonthOfYearNth.Items.Add(new ComboItem("May", 5));
			this.cboMonthOfYearNth.Items.Add(new ComboItem("June", 6));
			this.cboMonthOfYearNth.Items.Add(new ComboItem("July", 7));
			this.cboMonthOfYearNth.Items.Add(new ComboItem("August", 8));
			this.cboMonthOfYearNth.Items.Add(new ComboItem("September", 9));
			this.cboMonthOfYearNth.Items.Add(new ComboItem("October", 10));
			this.cboMonthOfYearNth.Items.Add(new ComboItem("November", 11));
			this.cboMonthOfYearNth.Items.Add(new ComboItem("December", 12));
			this.cboMonthOfYearNth.DisplayMember = "Text";
			this.cboMonthOfYearNth.ValueMember = "Value";
		}

		private bool SetRecurrencePatternValues()
		{			
			if(this.Appointment.RecurrencePattern == null)
			{
				this.Appointment.RecurrencePattern = recurrencePattern;
			}

			recurrencePattern.BeginEdit();
			try
			{
				recurrencePattern.StartTime = this.jccStartTime.Value.TimeOfDay;
				recurrencePattern.EndTime = this.jccEndTime.Value.TimeOfDay;
				recurrencePattern.PatternStartDate = this.jccRecurrenceStart.Value;
				recurrencePattern.PatternEndDate = this.jccRecurrenceEndDate.Value;
				if(this.rdbDaily.Checked)
				{
					recurrencePattern.RecurrenceType = RecurrenceType.Daily;
					recurrencePattern.Interval = int.Parse(this.txtDailyInterval.Text);
					if(this.rdbWeekDay.Checked)
					{
						recurrencePattern.DailyRecurrenceMode = DailyRecurrenceMode.WeekDays;
					}
					else if(this.rdbWeekendDay.Checked)
					{
						recurrencePattern.DailyRecurrenceMode = DailyRecurrenceMode.WeekendDays;
					}
				}
				else if(this.rdbWeekly.Checked)
				{
					recurrencePattern.RecurrenceType = RecurrenceType.Weekly;
					recurrencePattern.Interval = int.Parse(this.txtWeeklyInterval.Text);
					recurrencePattern.DayOfWeek = this.GetSelectedWeekDays();
				}
				else if(this.rdbMonthly.Checked)
				{
					if(this.rdbMonthNth.Checked)
					{
						recurrencePattern.RecurrenceType = RecurrenceType.MontNth;
						recurrencePattern.OccurrenceInMonth = (Janus.Windows.Schedule.OccurrenceInMonth)this.cboMonthlyOccurrence.SelectedItem;
						recurrencePattern.DayOfWeek = (ScheduleDayOfWeek)((ComboItem)this.cboMonthlyDayWeek.SelectedItem).Value;
						recurrencePattern.Interval = int.Parse(this.txtMonthNthInterval.Text);
					}
					else
					{
						recurrencePattern.RecurrenceType = RecurrenceType.Monthly;
						recurrencePattern.DayOfMonth = int.Parse(this.txtDayOfMonth.Text);
						recurrencePattern.Interval = int.Parse(this.txtMonthlyInterval.Text);
					}
				}
				else if(this.rdbYearly.Checked)
				{
					if(this.rdbYearNth.Checked)
					{
						recurrencePattern.RecurrenceType = RecurrenceType.YearNth;
						recurrencePattern.MonthOfYear = (int)((ComboItem)this.cboMonthOfYearNth.SelectedItem).Value;
						recurrencePattern.OccurrenceInMonth = (OccurrenceInMonth)this.cboYearlyOccurrence.SelectedItem;
						recurrencePattern.DayOfWeek = (ScheduleDayOfWeek)((ComboItem)this.cboYearlyDayOfWeek.SelectedItem).Value;
					}
					else
					{
						recurrencePattern.RecurrenceType = RecurrenceType.Yearly;
						recurrencePattern.MonthOfYear = (int)((ComboItem)this.cboMonthOfYear.SelectedItem).Value;
						recurrencePattern.DayOfMonth = int.Parse(this.txtYearlyDayOfMonth.Text);
					}
				}

				if(this.rdbNoEndDate.Checked)
				{
					recurrencePattern.RecurrenceEndMode = RecurrenceEndMode.NoEndDate;
				}
				else if(this.rdbOccurrences.Checked)
				{
					recurrencePattern.RecurrenceEndMode = RecurrenceEndMode.Occurrences;
					recurrencePattern.Occurrences = int.Parse(this.txtOccurrences.Text);
				}
				else
				{
					recurrencePattern.RecurrenceEndMode = RecurrenceEndMode.EndDate;
					recurrencePattern.PatternEndDate = this.jccRecurrenceEndDate.Value;
				}

			}
			catch
			{
				MessageBox.Show(this, "The recurrence pattern is not valid", "DataBound Sample", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			recurrencePattern.EndEdit();
			return true;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.recurrencePattern != null && this.recurrencePattern.Exceptions.Count > 0)
				{
					DialogResult result = MessageBox.Show(this, "Any exceptions associated with this recurring appointment will be lost. Is this OK?",
						"Janus Schedule Sample", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

					if(result == DialogResult.Cancel)
					{
						return;
					}
					
				}
				if(this.SetRecurrencePatternValues())
				{
					this.Close();
				}
			}
			catch
			{
				MessageBox.Show("Sample Schedule", "The recurrence pattern is not valid");
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void SelectComboValue(ComboBox comboBox, object value)
		{
			foreach(ComboItem item in comboBox.Items)
			{
				if(item.Value.Equals(value))
				{
					comboBox.SelectedItem = item;
					break;
				}
			}
		}

		private void rdbDaily_CheckedChanged(object sender, System.EventArgs e)
		{
			this.grbDailyPattern.Visible = this.rdbDaily.Checked;
			this.txtDailyInterval.Text = this.recurrencePattern.Interval.ToString();
			switch(this.recurrencePattern.DailyRecurrenceMode)
			{
				case DailyRecurrenceMode.UseInterval:
					this.rdbDailyInterval.Checked = true;
					break;
				case DailyRecurrenceMode.WeekDays:
					this.rdbWeekDay.Checked = true;
					break;
				case DailyRecurrenceMode.WeekendDays:
					this.rdbWeekendDay.Checked = true;
					break;
			}
		}

		private void rdbWeekly_CheckedChanged(object sender, System.EventArgs e)
		{
			this.grbWeeklyPattern.Visible = this.rdbWeekly.Checked;
			this.recurrencePattern.SetDefaultValuesForDate(this.jccRecurrenceStart.Value);
			this.txtWeeklyInterval.Text = this.recurrencePattern.Interval.ToString(); 
			this.SelectDaysOfWeek();
		}

		private void rdbMonthly_CheckedChanged(object sender, System.EventArgs e)
		{
			this.grbMonthlyPattern.Visible = this.rdbMonthly.Checked;
			this.recurrencePattern.SetDefaultValuesForDate(this.jccRecurrenceStart.Value);
			this.txtDayOfMonth.Text = this.recurrencePattern.DayOfMonth.ToString();
			this.SelectComboValue(this.cboMonthlyDayWeek, this.recurrencePattern.DayOfWeek);
			this.cboMonthlyOccurrence.SelectedItem = this.recurrencePattern.OccurrenceInMonth;			
			this.txtMonthlyInterval.Text = this.recurrencePattern.Interval.ToString();
			this.txtMonthNthInterval.Text = this.recurrencePattern.Interval.ToString();
		}

		private void rdbYearly_CheckedChanged(object sender, System.EventArgs e)
		{
			this.grbYearlyPattern.Visible = this.rdbYearly.Checked;
			this.recurrencePattern.SetDefaultValuesForDate(this.jccRecurrenceStart.Value);
			this.txtYearlyDayOfMonth.Text = this.recurrencePattern.DayOfMonth.ToString();
			this.SelectComboValue(this.cboYearlyDayOfWeek, this.recurrencePattern.DayOfWeek);
			this.SelectComboValue(this.cboMonthOfYear, this.recurrencePattern.MonthOfYear);
			this.SelectComboValue(this.cboMonthOfYearNth, this.recurrencePattern.MonthOfYear);
			this.cboYearlyOccurrence.SelectedItem = this.recurrencePattern.OccurrenceInMonth;
		}

		private void btnRemoveRecurrence_Click(object sender, System.EventArgs e)
		{
			this.Appointment.RecurrencePattern = null;
			this.Close();
		}

	}
}