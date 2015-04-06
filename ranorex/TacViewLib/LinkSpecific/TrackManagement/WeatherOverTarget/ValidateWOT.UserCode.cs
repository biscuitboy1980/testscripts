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

	public partial class ValidateWOT
	{		
		public static bool ZoomFlag = false;
		
		public static string TrackNum;
		
		//Weather Over Target
		public static string Ind;
		public static string Hr;
		public static string Min;
		public static string QNH;
		public static string WindDir;
		public static string WindSp;
		public static string Vis;
		public static string CC1;
		public static string CH1;
		public static string CC4;
		public static string CH4;
		public static string CC5;
		public static string CH5;
		public static string CC6;		
		public static string CH6;
		public static string ActWeather;
		public static string ActWeatherDes;
		public static string ActWeatherInt;
		public static string HeightOfObs;
		public static string RelativeHum;
		public static string SWC;
		public static string WeatherAmp;
		public static string CHLL;		
		public static string CHUL;		
		public static string IHLL;		
		public static string IHUL;	
		public static string EnRoute;
		
		//Out of Range Flags
		public static bool CC1_OOR;
		public static bool CC4_OOR;
		public static bool CC5_OOR;
		public static bool CC6_OOR;
		public static bool ActWeather_OOR;
		public static bool ActWeatherDes_OOR;		
		public static bool ActWeatherInt_OOR;	
		public static bool SWC_OOR;		
		public static bool WeatherAmp_OOR;		
		public static bool EnRoute_OOR;		
		
		//************************************************************************************//
		//*****************************Sets Track Number in Repo******************************//
		//************************************************************************************//
		
		public void SetTrackNumberInRepo()
		{
			tracknumber = TrackNum;	
			Report.Info("Setting tracknumber to " + tracknumber);
		}		
				
		//************************************************************************************//
		//****************************Opens Track Properties Dialog***************************//
		//************************************************************************************//
		
		public void ViewTrackProperties()
		{			
			Duration OrigDur = repo.FormRealView.MenuItemTracksInfo.SearchTimeout;
			repo.FormRealView.MenuItemTracksInfo.SearchTimeout = 1000;
			Duration OrigDur1 = repo.FormRealView.MenuItemTrackNumber2Info.SearchTimeout;
			repo.FormRealView.MenuItemTrackNumber2Info.SearchTimeout = 1000;			
			
			if (repo.FormRealView.MenuItemTracksInfo.Exists())
			{
				Report.Info("Mouse Left Click item 'FormRealView.MenuItemTracks'");
			    repo.FormRealView.MenuItemTracks.Click();
			    Report.Info("Mouse Left Click item 'FormTracks.MenuItemC2_HOST_2_Track'");
		        repo.FormTracks.MenuItemC2_HOST_2_Track.Click();
		       	Report.Info("Mouse Left Click item 'FormTOAD2.MenuItemTrack_Properties");
				repo.FormConnection2.MenuItemTrack_Properties.Click();
			}			
			else if (repo.FormRealView.MenuItemTrackNumber2Info.Exists())
			{
			    Report.Info("Mouse Left Click item 'repo.FormRealView.MenuItemTrackNumber2'");
		        repo.FormRealView.MenuItemTrackNumber2.Click();
		       	Report.Info("Mouse Left Click item 'FormTOAD2.MenuItemTrack_Properties");
				repo.FormConnection2.MenuItemTrack_Properties.Click();
			}
			
			repo.FormRealView.MenuItemTracksInfo.SearchTimeout = OrigDur;
			repo.FormRealView.MenuItemTrackNumber2Info.SearchTimeout = OrigDur1;
		}
		
		//************************************************************************************//
		//***************************Validates Weather Over Target****************************//
		//************************************************************************************//
		
		public void ValidateWeather_Over_Target()
		{
			if (repo.FormMain__Land_Point_Track_TN.TabPageWeather_Over_Target__LanInfo.Exists())
			{
				Report.Info("Mouse Left Click item 'FormMain__Land_Point_Track_TN.TabPageWeather_Over_Target' at Center.");
				repo.FormMain__Land_Point_Track_TN.TabPageWeather_Over_Target__Lan.Click();
				
//				ValidateIndex();
				ValidateHour();
				ValidateMinute();
				ValidateQNH();
				ValidateWindDir();
				ValidateWindSp();
				ValidateVisibility();
				ValidateCC1();
				ValidateCH1();			
				ValidateCC4();
				ValidateCH4();
				ValidateCC5();
				ValidateCH5();
				ValidateCC6();
				ValidateCH6();
				ValidateActualWeather();
				ValidateActualWeatherDes();
				ValidateActualWeatherInt();
				ValidateHOO();
				ValidateRelativeHu();
				ValidateSWC();
				ValidateWeatherAmp();
				ValidateCHLL();
				ValidateCHUL();
				ValidateIHLL();
				ValidateIHUL();
				ValidateRoute();
				repo.FormWeather_Over.ButtonCLOSE.Click();
				RightClickTrack();
				DropTrack();
				Validate_DropTrack();
				Zoom500();
			}
			else
			{
				Report.Error("Weather Over Target has been Rejected. Please Resync your ADSI Segments ");
				repo.FormMain__Land_Point_Track_TN.ButtonCLOSE.Click();
				RightClickTrack();
				DropTrack();
				Validate_DropTrack();
				Zoom500();
			}
		}
		
		//************************************************************************************//
		//************************************************************************************//
		//***********************************Sub-Routines*************************************//
		//************************************************************************************//		
		//************************************************************************************//		
		
		//*******************************Validates Index Value********************************//
						
		public void ValidateIndex()
		{
			Report.Info("Validating AttributeEqual (Text='(Ind)') on item 'FormMain__Land_Point_Track_TN_Airfield.ListItemIndex_Number'.");
			Report.Info("Value Entered = " + Ind);
			Validate.Attribute(repo.FormWeather_Over.ListItemIndex_NumberInfo, "AccessibleValue", Ind, Validate.DefaultMessage, false);
		}
		
		//*******************************Validates Hour Value********************************//
				
		public void ValidateHour()
		{
			Report.Info("Validating AttributeEqual (Text='(Hr)') on item 'FormWeather_Over.ListItemHour'.");
			Report.Info("Value Entered = " + Hr);
			Validate.Attribute(repo.FormWeather_Over.ListItemHourInfo, "AccessibleValue", Hr, Validate.DefaultMessage, false);
		}
		
		//*******************************Validates Minute Value********************************//
				
		public void ValidateMinute()
		{
			Report.Info("Validating AttributeEqual (Text='(Min)') on item 'FormWeather_Over.ListItemMinute'.");
			Report.Info("Value Entered = " + Min);
			Validate.Attribute(repo.FormWeather_Over.ListItemMinuteInfo, "AccessibleValue", Min, Validate.DefaultMessage, false);
		}		
		
		//*******************************Validates QNH Value********************************//
				
		public void ValidateQNH()
		{
			Report.Info("Validating AttributeEqual (Text='(QNH)') on item 'FormWeather_Over.ListItemQNH__hectopascals'.");
			Report.Info("Value Entered = " + QNH);
			Validate.Attribute(repo.FormWeather_Over.ListItemQNH__hectopascalsInfo, "AccessibleValue", QNH, Validate.DefaultMessage, false);
		}
		
		//**************************Validates Wind Direction Value****************************//
				
		public void ValidateWindDir()
		{
			Report.Info("Validating AttributeEqual (Text='(WindDir)') on item 'FormWeather_Over.ListItemWind_Direction'.");
			Report.Info("Value Entered = " + QNH);
			Validate.Attribute(repo.FormWeather_Over.ListItemWind_DirectionInfo, "AccessibleValue", WindDir, Validate.DefaultMessage, false);
		}
		
		//****************************Validates Wind Speed Value******************************//
				
		public void ValidateWindSp()
		{
			Report.Info("Validating AttributeEqual (Text='(WindSp)') on item 'FormWeather_Over.ListItemWind_Speed'.");
			Report.Info("Value Entered = " + WindSp);
			Validate.Attribute(repo.FormWeather_Over.ListItemWind_SpeedInfo, "AccessibleValue", WindSp, Validate.DefaultMessage, false);
		}		
		
		//****************************Validates Visibility Value******************************//
				
		public void ValidateVisibility()
		{
			Report.Info("Validating AttributeEqual (Text='(Vis)') on item 'FormWeather_Over.ListItemVisibility'.");
			Report.Info("Value Entered = " + Vis);
			Validate.Attribute(repo.FormWeather_Over.ListItemVisibilityInfo, "AccessibleValue", Vis, Validate.DefaultMessage, false);
		}			
		
		//**************************Validates Cloud Cover 1 Value*****************************//
				
		public void ValidateCC1()
		{
			if (!CC1_OOR)
			{
				Report.Info("Validating AttributeEqual (Text='(CC1)') on item 'FormWeather_Over.ListItemCloud_Cover_1'.");
				Report.Info("Value Entered = " + CC1);
				Validate.Attribute(repo.FormWeather_Over.ListItemCloud_Cover_1Info, "AccessibleValue", CC1, Validate.DefaultMessage, false);
			}
		}	
		
		//**************************Validates Cloud Height 1 Value****************************//
				
		public void ValidateCH1()
		{
			if (!CC1_OOR)
			{
				Report.Info("Validating AttributeEqual (Text='(CH1)') on item 'FormWeather_Over.ListItemCloud_Height_1'.");
				Report.Info("Value Entered = " + CH1);
				Validate.Attribute(repo.FormWeather_Over.ListItemCloud_Height_1Info, "AccessibleValue", CH1, Validate.DefaultMessage, false);
			}
		}	

		//************************************************************************************//
		//**************************Validates Cloud Cover 4 Value*****************************//
		//************************************************************************************//
				
		public void ValidateCC4()
		{
			if (!CC4_OOR)
			{
				Report.Info("Validating AttributeEqual (Text='(CC4)') on item 'FormWeather_Over.ListItemCloud_Cover_4'.");
				Report.Info("Value Entered = " + CC4);
				Validate.Attribute(repo.FormWeather_Over.ListItemCloud_Cover_4Info, "AccessibleValue", CC4, Validate.DefaultMessage, false);
			}
		}	
		
		//**************************Validates Cloud Height 4 Value****************************//
				
		public void ValidateCH4()
		{
			if (!CC4_OOR)
			{
				Report.Info("Validating AttributeEqual (Text='(CH4)') on item 'FormWeather_Over.ListItemCloud_Height_4'.");
				Report.Info("Value Entered = " + CH4);
				Validate.Attribute(repo.FormWeather_Over.ListItemCloud_Height_4Info, "AccessibleValue", CH4, Validate.DefaultMessage, false);
			}
		}	
		
		//**************************Validates Cloud Cover 5 Value*****************************//
				
		public void ValidateCC5()
		{
			if (!CC5_OOR)
			{
				Report.Info("Validating AttributeEqual (Text='(CC5)') on item 'FormWeather_Over.ListItemCloud_Cover_5'.");
				Report.Info("Value Entered = " + CC5);
				Validate.Attribute(repo.FormWeather_Over.ListItemCloud_Cover_5Info, "AccessibleValue", CC5, Validate.DefaultMessage, false);
			}
		}	
		
		//**************************Validates Cloud Height 5 Value****************************//
				
		public void ValidateCH5()
		{
			if (!CC5_OOR)
			{
				Report.Info("Validating AttributeEqual (Text='(CH5)') on item 'FormWeather_Over.ListItemCloud_Height_5'.");
				Report.Info("Value Entered = " + CH5);
				Validate.Attribute(repo.FormWeather_Over.ListItemCloud_Height_5Info, "AccessibleValue", CH5, Validate.DefaultMessage, false);
			}
		}			
		
		//**************************Validates Cloud Cover 6 Value*****************************//
				
		public void ValidateCC6()
		{
			if (!CC6_OOR)
			{
				Report.Info("Validating AttributeEqual (Text='(CC6)') on item 'FormWeather_Over.ListItemCloud_Cover_6'.");
				Report.Info("Value Entered = " + CC6);
				Validate.Attribute(repo.FormWeather_Over.ListItemCloud_Cover_6Info, "AccessibleValue", CC6, Validate.DefaultMessage, false);
			}
		}	
		
		//**************************Validates Cloud Height 6 Value****************************//
				
		public void ValidateCH6()
		{
			if (!CC6_OOR)
			{
				Report.Info("Validating AttributeEqual (Text='(CH6)') on item 'FormWeather_Over.ListItemCloud_Height_6'.");
				Report.Info("Value Entered = " + CH6);
				Validate.Attribute(repo.FormWeather_Over.ListItemCloud_Height_6Info, "AccessibleValue", CH6, Validate.DefaultMessage, false);
			}
		}			
		
		//*****************************Validates Actual Weather Value*************************//
				
		public void ValidateActualWeather()
		{
			if (!ActWeather_OOR)
			{
				Report.Info("Validating AttributeEqual (Text='(ActWeather)') on item 'FormWeather_Over.ListItemActual_Weather'.");
				Report.Info("Value Entered = " + ActWeather);
				Validate.Attribute(repo.FormWeather_Over.ListItemActual_WeatherInfo, "AccessibleValue", ActWeather, Validate.DefaultMessage, false);
			}
		}				
		
		//***********************Validates Actual Weather Descriptor Value********************//
				
		public void ValidateActualWeatherDes()
		{
			if (!ActWeatherDes_OOR)
			{
				Report.Info("Validating AttributeEqual (Text='(ActWeatherDes)') on item 'FormWeather_Over.ListItemActual_Weather_Descriptor'.");
				Report.Info("Value Entered = " + ActWeatherDes);
				Validate.Attribute(repo.FormWeather_Over.ListItemActual_Weather_DescriptorInfo, "AccessibleValue", ActWeatherDes, Validate.DefaultMessage, false);
			}
		}					
		
		//*****************Validates Actual Weather Intensity Proximity Value*****************//
				
		public void ValidateActualWeatherInt()
		{
			if (!ActWeatherInt_OOR)
			{
				Report.Info("Validating AttributeEqual (Text='(ActWeatherInt)') on item 'FormWeather_Over.ListItemActual_Weather_Intensity'.");
				Report.Info("Value Entered = " + ActWeatherDes);
				Validate.Attribute(repo.FormWeather_Over.ListItemActual_Weather_IntensityInfo, "AccessibleValue", ActWeatherInt, Validate.DefaultMessage, false);
			}
		}				
		
		//***********************Validates Height of Observation Value************************//
				
		public void ValidateHOO()
		{
			Report.Info("Validating AttributeEqual (Text='(HeightOfObs)') on item 'FormWeather_Over.ListItemHeight_of_Observation'.");
			Report.Info("Value Entered = " + HeightOfObs);
			Validate.Attribute(repo.FormWeather_Over.ListItemHeight_of_ObservationInfo, "AccessibleValue", HeightOfObs, Validate.DefaultMessage, false);
		}		
		
		//***********************Validates Height of Observation Value************************//
				
		public void ValidateRelativeHu()
		{
			Report.Info("Validating AttributeEqual (Text='(RelativeHum)') on item 'FormWeather_Over.ListItemRelative_Humidity'.");
			Report.Info("Value Entered = " + RelativeHum);
			Validate.Attribute(repo.FormWeather_Over.ListItemRelative_HumidityInfo, "AccessibleValue", RelativeHum, Validate.DefaultMessage, false);
		}	
		
		//*************Validates Height of Surrounding Weather Condition Value****************//
				
		public void ValidateSWC()
		{
			if (! SWC_OOR)
			{
				Report.Info("Validating AttributeEqual (Text='(SWC)') on item 'FormWeather_Over.ListItemSurrounding_Weather_Cond'.");
				Report.Info("Value Entered = " + SWC);
				Validate.Attribute(repo.FormWeather_Over.ListItemSurrounding_Weather_CondInfo, "AccessibleValue", SWC, Validate.DefaultMessage, false);
			}
		}	
		
		//*******************Validates Height of Weather Amplification Value******************//
				
		public void ValidateWeatherAmp()
		{
			if (! WeatherAmp_OOR)
			{
				Report.Info("Validating AttributeEqual (Text='(WeatherAmp)') on item 'FormWeather_Over.ListItemWeather_Amplification'.");
				Report.Info("Value Entered = " + WeatherAmp);
				Validate.Attribute(repo.FormWeather_Over.ListItemWeather_AmplificationInfo, "AccessibleValue", WeatherAmp, Validate.DefaultMessage, false);
			}
		}	
		
		//*******************************Validates CHLL Value*********************************//
				
		public void ValidateCHLL()
		{
			Report.Info("Validating AttributeEqual (Text='(CHLL)') on item 'FormWeather_Over.ListItemContrail_Height_Lower_Li'.");
			Report.Info("Value Entered = " + CHLL);
			Validate.Attribute(repo.FormWeather_Over.ListItemContrail_Height_Lower_LiInfo, "AccessibleValue", CHLL, Validate.DefaultMessage, false);
		}			
		
		//********************************Validates CHUL Value********************************//
				
		public void ValidateCHUL()
		{
			Report.Info("Validating AttributeEqual (Text='(CHUL)') on item 'FormWeather_Over.ListItemContrail_Height_Upper_Li'.");
			Report.Info("Value Entered = " + CHUL);
			Validate.Attribute(repo.FormWeather_Over.ListItemContrail_Height_Upper_LiInfo, "AccessibleValue", CHUL, Validate.DefaultMessage, false);
		}			
		
		//********************************Validates IHLL Value********************************//
				
		public void ValidateIHLL()
		{
			Report.Info("Validating AttributeEqual (Text='(IHLL)') on item 'FormWeather_Over.ListItemIcing_Height_Lower_Limit'.");
			Report.Info("Value Entered = " + IHLL);
			Validate.Attribute(repo.FormWeather_Over.ListItemIcing_Height_Lower_LimitInfo, "AccessibleValue", IHLL, Validate.DefaultMessage, false);
		}		
		
		//********************************Validates IHUL Value********************************//
				
		public void ValidateIHUL()
		{
			Report.Info("Validating AttributeEqual (Text='(IHUL)') on item 'FormWeather_Over.ListItemIcing_Height_Upper_Limit'.");
			Report.Info("Value Entered = " + IHUL);
			Validate.Attribute(repo.FormWeather_Over.ListItemIcing_Height_Upper_LimitInfo, "AccessibleValue", IHUL, Validate.DefaultMessage, false);
		}		
		
		//************************************************************************************//
		//***************************Validates En Route Weather Value*************************//
		//************************************************************************************//
				
		public void ValidateRoute()
		{
			Report.Info("Validating AttributeEqual (Text='(IHUL)') on item 'FormWeather_Over.ListItemIcing_Height_Upper_Limit'.");
			Report.Info("Value Entered = " + IHUL);
			Validate.Attribute(repo.FormWeather_Over.ListItemIcing_Height_Upper_LimitInfo, "AccessibleValue", IHUL, Validate.DefaultMessage, false);
		}
		
		//*******************************Right Clicks on Track********************************//
		
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
		
		//*************************************Drops Track************************************//
		
		public void DropTrack()
		{			
			TrackManagement.DropTrack.DropTrack.Start();
		}
		
		//***************************Validates Track is Dropped*******************************//
		
		public void Validate_DropTrack()
		{
			Duration OrigDur = repo.FormTacViewC2.PictureTrackInfo.SearchTimeout;
			repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = 8000;

			Report.Info("Validating Track #" + TrackNum + " was dropped");
	
			bool result = Validate.NotExists(repo.FormTacViewC2.PictureTrackInfo, Validate.DefaultMessage, false);
			
			if (result == true)
			{
				Report.Success("Successfully dropped track #" + TrackNum);
			}
			else
			{
				Report.Debug("Track #" + TrackNum + " failed to drop within 8 seconds, proceeding to next track creation.");
				Report.Screenshot();				
			}
			
			repo.FormTacViewC2.PictureTrackInfo.SearchTimeout = OrigDur;
		}				
		
		//*****************************Zooms Out to Locate Track******************************//
				
		public void Zoom500()
		{
			if (ZoomFlag == true)
			{
				Report.Info("Mouse Left Click item 'FormTacViewC2.ButtonSet_Range_to_500_km' at Center.");
				repo.FormTacViewC2.ButtonSet_Range_to_500_km.Click();
				Report.Info("Mouse Left Click item 'FormTacViewC2.Button_Center_on_Own_Site' at Center.");
				repo.FormTacViewC2.Button_Center_on_Own_Site.Click();
				ZoomFlag = false;
			}
		}
		
		//**************************************************************************************//
		//***************************Ranorex Generated Default Method***************************//
		//**************************************************************************************//		

		static ValidateWOT()
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

        public void Mouse_Click_ButtonCLOSE1()
        {
            // Your code goes here. Code inside this method will not be changed by the code generator.
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__Land_Point_Track_TN.ButtonCLOSE' at 7;10.", repo.FormMain__Land_Point_Track_TN.ButtonCLOSEInfo, new RecordItemIndex(-1));
            repo.FormMain__Land_Point_Track_TN.ButtonCLOSE.Click("7;10");
        }
	}
}