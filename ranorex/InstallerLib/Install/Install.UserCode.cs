﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Ranorex;
using Ranorex.Core;

namespace InstallerLib.Install
{
    public partial class  Install
    {
                        	
        public string ip1=""; 
        public string ip2="";  
        public string user1="";
        public string user2="";
        public string password1="";
        public string password2="";      
  		public string rpmname = "";
        public string linuxRpmPath = "";
        public string windowsZipPath = "";
       
//  TODO Create csv connector    
//
//		static Install()
//		{
//			CSVConnector con2 = new CSVConnector ("DataFiles/connections.csv");
//			foreach( System.Data.DataRow r in con2.Rows)
//			{
//				ip1 = r["ip1"].ToString();	         		
//   	   			ip2 = r["ip2"].ToString();
//				user1 = r["user1"].ToString();	         		
//   	   			user2 = r["user2"].ToString();
//   	   			password1 = r["Password1"].ToString();
//   	   			password2 = r["Password2"].ToString();				
//			}
//		}
        
        public void typeWindowsPath()
        {
        	Keyboard.Press(windowsZipPath);
        }
        public void typeLinuxPath()
        {
        	Keyboard.Press(linuxRpmPath);
        }        
        //*************************************************************************************//
		//**********Creates folers and removes hudson files if necessary***********************//
		//*************************************************************************************//
		
		public void SetupFolders()
		{		
			
			string targetPath =  @"C:\Documents and Settings\All Users\Desktop\Hudson Files\";
			
			// Create a new target folder, if necessary.
			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}
			
			// Serch for existing Windows install zips
			DirectoryInfo HudsonDir = new System.IO.DirectoryInfo(targetPath);
			FileInfo [] WinFile = HudsonDir.GetFiles("*.zip");
			
			// Delete if windows zip exists
			if (WinFile.Length != 0)
			{
				foreach(FileInfo i in WinFile){
					Report.Info("Deleted ", i.ToString());
					i.Delete();
				}
			}
			else
			{
				Report.Info(@"Failed to find C:\Documents and Settings\All Users\Desktop\Hudson Files\*.zip, skipping deletion");
			}

			// Serch for existing Linux install rpms
			FileInfo [] LinFile = HudsonDir.GetFiles("*.rpm");
			
			// Delete linux rpm files that exist
			if (LinFile.Length != 0)
			{
				foreach( FileInfo x in LinFile){
					Report.Info("Deleted ", x.ToString());
					x.Delete();
				}
			}
			else
			{
				Report.Info(@"Failed to find C:\Documents and Settings\All Users\Desktop\Hudson Files\*.rpm, skipping deletion");
			}
			
			//find all folders
			DirectoryInfo [] WindowsFolder = HudsonDir.GetDirectories("*");
			// Delete if folders exist
			if (WindowsFolder.Length != 0)
			{
				foreach(DirectoryInfo i in WindowsFolder){
					Report.Info("Deleted ", i.ToString());
					Directory.Delete(HudsonDir + i.ToString(),true);
				}
			}
			else
			{
				Report.Info(@"Failed to any folders, skipping deletion");
			}			
			
			Report.Success("Done Setting up Hudson Folder and deleting old files");			
			
		}
		
		public void WriteVersionFile()
		{
			/*string targetPath =  @"C:\Documents and Settings\All Users\Desktop\Hudson Files";	
			
			// Create a new file, if necessary.
			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}
			
			// Serch for existing Windows install zips
			DirectoryInfo HudsonDir = new System.IO.DirectoryInfo(targetPath);
			FileInfo [] WinFile = HudsonDir.GetFiles("*.zip");
			
			// Delete if windows zip exists
			if (WinFile.Length != 0)
			{
				foreach(FileInfo i in WinFile){
					Report.Info("Deleted ", WinFile[0].ToString());
					WinFile[0].Delete();
				}
			}
			else
			{
				Report.Info(@"Failed to find C:\Documents and Settings\All Users\Desktop\Hudson Files\*.zip, skipping deletion");
			}

			// Serch for existing Linux install rpms
			FileInfo [] LinFile = HudsonDir.GetFiles("*.rpm");
			
			// Delete linux rpm files that exist
			if (LinFile.Length != 0)
			{
				foreach( FileInfo x in LinFile){
					Report.Info("Deleted ", x.ToString());
					x.Delete();
				}
			}
			else
			{
				Report.Info(@"Failed to find C:\Documents and Settings\All Users\Desktop\Hudson Files\*.rpm, skipping deletion");
			}
			Report.Success("Done Writing Version file to Desktop");		*/	
		}

		

