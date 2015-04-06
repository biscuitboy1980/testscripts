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

namespace TacViewLib.UISpecific.MapFeatures
{
	/// <summary>
	/// The ClearGeoImage recording.
	/// </summary>
	[TestModule("2924432f-7906-4ce6-97a5-23731fee5fcf", ModuleType.Recording, 1)]
	public partial class ClearGeoImage : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.TacViewLibRepository repository.
		/// </summary>
		public static TacViewLib.TacViewLibRepository repo = TacViewLib.TacViewLibRepository.Instance;

		static ClearGeoImage instance = new ClearGeoImage();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public ClearGeoImage()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static ClearGeoImage Instance
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

			Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click at Center.", new RecordItemIndex(0));
			Mouse.MoveTo(898, 551, 300);
			Mouse.Click(MouseButtons.Right);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at Center.", new RecordItemIndex(1));
			Mouse.MoveTo(935, 603, 100);
			Mouse.Click(MouseButtons.Left);
			Delay.Milliseconds(0);
			
			// TODO Validate "No CADRG/Geo Images"
			Report.Log(ReportLevel.Info, "User", "");
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at Center.", new RecordItemIndex(3));
			Mouse.MoveTo(1021, 505, 300);
			Mouse.Click(MouseButtons.Left);
			Delay.Milliseconds(0);
			
		}

#region Image Feature Data
#endregion
	}
}
