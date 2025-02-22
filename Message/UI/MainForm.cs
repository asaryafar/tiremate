using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Message.Domain;
using Janus.Windows.GridEX;
using System.Threading;
namespace Message.UI
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : CommonClass.FrmBase
	{
		private Janus.Windows.EditControls.UIButton uiSend;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Panel panel1;
		private MirroredTreeView.MirroredTreeView foldersTreeView;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel2;
		private TreeNode inboxNode, sentNode;
		private Janus.Windows.EditControls.UIButton DeleteButton1;
		private Janus.Windows.EditControls.UIButton refreshButton;
		private Inbox inboxFolder;
		private AxSHDocVw.AxWebBrowser webMail;
		private Sent sentFolder;
		private User currentUser;
		private Company currComp;
		private string msgSender;
		private System.Windows.Forms.Panel panel3;
		private Janus.Windows.EditControls.UIButton uiButton1;
		private Janus.Windows.EditControls.UIButton OpenAttachmentButton;
		private Janus.Windows.EditControls.UIButton DisableButton;
		private ArrayList messageArray;		
		private string username;
		private System.Windows.Forms.ContextMenu mailContextMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private System.Windows.Forms.Splitter splitter2;
		private AxSHDocVw.AxWebBrowser webMail1;
		private string company;
		

		public MainForm()
		{
			//Thread.CurrentThread.CurrentUICulture =  new System.Globalization.CultureInfo("fa-IR",false);
			InitializeComponent();


			
			inboxNode = foldersTreeView.Nodes[0];
			sentNode = foldersTreeView.Nodes[1];
		}

		public string MsgSender
		{
			get{return msgSender;}
			set{ msgSender = value;}
		}

		public MainForm(string _msgSender)
		{

			InitializeComponent();

			msgSender = _msgSender;

			inboxNode = foldersTreeView.Nodes[0];
			sentNode = foldersTreeView.Nodes[1];
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.uiSend = new Janus.Windows.EditControls.UIButton();
			this.refreshButton = new Janus.Windows.EditControls.UIButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.webMail1 = new AxSHDocVw.AxWebBrowser();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.mailContextMenu = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.panel6 = new System.Windows.Forms.Panel();
			this.uiButton1 = new Janus.Windows.EditControls.UIButton();
			this.OpenAttachmentButton = new Janus.Windows.EditControls.UIButton();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.foldersTreeView = new MirroredTreeView.MirroredTreeView();
			this.webMail = new AxSHDocVw.AxWebBrowser();
			this.DisableButton = new Janus.Windows.EditControls.UIButton();
			this.DeleteButton1 = new Janus.Windows.EditControls.UIButton();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.webMail1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.webMail)).BeginInit();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// uiSend
			// 
			this.uiSend.Location = new System.Drawing.Point(24, 16);
			this.uiSend.Name = "uiSend";
			this.uiSend.Size = new System.Drawing.Size(75, 75);
			this.uiSend.TabIndex = 0;
			this.uiSend.Text = "Compose";
			this.uiSend.Click += new System.EventHandler(this.uiSend_Click);
			// 
			// refreshButton
			// 
			this.refreshButton.Location = new System.Drawing.Point(144, 16);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(75, 75);
			this.refreshButton.TabIndex = 1;
			this.refreshButton.Text = "Refresh";
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.splitter1);
			this.panel1.Controls.Add(this.foldersTreeView);
			this.panel1.Location = new System.Drawing.Point(8, 104);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(960, 552);
			this.panel1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Location = new System.Drawing.Point(124, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(836, 552);
			this.panel2.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.splitter2);
			this.panel3.Controls.Add(this.webMail1);
			this.panel3.Controls.Add(this.gridEX1);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(836, 512);
			this.panel3.TabIndex = 9;
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter2.Location = new System.Drawing.Point(0, 200);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(836, 3);
			this.splitter2.TabIndex = 18;
			this.splitter2.TabStop = false;
			// 
			// webMail1
			// 
			this.webMail1.ContainingControl = this;
			this.webMail1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webMail1.Enabled = true;
			this.webMail1.Location = new System.Drawing.Point(0, 200);
			this.webMail1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("webMail1.OcxState")));
			this.webMail1.Size = new System.Drawing.Size(836, 312);
			this.webMail1.TabIndex = 9;
			// 
			// gridEX1
			// 
			this.gridEX1.AlternatingColors = true;
			this.gridEX1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(244)), ((System.Byte)(242)), ((System.Byte)(255)));
			this.gridEX1.ContextMenu = this.mailContextMenu;
			this.gridEX1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gridEX1.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.gridEX1.GroupByBoxVisible = false;
			this.gridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.gridEX1.Location = new System.Drawing.Point(0, 0);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.gridEX1.SelectedFormatStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.gridEX1.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.gridEX1.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
			this.gridEX1.Size = new System.Drawing.Size(836, 200);
			this.gridEX1.TabIndex = 17;
			this.gridEX1.TreeLineColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.gridEX1.TreeLines = false;
			this.gridEX1.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.gridEX1_RowDoubleClick);
			this.gridEX1.SelectionChanged += new System.EventHandler(this.gridEX1_SelectionChanged);
			this.gridEX1.ColumnHeaderClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.gridEX1_ColumnHeaderClick);
			// 
			// mailContextMenu
			// 
			this.mailContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.menuItem1,
																							this.menuItem2,
																							this.menuItem3,
																							this.menuItem4});
			this.mailContextMenu.Popup += new System.EventHandler(this.mailContextMenu_Popup);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "Delete";
			this.menuItem1.Click += new System.EventHandler(this.Delete_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "Disable";
			this.menuItem2.Click += new System.EventHandler(this.disableMenu_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "Open Attachment";
			this.menuItem3.Click += new System.EventHandler(this.openAttachmentMenu_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 3;
			this.menuItem4.Text = "Refresh";
			this.menuItem4.Click += new System.EventHandler(this.refreshMenu_Click);
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(201)), ((System.Byte)(197)), ((System.Byte)(254)));
			this.panel6.Controls.Add(this.uiButton1);
			this.panel6.Controls.Add(this.OpenAttachmentButton);
			this.panel6.Location = new System.Drawing.Point(0, 520);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(836, 32);
			this.panel6.TabIndex = 16;
			// 
			// uiButton1
			// 
			this.uiButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.uiButton1.Enabled = false;
			this.uiButton1.Location = new System.Drawing.Point(728, 0);
			this.uiButton1.Name = "uiButton1";
			this.uiButton1.Size = new System.Drawing.Size(104, 30);
			this.uiButton1.TabIndex = 12;
			this.uiButton1.Text = "Delete";
			this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
			// 
			// OpenAttachmentButton
			// 
			this.OpenAttachmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.OpenAttachmentButton.Location = new System.Drawing.Point(8, 0);
			this.OpenAttachmentButton.Name = "OpenAttachmentButton";
			this.OpenAttachmentButton.Size = new System.Drawing.Size(104, 30);
			this.OpenAttachmentButton.TabIndex = 15;
			this.OpenAttachmentButton.Text = "Open Attachments";
			this.OpenAttachmentButton.Click += new System.EventHandler(this.OpenAttachmentButton_Click);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(121, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 552);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// foldersTreeView
			// 
			this.foldersTreeView.Dock = System.Windows.Forms.DockStyle.Left;
			this.foldersTreeView.ImageIndex = -1;
			this.foldersTreeView.Location = new System.Drawing.Point(0, 0);
			this.foldersTreeView.Name = "foldersTreeView";
			this.foldersTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
																						new System.Windows.Forms.TreeNode("Inbox"),
																						new System.Windows.Forms.TreeNode("Sent Items")});
			this.foldersTreeView.SelectedImageIndex = -1;
			this.foldersTreeView.Size = new System.Drawing.Size(121, 552);
			this.foldersTreeView.TabIndex = 0;
			this.foldersTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.foldersTreeView_AfterSelect_1);
			// 
			// webMail
			// 
			this.webMail.ContainingControl = this;
			this.webMail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webMail.Enabled = true;
			this.webMail.Location = new System.Drawing.Point(0, 0);
			this.webMail.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("webMail.OcxState")));
			this.webMail.Size = new System.Drawing.Size(832, 220);
			this.webMail.TabIndex = 8;
			// 
			// DisableButton
			// 
			this.DisableButton.Enabled = false;
			this.DisableButton.Location = new System.Drawing.Point(320, 16);
			this.DisableButton.Name = "DisableButton";
			this.DisableButton.Size = new System.Drawing.Size(75, 75);
			this.DisableButton.TabIndex = 13;
			this.DisableButton.Text = "Disable";
			this.DisableButton.Click += new System.EventHandler(this.DisableButton_Click);
			// 
			// DeleteButton1
			// 
			this.DeleteButton1.Location = new System.Drawing.Point(232, 16);
			this.DeleteButton1.Name = "DeleteButton1";
			this.DeleteButton1.Size = new System.Drawing.Size(75, 75);
			this.DeleteButton1.TabIndex = 5;
			this.DeleteButton1.Text = "Delete";
			this.DeleteButton1.Click += new System.EventHandler(this.DeleteButton1_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 600000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.uiSend);
			this.panel5.Controls.Add(this.DisableButton);
			this.panel5.Controls.Add(this.DeleteButton1);
			this.panel5.Controls.Add(this.refreshButton);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(974, 104);
			this.panel5.TabIndex = 14;
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(201)), ((System.Byte)(197)), ((System.Byte)(254)));
			this.ClientSize = new System.Drawing.Size(974, 660);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.MaximizeBox = true;
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Inbox";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.webMail1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.webMail)).EndInit();
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{

			Application.Run(new MainForm("user"));
		}


		
		private void uiSend_Click(object sender, System.EventArgs e)
		{
			if(msgSender == "user")
			{
				
				currentUser = new User();
			

				currentUser.fillUserInfo(username);
			

				SendForm snd = new SendForm(currentUser);
			
				snd.ShowDialog();
			}
			else
			{
				currComp = new Company();
				currComp.fillCompanyInfo(company);

				SendForm snd = new SendForm(currComp);
			
				snd.ShowDialog();

			}
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			 User t1 = new User();
			Company t2 = new Company();

			t1.fillUserInfo(Convert.ToInt32( CommonClass.MainModule.PUserCod));
			t2.fillCompanyInfo(Convert.ToInt32( CommonClass.MainModule.PubStoreNO));
			username = t1.Login;
			company = t2.CompanyShortName;

			DisableButton.Enabled = false;
			OpenAttachmentButton.Visible = false;
			
			this.Text = t1.FirstName +" "+t1.LastName + " : " +  t2.CompanyShortName + " - Messages";
			timer1.Start();

		}


		private void foldersTreeView_AfterSelect_1(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			OpenAttachmentButton.Enabled = false;
			uiButton1.Enabled = false;

			if(msgSender == "user")
			{
				currentUser = new User();

				currentUser.fillUserInfo(username);
				if(e.Node == inboxNode)
				{
					fillInbox();
					DisableButton.Enabled = false;
					OpenAttachmentButton.Visible = true;
					uiButton1.Visible = true;
				
				}
				else if ( e.Node == sentNode)
				{
					fillSent();
					DisableButton.Enabled = true;
					OpenAttachmentButton.Visible = true;
					uiButton1.Visible = true;
				}
			}
			else
			{
				currComp = new Company();

				currComp.fillCompanyInfo(company);
				if(e.Node == inboxNode)
				{
					fillInbox();
					DisableButton.Enabled = false;

					OpenAttachmentButton.Visible = true;
					uiButton1.Visible = true;
				}
				else if ( e.Node == sentNode)
				{
					fillSent();
					DisableButton.Enabled = true;
					OpenAttachmentButton.Visible = true;
					uiButton1.Visible = true;
				}
			}
		}
		private void saveAttachments(MessageInfo mi)
		{
			if(!Directory.Exists("Attachments"))
				Directory.CreateDirectory("Attachments");

				string path = "Attachments\\Message"+mi.MsgId;
				Directory.CreateDirectory(path);
				
				foreach(Attachment att in mi.FileAttachments)
				{
					string filename = path+"\\"+ att.FileName;
					att.FilePath = filename;
					FileStream fs = File.Create(filename);
					fs.Write(att.AttachedFile.Value,0,att.AttachedFile.Length);
				}
				
			
			
		}
		private void fillInbox()
		{
			if(msgSender == "user")
				inboxFolder = new Inbox(currentUser);
			else
				inboxFolder = new Inbox(currComp);

			messageArray = inboxFolder.getMessages();
			
			DataTable InboxDT = new DataTable();
			InboxDT.Columns.Add("Checked", typeof(bool));
			InboxDT.Columns.Add("AttachedFiles",typeof (Attachment));
			InboxDT.Columns.Add("AttachmentIcon", typeof (Bitmap));
			InboxDT.Columns.Add("From");
			InboxDT.Columns.Add("Subject");
			InboxDT.Columns.Add("Received");
			InboxDT.Columns.Add("Body");

		
			InboxDT.Columns.Add("msgId", typeof (Guid));

			FileStream fs = new FileStream(CommonClass.MainModule.PLogo,FileMode.Open);
			foreach( MessageInfo mi in messageArray)
			{

				DataRow inboxRow = InboxDT.NewRow();
				inboxRow["Checked"] = false;
				/*if(mi.From.Login == "")
					inboxRow["From"] = mi.From.CompanyInfo.CompanyName+", "+mi.From.CompanyInfo.CompanyShortName;
				else
				*/
				if(msgSender == "user")
					inboxRow["From"] = mi.SenderUser.FirstName + " "+ mi.SenderUser.LastName;
				else
					inboxRow["From"] = mi.SenderComp.CompanyShortName;
				inboxRow["Subject"] = mi.Subject;
				inboxRow["Received"] =   mi.Received;
				inboxRow["Body"] = mi.Body;
				inboxRow["msgId"]= mi.MsgId;
				inboxRow["AttachedFiles"] = mi.FileAttachments;
				if(mi.FileAttachments.Count>0)
					inboxRow["AttachmentIcon"] = new Bitmap(fs);
				InboxDT.Rows.Add(inboxRow); 

				
			}
			gridEX1.ColumnAutoResize = true;
			gridEX1.SetDataBinding(InboxDT,"");
			gridEX1.RetrieveStructure();

			initializeInboxGrid();
			fs.Close();
			
		}
		private void initializeInboxGrid()
		{
			gridEX1.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
			gridEX1.RootTable.Columns["Checked"].Caption = "";
			
			gridEX1.CellSelectionMode = CellSelectionMode.EntireRow;
			gridEX1.RootTable.Columns["From"].Selectable = false;
			gridEX1.RootTable.Columns["Subject"].Selectable = false;
			gridEX1.RootTable.Columns["Received"].Selectable = false;
			gridEX1.RootTable.Columns["AttachedFiles"].Visible = false;
			gridEX1.RootTable.Columns["Body"].Visible = false;
			gridEX1.RootTable.Columns["msgId"].Visible = false;
			/*FileStream fs = new FileStream("product.bmp",FileMode.Open);
			Bitmap bt = new System.Drawing.Bitmap(fs);
			fs.Close();
				
			gridEX1.RootTable.Columns["AttachmentIcon"].Image = bt;*/
			//gridEX1.AutoSizeColumns();

			gridEX1.RootTable.Columns["Checked"].Width = 0;
			gridEX1.RootTable.Columns["AttachmentIcon"].Width= 17;	
			gridEX1.RootTable.Columns["AttachmentIcon"].AllowSize = false;
			//gridEX1.RootTable.Columns["From"].AutoSize();
			//gridEX1.RootTable.Columns["Subject"].AutoSize();
			//gridEX1.RootTable.Columns["Received"].AutoSize();
			

			gridEX1.RootTable.Columns["AttachmentIcon"].Caption = "";
			gridEX1.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
		
			//gridEX1.RootTable.Columns["AttachmentIcon"].ButtonStyle = Janus.Windows.GridEX.ButtonStyle.ButtonCell;
			//gridEX1.ColumnButtonClick +=new ColumnActionEventHandler(gridEX1_ColumnButtonClick);
			
			
		}

		private void fillSent()
		{
			if(msgSender == "user")
                sentFolder = new Sent(currentUser);
			else
				sentFolder = new Sent(currComp);
				
			messageArray = sentFolder.getMessages();
			DataSet sentItems = buildSentDataSet(messageArray);
			gridEX1.SetDataBinding(sentItems,sentItems.Tables[0].TableName);
			gridEX1.Hierarchical = true;
			gridEX1.RetrieveStructure(true);  			
			initializeSentItemsGrid();

		}	
		private void initializeSentItemsGrid()
		{

			gridEX1.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
			gridEX1.RootTable.Columns["MsgId"].Visible = false;
			gridEX1.RootTable.ChildTables[0].Columns["MsgId"].Visible = false;
			gridEX1.RootTable.Columns["Body"].Visible = false;
			gridEX1.RootTable.Columns["From"].Visible = false;
			gridEX1.RootTable.Columns["AttachedFiles"].Visible = false;
			if(msgSender =="company")
				gridEX1.Tables[0].ChildTables[0].Columns["compcode"].Visible = false;
			else
				gridEX1.Tables[0].ChildTables[0].Columns["usercode"].Visible = false;

			//gridEX1.Tables[0].ChildTables[0].Columns["sqlconnection"].Visible = false;

			//gridEX1.AutoSizeColumns();
			gridEX1.RootTable.Columns["Checked"].Caption = "";
			gridEX1.RootTable.Columns["Checked"].Width = 5;
			

			gridEX1.RootTable.Columns["AttachmentIcon"].Caption = "";
			gridEX1.RootTable.Columns["AttachmentIcon"].Width = 17;
			gridEX1.RootTable.Columns["AttachmentIcon"].AllowSize = false;
			gridEX1.RootTable.Columns["AttachmentIcon"].SelectableCells = Janus.Windows.GridEX.SelectableCells.None;

			gridEX1.RootTable.Columns["Subject"].Caption = "Subject";
			//gridEX1.RootTable.Columns["Subject"].Width = 10;
			gridEX1.RootTable.Columns["Subject"].SelectableCells = Janus.Windows.GridEX.SelectableCells.None;

			gridEX1.Tables[0].Columns["CreationDate"].Caption = "Creation Date";
			gridEX1.Tables[0].Columns["CreationDate"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
			gridEX1.Tables[0].Columns["CreationDate"].SelectableCells = Janus.Windows.GridEX.SelectableCells.None;

			gridEX1.Tables[0].ChildTables[0].Columns["ActivationDate"].Caption = "Activation Date";
			gridEX1.Tables[0].ChildTables[0].Columns["ActivationDate"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
			gridEX1.Tables[0].ChildTables[0].Columns["ActivationDate"].SelectableCells = Janus.Windows.GridEX.SelectableCells.None;

			gridEX1.Tables[0].ChildTables[0].Columns["VisitDate"].Caption = "Visit Date";
			gridEX1.Tables[0].ChildTables[0].Columns["VisitDate"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
			gridEX1.Tables[0].ChildTables[0].Columns["VisitDate"].SelectableCells = Janus.Windows.GridEX.SelectableCells.None;

			gridEX1.RootTable.ChildTables[0].Columns["LastFlag"].Caption = "Message Status";
			gridEX1.RootTable.ChildTables[0].Columns["LastFlag"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
			gridEX1.RootTable.ChildTables[0].Columns["LastFlag"].SelectableCells = Janus.Windows.GridEX.SelectableCells.None;


			gridEX1.RootTable.ChildTables[0].Columns["Disable"].Caption = "Disable";
			gridEX1.RootTable.ChildTables[0].Columns["Disable"].SelectableCells = Janus.Windows.GridEX.SelectableCells.RowCells;
			
/*			gridEX1.Tables[0].ChildTables[0].Columns["ActivationDate"].FilterEditType = 
				Janus.Windows.GridEX.FilterEditType.TextBox;
			gridEX1.Tables[0].ChildTables[0].Columns["ActivationDate"].SelectableCells = 
				Janus.Windows.GridEX.SelectableCells.FilterRowCells;
*/
			gridEX1.Tables[0].ChildTables[0].Columns["To"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
			gridEX1.Tables[0].ChildTables[0].Columns["To"].SelectableCells = Janus.Windows.GridEX.SelectableCells.None;
		

			
			
		}
		private DataSet buildSentDataSet(ArrayList msgs)
		{
			DataTable parentTable = new DataTable("parent");
			
			parentTable.Columns.Add("Checked",typeof (bool));
			parentTable.Columns.Add("MsgId",typeof (Guid));
			parentTable.Columns.Add("AttachmentIcon", typeof (Bitmap));
			parentTable.Columns.Add("AttachedFiles",typeof (Attachment));		
			parentTable.Columns.Add("Subject",typeof (string));
			parentTable.Columns.Add("From",typeof (string));
			parentTable.Columns.Add("Body",typeof (string));
			
			
			
			parentTable.Columns.Add("CreationDate",typeof (string));


			DataTable childTable = new DataTable("child");
			childTable.Columns.Add("MsgId",typeof (Guid));
			childTable.Columns.Add("To",typeof (string));
			childTable.Columns.Add("ActivationDate",typeof (string));
			childTable.Columns.Add("VisitDate",typeof (string));
			childTable.Columns.Add("LastFlag");
			childTable.Columns.Add("Disable",typeof (bool));
			//childTable.Columns.Add("sqlconnection");
			if(msgSender == "company")
				childTable.Columns.Add("compcode",typeof (int));
			else
				childTable.Columns.Add("usercode",typeof (int));


			   FileStream fs = new FileStream(CommonClass.MainModule.PLogo,FileMode.Open);
				
			foreach(MessageInfo mi in msgs)
			{
				DataRow parentRow = parentTable.NewRow();
				parentRow["Checked"]= false;
				parentRow["MsgId"]=mi.MsgId;
				parentRow ["From"]=( msgSender == "user" ? (currentUser.FirstName +" " + currentUser.LastName) : currComp.CompanyShortName);
				parentRow["Body"]= mi.Body;
				parentRow["Subject"] = mi.Subject;
				if(mi.FileAttachments.Count>0)
					parentRow["AttachmentIcon"] = new Bitmap(fs);
				parentRow["AttachedFiles"] = mi.FileAttachments;
				parentRow["CreationDate"] = mi.CreationDate.ToString();

				parentTable.Rows.Add(parentRow);
				foreach(SendInfo si in mi.SendInformation)
				{
					DataRow childRow = childTable.NewRow();
					childRow["MsgId"]=mi.MsgId;
					childRow["To"] = ((msgSender == "user") ?si.DestUser.FirstName+" "+si.DestUser.LastName : si.DestCompany.CompanyShortName);
					childRow["ActivationDate"] = si.ActivationDate.ToString();
					if(si.VisitDate.Equals(new DateTime(1,1,1)))
					{
						childRow["VisitDate"] = "Not Visited";
						
					}
					else
					{
						childRow["VisitDate"] = si.VisitDate.ToString();
						
					}
					if(si.LastFlag == false)
					{
						childRow["LastFlag"] = "Enabled";
					}
					else
					{
						childRow["LastFlag"] = "Disabled";
					}
					if(msgSender == "company")
					{
						//childRow["sqlconnection"] = si.DestCompany.SqlConnection;
						childRow["compcode"] = si.DestCompany.Code;
					}
					else

					{
						childRow["usercode"] = si.DestUser.Code;
					}
					childTable.Rows.Add(childRow);
				}
			}
			
			DataRelation dtRelation = new DataRelation("SentMessage",parentTable.Columns["MsgId"],childTable.Columns["MsgId"]);
			DataSet tmp = new DataSet();
			tmp.Tables.Add(parentTable);
			tmp.Tables.Add(childTable);
			tmp.Relations.Add(dtRelation);
			fs.Close();
			return tmp;
		}
		
		private void showMessage(string body)
		{
			FileStream ifn = new FileStream("e:\\fate.htm",System.IO.FileMode.Create,System.IO.FileAccess.Write);
			StreamWriter str = new StreamWriter(ifn);
			str.Write(body);
			str.Close();
			ifn.Close();
			
			object empty = null;
			string tt = "e:\\fate.htm";
			webMail1.Navigate(tt, ref empty, ref empty, ref empty, ref empty);
			uiButton1.Enabled = true;
		
		}
		
		private void gridEX1_SelectionChanged(object sender, System.EventArgs  e)
		{	
			OpenAttachmentButton.Enabled = false;
			uiButton1.Enabled = false;
			if(gridEX1.SelectedItems[0].Table.Caption == "SentMessage")
			{
				/*
				Guid msgid =(Guid) gridEX1.GetValue("MsgId");
				DataTable dt =((DataSet) gridEX1.DataSource).Tables[0];
				DataRow[] currRows = dt.Select(null,null,DataViewRowState.CurrentRows);
				string Body= "";
				foreach(DataRow dr in currRows)
				{
					if((Guid)dr["MsgId"] == msgid)
					{
						Body = (string) dr["Body"];
					}
				}

				*/
				GridEXRow r = gridEX1.SelectedItems[0].GetRow();
				string Body = (string)r.Parent.Cells["Body"].Text;
				if(r.Parent.Cells["AttachedFiles"].Value != null && 
					((ArrayList) r.Parent.Cells["AttachedFiles"].Value).Count >0)
					OpenAttachmentButton.Enabled = true;

				showMessage(Body);
			}
			else
			{
				showMessage((string)gridEX1.GetValue("Body"));
			//if( gridEX1.GetValue("Attachments") != null  )
			//	{
				 
				if (gridEX1.GetValue("AttachedFiles") != DBNull.Value)
				{
					if(((ArrayList) gridEX1.GetValue("AttachedFiles")).Count ==  0)

						OpenAttachmentButton.Enabled = false;
					else
						OpenAttachmentButton.Enabled = true;
					//	}
				}
			}
			



		}


		private void DeleteButton1_Click(object sender, System.EventArgs e)
		{
			if(foldersTreeView.SelectedNode == inboxNode)
			{
				for(int i = 0; i < gridEX1.RowCount; i++)
				{
					gridEX1.Row = i;
					if((bool)gridEX1.GetValue("Checked") == true)
						inboxFolder.DeleteMessage((Guid)gridEX1.GetValue("msgId"));
				}
				fillInbox();
				
			}
			else if(foldersTreeView.SelectedNode == sentNode)
			{
				for(int i = 0; i < gridEX1.RowCount; i++)
				{
					gridEX1.Row = i;
					if(gridEX1.SelectedItems[0].Table.Caption == "parent" && (bool)gridEX1.GetValue("Checked") == true)
						sentFolder.deleteMessage((Guid)gridEX1.GetValue("msgId"));
				}
				fillSent();
			}
				
		}

		private void refreshButton_Click(object sender, System.EventArgs e)
		{
			Object obj = null;
			object url = "about:blank";
			OpenAttachmentButton.Enabled = false;
			uiButton1.Enabled = false;
			webMail1.Navigate2(ref url, ref obj, ref obj, ref obj, ref obj);
			
			if(foldersTreeView.SelectedNode == inboxNode)
				fillInbox();
			else if(foldersTreeView.SelectedNode == sentNode)
				fillSent();
		}

	/*	private void DisableButton_Click(object sender, System.EventArgs e)
		{
		
				Guid msgid =(Guid) gridEX1.GetValue("MsgId");
			DataTable dt =((DataSet) gridEX1.DataSource).Tables[1];
			DataRow[] currRows = dt.Select(null,null,DataViewRowState.CurrentRows);
			ArrayList er = new ArrayList();
			ArrayList already = new ArrayList();
			ArrayList disabled = new ArrayList();
			foreach(DataRow dr in currRows)
			{
				if(((Guid)dr["MsgId"]).Equals(msgid)  )
				{
					if(((string) dr["VisitDate"]) == "Not Visited")
					{
						if((string) dr["LastFlag"] != "Disabled")
						{
							if(dr["Disable"] != DBNull.Value && (bool) dr["Disable"] == true)
							{
								if(msgSender == "user")
									sentFolder.deleteMessageFromServer(msgid,(int) dr["usercode"]);
								else
									sentFolder.deleteMessageFromServer(msgid,(int) dr["compcode"]);
								disabled.Add(dr["To"]);
							}
						}
						else
						{
							if(dr["Disable"] != DBNull.Value && (bool) dr["Disable"] == true)
								already.Add(dr["To"]);
						}
					}
					else
					{	if(dr["Disable"] != DBNull.Value && (bool) dr["Disable"] == true)
							er.Add(dr["To"]);
					}
				}
			}
			string msg ="";
			if( already.Count == 1)
			{
				msg += "Message to" ;
				foreach(string t in already)
				{
					msg +=" "+t+",";
				}
				msg = msg.Remove(msg.Length-1,1);
				msg += " has already been disabled.";
			}
			else if (already.Count > 1)
			{
				msg += "Messages to" ;
				foreach(string t in already)
				{
					msg +=" "+t+",";
				}
				msg = msg.Remove(msg.Length-1,1);
				msg += " have already been disabled.";
			}

			if( er.Count == 1 )
			{
				msg += "Message to";
				foreach (string t in er)
				{
					msg +=" "+t+",";
				}
				msg = msg.Remove(msg.Length-1,1);
				msg += " couldn't be disabled.";
			}
			else if (er.Count >1)
			{
				msg += "Messages to";
				foreach (string t in er)
				{
					msg +=" "+t+",";
				}
				msg = msg.Remove(msg.Length-1,1);
				msg += " couldn't be disabled.";
			}

			if( disabled.Count == 1 )
			{
				msg += "Message to";
				foreach (string t in disabled)
				{
					msg +=" "+t+",";
				}
				msg = msg.Remove(msg.Length-1,1);
				msg += " has been disabled successfully.";
			}
			else if (disabled.Count >1)
			{
				msg += "Messages to";
				foreach (string t in disabled)
				{
					msg +=" "+t+",";
				}
				msg = msg.Remove(msg.Length-1,1);
				msg += " have been disabled successfully.";
			}
			if (msg == "")
				msg = "Please choose a message to disable.";
			MessageBox.Show(msg);

			if(foldersTreeView.SelectedNode == inboxNode)
				fillInbox();
			else
				fillSent();
			

		}*/
		private void DisableButton_Click(object sender, System.EventArgs e)
		{
			//Guid msgid =(Guid) gridEX1.GetValue("MsgId");
			DataTable dt =((DataSet) gridEX1.DataSource).Tables[1];
			DataRow[] currRows = dt.Select(null,null,DataViewRowState.CurrentRows);
			ArrayList er = new ArrayList();
			ArrayList already = new ArrayList();
			ArrayList disabled = new ArrayList();
			foreach(DataRow dr in currRows)
			{
				if( true )
				{
					if(((string) dr["VisitDate"]) == "Not Visited")
					{
						if((string) dr["LastFlag"] != "Disabled")
						{
							if(dr["Disable"] != DBNull.Value && (bool) dr["Disable"] == true)
							{
								if(msgSender == "user")
									sentFolder.deleteMessageFromServer((Guid)dr["MsgId"],(int) dr["usercode"]);
								else
									sentFolder.deleteMessageFromServer((Guid)dr["MsgId"],(int) dr["compcode"]);
								disabled.Add(dr["To"]);
							}
						}
						else
						{
							if(dr["Disable"] != DBNull.Value && (bool) dr["Disable"] == true)
								already.Add(dr["To"]);
						}
					}
					else
					{	if(dr["Disable"] != DBNull.Value && (bool) dr["Disable"] == true)
							er.Add(dr["To"]);
					}
				}
			}
			string msg ="";
			if( already.Count == 1)
			{
				msg += "Message to" ;
				foreach(string t in already)
				{
					msg +=" "+t+",";
				}
				msg = msg.Remove(msg.Length-1,1);
				msg += " has already been disabled.";
			}
			else if (already.Count > 1)
			{
				msg += "Messages to" ;
				foreach(string t in already)
				{
					msg +=" "+t+",";
				}
				msg = msg.Remove(msg.Length-1,1);
				msg += " have already been disabled.";
			}

			if( er.Count == 1 )
			{
				msg += "Message to";
				foreach (string t in er)
				{
					msg +=" "+t+",";
				}
				msg = msg.Remove(msg.Length-1,1);
				msg += " can not be disabled.";
			}
			else if (er.Count >1)
			{
				msg += "Messages to";
				foreach (string t in er)
				{
					msg +=" "+t+",";
				}
				msg = msg.Remove(msg.Length-1,1);
				msg += "can not be disabled.";
			}

			if( disabled.Count == 1 )
			{
				msg += "Message to";
				foreach (string t in disabled)
				{
					msg +=" "+t+",";
				}
				msg = msg.Remove(msg.Length-1,1);
				msg += " has been disabled successfully.";
			}
			else if (disabled.Count >1)
			{
				msg += "Messages to";
				foreach (string t in disabled)
				{
					msg +=" "+t+",";
				}
				msg = msg.Remove(msg.Length-1,1);
				msg += " have been disabled successfully.";
			}
			if (msg == "")
				msg = "Please choose a message to disable.";
			MessageBox.Show(msg);

			if(foldersTreeView.SelectedNode == inboxNode)
				fillInbox();
			else if(foldersTreeView.SelectedNode == sentNode)
				fillSent();
			

		}

		private void OpenAttachmentButton_Click(object sender, System.EventArgs e)
		{
			AttachmentForm af = new AttachmentForm(gridEX1.GetValue("AttachedFiles"));
			af.AddButtonVisible = false;
			af.DeleteButtonVisible = false;
			af.Show();
		}

		private void gridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			if((gridEX1.GetValue("AttachedFiles") as ArrayList).Count == 0)
				return;
			AttachmentForm af = new AttachmentForm(gridEX1.GetValue("AttachedFiles"));
			af.AddButtonVisible = false;
			af.DeleteButtonVisible = false;
			af.Show();

		}

		private void uiButton1_Click(object sender, System.EventArgs e)
		{
			if(foldersTreeView.SelectedNode == inboxNode)
			{
				//if((bool)gridEX1.GetValue("Checked") == true)
					inboxFolder.DeleteMessage((Guid)gridEX1.GetValue("msgId"));
				fillInbox();
			}
			else if(foldersTreeView.SelectedNode == sentNode)
			{
				//if(gridEX1.SelectedItems[0].Table.Caption == "parent" &&
			//										(bool)gridEX1.GetValue("Checked") == true)
					sentFolder.deleteMessage((Guid)gridEX1.GetValue("msgId"));
				fillSent();
			}
		}


		private void Delete_Click(object sender, System.EventArgs e)
		{
			if(foldersTreeView.SelectedNode == inboxNode)
			{
				showWarningMessageBox(1);
				inboxFolder.DeleteMessage((Guid)gridEX1.GetValue("msgId"));
				fillInbox();
			}
			else if(foldersTreeView.SelectedNode == sentNode)
			{
				
				showWarningMessageBox(1);
				sentFolder.deleteMessage((Guid)gridEX1.GetValue("msgId"));
								
				fillSent();
			}
		
		}

		
		private int showWarningMessageBox(int items)
		{
			string mes="";
			if (items == 1)
				mes = "Are you sure you want to delete this message?"; 
			string caption = "Confirm Delete";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result;

			result = MessageBox.Show(this, mes, caption, buttons);

			if(result == DialogResult.Yes)
			{
				return 1;
			}
			
			return 0;

		}
		
		private void mailContextMenu_Popup(object sender, System.EventArgs e)
		{
		
			if(foldersTreeView.SelectedNode == inboxNode)
			{
				//mailContextMenu.MenuItems[0].Enabled = true;
				mailContextMenu.MenuItems[1].Enabled = false;

			}
			else if(foldersTreeView.SelectedNode == sentNode)
			{
								
				mailContextMenu.MenuItems[1].Enabled = false;
				//mailContextMenu.MenuItems[0].Enabled = true;
				
				if(gridEX1.SelectedItems[0].Table.Caption == "SentMessage")
				{
						mailContextMenu.MenuItems[1].Enabled = true;
				//		mailContextMenu.MenuItems[0].Enabled = false;
				}

			}
			if(OpenAttachmentButton.Enabled == false)
				mailContextMenu.MenuItems[2].Enabled = false;
			else
				mailContextMenu.MenuItems[2].Enabled = true;
				
		}

		private void openAttachmentMenu_Click(object sender, System.EventArgs e)
		{
			if((gridEX1.GetValue("AttachedFiles") as ArrayList).Count == 0)
				return;
			AttachmentForm af = new AttachmentForm(gridEX1.GetValue("AttachedFiles"));
			af.AddButtonVisible = false;
			af.DeleteButtonVisible = false;
			af.Show();		
		}

		private void refreshMenu_Click(object sender, System.EventArgs e)
		{
			if(foldersTreeView.SelectedNode == inboxNode)
			{
				fillInbox();
			}
			else if(foldersTreeView.SelectedNode == sentNode)
			{
				fillSent();
			}
		}

		private void disableMenu_Click(object sender, System.EventArgs e)
		{
			
			bool disabled = false , already = false , er = false;

			if(((string) gridEX1.GetValue("VisitDate")) == "Not Visited")
			{
				if((string) gridEX1.GetValue("LastFlag") != "Disabled")
				{
					//if((bool) gridEX1.GetValue("Disable") == true)
					{
						if(msgSender == "user")
							sentFolder.deleteMessageFromServer((Guid)gridEX1.GetValue("MsgId"),(int) gridEX1.GetValue("usercode"));
						else
							sentFolder.deleteMessageFromServer((Guid)gridEX1.GetValue("MsgId"),(int) gridEX1.GetValue("compcode"));
						disabled = true;
					}
				}
				else
				{
					already = true;
				}
			}
			else
			{
				er = true;
			}

			if(er)
			{
				string mes = "Message To " + gridEX1.GetValue("To") + " can not be disabled";
				MessageBox.Show(mes);
			}

			if(already)
			{
				string mes = "Message To " + gridEX1.GetValue("To") + " has already been disabled";
				MessageBox.Show(mes);
			}

			if(disabled)
			{
				string mes = "Message To " + gridEX1.GetValue("To") + " has been disabled successfully";
				MessageBox.Show(mes);
			}
		}

		private void gridEX1_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
		{
			GridEXRow r;
			if(e.Row.Parent == null)
				r = e.Row;
			 else 
				r = e.Row.Parent;

			if(r.Cells["AttachedFiles"].Value != null &&  ((ArrayList)r.Cells["AttachedFiles"].Value).Count>0)
				openAttachmentMenu_Click(this,new System.EventArgs());
		}
		bool inboxcheck=false,sentcheck=false,sentdisable = false;
		
		private void gridEX1_ColumnHeaderClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			if(e.Column.Key == "Checked")
			{
			
				if(foldersTreeView.SelectedNode == inboxNode)
				{
					inboxcheck = !inboxcheck;				
					for(int i=0; i<gridEX1.RowCount;i++)
					{
						gridEX1.Row = i;
						gridEX1.SetValue("Checked", inboxcheck);

					}
					
				}
				else if(foldersTreeView.SelectedNode == sentNode)
				{
					sentcheck = !sentcheck;
					for(int i=0; i<gridEX1.RowCount;i++)
					{
						gridEX1.Row = i;
						if(gridEX1.SelectedItems[0].Table.Caption != "SentMessage" )
						
							gridEX1.SetValue("Checked", sentcheck);

					}
				}

			}
			else if(e.Column.Key == "Disable")
			{
				sentdisable = !sentdisable;

				for(int i=0; i<gridEX1.RowCount;i++)
				{
					gridEX1.Row = i;
					if(gridEX1.SelectedItems[0].Table.Caption == "SentMessage" )
					{
						if(gridEX1.GetValue("VisitDate") == "Not Visited" && gridEX1.GetValue("LastFlag") == "Enabled")
							gridEX1.SetValue("Disable", sentdisable);

					}
				}
			}

		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if(foldersTreeView.SelectedNode == inboxNode)
			{
				fillInbox();
			}
			else if(foldersTreeView.SelectedNode == sentNode)
			{
				fillInbox();
				fillSent();				
			}

		}



	}
}
