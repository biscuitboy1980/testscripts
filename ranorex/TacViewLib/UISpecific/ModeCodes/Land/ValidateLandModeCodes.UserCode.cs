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

using CommonUtilLib;
using Ranorex;
using Ranorex.Core;

namespace TacViewLib.UISpecific.ModeCodes.Land
{
	/// <summary>
	/// The ValidateTrackRegression recording.
	/// </summary>

	public partial class ValidateLandModeCodes
	{		
		public bool ZoomFlag = false;
		
		public string TrackNum;	
		
		//Modes & Codes
		public string M1;
		public string M2;
		public string M3;
		public string M4;
		public string M5;
		public string M5Nat;
		public string M5ID;

		//Out of Range Flags
		public bool Mode1_OOR;
		public bool Mode4_OOR;		
		public bool Mode5_OOR;
		public bool Mode5Nat_OOR;		
		
		//************************************************************************************//
		//*****************************Creates Track Repo Items*******************************//
		//************************************************************************************//
		
		public void CreateTrackRepoItems()
		{			
			string currentPath = repo.FormTacViewC2.PictureTrackInfo.Path.ToString();
			repo.FormTacViewC2.PictureTrackInfo.Path = currentPath.Replace("%track%", TrackNum);
			Report.Info("Setting repo item FormTacViewC2.PictureTrack to " + repo.FormTacViewC2.PictureTrackInfo.Path.ToString());
			
			string currentPath1 = repo.FormTracks.MenuItemC2_HOST_2_TrackInfo.Path.ToString();
			repo.FormTracks.MenuItemC2_HOST_2_TrackInfo.Path = currentPath1.Replace("%track%", TrackNum);
			Report.Info("Setting repo item FormTracks.MenuItemC2_HOST_2_Track to " + repo.FormTracks.MenuItemC2_HOST_2_TrackInfo.Path.ToString());
			
			string currentPath2 = repo.FormRealView.MenuItemTrackNumber2Info.Path.ToString();
			repo.FormRealView.MenuItemTrackNumber2Info.Path = currentPath2.Replace("%track%", TrackNum);
			Report.Info("Setting repo item FormRealView.MenuItemTrackNumber2 to " + repo.FormRealView.MenuItemTrackNumber2Info.Path.ToString());
			
			string currentPath3 = repo.FormRealView.MenuItemTrackNumberInfo.Path.ToString();
			repo.FormRealView.MenuItemTrackNumberInfo.Path = currentPath3.Replace("%track%", TrackNum);
			Report.Info("Setting repo item FormRealView.MenuItemTrackNumber to " + repo.FormRealView.MenuItemTrackNumberInfo.Path.ToString());
			
			string currentPath4 = repo.FormTracks.MenuItemC2_HOST_TrackInfo.Path.ToString();
			repo.FormTracks.MenuItemC2_HOST_TrackInfo.Path = currentPath4.Replace("%track%", TrackNum);
			Report.Info("Setting repo item FormTracks.MenuItemC2_HOST_Track to " + repo.FormTracks.MenuItemC2_HOST_TrackInfo.Path.ToString());	
		}		
		
		//************************************************************************************//
		//*********************************Right Clicks Track*********************************//
		//************************************************************************************//
		
		public void RightClickTrack()
		{			
			Duration OrigDur = repo.FormTacViewC2.PictureTrackInfo.SearchTimeout;
			repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = 2000;			
			
			if (repo.FormTacViewC2.PictureTrackInfo.Exists())
			{
				Report.Info("Mouse Right Click item 'FormTacViewC2.PictureTrack' at Center.");
				repo.FormTacViewC2.PictureTrack.Click(MouseButtons.Right);
			}
			else
			{
				ZoomFlag = true;
				Report.Info("Track # " + TrackNum + " not found on the current display, going to world wide view");
				repo.FormTacViewC2.ButtonZoom_Out_Max.Click();
				
				if (repo.FormTacViewC2.PictureTrackInfo.Exists())
				{
					Report.Info("Mouse Right Click item 'FormTacViewC2.PictureTrack' at Center.");
					repo.FormTacViewC2.PictureTrack.Click(MouseButtons.Right);
				}
				else
				{
					Report.Error("Unable to find Track # " + TrackNum + " anywhere in the world");
					return;
				}				
			}
			
			repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = OrigDur;
		}
		
