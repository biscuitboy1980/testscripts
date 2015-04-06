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

namespace TacViewLib.LinkSpecific.TrackManagement.WeatherOverTarget
{
	/// <summary>
	/// The CreateTrack recording.
	/// </summary>	

	public partial class CreateTargetTrack
	{		
		public static bool IndFlag;
		public static int TCount;
		
		//************************************************************************************//
		//**********************************Gets Track Number*********************************//
		//************************************************************************************//
		
		public void GetTrackCount()
		{
			Ranorex.Container cont1 = repo.FormTacViewC2.ContainerRvView;
			//IList<Picture> list1 = cont1.FindDescendants<Picture>();// OLD CODE
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
		//************************Enters Random Point/Track Indicator*************************//
		//************************************************************************************//
		
		public void IndVal()
		{

				repo.FormMain__Land_Point_Track_TN.ListItemPoint_Track_Ind.Click("CenterLeft");
			    Keyboard.Press(Keys.Tab);
			    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
				Ranorex.List list2 = "//list[@processname='RealView']";
	            int AScount = list2.Items.Count;
	            Random ASvalue = new Random();
				int ASnum = ASvalue.Next(0, AScount);
				if (ASnum < 0 || ASnum > AScount)
				{
						Keyboard.Press(Keys.Escape);
						Report.Debug("List Count Out of Range for Point/Track Indicator");
				}
				else
				{
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click("center");
					Accessible accElement = new Accessible(repo.FormMain__Land_Point_Track_TN.ListItemPoint_Track_Ind);  
		   			string IndValue = accElement.Value;
		   			Report.Info("Point/Track Indicator Entered = " + IndValue);
		   			IndFlag=false;

				}

		}
		
		//************************************************************************************//
		//*******************************Enters Random Identity*******************************//
		//************************************************************************************//
		
		public void IdVal()
		{

				repo.FormMain__Land_Point_Track_TN.ListItemIdentity.Click("CenterLeft");
			    Keyboard.Press(Keys.Tab);
			    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
				Ranorex.List list2 = "//list[@processname='RealView']";
	            int AScount = list2.Items.Count;
	            Random ASvalue = new Random();
				int ASnum = ASvalue.Next(0, AScount);
				if (ASnum < 0 || ASnum > AScount)
				
				{
					Keyboard.Press(Keys.Escape);
					Report.Debug("List Count Out of Range for Identity, List Item Will Not be Validated");
				}
		
				else
				{
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click("center");
					Accessible accElement = new Accessible(repo.FormMain__Land_Point_Track_TN.ListItemIdentity);  
		   			string IDValue = accElement.Value;
		   			Report.Info("Identity Entered = " + IDValue);

				}
			
		}		
		
		//************************************************************************************//
		//*******************************Enters Random Platform*******************************//
		//************************************************************************************//
		
		public void PlatVal()
		{

				repo.FormMain__Land_Point_Track_TN.ListItemPlatform.Click("CenterLeft");
			    Keyboard.Press(Keys.Tab);
			    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
				Ranorex.List list2 = "//list[@processname='RealView']";
	            int AScount = list2.Items.Count;
	            Random ASvalue = new Random();
				int ASnum = ASvalue.Next(1, AScount-1);
				if (ASnum < 1 || ASnum > AScount)
				{

						Keyboard.Press(Keys.Escape);
						Report.Debug("List Count Out of Range for Platform");
					
				}
				else
				{
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click("center");
					Accessible accElement = new Accessible(repo.FormMain__Land_Point_Track_TN.ListItemPlatform);  
		   			string PlatValue = accElement.Value;
		   			Report.Info("Platform Entered = " + PlatValue);

				}
			
		}		

		//************************************************************************************//
		//*******************************Enters Random Activity*******************************//
		//************************************************************************************//
		
		public void ActVal()
		{

				repo.FormMain__Land_Point_Track_TN.ListItemActivity.Click("CenterLeft");
			    Keyboard.Press(Keys.Tab);
			    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
				Ranorex.List list2 = "//list[@processname='RealView']";
	            int AScount = list2.Items.Count;
	            Random ASvalue = new Random();
				int ASnum = ASvalue.Next(1, AScount-1);
				if (ASnum < 1 || ASnum > AScount)
				{

						Keyboard.Press(Keys.Escape);
						Report.Debug("List Count Out of Range for Activity");
				}


				else
				{
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click("center");
					Accessible accElement = new Accessible(repo.FormMain__Land_Point_Track_TN.ListItemActivity);  
		   			string ActValue = accElement.Value;
		   			Report.Info("Activity Entered = " + ActValue);

				}
			
		}	
		
		//************************************************************************************//
		//*****************************Enters Random Specific Type****************************//
		//************************************************************************************//
		
		public void STypeVal()
		{

				repo.FormMain__Land_Point_Track_TN.ListItemSpecific_Type.Click("CenterLeft");
			    Keyboard.Press(Keys.Tab);
			    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
				Ranorex.List list2 = "//list[@processname='RealView']";
	            int AScount = list2.Items.Count;
	            Random ASvalue = new Random();
				int ASnum = ASvalue.Next(1, AScount-1);
				if (ASnum < 1 || ASnum > AScount)
				{

						Keyboard.Press(Keys.Escape);
						Report.Debug("List Count Out of Range for Specific Type");
					
				}
				else
				{
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click("center");
					Accessible accElement = new Accessible(repo.FormMain__Land_Point_Track_TN.ListItemSpecific_Type);  
		   			string STypeValue = accElement.Value;
		   			Report.Info("Specific Type Entered = " + STypeValue);

				}
			
		}		
		
		//************************************************************************************//
		//**********************************Gets Track Number*********************************//
		//************************************************************************************//		
		
		public void GetTrackNum()			
		{			
		    TCount++;
		    Accessible pic1 = @"/form[@title~'^TacViewC2\ \ \ \(map:\ .*']/element/container/picture[@accessiblevalue='Track']" + "[" + TCount + "]";
		    Accessible accElement = new Accessible(pic1);
   			string track1 = accElement.Name;
   			Report.Info("Track Number = " + track1);
   			CreateWOT.TrackNum = track1;
			ValidateWOT.TrackNum = track1;
			DropTrack.DropTrack.TrackNum = track1;
		}

		//**************************************************************************************//
		//**************************Ranorex Generated Default Method****************************//
		//**************************************************************************************//
		
		static CreateTargetTrack()
		{
			//Your recording specific initialization code goes here.
		}

		//**************************************************************************************//
		//****************************Ranorex Generated Init Method*****************************//
		//**************************************************************************************//	
		
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}		
	}
}