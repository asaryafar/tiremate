using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Documents.Domain;

namespace DocumentsUI
{
	/// <summary>
	/// Summary description for AttachmentForm.
	/// </summary>
	public class AttachmentForm : CommonClass.FrmBase//System.Windows.Forms.Form
	{
		private Janus.Windows.EditControls.UIButton okButton;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ListView attachmentsListView;
		private Janus.Windows.EditControls.UIButton addButton;
		private Janus.Windows.EditControls.UIButton deleteButton;
		private Janus.Windows.EditControls.UIButton largeIconButton;
		private Janus.Windows.EditControls.UIButton listButton;
		private Janus.Windows.EditControls.UIButton smallIconButton;
		private System.Windows.Forms.ContextMenu cm;
		private System.Windows.Forms.MenuItem renameMenuItem;
		private System.Windows.Forms.MenuItem openMenuItem;
		private System.Windows.Forms.MenuItem deleteMenuItem;
		private System.Windows.Forms.MenuItem addMenuItem;
		private TOCEntry tocentry;
		private System.Windows.Forms.ColumnHeader fnCH;
		private System.Windows.Forms.ColumnHeader sizeCH;
		private Hashtable extToIcon;

		public AttachmentForm(TOCEntry tocentry)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.tocentry = tocentry;
			extToIcon = new Hashtable (15);

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AttachmentForm));
			this.okButton = new Janus.Windows.EditControls.UIButton();
			this.attachmentsListView = new System.Windows.Forms.ListView();
			this.fnCH = new System.Windows.Forms.ColumnHeader();
			this.sizeCH = new System.Windows.Forms.ColumnHeader();
			this.cm = new System.Windows.Forms.ContextMenu();
			this.addMenuItem = new System.Windows.Forms.MenuItem();
			this.deleteMenuItem = new System.Windows.Forms.MenuItem();
			this.renameMenuItem = new System.Windows.Forms.MenuItem();
			this.openMenuItem = new System.Windows.Forms.MenuItem();
			this.addButton = new Janus.Windows.EditControls.UIButton();
			this.deleteButton = new Janus.Windows.EditControls.UIButton();
			this.largeIconButton = new Janus.Windows.EditControls.UIButton();
			this.listButton = new Janus.Windows.EditControls.UIButton();
			this.smallIconButton = new Janus.Windows.EditControls.UIButton();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.AccessibleDescription = resources.GetString("okButton.AccessibleDescription");
			this.okButton.AccessibleName = resources.GetString("okButton.AccessibleName");
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("okButton.Anchor")));
			this.okButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("okButton.BackgroundImage")));
			this.okButton.DisabledImageIndex = ((int)(resources.GetObject("okButton.DisabledImageIndex")));
			this.okButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("okButton.Dock")));
			this.okButton.Enabled = ((bool)(resources.GetObject("okButton.Enabled")));
			this.okButton.Font = ((System.Drawing.Font)(resources.GetObject("okButton.Font")));
			this.okButton.HotImageIndex = ((int)(resources.GetObject("okButton.HotImageIndex")));
			this.okButton.ImageIndex = ((int)(resources.GetObject("okButton.ImageIndex")));
			this.okButton.ImageSize = ((System.Drawing.Size)(resources.GetObject("okButton.ImageSize")));
			this.okButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("okButton.ImeMode")));
			this.okButton.Location = ((System.Drawing.Point)(resources.GetObject("okButton.Location")));
			this.okButton.Name = "okButton";
			this.okButton.PressedImageIndex = ((int)(resources.GetObject("okButton.PressedImageIndex")));
			this.okButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("okButton.RightToLeft")));
			this.okButton.Size = ((System.Drawing.Size)(resources.GetObject("okButton.Size")));
			this.okButton.TabIndex = ((int)(resources.GetObject("okButton.TabIndex")));
			this.okButton.Text = resources.GetString("okButton.Text");
			this.okButton.TextHorizontalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("okButton.TextHorizontalAlignment")));
			this.okButton.TextVerticalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("okButton.TextVerticalAlignment")));
			this.okButton.UseThemes = ((bool)(resources.GetObject("okButton.UseThemes")));
			this.okButton.Visible = ((bool)(resources.GetObject("okButton.Visible")));
			this.okButton.VisualStyle = ((Janus.Windows.UI.VisualStyle)(resources.GetObject("okButton.VisualStyle")));
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// attachmentsListView
			// 
			this.attachmentsListView.AccessibleDescription = resources.GetString("attachmentsListView.AccessibleDescription");
			this.attachmentsListView.AccessibleName = resources.GetString("attachmentsListView.AccessibleName");
			this.attachmentsListView.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("attachmentsListView.Alignment")));
			this.attachmentsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("attachmentsListView.Anchor")));
			this.attachmentsListView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("attachmentsListView.BackgroundImage")));
			this.attachmentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																								  this.fnCH,
																								  this.sizeCH});
			this.attachmentsListView.ContextMenu = this.cm;
			this.attachmentsListView.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("attachmentsListView.Dock")));
			this.attachmentsListView.Enabled = ((bool)(resources.GetObject("attachmentsListView.Enabled")));
			this.attachmentsListView.Font = ((System.Drawing.Font)(resources.GetObject("attachmentsListView.Font")));
			this.attachmentsListView.FullRowSelect = true;
			this.attachmentsListView.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("attachmentsListView.ImeMode")));
			this.attachmentsListView.LabelEdit = true;
			this.attachmentsListView.LabelWrap = ((bool)(resources.GetObject("attachmentsListView.LabelWrap")));
			this.attachmentsListView.Location = ((System.Drawing.Point)(resources.GetObject("attachmentsListView.Location")));
			this.attachmentsListView.Name = "attachmentsListView";
			this.attachmentsListView.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("attachmentsListView.RightToLeft")));
			this.attachmentsListView.Size = ((System.Drawing.Size)(resources.GetObject("attachmentsListView.Size")));
			this.attachmentsListView.TabIndex = ((int)(resources.GetObject("attachmentsListView.TabIndex")));
			this.attachmentsListView.Text = resources.GetString("attachmentsListView.Text");
			this.attachmentsListView.Visible = ((bool)(resources.GetObject("attachmentsListView.Visible")));
			this.attachmentsListView.DoubleClick += new System.EventHandler(this.attachmentsListView_DoubleClick);
			this.attachmentsListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.attachmentsListView_AfterLabelEdit);
			// 
			// fnCH
			// 
			this.fnCH.Text = resources.GetString("fnCH.Text");
			this.fnCH.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("fnCH.TextAlign")));
			this.fnCH.Width = ((int)(resources.GetObject("fnCH.Width")));
			// 
			// sizeCH
			// 
			this.sizeCH.Text = resources.GetString("sizeCH.Text");
			this.sizeCH.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("sizeCH.TextAlign")));
			this.sizeCH.Width = ((int)(resources.GetObject("sizeCH.Width")));
			// 
			// cm
			// 
			this.cm.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																			   this.addMenuItem,
																			   this.deleteMenuItem,
																			   this.renameMenuItem,
																			   this.openMenuItem});
			this.cm.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cm.RightToLeft")));
			// 
			// addMenuItem
			// 
			this.addMenuItem.Enabled = ((bool)(resources.GetObject("addMenuItem.Enabled")));
			this.addMenuItem.Index = 0;
			this.addMenuItem.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("addMenuItem.Shortcut")));
			this.addMenuItem.ShowShortcut = ((bool)(resources.GetObject("addMenuItem.ShowShortcut")));
			this.addMenuItem.Text = resources.GetString("addMenuItem.Text");
			this.addMenuItem.Visible = ((bool)(resources.GetObject("addMenuItem.Visible")));
			this.addMenuItem.Click += new System.EventHandler(this.addButton_Click);
			// 
			// deleteMenuItem
			// 
			this.deleteMenuItem.Enabled = ((bool)(resources.GetObject("deleteMenuItem.Enabled")));
			this.deleteMenuItem.Index = 1;
			this.deleteMenuItem.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("deleteMenuItem.Shortcut")));
			this.deleteMenuItem.ShowShortcut = ((bool)(resources.GetObject("deleteMenuItem.ShowShortcut")));
			this.deleteMenuItem.Text = resources.GetString("deleteMenuItem.Text");
			this.deleteMenuItem.Visible = ((bool)(resources.GetObject("deleteMenuItem.Visible")));
			this.deleteMenuItem.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// renameMenuItem
			// 
			this.renameMenuItem.Enabled = ((bool)(resources.GetObject("renameMenuItem.Enabled")));
			this.renameMenuItem.Index = 2;
			this.renameMenuItem.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("renameMenuItem.Shortcut")));
			this.renameMenuItem.ShowShortcut = ((bool)(resources.GetObject("renameMenuItem.ShowShortcut")));
			this.renameMenuItem.Text = resources.GetString("renameMenuItem.Text");
			this.renameMenuItem.Visible = ((bool)(resources.GetObject("renameMenuItem.Visible")));
			this.renameMenuItem.Click += new System.EventHandler(this.renameMenuItem_Click);
			// 
			// openMenuItem
			// 
			this.openMenuItem.Enabled = ((bool)(resources.GetObject("openMenuItem.Enabled")));
			this.openMenuItem.Index = 3;
			this.openMenuItem.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("openMenuItem.Shortcut")));
			this.openMenuItem.ShowShortcut = ((bool)(resources.GetObject("openMenuItem.ShowShortcut")));
			this.openMenuItem.Text = resources.GetString("openMenuItem.Text");
			this.openMenuItem.Visible = ((bool)(resources.GetObject("openMenuItem.Visible")));
			this.openMenuItem.Click += new System.EventHandler(this.attachmentsListView_DoubleClick);
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
			this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
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
			// deleteButton
			// 
			this.deleteButton.AccessibleDescription = resources.GetString("deleteButton.AccessibleDescription");
			this.deleteButton.AccessibleName = resources.GetString("deleteButton.AccessibleName");
			this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("deleteButton.Anchor")));
			this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
			this.deleteButton.DisabledImageIndex = ((int)(resources.GetObject("deleteButton.DisabledImageIndex")));
			this.deleteButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("deleteButton.Dock")));
			this.deleteButton.Enabled = ((bool)(resources.GetObject("deleteButton.Enabled")));
			this.deleteButton.Font = ((System.Drawing.Font)(resources.GetObject("deleteButton.Font")));
			this.deleteButton.HotImageIndex = ((int)(resources.GetObject("deleteButton.HotImageIndex")));
			this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
			this.deleteButton.ImageIndex = ((int)(resources.GetObject("deleteButton.ImageIndex")));
			this.deleteButton.ImageSize = ((System.Drawing.Size)(resources.GetObject("deleteButton.ImageSize")));
			this.deleteButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("deleteButton.ImeMode")));
			this.deleteButton.Location = ((System.Drawing.Point)(resources.GetObject("deleteButton.Location")));
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.PressedImageIndex = ((int)(resources.GetObject("deleteButton.PressedImageIndex")));
			this.deleteButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("deleteButton.RightToLeft")));
			this.deleteButton.Size = ((System.Drawing.Size)(resources.GetObject("deleteButton.Size")));
			this.deleteButton.TabIndex = ((int)(resources.GetObject("deleteButton.TabIndex")));
			this.deleteButton.Text = resources.GetString("deleteButton.Text");
			this.deleteButton.TextHorizontalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("deleteButton.TextHorizontalAlignment")));
			this.deleteButton.TextVerticalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("deleteButton.TextVerticalAlignment")));
			this.deleteButton.UseThemes = ((bool)(resources.GetObject("deleteButton.UseThemes")));
			this.deleteButton.Visible = ((bool)(resources.GetObject("deleteButton.Visible")));
			this.deleteButton.VisualStyle = ((Janus.Windows.UI.VisualStyle)(resources.GetObject("deleteButton.VisualStyle")));
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// largeIconButton
			// 
			this.largeIconButton.AccessibleDescription = resources.GetString("largeIconButton.AccessibleDescription");
			this.largeIconButton.AccessibleName = resources.GetString("largeIconButton.AccessibleName");
			this.largeIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("largeIconButton.Anchor")));
			this.largeIconButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("largeIconButton.BackgroundImage")));
			this.largeIconButton.DisabledImageIndex = ((int)(resources.GetObject("largeIconButton.DisabledImageIndex")));
			this.largeIconButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("largeIconButton.Dock")));
			this.largeIconButton.Enabled = ((bool)(resources.GetObject("largeIconButton.Enabled")));
			this.largeIconButton.Font = ((System.Drawing.Font)(resources.GetObject("largeIconButton.Font")));
			this.largeIconButton.HotImageIndex = ((int)(resources.GetObject("largeIconButton.HotImageIndex")));
			this.largeIconButton.Image = ((System.Drawing.Image)(resources.GetObject("largeIconButton.Image")));
			this.largeIconButton.ImageIndex = ((int)(resources.GetObject("largeIconButton.ImageIndex")));
			this.largeIconButton.ImageSize = ((System.Drawing.Size)(resources.GetObject("largeIconButton.ImageSize")));
			this.largeIconButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("largeIconButton.ImeMode")));
			this.largeIconButton.Location = ((System.Drawing.Point)(resources.GetObject("largeIconButton.Location")));
			this.largeIconButton.Name = "largeIconButton";
			this.largeIconButton.PressedImageIndex = ((int)(resources.GetObject("largeIconButton.PressedImageIndex")));
			this.largeIconButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("largeIconButton.RightToLeft")));
			this.largeIconButton.Size = ((System.Drawing.Size)(resources.GetObject("largeIconButton.Size")));
			this.largeIconButton.TabIndex = ((int)(resources.GetObject("largeIconButton.TabIndex")));
			this.largeIconButton.Text = resources.GetString("largeIconButton.Text");
			this.largeIconButton.TextHorizontalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("largeIconButton.TextHorizontalAlignment")));
			this.largeIconButton.TextVerticalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("largeIconButton.TextVerticalAlignment")));
			this.largeIconButton.UseThemes = ((bool)(resources.GetObject("largeIconButton.UseThemes")));
			this.largeIconButton.Visible = ((bool)(resources.GetObject("largeIconButton.Visible")));
			this.largeIconButton.VisualStyle = ((Janus.Windows.UI.VisualStyle)(resources.GetObject("largeIconButton.VisualStyle")));
			this.largeIconButton.Click += new System.EventHandler(this.largeIconButton_Click);
			// 
			// listButton
			// 
			this.listButton.AccessibleDescription = resources.GetString("listButton.AccessibleDescription");
			this.listButton.AccessibleName = resources.GetString("listButton.AccessibleName");
			this.listButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("listButton.Anchor")));
			this.listButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listButton.BackgroundImage")));
			this.listButton.DisabledImageIndex = ((int)(resources.GetObject("listButton.DisabledImageIndex")));
			this.listButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("listButton.Dock")));
			this.listButton.Enabled = ((bool)(resources.GetObject("listButton.Enabled")));
			this.listButton.Font = ((System.Drawing.Font)(resources.GetObject("listButton.Font")));
			this.listButton.HotImageIndex = ((int)(resources.GetObject("listButton.HotImageIndex")));
			this.listButton.Image = ((System.Drawing.Image)(resources.GetObject("listButton.Image")));
			this.listButton.ImageIndex = ((int)(resources.GetObject("listButton.ImageIndex")));
			this.listButton.ImageSize = ((System.Drawing.Size)(resources.GetObject("listButton.ImageSize")));
			this.listButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("listButton.ImeMode")));
			this.listButton.Location = ((System.Drawing.Point)(resources.GetObject("listButton.Location")));
			this.listButton.Name = "listButton";
			this.listButton.PressedImageIndex = ((int)(resources.GetObject("listButton.PressedImageIndex")));
			this.listButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("listButton.RightToLeft")));
			this.listButton.Size = ((System.Drawing.Size)(resources.GetObject("listButton.Size")));
			this.listButton.TabIndex = ((int)(resources.GetObject("listButton.TabIndex")));
			this.listButton.Text = resources.GetString("listButton.Text");
			this.listButton.TextHorizontalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("listButton.TextHorizontalAlignment")));
			this.listButton.TextVerticalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("listButton.TextVerticalAlignment")));
			this.listButton.UseThemes = ((bool)(resources.GetObject("listButton.UseThemes")));
			this.listButton.Visible = ((bool)(resources.GetObject("listButton.Visible")));
			this.listButton.VisualStyle = ((Janus.Windows.UI.VisualStyle)(resources.GetObject("listButton.VisualStyle")));
			this.listButton.Click += new System.EventHandler(this.listButton_Click);
			// 
			// smallIconButton
			// 
			this.smallIconButton.AccessibleDescription = resources.GetString("smallIconButton.AccessibleDescription");
			this.smallIconButton.AccessibleName = resources.GetString("smallIconButton.AccessibleName");
			this.smallIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("smallIconButton.Anchor")));
			this.smallIconButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("smallIconButton.BackgroundImage")));
			this.smallIconButton.DisabledImageIndex = ((int)(resources.GetObject("smallIconButton.DisabledImageIndex")));
			this.smallIconButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("smallIconButton.Dock")));
			this.smallIconButton.Enabled = ((bool)(resources.GetObject("smallIconButton.Enabled")));
			this.smallIconButton.Font = ((System.Drawing.Font)(resources.GetObject("smallIconButton.Font")));
			this.smallIconButton.HotImageIndex = ((int)(resources.GetObject("smallIconButton.HotImageIndex")));
			this.smallIconButton.Image = ((System.Drawing.Image)(resources.GetObject("smallIconButton.Image")));
			this.smallIconButton.ImageIndex = ((int)(resources.GetObject("smallIconButton.ImageIndex")));
			this.smallIconButton.ImageSize = ((System.Drawing.Size)(resources.GetObject("smallIconButton.ImageSize")));
			this.smallIconButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("smallIconButton.ImeMode")));
			this.smallIconButton.Location = ((System.Drawing.Point)(resources.GetObject("smallIconButton.Location")));
			this.smallIconButton.Name = "smallIconButton";
			this.smallIconButton.PressedImageIndex = ((int)(resources.GetObject("smallIconButton.PressedImageIndex")));
			this.smallIconButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("smallIconButton.RightToLeft")));
			this.smallIconButton.Size = ((System.Drawing.Size)(resources.GetObject("smallIconButton.Size")));
			this.smallIconButton.TabIndex = ((int)(resources.GetObject("smallIconButton.TabIndex")));
			this.smallIconButton.Text = resources.GetString("smallIconButton.Text");
			this.smallIconButton.TextHorizontalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("smallIconButton.TextHorizontalAlignment")));
			this.smallIconButton.TextVerticalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("smallIconButton.TextVerticalAlignment")));
			this.smallIconButton.UseThemes = ((bool)(resources.GetObject("smallIconButton.UseThemes")));
			this.smallIconButton.Visible = ((bool)(resources.GetObject("smallIconButton.Visible")));
			this.smallIconButton.VisualStyle = ((Janus.Windows.UI.VisualStyle)(resources.GetObject("smallIconButton.VisualStyle")));
			this.smallIconButton.Click += new System.EventHandler(this.smallIconButton_Click);
			// 
			// AttachmentForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(249)), ((System.Byte)(249)), ((System.Byte)(134)));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.smallIconButton);
			this.Controls.Add(this.listButton);
			this.Controls.Add(this.largeIconButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.attachmentsListView);
			this.Controls.Add(this.okButton);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "AttachmentForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.Load += new System.EventHandler(this.AttachmentForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void AttachmentForm_Load(object sender, System.EventArgs e)
		{
			attachmentsListView.LargeImageList = new ImageList();
			attachmentsListView.LargeImageList.ImageSize = new Size (32, 32);
			attachmentsListView.SmallImageList = new ImageList();
			attachmentsListView.SmallImageList.ImageSize = new Size (16, 16);
			attachmentsListView.LargeImageList.ColorDepth = ColorDepth.Depth32Bit;
			attachmentsListView.SmallImageList.TransparentColor = System.Drawing.SystemColors.Window;
			attachmentsListView.LargeImageList.TransparentColor = System.Drawing.SystemColors.Window;

			loadAttachments (false);
		}

		private void loadAttachments (bool refresh)
		{
			tocentry.LoadAttachments (refresh);
			
			foreach (Attachment a in tocentry.Attachments)
				addItem (a);
		}

		private void addItem (Attachment a)
		{
			int index;
			string ext = System.IO.Path.GetExtension (a.AttachedFilename);
			string key = (ext == null ? string.Empty : ext);

			if (extToIcon.ContainsKey (key))
				index = (int) extToIcon [key];
			else
			{
				System.Drawing.Icon largeIcon = Common.IconHandler.IconFromExtension (
					key, Common.IconSize.Large);

				System.Drawing.Icon smallIcon = Common.IconHandler.IconFromExtension (
					key, Common.IconSize.Small);

				if (largeIcon == null)
					largeIcon = new Icon (CommonClass.MainModule.PubMainImagePath + "\\beh.ico");
			
				if (smallIcon == null)
					smallIcon = new Icon (CommonClass.MainModule.PubMainImagePath + "\\beh.ico");

				index = attachmentsListView.LargeImageList.Images.Count;

				attachmentsListView.LargeImageList.Images.Add (largeIcon);
				attachmentsListView.SmallImageList.Images.Add (smallIcon);

				extToIcon.Add (key, index);
			}

			ListViewItem lvi = new ListViewItem (a.AttachedFilename, index);
			attachmentsListView.Items.Add (lvi);
			lvi.Selected = true;
			lvi.Focused = true;
			lvi.EnsureVisible ();
		}

		private void addButton_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog ();
			ofd.CheckFileExists = true;
			ofd.CheckPathExists = true;
			ofd.Multiselect = false;
			if (ofd.ShowDialog () == DialogResult.OK)
			{
				if (System.IO.File.Exists (ofd.FileName))
				{
					System.IO.Stream s = ofd.OpenFile ();
					if (s.Length > Attachment.MAX_ATTACHED_FILE_SIZE)
					{
						double mg = Attachment.MAX_ATTACHED_FILE_SIZE / 1024/1024;
						Common.MessageBox.Show (ResourceAccess.RA.RM.GetString("0004").Replace("*", mg.ToString()));
						return;
					}
					Attachment a = new Attachment (tocentry, tocentry.NewAttachmentID (), System.IO.Path.GetFileName (ofd.FileName));
					a.File = new byte [s.Length];
					s.Read (a.File, 0, (int) s.Length);
					tocentry.Attachments.Add (a);
					a.Status = Updater.Status.New;
					if (tocentry.Status != Updater.Status.New)
						tocentry.Status = Updater.Status.Changed;
					//a.Save();
					addItem (a);
				}
			}
		}

		private void okButton_Click(object sender, System.EventArgs e)
		{
			Close ();
		}

		private void attachmentsListView_DoubleClick(object sender, System.EventArgs e)
		{
			string filename = attachmentsListView.SelectedItems [0].Text;
			Attachment a = tocentry.FindAttachmentByName (filename);
			if (a == null)
			{
				Common.MessageBox.Show ("unexpected error");
				return;
			}

			string filename2 = a.SaveAttachmentAsTemp ();

			Common.Utils.OpenFile (filename2, System.Diagnostics.ProcessWindowStyle.Normal);
		}	

		private void deleteButton_Click(object sender, System.EventArgs e)
		{
			if (attachmentsListView.SelectedItems.Count == 0)
			{
				return;
			}
			string filenames = "";
			foreach (ListViewItem lvi in attachmentsListView.SelectedItems)
				filenames += lvi.Text + ", ";
			filenames = filenames.Substring (0, filenames.Length - 2);
			
			if (Common.MessageBox.Show (ResourceAccess.RA.RM.GetString("0005").Replace ("*", filenames)
				, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				foreach (ListViewItem lvi in attachmentsListView.SelectedItems)
				{
					Attachment a = tocentry.FindAttachmentByName (lvi.Text);
					if (a == null)
					{
						Common.MessageBox.Show ("unexpected error");
						return;
					}
			
					//a.Delete ();
					a.Status = Updater.Status.Deleted;
					if (tocentry.Status != Updater.Status.New)
						tocentry.Status = Updater.Status.Changed;
					//tocentry.Attachments.Remove (a);
					attachmentsListView.Items.Remove (lvi);
				}
			}
		}

		private void detailsButton_Click(object sender, System.EventArgs e)
		{
			attachmentsListView.View = View.Details;
		}

		private void listButton_Click(object sender, System.EventArgs e)
		{
			attachmentsListView.View = View.List;
		}

		private void smallIconButton_Click(object sender, System.EventArgs e)
		{
			attachmentsListView.View = View.SmallIcon;
		}

		private void largeIconButton_Click(object sender, System.EventArgs e)
		{
			attachmentsListView.View = View.LargeIcon;
		}

		private void renameMenuItem_Click(object sender, System.EventArgs e)
		{
			if (attachmentsListView.SelectedItems.Count == 0)
				return;
			attachmentsListView.SelectedItems[0].BeginEdit();
		}

		private void attachmentsListView_AfterLabelEdit(object sender, System.Windows.Forms.LabelEditEventArgs e)
		{
			Attachment a = tocentry.FindAttachmentByName (attachmentsListView.Items [e.Item].Text);
			if (a == null)
			{
				e.CancelEdit = true;
				return;
			}
			a.Rename (e.Label);
		}


	}
}