		//************************************************************************************//
		//***************************Opens Track Properties Dialog****************************//
		//************************************************************************************//
		
		public void ViewTrackProperties()
		{			
			if( TacViewLib.UISpecific.Configuration.Common.Interface2TrackMenu(TrackNum) )
			{
				Report.Info("Mouse Left Click item 'MenuItemTrack_Properties'");
				repo.MenuItemTrack_Properties.Click();
			}
		}
		
		//************************************************************************************//
		//***********************************Validates M1 value*******************************//
		//************************************************************************************//
				
		public void ValidateMode1()
		{
		if (!Mode1_OOR)
			{
			Report.Info("Validating AttributeEqual (Text='Mode 1') on item 'FormMain__Land_TN.ListItemMode_1_Code.");
			Report.Info("Value Entered = " + M1);
			Validate.Attribute(repo.FormMain__Land_TN.ListItemMode_1_CodeInfo, "AccessibleValue", M1, Validate.DefaultMessage, false);
			}
		}
		
		//************************************************************************************//
		//***********************************Validates M3 value*******************************//
		//************************************************************************************//
		
		public void ValidateMode2()
		{
			Report.Info("Validating AttributeEqual (Text='Mode 2') on item 'FormMain__Land_TN.ListItemMode_2_Code.");
			int val = Int32.Parse (M2);
			string Mode2 = val.ToString("D4");
			Report.Info("Value Entered = " + Mode2);
			Validate.Attribute(repo.FormMain__Land_TN.ListItemMode_2_CodeInfo, "AccessibleValue", Mode2, Validate.DefaultMessage, false);
		}
		
		//************************************************************************************//
		//***********************************Validates M3 value*******************************//
		//************************************************************************************//
		
		public void ValidateMode3()
		{
			Report.Info("Validating AttributeEqual (Text='Mode 3') on item 'FormMain__Land_TN.ListItemMode_3_Code.");
			int val = Int32.Parse (M3);
			string Mode3 = val.ToString("D4");
			Report.Info("Value Entered = " + Mode3);
			Validate.Attribute(repo.FormMain__Land_TN.ListItemMode_3_CodeInfo, "AccessibleValue", Mode3, Validate.DefaultMessage, false);
		}
		
		//************************************************************************************//
		//***********************************Validates M4 value*******************************//
		//************************************************************************************//
		
		public void ValidateMode4()
		{
		if (!Mode4_OOR)
			{
			Report.Info("Validating AttributeEqual (Text='Mode 4') on item 'FormMain__Land_TN.ListItemMode_4_Indicator.");
			Report.Info("Value Entered = " + M4);
			Validate.Attribute(repo.FormMain__Land_TN.ListItemMode_4_IndicatorInfo, "AccessibleValue", M4, Validate.DefaultMessage, false);
			}
		}
		
		//************************************************************************************//
		//***********************************Validates M5 value*******************************//
		//************************************************************************************//
		
		public void ValidateMode5()
		{
		if (!Mode5_OOR)
			{
			Report.Info("Validating AttributeEqual (Text='Mode 5') on item 'FormMain__Land_TN.ListItemMode_5_Indicator.");
			Report.Info("Value Entered = " + M5);
			Validate.Attribute(repo.FormMain__Land_TN.ListItemMode_5_IndicatorInfo, "AccessibleValue", M5, Validate.DefaultMessage, false);
			}
		}
		
		//************************************************************************************//
		//***********************Validates M5 Nationality value*******************************//
		//************************************************************************************//
		
		public void ValidateM5Nat()
		{
			if (!Mode5Nat_OOR)
			{
			Report.Info("Validating AttributeEqual (Text='Mode 5 Nationality') on item 'FormMain__Land_TN.ListItemMode_5_Nationality.");
			Report.Info("Value Entered = " + M5Nat);
			Validate.Attribute(repo.FormMain__Land_TN.ListItemMode_5_NationalityInfo, "AccessibleValue", M5Nat, Validate.DefaultMessage, false);
			}
		}

		//************************************************************************************//
		//***********************Validates M5 ID value****************************************//
		//************************************************************************************//
		
