﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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

namespace TacViewLib.LinkSpecific.Weapons.Association
{
    public partial class AssociateTracks
    {
		public static string track1;	
		public static string track2;	
		
		public static bool ZoomFlag;
		
		//************************************************************************************//
		//*****************************Sets Track Number in Repo******************************//
		//************************************************************************************//
		
		public void SetTrackNumberInRepo()
		{
			tracknumber = track1;	
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
				Report.Info("Track # " + track1 + " not found on the current display, going to world wide view");
				Report.Screenshot();
				repo.FormTacViewC2.ButtonZoom_Out_Max.Click();
				
				if (repo.FormTacViewC2.PictureTrackInfo.Exists())
				{
					Report.Info("Mouse Right Click item 'FormTacViewC2.PictureTrack' at Center.");
					repo.FormTacViewC2.PictureTrack.Click(MouseButtons.Right);
				}
				else
				{
					Report.Error("Unable to find Track # " + track1 + " anywhere in the world");
					Report.Screenshot();
					return;
				}				
			}
			
			repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = OrigDur;
		}		

		//************************************************************************************//
		//**************************Opens Track Correlation Dialog****************************//
		//************************************************************************************//
		
		public void Associate()
		{			
			Duration OrigDur = repo.FormRealView.MenuItemTracksInfo.SearchTimeout;
			repo.FormRealView.MenuItemTracksInfo.SearchTimeout = 1000;
			Duration OrigDur1 = repo.FormRealView.MenuItemTrackNumberInfo.SearchTimeout;
			repo.FormRealView.MenuItemTrackNumberInfo.SearchTimeout = 1000;			
			
			if (repo.FormRealView.MenuItemTracksInfo.Exists())
			{
				Report.Info("Mouse Left Click item 'FormRealView.MenuItemTracks'");
			    repo.FormRealView.MenuItemTracks.Click();
			    Report.Info("Mouse Left Click item 'FormTracks.MenuItemC2_HOST_Track'");
		        repo.FormTracks.MenuItemC2_HOST_Track.Click();
		       	Report.Info("Mouse Left Click item 'FormTOAD2.MenuItemWeapons");
				repo.FormTOAD.MenuItemWeapons.Click();
		       	Report.Info("Mouse Left Click item 'FormWeapons.MenuItemAssociate__J7_7");
				repo.FormWeapons.MenuItemAssociate__J7_7.Click();					
			}			
			else if (repo.FormRealView.MenuItemTrackNumberInfo.Exists())
			{
			    Report.Info("Mouse Left Click item 'repo.FormRealView.MenuItemTrackNumber'");
		        repo.FormRealView.MenuItemTrackNumber.Click();
		       	Report.Info("Mouse Left Click item 'FormTOAD2.MenuItemWeapons");
				repo.FormTOAD.MenuItemWeapons.Click();
		       	Report.Info("Mouse Left Click item 'FormWeapons.MenuItemAssociate__J7_7");
				repo.FormWeapons.MenuItemAssociate__J7_7.Click();						
			}
			
			repo.FormRealView.MenuItemTracksInfo.SearchTimeout = OrigDur;
			repo.FormRealView.MenuItemTrackNumberInfo.SearchTimeout = OrigDur1;
		}

        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

		//************************************************************************************//
		//****************************Enters Track to be Dropped******************************//
		//************************************************************************************//
		
        public void Objective()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence " + track2, new RecordItemIndex(-1));
            Keyboard.Press(track2);
        }
    }
}