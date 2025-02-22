using System;
using System.Data;

namespace Message.Domain
{
	/// <summary>
	/// Summary description for Company.
	/// </summary>
	public class Company
	{
		string companyName, companyShortName, sqlConnection;
		int code;

		public Company()
		{
			companyName=companyShortName = "";
			code = -1;

		}
		public int Code
		{
			set{ code = value;}
			get { return code;}
		}
		public string CompanyName
		{
			set {companyName = value;}
			get { return companyName; }
		}
		public string SqlConnection
		{
			set {sqlConnection = value;}
			get { return sqlConnection; }
		}
		public string CompanyShortName
		{
			set {companyShortName = value;}
			get { return companyShortName; }
		}
		public int fillCompanyInfo(int _code)
		{
			DataRow dr = DataGateway.DataGateway.GetCompanyInfo(_code);
			if(dr!= null)
			{
				companyName =(string) dr["StoreName"];
				companyShortName = (string) dr["ShortName"];
				code = _code;
				//sqlConnection = (string) dr["SqlServerName"];
				return 0;
			}
			else
				return -1;
		}
		public int fillCompanyInfo(string shortName)
		{
			DataRow dr = DataGateway.DataGateway.GetCompanyInfo(shortName);
			if(dr!= null)
			{
				companyName =(string) dr["StoreName"];
				companyShortName = (string) dr["ShortName"];
				code = Convert.ToInt16( (string)dr["StoreNo"]);
				//sqlConnection = (string) dr["SqlServerName"];
				return 0;
			}
			else 
				return -1;
		}	
	}
}
