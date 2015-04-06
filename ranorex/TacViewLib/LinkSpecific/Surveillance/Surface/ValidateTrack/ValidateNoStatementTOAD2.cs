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

namespace TacViewLib.LinkSpecific.Surveillance.Surface.ValidateTrack
{
	/// <summary>
	/// The ValidateNoStatementTOAD2 recording.
	/// </summary>
	public partial class ValidateNoStatementTOAD2
	{
		public static TacViewLib.TacViewLibRepository repo = TacViewLib.TacViewLibRepository.Instance;

		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "2.2.2")]
		public static void Start()
		{
			Mouse.DefaultMoveTime = 150;
			Keyboard.DefaultKeyPressTime = 10;
			Delay.SpeedFactor = 1.0;

			Delay.Milliseconds(3000, false);
			Report.Info("Mouse Right Click item 'FormTacViewC2____map__Pacifi1.PictureTrack1' at Center.");
			repo.FormTacViewC2____map__Pacifi1.PictureTrack1.Click(MouseButtons.Right, 300);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormRealView1.MenuItemTOAD2' at 63;9.");
			repo.FormRealView1.MenuItemTOAD2.Click("63;9", 300);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTOAD2_TrackHash3012.MenuItemTrack_Properties' at 103;14.");
			repo.FormTOAD2_TrackHash3012.MenuItemTrack_Properties.Click("103;14", 300);
			Delay.Milliseconds(0);
			Report.Info("Validating AttributeEqual (Text='Specific Type') on item 'FormMain__Surface_TN.ListItemSpecific_Type'.");
			Validate.Attribute(repo.FormMain__Surface_TN.ListItemSpecific_TypeInfo, "Text", "Specific Type");
			Delay.Milliseconds(100);
			Report.Info("Validating AttributeEqual (AccessibleValue='RESET TO NO STATEMENT') on item 'FormMain__Surface_TN.ListItemSpecific_Type'.");
			Validate.Attribute(repo.FormMain__Surface_TN.ListItemSpecific_TypeInfo, "AccessibleValue", "RESET TO NO STATEMENT");
			Delay.Milliseconds(100);
			Report.Info("Mouse Left Click item 'FormMain__Surface_TN.ButtonCLOSE' at 6;7.");
			repo.FormMain__Surface_TN.ButtonCLOSE.Click("6;7", 300);
			Delay.Milliseconds(0);
			Report.Info("Mouse Right Click item 'FormTacViewC2____map__Pacifi1.PictureTrack1' at Center.");
			repo.FormTacViewC2____map__Pacifi1.PictureTrack1.Click(MouseButtons.Right, 300);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormRealView1.MenuItemTOAD' at Center.");
			repo.FormRealView1.MenuItemTOAD.Click(300);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTOAD_TrackHash3012.MenuItemDrop_Track' at 116;14.");
			repo.FormTOAD_TrackHash3012.MenuItemDrop_Track.Click("116;14", 300);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormRealView2.ButtonYes1' at 20;8.");
			repo.FormRealView2.ButtonYes1.Click("20;8", 300);
			Delay.Milliseconds(0);
		}

#region Image Feature Data
#endregion
	}
}

