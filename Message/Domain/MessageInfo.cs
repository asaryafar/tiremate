using System;
using System.Data;
using System.Collections;
using Message.DataGateway;

namespace Message.Domain
	  {
	/// <summary>
	/// Summary description for MessageInfo.
	/// </summary>

	public class MessageInfo
	{
		string body, subject;
		Guid msgId;
		User user;
		Company company;
		ArrayList userSend;
		DateTime received,createDate;
		//bool lastFlag = false;
		string msgSender = "user";
		ArrayList attachments;
		ArrayList failed;

		public MessageInfo(string _msgSender)
		{
			msgId = Guid.Empty;
			body = subject = "";
			msgSender = _msgSender;
			attachments = new ArrayList();
			failed = new ArrayList();
		}
		public string Body
		{
			set { body = value; }
			get{ return body;}
		}
		public DateTime Received
		{
			set { received = value; }
			get{ return received;}
		}
		public DateTime CreationDate
		{
			set { createDate = value; }
			get{ return createDate;}
		}
		public string Subject 
		{
			set { subject = value;}
			get { return subject;}
		}
	/*	public bool LastFlag
		{
			set { lastFlag = value;}
			get { return lastFlag; }
		}*/
		public Guid MsgId
		{
			set { msgId = value;}
			get { return msgId;}
		}
		public ArrayList SendInformation
		{
			set { userSend = value;}
			get { return userSend;}
		}
		public string MsgSender
		{
			set { msgSender = value; }
			get { return msgSender;}
		}
		public User SenderUser
		{
			set { user = value;}
			get { return user;}
		}
		public Company SenderComp
		{
			set { company = value;}
			get { return company;}
		}
		public ArrayList FileAttachments
		{
			get{ return attachments;}
			set { attachments = value;}
		}
		public ArrayList FailedSend
		{
			get{ return failed;}
		}
		public void Send()
		{
			Guid msgId = Guid.Empty;
			if(msgSender == "user")
			{
				msgId = DataGateway.DataGateway.SendUserMessage(user.Code,body, subject);
				
				foreach (SendInfo tmp in userSend)
					DataGateway.DataGateway.AddDestUserList(msgId, tmp.DestUser.Code, tmp.ActivationDate);
				
				foreach (Attachment att in attachments)
					DataGateway.DataGateway.AddUserAttachmentsList(msgId, att.AttachedFile , att.FileName);

			}
			else
			{
				msgId = DataGateway.DataGateway.SendCompanyMessage(company.Code ,body, subject);
				
				foreach (SendInfo tmp in userSend)
					DataGateway.DataGateway.AddDestCompanyList(msgId, tmp.DestCompany.Code, tmp.ActivationDate);

				foreach (Attachment att in attachments)
					DataGateway.DataGateway.AddCompanyAttachmentsList(msgId, att.AttachedFile, att.FileName);
				
				bool success = false;
				foreach(SendInfo tmp in userSend)
				{
					if(tmp.DestCompany.CompanyShortName != company.CompanyShortName)
					{
						
						int res = DataGateway.DataGateway.CopyCompanyMessage(msgId,company.Code ,body, subject, tmp.DestCompany.Code);
						if(res == 0 )
						{
							success = true;
							DataGateway.DataGateway.AddRemoteDestCompanyList(msgId, tmp.DestCompany.Code, tmp.ActivationDate, tmp.DestCompany.Code);

							foreach (Attachment att in attachments)
								DataGateway.DataGateway.AddRemoteCompanyAttachmentsList(msgId, att.AttachedFile, att.FileName, tmp.DestCompany.Code);
						}
						else  
						{
							failed.Add(tmp.DestCompany);
							DataGateway.DataGateway.DeleteFailedMessageFromMessage_Send(msgId, tmp.DestCompany.Code);
						}

							
					}
					else
					{
						success = true;
					}
					

				}
				if (!success)
				{
					DataGateway.DataGateway.DeleteMessageFromSent(msgId);

				}
			}
				
		}



	}
}
