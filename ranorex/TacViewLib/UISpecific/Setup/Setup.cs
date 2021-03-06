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

namespace TacViewLib.UISpecific.Setup
{
	/// <summary>
	/// The Setup recording.
	/// </summary>
	public partial class Setup
	{
		public static TacViewLib.TacViewLibRepository repo = TacViewLib.TacViewLibRepository.Instance;

		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "2.2.2")]
		public static void Start()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;

			Report.Info("Mouse Left DoubleClick item 'DesktopExplorer.ListItemTacViewC21' at 38;30.");
			repo.DesktopExplorer.ListItemTacViewC21.DoubleClick("38;30");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormRealView2.ButtonOK1' at 37;11.");
			repo.FormRealView2.ButtonOK1.Click("37;11");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormOpen.ListItemPacificWorldMap_map1' at 77;12.");
			repo.FormOpen.ListItemPacificWorldMap_map1.Click("77;12");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormOpen.ButtonOpen1' at 50;10.");
			repo.FormOpen.ButtonOpen1.Click("50;10");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.ButtonMaximize' at 16;14.");
			repo.FormTacViewC2____map__Pacifi1.ButtonMaximize.Click("16;14");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi.MenuItemFile' at 21;11.");
			repo.FormTacViewC2____map__Pacifi.MenuItemFile.Click("21;11");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormFile.MenuItemPreferences___1' at 74;8.");
			repo.FormFile.MenuItemPreferences___1.Click("74;8");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormPreferences.TreeItemConfigurations1' at 52;13.");
			repo.FormPreferences.TreeItemConfigurations1.Click("52;13");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormPreferences.ContainerGrouping1' at 25;41.");
			repo.FormPreferences.ContainerGrouping1.Click("25;41");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormPreferences.ButtonClose1' at 11;3.");
			repo.FormPreferences.ButtonClose1.Click("11;3");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormRealView2.ButtonOK1' at 10;2.");
			repo.FormRealView2.ButtonOK1.Click("10;2");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi.ButtonClose' at 12;18.");
			repo.FormTacViewC2____map__Pacifi.ButtonClose.Click("12;18");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left DoubleClick item 'DesktopExplorer.ListItemTacViewC21' at 44;31.");
			repo.DesktopExplorer.ListItemTacViewC21.DoubleClick("44;31");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormRealView2.ButtonOK1' at 30;14.");
			repo.FormRealView2.ButtonOK1.Click("30;14");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormOpen.ListItemPacificWorldMap_map1' at 49;8.");
			repo.FormOpen.ListItemPacificWorldMap_map1.Click("49;8");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormOpen.ButtonOpen1' at 52;12.");
			repo.FormOpen.ButtonOpen1.Click("52;12");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.ButtonMaximize' at 16;17.");
			repo.FormTacViewC2____map__Pacifi1.ButtonMaximize.Click("16;17");
			Delay.Milliseconds(0);
			Report.Info("Mouse Right Click item 'FormTacViewC2____map__Pacifi1.CellInterface_0_' at 51;7.");
			repo.FormTacViewC2____map__Pacifi1.CellInterface_0_.Click(MouseButtons.Right, "51;7");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormRealView11.MenuItemInterface_Properties1' at 37;8.");
			repo.FormRealView11.MenuItemInterface_Properties1.Click("37;8");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormInterface_Properties.TabPageConnection_Settings1' at 33;15.");
			repo.FormInterface_Properties.TabPageConnection_Settings1.Click("33;15");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormConnection_Settings.ToolBarToolBar.ButtonEdit' at 23;23.");
			repo.FormConnection_Settings.ToolBarToolBar.ButtonEdit.Click("23;23");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormConnection_Settings.ContainerRealView1.ListItemServer_Address1' at 186;9.");
			repo.FormConnection_Settings.ContainerRealView1.ListItemServer_Address1.Click("186;9");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Down item 'FormConnection_Settings.ContainerRealView1.TextRealView1' at 36;8.");
			repo.FormConnection_Settings.ContainerRealView1.TextRealView1.MoveTo("36;8");
			Mouse.ButtonDown(MouseButtons.Left);
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormConnection_Settings.ContainerRealView1.TextRealView1' at 44;9.");
			repo.FormConnection_Settings.ContainerRealView1.TextRealView1.Click("44;9");
			Delay.Milliseconds(0);
			Report.Info("Key sequence '172.16.98.204'.");
			Keyboard.Press("172.16.98.204");
			Delay.Milliseconds(0);
			Report.Info("Key 'Return' Press.");
			Keyboard.Press(Keys.Return, 28, Keyboard.DefaultKeyPressTime, 1, false);
			Delay.Milliseconds(150);
			Report.Info("Mouse Left Click item 'FormConnection_Settings.ToolBarToolBar.ButtonSave' at 20;27.");
			repo.FormConnection_Settings.ToolBarToolBar.ButtonSave.Click("20;27");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormConnection_Settings.ButtonCLOSE1' at 11;12.");
			repo.FormConnection_Settings.ButtonCLOSE1.Click("11;12");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.CellStatus_0_' at 12;12.");
			repo.FormTacViewC2____map__Pacifi1.CellStatus_0_.Click("12;12");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.ButtonView_Range_Rings' at 6;14.");
			repo.FormTacViewC2____map__Pacifi1.ButtonView_Range_Rings.Click("6;14");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.ButtonSet_Range_to_200_km' at 19;13.");
			repo.FormTacViewC2____map__Pacifi1.ButtonSet_Range_to_200_km.Click("19;13");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Button_Center_on_Own_Site' at 12;7.");
			repo.FormTacViewC2____map__Pacifi1.Button_Center_on_Own_Site.Click("12;7");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.TabPageLocal_R2__0_tracks_' at 31;10.");
			repo.FormTacViewC2____map__Pacifi1.TabPageLocal_R2__0_tracks_.Click("31;10");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.ToolBarToolBar' at 6;52.");
			repo.FormTacViewC2____map__Pacifi1.ToolBarToolBar.Click("6;52");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 9;59.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("9;59");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 46;90.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("46;90");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 47;139.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("47;139");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 45;154.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("45;154");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 46;187.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("46;187");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 46;218.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("46;218");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 48;252.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("48;252");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 47;278.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("47;278");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 46;297.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("46;297");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 44;315.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("44;315");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 46;329.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("46;329");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 46;347.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("46;347");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 44;361.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("44;361");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 47;379.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("47;379");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 47;398.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("47;398");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 44;410.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("44;410");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.Tree10181' at 45;427.");
			repo.FormTacViewC2____map__Pacifi1.Tree10181.Click("45;427");
			Delay.Milliseconds(0);
			Report.Info("Mouse Left Click item 'FormTacViewC2____map__Pacifi1.ElementTabbedContainerName' at 121;7.");
			repo.FormTacViewC2____map__Pacifi1.ElementTabbedContainerName.Click("121;7");
			Delay.Milliseconds(0);
		}

#region Image Feature Data
#endregion
	}
}

