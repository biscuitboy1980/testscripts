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

namespace SystemManagerLib.UISpecific.Setup2SFF
{
	/// <summary>
	/// The Setup recording.
	/// </summary>
	public partial class Setup2SFF
	{
		
		
		public string ip1csv = "999.999.999.999";
		public string ip2csv = "999.999.999.999";
		public string ipval1;
		public string ipval2;
		
		
		static Setup2SFF()
		{
			//Your recording specific initialization code goes here.
		}
	
		//*************************************************************************************//
		//**********Copies and overwrites config files if necessarys***************************//
		//*************************************************************************************//
		
		public void CopySiteFiles()
		{		
		
		string fileName1 = "Site1.site";
		string fileName2 = "Site2.site";
        string sourcePath = "DataFiles";
        string targetPath =  @"C:\Documents and Settings\All Users\Documents\Ultra Electronics Inc\System Manager";

        // Use Path class to manipulate file and directory paths.
        string sourceFile1 = System.IO.Path.Combine(sourcePath, fileName1);
        string destFile1 = System.IO.Path.Combine(targetPath, fileName1);
       
        string sourceFile2 = System.IO.Path.Combine(sourcePath, fileName2);
        string destFile2 = System.IO.Path.Combine(targetPath, fileName2);
        
        // To copy a folder's contents to a new location:
        // Create a new target folder, if necessary.
        if (!System.IO.Directory.Exists(targetPath))
        {
            System.IO.Directory.CreateDirectory(targetPath);
        }

        // To copy a file to another location and 
        // overwrite the destination file if it already exists.
        System.IO.File.Copy(sourceFile1, destFile1, true);	
        System.IO.File.Copy(sourceFile2, destFile2, true);
        Report.Info("Copied " + fileName1 + " & " + fileName2 + " to C:/Documents and Settings/All Users/Documents/Ultra Electronics Inc/System Manager");
		}
		
		
		//*************************************************************************************//
		//**********Deletes System Manager Connections File************************************//
		//*************************************************************************************//
		
		public void DeleteSMConfig()
		{			

			if (File.Exists(@"C:\Documents and Settings\All Users\Documents\Ultra Electronics Inc\System Manager\configs.dat"))
      	    {
        	FileInfo SMConfFile = new FileInfo(@"C:\Documents and Settings\All Users\Documents\Ultra Electronics Inc\System Manager\configs.dat");
        	SMConfFile.Delete();
        	Report.Info("Deleted C:/Documents and Settings/All Users/Documents/Ultra Electronics Inc/System Manager/configs.dat");
      	    }
			else 
			{
				Report.Warn("Failed to find C:/Documents and Settings/All Users/Documents/Ultra Electronics Inc/System Manager/configs.dat, skipping deletion");
			}
			
		}
            
        
		
		//**************************************************************************************//
		//********************************Populates C2Host IP Address***************************//
		//**************************************************************************************//
		
		public void SFF3()
		{
			if (ip1csv == "999.999.999.999")
			{
				Report.Info("Key sequence 'ipval1'.");
				Keyboard.Press(ipval1);
			}
			else
			{
				Report.Info("Key sequence 'ip1csv'.");
				Keyboard.Press(ip1csv);
			}
		}		
		
		//**************************************************************************************//
		//********************************Populates C2Host 2 IP Address*************************//
		//**************************************************************************************//
		
		public void SFF4()
		{
			if (ip2csv == "999.999.999.999")
			{
				Report.Info("Key sequence 'ipval2'.");
				Keyboard.Press(ipval2);
			}
			else
			{
				Report.Info("Key sequence 'ip2csv'.");
				Keyboard.Press(ip2csv);
			}
		}

		public void DataLinkStatus()
		{
			
			if (repo.FormSystem_Manager___UNCLASS.TitleBarData_LinksInfo.Exists())
		
			{
			return;
			}
			else
			{
			repo.FormSystem_Manager___UNCLASS.ElementSm.Click("42;8");
			repo.FormSm.MenuItemData_Links.Click("59;16");	
			}
		}


		public void ApplicationStatus()
		{
			if (repo.FormSystem_Manager___UNCLASS.TitleBarApplication_StatusInfo.Exists())
			{
			return;
			}
			else
			{
			repo.FormSystem_Manager___UNCLASS.ElementSm.Click("44;13");
			repo.FormSm.MenuItemApplication_Status.Click("34;6");
			}
		}

