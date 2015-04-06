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

namespace TacViewLib.LinkSpecific.Surveillance.Space.CreateTrack
{
    public partial class CreateSpaceTrackL16_L11
    {
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
		//********************Enters Random Identity value************************************//
		//************************************************************************************//
		
		public void IDval()
		{
			int x = 0;
			
			while (x < 2)
			{
				try
				{
					repo.FormMainCreate.ListItemIdentity.Click("CenterLeft");
				    Keyboard.Press(Keys.Tab);
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
		            int ASnum = ASvalue.Next(0, AScount++);
					repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemIdentity);  
		   			string IDValue = accElement.Value;
		   			ValidateTrack.ValidateSpaceTrackL16_L11.ID = IDValue;
		   			Report.Info("Identity Entered = " + IDValue);
		   			ValidateTrack.ValidateSpaceTrackL16_L11.ID_OOR = false;
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
			   			ValidateTrack.ValidateSpaceTrackL16_L11.ID_OOR = true;
			   		}
				}			
			}
		}
		
		//************************************************************************************//
		//*******************************Enters Random Platform*******************************//
		//************************************************************************************//
		
		public void PlatVal()
		{
			int x = 0;
			
			while (x < 2)
			{
				try
				{
					repo.FormMain__Space_TN.ListItemPlatform.Click("CenterLeft");
				    Keyboard.Press(Keys.Tab);
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
		            AScount--;
					int ASnum = ASvalue.Next(1, AScount++);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click("center");
					Accessible accElement = new Accessible(repo.FormMain__Space_TN.ListItemPlatform);  
		   			string PlatValue = accElement.Value;
		   			ValidateTrack.ValidateSpaceTrackL16_L11.Plat = PlatValue;
		   			Report.Info("Platform Entered = " + PlatValue);
		   			ValidateTrack.ValidateSpaceTrackL16_L11.Plat_OOR = false;
		   			x=2;
				}
				catch (ArgumentOutOfRangeException e)
				{								   			
			   		x++;
			   		if (x == 1)
			   		{
			   			Report.Debug("List Count Out of Range for Platform, Re-Executing Function");
			   			Report.Debug(e.ToString());	
			   		}
			   		else if (x == 2)
			   		{
			   			Report.Debug("List Count Out of Range for Platform, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.ValidateSpaceTrackL16_L11.Plat_OOR = true;
			   		}
				}					
			}
		}		

		//************************************************************************************//
		//*******************************Enters Random Activity*******************************//
		//************************************************************************************//
		
		public void ActVal()
		{
			int x = 0;
			
			while (x < 2)
			{
				try
				{
					repo.FormMain__Space_TN.ListItemActivity.Click("CenterLeft");
				    Keyboard.Press(Keys.Tab);
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
		            AScount--;
					int ASnum = ASvalue.Next(1, AScount++);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click("center");
					Accessible accElement = new Accessible(repo.FormMain__Space_TN.ListItemActivity);  
		   			string ActValue = accElement.Value;
		   			ValidateTrack.ValidateSpaceTrackL16_L11.Act = ActValue;
		   			Report.Info("Activity Entered = " + ActValue);
		   			ValidateTrack.ValidateSpaceTrackL16_L11.Act_OOR = false;
		   			x=2;
				}
				catch (ArgumentOutOfRangeException e)
				{								   			
			   		x++;
			   		if (x == 1)
			   		{
			   			Report.Debug("List Count Out of Range for Activity, Re-Executing Function");
			   			Report.Debug(e.ToString());	
			   		}
			   		else if (x == 2)
			   		{
			   			Report.Debug("List Count Out of Range for Activity, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.ValidateSpaceTrackL16_L11.Act_OOR = true;
			   		}
				}					
			}
		}	
		
		//************************************************************************************//
		//*****************************Enters Random Specific Type****************************//
		//************************************************************************************//
		
		public void STypeVal()
		{
//			int x = 0;
//			
//			while (x < 2)
//			{
//				try
//				{
//					repo.FormMain__Space_TN.ListItemSpecific_Type.Click("CenterLeft");
//				    Keyboard.Press(Keys.Tab);
//				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
//					Ranorex.List list2 = "//list[@processname='RealView']";
//		            int AScount = list2.Items.Count;
//		            Random ASvalue = new Random();
//		            AScount--;
//					int ASnum = ASvalue.Next(1, AScount++);
//		       		repo.ListRealView.Self.Items[ASnum].Select();
//		       		repo.ListRealView.Self.Items[ASnum].Click("center");
//					Accessible accElement = new Accessible(repo.FormMain__Space_TN.ListItemSpecific_Type);  
//		   			string STypeValue = accElement.Value;
//		   			ValidateTrack.SpaceValidateTrackRegression.SType = STypeValue;
//		   			Report.Info("Specific Type Entered = " + STypeValue);
//		   			ValidateTrack.SpaceValidateTrackRegression.Stype_OOR = false;
//		   			x=2;
//				}
//				catch (ArgumentOutOfRangeException e)
//				{								   			
//			   		x++;
//			   		if (x == 1)
//			   		{
//			   			Report.Debug("List Count Out of Range for Specific Type, Re-Executing Function");
//			   			Report.Debug(e.ToString());	
//			   		}
//			   		else if (x == 2)
//			   		{
//			   			Report.Debug("List Count Out of Range for Specific Type, List Item Will Not be Validated");
//			   			Report.Debug(e.ToString());	
//			   			ValidateTrack.SpaceValidateTrackRegression.Stype_OOR = true;
//			   		}
//				}					
//			}
		}					
		
		//************************************************************************************//
		//*********************************Gets Track Number**********************************//
		//************************************************************************************//
		
		public void GetTrackNum()			
		{			
		    TCount++;
		    Accessible pic1 = @"/form[@title~'^TacViewC2\ \ \ \(map:\ .*']/element/container/picture[@accessiblevalue='Track']" + "[" + TCount + "]";
		    Accessible accElement = new Accessible(pic1);
			string track1 = accElement.Name;
	  		Report.Info("Track Number = " + track1);
	 		ValidateTrack.ValidateSpaceTrackL16_L11.TrackNum = track1;
	  		Drop_Track.DropTrack.TrackNum = track1;   	 
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