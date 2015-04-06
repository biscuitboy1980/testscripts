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

namespace TacViewLib.LinkSpecific.Surveillance.Reference.CreateTrack
{
	/// <summary>
	/// The CreateSpaceTrackTOAD1 recording.
	/// </summary>
	public partial class CreateSpaceTrack6016D
	{
		public static string track1;
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
		//*******************************Enters Random Platform*******************************//
		//************************************************************************************//
		
		public void IdVal()
		{
			int x = 0;
			while (x < 2)
			{
				repo.FormMain__Space_TN.ListItemIdentity.Click("CenterLeft");
			    Keyboard.Press(Keys.Tab);
			    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
				Ranorex.List list2 = "//list[@processname='RealView']";
	            int AScount = list2.Items.Count;
	            Random ASvalue = new Random();
				int ASnum = ASvalue.Next(0, AScount);
				if (ASnum < 0 || ASnum > AScount)
				{
					x++;
					if (x==1)
					{
						Keyboard.Press(Keys.Escape);
						Report.Debug("List Count Out of Range for Identity, Re-Executing Function");
					}
					else if (x==2)
					{
						Keyboard.Press(Keys.Escape);
						Report.Debug("List Count Out of Range for Identity, List Item Will Not be Validated");
					}
				}
				else
				{
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click("center");
					Accessible accElement = new Accessible(repo.FormMain__Space_TN.ListItemIdentity);  
		   			string IDValue = accElement.Value;
		   			Report.Info("Identity Entered = " + IDValue);
		   			x=2;
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
				repo.FormMain__Space_TN.ListItemPlatform.Click("CenterLeft");
			    Keyboard.Press(Keys.Tab);
			    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
				Ranorex.List list2 = "//list[@processname='RealView']";
	            int AScount = list2.Items.Count;
	            Random ASvalue = new Random();
	            AScount--;
				int ASnum = ASvalue.Next(1, AScount);
				if (ASnum < 1 || ASnum > AScount)
				{
					x++;
					if (x==1)
					{
						Keyboard.Press(Keys.Escape);
						Report.Debug("List Count Out of Range for Platform, Re-Executing Function");
					}
					else if (x==2)
					{
						Keyboard.Press(Keys.Escape);
						Report.Debug("List Count Out of Range for Platform, List Item Will Not be Validated");
					}
				}
				else
				{
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click("center");
					Accessible accElement = new Accessible(repo.FormMain__Space_TN.ListItemPlatform);  
		   			string PlatValue = accElement.Value;
		   			Report.Info("Platform Entered = " + PlatValue);
		   			x=2;
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
				repo.FormMain__Space_TN.ListItemActivity.Click("CenterLeft");
			    Keyboard.Press(Keys.Tab);
			    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
				Ranorex.List list2 = "//list[@processname='RealView']";
	            int AScount = list2.Items.Count;
	            Random ASvalue = new Random();
	            AScount--;
				int ASnum = ASvalue.Next(1, AScount);
				if (ASnum < 1 || ASnum > AScount)
				{
					x++;
					if (x==1)
					{
						Keyboard.Press(Keys.Escape);
						Report.Debug("List Count Out of Range for Activity, Re-Executing Function");
					}
					else if (x==2)
					{
						Keyboard.Press(Keys.Escape);
						Report.Debug("List Count Out of Range for Activity, List Item Will Not be Validated");
					}
				}
				else
				{
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click("center");
					Accessible accElement = new Accessible(repo.FormMain__Space_TN.ListItemActivity);  
		   			string ActValue = accElement.Value;
		   			Report.Info("Activity Entered = " + ActValue);
		   			x=2;
				}
			}
		}	
		
		//************************************************************************************//
		//*****************************Enters Random Specific Type****************************//
		//************************************************************************************//
		
		public void STypeVal()
		{
			int x = 0;
			while (x < 2)
			{
			repo.FormMain__Space_TN.ListItemSpecific_Type.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			Ranorex.List list2 = "//list[@processname='RealView']";
            int AScount = list2.Items.Count;
            Random ASvalue = new Random();
            AScount--;
			int ASnum = ASvalue.Next(1, AScount);
			if (ASnum < 1 || ASnum > AScount)
				{
					x++;
					if (x==1)
					{
						Keyboard.Press(Keys.Escape);
						Report.Debug("List Count Out of Range for Specific Type, Re-Executing Function");
					}
					else if (x==2)
					{
						Keyboard.Press(Keys.Escape);
						Report.Debug("List Count Out of Range for Specific Type, List Item Will Not be Validated");
					}
				}
				else
				{
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click("center");
					Accessible accElement = new Accessible(repo.FormMain__Space_TN.ListItemSpecific_Type);  
		   			string STypeValue = accElement.Value;
		   			Report.Info("Specific Type Entered = " + STypeValue);
		   			x=2;
				}
			}
		}			
		
		//************************************************************************************//
		//****************************Enters Random Altitude Value****************************//
		//************************************************************************************//
		
		public void AltVal()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMain__Space_TN.ListItemAltitude.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 204750);
			Keyboard.Press(b);
   			string AltValue = b;
   			Report.Info("Altitude Value Entered = " + AltValue);
		}				

		//************************************************************************************//
		//*******************************Enters Random Velocity*******************************//
		//************************************************************************************//
		
		public void VelVal()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMain__Space_TN.ListItemSpeedVelocity.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 222); //13107
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormMain__Space_TN.ListItemSpeedVelocity);  
   			string VelValue = b;
   			Report.Info("Velocity Value Entered = " + VelValue);	
		}
		
		//************************************************************************************//
		//******************************Enters Random True Course*****************************//
		//************************************************************************************//
		
		public void CrsVal()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMain__Space_TN.ListItemTrue_Course.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 359);
			Keyboard.Press(b);
			Keyboard.Press(Keys.Tab); 
   			string CrsValue = b;
   			Report.Info("Course Value Entered = " + CrsValue);
		
			Accessible accElement = new Accessible(repo.FormMain__Space_TN.ListItemMagnetic_Course);  
   			string MagValue = accElement.Value;
   			Report.Info("Magnetic Course Value Entered = " + MagValue);
		}
		
		//*************************************************************************************//
		//****************************Ranorex Generated Default Method*************************//
		//*************************************************************************************//		

		static CreateSpaceTrack6016D()
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
   			ValidateTrack.ValidateRefTrack6016D.SpTrk = track1;
   			CreateRefTrack6016D.SpTrk = track1;
   			ValidateTrack.DropSpaceTrack6016D.SpcTrackNum = track1;   	
		}		
	}
}