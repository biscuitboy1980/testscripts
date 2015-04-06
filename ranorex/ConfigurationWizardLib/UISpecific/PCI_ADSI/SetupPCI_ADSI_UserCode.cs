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

using CommonUtilLib;
using Ranorex;
using Ranorex.Core;

namespace ConfigurationWizardLib.UISpecific.PCI_ADSI
{
	/// <summary>
	/// The Setup recording.
	/// </summary>
	public partial class SetupPCI_ADSI
	{
		
		public string WinIP;
			
			
	    //*************************************************************************************//
		//**********Copies and overwrites config files if necessarys***************************//
		//*************************************************************************************//
		
		public void CopyConfigFiles()
		{		
		
		string fileName1 = "PCI_ADSI.xml";
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
		
		public void EnterC2Hip()
		{
			Report.Info("Key sequence " + C2Hip);
			string[] output = C2Hip.Split('.');
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
		
		//**************************************************************************************//
		//*******************************Populates TDLG IP Address***************************//
		//***************************************************************************************//
		
		public void EnterTDLGip()
		{
			if (TDLGip == "999.999.999.999")
			{
				Report.Info("Key sequence " + TDLGip);
				string[] output = TDLGip.Split('.');
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
				Report.Info("Key sequence " + TDLGip);
				string[] output = TDLGip.Split('.');
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


		public void CfgWizState()
		{
			
		   Duration OrigDur1 = repo.FormConfiguration_Wizard.RadioButtonOpen_a_Saved_ConfiguratiInfo.SearchTimeout;
		   repo.FormConfiguration_Wizard.RadioButtonOpen_a_Saved_ConfiguratiInfo.SearchTimeout = 2000;
		   Duration OrigDur2 = repo.FormConfiguration_Wizard.ButtonBrowseInfo.SearchTimeout;
		   repo.FormConfiguration_Wizard.ButtonBrowseInfo.SearchTimeout = 2000;
		   Duration OrigDur3 = repo.FormConfiguration_Wizard.SearchTimeout;
		   repo.FormConfiguration_Wizard.SearchTimeout = 100;
				
		   CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
	
			if (repo.FormConfiguration_Wizard.RadioButtonOpen_a_Saved_ConfiguratiInfo.Exists())
				{
				Report.Info("Mouse Left Click item 'FormConfiguration_Wizard.RadioButtonOpen_a_Saved_Configurati'");
				repo.FormConfiguration_Wizard.RadioButtonOpen_a_Saved_Configurati.Click("6,9");
				Report.Info("Mouse Left Click item 'FormConfiguration_Wizard.ButtonBrowse'");
				repo.FormConfiguration_Wizard.ButtonBrowse.Click();
				}
			
			if (repo.FormConfiguration_Wizard.ButtonBrowseInfo.Exists())
				{
				Report.Info("Mouse Left Click item 'FormConfiguration_Wizard.ButtonBrowse'");
				repo.FormConfiguration_Wizard.ButtonBrowse.Click();
				}
			else
				{
				Report.Info("Launching Configuration Wizard");
				int OSBit = SharedFunctions.OSBit();
				
				if (OSBit == 32)
					{
						Process CfgWiz = new Process();
						CfgWiz.StartInfo.FileName = @"C:\Program Files\Ultra Electronics Inc\ADSI\current\bin\cfgwizard.exe";
						CfgWiz.Start();
					}
					else
					{
						Process CfgWiz = new Process();
						CfgWiz.StartInfo.FileName = @"C:\Program Files (x86)\Ultra Electronics Inc\ADSI\current\bin\cfgwizard.exe";
						CfgWiz.Start();
					}
					
				repo.FormConfiguration_Wizard.RadioButtonOpen_a_Saved_ConfiguratiInfo.SearchTimeout = OrigDur1;
			    repo.FormConfiguration_Wizard.ButtonBrowseInfo.SearchTimeout = OrigDur2;
			    repo.FormConfiguration_Wizard.SearchTimeout = OrigDur3;

				Report.Info("Validating Exists on item 'FormConfiguration_Wizard.FormConfiguration_Wizard'.");
				Validate.Exists(repo.FormConfiguration_Wizard.FormConfiguration_WizardInfo);
				Report.Info("Mouse Left Click item 'FormConfiguration_Wizard.RadioButtonOpen_a_Saved_Configurati'");
				repo.FormConfiguration_Wizard.RadioButtonOpen_a_Saved_Configurati.Click("6,9");
				Report.Info("Mouse Left Click item 'FormConfiguration_Wizard.ButtonBrowse'");
				repo.FormConfiguration_Wizard.ButtonBrowse.Click();
				}
				
		}


		

		public void KillUltraProcesses()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			
			SharedFunctions.KillUltraProcesses();
		}

		public void CloseExist()
			
		{
			Duration OrigDur1 = repo.ButtonCloseInfo.SearchTimeout;
			repo.ButtonCloseInfo.SearchTimeout = 3000;
			
			Report.Info("Checking to see if 'FormConfiguration_Wizard.ButtonClose' Exists");
			
			if (repo.ButtonCloseInfo.Exists())
				{
				Report.Info("Mouse Left Click item 'ButtonClose' at Center.");
				repo.ButtonClose.Click();
				}
			
			repo.ButtonCloseInfo.SearchTimeout = OrigDur1;
		}


		public void MaximizeExist()
			
		{
			Duration OrigDur1 = repo.FormConfiguration_Wizard.ButtonMaximizeInfo.SearchTimeout;
			repo.FormConfiguration_Wizard.ButtonMaximizeInfo.SearchTimeout = 3000;
			
			if (repo.FormConfiguration_Wizard.ButtonMaximizeInfo.Exists())
				{
				Report.Info("Mouse Left Click item 'FormConfiguration_Wizard.ButtonMaximize' at Center.");
				repo.FormConfiguration_Wizard.ButtonMaximize.Click();
				}
			
			repo.FormConfiguration_Wizard.ButtonMaximizeInfo.SearchTimeout = OrigDur1;
		}

		public void UserCodeMethod1()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			
		}

		public void ExitSIM()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Mouse Left Click item 'FormCfgwizard.MenuItemExit' at 44;10.");
			repo.FormConfiguration_Wizard.MenuItemExit.Click("44;10");
		}

		public void SimulatorIP()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Mouse Left DoubleClick item 'DesktopExplorer.ListItemConfig_Wizard' at 40;26.");
			repo.DesktopExplorer.ListItemConfig_Wizard.DoubleClick("40;26");
		}

