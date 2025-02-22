using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace schedule_manager
{
	/// <summary>
	/// Summary description for DateNavigator.
	/// </summary>
	public class DateNavigator : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.ComboBox cboView;
		private Janus.Windows.CalendarCombo.CalendarCombo clcDate;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DateNavigator()
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
			this.clcDate = new Janus.Windows.CalendarCombo.CalendarCombo();
			this.cboView = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// clcDate
			// 
			this.clcDate.BackColor = System.Drawing.SystemColors.Window;
			this.clcDate.BindableValue = new System.DateTime(2002, 1, 24, 0, 0, 0, 0);
			this.clcDate.CustomFormat = "ddd M/dd/yy";
			this.clcDate.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom;
			// 
			// clcDate.DropDownCalendar
			// 
			this.clcDate.DropDownCalendar.Size = new System.Drawing.Size(166, 136);
			this.clcDate.DropDownCalendar.TabIndex = 0;
			this.clcDate.DropDownCalendar.Text = "Calendar";
			this.clcDate.Location = new System.Drawing.Point(72, 16);
			this.clcDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.clcDate.MinDate = new System.DateTime(1, 2, 1, 0, 0, 0, 0);
			this.clcDate.Name = "clcDate";
			this.clcDate.Size = new System.Drawing.Size(128, 21);
			this.clcDate.TabIndex = 2;
			this.clcDate.Value = new System.DateTime(2002, 1, 24, 0, 0, 0, 0);
			// 
			// cboView
			// 
			this.cboView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboView.Items.AddRange(new object[] {
														 "Day Calendar",
														 "Week Calendar",
														 "Month Calendar",
														 "Work Week Calendar"});
			this.cboView.Location = new System.Drawing.Point(72, 40);
			this.cboView.Name = "cboView";
			this.cboView.Size = new System.Drawing.Size(128, 21);
			this.cboView.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.clcDate,
																					this.cboView,
																					this.label1,
																					this.label2});
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(12, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(209, 72);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "&Date:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 14);
			this.label2.TabIndex = 3;
			this.label2.Text = "&Show in:";
			// 
			// btnOk
			// 
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOk.Location = new System.Drawing.Point(232, 16);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 22);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "&OK";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCancel.Location = new System.Drawing.Point(232, 48);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 22);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// DateNavigator
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(316, 86);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnCancel,
																		  this.btnOk,
																		  this.groupBox1});
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DateNavigator";
			this.ShowInTaskbar = false;
			this.Text = "DateNavigator";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		public Janus.Windows.Schedule.Schedule Schedule = null;
		public void ShowDateNavigator(Janus.Windows.Schedule.Schedule schedule)
		{
			this.Schedule = schedule;
			this.clcDate.Value = schedule.Date;
			switch(schedule.View)
			{
				case Janus.Windows.Schedule.ScheduleView.DayView:
					cboView.SelectedIndex = 0;
					break;
				case Janus.Windows.Schedule.ScheduleView.WeekView:
					cboView.SelectedIndex = 1;
					break;
				case Janus.Windows.Schedule.ScheduleView.MonthView:
					cboView.SelectedIndex = 2;
					break;
				case Janus.Windows.Schedule.ScheduleView.WorkWeek:
					cboView.SelectedIndex = 3;
					break;
			}
			this.ShowDialog();
		}
		private void btnOk_Click(object sender, System.EventArgs e)
		{
			if(Schedule != null)
			{
				switch(cboView.SelectedIndex)
				{
					case 0:
						Schedule.View = Janus.Windows.Schedule.ScheduleView.DayView;
						break;
					case 1:
						Schedule.View = Janus.Windows.Schedule.ScheduleView.WeekView;
						break;
					case 2:
						Schedule.View = Janus.Windows.Schedule.ScheduleView.MonthView;
						break;
					case 3:
						Schedule.View = Janus.Windows.Schedule.ScheduleView.WorkWeek;
						break;
				}
				Schedule.Date = clcDate.Value;
				
			}
			this.Close();
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
