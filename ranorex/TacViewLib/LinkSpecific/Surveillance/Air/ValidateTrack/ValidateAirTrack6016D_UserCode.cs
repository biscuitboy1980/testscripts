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

namespace TacViewLib.LinkSpecific.Surveillance.Air.ValidateTrack
{	
	public partial class ValidateAirTrack6016D
	{
		public static bool ZoomFlag = false;		
		public static string TrackNum;		
		
		//Basic Info
		public static string ID;

		//Out of Range Flags
		public static bool PlatFlag;
		public static bool ActFlag;
		public static bool StypeFlag;	
		
		//************************************************************************************//
		//*****************************Sets Track Number in Repo******************************//
		//************************************************************************************//
		
		public void SetTrackNumberInRepo()
		{
			tracknumber = TrackNum;	
			Report.Info("Setting tracknumber to " + tracknumber);
		}

        //************************************************************************************//
		//*******************************Right Clicks on Track********************************//
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
				Report.Screenshot();
				repo.FormTacViewC2.ButtonZoom_Out_Max.Click();
				
				if (repo.FormTacViewC2.PictureTrackInfo.Exists())
				{
					Report.Info("Mouse Right Click item 'FormTacViewC2.PictureTrack' at Center.");
					repo.FormTacViewC2.PictureTrack.Click(MouseButtons.Right);
				}
				else
				{
					Report.Error("Unable to find Track # " + TrackNum + " anywhere in the world");
					Report.Screenshot();
					return;
				}				
			}
			
			repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = OrigDur;
		}	
		
		//************************************************************************************//
		//********************Opens Track Dialog For Corresponding Track**********************//
		//************************************************************************************//
		
		public void ViewTrackProperties()
		{			
			Duration OrigDur = repo.FormRealView.MenuItemTracksInfo.SearchTimeout;
			repo.FormRealView.MenuItemTracksInfo.SearchTimeout = 1000;
			Duration OrigDur1 = repo.FormRealView.MenuItemTrackNumber2Info.SearchTimeout;
			repo.FormRealView.MenuItemTrackNumber2Info.SearchTimeout = 1000;			
			
			if (repo.FormRealView.MenuItemTracksInfo.Exists())
			{
				Report.Info("Mouse Left Click item 'FormRealView.MenuItemTracks'");
			    repo.FormRealView.MenuItemTracks.Click();
			    Report.Info("Mouse Left Click item 'FormTracks.MenuItemC2_HOST_2_Track'");
		        repo.FormTracks.MenuItemConnection2_Track.Click();
		       	Report.Info("Mouse Left Click item 'FormConnection2.MenuItemTrack_Properties");
				repo.FormConnection2.MenuItemTrack_Properties.Click();
			}			
			else if (repo.FormRealView.MenuItemTrackNumber2Info.Exists())
			{
			    Report.Info("Mouse Left Click item 'repo.FormRealView.MenuItemTrackNumber2'");
		        repo.FormRealView.MenuItemTrackNumber2.Click();
		       	Report.Info("Mouse Left Click item 'FormTOAD2.MenuItemTrack_Properties");
				repo.FormConnection2.MenuItemTrack_Properties.Click();
			}
			
			repo.FormRealView.MenuItemTracksInfo.SearchTimeout = OrigDur;
			repo.FormRealView.MenuItemTrackNumber2Info.SearchTimeout = OrigDur1;
		}		

		//************************************************************************************//
		//********************Validates Identity value from csv file**************************//
		//************************************************************************************//
				
		public void ValidateID()
		{
			Report.Info("Validating AttributeEqual (Text='(ID)') on item 'TrackDialogue.Container5019.ListItemIdentity'.");
			Report.Info("Value Selected =" + ID);
			Validate.Attribute(repo.FormMain__Air_TN.ListItemIdentityInfo, "AccessibleValue", ID, Validate.DefaultMessage, false);
		}
		
		//************************************************************************************//
		//*******************Validates Platform value from csv file***************************//
		//************************************************************************************//
		
		public void ValidatePlat()
		{
			if (!PlatFlag)
			{
				Report.Info("Validating AttributeEqual (Text='Platform') on item 'FormMain__Air_TN_(TN)_.ListItemPlatform'.");
				Report.Info("Value Selected =" + Plat);
				Validate.Attribute(repo.FormMain__Air_TN.ListItemPlatformInfo, "AccessibleValue", Plat, Validate.DefaultMessage, false);
			}
			else
			{
				Report.Info("Validating AttributeEqual (Text='Platform') on item 'FormMain__Air_TN_(TN)_.ListItemPlatform'.");
				Report.Info("CSV Value =" + Plat);			
				Report.Error("Value " + Plat + " Does Not Exist for Platform Field, Selecting 1st Item Available");	
			}
		}
		
		//************************************************************************************//
		//******************Validates Activity value from csv file****************************//
		//************************************************************************************//
		
		public void ValidateAct()
		{
			if (!ActFlag)
			{			
				Report.Info("Validating AttributeEqual (Text='Activity') on item 'FormMain__Air_TN_(TN)_.ListItemActivity'.");
				Report.Info("Value Selected =" + Act);
				Validate.Attribute(repo.FormMain__Air_TN.ListItemActivityInfo, "AccessibleValue", Act, Validate.DefaultMessage, false);
			}
			else
			{
				Report.Info("Validating AttributeEqual (Text='Activity') on item 'FormMain__Air_TN_(TN)_.ListItemActivity'.");
				Report.Info("CSV Value =" + Act);				
				Report.Error("Value " + Act + " Does Not Exist for Activity Field, Selecting 1st Item Available");	
			}
		}
		
		//************************************************************************************//
		//********************Validates Specific Type value from csv file*********************//
		//************************************************************************************//
		
		public void ValidateStype()
		{
			if (!StypeFlag)
			{
				Report.Info("Validating AttributeEqual (Text='Specific Type') on item 'FormMain__Air_TN_(TN)_.ListItemSpecificType.");
				Report.Info("Value Selected =" + Stype);		
				Validate.Attribute(repo.FormMain__Air_TN.ListItemStypeInfo, "AccessibleValue", Stype, Validate.DefaultMessage, false);
			}
			else
			{
				Report.Info("Validating AttributeEqual (Text='Specific Type') on item 'FormMain__Air_TN_(TN)_.ListItemSpecificType.");
				Report.Info("CSV Value =" + Stype);				
				Report.Error("Value " + Stype + " Does Not Exist for Specifc Type Field, Selecting 1st Item Available");	
			}
		}
		
		//************************************************************************************//
		//****************************Drops Corresponding Track*******************************//
		//************************************************************************************//
		
		public void DropTrack()
		{			
			Drop_Track.DropTrack.Start();
		}		
		
		//**************************************************************************************//
		//****************************Ranorex Generated Default Method**************************//
		//**************************************************************************************//		

		static ValidateAirTrack6016D()
		{
			//Your recording specific initialization code goes here.
		}
		
		//**************************************************************************************//
		//*****************************Ranorex Generated Init Method****************************//
		//**************************************************************************************//		

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}