		public void LoadSite1()
		{
			
			Duration OrigDur = repo.FormSite_Creation_Needed.TextSetupSiteInfo.SearchTimeout;
			repo.FormSite_Creation_Needed.TextSetupSiteInfo.SearchTimeout = 500;
			
			if (repo.FormSite_Creation_Needed.TextSetupSiteInfo.Exists())
				
				{
				//Your code here. Code inside this method will not be changed by the code generator.
				repo.FormSite_Creation_Needed.ButtonLoad_Site.Click("23;13");
				
				Report.Info("Checking for load site from file warning dialogue");
				if (repo.FormLoad_Site_File.ButtonYesInfo.Exists())
					{
					Report.Info("Mouse Left Click item 'FormLoad_Site_File.ButtonYes' at 32;14.");
					repo.FormLoad_Site_File.ButtonYes.Click("32;14");
					}
				
				repo.FormLoad_a_Site.ListItemSite1_site.Click("40;9");
				repo.FormLoad_a_Site.ButtonOpen.Click("23;5");
				Report.Info("Site file has been loaded");
				}
			
			Report.Info("Site file has been loaded");
			repo.FormSite_Creation_Needed.TextSetupSiteInfo.SearchTimeout = OrigDur;

		}
		
		public void LoadSite2()
		{
			
			Duration OrigDur = repo.FormSite_Creation_Needed.TextSetupSiteInfo.SearchTimeout;
			repo.FormSite_Creation_Needed.TextSetupSiteInfo.SearchTimeout = 500;
			
			if (repo.FormSite_Creation_Needed.TextSetupSiteInfo.Exists())
				{
				//Your code here. Code inside this method will not be changed by the code generator.
				repo.FormSite_Creation_Needed.ButtonLoad_Site.Click("23;13");
				
				Report.Info("Checking for load site from file warning dialogue");
				if (repo.FormLoad_Site_File.ButtonYesInfo.Exists())
					{
					Report.Info("Mouse Left Click item 'FormLoad_Site_File.ButtonYes' at 32;14.");
					repo.FormLoad_Site_File.ButtonYes.Click("32;14");
					}
				
				repo.FormLoad_a_Site.ListItemSite2_site.Click("40;9");
				repo.FormLoad_a_Site.ButtonOpen.Click("23;5");
				}
			
			repo.FormSite_Creation_Needed.TextSetupSiteInfo.SearchTimeout = OrigDur;

		}

