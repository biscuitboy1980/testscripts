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

namespace TacViewLib.UISpecific.ACO
{
	/// <summary>
	/// The ValidateACOImport recording.
	/// </summary>
	[TestModule("e044dfaf-a02b-4e71-958d-ff7bac0df298", ModuleType.Recording, 1)]
	public partial class ValidateACOImport : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.TacViewLibRepositoryUISpecific repository.
		/// </summary>
		public static TacViewLib.TacViewLibRepositoryUISpecific repo = TacViewLib.TacViewLibRepositoryUISpecific.Instance;

		static ValidateACOImport instance = new ValidateACOImport();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public ValidateACOImport()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static ValidateACOImport Instance
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

			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TacView_TitleBar.View' at Center.", repo.TacView_TitleBar.ViewInfo, new RecordItemIndex(0));
			repo.TacView_TitleBar.View.Click(300);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'View_Menu.OverlayWatchListTemplates' at Center.", repo.View_Menu.OverlayWatchListTemplatesInfo, new RecordItemIndex(1));
			repo.View_Menu.OverlayWatchListTemplates.Click(300);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Overlays.Overlay_Watch_List_Templates.ACM_Overlays_Menu_Option' at Center.", repo.Overlays.Overlay_Watch_List_Templates.ACM_Overlays_Menu_OptionInfo, new RecordItemIndex(2));
			repo.Overlays.Overlay_Watch_List_Templates.ACM_Overlays_Menu_Option.Click(300);
			Delay.Milliseconds(0);
			
			Validate_ACM_Overlays_607_overlays1();
			Delay.Milliseconds(0);
			
			Validate_ACM_Overlays_607_overlays2();
			Delay.Milliseconds(0);
			
		}

#region Image Feature Data
#endregion
	}
}
