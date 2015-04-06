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

namespace TacViewLib.UISpecific.ATOUpgrade.Mode2andMode3Codes_Correlation_Test
{
	/// <summary>
	/// The ValidateAirTrack recording.
	/// </summary>
	public partial class ValidateMode3AirTrack
	{		
		public bool ZoomFlag = false;		
		public string TrackNum;
		
		//Basic Info
		public string ID;
		public string Plat;
		public string Act;
		public string Stype;
		
		//Position & Velocity
		public string Alt;
		public string Vel;
		public double Crs;
		
		//Modes & Codes
		public string M2;
		public string M3;

		//Out of Range Flags
		public bool ID_OOR;
		public bool Plat_OOR;
		public bool Act_OOR;
		public bool Stype_OOR;
	
		static ValidateMode3AirTrack()
		{
			//Your recording specific initialization code goes here.
		}
		
//************************************************************************************//
		//***************************Creates Run-Time Repo Items******************************//
		//************************************************************************************//		

		public void CreateTrackRepoItems()
		{			
			string currentPath = repo.FormTacViewC2.PictureTrackInfo.Path.ToString();
			repo.FormTacViewC2.PictureTrackInfo.Path = currentPath.Replace("%track%", TrackNum);
			Report.Info("Setting repo item FormTacViewC2.PictureTrack to " + repo.FormTacViewC2.PictureTrackInfo.Path.ToString());
						
			string currentPath3 = repo.FormRealView.MenuItemTrackNumberInfo.Path.ToString();
			repo.FormRealView.MenuItemTrackNumberInfo.Path = currentPath3.Replace("%track%", TrackNum);
			Report.Info("Setting repo item FormRealView.MenuItemTrackNumber to " + repo.FormRealView.MenuItemTrackNumberInfo.Path.ToString());
		}
		
		//************************************************************************************//
		//************************************************************************************//
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
		//*******************Opens Track Dialog For Corresponding Track***********************//
		//************************************************************************************//
		
		public void ViewTrackProperties()
		{			
			Duration OrigDur = repo.FormRealView.MenuItemTrackNumberInfo.SearchTimeout;
			repo.FormRealView.MenuItemTrackNumberInfo.SearchTimeout = 1000;			

			if (repo.FormRealView.MenuItemTrackNumberInfo.Exists())
			{			    
			    Report.Info("Mouse Left Click item 'repo.FormRealView.MenuItemTrackNumber'");
		        repo.FormRealView.MenuItemTrackNumber.Click();
		       	Report.Info("Mouse Left Click item 'FormRealView.MenuItemTrack_Properties");
				repo.FormRealView.MenuItemTrack_Properties.Click();
			}
			else
			{
				Report.Info("Mouse Left Click item 'FormRealView.MenuItemTrack_Properties");
				repo.FormRealView.MenuItemTrack_Properties.Click();
			}
			
			repo.FormRealView.MenuItemTrackNumberInfo.SearchTimeout = OrigDur;
		}
		
		//************************************************************************************//
		//***************************Validates Track is Dropped*******************************//
		//************************************************************************************//
		
		public void Validate_DropTrack()
		{
			Duration OrigDur = repo.FormTacViewC2.PictureTrackInfo.SearchTimeout;
			repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = 3000;

			Report.Info("Validating Track # " + TrackNum + " was dropped");
	
			bool result = Validate.NotExists(repo.FormTacViewC2.PictureTrackInfo, Validate.DefaultMessage, false);
			
				if (result == true)
				{
					Report.Success("Successfully dropped track # " + TrackNum);
				}
				else
				{
					Report.Debug("Track # " + TrackNum + " failed to drop within 15 seconds, proceeding to next track creation.");
					Report.Screenshot();				
				}
			
			repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = OrigDur;
		}			
		
		//************************************************************************************//
		//************************Resets Paths Created at Run-Time****************************//
		//************************************************************************************//
		
		public void ResetPaths()
		{
			string currentPath = repo.FormTacViewC2.PictureTrackInfo.Path.ToString();
			repo.FormTacViewC2.PictureTrackInfo.Path = currentPath.Replace(TrackNum, "%track%");
			Report.Info("Resetting repo item FormTacViewC2.PictureTrack repo item to" + repo.FormTacViewC2.PictureTrackInfo.Path.ToString());
		
			string currentPath3 = repo.FormRealView.MenuItemTrackNumberInfo.Path.ToString();
			repo.FormRealView.MenuItemTrackNumberInfo.Path = currentPath3.Replace(TrackNum, "%track%");
			Report.Info("Resetting repo item FormRealView.MenuItemTrackNumber to " + repo.FormRealView.MenuItemTrackNumberInfo.Path.ToString());
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}