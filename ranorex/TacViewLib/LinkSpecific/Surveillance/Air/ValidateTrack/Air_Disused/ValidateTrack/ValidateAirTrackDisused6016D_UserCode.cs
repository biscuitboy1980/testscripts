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

namespace TacViewLib.LinkSpecific.Surveillance.Air.ValidateTrack.Air_Disused.ValidateTrack
{
	/// <summary>
	/// The ValidateTrack recording.
	/// </summary>
	
	//************************************************************************************//
	//**************Default values to validate for track if csv file not present**********//
	//************************************************************************************//
	
	public partial class ValidateAirTrackDisused6016D
	{
		public static string ID;
		public static bool PlatFlag;
		public static bool ActFlag;
		public static bool StypeFlag;		
		
		//************************************************************************************//
		//************************Validates Identity Value is N.S.****************************//
		//************************************************************************************//
				
		public void ValidateID()
		{
			Report.Info("Validating AttributeEqual (Text='(ID)') on item 'FormMain__Air_TN.ListItemIdentity'.");
			Report.Info("Value Entered =" + ID);
			Validate.Attribute(repo.FormMain__Air_TN.ListItemIdentityInfo, "AccessibleValue", ID, Validate.DefaultMessage, false);
		}
		
		//************************************************************************************//
		//**********************Validates Platform Value is N.S.******************************//
		//************************************************************************************//
		
		public void ValidatePlat()
		{
			if (!PlatFlag)
			{			
			Report.Info("Validating AttributeEqual (Text='Platform') on item 'FormMain__Air_TN.ListItemPlatform'.");
			Report.Info("Value Entered =" + Plat);
			Validate.Attribute(repo.FormMain__Air_TN.ListItemPlatformInfo, "AccessibleValue", "N.S.", Validate.DefaultMessage, false);
			}
			else
			{
			Report.Info("Validating AttributeEqual (Text='Platform') on item 'FormMain__Air_TN.ListItemPlatform'.");
			Report.Info("Value Entered =" + Plat);				
			Report.Error(Plat + " Does Not Exist for Platform Field, Selecting 1st Item Available");	
			}
		}
		
		//************************************************************************************//
		//***********************Validates Activity Value is N.S.*****************************//
		//************************************************************************************//
		
		public void ValidateAct()
		{
			if (!ActFlag)
			{			
			Report.Info("Validating AttributeEqual (Text='Activity') on item 'FormMain__Air_TN.ListItemActivity'.");
			Report.Info("Value Entered =" + Act);
			Validate.Attribute(repo.FormMain__Air_TN.ListItemActivityInfo, "AccessibleValue", "N.S.", Validate.DefaultMessage, false);
			}
			else
			{
			Report.Info("Validating AttributeEqual (Text='Activity') on item 'FormMain__Air_TN.ListItemActivity'.");
			Report.Info("Value Entered =" + Act);					
			Report.Error(Act + " Does Not Exist for Activity Field, Selecting 1st Item Available");	
			}
		}		
		
		//************************************************************************************//
		//************************Validates Specific Type Value is N.S.***********************//
		//************************************************************************************//
		
		public void ValidateStype()
		{
			if (!StypeFlag)
			{
			Report.Info("Validating AttributeEqual (Text='Specific Type') on item 'FormMain__Air_TN.ListItemSpecificType.");
			Report.Info("Value Entered =" + Stype);			
			Validate.Attribute(repo.FormMain__Air_TN.ListItemStypeInfo, "AccessibleValue", "N.S.", Validate.DefaultMessage, false);
			}
			else
			{
			Report.Info("Validating AttributeEqual (Text='Specific Type') on item 'FormMain__Air_TN.ListItemSpecificType.");
			Report.Info("Value Entered =" + Stype);			
			Report.Error(Stype + " Does Not Exist for Specifc Type Field, Selecting 1st Item Available");	
			}
		}

		static ValidateAirTrackDisused6016D()
		{
			//Your recording specific initialization code goes here.
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

	}
}