		public void ValidateM5ID()
		{
			Report.Info("Validating AttributeEqual (Text='Mode 5 Platform ID') on item 'FormMain__Land_TN.ListItemMode_5_platformID'.");
			Report.Info("Value Entered = " + M5ID);		
			Validate.Attribute(repo.FormMain__Land_TN.ListItemMode_5_platformIDInfo, "AccessibleValue", M5ID, Validate.DefaultMessage, false);
		}
		
		//************************************************************************************//
		//***********************************Drops Track**************************************//
		//************************************************************************************//		
		
		public void DropTrack()
		{			
			TacViewLib.UISpecific.Configuration.Common.DropTrackSequence( TrackNum );
		}
		
		//************************************************************************************//
		//****************************Validates Track was Dropped*****************************//
		//************************************************************************************//	
		
		public void Validate_DropTrack()
		{
			Duration OrigDur = repo.FormTacViewC2.PictureTrackInfo.SearchTimeout;
			repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = 10000;

			Report.Info("Validating NotExists on Track # " + TrackNum);
			Validate.NotExists(repo.FormTacViewC2.PictureTrackInfo, Validate.DefaultMessage, false);
			
			repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = OrigDur;
		}
		
		//************************************************************************************//
		//*******************************Zooms Out if Necessary*******************************//
		//************************************************************************************//
		
		public void Zoom500()
		{
			if (ZoomFlag == true)
			{
				Report.Info("Mouse Left Click item 'FormTacViewC2.ButtonSet_Range_to_500_km' at Center.");
				repo.FormTacViewC2.ButtonSet_Range_to_500_km.Click();
				Report.Info("Mouse Left Click item 'FormTacViewC2.Button_Center_on_Own_Site' at Center.");
				repo.FormTacViewC2.Button_Center_on_Own_Site.Click();
				ZoomFlag = false;
			}
		}
		
		//************************************************************************************//
		//*********************************Resets Repo Paths**********************************//
		//************************************************************************************//
		
		public void ResetPaths()
		{
			string currentPath = repo.FormTacViewC2.PictureTrackInfo.Path.ToString();
			repo.FormTacViewC2.PictureTrackInfo.Path = currentPath.Replace(TrackNum, "%track%");
			Report.Info("Resetting repo item FormTacViewC2.PictureTrack repo item to" + repo.FormTacViewC2.PictureTrackInfo.Path.ToString());
		
			string currentPath1 = repo.FormTracks.MenuItemC2_HOST_2_TrackInfo.Path.ToString();
			repo.FormTracks.MenuItemC2_HOST_2_TrackInfo.Path = currentPath1.Replace(TrackNum, "%track%");
			Report.Info("Resetting repo item FormTracks.MenuItemC2_HOST_2_Track to " + repo.FormTracks.MenuItemC2_HOST_2_TrackInfo.Path.ToString());
			
			string currentPath2 = repo.FormRealView.MenuItemTrackNumber2Info.Path.ToString();
			repo.FormRealView.MenuItemTrackNumber2Info.Path = currentPath2.Replace(TrackNum, "%track%");
			Report.Info("Resetting repo item FormRealView.MenuItemTrackNumber2 to " + repo.FormRealView.MenuItemTrackNumber2Info.Path.ToString());
			
			string currentPath3 = repo.FormRealView.MenuItemTrackNumberInfo.Path.ToString();
			repo.FormRealView.MenuItemTrackNumberInfo.Path = currentPath3.Replace(TrackNum, "%track%");
			Report.Info("Resetting repo item FormRealView.MenuItemTrackNumber to " + repo.FormRealView.MenuItemTrackNumberInfo.Path.ToString());
			
			string currentPath4 = repo.FormTracks.MenuItemC2_HOST_TrackInfo.Path.ToString();
			repo.FormTracks.MenuItemC2_HOST_TrackInfo.Path = currentPath4.Replace(TrackNum, "%track%");
			Report.Info("Resetting repo item FormTracks.MenuItemC2_HOST_Track to " + repo.FormTracks.MenuItemC2_HOST_TrackInfo.Path.ToString());		
		}		

		static ValidateLandModeCodes()
		{
			//Your recording specific initialization code goes here.
		}

		public void RXtrack()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			
		}

		public void TXtrack()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}