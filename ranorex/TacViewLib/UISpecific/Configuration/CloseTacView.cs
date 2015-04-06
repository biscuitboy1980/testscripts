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
	/// The CloseTacView recording.
	/// </summary>
	[TestModule("962329cc-0ca7-46cd-8e1d-940e62818361", ModuleType.Recording, 1)]
	public partial class CloseTacView : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.TacViewLibRepository repository.
		/// </summary>
		public static TacViewLib.TacViewLibRepository repo = TacViewLib.TacViewLibRepository.Instance;

		static CloseTacView instance = new CloseTacView();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public CloseTacView()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static CloseTacView Instance
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
			repo.FormTacViewC2.File.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormFile.MenuItemExit' at Center.", repo.FormFile.MenuItemExitInfo, new RecordItemIndex(1));
			repo.FormFile.MenuItemExit.Click();
			Delay.Milliseconds(0);
			
			Delay.Duration(5000, false);
			
		}

#region Image Feature Data
#endregion
	}
}
