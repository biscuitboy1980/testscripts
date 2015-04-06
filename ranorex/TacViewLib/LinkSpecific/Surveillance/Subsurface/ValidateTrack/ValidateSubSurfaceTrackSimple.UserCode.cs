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
using Ranorex.Core.Testing;

namespace TacViewLib.LinkSpecific.Surveillance.Subsurface.ValidateTrack
{
	public partial class ValidateSubSurfaceTrackSimple
	{
		public static bool ZoomFlag = false;		
		public static string TrackNum;
		public static bool ExitFlag1;
		public static bool ExitFlag2;
		
		//Basic Info
		public static string ID;
		public static string Link11ID;
		public static string Link11PriAmp;
		
		//Out of Range Flags
		public static bool ID_OOR;
		
		public static bool Link11 = false;
		public static string L11ID;
		public static string L11PriAmp;		
		
		//************************************************************************************//
		//***************************Creates Run-Time Repo Items******************************//
		//************************************************************************************//		
		
		public void CreateTrackRepoItems()
		{			
			if (!ExitFlag1)
			{
				string currentPath = repo.FormTacViewC2.PictureTrackInfo.Path.ToString();
				repo.FormTacViewC2.PictureTrackInfo.Path = currentPath.Replace("%track%", TrackNum);
				Report.Info("Setting repo item FormTacViewC2.PictureTrack to " + repo.FormTacViewC2.PictureTrackInfo.Path.ToString());
				
				string currentPath1 = repo.FormTracks.MenuItemConnection2_TrackInfo.Path.ToString();
				repo.FormTracks.MenuItemConnection2_TrackInfo.Path = currentPath1.Replace("%track%", TrackNum);
				Report.Info("Setting repo item FormTracks.MenuItemC2_HOST_2_Track to " + repo.FormTracks.MenuItemConnection2_TrackInfo.Path.ToString());
				
				string currentPath2 = repo.FormRealView.MenuItemTrackNumber2Info.Path.ToString();
				repo.FormRealView.MenuItemTrackNumber2Info.Path = currentPath2.Replace("%track%", TrackNum);
				Report.Info("Setting repo item FormRealView.MenuItemTrackNumber2 to " + repo.FormRealView.MenuItemTrackNumber2Info.Path.ToString());
				
				string currentPath3 = repo.FormRealView.MenuItemTrackNumberInfo.Path.ToString();
				repo.FormRealView.MenuItemTrackNumberInfo.Path = currentPath3.Replace("%track%", TrackNum);
				Report.Info("Setting repo item FormRealView.MenuItemTrackNumber to " + repo.FormRealView.MenuItemTrackNumberInfo.Path.ToString());
				
				string currentPath4 = repo.FormTracks.MenuItemConnection1_TrackInfo.Path.ToString();
				repo.FormTracks.MenuItemConnection1_TrackInfo.Path = currentPath4.Replace("%track%", TrackNum);
				Report.Info("Setting repo item FormTracks.MenuItemC2_HOST_Track to " + repo.FormTracks.MenuItemConnection1_TrackInfo.Path.ToString());
			}
		}		
		
		//************************************************************************************//
		//******************************Right Clicks on Track*********************************//
		//************************************************************************************//		
		
		public void RightClickTrack()
		{			
			if (!ExitFlag1)
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
						ExitFlag2 = true;
					}				
				}
				
				repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = OrigDur;
			}		
		}
		
		//************************************************************************************//
		//*******************Opens Track Dialog For Corresponding Track***********************//
		//************************************************************************************//		
		
		public void ViewTrackProperties()
		{		
			if (!ExitFlag2)
			{
				Duration OrigDur = repo.FormRealView.MenuItemTracksInfo.SearchTimeout;
				repo.FormRealView.MenuItemTracksInfo.SearchTimeout = 1000;
				Duration OrigDur1 = repo.FormRealView.MenuItemTrackNumber2Info.SearchTimeout;
				repo.FormRealView.MenuItemTrackNumber2Info.SearchTimeout = 1000;	
				Duration OrigDur2 = repo.FormRealView.MenuItemDrop_TrackInfo.SearchTimeout;
				repo.FormRealView.MenuItemDrop_TrackInfo.SearchTimeout = 1000;	
				
				int i = 0;
							
				while (repo.FormRealView.MenuItemDrop_TrackInfo.Exists() && (i < 4))					
				{
					i++;
					Report.Debug("Unable to find " + TrackNum + " on C2 HOST Interface, waiting 20 seconds and attempting to re-execute");
					Keyboard.Press(Keys.Escape);
					Delay.Seconds(20);	
					RightClickTrack();
				}
				
				if (i < 4)
				{					
					if (repo.FormRealView.MenuItemTracksInfo.Exists())
					{
						Report.Info("Mouse Left Click item 'FormRealView.MenuItemTracks'");
						repo.FormRealView.MenuItemTracks.Click();
						Report.Info("Mouse Left Click item 'FormTracks.MenuItemC2_HOST_2_Track'");
						repo.FormTracks.MenuItemConnection2_Track.Click();
						Report.Info("Mouse Left Click item 'FormTOAD2.MenuItemTrack_Properties' at 103;14.");
						repo.FormConnection2.MenuItemTrack_Properties.Click();
					}			
					else if (repo.FormRealView.MenuItemTrackNumber2Info.Exists())
					{
						Report.Info("Mouse Left Click item 'repo.FormRealView.MenuItemTrackNumber2'");
						repo.FormRealView.MenuItemTrackNumber2.Click();
						Report.Info("Mouse Left Click item 'FormTOAD2.MenuItemTrack_Properties' at 103;14.");
						repo.FormConnection2.MenuItemTrack_Properties.Click();
					}
				}				
				else
				{
					Report.Error("Unable to find " + TrackNum + " on C2 HOST Interface aborting validate");
					Keyboard.Press(Keys.Escape);
					RightClickTrack();
					DropTrack();
					ExitFlag2 = true;
					return;
				}
	
				repo.FormRealView.MenuItemTracksInfo.SearchTimeout = OrigDur;
				repo.FormRealView.MenuItemTrackNumber2Info.SearchTimeout = OrigDur1;
				repo.FormRealView.MenuItemDrop_TrackInfo.SearchTimeout = OrigDur2;
			}
		}			
		
		//************************************************************************************//
		//****************************Validates Track Type Value******************************//
		//************************************************************************************//		

		public void ValidateTrackType()
		{
			if (!ExitFlag2)
			{
				if (Link11 == true)
				{
					Report.Info("Validating AttributeEqual (AccessibleValue='L11 SubSurface') on item 'FormMain__SubSurface_TN.ListItemTrack_Type'.");
					Validate.Attribute(repo.FormMain__SubSurface_TN.ListItemTrack_TypeInfo, "AccessibleValue", "L11 SubSurface", Validate.DefaultMessage, false);
				}
				else
				{
					Report.Info("Validating AttributeEqual (AccessibleValue='SubSurface') on item 'FormMain__SubSurface_TN.ListItemTrack_Type'.");
					Validate.Attribute(repo.FormMain__SubSurface_TN.ListItemTrack_TypeInfo, "AccessibleValue", "SubSurface", Validate.DefaultMessage, false);
				}
			}
		}		
		
		//************************************************************************************//
		//*****************************Validates Identity value****************矔**************//
		//************************************************************************************//
				
		public void ValidateID()
		{
			if (!ExitFlag2)
			{
				if (!ID_OOR)
				{
					if (Link11 == true)
					{
						CommonUtilLib.Forwarding ForwardingFunctions = new CommonUtilLib.Forwarding();
						L11ID = ForwardingFunctions.ConvertID_Subsurface(ID);	
						Report.Info("Value Entered = " + ID);
						Report.Info("Value Received = " + L11ID);					
						Report.Info("Validating AttributeEqual (Text='(ID)') on item 'FormMain__SubSurface_TN.ListItemIdentity'.");
						Validate.Attribute(repo.FormMain__SubSurface_TN.ListItemIdentityInfo, "AccessibleValue", L11ID, Validate.DefaultMessage, false);	
						Report.Info("Mouse Left Click item 'FormMain__SubSurface_TN.ButtonCLOSE' at Center.");
						repo.FormMain__SubSurface_TN.ButtonCLOSE.Click();
					}
					else
					{
						Report.Info("Validating AttributeEqual (Text='(ID)') on item 'FormMain__SubSurface_TN.ListItemIdentity'.");
						Report.Info("Value Entered = " + ID);
						Validate.Attribute(repo.FormMain__SubSurface_TN.ListItemIdentityInfo, "AccessibleValue", ID, Validate.DefaultMessage, false);
						Report.Info("Mouse Left Click item 'FormMain__SubSurface_TN.ButtonCLOSE' at Center.");
						repo.FormMain__SubSurface_TN.ButtonCLOSE.Click();
					}
				}
			}
		}
			
		//************************************************************************************//
		//****************************Drops Corresponding Track*******************************//
		//************************************************************************************//
		
		public void DropTrack()
		{		
			if (!ExitFlag2)
			{
				Report.Info("Mouse Right Click item 'FormTacViewC2.PictureTrack' at Center.");
				repo.FormTacViewC2.PictureTrack.Click(MouseButtons.Right, 150);			
				Drop_Track.DropTrack.Start();
				Delay.Seconds(10);
			}
		}
		
		//************************************************************************************//
		//*******************************Validates Drop Track*********************************//
		//************************************************************************************//
		
		public void Validate_DropTrack()
		{	
			if (!ExitFlag2)
			{
				Report.Info("Validating Track # " + TrackNum + " was dropped");
		
				bool result = Validate.NotExists(repo.FormTacViewC2.PictureTrackInfo.AbsolutePath, 1000, Validate.DefaultMessage, false);
				
				if (result == true)
				{
					Report.Success("Successfully dropped track # " + TrackNum);
				}
				else
				{
					Report.Screenshot();
					Report.Debug("Track # " + TrackNum + " failed to drop within 10 seconds, proceeding to next track creation.");
				}		
			}
		}		

		//************************************************************************************//
		//*****************************Zooms Out to Locate Track******************************//
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
		//************************Resets Paths Created at Run-Time****************************//
		//************************************************************************************//		
		
		public void ResetPaths()
		{
			if (!ExitFlag1)
			{
				string currentPath = repo.FormTacViewC2.PictureTrackInfo.Path.ToString();
				repo.FormTacViewC2.PictureTrackInfo.Path = currentPath.Replace(TrackNum, "%track%");
				Report.Info("Resetting repo item FormTacViewC2.PictureTrack repo item to" + repo.FormTacViewC2.PictureTrackInfo.Path.ToString());
	
				string currentPath1 = repo.FormTracks.MenuItemConnection2_TrackInfo.Path.ToString();
				repo.FormTracks.MenuItemConnection2_TrackInfo.Path = currentPath1.Replace(TrackNum, "%track%");
				Report.Info("Resetting repo item FormTracks.MenuItemC2_HOST_2_Track to " + repo.FormTracks.MenuItemConnection2_TrackInfo.Path.ToString());
				
				string currentPath2 = repo.FormRealView.MenuItemTrackNumber2Info.Path.ToString();
				repo.FormRealView.MenuItemTrackNumber2Info.Path = currentPath2.Replace(TrackNum, "%track%");
				Report.Info("Resetting repo item FormRealView.MenuItemTrackNumber2 to " + repo.FormRealView.MenuItemTrackNumber2Info.Path.ToString());
				
				string currentPath3 = repo.FormRealView.MenuItemTrackNumberInfo.Path.ToString();
				repo.FormRealView.MenuItemTrackNumberInfo.Path = currentPath3.Replace(TrackNum, "%track%");
				Report.Info("Resetting repo item FormRealView.MenuItemTrackNumber to " + repo.FormRealView.MenuItemTrackNumberInfo.Path.ToString());
				
				string currentPath4 = repo.FormTracks.MenuItemConnection1_TrackInfo.Path.ToString();
				repo.FormTracks.MenuItemConnection1_TrackInfo.Path = currentPath4.Replace(TrackNum, "%track%");
				Report.Info("Resetting repo item FormTracks.MenuItemC2_HOST_Track to " + repo.FormTracks.MenuItemConnection1_TrackInfo.Path.ToString());		
			}
		}
		
		public void SetTrackNumberInRepo()
		{
			tracknumber = TrackNum;
			
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

	}

}
