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
	/// The ToggleTOAD2 recording.
	/// </summary>
	public partial class ToggleTOAD2
	{
		public static TacViewLib.TacViewLibRepositoryConfiguration repo = TacViewLib.TacViewLibRepositoryConfiguration.Instance;

		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "2.3.4")]
		public static void Start()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;

			Report.Info("Mouse Left Click item 'FormTacViewC2.TOAD2_OFF' at CenterLeft.");
			repo.FormTacViewC2.TOAD2_OFF.Click(Location.CenterLeft);
			Delay.Milliseconds(0);
			Delay.Milliseconds(2000, false);
			Report.Info("Validating AttributeEqual (Text='ON') on item 'FormTacViewC2.TOAD2_ON'.");
			Validate.Attribute(repo.FormTacViewC2.TOAD2_ONInfo, "Text", "ON");
			Delay.Milliseconds(250);
		}

#region Image Feature Data
#endregion
	}
}