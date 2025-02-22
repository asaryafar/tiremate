using System;
using System.Collections;
using System.IO;
using System.Data.SqlTypes;

namespace Message.Domain
{
	/// <summary>
	/// Summary description for Attachment.
	/// </summary>
	public class Attachment
	{
		SqlBinary file;
		int filesize;
		string filename;
		string filepath;
		public Attachment()
		{
		}
		public int FileSize
		{
			get { return filesize;}
		}
		public Attachment(string path)
		{
			filepath = path;
			readFile(path);
		}
		private void readFile(string path)
		{

			FileInfo fi = new FileInfo(path);
			FileStream fs = fi.OpenRead();
			byte[] bytes = new byte[fi.Length];
		
			fs.Read(bytes, 0,(int)(fi.Length-1<0 ? 0:fi.Length-1));
			file = new SqlBinary(bytes);
			filename = path;
			int pos = filename.LastIndexOf( "\\" );
		
			if( pos != -1 )
				filename = filename.Substring( pos+1 );
			filesize = file.Length;

		}

		public SqlBinary AttachedFile
		{
			get {return file;}
			set {file = value;} 
		}

		public string FileName
		{
			get {return filename;}
			set { filename= value;}
		}
		public string FilePath
		{
			get{return filepath;}
			set {filepath = value;}

		}
		public string SaveAttachmentAsTemp()
		{
			if(!Directory.Exists("Attachments"))
				Directory.CreateDirectory("Attachments");

			
				

				string filename = "Attachments\\"+ this.FileName;
				this.FilePath = filename;
				FileStream fs = File.Create(filename);
				fs.Write(this.AttachedFile.Value,0,this.AttachedFile.Length);
				fs.Close();
				
			return filename;
		}
	}
}
