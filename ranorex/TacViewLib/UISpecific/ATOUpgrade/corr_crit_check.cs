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

namespace TacViewLib.UISpecific.ATOUpgrade
{
	/// <summary>
	/// The corr_crit_check recording.
	/// </summary>
	[TestModule("12d7bb03-eaab-4963-8d72-35f639eb2c43", ModuleType.Recording, 1)]
	public partial class corr_crit : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.TacViewLibRepository repository.
		/// </summary>
		public static TacViewLib.TacViewLibRepository repo = TacViewLib.TacViewLibRepository.Instance;

		static corr_crit instance = new corr_crit();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public corr_crit()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static corr_crit Instance
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
			repo.FormTacViewC2.MenuItemATO.Click(100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormATO.MenuItemManage_Correlation_Crite' at Center.", repo.FormATO.MenuItemManage_Correlation_CriteInfo, new RecordItemIndex(1));
			repo.FormATO.MenuItemManage_Correlation_Crite.Click(100);
			Delay.Milliseconds(0);
			
			// Is check box clear?
			Report.Log(ReportLevel.Info, "Validation", "Is check box clear?\r\nValidating AttributeEqual (Text='Mode 3 (Track Mode 3 Code matches ATO)') on item 'FormCorrelation_Criteria.ListItemMode_3__Track_Mode_3_Cod'.", repo.FormCorrelation_Criteria.ListItemMode_3__Track_Mode_3_CodInfo, new RecordItemIndex(2));
			Validate.Attribute(repo.FormCorrelation_Criteria.ListItemMode_3__Track_Mode_3_CodInfo, "Text", "Mode 3 (Track Mode 3 Code matches ATO)");
			Delay.Milliseconds(100);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCorrelation_Criteria.ListItemMode_3__Track_Mode_3_Cod' at 6;10.", repo.FormCorrelation_Criteria.ListItemMode_3__Track_Mode_3_CodInfo, new RecordItemIndex(3));
			repo.FormCorrelation_Criteria.ListItemMode_3__Track_Mode_3_Cod.Click("6;10", 100);
			Delay.Milliseconds(0);
			
			// Is check box set?
			Report.Log(ReportLevel.Info, "Validation", "Is check box set?\r\nValidating AttributeEqual (Text='Mode 3 (Track Mode 3 Code matches ATO)') on item 'FormCorrelation_Criteria.ListItemMode_3__Track_Mode_3_Cod'.", repo.FormCorrelation_Criteria.ListItemMode_3__Track_Mode_3_CodInfo, new RecordItemIndex(4));
			Validate.Attribute(repo.FormCorrelation_Criteria.ListItemMode_3__Track_Mode_3_CodInfo, "Text", "Mode 3 (Track Mode 3 Code matches ATO)");
			Delay.Milliseconds(100);
			
			// Reset list
			Report.Log(ReportLevel.Info, "Mouse", "Reset list\r\nMouse Left Click item 'FormCorrelation_Criteria.ButtonReset' at Center.", repo.FormCorrelation_Criteria.ButtonResetInfo, new RecordItemIndex(5));
			repo.FormCorrelation_Criteria.ButtonReset.Click(100);
			Delay.Milliseconds(0);
			
			// Reopen Corr Crit Window
			Report.Log(ReportLevel.Info, "Mouse", "Reopen Corr Crit Window\r\nMouse Left Click item 'FormTacViewC2.MenuItemATO' at .25;.25.", repo.FormTacViewC2.MenuItemATOInfo, new RecordItemIndex(6));
			repo.FormTacViewC2.MenuItemATO.Click(".25;.25", 100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormATO.MenuItemManage_Correlation_Crite' at .25;.25.", repo.FormATO.MenuItemManage_Correlation_CriteInfo, new RecordItemIndex(7));
			repo.FormATO.MenuItemManage_Correlation_Crite.Click(".25;.25", 100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'FormCorrelation_Criteria.ListItemMode_3__Track_Mode_3_Cod'.", repo.FormCorrelation_Criteria.ListItemMode_3__Track_Mode_3_CodInfo, new RecordItemIndex(8));
			Validate.Attribute(repo.FormCorrelation_Criteria.ListItemMode_3__Track_Mode_3_CodInfo, "Checked", "False");
			Delay.Milliseconds(100);
			
			Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'FormCorrelation_Criteria.ListItemJU_Address__Track_number'.", repo.FormCorrelation_Criteria.ListItemJU_Address__Track_numberInfo, new RecordItemIndex(9));
			Validate.Attribute(repo.FormCorrelation_Criteria.ListItemJU_Address__Track_numberInfo, "Checked", "False");
			Delay.Milliseconds(100);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCorrelation_Criteria.ListItemJU_Address__Track_number' at 6;10.", repo.FormCorrelation_Criteria.ListItemJU_Address__Track_numberInfo, new RecordItemIndex(10));
			repo.FormCorrelation_Criteria.ListItemJU_Address__Track_number.Click("6;10", 100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FormCorrelation_Criteria.ListItemJU_Address__Track_number'.", repo.FormCorrelation_Criteria.ListItemJU_Address__Track_numberInfo, new RecordItemIndex(11));
			Validate.Attribute(repo.FormCorrelation_Criteria.ListItemJU_Address__Track_numberInfo, "Checked", "True");
			Delay.Milliseconds(100);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCorrelation_Criteria.ButtonOK' at Center.", repo.FormCorrelation_Criteria.ButtonOKInfo, new RecordItemIndex(12));
			repo.FormCorrelation_Criteria.ButtonOK.Click(100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.MenuItemATO' at Center.", repo.FormTacViewC2.MenuItemATOInfo, new RecordItemIndex(13));
			repo.FormTacViewC2.MenuItemATO.Click(100);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'FormATO.MenuItemManage_Correlation_Crite' at Center.", repo.FormATO.MenuItemManage_Correlation_CriteInfo, new RecordItemIndex(14));
			repo.FormATO.MenuItemManage_Correlation_Crite.MoveTo(100);
			Mouse.ButtonUp(MouseButtons.Left);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FormCorrelation_Criteria.ListItemJU_Address__Track_number'.", repo.FormCorrelation_Criteria.ListItemJU_Address__Track_numberInfo, new RecordItemIndex(15));
			Validate.Attribute(repo.FormCorrelation_Criteria.ListItemJU_Address__Track_numberInfo, "Checked", "True");
			Delay.Milliseconds(100);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCorrelation_Criteria.ListItemJU_Address__Track_number' at 6;10.", repo.FormCorrelation_Criteria.ListItemJU_Address__Track_numberInfo, new RecordItemIndex(16));
			repo.FormCorrelation_Criteria.ListItemJU_Address__Track_number.Click("6;10", 100);
			Delay.Milliseconds(0);
			
			// Reset to original
			Report.Log(ReportLevel.Info, "Mouse", "Reset to original\r\nMouse Left Click item 'FormCorrelation_Criteria.ButtonOK' at Center.", repo.FormCorrelation_Criteria.ButtonOKInfo, new RecordItemIndex(17));
			repo.FormCorrelation_Criteria.ButtonOK.Click(100);
			Delay.Milliseconds(0);
			
		}

#region Image Feature Data
#endregion
	}
}