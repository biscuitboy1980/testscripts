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

namespace TacViewLib.LinkSpecific.Surveillance.Land.CreateTrack
{
	/// <summary>
	/// The CreateTrack recording.
	/// </summary>
	

	public partial class CreateLandTrackSimple
	{		
		
		public static bool IndFlag;
		public static int TCount;
		
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
			SharedFunctions.RandCoord();
		}	
		
		//************************************************************************************//
		//************************Enters Random Point/Track Indicator*************************//
		//************************************************************************************//
		
		public void IndVal()
		{
			int x = 0;
			
			while (x < 2)
			{
				try
				{
				repo.FormMain__Land_Point_Track_TN.ListItemPoint_Track_Ind.Click("CenterLeft");
			    Keyboard.Press(Keys.Tab);
			    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
				Ranorex.List list2 = "//list[@processname='RealView']";
	            int AScount = list2.Items.Count;
	            Random ASvalue = new Random();
				int ASnum = ASvalue.Next(0, AScount++);
	       		repo.ListRealView.Self.Items[ASnum].Select();
	       		repo.ListRealView.Self.Items[ASnum].Click("center");
				Accessible accElement = new Accessible(repo.FormMain__Land_Point_Track_TN.ListItemPoint_Track_Ind);  
	   			string IndValue = accElement.Value;
	   			ValidateTrack.ValidateLandTrackSimple.Ind = IndValue;
	   			Report.Info("Point/Track Indicator Entered = " + IndValue);
	   			ValidateTrack.ValidateLandTrackSimple.Ind_OOR = false;
	   			IndFlag=false;
	   			x=2;
				if (ASnum==1)
		   		{
		   			ValidateTrack.ValidateLandTrackSimple.IndFlag=true;
		   			IndFlag=true;
		   		}
				else
				{
					ValidateTrack.ValidateLandTrackSimple.IndFlag=false;
		   			IndFlag=false;
				}					
				}
				catch (ArgumentOutOfRangeException e)
				{								   			
			   		x++;
			   		if (x == 1)
			   		{
			   			Report.Debug("List Count Out of Range for Point/Track Indicator, Re-Executing Function");
			   			Report.Debug(e.ToString());	
			   		}
			   		else if (x == 2)
			   		{
			   			Report.Debug("List Count Out of Range for Point/Track Indicator, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.ValidateLandTrackSimple.Ind_OOR = true;
			   		}
				}				
			}
		}
		
		//************************************************************************************//
		//*******************************Enters Random Identity*******************************//
		//************************************************************************************//
		
		public void IdVal()
		{
			int x = 0;
			
			while (x < 2)
			{
				try
				{
					repo.FormMain__Land_Point_Track_TN.ListItemIdentity.Click("CenterLeft");
				    Keyboard.Press(Keys.Tab);
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
					int ASnum = ASvalue.Next(0, AScount++);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click("center");
					Accessible accElement = new Accessible(repo.FormMain__Land_Point_Track_TN.ListItemIdentity);  
		   			string IDValue = accElement.Value;
		   			ValidateTrack.ValidateLandTrackSimple.ID = IDValue;
		   			Report.Info("Identity Entered = " + IDValue);
		   			ValidateTrack.ValidateLandTrackSimple.ID_OOR = false;
		   			x=2;
				}
				catch (ArgumentOutOfRangeException e)
				{								   			
			   		x++;
			   		if (x == 1)
			   		{
			   			Report.Debug("List Count Out of Range for Identity, Re-Executing Function");
			   			Report.Debug(e.ToString());	
			   		}
			   		else if (x == 2)
			   		{
			   			Report.Debug("List Count Out of Range for Identity, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.ValidateLandTrackSimple.ID_OOR = true;
			   		}
				}						
			}
		}		

		//************************************************************************************//
		//*********************************Gets Track Number**********************************//
		//************************************************************************************//
		
		public void GetTrackNum()			
		{			
			try
			{
			    TCount++;
			    Accessible pic1 = @"/form[@title~'^TacViewC2\ \ \ \(map:\ .*']/element/container/picture[@accessiblevalue='Track']" + "[" + TCount + "]";
	   			Accessible accElement = new Accessible(pic1);  
	   			string track1 = accElement.Name;
	   			Report.Info("Track Number = " + track1);
	   			ValidateTrack.ValidateLandTrackSimple.TrackNum = track1;
	   			Drop_Track.DropTrack.TrackNum = track1;   	
			}
			catch (Exception)
            {
				ValidateTrack.ValidateLandTrackSimple.ExitFlag1 = true;
				ValidateTrack.ValidateLandTrackSimple.ExitFlag2 = true;
				Report.Debug("picture[@accessiblevalue='Track']" + "[" + TCount + "] could not be found. Accessible item was not created. All validation for this track will be skipped");
            }			
		}

		static CreateLandTrackSimple()
		{
			//Your recording specific initialization code goes here.
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}
