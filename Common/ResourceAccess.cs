using System;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;
using System.Threading;
using CommonClass;
namespace Common
{
	/// <summary>
	/// Summary description for ResourceAccess.
	/// </summary>
	public class ResourceAccess
	{
		private string strResourcesPath= CommonClass.MainModule.PubMainImagePath + "\\Resources";
		private string strCulture= System.Configuration.ConfigurationSettings.AppSettings["culture"].ToString();
		public enum Cultures {FA, EN}
		public Cultures Culture 
		{
			get 
			{
				if(strCulture == "en-US") return Cultures.EN;
				else if(strCulture == "fa-IR") return Cultures.FA;
				return Cultures.EN;
			}
		}
		private static ResourceManager rm;
		public static ResourceAccess RA= new ResourceAccess();

		public ResourceManager RM
		{
			get
			{
				return rm ;
			}
		}
		private ResourceAccess()
		{
			GlobalizeApp();
		}
		private void GlobalizeApp()
		{
			SetCulture();
			SetResource();
		}
		private void SetCulture()
		{
			//CultureInfo objCI = new CultureInfo(strCulture);
			//Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US", false);
			

            
		}
		private void SetResource()
		{
			if(strCulture == "en-US")
				rm = ResourceManager.CreateFileBasedResourceManager
					("msg-en", strResourcesPath, null);
			else if(strCulture == "fa-IR")
				rm = ResourceManager.CreateFileBasedResourceManager
					("msg-fa", strResourcesPath, null);
		}
	}
}
