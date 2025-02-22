using System;
using System.Data;
using System.Collections;
using System.IO;
using Message.DataGateway;
using System.Data.SqlTypes;
namespace Message.Domain
{
	/// <summary>
	/// Summary description for Folder.
	/// </summary>
	public class Inbox
	{
		User currentUser;
		Company currentCompany;
		ArrayList messages;
		string msgSender;

		public Inbox(User curUser)
		{
			currentUser = curUser;
			msgSender = "user";
		}
		public Inbox(Company curCompany)
		{
			currentCompany = curCompany;
			msgSender = "company";
		}
		private ArrayList getCompInbox()
		{
			DataTable dt = DataGateway.DataGateway.GetCompanyInbox(currentCompany.Code);	
			messages = new ArrayList();
			DataRow[] currRows = dt.Select(null,null,DataViewRowState.CurrentRows);
			Guid  lstMsgId = Guid.Empty;
			MessageInfo mi = null;
			
			foreach( DataRow dr in currRows)
			{
				Company tmp = new Company();
				if(tmp.fillCompanyInfo((int) dr["company_code1"]) == 0)
				{
					if(!lstMsgId.Equals(dr["message_code"]))
					{
						
						//tmp.CompanyInfo = currentUser.CompanyInfo;
						/*if(tmp.CompanyInfo.Code==(int)dr["company_code"] )*/
						for(int i=0;i<dt.Columns.Count;i++)
							Console.WriteLine( dt.Columns[i].Caption);
					
					
						mi = new MessageInfo("company");
						mi.SenderComp = tmp;
						mi.Subject = (string) dr["message_subject"];
						mi.Body = (string)dr["message_body"];
						mi.Received = (DateTime)dr["visit_date"];
						mi.MsgId = (Guid) dr["message_code"];
						if(dr["attached_file"] != DBNull.Value)
						{
							Attachment att = new Attachment();
					
							byte[] image =(byte[]) dr["attached_file"];

							SqlBinary sb = new SqlBinary(image) ;
							att.AttachedFile = sb;
							att.FileName =(string) dr["f_name"];
							mi.FileAttachments.Add(att);

						}
					
					
						messages.Add(mi);
					
					}
					else
				
					{
						Attachment att = new Attachment();
					
						byte[] image =(byte[]) dr["attached_file"];

						SqlBinary sb = new SqlBinary(image) ;
						att.AttachedFile = sb;
						att.FileName =(string) dr["f_name"];
						mi.FileAttachments.Add(att);
					}
				
					lstMsgId = mi.MsgId;
				}

			}

			return messages;

		}

		private ArrayList getUserInbox()
		{
			DataTable dt = DataGateway.DataGateway.GetUserInbox(currentUser.Code);	
			messages = new ArrayList();
			DataRow[] currRows = dt.Select(null,null,DataViewRowState.CurrentRows);
			Guid lstMsgId = Guid.Empty;
			MessageInfo mi = null;										
			foreach( DataRow dr in currRows)
			{
				User tmp = new User();
				if(tmp.fillUserInfo(Convert.ToInt16(dr["user_code1"])) ==0)
				{
					if(!lstMsgId.Equals(dr["message_code"]))
					{
						
						//tmp.CompanyInfo = currentUser.CompanyInfo;
						/*if(tmp.CompanyInfo.Code==(int)dr["company_code"] )*/

					
						mi = new MessageInfo("user");
						mi.SenderUser = tmp;
						mi.Subject = (string) dr["message_subject"];
						mi.Body = (string)dr["message_body"];
						mi.Received = (DateTime)dr["visit_date"];
						mi.MsgId = (Guid) dr["message_code"];
						if(dr["attached_file"] != DBNull.Value)
						{
							Attachment att = new Attachment();
					
							byte[] image =(byte[]) dr["attached_file"];

							SqlBinary sb = new SqlBinary(image) ;
							att.AttachedFile = sb;
							att.FileName =(string) dr["f_name"];
							mi.FileAttachments.Add(att);
						}
						messages.Add(mi);
					
					}
					else
					{
						if(dr["attached_file"] != DBNull.Value)
						{
							Attachment att = new Attachment();
					
							byte[] image =(byte[]) dr["attached_file"];

							SqlBinary sb = new SqlBinary(image) ;
							att.AttachedFile = sb;
							att.FileName =(string) dr["f_name"];
							mi.FileAttachments.Add(att);
						}
					}
			
					lstMsgId = mi.MsgId;
				}
			
			}
			

			return messages;
		
		}

		public ArrayList getMessages()
		{	
			if(msgSender == "user")
				return getUserInbox();
			else
				return getCompInbox();
			return null;
		}

		public void DeleteMessage(Guid msgId)
		{
			if(msgSender == "user")
				DataGateway.DataGateway.DeleteMessageFromUserInbox(currentUser.Code, msgId);
			else
				DataGateway.DataGateway.DeleteMessageFromCompanyInbox(currentCompany.Code, msgId);
			foreach ( MessageInfo mi in messages)
			{
				if( mi.MsgId.Equals(msgId))
				{
					messages.Remove(mi);
					break;
				}
				
			}
				
		}

	}
}

