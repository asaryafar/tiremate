using System;

namespace Common
{
	/// <summary>
	/// Summary description for Utils.
	/// </summary>
	public class Utils
	{
		public static void OpenFile (string filename, System.Diagnostics.ProcessWindowStyle windowStyle)
		{
			System.Diagnostics.Process p = new System.Diagnostics.Process ();
			p.StartInfo.FileName = filename;
			p.StartInfo.CreateNoWindow = true;
			p.StartInfo.WindowStyle = windowStyle;
			p.Start();
		}

		/*

		public static string GetFileExtension ()
		{
			
		}
		public static System.Drawing.Image GetDefaultIcon (string filename)
		{

		}

		//'For looking at registry keys 
		//'To: Open key ready to look at 
		private long regOpenKey (long hKey, string lpSubKey, long phkResult);
		Private Declare Function RegOpenKey Lib "advapi32.dll" Alias "RegOpenKeyA" (ByVal hKey As Long,
ByVal lpSubKey As String, phkResult As Long) As Long
																																						 'To: Look at key
		Private Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal lpReserved As Long, lpType As Long, ByVal lpData As Any, lpcbData As Long) As Long
																																																									'To: Close the key when it's finished with
																																																																			  Private Declare Function RegCloseKey Lib "advapi32.dll" (ByVal hKey As Long) As Long

																																																																																							   Private Const HKEY_CLASSES_ROOT = &H80000000 
																																																																																																	  Private Const KEY_READ = &H20019 'To allow us to READ the registery keys 

		'For Drawing the icon 
		'To: Retrieve the icon from the .EXE, .DLL or .ICO 
		Private Declare Function ExtractIcon Lib "shell32.dll" Alias "ExtractIconA" (ByVal hInst As Long, ByVal lpszExeFileName As String, ByVal nIconIndex As Long) As Long
																																										 'To: Draw the icon into our picture box 
		Private Declare Function DrawIcon Lib "user32.dll" (ByVal hDC As Long, ByVal X As Long, ByVal Y As Long, ByVal hIcon As Long) As Long
																																		  'To: Clean up after our selves (destroy the icon that "ExtractIcon" created)
		Private Declare Function DestroyIcon Lib "user32.dll" (ByVal hIcon As Long) As Long 

																						'For Finding the System folder 
		Private Declare Function GetSystemDirectory Lib "kernel32.dll" Alias "GetSystemDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long

																																					   Private Sub GetDefaultIcon(FileName As String, Picture_hDC As Long ) 
		Dim TempFileName As String 'Never manipulate an input unless it doubles as an output
		Dim lngError As Long'For receiving error numbers
		Dim lngRegKeyHandle As Long'Stores the "handle" of the registry key that is currently open
		Dim strProgramName As String'Stores the contents of the first registry key
		Dim strDefaultIcon As String'Stores the contents of the second registry key
		Dim lngStringLength As Long'Sets / Returns the length of the output string
		Dim lngIconNumber As Long'Stores the icon number within a file
		Dim lngIcon As Long'Stores the "Icon Handle" for the default icon
		Dim intN As Integer 'For any temporary numbers

	
		 *  Actually, all the registed file extensions are stored in registry. They are
stored as the sub keys of HKEY_CLASSES_ROOT key.

In C#, you may use Microsoft.Win32.RegistryKey to access the registry, then
loop through all the HKEY_CLASSES_ROOT's sub keys, that is started with
"."(such as .bmp, .avi etc)

I also want to inform you that, the icon is not associated with certain
file extension. Each file extension has default open program(For details,
it also associates with certain behavior). And the icon is associated with
the open program and behavior. So you should first find the default open
behavior of the file extension, then find the associated icon.

Take .mp3 file for example:
1). Use RegistryKey.GetValue to get the (Default) program behavior
associated with ".mp3" file e
„Õ„œ: 1). Use RegistryKey.GetValue to get the (Default) program behavior
associated with ".mp3" file extension.(On my machine, it is "Winamp.File")
2). Find "Winamp.File" sub key also in HKEY_CLASSES_ROOT key.
3). There should be a "DefaultIcon" sub key in "Winamp.File".
4). Then, also use RegistryKey.GetValue method to retrieve the associated
icon address(On my machine, it is "C:\Program Files\Winamp\Winamp.exe,1")

At last, you should P/invoke ExtractAssociatedIcon Win32 API to retrieve
the associated icon.*/
	}
}
