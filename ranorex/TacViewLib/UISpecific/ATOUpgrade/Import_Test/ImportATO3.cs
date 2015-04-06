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

namespace TacViewLib.UISpecific.ATOUpgrade.Import_Test
{
	/// <summary>
	/// The ImportATO3 recording.
	/// </summary>
	[TestModule("4bdf152b-372f-4d18-82a9-52ba592aa44e", ModuleType.Recording, 1)]
	public partial class ImportATO3 : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.ATOUpgradeRepository repository.
		/// </summary>
		public static TacViewLib.ATOUpgradeRepository repo = TacViewLib.ATOUpgradeRepository.Instance;

		static ImportATO3 instance = new ImportATO3();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public ImportATO3()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static ImportATO3 Instance
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

			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.MenuItemATO' at Center.", repo.FormTacViewC2.MenuItemATOInfo, new RecordItemIndex(0));
			repo.FormTacViewC2.MenuItemATO.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormATO.MenuItemDelete_all_records' at Center.", repo.FormATO.MenuItemDelete_all_recordsInfo, new RecordItemIndex(1));
			repo.FormATO.MenuItemDelete_all_records.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.ButtonYes' at Center.", repo.FormRealView.ButtonYesInfo, new RecordItemIndex(2));
			repo.FormRealView.ButtonYes.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FormTacViewC2.CellInterface' at Center.", repo.FormTacViewC2.CellInterfaceInfo, new RecordItemIndex(3));
			repo.FormTacViewC2.CellInterface.Click(MouseButtons.Right);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemImport_ATO' at CenterLeft.", repo.FormRealView.MenuItemImport_ATOInfo, new RecordItemIndex(4));
			repo.FormRealView.MenuItemImport_ATO.Click(Location.CenterLeft);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormImport_ATO.Text1148' at Center.", repo.FormImport_ATO.Text1148Info, new RecordItemIndex(5));
			repo.FormImport_ATO.Text1148.Click();
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\ranorex\\TacViewC2\\bin\\Release\\DataFiles\\ATOSmall1.txt'.", new RecordItemIndex(6));
			Keyboard.Press("C:\\ranorex\\TacViewC2\\bin\\Release\\DataFiles\\ATOSmall1.txt", 100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormImport_ATO.ButtonOpen' at Center.", repo.FormImport_ATO.ButtonOpenInfo, new RecordItemIndex(7));
			repo.FormImport_ATO.ButtonOpen.Click();
			Delay.Milliseconds(0);
			
		}

#region Image Feature Data
#endregion
	}
}
