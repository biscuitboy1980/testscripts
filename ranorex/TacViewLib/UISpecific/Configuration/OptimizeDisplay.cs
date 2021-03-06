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
	/// The OptimizeDisplay recording.
	/// </summary>
	[TestModule("b1a64418-3a65-46a9-9698-84680c389022", ModuleType.Recording, 1)]
	public partial class OptimizeDisplay : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.TacViewLibRepository repository.
		/// </summary>
		public static TacViewLib.TacViewLibRepository repo = TacViewLib.TacViewLibRepository.Instance;

		static OptimizeDisplay instance = new OptimizeDisplay();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public OptimizeDisplay()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static OptimizeDisplay Instance
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

			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.ButtonSet_Range_to_200_km' at Center.", repo.FormTacViewC2.ButtonSet_Range_to_200_kmInfo, new RecordItemIndex(0));
			repo.FormTacViewC2.ButtonSet_Range_to_200_km.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.Button_Center_on_Own_Site' at Center.", repo.FormTacViewC2.Button_Center_on_Own_SiteInfo, new RecordItemIndex(1));
			repo.FormTacViewC2.Button_Center_on_Own_Site.Click();
			Delay.Milliseconds(0);
			
			Delay.Duration(1500, false);
			
		}

#region Image Feature Data
#endregion
	}
}
