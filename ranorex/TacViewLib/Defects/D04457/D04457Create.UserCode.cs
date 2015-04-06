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

using Ranorex;
using Ranorex.Core;

namespace TacViewLib.Defects.D04457
{
	/// <summary>
	/// The D04457 recording.
	/// </summary>
	public partial class D04457Create
	{			
		//Variables
		public static string TrackNum;
		public static int TCount;
		public static int TimeVal;
		
		public static string HR1Value;
		public static string MN1Value;
		
		//Flags for processing
		public static bool TF1Flag;
		public static bool TF2Flag;

		//************************************************************************************//
		//*********************************Gets Track Count***********************************//
		//************************************************************************************//
	
		public void GetTrackCount()
		{			
			Ranorex.Container cont1 = repo.FormTacViewC2.ContainerRvView;
			IList<Picture> list1 = cont1.Find<Picture>(@"/form[@title~'^TacViewC2\ \ \ \(map:\ .*']/element/container/picture[@accessiblevalue='Track']");
			TCount = list1.Count;		    
		}
		
		//************************************************************************************//
		//******************************Randomly Plots a Track********************************//
		//************************************************************************************//		
		
		public void RandCoord()
		{	
			
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			
			SharedFunctions.RandCoord();
		}

		//************************************************************************************//
		//***************************Enters Active Time Function******************************//
		//************************************************************************************//
		
