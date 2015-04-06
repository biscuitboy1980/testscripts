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
using System.Diagnostics;
using System.Security.Principal;

using Ranorex;
using Ranorex.Core;

namespace SystemManagerLib.UISpecific.SetupSFF
{
	/// <summary>
	/// The Setup recording.
	/// </summary>
	public partial class SetupSFF
	{

		
	
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
		
		public void Linux_ip()
		{

			Report.Info("Key sequence " + LinuxIP);
			Keyboard.Press(LinuxIP);
		}		
		
		
		
		public void DataLinkStatus()
		{
			
//			if (repo.FormSystem_Manager___UNCLASS.TitleBarData_LinksInfo.Exists())
//			{
//			return;
//			}
//			else
//			{
//			repo.FormSystem_Manager___UNCLASS.ElementSm.Click("42;8");
//			repo.FormSm.MenuItemData_Links.Click("59;16");	
//			}
			
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
			
			Duration OrigDur = repo.FormSite_Creation_Needed.SearchTimeout;
			repo.FormSite_Creation_Needed.SearchTimeout = 2000;
			Report.Info("Checking to see if site setup is required");
			
			if (repo.FormSite_Creation_Needed.TextSetupSiteInfo.Exists())
				{
				//Your code here. Code inside this method will not be changed by the code generator.
				Report.Info("Site setup is required");
				repo.FormSite_Creation_Needed.ButtonLoad_Site.Click("23;13");
				
				Report.Info("Checking for load site from file warning dialogue");
				if (repo.FormLoad_Site_File.ButtonYesInfo.Exists())
					{
					Report.Info("Mouse Left Click item 'FormLoad_Site_File.ButtonYes' at 32;14.");
					repo.FormLoad_Site_File.ButtonYes.Click("32;14");
					}
				
				Report.Info("Loading saved site");
				repo.FormLoad_a_Site.ListItemSite1_site.Click("40;9");
				repo.FormLoad_a_Site.ButtonOpen.Click("23;5");
				Report.Info("Site file has been loaded");
				}
			
			Report.Info("Load site dialogue not detected");
			repo.FormSite_Creation_Needed.SearchTimeout = OrigDur;

		}


		public void StartStopRestartLinux()
		{
			Duration OrigDur1 = repo.Linux_StateInfo.SearchTimeout;
			repo.Linux_StateInfo.SearchTimeout = 3000;			
			
			if (repo.Linux_State.TextValue.Equals("Running"))
			{
				Report.Info("Linux is currently running, Mouse Left Click item 'FormSystem_Manager___UNCLASS.TextRestart'");
				repo.FormSystem_Manager___UNCLASS.TextRestart.Click();
				Report.Info("Mouse Left Click item 'FormSegment_Restart.ButtonYes'");
				repo.FormSegment_Restart.ButtonYes.Click();
				Report.Info("Waiting for Linux state to change to Running");
				
				while (repo.Linux_State.TextValue.Equals("Restarting"))
				{
					Report.Info("Waiting for Linux state to change");
					Delay.Seconds(1);
				}
				
				while (repo.Linux_State.TextValue.Equals("Stopping"))
				{
					Report.Info("Waiting for Linux state to change to Running");
					Delay.Seconds(1);
				}
				
				while (repo.Linux_State.TextValue.Equals("Generating"))
				{
					Report.Info("Waiting for Linux state to change to Running");
					Delay.Seconds(1);
				}
				
				while (repo.Linux_State.TextValue.Equals("Starting"))
				{
					Report.Info("Waiting for Linux state to change to Running");
					Delay.Seconds(1);
				}
				
				Delay.Seconds(5);
				Report.Info("Validating AttributeEqual (Text='Running')");
				Validate.Attribute(repo.Linux_StateInfo, "Text", "Running");	
				
				repo.Linux_StateInfo.SearchTimeout = OrigDur1;
			}
		
			else
			{
			
				if (repo.Linux_State.TextValue.Equals("Stopped"))
				{
					Report.Info("Linux is currently stopped, Mouse Left Click item 'FormSystem_Manager___UNCLASS.TextStart'");
					repo.FormSystem_Manager___UNCLASS.TextStart.Click();
					Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.TextStart'");
					Report.Info("Waiting for Linux state to change to Running");
					
					while (repo.Linux_State.TextValue.Equals("Starting"))
					{
						Report.Info("Waiting for Linux state to change");
						Delay.Milliseconds(500);
					}
					
					while (repo.Linux_State.TextValue.Equals("Generating"))
					{
						Report.Info("Waiting for Linux state to change to Running");
						Delay.Seconds(1);
					}

					Delay.Seconds(5);
					Report.Info("Validating AttributeEqual (Text='Running')");
					Validate.Attribute(repo.Linux_StateInfo, "Text", "Running");	
				}
				
				else
				{
					if (repo.Linux_State.TextValue.Equals("Fault"))
					{
						Report.Info("Linux is currently in a Fault state, Attempting to stop & start the system");
						Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.TextStop'");
						repo.FormSystem_Manager___UNCLASS.TextRestart.Click();
						Report.Info("Mouse Left Click item 'FormSegment_Restart.ButtonYes'");
						repo.FormSegment_Restart.ButtonYes.Click();
						Report.Info("Waiting for Linux state to change to Running");
						
						while (repo.Linux_State.TextValue.Equals("Restarting"))
							{
							Report.Info("Waiting for Linux state to change");
							Delay.Milliseconds(500);
							}
						
						while (repo.Linux_State.TextValue.Equals("Generating") || repo.Linux_State.TextValue.Equals("Starting") || repo.Linux_State.TextValue.Equals("Stopping"))
						{
							Report.Info("Waiting for Linux state to change to Running");
							Delay.Seconds(1);
						}
						
						Delay.Seconds(5);
						Report.Info("Validating AttributeEqual (Text='Running')");
						Validate.Attribute(repo.Linux_StateInfo, "Text", "Running");	
						
					}
					else
					{
						Report.Error("Unable to find a valid system state of Running, Stopped, or Fault on the Linux Segment");
					}
				}
			}
					
			repo.Linux_StateInfo.SearchTimeout = OrigDur1;
			
		}
				

