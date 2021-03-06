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

namespace TacViewLib.LinkSpecific.TNAccountability
{
    public partial class UnitValidate
    {
    	
    	public static string UnitNum;
    	public static bool ZoomFlag;
    	
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

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

        public void RightClickTrack()
        {
			
			Duration OrigDur = repo.FormTacViewC2.PictureSiteInfo.SearchTimeout;
			repo.FormTacViewC2.PictureSiteInfo.SearchTimeout = 2000;			
			
			if (repo.FormTacViewC2.PictureSiteInfo.Exists())
			{
				Report.Info("Mouse Right Click item 'FormTacViewC2.PictureSite' at Center.");
				repo.FormTacViewC2.PictureSite.Click(MouseButtons.Right);
			}
			else
			{
				ZoomFlag = true;
				Report.Info("Site # " + UnitNum + " not found on the current display, going to world wide view");
				Report.Screenshot();
				repo.FormTacViewC2.ButtonZoom_Out_Max.Click();
				
				if (repo.FormTacViewC2.PictureSiteInfo.Exists())
				{
					Report.Info("Mouse Right Click item 'FormTacViewC2.PictureSite' at Center.");
					repo.FormTacViewC2.PictureSite.Click(MouseButtons.Right);
				}
				else
				{
					Report.Error("Unable to find Site # " + UnitNum + " anywhere in the world");
					Report.Screenshot();
					return;
				}				
			}
			
			repo.FormTacViewC2.PictureSiteInfo.SearchTimeout = OrigDur;
        }

        public void CreateTrackRepoItems()
        {
			
			string currentPath = repo.FormTacViewC2.PictureSiteInfo.Path.ToString();
			repo.FormTacViewC2.PictureSiteInfo.Path = currentPath.Replace("%track%", UnitNum);
			Report.Info("Setting repo item FormTacViewC2.PictureSite to " + repo.FormTacViewC2.PictureSiteInfo.Path.ToString());							
			
			string currentPath2 = repo.FormRealView.MenuItemSiteNumber2Info.Path.ToString();
			repo.FormRealView.MenuItemSiteNumber2Info.Path = currentPath2.Replace("%track%", UnitNum);
			Report.Info("Setting repo item FormRealView.MenuItemSiteNumber2 to " + repo.FormRealView.MenuItemSiteNumber2Info.Path.ToString());
        }

        public void JUCenter()
        {
			Duration OrigDur1 = repo.FormRealView.MenuItemTrackNumsInfo.SearchTimeout;
			repo.FormRealView.MenuItemTrackNumsInfo.SearchTimeout = 500;
			
			Duration OrigDur2 = repo.FormRealView.MenuItemTracksInfo.SearchTimeout;
			repo.FormRealView.MenuItemTracksInfo.SearchTimeout = 500;
			
			if (repo.FormRealView.MenuItemTracksInfo.Exists())
			{
				Report.Info("Mouse Left Click item 'FormRealView.MenuItemTracks' at Center.");
				repo.FormRealView.MenuItemTracks.Click("Center");
				Report.Info("Mouse Left Click item 'FormRealView.MenuItemTrackNums' at Center.");
				Accessible site = @"/form[@title='Tracks']/contextmenu[1]/menuitem[@accessiblename~'.*Track#" + UnitNum + "$']";
   				Accessible accElement = new Accessible(site);  
				site.Click("Center");	
				repo.FormConnection.MenuItemCenter_On_Track.Click("Center");
			}			
			else if (repo.FormRealView.MenuItemTrackNumsInfo.Exists())
				{
				Report.Info("Mouse Left Click item 'FormRealView.MenuItemTrackNums' at Center.");
				Accessible site = @"/form[@title='' and @processname='RealView' and @class~'Afx:00*']/contextmenu[1]/menuitem[@accessiblename~'.*Track#" + UnitNum + "']";
   				Accessible accElement = new Accessible(site);  
				site.Click("Center");	
				repo.FormConnection.MenuItemCenter_On_Track.Click("Center");
				}
			else
				{
				Report.Info("Mouse Left Click item 'FormRealView.MenuItemCenter_On_Track' at Center.");
				repo.FormRealView.MenuItemCenter_On_Track.Click();
				}
			
			repo.FormRealView.MenuItemTrackNumsInfo.SearchTimeout = OrigDur1;	
			repo.FormRealView.MenuItemTracksInfo.SearchTimeout = OrigDur2;
        }

        public void KeyboardUnit()
        {
			Report.Info("Key 'UnitNum' Press.");
			tracknumber = UnitNum;
			Keyboard.Press(UnitNum);
        }

        public void Mouse_Click_ButtonSearch_For_Track1()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.ButtonSearch_For_Track' at Center.", repo.FormTacViewC2.ButtonSearch_For_TrackInfo, new RecordItemIndex(-1));
            repo.FormTacViewC2.ButtonSearch_For_Track.Click(150);
        }

        public void Validate_TrackNumber()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue=" + UnitNum);
            Validate.Attribute(repo.FormMain__Site_TN.ListItemTrack_NumberInfo, "AccessibleValue", UnitNum);
        }


    }
}