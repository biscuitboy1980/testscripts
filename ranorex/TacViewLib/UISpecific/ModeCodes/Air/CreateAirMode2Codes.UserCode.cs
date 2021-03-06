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

namespace TacViewLib.UISpecific.ModeCodes.Air
{
	/// <summary>
	/// The CreateTrack recording.
	/// </summary>
	

	public partial class CreateAirMode2Codes
	{
		
		public int TCount;
		public string M2Value;
		public string trknum;	
		
		//************************************************************************************//
		//*********************************Gets Track Number**********************************//
		//************************************************************************************//
		
		public void GetTrackNum()			
		{			
		    TCount++;
		    Accessible pic1 = @"/form[@title~'^TacViewC2\ \ \ \(map:\ .*']/element/container/picture[@accessiblevalue='Track']" + "[" + TCount + "]";
   			Accessible accElement = new Accessible(pic1);  
   			trknum = accElement.Name;
   			Report.Info("Track Number = " + trknum);
   			ValidateAirMode2Codes.TrackNum = trknum;   			
		}	

		//************************************************************************************//
		//**************************Enters Random Mode 2 Value********************************//
		//************************************************************************************//
		
		public void Mode2val()
		{
			repo.FormMainCreate.ListItemMode_2_Code.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);			
			string a = CommonUtilLib.Util.Random(1, 4095);
			string b = CommonUtilLib.Util.DecimalToBase(Convert.ToInt32(a), 8);
			Keyboard.Press(b);
			Accessible accElement = new Accessible(repo.FormMainCreate.ListItemMode_2_Code);  
   			M2Value = b;
   			Report.Info("Mode 2 Entered = " + M2Value);
   			Keyboard.Press(Keys.Tab);	   			
		}		

		//************************************************************************************//
		//*************************Enters Duplicate Mode 2 Value******************************//
		//************************************************************************************//
		
		public void DupMode2val()
		{
			repo.FormMainCreate.ListItemMode_2_Code.Click("CenterLeft");
		    Keyboard.Press(Keys.Tab);			
			Keyboard.Press(M2Value);
			Accessible accElement = new Accessible(repo.FormMainCreate.ListItemMode_2_Code);  
   			Keyboard.Press(Keys.Tab);	   			
		}		
		
		//************************************************************************************//
		//*************************Validates Duplicate Mode 2 Value***************************//
		//************************************************************************************//		
		
		public void Validate_InvalidMode2val()
		{
			Report.Info("Validating AttributeEqual (Enabled='False') on item 'FormMainCreate.ButtonSave'.");
			Validate.Attribute(repo.FormMainCreate.ButtonSaveInfo, "Enabled", "False", Validate.DefaultMessage, false);
		}	
		
		static CreateAirMode2Codes()
		{
			//Your recording specific initialization code goes here.
		}
		
		public void GetTrackCount()
		{			
			TCount = TacViewLib.UISpecific.Configuration.Common.GetTrackCount();
		}		
		
		
		public void RandCoord()
		{	
			TacViewLib.UISpecific.Configuration.Common.RandCoord();
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}