using System;
using System.Collections;
using System.Data;
using System.Data.SqlTypes;


namespace Message.DataGateway
{
	/// <summary>
	/// Summary description for DataGateway.
	/// </summary>
	public class DataGateway
	{
		public static DataTable LoadUsers()
		{
			DataSet ds = DBAccess.AccessRetrieve("select * from Users where UserActiveFalg = 1","user");
	
			return ds.Tables[0];


		}
		public static void AddUserAttachmentsList(Guid msgId, SqlBinary file, string filename )
		{
			string cmd = "insert into user_attachment(message_code, attached_file, f_name)"+
			" values('"+ msgId+"',@file,'"+filename.Replace ("'", "''")+"')";
							
			
			DBAccess.InsertImage(cmd,file.Value);
		}
		public static void AddCompanyAttachmentsList(Guid msgId, SqlBinary file, string filename )
		{
			string cmd = "insert into user_attachment(message_code, attached_file, f_name)"+
				" values('"+ msgId+"',@file,'"+filename.Replace ("'", "''")+"')";       
			DBAccess.InsertImage(cmd,file.Value);
		}

		public static void AddRemoteCompanyAttachmentsList(Guid msgId, SqlBinary file, string filename,int compcode )
		{
			string cmd = "insert into user_attachment(message_code, attached_file, f_name)"+
				" values('"+ msgId+"',@file,'"+filename.Replace ("'", "''")+"')";       
			DBAccess.InsertRemoteImage(cmd,file.Value,compcode.ToString());
		}

		public static DataTable LoadCompany()
		{
			DataSet ds = DBAccess.AccessRetrieve("select * from store_setup","company");
			 
			return ds.Tables[0];
		}
		public static DataRow GetUserInfo(string username)
		{
			DataSet ds = DBAccess.AccessRetrieve("select * from Users where UserActiveFalg = 1 and UserLogin = '"+username+"'","user");
			if(ds.Tables[0].Rows.Count >0)
				return ds.Tables[0].Rows[0];
			else
				return null;
		}
		public static DataRow GetCompanyInfo(string username)
		{
			DataSet ds = DBAccess.AccessRetrieve("select * from store_setup where shortname = '"+username+"'","company");
			if(ds.Tables[0].Rows.Count >0)
				return ds.Tables[0].Rows[0];
			else
				return null;
		}
		public static bool GetLastFlagUser(Guid msgId, int usercode)
		{


	
			string cmd = "select last_flag from message_send where message_code = '"+msgId+"' and user_code =" + usercode;
			DataSet ds = DBAccess.RetrieveCommand(cmd);

			if (ds.Tables[0].Rows.Count == 0)
				return false;
			return ((bool)ds.Tables[0].Rows[0][0]);
		}

		public static bool GetLastFlag(Guid msgId, int compcode)
		{
			string tmp = compcode.ToString();
			if(tmp.Length == 1 )
				tmp = "0"+tmp;
			string cmd = "select last_flag from message_send where message_code = '"+msgId+"' and company_code ='" +tmp+"'";
			DataSet ds = DBAccess.RetrieveRemoteCommand(cmd, tmp);
			if (ds == null) 
				ds = DBAccess.RetrieveCommand(cmd);
			if (ds.Tables[0].Rows.Count == 0)
				return false;
			return ((bool)ds.Tables[0].Rows[0][0]);
	
		}
		public static DateTime GetVisitDate(Guid msgId, int compcode)
		{
			string tmp = compcode.ToString();
			if(tmp.Length == 1 )
				tmp = "0"+tmp;
			string cmd = "select visit_date from message_send where message_code = '"+msgId+"' and company_code ='"+tmp+"'";
			DataSet ds = DBAccess.RetrieveRemoteCommand(cmd, tmp);
			if(ds == null)
				ds = DBAccess.RetrieveCommand(cmd);
			
			if (ds.Tables[0].Rows.Count > 0 && (ds.Tables[0].Rows[0][0]) != DBNull.Value)

				return ((DateTime)ds.Tables[0].Rows[0][0]);
			return new DateTime(1,1,1);
		
		}
		public static DataRow GetCompanyInfo(int compcode)
		{
			string tmp = compcode.ToString();
			if(tmp.Length == 1 )
				tmp = "0"+tmp;
			DataSet ds = DBAccess.AccessRetrieve("select * from store_setup where storeno = '"+tmp+"'","company");
			if(ds.Tables[0].Rows.Count >0)
				return ds.Tables[0].Rows[0];
			else
				return null;
		}

