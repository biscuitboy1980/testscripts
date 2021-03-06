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

namespace TacViewLib.LinkSpecific.Weapons.Association
{
	/// <summary>
	/// The CreateTrack recording.
	/// </summary>	

	public partial class Create2ndTrack
	{		
		public static int TCount;	
		public static int ASnum;
		
		//************************************************************************************//
		//**********************************Gets Track Number*********************************//
		//************************************************************************************//		
	
		public void GetTrackNum()			
		{			
		    TCount++;
		    Accessible pic1 = @"/form[@title~'^TacViewC2\ \ \ \(map:\ .*']/element/container/picture[@accessiblevalue='Track']" + "[" + TCount + "]";
   			Accessible accElement = new Accessible(pic1);  
   			string track2 = accElement.Name;
   			Report.Info("Track Number = " + track2);
   			Association.AssociateTracks.track2 = track2;
   			Association.ValidateAssociation.track2 = track2;
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
		//******************************Selects Random Track Type*****************************//
		//************************************************************************************//		
		
        public void TrackType()
        {			
			switch (ASnum)
			{					
				case 0:
				repo.FormTOAD.MenuItemAir.Click();
				break;
								
				case 1:
				repo.FormTOAD.MenuItemSurface.Click();
				break;			
			}
			
			Report.Info("Mouse Left Click item " + ASnum + " at Center.");
            			
        }			
		
		//************************************************************************************//
		//***************************Enters Random Identity value*****************************//
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
		   			Report.Info("Identity Entered = " + IDValue);
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
			   		}
				}	
			}
		}
		
		//************************************************************************************//
		//****************************Enters Random Platform value****************************//
		//************************************************************************************//
		
		public void Platval()
		{
			int x = 0;
			
			while (x < 2)
			{
				try
				{
					repo.FormMainCreate.ListItemPlatform.Click("CenterLeft");
				    Keyboard.Press(Keys.Tab);
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
		            AScount = AScount - 1;
					int ASnum = ASvalue.Next(1, AScount++);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemPlatform);  
		   			string PlatValue = accElement.Value;
		   			Report.Info("Platform Value Entered = " + PlatValue);
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
			   		}
				}					
			}
		}		

		//************************************************************************************//
		//****************************Enters Random Activity value****************************//
		//************************************************************************************//
		
		public void Actval()
		{
			int x = 0;
			
			while (x < 2)
			{
				try
				{
					repo.FormMainCreate.ListItemActivity.Click("CenterLeft");
				    Keyboard.Press(Keys.Tab);
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
		            AScount = AScount - 1;
					int ASnum = ASvalue.Next(1, AScount++);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemActivity);  
		   			string ActValue = accElement.Value;
		   			Report.Info("Activity Value Entered = " + ActValue);
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
			   			//ValidateTrack.SurfaceValidateTrackRegression.Act_OOR = true;
			   		}
				}					
			}
		}		

		//************************************************************************************//
		//***********************Enters Random Specific Type value****************************//
		//************************************************************************************//
		
		public void Stypeval()
		{
			int x = 0;
			
			while (x < 2)
			{
				try
				{
					repo.FormMainCreate.ListItemSpecific_Type.Click("CenterLeft");
				    Keyboard.Press(Keys.Tab);
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
		            AScount = AScount - 1;
					int ASnum = ASvalue.Next(1, AScount++);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemSpecific_Type);  
		   			string StypeValue = accElement.Value;
		   			Report.Info("Specific Type Value Entered = " + StypeValue);
		   			x=2;
				}
				catch (ArgumentOutOfRangeException e)
				{								   			
			   		x++;
			   		if (x == 1)
			   		{
			   			Report.Debug("List Count Out of Range for Specific Type, Re-Executing Function");
			   			Report.Debug(e.ToString());	
			   		}
			   		else if (x == 2)
			   		{
			   			Report.Debug("List Count Out of Range for Specific Type, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   		}
				}				
			}
		}		

		//************************************************************************************//
		//**********************************Gets Track Count**********************************//
		//************************************************************************************//
		
		public void GetTrackCount()
		{			
			Ranorex.Container cont1 = repo.FormTacViewC2.ContainerRvView;
			IList<Picture> list1 = cont1.Find<Picture>(@"/form[@title~'^TacViewC2\ \ \ \(map:\ .*']/element/container/picture[@accessiblevalue='Track']");
			TCount = list1.Count;		    
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