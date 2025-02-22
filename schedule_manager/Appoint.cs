using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Janus.Windows.Schedule;
using System.Data;

namespace schedule_manager
{
	/// <summary>
	/// Summary description for AppointmentForm.
	/// </summary>
	public enum Categories
	{
		None,
		Business,
		Competition,
		Gifts,
		Holiday,
		KeyCustomer,
		Ideas,
		International,
		Personal,
		PhoneCalls,
		Strategies
	}
	public class Appoint : CommonClass.FrmBase
	{
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblBorderColor;
		private System.Windows.Forms.Label lblBkgColor;
		private System.Windows.Forms.Button btnBorderColor;
		private System.Windows.Forms.Button btnBkgColor;
		private System.Windows.Forms.CheckBox chkAllDayEvent;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Panel pnlInfo;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.ComboBox cboReminder;
		private System.Windows.Forms.CheckBox chkReminder;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabDetails;
		private System.Windows.Forms.TabPage tabCategories;
		private System.Windows.Forms.RadioButton rdbNone;
		private System.Windows.Forms.RadioButton rdbBusiness;
		private System.Windows.Forms.GroupBox grbCategories;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnForeground;
		private System.Windows.Forms.Label lblFrgColor;
		private System.Windows.Forms.GroupBox grbAppearance;
		private System.Windows.Forms.RadioButton rdbCompetition;
		private System.Windows.Forms.RadioButton rdbGifts;
		private System.Windows.Forms.RadioButton rdbCustomer;
		private System.Windows.Forms.RadioButton rdbHoliday;
		private System.Windows.Forms.RadioButton rdbInternational;
		private System.Windows.Forms.RadioButton rdbIdeas;
		private System.Windows.Forms.RadioButton rdbPersonal;
		private System.Windows.Forms.RadioButton rdbPhone;
		private System.Windows.Forms.RadioButton rdbStrategies;
		private System.Windows.Forms.CheckBox chkUnderline;
		private System.Windows.Forms.CheckBox chkBold;
		private System.Windows.Forms.CheckBox chkStrikeout;
		private System.Windows.Forms.CheckBox chkItalic;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private Janus.Windows.CalendarCombo.CalendarCombo jsccEndTime;
		private Janus.Windows.CalendarCombo.CalendarCombo jsccEndDate;
		private Janus.Windows.CalendarCombo.CalendarCombo jsccStartDate;
		private Janus.Windows.CalendarCombo.CalendarCombo jsccStartTime;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel pnlReminder;
		private System.Windows.Forms.Panel pnlSubject;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.Panel pnlAppointmentTime;
		private System.Windows.Forms.Panel pnlRecurrenceInfo;
		private System.Windows.Forms.Label lblRecurrence;
		private System.Windows.Forms.Label lblRecurrenceInfo;
		private System.ComponentModel.IContainer components;

