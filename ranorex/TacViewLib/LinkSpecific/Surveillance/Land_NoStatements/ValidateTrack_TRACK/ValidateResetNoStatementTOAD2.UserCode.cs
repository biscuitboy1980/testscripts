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

namespace TacViewLib.LinkSpecific.Surveillance.Land_NoStatements.ValidateTrack_TRACK
{
	/// <summary>
	/// The ValidateTrack recording.
	/// </summary>
	public partial class ValidateResetNoStatementTOAD2
	{
		static ValidateResetNoStatementTOAD2()
		{
			//Your recording specific initialization code goes here.
		}

		public void Validate_ListItemPlatform1()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Validating Specific Type = RESET TO NO STATEMENT");
			Validate.Attribute(repo.FormMain__Land_Point_Track_TN.ListItemPlatformInfo, "AccessibleValue", "RESET TO NO STATEMENT", Validate.DefaultMessage, false);
		}

		public void Validate_ListItemActivity1()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Validating Specific Type = RESET TO NO STATEMENT");
			Validate.Attribute(repo.FormMain__Land_Point_Track_TN.ListItemActivityInfo, "AccessibleValue", "RESET TO NO STATEMENT", Validate.DefaultMessage, false);
		}

		public void Validate_ListItemStype1()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Validating Specific Type = RESET TO NO STATEMENT");
			Validate.Attribute(repo.FormMain__Land_Point_Track_TN.ListItemSpecific_TypeInfo, "AccessibleValue", "RESET TO NO STATEMENT", Validate.DefaultMessage, false);
		}
		
		public void Validate_ListItemPlatform2()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Validating Specific Type = N.S.");
			Validate.Attribute(repo.FormMain__Land_Point_Track_TN.ListItemPlatformInfo, "AccessibleValue", "N.S.", Validate.DefaultMessage, false);
		}

		public void Validate_ListItemActivity2()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Validating Specific Type = N.S.");
			Validate.Attribute(repo.FormMain__Land_Point_Track_TN.ListItemActivityInfo, "AccessibleValue", "N.S.", Validate.DefaultMessage, false);
		}

		public void Validate_ListItemStype2()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Validating Specific Type = N.S.");
			Validate.Attribute(repo.FormMain__Land_Point_Track_TN.ListItemSpecific_TypeInfo, "AccessibleValue", "N.S.", Validate.DefaultMessage, false);
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

	}
}
