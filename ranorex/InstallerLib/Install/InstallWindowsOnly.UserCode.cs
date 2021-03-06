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
using System.Net;
using System.Xml;
using System.Diagnostics;
using System.Management;
using Microsoft.Win32;
using System.Net.NetworkInformation;


using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Reporting;


namespace InstallerLib.Install
	
{
	/// <summary>
	/// The Recording1 recording.
	/// </summary>
	public partial class InstallWindowsOnly
		
	{	
		
		public string Lsvn;
		public string Wsvn;
		public string TVversion;
		public string Wfile;
		public string Lfile;
		public string svnmatch;
		public bool Win3InstallFlag = false;
		public int OSbit;
		public string currentDir;
		
		
		
		
		public void DelUltraTVDir()
		{
		string UltraTVDir = @"./Ultra Electronics Inc";
			
			if (Directory.Exists(UltraTVDir))
			{
				Directory.Delete(UltraTVDir, true);
				Console.WriteLine("Deleting " + UltraTVDir);
				Report.Info("Deleting " + UltraTVDir);
			}

		}


		public void CreateDirs()
		{
				
				
				////// Ensures InstallCDS/ADSI directory exists //////
				
				string InstallCDSADSIPath = "./InstallCDS/ADSI";
			
				if (!Directory.Exists(InstallCDSADSIPath))
					{
					Console.WriteLine("Creating Directory " + InstallCDSADSIPath);
					Report.Info("Creating Directory " + InstallCDSADSIPath);
					Directory.CreateDirectory(InstallCDSADSIPath);
					}
					
				
				////// Ensures InstallCDS/TacView directory exists //////
				
				string InstallCDSTVPath = "./InstallCDS/TacView";
			
				if (!Directory.Exists(InstallCDSTVPath))
					{
					Console.WriteLine("Creating Directory " + InstallCDSTVPath);
					Report.Info("Creating Directory " + InstallCDSTVPath);
					Directory.CreateDirectory(InstallCDSTVPath);
					}

				
				////// Ensures BuildInfo directory exists //////
				
				string BuildInfoPath = @"./BuildInfo";
			
				if (!Directory.Exists(BuildInfoPath))
					{
					Console.WriteLine("Creating Directory " + BuildInfoPath);
					Report.Info("Creating Directory " + BuildInfoPath);
					Directory.CreateDirectory(BuildInfoPath);
					}
				
				
		}
		
		public void GetRevision()
			
		{		
			
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
	   
			/// Determines Windows SVN number ///
			/// 
			
			WebClient Client2 = new WebClient ();
			
			
			switch(buildtype)
			{
				case "nightly":     
				Client2.DownloadFile("http://hudsonserver:8080/job/ADSI-Win-Trunk/lastSuccessfulBuild/artifact/trunk/FILENAME.txt", "./BuildInfo/WinRevInfo.txt");
				break;
				
				case "promoted":
				Client2.DownloadFile("http://hudsonserver:8080/job/ADSI-Win-Trunk/PCI%20ADSI%20Test/artifact/trunk/FILENAME.txt", "./BuildInfo/WinRevInfo.txt");
				break;	
				
				default:
				Report.Error("No build type specified, check parameters entered");
				break;
			}
			
			
			Wsvn = SharedFunctions.GetLine(@".\BuildInfo\WinRevInfo.txt", 2);
			Wsvn = Wsvn.Trim();
			Report.Info("Windows SVN number = "+ Wsvn);
			
			
			
			/// Determines Windows Filename ///
			
	        Wfile = SharedFunctions.GetLine(@".\BuildInfo\WinRevInfo.txt", 1);
	        Wfile = Wfile.Trim();
			Report.Info("Windows Filename = "+ Wfile);

		}
		
		
		
		
		public void CompareSVN()
		{
		
			bool result = (Wsvn == Lsvn);
			
			if (result == true)
			{
				Report.Info("Windows Build SVN #" + Wsvn + " matches Linux Build SVN #" + Lsvn);
				svnmatch = "PASS";
			}
			else
			{
			    Report.Info("Windows Build SVN #" + Wsvn + " does not match Linux Build SVN #" + Lsvn + " aborting smoke test");
			    StreamWriter SVNmismatch;
			    SVNmismatch = File.CreateText(@"svnmismatch.txt");
			    SVNmismatch.WriteLine("Linux SVN # = " + Lsvn);
			    SVNmismatch.WriteLine("Windows SVN # = " + Wsvn);
			    SVNmismatch.Close();
			    svnmatch = "FAIL";
			    Report.Failure("2 Segment Installation failed");	
			    Environment.Exit(-1);
			}
			
		}
		
			
						
								
						
