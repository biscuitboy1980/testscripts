/*
 * Created by Ranorex
 * User: laptop
 * Date: 1/14/2010
 * Time: 3:52 PM
 * 
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using IWshRuntimeLibrary;
using System.Runtime.InteropServices;
using System.IO;
using System.Timers;
using System.Net;
using System.ComponentModel;

using Ranorex;
using Ranorex.Core;

namespace CommonUtilLib
{
	/// <summary>
	/// Description of Util.
	/// </summary>
	public class Util
	{
		
	public CommonUtilLib.CommonUtil repo = CommonUtilLib.CommonUtil.Instance;
		
	public const int base10 = 10;
	public char[] cHexa = new char[]{'A','B','C','D','E','F'};
	public int[] iHexaNumeric = new int[] {10,11,12,13,14,15};
	public int[] iHexaIndices = new int[] {0,1,2,3,4,5};
	public const int asciiDiff = 48;
	public int error;
	public string strDesktop;
	public bool busy = true;
	public string repoItem = "repo.FormTacViewC2";
	
		
	//This is for getting the desktop folder path
	[DllImport("shfolder.dll", CharSet = CharSet.Auto)]
  	private static extern int SHGetFolderPath(IntPtr hwndOwner, int nFolder, IntPtr hToken, int dwFlags, StringBuilder lpszPath);	

	//************************************************************************//
	//*******************Gets time stamp suffice for reports******************//
	//************************************************************************//
	
	public string TimeStamp = Ranorex.Core.StringTools.GetFileTimeStampSuffix (System.DateTime.Now);	

	//************************************************************************//
	//***********Selects a random number between lower & upper range**********//
	//************************************************************************//
	
	public string Random(int lower, int upper)
	{
		Random random = new Random();
		int a = random.Next(lower, upper);
		string b = a.ToString();
		return b;
	}
	
	//************************************************************************//
	//******************Selects a random double between 0 & 1*****************//
	//************************************************************************//
	
	public static double RandomDouble()
	{
		Random random = new Random();
		double a = random.NextDouble();
		return a;
	}	
	
	//************************************************************************//
	//**************************Randomly Plots a Track************************//
	//************************************************************************//	
		
	public void RandCoord()
	{	
	    Ranorex.Container test = @"/form[@title~'^TacViewC2\ \ \ \(map:\ .*']/element/container[@accessiblename='RvView']";
	    var a = test.ScreenRectangle.Width;
	    var b = test.ScreenRectangle.Height;
	    int c = Convert.ToInt32(a);
	    c = c - 100;
	    int d = Convert.ToInt32(b);
	    d = d - 100;
	    string w = Random(100, c);
	    string h = Random(100, d);
	   	repo.FormTacViewC2.ContainerRvView.Click(MouseButtons.Right, "" + w + ";" + h + ""); 
	    	 
	    Duration OrigDur = repo.FormRealView.MenuItemCreate_TrackInfo.SearchTimeout;
		repo.FormRealView.MenuItemCreate_TrackInfo.SearchTimeout = 1000;			
			
		if (repo.FormRealView.MenuItemCreate_TrackInfo.Exists())
		{
			return;
		}			
		else
		{
			RandCoord();
		}
			
		repo.FormRealView.MenuItemCreate_TrackInfo.SearchTimeout = OrigDur;
	}	
		
	//***********************************************************************//
    //*******FUNCTION TO ENSURE DIALOG/MESSAGE BOXES ARE ALWAYS 'ON TOP'*****//
	//***********************************************************************//	
	
	public class MsgBox
	{	
    	static public DialogResult Show(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icons)
    	{	
	        // Create a host form that is a TopMost window which will be the parent of the MessageBox.
	        System.Windows.Forms.Form topmostForm = new System.Windows.Forms.Form();
	
	        topmostForm.Size = new System.Drawing.Size(40, 40);
	        topmostForm.StartPosition = FormStartPosition.Manual;
	        System.Drawing.Rectangle rect = SystemInformation.VirtualScreen;
	        topmostForm.Location = new System.Drawing.Point(rect.Bottom + 12, rect.Right + 12);
	        topmostForm.Show();
	        
	        // Make this form the active form and make it TopMost
	        topmostForm.Focus();
	        topmostForm.BringToFront();
	        topmostForm.TopMost = true;
	        
	        // Finally show the MessageBox with the form just created as its owner
			Keyboard.Enabled = true;
			Mouse.Enabled = true;
			Keyboard.Enabled = true;
	        DialogResult result = MessageBox.Show(topmostForm, message, title, buttons, icons);
	        topmostForm.Dispose(); // clean it up all the way
	        return result;
    	}
	}	
	
	
	//***********************************************************************//
	//*********************LAUNCHES AWAITING DATA FORM***********************//
	//***********************************************************************//	
	
	public class DialogForm : System.Windows.Forms.Form
	{
	
	    public static void AwaitingDataForm()
        {
	    	Forms.AwaitingDataForm ADform = new Forms.AwaitingDataForm();
	    	ADform.Show();
			Delay.Seconds(30);
        }
	}
	
	
