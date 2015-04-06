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

namespace TacViewLib.LinkSpecific.Surveillance.Space.ValidateTrack
{
	/// <summary>
	/// The ValidateTrack recording.
	/// </summary>
	
	public partial class ValidateSpaceTrack6016D
	{
		public static bool ZoomFlag = false;		
		public static string TrackNum;		
		
		//Basic Info
		public static string ID;
		public static string DI;		

		//Out of Range Flags
		public static bool PlatFlag;
		public static bool ActFlag;
		public static bool StypeFlag;
		public static bool SampFlag;
		
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
		       	Report.Info("Mouse Left Click item 'FormTOAD2.MenuItemTrack_Properties");
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
			Report.Info("Validating AttributeEqual (Text='(ID)') on item 'FormMain__Space_TN.ListItemIdentity'.");
			Report.Info("Value Entered =" + ID);
			Validate.Attribute(repo.FormMain__Space_TN.ListItemIdentityInfo, "AccessibleValue", ID, Validate.DefaultMessage, false);
		}
		
		//************************************************************************************//
		//*******************Validates Platform value from csv file***************************//
		//************************************************************************************//
		
		public void ValidatePlat()
		{
			if (!PlatFlag)
			{
				Report.Info("Validating AttributeEqual (Text='Platform') on item 'FormMain__Space_TN.ListItemPlatform'.");
				Report.Info("Value Entered =" + Plat + "-" + PlatN);
				Validate.Attribute(repo.FormMain__Space_TN.ListItemPlatformInfo, "AccessibleValue", Plat, Validate.DefaultMessage, false);
			}
			else
			{
				Report.Info("Validating AttributeEqual (Text='Platform') on item 'FormMain__Space_TN.ListItemPlatform'.");
				Report.Info("Value Entered =" + Plat + "-" + PlatN);				
				Report.Error("Value " + Plat + "-" + PlatN + " Does Not Exist for Platform Field, Selecting 1st Item Available");	
			}
		}
		
		//************************************************************************************//
		//******************Validates Activity value from csv file****************************//
		//************************************************************************************//
		
		public void ValidateAct()
		{
			if (!ActFlag)
			{
				Report.Info("Validating AttributeEqual (Text='Activity') on item 'FormMain__Space_TN.ListItemActivity'.");
				Report.Info("Value Entered =" + Act + "-" + ActN);
				Validate.Attribute(repo.FormMain__Space_TN.ListItemActivityInfo, "AccessibleValue", Act, Validate.DefaultMessage, false);
			}
			else
			{
				Report.Info("Validating AttributeEqual (Text='Activity') on item 'FormMain__Space_TN.ListItemActivity'.");
				Report.Info("Value Entered =" + Act + "-" + ActN);			
				Report.Error("Value " + Act + "-" + ActN + " Does Not Exist for Activity Field, Selecting 1st Item Available");	
			}
		}
		
		//************************************************************************************//
		//********************Validates Specific Type value from csv file*********************//
		//************************************************************************************//
		
		public void ValidateStype()
		{
			if (!StypeFlag)
			{
				Report.Info("Validating AttributeEqual (Text='Specific Type') on item 'FormMain__Space_TN.ListItemSpecificType.");
				Report.Info("Value Entered =" + Stype + "-" + StypeN);		
				Validate.Attribute(repo.FormMain__Space_TN.ListItemStypeInfo, "AccessibleValue", Stype, Validate.DefaultMessage, false);
			}
			else
			{
				Report.Info("Validating AttributeEqual (Text='Specific Type') on item 'FormMain__Space_TN.ListItemSpecificType.");
				Report.Info("Value Entered =" + Stype + "-" + StypeN);				
				Report.Error("Value " + Stype + "-" + StypeN + " Does Not Exist for Specifc Type Field, Selecting 1st Item Available");	
			}
		}
		
		//************************************************************************************//
		//****************Validates Space Amplilfication value from csv file******************//
		//************************************************************************************//
		
		public void ValidateSamp()
		{
			if (!SampFlag)
			{
				Report.Info("Validating AttributeEqual (Text='Space Amplification') on item 'FormMain__Space_TN.ListItemSpace_Amplification.");
				Report.Info("Value Entered =" + Samp + "-" + SampN);				
				Validate.Attribute(repo.FormMain__Space_TN.ListItemSpace_AmplificationInfo, "AccessibleValue", Samp, Validate.DefaultMessage, false);
			}
			else
			{
				Report.Info("Validating AttributeEqual (Text='Space Amplification') on item 'FormMain__Space_TN.ListItemSpace_Amplification.");
				Report.Info("Value Entered =" + Samp + "-" + SampN);					
				Report.Error("Value " + Samp + "-" + SampN + " Does Not Exist for Space Amplification Field, Selecting 1st Item Available");	
			}
		}		

		//************************************************************************************//
		//****************Validates Data Indicator value from csv file******************//
		//************************************************************************************//
		
		public void ValidateDI()
		{
			Report.Info("Validating AttributeEqual (Text='Data Indicator') on item 'FormMain__Space_TN.ListItemData_Indicator.");
			Report.Info("Value Entered =" + DI);			
			Validate.Attribute(repo.FormMain__Space_TN.ListItemData_IndicatorInfo, "AccessibleValue", DI, Validate.DefaultMessage, false);
		}	
		
		//************************************************************************************//
		//****************************Drops Corresponding Track*******************************//
		//************************************************************************************//
		
		public void DropTrack()
		{			
			Drop_Track.DropTrack.Instance.Connection1 = Connection1;
			Drop_Track.DropTrack.Start();
		}		
		
		//**************************************************************************************//
		//****************************Ranorex Generated Default Method**************************//
		//**************************************************************************************//		

		static ValidateSpaceTrack6016D()
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