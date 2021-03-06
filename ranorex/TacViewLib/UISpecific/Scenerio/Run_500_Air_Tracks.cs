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

namespace TacViewLib.UISpecific.Scenerio
{
	/// <summary>
	/// The Run_500_Air_Tracks recording.
	/// </summary>
	[TestModule("9a9ba931-3c06-4757-af63-7ea42a27a4ba", ModuleType.Recording, 1)]
	public partial class Run_500_Air_Tracks : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.TacViewLibRepositoryUISpecific repository.
		/// </summary>
		public static TacViewLib.TacViewLibRepositoryUISpecific repo = TacViewLib.TacViewLibRepositoryUISpecific.Instance;

		static Run_500_Air_Tracks instance = new Run_500_Air_Tracks();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Run_500_Air_Tracks()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static Run_500_Air_Tracks Instance
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

			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.MenuItemScenario' at Center.", repo.FormTacViewC2.MenuItemScenarioInfo, new RecordItemIndex(0));
			repo.FormTacViewC2.MenuItemScenario.Click(125);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Scenario.FormScenario.MenuItemLoad_Scenario_File___' at Center.", repo.Scenario.FormScenario.MenuItemLoad_Scenario_File___Info, new RecordItemIndex(1));
			repo.Scenario.FormScenario.MenuItemLoad_Scenario_File___.Click(125);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Scenario.FormOpen_Scenario_File.ScenarioTextBox' at CenterLeft.", repo.Scenario.FormOpen_Scenario_File.ScenarioTextBoxInfo, new RecordItemIndex(2));
			repo.Scenario.FormOpen_Scenario_File.ScenarioTextBox.Click(Location.CenterLeft, 100);
			Delay.Milliseconds(0);
			
			Get_Track_Count();
			Delay.Milliseconds(100);
			
			EnterScenario();
			Delay.Milliseconds(120);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Scenario.FormOpen_Scenario_File.ButtonOpen' at Center.", repo.Scenario.FormOpen_Scenario_File.ButtonOpenInfo, new RecordItemIndex(5));
			repo.Scenario.FormOpen_Scenario_File.ButtonOpen.Click(300);
			Delay.Milliseconds(200);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.MenuItemScenario' at Center.", repo.FormTacViewC2.MenuItemScenarioInfo, new RecordItemIndex(6));
			repo.FormTacViewC2.MenuItemScenario.Click(125);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Scenario.FormScenario.MenuItemPlayback_Speed' at Center.", repo.Scenario.FormScenario.MenuItemPlayback_SpeedInfo, new RecordItemIndex(7));
			repo.Scenario.FormScenario.MenuItemPlayback_Speed.Click(125);
			Delay.Milliseconds(0);
			
			// test
			Report.Log(ReportLevel.Info, "Mouse", "test\r\nMouse Left Click item 'Scenario.FormPlayback_Speed.MenuItem1X' at Center.", repo.Scenario.FormPlayback_Speed.MenuItem1XInfo, new RecordItemIndex(8));
			repo.Scenario.FormPlayback_Speed.MenuItem1X.Click(125);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.MenuItemScenario' at Center.", repo.FormTacViewC2.MenuItemScenarioInfo, new RecordItemIndex(9));
			repo.FormTacViewC2.MenuItemScenario.Click(125);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'Scenario.FormScenario.MenuItemPlayback_Speed' at Center.", repo.Scenario.FormScenario.MenuItemPlayback_SpeedInfo, new RecordItemIndex(10));
			repo.Scenario.FormScenario.MenuItemPlayback_Speed.MoveTo(125);
			Mouse.ButtonDown(MouseButtons.Left);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Scenario.FormPlayback_Speed.MenuItem20X' at Center.", repo.Scenario.FormPlayback_Speed.MenuItem20XInfo, new RecordItemIndex(11));
			repo.Scenario.FormPlayback_Speed.MenuItem20X.Click(125);
			Delay.Milliseconds(0);
			
			Delay.Duration(90000, false);
			
			Validate_Track_Count();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.MenuItemScenario' at Center.", repo.FormTacViewC2.MenuItemScenarioInfo, new RecordItemIndex(14));
			repo.FormTacViewC2.MenuItemScenario.Click(125);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Scenario.FormScenario.MenuItemStop_Scenario' at Center.", repo.Scenario.FormScenario.MenuItemStop_ScenarioInfo, new RecordItemIndex(15));
			repo.Scenario.FormScenario.MenuItemStop_Scenario.Click(125);
			Delay.Milliseconds(0);
			
		}

#region Image Feature Data
#endregion
	}
}
