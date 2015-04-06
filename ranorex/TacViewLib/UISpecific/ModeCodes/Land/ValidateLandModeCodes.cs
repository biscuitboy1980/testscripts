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

namespace TacViewLib.UISpecific.ModeCodes.Land
{
	/// <summary>
	/// The ValidateLandModeCodes recording.
	/// </summary>
	[TestModule("07e51a85-e222-4fd8-8318-b51d826ef827", ModuleType.Recording, 1)]
	public partial class ValidateLandModeCodes : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.Link_16_RegressionRepository repository.
		/// </summary>
		public static TacViewLib.Link_16_RegressionRepository repo = TacViewLib.Link_16_RegressionRepository.Instance;

		static ValidateLandModeCodes instance = new ValidateLandModeCodes();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public ValidateLandModeCodes()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static ValidateLandModeCodes Instance
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

			Delay.Duration(1000, false);
			
			CreateTrackRepoItems();
			Delay.Milliseconds(100);
			
			RightClickTrack();
			Delay.Milliseconds(100);
			
			ViewTrackProperties();
			Delay.Milliseconds(100);
			
			Delay.Duration(1000, false);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick at CenterLeft.", new RecordItemIndex(5));
			Mouse.MoveTo(0, 0, 100);
			Mouse.DoubleClick(MouseButtons.Left);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick at CenterLeft.", new RecordItemIndex(6));
			Mouse.MoveTo(0, 0, 100);
			Mouse.DoubleClick(MouseButtons.Left);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick at CenterLeft.", new RecordItemIndex(7));
			Mouse.MoveTo(0, 0, 100);
			Mouse.DoubleClick(MouseButtons.Left);
			Delay.Milliseconds(0);
			
			ValidateMode1();
			Delay.Milliseconds(100);
			
			ValidateMode2();
			Delay.Milliseconds(100);
			
			ValidateMode3();
			Delay.Milliseconds(100);
			
			ValidateMode4();
			Delay.Milliseconds(100);
			
			ValidateMode5();
			Delay.Milliseconds(100);
			
			ValidateM5Nat();
			Delay.Milliseconds(100);
			
			ValidateM5ID();
			Delay.Milliseconds(100);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at Center.", new RecordItemIndex(15));
			Mouse.MoveTo(0, 0, 100);
			Mouse.Click(MouseButtons.Left);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FormTacViewC2.PictureTrackRelSpace' at Center.", repo.FormTacViewC2.PictureTrackRelSpaceInfo, new RecordItemIndex(16));
			repo.FormTacViewC2.PictureTrackRelSpace.Click(MouseButtons.Right, 100);
			Delay.Milliseconds(0);
			
			DropTrack();
			Delay.Milliseconds(100);
			
			Delay.Duration(2000, false);
			
			Validate_DropTrack();
			Delay.Milliseconds(100);
			
			Zoom500();
			Delay.Milliseconds(100);
			
			ResetPaths();
			Delay.Milliseconds(100);
			
		}

#region Image Feature Data
#endregion
	}
}
