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

namespace TacViewLib.LinkSpecific.Weapons.DropTrack
{
	/// <summary>
	/// The DropTrack recording.
	/// </summary>
	public partial class DropTrack
	{		
		public static string TrackNum;	
		public static bool multidrop = false;
		
			
		public void DropTrackSequence()
		{			
			if (!multidrop)
			{
				tracknumber = TrackNum;	
			
				Mouse.DefaultMoveTime = 0;
				Keyboard.DefaultKeyPressTime = 0;
				Mouse.DefaultClickTime = 0;	
				Delay.SpeedFactor = 0;	
				
				Duration OrigDur = repo.FormRealView.MenuItemTracksInfo.SearchTimeout;
				repo.FormRealView.MenuItemTracksInfo.SearchTimeout = 2000;
				Duration OrigDur1 = repo.FormRealView.MenuItemTrackNumberInfo.SearchTimeout;
				repo.FormRealView.MenuItemTrackNumberInfo.SearchTimeout = 2000;
			
				if (repo.FormRealView.MenuItemTracksInfo.Exists())
				{
					Report.Info("Dropping Track # " + TrackNum);
					Report.Info("Mouse Left Click item 'FormRealView.MenuItemTracks'");
				    repo.FormRealView.MenuItemTracks.Click();
				    Report.Info("Mouse Left Click item 'FormTracks.MenuItemC2_HOST_Track'");
			        repo.FormTracks.MenuItemConnection1_Track.Click();
			       	Report.Info("Mouse Left Click item 'FormTOAD2.MenuItemDrop_Track'");
					repo.FormConnection1.MenuItemDrop_Track.Click();
					repo.RealViewDialog.ButtonYes.Click();
				}			
				else if (repo.FormRealView.MenuItemTrackNumberInfo.Exists())
				{
					Report.Info("Dropping Track # " + TrackNum);
				    Report.Info("Mouse Left Click item 'repo.FormRealView.MenuItemTrackNumber'");
			        repo.FormRealView.MenuItemTrackNumber.Click();
			       	Report.Info("Mouse Left Click item 'repo.FormTOAD.MenuItemDrop_Track'");
					repo.FormConnection1.MenuItemDrop_Track.Click();
					repo.RealViewDialog.ButtonYes.Click();
				}
				else 
				{
					repo.FormRealView.MenuItemDrop_Track.Click();
					repo.RealViewDialog.ButtonYes.Click();
				}
			
				repo.FormRealView.MenuItemTracksInfo.SearchTimeout = OrigDur;
				repo.FormRealView.MenuItemTrackNumberInfo.SearchTimeout = OrigDur1;
			}
			else
			{
				TrackNum = Association.ValidateAssociation.track2;
				tracknumber = TrackNum;
				
				Duration OrigDur = repo.FormRealView.MenuItemTracksInfo.SearchTimeout;
				repo.FormRealView.MenuItemTracksInfo.SearchTimeout = 2000;
				Duration OrigDur1 = repo.FormRealView.MenuItemTrackNumber2Info.SearchTimeout;
				repo.FormRealView.MenuItemTrackNumberInfo.SearchTimeout = 2000;
				
				if (repo.FormRealView.MenuItemTracksInfo.Exists())
				{
					Report.Info("Dropping Track # " + TrackNum);
					Report.Info("Mouse Left Click item 'FormRealView.MenuItemTracks'");
				    repo.FormRealView.MenuItemTracks.Click();
				    Report.Info("Mouse Left Click item 'FormTracks.MenuItemC2_HOST_2_Track'");
			        repo.FormTracks.MenuItemConnection2_Track.Click();
			       	Report.Info("Mouse Left Click item 'FormTOAD2.MenuItemDrop_Track'");
					repo.FormConnection1.MenuItemDrop_Track.Click();
					repo.RealViewDialog.ButtonYes.Click();
				}			
				else if (repo.FormRealView.MenuItemTrackNumber2Info.Exists())
				{
					Report.Info("Dropping Track # " + TrackNum);
				    Report.Info("Mouse Left Click item 'repo.FormRealView.MenuItemTrackNumber'");
			        repo.FormRealView.MenuItemTrackNumber2.Click();
			       	Report.Info("Mouse Left Click item 'repo.FormTOAD.MenuItemDrop_Track'");
					repo.FormConnection1.MenuItemDrop_Track.Click();
					repo.RealViewDialog.ButtonYes.Click();
				}
				else 
				{
					repo.FormRealView.MenuItemDrop_Track.Click();
					repo.RealViewDialog.ButtonYes.Click();
				}
				
				repo.FormRealView.MenuItemTracksInfo.SearchTimeout = OrigDur;	
				multidrop = false;
			}	
		}

		static DropTrack()
		{
			//Your recording specific initialization code goes here.
		}

        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
	}
}