		public static DataRow GetUserInfo(int code)
		{
			DataSet ds = DBAccess.AccessRetrieve("select * from Users where UserActiveFalg = 1 and UserID = "+code,"user");
			if(ds.Tables[0].Rows.Count >0)
				return ds.Tables[0].Rows[0];
			else
				return null;
		}

		public static DataSet GetUserSentItems(int usercode)
		{
			string cmd =" select * from (select * from user_message  where deleted != 1 and user_code = "+usercode+") as a left join user_attachment on "+
						"a.message_code = user_attachment.message_code;";

				   cmd += "select * "
					   +"from user_message join  message_send on (user_message.message_code = message_send.message_code) "+
							"where user_message.user_code = "+ usercode +" and user_message.deleted != 1";
					
			DataSet ds = DBAccess.RetrieveCommand(cmd);
			return ds;
		}
		public static DataTable GetMessageAttachment(int msgId)
		{
			DataSet ds =  DBAccess.RetrieveCommand("select f_name, attached_file from user_attachment where message_code ="+ msgId);
			return ds.Tables[0];
		}
		public static DataSet GetCompanySentItems(int compcode)
		{
			string tmp = compcode.ToString();
			if(tmp.Length == 1 )
				tmp = "0"+tmp;
			string cmd = " select * from (select * from user_message  where deleted != 1 and company_code = '"+tmp+"') as a left join user_attachment on "+
				"a.message_code = user_attachment.message_code;";
			cmd += "select * "
				+"from user_message join  message_send on (user_message.message_code = message_send.message_code) "+
				"where user_message.company_code = '"+ tmp +"' and user_message.deleted != 1";
			DataSet ds = DBAccess.RetrieveCommand(cmd);

			return ds;
		}

