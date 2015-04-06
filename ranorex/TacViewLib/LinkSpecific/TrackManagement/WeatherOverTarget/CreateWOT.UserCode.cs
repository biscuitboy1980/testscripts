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
	/// The ValidateTrackRegression recording.
	/// </summary>

	public partial class CreateWOT
	{		
		public static string TrackNum;
		public static int ContrailHeightLower;
		public static int IcingHeightLower;		
		
		public static bool ZoomFlag = false;
		
		//************************************************************************************//
		//*******************************Right Clicks on Track********************************//
		//************************************************************************************//		
		
		public void RightClickTrack()
		{			
			Duration OrigDur = repo.FormTacViewC2.PictureTrackInfo.SearchTimeout;
			repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = 2000;			
			
			if (repo.FormTacViewC2.PictureTrackInfo.Exists())
			{
				Report.Info("Mouse Right Click item 'FormTacViewC2.PictureTrack' at Center.");
				repo.FormTacViewC2.PictureTrack.Click(MouseButtons.Right);
			}
			else
			{
				ZoomFlag = true;
				Report.Info("Track # " + TrackNum + " not found on the current display, going to world wide view");
				Report.Screenshot();
				repo.FormTacViewC2.ButtonZoom_Out_Max.Click();
				
				if (repo.FormTacViewC2.PictureTrackInfo.Exists())
				{
					Report.Info("Mouse Right Click item 'FormTacViewC2.PictureTrack' at Center.");
					repo.FormTacViewC2.PictureTrack.Click(MouseButtons.Right);
				}
				else
				{
					Report.Error("Unable to find Track # " + TrackNum + " anywhere in the world");
					Report.Screenshot();
					return;
				}				
			}
			
			repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = OrigDur;
		}				
		
		//************************************************************************************//
		//*********************************Opens WOT Dialog***********************************//
		//************************************************************************************//	
		
		public void CreateWeatherOverTarget()
		{		
			
			Duration OrigDur = repo.FormRealView.MenuItemTracksInfo.SearchTimeout;
			repo.FormRealView.MenuItemTracksInfo.SearchTimeout = 1000;
			Duration OrigDur1 = repo.FormRealView.MenuItemTrackNumberInfo.SearchTimeout;
			repo.FormRealView.MenuItemTrackNumber2Info.SearchTimeout = 1000;			
			
			if (repo.FormRealView.MenuItemTracksInfo.Exists())
			{
				Report.Info("Mouse Left Click item 'FormRealView.MenuItemTracks'");
			    repo.FormRealView.MenuItemTracks.Click();
			    Report.Info("Mouse Left Click item 'FormTracks.MenuItemC2_HOST_Track'");
		        repo.FormTracks.MenuItemC2_HOST_Track.Click();
		       	Report.Info("Mouse Left Click item 'FormConnection1withTrackNum.MenuItemTrack_Management'");
				repo.FormConnection1withTrackNum.MenuItemTrack_Management.Click("Center");
				Report.Info("Mouse Left Click item 'FormTrack_Management.MenuItemCreate_Weather_Over_Targ'");
				repo.FormTrack_Management.MenuItemCreate_Weather_Over_Targ.Click("Center");
			}			
			else if (repo.FormRealView.MenuItemTrackNumberInfo.Exists())
			{
			    Report.Info("Mouse Left Click item 'repo.FormRealView.MenuItemTrackNumber'");
		        repo.FormRealView.MenuItemTrackNumber.Click();
		       	Report.Info("Mouse Left Click item 'FormConnection1withTrackNum.MenuItemTrack_Management'");
				repo.FormConnection1withTrackNum.MenuItemTrack_Management.Click("Center");
				Report.Info("Mouse Left Click item 'FormTrack_Management.MenuItemCreate_Weather_Over_Targ'");
				repo.FormTrack_Management.MenuItemCreate_Weather_Over_Targ.Click("Center");
			}
			
			repo.FormRealView.MenuItemTracksInfo.SearchTimeout = OrigDur;
			repo.FormRealView.MenuItemTrackNumberInfo.SearchTimeout = OrigDur1;
		}			
		
		//************************************************************************************//
		//*****************************Sets Track Number in Repo******************************//
		//************************************************************************************//		

		public void SetTrackNumberInRepo()
		{
			tracknumber = TrackNum;	
		}
		
		//************************************************************************************//
		//***************************Enters Random Index Value********************************//
		//************************************************************************************//
		
		public void Index()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormCreate_Weather_Over.ListItemIndex_Number.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 64);
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemIndex_Number);  
   			string IndValue = b;
   			ValidateWOT.Ind = IndValue;
   			Report.Info("Index Number Entered = " + IndValue);	
		}
		
		//************************************************************************************//
		//***************************Enters Random Hour Value********************************//
		//************************************************************************************//
		
		public void Hour()
		{
			repo.FormCreate_Weather_Over.ListItemHour.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string a = System.DateTime.Now.ToString("HH");
			string b = a.TrimStart('0');   
			int c = Convert.ToInt32(b);
			c = c - 1;
			string d = c.ToString();
			Keyboard.Press(d);
   			ValidateWOT.Hr = d;
   			Report.Info("Hour Entered = " + d);
		}
		
		//************************************************************************************//
		//***************************Enters Random Minute Value*******************************//
		//************************************************************************************//
		
		public void Minute()
		{
			repo.FormCreate_Weather_Over.ListItemMinute.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);		    
			string a = System.DateTime.Now.ToString("mm");
			string b = a.TrimStart('0');        	
			Keyboard.Press(b);
   			ValidateWOT.Min = b;
   			Report.Info("Minute Entered = " + b);
		}
		
		//************************************************************************************//
		//*****************************Enters Random QNH Value********************************//
		//************************************************************************************//
		
		public void QNH()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormCreate_Weather_Over.ListItemQNH__hectopascals.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(950, 1051);
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemQNH__hectopascals);  
   			string QNHValue = b;
   			ValidateWOT.QNH = QNHValue;
   			Report.Info("QNH Value Entered = " + QNHValue);	
		}
		
		//************************************************************************************//
		//***********************Enters Random Wind Direction Value***************************//
		//************************************************************************************//
		
		public void WindDir()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormCreate_Weather_Over.ListItemWind_Direction.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 72);
			int a = Convert.ToInt32(b);
			a = a * 5;
			b = a.ToString();
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemWind_Direction);  
   			string WindDirValue = b;
   			ValidateWOT.WindDir = WindDirValue;
   			Report.Info("Wind Direction Value Entered = " + WindDirValue);	
		}
		
		//************************************************************************************//
		//**************************Enters Random Wind Speed Value****************************//
		//************************************************************************************//
		
		public void WindSp()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormCreate_Weather_Over.ListItemWind_Speed.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 126);
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemWind_Speed);  
   			string WindSpdValue = b;
   			ValidateWOT.WindSp = WindSpdValue;
   			Report.Info("Wind Speed Value Entered = " + WindSpdValue);	
		}

		//************************************************************************************//
		//**************************Enters Random Visibility Value****************************//
		//************************************************************************************//
		
		public void Visibility()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormCreate_Weather_Over.ListItemVisibility.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 125);
			int a = Convert.ToInt32(b);
			a = a * 100;
			b = a.ToString();
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemVisibility);  
   			string VisValue = b;
   			ValidateWOT.Vis = VisValue;
   			Report.Info("Visibility Value Entered = " + VisValue);	
		}
		
		//************************************************************************************//
		//**************************Enters Random Cloud Cover 1 Value*************************//
		//************************************************************************************//
		
		public void CloudCover1()
		{

			repo.FormCreate_Weather_Over.ListItemCloud_Cover_1.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			Ranorex.List list2 = "//list[@processname='RealView']";
            int AScount = list2.Items.Count;
            Random ASvalue = new Random();
			int ASnum = ASvalue.Next(0, AScount);
			if (ASnum < 0 || ASnum > AScount)
				{

					Keyboard.Press(Keys.Escape);
					Report.Debug("List Count Out of Range for Cloud Cover 1, Field will not be validated");
					ValidateWOT.CC1_OOR=true;
				
				}
			else
				{
	       		repo.ListRealView.Self.Items[ASnum].Select();
	       		repo.ListRealView.Self.Items[ASnum].Click("center");
				Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemCloud_Cover_1);  
	   			string CC1Value = accElement.Value;
	   			ValidateWOT.CC1 = CC1Value;
	   			Report.Info("Cloud Cover 1 Value Entered = " + CC1Value);
				}
			
		}	
		
		//************************************************************************************//
		//***********************Enters Random Cloud Height 1 Value***************************//
		//************************************************************************************//
		
		public void CloudHeight1()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormCreate_Weather_Over.ListItemCloud_Height_1.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 61);
			int a = Convert.ToInt32(b);
			a = a * 100;
			b = a.ToString();
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemCloud_Height_1);  
   			string CH1Value = b;
   			ValidateWOT.CH1 = CH1Value;
   			Report.Info("Cloud Height 1 Value Entered = " + CH1Value);	
		}
		
		//************************************************************************************//
		//**************************Enters Random Cloud Cover 4 Value*************************//
		//************************************************************************************//
		
		public void CloudCover4()
		{

			repo.FormCreate_Weather_Over.ListItemCloud_Cover_4.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			Ranorex.List list2 = "//list[@processname='RealView']";
            int AScount = list2.Items.Count;
            Random ASvalue = new Random();
			int ASnum = ASvalue.Next(0, AScount);
			if (ASnum < 0 || ASnum > AScount)
				{

					Keyboard.Press(Keys.Escape);
					Report.Debug("List Count Out of Range for Cloud Cover 4, Field will not be validated");
					ValidateWOT.CC4_OOR=true;
					
				}
			else
				{
	       		repo.ListRealView.Self.Items[ASnum].Select();
	       		repo.ListRealView.Self.Items[ASnum].Click("center");
				Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemCloud_Cover_4);  
	   			string CC4Value = accElement.Value;
	   			ValidateWOT.CC4 = CC4Value;
	   			Report.Info("Cloud Cover 4 Value Entered = " + CC4Value);
	   			
				}
			
		}	
		
		//************************************************************************************//
		//***********************Enters Random Cloud Height 4 Value***************************//
		//************************************************************************************//
		
		public void CloudHeight4()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormCreate_Weather_Over.ListItemCloud_Height_4.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 62);
			int a = Convert.ToInt32(b);
			a = a * 1000;
			b = a.ToString();
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemCloud_Height_4);  
   			string CH4Value = b;
   			ValidateWOT.CH4 = CH4Value;
   			Report.Info("Cloud Height 4 Value Entered = " + CH4Value);	
		}		

		//************************************************************************************//
		//**************************Enters Random Cloud Cover 5 Value*************************//
		//************************************************************************************//
		
		public void CloudCover5()
		{

			repo.FormCreate_Weather_Over.ListItemCloud_Cover_5.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			Ranorex.List list2 = "//list[@processname='RealView']";
            int AScount = list2.Items.Count;
            Random ASvalue = new Random();
			int ASnum = ASvalue.Next(0, AScount);
			if (ASnum < 0 || ASnum > AScount)
				{

					Keyboard.Press(Keys.Escape);
					Report.Debug("List Count Out of Range for Cloud Cover 5, Field will not be validated");
					ValidateWOT.CC5_OOR=true;
					
				}
			else
				{
	       		repo.ListRealView.Self.Items[ASnum].Select();
	       		repo.ListRealView.Self.Items[ASnum].Click("center");
				Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemCloud_Cover_5);  
	   			string CC5Value = accElement.Value;
	   			ValidateWOT.CC5 = CC5Value;
	   			Report.Info("Cloud Cover 5 Value Entered = " + CC5Value);
	   		
				}
			
		}	
		
		//************************************************************************************//
		//***********************Enters Random Cloud Height 5 Value***************************//
		//************************************************************************************//
		
		public void CloudHeight5()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormCreate_Weather_Over.ListItemCloud_Height_5.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 62);
			int a = Convert.ToInt32(b);
			a = a * 1000;
			b = a.ToString();
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemCloud_Height_5);  
   			string CH5Value = b;
   			ValidateWOT.CH5 = CH5Value;
   			Report.Info("Cloud Height 5 Value Entered = " + CH5Value);	
		}		

		//************************************************************************************//
		//**************************Enters Random Cloud Cover 6 Value*************************//
		//************************************************************************************//
		
		public void CloudCover6()
		{

			repo.FormCreate_Weather_Over.ListItemCloud_Cover_6.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			Ranorex.List list2 = "//list[@processname='RealView']";
            int AScount = list2.Items.Count;
            Random ASvalue = new Random();
			int ASnum = ASvalue.Next(0, AScount);
			if (ASnum < 0 || ASnum > AScount)
				{

					Keyboard.Press(Keys.Escape);
					Report.Debug("List Count Out of Range for Cloud Cover 6, Field will not be validated");
					ValidateWOT.CC6_OOR=true;
					
				}
			else
				{
	       		repo.ListRealView.Self.Items[ASnum].Select();
	       		repo.ListRealView.Self.Items[ASnum].Click("center");
				Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemCloud_Cover_6);  
	   			string CC6Value = accElement.Value;
	   			ValidateWOT.CC6 = CC6Value;
	   			Report.Info("Cloud Cover 6 Value Entered = " + CC6Value);
	   	
				}
			
		}	
		
		//************************************************************************************//
		//***********************Enters Random Cloud Height 6 Value***************************//
		//************************************************************************************//
		
		public void CloudHeight6()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormCreate_Weather_Over.ListItemCloud_Height_6.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 62);
			int a = Convert.ToInt32(b);
			a = a * 1000;
			b = a.ToString();
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemCloud_Height_6);  
   			string CH6Value = b;
   			ValidateWOT.CH6 = CH6Value;
   			Report.Info("Cloud Height 6 Value Entered = " + CH6Value);	
		}
		
		//************************************************************************************//
		//************************Enters Random Actual Weather Value**************************//
		//************************************************************************************//
		
		public void ActualWeather()
		{

			repo.FormCreate_Weather_Over.ListItemActual_Weather.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			Ranorex.List list2 = "//list[@processname='RealView']";
            int AScount = list2.Items.Count;
            Random ASvalue = new Random();
			int ASnum = ASvalue.Next(1, AScount);
			if (ASnum < 1 || ASnum > AScount)
				{

					Keyboard.Press(Keys.Escape);
					Report.Debug("List Count Out of Range for Actual Weather, Field will not be validated");
					ValidateWOT.ActWeather_OOR=true;
					
				}
			else
				{
	       		repo.ListRealView.Self.Items[ASnum].Select();
	       		repo.ListRealView.Self.Items[ASnum].Click("center");
				Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemActual_Weather);  
	   			string ActWeatherValue = accElement.Value;
	   			ValidateWOT.ActWeather = ActWeatherValue;
	   			Report.Info("Actual Weather Value Entered = " + ActWeatherValue);
	   			
				}
			
		}			
		
		//************************************************************************************//
		//*******************Enters Random Actual Weather Descriptor Value********************//
		//************************************************************************************//
		
		public void ActualWeatherDes()
		{

			repo.FormCreate_Weather_Over.ListItemActual_Weather_Descriptor.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			Ranorex.List list2 = "//list[@processname='RealView']";
            int AScount = list2.Items.Count;
            Random ASvalue = new Random();
			int ASnum = ASvalue.Next(1, AScount);
			if (ASnum < 1 || ASnum > AScount)
				{

					Keyboard.Press(Keys.Escape);
					Report.Debug("List Count Out of Range for Actual Weather Descriptor, Field will not be validated");
					ValidateWOT.ActWeatherDes_OOR=true;
					
				}
			else
				{
	       		repo.ListRealView.Self.Items[ASnum].Select();
	       		repo.ListRealView.Self.Items[ASnum].Click("center");
				Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemActual_Weather_Descriptor);  
	   			string ActWeatherDesValue = accElement.Value;
	   			ValidateWOT.ActWeatherDes = ActWeatherDesValue;
	   			Report.Info("Actual Weather Descriptor Value Entered = " + ActWeatherDesValue);
	   		
				}
			
		}		
		
		//************************************************************************************//
		//**************Enters Random Actual Weather Intensity Proximity Value****************//
		//************************************************************************************//
		
		public void ActualWeatherInt()
		{

			repo.FormCreate_Weather_Over.ListItemActual_Weather_Intensity.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			Ranorex.List list2 = "//list[@processname='RealView']";
            int AScount = list2.Items.Count;
            Random ASvalue = new Random();
			int ASnum = ASvalue.Next(1, AScount);
			if (ASnum < 1 || ASnum > AScount)
				{

					Keyboard.Press(Keys.Escape);
					Report.Debug("List Count Out of Range for Actual Weather Intensity Proximity, Field will not be validated");
					ValidateWOT.ActWeatherInt_OOR=true;
					
				}
			else
				{
	       		repo.ListRealView.Self.Items[ASnum].Select();
	       		repo.ListRealView.Self.Items[ASnum].Click("center");
				Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemActual_Weather_Intensity);  
	   			string ActWeatherIntValue = accElement.Value;
	   			ValidateWOT.ActWeatherInt = ActWeatherIntValue;
	   			Report.Info("Actual Weather Intensity Proximity Value Entered = " + ActWeatherIntValue);
	 
				}
			
		}			
		
		//************************************************************************************//
		//***********************Enters Height of Observation Value***************************//
		//************************************************************************************//
		
		public void HeightOfObs()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormCreate_Weather_Over.ListItemHeight_of_Observation.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 510);
			int a = Convert.ToInt32(b);
			a = a * 100;
			b = a.ToString();
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemHeight_of_Observation);  
   			string HeightOfObsValue = b;
   			ValidateWOT.HeightOfObs = HeightOfObsValue;
   			Report.Info("Height of Observation Entered = " + HeightOfObsValue);	
		}		
		
		//************************************************************************************//
		//**************************Enters Relative Humidity Value****************************//
		//************************************************************************************//
		
		public void RelativeHum()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormCreate_Weather_Over.ListItemRelative_Humidity.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 11);
			int a = Convert.ToInt32(b);
			a = a * 10;
			b = a.ToString();
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemRelative_Humidity);  
   			string RelativeHumValue = b;
   			ValidateWOT.RelativeHum = RelativeHumValue;
   			Report.Info("Relative Humidity Value Entered = " + RelativeHumValue);	
		}		
		
		//************************************************************************************//
		//*****************Enters Random Surrounding Weather Condition Value******************//
		//************************************************************************************//
		
		public void SWC()
		{

			repo.FormCreate_Weather_Over.ListItemSurrounding_Weather_Cond.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			Ranorex.List list2 = "//list[@processname='RealView']";
            int AScount = list2.Items.Count;
            Random ASvalue = new Random();
			int ASnum = ASvalue.Next(1, AScount);
			if (ASnum < 1 || ASnum > AScount)
				{

					Keyboard.Press(Keys.Escape);
					Report.Debug("List Count Out of Range for Surrounding Weather Condition, Field will not be validated");
					ValidateWOT.SWC_OOR=true;
					
				}
			else
				{
	       		repo.ListRealView.Self.Items[ASnum].Select();
	       		repo.ListRealView.Self.Items[ASnum].Click("center");
				Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemSurrounding_Weather_Cond);  
	   			string SWCValue = accElement.Value;
	   			ValidateWOT.SWC = SWCValue;
	   			Report.Info("Actual Surrounding Weather Condition Value Entered = " + SWCValue);
	   			
				}
			
		}		
		
		//************************************************************************************//
		//*********************Enters Random Weather Amplification Value**********************//
		//************************************************************************************//
		
		public void WeatherAmp()
		{

			repo.FormCreate_Weather_Over.ListItemWeather_Amplification.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			Ranorex.List list2 = "//list[@processname='RealView']";
            int AScount = list2.Items.Count;
            Random ASvalue = new Random();
			int ASnum = ASvalue.Next(1, AScount);
			if (ASnum < 1 || ASnum > AScount)
				{

					Keyboard.Press(Keys.Escape);
					Report.Debug("List Count Out of Range for Weather Amplification, Field will not be validated");
					ValidateWOT.SWC_OOR=true;
					
				}
			else
				{
	       		repo.ListRealView.Self.Items[ASnum].Select();
	       		repo.ListRealView.Self.Items[ASnum].Click("center");
				Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemWeather_Amplification);  
	   			string WeatherAmpValue = accElement.Value;
	   			ValidateWOT.WeatherAmp = WeatherAmpValue;
	   			Report.Info("Actual Weather Amplification Value Entered = " + WeatherAmpValue);
	   		
				}
			
		}					
		
		//************************************************************************************//
		//****************************Contrail Height Lower Limit*****************************//
		//************************************************************************************//
		
		public void CHLL()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormCreate_Weather_Over.ListItemContrail_Height_Lower_Li.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 510);
			int a = Convert.ToInt32(b);
			a = a * 100;
			b = a.ToString();
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemContrail_Height_Lower_Li);  
   			string CHLLValue = b;
   			ValidateWOT.CHLL = CHLLValue;
   			ContrailHeightLower = Convert.ToInt32(CHLLValue);
   			Report.Info("Contrail Height Lower Limit Value Entered = " + CHLLValue);	
		}			
		
		//************************************************************************************//
		//****************************Contrail Height Upper Limit*****************************//
		//************************************************************************************//
		
		public void CHUL()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormCreate_Weather_Over.ListItemContrail_Height_Upper_Li.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    ContrailHeightLower = (ContrailHeightLower/100) + 1;
			string b = SharedFunctions.Random(ContrailHeightLower, 510);
			int a = Convert.ToInt32(b);
			a = a * 100;
			b = a.ToString();
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemContrail_Height_Upper_Li);  
   			string CHULValue = b;
   			ValidateWOT.CHUL = CHULValue;
   			Report.Info("Contrail Height Upper Limit Value Entered = " + CHULValue);	
		}	
		
		//************************************************************************************//
		//******************************Icing Height Lower Limit******************************//
		//************************************************************************************//
		
		public void IHLL()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormCreate_Weather_Over.ListItemIcing_Height_Lower_Limit.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
			string b = SharedFunctions.Random(1, 510);
			int a = Convert.ToInt32(b);
			a = a * 100;
			b = a.ToString();
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemIcing_Height_Lower_Limit);  
   			string IHLLValue = b;
   			ValidateWOT.IHLL = IHLLValue;
   			IcingHeightLower = Convert.ToInt32(IHLLValue);
   			Report.Info("Icing Height Lower Limit Value Entered = " + IHLLValue);	
		}			
		
		//************************************************************************************//
		//******************************Icing Height Upper Limit******************************//
		//************************************************************************************//
		
		public void IHUL()
		{
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			repo.FormCreate_Weather_Over.ListItemIcing_Height_Upper_Limit.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    IcingHeightLower = (IcingHeightLower/100) + 1;
			string b = SharedFunctions.Random(IcingHeightLower, 510);
			int a = Convert.ToInt32(b);
			a = a * 100;
			b = a.ToString();
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemIcing_Height_Upper_Limit);  
   			string IHULValue = b;
   			ValidateWOT.IHUL = IHULValue;
   			Report.Info("Icing Height Upper Limit Value Entered = " + IHULValue);	
		}		
		
		//************************************************************************************//
		//************************Enters Random En Route Weather Value************************//
		//************************************************************************************//
		
		public void EnRoute()
		{

			repo.FormCreate_Weather_Over.ListItemEn_Route_Weather.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);
		    Keyboard.Press("{LMenu down}{Down}{LMenu up}");
			Ranorex.List list2 = "//list[@processname='RealView']";
            int AScount = list2.Items.Count;
            Random ASvalue = new Random();
			int ASnum = ASvalue.Next(1, AScount);
			if (ASnum < 1 || ASnum > AScount)
				{

					Keyboard.Press(Keys.Escape);
					Report.Debug("List Count Out of Range for En Route Weather, Field will not be validated");
					ValidateWOT.EnRoute_OOR=true;
					
				}
			else
				{
	       		repo.ListRealView.Self.Items[ASnum].Select();
	       		repo.ListRealView.Self.Items[ASnum].Click("center");
				Accessible accElement = new Accessible(repo.FormCreate_Weather_Over.ListItemEn_Route_Weather);  
	   			string EnRouteValue = accElement.Value;
	   			ValidateWOT.EnRoute = EnRouteValue;
	   			Report.Info("En Route Weather Value Entered = " + EnRouteValue);
	   			
				}
			
		}		
		
		//**************************************************************************************//
		//***************************Ranorex Generated Default Method***************************//
		//**************************************************************************************//		

		static CreateWOT()
		{
			//Your recording specific initialization code goes here.
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