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
	/// The EnterTOAD_IP recording.
	/// </summary>
	public partial class EnterTOAD_IP
	{
		public static TacViewLib.TacViewLibRepositoryConfiguration repo = TacViewLib.TacViewLibRepositoryConfiguration.Instance;

		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "2.3.3")]
		public static void Start()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;

			Report.Info("Mouse Left Click item 'TacView_Windows.HostInterfaceControl' at 114;9.");
			repo.TacView_Windows.HostInterfaceControl.Click("114;9");
			Delay.Milliseconds(1500);
			Report.Info("Mouse Right Click item 'FormTacViewC2.TOADInterface' at 54;11.");
			repo.FormTacViewC2.TOADInterface.Click(MouseButtons.Right, "54;11");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormRealView.MenuItemInterface_Properties' at 57;12.");
			repo.FormRealView.MenuItemInterface_Properties.Click("57;12");
			Delay.Milliseconds(3120);
			Report.Info("Mouse Left Click item 'TOAD_Interface_Properties.Interface_Properties_Form' at 208;15.");
			repo.TOAD_Interface_Properties.Interface_Properties_Form.Click("208;15");
			Delay.Milliseconds(800);
			Report.Info("Mouse Left Click item 'TOAD_Interface_Properties.Transparency' at 6;9.");
			repo.TOAD_Interface_Properties.Transparency.Click("6;9");
			Delay.Milliseconds(1110);
			Report.Info("Mouse Left Click item 'TOAD_Interface_Properties.Connection_Settings_Tab' at 58;8.");
			repo.TOAD_Interface_Properties.Connection_Settings_Tab.Click("58;8");
			Delay.Milliseconds(1290);
			Report.Info("Mouse Left Click item 'TOAD_Connection_Settings.ToolBar.Edit' at 21;21.");
			repo.TOAD_Connection_Settings.ToolBar.Edit.Click("21;21");
			Delay.Milliseconds(1800);
			Report.Info("Mouse Left Click item 'TOAD_Connection_Settings.Server_Address' at 87;6.");
			repo.TOAD_Connection_Settings.Server_Address.Click("87;6");
			Delay.Milliseconds(1190);
			Report.Info("Key sequence '172.16.98.159'.");
			Keyboard.Press("172.16.98.159");
			Delay.Milliseconds(3130);
			Report.Info("Key sequence '{Return}{Return}{Return}{Return}'.");
			Keyboard.Press("{Return}{Return}{Return}{Return}");
			Delay.Milliseconds(4240);
			Report.Info("Mouse Left Click item 'TOAD_Connection_Settings.Interface_Properties_Tab' at 65;9.");
			repo.TOAD_Connection_Settings.Interface_Properties_Tab.Click("65;9", 180);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'TOAD_Interface_Properties.Close' at 7;7.");
			repo.TOAD_Interface_Properties.Close.Click("7;7");
			Delay.Milliseconds(750);
		}

#region Image Feature Data
#endregion
	}
}