		public static int DeleteSentMessageFromServerUser(Guid msgId,int usercode)
		{
			string cmd = "select visit_date from message_send where message_code ='" + msgId+"'"+
				"and user_code =" + usercode;
			DataTable dt = DBAccess.RetrieveCommand(cmd).Tables[0];
			if ( dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
				return -1;
			else
				cmd = "update message_send set last_flag = 1 where message_code ='"+ msgId+"'"+
					"and user_code =" + usercode;
			DBAccess.ExecuteCommand(cmd);
			return 0;
		}

		public static int DeleteSentMessageFromServerComp(Guid msgId,int compcode)
		{
			
			string cmd = "select visit_date from message_send where message_code ='" + msgId+"'";
			DataTable dt = DBAccess.RetrieveRemoteCommand(cmd, compcode.ToString()).Tables[0];
			if ( dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
				return -1;
			else
				cmd = "update message_send set last_flag = 1 where message_code ='"+ msgId+"'";
			DBAccess.ExecuteRemoteCommand(cmd, compcode.ToString());
			return 0;
			/*DataRow[] currRows = dt.Select(null,null,DataViewRowState.CurrentRows);
			bool lflag = true;
			foreach(DataRow dr in currRows)
			{
				if(dr["visit_date"]!=DBNull.Value)
				{
					lflag = false;
					break;
				}
			}
			if(lflag)
			{
				cmd = "update user_message set last_flag = 1 where message_code ="+ msgId;
				DBAccess.ExecuteCommand(cmd);
			}
			else return -1;

			return 1;
			*/

		}
		public static void DeleteMessageFromSent(Guid msgId)
		{
			string cmd = "update user_message set deleted = 1 where message_code = '"+msgId +"'";
			DBAccess.ExecuteCommand(cmd);
			
		}
		public static void DeleteFailedMessageFromMessage_Send(Guid msgId, int compCode)
		{
			string cmd = "delete from message_send where message_code ='"+msgId+"' and company_code ="+compCode ;
			DBAccess.ExecuteCommand(cmd);
		}
		public static DataTable GetCompanyInbox(int compcode)
		{
			string tmp = compcode.ToString();
			if(tmp.Length == 1)
				tmp = "0"+tmp;
			string	cmd = " update message_send " +
				"set message_send.visit_date = getdate() "+
				"from message_send join user_message " +
				"on message_send.message_code = user_message.message_code and message_send.company_code = '"+ tmp+
				"' and message_send.visit_date is null and message_send.last_flag = 0 and message_send.activation_date < getdate()";


			DBAccess.ExecuteCommand(cmd);
			


			cmd = "select * from (select * from message_send where company_code ='"+ tmp+"' and message_send.deleted != 1 "+
				"and getdate() > message_send.activation_date and message_send.last_flag != 1) as a join" +
				"(select * from user_message) as b on a.message_code = b.message_code left join" +
				"(select * from user_attachment) as c on b.message_code = c.message_code";

			DataSet ds = DBAccess.RetrieveCommand(cmd);
			DataTable dt = ds.Tables[0];
			return dt;
			
		}
		public static DataTable GetUserInbox(int usercode)
		{
			/*cmd =
			 * update message_send 
			  set message_send.visit_date = getdate()
				from message_send join user_message 
				on message_send.message_code = user_message.message_code and message_send.user_code = 27 
			 */
		/*	string cmd = "select count(*) as row_count from (select * from message_send where user_code ="+ usercode+" and message_send.deleted != 1 "+
				"and getdate() > message_send.activation_date and message_send.last_flag != 1) as a join" +
				"(select * from user_message) as b on a.message_code = b.message_code left join" +
				"(select * from user_attachment) as c on b.message_code = c.message_code";
			
			DataSet ds = DBAccess.RetrieveCommand(cmd);*/
			
			/* 
				update message_send set message_send.visit_date = getdate() 
				where message_send.message_code in ( select top 20 message_send.message_code 
				from message_send join user_message on message_send.message_code = user_message.message_code 
				and message_send.user_code = 1 and getdate() > message_send.activation_date 
				and message_send.visit_date is null and message_send.last_flag = 0)
			 */
		
			
			string cmd = " update message_send " +
						  "set message_send.visit_date = getdate() "+
						  "from message_send join user_message " +
						  "on message_send.message_code = user_message.message_code and message_send.user_code = "+ usercode+
							"and getdate() > message_send.activation_date and message_send.visit_date is null and message_send.last_flag = 0";
			DBAccess.ExecuteCommand(cmd);


			cmd = "select * from (select * from message_send where user_code ="+ usercode+" and message_send.deleted != 1 "+
				  "and getdate() > message_send.activation_date and message_send.last_flag != 1) as a join" +
                  "(select * from user_message) as b on a.message_code = b.message_code left join" +
                  "(select * from user_attachment) as c on b.message_code = c.message_code";
		
			/*cmd = " select * from user_attachment join"+
				  " (select * from user_message join (select * from message_send where message_send.deleted != 1"+
				  " and message_send.user_code ="+ usercode+
				  " and getdate() > message_send.activation_date)"+
				  " as ddd on user_message.message_code = ddd.message_code where user_message.last_flag != 1) as bbb"+
				  "on  user_attachment.message_code = bbb.message";

/*			cmd = " select * from user_attachment join user_message on user_message.message_code = user_attachment.mesage_code"+
				" where user_message.user_code ="+usercode+
				" and getdate() > message_send.activation_date)"+
				" as ddd on user_message.message_code = ddd.message_code where user_message.last_flag != 1";*/

			return DBAccess.RetrieveCommand(cmd).Tables[0];
			
			
		/*	DataRow[] rows = dt.Select(null,null,DataViewRowState.CurrentRows);
			foreach( DataRow dr in rows)
			{
				if((int) dr["last_flag"] == 0) 
				{
					//cmd = "update user_message set last_flag = 1 where message_code ="+dr["message_code"]; 
					DBAccess.ExecuteCommand(cmd);
				}
			}*/
			//cmd = "update user_message set last_flag";
		
		}

		public static void DeleteMessageFromCompanyInbox(int compcode, Guid msgId)
		{
			string tmp = compcode.ToString();
			if(tmp.Length == 1 )
				tmp = "0"+tmp;
			string cmd = "update message_send set deleted = 1 where company_code ='"+ tmp+"'and message_code = '"+ msgId+"'";
			DBAccess.ExecuteCommand(cmd);
			
		}
		public static void DeleteMessageFromUserInbox(int usrcode, Guid msgId)
		{
			string cmd = "update message_send set deleted = 1 where user_code = "+ usrcode+" and message_code = '"+ msgId+"'";
			DBAccess.ExecuteCommand(cmd);
			
		}
		public static int CopyCompanyMessage(Guid msgId, int companyCode, string body, string subj,int destcomp)
		{
			string tmp = companyCode.ToString();
			if(tmp.Length == 1 )
				tmp = "0"+tmp;
			string cmd = "insert into user_message (message_code,company_code, message_body, message_subject) "+
				"values('"+msgId+"','"+ tmp + "', '" + body.Replace ("'", "''") + "', '"+ subj.Replace ("'", "''")+"');";
				
			
			/*string cmd = "insert into user_message (company_code, message_body, message_subject) "
				+ "values ("+companyCode+", '" + body.Replace ("'", "''") + "', '"+ subj.Replace ("'", "''")+"');"+
				" select @@identity as fff";*/

			return DBAccess.ExecuteRemoteCommand(cmd,destcomp.ToString());
			
			

		}
		public static Guid SendUserMessage(int userCode, string body, string subj)
		{
			
			string cmd = "declare @myguid uniqueidentifier;"+
						 "select @myguid = newid();"+
						 "insert into user_message (message_code,user_code, message_body, message_subject) "+
						 "values(@myguid,"+ userCode + ", '" + body.Replace ("'", "''") + "', '"+ subj.Replace ("'", "''")+"');"+
						 "SELECT @MyGUID AS MyGUID";


			/*
			string cmd = "insert into user_message (user_code, message_body, message_subject) "
				+ "values (" + userCode + ", '" + body.Replace ("'", "''") + "', '"+ subj.Replace ("'", "''")+"');"+
				" select @@identity as fff";*/

			DataSet ds = DBAccess.RetrieveCommand(cmd);
			
			return  ((Guid)ds.Tables[0].Rows[0][0]);
		}
		public static Guid SendCompanyMessage(int compcode, string body, string subj)
		{	
			string tmp = compcode.ToString();
			if(tmp.Length == 1 )
				tmp = "0"+tmp;
			string cmd = "declare @myguid uniqueidentifier;"+
				"select @myguid = newid();"+
				"insert into user_message (message_code,company_code, message_body, message_subject) "+
				"values(@myguid,'"+ tmp + "', '" + body.Replace ("'", "''") + "', '"+ subj.Replace ("'", "''")+"');"+
				"SELECT @MyGUID AS MyGUID";
			
			/*string cmd = "insert into user_message (company_code, message_body, message_subject) "
				+ "values ("+companyCode+", '" + body.Replace ("'", "''") + "', '"+ subj.Replace ("'", "''")+"');"+
				" select @@identity as fff";*/

			DataSet ds = DBAccess.RetrieveCommand(cmd);

			
			return  ((Guid) ds.Tables[0].Rows[0][0]);
		}
		public static void AddDestUserList(Guid msgId, int usrCode, DateTime actDate)
		{

				
			string cmd = "insert into message_send (message_code, user_code, activation_date) "
					+ "values ('" + msgId + "', " + usrCode + ",'"+ actDate+ "' );";
			cmd = cmd.Replace("Þ.Ù", "AM");
			cmd = cmd.Replace("È.Ù", "PM"); 
				
			DBAccess.ExecuteCommand(cmd);
		}
		public static void AddDestCompanyList(Guid msgId, int compcode, DateTime actDate)
		{
			string tmp = compcode.ToString();
			if(tmp.Length == 1 )
				tmp = "0"+tmp;
				
			string cmd = "insert into message_send (message_code, company_code, activation_date) "
				+ "values ('" + msgId + "', '" + tmp + "','"+ actDate+ "' );";
	
				cmd = cmd.Replace("Þ.Ù", "AM");
                cmd = cmd.Replace("È.Ù", "PM"); 
			DBAccess.ExecuteCommand(cmd);
	
		}

		public static void AddRemoteDestCompanyList(Guid msgId, int compCode, DateTime actDate, int storeno)
		{
			string tmp = compCode.ToString();
			if(tmp.Length == 1 )
				tmp = "0"+tmp;	
			string cmd = "insert into message_send (message_code, company_code, activation_date) "
				+ "values ('" + msgId + "', '" + tmp + "','"+ actDate+ "' );";

			cmd = cmd.Replace("Þ.Ù", "AM");
			cmd = cmd.Replace("È.Ù", "PM"); 
	
			DBAccess.ExecuteRemoteCommand(cmd,storeno.ToString());
		}
	}
}
