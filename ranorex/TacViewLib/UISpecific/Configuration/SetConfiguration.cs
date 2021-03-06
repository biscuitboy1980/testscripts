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

namespace TacViewLib.UISpecific.Configuration
{
	/// <summary>
	/// The SetConfiguration recording.
	/// </summary>
	[TestModule("45c1486a-33f3-4b92-8df8-760f7cbd6d7b", ModuleType.Recording, 1)]
	public partial class SetConfiguration : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.TacViewLibRepositoryConfiguration repository.
		/// </summary>
		public static TacViewLib.TacViewLibRepositoryConfiguration repo = TacViewLib.TacViewLibRepositoryConfiguration.Instance;

		static SetConfiguration instance = new SetConfiguration();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public SetConfiguration()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static SetConfiguration Instance
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

			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.File' at Center.", repo.FormTacViewC2.FileInfo, new RecordItemIndex(0));
			repo.FormTacViewC2.File.Click(100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'File_Menu.Preferences' at Center.", repo.File_Menu.PreferencesInfo, new RecordItemIndex(1));
			repo.File_Menu.Preferences.Click(100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences_Control.Configurations' at Center.", repo.Preferences_Control.ConfigurationsInfo, new RecordItemIndex(2));
			repo.Preferences_Control.Configurations.Click(100);
			Delay.Milliseconds(0);
			
			Mouse_Click_Configuration();
			Delay.Milliseconds(100);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences_Control.Close' at Center.", repo.Preferences_Control.CloseInfo, new RecordItemIndex(4));
			repo.Preferences_Control.Close.Click(100);
			Delay.Milliseconds(0);
			
			DismissPopUp();
			Delay.Milliseconds(100);
			
		}

#region Image Feature Data
#endregion
	}
}
