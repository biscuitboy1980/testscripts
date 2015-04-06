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

namespace TacViewLib.UISpecific.ModeCodes.Air
{
	/// <summary>
	/// The CreateAirModeCodes recording.
	/// </summary>
	[TestModule("1eaa0ace-5e55-4eb0-b90c-10eb61d5df05", ModuleType.Recording, 1)]
	public partial class CreateAirModeCodes : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.Link_16_RegressionRepository repository.
		/// </summary>
		public static TacViewLib.Link_16_RegressionRepository repo = TacViewLib.Link_16_RegressionRepository.Instance;

		static CreateAirModeCodes instance = new CreateAirModeCodes();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public CreateAirModeCodes()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static CreateAirModeCodes Instance
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
			Mouse.DefaultMoveTime = 18;
			Keyboard.DefaultKeyPressTime = 25;
			Delay.SpeedFactor = 8.0;

			Init();

			GetTrackCount();
			Delay.Milliseconds(100);
			
			RandCoord();
			Delay.Milliseconds(100);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemCreate_Track' at Center.", repo.FormRealView.MenuItemCreate_TrackInfo, new RecordItemIndex(2));
			repo.FormRealView.MenuItemCreate_Track.Click(100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at Center.", new RecordItemIndex(3));
			Mouse.MoveTo(0, 0, 100);
			Mouse.Click(MouseButtons.Left);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTOAD.MenuItemAir' at Center.", repo.FormTOAD.MenuItemAirInfo, new RecordItemIndex(4));
			repo.FormTOAD.MenuItemAir.Click(100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMainCreate.ListItemBasic_Track_Info' at CenterLeft.", repo.FormMainCreate.ListItemBasic_Track_InfoInfo, new RecordItemIndex(5));
			repo.FormMainCreate.ListItemBasic_Track_Info.DoubleClick(Location.CenterLeft, 100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMainCreate.ListItemPosition_and_SpeedVelocity' at CenterLeft.", repo.FormMainCreate.ListItemPosition_and_SpeedVelocityInfo, new RecordItemIndex(6));
			repo.FormMainCreate.ListItemPosition_and_SpeedVelocity.DoubleClick(Location.CenterLeft, 100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMainCreate.ListItemInterface_Info' at CenterLeft.", repo.FormMainCreate.ListItemInterface_InfoInfo, new RecordItemIndex(7));
			repo.FormMainCreate.ListItemInterface_Info.DoubleClick(Location.CenterLeft, 100);
			Delay.Milliseconds(0);
			
			Mode1val();
			Delay.Milliseconds(100);
			
			InvalidMode2val();
			Delay.Milliseconds(100);
			
			Validate_InvalidMode2val();
			Delay.Milliseconds(100);
			
			Mode2val();
			Delay.Milliseconds(100);
			
			Validate_Mode2val();
			Delay.Milliseconds(100);
			
			InvalidMode3val();
			Delay.Milliseconds(100);
			
			Validate_InvalidMode3val();
			Delay.Milliseconds(100);
			
			Mode3val();
			Delay.Milliseconds(100);
			
			Validate_Mode3val();
			Delay.Milliseconds(100);
			
			Mode4val();
			Delay.Milliseconds(100);
			
			Mode5val();
			Delay.Milliseconds(100);
			
			Mode5Natval();
			Delay.Milliseconds(100);
			
			M5IDval();
			Delay.Milliseconds(100);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonSave' at Center.", repo.FormMainCreate.ButtonSaveInfo, new RecordItemIndex(21));
			repo.FormMainCreate.ButtonSave.Click(100);
			Delay.Milliseconds(0);
			
			GetTrackNum();
			Delay.Milliseconds(100);
			
		}

#region Image Feature Data
#endregion
	}
}
