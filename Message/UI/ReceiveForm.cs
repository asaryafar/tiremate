using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Message.UI
{
	/// <summary>
	/// Summary description for ReceiveForm.
	/// </summary>
	public class ReceiveForm : CommonClass.FrmBase
	{
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.ColumnHeader colFrom;
		private AxSHDocVw.AxWebBrowser webMail;
		private System.Windows.Forms.ListView lstMail;
		private System.Windows.Forms.ColumnHeader colSubject;
		private System.Windows.Forms.ColumnHeader colDate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ProgressBar pgBar;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox textPassword;
		private System.Windows.Forms.TextBox textUser;
		private System.Windows.Forms.TextBox textServer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ReceiveForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ReceiveForm));
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnDel = new System.Windows.Forms.Button();
			this.colFrom = new System.Windows.Forms.ColumnHeader();
			this.webMail = new AxSHDocVw.AxWebBrowser();
			this.lstMail = new System.Windows.Forms.ListView();
			this.colSubject = new System.Windows.Forms.ColumnHeader();
			this.colDate = new System.Windows.Forms.ColumnHeader();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pgBar = new System.Windows.Forms.ProgressBar();
			this.lblStatus = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.textPassword = new System.Windows.Forms.TextBox();
			this.textUser = new System.Windows.Forms.TextBox();
			this.textServer = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.webMail)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(272, 224);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(0, 17);
			this.lblTotal.TabIndex = 9;
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(288, 232);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(72, 26);
			this.btnDel.TabIndex = 8;
			this.btnDel.Text = "Delete";
			// 
			// colFrom
			// 
			this.colFrom.Text = "From";
			this.colFrom.Width = 100;
			// 
			// webMail
			// 
			this.webMail.Enabled = true;
			this.webMail.Location = new System.Drawing.Point(272, 264);
			this.webMail.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("webMail.OcxState")));
			this.webMail.Size = new System.Drawing.Size(488, 232);
			this.webMail.TabIndex = 7;
			this.webMail.Enter += new System.EventHandler(this.webMail_Enter);
			// 
			// lstMail
			// 
			this.lstMail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this.colFrom,
																					  this.colSubject,
																					  this.colDate});
			this.lstMail.FullRowSelect = true;
			this.lstMail.HideSelection = false;
			this.lstMail.Location = new System.Drawing.Point(264, 32);
			this.lstMail.Name = "lstMail";
			this.lstMail.Size = new System.Drawing.Size(488, 181);
			this.lstMail.TabIndex = 6;
			this.lstMail.View = System.Windows.Forms.View.Details;
			// 
			// colSubject
			// 
			this.colSubject.Text = "Subject";
			this.colSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.colSubject.Width = 200;
			// 
			// colDate
			// 
			this.colDate.Text = "Date";
			this.colDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.colDate.Width = 150;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pgBar);
			this.groupBox1.Controls.Add(this.lblStatus);
			this.groupBox1.Controls.Add(this.btnCancel);
			this.groupBox1.Controls.Add(this.btnStart);
			this.groupBox1.Controls.Add(this.textPassword);
			this.groupBox1.Controls.Add(this.textUser);
			this.groupBox1.Controls.Add(this.textServer);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(24, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(232, 353);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Account Information";
			// 
			// pgBar
			// 
			this.pgBar.Location = new System.Drawing.Point(8, 336);
			this.pgBar.Name = "pgBar";
			this.pgBar.Size = new System.Drawing.Size(216, 9);
			this.pgBar.TabIndex = 15;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(8, 293);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(0, 17);
			this.lblStatus.TabIndex = 14;
			// 
			// btnCancel
			// 
			this.btnCancel.Enabled = false;
			this.btnCancel.Location = new System.Drawing.Point(128, 258);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(88, 26);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "Cancel";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(32, 258);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(88, 26);
			this.btnStart.TabIndex = 12;
			this.btnStart.Text = "Start";
			// 
			// textPassword
			// 
			this.textPassword.Location = new System.Drawing.Point(80, 93);
			this.textPassword.Name = "textPassword";
			this.textPassword.PasswordChar = '*';
			this.textPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textPassword.Size = new System.Drawing.Size(136, 21);
			this.textPassword.TabIndex = 5;
			this.textPassword.Text = "";
			// 
			// textUser
			// 
			this.textUser.Location = new System.Drawing.Point(80, 58);
			this.textUser.Name = "textUser";
			this.textUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textUser.Size = new System.Drawing.Size(136, 21);
			this.textUser.TabIndex = 4;
			this.textUser.Text = "admin@testmail.com";
			// 
			// textServer
			// 
			this.textServer.Location = new System.Drawing.Point(80, 24);
			this.textServer.Name = "textServer";
			this.textServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textServer.Size = new System.Drawing.Size(136, 21);
			this.textServer.TabIndex = 3;
			this.textServer.Text = "localhost";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "User";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server";
			// 
			// ReceiveForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(838, 547);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.webMail);
			this.Controls.Add(this.lstMail);
			this.Controls.Add(this.groupBox1);
			this.Name = "ReceiveForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "ReceiveForm";
			((System.ComponentModel.ISupportInitialize)(this.webMail)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void webMail_Enter(object sender, System.EventArgs e)
		{
		
		}
	}
}