		public void ToggleLink()
		{
			
//			Duration OrigDur1 = repo.FormSystem_Manager___UNCLASS.CellOFFInfo.SearchTimeout;
//			repo.FormSystem_Manager___UNCLASS.CellOFFInfo.SearchTimeout = 1000;
//			Duration OrigDur2 = repo.FormSystem_Manager___UNCLASS.CellONInfo.SearchTimeout;
//			repo.FormSystem_Manager___UNCLASS.CellONInfo.SearchTimeout = 1000;
//			Duration OrigDur3 = repo.FormSystem_Manager___UNCLASS.CellOPERInfo.SearchTimeout;
//			repo.FormSystem_Manager___UNCLASS.CellOPERInfo.SearchTimeout = 1000;
//
//			if (repo.FormSystem_Manager___UNCLASS.CellOFFInfo.Exists())
//			    {
//				Report.Info("Data Link is turned OFF, attemtping to turn ON");
//				Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.CellOFF'");
//				repo.FormSystem_Manager___UNCLASS.CellOFFInfo.SearchTimeout = OrigDur1;
//				repo.FormSystem_Manager___UNCLASS.CellOFF.Click("17;15");
//				repo.FormSystem_Manager___UNCLASS.CellONInfo.SearchTimeout = OrigDur2;
//				Validate.Attribute(repo.FormSystem_Manager___UNCLASS.CellONInfo, "Text", "ON");	
//				}
//
//			else
//			{	
//			    
//			    if (repo.FormSystem_Manager___UNCLASS.CellONInfo.Exists())
//				    {
//				    Report.Info("Data Link is already turned ON");
//				   	Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.CellON'");
//					repo.FormSystem_Manager___UNCLASS.CellON.Click("17;15"); 
//					repo.FormSystem_Manager___UNCLASS.CellOFFInfo.SearchTimeout = OrigDur1;
//					Validate.Attribute(repo.FormSystem_Manager___UNCLASS.CellOFFInfo, "Text", "OFF");	
//					Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.CellOFF'");
//					repo.FormSystem_Manager___UNCLASS.CellOFF.Click("17;15");
//					repo.FormSystem_Manager___UNCLASS.CellONInfo.SearchTimeout = OrigDur2;
//					Validate.Attribute(repo.FormSystem_Manager___UNCLASS.CellONInfo, "Text", "ON");
//				    }
//			    
//			    else
//			    {
//			    	
//					if (repo.FormSystem_Manager___UNCLASS.CellOPERInfo.Exists())
//					    {
//					    Report.Info("Link is already OPER, attempting to toggle the link");
//					   	Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.CellOPER'");
//						repo.FormSystem_Manager___UNCLASS.CellOPER.Click("17;15"); 
//						repo.FormSystem_Manager___UNCLASS.CellOFFInfo.SearchTimeout = OrigDur1;
//						Validate.Attribute(repo.FormSystem_Manager___UNCLASS.CellOFFInfo, "Text", "OFF");
//						Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.CellOFF'");
//						repo.FormSystem_Manager___UNCLASS.CellOFF.Click("17;15");
//						repo.FormSystem_Manager___UNCLASS.CellONInfo.SearchTimeout = OrigDur2;
//						Validate.Attribute(repo.FormSystem_Manager___UNCLASS.CellONInfo, "Text", "ON");
//					    }
//					else
//						{
//						Report.Error("Unable to find valid data link status");
//						}
//			    }
//			}
//			
//			repo.FormSystem_Manager___UNCLASS.CellOFFInfo.SearchTimeout = OrigDur1;
//			repo.FormSystem_Manager___UNCLASS.CellONInfo.SearchTimeout = OrigDur2;
//			repo.FormSystem_Manager___UNCLASS.CellOPERInfo.SearchTimeout = OrigDur3;			
			
		}

