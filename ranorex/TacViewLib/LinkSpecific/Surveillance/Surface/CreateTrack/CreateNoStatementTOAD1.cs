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

namespace TacViewLib.LinkSpecific.Surveillance.Surface.CreateTrack
{
	/// <summary>
	/// The CreateNoStatementTOAD1 recording.
	/// </summary>
	public partial class CreateNoStatementTOAD1
	{
		public static TacViewLib.TacViewLibRepository repo = TacViewLib.TacViewLibRepository.Instance;

		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "2.2.2")]
		public static void Start()
		{
			Mouse.DefaultMoveTime = 150;
			Keyboard.DefaultKeyPressTime = 10;
			Delay.SpeedFactor = 1.0;

			CreateNoStatementTOAD1.ValidateDropTrack();
			Delay.Milliseconds(0);
			Report.Info("Mouse Right Click item 'FormTacViewC2____map__Pacifi1.ContainerRvView' at 507;278.");
			repo.FormTacViewC2____map__Pacifi1.ContainerRvView.Click(MouseButtons.Right, "507;278", 300);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormRealView.MenuItemCreate_Track' at 54;11.");
			repo.FormRealView.MenuItemCreate_Track.Click("54;11", 300);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormCreate_Track1.MenuItemTOAD1' at 36;8.");
			repo.FormCreate_Track1.MenuItemTOAD1.Click("36;8", 300);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTOAD_TrackHash3012.MenuItemSurface' at 59;11.");
			repo.FormTOAD_TrackHash3012.MenuItemSurface.Click("59;11", 300);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormMain__Surface_TN___CREAT.ListItemIdentity' at 22;6.");
			repo.FormMain__Surface_TN___CREAT.ListItemIdentity.Click("22;6", 300);
			Delay.Milliseconds(0);
			Report.Info("Key 'Tab' Press.");
			Keyboard.Press(Keys.Tab, Keyboard.DefaultScanCode, 100, 1, true);
			Delay.Milliseconds(150);
			Report.Info("Key sequence 'Pending'.");
			Keyboard.Press("Pending", 100);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormMain__Surface_TN___CREAT.ListItemPlatform' at 37;7.");
			repo.FormMain__Surface_TN___CREAT.ListItemPlatform.Click("37;7", 300);
			Delay.Milliseconds(0);
			Report.Info("Key 'Tab' Press.");
			Keyboard.Press(Keys.Tab, 15, 100, 1, false);
			Delay.Milliseconds(150);
			Report.Info("Key sequence 'Intelligence Collector'.");
			Keyboard.Press("Intelligence Collector", 100);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormMain__Surface_TN___CREAT.ListItemActivity' at 53;13.");
			repo.FormMain__Surface_TN___CREAT.ListItemActivity.Click("53;13", 300);
			Delay.Milliseconds(0);
			Report.Info("Key 'Tab' Press.");
			Keyboard.Press(Keys.Tab, 15, 100, 1, false);
			Delay.Milliseconds(150);
			Report.Info("Key sequence 'Towing'.");
			Keyboard.Press("Towing", 100);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormMain__Surface_TN___CREAT.ListItemSpecific_Type' at 75;8.");
			repo.FormMain__Surface_TN___CREAT.ListItemSpecific_Type.Click("75;8", 300);
			Delay.Milliseconds(0);
			Report.Info("Key 'Tab' Press.");
			Keyboard.Press(Keys.Tab, 15, 100, 1, false);
			Delay.Milliseconds(150);
			Report.Info("Key sequence 'CV GENERAL'.");
			Keyboard.Press("CV GENERAL", 100);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormMain__Surface_TN___CREAT.ButtonSave' at 12;21.");
			repo.FormMain__Surface_TN___CREAT.ButtonSave.Click("12;21", 300);
			Delay.Milliseconds(0);
			Report.Info("Mouse Right Click item 'FormTacViewC2____map__Pacifi1.PictureTrack1' at 12;15.");
			repo.FormTacViewC2____map__Pacifi1.PictureTrack1.Click(MouseButtons.Right, "12;15", 300);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormRealView1.MenuItemTOAD' at 47;6.");
			repo.FormRealView1.MenuItemTOAD.Click("47;6", 300);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTOAD_TrackHash3012.MenuItemEdit_Track' at 112;9.");
			repo.FormTOAD_TrackHash3012.MenuItemEdit_Track.Click("112;9", 300);
			Delay.Milliseconds(800);
			Report.Info("Mouse Left Click item 'FormMain__Surface_TN.ListItemSpecific_Type1' at 44;8.");
			repo.FormMain__Surface_TN.ListItemSpecific_Type1.Click("44;8", 300);
			Delay.Milliseconds(0);
			Report.Info("Key 'Tab' Press.");
			Keyboard.Press(Keys.Tab, 15, 100, 1, false);
			Delay.Milliseconds(150);
			Report.Info("Key sequence 'RESET TO NO STATEMENT'.");
			Keyboard.Press("RESET TO NO STATEMENT", 100);
			Delay.Milliseconds(0);
			Report.Info("Key 'Tab' Press.");
			Keyboard.Press(Keys.Tab, 15, 100, 1, false);
			Delay.Milliseconds(150);
			Report.Info("Mouse Left Click item 'FormMain__Surface_TN.ButtonSave' at 13;16.");
			repo.FormMain__Surface_TN.ButtonSave.Click("13;16", 300);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormMain__Surface_TN.ButtonCLOSE' at 10;11.");
			repo.FormMain__Surface_TN.ButtonCLOSE.Click("10;11", 300);
			Delay.Milliseconds(0);
		}

#region Image Feature Data
#endregion
	}
}

