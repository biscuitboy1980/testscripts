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

namespace TacViewLib.UISpecific.ModeCodes.Air
{
	/// <summary>
	/// The ValidateTrackRegression recording.
	/// </summary>

	public partial class ValidateAirMode2Codes
	{
		
		public bool ZoomFlag = false;
		public string TrackNum;		

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

		static ValidateAirMode2Codes()
		{
			//Your recording specific initialization code goes here.
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}		

	}
}