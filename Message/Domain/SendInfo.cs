using System;

namespace Message.Domain
{
	/// <summary>
	/// Summary description for SendInfo.
	/// </summary>
	public class SendInfo
	{
		DateTime activationDate, visitDate;
		User usr;
		Company comp;
		bool lastflag = false;
		public SendInfo(User tmp, DateTime actDate)
		{
			usr = tmp;
			activationDate = actDate;
		}
		public SendInfo(Company tmp, DateTime actDate)
		{
			comp = tmp;
			activationDate = actDate;
		}
		public SendInfo()
		{
		}
		public Company DestCompany
		{
			set {comp = value;}
			get	{ return comp;}
		}
		public User DestUser
		{
			set 
			{
				usr = value;
			}
			get
			{
				return usr;
			}
		}

		public DateTime ActivationDate
		{
			set
			{
				activationDate = value;
			}
			get
			{
				return  activationDate;
			}

		}
		public DateTime VisitDate
		{
			set
			{
				visitDate = value;
			}
			get
			{
				return  visitDate;
			}

		}
		public bool LastFlag 
		{
			set
			{ 
				lastflag = value;
			}
			get
			{
				return lastflag;
			}
		}

	}
}
