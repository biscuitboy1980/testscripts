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
	/// The CreateQuery recording.
	/// </summary>
	public partial class CreateQuery
	{
		public TacViewLib.ATOUpgradeRepository repo = TacViewLib.ATOUpgradeRepository.Instance;

		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "2.3.8")]
		public void Start()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;

			Report.Info("Mouse Left Click item 'FormTacViewC2.MenuItemATO' at Center.");
			repo.FormTacViewC2.MenuItemATO.Click();
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormATO.MenuItemRun_User_Query' at CenterLeft.");
			repo.FormATO.MenuItemRun_User_Query.Click(Location.CenterLeft);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormRun_User_Query.Text1001' at Center.");
			repo.FormRun_User_Query.Text1001.Click();
			Delay.Milliseconds(0);
			CreateQuery.SelectQuery();
			Delay.Milliseconds(150);
			Report.Info("Key 'Tab' Press.");
			Keyboard.Press(Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
			Delay.Milliseconds(50);
			Report.Info("Key sequence '4565'.");
			Keyboard.Press("4565");
			Delay.Milliseconds(0);
			Report.Info("Key 'Tab' Press.");
			Keyboard.Press(Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
			Delay.Milliseconds(0);
			Report.Info("Key sequence '4567'.");
			Keyboard.Press("4567");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormRun_User_Query.ButtonOK' at Center.");
			repo.FormRun_User_Query.ButtonOK.Click();
			Delay.Milliseconds(0);
		}

#region Image Feature Data
#endregion
	}
}
