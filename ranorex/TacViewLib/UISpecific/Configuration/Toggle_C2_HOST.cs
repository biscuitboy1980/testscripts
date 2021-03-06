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

namespace TacViewLib.UISpecific.Configuration
{
	/// <summary>
	/// The Toggle_C2_HOST recording.
	/// </summary>
	public partial class Toggle_C2_HOST
	{
		public static TacViewLib.TacViewLibRepositoryConfiguration repo = TacViewLib.TacViewLibRepositoryConfiguration.Instance;

		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "2.3.1")]
		public static void Start()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;

			Report.Info("Mouse Left Click item 'TacView_Windows.HostInterfaceControl' at 48;12.");
			repo.TacView_Windows.HostInterfaceControl.Click("48;12");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'TacView_Windows.TOAD_Status_CheckBox' at 9;8.");
			repo.TacView_Windows.TOAD_Status_CheckBox.Click("9;8", 196);
			Delay.Milliseconds(50);
			Delay.Milliseconds(3000, false);
			Report.Info("Validating AttributeEqual (Text='ON') on item 'TacView_Windows.TOAD_Status_CheckBox'.");
			Validate.Attribute(repo.TacView_Windows.TOAD_Status_CheckBoxInfo, "Text", "ON");
			Delay.Milliseconds(100);
		}

#region Image Feature Data
#endregion
	}
}
