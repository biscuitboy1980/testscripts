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

using CommonUtilLib;
using Ranorex;
using Ranorex.Core;

namespace ConfigurationWizardLib.UISpecific.SFF
{
	/// <summary>
	/// The Setup recording.
	/// </summary>
	public partial class Setup
	{

		public static string LinuxIP = "999.999.999.999";
		public static string ipval1;
		public static string SIM = "false";
			
			
	    //*************************************************************************************//
		//**********Copies and overwrites config files if necessarys***************************//
		//*************************************************************************************//
		
		public static void CopyConfigFiles()
		{		
		
		string fileName1 = "SFF_SUT.xml";
        string sourcePath = "DataFiles";
        string targetPath =  @"C:\Documents and Settings\All Users\Documents\Ultra Electronics Inc\Config Wizard";

        // Use Path class to manipulate file and directory paths.
        string sourceFile1 = System.IO.Path.Combine(sourcePath, fileName1);
        string destFile1 = System.IO.Path.Combine(targetPath, fileName1);
        
        
        // To copy a folder's contents to a new location:
        // Create a new target folder, if necessary.
        if (!System.IO.Directory.Exists(targetPath))
        {
            System.IO.Directory.CreateDirectory(targetPath);
        }

        // To copy a file to another location and 
        // overwrite the destination file if it already exists.
        System.IO.File.Copy(sourceFile1, destFile1, true);	
		}
		
	    //**************************************************************************************//
		//********************************Populates C2Host IP Address***************************//
		//**************************************************************************************//
		
		public static void EnterLinuxIP()
		{
			if (LinuxIP == "999.999.999.999")
			{
				Report.Info("Key sequence " + LinuxIP);
				string[] output = ipval1.Split('.');
				string w = output[0].ToString();
				string x = output[1].ToString();
				string y = output[2].ToString();
				string z = output[3].ToString();
				string a = w.PadLeft(3,'0');
				string b = x.PadLeft(3,'0');
				string c = y.PadLeft(3,'0');
				string d = z.PadLeft(3,'0');
				Keyboard.Press(a);
				Keyboard.Press(b);
				Keyboard.Press(c);
				Keyboard.Press(d);
			}
			else
			{
				Report.Info("Key sequence " + LinuxIP);
				string[] output = LinuxIP.Split('.');
				string w = output[0].ToString();
				string x = output[1].ToString();
				string y = output[2].ToString();
				string z = output[3].ToString();
				string a = w.PadLeft(3,'0');
				string b = x.PadLeft(3,'0');
				string c = y.PadLeft(3,'0');
				string d = z.PadLeft(3,'0');
				Keyboard.Press(a);
				Keyboard.Press(b);
				Keyboard.Press(c);
				Keyboard.Press(d);
			}
		}		
	


		public static void LaunchCfgWiz()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Launching Configuration Wizard from the Desktop");
			CommonUtilLib.Util.LaunchApp("Config Wizard");
		}
		
		public static void ExitSIM()
		{
			
			if (SIM == "false")
				{
				//Your code here. Code inside this method will not be changed by the code generator.
				Report.Info("Mouse Left Click item 'FormCfgwizard.MenuItemExit' at 44;10.");
				repo.FormCfgwizard.MenuItemExit.Click("44;10");
				Report.Info("Mouse Left Click item 'FormUnsaved_Changes.ButtonNo' at 38;12.");
				repo.FormUnsaved_Changes.ButtonNo.Click("38;12");
				}
			else
				{
				Report.Info("Mouse Left Click item 'FormCfgwizard.MenuItemOpen_Configuration' at 55;12.");
				repo.FormCfgwizard.MenuItemOpen_Configuration.Click("55;12");
				Report.Info("Mouse Left Click item 'FormOpen_Configuration.ButtonYes' at 30;12.");
				repo.FormOpen_Configuration.ButtonYes.Click("30;12");
				ConfigurationWizardLib.UISpecific.SetupSimulator.Setup.Start();
				}
		}

		public static void KillUltraProcesses()
		{
			CommonUtilLib.Util.KillProcess("sm.exe");
			CommonUtilLib.Util.KillProcess("sm.exe");
		    CommonUtilLib.Util.KillProcess("c2c.exe");   
		    CommonUtilLib.Util.KillProcess("c2m.exe");
		    CommonUtilLib.Util.KillProcess("qtderg.exe");
		    CommonUtilLib.Util.KillProcess("mids.exe");
		    CommonUtilLib.Util.KillProcess("mids_x25.exe");
		    CommonUtilLib.Util.KillProcess("FTMClient.exe");
		    CommonUtilLib.Util.KillProcess("cfgwizard.exe");
		    CommonUtilLib.Util.KillProcess("loader.exe");
		    CommonUtilLib.Util.KillProcess("RealView.exe");
		}

		public static void CloseExist()
			
		{
			Duration OrigDur1 = repo.FormCfgwizard.ButtonCloseInfo.SearchTimeout;
			repo.FormCfgwizard.ButtonCloseInfo.SearchTimeout = 500;
			
			Report.Info("Checking to see if 'FormConfiguration_Wizard.ButtonClose' Exists");
			
			if (repo.FormCfgwizard.ButtonCloseInfo.Exists())
				{
				Report.Info("Mouse Left Click item 'FormConfiguration_Wizard.ButtonClose' at Center.");
				repo.FormCfgwizard.ButtonClose.Click();
				}
			
			repo.FormCfgwizard.ButtonCloseInfo.SearchTimeout = OrigDur1;
		}


		public static void MaximizeExist()
			
		{
			Duration OrigDur1 = repo.FormConfiguration_Wizard.ButtonMaximizeInfo.SearchTimeout;
			repo.FormConfiguration_Wizard.ButtonMaximizeInfo.SearchTimeout = 1000;
			
			if (repo.FormConfiguration_Wizard.ButtonMaximizeInfo.Exists())
				{
				Report.Info("Mouse Left Click item 'FormConfiguration_Wizard.ButtonMaximize' at Center.");
				repo.FormConfiguration_Wizard.ButtonMaximize.Click();
				}
			
			repo.FormConfiguration_Wizard.ButtonMaximizeInfo.SearchTimeout = OrigDur1;
		}

		static Setup()
		{
			//Your recording specific initialization code goes here.
		}


	}
}