//	//***********************************************************************//
//  //********FORM-LIKE ALERT DIALOG THAT AUTO_CLOSES AFTER 60 SECONDS*******//
//	//***********************************************************************//	
//	
//	public class DialogForm : System.Windows.Forms.Form 
//	{
//		//Define variables for the components
//		private System.Windows.Forms.PictureBox picturebox1;
//		private System.Windows.Forms.PictureBox pictureBox2;		
//		private System.Windows.Forms.Button button1;
//		private System.Windows.Forms.Button button2;
//		private System.Windows.Forms.Label label1;
//		private System.Windows.Forms.Label label2;
//		private System.Windows.Forms.Label label3;
//		private System.Windows.Forms.Label label4;
//		private System.Windows.Forms.Timer timer1;
//		private System.ComponentModel.IContainer components = null;
//		int Counter = 60;		
//				
//		//Set error icons according to parameter received
//		public void ErrMsg(string message, string title, int icon) 
//		{
//			Keyboard.Enabled = true;
//			Mouse.Enabled = true;
//			
//			string dialogtitle = title;
//			string dialogmsg = message;
//			string dialogicon;
//			
//			if (icon == 1)
//			{
//				dialogicon = "Images/remove-icon.png";
//			}
//			else if (icon == 2)
//			{
//				dialogicon = "Images/accept-icon.png";
//			}
//			else
//			{
//				dialogicon = "Images/warning-icon.png";
//			}
//	
//			Application.Run(new DialogForm(dialogmsg, dialogtitle, dialogicon));
//		}	
//		
//		//Create and display the form
//		public DialogForm(string message, string title, string icon)
//		{
//			this.components = new System.ComponentModel.Container();
//			this.label1 = new System.Windows.Forms.Label();			
//			this.label2 = new System.Windows.Forms.Label();
//			this.label3 = new System.Windows.Forms.Label();
//			this.label4 = new System.Windows.Forms.Label();
//			this.picturebox1 = new System.Windows.Forms.PictureBox();
//			this.pictureBox2 = new System.Windows.Forms.PictureBox();
//			this.button1 = new System.Windows.Forms.Button();
//			this.button2 = new System.Windows.Forms.Button();			
//			this.timer1 = new System.Windows.Forms.Timer(this.components);
//			((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
//			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
//			// 
//			// timer1
//			// 
//			this.timer1.Tick += new System.EventHandler(timer1_Tick);
//			this.timer1.Enabled = true;
//			this.timer1.Interval = 1000;
//			// 
//			// label1
//			// 
//			this.label1.AutoSize = true;
//			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
//			this.label1.Location = new System.Drawing.Point(75, 24);
//			this.label1.Name = "label1";
//			this.label1.Size = new System.Drawing.Size(35, 17);
//			this.label1.TabIndex = 0;
//			this.label1.Text = message;
//			// 
//			// label2
//			// 
//			this.label2.AutoSize = true;
//			this.label2.Location = new System.Drawing.Point(182, 98);
//			this.label2.Name = "label2";
//			this.label2.Size = new System.Drawing.Size(159, 13);
//			this.label2.TabIndex = 3;
//			this.label2.Text = System.DateTime.Now.ToString();
//			// 
//			// label3
//			// 
//			this.label3.AutoSize = true;
//			this.label3.Location = new System.Drawing.Point(75, 44);
//			this.label3.Name = "label3";
//			this.label3.Size = new System.Drawing.Size(137, 13);
//			this.label3.TabIndex = 0;
//			this.label3.Text = "This message will close in...";
//			// 
//			// label4
//			// 
//			this.label4.AutoSize = true;
//			this.label4.Location = new System.Drawing.Point(220, 44);
//			this.label4.Name = "label4";
//			this.label4.Size = new System.Drawing.Size(0, 13);
//			this.label4.TabIndex = 0;
//			// 
//			// picturebox1
//			// 
//			this.picturebox1.BackColor = System.Drawing.SystemColors.Control;
//			this.picturebox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//			this.picturebox1.ImageLocation = "Images/Ultra_logo_color.jpg";
//			this.picturebox1.Location = new System.Drawing.Point(289, 11);
//			this.picturebox1.Name = "picturebox1";
//			this.picturebox1.Size = new System.Drawing.Size(69, 51);
//			this.picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
//			this.picturebox1.TabIndex = 2;
//			this.picturebox1.TabStop = false;
//			// 
//			// pictureBox2
//			// 
//			this.pictureBox2.ImageLocation = icon;
//			this.pictureBox2.Location = new System.Drawing.Point(10, 12);
//			this.pictureBox2.Name = "pictureBox2";
//			this.pictureBox2.Size = new System.Drawing.Size(48, 48);
//			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
//			this.pictureBox2.TabIndex = 4;
//			this.pictureBox2.TabStop = false;
//			// 
//			// button1
//			// 
//			this.button1.Location = new System.Drawing.Point(10, 88);
//			this.button1.Name = "button1";
//			this.button1.Size = new System.Drawing.Size(69, 31);
//			this.button1.TabIndex = 1;
//			this.button1.Text = "OK";
//			this.button1.UseVisualStyleBackColor = true;
//			this.button1.Click += OnButton1Clicked;
//			// 
//			// timer1
//			// 
//			this.timer1.Enabled = true;
//			this.timer1.Interval = 1000;
//			// 
//			// button2
//			// 
//			this.button2.Location = new System.Drawing.Point(86, 88);
//			this.button2.Name = "button2";
//			this.button2.Size = new System.Drawing.Size(80, 31);
//			this.button2.TabIndex = 5;
//			this.button2.Text = "View Report";
//			this.button2.UseVisualStyleBackColor = true;
//			this.button2.Click += OnButton2Clicked;
//			// 
//			// Form1
//			// 
//			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//			this.ClientSize = new System.Drawing.Size(369, 128);
//			this.ControlBox = false;
//			this.Controls.Add(this.picturebox1);
//			this.Controls.Add(this.pictureBox2);
//			this.Controls.Add(this.button1);
//			this.Controls.Add(this.button2);			
//			this.Controls.Add(this.label1);
//			this.Controls.Add(this.label2);
//			this.Controls.Add(this.label3);
//			this.Controls.Add(this.label4);
//			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
//			this.MaximizeBox = false;
//			this.MinimizeBox = false;
//			this.Name = "Form1";
//			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//			this.Text = title;
//			this.TopMost = true;
//			((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
//			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
//			this.ShowDialog();
//		}
//		
//		//Close dialog on click
//		void OnButton1Clicked(Object sender,EventArgs e)
//	  	{
//			this.Close();
//			Application.Exit();
//	  	}	
//		
//		//Close dialog on click
//		void OnButton2Clicked(Object sender,EventArgs e)
//	  	{
//			this.Close();
//			Application.Exit();
//			Process.Start("DisplayAutomationLogs.exe");
//	  	}			
//		
//		//Close dialog after time has elapsed
//		void timer1_Tick(Object sender, EventArgs e)
//		{	  
//		     if(Counter > 0)
//		     {
//		     	this.label4.Text = Counter.ToString() + " seconds";
//		     }
//		     else
//		     {
//				 this.timer1.Stop();
//				 this.Close();
//				 Application.Exit();
//		     }
//		     Counter--;
//		}
//	}	
//	
//	
//	//***********************************************************************//
//	//*****************AWAITING DATA FOR VALIDATION FORM*********************//
//	//***********************************************************************//
//	
//	public class AwaitingDataForm : System.Windows.Forms.Form 
//	{
//		//Define variables for the components
//		private System.Windows.Forms.ProgressBar progressBar1;
//		private System.Windows.Forms.Label label2;
//		private System.Windows.Forms.Label label1;
//		private System.ComponentModel.IContainer components = null;
//					
//		//Create and display the form
//		public void Display()
//	
//			{
////			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
////			this.components = new System.ComponentModel.Container();
//			this.label1 = new System.Windows.Forms.Label();
//			this.label2 = new System.Windows.Forms.Label();
//			this.progressBar1 = new System.Windows.Forms.ProgressBar();
//			this.SuspendLayout();
//			// 
//			// label1
//			// 
//			this.label1.AutoSize = true;
//			this.label1.Location = new System.Drawing.Point(13, 106);
//			this.label1.Name = "label1";
//			this.label1.Size = new System.Drawing.Size(260, 13);
//			this.label1.TabIndex = 0;
//			this.label1.Text = "Awaiting Data Transmission to begin verification steps";
//			// 
//			// label2
//			// 
//			this.label2.AutoSize = true;
//			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//			this.label2.Location = new System.Drawing.Point(12, 19);
//			this.label2.Name = "label2";
//			this.label2.Size = new System.Drawing.Size(242, 16);
//			this.label2.TabIndex = 1;
//			this.label2.Text = "Automated Test Compliance Suite";
//			// 
//			// progressBar1
//			// 
//			this.progressBar1.Location = new System.Drawing.Point(13, 60);
//			this.progressBar1.Name = "progressBar1";
//			this.progressBar1.Size = new System.Drawing.Size(325, 23);
//			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
//			this.progressBar1.TabIndex = 2;
//			// 
//			// Form3
//			// 
//			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//			this.ClientSize = new System.Drawing.Size(350, 142);
//			this.Controls.Add(this.progressBar1);
//			this.Controls.Add(this.label2);
//			this.Controls.Add(this.label1);
////			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
//			this.Name = "Form3";
//			this.Text = "Awaiting Data to Verify";
//			this.ResumeLayout(false);
//			this.PerformLayout();
//		}
//	}


	//***********************************************************************//
    //********Uses the Ultra Template XSL Stylesheet instead of Ranorex'*****//
	//***********************************************************************//
	
	public void UltraXSL()			
	{
		XmlLogger.SetReportStylesheetFile("Reports/RanorexReport.xsl");		
	}
		
	//***********************************************************************//
    //********Converts Decimal to Octal, Binary, or Hexadecimal**************//
	//***********************************************************************//	
	
	public string DecimalToBase(int iDec, int numbase)
	{
		string strBin = "";
	    int[] result = new int[32];
	    int MaxBit = 32;
	    for(; iDec > 0; iDec/=numbase)
	    	{
	        int rem = iDec % numbase;
	        result[--MaxBit] = rem;
	    	} 
	    for (int i=0;i<result.Length;i++)
	          if ((int) result.GetValue(i) >= base10)
	            strBin += cHexa[(int)result.GetValue(i)%base10];
	          else
	            strBin += result.GetValue(i);
	    strBin = strBin.TrimStart(new char[] {'0'});
	    return strBin;
	}
	
	//***********************************************************************//
    //***********Converts Octal, Binary, or Hexadecimal to Decimal***********//
	//***********************************************************************//	
	
	public int BaseToDecimal(string sBase, int numbase)
	{
	    int dec = 0;
	    int b;
	    int iProduct=1;
	    string sHexa = "";
	    if (numbase > base10)
	    for (int i=0;i<cHexa.Length;i++)
	        sHexa += cHexa.GetValue(i).ToString();
	    for(int i=sBase.Length-1; i>=0; i--,iProduct *= numbase)
	    	{
	        string sValue = sBase[i].ToString();
	        if (sValue.IndexOfAny(cHexa) >=0)
	            b=iHexaNumeric[sHexa.IndexOf(sBase[i])];
	        else 
	            b= (int) sBase[i] - asciiDiff;
	        dec += (b * iProduct);
	    	} 
	    return dec; 
	}

	//***********************************************************************//
    //*********Checks for Valid Iteration Number (Link-16 Regression)********//
	//***********************************************************************//
	
	public void ValidIteration(string Count)			
	{
		try
		{
			int Cnt = Int32.Parse(Count);
			
			if (Cnt == 0 || Cnt > 100 || Count == null)
			{
				MsgBox.Show("Invalid Iteration Number in 'iteration.csv' File. Please Enter a Number Greater than 0 AND Less than 100 for the Count Field.", "Test Aborted", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(-1);
			}
		}
		catch
		{
			MsgBox.Show("Invalid Iteration Number in 'iteration.csv' File. Please Enter a Number for the Count Field.", "Test Aborted", MessageBoxButtons.OK, MessageBoxIcon.Error);
			Environment.Exit(-1);
		}
	}	
	
	//***********************************************************************//
    //*******************Checks for Valid IP Address*************************//
	//***********************************************************************//
	
	public void ValidIP(string IP)	
	{
 		string IPAdress =@"^(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])$";
 		
 		if (System.Text.RegularExpressions.Regex.IsMatch(IP,IPAdress) == false || IP == null)
 		{
 			MsgBox.Show("Invalid IP Address entered in 'ipdata.csv' File. Please Enter a Valid IP Address", "Test Aborted", MessageBoxButtons.OK, MessageBoxIcon.Error);
 			Console.WriteLine("Invalid IP Address entered in 'ipdata.csv' File. Please Enter a Valid IP Address");
 			Report.Info("Invalid IP Address entered in 'ipdata.csv' File. Please Enter a Valid IP Address");
 			Environment.Exit(-1);
 		}
	}	
	
	//***********************************************************************//
    //************Used to launch applications from the desktop***************//
	//***********************************************************************//

	public void LaunchApp(string AppName)
	{	
		try 
        {
			//Get the public desktop        	
        	const int MAX_PATH = 260;
        	const int CSIDL_COMMON_DESKTOPDIRECTORY = 0x0019;
            StringBuilder sbPath = new StringBuilder(MAX_PATH);
            SHGetFolderPath(IntPtr.Zero, CSIDL_COMMON_DESKTOPDIRECTORY, IntPtr.Zero, 0, sbPath);
            strDesktop = sbPath.ToString();
	       
            //Add the shortcut	        
	        strDesktop += "\\" + AppName + ".lnk";	        
	        
			WshShell Wshell = new WshShell();
            IWshRuntimeLibrary.IWshShortcut shortc = (IWshRuntimeLibrary.IWshShortcut)Wshell.CreateShortcut(strDesktop);
            if(shortc!=null)
            {
            	Delay.Milliseconds(5000);
            	string Target=shortc.TargetPath;
                string Arguments =shortc.Arguments;
                string WorknigDir = shortc.WorkingDirectory;
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.EnableRaisingEvents=false;
                proc.StartInfo.FileName=Target;
                proc.StartInfo.Arguments = Arguments;
                proc.StartInfo.WorkingDirectory = WorknigDir;
                proc.Start();
            }
        }        
        catch (Exception)
        {
             Report.Error("Unable to find an icon on the desktop named" + AppName);
             error = -1;
                
             if (error == -1)
             {
                MsgBox.Show("Unable to find an icon on the desktop named " + AppName + " PATH = " + strDesktop, "Icon not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);                	
             }
         }	
  	}

		//***********************************************************************//
	    //***********************Used to kill a process**************************//
		//***********************************************************************//
	
		public void KillProcess(string ProcessName)
		{
			try
			{
				string strCommand = "/c TASKKILL /F /IM " + ProcessName + " /FI \"STATUS ne RUNNING|NOT RESPONDING\"";
				System.Diagnostics.ProcessStartInfo procStartInfo =
				new System.Diagnostics.ProcessStartInfo("cmd", strCommand);
				
				// The following commands are needed to redirect the standard output.
				// This means that it will be redirected to the Process.StandardOutput StreamReader.
				procStartInfo.RedirectStandardOutput = true;
				procStartInfo.UseShellExecute = false;
				// Do not create the black window.
				procStartInfo.CreateNoWindow = true;
				// Now we create a process, assign its ProcessStartInfo and start it
				System.Diagnostics.Process proc = new System.Diagnostics.Process();
				proc.StartInfo = procStartInfo;
				proc.Start();
				// Get the output into a string
				string result = proc.StandardOutput.ReadToEnd();
				// Display the command output.
				Console.WriteLine(result);
			}			
			catch (Exception)
			{
				Report.Error("There was an error executing function Kill Processes in CommonUtilLib when trying to kill process named " + ProcessName);
			}
		}		
		
		
		public void KillUltraProcesses()
		{
			KillProcess("sm.exe");
		    KillProcess("c2c.exe");   
		    KillProcess("c2m.exe");
		    KillProcess("qtderg.exe");
		    KillProcess("midsctl.exe");
		    KillProcess("midsctl_x25.exe");
		    KillProcess("FTMClient.exe");
		    KillProcess("cfgwizard.exe");
		    KillProcess("loader.exe");
		    KillProcess("RealView.exe");
		}
		
		
		//***********************************************************************//
	    //****************Used to Generate ATDL-1 Track Number*******************//
		//***********************************************************************//
	
		public string ATDL1_TN()
		{
			string[] ATDL1_1st_Char = new string[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "P", "Q"};
			Random random = new Random();
			string a = ATDL1_1st_Char[random.Next(0, ATDL1_1st_Char.Length)];
		
			if (a == "A")
			{
				string[] ATDL1_2nd_Char1 = new string[] {"B", "C", "D", "E", "F", "G", "H"};
				string b = ATDL1_2nd_Char1[random.Next(ATDL1_2nd_Char1.Length)];
				string c = (a + b);
				string d = Random(1, 512);
				string e = DecimalToBase(Convert.ToInt32(d), 8);
				string f = e.PadLeft(3,'0');
				string g = (c + f);
				return g;
			}
			if (a == "Q")
			{
				string[] ATDL1_2nd_Char2 = new string[] {"A", "B", "C", "D", "E", "F", "G"};
				string b = ATDL1_2nd_Char2[random.Next(ATDL1_2nd_Char2.Length)];
				string c = (a + b);
				string d = Random(1, 512);
				string e = DecimalToBase(Convert.ToInt32(d), 8);
				string f = e.PadLeft(3,'0');
				string g = (c + f);
				return g;
			}
			else
			{
				string[] ATDL1_2nd_Char3 = new string[] {"A", "B", "C", "D", "E", "F", "G", "H"};
				string b = ATDL1_2nd_Char3[random.Next(0, ATDL1_2nd_Char3.Length)];
				string c = (a + b);
				string d = Random(1, 512);
				string e = DecimalToBase(Convert.ToInt32(d), 8);
				string f = e.PadLeft(3,'0');
				string g = (c + f);
				return g;
			}
		}
	
		
		//***********************************************************************//
	    //****************Used to Generate IDL Track Number*******************//
		//***********************************************************************//
	
		
		public string IDL_TN()
		{
			string[] IDL_1st_Char = new string[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "P", "Q"};
			Random random = new Random();
			string a = IDL_1st_Char[random.Next(0, IDL_1st_Char.Length)];
		
			if (a == "A")
			{
				string[] IDL_2nd_Char1 = new string[] {"B", "C", "D", "E", "F", "G", "H"};
				string b = IDL_2nd_Char1[random.Next(IDL_2nd_Char1.Length)];
				string c = (a + b);
				string d = Random(1, 512);
				string e = DecimalToBase(Convert.ToInt32(d), 8);
				string f = e.PadLeft(3,'0');
				string g = (c + f);
				return g;
			}
			if (a == "Q")
			{
				string[] IDL_2nd_Char2 = new string[] {"A", "B", "C", "D", "E", "F", "G"};
				string b = IDL_2nd_Char2[random.Next(IDL_2nd_Char2.Length)];
				string c = (a + b);
				string d = Random(1, 512);
				string e = DecimalToBase(Convert.ToInt32(d), 8);
				string f = e.PadLeft(3,'0');
				string g = (c + f);
				return g;
			}
			else
			{
				string[] IDL_2nd_Char3 = new string[] {"A", "B", "C", "D", "E", "F", "G", "H"};
				string b = IDL_2nd_Char3[random.Next(0, IDL_2nd_Char3.Length)];
				string c = (a + b);
				string d = Random(1, 512);
				string e = DecimalToBase(Convert.ToInt32(d), 8);
				string f = e.PadLeft(3,'0');
				string g = (c + f);
				return g;
			}
		}
		
		//***********************************************************************//
	    //**************Used to Generate NATO Link-1 Track Number****************//
		//***********************************************************************//
	
		public string NATO_TN()
		{
			string[] NL1_1st_Char = new string[] {"A", "E", "G", "H", "J", "K", "L", "M"};	
			Random random = new Random();
			string a = NL1_1st_Char[random.Next(0, NL1_1st_Char.Length)];
			
			if (a == "A")
			{
				string[] NL1_2nd_Char1 = new string[] {"E", "G", "H", "J", "K", "L", "M"};
				string b = NL1_2nd_Char1[random.Next(0, NL1_2nd_Char1.Length)];
				string c = (a + b);
				string d = Random(1, 512);
				string e = DecimalToBase(Convert.ToInt32(d), 8);
				string f = e.PadLeft(3,'0');
				string g = (c + f);
				return g;
			}		
			else
			{
				string[] NL1_2nd_Char2 = new string[] {"A", "E", "G", "H", "J", "K", "L", "M"};
				string b = NL1_2nd_Char2[random.Next(0, NL1_2nd_Char2.Length)];
				string c = (a + b);
				string d = Random(1, 512);
				string e = DecimalToBase(Convert.ToInt32(d), 8);
				string f = e.PadLeft(3,'0');
				string g = (c + f);
				return g;
			}
		}
		
		//***********************************************************************//
	    //****************Used to Generate TADIL J Track Number******************//
		//***********************************************************************//
	
		public string TADILJ_TN()
		{		
			string x = Random(0, 2);		
			
			if (x == "0")
			{
				string[] TADILJ_1st_Char = new string[] {"A", "B", "C", "E", "F", "G", "H", "I", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};	
				Random random1 = new Random();
				string a = TADILJ_1st_Char[random1.Next(0, TADILJ_1st_Char.Length)];
				string[] TADILJ_2nd_Char1 = new string[] {"A", "B", "C", "E", "F", "G", "H", "I", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
				string b = TADILJ_2nd_Char1[random1.Next(0, TADILJ_2nd_Char1.Length)];
				string c = (a + b);
				string d = Random(1, 512);
				string e = d.PadLeft(3,'0');
				string f = DecimalToBase(Convert.ToInt32(d), 8);
				string g = (c + f);
		           return g;
			}		
			else
			{
				string a = Random(128, 32766);
				string b = DecimalToBase(Convert.ToInt32(a), 8);
				return b;
			}
		}
		
		public string GetLine(string fileName, int line)
		{
  			using (var sr = new StreamReader(fileName)) 
  		 	{
      	 		for (int i = 1; i < line; i++)
         		sr.ReadLine();
       			return sr.ReadLine();
   			}
		}
		
		public int OSBit()
		{
     		if (Directory.Exists(Environment.GetEnvironmentVariable("ProgramFiles(x86)")))
	     		{
     			return(64);
	     		}
     		else
	     	    {
     			return(32);
	     		}
		}
		
		
		public void ConsoleProgressBar(string address, string filename)
	    {
			
			WebClient client = new WebClient();
			Uri uri = new Uri(address);
			client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);
			client.DownloadFileCompleted += new AsyncCompletedEventHandler (DownloadFileCallback);
			client.DownloadFileAsync(uri, filename);
			
			while (busy == true)
			{
				Thread.Sleep(1);
			}
	    }
		
		private void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
		{
		    // Displays the operation identifier, and the transfer progress.
		    Console.Write("\r{0}    downloaded {1} of {2} bytes. {3} % complete...", 
		        (string)e.UserState, 
		        e.BytesReceived, 
		        e.TotalBytesToReceive,
		        e.ProgressPercentage);
		}
		
		private void DownloadFileCallback(object sender, AsyncCompletedEventArgs e)
		{
		    // Displays the operation identifier, and the transfer progress.
		    Console.Write("Download Complete!!!", (string)e.UserState);
		    busy = false;
		    
		}
		
		public string GetLocalIP()
		{
			IPHostEntry host;
			string localIP = "";
			host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (IPAddress ip in host.AddressList)
			{
				localIP = ip.ToString();
			}
			return localIP;
		}
		
	}
}