		static SetupPCI_ADSI()
		{
			//Your recording specific initialization code goes here.
		}

		public void Validate_FormConfiguration_Wizard1()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Validating Exists on item 'FormConfiguration_Wizard.FormConfiguration_Wizard'.");
			Validate.Exists(repo.FormConfiguration_Wizard.FormConfiguration_WizardInfo);
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}


        public void GetWinIP()
        {
        	CommonUtilLib.Util SharedFunction = new CommonUtilLib.Util();
        	WinIP = SharedFunction.GetLocalIP();
            
        }

        public void EnterWinIP()
		{

			Report.Info("Key sequence " + WinIP);
			string[] output = WinIP.Split('.');
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

        public void appform()
        {
        	CommonUtilLib.Forms.AwaitingDataForm adform = new CommonUtilLib.Forms.AwaitingDataForm();
        		adform.Show();
            
        }

        public void appkill()
        {
            // Your code goes here. Code inside this method will not be changed by the code generator.
            
        }

        public void AwaitingDataForm()
        {
        	
//        	CommonUtilLib.Util.DialogForm.AwaitingDataForm();
			CommonUtilLib.Forms.AwaitingDataForm ADform = new CommonUtilLib.Forms.AwaitingDataForm();
			ADform.Show();	

        }

	}
}
