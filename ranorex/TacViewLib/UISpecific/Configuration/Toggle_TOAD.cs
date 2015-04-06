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
	/// The Toggle_TOAD recording.
	/// </summary>
	public partial class Toggle_TOAD
	{
		public static TacViewLib.TacViewLibRepositoryConfiguration repo = TacViewLib.TacViewLibRepositoryConfiguration.Instance;

		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "2.3.3")]
		public static void Start()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;

			Report.Info("Mouse Left Click item 'TacView_Windows.HostInterfaceControl' at 75;12.");
			repo.TacView_Windows.HostInterfaceControl.Click("75;12");
			Delay.Milliseconds(0);
			Report.Info("Validating AttributeEqual (Text='TOAD') on item 'FormTacViewC2.TOADInterface'.");
			Validate.Attribute(repo.FormTacViewC2.TOADInterfaceInfo, "Text", "TOAD");
			Delay.Milliseconds(100);
			Report.Info("Mouse Left Click item 'FormTacViewC2.TableCCustomReportControl2.CellStatus' at 8;9.");
			repo.FormTacViewC2.TableCCustomReportControl2.CellStatus.Click("8;9", 164);
			Delay.Milliseconds(80);
			Delay.Milliseconds(2000, false);
			Report.Info("Validating AttributeEqual (Text='ON') on item 'FormTacViewC2.TableCCustomReportControl2.CellStatus'.");
			Validate.Attribute(repo.FormTacViewC2.TableCCustomReportControl2.CellStatusInfo, "Text", "ON");
			Delay.Milliseconds(100);
		}

#region Image Feature Data
#endregion
	}
}