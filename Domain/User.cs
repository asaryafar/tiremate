using System;
using Message.DataGateway;
using System.Data;

namespace Message.Domain
{
	/// <summary>
	/// Summary description for User.
	/// </summary>
	public class User
	{
		private string login, fname, lname;
		private int code;
		private Company comp;
		public User()
		{
			login=fname=lname = "";
			code = -1;
		}
		public User(string companyname)
		{
			login=fname=lname = "";
			code = -1;
			comp = new Company();
			comp.fillCompanyInfo(companyname);
		}
		public Company CompanyInfo
		{
			set { comp = value;}
			get { return comp;}
		}


		public string Login
		{
			set { login = value;}
			get { return login;}
		}

		public int Code
		{
			set { code = value;}
			get { return code;}
		}
		public string FirstName
		{
			set { fname = value;}
			get { return fname;}
		}
		public string LastName
		{
			set { lname = value;}
			get { return lname;}
		}
		
		public int fillUserInfo(string uname)
		{
			login = uname;
			DataRow r = DataGateway.DataGateway.GetUserInfo(login);
			if(r!=null)

			{
				code = Convert.ToInt32(r["UserId"]);
				fname = (string)r["UserName"];
				lname = (string)r["UserFamily"];
				return 0;
			}
			else
				return -1;
		}
	
		public int fillUserInfo(int cd)
		{
			code = cd;
			DataRow r = DataGateway.DataGateway.GetUserInfo(code);
			if(r!=null)
			{
				login = (string)r["UserLogin"];
				fname = (string)r["UserName"];
				lname = (string)r["UserFamily"];
				return 0;
			}
			else
				return -1;
		}
	}
}
