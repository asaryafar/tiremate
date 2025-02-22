using System;
using System.Data;
using System.Collections;
using Message.DataGateway;
using System.Data.SqlTypes;
namespace Message.Domain
{
	/// <summary>
	/// Summary description for Folder.
	/// </summary>
	public class Sent
	{
		User currentUser;
		Company currentCompany;
		ArrayList messages;
		string msgSender;
		
		public Sent(User curUser)
		{
			currentUser = curUser;
			msgSender = "user";
		}

		public Sent(Company curCompany)
		{
			currentCompany = curCompany;
			msgSender = "company";
		}
		
		private ArrayList getCompSentItems()

		{
			DataSet ds = DataGateway.DataGateway.GetCompanySentItems(currentCompany.Code);
			messages = new ArrayList();	
			if(ds.Tables[0].Rows.Count !=0)
			{
				DataTable parent = ds.Tables[0];
				DataTable child = ds.Tables[1];
		
				Guid lstMsgId = Guid.Empty;
				MessageInfo mi = null;	
				
				/*for(int i=0;i<child.Columns.Count;i++)
					Console.WriteLine(child.Columns[i].Caption);*/

				foreach(DataRow pdr in parent.Rows)
				{
				
					if(!lstMsgId.Equals((Guid) pdr["message_code"]))
					{
						mi = new MessageInfo("company");
				
						mi.SenderComp = currentCompany;
				
						mi.Body = (string )pdr["message_body"];
						mi.MsgId = (Guid) pdr["message_code"];
						mi.Subject = (string) pdr["message_subject"];
						mi.CreationDate = (DateTime) pdr["create_date"];
						mi.SendInformation = new ArrayList();
						#region sent
						foreach(DataRow	cdr in child.Rows)
						{
							SendInfo si = new SendInfo();
							Company tmp = new Company();
							if(mi.MsgId.Equals(cdr["message_code"]))
							{
								tmp.fillCompanyInfo(Convert.ToInt32(cdr["company_code1"].ToString()));
								si.DestCompany = tmp;
								si.ActivationDate =(DateTime) cdr["activation_date"];

							
								si.VisitDate = (DateTime) DataGateway.DataGateway.GetVisitDate(mi.MsgId,si.DestCompany.Code);
								si.LastFlag = (bool) DataGateway.DataGateway.GetLastFlag(mi.MsgId, si.DestCompany.Code);
								mi.SendInformation.Add(si);	
						
							}
					
						}
						#endregion
						Attachment att = new Attachment();
						if( pdr["attached_file"] != DBNull.Value)
						{
							byte[] image =(byte[]) pdr["attached_file"];

							SqlBinary sb = new SqlBinary(image) ;
							att.AttachedFile = sb;
							att.FileName =(string) pdr["f_name"];
							mi.FileAttachments.Add(att);
						}
						messages.Add(mi);
						
					}
					else
					{
						Attachment att = new Attachment();
						if( pdr["attached_file"] != DBNull.Value)
						{
							byte[] image =(byte[]) pdr["attached_file"];

							SqlBinary sb = new SqlBinary(image) ;
							att.AttachedFile = sb;
							att.FileName =(string) pdr["f_name"];
							mi.FileAttachments.Add(att);
						}
						
					}
					lstMsgId = (Guid) pdr["message_code"];
				}
		
			}

				return messages;

		}
		private ArrayList getUserSentItems()
		{
			DataSet ds = DataGateway.DataGateway.GetUserSentItems(currentUser.Code);
			messages = new ArrayList();	
			if(ds.Tables[0].Rows.Count !=0)
			{
				DataTable parent = ds.Tables[0];
				DataTable child = ds.Tables[1];
							
				Guid lstMsgId = Guid.Empty;
				MessageInfo mi = null;
				#region tmp
			
				foreach(DataRow pdr in parent.Rows)
				{
					if(!lstMsgId.Equals(pdr["message_code"]))
					{
						mi = new MessageInfo("user");
				
						mi.SenderUser = currentUser;
				
						mi.Body = (string )pdr["message_body"];
						mi.MsgId = (Guid) pdr["message_code"];
						mi.Subject = (string) pdr["message_subject"];
						mi.CreationDate = (DateTime) pdr["create_date"];
						mi.SendInformation = new ArrayList();
						//mi.LastFlag = (bool) pdr["last_flag"];
						foreach(DataRow	cdr in child.Rows)
						{
							SendInfo si = new SendInfo();
							User tmp = new User();
							if(mi.MsgId.Equals(cdr["message_code"]))
							{
								tmp.fillUserInfo(Convert.ToInt32(cdr["user_code1"].ToString()));
								si.DestUser = tmp;
								si.ActivationDate =(DateTime) cdr["activation_date"];
								if(!(cdr["visit_date"]== DBNull.Value))
									si.VisitDate = (DateTime) cdr["visit_date"];
								si.LastFlag = (bool)DataGateway.DataGateway.GetLastFlagUser(mi.MsgId,tmp.Code);
								mi.SendInformation.Add(si);	
						
							}
					
					
						}
						Attachment att = new Attachment();
					
						if( pdr["attached_file"] != DBNull.Value)
						{
							byte[] image =(byte[]) pdr["attached_file"];

							SqlBinary sb = new SqlBinary(image) ;
							att.AttachedFile = sb;
							att.FileName =(string) pdr["f_name"];
							mi.FileAttachments.Add(att);
						}
						messages.Add(mi);
					}
					else
					{
						Attachment att = new Attachment();
					
						if( pdr["attached_file"] != DBNull.Value)
						{
							byte[] image =(byte[]) pdr["attached_file"];

							SqlBinary sb = new SqlBinary(image) ;
							att.AttachedFile = sb;
							att.FileName =(string) pdr["f_name"];
							mi.FileAttachments.Add(att);
						}
					}
					lstMsgId = (Guid) pdr["message_code"];
				}
				#endregion
	
			}
			return messages;

		}

		public ArrayList getMessages()
		{
			if(msgSender == "user")
				return getUserSentItems();
			else
				return getCompSentItems();
			return null;

		}
		public int deleteMessageFromServer(Guid msgId, int code)
		{
			if(msgSender == "company")
			
				return DataGateway.DataGateway.DeleteSentMessageFromServerComp(msgId, code);
			else
				return DataGateway.DataGateway.DeleteSentMessageFromServerUser(msgId,code);

		}
		public void deleteMessage(Guid msgId)
		{
			DataGateway.DataGateway.DeleteMessageFromSent(msgId);
		}

	}
}

