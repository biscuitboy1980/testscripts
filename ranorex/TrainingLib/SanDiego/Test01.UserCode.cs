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

using CommonUtilLib;

namespace TrainingLib.SanDiego
{
	/// <summary>
	/// The Test01 recording.
	/// </summary>
	public partial class Test01
	{
		public int TCount;
		public string track1;
		
		static Test01()
		{
			//Your recording specific initialization code goes here.
		}
		
		//************************************************************************************//
		//*********************************Gets Track Count***********************************//
		//************************************************************************************//
		
		public void GetTrackCount()
		{			
			Ranorex.Container cont1 = repo.FormTacViewC2.ContainerRvView;
			IList<Picture> list1 = cont1.Find<Picture>(@"/form[@title~'^TacViewC2\ \ \ \(map:\ .*']/element/container/picture[@accessiblevalue='Track']");
			TCount = list1.Count;		    
		}		
		
		//************************************************************************************//
		//******************************Randomly Plots a Track********************************//
		//************************************************************************************//		
		
		public void RandCoord()
		{	
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			
	       	 Ranorex.Container test = @"/form[@title~'^TacViewC2\ \ \ \(map:\ .*']/element/container[@accessiblename='RvView']";
	       	 var a = test.ScreenRectangle.Width;
	       	 var b = test.ScreenRectangle.Height;
	       	 int c = Convert.ToInt32(a);
	       	 c = c - 100;
	       	 int d = Convert.ToInt32(b);
	       	 d = d - 100;
	       	 string w = SharedFunctions.Random(100, c);
	       	 string h = SharedFunctions.Random(100, d);
	    	 repo.FormTacViewC2.ContainerRvView.Click(MouseButtons.Right, "" + w + ";" + h + ""); 
	    	 
	    	Duration OrigDur = repo.FormRealView.MenuItemCreate_TrackInfo.SearchTimeout;
			repo.FormRealView.MenuItemCreate_TrackInfo.SearchTimeout = 1000;			
			
			if (repo.FormRealView.MenuItemCreate_TrackInfo.Exists())
			{
				return;
			}			
			else
			{
				RandCoord();
			}
			
			repo.FormRealView.MenuItemCreate_TrackInfo.SearchTimeout = OrigDur;
		}
		
		//************************************************************************************//
		//*********************************Gets Track Number**********************************//
		//************************************************************************************//
		
		public void GetTrackNum()			
		{		
			
		    TCount++;
		    Accessible pic1 = @"/form[@title~'^TacViewC2\ \ \ \(map:\ .*']/element/container/picture[@accessiblevalue='Track']" + "[" + TCount + "]";
   			Accessible accElement = new Accessible(pic1);  
   			track1 = accElement.Name;
   			Report.Info("Track Number = " + track1);
   			Drop_Track.DropTrack.TrackNum = track1;

		}
   			
		//************************************************************************************//
		//***************************Creates Run-Time Repo Items******************************//
		//************************************************************************************//		

		public void CreateTrackRepoItems()
		{			
			string currentPath = repo.FormTacViewC2.PictureTrackInfo.Path.ToString();
			repo.FormTacViewC2.PictureTrackInfo.Path = currentPath.Replace("%track%", track1);
			Report.Info("Setting repo item FormTacViewC2.PictureTrack to " + repo.FormTacViewC2.PictureTrackInfo.Path.ToString());
		}
		
		//************************************************************************************//
		//*******************************Right Clicks Track***********************************//
		//************************************************************************************//		
		
		public void RightClickTrack()
		{			
			Duration OrigDur = repo.FormTacViewC2.PictureTrackInfo.SearchTimeout;
			repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = 2000;			

			Report.Info("Mouse Right Click item 'FormTacViewC2.PictureTrack' at Center.");
			repo.FormTacViewC2.PictureTrack.Click(MouseButtons.Right);
			
			repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = OrigDur;  			
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
			Duration OrigDur = repo.FormTacViewC2.PictureTrackInfo.SearchTimeout;
			repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = 3000;

			Report.Info("Validating Track # " + track1 + " was dropped");
	
			bool result = Validate.NotExists(repo.FormTacViewC2.PictureTrackInfo, Validate.DefaultMessage, false);
			
				if (result == true)
				{
					Report.Success("Successfully dropped track # " + track1);
				}
				else
				{
					Report.Warn("Track # " + track1 + " failed to drop within 15 seconds.");
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
			repo.FormTacViewC2.PictureTrackInfo.Path = currentPath.Replace(track1, "%track%");
			Report.Info("Resetting repo item FormTacViewC2.PictureTrack repo item to" + repo.FormTacViewC2.PictureTrackInfo.Path.ToString());
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}		
	}
}
