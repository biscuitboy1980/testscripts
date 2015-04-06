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

namespace TacViewLib.LinkSpecific.Surveillance.Surface.CreateTrack
{
	/// <summary>
	/// The CreateTrack recording.
	/// </summary>

	public partial class CreateSurfaceTrack6016D
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

		//*******************************************************************************************//
		//**********************************Gets Random Identity*************************************//
		//*******************************************************************************************//

		public void IDval()
		{
			repo.FormMain__Surface_TN___CREATE.ListItemIdentity.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			Ranorex.List list2 = "//list[@processname='RealView']";
            int AScount = list2.Items.Count;
            Random ASvalue = new Random();
			int ASnum = ASvalue.Next(0, AScount++);
       		repo.ListRealView.Self.Items[ASnum].Select();
       		repo.ListRealView.Self.Items[ASnum].Click();
			Accessible accElement = new Accessible(repo.FormMain__Surface_TN___CREATE.ListItemIdentity);  
   			string IDValue = accElement.Value;
   			ValidateTrack.ValidateSurfaceTrack6016D.ID = IDValue;
		}
		
		//*******************************************************************************************//
		//***************************Gets Platform from csv file*************************************//
		//*******************************************************************************************//
		
		public void Platval()
		{
			repo.FormMain__Surface_TN___CREATE.ListItemPlatform.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);			
			Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			bool found = false;
			ValidateTrack.ValidateSurfaceTrack6016D.PlatFlag=false;
        	foreach( ListItem item in repo.ListRealView.Self.Items )
        	{
           		if ( item.Text == Plat )
           		{
	            	item.Select();
	            	item.Click();
	            	found=true;
	            	break;        
           		}           		
        	}
        	if (!found)
        	{
	        	 ValidateTrack.ValidateSurfaceTrack6016D.PlatFlag=true;
	           	 repo.ListRealView.Self.Items[1].Select();
	       		 repo.ListRealView.Self.Items[1].Click();
        	}   
		}

		//*******************************************************************************************//
		//****************************Gets Activity from csv file************************************//
		//*******************************************************************************************//
		
		public void Actval()
		{
			repo.FormMain__Surface_TN___CREATE.ListItemActivity.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);			
			Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			bool found = false;
			ValidateTrack.ValidateSurfaceTrack6016D.ActFlag=false;
        	foreach( ListItem item in repo.ListRealView.Self.Items )
        	{
           		if ( item.Text == Act )
           		{
	            	item.Select();
	            	item.Click();
	            	found=true;
	            	break;        
           		}           		
        	}
        	if (!found)
        	{
	        	 ValidateTrack.ValidateSurfaceTrack6016D.ActFlag=true;
	           	 repo.ListRealView.Self.Items[1].Select();
	       		 repo.ListRealView.Self.Items[1].Click();
        	}   
		}

		//*******************************************************************************************//
		//***************************Gets Specific type from csv file********************************//
		//*******************************************************************************************//
		
		public void Stypeval()
		{
			repo.FormMain__Surface_TN___CREATE.ListItemSpecific_Type.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);			
			Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			bool found = false;
			ValidateTrack.ValidateSurfaceTrack6016D.StypeFlag=false;
        	foreach( ListItem item in repo.ListRealView.Self.Items )
        	{
           		if ( item.Text == Stype )
           		{
	            	item.Select();
	            	item.Click();
	            	found=true;
	            	break;        
           		}           		
        	}
        	if (!found)
        	{
	        	 ValidateTrack.ValidateSurfaceTrack6016D.StypeFlag=true;
	           	 repo.ListRealView.Self.Items[1].Select();
	       		 repo.ListRealView.Self.Items[1].Click();
        	}   
		}

		//*************************************************************************************//
		//****************************Ranorex Generated Default Method*************************//
		//*************************************************************************************//
		
		static CreateSurfaceTrack6016D()
		{
			//Your recording specific initialization code goes here.
		}

		//*************************************************************************************//
		//*****************************Ranorex Generated Init Method***************************//
		//*************************************************************************************//
		
		private void Init()
		{
			// Your recording specific initialization code goes here.
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
	 		ValidateTrack.ValidateSurfaceTrack6016D.TrackNum = track1;
	  		Drop_Track.DropTrack.TrackNum = track1;   	 
		}
	}
}