				public void DownloadLatestWin()
				{
				
				////// Downloads latest passed Hudson Windows build //////
				
				Console.WriteLine("Downloading ADSI Windows SVN # " + Wsvn);
				Report.Info("Downloading ADSI Windows SVN # " + Wsvn);
				CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
				
				switch (buildtype)
					
					{
					case "nightly":
					SharedFunctions.ConsoleProgressBar("http://hudsonserver:8080/job/ADSI-Win-Trunk/lastSuccessfulBuild/artifact/trunk/install/win32/artifacts/" + Wfile, "./InstallCDS/ADSI/LatestWinBuild.zip");
					break;
					
					case "promoted":
					SharedFunctions.ConsoleProgressBar("http://hudsonserver:8080/job/ADSI-Win-Trunk/PCI%20ADSI%20Test/artifact/trunk/install/win32/artifacts/" + Wfile, "./InstallCDS/ADSI/LatestWinBuild.zip");
					break;	
				
					default:
					Report.Error("No build type specified, check parameters entered");
					break;
				
					
					}
				}

				
				public void UnzipLatestWin()
				{
				////// Unzip ADSIInstallCD zip file //////
				
				Console.WriteLine("Unzipping ADSI Windows Installer");
				Report.Info("Unzipping ADSI Windows Installer");
				System.Diagnostics.Process unzipwin = new System.Diagnostics.Process();
				unzipwin.EnableRaisingEvents=false;
				unzipwin.StartInfo.FileName=@"c:/Program Files/7-Zip/7z.exe";
				unzipwin.StartInfo.Arguments=@"x -y .\InstallCDS\ADSI\LatestWinBuild.zip -oInstallCDS/ADSI/LatestWinBuild";
				unzipwin.Start();
				unzipwin.WaitForExit();
				}
					
				
				public void InstallLatestWin()
				{
				///// Installs Latest Hudson ADSI Windows Software //////
				
				Console.WriteLine("Installing ADSI Windows SVN " + Wsvn);
				Report.Info("Installing ADSI Windows SVN " + Wsvn);
				System.Diagnostics.Process InstallWin = new System.Diagnostics.Process();
				InstallWin.EnableRaisingEvents=false;
				InstallWin.StartInfo.FileName=@currentDir + "\\InstallCDS\\ADSI/LatestWinBuild\\V15WinSoftware.exe";
				InstallWin.StartInfo.Arguments=@"/qb /Lime ADSI_install.log";
				InstallWin.Start();
				InstallWin.WaitForExit();

				
				if (repo.FormVersion_15_Windows_Softw.ButtonNext_Info.Exists() && repo.FormVersion_15_Windows_Softw.ButtonNext_.Enabled.Equals(true))
					{
					repo.FormVersion_15_Windows_Softw.ButtonNext_.Click();
					Report.Info("Checking to see if prerequisite applications are installed");
					
					if (repo.FormVersion_15_Windows_Softw.CellInstallInfo.Exists())
						{
						Report.Info("Java not installed, Java install will take place prior to ADSI software installation");
						}
					
					if (repo.FormVersion_15_Windows_Softw.CellInstall1Info.Exists())
						{
						Report.Info("LeftClick FormVersion_15_Windows_Softw.CellChipset");
						repo.FormVersion_15_Windows_Softw.CellChipset.Click(Location.CenterLeft);
						}
					
					if (repo.FormVersion_15_Windows_Softw.CellInstall2Info.Exists())
						{
						Report.Info("LeftClick FormVersion_15_Windows_Softw.CellEthernet");
						repo.FormVersion_15_Windows_Softw.CellEthernet.Click(Location.CenterLeft);
						}
					
					if (repo.FormVersion_15_Windows_Softw.CellInstall3Info.Exists())
						{
						Report.Info("LeftClick FormVersion_15_Windows_Softw.CellPutty");
						repo.FormVersion_15_Windows_Softw.CellPutty.Click(Location.CenterLeft);
						}
					if (repo.FormVersion_15_Windows_Softw.CellInstall4Info.Exists())
						{
						Report.Info("LeftClick FormVersion_15_Windows_Softw.CellVideo");
						repo.FormVersion_15_Windows_Softw.CellVideo.Click(Location.CenterLeft);
						}
					if (repo.FormVersion_15_Windows_Softw.CellInstall5Info.Exists())
						{		
						Report.Info("Windows 3.1 Installer is not installed, Windows 3.1 installer will take place prior to ADSI software installation");
	
						Win3InstallFlag = true;
						}
					
					Report.Info("LeftClick FormVersion_15_Windows_Softw.ButtonNext_");
					repo.FormVersion_15_Windows_Softw.ButtonNext_.Click();	
					
					if (repo.FormJava_Setup___Close_Appli.ButtonRetryInfo.Exists())
						{
						Report.Info("Java dialogue detected, closing running applications and retrying");
						repo.FormJava_Setup___Close_Appli.CheckBoxQuit_the_applications_li.Click();
						repo.FormJava_Setup___Close_Appli.ButtonRetry.Click();
						}
					
					if (Win3InstallFlag == true)
						{
						
						Report.Info("Windows 3.1 Installer running");
						
						while (repo.FormSoftware_Update_Installa.ButtonFinish.Enabled.Equals(false))
							{
							Delay.Seconds(1);
							}
						
						Report.Info("LeftClick FormSoftware_Update_Installa.ButtonFinish");
						repo.FormSoftware_Update_Installa.ButtonFinish.Click();
						Report.Info("LeftClick FormConfirmation.ButtonYes");
						repo.FormConfirmation.ButtonYes.Click();
						Report.Info("Rebooting Windows, ADSI installation will continue after next logon");
						Delay.Seconds(5);
						Environment.Exit(-1);
						}
					
					else 
						{
						Report.Info("LeftClick FormVersion_15_Windows_Softw.ButtonNext_");
						repo.FormVersion_15_Windows_Softw.ButtonNext_.Click();	
						
						if (repo.FormVersion_15_Windows_Softw.ButtonYesInfo.Exists())
							
							{
							Report.Info("LeftClick FormVersion_15_Windows_Softw.ButtonYes");
							repo.FormVersion_15_Windows_Softw.ButtonYes.Click();
							Report.Info("Installing ADSI software");
							}
						
						}
					
					}
				
				
				if (repo.FormVersion_15_Windows_Softw.ButtonFinishInfo.Exists())
					{
					Report.Info("LeftClick FormVersion_15_Windows_Softw.ButtonFinish");
					repo.FormVersion_15_Windows_Softw.ButtonFinish.Click();	
						
					if (repo.FormVersion_15_Windows_Softw.ButtonYesInfo.Exists())
							
						{
						Report.Info("LeftClick FormVersion_15_Windows_Softw.ButtonYes");
						repo.FormVersion_15_Windows_Softw.ButtonYes.Click();
						Report.Info("Installing ADSI software");
						}
						
					}

						
				}
			
				
				public void Is64BitSystem()
				{
     			if (Directory.Exists(Environment.GetEnvironmentVariable("ProgramFiles(x86)")))
	     			{
	     				OSbit = 64;
	     				Report.Info("64-bit Operating System Detected");
	     			}
     		    else
	     		    {
	     		    	OSbit = 32;
	     		    	Report.Info("32-bit Operating System Detected");
	     		    }
				}
				