		public void LaunchSM()
		{
//		Report.Info("Launching System Manager");
//		CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
//		int OSBit = SharedFunctions.OSBit();
//				
//			if (OSBit == 32)
//			{
//				Process SystemManager = new Process();
//				SystemManager.StartInfo.FileName = @"C:\Program Files\Ultra Electronics Inc\ADSI\current\bin\sm.exe";
//				SystemManager.Start();
//			}
//			else
//			{
//				Process SystemManager = new Process();
//				SystemManager.StartInfo.FileName = @"C:\Program Files (x86)\Ultra Electronics Inc\ADSI\current\bin\sm.exe";
//				SystemManager.Start();
//			}
		}

		public void Validate_C2H_Connected()
		{
			Duration OrigDur = repo.FormSystem_Manager___UNCLASS.C2H_ConnectionInfo.SearchTimeout;
			repo.FormSystem_Manager___UNCLASS.C2H_ConnectionInfo.SearchTimeout = 3000;			
			
				if (repo.FormSystem_Manager___UNCLASS.C2H_Connection.TextValue.Equals("Connected"))
					{
					Report.Info("Validating AttributeEqual (Text='Connected')");
					Validate.Attribute(repo.FormSystem_Manager___UNCLASS.C2H_ConnectionInfo, "Text", "Connected");
					}
				
				else
					{
					////// Restarts C2H System Manager daemon on Linux //////
					Report.Info("Connected not found, restarting System Manager daemon on the C2H");
					System.Diagnostics.Process C2Hdaemon = new System.Diagnostics.Process();
					C2Hdaemon.StartInfo.FileName=@"c:/Program Files/Attachmate/RSecure/ssh.exe";
					C2Hdaemon.StartInfo.Arguments="-i ../keys/key -o StrictHostKeyChecking=no adsi@" + LinuxIP + " SM_RESTART";
					C2Hdaemon.Start();
					C2Hdaemon.WaitForExit();
					Delay.Seconds(5);
					Report.Info("Validating AttributeEqual (Text='Connected')");
					Validate.Attribute(repo.FormSystem_Manager___UNCLASS.C2H_ConnectionInfo, "Text", "Connected");
					}
				
			repo.FormSystem_Manager___UNCLASS.C2H_ConnectionInfo.SearchTimeout = OrigDur;
			
		}

//		public void SetupSIM()
//		{
//			
//			if (SIM == "false")
//				{
//				return;
//				}
//			else
//				{
//				Report.Info("Setting up Simulators System Manager");
//				SystemManagerLib.UISpecific.SetupSimulator.SetupSimulator.Start();
//				}
//		}


		static SetupSFF()
		{
			//Your recording specific initialization code goes here.
		}

