﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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

namespace TacViewLib.UISpecific.ATOUpgrade.ATOMode3Codes_Query_Test
{
	/// <summary>
	/// The ValidateQuery recording.
	/// </summary>
	public partial class ValidateQuery
	{
		public TacViewLib.ATOUpgradeRepository repo = TacViewLib.ATOUpgradeRepository.Instance;

		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "2.3.8")]
		public void Start()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;

			Report.Info("Validating AttributeEqual (AccessibleValue='WAKEN71') on item 'FormRealView1.Row0.CellATO_Call_Sign'.");
			Validate.Attribute(repo.FormRealView1.Row0.CellATO_Call_SignInfo, "AccessibleValue", "WAKEN71", Validate.DefaultMessage, false);
			Delay.Milliseconds(100);
			Report.Info("Validating Exists on item 'FormRealView1.Row0.CellMissionKey'.");
			Validate.Exists(repo.FormRealView1.Row0.CellMissionKeyInfo);
			Delay.Milliseconds(100);
			Report.Info("Validating AttributeEqual (AccessibleValue='') on item 'FormRealView1.Row0.CellMode1Code'.");
			Validate.Attribute(repo.FormRealView1.Row0.CellMode1CodeInfo, "AccessibleValue", "", Validate.DefaultMessage, false);
			Delay.Milliseconds(100);
			Report.Info("Validating AttributeEqual (AccessibleValue='4565') on item 'FormRealView1.Row0.CellMode_2_Code'.");
			Validate.Attribute(repo.FormRealView1.Row0.CellMode_2_CodeInfo, "AccessibleValue", "4565", Validate.DefaultMessage, false);
			Delay.Milliseconds(100);
			Report.Info("Validating AttributeEqual (AccessibleValue='4566') on item 'FormRealView1.Row0.CellMode_3_Code'.");
			Validate.Attribute(repo.FormRealView1.Row0.CellMode_3_CodeInfo, "AccessibleValue", "4566", Validate.DefaultMessage, false);
			Delay.Milliseconds(100);
			Report.Info("Validating AttributeEqual (AccessibleValue='') on item 'FormRealView1.Row0.CellJUAddress'.");
			Validate.Attribute(repo.FormRealView1.Row0.CellJUAddressInfo, "AccessibleValue", "", Validate.DefaultMessage, false);
			Delay.Milliseconds(100);
			Report.Info("Validating AttributeEqual (AccessibleValue='') on item 'FormRealView1.Row0.CellLink_16_Call_Sign'.");
			Validate.Attribute(repo.FormRealView1.Row0.CellLink_16_Call_SignInfo, "AccessibleValue", "");
			Delay.Milliseconds(100);
			Report.Info("Validating AttributeEqual (AccessibleValue='3') on item 'FormRealView1.Row0.CellNumber_of_Aircraft'.");
			Validate.Attribute(repo.FormRealView1.Row0.CellNumber_of_AircraftInfo, "AccessibleValue", "3", Validate.DefaultMessage, false);
			Delay.Milliseconds(100);
			Report.Info("Validating AttributeEqual (AccessibleValue='TEST01') on item 'FormRealView1.Row0.CellPrimary_Config_Code'.");
			Validate.Attribute(repo.FormRealView1.Row0.CellPrimary_Config_CodeInfo, "AccessibleValue", "TEST01", Validate.DefaultMessage, false);
			Delay.Milliseconds(100);
			Report.Info("Validating AttributeEqual (AccessibleValue='TEST02') on item 'FormRealView1.Row0.CellSecondary_Config_Code'.");
			Validate.Attribute(repo.FormRealView1.Row0.CellSecondary_Config_CodeInfo, "AccessibleValue", "TEST02", Validate.DefaultMessage, false);
			Delay.Milliseconds(100);
			Report.Info("Validating AttributeEqual (AccessibleValue='') on item 'FormRealView1.Row0.CellTACAN_Channel'.");
			Validate.Attribute(repo.FormRealView1.Row0.CellTACAN_ChannelInfo, "AccessibleValue", "", Validate.DefaultMessage, false);
			Delay.Milliseconds(100);
			Report.Info("Validating AttributeEqual (AccessibleValue='OTHAC:UH80H') on item 'FormRealView1.Row0.CellAC_Type'.");
			Validate.Attribute(repo.FormRealView1.Row0.CellAC_TypeInfo, "AccessibleValue", "OTHAC:UH80H", Validate.DefaultMessage, false);
			Delay.Milliseconds(100);
			Report.Info("Validating Exists on item 'FormRealView1.Row0.CellPkey'.");
			Validate.Exists(repo.FormRealView1.Row0.CellPkeyInfo, Validate.DefaultMessage, false);
			Delay.Milliseconds(4120);
			Report.Info("Mouse Left Click item 'FormRealView1.ButtonCLOSE' at Center.");
			repo.FormRealView1.ButtonCLOSE.Click();
			Delay.Milliseconds(0);
		}

#region Image Feature Data
#endregion
	}
}