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

namespace TacViewLib.LinkSpecific.Surveillance.Surface.CreateTrack
{
	/// <summary>
	/// The CreateTrack recording.
	/// </summary>	

	public partial class SurfaceCreateTrackRegression
	{		
		public static int TCount;
		
		//************************************************************************************//
		//***************************Enters Random Identity value*****************************//
		//************************************************************************************//
		
		public void IDval()
		{

				try
				{
					repo.FormMainCreate.ListItemIdentity.Click("CenterLeft");
				    Keyboard.Press(Keys.Tab);
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
					int ASnum = ASvalue.Next(0, AScount);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemIdentity);  
		   			string IDValue = accElement.Value;
		   			ValidateTrack.SurfaceValidateTrackRegression.ID = IDValue;
		   			Report.Info("Identity Entered = " + IDValue);
		   			ValidateTrack.SurfaceValidateTrackRegression.ID_OOR = false;

				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for Identity, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.ID_OOR = true;

				}	
			
		}
		
		//************************************************************************************//
		//****************************Enters Random Platform value****************************//
		//************************************************************************************//
		
		public void Platval()
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
					int ASnum = ASvalue.Next(1, AScount-1);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemPlatform);  
		   			string PlatValue = accElement.Value;
		   			ValidateTrack.SurfaceValidateTrackRegression.Plat = PlatValue;
		   			Report.Info("Platform Value Entered = " + PlatValue);
		   			ValidateTrack.SurfaceValidateTrackRegression.Plat_OOR = false;

				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for Platform, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.Plat_OOR = true;
			   		
				}					
			
		}		

		//************************************************************************************//
		//****************************Enters Random Activity value****************************//
		//************************************************************************************//
		
		public void Actval()
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
					int ASnum = ASvalue.Next(1, AScount-1);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemActivity);  
		   			string ActValue = accElement.Value;
		   			ValidateTrack.SurfaceValidateTrackRegression.Act = ActValue;
		   			Report.Info("Activity Value Entered = " + ActValue);
		   			ValidateTrack.SurfaceValidateTrackRegression.Act_OOR = false;

				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for Activity, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.Act_OOR = true;
			   		
				}					
			
		}		

		//************************************************************************************//
		//***********************Enters Random Specific Type value****************************//
		//************************************************************************************//
		
		public void Stypeval()
		{

				try
				{
					repo.FormMainCreate.ListItemSpecific_Type.Click("CenterLeft");
				    Keyboard.Press(Keys.Tab);
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
				    Delay.Seconds(1);
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
		            AScount = AScount - 1;
					int ASnum = ASvalue.Next(1, AScount-1);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemSpecific_Type);  
		   			string StypeValue = accElement.Value;
		   			ValidateTrack.SurfaceValidateTrackRegression.Stype = StypeValue;
		   			Report.Info("Specific Type Value Entered = " + StypeValue);
		   			ValidateTrack.SurfaceValidateTrackRegression.Stype_OOR = false;

				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for Specific Type, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.Stype_OOR = true;
			   		
				}				
			
		}	
		
		//************************************************************************************//
		//***************************Enters Random Strength value*****************************//
		//************************************************************************************//
		
		public void Strengthval()
		{

				try
				{
					repo.FormMainCreate.ListItemStrength.Click("CenterLeft");
				    Keyboard.Press(Keys.Tab);
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
					int ASnum = ASvalue.Next(1, AScount-1);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemStrength);  
		   			string StrengthValue = accElement.Value;
		   			ValidateTrack.SurfaceValidateTrackRegression.Strength = StrengthValue;
		   			Report.Info("Strength Value Entered = " + StrengthValue);
		   			ValidateTrack.SurfaceValidateTrackRegression.Strength_OOR = false;

				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for Strength, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.Strength_OOR = true;
			   		
				}				
			
		}

		//************************************************************************************//
		//***************************Enters Random Velocity value*****************************//
		//************************************************************************************//
		
		public void Velocityval()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMainCreate.ListItemSpeedVelocity.Click("CenterLeft");
			Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 4650);
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormMainCreate.ListItemSpeedVelocity);  
   			string VelocityValue = b;
   			ValidateTrack.SurfaceValidateTrackRegression.Vel = VelocityValue;
   			Report.Info("Velocity Entered = " + VelocityValue);
		}		
		
		//************************************************************************************//
		//*****************************Enters Random Course value*****************************//
		//************************************************************************************//
		
		public void Courseval()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			
			repo.FormMainCreate.ListItemTrue_Course.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);			
			string b = SharedFunctions.Random(0, 360);			
			int a = Convert.ToInt32(b);
			string c = a.ToString("D3");
			Keyboard.Press(c);
			Accessible accElement = new Accessible(repo.FormMainCreate.ListItemTrue_Course);  
			ValidateTrack.SurfaceValidateTrackRegression.Crs = c;
   			Report.Info("Course Entered = " + b);
   			Keyboard.Press(Keys.Tab);
		}		

		public void GetMagneticCourse()
		{
			Accessible accElement2 = new Accessible(repo.FormMainCreate.ListItemMagnetic_Course);
			string MCrs = accElement2.Value;
			ValidateTrack.SurfaceValidateTrackRegression.MagCrs = MCrs;
			Report.Info("Magnetic Course Entered = " + MCrs);
		}

		//************************************************************************************//
		//**********************Enters Random Track Quality***********************************//
		//************************************************************************************//
		
		public void TrackQualityval()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMainCreate.ListItemLocal_TQ.Click("CenterLeft");
			Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 15);
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormMainCreate.ListItemLocal_TQ);  
   			string TQValue = b;
   			ValidateTrack.SurfaceValidateTrackRegression.TQ = TQValue;
   			Report.Info("Track Quality Entered = " + TQValue);
		}		
		
		//************************************************************************************//
		//**********************Stores Reporting Unit to Variable*****************************//
		//************************************************************************************//
		
		public void ReportingUnitval()
		{
			Accessible accElement3 = new Accessible(repo.FormMainCreate.ListItemReporting_Unit);  
			string ReportingUnit = accElement3.Value;
			TacViewLib.LinkSpecific.Surveillance.Surface.ValidateTrack.SurfaceValidateTrackRegression.RU = ReportingUnit;
		}	
		
		//************************************************************************************//
		//**************************Enters Random Hi Priority value***************************//
		//************************************************************************************//
		
		public void HiPrival()
		{

				try
				{
					repo.FormMainCreate.ListItemHi_Priority.Click("CenterLeft");
				    Keyboard.Press(Keys.Tab);
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
					int ASnum = ASvalue.Next(0, AScount);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemHi_Priority);  
		   			string HiPriValue = accElement.Value;
		   			ValidateTrack.SurfaceValidateTrackRegression.Hi = HiPriValue;
		   			Report.Info("Hi Priority Value Entered = " + HiPriValue);
		   			ValidateTrack.SurfaceValidateTrackRegression.HiPri_OOR = false;

				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for Hi Priority, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.HiPri_OOR = true;
			   		
				}				
		
		}		
		
		//************************************************************************************//
		//*****************************Enters Random Mode 1 Value*****************************//
		//************************************************************************************//
		
		public void Mode1val()
		{

				try
				{
					repo.FormMainCreate.ListItemMode_1_Code.Click("CenterLeft");
				    Keyboard.Press(Keys.Tab);
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
		            AScount = AScount - 1;
					int ASnum = ASvalue.Next(1, AScount-1);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemMode_1_Code);  
		   			string M1Value = accElement.Value;
		   			ValidateTrack.SurfaceValidateTrackRegression.M1 = M1Value;
		   			Report.Info("Mode 1 Value Entered = " + M1Value);
		   			ValidateTrack.SurfaceValidateTrackRegression.Mode1_OOR = false;

				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for Mode 1 List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.Mode1_OOR = true;
			   		
				}				
			
		}

		//************************************************************************************//
		//***************************Enters Random Mode 2 Value*******************************//
		//************************************************************************************//
		
		public void Mode2val()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMainCreate.ListItemMode_2_Code.Click("CenterLeft");
			Keyboard.Press(Keys.Tab);
			string a = SharedFunctions.Random(1, 4095);
			string b = SharedFunctions.DecimalToBase(Convert.ToInt32(a), 8);
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormMainCreate.ListItemMode_2_Code);  
   			string M2Value = b;
   			ValidateTrack.SurfaceValidateTrackRegression.M2 = M2Value;
   			Report.Info("Mode 2 Entered = " + M2Value);
		}		
		
		//************************************************************************************//
		//****************************Enters Random Mode 3 Value******************************//
		//************************************************************************************//
		
		public void Mode3val()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMainCreate.ListItemMode_3_Code.Click("CenterLeft");
			Keyboard.Press(Keys.Tab);
			string a = SharedFunctions.Random(1, 4095);
			string b = SharedFunctions.DecimalToBase(Convert.ToInt32(a), 8);
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormMainCreate.ListItemMode_3_Code);  
   			string M3Value = b;
   			ValidateTrack.SurfaceValidateTrackRegression.M3 = M3Value;
   			Report.Info("Mode 3 Entered = " + M3Value);
		}		

		//************************************************************************************//
		//**************************Enters Random Mode 4 Indicator****************************//
		//************************************************************************************//
		
		public void Mode4val()
		{

				try
				{
				repo.FormMainCreate.ListItemMode_4_Indicator.Click("CenterLeft");
			    Keyboard.Press(Keys.Tab);
			    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
				Ranorex.List list2 = "//list[@processname='RealView']";
	            int AScount = list2.Items.Count;
	            Random ASvalue = new Random();
				int ASnum = ASvalue.Next(0, AScount);
	       		repo.ListRealView.Self.Items[ASnum].Select();
	       		repo.ListRealView.Self.Items[ASnum].Click();
				Accessible accElement = new Accessible(repo.FormMainCreate.ListItemMode_4_Indicator);  
	   			string M4Value = accElement.Value;
	   			ValidateTrack.SurfaceValidateTrackRegression.M4 = M4Value;
	   			Report.Info("Mode 4 Indicator Entered = " + M4Value);
	   			ValidateTrack.SurfaceValidateTrackRegression.Mode4_OOR = false;

				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for Mode 4 List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.Mode4_OOR = true;
			   				
				}
			
		}
		
		//************************************************************************************//
		//***************************Enters Random Mode 5 Indicator***************************//
		//************************************************************************************//
		
		public void Mode5val()
		{

				try
				{
					repo.FormMainCreate.ListItemMode_5_Indicator.Click("CenterLeft");
				    Keyboard.Press(Keys.Tab);
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
					int ASnum = ASvalue.Next(1, AScount-1);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemMode_5_Indicator);  
		   			string M5Value = accElement.Value;
		   			ValidateTrack.SurfaceValidateTrackRegression.M5 = M5Value;
		   			Report.Info("Mode 5 Indicator Entered = " + M5Value);
		   			ValidateTrack.SurfaceValidateTrackRegression.Mode5_OOR = false;

				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for Mode 5 List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.Mode5_OOR = true;
			   					
				}				
			
		}

		//************************************************************************************//
		//*************************Enters Random Mode 5 Nationality***************************//
		//************************************************************************************//
		
		public void Mode5Natval()
		{

				try
				{				
					repo.FormMainCreate.ListItemMode_5_Nationality.Click("CenterLeft");
				    Keyboard.Press(Keys.Tab);
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
					int ASnum = ASvalue.Next(1, AScount-1);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemMode_5_Nationality);  
		   			string M5NatValue = accElement.Value;
		   			ValidateTrack.SurfaceValidateTrackRegression.M5Nat = M5NatValue;
		   			Report.Info("Mode 5 Nationality Entered = " + M5NatValue);
		   			ValidateTrack.SurfaceValidateTrackRegression.Mode5Nat_OOR = false;

				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for Mode 5 Nationality, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.Mode5Nat_OOR = true;
			   				
				}					
			
		}

		//************************************************************************************//
		//***************************Enters Random Mode 5 ID value****************************//
		//************************************************************************************//
		
		public void M5IDval()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMainCreate.ListItemMode_5_Platform_ID.Click("CenterLeft");
			Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 16383);
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormMainCreate.ListItemMode_5_Platform_ID);  
   			string M5IDValue = b;
   			ValidateTrack.SurfaceValidateTrackRegression.M5ID = M5IDValue;
   			Report.Info("Mode 5 ID Entered = " + M5IDValue);
		}	
		
		//************************************************************************************//
		//*****************************Enters Random SPI value********************************//
		//************************************************************************************//
		
		public void SPIval()
		{

				try
				{
					repo.FormMainCreate.ListItemSpecialProcessing.Click("CenterLeft");
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
					int ASnum = ASvalue.Next(0, AScount);
			   		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemSpecialProcessing);  
		   			string SPIValue = accElement.Value;
		   			ValidateTrack.SurfaceValidateTrackRegression.SPI = SPIValue;
		   			Report.Info("SPI Entered = " + SPIValue);
		   			ValidateTrack.SurfaceValidateTrackRegression.SPI_OOR = false;

					if (ASnum==0)
		   			{
		   				ValidateTrack.SurfaceValidateTrackRegression.SPIflag = false;
		   			}
					else
					{
				  		ValidateTrack.SurfaceValidateTrackRegression.SPIflag = true;
					}			   			
				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for SPI, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.SPI_OOR = true;
			   					
				}				
			
		}
		
		//************************************************************************************//
		//*********************Enters Random Passive/Active Indicator*************************//
		//************************************************************************************//
		
		public void PassiveActiveval()
		{

				try
				{
					repo.FormMainCreate.ListItemPassive_Active_Ind.Click("CenterLeft");
				    Keyboard.Press(Keys.Tab);
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
					int ASnum = ASvalue.Next(0, AScount);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemPassive_Active_Ind);  
		   			string PAValue = accElement.Value;
		   			ValidateTrack.SurfaceValidateTrackRegression.PA = PAValue;
		   			Report.Info("Passive/Active Indicator Entered = " + PAValue);
		   			ValidateTrack.SurfaceValidateTrackRegression.PAInd_OOR = false;

				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for Passive/Active Indicator, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.PAInd_OOR = true;
			   				
				}					
			
		}
		
		//************************************************************************************//
		//********************Enters Random Special Interest Indicator************************//
		//************************************************************************************//
		
		public void SpecialIntval()
		{

				try
				{
					ValidateTrack.SurfaceValidateTrackRegression.SpecialIntFlag = false;
					repo.FormMainCreate.ListItemSpecial_Interest.Click("CenterLeft");
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
					int ASnum = ASvalue.Next(0, AScount);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemSpecial_Interest);  
		   			string SIValue = accElement.Value;
		   			ValidateTrack.SurfaceValidateTrackRegression.SpecialInt = SIValue;
		   			Report.Info("Special Interest Indicator = " + SIValue);
		   			ValidateTrack.SurfaceValidateTrackRegression.SpecInt_OOR = false;

		   			if (ASnum == 1)
   					{
   						ValidateTrack.SurfaceValidateTrackRegression.SpecialIntFlag = true;
   					}
		   			else
					{
				  		ValidateTrack.SurfaceValidateTrackRegression.SpecialIntFlag = false;
					}	 
				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for Special Interest Indicator, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.SpecInt_OOR = true;
			   					
				}	
			
		}

		//************************************************************************************//
		//********************************Enters Random Hour**********************************//
		//************************************************************************************//
			
		public void Hourval()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMainCreate.ListItemHour.Click("CenterLeft");
			Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(0, 23);
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormMainCreate.ListItemHour);  
   			string HourValue = b;
   			ValidateTrack.SurfaceValidateTrackRegression.Hour = HourValue;
   			Report.Info("Hour Entered=" + HourValue);
		}		
		
		//************************************************************************************//
		//********************************Enters Random Minute********************************//
		//************************************************************************************//
			
		public void Minuteval()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMainCreate.ListItemMinute.Click("CenterLeft");
			Keyboard.Press(Keys.Tab);
		    string b = SharedFunctions.Random(0, 59);
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormMainCreate.ListItemMinute);  
   			string MinuteValue = b;
   			ValidateTrack.SurfaceValidateTrackRegression.Min = MinuteValue;
   			Report.Info("Minute Entered=" + MinuteValue);
		}	
		
		//************************************************************************************//
		//***********************************Enters IDL TN************************************//
		//************************************************************************************//
		
		public void IDLval()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMainCreate.ListItemIDL_TN.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    string a = SharedFunctions.IDL_TN();
			Keyboard.Press(a);
   			string OrientValue = a;
   			ValidateTrack.SurfaceValidateTrackRegression.IDL = a;
   			Report.Info("IDL TN Value Entered = " + a);
		}			
		
		//************************************************************************************//
		//**********************************Enters TADIL TN***********************************//
		//************************************************************************************//
		
		public void TADILval()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMainCreate.ListItemTADIL_TN.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    string a = SharedFunctions.Random(128, 4094);
			string b = SharedFunctions.DecimalToBase(Convert.ToInt32(a), 8);
			Keyboard.Press(b);
   			string OrientValue = b;
   			ValidateTrack.SurfaceValidateTrackRegression.TADIL = b;
   			Report.Info("TADIL TN Value Entered = " + b);
		}	
		
		//************************************************************************************//
		//**********************************Enters ATDIL1 TN**********************************//
		//************************************************************************************//
		
		public void ATDL1val()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMainCreate.ListItemATDL1_TN.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    string a = SharedFunctions.ATDL1_TN();
			Keyboard.Press(a);
   			string OrientValue = a;
   			ValidateTrack.SurfaceValidateTrackRegression.ATDL1 = a;
   			Report.Info("ATDIL1 TN Value Entered = " + a);
		}			
		
		//************************************************************************************//
		//**********************************Enters NL1 TN**********************************//
		//************************************************************************************//
		
		public void NL1val()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMainCreate.ListItemNL1_TN.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    string a = SharedFunctions.NATO_TN();
			Keyboard.Press(a);
   			string OrientValue = a;
   			ValidateTrack.SurfaceValidateTrackRegression.NL1 = a;
   			Report.Info("NL1 TN Value Entered = " + a);
		}		
		
		//************************************************************************************//
		//**********************************Enters TADILJ TN**********************************//
		//************************************************************************************//
		
		public void TADILJval()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMainCreate.ListItemTADIL_J_TN.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    string a = SharedFunctions.Random(128, 32766);
			string b = SharedFunctions.DecimalToBase(Convert.ToInt32(a), 8);
			Keyboard.Press(b);
   			string OrientValue = b;
   			ValidateTrack.SurfaceValidateTrackRegression.TADILJ = b;
   			Report.Info("TADILJ TN Value Entered = " + b);
		}	
		
		//************************************************************************************//
		//********************************Enters External TN**********************************//
		//************************************************************************************//
		
		public void Extval()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormMainCreate.ListItemExternal_TN.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    string a = SharedFunctions.Random(128, 32766);
			string b = SharedFunctions.DecimalToBase(Convert.ToInt32(a), 8);
			Keyboard.Press(b);
   			string OrientValue = b;
   			ValidateTrack.SurfaceValidateTrackRegression.Ext = b;
   			Report.Info("External TN Value Entered = " + b);
		}	
		
		//************************************************************************************//
		//****************************Enters Random SAM/SSM Type 1****************************//
		//************************************************************************************//
			
		public void SSM1val()
		{

				try
				{
					repo.FormMainCreate.ListItemSAM_SSM_Type_1.Click("CenterLeft");
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
		            AScount = AScount - 1;
					int ASnum = ASvalue.Next(1, AScount-1);
			       	repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemSAM_SSM_Type_1);  
		   			string SSM1Value = accElement.Value;
		   			ValidateTrack.SurfaceValidateTrackRegression.SSM1 = SSM1Value;
		   			Report.Info("SAM/SSM Type 1 Entered = " + SSM1Value);
		   			ValidateTrack.SurfaceValidateTrackRegression.SSM1_OOR = false;

				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for SAM/SSM Type 1, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.SSM1_OOR = true;
			   					
				}					
			
		}		
		
		//************************************************************************************//
		//****************************Enters Random SAM/SSM Type 2****************************//
		//************************************************************************************//
			
		public void SSM2val()
		{

				try
				{
					repo.FormMainCreate.ListItemSAM_SSM_Type_2.Click("CenterLeft");
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
		            AScount = AScount - 1;
					int ASnum = ASvalue.Next(1, AScount-1);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemSAM_SSM_Type_2);  
		   			string SSM2Value = accElement.Value;
		   			ValidateTrack.SurfaceValidateTrackRegression.SSM2 = SSM2Value;
		   			Report.Info("SAM/SSM Type 2 Entered = " + SSM2Value);
		   			ValidateTrack.SurfaceValidateTrackRegression.SSM2_OOR = false;

				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for SAM/SSM Type 2, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.SSM2_OOR = true;
			   				
				}					
			
		}		
		
		//************************************************************************************//
		//****************************Enters Random SAM/SSM Type 3****************************//
		//************************************************************************************//
			
		public void SSM3val()
		{

				try
				{
					repo.FormMainCreate.ListItemSAM_SSM_Type_3.Click("CenterLeft");
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
					Ranorex.List list2 = "//list[@processname='RealView']";
		            int AScount = list2.Items.Count;
		            Random ASvalue = new Random();
		            AScount = AScount - 1;
					int ASnum = ASvalue.Next(1, AScount-1);
		       		repo.ListRealView.Self.Items[ASnum].Select();
		       		repo.ListRealView.Self.Items[ASnum].Click();
					Accessible accElement = new Accessible(repo.FormMainCreate.ListItemSAM_SSM_Type_3);  
		   			string SSM3Value = accElement.Value;
		   			ValidateTrack.SurfaceValidateTrackRegression.SSM3 = SSM3Value;
		   			Report.Info("SAM/SSM Type 3 Entered = " + SSM3Value);
		   			ValidateTrack.SurfaceValidateTrackRegression.SSM3_OOR = false;

				}
				catch (ArgumentOutOfRangeException e)
				{								   			

			   			Report.Debug("List Count Out of Range for SAM/SSM Type 3, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateTrack.SurfaceValidateTrackRegression.SSM3_OOR = true;
			   					
				}					
			
		}		

		//************************************************************************************//
		//***********************Validates Previous Track Was Dropped*************************//
		//************************************************************************************//
		
		public void ValidateDropTrack()
		{
		Delay.Milliseconds(1500, false);
		if (repo.FormTacViewC2.PictureTrackCreateDropInfo.Exists())
			{
				TacViewLib.LinkSpecific.Surveillance.Drop_Track.DropTrack.Start();
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
   			ValidateTrack.SurfaceValidateTrackRegression.TrackNum = track1;
   			Drop_Track.DropTrack.TrackNum = track1;   			
		}
		
		//**************************************************************************************//
		//**************************Ranorex Generated Default Method****************************//
		//**************************************************************************************//		
		
		static SurfaceCreateTrackRegression()
		{
			//Your recording specific initialization code goes here.
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

		//**************************************************************************************//
		//****************************Ranorex Generated Init Method*****************************//
		//**************************************************************************************//
		
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}	
	}
}