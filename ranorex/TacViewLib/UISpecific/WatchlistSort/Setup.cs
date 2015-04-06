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

namespace TacViewLib.UISpecific.WatchlistSort
{
	/// <summary>
	/// The Setup recording.
	/// </summary>
	[TestModule("f9565b66-352e-4ead-aefa-90a103e94d14", ModuleType.Recording, 1)]
	public partial class Setup : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.TacViewLibRepository repository.
		/// </summary>
		public static TacViewLib.TacViewLibRepository repo = TacViewLib.TacViewLibRepository.Instance;

		static Setup instance = new Setup();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Setup()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static Setup Instance
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

			InterfaceOFF();
			Delay.Milliseconds(100);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at Center.", new RecordItemIndex(1));
			Mouse.MoveTo(0, 0, 100);
			Mouse.Click(MouseButtons.Left);
			Delay.Milliseconds(0);
			
			JUSelect();
			Delay.Milliseconds(100);
			
			// Setup Test Complete
			Report.Log(ReportLevel.Debug, "User", "Setup Test Complete");
			
		}

#region Image Feature Data
#endregion
	}
}