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
using Ranorex.Core.Testing;

namespace TacViewLib.UISpecific.CriticalAreas
{
	/// <summary>
	/// The SafeCorridorDrag recording.
	/// </summary>
	[TestModule("cd327900-342c-477e-9fb6-bbda75ccf6fa", ModuleType.Recording, 1)]
	public partial class SafeCorridorDrag : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.TacViewLibRepositoryOverlays repository.
		/// </summary>
		public static TacViewLib.TacViewLibRepositoryOverlays repo = TacViewLib.TacViewLibRepositoryOverlays.Instance;

		static SafeCorridorDrag instance = new SafeCorridorDrag();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public SafeCorridorDrag()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static SafeCorridorDrag Instance
		{
			get { return instance; }
		}

#region Variables

#endregion

		/// <summary>
		/// Starts the replay of the static recording <see cref="Instance"/>.
		/// </summary>
		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "3.0.0")]
		public static void Start()
		{
			TestModuleRunner.Run(Instance);
		}

		/// <summary>
		/// Performs the playback of actions in this recording.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "3.0.0")]
		void ITestModule.Run()
		{
			Mouse.DefaultMoveTime = 150;
			Keyboard.DefaultKeyPressTime = 25;
			Delay.SpeedFactor = 1.0;

			Init();

			Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='OPER') on item 'FormTacViewC2____map__Defaul.STATUS_ONE'.", repo.FormTacViewC2____map__Defaul.STATUS_ONEInfo, new RecordItemIndex(0));
			Validate.Attribute(repo.FormTacViewC2____map__Defaul.STATUS_ONEInfo, "Text", "OPER");
			Delay.Milliseconds(150);
			
			TurnOffInterfaceTwo();
			Delay.Milliseconds(150);
			
			TurnOnEventHistory();
			Delay.Milliseconds(150);
			
			ClearAllEventsInEventHistory();
			Delay.Milliseconds(150);
			
			EnableOverlayName();
			Delay.Milliseconds(150);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.MenuItemFile' at Center.", repo.FormTacViewC2.MenuItemFileInfo, new RecordItemIndex(5));
			repo.FormTacViewC2.MenuItemFile.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormFile.MenuItemImport_Overlays' at Center.", repo.FormFile.MenuItemImport_OverlaysInfo, new RecordItemIndex(6));
			repo.FormFile.MenuItemImport_Overlays.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormImport_Overlays.Text_OverlayFileName' at Center.", repo.FormImport_Overlays.Text_OverlayFileNameInfo, new RecordItemIndex(7));
			repo.FormImport_Overlays.Text_OverlayFileName.Click();
			Delay.Milliseconds(0);
			
			KeySafeCorridorFile();
			Delay.Milliseconds(150);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormImport_Overlays_From_Fil.ButtonOK' at Center.", repo.FormImport_Overlays_From_Fil.ButtonOKInfo, new RecordItemIndex(9));
			repo.FormImport_Overlays_From_Fil.ButtonOK.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'RealViewDialog.TextOverlay_import_completed'.", repo.RealViewDialog.TextOverlay_import_completedInfo, new RecordItemIndex(10));
			Validate.Exists(repo.RealViewDialog.TextOverlay_import_completedInfo);
			Delay.Milliseconds(150);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RealViewDialog.ButtonOK' at Center.", repo.RealViewDialog.ButtonOKInfo, new RecordItemIndex(11));
			repo.RealViewDialog.ButtonOK.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.ButtonZoom_Out_Max' at Center.", repo.FormTacViewC2.ButtonZoom_Out_MaxInfo, new RecordItemIndex(12));
			repo.FormTacViewC2.ButtonZoom_Out_Max.Click();
			Delay.Milliseconds(0);
			
			GetTrackCount();
			Delay.Milliseconds(150);
			
			RandCoord();
			Delay.Milliseconds(150);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemCreate_Track' at Center.", repo.FormRealView.MenuItemCreate_TrackInfo, new RecordItemIndex(15));
			repo.FormRealView.MenuItemCreate_Track.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCreate_Track.MenuItemAir' at Center.", repo.FormCreate_Track.MenuItemAirInfo, new RecordItemIndex(16));
			repo.FormCreate_Track.MenuItemAir.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ListItemLatitude' at CenterLeft.", repo.FormMainCreate.ListItemLatitudeInfo, new RecordItemIndex(17));
			repo.FormMainCreate.ListItemLatitude.Click(Location.CenterLeft);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(18));
			Keyboard.Press(Keys.Tab, Keyboard.DefaultScanCode, 100, 1, true);
			Delay.Milliseconds(50);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Home}{LShiftKey down}{End}{LShiftKey up}{Back}{Subtract}{NumPad6}{Decimal}{NumPad0}{NumPad4}{NumPad4}{Return}{Subtract}{NumPad6}{NumPad1}{Decimal}{NumPad4}{NumPad8}{Return}'.", new RecordItemIndex(19));
			Keyboard.Press("{Home}{LShiftKey down}{End}{LShiftKey up}{Back}{Subtract}{NumPad6}{Decimal}{NumPad0}{NumPad4}{NumPad4}{Return}{Subtract}{NumPad6}{NumPad1}{Decimal}{NumPad4}{NumPad8}{Return}", 100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__Air_TN___CREATING.ButtonSave' at Center.", repo.FormMain__Air_TN___CREATING.ButtonSaveInfo, new RecordItemIndex(20));
			repo.FormMain__Air_TN___CREATING.ButtonSave.Click();
			Delay.Milliseconds(0);
			
			GetTrackNum();
			Delay.Milliseconds(150);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2____map__Defaul.TextRealView' at Center.", repo.FormTacViewC2____map__Defaul.TextRealViewInfo, new RecordItemIndex(22));
			repo.FormTacViewC2____map__Defaul.TextRealView.Click();
			Delay.Milliseconds(0);
			
			KeyCurrentTrack();
			Delay.Milliseconds(150);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(24));
			Keyboard.Press(Keys.Return, 28, 100, 1, false);
			Delay.Milliseconds(50);
			
			Delay.Duration(1000, false);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemCenter_On_Track' at Center.", repo.FormRealView.MenuItemCenter_On_TrackInfo, new RecordItemIndex(26));
			repo.FormRealView.MenuItemCenter_On_Track.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2____map__Defaul.ButtonSet_Range_to_200_km' at Center.", repo.FormTacViewC2____map__Defaul.ButtonSet_Range_to_200_kmInfo, new RecordItemIndex(27));
			repo.FormTacViewC2____map__Defaul.ButtonSet_Range_to_200_km.Click();
			Delay.Milliseconds(0);
			
			CreateTrackRepoItems();
			Delay.Milliseconds(150);
			
			RightClickTrack();
			Delay.Milliseconds(150);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemEdit_Track' at Center.", repo.FormRealView.MenuItemEdit_TrackInfo, new RecordItemIndex(30));
			repo.FormRealView.MenuItemEdit_Track.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ListItemLatitude' at CenterLeft.", repo.FormMainCreate.ListItemLatitudeInfo, new RecordItemIndex(31));
			repo.FormMainCreate.ListItemLatitude.Click(Location.CenterLeft);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(32));
			Keyboard.Press(Keys.Tab, Keyboard.DefaultScanCode, 100, 1, true);
			Delay.Milliseconds(50);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{End}{LShiftKey down}{Home}{LShiftKey up}{Subtract}{NumPad5}{Decimal}{NumPad8}{Return}{Subtract}{NumPad6}{NumPad2}{Decimal}{NumPad1}{Return}'.", new RecordItemIndex(33));
			Keyboard.Press("{End}{LShiftKey down}{Home}{LShiftKey up}{Subtract}{NumPad5}{Decimal}{NumPad8}{Return}{Subtract}{NumPad6}{NumPad2}{Decimal}{NumPad1}{Return}", 100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonSave' at Center.", repo.FormMainCreate.ButtonSaveInfo, new RecordItemIndex(34));
			repo.FormMainCreate.ButtonSave.Click();
			Delay.Milliseconds(0);
			
			Delay.Duration(1000, false);
			
			ValidateEnterAlert();
			Delay.Milliseconds(150);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonEdit_Track' at Center.", repo.FormMainCreate.ButtonEdit_TrackInfo, new RecordItemIndex(37));
			repo.FormMainCreate.ButtonEdit_Track.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ListItemLatitude' at CenterLeft.", repo.FormMainCreate.ListItemLatitudeInfo, new RecordItemIndex(38));
			repo.FormMainCreate.ListItemLatitude.Click(Location.CenterLeft);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(39));
			Keyboard.Press(Keys.Tab, Keyboard.DefaultScanCode, 100, 1, true);
			Delay.Milliseconds(50);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{End}{LShiftKey down}{Home}{LShiftKey up}{Back}{Subtract}{NumPad6}{Decimal}{NumPad0}{NumPad4}{NumPad4}{Return}{Subtract}{NumPad6 down}{NumPad1 down}{NumPad6 up}{NumPad1 up}{Decimal}{NumPad4 down}{NumPad8 down}{NumPad4 up}{NumPad8 up}{Return}'.", new RecordItemIndex(40));
			Keyboard.Press("{End}{LShiftKey down}{Home}{LShiftKey up}{Back}{Subtract}{NumPad6}{Decimal}{NumPad0}{NumPad4}{NumPad4}{Return}{Subtract}{NumPad6 down}{NumPad1 down}{NumPad6 up}{NumPad1 up}{Decimal}{NumPad4 down}{NumPad8 down}{NumPad4 up}{NumPad8 up}{Return}", 100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonSave' at Center.", repo.FormMainCreate.ButtonSaveInfo, new RecordItemIndex(41));
			repo.FormMainCreate.ButtonSave.Click();
			Delay.Milliseconds(0);
			
			Delay.Duration(1000, false);
			
			ValidateExitAlert();
			Delay.Milliseconds(150);
			
			Delay.Duration(1000, false);
			
			ClearAllEventsInEventHistory();
			Delay.Milliseconds(150);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonEdit_Track' at Center.", repo.FormMainCreate.ButtonEdit_TrackInfo, new RecordItemIndex(46));
			repo.FormMainCreate.ButtonEdit_Track.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ListItemLongitude' at CenterLeft.", repo.FormMainCreate.ListItemLongitudeInfo, new RecordItemIndex(47));
			repo.FormMainCreate.ListItemLongitude.Click(Location.CenterLeft);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(48));
			Keyboard.Press(Keys.Tab, Keyboard.DefaultScanCode, 100, 1, true);
			Delay.Milliseconds(50);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{End}{LShiftKey down}{Home}{LShiftKey up}{Back}{Subtract}{NumPad6 down}{NumPad1 down}{NumPad6 up}{NumPad1 up}{Decimal}{NumPad7}{NumPad6 down}{NumPad3 down}{NumPad6 up}{NumPad3 up}{Back}{Back}{NumPad3}{Return}'.", new RecordItemIndex(49));
			Keyboard.Press("{End}{LShiftKey down}{Home}{LShiftKey up}{Back}{Subtract}{NumPad6 down}{NumPad1 down}{NumPad6 up}{NumPad1 up}{Decimal}{NumPad7}{NumPad6 down}{NumPad3 down}{NumPad6 up}{NumPad3 up}{Back}{Back}{NumPad3}{Return}", 100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonSave' at Center.", repo.FormMainCreate.ButtonSaveInfo, new RecordItemIndex(50));
			repo.FormMainCreate.ButtonSave.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonEdit_Track' at Center.", repo.FormMainCreate.ButtonEdit_TrackInfo, new RecordItemIndex(51));
			repo.FormMainCreate.ButtonEdit_Track.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMainCreate.ListItemLongitude' at Center.", repo.FormMainCreate.ListItemLongitudeInfo, new RecordItemIndex(52));
			repo.FormMainCreate.ListItemLongitude.DoubleClick();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{End}{LShiftKey down}{Home}{LShiftKey up}{Back}{Subtract}{NumPad6 down}{NumPad2 down}{NumPad6 up}{NumPad2 up}{Decimal}{NumPad1}{Return}'.", new RecordItemIndex(53));
			Keyboard.Press("{End}{LShiftKey down}{Home}{LShiftKey up}{Back}{Subtract}{NumPad6 down}{NumPad2 down}{NumPad6 up}{NumPad2 up}{Decimal}{NumPad1}{Return}", 100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonSave' at Center.", repo.FormMainCreate.ButtonSaveInfo, new RecordItemIndex(54));
			repo.FormMainCreate.ButtonSave.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonEdit_Track' at Center.", repo.FormMainCreate.ButtonEdit_TrackInfo, new RecordItemIndex(55));
			repo.FormMainCreate.ButtonEdit_Track.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ListItemLongitude' at CenterLeft.", repo.FormMainCreate.ListItemLongitudeInfo, new RecordItemIndex(56));
			repo.FormMainCreate.ListItemLongitude.Click(Location.CenterLeft);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(57));
			Keyboard.Press(Keys.Tab, Keyboard.DefaultScanCode, 100, 1, true);
			Delay.Milliseconds(50);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{End}{LShiftKey down}{Home}{LShiftKey up}{Back}{Subtract}{NumPad6 down}{NumPad2 down}{NumPad6 up}{NumPad2 up}{Decimal}{NumPad5}{Return}'.", new RecordItemIndex(58));
			Keyboard.Press("{End}{LShiftKey down}{Home}{LShiftKey up}{Back}{Subtract}{NumPad6 down}{NumPad2 down}{NumPad6 up}{NumPad2 up}{Decimal}{NumPad5}{Return}", 100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonSave' at Center.", repo.FormMainCreate.ButtonSaveInfo, new RecordItemIndex(59));
			repo.FormMainCreate.ButtonSave.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonEdit_Track' at Center.", repo.FormMainCreate.ButtonEdit_TrackInfo, new RecordItemIndex(60));
			repo.FormMainCreate.ButtonEdit_Track.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ListItemLongitude' at Center.", repo.FormMainCreate.ListItemLongitudeInfo, new RecordItemIndex(61));
			repo.FormMainCreate.ListItemLongitude.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(62));
			Keyboard.Press(Keys.Tab, Keyboard.DefaultScanCode, 100, 1, true);
			Delay.Milliseconds(50);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{End up}{LShiftKey down}{Home}{LShiftKey up}{End}{LShiftKey down}{Home}{LShiftKey up}{Back}{Subtract}{NumPad6}{NumPad3}{NumPad0}{Back}{Decimal}{NumPad0}{Return}'.", new RecordItemIndex(63));
			Keyboard.Press("{End up}{LShiftKey down}{Home}{LShiftKey up}{End}{LShiftKey down}{Home}{LShiftKey up}{Back}{Subtract}{NumPad6}{NumPad3}{NumPad0}{Back}{Decimal}{NumPad0}{Return}", 100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonSave' at Center.", repo.FormMainCreate.ButtonSaveInfo, new RecordItemIndex(64));
			repo.FormMainCreate.ButtonSave.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonCLOSE' at Center.", repo.FormMainCreate.ButtonCLOSEInfo, new RecordItemIndex(65));
			repo.FormMainCreate.ButtonCLOSE.Click();
			Delay.Milliseconds(0);
			
			Delay.Duration(1000, false);
			
			ValidateNoAlerts();
			Delay.Milliseconds(150);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2____map__Defaul.TextRealView' at Center.", repo.FormTacViewC2____map__Defaul.TextRealViewInfo, new RecordItemIndex(68));
			repo.FormTacViewC2____map__Defaul.TextRealView.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(69));
			Keyboard.Press(Keys.Return, 28, 100, 1, false);
			Delay.Milliseconds(50);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemDrop_Track' at Center.", repo.FormRealView.MenuItemDrop_TrackInfo, new RecordItemIndex(70));
			repo.FormRealView.MenuItemDrop_Track.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RealViewDialog.ButtonYes' at Center.", repo.RealViewDialog.ButtonYesInfo, new RecordItemIndex(71));
			repo.RealViewDialog.ButtonYes.Click();
			Delay.Milliseconds(0);
			
		}

#region Image Feature Data
#endregion
	}
}
