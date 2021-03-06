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

namespace TacViewLib.LinkSpecific.Surveillance.Land.CreateTrack
{
	/// <summary>
	/// The CreateTrack recording.
	/// </summary>
	
	public partial class CreateLandTrack6016D
	{
		public static string AOPcs;	
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
		//****************Enters Random Point/Track Indicator Indicator value*****************//
		//************************************************************************************//

		public void Indval()
		{
			repo.FormMain__Land_Point_Track_TN.ListItemPoint_Track_Ind.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			Ranorex.List list2 = "//list[@processname='RealView']";
            int AScount = list2.Items.Count;
            Random ASvalue = new Random();
			int ASnum = ASvalue.Next(0, AScount++);
       		repo.ListRealView.Self.Items[ASnum].Select();
       		repo.ListRealView.Self.Items[ASnum].Click();
			Accessible accElement = new Accessible(repo.FormMain__Land_Point_Track_TN.ListItemPoint_Track_Ind);  
   			string IndValue = accElement.Value;
   			ValidateTrack.ValidateLandTrack6016D.Ind = IndValue;
		}		
		
		//************************************************************************************//
		//**************************Enters Random Identity value******************************//
		//************************************************************************************//
		
		public void IDval()
		{
			repo.FormMain__Land_Point_Track_TN.ListItemIdentity.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			Ranorex.List list2 = "//list[@processname='RealView']";
            int AScount = list2.Items.Count;
            Random ASvalue = new Random();
			int ASnum = ASvalue.Next(0, AScount++);
       		repo.ListRealView.Self.Items[ASnum].Select();
       		repo.ListRealView.Self.Items[ASnum].Click();
			Accessible accElement = new Accessible(repo.FormMain__Land_Point_Track_TN.ListItemIdentity);  
   			string IDValue = accElement.Value;
   			ValidateTrack.ValidateLandTrack6016D.ID = IDValue;
		}		
		
		//************************************************************************************//
		//**********************Enters Platform value from csv file***************************//
		//************************************************************************************//
		
		public void Platval()
		{
			repo.FormMain__Land_Point_Track_TN.ListItemPlatform.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			bool found = false;
			ValidateTrack.ValidateLandTrack6016D.PlatFlag=false;
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
	        	ValidateTrack.ValidateLandTrack6016D.PlatFlag=true;
	           	repo.ListRealView.Self.Items[1].Select();
	       		repo.ListRealView.Self.Items[1].Click();;
        	}   
		}

		//************************************************************************************//
		//********************Enters Activity value from csv file*****************************//
		//************************************************************************************//
		
		public void Actval()
		{
			repo.FormMain__Land_Point_Track_TN.ListItemActivity.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			bool found = false;
			ValidateTrack.ValidateLandTrack6016D.ActFlag=false;
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
	        	ValidateTrack.ValidateLandTrack6016D.ActFlag=true;
		      	repo.ListRealView.Self.Items[1].Select();
	       		repo.ListRealView.Self.Items[1].Click();
        	}   
		}

		//************************************************************************************//
		//********************Enters Specific Type value from csv file************************//
		//************************************************************************************//
		
		public void Stypeval()
		{
			repo.FormMain__Land_Point_Track_TN.ListItemSpecific_Type.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);			
			Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			bool found = false;
			ValidateTrack.ValidateLandTrack6016D.StypeFlag=false;
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
	        	ValidateTrack.ValidateLandTrack6016D.StypeFlag=true;
	          	repo.ListRealView.Self.Items[1].Select();
	       		repo.ListRealView.Self.Items[1].Click();
        	}   
		}
		
		//************************************************************************************//
		//************************Enters Random Circle/Square value***************************//
		//************************************************************************************//
		
		public void CirSquareval()
		{
			repo.FormMain__Land_Point_Track_TN.ListItemAOP_Circle_Square_Switch.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			Ranorex.List list2 = "//list[@processname='RealView']";
            int AScount = list2.Items.Count;
            Random ASvalue = new Random();
			int ASnum = ASvalue.Next(1, AScount++);
       		repo.ListRealView.Self.Items[ASnum].Select();
       		repo.ListRealView.Self.Items[ASnum].Click();
			Accessible accElement = new Accessible(repo.FormMain__Land_Point_Track_TN.ListItemAOP_Circle_Square_Switch);  
   			string AOPcsVal = accElement.Value;
   			ValidateTrack.ValidateLandTrack6016D.AOPcs = AOPcsVal;
		}	
		
		//************************************************************************************//
		//*******************************Enters Random HAE value******************************//
		//************************************************************************************//

		public void HAEft_Random()
		{
			repo.FormMain__Land_Point_Track_TN.ListItemHAE__ft_.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			Report.Info("HAE Random Value.");			
			Random random = new Random();
			double a = random.Next(-159688, 159688);
			a = a*.01;
			Math.Round(a, 2);
			string b = a.ToString();
			ValidateTrack.ValidateLandTrack6016D.hae = b;
			Keyboard.Press(b);
		}		
		
		//************************************************************************************//
		//***************************Enters Random AOP Major value****************************//
		//************************************************************************************//		
		
		public void AOPMajor()
		{
			repo.FormMain__Land_Point_Track_TN.ListItemAOP_Major_Axis.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);			
			Report.Info("AOP Axis Major Random Value.");			
			Random random = new Random();
			double c = random.Next(0, 8257);
			c = c*.01;
			c=Math.Round(c, 2);
			string d = c.ToString();
			ValidateTrack.ValidateLandTrack6016D.axismaj3 = d;
			Keyboard.Press(d);
		}

		//************************************************************************************//
		//***************************Enters Random AOP Minor value****************************//
		//************************************************************************************//	
		
		public void AOPMinor()
		{
			repo.FormMain__Land_Point_Track_TN.ListItemAOP_Minor_Axis.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);			
			Report.Info("AOP Axis Minor Random Value.");
			Random random = new Random();
			double e = random.Next(0, 8257);
			e = e*.01;
			e=Math.Round(e, 2);
			string f = e.ToString();
			ValidateTrack.ValidateLandTrack6016D.axismin3 = f;
			Keyboard.Press(f);		
		}
		
 		//*************************************************************************************//
		//***************************Ranorex Generated Default Method**************************//
		//*************************************************************************************//		

		static CreateLandTrack6016D()
		{
			//Your recording specific initialization code goes here.
		}

		//*************************************************************************************//
		//****************************Ranorex Generated Init Method****************************//
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
	 		ValidateTrack.ValidateLandTrack6016D.TrackNum = track1;
	  		Drop_Track.DropTrack.TrackNum = track1;   	 
		}		
	}
}
