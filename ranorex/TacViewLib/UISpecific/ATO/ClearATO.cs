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

namespace TacViewLib.UISpecific.ATO
{
	/// <summary>
	/// The ClearATO recording.
	/// </summary>
	[TestModule("b06fa70f-3c27-463c-b13a-fbcf0f058ea9", ModuleType.Recording, 1)]
	public partial class ClearATO : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.TacViewLibRepositoryUISpecific repository.
		/// </summary>
		public static TacViewLib.TacViewLibRepositoryUISpecific repo = TacViewLib.TacViewLibRepositoryUISpecific.Instance;

		static ClearATO instance = new ClearATO();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public ClearATO()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static ClearATO Instance
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

			Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'ATO.FormATO_List.FormATO_List' at Center.", repo.ATO.FormATO_List.FormATO_ListInfo, new RecordItemIndex(0));
			repo.ATO.FormATO_List.FormATO_List.Click(MouseButtons.Right, 100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ContextMenuRealView.MenuItemClear_ATO_List' at Center.", repo.ContextMenuRealView.MenuItemClear_ATO_ListInfo, new RecordItemIndex(1));
			repo.ContextMenuRealView.MenuItemClear_ATO_List.Click(100);
			Delay.Milliseconds(0);
			
			Delay.Duration(1500, false);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ATO.FormATO_List.ButtonCLOSE' at Center.", repo.ATO.FormATO_List.ButtonCLOSEInfo, new RecordItemIndex(3));
			repo.ATO.FormATO_List.ButtonCLOSE.Click(100);
			Delay.Milliseconds(0);
			
		}

#region Image Feature Data
#endregion
	}
}