				public void Check7zip()
					
				{
					
					  Report.Info("Checking to see if 7-zip is installed");
				      RegistryKey key = Registry.CurrentUser;
				      RegistryKey ZipKey = key.OpenSubKey("Software\\7-Zip");
				      bool ZipInstalled = ZipKey == null ? false : true;			  
				
					  if (!ZipInstalled)
						{
					    Report.Info("7-zip not installed, installing 7-zip now");
					    
					    if (OSbit == 32)
						    {
					        System.Diagnostics.Process Install7Zip = new System.Diagnostics.Process();
							Install7Zip.StartInfo.FileName=@"Apps\7z920.exe";
							Install7Zip.StartInfo.Arguments=@"/S";
							Install7Zip.Start();	
							Install7Zip.WaitForExit();
						    }
						else
							{
				            System.Diagnostics.Process Install7Zip = new System.Diagnostics.Process();
							Install7Zip.StartInfo.FileName=@"Apps\7z920-x64.msi";
							Install7Zip.StartInfo.Arguments=@"/quiet /passive";
							Install7Zip.Start();
							Install7Zip.WaitForExit();
							}
						}
					  else
					    {
						Report.Info("7-zip is already installed");
						}
				}

		static InstallWindowsOnly()
		{
			//Your recording specific initialization code goes here.
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
		
		
				public void DownloadTacView()
				{
				CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
				WebClient Client4 = new WebClient();
				Client4.DownloadFile("http://hudsonserver:8080/job/RealView-SprintBuilds/lastSuccessfulBuild/artifact/source/artifacts/svnversion.txt", "./BuildInfo/TVversion.txt");
				TVversion = SharedFunctions.GetLine(@".\BuildInfo\TVversion.txt", 2);
				TVversion = TVversion.Remove(0, 56);
				Report.Info("Downloading Latest Tacview Sprint Build, version " + TVversion);                 
				SharedFunctions.ConsoleProgressBar("http://hudsonserver:8080/job/RealView-SprintBuilds/lastSuccessfulBuild/artifact/source/artifacts/TacViewC2InstallCD.zip", "./InstallCDS/TacView/TacViewInstaller.zip");
				}
				
				public void UnzipTacView()
				{
				////// Unzip TacView zip file //////
				
				Console.WriteLine("Unzipping TacView Installer");
				Report.Info("Unzipping TacView Installer");
				System.Diagnostics.Process unzipTV = new System.Diagnostics.Process();
				unzipTV.EnableRaisingEvents=false;
				unzipTV.StartInfo.FileName=@"c:/Program Files/7-Zip/7z.exe";
				unzipTV.StartInfo.Arguments=@"x -y "  + currentDir + "//InstallCDS//TacView//TacViewInstaller.zip -oInstallCDS//TacView//" + TVversion;
				unzipTV.Start();
				unzipTV.WaitForExit();
				}
			
				public void InstallTacView()
				{
				///// Installs Latest Hudson TacViewC2 Software //////
			
				Console.WriteLine("Installing version " + TVversion + " of TacViewC2");
				Report.Info("Installing version" + TVversion + " of TacViewC2");
				System.Diagnostics.Process InstallTV = new System.Diagnostics.Process();
				InstallTV.EnableRaisingEvents=false;
				InstallTV.StartInfo.FileName=@currentDir +"//InstallCDS//TacView//" + TVversion + @"//TacViewC2InstallCD//Setup.exe";
				InstallTV.StartInfo.Arguments=@"/qb /passive /Lime TacView_install.log RUNMAPINSTALLER=No";			
				InstallTV.Start();
				InstallTV.WaitForInputIdle();
				InstallTV.WaitForExit();
				}


        public void GetCurrentDirectory()
        {
		currentDir = Directory.GetCurrentDirectory();  
        }

        public void InstallTDLG()
        {
            // Your code goes here. Code inside this method will not be changed by the code generator.
            
        }

        public void InstallC2H()
        {
            // Your code goes here. Code inside this method will not be changed by the code generator.
            
        }

        public void PingTDLG()
        {
            // Your code goes here. Code inside this method will not be changed by the code generator.
            
        }

        public void PingC2H()
        {
            // Your code goes here. Code inside this method will not be changed by the code generator.
            
        }

							
	}

}