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

namespace TacViewLib.Defects.D03968
{
	/// <summary>
	/// The D03968Validate recording.
	/// </summary>
	public partial class D03968Validate
	{				
		public static int Tcount;
					
		//Track Info
		public static string PType;
		public static string Amp;
		public static string SonoType;
		public static string SonoPType;
		public static string TrackNum;
		
		//Flags 
		public static bool Ptype_OOR;
		public static bool Amp_OOR;
		public static bool Sontype_OOR;
		public static bool SonPattype_OOR;
		public static bool ZoomFlag;
		
		static D03968Validate()
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
				repo.FormTacViewC2.ButtonZoom_Out_Max.Click();
				
				if (repo.FormTacViewC2.PictureTrackInfo.Exists())
				{
					Report.Info("Mouse Right Click item 'FormTacViewC2.PictureTrack' at Center.");
					repo.FormTacViewC2.PictureTrack.Click(MouseButtons.Right);
				}
				else
				{
					Report.Error("Unable to find Track # " + TrackNum + " anywhere in the world");
					Application.Exit();
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
			Duration OrigDur = repo.FormRealView.MenuItemTracksInfo.SearchTimeout;
			repo.FormRealView.MenuItemTracksInfo.SearchTimeout = 1000;
			Duration OrigDur1 = repo.FormRealView.MenuItemTrackNumber2Info.SearchTimeout;
			repo.FormRealView.MenuItemTrackNumber2Info.SearchTimeout = 1000;			
			
			if (repo.FormRealView.MenuItemTracksInfo.Exists())
			{
				Report.Info("Mouse Left Click item 'FormRealView.MenuItemTracks'");
			    repo.FormRealView.MenuItemTracks.Click();
			    Report.Info("Mouse Left Click item 'FormTracks.MenuItemC2_HOST_2_Track'");
		        repo.FormTracks.MenuItemC2_HOST_2_Track.Click();
		       	Report.Info("Mouse Left Click item 'FormTOAD2.MenuItemTrack_Properties' at 103;14.");
				repo.FormTOAD2.MenuItemTrack_Properties.Click();
			}			
			else if (repo.FormRealView.MenuItemTrackNumber2Info.Exists())
			{
			    Report.Info("Mouse Left Click item 'repo.FormRealView.MenuItemTrackNumber2'");
		        repo.FormRealView.MenuItemTrackNumber2.Click();
		       	Report.Info("Mouse Left Click item 'FormTOAD2.MenuItemTrack_Properties' at 103;14.");
				repo.FormTOAD2.MenuItemTrack_Properties.Click();
			}
			
			repo.FormRealView.MenuItemTracksInfo.SearchTimeout = OrigDur;
			repo.FormRealView.MenuItemTrackNumber2Info.SearchTimeout = OrigDur1;
		}
		
		//************************************************************************************//
		//***************************Validates Point Type Value*******************************//
		//************************************************************************************//
				
		public void ValidatePtype()
		{
			bool Defect = false;
					
			if (Defect == false)
			{
			
				if (!Ptype_OOR)
				{
					Report.Info("Validating AttributeEqual (Text='(Point Type)') on item 'FormMain__Reference_Point_TN.ListItemPoint_Type'.");
					Report.Info("Value Entered = " + PType);
					Validate.Attribute(repo.FormMain__Reference_Point_TNProp.ListItemPoint_TypeInfo, "AccessibleValue", PType, Validate.DefaultMessage, false);
				}
			}
				
			else
			{
				Report.Debug("Altitude 2 field is currently not functioning and is written up in R-02142");
			}
		}
		
		//************************************************************************************//
		//**************************Validates Amplification Value*****************************//
		//************************************************************************************//
				
		public void ValidateAmp()
		{
			if (!Amp_OOR)
			{
				Report.Info("Validating AttributeEqual (Text='(Amplification)') on item 'FormMain__Reference_Point_TN.ListItemAmplification'.");
				Report.Info("Value Entered = " + Amp);
				Validate.Attribute(repo.FormMain__Reference_Point_TNProp.ListItemAmplificationInfo, "AccessibleValue", Amp, Validate.DefaultMessage, false);
			}
		}
						
		//************************************************************************************//
		//*****************************Validates Sonobouy Values******************************//
		//************************************************************************************//
				
		public void ValidateSono()
		{
			//Sonobuoy Type
			if (!Sontype_OOR && repo.FormMain__Reference_Point_TNProp.ListItemSonobuoy_TypeInfo.Exists())
			{		
				Report.Info("Validating AttributeEqual (Text='(Sonobuoy Type)') on item 'FormMain__Reference_Point_TNProp.ListItemSonobuoy_Type'.");
				Report.Info("Value Entered = " + SonoType);
				Validate.Attribute(repo.FormMain__Reference_Point_TNProp.ListItemSonobuoy_TypeInfo, "AccessibleValue", SonoType, Validate.DefaultMessage, false);
			}				
			else
			{				
				Report.Warn("Sonobuoy Type Not found in Track Properties, skipping.");				
			}
				
			//Sonobuoy Pattern Type
			if (!SonPattype_OOR)
			{
				Report.Info("Validating AttributeEqual (Text='(Sonobuoy Pattern Type)') on item 'FormMain__Reference_Point_TN.ListItemSonobuoy_Pattern_Type'.");
				Report.Info("Value Entered = " + SonoPType);
				Validate.Attribute(repo.FormMain__Reference_Point_TNProp.ListItemSonobuoy_Pattern_TypeInfo, "AccessibleValue", SonoPType, Validate.DefaultMessage, false);
			}
		}			
				
		//************************************************************************************//
		//****************************Drops Corresponding Track*******************************//
		//************************************************************************************//
		
		public void DropTrack()
		{			
			Drop_Track.DropTrack.Start();
		}
		
		//************************************************************************************//
		//***************************Validates Track is Dropped*******************************//
		//************************************************************************************//		

		public void Validate_DropTrack()
		{			
			Report.Info("Validating Track # " + TrackNum + " was dropped");
	
			bool result = Validate.NotExists(repo.FormTacViewC2.PictureTrackInfo.AbsolutePath, 10000, Validate.DefaultMessage, false);
			
			if (result == true)
			{
				Report.Success("Successfully dropped track # " + TrackNum);
			}
			else
			{
				Report.Screenshot();
				Report.Debug("Track # " + TrackNum + " failed to drop within 15 seconds, proceeding to next track creation.");
			}			
		}		

		//************************************************************************************//
		//************************Resets Paths Created at Run-Time****************************//
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

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}