		public void TF1val()
		{			
			int x = 0;
				
			while (x < 2)
			{
				try
				{
					repo.FormMain__Reference_Point_TN.ListItemTime_Function_1.Click("CenterLeft");
					Keyboard.Press(Keys.Tab);
					Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					int ASnum = 2;
			       	repo.ListRealView.Self.Items[ASnum].Select();
			       	repo.ListRealView.Self.Items[ASnum].Click("center");
					Accessible accElement = new Accessible(repo.FormMain__Reference_Point_TN.ListItemTime_Function_1);  
			   		string TF1Value = accElement.Value;
			   		D04457.D04457Validate.TF1 = TF1Value;
			   		Report.Info("Time Function 1 Value Entered = " + TF1Value);
			   		D04457.D04457Validate.TF1Flag = true;
			   		D04457.D04457Validate.TF1_OOR = false;
			   		TF1Flag = true;
			   		x=2;
				}
				catch (ArgumentOutOfRangeException e)
				{								   			
			   		x++;
			   		if (x == 1)
			   		{
			   			Report.Debug("List Count Out of Range for Time Function 1, Re-Executing Function");
			   			Report.Debug(e.ToString());	
			   		}
			   		else if (x == 2)
			   		{
			   			Report.Debug("List Count Out of Range for Time Function 1, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			D04457.D04457Validate.TF1_OOR = true;
			   			TF1Flag = false;
			   		}
				}
			}		

			//************************************************************************************//
			//*******************************Records Current Hour*********************************//
			//************************************************************************************//
	
			if (TF1Flag)
			{		
				repo.FormMain__Reference_Point_TN.ListItemHour1.Click("CenterLeft");
				Keyboard.Press(Keys.Tab);
				string a = System.DateTime.Now.ToString("HH");
				string b = a.TrimStart('0');        	
				Keyboard.Press(b);
		   		D04457.D04457Validate.HR1 = b;
	   			Report.Info("Hour 1 Value Entered = " + b);
	   			HR1Value = b;	   				
			}		    	
		
			//************************************************************************************//
			//******************************Records Current Minute********************************//
			//************************************************************************************//

			if (TF1Flag)
			{		
				repo.FormMain__Reference_Point_TN.ListItemMinute1.Click("CenterLeft");
				Keyboard.Press(Keys.Tab);
				string a = System.DateTime.Now.ToString("mm");
				string b = a.TrimStart('0');        	
				Keyboard.Press(b);
		   		D04457.D04457Validate.MN1 = b;
	   			Report.Info("Minute 1 Value Entered = " + b);
	   			MN1Value = b;
			}		
		}
			
		//************************************************************************************//
		//*************************Enters Deactive Time Function 2****************************//
		//************************************************************************************//
		
		public void TF2val()
		{
			int x = 0;
				
			while (x < 2)
			{
				try
				{
					repo.FormMain__Reference_Point_TN.ListItemTime_Function_2.Click("CenterLeft");
				   	Keyboard.Press(Keys.Tab);
				   	Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
					int ASnum = 1;
			   		repo.ListRealView.Self.Items[ASnum].Select();
			   		repo.ListRealView.Self.Items[ASnum].Click("center");
					Accessible accElement = new Accessible(repo.FormMain__Reference_Point_TN.ListItemTime_Function_2);  
					string TF2Value = accElement.Value;
					D04457.D04457Validate.TF2 = TF2Value;
					Report.Info("Time Function 2 Value Entered = " + TF2Value);
					D04457.D04457Validate.TF2Flag = true;
					D04457.D04457Validate.TF2_OOR = false;
					TF2Flag = true;
					x=2;
				}
				catch (ArgumentOutOfRangeException e)
			    {								   			
					x++;
					if (x == 1)
					{
						Report.Debug("List Count Out of Range for Time Function 2, Re-Executing Function");
						Report.Debug(e.ToString());	
					}
					else if (x == 2)
					{
						Report.Debug("List Count Out of Range for Time Function 2, List Item Will Not be Validated");
						Report.Debug(e.ToString());	
						D04457.D04457Validate.TF2_OOR = true;
						TF2Flag = false;
					}
			    }
			}		

			//************************************************************************************//
			//***********************************Enters Hour 2************************************//
			//************************************************************************************//
	
			if (TF2Flag)
			{			
				repo.FormMain__Reference_Point_TN.ListItemHour2.Click("CenterLeft");
			    Keyboard.Press(Keys.Tab);
				int HR2Val = Int32.Parse(HR1Value);
			    HR2Val = HR2Val + 1;
			    string b = HR2Val.ToString();
				Keyboard.Press(b);
	   			string HR2Value = b;
	   			D04457.D04457Validate.HR2 = HR2Value;
	   			Report.Info("Hour 2 Value Entered = " + HR2Value);	
			}
		
			//************************************************************************************//
			//******************************Enters Current Minute 2*******************************//
			//************************************************************************************//
			
			if (TF2Flag)
			{	
				repo.FormMain__Reference_Point_TN.ListItemMinute2.Click("CenterLeft");
    			Keyboard.Press(Keys.Tab);
				Keyboard.Press(MN1Value);
  				D04457.D04457Validate.MN2 = MN1Value;
   				Report.Info("Minute 2 Value Entered = " + MN1Value);
			}
		}
		
		
		//************************************************************************************//
		//*******************************Saves Reference Point********************************//
		//************************************************************************************//		
		
		public void Click_ButtonSave()
		{
			Duration OrigDur = repo.FormMain__Reference_Point_TN.ButtonSaveInfo.SearchTimeout;
			repo.FormMain__Reference_Point_TN.ButtonSaveInfo.SearchTimeout = 1500;
			
			if (repo.FormMain__Reference_Point_TN.ButtonSave.Enabled == true)
			{
				Report.Info("Mouse Left Click item 'FormMain__Reference_Point_TN.ButtonSave' at Center.");
				repo.FormMain__Reference_Point_TN.ButtonSave.Click();
			}
			else
			{
				Report.Debug("Save button is disabled to an error with the Reference Point Create Dialog. Please check the log report to determine the issue");
				repo.FormMain__Reference_Point_TN.ButtonCLOSE.Click();
				D04457.D04457Create.Start();
			}
			
			repo.FormMain__Reference_Point_TN.ButtonSaveInfo.SearchTimeout = OrigDur;
		}
		
		//************************************************************************************//
		//*********************************Gets Track Number**********************************//
		//************************************************************************************//
		
		public void GetTrackNum()			
		{			
		    TCount++;
		    Accessible pic1 = @"/form[@title~'^TacViewC2\ \ \ \(map:\ .*']/element/container/picture[@accessiblevalue='Track']" + "[" + TCount + "]";
   			Accessible accElement = new Accessible(pic1);  
   			string track1 = accElement.Name;
   			Report.Info("Track Number = " + track1);
   			TacViewLib.Defects.D04457.D04457Validate.TrackNum = track1;		
   			TacViewLib.Defects.Drop_Track.DropTrack.TrackNum = track1;
		}

		static D04457Create()
		{
			//Your recording specific initialization code goes here.
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}