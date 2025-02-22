using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Message.Domain;

namespace Message.UI
{
	/// <summary>
	/// Summary description for SendForm.
	/// </summary>
	public class SendForm : CommonClass.FrmBase
	{
		private Janus.Windows.EditControls.UIButton uiButton1;
		private System.Windows.Forms.RichTextBox textBody;
		private System.Windows.Forms.OpenFileDialog attachmentDlg;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Janus.Windows.GridEX.EditControls.EditBox FromEditBox;
		private Janus.Windows.GridEX.EditControls.EditBox ToEditBox;
		private Janus.Windows.GridEX.EditControls.EditBox SubjEditBox;
		private ArrayList fileAttachments = new ArrayList();
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private ArrayList selectedItems;
		//private Janus.Windows.EditControls.UIButton CancelButton;
		private Janus.Windows.EditControls.UIButton SendButton;
		private User currentUser;
		private Company currentCompany;
		private Janus.Windows.GridEX.EditControls.EditBox AttachmentsEdit;
		private Janus.Windows.EditControls.UIButton addButton;
		string msgSender = "user";
		
		public SendForm(User usr)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			currentUser = usr;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public SendForm(Company comp)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			currentCompany = comp;
			msgSender = "company";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SendForm));
			this.addButton = new Janus.Windows.EditControls.UIButton();
			this.SendButton = new Janus.Windows.EditControls.UIButton();
			this.uiButton1 = new Janus.Windows.EditControls.UIButton();
			this.textBody = new System.Windows.Forms.RichTextBox();
			this.attachmentDlg = new System.Windows.Forms.OpenFileDialog();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.FromEditBox = new Janus.Windows.GridEX.EditControls.EditBox();
			this.ToEditBox = new Janus.Windows.GridEX.EditControls.EditBox();
			this.SubjEditBox = new Janus.Windows.GridEX.EditControls.EditBox();
			this.AttachmentsEdit = new Janus.Windows.GridEX.EditControls.EditBox();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.AccessibleDescription = resources.GetString("addButton.AccessibleDescription");
			this.addButton.AccessibleName = resources.GetString("addButton.AccessibleName");
			this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("addButton.Anchor")));
			this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
			this.addButton.DisabledImageIndex = ((int)(resources.GetObject("addButton.DisabledImageIndex")));
			this.addButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("addButton.Dock")));
			this.addButton.Enabled = ((bool)(resources.GetObject("addButton.Enabled")));
			this.addButton.Font = ((System.Drawing.Font)(resources.GetObject("addButton.Font")));
			this.addButton.HotImageIndex = ((int)(resources.GetObject("addButton.HotImageIndex")));
			this.addButton.ImageIndex = ((int)(resources.GetObject("addButton.ImageIndex")));
			this.addButton.ImageSize = ((System.Drawing.Size)(resources.GetObject("addButton.ImageSize")));
			this.addButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("addButton.ImeMode")));
			this.addButton.Location = ((System.Drawing.Point)(resources.GetObject("addButton.Location")));
			this.addButton.Name = "addButton";
			this.addButton.PressedImageIndex = ((int)(resources.GetObject("addButton.PressedImageIndex")));
			this.addButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("addButton.RightToLeft")));
			this.addButton.Size = ((System.Drawing.Size)(resources.GetObject("addButton.Size")));
			this.addButton.TabIndex = ((int)(resources.GetObject("addButton.TabIndex")));
			this.addButton.Text = resources.GetString("addButton.Text");
			this.addButton.TextHorizontalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("addButton.TextHorizontalAlignment")));
			this.addButton.TextVerticalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("addButton.TextVerticalAlignment")));
			this.addButton.UseThemes = ((bool)(resources.GetObject("addButton.UseThemes")));
			this.addButton.Visible = ((bool)(resources.GetObject("addButton.Visible")));
			this.addButton.VisualStyle = ((Janus.Windows.UI.VisualStyle)(resources.GetObject("addButton.VisualStyle")));
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// SendButton
			// 
			this.SendButton.AccessibleDescription = resources.GetString("SendButton.AccessibleDescription");
			this.SendButton.AccessibleName = resources.GetString("SendButton.AccessibleName");
			this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("SendButton.Anchor")));
			this.SendButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SendButton.BackgroundImage")));
			this.SendButton.DisabledImageIndex = ((int)(resources.GetObject("SendButton.DisabledImageIndex")));
			this.SendButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("SendButton.Dock")));
			this.SendButton.Enabled = ((bool)(resources.GetObject("SendButton.Enabled")));
			this.SendButton.Font = ((System.Drawing.Font)(resources.GetObject("SendButton.Font")));
			this.SendButton.HotImageIndex = ((int)(resources.GetObject("SendButton.HotImageIndex")));
			this.SendButton.ImageIndex = ((int)(resources.GetObject("SendButton.ImageIndex")));
			this.SendButton.ImageSize = ((System.Drawing.Size)(resources.GetObject("SendButton.ImageSize")));
			this.SendButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("SendButton.ImeMode")));
			this.SendButton.Location = ((System.Drawing.Point)(resources.GetObject("SendButton.Location")));
			this.SendButton.Name = "SendButton";
			this.SendButton.PressedImageIndex = ((int)(resources.GetObject("SendButton.PressedImageIndex")));
			this.SendButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("SendButton.RightToLeft")));
			this.SendButton.Size = ((System.Drawing.Size)(resources.GetObject("SendButton.Size")));
			this.SendButton.TabIndex = ((int)(resources.GetObject("SendButton.TabIndex")));
			this.SendButton.Text = resources.GetString("SendButton.Text");
			this.SendButton.TextHorizontalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("SendButton.TextHorizontalAlignment")));
			this.SendButton.TextVerticalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("SendButton.TextVerticalAlignment")));
			this.SendButton.UseThemes = ((bool)(resources.GetObject("SendButton.UseThemes")));
			this.SendButton.Visible = ((bool)(resources.GetObject("SendButton.Visible")));
			this.SendButton.VisualStyle = ((Janus.Windows.UI.VisualStyle)(resources.GetObject("SendButton.VisualStyle")));
			this.SendButton.Click += new System.EventHandler(this.uiButton2_Click);
			// 
			// uiButton1
			// 
			this.uiButton1.AccessibleDescription = resources.GetString("uiButton1.AccessibleDescription");
			this.uiButton1.AccessibleName = resources.GetString("uiButton1.AccessibleName");
			this.uiButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("uiButton1.Anchor")));
			this.uiButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiButton1.BackgroundImage")));
			this.uiButton1.DisabledImageIndex = ((int)(resources.GetObject("uiButton1.DisabledImageIndex")));
			this.uiButton1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("uiButton1.Dock")));
			this.uiButton1.Enabled = ((bool)(resources.GetObject("uiButton1.Enabled")));
			this.uiButton1.Font = ((System.Drawing.Font)(resources.GetObject("uiButton1.Font")));
			this.uiButton1.HotImageIndex = ((int)(resources.GetObject("uiButton1.HotImageIndex")));
			this.uiButton1.ImageIndex = ((int)(resources.GetObject("uiButton1.ImageIndex")));
			this.uiButton1.ImageSize = ((System.Drawing.Size)(resources.GetObject("uiButton1.ImageSize")));
			this.uiButton1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("uiButton1.ImeMode")));
			this.uiButton1.Location = ((System.Drawing.Point)(resources.GetObject("uiButton1.Location")));
			this.uiButton1.Name = "uiButton1";
			this.uiButton1.PressedImageIndex = ((int)(resources.GetObject("uiButton1.PressedImageIndex")));
			this.uiButton1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("uiButton1.RightToLeft")));
			this.uiButton1.Size = ((System.Drawing.Size)(resources.GetObject("uiButton1.Size")));
			this.uiButton1.TabIndex = ((int)(resources.GetObject("uiButton1.TabIndex")));
			this.uiButton1.Text = resources.GetString("uiButton1.Text");
			this.uiButton1.TextHorizontalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("uiButton1.TextHorizontalAlignment")));
			this.uiButton1.TextVerticalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("uiButton1.TextVerticalAlignment")));
			this.uiButton1.UseThemes = ((bool)(resources.GetObject("uiButton1.UseThemes")));
			this.uiButton1.Visible = ((bool)(resources.GetObject("uiButton1.Visible")));
			this.uiButton1.VisualStyle = ((Janus.Windows.UI.VisualStyle)(resources.GetObject("uiButton1.VisualStyle")));
			this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
			// 
			// textBody
			// 
			this.textBody.AccessibleDescription = resources.GetString("textBody.AccessibleDescription");
			this.textBody.AccessibleName = resources.GetString("textBody.AccessibleName");
			this.textBody.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBody.Anchor")));
			this.textBody.AutoSize = ((bool)(resources.GetObject("textBody.AutoSize")));
			this.textBody.AutoWordSelection = true;
			this.textBody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBody.BackgroundImage")));
			this.textBody.BulletIndent = ((int)(resources.GetObject("textBody.BulletIndent")));
			this.textBody.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBody.Dock")));
			this.textBody.Enabled = ((bool)(resources.GetObject("textBody.Enabled")));
			this.textBody.Font = ((System.Drawing.Font)(resources.GetObject("textBody.Font")));
			this.textBody.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBody.ImeMode")));
			this.textBody.Location = ((System.Drawing.Point)(resources.GetObject("textBody.Location")));
			this.textBody.MaxLength = ((int)(resources.GetObject("textBody.MaxLength")));
			this.textBody.Multiline = ((bool)(resources.GetObject("textBody.Multiline")));
			this.textBody.Name = "textBody";
			this.textBody.RightMargin = ((int)(resources.GetObject("textBody.RightMargin")));
			this.textBody.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBody.RightToLeft")));
			this.textBody.ScrollBars = ((System.Windows.Forms.RichTextBoxScrollBars)(resources.GetObject("textBody.ScrollBars")));
			this.textBody.Size = ((System.Drawing.Size)(resources.GetObject("textBody.Size")));
			this.textBody.TabIndex = ((int)(resources.GetObject("textBody.TabIndex")));
			this.textBody.Text = resources.GetString("textBody.Text");
			this.textBody.Visible = ((bool)(resources.GetObject("textBody.Visible")));
			this.textBody.WordWrap = ((bool)(resources.GetObject("textBody.WordWrap")));
			this.textBody.ZoomFactor = ((System.Single)(resources.GetObject("textBody.ZoomFactor")));
			// 
			// attachmentDlg
			// 
			this.attachmentDlg.Filter = resources.GetString("attachmentDlg.Filter");
			this.attachmentDlg.Title = resources.GetString("attachmentDlg.Title");
			// 
			// label8
			// 
			this.label8.AccessibleDescription = resources.GetString("label8.AccessibleDescription");
			this.label8.AccessibleName = resources.GetString("label8.AccessibleName");
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label8.Anchor")));
			this.label8.AutoSize = ((bool)(resources.GetObject("label8.AutoSize")));
			this.label8.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label8.Dock")));
			this.label8.Enabled = ((bool)(resources.GetObject("label8.Enabled")));
			this.label8.Font = ((System.Drawing.Font)(resources.GetObject("label8.Font")));
			this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
			this.label8.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label8.ImageAlign")));
			this.label8.ImageIndex = ((int)(resources.GetObject("label8.ImageIndex")));
			this.label8.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label8.ImeMode")));
			this.label8.Location = ((System.Drawing.Point)(resources.GetObject("label8.Location")));
			this.label8.Name = "label8";
			this.label8.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label8.RightToLeft")));
			this.label8.Size = ((System.Drawing.Size)(resources.GetObject("label8.Size")));
			this.label8.TabIndex = ((int)(resources.GetObject("label8.TabIndex")));
			this.label8.Text = resources.GetString("label8.Text");
			this.label8.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label8.TextAlign")));
			this.label8.Visible = ((bool)(resources.GetObject("label8.Visible")));
			// 
			// label4
			// 
			this.label4.AccessibleDescription = resources.GetString("label4.AccessibleDescription");
			this.label4.AccessibleName = resources.GetString("label4.AccessibleName");
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label4.Anchor")));
			this.label4.AutoSize = ((bool)(resources.GetObject("label4.AutoSize")));
			this.label4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label4.Dock")));
			this.label4.Enabled = ((bool)(resources.GetObject("label4.Enabled")));
			this.label4.Font = ((System.Drawing.Font)(resources.GetObject("label4.Font")));
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.ImageAlign")));
			this.label4.ImageIndex = ((int)(resources.GetObject("label4.ImageIndex")));
			this.label4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label4.ImeMode")));
			this.label4.Location = ((System.Drawing.Point)(resources.GetObject("label4.Location")));
			this.label4.Name = "label4";
			this.label4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label4.RightToLeft")));
			this.label4.Size = ((System.Drawing.Size)(resources.GetObject("label4.Size")));
			this.label4.TabIndex = ((int)(resources.GetObject("label4.TabIndex")));
			this.label4.Text = resources.GetString("label4.Text");
			this.label4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.TextAlign")));
			this.label4.Visible = ((bool)(resources.GetObject("label4.Visible")));
			// 
			// label2
			// 
			this.label2.AccessibleDescription = resources.GetString("label2.AccessibleDescription");
			this.label2.AccessibleName = resources.GetString("label2.AccessibleName");
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label2.Anchor")));
			this.label2.AutoSize = ((bool)(resources.GetObject("label2.AutoSize")));
			this.label2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label2.Dock")));
			this.label2.Enabled = ((bool)(resources.GetObject("label2.Enabled")));
			this.label2.Font = ((System.Drawing.Font)(resources.GetObject("label2.Font")));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.ImageAlign")));
			this.label2.ImageIndex = ((int)(resources.GetObject("label2.ImageIndex")));
			this.label2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label2.ImeMode")));
			this.label2.Location = ((System.Drawing.Point)(resources.GetObject("label2.Location")));
			this.label2.Name = "label2";
			this.label2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label2.RightToLeft")));
			this.label2.Size = ((System.Drawing.Size)(resources.GetObject("label2.Size")));
			this.label2.TabIndex = ((int)(resources.GetObject("label2.TabIndex")));
			this.label2.Text = resources.GetString("label2.Text");
			this.label2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.TextAlign")));
			this.label2.Visible = ((bool)(resources.GetObject("label2.Visible")));
			// 
			// label1
			// 
			this.label1.AccessibleDescription = resources.GetString("label1.AccessibleDescription");
			this.label1.AccessibleName = resources.GetString("label1.AccessibleName");
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label1.Anchor")));
			this.label1.AutoSize = ((bool)(resources.GetObject("label1.AutoSize")));
			this.label1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label1.Dock")));
			this.label1.Enabled = ((bool)(resources.GetObject("label1.Enabled")));
			this.label1.Font = ((System.Drawing.Font)(resources.GetObject("label1.Font")));
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.ImageAlign")));
			this.label1.ImageIndex = ((int)(resources.GetObject("label1.ImageIndex")));
			this.label1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label1.ImeMode")));
			this.label1.Location = ((System.Drawing.Point)(resources.GetObject("label1.Location")));
			this.label1.Name = "label1";
			this.label1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label1.RightToLeft")));
			this.label1.Size = ((System.Drawing.Size)(resources.GetObject("label1.Size")));
			this.label1.TabIndex = ((int)(resources.GetObject("label1.TabIndex")));
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.TextAlign")));
			this.label1.Visible = ((bool)(resources.GetObject("label1.Visible")));
			// 
			// FromEditBox
			// 
			this.FromEditBox.AccessibleDescription = resources.GetString("FromEditBox.AccessibleDescription");
			this.FromEditBox.AccessibleName = resources.GetString("FromEditBox.AccessibleName");
			this.FromEditBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("FromEditBox.Anchor")));
			this.FromEditBox.AutoScroll = ((bool)(resources.GetObject("FromEditBox.AutoScroll")));
			this.FromEditBox.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("FromEditBox.AutoScrollMargin")));
			this.FromEditBox.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("FromEditBox.AutoScrollMinSize")));
			this.FromEditBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FromEditBox.BackgroundImage")));
			this.FromEditBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("FromEditBox.Dock")));
			this.FromEditBox.Enabled = ((bool)(resources.GetObject("FromEditBox.Enabled")));
			this.FromEditBox.Font = ((System.Drawing.Font)(resources.GetObject("FromEditBox.Font")));
			this.FromEditBox.Image = ((System.Drawing.Image)(resources.GetObject("FromEditBox.Image")));
			this.FromEditBox.ImageIndex = ((int)(resources.GetObject("FromEditBox.ImageIndex")));
			this.FromEditBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("FromEditBox.ImeMode")));
			this.FromEditBox.Location = ((System.Drawing.Point)(resources.GetObject("FromEditBox.Location")));
			this.FromEditBox.Name = "FromEditBox";
			this.FromEditBox.ReadOnly = true;
			this.FromEditBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("FromEditBox.RightToLeft")));
			this.FromEditBox.Size = ((System.Drawing.Size)(resources.GetObject("FromEditBox.Size")));
			this.FromEditBox.TabIndex = ((int)(resources.GetObject("FromEditBox.TabIndex")));
			this.FromEditBox.Text = resources.GetString("FromEditBox.Text");
			this.FromEditBox.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
			this.FromEditBox.Visible = ((bool)(resources.GetObject("FromEditBox.Visible")));
			// 
			// ToEditBox
			// 
			this.ToEditBox.AccessibleDescription = resources.GetString("ToEditBox.AccessibleDescription");
			this.ToEditBox.AccessibleName = resources.GetString("ToEditBox.AccessibleName");
			this.ToEditBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("ToEditBox.Anchor")));
			this.ToEditBox.AutoScroll = ((bool)(resources.GetObject("ToEditBox.AutoScroll")));
			this.ToEditBox.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("ToEditBox.AutoScrollMargin")));
			this.ToEditBox.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("ToEditBox.AutoScrollMinSize")));
			this.ToEditBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToEditBox.BackgroundImage")));
			this.ToEditBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("ToEditBox.Dock")));
			this.ToEditBox.Enabled = ((bool)(resources.GetObject("ToEditBox.Enabled")));
			this.ToEditBox.Font = ((System.Drawing.Font)(resources.GetObject("ToEditBox.Font")));
			this.ToEditBox.Image = ((System.Drawing.Image)(resources.GetObject("ToEditBox.Image")));
			this.ToEditBox.ImageIndex = ((int)(resources.GetObject("ToEditBox.ImageIndex")));
			this.ToEditBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("ToEditBox.ImeMode")));
			this.ToEditBox.Location = ((System.Drawing.Point)(resources.GetObject("ToEditBox.Location")));
			this.ToEditBox.Name = "ToEditBox";
			this.ToEditBox.ReadOnly = true;
			this.ToEditBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("ToEditBox.RightToLeft")));
			this.ToEditBox.Size = ((System.Drawing.Size)(resources.GetObject("ToEditBox.Size")));
			this.ToEditBox.TabIndex = ((int)(resources.GetObject("ToEditBox.TabIndex")));
			this.ToEditBox.Text = resources.GetString("ToEditBox.Text");
			this.ToEditBox.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
			this.ToEditBox.Visible = ((bool)(resources.GetObject("ToEditBox.Visible")));
			// 
			// SubjEditBox
			// 
			this.SubjEditBox.AccessibleDescription = resources.GetString("SubjEditBox.AccessibleDescription");
			this.SubjEditBox.AccessibleName = resources.GetString("SubjEditBox.AccessibleName");
			this.SubjEditBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("SubjEditBox.Anchor")));
			this.SubjEditBox.AutoScroll = ((bool)(resources.GetObject("SubjEditBox.AutoScroll")));
			this.SubjEditBox.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("SubjEditBox.AutoScrollMargin")));
			this.SubjEditBox.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("SubjEditBox.AutoScrollMinSize")));
			this.SubjEditBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubjEditBox.BackgroundImage")));
			this.SubjEditBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("SubjEditBox.Dock")));
			this.SubjEditBox.Enabled = ((bool)(resources.GetObject("SubjEditBox.Enabled")));
			this.SubjEditBox.Font = ((System.Drawing.Font)(resources.GetObject("SubjEditBox.Font")));
			this.SubjEditBox.Image = ((System.Drawing.Image)(resources.GetObject("SubjEditBox.Image")));
			this.SubjEditBox.ImageIndex = ((int)(resources.GetObject("SubjEditBox.ImageIndex")));
			this.SubjEditBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("SubjEditBox.ImeMode")));
			this.SubjEditBox.Location = ((System.Drawing.Point)(resources.GetObject("SubjEditBox.Location")));
			this.SubjEditBox.Name = "SubjEditBox";
			this.SubjEditBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("SubjEditBox.RightToLeft")));
			this.SubjEditBox.Size = ((System.Drawing.Size)(resources.GetObject("SubjEditBox.Size")));
			this.SubjEditBox.TabIndex = ((int)(resources.GetObject("SubjEditBox.TabIndex")));
			this.SubjEditBox.Text = resources.GetString("SubjEditBox.Text");
			this.SubjEditBox.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
			this.SubjEditBox.Visible = ((bool)(resources.GetObject("SubjEditBox.Visible")));
			// 
			// AttachmentsEdit
			// 
			this.AttachmentsEdit.AccessibleDescription = resources.GetString("AttachmentsEdit.AccessibleDescription");
			this.AttachmentsEdit.AccessibleName = resources.GetString("AttachmentsEdit.AccessibleName");
			this.AttachmentsEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("AttachmentsEdit.Anchor")));
			this.AttachmentsEdit.AutoScroll = ((bool)(resources.GetObject("AttachmentsEdit.AutoScroll")));
			this.AttachmentsEdit.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("AttachmentsEdit.AutoScrollMargin")));
			this.AttachmentsEdit.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("AttachmentsEdit.AutoScrollMinSize")));
			this.AttachmentsEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AttachmentsEdit.BackgroundImage")));
			this.AttachmentsEdit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("AttachmentsEdit.Dock")));
			this.AttachmentsEdit.Enabled = ((bool)(resources.GetObject("AttachmentsEdit.Enabled")));
			this.AttachmentsEdit.Font = ((System.Drawing.Font)(resources.GetObject("AttachmentsEdit.Font")));
			this.AttachmentsEdit.Image = ((System.Drawing.Image)(resources.GetObject("AttachmentsEdit.Image")));
			this.AttachmentsEdit.ImageIndex = ((int)(resources.GetObject("AttachmentsEdit.ImageIndex")));
			this.AttachmentsEdit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("AttachmentsEdit.ImeMode")));
			this.AttachmentsEdit.Location = ((System.Drawing.Point)(resources.GetObject("AttachmentsEdit.Location")));
			this.AttachmentsEdit.Name = "AttachmentsEdit";
			this.AttachmentsEdit.ReadOnly = true;
			this.AttachmentsEdit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("AttachmentsEdit.RightToLeft")));
			this.AttachmentsEdit.Size = ((System.Drawing.Size)(resources.GetObject("AttachmentsEdit.Size")));
			this.AttachmentsEdit.TabIndex = ((int)(resources.GetObject("AttachmentsEdit.TabIndex")));
			this.AttachmentsEdit.Text = resources.GetString("AttachmentsEdit.Text");
			this.AttachmentsEdit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
			this.AttachmentsEdit.Visible = ((bool)(resources.GetObject("AttachmentsEdit.Visible")));
			// 
			// SendForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(201)), ((System.Byte)(197)), ((System.Byte)(254)));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.AttachmentsEdit);
			this.Controls.Add(this.SubjEditBox);
			this.Controls.Add(this.ToEditBox);
			this.Controls.Add(this.FromEditBox);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.SendButton);
			this.Controls.Add(this.uiButton1);
			this.Controls.Add(this.textBody);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximizeBox = true;
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "SendForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.Load += new System.EventHandler(this.SendForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void uiButton1_Click(object sender, System.EventArgs e)
		{
			
			AddressBookForm adrs = new AddressBookForm(msgSender,selectedItems);
			adrs.ShowDialog();
			if(adrs.OkButtonClick && adrs.Tag != null)
			{
				selectedItems =(ArrayList) adrs.Tag;
			}	

			ToEditBox.Text="";
			if(selectedItems != null)
				fillToEditBox(selectedItems);
			
		}

		private void SendForm_Load(object sender, System.EventArgs e)
		{
			string from = "";
			if(msgSender == "user")
			{
				from = currentUser.Login;
			}
			else
			{
				from = currentCompany.CompanyShortName;
			}
			FromEditBox.Text = from;
		}
		private void fillToEditBox(ArrayList dest)
		{	
			  
			foreach(SendInfo tmp in selectedItems)
			{
				
				
				if(msgSender == "user")
				{
					ToEditBox.Text += tmp.DestUser.Login+";";
				}
				else
				{
					ToEditBox.Text += tmp.DestCompany.CompanyShortName+";";
				}
			
			}
		}
		private void uiButton2_Click(object sender, System.EventArgs e)
		{
			if(selectedItems == null )
				MessageBox.Show("Please fill \"To\" Field by pressing Addressbook button!");
			else
			{
				MessageInfo mi = new MessageInfo(msgSender);
				mi.Body = textBody.Text;
				mi.MsgSender = msgSender;
				if(msgSender == "user")
					mi.SenderUser = currentUser;
				else
					mi.SenderComp = currentCompany;
				
				mi.Subject = SubjEditBox.Text;
				mi.SendInformation = selectedItems;
				mi.FileAttachments = fileAttachments;

				mi.Send();
				if(mi.FailedSend.Count == 0)
					System.Windows.Forms.MessageBox.Show ("Messages has been sent successfully");
				else
				{
					string tmp = "Message(s) to";
					foreach(Company c in mi.FailedSend)
					{
						tmp += " "+ c.CompanyShortName+",";
					}
					tmp = tmp.Remove(tmp.Length-1,1);
					tmp += " haven't been sent.";
					System.Windows.Forms.MessageBox.Show (tmp);
					
				}
				this.Close();
			}
		}

		private void CancelButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		
		
		/*private void uiButton4_Click(object sender, System.EventArgs e)
		{
			attachmentDlg.Reset(); 
			attachmentDlg.Multiselect = true;
			attachmentDlg.CheckFileExists = true;
			attachmentDlg.CheckPathExists = true;
			if( attachmentDlg.ShowDialog()!= DialogResult.OK )
				return;
			string [] attachments = attachmentDlg.FileNames;
			int nLen = attachments.Length;
			for( int i = 0; i < nLen; i++ )
			{
				fileAttachments.Add(new Attachment( attachments[i] ));
				string fileName = attachments[i];
				int pos = fileName.LastIndexOf( "\\" );
				if( pos != -1 )
					fileName = fileName.Substring( pos+1 );

				AttachmentsEdit.Text += fileName;
				AttachmentsEdit.Text += ";";
			}

		}
		*/
		private void uiButton5_Click(object sender, System.EventArgs e)
		{
			AttachmentForm af = new AttachmentForm(fileAttachments);
			af.SaveButtonVisible = false;
						
			af.ShowDialog();
			AttachmentsEdit.Text = "";
			fileAttachments = (ArrayList) af.Tag;
			foreach(Attachment a in fileAttachments)
			{
				AttachmentsEdit.Text += a.FileName+"; "; 
			}


			/*fileAttachments.Clear();
			AttachmentsEdit.Text = "";
			*/
		}

		private void addButton_Click(object sender, System.EventArgs e)
		{
			
			AttachmentForm af = new AttachmentForm(fileAttachments);
			af.SaveButtonVisible = false;
			af.ShowDialog();
			if(af.OkButtonClick)
			{
				AttachmentsEdit.Text = "";
				fileAttachments = (ArrayList) af.Tag;
				foreach(Attachment a in fileAttachments)
				{
					AttachmentsEdit.Text += a.FileName+"; "; 
				}
			}
		}


	}
}
