using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Janus.Windows.Schedule;

namespace schedule_manager
{
	/// <summary>
	/// Summary description for ReminderForm.
	/// </summary>
	public class ReminderForm : CommonClass.FrmBase
	{
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader chSubject;
		private System.Windows.Forms.ColumnHeader chDue;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.Label lblStartTime;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnSnooze;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnDismissAll;
		private System.Windows.Forms.Button btnDismiss;
		private System.Windows.Forms.ComboBox cboSnoozeTime;
		private ListViewItem selectedItem = null;
		private Janus.Windows.Schedule.Schedule schedule = null;
		private ArrayList reminderAppointments = new ArrayList();
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private void PopulateSnoozeTimeCombo()
		{
			this.cboSnoozeTime.DisplayMember = "Text";
			ComboItem item = new ComboItem("1 minute", new TimeSpan(0,1,0));
			this.cboSnoozeTime.Items.Add(item);
			item = new ComboItem("5 minutes", new TimeSpan(0,5,0));
			this.cboSnoozeTime.Items.Add(item);
			item = new ComboItem("10 minutes", new TimeSpan(0,10,0));
			this.cboSnoozeTime.Items.Add(item);
			item = new ComboItem("15 minutes", new TimeSpan(0,15,0));
			this.cboSnoozeTime.Items.Add(item);
			item = new ComboItem("30 minutes", new TimeSpan(0,30,0));
			this.cboSnoozeTime.Items.Add(item);
			item = new ComboItem("1 hour", new TimeSpan(1,0,0));
			this.cboSnoozeTime.Items.Add(item);
			item = new ComboItem("2 hours", new TimeSpan(2,0,0));
			this.cboSnoozeTime.Items.Add(item);
			item = new ComboItem("4 hours", new TimeSpan(4,0,0));
			this.cboSnoozeTime.Items.Add(item);
			item = new ComboItem("8 hours", new TimeSpan(8,0,0));
			this.cboSnoozeTime.Items.Add(item);
			item = new ComboItem("1 day", new TimeSpan(1,0,0,0));
			this.cboSnoozeTime.Items.Add(item);
			item = new ComboItem("2 days", new TimeSpan(2,0,0,0));
			this.cboSnoozeTime.Items.Add(item);
			item = new ComboItem("4 days", new TimeSpan(4,0,0,0));
			this.cboSnoozeTime.Items.Add(item);
			item = new ComboItem("1 week", new TimeSpan(7,0,0,0));
			this.cboSnoozeTime.Items.Add(item);
			item = new ComboItem("2 weeks", new TimeSpan(14,0,0,0));
			this.cboSnoozeTime.Items.Add(item);
			this.cboSnoozeTime.SelectedItem = this.cboSnoozeTime.Items[0];
		}
		public ReminderForm()
		{
			InitializeComponent();
			this.PopulateSnoozeTimeCombo();
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
		public void CreateReminder(Janus.Windows.Schedule.Schedule schedule, Janus.Windows.Schedule.ScheduleAppointment appointment)
		{
			this.schedule = schedule;
			this.schedule.AppointmentChanged += new AppointmentChangeEventHandler(this.schedule_AppointmentChanged);
			this.schedule.AppointmentRemoved += new AppointmentEventHandler(this.schedule_AppointmentRemoved);
			this.AddItem(appointment);
			this.Show();
		}
		private System.String GetDueTimeText(System.TimeSpan dueTime)
		{
			string text;
			if((int)Math.Abs(dueTime.Days) > 0)
				text = ((int)Math.Abs(dueTime.Days)).ToString() + " days"; 
			else if((int)Math.Abs(dueTime.Hours) > 0)
				text = ((int)Math.Abs(dueTime.Hours)).ToString() + " hours";
			else
				text = ((int)Math.Abs(dueTime.Minutes)).ToString() + " minutes";

			if(dueTime < TimeSpan.Zero)
				text += " overdue";
			return text;
		}
		public void AddItem(Janus.Windows.Schedule.ScheduleAppointment app)
		{
			if(!this.reminderAppointments.Contains(app))
			{
				ListViewItem item = new ListViewItem(app.Text);
				item.Tag = app;
				TimeSpan dueTime = app.StartTime.Subtract(DateTime.Now);
				item.SubItems.Add(this.GetDueTimeText(dueTime));
				item.Selected = true;
				this.listView1.Items.Add(item);
				this.reminderAppointments.Add(app);
			}
		}
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ReminderForm));
			this.listView1 = new System.Windows.Forms.ListView();
			this.chSubject = new System.Windows.Forms.ColumnHeader();
			this.chDue = new System.Windows.Forms.ColumnHeader();
			this.lblText = new System.Windows.Forms.Label();
			this.lblStartTime = new System.Windows.Forms.Label();
			this.btnDismissAll = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnSnooze = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnDismiss = new System.Windows.Forms.Button();
			this.cboSnoozeTime = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.chSubject,
																						this.chDue});
			this.listView1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView1.FullRowSelect = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(8, 80);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(432, 120);
			this.listView1.TabIndex = 0;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// chSubject
			// 
			this.chSubject.Text = "Subject";
			this.chSubject.Width = 300;
			// 
			// chDue
			// 
			this.chDue.Text = "Due in";
			this.chDue.Width = 100;
			// 
			// lblText
			// 
			this.lblText.AutoSize = true;
			this.lblText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblText.Image = ((System.Drawing.Bitmap)(resources.GetObject("lblText.Image")));
			this.lblText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblText.Location = new System.Drawing.Point(16, 16);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(0, 14);
			this.lblText.TabIndex = 1;
			this.lblText.Tag = "";
			this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblStartTime
			// 
			this.lblStartTime.AutoSize = true;
			this.lblStartTime.Location = new System.Drawing.Point(16, 40);
			this.lblStartTime.Name = "lblStartTime";
			this.lblStartTime.Size = new System.Drawing.Size(0, 14);
			this.lblStartTime.TabIndex = 2;
			// 
			// btnDismissAll
			// 
			this.btnDismissAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDismissAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnDismissAll.Location = new System.Drawing.Point(8, 208);
			this.btnDismissAll.Name = "btnDismissAll";
			this.btnDismissAll.Size = new System.Drawing.Size(88, 24);
			this.btnDismissAll.TabIndex = 3;
			this.btnDismissAll.Text = "Dismiss All";
			this.btnDismissAll.Click += new System.EventHandler(this.btnDismissAll_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOpen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnOpen.Location = new System.Drawing.Point(248, 208);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(88, 24);
			this.btnOpen.TabIndex = 4;
			this.btnOpen.Text = "Open Item";
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnSnooze
			// 
			this.btnSnooze.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSnooze.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnSnooze.Location = new System.Drawing.Point(352, 264);
			this.btnSnooze.Name = "btnSnooze";
			this.btnSnooze.Size = new System.Drawing.Size(88, 24);
			this.btnSnooze.TabIndex = 5;
			this.btnSnooze.Text = "Snooze";
			this.btnSnooze.Click += new System.EventHandler(this.btnSnooze_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 240);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(199, 14);
			this.label3.TabIndex = 6;
			this.label3.Text = "Click Snooze to be remainded again in:";
			// 
			// btnDismiss
			// 
			this.btnDismiss.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDismiss.Location = new System.Drawing.Point(352, 208);
			this.btnDismiss.Name = "btnDismiss";
			this.btnDismiss.Size = new System.Drawing.Size(88, 24);
			this.btnDismiss.TabIndex = 7;
			this.btnDismiss.Text = "Dismiss";
			this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
			// 
			// cboSnoozeTime
			// 
			this.cboSnoozeTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSnoozeTime.Location = new System.Drawing.Point(8, 264);
			this.cboSnoozeTime.Name = "cboSnoozeTime";
			this.cboSnoozeTime.Size = new System.Drawing.Size(328, 21);
			this.cboSnoozeTime.TabIndex = 8;
			// 
			// ReminderForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(448, 293);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.cboSnoozeTime,
																		  this.btnDismiss,
																		  this.label3,
																		  this.btnSnooze,
																		  this.btnOpen,
																		  this.btnDismissAll,
																		  this.lblStartTime,
																		  this.lblText,
																		  this.listView1});
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ReminderForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reminder";
			this.ResumeLayout(false);

		}
		#endregion
		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(listView1.SelectedItems.Count > 0)
			{
				this.selectedItem = this.listView1.SelectedItems[0];
				ScheduleAppointment app = (ScheduleAppointment)selectedItem.Tag;
				this.lblStartTime.Text = app.StartTime.ToString("f");
				this.lblText.Text = "     " + app.Text;
			}
			else
				selectedItem = null;
		}
		private void btnDismiss_Click(object sender, System.EventArgs e)
		{
			if(selectedItem != null)
			{
				ScheduleAppointment dismissApp = (ScheduleAppointment)selectedItem.Tag;
				dismissApp.Reminder.Enabled = false;
				this.listView1.Items.Remove(selectedItem);
				if(this.listView1.Items.Count == 0)
				{
					this.Close();
				}
			}
			else
				this.listView1.Items[0].Selected = true;
		}

		private void btnSnooze_Click(object sender, System.EventArgs e)
		{
			if(selectedItem != null)
			{
				ScheduleAppointment dismissApp = (ScheduleAppointment)selectedItem.Tag;
				dismissApp.Reminder.SnoozedInterval = (TimeSpan)((ComboItem)this.cboSnoozeTime.SelectedItem).Value;
				dismissApp.Reminder.Snooze();
				this.listView1.Items.Remove(selectedItem);
				if(this.listView1.Items.Count == 0)
				{
					this.Close();
					return;
				}
			}			
			this.listView1.Items[0].Selected = true;
		}

		private void btnOpen_Click(object sender, System.EventArgs e)
		{
			if(selectedItem != null)
			{
				Appoint form = new Appoint();
				ScheduleAppointment app = (ScheduleAppointment)selectedItem.Tag;
				form.CreateAppointmentForm(this.schedule, app.StartTime, app.Duration, (ScheduleAppointment)selectedItem.Tag);			
			}
			else
			{
				this.listView1.Items[0].Selected = true;
			}
		}
		private void btnDismissAll_Click(object sender, System.EventArgs e)
		{
			foreach(ListViewItem item in this.listView1.Items)
			{
				ScheduleAppointment app = (ScheduleAppointment)item.Tag;
				app.Reminder.Enabled = false;
			}
			this.listView1.Items.Clear();
			this.Close();
		}
		private ListViewItem GetListViewItem(ScheduleAppointment appointment)
		{
			foreach(ListViewItem item in this.listView1.Items)
			{
				if(item.Tag == appointment)
					return item;
			}
			return null;
		}
		private void RemoveAppointment(ScheduleAppointment appointment)
		{
			this.reminderAppointments.Remove(appointment);
			ListViewItem item = this.GetListViewItem(appointment);
			if(item != null)
			{
				this.listView1.Items.Remove(item);
			}
			if(this.listView1.Items.Count ==0)
			{
				this.Close();
			}
		}
		private void schedule_AppointmentRemoved(object sender, AppointmentEventArgs e)
		{
			if(this.reminderAppointments.Contains(e.Appointment))
				this.RemoveAppointment(e.Appointment);
		}
		private void schedule_AppointmentChanged(object sender, AppointmentChangeEventArgs e)
		{
			if(this.reminderAppointments.Contains(e.Appointment))
			{
				ListViewItem item = null;
				switch(e.PropertyChanged)
				{
					case AppointmentChange.Text:
						item = this.GetListViewItem(e.Appointment);
						if(item != null)
						{
							item.Text = e.Appointment.Text;
							if(item.Selected)
								lblText.Text = "     " + e.Appointment.Text;
						}
						break;
					case AppointmentChange.ReminderEnabled:
						if(!e.Appointment.Reminder.Enabled)
						{
							this.RemoveAppointment(e.Appointment);
						}
						break;
					case AppointmentChange.StartTime:
					case AppointmentChange.ReminderInterval:
						if(e.Appointment.Reminder.GetReminderDateTime() > DateTime.Now)
						{
							this.RemoveAppointment(e.Appointment);
						}
						else
						{
							item = this.GetListViewItem(e.Appointment);
							if(item != null)
							{
								TimeSpan dueTime = e.Appointment.StartTime.Subtract(DateTime.Now);
								item.SubItems[1].Text = this.GetDueTimeText(dueTime);
								if(item.Selected)
									this.lblStartTime.Text = e.Appointment.StartTime.ToString("f");
							}
						}
						break;
					default:
						break;
				}
			}
		}
	}
}
