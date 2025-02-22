using System;
using System.Windows.Forms;
using Janus.Windows.EditControls;

namespace Common
{
	/// <summary>
	/// Summary description for MessageBox.
	/// </summary>
	public class MessageBox : CommonClass.FrmBase
	{
		private Janus.Windows.EditControls.UIButton button3;
		private Janus.Windows.EditControls.UIButton button2;
		private Janus.Windows.EditControls.UIButton button1;
		private System.Windows.Forms.Label messageLabel;
		private string text;
		private string caption;
		private MessageBoxButtons buttons;
		private MessageBoxIcon icon;
		private MessageBoxDefaultButton defultButton;
		private MessageBoxOptions options;

		private string OK;
		private string ABORT;
		private string CANCEL;
		private string RETRY;
		private string IGNORE;
		private string YES;
		private System.Windows.Forms.PictureBox pic;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ImageList systemIcons;
		private string NO;
	
		public MessageBox()
		{
			InitializeComponent ();

			OK = ResourceAccess.RA.RM.GetString ("0001");
			ABORT= ResourceAccess.RA.RM.GetString ("0002");
			CANCEL = ResourceAccess.RA.RM.GetString ("0003");
			RETRY = ResourceAccess.RA.RM.GetString ("0004");
			IGNORE = ResourceAccess.RA.RM.GetString ("0005");
			YES = ResourceAccess.RA.RM.GetString ("0006");
			NO = ResourceAccess.RA.RM.GetString ("0007");

			systemIcons.Images.Add (System.Drawing.SystemIcons.Asterisk);
			systemIcons.Images.Add (System.Drawing.SystemIcons.Error);
			systemIcons.Images.Add (System.Drawing.SystemIcons.Exclamation);
			systemIcons.Images.Add (System.Drawing.SystemIcons.Hand);
			systemIcons.Images.Add (System.Drawing.SystemIcons.Information);
			systemIcons.Images.Add (System.Drawing.SystemIcons.Question);
			systemIcons.Images.Add (System.Drawing.SystemIcons.Warning);
			systemIcons.Images.Add (System.Drawing.SystemIcons.Error);

			systemIcons.ImageSize = new System.Drawing.Size (System.Drawing.SystemIcons.Question.Width,
				System.Drawing.SystemIcons.Question.Height);
			pic.Width = System.Drawing.SystemIcons.Question.Width;
			pic.Height = System.Drawing.SystemIcons.Question.Height;
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button3 = new Janus.Windows.EditControls.UIButton();
			this.button2 = new Janus.Windows.EditControls.UIButton();
			this.button1 = new Janus.Windows.EditControls.UIButton();
			this.pic = new System.Windows.Forms.PictureBox();
			this.messageLabel = new System.Windows.Forms.Label();
			this.systemIcons = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(248, 120);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 0;
			this.button3.Text = "uiButton1";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(168, 120);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "uiButton2";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(88, 120);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "uiButton3";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pic
			// 
			this.pic.Location = new System.Drawing.Point(16, 24);
			this.pic.Name = "pic";
			this.pic.Size = new System.Drawing.Size(70, 70);
			this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pic.TabIndex = 3;
			this.pic.TabStop = false;
			// 
			// messageLabel
			// 
			this.messageLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.messageLabel.Location = new System.Drawing.Point(104, 24);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(288, 72);
			this.messageLabel.TabIndex = 4;
			this.messageLabel.Text = "label1";
			// 
			// systemIcons
			// 
			this.systemIcons.ImageSize = new System.Drawing.Size(70, 70);
			this.systemIcons.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// MessageBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(414, 164);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.pic);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button3);
			this.Name = "MessageBox";
			this.ResumeLayout(false);

		}

