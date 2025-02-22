using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace schedule_manager
{
	/// <summary>
	/// Summary description for ConfirmDeleteForm.
	/// </summary>
	public class RecurrenceOptionDialog : CommonClass.FrmBase
	{
		private System.Windows.Forms.Button btnCance;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.RadioButton rdbOccurrence;
		private System.Windows.Forms.RadioButton rdbSeries;
		private System.Windows.Forms.PictureBox pictureBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RecurrenceOptionDialog()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(RecurrenceOptionDialog));
			this.btnCance = new System.Windows.Forms.Button();
			this.OK = new System.Windows.Forms.Button();
			this.lblInfo = new System.Windows.Forms.Label();
			this.rdbOccurrence = new System.Windows.Forms.RadioButton();
			this.rdbSeries = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// btnCance
			// 
			this.btnCance.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCance.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCance.Location = new System.Drawing.Point(139, 120);
			this.btnCance.Name = "btnCance";
			this.btnCance.Size = new System.Drawing.Size(88, 24);
			this.btnCance.TabIndex = 2;
			this.btnCance.Text = "Cancel";
			// 
			// OK
			// 
			this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.OK.Location = new System.Drawing.Point(40, 120);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(88, 24);
			this.OK.TabIndex = 0;
			this.OK.Text = "OK";
			// 
			// lblInfo
			// 
			this.lblInfo.Location = new System.Drawing.Point(56, 8);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(204, 52);
			this.lblInfo.TabIndex = 3;
			// 
			// rdbOccurrence
			// 
			this.rdbOccurrence.Checked = true;
			this.rdbOccurrence.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbOccurrence.Location = new System.Drawing.Point(56, 68);
			this.rdbOccurrence.Name = "rdbOccurrence";
			this.rdbOccurrence.Size = new System.Drawing.Size(204, 16);
			this.rdbOccurrence.TabIndex = 4;
			this.rdbOccurrence.TabStop = true;
			// 
			// rdbSeries
			// 
			this.rdbSeries.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdbSeries.Location = new System.Drawing.Point(56, 92);
			this.rdbSeries.Name = "rdbSeries";
			this.rdbSeries.Size = new System.Drawing.Size(204, 16);
			this.rdbSeries.TabIndex = 4;
			this.rdbSeries.CheckedChanged += new System.EventHandler(this.rdbSeries_CheckedChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// RecurrenceOptionDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(266, 152);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pictureBox1,
																		  this.rdbOccurrence,
																		  this.lblInfo,
																		  this.btnCance,
																		  this.OK,
																		  this.rdbSeries});
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RecurrenceOptionDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Confirm Delete";
			this.ResumeLayout(false);

		}
		#endregion

		private bool applyToTheSeries = false;

		private void rdbSeries_CheckedChanged(object sender, System.EventArgs e)
		{
			this.ApplyToTheSeries = rdbSeries.Checked;
		}

		public void ShowRecurrenceOptionDialog(string appText, bool deleteForm)
		{
			if(deleteForm)
			{
				this.lblInfo.Text = "Do you want to delete all occurrences of the recurring appointment \"" + appText + "\", or just this one?"; 
				this.rdbOccurrence.Text = "Delete this occurrence";
				this.rdbSeries.Text = "Delete the series";
			}
			else
			{
				this.lblInfo.Text =  "\"" + appText + "\" is a recurring appointment. Do you want to open only this occurrence or the series?";
				this.rdbOccurrence.Text = "Open this occurrence";
				this.rdbSeries.Text = "Open the series";
				this.Text = "Open Recurring Item";
			}
			this.ShowDialog();
		}
	
		public bool ApplyToTheSeries
		{
			get
			{
				return applyToTheSeries;
			}
			set
			{
				applyToTheSeries = value;
			}
		}
	}
}