		public void Click_Checkbox()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			if (repo.FormFolder_Options.TreeItemHide_extensions_for_know.Checked){
				Report.Info("Mouse Left Click item 'FormFolder_Options.Tree30120' at 31;186.");
				repo.FormFolder_Options.TreeItemHide_extensions_for_know.Click();
			}
			
		}

		public void ADSISoftwareExists(){
			
			if(repo.DesktopExplorer.ListItemSystem_ManagerInfo.Exists())
			{
				Report.Info("Remove ADSI software with ADD/Remove programs");
				Keyboard.Press("{LWin down}r{LWin up}");
				Keyboard.Press("appwiz.cpl{Return}");
				repo.FormAdd_or_Remove_Programs.ButtonMaximize.Click();
				Delay.Seconds(2, false);
				repo.FormAdd_or_Remove_Programs.TextVersion_15_Windows_Softw.Click();
				repo.FormAdd_or_Remove_Programs.ButtonRemove.Click();
				Delay.Milliseconds(500,false);
				Keyboard.Press("{Return}");
			}
			
				
		}

		public void ScpFiles(){
			Report.Info("Copying over rpm file to both linux segments");
			Keyboard.Press("cmd{Return}");
			//Keyboard.Press("c{LShiftKey down}:{LShiftKey up}{Return}");
			//Keyboard.Press(@"cd C:\Program Files\Attachmate\RSecure\{Return}");
			Delay.Seconds(5, false);
			Report.Info("SCP to ip" + ip1);
			Keyboard.Press("scp " + '"' + @"C:\Documents and Settings\All Users\Desktop\Hudson Files\*.rpm" + '"' + " " + user1 + "@" + ip1 + ":/tmp{Return}");
			Delay.Seconds(2, false);
			Keyboard.Press("once{Return}");
			Delay.Seconds(5, false);
			Keyboard.Press(password1);
			Keyboard.Press(Keys.Return);
			Delay.Seconds(50, false);
			Report.Info("SCP to ip " + ip2);
			Keyboard.Press("scp " + '"' + @"C:\Documents and Settings\All Users\Desktop\Hudson Files\*.rpm" + '"' + " " + user2 + "@" + ip2 + ":/tmp{Return}");
			Delay.Seconds(2, false);
			Keyboard.Press("once{Return}");
			Delay.Seconds(5, false);
			Keyboard.Press(password2);
			Keyboard.Press(Keys.Return);
			Delay.Seconds(50, false);
		}
		
		public void getRpmName()
		{
			// Serch for existing Linux install rpms
			DirectoryInfo HudsonDir = new System.IO.DirectoryInfo(@"C:\Documents and Settings\All Users\Desktop\Hudson Files\");
			FileInfo [] LinFile = HudsonDir.GetFiles("*.rpm");
			rpmname = LinFile[0].ToString();
			Report.Info("rpm file name is: " + rpmname);
		}
		public void SSHinstall()
		{
			Report.Info("SSHing into system1 ip:" + ip1 + " user: " + user1);
			Keyboard.Press("ssh " + user1 + "@" + ip1 + "{Return}");
			Delay.Seconds(5);
			Keyboard.Press("once{Return}");Keyboard.Press(password1);Keyboard.Press(Keys.Return);
			StopADSI();
			Keyboard.Press("cd /tmp{Return}");
			Keyboard.Press("sudo rpm -Uvh --force --nomd5 " + rpmname + "{Return}");
			Delay.Seconds(20, false);
			Keyboard.Press("exit{Return}");
			Delay.Seconds(10, false);
			Report.Info("SSHing into system1 ip:" + ip2 + " user: " + user2);
			Keyboard.Press("ssh " + user2 + "@" + ip2 + "{Return}");
			Delay.Seconds(5, false);
			Keyboard.Press("once{Return}");Keyboard.Press(password2);Keyboard.Press(Keys.Return);
			StopADSI();
			Keyboard.Press("cd /tmp{Return}");
			Keyboard.Press("sudo rpm -Uvh --force --nomd5 " + rpmname + "{Return}");
			Delay.Seconds(30, false);
			Keyboard.Press("exit{Return}");
		}

		public void StopADSI()
		{
			Keyboard.Press("gapc{Return}");
			Keyboard.Press("cd config{Return}");
			Keyboard.Press("../goq -z{Return}");
			Delay.Seconds(12, false);
		}
		public void CloseDialogCheckBox()
		{
			Report.Info("Clicking check box to auto close download dialog when finishing the dowload");
			if(!repo.FormDowload.CheckBoxClose_this_dialog_box_wh.Checked){
				repo.FormDowload.CheckBoxClose_this_dialog_box_wh.Click();
			}
		}

		public void Wait_for_Download()
		{
			Report.Info("Waiting for windows download to finish");
			while(repo.FormCopying___.TitleBarCopying___Info.Exists() || repo.FormDowload.TitleBarPercentInfo.Exists()){
				Delay.Milliseconds (1000, false);
			}
			
		}

		public void Close()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			
		}

		public void Open_IE()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Opening Internet Explorer");
			Keyboard.Press("{LWin down}r{LWin up}");
			Delay.Milliseconds(500,false);
			Keyboard.Press("http://hudsonserver.ultra-ats.com:8080{Return}");
			while(!repo.FormDashboard__Hudson____Mic.TitleBarDashboard__Hudson____MicInfo.Exists()){
				Delay.Milliseconds(500,false);
			}
			Keyboard.Press(Keys.Tab);
			Delay.Milliseconds(1000, false);
		}

		public void LaunchMyComputer()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			//Util.LaunchApp("My Computer");
			Keyboard.Press("{LWin down}r{LWin up}");
			Delay.Milliseconds(500,false);
			Keyboard.Press("explorer{Return}");
		}

		public void OpenHudsonFiles()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Mouse Left DoubleClick item 'FormSave_As.ListItemHudson_Files' at 36;10.");
			Keyboard.Press("{LWin down}r{LWin up}");
			Delay.Milliseconds(500,false);
			Keyboard.Press(@"C:\Documents and Settings\All Users\Desktop\Hudson Files{Return}");
			
		}

		public void InstallDriversExists()
		{
			if((!repo.FormVersion_15_Windows_Softw.TitleBarVersion_15_Windows_SoftwInfo.Exists()) ||
			   (!repo.ButtonFinishInfo.Exists())){
				Report.Info("hitting left,enter to compensate for security warnings");
				Keyboard.Press("{Left}{Return}");
			}
			if(repo.ButtonFinishInfo.Exists()){
				Report.Info("Key sequence '{Right}{Return}'.");
				Keyboard.Press("{Right}{Return}");
			}
		}

		public void CloseAddRemove()
		{
			if(repo.FormAdd_or_Remove_Programs.ButtonCloseInfo.Exists())
			{
				repo.FormAdd_or_Remove_Programs.ButtonClose.Click();
			}
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
			
	}
}
			
		
		