		//***********************************************************************//
		//****Validates that the NTP time is synched on all segments and if it***//
		//*******it is not it synchs them using the C2H as the tim server********//
		//***********************************************************************//
		
//		public void ValidateTimeSych()
//		{
//			
//			if (repo.FormSystem_Manager___UNCLASS.TimeNotSynhcedInfo.Exists())
//			{
//				Report.Info("System times are out of sync, synchronizing time now");
//				Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.HyperlinkEditTimeSettings'");
//				repo.FormSystem_Manager___UNCLASS.HyperlinkEditTimeSettings.Click("20;8");
//				Report.Info("Mouse Left Click item 'FormNetwork_Time_Configurati.ButtonOpen'");
//				repo.FormNetwork_Time_Configurati.ButtonOpen.Click();
//				Report.Info("Mouse Left Click item 'ListItemSmall_Form_Factor'");
//				repo.ListItemSmall_Form_Factor.Click();
//				Report.Info("Mouse Left Click item 'FormNetwork_Time_Configurati.RadioButtonNormal'");
//				repo.FormNetwork_Time_Configurati.RadioButtonNormal.Click();
//				
//			
//					if  (repo.FormNetwork_Time_Configurati.CheckBoxTactical_Workstation.Checked)
//					{
//						Report.Info("Tactical Workstation time is selected to be sychronized");
//					}
//				
//					else
//					{
//						Report.Info("Mouse Left Click item 'FormNetwork_Time_Configurati.CheckBoxTactical_Workstation");
//						repo.FormNetwork_Time_Configurati.CheckBoxTactical_Workstation.Click();
//						Report.Info("Tactical Workstation time is selected to be sychronized");
//					}
//					
//					
//					if  (repo.FormNetwork_Time_Configurati.CheckBoxAdjust_Time.Checked)
//					{
//						Report.Info("Selecting to adjust time servers time to current time");
//					}
//				
//					else
//					{
//						Report.Info("Mouse Left Click item 'FormNetwork_Time_Configurati.CheckBoxAdjust_Time");
//						repo.FormNetwork_Time_Configurati.CheckBoxAdjust_Time.Click();
//						Report.Info("Selecting to adjust time servers time to current time");
//					}
//
//				Report.Info("Mouse Left Click item 'FormNetwork_Time_Configurati.ButtonOK'");
//				repo.FormNetwork_Time_Configurati.ButtonOK.Click();
//				Report.Info("Validating AttributeEqual (Text='Configuration is complete.  Please allow approximately 90 seconds for the segments to sync.') on item 'FormComplete.TextConfiguration_is_complet'.");
//				Validate.Attribute(repo.FormComplete.TextConfiguration_is_completInfo, "Text", "Configuration is complete.  Please allow approximately 90 seconds for the segments to sync.");
//				repo.FormComplete.TitleBarComplete.Click();
//				Report.Info("Mouse Left Click item 'FormComplete.ButtonOK");
//			    repo.FormComplete.ButtonOK.Click();
//			    Report.Info("Validating all system times have synchronized");
//			    
//			    Duration OrigDur = repo.FormSystem_Manager___UNCLASS.TimeSynchedInfo.SearchTimeout;
//				repo.FormSystem_Manager___UNCLASS.TimeSynchedInfo.SearchTimeout = 90000;
//			    
//			    bool result = Validate.Exists(repo.FormSystem_Manager___UNCLASS.TimeSynchedInfo, Validate.DefaultMessage, false);
//			    
//			   	repo.FormSystem_Manager___UNCLASS.TimeSynchedInfo.SearchTimeout = OrigDur;
//			    
//			    if (result == true)
//			    {
//			    	Report.Success("All system times have been synchronized");
//			    }
//			    else
//			    {
//			    	Report.Failure("System times failed to syncrhonize within 90 seconds");
//			    }
//			    
//
//			}
//
//			else
//			{
//				return;
//			}
//		}

		public void StartStopRestartC2H()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Mouse Left Click item 'FormSystem_Manager___UNCLASS.TextStart' at 29;13.");
			repo.FormSystem_Manager___UNCLASS.TextStart.Click("29;13");
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

        public void GetFocusSM()
        {
        	repo.FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASS.Focus();
        	Delay.Milliseconds(250);
        }

        public void RemoveAutostart()
        {
		
        string usr = WindowsIdentity.GetCurrent().Name.Split('\\')[1];	
		string fileName = "sm.ini";
        string sourcePath = "DataFiles";
        string targetPath =  @"C:\Users\" + usr + @"\Documents\Ultra Electronics Inc\System Manager";

        // Use Path class to manipulate file and directory paths.
        string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
        string destFile = System.IO.Path.Combine(targetPath, fileName);
        
        // To copy a folder's contents to a new location:
        // Create a new target folder, if necessary.
        if (!System.IO.Directory.Exists(targetPath))
        {
            System.IO.Directory.CreateDirectory(targetPath);
        }

        // To copy a file to another location and 
        // overwrite the destination file if it already exists.
        System.IO.File.Copy(sourceFile, destFile, true);	
        Report.Info("Copied " + fileName + " to " + targetPath);
		}
	
					
	}
}