		public Appoint()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Appoint));
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.lblBorderColor = new System.Windows.Forms.Label();
			this.btnBorderColor = new System.Windows.Forms.Button();
			this.jsccEndTime = new Janus.Windows.CalendarCombo.CalendarCombo();
			this.jsccEndDate = new Janus.Windows.CalendarCombo.CalendarCombo();
			this.jsccStartDate = new Janus.Windows.CalendarCombo.CalendarCombo();
			this.jsccStartTime = new Janus.Windows.CalendarCombo.CalendarCombo();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblBkgColor = new System.Windows.Forms.Label();
			this.cboReminder = new System.Windows.Forms.ComboBox();
			this.btnBkgColor = new System.Windows.Forms.Button();
			this.chkAllDayEvent = new System.Windows.Forms.CheckBox();
			this.chkReminder = new System.Windows.Forms.CheckBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.pnlInfo = new System.Windows.Forms.Panel();
			this.lblInfo = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabDetails = new System.Windows.Forms.TabPage();
			this.pnlReminder = new System.Windows.Forms.Panel();
			this.pnlAppointmentTime = new System.Windows.Forms.Panel();
			this.pnlRecurrenceInfo = new System.Windows.Forms.Panel();
			this.lblRecurrence = new System.Windows.Forms.Label();
			this.lblRecurrenceInfo = new System.Windows.Forms.Label();
			this.pnlSubject = new System.Windows.Forms.Panel();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabCategories = new System.Windows.Forms.TabPage();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.grbAppearance = new System.Windows.Forms.GroupBox();
			this.lblFrgColor = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnForeground = new System.Windows.Forms.Button();
			this.chkUnderline = new System.Windows.Forms.CheckBox();
			this.chkBold = new System.Windows.Forms.CheckBox();
			this.chkStrikeout = new System.Windows.Forms.CheckBox();
			this.chkItalic = new System.Windows.Forms.CheckBox();
			this.grbCategories = new System.Windows.Forms.GroupBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.rdbGifts = new System.Windows.Forms.RadioButton();
			this.rdbCompetition = new System.Windows.Forms.RadioButton();
			this.rdbBusiness = new System.Windows.Forms.RadioButton();
			this.rdbNone = new System.Windows.Forms.RadioButton();
			this.rdbCustomer = new System.Windows.Forms.RadioButton();
			this.rdbHoliday = new System.Windows.Forms.RadioButton();
			this.rdbInternational = new System.Windows.Forms.RadioButton();
			this.rdbIdeas = new System.Windows.Forms.RadioButton();
			this.rdbPersonal = new System.Windows.Forms.RadioButton();
			this.rdbPhone = new System.Windows.Forms.RadioButton();
			this.rdbStrategies = new System.Windows.Forms.RadioButton();
			this.pnlInfo.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabDetails.SuspendLayout();
			this.pnlReminder.SuspendLayout();
			this.pnlAppointmentTime.SuspendLayout();
			this.pnlRecurrenceInfo.SuspendLayout();
			this.pnlSubject.SuspendLayout();
			this.tabCategories.SuspendLayout();
			this.grbAppearance.SuspendLayout();
			this.grbCategories.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton2,
																						this.toolBarButton3});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(488, 28);
			this.toolBar1.TabIndex = 4;
			this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			this.toolBarButton1.Text = "Save and Close";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 1;
			this.toolBarButton2.Text = "Delete";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 2;
			this.toolBarButton3.Text = "Recurrence";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lblBorderColor
			// 
			this.lblBorderColor.BackColor = System.Drawing.Color.Blue;
			this.lblBorderColor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblBorderColor.Location = new System.Drawing.Point(125, 71);
			this.lblBorderColor.Name = "lblBorderColor";
			this.lblBorderColor.Size = new System.Drawing.Size(52, 13);
			this.lblBorderColor.TabIndex = 56;
			this.lblBorderColor.Click += new System.EventHandler(this.EditColor_Click);
			// 
			// btnBorderColor
			// 
			this.btnBorderColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnBorderColor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnBorderColor.Location = new System.Drawing.Point(120, 67);
			this.btnBorderColor.Name = "btnBorderColor";
			this.btnBorderColor.Size = new System.Drawing.Size(88, 21);
			this.btnBorderColor.TabIndex = 53;
			this.btnBorderColor.Text = "... ";
			this.btnBorderColor.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.btnBorderColor.Click += new System.EventHandler(this.EditColor_Click);
			// 
			// jsccEndTime
			// 
			this.jsccEndTime.BindableValue = new System.DateTime(2002, 1, 18, 0, 0, 0, 0);
			this.jsccEndTime.CustomFormat = "h:mm tt";
			this.jsccEndTime.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom;
			// 
			// jsccEndTime.DropDownCalendar
			// 
			this.jsccEndTime.DropDownCalendar.Location = new System.Drawing.Point(0, 0);
			this.jsccEndTime.DropDownCalendar.Name = "";
			this.jsccEndTime.DropDownCalendar.Size = new System.Drawing.Size(164, 167);
			this.jsccEndTime.DropDownCalendar.TabIndex = 0;
			this.jsccEndTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard;
			this.jsccEndTime.Location = new System.Drawing.Point(222, 28);
			this.jsccEndTime.Name = "jsccEndTime";
			this.jsccEndTime.ShowDropDown = false;
			this.jsccEndTime.ShowUpDown = true;
			this.jsccEndTime.Size = new System.Drawing.Size(96, 21);
			this.jsccEndTime.TabIndex = 60;
			this.jsccEndTime.Value = new System.DateTime(2002, 1, 18, 0, 0, 0, 0);
			this.jsccEndTime.ValueChanged += new System.EventHandler(this.jsccEndTime_ValueChanged);
			// 
			// jsccEndDate
			// 
			this.jsccEndDate.BindableValue = new System.DateTime(2002, 1, 18, 0, 0, 0, 0);
			// 
			// jsccEndDate.DropDownCalendar
			// 
			this.jsccEndDate.DropDownCalendar.Location = new System.Drawing.Point(0, 0);
			this.jsccEndDate.DropDownCalendar.Name = "";
			this.jsccEndDate.DropDownCalendar.Size = new System.Drawing.Size(164, 167);
			this.jsccEndDate.DropDownCalendar.TabIndex = 0;
			this.jsccEndDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard;
			this.jsccEndDate.Location = new System.Drawing.Point(92, 28);
			this.jsccEndDate.Name = "jsccEndDate";
			this.jsccEndDate.Size = new System.Drawing.Size(120, 21);
			this.jsccEndDate.TabIndex = 59;
			this.jsccEndDate.Value = new System.DateTime(2002, 1, 18, 0, 0, 0, 0);
			this.jsccEndDate.ValueChanged += new System.EventHandler(this.jsccEndDate_ValueChanged);
			// 
			// jsccStartDate
			// 
			this.jsccStartDate.BindableValue = new System.DateTime(2002, 1, 18, 0, 0, 0, 0);
			// 
			// jsccStartDate.DropDownCalendar
			// 
			this.jsccStartDate.DropDownCalendar.Location = new System.Drawing.Point(0, 0);
			this.jsccStartDate.DropDownCalendar.Name = "";
			this.jsccStartDate.DropDownCalendar.Size = new System.Drawing.Size(164, 167);
			this.jsccStartDate.DropDownCalendar.TabIndex = 0;
			this.jsccStartDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard;
			this.jsccStartDate.Location = new System.Drawing.Point(92, 4);
			this.jsccStartDate.Name = "jsccStartDate";
			this.jsccStartDate.Size = new System.Drawing.Size(120, 21);
			this.jsccStartDate.TabIndex = 58;
			this.jsccStartDate.Value = new System.DateTime(2002, 1, 18, 0, 0, 0, 0);
			this.jsccStartDate.ValueChanged += new System.EventHandler(this.jsccStartDate_ValueChanged);
			// 
			// jsccStartTime
			// 
			this.jsccStartTime.BindableValue = new System.DateTime(2002, 1, 18, 0, 0, 0, 0);
			this.jsccStartTime.CustomFormat = "h:mm tt";
			this.jsccStartTime.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom;
			// 
			// jsccStartTime.DropDownCalendar
			// 
			this.jsccStartTime.DropDownCalendar.Location = new System.Drawing.Point(15, 35);
			this.jsccStartTime.DropDownCalendar.Name = "";
			this.jsccStartTime.DropDownCalendar.Size = new System.Drawing.Size(164, 167);
			this.jsccStartTime.DropDownCalendar.TabIndex = 0;
			this.jsccStartTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard;
			this.jsccStartTime.Location = new System.Drawing.Point(222, 4);
			this.jsccStartTime.Name = "jsccStartTime";
			this.jsccStartTime.ShowDropDown = false;
			this.jsccStartTime.ShowUpDown = true;
			this.jsccStartTime.Size = new System.Drawing.Size(96, 21);
			this.jsccStartTime.TabIndex = 57;
			this.jsccStartTime.Value = new System.DateTime(2002, 1, 18, 0, 0, 0, 0);
			this.jsccStartTime.ValueChanged += new System.EventHandler(this.jsccStartTime_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 17);
			this.label6.TabIndex = 47;
			this.label6.Text = "Border color: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 17);
			this.label5.TabIndex = 46;
			this.label5.Text = "Background color:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 17);
			this.label4.TabIndex = 45;
			this.label4.Text = "End Time:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 17);
			this.label3.TabIndex = 44;
			this.label3.Text = "Start Time:";
			// 
			// lblBkgColor
			// 
			this.lblBkgColor.BackColor = System.Drawing.SystemColors.Window;
			this.lblBkgColor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblBkgColor.Location = new System.Drawing.Point(125, 31);
			this.lblBkgColor.Name = "lblBkgColor";
			this.lblBkgColor.Size = new System.Drawing.Size(52, 13);
			this.lblBkgColor.TabIndex = 51;
			this.lblBkgColor.Click += new System.EventHandler(this.EditColor_Click);
			// 
			// cboReminder
			// 
			this.cboReminder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboReminder.Enabled = false;
			this.cboReminder.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cboReminder.Location = new System.Drawing.Point(92, 4);
			this.cboReminder.Name = "cboReminder";
			this.cboReminder.Size = new System.Drawing.Size(120, 21);
			this.cboReminder.TabIndex = 54;
			this.cboReminder.SelectionChangeCommitted += new System.EventHandler(this.value_Changed);
			// 
			// btnBkgColor
			// 
			this.btnBkgColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnBkgColor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnBkgColor.Location = new System.Drawing.Point(120, 27);
			this.btnBkgColor.Name = "btnBkgColor";
			this.btnBkgColor.Size = new System.Drawing.Size(88, 21);
			this.btnBkgColor.TabIndex = 52;
			this.btnBkgColor.Text = "... ";
			this.btnBkgColor.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.btnBkgColor.Click += new System.EventHandler(this.EditColor_Click);
			// 
			// chkAllDayEvent
			// 
			this.chkAllDayEvent.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkAllDayEvent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkAllDayEvent.Location = new System.Drawing.Point(328, 6);
			this.chkAllDayEvent.Name = "chkAllDayEvent";
			this.chkAllDayEvent.Size = new System.Drawing.Size(88, 16);
			this.chkAllDayEvent.TabIndex = 50;
			this.chkAllDayEvent.Text = "All day event";
			this.chkAllDayEvent.CheckedChanged += new System.EventHandler(this.chkAllDayEvent_CheckedChanged);
			// 
			// chkReminder
			// 
			this.chkReminder.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkReminder.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkReminder.Location = new System.Drawing.Point(12, 8);
			this.chkReminder.Name = "chkReminder";
			this.chkReminder.Size = new System.Drawing.Size(76, 16);
			this.chkReminder.TabIndex = 48;
			this.chkReminder.Text = "Reminder :";
			this.chkReminder.CheckedChanged += new System.EventHandler(this.chkReminder_CheckedChanged);
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtDescription.Location = new System.Drawing.Point(4, 32);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescription.Size = new System.Drawing.Size(472, 154);
			this.txtDescription.TabIndex = 43;
			this.txtDescription.Text = "";
			this.txtDescription.TextChanged += new System.EventHandler(this.value_Changed);
			// 
			// pnlInfo
			// 
			this.pnlInfo.BackColor = System.Drawing.SystemColors.Menu;
			this.pnlInfo.Controls.Add(this.lblInfo);
			this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlInfo.Location = new System.Drawing.Point(0, 0);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(480, 35);
			this.pnlInfo.TabIndex = 43;
			// 
			// lblInfo
			// 
			this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lblInfo.BackColor = System.Drawing.SystemColors.ControlDark;
			this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblInfo.ForeColor = System.Drawing.Color.White;
			this.lblInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblInfo.Location = new System.Drawing.Point(8, 8);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(464, 20);
			this.lblInfo.TabIndex = 1;
			this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabDetails);
			this.tabControl1.Controls.Add(this.tabCategories);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 28);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(488, 364);
			this.tabControl1.TabIndex = 44;
			// 
			// tabDetails
			// 
			this.tabDetails.Controls.Add(this.pnlReminder);
			this.tabDetails.Controls.Add(this.pnlAppointmentTime);
			this.tabDetails.Controls.Add(this.pnlRecurrenceInfo);
			this.tabDetails.Controls.Add(this.pnlSubject);
			this.tabDetails.Controls.Add(this.pnlInfo);
			this.tabDetails.Location = new System.Drawing.Point(4, 22);
			this.tabDetails.Name = "tabDetails";
			this.tabDetails.Size = new System.Drawing.Size(480, 338);
			this.tabDetails.TabIndex = 0;
			this.tabDetails.Text = "Details";
			// 
			// pnlReminder
			// 
			this.pnlReminder.BackColor = System.Drawing.SystemColors.Menu;
			this.pnlReminder.Controls.Add(this.cboReminder);
			this.pnlReminder.Controls.Add(this.txtDescription);
			this.pnlReminder.Controls.Add(this.chkReminder);
			this.pnlReminder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlReminder.Location = new System.Drawing.Point(0, 147);
			this.pnlReminder.Name = "pnlReminder";
			this.pnlReminder.Size = new System.Drawing.Size(480, 191);
			this.pnlReminder.TabIndex = 61;
			// 
			// pnlAppointmentTime
			// 
			this.pnlAppointmentTime.BackColor = System.Drawing.SystemColors.Menu;
			this.pnlAppointmentTime.Controls.Add(this.jsccStartTime);
			this.pnlAppointmentTime.Controls.Add(this.jsccEndTime);
			this.pnlAppointmentTime.Controls.Add(this.jsccEndDate);
			this.pnlAppointmentTime.Controls.Add(this.label3);
			this.pnlAppointmentTime.Controls.Add(this.chkAllDayEvent);
			this.pnlAppointmentTime.Controls.Add(this.jsccStartDate);
			this.pnlAppointmentTime.Controls.Add(this.label4);
			this.pnlAppointmentTime.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlAppointmentTime.Location = new System.Drawing.Point(0, 95);
			this.pnlAppointmentTime.Name = "pnlAppointmentTime";
			this.pnlAppointmentTime.Size = new System.Drawing.Size(480, 52);
			this.pnlAppointmentTime.TabIndex = 62;
			// 
			// pnlRecurrenceInfo
			// 
			this.pnlRecurrenceInfo.BackColor = System.Drawing.SystemColors.Menu;
			this.pnlRecurrenceInfo.Controls.Add(this.lblRecurrence);
			this.pnlRecurrenceInfo.Controls.Add(this.lblRecurrenceInfo);
			this.pnlRecurrenceInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRecurrenceInfo.Location = new System.Drawing.Point(0, 67);
			this.pnlRecurrenceInfo.Name = "pnlRecurrenceInfo";
			this.pnlRecurrenceInfo.Size = new System.Drawing.Size(480, 28);
			this.pnlRecurrenceInfo.TabIndex = 63;
			// 
			// lblRecurrence
			// 
			this.lblRecurrence.AutoSize = true;
			this.lblRecurrence.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblRecurrence.Location = new System.Drawing.Point(12, 8);
			this.lblRecurrence.Name = "lblRecurrence";
			this.lblRecurrence.Size = new System.Drawing.Size(64, 17);
			this.lblRecurrence.TabIndex = 2;
			this.lblRecurrence.Text = "Recurrence:";
			// 
			// lblRecurrenceInfo
			// 
			this.lblRecurrenceInfo.AutoSize = true;
			this.lblRecurrenceInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblRecurrenceInfo.Location = new System.Drawing.Point(76, 8);
			this.lblRecurrenceInfo.Name = "lblRecurrenceInfo";
			this.lblRecurrenceInfo.Size = new System.Drawing.Size(0, 17);
			this.lblRecurrenceInfo.TabIndex = 1;
			// 
			// pnlSubject
			// 
			this.pnlSubject.BackColor = System.Drawing.SystemColors.Menu;
			this.pnlSubject.Controls.Add(this.txtSubject);
			this.pnlSubject.Controls.Add(this.label1);
			this.pnlSubject.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubject.Location = new System.Drawing.Point(0, 35);
			this.pnlSubject.Name = "pnlSubject";
			this.pnlSubject.Size = new System.Drawing.Size(480, 32);
			this.pnlSubject.TabIndex = 61;
			// 
			// txtSubject
			// 
			this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSubject.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtSubject.Location = new System.Drawing.Point(64, 5);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(408, 21);
			this.txtSubject.TabIndex = 42;
			this.txtSubject.Text = "";
			this.txtSubject.TextChanged += new System.EventHandler(this.txtSubject_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Menu;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 17);
			this.label1.TabIndex = 41;
			this.label1.Text = "Subject:";
			// 
			// tabCategories
			// 
			this.tabCategories.BackColor = System.Drawing.SystemColors.Menu;
			this.tabCategories.Controls.Add(this.pictureBox14);
			this.tabCategories.Controls.Add(this.pictureBox13);
			this.tabCategories.Controls.Add(this.grbAppearance);
			this.tabCategories.Controls.Add(this.grbCategories);
			this.tabCategories.Location = new System.Drawing.Point(4, 22);
			this.tabCategories.Name = "tabCategories";
			this.tabCategories.Size = new System.Drawing.Size(480, 341);
			this.tabCategories.TabIndex = 1;
			this.tabCategories.Text = "Categories";
			// 
			// pictureBox14
			// 
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(248, 8);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(32, 32);
			this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox14.TabIndex = 72;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(28, 8);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(32, 32);
			this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox13.TabIndex = 71;
			this.pictureBox13.TabStop = false;
			// 
			// grbAppearance
			// 
			this.grbAppearance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.grbAppearance.Controls.Add(this.lblFrgColor);
			this.grbAppearance.Controls.Add(this.label2);
			this.grbAppearance.Controls.Add(this.btnForeground);
			this.grbAppearance.Controls.Add(this.chkUnderline);
			this.grbAppearance.Controls.Add(this.chkBold);
			this.grbAppearance.Controls.Add(this.chkStrikeout);
			this.grbAppearance.Controls.Add(this.chkItalic);
			this.grbAppearance.Controls.Add(this.lblBkgColor);
			this.grbAppearance.Controls.Add(this.label5);
			this.grbAppearance.Controls.Add(this.btnBkgColor);
			this.grbAppearance.Controls.Add(this.lblBorderColor);
			this.grbAppearance.Controls.Add(this.label6);
			this.grbAppearance.Controls.Add(this.btnBorderColor);
			this.grbAppearance.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grbAppearance.Location = new System.Drawing.Point(240, 16);
			this.grbAppearance.Name = "grbAppearance";
			this.grbAppearance.Size = new System.Drawing.Size(224, 308);
			this.grbAppearance.TabIndex = 59;
			this.grbAppearance.TabStop = false;
			this.grbAppearance.Text = "           Appearance";
			// 
			// lblFrgColor
			// 
			this.lblFrgColor.BackColor = System.Drawing.SystemColors.ControlText;
			this.lblFrgColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblFrgColor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblFrgColor.Location = new System.Drawing.Point(125, 109);
			this.lblFrgColor.Name = "lblFrgColor";
			this.lblFrgColor.Size = new System.Drawing.Size(52, 13);
			this.lblFrgColor.TabIndex = 56;
			this.lblFrgColor.Click += new System.EventHandler(this.EditColor_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(8, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 17);
			this.label2.TabIndex = 61;
			this.label2.Text = "Text Color:";
			// 
			// btnForeground
			// 
			this.btnForeground.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnForeground.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnForeground.Location = new System.Drawing.Point(120, 105);
			this.btnForeground.Name = "btnForeground";
			this.btnForeground.Size = new System.Drawing.Size(88, 21);
			this.btnForeground.TabIndex = 60;
			this.btnForeground.Text = "... ";
			this.btnForeground.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.btnForeground.Click += new System.EventHandler(this.EditColor_Click);
			// 
			// chkUnderline
			// 
			this.chkUnderline.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkUnderline.Location = new System.Drawing.Point(8, 186);
			this.chkUnderline.Name = "chkUnderline";
			this.chkUnderline.Size = new System.Drawing.Size(128, 16);
			this.chkUnderline.TabIndex = 64;
			this.chkUnderline.Text = "Font Underline";
			// 
			// chkBold
			// 
			this.chkBold.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkBold.Location = new System.Drawing.Point(8, 146);
			this.chkBold.Name = "chkBold";
			this.chkBold.Size = new System.Drawing.Size(128, 16);
			this.chkBold.TabIndex = 65;
			this.chkBold.Text = "Font Bold";
			// 
			// chkStrikeout
			// 
			this.chkStrikeout.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkStrikeout.Location = new System.Drawing.Point(8, 226);
			this.chkStrikeout.Name = "chkStrikeout";
			this.chkStrikeout.Size = new System.Drawing.Size(128, 16);
			this.chkStrikeout.TabIndex = 62;
			this.chkStrikeout.Text = "Font Strikeout";
			// 
			// chkItalic
			// 
			this.chkItalic.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkItalic.Location = new System.Drawing.Point(8, 266);
			this.chkItalic.Name = "chkItalic";
			this.chkItalic.Size = new System.Drawing.Size(128, 16);
			this.chkItalic.TabIndex = 63;
			this.chkItalic.Text = "Font Italic";
			// 
			// grbCategories
			// 
			this.grbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.grbCategories.Controls.Add(this.pictureBox12);
			this.grbCategories.Controls.Add(this.pictureBox11);
			this.grbCategories.Controls.Add(this.pictureBox10);
			this.grbCategories.Controls.Add(this.pictureBox9);
			this.grbCategories.Controls.Add(this.pictureBox8);
			this.grbCategories.Controls.Add(this.pictureBox7);
			this.grbCategories.Controls.Add(this.pictureBox6);
			this.grbCategories.Controls.Add(this.pictureBox5);
			this.grbCategories.Controls.Add(this.pictureBox4);
			this.grbCategories.Controls.Add(this.pictureBox3);
			this.grbCategories.Controls.Add(this.rdbGifts);
			this.grbCategories.Controls.Add(this.rdbCompetition);
			this.grbCategories.Controls.Add(this.rdbBusiness);
			this.grbCategories.Controls.Add(this.rdbNone);
			this.grbCategories.Controls.Add(this.rdbCustomer);
			this.grbCategories.Controls.Add(this.rdbHoliday);
			this.grbCategories.Controls.Add(this.rdbInternational);
			this.grbCategories.Controls.Add(this.rdbIdeas);
			this.grbCategories.Controls.Add(this.rdbPersonal);
			this.grbCategories.Controls.Add(this.rdbPhone);
			this.grbCategories.Controls.Add(this.rdbStrategies);
			this.grbCategories.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grbCategories.Location = new System.Drawing.Point(16, 16);
			this.grbCategories.Name = "grbCategories";
			this.grbCategories.Size = new System.Drawing.Size(208, 308);
			this.grbCategories.TabIndex = 58;
			this.grbCategories.TabStop = false;
			this.grbCategories.Text = "             Categories";
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(32, 276);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(16, 16);
			this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox12.TabIndex = 70;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(32, 252);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(16, 16);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox11.TabIndex = 69;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(32, 228);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(16, 16);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox10.TabIndex = 68;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(32, 204);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(16, 16);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox9.TabIndex = 67;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(32, 180);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(16, 16);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox8.TabIndex = 66;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(32, 156);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(16, 16);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox7.TabIndex = 65;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(32, 132);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(16, 16);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox6.TabIndex = 64;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(32, 108);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(16, 16);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox5.TabIndex = 63;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(32, 84);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(16, 16);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox4.TabIndex = 62;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(32, 60);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(16, 16);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 61;
			this.pictureBox3.TabStop = false;
			// 
			// rdbGifts
			// 
			this.rdbGifts.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbGifts.Location = new System.Drawing.Point(16, 108);
			this.rdbGifts.Name = "rdbGifts";
			this.rdbGifts.Size = new System.Drawing.Size(120, 16);
			this.rdbGifts.TabIndex = 57;
			this.rdbGifts.Text = "       Gifts";
			this.rdbGifts.CheckedChanged += new System.EventHandler(this.Categories_Changed);
			// 
			// rdbCompetition
			// 
			this.rdbCompetition.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbCompetition.Location = new System.Drawing.Point(16, 84);
			this.rdbCompetition.Name = "rdbCompetition";
			this.rdbCompetition.Size = new System.Drawing.Size(120, 16);
			this.rdbCompetition.TabIndex = 57;
			this.rdbCompetition.Text = "       Competition";
			this.rdbCompetition.CheckedChanged += new System.EventHandler(this.Categories_Changed);
			// 
			// rdbBusiness
			// 
			this.rdbBusiness.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbBusiness.Location = new System.Drawing.Point(16, 60);
			this.rdbBusiness.Name = "rdbBusiness";
			this.rdbBusiness.Size = new System.Drawing.Size(120, 16);
			this.rdbBusiness.TabIndex = 57;
			this.rdbBusiness.Text = "       Business";
			this.rdbBusiness.CheckedChanged += new System.EventHandler(this.Categories_Changed);
			// 
			// rdbNone
			// 
			this.rdbNone.Checked = true;
			this.rdbNone.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbNone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rdbNone.Location = new System.Drawing.Point(16, 36);
			this.rdbNone.Name = "rdbNone";
			this.rdbNone.Size = new System.Drawing.Size(120, 16);
			this.rdbNone.TabIndex = 57;
			this.rdbNone.TabStop = true;
			this.rdbNone.Text = "None";
			this.rdbNone.CheckedChanged += new System.EventHandler(this.Categories_Changed);
			// 
			// rdbCustomer
			// 
			this.rdbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbCustomer.Location = new System.Drawing.Point(16, 156);
			this.rdbCustomer.Name = "rdbCustomer";
			this.rdbCustomer.Size = new System.Drawing.Size(120, 16);
			this.rdbCustomer.TabIndex = 57;
			this.rdbCustomer.Text = "       Key Customer";
			this.rdbCustomer.CheckedChanged += new System.EventHandler(this.Categories_Changed);
			// 
			// rdbHoliday
			// 
			this.rdbHoliday.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbHoliday.Location = new System.Drawing.Point(16, 132);
			this.rdbHoliday.Name = "rdbHoliday";
			this.rdbHoliday.Size = new System.Drawing.Size(120, 16);
			this.rdbHoliday.TabIndex = 57;
			this.rdbHoliday.Text = "       Holiday";
			this.rdbHoliday.CheckedChanged += new System.EventHandler(this.Categories_Changed);
			// 
			// rdbInternational
			// 
			this.rdbInternational.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbInternational.Location = new System.Drawing.Point(16, 204);
			this.rdbInternational.Name = "rdbInternational";
			this.rdbInternational.Size = new System.Drawing.Size(120, 16);
			this.rdbInternational.TabIndex = 57;
			this.rdbInternational.Text = "       International";
			this.rdbInternational.CheckedChanged += new System.EventHandler(this.Categories_Changed);
			// 
			// rdbIdeas
			// 
			this.rdbIdeas.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbIdeas.Location = new System.Drawing.Point(16, 180);
			this.rdbIdeas.Name = "rdbIdeas";
			this.rdbIdeas.Size = new System.Drawing.Size(120, 16);
			this.rdbIdeas.TabIndex = 57;
			this.rdbIdeas.Text = "       Ideas";
			this.rdbIdeas.CheckedChanged += new System.EventHandler(this.Categories_Changed);
			// 
			// rdbPersonal
			// 
			this.rdbPersonal.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbPersonal.Location = new System.Drawing.Point(16, 228);
			this.rdbPersonal.Name = "rdbPersonal";
			this.rdbPersonal.Size = new System.Drawing.Size(120, 16);
			this.rdbPersonal.TabIndex = 57;
			this.rdbPersonal.Text = "       Personal/Leisure";
			this.rdbPersonal.CheckedChanged += new System.EventHandler(this.Categories_Changed);
			// 
			// rdbPhone
			// 
			this.rdbPhone.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbPhone.Location = new System.Drawing.Point(16, 252);
			this.rdbPhone.Name = "rdbPhone";
			this.rdbPhone.Size = new System.Drawing.Size(120, 16);
			this.rdbPhone.TabIndex = 57;
			this.rdbPhone.Text = "       Phone Calls";
			this.rdbPhone.CheckedChanged += new System.EventHandler(this.Categories_Changed);
			// 
			// rdbStrategies
			// 
			this.rdbStrategies.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbStrategies.Location = new System.Drawing.Point(16, 276);
			this.rdbStrategies.Name = "rdbStrategies";
			this.rdbStrategies.Size = new System.Drawing.Size(120, 16);
			this.rdbStrategies.TabIndex = 57;
			this.rdbStrategies.Text = "       Strategies";
			this.rdbStrategies.CheckedChanged += new System.EventHandler(this.Categories_Changed);
			// 
			// Appoint
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(488, 392);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.toolBar1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.MinimumSize = new System.Drawing.Size(496, 426);
			this.Name = "Appoint";
			this.Text = "Untitled - Appointment";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.AppointmentForm_Closing);
			this.pnlInfo.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabDetails.ResumeLayout(false);
			this.pnlReminder.ResumeLayout(false);
			this.pnlAppointmentTime.ResumeLayout(false);
			this.pnlRecurrenceInfo.ResumeLayout(false);
			this.pnlSubject.ResumeLayout(false);
			this.tabCategories.ResumeLayout(false);
			this.grbAppearance.ResumeLayout(false);
			this.grbCategories.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private bool hasChanged = false;
		private TimeSpan duration;
		private bool fontItalic = false;
		private bool fontUnderline = false;
		private bool fontStrikeout = false;
		private bool fontBold = false;
		private Color bkgColor = SystemColors.Window;
		private Color frgColor = SystemColors.ControlText;
		private Color borderColor = Color.Blue;
		private schedule_manager.Categories categoryTag = Categories.None;
		private int imgIndex = -1;
		private Janus.Windows.Schedule.Schedule schedule1 = null;
		private bool initialized = false;

		public void CreateAppointmentForm(Janus.Windows.Schedule.Schedule schedule, DateTime date, TimeSpan durationTime, Janus.Windows.Schedule.ScheduleAppointment app)
		{
			this.schedule1 = schedule;
			if(app == null)
			{
				app = new ScheduleAppointment(date, date.Add(durationTime));
			}
			this.Appointment = app;
			hasChanged = false;
			this.Show();
		}
		private Janus.Windows.Schedule.ScheduleAppointment appointment = null;
		
		private ScheduleAppointment Appointment
		{
			get
			{
				return appointment;
			}
			set
			{
				if(appointment != value)
				{
					appointment = value;
					if(appointment != null)
					{
						this.duration = appointment.Duration;
						this.txtDescription.Text = appointment.Description;
						this.txtSubject.Text = appointment.Text;
				
						if(appointment.Tag != null && appointment.Tag.GetType() == typeof(Categories) && (Categories)appointment.Tag != Categories.None)
						{
							SetCheckedRadioButton((schedule_manager.Categories)appointment.Tag);
						}
						else
						{
							Color c = appointment.FormatStyle.BackColor;
							if(c == Color.Empty)c = SystemColors.Window;				
							bkgColor = c;
							c = appointment.FormatStyle.ForeColor;
							if(c == Color.Empty)c = SystemColors.ControlText;
							frgColor = c;
							borderColor = appointment.BorderColor;					
							fontBold = TransformTriStateValues(appointment.FormatStyle.FontBold);
							fontUnderline = TransformTriStateValues(appointment.FormatStyle.FontUnderline);
							fontStrikeout = TransformTriStateValues(appointment.FormatStyle.FontStrikeout);
							fontItalic = TransformTriStateValues(appointment.FormatStyle.FontItalic);						
							this.SetCategoryValues(Categories.None);
						}
						this.chkReminder.Checked = appointment.Reminder.Enabled;
						this.chkAllDayEvent.Checked = appointment.AllDayEvent;
						
						this.SetTimePanel();

						this.PopulateReminderCombo();
						initialized = false;
						DateTime date = appointment.StartTime;
						this.jsccStartDate.Value = date.Date;
						this.jsccEndDate.Value = date.Add(duration).Date;
						this.jsccStartTime.Value = date;
						this.jsccEndTime.Value = date.Add(duration);
						this.SetWarningText();
						initialized = true;
					}
				}
			}
		}
		private bool TransformTriStateValues(TriState triState)
		{
			if(triState == TriState.True)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private Janus.Windows.Schedule.TriState TransformTriStateValues(bool editValue)
		{
			if(editValue)
			{
				return TriState.True;
			}
			else
			{
				return TriState.False;
			}
		}
		private void PopulateReminderCombo()
		{
			cboReminder.Items.Clear();
			cboReminder.DisplayMember = "Text";
			ComboItem item = new ComboItem("0 minutes", new TimeSpan(0,0,0));
			
			cboReminder.Items.Add(item);
			item = new ComboItem("5 minutes", new TimeSpan(0,5,0));
			cboReminder.Items.Add(item);
			item = new ComboItem("10 minutes", new TimeSpan(0,10,0));
			cboReminder.Items.Add(item);
			item = new ComboItem("15 minutes", new TimeSpan(0,15,0));
			cboReminder.Items.Add(item);
			item = new ComboItem("30 minutes", new TimeSpan(0, 30, 0));
			cboReminder.Items.Add(item);
			item = new ComboItem("1 hour", new TimeSpan(1,0,0));
			cboReminder.Items.Add(item);
			item = new ComboItem("2 hours", new TimeSpan(2,0,0));
			cboReminder.Items.Add(item);
			item = new ComboItem("4 hours", new TimeSpan(4,0,0));
			cboReminder.Items.Add(item);

			if(Appointment != null)
			{
				foreach(ComboItem reminder in cboReminder.Items)
				{
					if((TimeSpan)reminder.Value == Appointment.Reminder.ReminderInterval)
					{
						cboReminder.SelectedItem = reminder;
						return;
					}
				}
			}
			cboReminder.SelectedIndex =3;
		}

		private void SetWarningText()
		{
			string str = string.Empty;
			this.pnlInfo.Height = 35;
			if(this.Appointment.RecurrenceState == RecurrenceState.Master)
			{
				pnlInfo.Visible = false;
				return;
			}
			else if(this.Appointment.RecurrenceState != RecurrenceState.NotRecurring)
			{
				str = "  " + this.GetRecurrenceInfoText() + "\n";
			}
			Janus.Windows.Schedule.DateRange range = new Janus.Windows.Schedule.DateRange(this.GetCompleteStartDate(), this.GetCompleteEndDate());
			if(range.Start < DateTime.Now)
			{
				if(str.Length > 0)
				{
					this.pnlInfo.Height += this.lblInfo.Height - 4;
				}
				str += "  This appointment occurs in the past";				
			}
			else
			{
				ScheduleAppointment[] list =schedule1.GetAppointmentsFromRange(range);
				if(list.Length > 1 || (list.Length == 1 && this.Appointment.Schedule == null))
				{
					if(str.Length > 0)
					{
						this.pnlInfo.Height += this.lblInfo.Height - 4;
					}
					str += "  Conflicts with another appointment in your Calendar";
				}
			}
			if(str == string.Empty)
			{
				pnlInfo.Visible = false;
			}
			else
			{
				pnlInfo.Visible = true;
				lblInfo.Text = str;
			}
		}

		private string GetDayOfWeekText(ScheduleDayOfWeek daysOfWeek)
		{
			string daysOfWeekText = "";
			if((daysOfWeek & ScheduleDayOfWeek.Monday) != 0)
			{
				daysOfWeekText += "Monday, ";			
			}
			if((daysOfWeek & ScheduleDayOfWeek.Tuesday) != 0)
			{
				daysOfWeekText += "Tuesday, ";			
			}
			if((daysOfWeek & ScheduleDayOfWeek.Wednesday) != 0)
			{
				daysOfWeekText += "Wednesday, ";			
			}
			if((daysOfWeek & ScheduleDayOfWeek.Thursday) != 0)
			{
				daysOfWeekText += "Thursday, ";			
			}
			if((daysOfWeek & ScheduleDayOfWeek.Friday) != 0)
			{
				daysOfWeekText += "Friday, ";			
			}
			if((daysOfWeek & ScheduleDayOfWeek.Saturday) != 0)
			{
				daysOfWeekText += "Saturday, ";			
			}
			if((daysOfWeek & ScheduleDayOfWeek.Sunday) != 0)
			{
				daysOfWeekText += "Sunday, ";
			}
			daysOfWeekText = daysOfWeekText.Remove(daysOfWeekText.Length - 2, 2);
			return daysOfWeekText;
		}


		private string GetRecurrenceInfoText()
		{
			string recurrenceText = "Occurs every ";
			RecurrencePattern pattern = this.Appointment.RecurrencePattern;
			switch(pattern.RecurrenceType)
			{
				case RecurrenceType.Daily:
				switch (pattern.DailyRecurrenceMode)
				{
					case DailyRecurrenceMode.UseInterval:
						if(pattern.Interval == 1)
						{
							recurrenceText += "day";
						}
						else
						{
							recurrenceText += pattern.Interval + " days";
						}
						break;
					case DailyRecurrenceMode.WeekDays:
						recurrenceText += "weekday";
						break;
					case DailyRecurrenceMode.WeekendDays:
						recurrenceText += "weekend day";
						break;
				}
					break;
				case RecurrenceType.Weekly:
					if(pattern.Interval > 1)
					{
						recurrenceText += pattern.Interval + " weeks on ";						
					}
					recurrenceText += this.GetDayOfWeekText(pattern.DayOfWeek);
					break;
				case RecurrenceType.Monthly:
					if(pattern.Interval > 1)
					{
						recurrenceText += "day " + pattern.DayOfMonth + " of every month";
					}
					else
					{
						recurrenceText += "day " + pattern.DayOfMonth + " of every " + pattern.Interval + " months";
					}
					break;
				case RecurrenceType.MontNth:
					recurrenceText += pattern.OccurrenceInMonth + " " + this.GetDayOfWeekText(pattern.DayOfWeek);
					if(pattern.Interval > 1)
					{
						recurrenceText += " of every month";
					}
					else
					{
						recurrenceText += " of every " + pattern.Interval + " months";
					}
					break;
				case RecurrenceType.Yearly:
					recurrenceText += System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(pattern.MonthOfYear) + " " + pattern.DayOfMonth;
					break;
				case RecurrenceType.YearNth:
					recurrenceText += pattern.OccurrenceInMonth + " " + this.GetDayOfWeekText(pattern.DayOfWeek);
					recurrenceText += " of " + System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(pattern.MonthOfYear);
					break;

			}
			recurrenceText += " effective " + this.Appointment.RecurrencePattern.PatternStartDate.ToShortDateString();
			DateTime startTime = DateTime.Today.Add(this.Appointment.RecurrencePattern.StartTime);
			DateTime endTime = DateTime.Today.Add(this.Appointment.RecurrencePattern.EndTime);
			recurrenceText += " from "  + startTime.ToShortTimeString() + " to " + endTime.ToShortTimeString();
			return recurrenceText;
		}

		private void SetTimePanel()
		{
			if(this.Appointment.RecurrenceState == RecurrenceState.Master)
			{
				this.pnlAppointmentTime.Visible = false;
				this.pnlRecurrenceInfo.Visible = true;
				this.lblRecurrenceInfo.Text = this.GetRecurrenceInfoText();
			}
			else
			{
				this.pnlAppointmentTime.Visible = true;
				this.pnlRecurrenceInfo.Visible = false;
			}
		}

		private void SetFormText()
		{
			if(txtSubject.Text.Length > 0)
			{
				this.Text = txtSubject.Text + " - ";
			}
			else
			{
				this.Text = "Untitled - ";
			}
			if(this.chkAllDayEvent.Checked)
			{
				this.Text += "Event";
			}
			else
			{
				this.Text += "Appointment";
			}
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if(e.Button.Text == "Delete")
			{
				this.DeleteAppointment();
			}
			else if(e.Button.Text == "Recurrence")
			{
				RecurrenceForm frm = new RecurrenceForm();
				frm.ShowRecurrenceForm(this.Appointment);
				if(frm.DialogResult == DialogResult.OK)
				{
					if(this.Appointment.MasterAppointment != null)
					{
						this.Appointment = this.Appointment.MasterAppointment;
					}
					else
					{
						this.SetTimePanel();
						this.SetWarningText();
					}
				}
			}
			else
			{
				this.SaveAppointment(true);
		       	}
		}

		private void DeleteAppointment()
		{
			if(hasChanged)
			{
				DialogResult dialog = MessageBox.Show(this, "The appointment has been changed. Are you sure you want to delete it?", "",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if(dialog == DialogResult.No)
				{
					return;
				}
			}
			if(Appointment != null)
			{
				Appointment.Delete();
			}

			this.Close();
		}
		private void SaveAppointment(bool close)
		{
			hasChanged = false;
			Appointment.Move(this.GetCompleteStartDate(), this.GetCompleteEndDate());
			Appointment.Text = this.txtSubject.Text;
			
			Appointment.Description = this.txtDescription.Text;
			Appointment.FormatStyle.BackColor = this.lblBkgColor.BackColor;
			Appointment.BorderColor = this.lblBorderColor.BackColor;
			Appointment.FormatStyle.ForeColor = lblFrgColor.BackColor;
			Appointment.FormatStyle.FontBold = TransformTriStateValues(chkBold.Checked);
			Appointment.FormatStyle.FontItalic = TransformTriStateValues(chkItalic.Checked);
			Appointment.FormatStyle.FontStrikeout = TransformTriStateValues(chkStrikeout.Checked);
			Appointment.FormatStyle.FontUnderline = TransformTriStateValues(chkUnderline.Checked);			
			Appointment.ImageIndex2 = imgIndex;			
			Appointment.Reminder.ReminderInterval = (TimeSpan)((ComboItem)cboReminder.SelectedItem).Value;
			Appointment.Tag = categoryTag;
			Appointment.AllDayEvent = this.chkAllDayEvent.Checked;
			Appointment.Reminder.Enabled = this.chkReminder.Checked;
			
			if(Appointment.Schedule == null)
			{
				this.schedule1.Appointments.Add(Appointment);
			}
			
			
			
			DataRowView dt_v = (DataRowView)Appointment.DataRow;	
			
			dt_v.Row[6]= imgIndex;

			if(close)
			{
				this.Close();
			}
		}
		private void AppointmentForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
			if(hasChanged)
			{
				DialogResult result =MessageBox.Show(this, "Do you want to save changes", "Schedule Sample", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
				switch(result)
				{
					case DialogResult.Yes:
						this.SaveAppointment(false);
						break;
					case DialogResult.Cancel:
						e.Cancel = true;
						break;
					default:
						break;
				}
			}
		}
		private void jsccStartTime_ValueChanged(object sender, System.EventArgs e)
		{
			if(!initialized)
			{
				return;
			}
			DateTime startDate = this.GetCompleteStartDate();
			jsccEndTime.Value = startDate.Add(duration);
			this.SetWarningText();
			hasChanged = true;
		}

		private void jsccStartDate_ValueChanged(object sender, System.EventArgs e)
		{
			if(!initialized)
			{
				return;
			}

			jsccEndDate.Value = this.GetCompleteStartDate().Add(duration);
			hasChanged = true;
		}

		private void jsccEndDate_ValueChanged(object sender, System.EventArgs e)
		{
			if(!initialized)
			{
				return;
			}
			DateTime startDate = this.GetCompleteStartDate();
			DateTime endDate = this.GetCompleteEndDate();
			if(endDate < startDate)
			{
				jsccEndTime.Value = startDate.Add(duration);
				jsccEndDate.Value = startDate.Add(duration);
			}
			else
			{
				duration = endDate.Subtract(startDate);
			}
			this.SetWarningText();
			hasChanged = true;
		}

		private void jsccEndTime_ValueChanged(object sender, System.EventArgs e)
		{
			if(!initialized)
			{
				return;
			}

			if(jsccEndTime.Value < jsccStartTime.Value)
			{
				jsccEndTime.Value = jsccStartTime.Value.Add(duration);
			}
			else
			{
				duration = jsccEndTime.Value.Subtract(jsccStartTime.Value);
			}
			this.SetWarningText();
			hasChanged = true;
		}

		private DateTime GetCompleteStartDate()
		{
			DateTime startDate = this.jsccStartDate.Value.Date;
			if(!chkAllDayEvent.Checked)
			{
				startDate = startDate.Add(this.jsccStartTime.Value.TimeOfDay);
			}
			return startDate;
		}
		private DateTime GetCompleteEndDate()
		{
			DateTime endDate = this.jsccEndDate.Value.Date;
			if(!this.chkAllDayEvent.Checked)
			{
				endDate = endDate.Add(this.jsccEndTime.Value.TimeOfDay);
			}
			return endDate;
		}
		private void value_Changed(object sender, System.EventArgs e)
		{
			hasChanged = true;
		}
		private void EditColor_Click(object sender, System.EventArgs e)
		{
			if(colorDialog1.ShowDialog() == DialogResult.OK)
			{
				if(sender == btnBkgColor || sender == lblBkgColor)
				{
					lblBkgColor.BackColor = colorDialog1.Color;
					bkgColor = colorDialog1.Color;
				}
				else if(sender == btnBorderColor || sender == lblBorderColor)
				{
					lblBorderColor.BackColor = colorDialog1.Color;
					borderColor = colorDialog1.Color;
				}
				else
				{
					lblFrgColor.BackColor = colorDialog1.Color;
					frgColor =colorDialog1.Color;
				}
			}
		}

		private void chkAllDayEvent_CheckedChanged(object sender, System.EventArgs e)
		{
			this.jsccEndTime.Enabled = !chkAllDayEvent.Checked;
			this.jsccStartTime.Enabled = !chkAllDayEvent.Checked;
			if(Appointment != null && duration.TotalDays >= 1)
			{
				duration = new TimeSpan((int)duration.TotalDays - 1,0, schedule1.MinuteInterval,0);
				this.jsccStartTime.Value = this.jsccStartDate.Value.Add(schedule1.WorkStartTime);
				this.jsccEndDate.Value = jsccStartTime.Value.Add(duration).Date;
			}
			this.SetFormText();
			hasChanged = true;
		}
		
		private void chkReminder_CheckedChanged(object sender, System.EventArgs e)
		{
			this.cboReminder.Enabled = chkReminder.Checked;
			hasChanged = true;
		}
		
		private void txtSubject_TextChanged(object sender, System.EventArgs e)
		{
			this.SetFormText();
			hasChanged = true;
		}

		private void Categories_Changed(object sender, System.EventArgs e)
		{
			RadioButton rdbButton = (RadioButton)sender;
			if(!rdbButton.Checked)
			{
				return;
			}
			switch(rdbButton.Name)
			{
				case "rdbNone":
					SetCategoryValues(Categories.None);
					break;
				case "rdbBusiness":
					SetCategoryValues(Categories.Business);
					break;
				case "rdbCompetition":
					SetCategoryValues(Categories.Competition);
					break;
				case "rdbGifts":
					SetCategoryValues(Categories.Gifts);
					break;
				case "rdbHoliday":
					SetCategoryValues(Categories.Holiday);
					break;
				case "rdbCustomer":
					SetCategoryValues(Categories.KeyCustomer);
					break;
				case "rdbIdeas":
					SetCategoryValues(Categories.Ideas);
					break;
				case "rdbInternational":
					SetCategoryValues(Categories.International);
					break;
				case "rdbPersonal":
					SetCategoryValues(Categories.Personal);
					break;
				case "rdbPhone":
					SetCategoryValues(Categories.PhoneCalls);
					break;
				case "rdbStrategies":
					SetCategoryValues(Categories.Strategies);
					break;
			}
			hasChanged = true;
			if(rdbNone.Checked)
			{
				grbAppearance.Enabled = true;
			}
			else
			{
				grbAppearance.Enabled = false;
			}
		}
		private void SetCheckedRadioButton(schedule_manager.Categories category)
		{
			switch(category)
			{
				case schedule_manager.Categories.None:
					rdbNone.Checked = true;
					break;
				case schedule_manager.Categories.Business:
					rdbBusiness.Checked = true;
					break;
				case schedule_manager.Categories.Competition:
					rdbCompetition.Checked = true;
					break;
				case schedule_manager.Categories.Gifts:
					rdbGifts.Checked = true;
					break;
				case schedule_manager.Categories.Holiday:
					rdbHoliday.Checked = true;
					break;
				case schedule_manager.Categories.KeyCustomer:
					rdbCustomer.Checked = true;
					break;
				case schedule_manager.Categories.Ideas:
					rdbIdeas.Checked = true;
					break;
				case schedule_manager.Categories.International:
					rdbInternational.Checked = true;
					break;
				case schedule_manager.Categories.Personal:
					rdbPersonal.Checked = true;
					break;
				case schedule_manager.Categories.PhoneCalls:
					rdbPhone.Checked = true;
					break;
				case schedule_manager.Categories.Strategies:
					rdbStrategies.Checked = true;
					break;
			}
		}
		private void SetCategoryValues(schedule_manager.Categories category)
		{
			switch(category)
			{
				case schedule_manager.Categories.None:
					lblBkgColor.BackColor = bkgColor;
					lblFrgColor.BackColor = frgColor;
					lblBorderColor.BackColor = borderColor;
					chkItalic.Checked = fontItalic;
					chkBold.Checked = fontBold;
					chkStrikeout.Checked = fontStrikeout;
					chkUnderline.Checked = fontUnderline;
					imgIndex = -1;
					categoryTag = Categories.None;
					break;
				case schedule_manager.Categories.Business:
					lblBkgColor.BackColor = Color.FromArgb(236, 237, 238);
					lblFrgColor.BackColor = Color.FromArgb(98, 107, 124);
					lblBorderColor.BackColor = Color.FromArgb(109, 116, 128);
					chkItalic.Checked = false;
					chkBold.Checked = true;
					chkStrikeout.Checked = false;
					chkUnderline.Checked = false;
					imgIndex = 0;
					categoryTag = Categories.Business;
					break;
				case schedule_manager.Categories.Competition:
					lblBkgColor.BackColor = Color.FromArgb(246, 236, 214);
					lblFrgColor.BackColor = Color.FromArgb(217, 175, 70);
					lblBorderColor.BackColor = Color.FromArgb(236, 213, 157);
					chkItalic.Checked = false;
					chkBold.Checked = false;
					chkStrikeout.Checked = false;
					chkUnderline.Checked = false;
					imgIndex = 1;
					categoryTag = Categories.Competition;
					break;
				case schedule_manager.Categories.Gifts:
					lblBkgColor.BackColor = Color.FromArgb(198, 213, 221);
					lblFrgColor.BackColor = Color.FromArgb(98, 99, 111);
					lblBorderColor.BackColor = Color.FromArgb(101, 137, 162);
					chkItalic.Checked = false;
					chkBold.Checked = false;
					chkStrikeout.Checked = false;
					chkUnderline.Checked = false;
					imgIndex = 2;
					categoryTag = Categories.Gifts;	
					break;
				case schedule_manager.Categories.Holiday:
					lblBkgColor.BackColor = Color.FromArgb(219, 225, 215);
					lblFrgColor.BackColor = Color.FromArgb(110, 120, 99);
					lblBorderColor.BackColor = Color.FromArgb(98, 128, 117);
					chkItalic.Checked = false;
					chkBold.Checked = false;
					chkStrikeout.Checked = false;
					chkUnderline.Checked = false;
					imgIndex = 3;
					categoryTag = Categories.Holiday;
					break;
				case schedule_manager.Categories.KeyCustomer:
					lblBkgColor.BackColor = Color.FromArgb(253, 248, 229);
					lblFrgColor.BackColor = Color.FromArgb(90, 111, 144);
					lblBorderColor.BackColor = Color.FromArgb(112, 149, 169);
					chkItalic.Checked = false;
					chkBold.Checked = true;
					chkStrikeout.Checked = false;
					chkUnderline.Checked = true;
					imgIndex = 4;
					categoryTag = Categories.KeyCustomer;
					break;
				case schedule_manager.Categories.Ideas:
					lblBkgColor.BackColor = Color.FromArgb(236, 233, 216);
					lblFrgColor.BackColor = Color.FromArgb(128, 111, 106);
					lblBorderColor.BackColor = Color.FromArgb(175, 172, 158);
					chkItalic.Checked = true;
					chkBold.Checked = false;
					chkStrikeout.Checked = false;
					chkUnderline.Checked = false;
					imgIndex = 5;
					categoryTag = Categories.Ideas;
					break;
				case schedule_manager.Categories.International:
					lblBkgColor.BackColor = Color.FromArgb(205, 220, 218);
					lblFrgColor.BackColor = Color.FromArgb(98, 99, 111);
					lblBorderColor.BackColor = Color.FromArgb(112, 167, 160);
					chkItalic.Checked = false;
					chkBold.Checked = false;
					chkStrikeout.Checked = false;
					chkUnderline.Checked = false;
					imgIndex = 6;
					categoryTag = Categories.International;
					break;
				case schedule_manager.Categories.Personal:
					lblBkgColor.BackColor = Color.FromArgb(232, 232, 232);
					lblFrgColor.BackColor = Color.FromArgb(98, 99, 111);
					lblBorderColor.BackColor = Color.FromArgb(98, 99, 111);
					chkItalic.Checked = false;
					chkBold.Checked = false;
					chkStrikeout.Checked = false;
					chkUnderline.Checked = false;
					imgIndex = 7;
					categoryTag = Categories.Personal;
					break;
				case schedule_manager.Categories.PhoneCalls:
					lblBkgColor.BackColor = Color.FromArgb(216, 208, 200);
					lblFrgColor.BackColor = Color.FromArgb(144, 124, 103);
					lblBorderColor.BackColor = Color.FromArgb(168, 152, 144);
					chkItalic.Checked = false;
					chkBold.Checked = false;
					chkStrikeout.Checked = false;
					chkUnderline.Checked = false;
					imgIndex = 8;
					categoryTag = Categories.PhoneCalls;
					break;
				case schedule_manager.Categories.Strategies:
					lblBkgColor.BackColor = Color.FromArgb(230, 216, 174);
					lblFrgColor.BackColor = Color.FromArgb(136, 21, 0);
					lblBorderColor.BackColor = Color.FromArgb(192, 155, 74);
					chkItalic.Checked = false;
					chkBold.Checked = false;
					chkStrikeout.Checked = false;
					chkUnderline.Checked = false;
					imgIndex = 9;
					categoryTag = Categories.Strategies;
					break;
			}
		}
	}
}