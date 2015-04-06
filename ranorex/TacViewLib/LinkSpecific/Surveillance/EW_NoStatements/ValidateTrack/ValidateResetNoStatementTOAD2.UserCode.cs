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

namespace TacViewLib.LinkSpecific.Surveillance.EW_NoStatements.ValidateTrack
{
	//************************************************************************************//
	//*******************************Variable Definitions*********************************//
	//************************************************************************************//
	
	public partial class ValidateResetNoStatementTOAD2
	{
		public static string Plat;
		public static string Act;
		public static string Stype;
		static ValidateResetNoStatementTOAD2()
		{
			//Your recording specific initialization code goes here.
		}

		//************************************************************************************//
		//**************************Validates Platform RESET.*********************************//
		//************************************************************************************//
		
		public void Validate_ListItemPlatform1()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Validating Platform = RESET TO NO STATEMENT");
			Validate.Attribute(repo.FormMain__EW_TN.ListItemPlatformInfo, "AccessibleValue", "RESET TO NO STATEMENT", Validate.DefaultMessage, false);
		}

		//************************************************************************************//
		//****************************Validates Activity RESET********************************//
		//************************************************************************************//
		
		public void Validate_ListItemActivity1()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Validating Activity = RESET TO NO STATEMENT");
			Validate.Attribute(repo.FormMain__EW_TN.ListItemActivityInfo, "AccessibleValue", "RESET TO NO STATEMENT", Validate.DefaultMessage, false);
		}

		//************************************************************************************//
		//***************************Validates Specific Type RESET****************************//
		//************************************************************************************//
		
		public void Validate_ListItemStype1()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Validating Specific Type = RESET TO NO STATEMENT");
			Validate.Attribute(repo.FormMain__EW_TN.ListItemStypeInfo, "AccessibleValue", "RESET TO NO STATEMENT", Validate.DefaultMessage, false);
		}
		
		//************************************************************************************//
		//****************************Validates Platform N.S.*********************************//
		//************************************************************************************//
		
		public void Validate_ListItemPlatform2()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Validating Platform = N.S.");
			Validate.Attribute(repo.FormMain__EW_TN.ListItemPlatformInfo, "AccessibleValue", "N.S.", Validate.DefaultMessage, false);
		}

		//************************************************************************************//
		//****************************Validates Activity N.S.*********************************//
		//************************************************************************************//
		
		public void Validate_ListItemActivity2()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Validating Activity = N.S.");
			Validate.Attribute(repo.FormMain__EW_TN.ListItemActivityInfo, "AccessibleValue", "N.S.", Validate.DefaultMessage, false);
		}

		//************************************************************************************//
		//*************************Validates Specific Type N.S.*******************************//
		//************************************************************************************//
		
		public void Validate_ListItemStype2()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Validating Specific Type = N.S.");
			Validate.Attribute(repo.FormMain__EW_TN.ListItemStypeInfo, "AccessibleValue", "N.S.", Validate.DefaultMessage, false);
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

	}
}