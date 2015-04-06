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

namespace TacViewLib.UISpecific.ATOUpgrade.Mode2andMode3Codes_Correlation_Test
{
	/// <summary>
	/// The CreateMode2AirTrack recording.
	/// </summary>
	[TestModule("4dd879f4-6ee8-43f2-a40e-c3d89550ad94", ModuleType.Recording, 1)]
	public partial class CreateMode2AirTrack : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.TacViewLibRepository repository.
		/// </summary>
		public static TacViewLib.TacViewLibRepository repo = TacViewLib.TacViewLibRepository.Instance;

		static CreateMode2AirTrack instance = new CreateMode2AirTrack();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public CreateMode2AirTrack()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static CreateMode2AirTrack Instance
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

			GetTrackCount();
			Delay.Milliseconds(150);
			
			RandomTrack();
			Delay.Milliseconds(150);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at Center.", new RecordItemIndex(2));
			Mouse.MoveTo(0, 0);
			Mouse.Click(MouseButtons.Left);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at Center.", new RecordItemIndex(3));
			Mouse.MoveTo(0, 0);
			Mouse.Click(MouseButtons.Left);
			Delay.Milliseconds(0);
			
			IDval();
			Delay.Milliseconds(150);
			
			Platval();
			Delay.Milliseconds(150);
			
			Actval();
			Delay.Milliseconds(150);
			
			Stypeval();
			Delay.Milliseconds(150);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick at CenterLeft.", new RecordItemIndex(8));
			Mouse.MoveTo(697, 293);
			Mouse.DoubleClick(MouseButtons.Left);
			Delay.Milliseconds(0);
			
			Altitudeval();
			Delay.Milliseconds(150);
			
			Velocityval();
			Delay.Milliseconds(150);
			
			Courseval();
			Delay.Milliseconds(150);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick at CenterLeft.", new RecordItemIndex(12));
			Mouse.MoveTo(680, 316);
			Mouse.DoubleClick(MouseButtons.Left);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick at CenterLeft.", new RecordItemIndex(13));
			Mouse.MoveTo(674, 331);
			Mouse.DoubleClick(MouseButtons.Left);
			Delay.Milliseconds(0);
			
			Mode2val();
			Delay.Milliseconds(150);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at Center.", new RecordItemIndex(15));
			Mouse.MoveTo(0, 0);
			Mouse.Click(MouseButtons.Left);
			Delay.Milliseconds(0);
			
			GetTrackNum();
			Delay.Milliseconds(150);
			
		}

#region Image Feature Data
#endregion
	}
}