		public void StartStopRestart()
		{
			Duration OrigDur1 = repo.FormSystem_Manager___UNCLASS.TextStoppedInfo.SearchTimeout;
			repo.FormSystem_Manager___UNCLASS.TextStoppedInfo.SearchTimeout = 500;
			Duration OrigDur2 = repo.FormSystem_Manager___UNCLASS.TextFaultInfo.SearchTimeout;
			repo.FormSystem_Manager___UNCLASS.TextFaultInfo.SearchTimeout = 500;
			Duration OrigDur3 = repo.FormSystem_Manager___UNCLASS.TextRunningInfo.SearchTimeout;
			repo.FormSystem_Manager___UNCLASS.TextRunningInfo.SearchTimeout = 500;
			

			
			if (repo.FormSystem_Manager___UNCLASS.TextRunningInfo.Exists())
			{
				Report.Info("System is currently running, Mouse Left Click item 'FormSystem_Manager___UNCLASS.TextRestart'");
				repo.FormSystem_Manager___UNCLASS.TextRestart.Click();
				Report.Info("Mouse Left Click item 'FormSegment_Restart.ButtonYes'");
				repo.FormSegment_Restart.ButtonYes.Click();
				Report.Info("Validating AttributeEqual (Text='Restarting') on item 'FormSystem_Manager___UNCLASS.TextRestarting'.");
				Validate.Attribute(repo.FormSystem_Manager___UNCLASS.TextRestartingInfo, "Text", "Restarting");
				repo.FormSystem_Manager___UNCLASS.TextRunningInfo.SearchTimeout = OrigDur3;	
				Report.Info("Validating AttributeEqual (Text='Running') on item 'FormSystem_Manager___UNCLASS.TextRunning'.");
				Validate.Attribute(repo.FormSystem_Manager___UNCLASS.TextRunningInfo, "Text", "Running");
			}
			else
			{
			
				if (repo.FormSystem_Manager___UNCLASS.TextStoppedInfo.Exists())
				{
					Report.Info("System is currently stopped, Mouse Left Click item 'FormSystem_Manager___UNCLASS.TextStart'");
					repo.FormSystem_Manager___UNCLASS.TextStart.Click();
					Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.TextStart'");
					repo.FormSystem_Manager___UNCLASS.TextStart.Click();
					Report.Info("Validating AttributeEqual (Text='Starting') on item 'FormSystem_Manager___UNCLASS.TextStarting'");
					Validate.Attribute(repo.FormSystem_Manager___UNCLASS.TextStartingInfo, "Text", "Starting");
					repo.FormSystem_Manager___UNCLASS.TextRunningInfo.SearchTimeout = OrigDur3;	
					Report.Info("Validating AttributeEqual (Text='Running') on item 'FormSystem_Manager___UNCLASS.TextRunning'.");
					Validate.Attribute(repo.FormSystem_Manager___UNCLASS.TextRunningInfo, "Text", "Running");	
				}
				
				else
				{
					if (repo.FormSystem_Manager___UNCLASS.TextFaultInfo.Exists())
					{
						Report.Info("System is currently in a Failed state, Attempting to stop & start the system");
						Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.TextStop'");
						repo.FormSystem_Manager___UNCLASS.TextStop.Click();
						Report.Info("Mouse Left Click item 'FormSegment_Stop.ButtonYes'");
						repo.FormSegment_Stop.ButtonYes.Click();
						Report.Info("Validating AttributeEqual (Text='Stopping') on item 'FormSystem_Manager___UNCLASS.TextStopping'.");
						Validate.Attribute(repo.FormSystem_Manager___UNCLASS.TextStoppingInfo, "Text", "Stopping");
						Report.Info("Validating AttributeEqual (Text='Stopped') on item 'FormSystem_Manager___UNCLASS.TextStopped'.");
						Validate.Attribute(repo.FormSystem_Manager___UNCLASS.TextStoppedInfo, "Text", "Stopped");
						Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.TextStart'");
						repo.FormSystem_Manager___UNCLASS.TextStart.Click();
						Report.Info("Validating AttributeEqual (Text='Starting') on item 'FormSystem_Manager___UNCLASS.TextStarting'.");
						Validate.Attribute(repo.FormSystem_Manager___UNCLASS.TextStartingInfo, "Text", "Starting");
						repo.FormSystem_Manager___UNCLASS.TextRunningInfo.SearchTimeout = OrigDur3;	
						Report.Info("Validating AttributeEqual (Text='Running') on item 'FormSystem_Manager___UNCLASS.TextRunning'.");
						Validate.Attribute(repo.FormSystem_Manager___UNCLASS.TextRunningInfo, "Text", "Running");	
					}
					else
					{
						Report.Error("Unable to find a valid system state of Running, Stopped, or Failed");
					}
				}
			}
						
			repo.FormSystem_Manager___UNCLASS.TextStoppedInfo.SearchTimeout = OrigDur1;
			repo.FormSystem_Manager___UNCLASS.TextFaultInfo.SearchTimeout = OrigDur2;	
			repo.FormSystem_Manager___UNCLASS.TextRunningInfo.SearchTimeout = OrigDur3;	
			
		}
				

