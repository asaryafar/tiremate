using System;
using System.Collections;
using System.Data;

namespace Message.Domain
{
	/// <summary>
	/// Summary description for Users.
	/// </summary>
	public class UsersList
	{
		public UsersList()
		{
			
		}
		public DataTable getUsersList()
		{
			DataTable users = DataGateway.DataGateway.LoadUsers();
						
			return users;
			
		}
		public DataTable getCompanyList()
		{
			DataTable company = DataGateway.DataGateway.LoadCompany();
			return company;
		}

	}
}
