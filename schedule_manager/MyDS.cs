using System;

namespace schedule_manager
{
	/// <summary>
	/// Summary description for MyDS.
	/// </summary>
	public class MyDS : System.Data.DataSet
	{
		public System.Data.DataTable Appointments { get { return Tables[0];}}
		public MyDS()
		{
			System.Data.DataTable dt = new System.Data.DataTable("Appointments");
			dt.Columns.Add("aa", typeof(int));
			this.Tables.Add(dt);
		}
	}
}
