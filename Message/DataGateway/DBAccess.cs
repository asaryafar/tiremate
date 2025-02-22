using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Message.DataGateway
{
	/// <summary>
	/// Summary description for DBAccess.
	/// </summary>
	public class DBAccess
	{
		private static SqlConnection createSqlConnection ()
		{
			return new SqlConnection(CommonClass.MainModule.PConnectionStringMessage);
		}
		private static SqlConnection CreateRemoteSqlConnection (string storeno)
		{

			if(storeno.Length == 1)
				storeno = "0"+storeno;
			return new SqlConnection(CommonClass.MainModule.MakeConnectionSqlForThisStoreMessaging(storeno));
		}
		public static DataSet RetrieveRemoteCommand(string command,string con)
		{
			try
			{
				SqlConnection conn = CreateRemoteSqlConnection (con);
				SqlCommand comm = new SqlCommand ();
				comm.Connection = conn;
				comm.CommandText = command;
				comm.CommandType = CommandType.Text;

				SqlDataAdapter adapter = new SqlDataAdapter (comm);
				DataSet ds = new DataSet();
				adapter.Fill(ds);
				return ds;
			}
			catch (SqlException ex)
			{
				
				System.Windows.Forms.MessageBox.Show ("couldn't connect to store No." + con);
				return null;
			}
	

		}
		public static DataSet RetrieveCommand(string command)
		{
			try
			{
				SqlConnection conn = createSqlConnection ();
				SqlCommand comm = new SqlCommand ();
				comm.Connection = conn;
				comm.CommandText = command;
				comm.CommandType = CommandType.Text;

				SqlDataAdapter adapter = new SqlDataAdapter (comm);
				DataSet ds = new DataSet();
				adapter.Fill(ds);
				return ds;
			}
			catch (SqlException ex)
			{
				
				System.Windows.Forms.MessageBox.Show (ex.Message);
			}
			return null;
		}
	
		// === added by maryam
		public static OleDbConnection createAccessConnection(string name)
		{	if(name == "user")
				return new OleDbConnection (CommonClass.MainModule.PConnectionStringForUserMdb);
			if(name == "company")
				return new OleDbConnection (CommonClass.MainModule.PConnectionStringForSetupTables);
			return null;
		}

		public static void AccessExecuteCommand (string command,string name)
		{
			OleDbConnection conn = createAccessConnection(name);
			OleDbCommand comm = new OleDbCommand (command, conn);
			try
			{
				conn.Open();
				comm.ExecuteNonQuery();
				conn.Close();
			}
			catch (OleDbException ex)
			{
				if (conn.State != ConnectionState.Closed)
					conn.Close();
				System.Windows.Forms.MessageBox.Show (ex.Message, "AccessExecuteCommand Exception");
			}
		}
		public static int ExecuteRemoteCommand (string command, string con)
		{
			SqlConnection conn = CreateRemoteSqlConnection(con);
			SqlCommand comm = new SqlCommand (command, conn);
			try
			{
				conn.Open();
				comm.ExecuteNonQuery();
				conn.Close();
			}
			catch (SqlException ex)
			{
				if (conn.State != ConnectionState.Closed)
					conn.Close();
				//System.Windows.Forms.MessageBox.Show (ex.Message, "ExecuteCommand Exception");
				return -1;
			}
			return 0;
		}
		public static void ExecuteCommand (string command)
		{
			SqlConnection conn = createSqlConnection();
			SqlCommand comm = new SqlCommand (command, conn);
			try
			{
				conn.Open();
				comm.ExecuteNonQuery();
				conn.Close();
			}
			catch (SqlException ex)
			{
				if (conn.State != ConnectionState.Closed)
					conn.Close();
				System.Windows.Forms.MessageBox.Show (ex.Message, "ExecuteCommand Exception");
			}
		}
		public static void InsertRemoteImage (string command,byte[] file,string con)
		{
			SqlConnection conn = CreateRemoteSqlConnection(con);
			SqlCommand comm = new SqlCommand (command, conn);

			comm.Parameters.Add("@file",file);
			try
			{
				conn.Open();
				comm.ExecuteNonQuery();
				conn.Close();
			}
			catch (SqlException ex)
			{
				if (conn.State != ConnectionState.Closed)
					conn.Close();
				System.Windows.Forms.MessageBox.Show (ex.Message, "ExecuteCommand Exception");
			}
		}
		public static void InsertImage (string command,byte[] file)
		{
			SqlConnection conn = createSqlConnection();
			SqlCommand comm = new SqlCommand (command, conn);

			comm.Parameters.Add("@file",file);
			try
			{
				conn.Open();
				comm.ExecuteNonQuery();
				conn.Close();
			}
			catch (SqlException ex)
			{
				if (conn.State != ConnectionState.Closed)
					conn.Close();
				System.Windows.Forms.MessageBox.Show (ex.Message, "ExecuteCommand Exception");
			}
		}
		public static DataSet AccessRetrieve (string command,string name)
		{
			try
			{
				OleDbDataAdapter ada = new OleDbDataAdapter (new OleDbCommand (command, createAccessConnection(name)));
				DataSet ds = new DataSet();
				ada.Fill(ds);
				return ds;
			}
			catch (OleDbException ex)
			{
				System.Windows.Forms.MessageBox.Show (ex.Message);
			}
			return null;
		}

		public static void CreateFunctions ()
		{
			string n = "\n", s1 = "\n\t", s2 = "\n\t\t", s3 = "\n\t\t\t", s4 = "\n\t\t\t\t";
			SqlConnection conn = createSqlConnection();
			SqlCommand comm = new SqlCommand ();
			comm.Connection = conn;
			comm.CommandType = CommandType.Text;

			string cmd = "select * from dbo.table_description ('existance check')";
			try
			{
				comm.CommandText = cmd;
				conn.Open();
				comm.ExecuteNonQuery();
				conn.Close();
			}
			catch (SqlException ex)
			{
				conn.Close();
				cmd = "CREATE FUNCTION dbo.table_description (@tablename sysname)\n"
					+ "RETURNS @table_variable TABLE (column_name sysname, column_desc sql_variant)"
					+ n + "AS" + s1 + "BEGIN" + s2 + "INSERT INTO @table_variable"
					+ s3 + "SELECT mysyscolumns.name as column_name ,sysproperties.[value] as column_desc"
					+ s3 + "FROM (SELECT syscolumns.colid, syscolumns.id , syscolumns.name from syscolumns)"
					+ s3 + "AS mysyscolumns "
					+ s3 + "JOIN (select sysobjects.id from sysobjects where sysobjects.name = @tablename and sysobjects.xtype = 'U')"
					+ s3 + "AS mysysobjects"
					+ s3 + "ON mysyscolumns.id = mysysobjects.id"
					+ s3 + "LEFT JOIN sysproperties"
					+ s3 + "ON mysyscolumns.id = sysproperties.id and mysyscolumns.colid = sysproperties.smallid"
					+ s3 + " WHERE sysproperties.[value] IS NOT NULL"
					+ s3 + "ORDER BY mysyscolumns.colid"
					+ s1 + "RETURN" + n + "END";
				ExecuteCommand (cmd);
			}

			cmd = "select * from dbo.RelatedTables ('existence check', ' ')";
			try
			{
				comm.CommandText = cmd;
				conn.Open();
				comm.ExecuteNonQuery();
				conn.Close();
			}
			catch (SqlException ex)
			{
				conn.Close();
				cmd = "CREATE FUNCTION dbo.RelatedTables (@tablename sysname, @parenttablename sysname)"
					+ n + "RETURNS @table_variable TABLE (reltablename sysname, this_name sysname, that_name sysname)"
					+ n + "AS" + s1 + "BEGIN" + s2 + "INSERT INTO @table_variable"
					+ s4 + "SELECT sysobjects.name AS RelatedTable , syscolumns2.name AS this_name, "
					+ "syscolumns.name as that_name"
					+ s4 + "FROM sysobjects"
					+ s4 + "INNER JOIN  syscolumns ON sysobjects.id = syscolumns.id"
					+ s4 + "INNER JOIN  sysforeignkeys"
					+ s4 + "ON syscolumns.id = sysforeignkeys.rkeyid AND  syscolumns.colid = sysforeignkeys.rkey"
					+ s4 + "INNER JOIN  syscolumns syscolumns2"
					+ s4 + "ON sysforeignkeys.fkeyid = syscolumns2.id AND  sysforeignkeys.fkey = syscolumns2.colid"
					+ s4 + "INNER JOIN  sysobjects sysobjects2 ON syscolumns2.id = sysobjects2.id"
					+ s4 + "WHERE sysobjects2.name = @tablename and sysobjects.name != @parenttablename"
					//+ s4 + "AND NOT convert (varchar, (select column_desc from table_description(@tablename) "
					//+ "where column_name = syscolumns2.name)) like '*%'"
					+ s3 + "UNION"
					+ s4 + "SELECT  sysobjects.name AS RelatedTable , syscolumns2.name AS this_name, syscolumns.name as that_name"
					+ s4 + "FROM    sysobjects"
					+ s4 + "INNER JOIN  syscolumns ON sysobjects.id = syscolumns.id"
					+ s4 + "INNER JOIN  sysforeignkeys ON syscolumns.id = sysforeignkeys.fkeyid AND  syscolumns.colid = sysforeignkeys.fkey"
					+ s4 + "INNER JOIN  syscolumns syscolumns2 ON sysforeignkeys.rkeyid = syscolumns2.id AND  sysforeignkeys.rkey = syscolumns2.colid"
					+ s4 + "INNER JOIN  sysobjects sysobjects2 ON syscolumns2.id = sysobjects2.id"
					+ s4 + "WHERE   sysobjects2.name = @tablename and sysobjects.name != @parenttablename"
					+ s1 + "RETURN" + n + "END";

				ExecuteCommand (cmd);
			}

			// ======================
			//			cmd = "select * from dbo.StatRelatedTables ('existence check')";
			//			try
			//			{
			//				comm.CommandText = cmd;
			//				conn.Open();
			//				comm.ExecuteNonQuery();
			//				conn.Close();
			//			}
			//			catch (SqlException ex)
			//			{
			//				conn.Close();
			//				cmd = "CREATE FUNCTION dbo.StatRelatedTables (@tablename sysname)"
			//					+ n + "RETURNS @table_variable TABLE (reltablename sysname, this_name sysname, that_name sysname)"
			//					+ n + "AS" + s1 + "BEGIN" + s2 + "INSERT INTO @table_variable"
			//					+ s4 + "SELECT sysobjects.name AS RelatedTable , syscolumns2.name AS this_name, "
			//					+ "syscolumns.name as that_name"
			//					+ s4 + "FROM sysobjects"
			//					+ s4 + "INNER JOIN  syscolumns ON sysobjects.id = syscolumns.id"
			//					+ s4 + "INNER JOIN  sysforeignkeys"
			//					+ s4 + "ON syscolumns.id = sysforeignkeys.rkeyid AND  syscolumns.colid = sysforeignkeys.rkey"
			//					+ s4 + "INNER JOIN  syscolumns syscolumns2"
			//					+ s4 + "ON sysforeignkeys.fkeyid = syscolumns2.id AND  sysforeignkeys.fkey = syscolumns2.colid"
			//					+ s4 + "INNER JOIN  sysobjects sysobjects2 ON syscolumns2.id = sysobjects2.id"
			//					+ s4 + "WHERE sysobjects2.name = @tablename"
			//					+ s4 + "AND NOT convert (varchar, (select column_desc from table_description(@tablename) "
			//					+ "where column_name = syscolumns2.name)) like '*%'"
			//					+ s1 + "RETURN" + n + "END";
			//
			//				ExecuteCommand (cmd);
			//			}
			// ======================

			cmd = "select * from dbo.alltables_description ()";
			try
			{
				comm.CommandText = cmd;
				conn.Open();
				comm.ExecuteNonQuery();
				conn.Close();
			}
			catch (SqlException ex)
			{
				cmd = "CREATE FUNCTION dbo.alltables_description ()"
					+ n + "RETURNS  @table_variable TABLE (table_name sysname, column_name sysname, column_desc sql_variant)"
					+ n + "AS" + s1 + "BEGIN" + s2 + "INSERT INTO @table_variable"
					+ s3 + "SELECT mysysobjects.name as tablename, mysyscolumns.name as column_name ,sysproperties.[value] as column_desc"
					+ s3 + "FROM (select syscolumns.colid, syscolumns.id , syscolumns.name from syscolumns) as mysyscolumns"
					+ s3 + "JOIN (SELECT sysobjects.id , sysobjects.name from sysobjects where sysobjects.xtype = 'U') as mysysobjects"
					+ s3 + "ON mysyscolumns.id = mysysobjects.id"
					+ s3 + "LEFT JOIN sysproperties"
					+ s3 + "ON mysyscolumns.id = sysproperties.id and mysyscolumns.colid = sysproperties.smallid"
					+ s3 + " WHERE sysproperties.[value] IS NOT NULL"
					+ s1 + "RETURN" + n + "END";

				ExecuteCommand (cmd);
			}

			cmd = "SELECT dbo.changedate('00/00/0000') AS mydate";
			try
			{
				comm.CommandText = cmd;
				conn.Open();
				comm.ExecuteNonQuery();
				conn.Close();
			}
			catch (Exception ex)
			{
				cmd = "CREATE FUNCTION dbo.ChangeDate (@ThisDate Char(10))"
					+ n + "RETURNS Char(10)"
					+ n + "AS"
					+ s1 + "BEGIN"
					+ s2 + "DECLARE @ChangedDate1 char(10)"
					+ s2 + "set @ChangedDate1 = SUBSTRING(@ThisDate, 7, 4) + '/' + SUBSTRING(@ThisDate, 1, 2) + '/' + SUBSTRING(@ThisDate, 4, 2)"
					+ s2 + "RETURN @ChangedDate1"
					+ n + "END";

				ExecuteCommand (cmd);
			}

		}
		// === end of added by maryam

	}
}