		public void ToggleLink()
		{
			
			Duration OrigDur1 = repo.FormSystem_Manager___UNCLASS.CellOFFInfo.SearchTimeout;
			repo.FormSystem_Manager___UNCLASS.CellOFFInfo.SearchTimeout = 250;
			Duration OrigDur2 = repo.FormSystem_Manager___UNCLASS.CellONInfo.SearchTimeout;
			repo.FormSystem_Manager___UNCLASS.CellONInfo.SearchTimeout = 250;
			Duration OrigDur3 = repo.FormSystem_Manager___UNCLASS.CellOPERInfo.SearchTimeout;
			repo.FormSystem_Manager___UNCLASS.CellOPERInfo.SearchTimeout = 250;

			if (repo.FormSystem_Manager___UNCLASS.CellOFFInfo.Exists())
			    {
				Report.Info("Data Link is turned OFF, attemtping to turn ON");
				Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.CellOFF'");
				repo.FormSystem_Manager___UNCLASS.CellOFFInfo.SearchTimeout = OrigDur1;
				repo.FormSystem_Manager___UNCLASS.CellOFF.Click("17;15");
				repo.FormSystem_Manager___UNCLASS.CellONInfo.SearchTimeout = OrigDur2;
				Validate.Attribute(repo.FormSystem_Manager___UNCLASS.CellONInfo, "Text", "ON");	
				}

			else
			{	
			    
			    if (repo.FormSystem_Manager___UNCLASS.CellONInfo.Exists())
				    {
				    Report.Info("Data Link is already turned ON");
				   	Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.CellON'");
					repo.FormSystem_Manager___UNCLASS.CellON.Click("17;15"); 
					repo.FormSystem_Manager___UNCLASS.CellOFFInfo.SearchTimeout = OrigDur1;
					Validate.Attribute(repo.FormSystem_Manager___UNCLASS.CellOFFInfo, "Text", "OFF");	
					Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.CellOFF'");
					repo.FormSystem_Manager___UNCLASS.CellOFF.Click("17;15");
					repo.FormSystem_Manager___UNCLASS.CellONInfo.SearchTimeout = OrigDur2;
					Validate.Attribute(repo.FormSystem_Manager___UNCLASS.CellONInfo, "Text", "ON");
				    }
			    
			    else
			    {
			    	
					if (repo.FormSystem_Manager___UNCLASS.CellOPERInfo.Exists())
					    {
					    Report.Info("Link is already OPER, attempting to toggle the link");
					   	Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.CellOPER'");
						repo.FormSystem_Manager___UNCLASS.CellOPER.Click("17;15"); 
						repo.FormSystem_Manager___UNCLASS.CellOFFInfo.SearchTimeout = OrigDur1;
						Validate.Attribute(repo.FormSystem_Manager___UNCLASS.CellOFFInfo, "Text", "OFF");
						Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.CellOFF'");
						repo.FormSystem_Manager___UNCLASS.CellOFF.Click("17;15");
						repo.FormSystem_Manager___UNCLASS.CellONInfo.SearchTimeout = OrigDur2;
						Validate.Attribute(repo.FormSystem_Manager___UNCLASS.CellONInfo, "Text", "ON");
					    }
					else
						{
						Report.Error("Unable to find valid data link status");
						}
			    }
			}
			
			repo.FormSystem_Manager___UNCLASS.CellOFFInfo.SearchTimeout = OrigDur1;
			repo.FormSystem_Manager___UNCLASS.CellONInfo.SearchTimeout = OrigDur2;
			repo.FormSystem_Manager___UNCLASS.CellOPERInfo.SearchTimeout = OrigDur3;			
			
		}

		public void LaunchSM()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			Report.Info("Launching System Manager from the Desktop");
			SharedFunctions.LaunchApp("System Manager");
		}


		
		public void RestartDaemonsSys1()
		{
				
				////// Restarts Trackserverd & SystemManagerd //////
				
				System.Diagnostics.Process InstallSys1 = new System.Diagnostics.Process();
				InstallSys1.EnableRaisingEvents=false;
				InstallSys1.StartInfo.FileName=@"c:/Program Files/PuTTY/putty.exe";
				InstallSys1.StartInfo.Arguments="-ssh -2 -P 22 huser@" + ip1csv + " -pw password -m DataFiles/RestartDaemons.bat";
				InstallSys1.Start();
				Console.WriteLine("Restarting Trackserver & System Manager server deamons on System 1");
				InstallSys1.WaitForExit();
		}
		
		public void RestartDaemonsSys2()
		{
				
				////// Restarts Trackserverd & SystemManagerd //////
				
				System.Diagnostics.Process InstallSys1 = new System.Diagnostics.Process();
				InstallSys1.EnableRaisingEvents=false;
				InstallSys1.StartInfo.FileName=@"c:/Program Files/PuTTY/putty.exe";
				InstallSys1.StartInfo.Arguments="-ssh -2 -P 22 huser@" + ip2csv + " -pw password -m DataFiles/RestartDaemons.bat";
				InstallSys1.Start();
				Console.WriteLine("Restarting Trackserver & System Manager server deamons on System 2");
				InstallSys1.WaitForExit();
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

	}
}