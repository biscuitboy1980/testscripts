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
	/// The CreateAirTrack recording.
	/// </summary>
	public partial class CreateAirTrack
	{		
		public int TCount;
		
		static CreateAirTrack()
		{
			//Your recording specific initialization code goes here.
		}

		public void RandomTrack()
		{
			Report.Info("Calling RandomCoord Function from CommonUtilLib");
			CommonUtilLib.Util.RandCoord();
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
		   			ValidateAirTrack.ID = IDValue;
		   			Report.Info("Identity Entered = " + IDValue);
		   			ValidateAirTrack.ID_OOR = false;
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
			   			ValidateAirTrack.ID_OOR = true;
			   		}
				}			
			}
		}
		
		//************************************************************************************//
		//********************Enters Random Platform value************************************//
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
		   			ValidateAirTrack.Plat = PlatValue;
		   			Report.Info("Platform Value Entered = " + PlatValue);
		   			ValidateAirTrack.Plat_OOR = false;
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
			   			ValidateAirTrack.Plat_OOR = true;
			   		}
				}					
			}
		}		

		//************************************************************************************//
		//**********************Enters Random Activity value**********************************//
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
		   			ValidateAirTrack.Act = ActValue;
		   			Report.Info("Activity Value Entered = " + ActValue);
		   			ValidateAirTrack.Act_OOR = false;
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
			   			ValidateAirTrack.Act_OOR = true;
			   		}
				}			
			}
		}		

		//************************************************************************************//
		//********************Enters Random Specific Type value*******************************//
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
	   				ValidateAirTrack.Stype = StypeValue;
	   				Report.Info("Specific Type Value Entered = " + StypeValue);
	   				ValidateAirTrack.Stype_OOR = false;
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
			   			ValidateAirTrack.Stype_OOR = true;
			   		}
				}						
			}
		}		
		
		//************************************************************************************//
		//********************Enters Random Altitude value************************************//
		//************************************************************************************//
		
		public void Altitudeval()
		{
			repo.FormMainCreate.ListItemAltitude.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = CommonUtilLib.Util.Random(1, 204750);
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormMainCreate.ListItemAltitude);  
   			string AltValue = b;
   			ValidateAirTrack.Alt = AltValue;
   			Report.Info("Altitude Entered = " + AltValue);
		}		
		
		//************************************************************************************//
		//********************Enters Random Velocity value************************************//
		//************************************************************************************//
		
		public void Velocityval()
		{
			repo.FormMainCreate.ListItemSpeed.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = CommonUtilLib.Util.Random(1, 4650);
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormMainCreate.ListItemSpeed);  
   			string VelocityValue = b;
   			ValidateAirTrack.Vel = VelocityValue;
   			Report.Info("Velocity Entered = " + VelocityValue);
		}		
		
		//************************************************************************************//
		//***************************Enters Random Course value*******************************//
		//************************************************************************************//
		
		public void Courseval()
		{
			repo.FormMainCreate.ListItemTrue_Course.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);			
			string b = CommonUtilLib.Util.Random(0, 360);
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormMainCreate.ListItemTrue_Course);  
			double CourseValue = Convert.ToDouble(b);
   			ValidateAirTrack.Crs = CourseValue;
   			Report.Info("Course Entered = " + Convert.ToString(CourseValue));
   			Keyboard.Press(Keys.Tab);
		}		
		
		//************************************************************************************//
		//**************************Enters Specific Mode 2 Value******************************//
		//************************************************************************************//
		
		public void Mode2val()
		{
			repo.FormMainCreate.ListItemMode_2_Code.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);			
			Keyboard.Press("7450");
   			ValidateAirTrack.M2 = "7450";
   			Report.Info("Mode 2 Entered = 7450");
		}	
		
		//************************************************************************************//
		//**************************Enters Specific Mode 3 Value******************************//
		//************************************************************************************//
		
		public void Mode3val()
		{
			repo.FormMainCreate.ListItemMode_3_Code.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);			
			Keyboard.Press("7451");
   			ValidateAirTrack.M3 = "7451";
   			Report.Info("Mode 3 Entered = 7451");
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
   			ValidateAirTrack.TrackNum = track1;		
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}