		public static DialogResult Show (string text, string caption, MessageBoxButtons buttons,
			MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
		{
			return show(text, caption, buttons, icon, defaultButton, options);
		}
		public static DialogResult Show (string text, string caption, MessageBoxButtons buttons,
			MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
		{
			return show(text, caption, buttons, icon, defaultButton, MessageBoxOptions.DefaultDesktopOnly);
		}
		public static DialogResult Show (string text, string caption, MessageBoxButtons buttons,
			MessageBoxIcon icon)
		{
			return show(text, caption, buttons, icon,
				MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
		}
		public static DialogResult Show (string text, string caption, MessageBoxButtons buttons)
		{
			return show(text, caption, buttons, MessageBoxIcon.None,
				MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
		}
		public static DialogResult Show (string text, string caption)
		{
			return show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.None,
				MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
		}
		public static DialogResult Show (string text)
		{
			return show(text, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None,
				MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
		}

		private static DialogResult show (string text, string caption, MessageBoxButtons buttons,
			MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
		{
			MessageBox mb = new MessageBox ();
			mb.text = text;
			mb.caption = caption;
			mb.buttons = buttons;
			mb.icon = icon;
			mb.defultButton = defaultButton;
			mb.options = options;

			mb.initialize ();

			return mb.ShowDialog ();
		}

		private void initialize ()
		{
			this.messageLabel.Text = text;
			this.Text = caption;
			
			initButtons ();
			initIcon ();
			initDefaultButton ();
			initOptions ();
			reArrange ();
		}

		private void initDefaultButton ()
		{
			switch (defultButton)
			{
				case MessageBoxDefaultButton.Button1:
					if (button1.Enabled)
					{
						AcceptButton = button1;
						button1.Select();
					}
					break;
				case MessageBoxDefaultButton.Button2:
					if (button2.Enabled)
					{
						AcceptButton = button2;
						button2.Select();
					}
					break;
				case MessageBoxDefaultButton.Button3:
					if (button3.Enabled)
					{
						AcceptButton = button3;
						button2.Select();
						}
					break;
			}
		}

		private void initOptions ()
		{
			if ((options & MessageBoxOptions.DefaultDesktopOnly) == MessageBoxOptions.DefaultDesktopOnly)
			{
			}
			if ((options & MessageBoxOptions.DefaultDesktopOnly) == MessageBoxOptions.RightAlign)
			{
				messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			}
			if ((options & MessageBoxOptions.DefaultDesktopOnly) == MessageBoxOptions.RtlReading)
			{
				RightToLeft = RightToLeft.Yes;
			}
			if ((options & MessageBoxOptions.DefaultDesktopOnly) == MessageBoxOptions.ServiceNotification)
			{
			}
		}

		private void initIcon ()
		{
			if (icon == MessageBoxIcon.Asterisk)
				pic.Image = systemIcons.Images [0];
			else if (icon == MessageBoxIcon.Error)
				pic.Image = systemIcons.Images [1];
			else if (icon == MessageBoxIcon.Exclamation)
				pic.Image = systemIcons.Images [2];
			else if (icon == MessageBoxIcon.Hand)
				pic.Image = systemIcons.Images [3];
			else if (icon == MessageBoxIcon.Information)
				pic.Image = systemIcons.Images [4];
			else if (icon == MessageBoxIcon.Question)
				pic.Image = systemIcons.Images [5];
			else if (icon == MessageBoxIcon.Warning)
				pic.Image = systemIcons.Images [6];
			else if (icon == MessageBoxIcon.Stop)
				pic.Image = systemIcons.Images [7];
		}
		private void initButtons ()
		{
			switch (buttons)
			{
				case MessageBoxButtons.AbortRetryIgnore:
					button1.Text = ABORT;
					button2.Text = RETRY;
					button3.Text = IGNORE;
					AddButton (button1, button2, button3);
					break;
				case MessageBoxButtons.OK:
					button1.Text = OK;
					AddButton (button1);
					break;
				case MessageBoxButtons.OKCancel:
					button1.Text = OK;
					button2.Text = CANCEL;
					AddButton (button1, button2);
					break;
				case MessageBoxButtons.RetryCancel:
					button1.Text = RETRY;
					button2.Text = CANCEL;
					AddButton (button1, button2);
					break;
				case MessageBoxButtons.YesNo:
					button1.Text = YES;
					button2.Text = NO;
					AddButton (button1, button2);
					break;
				case MessageBoxButtons.YesNoCancel:
					button1.Text = YES;
					button2.Text = NO;
					button3.Text = CANCEL;
					AddButton (button1, button2, button3);
					break;
			}
		}

		private void AddButton (UIButton button)
		{
			button1.Visible = button2.Visible = button3.Visible =
				button1.Enabled = button2.Enabled = button3.Enabled = false;
			button.Visible = button.Enabled = true;
			button.Left = Width / 2 - button.Width / 2;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			close (button3.Text);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			close (button2.Text);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			close (button1.Text);
		}
	
		private void AddButton (UIButton button1, UIButton button2)
		{
			this.button1.Visible = this.button2.Visible = this.button3.Visible =
				this.button1.Enabled = this.button2.Enabled = this.button3.Enabled = false;
			button1.Visible = button1.Enabled = button2.Visible = button2.Enabled = true;

			if (RightToLeft == RightToLeft.No)
			{
				button1.Left = Width / 2 - (button1.Width + button2.Width + 10)/ 2;
				button2.Left = button1.Left + button1.Width + 10;
			}
			else
			{
				button2.Left = Width / 2 - (button1.Width + button2.Width + 10)/ 2;
				button1.Left = button2.Left + button2.Width + 10;
			}
		}
		private void AddButton (UIButton button1, UIButton button2, UIButton button3)
		{
			if (RightToLeft == RightToLeft.No)
			{
				button1.Left = Width / 2 - (button1.Width + button2.Width + button3.Width + 20)/ 2;
				button2.Left = button1.Left + button1.Width + 10;
				button3.Left = button2.Left + button2.Width + 10;
			}
			else
			{
				button3.Left = Width / 2 - (button1.Width + button2.Width + button3.Width + 20)/ 2;
				button2.Left = button3.Left + button3.Width + 10;
				button1.Left = button2.Left + button2.Width + 10;
			}
		}

		private void close (string result)
		{
			if (result == OK) DialogResult = DialogResult.OK;
			else if (result == ABORT) DialogResult = DialogResult.Abort;
			else if (result == CANCEL) DialogResult = DialogResult.Cancel;
			else if (result == RETRY) DialogResult = DialogResult.Retry;
			else if (result == IGNORE) DialogResult = DialogResult.Ignore;
			else if (result == YES)  DialogResult = DialogResult.Yes;
			else if (result == NO)  DialogResult = DialogResult.No;
			else DialogResult = DialogResult.Cancel;
			
			Close ();
		}

		private void reArrange ()
		{
			if (icon == MessageBoxIcon.None)
			{
				pic.Visible = false;
				messageLabel.Width = Width - 70;
				messageLabel.Left = 35;

			}
			else
			{
				pic.Left = 35;
				messageLabel.Width = Width - 70 - 30 - pic.Width;
				messageLabel.Left = 35 + 30 + pic.Width;
			}

		}
	}
}