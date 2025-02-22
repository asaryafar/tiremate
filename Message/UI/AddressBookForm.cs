using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Janus.Windows.GridEX;
using Message.Domain;

namespace Message.UI
{
	/// <summary>
	/// Summary description for AddressBookForm.
	/// </summary>
	public class AddressBookForm : CommonClass.FrmBase
	{
		private Janus.Windows.EditControls.UIButton AddSelected;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private ArrayList SelectedItems;
		//private DataTable dt;
		private Janus.Windows.EditControls.UIButton CancelButton;
		private System.Windows.Forms.Panel panel2;
		private Janus.Windows.GridEX.GridEX namesList;
		private Janus.Windows.GridEX.GridEX companyList;
		Calendar.UcCalendar cc2; 
		private string msgSender;
		private ArrayList ll;
		private Janus.Windows.GridEX.EditControls.MaskedEditBox timeMaskedEditBox;
		private bool okButtonClick = false;

		public bool OkButtonClick
		{
			get { return okButtonClick; }
		}

		public AddressBookForm(string _sender,ArrayList selected)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			msgSender = _sender;
			if(selected !=null )
				ll = (ArrayList)selected.Clone();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AddressBookForm));
			Janus.Windows.GridEX.GridEXLayout gridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
			this.AddSelected = new Janus.Windows.EditControls.UIButton();
			this.CancelButton = new Janus.Windows.EditControls.UIButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.companyList = new Janus.Windows.GridEX.GridEX();
			this.namesList = new Janus.Windows.GridEX.GridEX();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.companyList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.namesList)).BeginInit();
			this.SuspendLayout();
			// 
			// AddSelected
			// 
			this.AddSelected.AccessibleDescription = resources.GetString("AddSelected.AccessibleDescription");
			this.AddSelected.AccessibleName = resources.GetString("AddSelected.AccessibleName");
			this.AddSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("AddSelected.Anchor")));
			this.AddSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddSelected.BackgroundImage")));
			this.AddSelected.DisabledImageIndex = ((int)(resources.GetObject("AddSelected.DisabledImageIndex")));
			this.AddSelected.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("AddSelected.Dock")));
			this.AddSelected.Enabled = ((bool)(resources.GetObject("AddSelected.Enabled")));
			this.AddSelected.Font = ((System.Drawing.Font)(resources.GetObject("AddSelected.Font")));
			this.AddSelected.HotImageIndex = ((int)(resources.GetObject("AddSelected.HotImageIndex")));
			this.AddSelected.ImageIndex = ((int)(resources.GetObject("AddSelected.ImageIndex")));
			this.AddSelected.ImageSize = ((System.Drawing.Size)(resources.GetObject("AddSelected.ImageSize")));
			this.AddSelected.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("AddSelected.ImeMode")));
			this.AddSelected.Location = ((System.Drawing.Point)(resources.GetObject("AddSelected.Location")));
			this.AddSelected.Name = "AddSelected";
			this.AddSelected.PressedImageIndex = ((int)(resources.GetObject("AddSelected.PressedImageIndex")));
			this.AddSelected.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("AddSelected.RightToLeft")));
			this.AddSelected.Size = ((System.Drawing.Size)(resources.GetObject("AddSelected.Size")));
			this.AddSelected.TabIndex = ((int)(resources.GetObject("AddSelected.TabIndex")));
			this.AddSelected.Text = resources.GetString("AddSelected.Text");
			this.AddSelected.TextHorizontalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("AddSelected.TextHorizontalAlignment")));
			this.AddSelected.TextVerticalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("AddSelected.TextVerticalAlignment")));
			this.AddSelected.UseThemes = ((bool)(resources.GetObject("AddSelected.UseThemes")));
			this.AddSelected.Visible = ((bool)(resources.GetObject("AddSelected.Visible")));
			this.AddSelected.VisualStyle = ((Janus.Windows.UI.VisualStyle)(resources.GetObject("AddSelected.VisualStyle")));
			this.AddSelected.Click += new System.EventHandler(this.AddSelected_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.AccessibleDescription = resources.GetString("CancelButton.AccessibleDescription");
			this.CancelButton.AccessibleName = resources.GetString("CancelButton.AccessibleName");
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("CancelButton.Anchor")));
			this.CancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelButton.BackgroundImage")));
			this.CancelButton.DisabledImageIndex = ((int)(resources.GetObject("CancelButton.DisabledImageIndex")));
			this.CancelButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("CancelButton.Dock")));
			this.CancelButton.Enabled = ((bool)(resources.GetObject("CancelButton.Enabled")));
			this.CancelButton.Font = ((System.Drawing.Font)(resources.GetObject("CancelButton.Font")));
			this.CancelButton.HotImageIndex = ((int)(resources.GetObject("CancelButton.HotImageIndex")));
			this.CancelButton.ImageIndex = ((int)(resources.GetObject("CancelButton.ImageIndex")));
			this.CancelButton.ImageSize = ((System.Drawing.Size)(resources.GetObject("CancelButton.ImageSize")));
			this.CancelButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("CancelButton.ImeMode")));
			this.CancelButton.Location = ((System.Drawing.Point)(resources.GetObject("CancelButton.Location")));
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.PressedImageIndex = ((int)(resources.GetObject("CancelButton.PressedImageIndex")));
			this.CancelButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("CancelButton.RightToLeft")));
			this.CancelButton.Size = ((System.Drawing.Size)(resources.GetObject("CancelButton.Size")));
			this.CancelButton.TabIndex = ((int)(resources.GetObject("CancelButton.TabIndex")));
			this.CancelButton.Text = resources.GetString("CancelButton.Text");
			this.CancelButton.TextHorizontalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("CancelButton.TextHorizontalAlignment")));
			this.CancelButton.TextVerticalAlignment = ((Janus.Windows.EditControls.TextAlignment)(resources.GetObject("CancelButton.TextVerticalAlignment")));
			this.CancelButton.UseThemes = ((bool)(resources.GetObject("CancelButton.UseThemes")));
			this.CancelButton.Visible = ((bool)(resources.GetObject("CancelButton.Visible")));
			this.CancelButton.VisualStyle = ((Janus.Windows.UI.VisualStyle)(resources.GetObject("CancelButton.VisualStyle")));
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// panel2
			// 
			this.panel2.AccessibleDescription = resources.GetString("panel2.AccessibleDescription");
			this.panel2.AccessibleName = resources.GetString("panel2.AccessibleName");
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel2.Anchor")));
			this.panel2.AutoScroll = ((bool)(resources.GetObject("panel2.AutoScroll")));
			this.panel2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMargin")));
			this.panel2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMinSize")));
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Controls.Add(this.companyList);
			this.panel2.Controls.Add(this.namesList);
			this.panel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel2.Dock")));
			this.panel2.Enabled = ((bool)(resources.GetObject("panel2.Enabled")));
			this.panel2.Font = ((System.Drawing.Font)(resources.GetObject("panel2.Font")));
			this.panel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel2.ImeMode")));
			this.panel2.Location = ((System.Drawing.Point)(resources.GetObject("panel2.Location")));
			this.panel2.Name = "panel2";
			this.panel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel2.RightToLeft")));
			this.panel2.Size = ((System.Drawing.Size)(resources.GetObject("panel2.Size")));
			this.panel2.TabIndex = ((int)(resources.GetObject("panel2.TabIndex")));
			this.panel2.Text = resources.GetString("panel2.Text");
			this.panel2.Visible = ((bool)(resources.GetObject("panel2.Visible")));
			// 
			// companyList
			// 
			this.companyList.AccessibleDescription = resources.GetString("companyList.AccessibleDescription");
			this.companyList.AccessibleName = resources.GetString("companyList.AccessibleName");
			this.companyList.AlternatingColors = true;
			this.companyList.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("companyList.Anchor")));
			this.companyList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("companyList.BackgroundImage")));
			this.companyList.BuiltInTextsData = resources.GetString("companyList.BuiltInTextsData");
			this.companyList.CardCaptionPrefix = resources.GetString("companyList.CardCaptionPrefix");
			this.companyList.ColumnAutoResize = true;
			this.companyList.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("companyList.Dock")));
			this.companyList.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.companyList.Enabled = ((bool)(resources.GetObject("companyList.Enabled")));
			this.companyList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.companyList.FilterRowInfoText = resources.GetString("companyList.FilterRowInfoText");
			this.companyList.Font = ((System.Drawing.Font)(resources.GetObject("companyList.Font")));
			this.companyList.GroupByBoxVisible = false;
			this.companyList.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("companyList.ImeMode")));
			this.companyList.Location = ((System.Drawing.Point)(resources.GetObject("companyList.Location")));
			this.companyList.Name = "companyList";
			this.companyList.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("companyList.RightToLeft")));
			this.companyList.Size = ((System.Drawing.Size)(resources.GetObject("companyList.Size")));
			this.companyList.TabIndex = ((int)(resources.GetObject("companyList.TabIndex")));
			this.companyList.Visible = ((bool)(resources.GetObject("companyList.Visible")));
			this.companyList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
			this.companyList.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.companyList_RowDoubleClick);
			this.companyList.EndCustomEdit += new Janus.Windows.GridEX.EndCustomEditEventHandler(this.companyList_EndCustomEdit);
			this.companyList.ColumnHeaderClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.companyList_ColumnHeaderClick);
			this.companyList.InitCustomEdit += new Janus.Windows.GridEX.InitCustomEditEventHandler(this.companyList_InitCustomEdit);
			// 
			// namesList
			// 
			this.namesList.AccessibleDescription = resources.GetString("namesList.AccessibleDescription");
			this.namesList.AccessibleName = resources.GetString("namesList.AccessibleName");
			this.namesList.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("namesList.Anchor")));
			this.namesList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("namesList.BackgroundImage")));
			this.namesList.BuiltInTextsData = resources.GetString("namesList.BuiltInTextsData");
			this.namesList.CardCaptionPrefix = resources.GetString("namesList.CardCaptionPrefix");
			this.namesList.ColumnAutoResize = true;
			gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
			this.namesList.DesignTimeLayout = gridEXLayout1;
			this.namesList.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("namesList.Dock")));
			this.namesList.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.namesList.Enabled = ((bool)(resources.GetObject("namesList.Enabled")));
			this.namesList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.namesList.FilterRowInfoText = resources.GetString("namesList.FilterRowInfoText");
			this.namesList.Font = ((System.Drawing.Font)(resources.GetObject("namesList.Font")));
			this.namesList.GroupByBoxVisible = false;
			this.namesList.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("namesList.ImeMode")));
			this.namesList.Location = ((System.Drawing.Point)(resources.GetObject("namesList.Location")));
			this.namesList.Name = "namesList";
			this.namesList.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("namesList.RightToLeft")));
			this.namesList.Size = ((System.Drawing.Size)(resources.GetObject("namesList.Size")));
			this.namesList.TabIndex = ((int)(resources.GetObject("namesList.TabIndex")));
			this.namesList.Visible = ((bool)(resources.GetObject("namesList.Visible")));
			this.namesList.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.namesList_RowDoubleClick);
			this.namesList.EndCustomEdit += new Janus.Windows.GridEX.EndCustomEditEventHandler(this.namesList_EndCustomEdit);
			this.namesList.ColumnHeaderClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.namesList_ColumnHeaderClick);
			this.namesList.InitCustomEdit += new Janus.Windows.GridEX.InitCustomEditEventHandler(this.namesList_InitCustomEdit);
			// 
			// AddressBookForm
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
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.AddSelected);
			this.Controls.Add(this.panel2);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximizeBox = true;
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "AddressBookForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.Load += new System.EventHandler(this.AddressBookForm_Load);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.companyList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.namesList)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void AddressBookForm_Load(object sender, System.EventArgs e)
		{
			if(msgSender == "company")
			{
				namesList.Visible = false;
				LoadCompanyList();
				
			}
			else
			{
				companyList.Visible = false;
				LoadUserList();
			}
		}

		private void LoadUserList()
		{
			cc2 = new Calendar.UcCalendar ();
			UsersList usr = new UsersList();
			DataTable dt = usr.getUsersList();
			dt.Columns.Add("ActivationDate", typeof (string));
			dt.Columns.Add("ActivationTime", typeof (string));
			dt.Columns.Add("checked",typeof (bool));
			
			for(int i = 0; i< dt.Rows.Count;i++)
			{
				dt.Rows[i]["ActivationDate"] = System.DateTime.Today.ToShortDateString() ;
				dt.Rows[i]["ActivationTime"] =  System.DateTime.Now.ToShortTimeString();
			}		  
											  
			namesList.SetDataBinding(dt,"");
			namesList.RetrieveStructure();
			namesList.CellSelectionMode = CellSelectionMode.EntireRow;
			initializeNamesList();
			
			//namesList.RootTable.Columns["ActivationDate"].EditType = EditType.Custom;
			namesList.RootTable.Columns["ActivationDate"].EditType = EditType.CalendarDropDown;
			
			if(ll!= null)
			{
				for(int i = 0; i< dt.Rows.Count;i++)
				{
					namesList.Row = i;
					foreach( SendInfo si in ll)
					{
						if((int)namesList.GetValue("UserId") == si.DestUser.Code)
						{
							namesList.SetValue("checked",true);
							ll.Remove(si);
							break;
						}
					}

				}
			}

		}
		private void LoadCompanyList()
		{	
			cc2 = new Calendar.UcCalendar ();
			UsersList company = new UsersList();
			DataTable dt = company.getCompanyList();
			dt.Columns.Add("ActivationDate", typeof (string));
			dt.Columns.Add("ActivationTime", typeof (string));
			dt.Columns.Add("checked", typeof (bool));
			
			for(int i = 0; i< dt.Rows.Count;i++)
			{
				dt.Rows[i]["ActivationDate"] = System.DateTime.Today.ToShortDateString();
				dt.Rows[i]["ActivationTime"] =  System.DateTime.Now.ToShortTimeString();
			}			  

			companyList.SetDataBinding(dt,"");
			companyList.RetrieveStructure();
			companyList.CellSelectionMode = CellSelectionMode.EntireRow;
			initializeCompanyList();

			companyList.RootTable.Columns["ActivationDate"].EditType = EditType.CalendarDropDown;

			if(ll!= null)
			{
				for(int i = 0; i< dt.Rows.Count;i++)
				{
					companyList.Row = i;
					
					foreach( SendInfo si in ll)
					{
						if(Convert.ToInt32( (string)companyList.GetValue("StoreNo")) == si.DestCompany.Code)
						{
							companyList.SetValue("checked",true);
							ll.Remove(si);
							break;
						}
					}

				}
			}
		}
		private void initializeCompanyList()
		{

			for(int i = 0; i < companyList.RootTable.Columns.Count; i++)
				companyList.RootTable.Columns[i].Visible = false;
			
			companyList.RootTable.Columns["Shortname"].Caption = "Store Name";
			companyList.RootTable.Columns["Shortname"].Visible = true;
			companyList.RootTable.Columns["checked"].Caption = "";
			companyList.RootTable.Columns["checked"].Visible = true;
			companyList.RootTable.Columns["checked"].FilterEditType = Janus.Windows.GridEX.FilterEditType.NoEdit;

			companyList.RootTable.Columns["activationdate"].Visible = true;
			companyList.RootTable.Columns["activationdate"].Caption = "Activation Date";
			companyList.RootTable.Columns["activationdate"].FilterEditType = Janus.Windows.GridEX.FilterEditType.NoEdit;

			companyList.RootTable.Columns["activationtime"].Visible = true;
			companyList.RootTable.Columns["activationtime"].Caption = "Activation Time";
			companyList.RootTable.Columns["activationtime"].FilterEditType = Janus.Windows.GridEX.FilterEditType.NoEdit;
			companyList.RootTable.Columns["activationtime"].EditType = Janus.Windows.GridEX.EditType.Custom;


			companyList.AutoSizeColumns();

		}
		
		private void initializeNamesList()
		{
			namesList.RootTable.Columns["UserId"].Visible = false;
			namesList.RootTable.Columns["UserPassword"].Visible = false;
			namesList.RootTable.Columns["UserActiveFalg"].Visible = false;
			namesList.RootTable.Columns["DefaultStoreNo"].Visible = false;
			namesList.RootTable.Columns["DefaultYear"].Visible = false;
			namesList.RootTable.Columns["UserGroupId"].Visible = false;



			namesList.RootTable.Columns["checked"].Caption = "";
			namesList.RootTable.Columns["checked"].FilterEditType = Janus.Windows.GridEX.FilterEditType.NoEdit;

			namesList.RootTable.Columns["ActivationDate"].Caption = "Activation Date";
			namesList.RootTable.Columns["ActivationDate"].FilterEditType = Janus.Windows.GridEX.FilterEditType.NoEdit;

			namesList.RootTable.Columns["ActivationTime"].Caption = "Activation Time";
			namesList.RootTable.Columns["ActivationTime"].FilterEditType = Janus.Windows.GridEX.FilterEditType.NoEdit;
			namesList.RootTable.Columns["ActivationTime"].EditType = Janus.Windows.GridEX.EditType.Custom;
			

			namesList.RootTable.Columns["UserLogin"].EditType= EditType.NoEdit;
			namesList.RootTable.Columns["UserLogin"].Caption = "User Name";
			namesList.RootTable.Columns["UserLogin"].FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox;


			namesList.RootTable.Columns["UserName"].EditType= EditType.NoEdit;
			namesList.RootTable.Columns["UserName"].Caption = "First Name";
			namesList.RootTable.Columns["UserName"].FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox;

			namesList.RootTable.Columns["UserFamily"].EditType= EditType.NoEdit;
			namesList.RootTable.Columns["UserFamily"].Caption = "Last Name";
			namesList.RootTable.Columns["UserFamily"].FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox;
			

		}

		private void AddSelected_Click(object sender, System.EventArgs e)
		{
			SelectedItems = new ArrayList();
			
			

			for(int r = 0; r < namesList.RowCount; r++)
			{
				namesList.Row = r;
				if(namesList.GetValue("checked").Equals(true) )
				{
					User tmp = new User();
					//tmp.FirstName = namesList.GetValue("UserName");
					//tmp.LastName = namesList.GetValue("UserFamily");
					tmp.Code = (int) namesList.GetValue("UserId");
					tmp.Login = (string)  namesList.GetValue("UserLogin");
					string date;
					/*if(namesList.GetValue("ActivationDate") == DBNull.Value)
						 date = Calendar.DateUtils.FarToDay();
					else 
						 date = (string)namesList.GetValue("ActivationDate");
					*/
					
					if(namesList.GetValue("ActivationDate") == DBNull.Value)
						date = System.DateTime.Today.ToShortDateString();
					else 
						date = (string)namesList.GetValue("ActivationDate");

					string time;
					
					if(namesList.GetValue("ActivationTime") == DBNull.Value)
						time	 = System.DateTime.Now.ToShortTimeString();
					else
						time = (string)namesList.GetValue("ActivationTime");

					DateTime enDate = convertDate(date,time);
					
					SendInfo sI = new SendInfo(tmp, enDate );
					SelectedItems.Add(sI);
				}
				

			}
			
			for(int r = 0; r < companyList.RowCount; r++)
			{
				companyList.Row = r;
				if(companyList.GetValue("checked").Equals(true) )
				{
					Company tmp = new Company();
					//tmp.FirstName = namesList.GetValue("UserName");
					//tmp.LastName = namesList.GetValue("UserFamily");
					tmp.Code = Convert.ToInt32((string) companyList.GetValue("StoreNo"));
					tmp.CompanyName = (string)  companyList.GetValue("StoreName");
					tmp.CompanyShortName = (string) companyList.GetValue("ShortName");
//					tmp.SqlConnection = (string) companyList.GetValue("SqlServerName");

					string date =  System.DateTime.Today.ToShortDateString();
					if(companyList.GetValue("ActivationDate") != DBNull.Value)
						date = (string)companyList.GetValue("ActivationDate");
					string time =  DateTime.Now.ToShortTimeString();
					if(companyList.GetValue("ActivationTime") != DBNull.Value)
						time = (string)companyList.GetValue("ActivationTime");

					DateTime enDate = convertDate(date ,time);
					SendInfo sI = new SendInfo(tmp, enDate );
					SelectedItems.Add(sI);
				}
				

			}
			this.Tag = SelectedItems;
			this.okButtonClick = true;
			this.Close();
		}

		private DateTime convertDate(string ActDate, string actTime)
		{
			/*	int t = actTime.Length-actTime.IndexOf(" ");
			string tmp = actTime.Substring(actTime.IndexOf(" ")+1,t-1);
			string enActDate = Calendar.DateUtils.FarToEn(faActDate)+", "+tmp;
			//
			int t = actTime.Length-actTime.IndexOf(" ");
			string tmp = actTime.Substring(actTime.IndexOf(" ")+1,t-1);*/
			string enActDate = ActDate+", "+actTime;
			
			return Convert.ToDateTime(enActDate);
			
		}


		private void namesList_InitCustomEdit(object sender, Janus.Windows.GridEX.InitCustomEditEventArgs e)
		{
			if(e.Column.Caption == "Activation Date")
				e.EditControl = cc2;
			if(e.Column.Caption == "Activation Time")
			{
				timeMaskedEditBox = new Janus.Windows.GridEX.EditControls.MaskedEditBox();
				timeMaskedEditBox.Mask = "00:00";
				e.EditControl = timeMaskedEditBox;
			}
		}

		private void namesList_EndCustomEdit(object sender, Janus.Windows.GridEX.EndCustomEditEventArgs e)
		{
			if(e.Column.Caption == "Activation Date")
				e.Value = cc2.Text;
			if(e.Column.Caption == "Activation Time")
				e.Value = timeMaskedEditBox.Text;;
		}

		private void CancelButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void namesList_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
		{
			namesList.SetValue("checked", true);
		}

		private void companyList_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
		{
			companyList.SetValue("checked", true);
		}

		private void companyList_EndCustomEdit(object sender, Janus.Windows.GridEX.EndCustomEditEventArgs e)
		{
			if(e.Column.Caption == "Activation Date")
				e.Value = cc2.Text;
			if(e.Column.Caption == "Activation Time")
				e.Value = timeMaskedEditBox.Text;
		}

		private void companyList_InitCustomEdit(object sender, Janus.Windows.GridEX.InitCustomEditEventArgs e)
		{
			if(e.Column.Caption == "Activation Date")
				e.EditControl = cc2;
			if(e.Column.Caption == "Activation Time"){
				timeMaskedEditBox = new Janus.Windows.GridEX.EditControls.MaskedEditBox();
				timeMaskedEditBox.Mask = "00:00 LL";
				e.EditControl = timeMaskedEditBox;
			}
						
			
		}
		bool namecheck = false,companycheck=false;
		private void companyList_ColumnHeaderClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			if(e.Column.Key == "checked")
			{
				companycheck = !companycheck;
				
				for(int i=0; i<companyList.RowCount;i++)
				{
					companyList.Row = i;
					companyList.SetValue("Checked", companycheck);
				}
			}
		}

		private void namesList_ColumnHeaderClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{

			if(e.Column.Key == "checked")
			{
				namecheck =  !namecheck;
				for(int i=0; i<namesList.RowCount;i++)
				{
					namesList.Row = i;
					namesList.SetValue("Checked", namecheck);
				}
			}		
		}





	}
}
